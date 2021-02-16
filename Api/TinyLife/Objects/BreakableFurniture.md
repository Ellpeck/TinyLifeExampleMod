# [BreakableFurniture](./BreakableFurniture.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./BreakableFurniture.md), [IPricedObject](./../World/IPricedObject.md), [IUpdatingObject](./IUpdatingObject.md)

## Summary
Breakable furniture is `TinyLife.Objects.Furniture` that can be `TinyLife.Objects.BreakableFurniture.Broken` and then repaired.  An object of this class is automatically returned in `TinyLife.Objects.FurnitureType.Construct(System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,System.Nullable{System.Guid})` if no `TinyLife.Objects.FurnitureType.TypeSettings.ConstructedType` is set.

## Constructors

| Name | Summary | 
| --- | --- | 
| BreakableFurniture ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`FurnitureType`](./FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./BreakableFurniture.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Broken | A field that stores whether this furniture is currently broken | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | ActionUpdate ( [`Action`](./../Actions/Action.md), [`GameTime`](./BreakableFurniture.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) |  | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String)> | GetDescription (  ) |  | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 
| void | Update ( [`GameTime`](./BreakableFurniture.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) |  | 
| void | WearDown ( [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) ) | Causes this furniture to wear down, increasing the likelihood of it becoming `TinyLife.Objects.BreakableFurniture.Broken` and randomly breaking it | 


