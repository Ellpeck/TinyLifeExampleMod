# [Quality](./Quality.md)
Namespace: [TinyLife]() > [Skills]()

Assembly: Tiny Life.dll


An enumeration for qualitites of objects like `TinyLife.Objects.FurnitureType.CustomPainting`.  To receive a random quality based on a person's `TinyLife.Skills.Skill` level, use `TinyLife.Skills.SkillType.GetRandomQuality(TinyLife.Objects.Person,System.Random,System.Boolean,System.Boolean)`.

##	Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| 0 | Terrible | A quality for objects that are terrible | 
| 1 | Average | A quality for objects that have an average quality | 
| 2 | Good | A quality for objects that have good quality | 
| 3 | Great | A quality for objects that have great quality | 
| 4 | Perfect | A quality for objects that are considered perfect | 
| 5 | Masterpiece | A quality for objects that are masterpieces.  When an object with this quality is created, a `TinyLife.Uis.Notifications` notification should be displayed to the user | 


