# Camera Viewer App

A minimal Python app for Windows that displays a USB camera feed, allows toggling the camera on/off, takes a photo every 10 seconds, and saves images to a user-chosen folder. The app uses OpenCV and Tkinter for a lightweight GUI. Saved images can be accessed by LM Studio or other local LLMs for RAG purposes.

## Features
- View USB camera feed in a small window
- Camera on/off toggle
- Take a photo every 10 seconds
- Save images to a user-selected folder
- Button to choose save location (opens Explorer)
- Lightweight and simple

## Requirements
- Python 3.8+
- OpenCV (`opencv-python`)
- Tkinter (included with standard Python)

## Setup
1. Install Python 3.8 or newer from https://python.org
2. Install dependencies:
   ```
   pip install opencv-python
   ```
3. Run the app:
   ```
   python camera_viewer.py
   ```

## Usage
- Use the GUI to start/stop the camera, select the save folder, and view the camera feed.
- Images are saved every 10 seconds to the selected folder.

---
This app is designed for local use and easy integration with LM Studio for RAG workflows.
