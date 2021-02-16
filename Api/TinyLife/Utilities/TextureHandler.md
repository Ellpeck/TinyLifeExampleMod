# [TextureHandler](./TextureHandler.md)

Namespace: [TinyLife]() > [Utilities]()

Assembly: Tiny Life.dll

## Summary
The texture handler stores data for the game's textures, including all of the game's internal textures and various utility methods.  It also stores the game's `MLEM.Data.RuntimeTexturePacker` which is used to pack all textures into a big texture for performance.

## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | ApplyWallpaperMasks ( [`Texture2D`](./TextureHandler.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Action`](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1)\<[`UniformTextureAtlas`](./TextureHandler.md)> ) | Applies the game's predefined wallpaper maskings (based on `TinyLife.World.WallMode`) to the given wallpaper texture.  When adding custom `TinyLife.World.Wallpaper` types, this method should be used.  Note that, as part of this method, the resulting texture is implicitly added onto the game's `MLEM.Data.RuntimeTexturePacker`. | 


