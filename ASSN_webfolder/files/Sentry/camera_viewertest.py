can you import cv2
import tkinter as tk
from tkinter import filedialog, messagebox
from PIL import Image, ImageTk
import threading
import time
import os

class CameraApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Camera Viewer")
        self.root.geometry("400x350")
        self.root.resizable(False, False)

        self.save_dir = os.getcwd()
        self.camera_on = False
        self.capture_thread = None
        self.last_frame = None
        self.stop_event = threading.Event()

        self.create_widgets()

    def create_widgets(self):
        self.video_label = tk.Label(self.root, text="Camera preview", width=320, height=240, bg="black")
        self.video_label.pack(pady=10)

        self.toggle_btn = tk.Button(self.root, text="Camera ON", command=self.toggle_camera)
        self.toggle_btn.pack(pady=5)

        self.save_btn = tk.Button(self.root, text="Choose Save Location", command=self.choose_save_dir)
        self.save_btn.pack(pady=5)

        self.status_label = tk.Label(self.root, text=f"Save to: {self.save_dir}")
        self.status_label.pack(pady=5)

    def choose_save_dir(self):
        folder = filedialog.askdirectory()
        if folder:
            self.save_dir = folder
            self.status_label.config(text=f"Save to: {self.save_dir}")

    def toggle_camera(self):
        if not self.camera_on:
            self.camera_on = True
            self.toggle_btn.config(text="Camera OFF")
            self.stop_event.clear()
            self.capture_thread = threading.Thread(target=self.camera_loop, daemon=True)
            self.capture_thread.start()
        else:
            self.camera_on = False
            self.toggle_btn.config(text="Camera ON")
            self.stop_event.set()

    def camera_loop(self):
        cap = cv2.VideoCapture(0)
        if not cap.isOpened():
            messagebox.showerror("Error", "Cannot open camera.")
            self.toggle_camera()
            return
        next_capture = time.time() + 10
        while not self.stop_event.is_set():
            ret, frame = cap.read()
            if not ret:
                break
            self.last_frame = frame
            self.show_frame(frame)
            if time.time() >= next_capture:
                self.save_image(frame)
                next_capture = time.time() + 10
            if cv2.waitKey(1) == 27:
                break
        cap.release()
        self.video_label.config(image="", text="Camera preview")

    def show_frame(self, frame):
        rgb = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        img = Image.fromarray(rgb)
        img = img.resize((320, 240))
        imgtk = ImageTk.PhotoImage(image=img)
        self.video_label.imgtk = imgtk
        self.video_label.config(image=imgtk, text="")

    def save_image(self, frame):
        ts = time.strftime("%Y%m%d_%H%M%S")
        filename = os.path.join(self.save_dir, f"photo_{ts}.jpg")
        cv2.imwrite(filename, frame)

if __name__ == "__main__":
    root = tk.Tk()
    app = CameraApp(root)
    root.mainloop()
