#!/bin/bash
# move to the script directory
cd "$(dirname "$0")"
# build the mod
dotnet build
# zip the mod
cd ./bin/Debug/net6.0
file=$(find *.dll -printf %f)
dest=${file::-4}.zip
zip -FSr ../$dest * --exclude 'ref/*' --exclude '*.pdb' --exclude '*.deps.json'
echo Published to bin/Debug/$dest