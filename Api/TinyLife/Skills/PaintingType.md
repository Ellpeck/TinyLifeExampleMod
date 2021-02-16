# [PaintingType](./PaintingType.md)

Namespace: [TinyLife]() > [Skills]()

Assembly: Tiny Life.dll

## Summary
This class represents a type of `TinyLife.Objects.Painting` that can be created using the `TinyLife.Skills.SkillType.Painting`.  Painting types are registered using `TinyLife.Skills.PaintingType.Register(TinyLife.Skills.PaintingType)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| PaintingType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Range`](./PaintingType.md)\<[`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)>, [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Creates a new painting type with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | BaseMarkup | The multiplier with which the created `TinyLife.Objects.Painting`'s price will be marked up.  Before this multiplier is applied, the level and quality modifiers are also applied. | 
| [Range](./PaintingType.md)\<[Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> | LevelRange | The `MonoGame.Extended.Range`1` of levels of the `TinyLife.Skills.SkillType.Painting` skill that allows creating this painting | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this painting type | 
| [TextureRegion](./PaintingType.md) | Texture | The texture that this painting uses.  The texture is loaded from the `TinyLife.Mods.Mod.GetCustomFurnitureTextures` as "Painting`TinyLife.Skills.PaintingType.Name`"  Note that this texture is just an overlay; the frame and white background are automatically drawn. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [PaintingType](./PaintingType.md)> | Types | All registered `TinyLife.Skills.PaintingType` instances in the game and in active mods | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`PaintingType`](./PaintingType.md) ) | Registers a painting type with the given settings to the `TinyLife.Skills.PaintingType.Types` registry | 


