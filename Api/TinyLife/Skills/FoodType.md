# [FoodType](./FoodType.md)

Namespace: [TinyLife]() > [Skills]()

Assembly: Tiny Life.dll

## Summary
A food type is a type of dish that can be cooked using `TinyLife.Actions.ActionType.GetIngredients`.  Food types store information such as their name and texture, but also the cooking level that is required to make them.  Food types are registered using `TinyLife.Skills.FoodType.Register(TinyLife.Skills.FoodType)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| FoodType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Creates a new food type with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | FoodAmount | The amount of food points that this food gives.  This is passed to `TinyLife.Objects.Food.FoodLeft` when a dish is created.  For reference, the mac and cheese dish has a food amount of 100. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | This food type's name | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | NeedsCooking | Whether or not this food item needs to be cooked on a stove to be created.  If this value is false, the food will instantly go from being on a cutting board to being finished. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Price | The price that creating this food type has | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | RequiredCookingLevel | The level of the `TinyLife.Skills.SkillType.Cooking` skill that is required to prepare this dish | 
| [TextureRegion](./FoodType.md) | Texture | This food type's texture region.  The texture is loaded from the `TinyLife.Mods.Mod.GetCustomFurnitureTextures` as "Food`TinyLife.Skills.FoodType.Name`"  Since the plate will automatically be rendered below this food type, the texture only needs to contain the dish itself. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | DisplayName | This food type's `TinyLife.Skills.FoodType.Name`, but localized using `TinyLife.LnCategory.Food` | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [FoodType](./FoodType.md)> | Types | All of the `TinyLife.Skills.FoodType` instances that are registered by the game and mods | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`FoodType`](./FoodType.md) ) | Registers a new `TinyLife.Skills.FoodType` with the given settings | 


