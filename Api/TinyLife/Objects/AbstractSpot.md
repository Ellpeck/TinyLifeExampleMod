# [AbstractSpot](./AbstractSpot.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

## Summary
An `TinyLife.Objects.AbstractSpot` is a base class for `TinyLife.Objects.ObjectSpot` and `TinyLife.Objects.ActionSpot`.

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Group | The groups that this spot has, which is interpreted as a bit flag.  Two action spots with overlapping groups ((g1 AND g2) != 0) cannot both be occupied by two different people.  This is used by things lke `TinyLife.Objects.FurnitureType.ModernBed` to stop people from sitting on a side there someone is already sleeping.  By default, this is set to 0, meaning there is no group set. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | YOffset | The offset on the visual y axis that the `TinyLife.Objects.Furniture` or `TinyLife.Objects.Person` slotted into this spot should render with | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | DoGroupsOverlap ( [`AbstractSpot`](./AbstractSpot.md) ) | Returns whether the passed `TinyLife.Objects.AbstractSpot`'s `TinyLife.Objects.AbstractSpot.Group` and this spot's Group overlap.  Two overlapping groups are groups for which (g1 AND g2) != 0. | 
| [Vector2](./AbstractSpot.md) | GetLocation ( [`Furniture`](./Furniture.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Returns the location that this spot has in world space, based on the given `TinyLife.Objects.Furniture` and its position and rotation. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Direction2](./AbstractSpot.md)> | GetValidDirections ( [`Direction2`](./AbstractSpot.md) ) | Returns the `TinyLife.Objects.AbstractSpot.ValidDirections` of this spot, but rotated by the given `MLEM.Misc.Direction2`. | 


