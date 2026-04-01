import speech_recognition as sr
import pyttsx3
import os
from openai import OpenAI

# Setup
client = OpenAI(base_url="http://localhost:1234/v1", api_key="lm-studio")
engine = pyttsx3.init()
r = sr.Recognizer()

def speak(text):
    print(f"\nChad: {text}")
    engine.say(text)
    engine.runAndWait()

def listen():
    with sr.Microphone() as source:
        print("\n[Listening...]")
        r.adjust_for_ambient_noise(source, duration=1)
        audio = r.listen(source)
    try:
        return r.recognize_google(audio)
    except:
        return ""

os.system('cls')
print("=== CHAD VOICE INTERFACE ===")

while True:
    user_speech = listen()
    
    if user_speech:
        print(f"You said: {user_speech}")
        
        if "exit" in user_speech.lower():
            speak("System shutting down. Goodbye Dale.")
            os.system("taskkill /F /IM python.exe /T")
            break
            
        with open("D:/Dev/Sentry/sentry_log.txt", "r") as f:
            history = "".join(f.readlines()[-5:])
            
        prompt = f"Context: {history}\nDale says: {user_speech}"
        response = client.chat.completions.create(
            model="local-model",
            messages=[{"role": "user", "content": prompt}]
        )
        speak(response.choices[0].message.content)