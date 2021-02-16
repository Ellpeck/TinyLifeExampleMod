# [WallMode](./WallMode.md)
Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll


This enumeration defines the possible rendering types for `TinyLife.World.Wallpaper`.  By default, `TinyLife.World.WallMode.Full` is rendered, but an `TinyLife.World.Opening` can change the type to allow for windows, doors etc.

##	Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| 0 | Full | A wall mode that represents a wall that is rendered in full, without any holes in it | 
| 1 | SmallWindow | A wall mode that represents a wall with a small, rectanglular window in it | 
| 2 | Door | A wall mode that represents a wall with a door-shaped hole in it | 
| 3 | Roof | A wall mode that represents a wall used on the faces of a `TinyLife.World.Roof` that are straight | 
| 4 | RoofGable | A wall mode that represents a wall used on the faces of a `TinyLife.World.Roof` that are gabled | 
| 5 | RoofGableInverse | A wall mode that represents a wall used on the faces of a `TinyLife.World.Roof` that are gabled in the opposite direction as `TinyLife.World.WallMode.RoofGable` | 


