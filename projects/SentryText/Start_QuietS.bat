@echo off
title CHAD QUIET HUB
echo Starting Sentry in background...
:: 'pythonw' runs the camera with NO window at all
start /b pythonw D:\Dev\Sentry\s.py
echo.
echo Mode: TEXT ONLY
echo.
python D:\Dev\Sentry\c_quiet.py
pause