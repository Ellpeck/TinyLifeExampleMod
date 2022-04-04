#!/bin/bash
# move to the script directory
cd "$(dirname "$0")"
# build the mod
dotnet build || exit
# copy the mod to the mods folder
cp -r ./bin/Debug/net6.0/* "$HOME/.local/share/Tiny Life/Mods"
# run the game
dir=$(<"$HOME/.local/share/Tiny Life/GameDir")
cd "$dir"
"./Tiny Life" -v --skip-splash --skip-preloads