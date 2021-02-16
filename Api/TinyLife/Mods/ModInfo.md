# [ModInfo](./ModInfo.md)

Namespace: [TinyLife]() > [Mods]()

Assembly: Tiny Life.dll

Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable)

## Summary
A mod info is a set of properties that every `TinyLife.Mods.ModInfo.Mod` instance is assigned

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [RawContentManager](./ModInfo.md) | Content | A `MLEM.Data.Content.RawContentManager` that this mod can use to load its content.  This content manager's base directory automatically points to the mod's Content folder. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Id | The id of the mod, which is based on the `TinyLife.Mods.ModInfo.Mod`'s class name | 
| [Logger](./ModInfo.md) | Logger | The `TinyLife.Mods.ModInfo.Logger` that this mod can use to log information about itself.  By default, this logger has the same sinks as the game's logger. | 
| [Mod](./Mod.md) | Mod | The actual mod instance | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Dispose (  ) |  | 


