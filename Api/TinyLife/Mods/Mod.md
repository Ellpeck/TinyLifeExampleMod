# [Mod](./Mod.md)

Namespace: [TinyLife]() > [Mods]()

Assembly: Tiny Life.dll

## Summary
The base class for all Tiny Life mods.  For an example mod, see <see href="https://github.com/Ellpeck/TinyLifeExampleMod" />.  Mods are uniquely identified by their ID. The id is the name of the class that extends `TinyLife.Mods.Mod`.

## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Description | The description of this mod, which will be visible in the options menu.  To localize the description, use `TinyLife.Localization`. | 
| [TextureRegion](./Mod.md) | Icon | The icon texture region of this mod, which will be visible in the options menu | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The display name of this mod, which will be visible in the options menu | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | AddGameContent ( [`GameImpl`](./../GameImpl.md) ) | Add the content that this mod provides for the given `TinyLife.GameImpl` instance. The following ways of content registration are supported:  `TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)` to register furniture types,  `TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)` to register action types,  `TinyLife.Objects.Clothes.Register(TinyLife.Objects.Clothes)` to register clothes (and hair),  `TinyLife.Skills.SkillType.Register(TinyLife.Skills.SkillType)` to register skills,  `TinyLife.World.Wallpaper.Register(System.String,System.Int32,MLEM.Textures.UniformTextureAtlas,Microsoft.Xna.Framework.Point,TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)` to register wallpapers,  `TinyLife.World.Tile.Register(System.String,System.Int32,MLEM.Textures.TextureRegion,TinyLife.Utilities.ColorScheme,System.Single,System.Boolean,System.Boolean,MLEM.Textures.TextureRegion)` to register tiles. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String)> | GetCustomFurnitureTextures (  ) | Return a list of paths (relative to this mod's Content directory) to textures that contain the texture regions used by this mod's custom `TinyLife.Objects.FurnitureType`s.  Note that the furniture texture needs to have an associated `MLEM.Data.DataTextureAtlas` file in the same location, but with the .atlas file extension.  By default, an empty `System.Collections.Generic.IEnumerable`1` is returned. | 
| void | Initialize ( [`Logger`](./Mod.md), [`RawContentManager`](./Mod.md), [`RuntimeTexturePacker`](./Mod.md) ) | Initialize the data for this mod, including textures, sounds and other data.  The `MLEM.Data.Content.RawContentManager` is a variation of MonoGame's `Microsoft.Xna.Framework.Content.ContentManager` and should be used to load mod content. | 


