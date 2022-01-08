@echo off
rem move to the script directory
cd /d "%~dp0"
rem build the mod
dotnet build || exit /b
rem zip the mod
cd ./bin/Debug/net6.0
for /F %%p in ('dir /b "*.dll"') do (set file=%%p)
set dest=%file:~0,-4%.zip
tar -acf ../%dest% --exclude ref --exclude *.pdb --exclude *.deps.json *
echo Published to bin/Debug/%dest%