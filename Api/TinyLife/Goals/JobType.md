# [JobType](./JobType.md)

Namespace: [TinyLife]() > [Goals]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./JobType.md)

## Summary
A job type is a singleton containing various kinds of data for a `TinyLife.Goals.Job` instance.  New jobs can be registered using `TinyLife.Goals.JobType.Register(TinyLife.Goals.JobType)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| JobType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Range`](./JobType.md)\<[`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)>, [`DayOfWeek`](https://docs.microsoft.com/en-us/dotnet/api/System.DayOfWeek)[] ) | Creates a new job type with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | HourlyPay | The amount of dollars that being at the job for an hour pays.  In `TinyLife.Actions.WorkAction`, this is automatically added to the household funds. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this job type | 
| [DayOfWeek](https://docs.microsoft.com/en-us/dotnet/api/System.DayOfWeek)[] | OffWorkDays | A set of `System.DayOfWeek` values which are days off of this job.  On `TinyLife.GameImpl.Weekday`s contained in this list, the `TinyLife.Goals.JobType.WorkHours` don't apply. | 
| [Range](./JobType.md)\<[Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> | WorkHours | A `System.Range` of hours that this job requires each day.  Note that the `MonoGame.Extended.Range`1.Min` value is inclusive, but the `MonoGame.Extended.Range`1.Max` value is exclusive. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Job](./Job.md) | Construct ( [`Person`](./../Objects/Person.md) ) | Creates a new `TinyLife.Goals.Job` from this type's information | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | GetDisplayName ( [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> ) | Returns the display name of this `TinyLife.Goals.JobType`, based on the given ``.  If no level is given, the job's regular name, without the level-based suffix, is returned. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsTimeToWork ( [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan)> ) | Returns whether the given time (or the game's current time) is in the bounds of `TinyLife.Goals.JobType.WorkHours` and outside of the bounds of `TinyLife.Goals.JobType.OffWorkDays`.  If this method returns true, `TinyLife.Actions.WorkAction` can be started. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | ToScheduleString (  ) | Returns a string representation of the schedule.  The string includes a line that states the `TinyLife.Goals.JobType.WorkHours` and a line that states the `TinyLife.Goals.JobType.OffWorkDays`. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [JobType](./JobType.md)> | Types | A registry of all `TinyLife.Goals.JobType` instances in the game and mods.  Register new jobs using `TinyLife.Goals.JobType.Register(TinyLife.Goals.JobType)`. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`JobType`](./JobType.md) ) | Registers the given job type to the `TinyLife.Goals.JobType.Types` registry | 


