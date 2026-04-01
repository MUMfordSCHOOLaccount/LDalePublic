# Sentry AI (Voice Mode)
A voice-enabled security system that listens, watches, and speaks.

## Features
- **Voice Interaction**: Ask the system who is there or what has happened using natural speech.
- **Audio Alerts**: The system speaks back to you using Text-to-Speech (TTS).
- **Motion Greeting**: Configured to greet you when movement is detected.
- **Seamless Operation**: Runs the camera monitoring in the background while keeping the voice interface active.

## Requirements
- **Hardware**: USB Webcam, Microphone, and Speakers.
- **Software**: 
  - Python 3.10+
  - **LM Studio**: Running a local LLM on port 1234.
- **Python Libraries**: `pip install opencv-python openai pyttsx3 SpeechRecognition pyaudio`

## Setup
1. Start **LM Studio** and enable the Local Server.
2. Ensure your microphone and speakers are the default system devices.
3. (Optional) Path Adjustment: Update file paths in `s.py` and `c.py` to match your local setup.
4. Run `Start_ChadS.bat` to activate the system.
