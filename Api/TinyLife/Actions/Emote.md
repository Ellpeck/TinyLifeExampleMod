# [Emote](./Emote.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

## Summary
An emote is a graphic that can be displayed in a bubble over a `TinyLife.Objects.Person`, usually as part of a conversation.

## Constructors

| Name | Summary | 
| --- | --- | 
| Emote ( [`TextureRegion`](./Emote.md), [`EmoteCategory`](./EmoteCategory.md) ) | Initializes a new emote with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [EmoteCategory](./EmoteCategory.md) | Categories | A combined `TinyLife.Actions.EmoteCategory` flag that determines the categories that this emote belongs to | 
| [TextureRegion](./Emote.md) | Texture | The texture that is displayed for this emote | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [EmoteCategory](./Emote.md)[] | AllCategories | A set of all valid `TinyLife.Actions.EmoteCategory` values | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Emote](./Emote.md)> | GetEmotes ( [`EmoteCategory`](./EmoteCategory.md) ) | Returns a set of all of the emotes in the given combined category flag | 
| [Emote](./Emote.md) | GetRandomEmote ( [`EmoteCategory`](./EmoteCategory.md) ) | Returns a random emote from a combined flag of possible categories | 
| void | Register ( [`Emote`](./Emote.md) ) | Registers a new `TinyLife.Actions.Emote` with the given settings | 


