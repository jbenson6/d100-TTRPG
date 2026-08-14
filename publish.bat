@echo off
setlocal

cd /d "D:\Projects\d100 TTRPG"

echo.
echo ========================================
echo   Publishing d100 TTRPG v1.0.0
echo ========================================
echo.

echo [1/6] Publishing main application...
dotnet publish ".\d100 TTRPG\d100 TTRPG.csproj" -c Release -r win-x64 --self-contained true
if errorlevel 1 goto :error

echo.
echo [2/6] Publishing updater...
dotnet publish ".\d100 TTRPG.Updater\d100 TTRPG.Updater.csproj" -c Release -r win-x86 --self-contained true
if errorlevel 1 goto :error

echo.
echo [3/6] Copying updater...
copy /Y ".\d100 TTRPG.Updater\bin\Release\net10.0\win-x86\publish\d100 TTRPG.Updater.exe" ".\d100 TTRPG\bin\Release\net10.0\win-x64\publish\d100 TTRPG.Updater.exe"
if errorlevel 1 goto :error

echo.
echo [4/6] Creating ZIP...
powershell -NoProfile -Command "Compress-Archive -Path '.\d100 TTRPG\bin\Release\net10.0\win-x64\publish\*' -DestinationPath '.\d100 TTRPG\bin\Release\net10.0\win-x64\d100-TTRPG-1.0.0.zip' -Force"
if errorlevel 1 goto :error

echo.
echo [5/6] Removing old GitHub asset...
gh release delete-asset v1.0.0 d100-TTRPG-1.0.0.zip --repo jbenson6/d100-TTRPG -y
if errorlevel 1 goto :error

echo.
echo [6/6] Uploading new GitHub asset...
gh release upload v1.0.0 ".\d100 TTRPG\bin\Release\net10.0\win-x64\d100-TTRPG-1.0.0.zip" --repo jbenson6/d100-TTRPG
if errorlevel 1 goto :error

echo.
echo ========================================
echo   v1.0.0 published successfully!
echo ========================================
echo.
echo GitHub release:
echo https://github.com/jbenson6/d100-TTRPG/releases/tag/v1.0.0
echo.
pause
exit /b 0

:error
echo.
echo ========================================
echo   ERROR - Publishing failed!
echo ========================================
echo.
pause
exit /b 1