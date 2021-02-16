# [WallDisplay](./WallDisplay.md)
Namespace: [TinyLife]()

Assembly: Tiny Life.dll


The possible modes that a `TinyLife.World.Wall` and `TinyLife.World.Roof` can display in.  The ordering of this enumeration is based on how much of the walls (and roofs) can be seen.

##	Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| 0 | Roofs | A wall display that represents full walls and the roofs of buildings being displayed | 
| 1 | Up | A wall display that represents full walls, but no roofs, being displayed | 
| 2 | Auto | A wall display that represents the back walls of buildings being `TinyLife.WallDisplay.Up`, but the front wals being `TinyLife.WallDisplay.Down` | 
| 3 | Down | A wall display that represents only the lowest few pixels of each wall being displayed | 


