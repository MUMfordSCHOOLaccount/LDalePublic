# Sentry AI (Text Mode)
An AI-powered security monitoring system focusing on text-based alerts and interaction.

## Features
- **Motion Detection**: Uses OpenCV to monitor camera feeds and detect movement.
- **Visual Description**: When motion is detected, it captures a frame and uses a local Vision LLM to describe what happened.
- **History Awareness**: Keeps a running log of events to provide context for new detections.
- **Interactive Terminal**: Chat with the system (named "Chad") to query recent history or status.

## Requirements
- **Hardware**: USB Webcam.
- **Software**: 
  - Python 3.10+
  - **LM Studio**: Must be running a Vision-capable LLM (e.g., LLaVA, Moondream) on the local server (port 1234).
- **Python Libraries**: `pip install opencv-python openai`

## Setup
1. Start **LM Studio** and enable the Local Server.
2. (Optional) Path Adjustment: The scripts currently point to `D:/Dev/Sentry/`. You may need to create this directory or update the paths in `s.py` and `c_quiet.py`.
3. Run `Start_QuietS.bat` to launch both the background monitor and the interactive chat hub.
