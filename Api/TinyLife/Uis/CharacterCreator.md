# [CharacterCreator](./CharacterCreator.md)

Namespace: [TinyLife]() > [Uis]()

Assembly: Tiny Life.dll

## Summary
The character creator is displayed when a person (or household) is being edited in terms of their `TinyLife.Objects.Clothes` and `TinyLife.PersonalityType`s.

## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanSwitchPeople (  ) | Returns whether or not this character creator instance currently allows switching the selected character.  The return value is based on the selected person's `TinyLife.Objects.Person.FullName` and `TinyLife.Objects.Person.PersonalityTypes`. | 


## Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [CharacterCreator](./CharacterCreator.md) | Active | The currently displayed `TinyLife.Uis.CharacterCreator` instance, or null if the character editor is closed | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Person](./../Objects/Person.md) | CreatePerson ( [`Map`](./../World/Map.md), [`Household`](./../World/Household.md) ) | Creates a new `TinyLife.Objects.Person` instance on the given map with the given lot.  The person is placed at the top left corner of the lot.  A few settings, like their animation and portrait, are additionally set up. | 
| void | Open ( [`Person`](./../Objects/Person.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Opens a new `TinyLife.Uis.CharacterCreator` for the given person (and their household). | 


