@echo off
xcopy /Y /F Dockerfile ..\bin\Release
set /p revversion=<version.txt

echo building baradiyah/foldercreation:%revversion%
docker build -t baradiyah/foldercreation:%revversion% ../bin/Release

echo ready to publish baradiyah/foldercreation:%revversion%, Press CTRL-C to exit or any key to continue

pause
docker push baradiyah/foldercreation:%revversion%

echo all done
pause 