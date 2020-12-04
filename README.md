# Tiny Life Example Mod
An example mod for my game Tiny Life. Fork this repository if you make a mod so people can easily find it!

# Installing mods
Installing a mod is pretty simple:
- Find the `Tiny Life` folder in your local app data (On Windows, just type `%localappdata%` into your search)
- Find the `Mods` folder in there
- If you received the mod you want to install as a `zip` (or any other kind of) archive, extract it first
- Put the mod's `dll` as well as its `Content` folder into the `Mods` folder.

Done! Now just start the game and the mod should automatically load. If there are any errors, they'll be logged in the `Log.txt` file in the `Tiny Life` folder.

# Creating mods
To create a mod, all you have to do is fork this repository and open the project contained in it using Visual Studio, Rider or any other kind of C# IDE. The code that is already there contains some examples. Once you're done checking them out, you can just delete them and start fresh.

Since Tiny Life uses early versions of some of my libraries, you will also have to add [my server](https://nuget.ellpeck.de/) to your NuGet config. You can do so using the following command:
```
dotnet nuget add source https://nuget.ellpeck.de/v3/index.json --name "Ellpeck"
```

This repository also contains a little script called `Run.sh` that you can use to automatically build your mod, copy it into the `Mods` directory of your Tiny Life instance and run the game. Just be sure to modify all of the paths first.

The game's API is currently in the process of being documented. This documentation is easily accessible by opening any of the API's files in your IDE. In the future, there will additionally be a web version of the API documentation.

## Distributing mods
To distribute your mod to other people, all you have to do is go into the `bin/Debug/netcoreapp3.0` folder after building and copy your mod's `dll` and the `Content` directory. You can either send them to your friends directly or pack them into an archive first.

## Updating mods
To change the version of Tiny Life that your mod is compiled against, simply go into [the project file](https://github.com/Ellpeck/TinyLifeExampleMod/blob/main/ExampleMod.csproj) and change the `TinyLifeApi` version. Note that some other dependencies might also have been updated, which needs to be [taken into account](https://github.com/Ellpeck/TinyLifeExampleMod#dependency-version-history).

## Where's the source code?
The NuGet package for the Tiny Life API just contains a [reference assembly](https://docs.microsoft.com/en-us/dotnet/standard/assembly/reference-assemblies) so that people can't just download the game from NuGet and play it. Since most of the public API is documented, you won't have to look at the source code in most cases, anyway.

Technically, you can download the game [from itch](https://ellpeck.itch.io/tiny-life) and then decompile it to see the implementation's code, but due to its license, copying it is not allowed.

## Dependency version history
Since the mod is compiled against the same dependencies as Tiny Life, it also needs to have the same versions of those dependencies for mods to work correctly with the game. The following is a list of versions of Tiny Life and the appropriate dependency versions that the mod should be compiled against to work for that version. When updating your mod, you can just copy the appropriate part [into your project file](https://github.com/Ellpeck/TinyLifeExampleMod/blob/main/ExampleMod.csproj#L10-L15).
```xml
<!-- Tiny Life 0.2.2+ -->
<PackageReference Include="ExtremelySimpleLogger" Version="1.2.1" />
<PackageReference Include="MLEM.Data" Version="4.3.0-8" />
<PackageReference Include="MLEM.Extended" Version="4.3.0-8" />
<PackageReference Include="MLEM.Startup" Version="4.3.0-8" />
<PackageReference Include="MonoGame.Extended" Version="3.8.0" />
<PackageReference Include="MonoGame.Framework.DesktopGL" Version="3.8.0.1641" />

<!-- Tiny Life 0.2.1 -->
<PackageReference Include="ExtremelySimpleLogger" Version="1.1.0" />
<PackageReference Include="MLEM.Data" Version="4.3.0-7" />
<PackageReference Include="MLEM.Extended" Version="4.0.0" />
<PackageReference Include="MLEM.Startup" Version="4.2.0-298" />
<PackageReference Include="MonoGame.Framework.DesktopGL" Version="3.8.0.1641" />
```