# [Gravestone](./Gravestone.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Gravestone.md), [IPricedObject](./../World/IPricedObject.md)


## Constructors

| Name | Summary | 
| --- | --- | 
| Gravestone ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`FurnitureType`](./FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./Gravestone.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [DeathReason](./Gravestone.md) | Reason | The `TinyLife.Objects.Person.DeathReason` for this gravestone's `TinyLife.Objects.Gravestone.DeadPerson`'s death | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Person](./Person.md) | DeadPerson | The `TinyLife.Objects.Person` that is "stored" in this gravestone.  Note that the actual dead person is stored in `TinyLife.World.Map.GetDeadPerson(System.Guid)`. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Tooltip](./Gravestone.md) | GetHoverInfo (  ) |  | 


