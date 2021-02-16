# [EmotionType](./EmotionType.md)

Namespace: [TinyLife]() > [Emotions]()

Assembly: Tiny Life.dll

## Summary
An emotion type is a type of feeling that a `TinyLife.Objects.Person` can have.  The emotion that a person has results from that person's applied `TinyLife.Emotions.EmotionModifier``TinyLife.Emotions.EmotionModifier.Instance`s.

## Constructors

| Name | Summary | 
| --- | --- | 
| EmotionType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`TextureRegion`](./EmotionType.md), [`Color`](./EmotionType.md), [`TypeCategory`](./EmotionType.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [TypeCategory](./EmotionType.md) | Category | The `TinyLife.Emotions.EmotionType.TypeCategory` that this emotion type fits into.  The category is used for ordering and organizing `TinyLife.Emotions.EmotionModifier` instances. | 
| [Color](./EmotionType.md) | Color | The color that represents this emotion.  The color is used as a backdrop for `TinyLife.Emotions.EmotionModifier` instances of this type. | 
| [TextureRegion](./EmotionType.md) | Icon | This emotion's icon, which is used in the portrait section for a `TinyLife.Objects.Person` that has this emotion | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | This emotion's name | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [EmotionType](./EmotionType.md) | Asleep |  | 
| [EmotionType](./EmotionType.md) | Bored |  | 
| [EmotionType](./EmotionType.md) | Creative |  | 
| [EmotionType](./EmotionType.md) | Embarrassed |  | 
| [EmotionType](./EmotionType.md) | Fine |  | 
| [EmotionType](./EmotionType.md) | Focused |  | 
| [EmotionType](./EmotionType.md) | Frisky |  | 
| [EmotionType](./EmotionType.md) | Happy |  | 
| [EmotionType](./EmotionType.md) | Sad |  | 
| [EmotionType](./EmotionType.md) | Stunned |  | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [EmotionType](./EmotionType.md)> | Types | A registry of all `TinyLife.Emotions.EmotionType` instances from the game and mods | 
| [EmotionType](./EmotionType.md) | Uncomfortable |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [EmotionType](./EmotionType.md) | Register ( [`EmotionType`](./EmotionType.md) ) | Registers the given emotion type to the `TinyLife.Emotions.EmotionType.Types` registry | 


