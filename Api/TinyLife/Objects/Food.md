# [Food](./Food.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Food.md), [IPricedObject](./../World/IPricedObject.md)


## Constructors

| Name | Summary | 
| --- | --- | 
| Food ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`FurnitureType`](./FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./Food.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | FoodLeft | The amount of food that this food item has left.  This is set to `TinyLife.Skills.FoodType.FoodAmount` by default | 
| [Quality](./../Skills/Quality.md) | Quality | The `TinyLife.Objects.Food.Quality` of this food item, defaults to `TinyLife.Skills.Quality.Average`.  Note that, by default, this property only differs if `TinyLife.Objects.FoodTypedItem.Creator` is set. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./Food.md), [`SpriteBatch`](./Food.md), [`Vector2`](./Food.md), [`Vector2`](./Food.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./Food.md)>, [`Direction2`](./Food.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) |  | 
| [Tooltip](./Food.md) | GetHoverInfo (  ) |  | 


