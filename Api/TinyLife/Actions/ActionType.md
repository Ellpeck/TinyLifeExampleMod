# [ActionType](./ActionType.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

## Summary
Action types are blueprints for `TinyLife.Actions.Action` instances which can be registered using `TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)`.  An action type contains information about its action and can create an instance using `TinyLife.Actions.ActionType.TypeSettings.Construct`.

## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [TypeSettings](./ActionType.md) | Settings | The `TinyLife.Actions.ActionType.TypeSettings` for this action type, which actually contain this type's properties. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Action](./Action.md) | Construct ( [`ActionInfo`](./ActionInfo.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`ActionVariety`](./ActionVariety.md)> ) | Creates a new `TinyLife.Actions.Action` instance of this `TinyLife.Actions.ActionType`. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | GetDisplayName ( [`ActionInfo`](./ActionInfo.md) ) |  | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ActionType](./ActionType.md) | AskAboutDay |  | 
| [ActionType](./ActionType.md) | AskToLeave |  | 
| [ActionType](./ActionType.md) | BreakUp |  | 
| [ActionType](./ActionType.md) | CallOver |  | 
| [ActionType](./ActionType.md) | ChangeClothes |  | 
| [ActionType](./ActionType.md) | Chat |  | 
| [ActionType](./ActionType.md) | CleanDish |  | 
| [ActionType](./ActionType.md) | ComplimentLooks |  | 
| [ActionType](./ActionType.md) | ConfideIn |  | 
| [ActionType](./ActionType.md) | CookFood |  | 
| [ActionType](./ActionType.md) | Drive |  | 
| [ActionType](./ActionType.md) | Eat |  | 
| [ActionType](./ActionType.md) | Flirt |  | 
| [ActionType](./ActionType.md) | FoolAround |  | 
| [ActionType](./ActionType.md) | GaugeRelationship |  | 
| [ActionType](./ActionType.md) | GetIngredients |  | 
| [ActionType](./ActionType.md) | GetJob |  | 
| [ActionType](./ActionType.md) | GoHere |  | 
| [ActionType](./ActionType.md) | GoHome |  | 
| [ActionType](./ActionType.md) | HackSomeone |  | 
| [ActionType](./ActionType.md) | ImplyMotherIsCamel |  | 
| [ActionType](./ActionType.md) | Insult |  | 
| [ActionType](./ActionType.md) | MakeRisqueRemark |  | 
| [ActionType](./ActionType.md) | ModGame |  | 
| [ActionType](./ActionType.md) | MopPuddle |  | 
| [ActionType](./ActionType.md) | Paint |  | 
| [ActionType](./ActionType.md) | PassOut |  | 
| [ActionType](./ActionType.md) | PeeSelf |  | 
| [ActionType](./ActionType.md) | PickUp |  | 
| [ActionType](./ActionType.md) | PlayGames |  | 
| [ActionType](./ActionType.md) | PlayTrick |  | 
| [ActionType](./ActionType.md) | PracticeJokes |  | 
| [ActionType](./ActionType.md) | PracticeProgramming |  | 
| [ActionType](./ActionType.md) | PracticeSpeech |  | 
| [ActionType](./ActionType.md) | PrepareFood |  | 
| [ActionType](./ActionType.md) | PutAwayBook |  | 
| [ActionType](./ActionType.md) | PutDown |  | 
| [ActionType](./ActionType.md) | QuitJob |  | 
| [ActionType](./ActionType.md) | Read |  | 
| [ActionType](./ActionType.md) | Repair |  | 
| [ActionType](./ActionType.md) | SellPainting |  | 
| [ActionType](./ActionType.md) | Sit |  | 
| [ActionType](./ActionType.md) | SitToilet |  | 
| [ActionType](./ActionType.md) | Sleep |  | 
| [ActionType](./ActionType.md) | StartDating |  | 
| [ActionType](./ActionType.md) | Starve |  | 
| [ActionType](./ActionType.md) | TakeShower |  | 
| [ActionType](./ActionType.md) | Talk |  | 
| [ActionType](./ActionType.md) | TellComplexJoke |  | 
| [ActionType](./ActionType.md) | TellEngagingStory |  | 
| [ActionType](./ActionType.md) | TellFunnyStory |  | 
| [ActionType](./ActionType.md) | TellJoke |  | 
| [ActionType](./ActionType.md) | TellPeopleToLeaveRoom |  | 
| [ActionType](./ActionType.md) | TellStory |  | 
| [ActionType](./ActionType.md) | ThisIsInappropriate |  | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[ObjectCategory](./../Objects/ObjectCategory.md), [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1)\<[ActionType](./ActionType.md)>> | Types | A list of all available action types.  To register your own action types, use the `TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)` method. | 
| [ActionType](./ActionType.md) | VisitLot |  | 
| [ActionType](./ActionType.md) | WakeUp |  | 
| [ActionType](./ActionType.md) | Walk |  | 
| [ActionType](./ActionType.md) | WatchTv |  | 
| [ActionType](./ActionType.md) | Work |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [CanExecuteResult](./ActionType.md) | CanExecuteAll ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`CanExecuteDelegate`](./ActionType.md)[] ) |  | 
| [CanExecuteResult](./ActionType.md) | CanPlaceHeldItem ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines whether or not the item that is currently held by the given person can be placed in an object spot on the given object. | 
| [CanExecuteResult](./ActionType.md) | CanWorkAtComputer ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the action object (which is expected to be a computer) meets all of the criteria for working at it | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[ActionType](./ActionType.md)> | GetMatchingActions ( [`ObjectCategory`](./../Objects/ObjectCategory.md) ) | Returns a set of actions that match any the given `TinyLife.Objects.ObjectCategory` flag values.  No check occurs that determines whether or not the action is valid in any given circumstance, other than the category. | 
| [CanExecuteResult](./ActionType.md) | HasChair ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the given object is sat on a table or desk that has a chair. | 
| [CanExecuteResult](./ActionType.md) | IsComfortable ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the person is comfortable enough to execute an action.  A comfortable person is one that doesn't have the `TinyLife.Emotions.EmotionType.Uncomfortable` or `TinyLife.Emotions.EmotionType.Sad` emotions. | 
| [CanExecuteResult](./ActionType.md) | IsDislikedOrMean ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the action is executed manually, the given `TinyLife.Actions.ActionInfo`'s person has the `TinyLife.PersonalityType.Mean` personality type, or if the interaction partner has the `TinyLife.RelationshipType.Disliked` relationship type (or lower). | 
| [CanExecuteResult](./ActionType.md) | IsEmptyHanded ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the person is not holding an item. | 
| [CanExecuteResult](./ActionType.md) | IsFunctional ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method inteded to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the action object is functional or broken.  This method always returns `TinyLife.Actions.ActionType.CanExecuteResult.Valid` if the object is not breakable. | 
| [CanExecuteResult](./ActionType.md) | IsHoldingOrPlaceableOn ( [`ActionInfo`](./ActionInfo.md), [`ObjectCategory`](./../Objects/ObjectCategory.md), [`Predicate`](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1)\<[`Furniture`](./../Objects/Furniture.md)> ) | A helper method to check whether or not the person in the given `TinyLife.Actions.ActionInfo` is an item that matches the predicate (``) and the `TinyLife.Actions.ActionInfo.GetActionObject``1` is of the required type (``) or if the action object itself matches the predicate. | 
| [CanExecuteResult](./ActionType.md) | IsNotEmbarrassed ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the person is `TinyLife.Emotions.EmotionType.Embarrassed` or not | 
| [CanExecuteResult](./ActionType.md) | IsReadyForRomance ( [`ActionInfo`](./ActionInfo.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method intended to be used with `TinyLife.Actions.ActionType.CanExecuteDelegate` that determines if the `TinyLife.Actions.ActionInfo.Person` and their interaction partner are `TinyLife.GenealogyType.Unrelated` and whether the action is executed manually or their `TinyLife.Relationship.RomanceLevel` is higher than 0.  This method will also return `TinyLife.Actions.ActionType.CanExecuteResult.TooSad` if the person is currently feeling `TinyLife.Emotions.EmotionType.Sad`.  This method should be used for `TinyLife.Actions.SocialAction` actions that are romantic in nature. | 
| [ActionType](./ActionType.md) | Register ( [`TypeSettings`](./ActionType.md) ) |  | 


