# [Skill](./Skill.md)

Namespace: [TinyLife]() > [Skills]()

Assembly: Tiny Life.dll

## Summary
A skill is an ability that a `TinyLife.Objects.Person` can have which influences their behavior in some way.  Skill instances are created from their corresponding `TinyLife.Skills.SkillType`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Skill ( [`SkillType`](./SkillType.md) ) | Creates a new skill instance from the given `TinyLife.Skills.SkillType`. | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [SkillType](./SkillType.md) | Type | The underlying `TinyLife.Skills.SkillType` that this skill instance originates from | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Level | The current level of this skill. Note that this value never goes beyond `TinyLife.Skills.SkillType.MaxLevel`.  To modify this value, use `TinyLife.Skills.Skill.Gain(TinyLife.Objects.Person,System.Single)` or `TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | PointPercentage | The percentage of `TinyLife.Skills.Skill.PointsToNextLevel` out of the required `TinyLife.Skills.Skill.GetRequiredPointsToNextLevel`.  Obviously, this value goes between 0 and 1. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | PointsToNextLevel | The amount of skill points that are required until the next `TinyLife.Skills.Skill.Level` is reached.  To modify this value, use `TinyLife.Skills.Skill.Gain(TinyLife.Objects.Person,System.Single)` or `TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)`. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Gain ( [`Person`](./../Objects/Person.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Causes the given person to gain a certain amount of points of this skill.  Note that `TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)` is preferred to this method. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetRequiredPointsToNextLevel (  ) | Returns the amount of skill points that is required to reach the next level.  This value is depenedent on the current `TinyLife.Skills.Skill.Level`, meaning higher skill levels are harder to reach. | 


