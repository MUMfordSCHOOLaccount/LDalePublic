import cv2
import time
import base64
import os
from openai import OpenAI

# --- 1. SETUP ---
client = OpenAI(base_url="http://localhost:1234/v1", api_key="lm-studio")

LOG_FILE = "D:/Dev/Sentry/sentry_log.txt"
TEMP_IMG = "D:/Dev/Sentry/Captures/temp_sentry.jpg"

def encode_image(path):
    with open(path, "rb") as f:
        return base64.b64encode(f.read()).decode('utf-8')

# MOVED: Now properly aligned to the left
def get_camera(index=0):
    """Tries to connect to the camera until it succeeds."""
    while True:
        cap = cv2.VideoCapture(index)
        if cap.isOpened():
            print(f"[{time.ctime()}] Camera {index} Connected Successfully.")
            return cap
        else:
            print(f"[{time.ctime()}] WARNING: Camera {index} not found. Retrying in 5 seconds...")
            cap.release()
            time.sleep(5)

# --- 2. INITIALIZATION ---
# CHANGED: Now uses the redundancy tool from the start
cap = get_camera(0) 
first_frame = None
last_heartbeat = 0
heartbeat_interval = 1800 

print("--- SENTRY SYSTEM ACTIVE ---")
print(f"Logging to: {LOG_FILE}")
print("Press 'Ctrl+C' in this window to stop the script.")

# --- 3. THE ACTION LOOP ---
try:
    while True:
        ret, frame = cap.read()
        
        # REDUNDANCY: If the camera drops mid-run
        if not ret:
            print("!!! CAMERA CONNECTION LOST !!!")
            cap.release()
            cap = get_camera(0) # Re-run the recovery loop
            first_frame = None  
            continue

        current_time = time.time()
        trigger_reason = None

        # A. PREPARE IMAGE FOR MOTION MATH
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        gray = cv2.GaussianBlur(gray, (21, 21), 0)

        if first_frame is None:
            first_frame = gray
            continue

        # B. CHECK FOR MOTION
        frame_delta = cv2.absdiff(first_frame, gray)
        thresh = cv2.threshold(frame_delta, 25, 255, cv2.THRESH_BINARY)[1]
        
        if thresh.sum() > 1000000: 
            trigger_reason = "MOTION DETECTED"
        
        # C. CHECK FOR HEARTBEAT
        elif current_time - last_heartbeat > heartbeat_interval:
            trigger_reason = "ROUTINE CHECK"
            last_heartbeat = current_time

        # D. IF TRIGGERED, TALK TO AI
        if trigger_reason:
            print(f"[{time.ctime()}] {trigger_reason}: Processing...")
            cv2.imwrite(TEMP_IMG, frame)
            base64_img = encode_image(TEMP_IMG)

            history = "No previous history."
            if os.path.exists(LOG_FILE):
                with open(LOG_FILE, "r") as f:
                    history = "".join(f.readlines()[-5:])

            prompt = (
                f"You are a professional security sentry. "
                f"Recent history:\n{history}\n"
                f"Current Time: {time.ctime()}\n"
                f"Task: Look at the image. If it matches the history, say 'Status unchanged'. "
                f"If something is new, describe it concisely."
            )

            try:
                response = client.chat.completions.create(
                    model="local-model",
                    messages=[{"role": "user", "content": [
                        {"type": "text", "text": prompt},
                        {"type": "image_url", "image_url": {"url": f"data:image/jpeg;base64,{base64_img}"}}
                    ]}]
                )
                ai_msg = response.choices[0].message.content
                
                with open(LOG_FILE, "a") as f:
                    f.write(f"[{time.ctime()}] {trigger_reason}: {ai_msg}\n")
                
                print(f"AI Response: {ai_msg}")

            except Exception as e:
                print(f"AI Communication Error: {e}")

            time.sleep(10)
            first_frame = None 

except KeyboardInterrupt:
    print("\nSentry shutting down safely...")
finally:
    if 'cap' in locals():
        cap.release()
    cv2.destroyAllWindows()