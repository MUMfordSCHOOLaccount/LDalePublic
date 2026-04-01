import cv2
import time
import pyttsx3
from openai import OpenAI

# Setup Mouth
engine = pyttsx3.init()
client = OpenAI(base_url="http://localhost:1234/v1", api_key="lm-studio")

def speak(text):
    engine.say(text)
    engine.runAndWait()

cap = cv2.VideoCapture(0)
ret, frame1 = cap.read()
ret, frame2 = cap.read()

print("Sentry Online...")
speak("Sentry system active.")

while cap.isOpened():
    diff = cv2.absdiff(frame1, frame2)
    gray = cv2.cvtColor(diff, cv2.COLOR_BGR2GRAY)
    _, thresh = cv2.threshold(gray, 20, 255, cv2.THRESH_BINARY)
    
    if thresh.sum() > 300000:
        cv2.imwrite("D:/Dev/Sentry/temp_sentry.jpg", frame2)
        
        prompt = "You see Dale (glasses). Greet him briefly."
        response = client.chat.completions.create(
            model="local-model",
            messages=[{"role": "user", "content": prompt}]
        )
        answer = response.choices[0].message.content
        
        # Log it and SPEAK it
        with open("D:/Dev/Sentry/sentry_log.txt", "a") as f:
            f.write(f"[{time.ctime()}] {answer}\n")
        speak(answer)

    frame1 = frame2
    ret, frame2 = cap.read()
    if cv2.waitKey(10) == 27: break