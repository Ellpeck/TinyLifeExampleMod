# TinyLifeExampleMod
An example mod for my game Tiny Life. Fork this repository if you make a mod so people can easily find it!

# Installing Mods
Installing a mod is pretty simple:
- Find the `Tiny Life` folder in your local app data (On Windows, just type `%localappdata%` into your search)
- Find the `Mods` folder in there
- If you received the mod you want to install as a `zip` (or any other kind of) archive, extract it first
- Put the mod's `dll` as well as its `Content` folder into the `Mods` folder.

Done! Now just start the game and the mod should automatically load. If there are any errors, they'll be logged in the `Log.txt` file in the `Tiny Life` folder.

# Creating Mods
To create a mod, all you have to do is fork this repository and open the project contained in it using Visual Studio, Rider or any other kind of C# IDE. The code that is already there contains some examples. Once you're done checking them out, you can just delete them and start fresh.

Since Tiny Life uses early versions of some of my libraries, you will also have to add [my server](https://nuget.ellpeck.de/) to your NuGet config. You can do so using the following command:
```
dotnet nuget add source https://nuget.ellpeck.de/v3/index.json --name "Ellpeck"
```

This repository also contains a little script called `Run.sh` that you can use to automatically build your mod, copy it into the `Mods` directory of your Tiny Life instance and run the game. Just be sure to modify all of the paths first.

**Note that there is no proper modding API right now**, so you can pretty much do anything you want. You can look around in the reference code to see what there is to add and change.

## Distributing mods
To distribute your mod to other people, all you have to do is go into the `bin/Debug/netcoreapp3.0` folder after building and copy your mod's `dll` and the `Content` directory. You can either send them to your friends directly or pack them into an archive first.

## Updating mods
To change the version of Tiny Life that your mod is compiled against, simply go into the `csproj` file and change the `TinyLifeApi` version. Note that some other dependencies might also have been updated, which needs to be taken into account. [The project file in this repo](https://github.com/Ellpeck/TinyLifeExampleMod/blob/main/ExampleMod.csproj) always has the same dependencies as the most recent version of the game.

## Where's the source code?
The NuGet package for the Tiny Life API just contains a [reference assembly](https://docs.microsoft.com/en-us/dotnet/standard/assembly/reference-assemblies) so that people can't just download the game from NuGet and play it. If you want to see the game's *full* source code, all you have to do is open the `Tiny Life.dll` that you downloaded [on itch](https://ellpeck.itch.io/tiny-life) in your IDE.