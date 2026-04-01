import os
from openai import OpenAI

# --- SETUP ---
client = OpenAI(base_url="http://localhost:1234/v1", api_key="lm-studio")
LOG_FILE = "D:/Dev/Sentry/sentry_log.txt"

def get_history():
    if not os.path.exists(LOG_FILE): return "No logs."
    with open(LOG_FILE, "r") as f:
        return "".join(f.readlines()[-10:]) # Last 10 lines

os.system('cls')
print("=== CHAD QUIET MODE (TEXT ONLY) ===")

while True:
    user_input = input("\nYou: ")
    
    if user_input.lower() in ['quit', 'exit', 'bye']:
        print("Shutting down...")
        # Kills the background camera script too
        os.system("taskkill /F /IM python.exe /T") 
        break
        
    history = get_history()
    prompt = f"Context: {history}\nDale says: {user_input}"
    
    try:
        response = client.chat.completions.create(
            model="local-model",
            messages=[{"role": "user", "content": prompt}]
        )
        print(f"\nChad: {response.choices[0].message.content}")
    except:
        print("Error: Is LM Studio Running?")