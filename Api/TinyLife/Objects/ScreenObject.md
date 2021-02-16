# [ScreenObject](./ScreenObject.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./ScreenObject.md), [IPricedObject](./../World/IPricedObject.md), [IUpdatingObject](./IUpdatingObject.md)


## Constructors

| Name | Summary | 
| --- | --- | 
| ScreenObject ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`FurnitureType`](./FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./ScreenObject.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | ScreenContent | A string representing the image that is displayed on this object's screen.  This field's value will have "Screen" prepended to it and all furniture `MLEM.Data.DataTextureAtlas` instances that are registered will be searched for the image.  This value resets every `TinyLife.Objects.ScreenObject.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)` call, so you have to set it perpetually. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./ScreenObject.md), [`SpriteBatch`](./ScreenObject.md), [`Vector2`](./ScreenObject.md), [`Vector2`](./ScreenObject.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./ScreenObject.md)>, [`Direction2`](./ScreenObject.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) |  | 
| void | Update ( [`GameTime`](./ScreenObject.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) |  | 


