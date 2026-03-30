@echo off
title CHAD SENTRY SYSTEM
echo Starting Sentry Camera...
start /min python D:\Dev\Sentry\s.py
echo.
echo Sentry is running in the background.
echo.
python D:\Dev\Sentry\c.py
pause
if user_input.lower() in ['quit', 'exit', 'bye']:
    print("Shutting down Chad...")
    # This command tells Windows to kill the background 's.py'
    os.system("taskkill /F /IM python.exe /T") 
    break