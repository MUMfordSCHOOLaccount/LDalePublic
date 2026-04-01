# Minimal MCP server for LM Studio to expose camera images as a tool
# Requires: fastapi, uvicorn
# Install with: pip install fastapi uvicorn

import os
from fastapi import FastAPI, Response
from fastapi.responses import FileResponse, JSONResponse
from typing import List

app = FastAPI()

# Set this to your camera image save directory
SAVE_DIR = os.path.abspath(os.path.join(os.path.dirname(__file__), "images"))
if not os.path.exists(SAVE_DIR):
    os.makedirs(SAVE_DIR)

@app.get("/tools/camera/latest")
def get_latest_image():
    files = sorted([f for f in os.listdir(SAVE_DIR) if f.endswith(".jpg")], reverse=True)
    if not files:
        return JSONResponse({"error": "No images found"}, status_code=404)
    latest = files[0]
    return FileResponse(os.path.join(SAVE_DIR, latest), media_type="image/jpeg")

@app.get("/tools/camera/list")
def list_images() -> List[str]:
    files = sorted([f for f in os.listdir(SAVE_DIR) if f.endswith(".jpg")], reverse=True)
    return files

# To run: uvicorn mcp_camera_server:app --host 127.0.0.1 --port 3333
# Add to LM Studio config as a custom MCP server
