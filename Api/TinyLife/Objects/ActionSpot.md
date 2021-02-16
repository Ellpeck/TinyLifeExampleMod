# [ActionSpot](./ActionSpot.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

## Summary
An action spot is a `TinyLife.Objects.AbstractSpot` extension that is used by `TinyLife.Objects.Furniture` to declare a location that a `TinyLife.Objects.Person` can interact with the furniture at

## Constructors

| Name | Summary | 
| --- | --- | 
| ActionSpot ( [`Vector2`](./ActionSpot.md), [`Direction2`](./ActionSpot.md)[] ) | Creates a new action spot with the given settings | 
| ActionSpot ( [`Vector2`](./ActionSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Direction2`](./ActionSpot.md)[] ) | Creates a new action spot with the given settings | 
| ActionSpot ( [`Vector2`](./ActionSpot.md), [`Vector2`](./ActionSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Direction2`](./ActionSpot.md)[] ) | Creates a new action spot with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[ObjectCategory](./ObjectCategory.md)> | CategoryRestriction | The categories that this `TinyLife.Objects.ActionSpot` is restricted to.  This is used by things like `TinyLife.Objects.FurnitureType.ModernBed` to declare separate spots for sitting on and sleeping on.  By default, this is set to null. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | DrawLayer | The layer that a person slotted into this action spot using `TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})` is drawn on.  By default, this is set to 0, meaning it will be drawn on top of the first layer of this furniture. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Direction2](./ActionSpot.md)> | GetFreeDirections ( [`Furniture`](./Furniture.md), [`Person`](./Person.md) ) | Returns a set of `MLEM.Misc.Direction2` values that this spot can be accessed from.  Valid directions will have an empty space that a `TinyLife.Objects.Person` can stand in, but not necessarily walk to.  The returned value is used by `TinyLife.Objects.Furniture.GetFreeActionSpots(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)` and `TinyLife.Objects.Furniture.GetFreeActionSpotInfo(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)` to find a location adjacent to this action spot that a `TinyLife.Objects.Person` can walk to. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Person](./Person.md)> | GetOccupants ( [`Furniture`](./Furniture.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Returns a set of the `TinyLife.Objects.Person` instances that are currently occupying this action spot.  Note that an action spot is also marked as occupied if the person is currently on their way to it. | 


