# Tiny Life Example Mod
An example mod for my game Tiny Life. Use this template repository to create your own mod!

# Getting custom content
You can get custom lots, households and mods from [the community](https://itch.io/board/1032686/mods).

Installing a mod or other custom content is pretty simple:
- Find the `Tiny Life` folder (you can open it from the game's options menu)
- Find the `Mods` (or `Custom Lots` or `Custom Households`) folder in there
  - For mods, if you received it as a `zip` (or any other kind of archive), extract it first, and then put the mod's `dll` as well as its `Content` folder into the `Mods` folder.
  - For custom lots and households, simply put the `json` file(s) you received into the respective folder.

Done! Now just start the game and the added content should automatically load. If there are any errors, they'll be logged in the most recent file in the `Tiny Life/Logs` folder.

# Creating mods
To create a mod, all you have to do is create a repository [from this template](https://github.com/Ellpeck/TinyLifeExampleMod/generate) and open the project contained in it using Visual Studio, Rider or any other kind of C# IDE. The code that is already there contains some examples. Once you're done checking them out, you can just delete them and start fresh.

This repository also contains a little `Run` script for [windows](./Run.bat) and [linux and mac](./Run.sh) that automatically builds your mod, copies it into the `Mods` directory of your Tiny Life instance and runs the game. Note that the script will only work correctly if you've previously launched Tiny Life manually.

The game's API is **fully documented**. The documentation is easily accessible by opening any of the API's files in your IDE. The most updated version can be found on [the wiki](https://github.com/Ellpeck/TinyLifeExampleMod/wiki) as well.

If you have any questions, don't hesitate to [ask on the Discord](https://ellpeck.de/discord) or [start a discussion](https://github.com/Ellpeck/TinyLifeExampleMod/discussions) about it.

## Distributing mods
To distribute your mod to other people, all you have to do is go into the `bin/Debug/net5.0` folder after building and copy your mod's `dll` and the `Content` directory. You can either send them to your friends directly or pack them into an archive first. If you want other players to try out your mod, you can also post it to [the community](https://itch.io/board/1032686/mods).

## Updating mods
To change the version of Tiny Life that your mod is compiled against, simply go into [the project file](https://github.com/Ellpeck/TinyLifeExampleMod/blob/main/ExampleMod.csproj) and change the `TinyLifeApi` version. Note that some other dependencies might also have been updated, which needs to be [taken into account](https://github.com/Ellpeck/TinyLifeExampleMod#dependency-version-history).

## Where's the source code?
The NuGet package for the Tiny Life API just contains a [reference assembly](https://docs.microsoft.com/en-us/dotnet/standard/assembly/reference-assemblies) so that people can't just download the game from NuGet and play it. Since most of the public API is documented, you won't have to look at the source code in most cases, anyway.

Technically, you can [download the game](https://tinylifegame.com/) and then decompile it to see the implementation's code, but due to its license, copying it is not allowed.

## Dependency version history
Since the mod is compiled against the same dependencies as Tiny Life, it also needs to have the same versions of those dependencies for mods to work correctly with the game. Each update to this repository is [tagged](https://github.com/Ellpeck/TinyLifeExampleMod/tags) with the game's version number. If you want to develop for a certain version, just check that tag's [project file](https://github.com/Ellpeck/TinyLifeExampleMod/blob/main/ExampleMod.csproj) to see the required dependency versions.

# Testing cheats
You can open up the game's cheat menu by pressing the `F1` key. Here is a list of some of the more useful cheats for mod development and testing. Keep in mind that `[arguments]` need to be replaced with your custom value.
- `ShowNonBuyable` allows you to buy plates, pots and the like
- `Need [name] [percentage <= 1]` changes the current person's needs
  - `NoNeed` stops need reduction for everyone
  - `Needless` fills all needs back up
  - `Needy` reduces all needs to zero
- `EditWorld` allows you to place things outside of lots
- `IgnorePlacementRules` allows you to place colliding furniture
- `EditPerson` opens a character editor with all functionality enabled
- `Gib` gives you 10,000 tiny bucks
- `ExtremelyFast` allows you to select the 15x speed option all the time
- `Skill [name] [level]` sets the current person's skill level
- `Held [object name or null]` sets the current person's held object
- `Job [name] [level]` stes the current person's job and job level
- `Die` kills the current person
- `Emotion [modifier name] [level] [seconds]` adds an emotion modifier to the current person
- `Friendship [name without spaces] [percentage <= 1]` sets the friendship level between the named partner and the current person
- `Romance [name without spaces] [percentage <= 1]` sets the romance level between the named partner and the current person
- `EditCurrentActionSpot` turns on action spot edit mode, which allows you to easily edit the properties of the selected person's current action spot
  - The person's animation stops, but they are drawn on all surrounding objects of the same type instead, which makes it easier to ensure that the offset looks correct in multiple rotations and positions
  - Pressing the up, down, left and right keys moves the current action spot's position and holding shift moves the spot's visual position instead
  - Pressing the page up and page down keys moves the spot's y offset
  - The resulting values are printed to the console every time a modification is made, so you can copy them and paste them into your action spot code