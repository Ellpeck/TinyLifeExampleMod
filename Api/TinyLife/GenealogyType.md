# [GenealogyType](./GenealogyType.md)
Namespace: [TinyLife]()

Assembly: Tiny Life.dll


An enumeration that represents the type that a `TinyLife.Relationship`'s genealogy can have.  Note that these typs are deliberately gender-neutral.

##	Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| 0 | Unrelated | A genealogy type that represents two unrelated people | 
| 1 | Parent | A genealogy type that represents a parent of a `TinyLife.GenealogyType.Child` | 
| 2 | Child | A genealogy type that represents a child of a `TinyLife.GenealogyType.Parent` | 
| 3 | Sibling | A genealogy type that represents a sibling | 
| 4 | Nibling | A genealogy type that represents a nibling (niece or nephew) of a `TinyLife.GenealogyType.Pibling` | 
| 5 | Pibling | A genealogy type that represents a pibling (aunt or uncle) or a `TinyLife.GenealogyType.Nibling` | 
| 6 | Grandparent | A genealogy type that represents a grandparent of a `TinyLife.GenealogyType.Grandchild` | 
| 7 | Grandchild | A genealogy type that represents a grandchild of a `TinyLife.GenealogyType.Grandparent` | 


