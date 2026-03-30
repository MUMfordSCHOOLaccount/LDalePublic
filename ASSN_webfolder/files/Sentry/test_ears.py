import speech_recognition as sr

r = sr.Recognizer()

# This part opens your microphone
with sr.Microphone() as source:
    print("\n[CHAD IS LISTENING... SAY SOMETHING!]")
    
    # It waits for 1 second of silence to calibrate
    r.adjust_for_ambient_noise(source, duration=1)
    
    # This takes your voice and saves it as 'audio'
    audio = r.listen(source)

try:
    # This sends the 'audio' to turn it into text
    print("Working...")
    text = r.recognize_google(audio)
    print(f"\nSUCCESS! Chad heard: {text}")
except Exception as e:
    print("\nERROR: Chad couldn't hear you. Check your Mic settings.")