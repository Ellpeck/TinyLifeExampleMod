# [Relationship](./Relationship.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
A relationship is a connection between two `TinyLife.Objects.Person` objects.  It should be noted that a relationship is not always the same between a person and the linked `TinyLife.Relationship.OtherPerson`.  What this means is that A can have a good relationship to B, but B can have a less good relationship to A.

## Constructors

| Name | Summary | 
| --- | --- | 
| Relationship ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) ) | Creates a new relationship to the given other person | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Dating | This value is set to true if this relationship is a romantic relationship | 
| [GenealogyType](./GenealogyType.md) | Genealogy | The `TinyLife.GenealogyType` of this relationship.  Note that the genealogy's value works in the following direction: "I am the [Genealogy] of [OtherPerson]".  Note that `TinyLife.Relationship.OtherPerson` will always have the `TinyLife.GenealogyType`'s `TinyLife.Utilities.Extensions.GetOpposite(TinyLife.GenealogyType)`. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | DisplayString | An (unlocalized) string that represents a written version of this relationship's status.  If `TinyLife.Relationship.Dating` is true, the string "Dating" will be returned. Otherwise, `TinyLife.Relationship.Type` is returned as a string. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | FriendLevel | The current amount of friendship points (out of `TinyLife.Relationship.Max`) that this relationship has.  This value is automatically clamped between -`TinyLife.Relationship.Max` and `TinyLife.Relationship.Max`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | FriendPercentage | The `TinyLife.Relationship.FriendLevel` of this relationship, divided by `TinyLife.Relationship.Max`, yielding a percentage between -1 and 1 of how good this friendship is | 
| [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) | OtherPerson | The `System.Guid` of the person that this relationship is linked to | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | RomanceLevel | The current amount of romance points (out of `TinyLife.Relationship.Max`) that this relationship has.  This value is automatically clamped between 0 and `TinyLife.Relationship.Max`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | RomancePercentage | The `TinyLife.Relationship.RomanceLevel` of this relationship, divided by `TinyLife.Relationship.Max`, yielding a percentage between 0 and 1 of how good this relationship's romance level is | 
| [RelationshipType](./RelationshipType.md) | Type | The `TinyLife.RelationshipType` that this relationship has, based on the current `TinyLife.Relationship.FriendLevel`. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Max | The maximum value that a relationship level can have | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | PassiveFriendReduction | The amount of points (out of `TinyLife.Relationship.Max`) that are removed from each relationship's `TinyLife.Relationship.FriendLevel` each update frame | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | PassiveRomanceReduction | The amount of points (out of `TinyLife.Relationship.Max`) that are removed from each relationship's `TinyLife.Relationship.RomanceLevel` each update frame | 


