# [Job](./Job.md)

Namespace: [TinyLife]() > [Goals]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Job.md)

## Summary
A job is a kind of work that a `TinyLife.Goals.Job.Person` can have.  The person's current job is accessible using `TinyLife.Objects.Person.Job`.  A job instance is constructed from its underlying `TinyLife.Goals.JobType`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Job ( [`JobType`](./JobType.md), [`Person`](./../Objects/Person.md) ) | Creates a new job from the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [JobType](./JobType.md) | Type | The underlying `TinyLife.Goals.JobType` that this job results from | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | CurrentHourlyPay | The amount of tiny bucks that this job pays per hour. This is based on `TinyLife.Goals.JobType.HourlyPay` and the current `TinyLife.Goals.Job.Level`. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Level | The current level that this job is at.  Note that the default level is 0, and the level goes up to a maximum of 9. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Performance | This job's current performance, ranging from 0 to 1, representing the percentage of work performance.  The default value is 0.5. | 
| [Person](./../Objects/Person.md) | Person | The `TinyLife.Goals.Job.Person` that currently has this job | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | AddLevel ( [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Adds (or removes) the given amount of levels to this job's `TinyLife.Goals.Job.Level`.  Note that the level value is automatically clamped between 0 and 9, inclusively. | 
| void | AddPerformance ( [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Adds (or removes) the given amount of performance to this job's `TinyLife.Goals.Job.Performance`.  If the total `TinyLife.Goals.Job.Performance` rolls over (below 0 or above 1), `TinyLife.Goals.Job.AddLevel(System.Int32)` is called and the performace is reset accordingly. | 
| void | Update ( [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) ) | Updates this job, changing the `TinyLife.Goals.Job.Performance` and `TinyLife.Goals.Job.Level` according to this job's person's current actions.  This is called in `TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate ( [`Person`](./../Objects/Person.md) ) |  | 


