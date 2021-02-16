# [Action](./Action.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Action.md)

## Summary
An action is something that a `TinyLife.Objects.Person` does.  An action is always derived from an underlying `TinyLife.Actions.ActionType` that contains various action settings.  Actions can be queued up for a person (`TinyLife.Objects.Person.ActionQueue`) or currently active (`TinyLife.Objects.Person.CurrentActions`).  To create a more complex action, it is best to extend `TinyLife.Actions.MultiAction`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Action ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) | Creates a new action from the given `TinyLife.Actions.ActionType` | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ActionInfo](./ActionInfo.md) | Info | The `TinyLife.Actions.ActionInfo` for this action that contains the clicked (or otherwise targeted) objects and more | 
| [ActionType](./ActionType.md) | Type | The `TinyLife.Actions.ActionType` that this action instance derives from | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) | ElapsedTime | The amount of in-game time that has elapsed since this action has started | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsCurrent | Returns true if this action instance is currently active.  This is a shorthand for a `TinyLife.Objects.Person.CurrentActions` containment check. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsUnderlying | Stores whether this action is an underlying action of either a `TinyLife.Actions.MultiAction` or a `TinyLife.Actions.UnderlyingAction` | 
| [Map](./../World/Map.md) | Map | The `TinyLife.Actions.Action.Map` that this action occurs on | 
| [Person](./../Objects/Person.md) | Person | The `TinyLife.Actions.Action.Person` that this action is being executed by | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | StartedAutomatically | If this value is true, this action was started using `TinyLife.Objects.PersonAi` or through another action rather than by the player | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[ActionVariety](./ActionVariety.md)> | Variety | The `TinyLife.Actions.ActionVariety` that this action was initialized with.  If this is null, then the underlying `TinyLife.Actions.ActionType` has no varieties. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanCancel ( [`Action`](./Action.md) ) | Returns whether or not this action can be canceled by the given outside source.  Note that the outside source can be null, and if it is, it means that the player canceled the action manually.  By default, actions can only be canceled if the `` is null. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanMultitask ( [`Action`](./Action.md) ) | Return true on this method if this action can be multi-tasked along with the passed `TinyLife.Actions.Action`.  To actually check this property, `TinyLife.Actions.Action.CanMultitask(TinyLife.Actions.Action,TinyLife.Actions.Action)` should be used as it compares both objects.  A multi-tasking is an action that `TinyLife.Actions.Action.IsCurrent` along with another action.  By default, multi-tasking is disallowed for any action. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CausesExtremelyFastSpeed (  ) | Returns true if this action, while it `TinyLife.Actions.Action.IsCurrent`, should cause the `TinyLife.GameSpeed.ExtremelyFast` speed to be available.  By default, this method returns false. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | GetDisplayName (  ) | Returns a localized string that explains this action in short.  By default, this method returns `TinyLife.Actions.ActionType.GetDisplayName(TinyLife.Actions.ActionInfo)`. | 
| [MapObject](./../Objects/MapObject.md) | GetIconObject (  ) | Returns the map object that is displayed in the action queue in the top left of the screen.  Note that this value is ignored if this action's type has a `TinyLife.Actions.ActionType.TypeSettings.Texture`.  By default, the `TinyLife.Actions.ActionInfo.GetActionObject``1` is returned. | 
| [Action](./Action.md) | GetNextAction ( [`CompletionType`](./Action.md) ) |  | 
| void | Initialize (  ) | This method is called when the action is first started by a `TinyLife.Actions.Action.Person`.  Note that it is not called when the action gets added to the `TinyLife.Objects.Person.ActionQueue`, but when it is moved to `TinyLife.Objects.Person.CurrentActions`. | 
| [CompletionType](./Action.md) | IsCompleted (  ) | This method is called every update frame by a `TinyLife.Actions.Action.Person` if this action `TinyLife.Actions.Action.IsCurrent` to check if it should be stopped.  If this returns a result other than `TinyLife.Actions.Action.CompletionType.Completed`, `TinyLife.Actions.Action.OnCompleted(TinyLife.Actions.Action.CompletionType)` will be called and the action is stopped.  By default, only `TinyLife.Actions.Action.ForceFail` modifies the completion type, otherwise `TinyLife.Actions.Action.CompletionType.Active` is returned. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsFullyInProgress (  ) | Returns whether this action is currently "properly" in progress.  This is used by `TinyLife.Actions.MultiAction` and `TinyLife.Actions.SocialAction` and returns true only once the first actions are completed or the conversation has started, respectively.  By default, this method returns true if `TinyLife.Actions.Action.GetInProgressTime` is greater than `System.TimeSpan.Zero`. | 
| void | OnCompleted ( [`CompletionType`](./Action.md) ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | TryForceFail ( [`CanExecuteResult`](./Action.md) ) |  | 
| void | Update ( [`GameTime`](./Action.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | This method is called every update frame if this action `TinyLife.Actions.Action.IsCurrent`.  By default, only the `TinyLife.Actions.Action.ElapsedTime` is modified in this method and `TinyLife.Objects.MapObject.ActionUpdate(TinyLife.Actions.Action,Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed,System.Boolean)` is called. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate ( [`Person`](./../Objects/Person.md) ) | Validates this action's data.  This is called when a map is loaded from disk.  When returning false on this method, the action is removed from the `TinyLife.Actions.Action.Person`. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanMultitask ( [`Action`](./Action.md), [`Action`](./Action.md) ) | A utility method that can be used whether the two `TinyLife.Actions.Action` instances can currently be invoked together.  Internally, this checks if both actions return true on `TinyLife.Actions.Action.CanMultitask(TinyLife.Actions.Action)`. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Furniture](./../Objects/Furniture.md)> | FindAllFreeFurniture ( [`Person`](./../Objects/Person.md), [`ObjectCategory`](./../Objects/ObjectCategory.md), [`FurnitureType`](./../Objects/FurnitureType.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Vector2`](./Action.md)>, [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method to find a set of all `TinyLife.Objects.Furniture` instances that are currently valid for interaction with the passed `TinyLife.Actions.Action.Person` | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Person](./../Objects/Person.md)> | FindAllFreePeople ( [`ActionType`](./ActionType.md), [`Person`](./../Objects/Person.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Vector2`](./Action.md)>, [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | A helper method to find a set of all `TinyLife.Actions.Action.Person` instances that are currently valid for interaction with the passed `TinyLife.Actions.Action.Person` | 
| [ActionInfo](./ActionInfo.md) | FindFreeFurniture ( [`Person`](./../Objects/Person.md), [`ObjectCategory`](./../Objects/ObjectCategory.md), [`FurnitureType`](./../Objects/FurnitureType.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Vector2`](./Action.md)>, [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method to find the best `TinyLife.Objects.Furniture` instance to interact with based on the given data.  Note that this method always returns a `TinyLife.Actions.ActionInfo` related to the first result from `TinyLife.Actions.Action.FindAllFreeFurniture(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory,TinyLife.Objects.FurnitureType,System.Boolean,System.Nullable{Microsoft.Xna.Framework.Vector2},System.Int32,System.Boolean)`. | 
| [Furniture](./../Objects/Furniture.md) | GetChair ( [`Furniture`](./../Objects/Furniture.md) ) | A helper method that returns a `TinyLife.Objects.Furniture` with the `TinyLife.Objects.ObjectCategory.Chair` category that is closest to the given object which is on a desk or table.  The furniture returned is the one that the person should `TinyLife.Actions.Action.Sit(TinyLife.Objects.Furniture,TinyLife.GameSpeed)` on when interacting with the passed ``. | 


