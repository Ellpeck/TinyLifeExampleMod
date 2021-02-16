# [SkillType](./SkillType.md)

Namespace: [TinyLife]() > [Skills]()

Assembly: Tiny Life.dll

## Summary
A skill is an ability that a `TinyLife.Objects.Person` can have which influences their behavior in some way.  The SkillType class contains underlying data for a `TinyLife.Skills.Skill` instance, like its name and maximum level.

## Constructors

| Name | Summary | 
| --- | --- | 
| SkillType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`TextureRegion`](./SkillType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`SkillCategory`](./SkillCategory.md) ) | Creates a new skill type with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [SkillCategory](./SkillCategory.md) | Categories | The `TinyLife.Skills.SkillCategory` combined flag that this skill type has.  The skill categories it has are used to determine skill gain from things like the `TinyLife.PersonalityType.Creative` personality type. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | MaxLevel | The maximum level that this skill can reach.  Most skills should default to 5 or 10 for consistency. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this skill type | 
| [TextureRegion](./SkillType.md) | Texture | The texture region of this skill type's icon | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Quality](./Quality.md) | GetRandomQuality ( [`Person`](./../Objects/Person.md), [`Random`](https://docs.microsoft.com/en-us/dotnet/api/System.Random), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Returns a semi-randomly generated `TinyLife.Skills.Quality` for the given `TinyLife.Objects.Person` based on their level of this skill.  The higher the skill level is, the more likely it is for higher qualities to be returned. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [SkillType](./SkillType.md) | Charisma |  | 
| [SkillType](./SkillType.md) | Cooking |  | 
| [SkillType](./SkillType.md) | Humor |  | 
| [SkillType](./SkillType.md) | Painting |  | 
| [SkillType](./SkillType.md) | Programming |  | 
| [SkillType](./SkillType.md) | Repair |  | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [SkillType](./SkillType.md)> | Types | A registry of all skill types that exist in the game and mods.  Use `TinyLife.Skills.SkillType.Register(TinyLife.Skills.SkillType)` to register custom skill types. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [SkillType](./SkillType.md) | Register ( [`SkillType`](./SkillType.md) ) | Registers a new `TinyLife.Skills.SkillType` to the `TinyLife.Skills.SkillType.Types` registry | 


