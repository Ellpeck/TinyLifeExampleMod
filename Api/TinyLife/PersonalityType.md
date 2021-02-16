# [PersonalityType](./PersonalityType.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
A personality type is a trait that a `TinyLife.Objects.Person` can have.  Each personality type is meant to influence the person's behavior and abilities slightly in a certain way.

## Constructors

| Name | Summary | 
| --- | --- | 
| PersonalityType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`TextureRegion`](./PersonalityType.md), [`PersonalityType`](./PersonalityType.md)[] ) | Creates a new personality type with the given name | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [PersonalityType](./PersonalityType.md)[] | DisallowedOthers | A set of personality types that cannot be applied together with this one | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this personality type.  As this is used for `TinyLife.PersonalityType.Types`, this name needs to be unique across all installed mods. | 
| [TextureRegion](./PersonalityType.md) | Texture | The icon texture for this personality type | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [PersonalityType](./PersonalityType.md) | Ambitious |  | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | AmountPerPerson | The amount of personality types that each `TinyLife.Objects.Person` can have | 
| [PersonalityType](./PersonalityType.md) | Creative |  | 
| [PersonalityType](./PersonalityType.md) | Energetic |  | 
| [PersonalityType](./PersonalityType.md) | Lazy |  | 
| [PersonalityType](./PersonalityType.md) | Likeable |  | 
| [PersonalityType](./PersonalityType.md) | Mean |  | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [PersonalityType](./PersonalityType.md)> | Types | A registry of all of the personality types in the game.  Use `TinyLife.PersonalityType.Register(TinyLife.PersonalityType)` to register custom personality types. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [PersonalityType](./PersonalityType.md) | Register ( [`PersonalityType`](./PersonalityType.md) ) | Registers this personality type to the `TinyLife.PersonalityType.Types` registry | 


