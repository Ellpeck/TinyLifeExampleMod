# [MapObject](./MapObject.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./MapObject.md)

## Summary
An instance of this class represents an object that can be, or is, part of a `TinyLife.Objects.MapObject.Map`.  If this object's `TinyLife.Objects.MapObject.Position` is set to -1, -1, that is usually an indicator that the object is currently not in the world.

## Constructors

| Name | Summary | 
| --- | --- | 
| MapObject ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`Map`](./../World/Map.md), [`Vector2`](./MapObject.md) ) | Creates a new map object with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) | Id | The `System.Guid` of this object instance | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Lot](./../World/Lot.md) | CurrentLot | A property that returns the `TinyLife.Objects.MapObject.CurrentLot` that this object is currently on | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsInWorld | A property that returns true if this object is currently present on a `TinyLife.Objects.MapObject.Map` | 
| [Map](./../World/Map.md) | Map | The map that this object is currently on.  If this is null, the object is not currently on a map. | 
| [Vector2](./MapObject.md) | Position | The position on the `TinyLife.Objects.MapObject.Map` of this object.  If this is set to -1, -1, that is usually an indicator that the object is currently not in the world. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | ActionUpdate ( [`Action`](./../Actions/Action.md), [`GameTime`](./MapObject.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | This method is called when an `TinyLife.Actions.Action` that this object is involved in updates, which is every `Microsoft.Xna.Framework.Game.Update(Microsoft.Xna.Framework.GameTime)` frame.  This object counts as involved in the action if its `TinyLife.Actions.ActionInfo`'s `TinyLife.Actions.ActionInfo.GetInvolvedObjects``1(TinyLife.Objects.ObjectCategory)` includes this object | 
| void | Draw ( [`GameTime`](./MapObject.md), [`SpriteBatch`](./MapObject.md), [`Vector2`](./MapObject.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./MapObject.md)> ) | Draws this object on the current `TinyLife.Objects.MapObject.Map`, at the current `TinyLife.Objects.MapObject.Position`. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetAiPriority ( [`Person`](./Person.md), [`ObjectCategory`](./ObjectCategory.md) ) | Returns an integer that represents a priority for the `TinyLife.Objects.PersonAi`'s interaction with this object.  A higher priority means that this object will be picked over other objects (with lower priority).  The default return value is 0, meaning that no special priority is assigned to this object.  For any `TinyLife.Objects.Furniture` with the `TinyLife.Objects.ObjectCategory.Bed` category that is the person's `TinyLife.Objects.Person.LastBedSleptIn`, 10 is returned. | 
| [ObjectCategory](./ObjectCategory.md) | GetCategories ( [`Person`](./Person.md) ) | Returns a set of `TinyLife.Objects.ObjectCategory` flags that this object has, based on the given `TinyLife.Objects.Person`. | 
| [Tooltip](./MapObject.md) | GetHoverInfo (  ) | Returns a `MLEM.Ui.Elements.Tooltip` object that is displayed whenever the mouse is hovered over this object in the world.  By default, this method returns null, which will cause no tooltip to be displayed. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | HasCategory ( [`Person`](./Person.md), [`ObjectCategory`](./ObjectCategory.md) ) | A shorthand that checks whether `TinyLife.Objects.MapObject.GetCategories(TinyLife.Objects.Person)` overlaps with the given `` flags | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Intersects ( [`RectangleF`](./MapObject.md) ) | Returns whether this map object intersects with the given rectangle.  This is used for `TinyLife.World.Map.GetObjects``1(MLEM.Misc.RectangleF)` | 
| void | OnActionCompleted ( [`Action`](./../Actions/Action.md), [`CompletionType`](./MapObject.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) |  | 
| void | OnAdded (  ) | This method is called when this object is added to a `TinyLife.Objects.MapObject.Map`.  By default, it does nothing. | 
| void | OnRemoved (  ) | This method is called when this object is removed from a `TinyLife.Objects.MapObject.Map`.  By default, it does nothing. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | SetMapAndValidate ( [`Map`](./../World/Map.md) ) | This method is the same as `TinyLife.Objects.MapObject.Validate`, but it also sets the `TinyLife.Objects.MapObject.Map`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) | This method is called when this object is loaded from disk.  Returning false on this method causes the object to be removed from the map.  By default, this method does nothing. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ObjectCategory](./MapObject.md)[] | Categories | A list of all of the `TinyLife.Objects.ObjectCategory` flags that exist | 
| [Direction2](./MapObject.md)[] | PersonRotationOrder | The order of `MLEM.Misc.Direction2` that the texture atlas for `TinyLife.Objects.Person` has for its textures, from left to right | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [ObjectCategory](./ObjectCategory.md) | GetModCategory ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Adds and returns a custom `TinyLife.Objects.ObjectCategory` with the given name.  Note that the returned category is not `System.Enum.IsDefined(System.Type,System.Object)`, and thus, does not have a name.  The returned category is guaranteed to be unique and mapped to the given name. Additionally, it can be used in combined flags, as it is not a combined flag itself. | 


