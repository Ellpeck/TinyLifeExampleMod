#!/bin/bash
GAME_DIR="path/to/Tiny Life"

# build the mod
dotnet build

# copy the mod to the mods folder
cp ./bin/Debug/netcoreapp3.0/* "$LOCALAPPDATA/Tiny Life/Mods" -r

# run the game
cd "$GAME_DIR"
"./Tiny Life.exe"