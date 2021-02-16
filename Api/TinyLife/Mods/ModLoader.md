# [ModLoader](./ModLoader.md)

Namespace: [TinyLife]() > [Mods]()

Assembly: Tiny Life.dll

## Summary
The mod loader loads `TinyLife.Mods.Mod` instances from the `TinyLife.Mods.ModLoader.GetModsFolder`.

## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo) | GetModsFolder (  ) | Returns a `System.IO.DirectoryInfo` pointing to the directory that mods should be put into and loaded from | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | TryGetModInfo ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), out [`ModInfo`](./ModLoader.md) ) | This method can be used to gather a `TinyLife.Mods.ModInfo` for a mod that is currently loaded with the given id.  If no mod with that id is currently loaded, this method returns false and assigns null to `TinyLife.Mods.ModInfo`. | 


