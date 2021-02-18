#!/bin/bash
# move to the script directory
cd "$(dirname "$0")"
# build the mod
dotnet build
# copy the mod to the mods folder
cp ./bin/Debug/net5.0/* "$LOCALAPPDATA/Tiny Life/Mods" -r
# run the game
dir=$(<"$LOCALAPPDATA/Tiny Life/GameDir")
cd $dir
"./Tiny Life.exe"