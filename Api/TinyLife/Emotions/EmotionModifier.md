# [EmotionModifier](./EmotionModifier.md)

Namespace: [TinyLife]() > [Emotions]()

Assembly: Tiny Life.dll

## Summary
An emotion modifier stores information about a `TinyLife.Objects.Person`'s current or past actions or events that influenced their `TinyLife.Objects.Person.Emotion` in some way.  Each emotion modifier contributes to the person's emotion, and the emotion modifier with the highest combined `TinyLife.Emotions.EmotionModifier.Instance.Amount` determines the person's `TinyLife.Objects.Person.Emotion`.  Emotion modifiers can be applied automatically using `TinyLife.Emotions.EmotionModifier.Condition` or manually using `TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| EmotionModifier ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`TextureRegion`](./EmotionModifier.md), [`EmotionType`](./EmotionType.md), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[`Person`](./../Objects/Person.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> ) | Creates a new emotion modifier with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[Person](./../Objects/Person.md), [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> | Condition | An (optional) condition that has to be met for this emotion modifier to be applied to a person.  If this value is non-null, and the value returned by this function is greater than zero, this emotion modifier will be applied to a `TinyLife.Objects.Person` with the `TinyLife.Emotions.EmotionModifier.Instance.Amount` set to the return value.  If this value is not set, the emotion modifier has to be applied manually using `TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)`. | 
| [EmotionType](./EmotionType.md) | Emotion | The `TinyLife.Emotions.EmotionType` that this emotion modifier causes (if the `TinyLife.Emotions.EmotionModifier.Instance.Amount` is high enough) | 
| [TextureRegion](./EmotionModifier.md) | Icon | This emotion modifier's icon which will be displayed in the emotions menu | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | This emotion modifier's name | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [EmotionModifier](./EmotionModifier.md) | Asleep |  | 
| [EmotionModifier](./EmotionModifier.md) | BadCreation |  | 
| [EmotionModifier](./EmotionModifier.md) | BadFood |  | 
| [EmotionModifier](./EmotionModifier.md) | BoringWork |  | 
| [EmotionModifier](./EmotionModifier.md) | BrokenUpWith |  | 
| [EmotionModifier](./EmotionModifier.md) | CaughtBeingInappropriate |  | 
| [EmotionModifier](./EmotionModifier.md) | Demoted |  | 
| [EmotionModifier](./EmotionModifier.md) | DirtyConversationPartner |  | 
| [EmotionModifier](./EmotionModifier.md) | DirtyDishes |  | 
| [EmotionModifier](./EmotionModifier.md) | FailedJoke |  | 
| [EmotionModifier](./EmotionModifier.md) | FailedRomance |  | 
| [EmotionModifier](./EmotionModifier.md) | FinishedMod |  | 
| [EmotionModifier](./EmotionModifier.md) | Fired |  | 
| [EmotionModifier](./EmotionModifier.md) | FriendDied |  | 
| [EmotionModifier](./EmotionModifier.md) | FunFoolingAround |  | 
| [EmotionModifier](./EmotionModifier.md) | GoodFood |  | 
| [EmotionModifier](./EmotionModifier.md) | HackingFail |  | 
| [EmotionModifier](./EmotionModifier.md) | Jobless |  | 
| [EmotionModifier](./EmotionModifier.md) | LovelyInteraction |  | 
| [EmotionModifier](./EmotionModifier.md) | MeanConversationPartner |  | 
| [EmotionModifier](./EmotionModifier.md) | NeedsToilet |  | 
| [EmotionModifier](./EmotionModifier.md) | NegativeGauge |  | 
| [EmotionModifier](./EmotionModifier.md) | NicelyDecorated |  | 
| [EmotionModifier](./EmotionModifier.md) | NoPromotion |  | 
| [EmotionModifier](./EmotionModifier.md) | NotEnoughCreative |  | 
| [EmotionModifier](./EmotionModifier.md) | PassedOut |  | 
| [EmotionModifier](./EmotionModifier.md) | PeedSelf |  | 
| [EmotionModifier](./EmotionModifier.md) | PerfectCreation |  | 
| [EmotionModifier](./EmotionModifier.md) | PleasantInteraction |  | 
| [EmotionModifier](./EmotionModifier.md) | PositiveGauge |  | 
| [EmotionModifier](./EmotionModifier.md) | Promoted |  | 
| [EmotionModifier](./EmotionModifier.md) | ReadBook |  | 
| [EmotionModifier](./EmotionModifier.md) | RepairFail |  | 
| [EmotionModifier](./EmotionModifier.md) | SawSomethingPersonal |  | 
| [EmotionModifier](./EmotionModifier.md) | SleptOutside |  | 
| [EmotionModifier](./EmotionModifier.md) | StartedDating |  | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [EmotionModifier](./EmotionModifier.md)> | Types | A registry that contains all `TinyLife.Emotions.EmotionModifier` instances from the game and mods | 
| [EmotionModifier](./EmotionModifier.md) | UglySurroundings |  | 
| [EmotionModifier](./EmotionModifier.md) | VeryBored |  | 
| [EmotionModifier](./EmotionModifier.md) | VeryDirty |  | 
| [EmotionModifier](./EmotionModifier.md) | VeryHungry |  | 
| [EmotionModifier](./EmotionModifier.md) | VeryLonely |  | 
| [EmotionModifier](./EmotionModifier.md) | VeryTired |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [EmotionModifier](./EmotionModifier.md) | Register ( [`EmotionModifier`](./EmotionModifier.md) ) | Registers the given emotion type into the `TinyLife.Emotions.EmotionModifier.Types` registry | 


