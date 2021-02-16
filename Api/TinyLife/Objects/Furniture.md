# [Furniture](./Furniture.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Furniture.md), [IPricedObject](./../World/IPricedObject.md)

## Summary
A furniture is an instance of a `TinyLife.Objects.FurnitureType` which is placed in the world, or in a `TinyLife.Objects.Person`'s hand.  To register a custom furniture, use `TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Furniture ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`FurnitureType`](./FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./Furniture.md) ) | Creates a new furniture instance.  By default, this is done using `TinyLife.Objects.FurnitureType.Construct(System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,System.Nullable{System.Guid})`. | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[] | Colors | The indices of the colors that this furniture has.  Refer to `TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes` for the actual colors that these indices represent. | 
| [Direction2](./Furniture.md) | Rotation | The current rotation of this furniture.  Since furniture has a wide variety of looks, the specific value of the rotation doesn't necessarily have much practical meaning. | 
| [FurnitureType](./FurnitureType.md) | Type | The `TinyLife.Objects.FurnitureType` that this furniture has | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [RectangleF](./Furniture.md) | Area | A `MLEM.Misc.RectangleF` that represents the area that this furniture piece is currently taking up, based on its `TinyLife.Objects.FurnitureType.GetSize(MLEM.Misc.Direction2)` and its `TinyLife.Objects.MapObject.Position` | 
| [Furniture](./Furniture.md) | ParentFurniture | The `TinyLife.Objects.Furniture` that this furniture is currently latched on to.  If this value is non-null, `TinyLife.Objects.Furniture.ParentObjectSpot` returns the object spot that this furniture is in. | 
| [ObjectSpot](./ObjectSpot.md) | ParentObjectSpot | The `TinyLife.Objects.ObjectSpot` that this furniture is currently in.  If this value is non-null, `TinyLife.Objects.Furniture.ParentFurniture` returns the furniture that this object spot belongs to. | 
| [Vector2](./Furniture.md) | VisualPosition | The position (in world space) that this furniture is at.  This only differs from this object's `TinyLife.Objects.MapObject.Position` if the `TinyLife.Objects.Furniture.ParentObjectSpot`'s `TinyLife.Objects.AbstractSpot.YOffset` is non-zero. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [T](./Furniture.md) | AddChild ( [`FurnitureType`](./FurnitureType.md), [`Direction2`](./Furniture.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid)>, [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Vector2`](./Furniture.md)> ) | Adds a child to this furniture, setting its parent (`TinyLife.Objects.Furniture.SetParent(TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot)`) to this furniture. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | AddChild ( [`Furniture`](./Furniture.md), [`Direction2`](./Furniture.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Vector2`](./Furniture.md)> ) | Adds a child to this furniture, setting its parent (`TinyLife.Objects.Furniture.SetParent(TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot)`) to this furniture.  The object spot selected is the first available object spot. | 
| void | Draw ( [`GameTime`](./Furniture.md), [`SpriteBatch`](./Furniture.md), [`Vector2`](./Furniture.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./Furniture.md)> ) |  | 
| void | Draw ( [`GameTime`](./Furniture.md), [`SpriteBatch`](./Furniture.md), [`Vector2`](./Furniture.md), [`Vector2`](./Furniture.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./Furniture.md)>, [`Direction2`](./Furniture.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Draws this furniture in the world with the given settings.  This is a more generalized version of `TinyLife.Objects.Furniture.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color})` | 
| void | DrawUi ( [`GameTime`](./Furniture.md), [`SpriteBatch`](./Furniture.md), [`Element`](./Furniture.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[] ) | Draws this furniture in a ui context, rather than a world context.  Scale is determined based on the element that is passed. | 
| [ActionInfo](./../Actions/ActionInfo.md) | GetActionSpotInfo ( [`Person`](./Person.md), [`ActionSpot`](./ActionSpot.md), [`Direction2`](./Furniture.md) ) | Returns a `TinyLife.Actions.ActionInfo` that corresponds to the given `TinyLife.Objects.ActionSpot` and rotation | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetAiPriority ( [`Person`](./Person.md), [`ObjectCategory`](./ObjectCategory.md) ) |  | 
| [ObjectCategory](./ObjectCategory.md) | GetCategories ( [`Person`](./Person.md) ) |  | 
| [IEnumerable](./Furniture.md)\<[T](./Furniture.md)> | GetChildren (  ) | Returns a list of all of the children of this furniture.  Children are all furnitures in the world that have their `TinyLife.Objects.Furniture.ParentFurniture` set to this furniture instance. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String)> | GetDescription (  ) | Returns a set of lines that are displayed in build mode when this furniture is hovered over, either in the buy menu or in the `TinyLife.World.Household.FurnitureStorage`.  By default, an empty set is returned. | 
| [ValueTuple](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple-2)\<[ActionSpot](./ActionSpot.md), [Direction2](./Furniture.md)> | GetFreeActionSpot ( [`Person`](./Person.md), [`ObjectCategory`](./ObjectCategory.md) ) | Returns the first free action spot from `TinyLife.Objects.Furniture.GetFreeActionSpots(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)`. | 
| [ActionInfo](./../Actions/ActionInfo.md) | GetFreeActionSpotInfo ( [`Person`](./Person.md), [`ObjectCategory`](./ObjectCategory.md) ) | Returns the first free action spot from `TinyLife.Objects.Furniture.GetFreeActionSpot(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)`, but packed into an `TinyLife.Actions.ActionInfo`. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[ValueTuple](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple-2)\<[ActionSpot](./ActionSpot.md), [Direction2](./Furniture.md)>> | GetFreeActionSpots ( [`Person`](./Person.md), [`ObjectCategory`](./ObjectCategory.md) ) | Returns a list of `TinyLife.Objects.ActionSpot` instances that are part of this furniture, which are considered free.  Free, in this instance, is any spot that has the given category and is not currently occupied by another person. | 
| [ObjectSpot](./ObjectSpot.md) | GetFreeObjectSpot ( [`FurnitureType`](./FurnitureType.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Vector2`](./Furniture.md)> ) | Returns the first free `TinyLife.Objects.ObjectSpot` on this furniture.  Free, in this case, is any object spot that isn't already occupied by a different furniture. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Intersects ( [`RectangleF`](./Furniture.md) ) |  | 
| void | OnAdded (  ) |  | 
| void | OnRemoved (  ) |  | 
| [IEnumerable](./Furniture.md)\<[T](./Furniture.md)> | RemoveChildren ( [`Predicate`](./Furniture.md)\<[`T`](./Furniture.md)> ) | Removes all of the children from this furniture that match the given predicate.  Children are all furnitures in the world that have their `TinyLife.Objects.Furniture.ParentFurniture` set to this furniture instance. | 
| void | SetChild ( [`ObjectSpot`](./ObjectSpot.md), [`FurnitureType`](./FurnitureType.md), [`Direction2`](./Furniture.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid)> ) | Sets the child element in the given object spot to the given furniture.  If there are already children in the given object spot, those are removed prior to adding the new child. | 
| void | SetChild ( [`ObjectSpot`](./ObjectSpot.md), [`Furniture`](./Furniture.md), [`Direction2`](./Furniture.md) ) | Sets the child element in the given object spot to the given furniture.  If there are already children in the given object spot, those are removed prior to adding the new child. | 
| void | SetParent ( [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md) ) | Sets the parent of this furniture, changing its `TinyLife.Objects.MapObject.Position` and settings its `TinyLife.Objects.Furniture.ParentObjectSpot` value. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) |  | 


