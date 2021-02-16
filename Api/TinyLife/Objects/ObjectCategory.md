# [ObjectCategory](./ObjectCategory.md)
Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll


An object category is a way to tell the `TinyLife.Actions.Action` and `TinyLife.Objects.AbstractSpot` system what type an object is.  An object can have any number of categories attached to it, since this is a `System.FlagsAttribute` enumeration.  Custom modded categories can be added and retrieved using `TinyLife.Objects.MapObject.GetModCategory(System.String)`.

##	Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| 0 | Nothing | An object category that reprsents an object without any properties | 
| 1 | Ground | An object category that represents the ground | 
| 2 | Chair | An object category that represents sittable surfaces | 
| 4 | Toilet | An object category that represents objects where one can use the toilet | 
| 8 | Bed | An object category that represents objects where one can sleep | 
| 16 | Fridge | An object category that represents objects where one can get food ingredients | 
| 32 | Shower | An object category that represents objects where one can shower | 
| 64 | Counter | An object category that represents objects where one can prepare food and place `TinyLife.Objects.ObjectCategory.CounterObject` objects | 
| 128 | Stove | An object category that represents objects where one can cook food | 
| 256 | SmallObject | An object category that represents objects that can sit on `TinyLife.Objects.ObjectCategory.Counter` and `TinyLife.Objects.ObjectCategory.Table` objects | 
| 512 | NonBuyable | An object category that represents objects that cannot be bought in the `TinyLife.Tools.FurnitureTool` | 
| 1024 | Table | An object category that represents objects where one can place `TinyLife.Objects.ObjectCategory.SmallObject` objects | 
| 2048 | Holdable | An object category that represents objects that can be held by a `TinyLife.Objects.Person` | 
| 4096 | DeskObject | An object category that represents objects that can be placed on desk-like tables | 
| 8192 | DisallowedOnGround | An object category that represents objects that cannot be placed on the ground, but only in object spots | 
| 16384 | Computer | An object category that represents computers | 
| 32768 | Sink | An object category that represents objects where one can clean dishes and wash hands | 
| 65536 | CounterObject | An object category that represents objects that can be placed on `TinyLife.Objects.ObjectCategory.Counter` objects | 
| 131072 | Cleanable | An object category that represents objects that can be cleaned in a `TinyLife.Objects.ObjectCategory.Sink` | 
| 262144 | People | An object category that all `TinyLife.Objects.Person` instances hae | 
| 524288 | Mailbox | An object category that represents mailboxes | 
| 1048576 | Wardrobe | An object category that represents objects where a `TinyLife.Objects.Person` can change | 
| 2097152 | NaturalGroundRequired | An object category that represents objects that can only be placed on natural ground, namely grass tiles | 
| 4194304 | Self | An object category that represents the object that contains it | 
| 8388608 | WallHanging | An object category that represents objects which need to be hung on `TinyLife.World.Wall` objects | 
| 16777216 | ForceGridPlacement | An object category that represents objects which cannot be placed off the grid using the ALT key in the `TinyLife.Tools.FurnitureTool` | 
| 33554432 | Easel | An object category that represents places where one can paint paintings | 
| 67108864 | Mirror | An object category that represents mirrors | 
| 134217728 | Bookshelf | An object category that represents things that books are stored in | 
| 268435456 | NonColliding | An object category that represents things that a `TinyLife.Objects.Person` does not collide with | 
| 536870912 | Gravestone | An object category that represents gravestones | 
| 1073741824 | NonSellable | An object category that represents things that cannot be solved or removed using `TinyLife.Tools.RemoveTool` | 
| 2147483648 | NonMovable | An object category that represents things that cannot be moved using `TinyLife.Tools.MoveTool` | 
| 4294967296 | Tree | An object category that represents trees | 
| 8589934592 | GentleCulling | An object category that represents objects that should be culled more gently (in a bigger radius). This property should be assigned to objects that are fairly large in display size. | 
| 17179869184 | Television | An object category that represents televisions | 


