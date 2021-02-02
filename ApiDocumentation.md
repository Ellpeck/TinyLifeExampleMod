<a name='assembly'></a>
# Tiny Life

## Contents

- [AbstractSpot](#T-TinyLife-Objects-AbstractSpot 'TinyLife.Objects.AbstractSpot')
  - [#ctor(offset,visualOffset,yOffset,validDirections)](#M-TinyLife-Objects-AbstractSpot-#ctor-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Single,MLEM-Misc-Direction2[]- 'TinyLife.Objects.AbstractSpot.#ctor(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Single,MLEM.Misc.Direction2[])')
  - [Offset](#F-TinyLife-Objects-AbstractSpot-Offset 'TinyLife.Objects.AbstractSpot.Offset')
  - [ValidDirections](#F-TinyLife-Objects-AbstractSpot-ValidDirections 'TinyLife.Objects.AbstractSpot.ValidDirections')
  - [VisualOffset](#F-TinyLife-Objects-AbstractSpot-VisualOffset 'TinyLife.Objects.AbstractSpot.VisualOffset')
  - [YOffset](#F-TinyLife-Objects-AbstractSpot-YOffset 'TinyLife.Objects.AbstractSpot.YOffset')
  - [GetLocation(furniture,visual)](#M-TinyLife-Objects-AbstractSpot-GetLocation-TinyLife-Objects-Furniture,System-Boolean- 'TinyLife.Objects.AbstractSpot.GetLocation(TinyLife.Objects.Furniture,System.Boolean)')
  - [GetValidDirections(rotation)](#M-TinyLife-Objects-AbstractSpot-GetValidDirections-MLEM-Misc-Direction2- 'TinyLife.Objects.AbstractSpot.GetValidDirections(MLEM.Misc.Direction2)')
- [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action')
  - [#ctor(type,info)](#M-TinyLife-Actions-Action-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.Action.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [ForceFail](#F-TinyLife-Actions-Action-ForceFail 'TinyLife.Actions.Action.ForceFail')
  - [Info](#F-TinyLife-Actions-Action-Info 'TinyLife.Actions.Action.Info')
  - [Random](#F-TinyLife-Actions-Action-Random 'TinyLife.Actions.Action.Random')
  - [Type](#F-TinyLife-Actions-Action-Type 'TinyLife.Actions.Action.Type')
  - [ElapsedTime](#P-TinyLife-Actions-Action-ElapsedTime 'TinyLife.Actions.Action.ElapsedTime')
  - [IsCurrent](#P-TinyLife-Actions-Action-IsCurrent 'TinyLife.Actions.Action.IsCurrent')
  - [Map](#P-TinyLife-Actions-Action-Map 'TinyLife.Actions.Action.Map')
  - [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person')
  - [StartedAutomatically](#P-TinyLife-Actions-Action-StartedAutomatically 'TinyLife.Actions.Action.StartedAutomatically')
  - [Variety](#P-TinyLife-Actions-Action-Variety 'TinyLife.Actions.Action.Variety')
  - [CanCancel(cancelSource)](#M-TinyLife-Actions-Action-CanCancel-TinyLife-Actions-Action- 'TinyLife.Actions.Action.CanCancel(TinyLife.Actions.Action)')
  - [CanEnqueueConversation(person,type)](#M-TinyLife-Actions-Action-CanEnqueueConversation-TinyLife-Objects-Person,TinyLife-Actions-ActionType- 'TinyLife.Actions.Action.CanEnqueueConversation(TinyLife.Objects.Person,TinyLife.Actions.ActionType)')
  - [CanMultitask(other)](#M-TinyLife-Actions-Action-CanMultitask-TinyLife-Actions-Action- 'TinyLife.Actions.Action.CanMultitask(TinyLife.Actions.Action)')
  - [CausesExtremelyFastSpeed()](#M-TinyLife-Actions-Action-CausesExtremelyFastSpeed 'TinyLife.Actions.Action.CausesExtremelyFastSpeed')
  - [CompleteIfNeedFull(type,els)](#M-TinyLife-Actions-Action-CompleteIfNeedFull-TinyLife-NeedType,TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.Action.CompleteIfNeedFull(TinyLife.NeedType,TinyLife.Actions.Action.CompletionType)')
  - [FindAllFreeFurniture(person,categories,objectSpotType,needsFreeActionSpot,position,radius)](#M-TinyLife-Actions-Action-FindAllFreeFurniture-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType,System-Boolean,System-Nullable{Microsoft-Xna-Framework-Vector2},System-Int32- 'TinyLife.Actions.Action.FindAllFreeFurniture(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory,TinyLife.Objects.FurnitureType,System.Boolean,System.Nullable{Microsoft.Xna.Framework.Vector2},System.Int32)')
  - [FindAllFreePeople(type,person,position,radius)](#M-TinyLife-Actions-Action-FindAllFreePeople-TinyLife-Actions-ActionType,TinyLife-Objects-Person,System-Nullable{Microsoft-Xna-Framework-Vector2},System-Int32- 'TinyLife.Actions.Action.FindAllFreePeople(TinyLife.Actions.ActionType,TinyLife.Objects.Person,System.Nullable{Microsoft.Xna.Framework.Vector2},System.Int32)')
  - [FindFreeFurniture(person,categories,objectSpotType,position)](#M-TinyLife-Actions-Action-FindFreeFurniture-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType,System-Nullable{Microsoft-Xna-Framework-Vector2}- 'TinyLife.Actions.Action.FindFreeFurniture(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory,TinyLife.Objects.FurnitureType,System.Nullable{Microsoft.Xna.Framework.Vector2})')
  - [GetChair(deskObject)](#M-TinyLife-Actions-Action-GetChair-TinyLife-Objects-Furniture- 'TinyLife.Actions.Action.GetChair(TinyLife.Objects.Furniture)')
  - [GetDisplayName()](#M-TinyLife-Actions-Action-GetDisplayName 'TinyLife.Actions.Action.GetDisplayName')
  - [GetIconObject()](#M-TinyLife-Actions-Action-GetIconObject 'TinyLife.Actions.Action.GetIconObject')
  - [GetNextAction(completion)](#M-TinyLife-Actions-Action-GetNextAction-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.Action.GetNextAction(TinyLife.Actions.Action.CompletionType)')
  - [GetPlaceDirection(item)](#M-TinyLife-Actions-Action-GetPlaceDirection-TinyLife-Objects-FurnitureType- 'TinyLife.Actions.Action.GetPlaceDirection(TinyLife.Objects.FurnitureType)')
  - [GetTableSpot(chair)](#M-TinyLife-Actions-Action-GetTableSpot-TinyLife-Objects-Furniture- 'TinyLife.Actions.Action.GetTableSpot(TinyLife.Objects.Furniture)')
  - [Initialize()](#M-TinyLife-Actions-Action-Initialize 'TinyLife.Actions.Action.Initialize')
  - [IsCompleted()](#M-TinyLife-Actions-Action-IsCompleted 'TinyLife.Actions.Action.IsCompleted')
  - [OnCompleted(type)](#M-TinyLife-Actions-Action-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.Action.OnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [PutDownOrGoTo(parentToPutOn,items)](#M-TinyLife-Actions-Action-PutDownOrGoTo-TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType[]- 'TinyLife.Actions.Action.PutDownOrGoTo(TinyLife.Objects.ObjectCategory,TinyLife.Objects.FurnitureType[])')
  - [Sit(chair,speed)](#M-TinyLife-Actions-Action-Sit-TinyLife-Objects-Furniture,TinyLife-GameSpeed- 'TinyLife.Actions.Action.Sit(TinyLife.Objects.Furniture,TinyLife.GameSpeed)')
  - [Update(time,passedInGame,speed)](#M-TinyLife-Actions-Action-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.Action.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate(person)](#M-TinyLife-Actions-Action-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.Action.Validate(TinyLife.Objects.Person)')
- [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo')
  - [ActionLocation](#F-TinyLife-Actions-ActionInfo-ActionLocation 'TinyLife.Actions.ActionInfo.ActionLocation')
  - [ActionObject](#F-TinyLife-Actions-ActionInfo-ActionObject 'TinyLife.Actions.ActionInfo.ActionObject')
  - [ActionSpot](#P-TinyLife-Actions-ActionInfo-ActionSpot 'TinyLife.Actions.ActionInfo.ActionSpot')
  - [Map](#P-TinyLife-Actions-ActionInfo-Map 'TinyLife.Actions.ActionInfo.Map')
  - [Person](#P-TinyLife-Actions-ActionInfo-Person 'TinyLife.Actions.ActionInfo.Person')
  - [FromLocation(person,location)](#M-TinyLife-Actions-ActionInfo-FromLocation-TinyLife-Objects-Person,Microsoft-Xna-Framework-Vector2- 'TinyLife.Actions.ActionInfo.FromLocation(TinyLife.Objects.Person,Microsoft.Xna.Framework.Vector2)')
  - [FromObjectGeneric(person,obj)](#M-TinyLife-Actions-ActionInfo-FromObjectGeneric-TinyLife-Objects-Person,TinyLife-Objects-MapObject- 'TinyLife.Actions.ActionInfo.FromObjectGeneric(TinyLife.Objects.Person,TinyLife.Objects.MapObject)')
  - [GetActionObject\`\`1()](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1')
  - [GetObjectOrChild\`\`1(category)](#M-TinyLife-Actions-ActionInfo-GetObjectOrChild``1-TinyLife-Objects-ObjectCategory- 'TinyLife.Actions.ActionInfo.GetObjectOrChild``1(TinyLife.Objects.ObjectCategory)')
  - [GetObjectOrParent\`\`1(category)](#M-TinyLife-Actions-ActionInfo-GetObjectOrParent``1-TinyLife-Objects-ObjectCategory- 'TinyLife.Actions.ActionInfo.GetObjectOrParent``1(TinyLife.Objects.ObjectCategory)')
  - [OccupyFreeActionSpot(context,enter,rotation)](#M-TinyLife-Actions-ActionInfo-OccupyFreeActionSpot-TinyLife-Objects-ObjectCategory,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Actions.ActionInfo.OccupyFreeActionSpot(TinyLife.Objects.ObjectCategory,System.Boolean,System.Nullable{MLEM.Misc.Direction2})')
  - [ToFreeActionSpot(context)](#M-TinyLife-Actions-ActionInfo-ToFreeActionSpot-TinyLife-Objects-ObjectCategory- 'TinyLife.Actions.ActionInfo.ToFreeActionSpot(TinyLife.Objects.ObjectCategory)')
  - [Validate(person)](#M-TinyLife-Actions-ActionInfo-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.ActionInfo.Validate(TinyLife.Objects.Person)')
- [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot')
  - [#ctor(offset,validDirections)](#M-TinyLife-Objects-ActionSpot-#ctor-Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2[]- 'TinyLife.Objects.ActionSpot.#ctor(Microsoft.Xna.Framework.Vector2,MLEM.Misc.Direction2[])')
  - [#ctor(offset,yOffset,validDirections)](#M-TinyLife-Objects-ActionSpot-#ctor-Microsoft-Xna-Framework-Vector2,System-Single,MLEM-Misc-Direction2[]- 'TinyLife.Objects.ActionSpot.#ctor(Microsoft.Xna.Framework.Vector2,System.Single,MLEM.Misc.Direction2[])')
  - [#ctor(offset,visualOffset,yOffset,validDirections)](#M-TinyLife-Objects-ActionSpot-#ctor-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Single,MLEM-Misc-Direction2[]- 'TinyLife.Objects.ActionSpot.#ctor(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Single,MLEM.Misc.Direction2[])')
  - [CategoryRestriction](#F-TinyLife-Objects-ActionSpot-CategoryRestriction 'TinyLife.Objects.ActionSpot.CategoryRestriction')
  - [DrawLayer](#F-TinyLife-Objects-ActionSpot-DrawLayer 'TinyLife.Objects.ActionSpot.DrawLayer')
  - [Group](#F-TinyLife-Objects-ActionSpot-Group 'TinyLife.Objects.ActionSpot.Group')
  - [GetFreeDirections(furniture,person)](#M-TinyLife-Objects-ActionSpot-GetFreeDirections-TinyLife-Objects-Furniture,TinyLife-Objects-Person- 'TinyLife.Objects.ActionSpot.GetFreeDirections(TinyLife.Objects.Furniture,TinyLife.Objects.Person)')
  - [GetOccupants(furniture,includeGroup)](#M-TinyLife-Objects-ActionSpot-GetOccupants-TinyLife-Objects-Furniture,System-Boolean- 'TinyLife.Objects.ActionSpot.GetOccupants(TinyLife.Objects.Furniture,System.Boolean)')
- [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType')
  - [Types](#F-TinyLife-Actions-ActionType-Types 'TinyLife.Actions.ActionType.Types')
  - [Settings](#P-TinyLife-Actions-ActionType-Settings 'TinyLife.Actions.ActionType.Settings')
  - [CanPlaceHeldItem(info,automatic)](#M-TinyLife-Actions-ActionType-CanPlaceHeldItem-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.CanPlaceHeldItem(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [Construct(info,variety)](#M-TinyLife-Actions-ActionType-Construct-TinyLife-Actions-ActionInfo,System-Nullable{TinyLife-Actions-ActionVariety}- 'TinyLife.Actions.ActionType.Construct(TinyLife.Actions.ActionInfo,System.Nullable{TinyLife.Actions.ActionVariety})')
  - [GetDisplayName()](#M-TinyLife-Actions-ActionType-GetDisplayName 'TinyLife.Actions.ActionType.GetDisplayName')
  - [GetMatchingActions(contextFlags)](#M-TinyLife-Actions-ActionType-GetMatchingActions-TinyLife-Objects-ObjectCategory- 'TinyLife.Actions.ActionType.GetMatchingActions(TinyLife.Objects.ObjectCategory)')
  - [HasChair(info,automatic)](#M-TinyLife-Actions-ActionType-HasChair-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.HasChair(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [IsComfortable(info,automatic)](#M-TinyLife-Actions-ActionType-IsComfortable-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.IsComfortable(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [IsDislikedOrMean(info,automatic)](#M-TinyLife-Actions-ActionType-IsDislikedOrMean-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.IsDislikedOrMean(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [IsEmptyHanded(info,automatic)](#M-TinyLife-Actions-ActionType-IsEmptyHanded-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.IsEmptyHanded(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [IsHoldingOrPlaceableOn(info,goalParent,isAllowed)](#M-TinyLife-Actions-ActionType-IsHoldingOrPlaceableOn-TinyLife-Actions-ActionInfo,TinyLife-Objects-ObjectCategory,System-Predicate{TinyLife-Objects-FurnitureType}- 'TinyLife.Actions.ActionType.IsHoldingOrPlaceableOn(TinyLife.Actions.ActionInfo,TinyLife.Objects.ObjectCategory,System.Predicate{TinyLife.Objects.FurnitureType})')
  - [IsNotEmbarrassed(info,automatic)](#M-TinyLife-Actions-ActionType-IsNotEmbarrassed-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.IsNotEmbarrassed(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [IsReadyForRomance(info,automatic)](#M-TinyLife-Actions-ActionType-IsReadyForRomance-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.ActionType.IsReadyForRomance(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [Register(settings)](#M-TinyLife-Actions-ActionType-Register-TinyLife-Actions-ActionType-TypeSettings- 'TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)')
- [ActionVariety](#T-TinyLife-Actions-ActionVariety 'TinyLife.Actions.ActionVariety')
  - [#ctor(name)](#M-TinyLife-Actions-ActionVariety-#ctor-System-String- 'TinyLife.Actions.ActionVariety.#ctor(System.String)')
  - [CanExecute](#F-TinyLife-Actions-ActionVariety-CanExecute 'TinyLife.Actions.ActionVariety.CanExecute')
  - [Description](#F-TinyLife-Actions-ActionVariety-Description 'TinyLife.Actions.ActionVariety.Description')
  - [DisplayName](#F-TinyLife-Actions-ActionVariety-DisplayName 'TinyLife.Actions.ActionVariety.DisplayName')
  - [Name](#F-TinyLife-Actions-ActionVariety-Name 'TinyLife.Actions.ActionVariety.Name')
  - [PassivePriority](#F-TinyLife-Actions-ActionVariety-PassivePriority 'TinyLife.Actions.ActionVariety.PassivePriority')
- [AiSettings](#T-TinyLife-Actions-ActionType-AiSettings 'TinyLife.Actions.ActionType.AiSettings')
  - [CanDoAtAnyPoint](#F-TinyLife-Actions-ActionType-AiSettings-CanDoAtAnyPoint 'TinyLife.Actions.ActionType.AiSettings.CanDoAtAnyPoint')
  - [CanDoRandomly](#F-TinyLife-Actions-ActionType-AiSettings-CanDoRandomly 'TinyLife.Actions.ActionType.AiSettings.CanDoRandomly')
  - [NeedsFreeActionSpot](#F-TinyLife-Actions-ActionType-AiSettings-NeedsFreeActionSpot 'TinyLife.Actions.ActionType.AiSettings.NeedsFreeActionSpot')
  - [PassivePriority](#F-TinyLife-Actions-ActionType-AiSettings-PassivePriority 'TinyLife.Actions.ActionType.AiSettings.PassivePriority')
  - [SolvedNeed](#F-TinyLife-Actions-ActionType-AiSettings-SolvedNeed 'TinyLife.Actions.ActionType.AiSettings.SolvedNeed')
- [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate')
- [CanExecuteResult](#T-TinyLife-Actions-ActionType-CanExecuteResult 'TinyLife.Actions.ActionType.CanExecuteResult')
  - [Hidden](#F-TinyLife-Actions-ActionType-CanExecuteResult-Hidden 'TinyLife.Actions.ActionType.CanExecuteResult.Hidden')
  - [HoldingItem](#F-TinyLife-Actions-ActionType-CanExecuteResult-HoldingItem 'TinyLife.Actions.ActionType.CanExecuteResult.HoldingItem')
  - [NoChair](#F-TinyLife-Actions-ActionType-CanExecuteResult-NoChair 'TinyLife.Actions.ActionType.CanExecuteResult.NoChair')
  - [NoSpace](#F-TinyLife-Actions-ActionType-CanExecuteResult-NoSpace 'TinyLife.Actions.ActionType.CanExecuteResult.NoSpace')
  - [NotEnoughMoney](#F-TinyLife-Actions-ActionType-CanExecuteResult-NotEnoughMoney 'TinyLife.Actions.ActionType.CanExecuteResult.NotEnoughMoney')
  - [NotEnoughSkill](#F-TinyLife-Actions-ActionType-CanExecuteResult-NotEnoughSkill 'TinyLife.Actions.ActionType.CanExecuteResult.NotEnoughSkill')
  - [NotYours](#F-TinyLife-Actions-ActionType-CanExecuteResult-NotYours 'TinyLife.Actions.ActionType.CanExecuteResult.NotYours')
  - [TooEmbarrassed](#F-TinyLife-Actions-ActionType-CanExecuteResult-TooEmbarrassed 'TinyLife.Actions.ActionType.CanExecuteResult.TooEmbarrassed')
  - [TooFar](#F-TinyLife-Actions-ActionType-CanExecuteResult-TooFar 'TinyLife.Actions.ActionType.CanExecuteResult.TooFar')
  - [TooSad](#F-TinyLife-Actions-ActionType-CanExecuteResult-TooSad 'TinyLife.Actions.ActionType.CanExecuteResult.TooSad')
  - [TooUncomfortable](#F-TinyLife-Actions-ActionType-CanExecuteResult-TooUncomfortable 'TinyLife.Actions.ActionType.CanExecuteResult.TooUncomfortable')
  - [Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid')
  - [WrongRelationshipType](#F-TinyLife-Actions-ActionType-CanExecuteResult-WrongRelationshipType 'TinyLife.Actions.ActionType.CanExecuteResult.WrongRelationshipType')
- [Car](#T-TinyLife-Objects-Car 'TinyLife.Objects.Car')
  - [#ctor()](#M-TinyLife-Objects-Car-#ctor-System-Guid,TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Car.#ctor(System.Guid,TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Driver](#F-TinyLife-Objects-Car-Driver 'TinyLife.Objects.Car.Driver')
  - [Rotation](#F-TinyLife-Objects-Car-Rotation 'TinyLife.Objects.Car.Rotation')
  - [Draw()](#M-TinyLife-Objects-Car-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}- 'TinyLife.Objects.Car.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color})')
  - [Update()](#M-TinyLife-Objects-Car-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Car.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-Objects-Car-Validate 'TinyLife.Objects.Car.Validate')
- [CharacterCreator](#T-TinyLife-Uis-CharacterCreator 'TinyLife.Uis.CharacterCreator')
  - [Active](#P-TinyLife-Uis-CharacterCreator-Active 'TinyLife.Uis.CharacterCreator.Active')
  - [CanSwitchPeople()](#M-TinyLife-Uis-CharacterCreator-CanSwitchPeople 'TinyLife.Uis.CharacterCreator.CanSwitchPeople')
  - [CreatePerson(map,household)](#M-TinyLife-Uis-CharacterCreator-CreatePerson-TinyLife-World-Map,TinyLife-World-Household- 'TinyLife.Uis.CharacterCreator.CreatePerson(TinyLife.World.Map,TinyLife.World.Household)')
  - [Open(person,full)](#M-TinyLife-Uis-CharacterCreator-Open-TinyLife-Objects-Person,System-Boolean- 'TinyLife.Uis.CharacterCreator.Open(TinyLife.Objects.Person,System.Boolean)')
- [Clothes](#T-TinyLife-Objects-Clothes 'TinyLife.Objects.Clothes')
  - [#ctor(name,layer,region,colors,icon)](#M-TinyLife-Objects-Clothes-#ctor-System-String,TinyLife-Objects-ClothesLayer,MLEM-Textures-TextureRegion,System-Single,MLEM-Textures-TextureRegion,TinyLife-Utilities-ColorScheme[]- 'TinyLife.Objects.Clothes.#ctor(System.String,TinyLife.Objects.ClothesLayer,MLEM.Textures.TextureRegion,System.Single,MLEM.Textures.TextureRegion,TinyLife.Utilities.ColorScheme[])')
  - [Colors](#F-TinyLife-Objects-Clothes-Colors 'TinyLife.Objects.Clothes.Colors')
  - [Icon](#F-TinyLife-Objects-Clothes-Icon 'TinyLife.Objects.Clothes.Icon')
  - [Layer](#F-TinyLife-Objects-Clothes-Layer 'TinyLife.Objects.Clothes.Layer')
  - [Layers](#F-TinyLife-Objects-Clothes-Layers 'TinyLife.Objects.Clothes.Layers')
  - [Name](#F-TinyLife-Objects-Clothes-Name 'TinyLife.Objects.Clothes.Name')
  - [TextureRegions](#F-TinyLife-Objects-Clothes-TextureRegions 'TinyLife.Objects.Clothes.TextureRegions')
  - [Types](#F-TinyLife-Objects-Clothes-Types 'TinyLife.Objects.Clothes.Types')
  - [GetPrice()](#M-TinyLife-Objects-Clothes-GetPrice 'TinyLife.Objects.Clothes.GetPrice')
  - [Register(clothes)](#M-TinyLife-Objects-Clothes-Register-TinyLife-Objects-Clothes- 'TinyLife.Objects.Clothes.Register(TinyLife.Objects.Clothes)')
- [ClothesLayer](#T-TinyLife-Objects-ClothesLayer 'TinyLife.Objects.ClothesLayer')
  - [Body](#F-TinyLife-Objects-ClothesLayer-Body 'TinyLife.Objects.ClothesLayer.Body')
  - [Eyes](#F-TinyLife-Objects-ClothesLayer-Eyes 'TinyLife.Objects.ClothesLayer.Eyes')
  - [Hair](#F-TinyLife-Objects-ClothesLayer-Hair 'TinyLife.Objects.ClothesLayer.Hair')
  - [Pants](#F-TinyLife-Objects-ClothesLayer-Pants 'TinyLife.Objects.ClothesLayer.Pants')
  - [Shirt](#F-TinyLife-Objects-ClothesLayer-Shirt 'TinyLife.Objects.ClothesLayer.Shirt')
  - [Shoes](#F-TinyLife-Objects-ClothesLayer-Shoes 'TinyLife.Objects.ClothesLayer.Shoes')
- [ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme')
  - [Count](#P-TinyLife-Utilities-ColorScheme-Count 'TinyLife.Utilities.ColorScheme.Count')
  - [Item](#P-TinyLife-Utilities-ColorScheme-Item-System-Int32- 'TinyLife.Utilities.ColorScheme.Item(System.Int32)')
  - [Create(objs)](#M-TinyLife-Utilities-ColorScheme-Create-System-Object[]- 'TinyLife.Utilities.ColorScheme.Create(System.Object[])')
  - [GetEnumerator()](#M-TinyLife-Utilities-ColorScheme-GetEnumerator 'TinyLife.Utilities.ColorScheme.GetEnumerator')
  - [Load(region)](#M-TinyLife-Utilities-ColorScheme-Load-MLEM-Textures-TextureRegion- 'TinyLife.Utilities.ColorScheme.Load(MLEM.Textures.TextureRegion)')
- [CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType')
  - [Active](#F-TinyLife-Actions-Action-CompletionType-Active 'TinyLife.Actions.Action.CompletionType.Active')
  - [Canceled](#F-TinyLife-Actions-Action-CompletionType-Canceled 'TinyLife.Actions.Action.CompletionType.Canceled')
  - [Completed](#F-TinyLife-Actions-Action-CompletionType-Completed 'TinyLife.Actions.Action.CompletionType.Completed')
  - [Failed](#F-TinyLife-Actions-Action-CompletionType-Failed 'TinyLife.Actions.Action.CompletionType.Failed')
- [Computer](#T-TinyLife-Objects-Computer 'TinyLife.Objects.Computer')
  - [#ctor()](#M-TinyLife-Objects-Computer-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Computer.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Draw()](#M-TinyLife-Objects-Computer-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean- 'TinyLife.Objects.Computer.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)')
- [ComputerAction](#T-TinyLife-Actions-ComputerAction 'TinyLife.Actions.ComputerAction')
  - [#ctor()](#M-TinyLife-Actions-ComputerAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-String- 'TinyLife.Actions.ComputerAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,System.String)')
  - [AndThenInitialize()](#M-TinyLife-Actions-ComputerAction-AndThenInitialize 'TinyLife.Actions.ComputerAction.AndThenInitialize')
  - [AndThenOnCompleted()](#M-TinyLife-Actions-ComputerAction-AndThenOnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.ComputerAction.AndThenOnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [AndThenUpdate()](#M-TinyLife-Actions-ComputerAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.ComputerAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [Constructor](#T-TinyLife-Objects-FurnitureType-Constructor 'TinyLife.Objects.FurnitureType.Constructor')
- [Cooking](#T-TinyLife-Skills-Cooking 'TinyLife.Skills.Cooking')
  - [FoodTypes](#F-TinyLife-Skills-Cooking-FoodTypes 'TinyLife.Skills.Cooking.FoodTypes')
  - [RegisterFoodType(type)](#M-TinyLife-Skills-Cooking-RegisterFoodType-TinyLife-Skills-Cooking-FoodType- 'TinyLife.Skills.Cooking.RegisterFoodType(TinyLife.Skills.Cooking.FoodType)')
- [CornerFurniture](#T-TinyLife-Objects-CornerFurniture 'TinyLife.Objects.CornerFurniture')
  - [#ctor()](#M-TinyLife-Objects-CornerFurniture-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.CornerFurniture.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Draw()](#M-TinyLife-Objects-CornerFurniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean- 'TinyLife.Objects.CornerFurniture.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)')
  - [OnNeighborChanged()](#M-TinyLife-Objects-CornerFurniture-OnNeighborChanged-TinyLife-Objects-Furniture- 'TinyLife.Objects.CornerFurniture.OnNeighborChanged(TinyLife.Objects.Furniture)')
  - [ShouldConnectTo(neighbor)](#M-TinyLife-Objects-CornerFurniture-ShouldConnectTo-TinyLife-Objects-Furniture- 'TinyLife.Objects.CornerFurniture.ShouldConnectTo(TinyLife.Objects.Furniture)')
  - [Validate()](#M-TinyLife-Objects-CornerFurniture-Validate 'TinyLife.Objects.CornerFurniture.Validate')
- [Counter](#T-TinyLife-Objects-CornerFurniture-Counter 'TinyLife.Objects.CornerFurniture.Counter')
  - [#ctor()](#M-TinyLife-Objects-CornerFurniture-Counter-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.CornerFurniture.Counter.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [ShouldConnectTo()](#M-TinyLife-Objects-CornerFurniture-Counter-ShouldConnectTo-TinyLife-Objects-Furniture- 'TinyLife.Objects.CornerFurniture.Counter.ShouldConnectTo(TinyLife.Objects.Furniture)')
- [Cursor](#T-TinyLife-Uis-Cursor 'TinyLife.Uis.Cursor')
  - [SetCursor(type)](#M-TinyLife-Uis-Cursor-SetCursor-TinyLife-Uis-CursorType- 'TinyLife.Uis.Cursor.SetCursor(TinyLife.Uis.CursorType)')
- [CursorType](#T-TinyLife-Uis-CursorType 'TinyLife.Uis.CursorType')
  - [Default](#F-TinyLife-Uis-CursorType-Default 'TinyLife.Uis.CursorType.Default')
  - [Disallowed](#F-TinyLife-Uis-CursorType-Disallowed 'TinyLife.Uis.CursorType.Disallowed')
  - [Hammer](#F-TinyLife-Uis-CursorType-Hammer 'TinyLife.Uis.CursorType.Hammer')
  - [None](#F-TinyLife-Uis-CursorType-None 'TinyLife.Uis.CursorType.None')
  - [Range](#F-TinyLife-Uis-CursorType-Range 'TinyLife.Uis.CursorType.Range')
  - [Wall](#F-TinyLife-Uis-CursorType-Wall 'TinyLife.Uis.CursorType.Wall')
- [DeathReason](#T-TinyLife-Objects-Person-DeathReason 'TinyLife.Objects.Person.DeathReason')
  - [InexplicableReasons](#F-TinyLife-Objects-Person-DeathReason-InexplicableReasons 'TinyLife.Objects.Person.DeathReason.InexplicableReasons')
  - [Starvation](#F-TinyLife-Objects-Person-DeathReason-Starvation 'TinyLife.Objects.Person.DeathReason.Starvation')
- [Door](#T-TinyLife-World-Door 'TinyLife.World.Door')
  - [#ctor()](#M-TinyLife-World-Door-#ctor-TinyLife-World-OpeningType,System-Int32- 'TinyLife.World.Door.#ctor(TinyLife.World.OpeningType,System.Int32)')
  - [CanWalkThrough()](#M-TinyLife-World-Door-CanWalkThrough 'TinyLife.World.Door.CanWalkThrough')
- [DrawEvent\`1](#T-TinyLife-Mods-Events-DrawEvent`1 'TinyLife.Mods.Events.DrawEvent`1')
- [DriveAction](#T-TinyLife-Actions-DriveAction 'TinyLife.Actions.DriveAction')
  - [#ctor()](#M-TinyLife-Actions-DriveAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.DriveAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [FindPath()](#M-TinyLife-Actions-DriveAction-FindPath-Microsoft-Xna-Framework-Point- 'TinyLife.Actions.DriveAction.FindPath(Microsoft.Xna.Framework.Point)')
  - [GetSpeed()](#M-TinyLife-Actions-DriveAction-GetSpeed 'TinyLife.Actions.DriveAction.GetSpeed')
  - [OnCompleted()](#M-TinyLife-Actions-DriveAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.DriveAction.OnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [OnPathReady()](#M-TinyLife-Actions-DriveAction-OnPathReady 'TinyLife.Actions.DriveAction.OnPathReady')
  - [Update()](#M-TinyLife-Actions-DriveAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.DriveAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [Emote](#T-TinyLife-Actions-Emote 'TinyLife.Actions.Emote')
  - [#ctor(texture,categories)](#M-TinyLife-Actions-Emote-#ctor-MLEM-Textures-TextureRegion,TinyLife-Actions-EmoteCategory- 'TinyLife.Actions.Emote.#ctor(MLEM.Textures.TextureRegion,TinyLife.Actions.EmoteCategory)')
  - [AllCategories](#F-TinyLife-Actions-Emote-AllCategories 'TinyLife.Actions.Emote.AllCategories')
  - [Categories](#F-TinyLife-Actions-Emote-Categories 'TinyLife.Actions.Emote.Categories')
  - [Texture](#F-TinyLife-Actions-Emote-Texture 'TinyLife.Actions.Emote.Texture')
  - [GetEmotes(possibleCategories)](#M-TinyLife-Actions-Emote-GetEmotes-TinyLife-Actions-EmoteCategory- 'TinyLife.Actions.Emote.GetEmotes(TinyLife.Actions.EmoteCategory)')
  - [GetRandomEmote(possibleCategories)](#M-TinyLife-Actions-Emote-GetRandomEmote-TinyLife-Actions-EmoteCategory- 'TinyLife.Actions.Emote.GetRandomEmote(TinyLife.Actions.EmoteCategory)')
  - [Register(emote)](#M-TinyLife-Actions-Emote-Register-TinyLife-Actions-Emote- 'TinyLife.Actions.Emote.Register(TinyLife.Actions.Emote)')
- [EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory')
  - [Flirty](#F-TinyLife-Actions-EmoteCategory-Flirty 'TinyLife.Actions.EmoteCategory.Flirty')
  - [General](#F-TinyLife-Actions-EmoteCategory-General 'TinyLife.Actions.EmoteCategory.General')
  - [Negative](#F-TinyLife-Actions-EmoteCategory-Negative 'TinyLife.Actions.EmoteCategory.Negative')
  - [Travel](#F-TinyLife-Actions-EmoteCategory-Travel 'TinyLife.Actions.EmoteCategory.Travel')
- [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier')
  - [#ctor(name,icon,emotion,condition)](#M-TinyLife-Emotions-EmotionModifier-#ctor-System-String,MLEM-Textures-TextureRegion,TinyLife-Emotions-EmotionType,System-Func{TinyLife-Objects-Person,System-Int32}- 'TinyLife.Emotions.EmotionModifier.#ctor(System.String,MLEM.Textures.TextureRegion,TinyLife.Emotions.EmotionType,System.Func{TinyLife.Objects.Person,System.Int32})')
  - [Condition](#F-TinyLife-Emotions-EmotionModifier-Condition 'TinyLife.Emotions.EmotionModifier.Condition')
  - [Emotion](#F-TinyLife-Emotions-EmotionModifier-Emotion 'TinyLife.Emotions.EmotionModifier.Emotion')
  - [Icon](#F-TinyLife-Emotions-EmotionModifier-Icon 'TinyLife.Emotions.EmotionModifier.Icon')
  - [Name](#F-TinyLife-Emotions-EmotionModifier-Name 'TinyLife.Emotions.EmotionModifier.Name')
  - [Types](#F-TinyLife-Emotions-EmotionModifier-Types 'TinyLife.Emotions.EmotionModifier.Types')
  - [Register(modifier)](#M-TinyLife-Emotions-EmotionModifier-Register-TinyLife-Emotions-EmotionModifier- 'TinyLife.Emotions.EmotionModifier.Register(TinyLife.Emotions.EmotionModifier)')
- [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType')
  - [#ctor(name,icon,color,category)](#M-TinyLife-Emotions-EmotionType-#ctor-System-String,MLEM-Textures-TextureRegion,Microsoft-Xna-Framework-Color,TinyLife-Emotions-EmotionType-TypeCategory- 'TinyLife.Emotions.EmotionType.#ctor(System.String,MLEM.Textures.TextureRegion,Microsoft.Xna.Framework.Color,TinyLife.Emotions.EmotionType.TypeCategory)')
  - [Category](#F-TinyLife-Emotions-EmotionType-Category 'TinyLife.Emotions.EmotionType.Category')
  - [Color](#F-TinyLife-Emotions-EmotionType-Color 'TinyLife.Emotions.EmotionType.Color')
  - [Icon](#F-TinyLife-Emotions-EmotionType-Icon 'TinyLife.Emotions.EmotionType.Icon')
  - [Name](#F-TinyLife-Emotions-EmotionType-Name 'TinyLife.Emotions.EmotionType.Name')
  - [Types](#F-TinyLife-Emotions-EmotionType-Types 'TinyLife.Emotions.EmotionType.Types')
  - [Register(type)](#M-TinyLife-Emotions-EmotionType-Register-TinyLife-Emotions-EmotionType- 'TinyLife.Emotions.EmotionType.Register(TinyLife.Emotions.EmotionType)')
- [EventPhase](#T-TinyLife-Mods-EventPhase 'TinyLife.Mods.EventPhase')
  - [Post](#F-TinyLife-Mods-EventPhase-Post 'TinyLife.Mods.EventPhase.Post')
  - [Pre](#F-TinyLife-Mods-EventPhase-Pre 'TinyLife.Mods.EventPhase.Pre')
- [Events](#T-TinyLife-Mods-Events 'TinyLife.Mods.Events')
- [ExportedHousehold](#T-TinyLife-World-ExportedHousehold 'TinyLife.World.ExportedHousehold')
  - [Members](#F-TinyLife-World-ExportedHousehold-Members 'TinyLife.World.ExportedHousehold.Members')
  - [Money](#F-TinyLife-World-ExportedHousehold-Money 'TinyLife.World.ExportedHousehold.Money')
- [ExportedLot](#T-TinyLife-World-ExportedLot 'TinyLife.World.ExportedLot')
  - [Area](#F-TinyLife-World-ExportedLot-Area 'TinyLife.World.ExportedLot.Area')
  - [Furniture](#F-TinyLife-World-ExportedLot-Furniture 'TinyLife.World.ExportedLot.Furniture')
  - [Roofs](#F-TinyLife-World-ExportedLot-Roofs 'TinyLife.World.ExportedLot.Roofs')
  - [Tiles](#F-TinyLife-World-ExportedLot-Tiles 'TinyLife.World.ExportedLot.Tiles')
  - [Type](#F-TinyLife-World-ExportedLot-Type 'TinyLife.World.ExportedLot.Type')
  - [Walls](#F-TinyLife-World-ExportedLot-Walls 'TinyLife.World.ExportedLot.Walls')
  - [GetCoveredArea()](#M-TinyLife-World-ExportedLot-GetCoveredArea 'TinyLife.World.ExportedLot.GetCoveredArea')
  - [GetPrice()](#M-TinyLife-World-ExportedLot-GetPrice 'TinyLife.World.ExportedLot.GetPrice')
- [Extensions](#T-TinyLife-Utilities-Extensions 'TinyLife.Utilities.Extensions')
  - [And(result,other)](#M-TinyLife-Utilities-Extensions-And-TinyLife-Actions-ActionType-CanExecuteResult,TinyLife-Actions-ActionType-CanExecuteResult- 'TinyLife.Utilities.Extensions.And(TinyLife.Actions.ActionType.CanExecuteResult,TinyLife.Actions.ActionType.CanExecuteResult)')
  - [GetDecorativeRating(quality)](#M-TinyLife-Utilities-Extensions-GetDecorativeRating-TinyLife-Skills-Quality- 'TinyLife.Utilities.Extensions.GetDecorativeRating(TinyLife.Skills.Quality)')
  - [GetOpposite(type)](#M-TinyLife-Utilities-Extensions-GetOpposite-TinyLife-GenealogyType- 'TinyLife.Utilities.Extensions.GetOpposite(TinyLife.GenealogyType)')
  - [GetPriceModifier(quality)](#M-TinyLife-Utilities-Extensions-GetPriceModifier-TinyLife-Skills-Quality- 'TinyLife.Utilities.Extensions.GetPriceModifier(TinyLife.Skills.Quality)')
  - [IsVertical(dir)](#M-TinyLife-Utilities-Extensions-IsVertical-MLEM-Misc-Direction2- 'TinyLife.Utilities.Extensions.IsVertical(MLEM.Misc.Direction2)')
  - [JsonCopy\`\`1(obj)](#M-TinyLife-Utilities-Extensions-JsonCopy``1-``0- 'TinyLife.Utilities.Extensions.JsonCopy``1(``0)')
  - [RotateBy(dir,reference,start)](#M-TinyLife-Utilities-Extensions-RotateBy-MLEM-Misc-Direction2,MLEM-Misc-Direction2,MLEM-Misc-Direction2- 'TinyLife.Utilities.Extensions.RotateBy(MLEM.Misc.Direction2,MLEM.Misc.Direction2,MLEM.Misc.Direction2)')
  - [ToLocalizedString(quality)](#M-TinyLife-Utilities-Extensions-ToLocalizedString-TinyLife-Skills-Quality- 'TinyLife.Utilities.Extensions.ToLocalizedString(TinyLife.Skills.Quality)')
  - [ToScreenPos(position,center)](#M-TinyLife-Utilities-Extensions-ToScreenPos-Microsoft-Xna-Framework-Vector2,System-Boolean- 'TinyLife.Utilities.Extensions.ToScreenPos(Microsoft.Xna.Framework.Vector2,System.Boolean)')
  - [ToSellingPriceString(value)](#M-TinyLife-Utilities-Extensions-ToSellingPriceString-System-Single- 'TinyLife.Utilities.Extensions.ToSellingPriceString(System.Single)')
  - [ToWallSide(dir)](#M-TinyLife-Utilities-Extensions-ToWallSide-MLEM-Misc-Direction2- 'TinyLife.Utilities.Extensions.ToWallSide(MLEM.Misc.Direction2)')
  - [ToWorking(pose)](#M-TinyLife-Utilities-Extensions-ToWorking-TinyLife-Objects-Person-Pose- 'TinyLife.Utilities.Extensions.ToWorking(TinyLife.Objects.Person.Pose)')
  - [ToWorldPos(position)](#M-TinyLife-Utilities-Extensions-ToWorldPos-Microsoft-Xna-Framework-Vector2- 'TinyLife.Utilities.Extensions.ToWorldPos(Microsoft.Xna.Framework.Vector2)')
- [Fence](#T-TinyLife-Objects-Fence 'TinyLife.Objects.Fence')
  - [#ctor()](#M-TinyLife-Objects-Fence-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Fence.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Draw()](#M-TinyLife-Objects-Fence-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean- 'TinyLife.Objects.Fence.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)')
  - [OnNeighborChanged()](#M-TinyLife-Objects-Fence-OnNeighborChanged-TinyLife-Objects-Furniture- 'TinyLife.Objects.Fence.OnNeighborChanged(TinyLife.Objects.Furniture)')
  - [ShouldConnectTo(neighbor)](#M-TinyLife-Objects-Fence-ShouldConnectTo-TinyLife-Objects-Furniture- 'TinyLife.Objects.Fence.ShouldConnectTo(TinyLife.Objects.Furniture)')
  - [Validate()](#M-TinyLife-Objects-Fence-Validate 'TinyLife.Objects.Fence.Validate')
- [Food](#T-TinyLife-Objects-Food 'TinyLife.Objects.Food')
  - [#ctor()](#M-TinyLife-Objects-Food-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Food.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [FoodLeft](#F-TinyLife-Objects-Food-FoodLeft 'TinyLife.Objects.Food.FoodLeft')
  - [Draw()](#M-TinyLife-Objects-Food-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean- 'TinyLife.Objects.Food.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)')
  - [GetHoverInfo()](#M-TinyLife-Objects-Food-GetHoverInfo 'TinyLife.Objects.Food.GetHoverInfo')
- [FoodType](#T-TinyLife-Skills-Cooking-FoodType 'TinyLife.Skills.Cooking.FoodType')
  - [#ctor(name,requiredCookingLevel,price,foodAmount)](#M-TinyLife-Skills-Cooking-FoodType-#ctor-System-String,System-Int32,System-Int32,System-Int32,System-Boolean- 'TinyLife.Skills.Cooking.FoodType.#ctor(System.String,System.Int32,System.Int32,System.Int32,System.Boolean)')
  - [FoodAmount](#F-TinyLife-Skills-Cooking-FoodType-FoodAmount 'TinyLife.Skills.Cooking.FoodType.FoodAmount')
  - [Name](#F-TinyLife-Skills-Cooking-FoodType-Name 'TinyLife.Skills.Cooking.FoodType.Name')
  - [Price](#F-TinyLife-Skills-Cooking-FoodType-Price 'TinyLife.Skills.Cooking.FoodType.Price')
  - [RequiredCookingLevel](#F-TinyLife-Skills-Cooking-FoodType-RequiredCookingLevel 'TinyLife.Skills.Cooking.FoodType.RequiredCookingLevel')
  - [Texture](#F-TinyLife-Skills-Cooking-FoodType-Texture 'TinyLife.Skills.Cooking.FoodType.Texture')
- [FoodTypedItem](#T-TinyLife-Objects-FoodTypedItem 'TinyLife.Objects.FoodTypedItem')
  - [#ctor()](#M-TinyLife-Objects-FoodTypedItem-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.FoodTypedItem.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Creator](#F-TinyLife-Objects-FoodTypedItem-Creator 'TinyLife.Objects.FoodTypedItem.Creator')
  - [FoodType](#F-TinyLife-Objects-FoodTypedItem-FoodType 'TinyLife.Objects.FoodTypedItem.FoodType')
  - [GetHoverInfo()](#M-TinyLife-Objects-FoodTypedItem-GetHoverInfo 'TinyLife.Objects.FoodTypedItem.GetHoverInfo')
  - [Validate()](#M-TinyLife-Objects-FoodTypedItem-Validate 'TinyLife.Objects.FoodTypedItem.Validate')
- [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture')
  - [#ctor(id,type,colors,map,pos)](#M-TinyLife-Objects-Furniture-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Furniture.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Colors](#F-TinyLife-Objects-Furniture-Colors 'TinyLife.Objects.Furniture.Colors')
  - [Rotation](#F-TinyLife-Objects-Furniture-Rotation 'TinyLife.Objects.Furniture.Rotation')
  - [Type](#F-TinyLife-Objects-Furniture-Type 'TinyLife.Objects.Furniture.Type')
  - [Area](#P-TinyLife-Objects-Furniture-Area 'TinyLife.Objects.Furniture.Area')
  - [ParentFurniture](#P-TinyLife-Objects-Furniture-ParentFurniture 'TinyLife.Objects.Furniture.ParentFurniture')
  - [ParentObjectSpot](#P-TinyLife-Objects-Furniture-ParentObjectSpot 'TinyLife.Objects.Furniture.ParentObjectSpot')
  - [AddChild(item,rotation)](#M-TinyLife-Objects-Furniture-AddChild-TinyLife-Objects-Furniture,MLEM-Misc-Direction2- 'TinyLife.Objects.Furniture.AddChild(TinyLife.Objects.Furniture,MLEM.Misc.Direction2)')
  - [AddChild\`\`1(type,rotation,colors,id)](#M-TinyLife-Objects-Furniture-AddChild``1-TinyLife-Objects-FurnitureType,MLEM-Misc-Direction2,System-Int32[],System-Nullable{System-Guid}- 'TinyLife.Objects.Furniture.AddChild``1(TinyLife.Objects.FurnitureType,MLEM.Misc.Direction2,System.Int32[],System.Nullable{System.Guid})')
  - [Draw()](#M-TinyLife-Objects-Furniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}- 'TinyLife.Objects.Furniture.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color})')
  - [Draw(time,batch,pos,drawPos,overrideColor,rotation,colors,drawScale,pivot,parent,parentSpot,depthOffset)](#M-TinyLife-Objects-Furniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean- 'TinyLife.Objects.Furniture.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)')
  - [DrawUi(time,batch,element,drawScale,colors)](#M-TinyLife-Objects-Furniture-DrawUi-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,MLEM-Ui-Elements-Element,System-Single,System-Int32[]- 'TinyLife.Objects.Furniture.DrawUi(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,MLEM.Ui.Elements.Element,System.Single,System.Int32[])')
  - [GetAiPriority()](#M-TinyLife-Objects-Furniture-GetAiPriority-TinyLife-Objects-Person- 'TinyLife.Objects.Furniture.GetAiPriority(TinyLife.Objects.Person)')
  - [GetCategories()](#M-TinyLife-Objects-Furniture-GetCategories-TinyLife-Objects-Person- 'TinyLife.Objects.Furniture.GetCategories(TinyLife.Objects.Person)')
  - [GetChildren\`\`1()](#M-TinyLife-Objects-Furniture-GetChildren``1 'TinyLife.Objects.Furniture.GetChildren``1')
  - [GetFreeActionSpot(person,context)](#M-TinyLife-Objects-Furniture-GetFreeActionSpot-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpot(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)')
  - [GetFreeActionSpotInfo(person,context)](#M-TinyLife-Objects-Furniture-GetFreeActionSpotInfo-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpotInfo(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)')
  - [GetFreeActionSpots(person,context)](#M-TinyLife-Objects-Furniture-GetFreeActionSpots-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpots(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)')
  - [GetFreeObjectSpot(type)](#M-TinyLife-Objects-Furniture-GetFreeObjectSpot-TinyLife-Objects-FurnitureType- 'TinyLife.Objects.Furniture.GetFreeObjectSpot(TinyLife.Objects.FurnitureType)')
  - [GetPrice()](#M-TinyLife-Objects-Furniture-GetPrice 'TinyLife.Objects.Furniture.GetPrice')
  - [Intersects()](#M-TinyLife-Objects-Furniture-Intersects-MLEM-Misc-RectangleF- 'TinyLife.Objects.Furniture.Intersects(MLEM.Misc.RectangleF)')
  - [OnAdded()](#M-TinyLife-Objects-Furniture-OnAdded 'TinyLife.Objects.Furniture.OnAdded')
  - [OnNeighborChanged(neighbor)](#M-TinyLife-Objects-Furniture-OnNeighborChanged-TinyLife-Objects-Furniture- 'TinyLife.Objects.Furniture.OnNeighborChanged(TinyLife.Objects.Furniture)')
  - [OnRemoved()](#M-TinyLife-Objects-Furniture-OnRemoved 'TinyLife.Objects.Furniture.OnRemoved')
  - [RemoveChildren\`\`1(predicate)](#M-TinyLife-Objects-Furniture-RemoveChildren``1-System-Predicate{``0}- 'TinyLife.Objects.Furniture.RemoveChildren``1(System.Predicate{``0})')
  - [SetChild(spot,type,rotation,colors,id)](#M-TinyLife-Objects-Furniture-SetChild-TinyLife-Objects-ObjectSpot,TinyLife-Objects-FurnitureType,MLEM-Misc-Direction2,System-Int32[],System-Nullable{System-Guid}- 'TinyLife.Objects.Furniture.SetChild(TinyLife.Objects.ObjectSpot,TinyLife.Objects.FurnitureType,MLEM.Misc.Direction2,System.Int32[],System.Nullable{System.Guid})')
  - [SetChild(spot,item,rotation)](#M-TinyLife-Objects-Furniture-SetChild-TinyLife-Objects-ObjectSpot,TinyLife-Objects-Furniture,MLEM-Misc-Direction2- 'TinyLife.Objects.Furniture.SetChild(TinyLife.Objects.ObjectSpot,TinyLife.Objects.Furniture,MLEM.Misc.Direction2)')
  - [SetParent(parent,spot)](#M-TinyLife-Objects-Furniture-SetParent-TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot- 'TinyLife.Objects.Furniture.SetParent(TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot)')
  - [Validate()](#M-TinyLife-Objects-Furniture-Validate 'TinyLife.Objects.Furniture.Validate')
- [FurniturePlacer](#T-TinyLife-Tools-FurniturePlacer 'TinyLife.Tools.FurniturePlacer')
  - [SelectedColors](#P-TinyLife-Tools-FurniturePlacer-SelectedColors 'TinyLife.Tools.FurniturePlacer.SelectedColors')
  - [SelectedFurniture](#P-TinyLife-Tools-FurniturePlacer-SelectedFurniture 'TinyLife.Tools.FurniturePlacer.SelectedFurniture')
  - [SelectedPreview](#P-TinyLife-Tools-FurniturePlacer-SelectedPreview 'TinyLife.Tools.FurniturePlacer.SelectedPreview')
  - [Draw(time,batch)](#M-TinyLife-Tools-FurniturePlacer-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.FurniturePlacer.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [ForceWallsUp()](#M-TinyLife-Tools-FurniturePlacer-ForceWallsUp 'TinyLife.Tools.FurniturePlacer.ForceWallsUp')
  - [GetMouseCursor()](#M-TinyLife-Tools-FurniturePlacer-GetMouseCursor 'TinyLife.Tools.FurniturePlacer.GetMouseCursor')
  - [HighlightSelectedObject()](#M-TinyLife-Tools-FurniturePlacer-HighlightSelectedObject 'TinyLife.Tools.FurniturePlacer.HighlightSelectedObject')
  - [SelectFurniture(furniture,preview,variation,rotation,colors,exact)](#M-TinyLife-Tools-FurniturePlacer-SelectFurniture-TinyLife-Objects-FurnitureType,TinyLife-Objects-Furniture,System-Action{TinyLife-Objects-Furniture},MLEM-Misc-Direction2,System-Int32[],System-Boolean- 'TinyLife.Tools.FurniturePlacer.SelectFurniture(TinyLife.Objects.FurnitureType,TinyLife.Objects.Furniture,System.Action{TinyLife.Objects.Furniture},MLEM.Misc.Direction2,System.Int32[],System.Boolean)')
  - [Update()](#M-TinyLife-Tools-FurniturePlacer-Update 'TinyLife.Tools.FurniturePlacer.Update')
- [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool')
  - [#ctor()](#M-TinyLife-Tools-FurnitureTool-#ctor 'TinyLife.Tools.FurnitureTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-FurnitureTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.FurnitureTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [ForceWallsUp()](#M-TinyLife-Tools-FurnitureTool-ForceWallsUp 'TinyLife.Tools.FurnitureTool.ForceWallsUp')
  - [GetMouseCursor()](#M-TinyLife-Tools-FurnitureTool-GetMouseCursor 'TinyLife.Tools.FurnitureTool.GetMouseCursor')
  - [InitBuildModeUi()](#M-TinyLife-Tools-FurnitureTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.FurnitureTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-FurnitureTool-ShouldHighlightSelectedObject 'TinyLife.Tools.FurnitureTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-FurnitureTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.FurnitureTool.Update(Microsoft.Xna.Framework.GameTime)')
- [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType')
  - [Textures](#F-TinyLife-Objects-FurnitureType-Textures 'TinyLife.Objects.FurnitureType.Textures')
  - [Types](#F-TinyLife-Objects-FurnitureType-Types 'TinyLife.Objects.FurnitureType.Types')
  - [ReferenceTexture](#P-TinyLife-Objects-FurnitureType-ReferenceTexture 'TinyLife.Objects.FurnitureType.ReferenceTexture')
  - [Rotations](#P-TinyLife-Objects-FurnitureType-Rotations 'TinyLife.Objects.FurnitureType.Rotations')
  - [Settings](#P-TinyLife-Objects-FurnitureType-Settings 'TinyLife.Objects.FurnitureType.Settings')
  - [AreWallsInTheWay(map,pos,rotation)](#M-TinyLife-Objects-FurnitureType-AreWallsInTheWay-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2- 'TinyLife.Objects.FurnitureType.AreWallsInTheWay(TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,MLEM.Misc.Direction2)')
  - [Construct(colors,map,pos,id)](#M-TinyLife-Objects-FurnitureType-Construct-System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,System-Nullable{System-Guid}- 'TinyLife.Objects.FurnitureType.Construct(System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,System.Nullable{System.Guid})')
  - [DrawColumns(map,position,rotation,batch,drawPos,texture,color,scale,size,pivot,parent,spot,depthOffset,mirror,wallHanging,groundItem)](#M-TinyLife-Objects-FurnitureType-DrawColumns-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,MLEM-Textures-TextureRegion,Microsoft-Xna-Framework-Color,System-Single,Microsoft-Xna-Framework-Point,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean,System-Boolean,System-Boolean- 'TinyLife.Objects.FurnitureType.DrawColumns(TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,MLEM.Misc.Direction2,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,MLEM.Textures.TextureRegion,Microsoft.Xna.Framework.Color,System.Single,Microsoft.Xna.Framework.Point,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean,System.Boolean,System.Boolean)')
  - [DrawLayers(map,position,batch,drawPos,rotation,layers,colors,scale,pivot,parent,spot,overrideColor,depthOffset)](#M-TinyLife-Objects-FurnitureType-DrawLayers-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2,MLEM-Textures-TextureRegion[],System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Nullable{Microsoft-Xna-Framework-Color},System-Single,System-Boolean- 'TinyLife.Objects.FurnitureType.DrawLayers(TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,MLEM.Misc.Direction2,MLEM.Textures.TextureRegion[],System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Nullable{Microsoft.Xna.Framework.Color},System.Single,System.Boolean)')
  - [GetColumns(rotation)](#M-TinyLife-Objects-FurnitureType-GetColumns-MLEM-Misc-Direction2- 'TinyLife.Objects.FurnitureType.GetColumns(MLEM.Misc.Direction2)')
  - [GetCoveredTiles(pos,size)](#M-TinyLife-Objects-FurnitureType-GetCoveredTiles-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Point- 'TinyLife.Objects.FurnitureType.GetCoveredTiles(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Point)')
  - [GetPrice()](#M-TinyLife-Objects-FurnitureType-GetPrice 'TinyLife.Objects.FurnitureType.GetPrice')
  - [GetSize(rotation)](#M-TinyLife-Objects-FurnitureType-GetSize-MLEM-Misc-Direction2- 'TinyLife.Objects.FurnitureType.GetSize(MLEM.Misc.Direction2)')
  - [GetTexture(name)](#M-TinyLife-Objects-FurnitureType-GetTexture-System-String- 'TinyLife.Objects.FurnitureType.GetTexture(System.String)')
  - [GetTextures(name,amount)](#M-TinyLife-Objects-FurnitureType-GetTextures-System-String,System-Int32- 'TinyLife.Objects.FurnitureType.GetTextures(System.String,System.Int32)')
  - [GetWallsInTheWay(map,pos,rotation)](#M-TinyLife-Objects-FurnitureType-GetWallsInTheWay-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2- 'TinyLife.Objects.FurnitureType.GetWallsInTheWay(TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,MLEM.Misc.Direction2)')
  - [HasCategory(category)](#M-TinyLife-Objects-FurnitureType-HasCategory-TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.FurnitureType.HasCategory(TinyLife.Objects.ObjectCategory)')
  - [Register(settings)](#M-TinyLife-Objects-FurnitureType-Register-TinyLife-Objects-FurnitureType-TypeSettings- 'TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)')
- [GameImpl](#T-TinyLife-GameImpl 'TinyLife.GameImpl')
  - [CurrentTime](#F-TinyLife-GameImpl-CurrentTime 'TinyLife.GameImpl.CurrentTime')
  - [FollowingPerson](#F-TinyLife-GameImpl-FollowingPerson 'TinyLife.GameImpl.FollowingPerson')
  - [Camera](#P-TinyLife-GameImpl-Camera 'TinyLife.GameImpl.Camera')
  - [CurrentHousehold](#P-TinyLife-GameImpl-CurrentHousehold 'TinyLife.GameImpl.CurrentHousehold')
  - [CurrentLot](#P-TinyLife-GameImpl-CurrentLot 'TinyLife.GameImpl.CurrentLot')
  - [CurrentTool](#P-TinyLife-GameImpl-CurrentTool 'TinyLife.GameImpl.CurrentTool')
  - [GraphicsMetrics](#P-TinyLife-GameImpl-GraphicsMetrics 'TinyLife.GameImpl.GraphicsMetrics')
  - [Instance](#P-TinyLife-GameImpl-Instance 'TinyLife.GameImpl.Instance')
  - [Listener](#P-TinyLife-GameImpl-Listener 'TinyLife.GameImpl.Listener')
  - [Map](#P-TinyLife-GameImpl-Map 'TinyLife.GameImpl.Map')
  - [Mode](#P-TinyLife-GameImpl-Mode 'TinyLife.GameImpl.Mode')
  - [Money](#P-TinyLife-GameImpl-Money 'TinyLife.GameImpl.Money')
  - [SaveName](#P-TinyLife-GameImpl-SaveName 'TinyLife.GameImpl.SaveName')
  - [Speed](#P-TinyLife-GameImpl-Speed 'TinyLife.GameImpl.Speed')
  - [Weekday](#P-TinyLife-GameImpl-Weekday 'TinyLife.GameImpl.Weekday')
  - [CanBeExtremelyFast()](#M-TinyLife-GameImpl-CanBeExtremelyFast 'TinyLife.GameImpl.CanBeExtremelyFast')
  - [CanSaveOrSwitchModes()](#M-TinyLife-GameImpl-CanSaveOrSwitchModes 'TinyLife.GameImpl.CanSaveOrSwitchModes')
  - [DoDraw()](#M-TinyLife-GameImpl-DoDraw-Microsoft-Xna-Framework-GameTime- 'TinyLife.GameImpl.DoDraw(Microsoft.Xna.Framework.GameTime)')
  - [DoUpdate()](#M-TinyLife-GameImpl-DoUpdate-Microsoft-Xna-Framework-GameTime- 'TinyLife.GameImpl.DoUpdate(Microsoft.Xna.Framework.GameTime)')
  - [IsMouseOnUi()](#M-TinyLife-GameImpl-IsMouseOnUi 'TinyLife.GameImpl.IsMouseOnUi')
  - [LoadContent()](#M-TinyLife-GameImpl-LoadContent 'TinyLife.GameImpl.LoadContent')
  - [SwitchGameMode(mode)](#M-TinyLife-GameImpl-SwitchGameMode-TinyLife-GameImpl-GameMode- 'TinyLife.GameImpl.SwitchGameMode(TinyLife.GameImpl.GameMode)')
- [GameMode](#T-TinyLife-GameImpl-GameMode 'TinyLife.GameImpl.GameMode')
  - [BuildOnly](#F-TinyLife-GameImpl-GameMode-BuildOnly 'TinyLife.GameImpl.GameMode.BuildOnly')
  - [InGameHousehold](#F-TinyLife-GameImpl-GameMode-InGameHousehold 'TinyLife.GameImpl.GameMode.InGameHousehold')
  - [MainMenu](#F-TinyLife-GameImpl-GameMode-MainMenu 'TinyLife.GameImpl.GameMode.MainMenu')
  - [SelectHousehold](#F-TinyLife-GameImpl-GameMode-SelectHousehold 'TinyLife.GameImpl.GameMode.SelectHousehold')
- [GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed')
  - [ExtremelyFast](#F-TinyLife-GameSpeed-ExtremelyFast 'TinyLife.GameSpeed.ExtremelyFast')
  - [Fast](#F-TinyLife-GameSpeed-Fast 'TinyLife.GameSpeed.Fast')
  - [Paused](#F-TinyLife-GameSpeed-Paused 'TinyLife.GameSpeed.Paused')
  - [Regular](#F-TinyLife-GameSpeed-Regular 'TinyLife.GameSpeed.Regular')
  - [VeryFast](#F-TinyLife-GameSpeed-VeryFast 'TinyLife.GameSpeed.VeryFast')
- [GenealogyType](#T-TinyLife-GenealogyType 'TinyLife.GenealogyType')
  - [Child](#F-TinyLife-GenealogyType-Child 'TinyLife.GenealogyType.Child')
  - [Grandchild](#F-TinyLife-GenealogyType-Grandchild 'TinyLife.GenealogyType.Grandchild')
  - [Grandparent](#F-TinyLife-GenealogyType-Grandparent 'TinyLife.GenealogyType.Grandparent')
  - [Nibling](#F-TinyLife-GenealogyType-Nibling 'TinyLife.GenealogyType.Nibling')
  - [Parent](#F-TinyLife-GenealogyType-Parent 'TinyLife.GenealogyType.Parent')
  - [Pibling](#F-TinyLife-GenealogyType-Pibling 'TinyLife.GenealogyType.Pibling')
  - [Sibling](#F-TinyLife-GenealogyType-Sibling 'TinyLife.GenealogyType.Sibling')
  - [Unrelated](#F-TinyLife-GenealogyType-Unrelated 'TinyLife.GenealogyType.Unrelated')
- [GetAndSitDownAction](#T-TinyLife-Actions-GetAndSitDownAction 'TinyLife.Actions.GetAndSitDownAction')
  - [#ctor()](#M-TinyLife-Actions-GetAndSitDownAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,TinyLife-Objects-FurnitureType,System-Boolean- 'TinyLife.Actions.GetAndSitDownAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,TinyLife.Objects.FurnitureType,System.Boolean)')
  - [AndThenInitialize()](#M-TinyLife-Actions-GetAndSitDownAction-AndThenInitialize 'TinyLife.Actions.GetAndSitDownAction.AndThenInitialize')
  - [AndThenUpdate()](#M-TinyLife-Actions-GetAndSitDownAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.GetAndSitDownAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [CreateFirstActions()](#M-TinyLife-Actions-GetAndSitDownAction-CreateFirstActions 'TinyLife.Actions.GetAndSitDownAction.CreateFirstActions')
  - [GetChair()](#M-TinyLife-Actions-GetAndSitDownAction-GetChair 'TinyLife.Actions.GetAndSitDownAction.GetChair')
  - [GetIconObject()](#M-TinyLife-Actions-GetAndSitDownAction-GetIconObject 'TinyLife.Actions.GetAndSitDownAction.GetIconObject')
  - [GetInteractingItem\`\`1()](#M-TinyLife-Actions-GetAndSitDownAction-GetInteractingItem``1 'TinyLife.Actions.GetAndSitDownAction.GetInteractingItem``1')
  - [GetNextAction()](#M-TinyLife-Actions-GetAndSitDownAction-GetNextAction-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.GetAndSitDownAction.GetNextAction(TinyLife.Actions.Action.CompletionType)')
- [GoHereAction](#T-TinyLife-Actions-GoHereAction 'TinyLife.Actions.GoHereAction')
  - [#ctor()](#M-TinyLife-Actions-GoHereAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.GoHereAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [AndThenInitialize()](#M-TinyLife-Actions-GoHereAction-AndThenInitialize 'TinyLife.Actions.GoHereAction.AndThenInitialize')
  - [AndThenIsCompleted()](#M-TinyLife-Actions-GoHereAction-AndThenIsCompleted 'TinyLife.Actions.GoHereAction.AndThenIsCompleted')
  - [CanCancel()](#M-TinyLife-Actions-GoHereAction-CanCancel-TinyLife-Actions-Action- 'TinyLife.Actions.GoHereAction.CanCancel(TinyLife.Actions.Action)')
  - [CreateFirstActions()](#M-TinyLife-Actions-GoHereAction-CreateFirstActions 'TinyLife.Actions.GoHereAction.CreateFirstActions')
  - [ShouldFail()](#M-TinyLife-Actions-GoHereAction-ShouldFail-TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.GoHereAction.ShouldFail(TinyLife.Actions.Action,TinyLife.Actions.Action.CompletionType)')
- [Gravestone](#T-TinyLife-Objects-Gravestone 'TinyLife.Objects.Gravestone')
  - [#ctor()](#M-TinyLife-Objects-Gravestone-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Gravestone.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Reason](#F-TinyLife-Objects-Gravestone-Reason 'TinyLife.Objects.Gravestone.Reason')
  - [DeadPerson](#P-TinyLife-Objects-Gravestone-DeadPerson 'TinyLife.Objects.Gravestone.DeadPerson')
  - [GetHoverInfo()](#M-TinyLife-Objects-Gravestone-GetHoverInfo 'TinyLife.Objects.Gravestone.GetHoverInfo')
- [Household](#T-TinyLife-World-Household 'TinyLife.World.Household')
  - [#ctor(map,lot)](#M-TinyLife-World-Household-#ctor-TinyLife-World-Map,TinyLife-World-Lot- 'TinyLife.World.Household.#ctor(TinyLife.World.Map,TinyLife.World.Lot)')
  - [IsCurrent](#P-TinyLife-World-Household-IsCurrent 'TinyLife.World.Household.IsCurrent')
  - [Lot](#P-TinyLife-World-Household-Lot 'TinyLife.World.Household.Lot')
  - [Members](#P-TinyLife-World-Household-Members 'TinyLife.World.Household.Members')
  - [Money](#P-TinyLife-World-Household-Money 'TinyLife.World.Household.Money')
  - [Name](#P-TinyLife-World-Household-Name 'TinyLife.World.Household.Name')
  - [Add(person)](#M-TinyLife-World-Household-Add-TinyLife-Objects-Person- 'TinyLife.World.Household.Add(TinyLife.Objects.Person)')
  - [Export()](#M-TinyLife-World-Household-Export 'TinyLife.World.Household.Export')
  - [GetAverageFriendshipTo(person)](#M-TinyLife-World-Household-GetAverageFriendshipTo-TinyLife-Objects-Person- 'TinyLife.World.Household.GetAverageFriendshipTo(TinyLife.Objects.Person)')
  - [HasMember(person)](#M-TinyLife-World-Household-HasMember-TinyLife-Objects-Person- 'TinyLife.World.Household.HasMember(TinyLife.Objects.Person)')
  - [Import(household)](#M-TinyLife-World-Household-Import-TinyLife-World-ExportedHousehold- 'TinyLife.World.Household.Import(TinyLife.World.ExportedHousehold)')
  - [IsLotVisible(lot)](#M-TinyLife-World-Household-IsLotVisible-TinyLife-World-Lot- 'TinyLife.World.Household.IsLotVisible(TinyLife.World.Lot)')
  - [MarkLotNonVisible(lot)](#M-TinyLife-World-Household-MarkLotNonVisible-TinyLife-World-Lot- 'TinyLife.World.Household.MarkLotNonVisible(TinyLife.World.Lot)')
  - [MarkLotVisible(lot)](#M-TinyLife-World-Household-MarkLotVisible-TinyLife-World-Lot- 'TinyLife.World.Household.MarkLotVisible(TinyLife.World.Lot)')
  - [Remove(person)](#M-TinyLife-World-Household-Remove-TinyLife-Objects-Person- 'TinyLife.World.Household.Remove(TinyLife.Objects.Person)')
  - [Update(time,passedInGame,speed)](#M-TinyLife-World-Household-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.World.Household.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-World-Household-Validate-TinyLife-World-Map- 'TinyLife.World.Household.Validate(TinyLife.World.Map)')
- [IPricedObject](#T-TinyLife-World-IPricedObject 'TinyLife.World.IPricedObject')
  - [GetPrice()](#M-TinyLife-World-IPricedObject-GetPrice 'TinyLife.World.IPricedObject.GetPrice')
- [IUpdatingObject](#T-TinyLife-Objects-IUpdatingObject 'TinyLife.Objects.IUpdatingObject')
  - [Update(time,passedInGame,speed)](#M-TinyLife-Objects-IUpdatingObject-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.IUpdatingObject.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [Instance](#T-TinyLife-Emotions-EmotionModifier-Instance 'TinyLife.Emotions.EmotionModifier.Instance')
  - [#ctor(type,amount,time)](#M-TinyLife-Emotions-EmotionModifier-Instance-#ctor-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan- 'TinyLife.Emotions.EmotionModifier.Instance.#ctor(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)')
  - [Amount](#F-TinyLife-Emotions-EmotionModifier-Instance-Amount 'TinyLife.Emotions.EmotionModifier.Instance.Amount')
  - [TotalTime](#F-TinyLife-Emotions-EmotionModifier-Instance-TotalTime 'TinyLife.Emotions.EmotionModifier.Instance.TotalTime')
  - [Type](#F-TinyLife-Emotions-EmotionModifier-Instance-Type 'TinyLife.Emotions.EmotionModifier.Instance.Type')
  - [Time](#P-TinyLife-Emotions-EmotionModifier-Instance-Time 'TinyLife.Emotions.EmotionModifier.Instance.Time')
  - [PassTime(passedInGame)](#M-TinyLife-Emotions-EmotionModifier-Instance-PassTime-System-TimeSpan- 'TinyLife.Emotions.EmotionModifier.Instance.PassTime(System.TimeSpan)')
- [Job](#T-TinyLife-Goals-Job 'TinyLife.Goals.Job')
  - [#ctor(type,person)](#M-TinyLife-Goals-Job-#ctor-TinyLife-Goals-JobType,TinyLife-Objects-Person- 'TinyLife.Goals.Job.#ctor(TinyLife.Goals.JobType,TinyLife.Objects.Person)')
  - [Type](#F-TinyLife-Goals-Job-Type 'TinyLife.Goals.Job.Type')
  - [CurrentHourlyPay](#P-TinyLife-Goals-Job-CurrentHourlyPay 'TinyLife.Goals.Job.CurrentHourlyPay')
  - [Level](#P-TinyLife-Goals-Job-Level 'TinyLife.Goals.Job.Level')
  - [Performance](#P-TinyLife-Goals-Job-Performance 'TinyLife.Goals.Job.Performance')
  - [Person](#P-TinyLife-Goals-Job-Person 'TinyLife.Goals.Job.Person')
  - [AddLevel(level)](#M-TinyLife-Goals-Job-AddLevel-System-Int32- 'TinyLife.Goals.Job.AddLevel(System.Int32)')
  - [AddPerformance(performance)](#M-TinyLife-Goals-Job-AddPerformance-System-Single- 'TinyLife.Goals.Job.AddPerformance(System.Single)')
  - [Update(passedInGame)](#M-TinyLife-Goals-Job-Update-System-TimeSpan- 'TinyLife.Goals.Job.Update(System.TimeSpan)')
  - [Validate()](#M-TinyLife-Goals-Job-Validate-TinyLife-Objects-Person- 'TinyLife.Goals.Job.Validate(TinyLife.Objects.Person)')
- [JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType')
  - [#ctor(name,hourlyPay,workHours,offWorkDays)](#M-TinyLife-Goals-JobType-#ctor-System-String,System-Single,MonoGame-Extended-Range{System-Int32},System-DayOfWeek[]- 'TinyLife.Goals.JobType.#ctor(System.String,System.Single,MonoGame.Extended.Range{System.Int32},System.DayOfWeek[])')
  - [HourlyPay](#F-TinyLife-Goals-JobType-HourlyPay 'TinyLife.Goals.JobType.HourlyPay')
  - [Name](#F-TinyLife-Goals-JobType-Name 'TinyLife.Goals.JobType.Name')
  - [OffWorkDays](#F-TinyLife-Goals-JobType-OffWorkDays 'TinyLife.Goals.JobType.OffWorkDays')
  - [Types](#F-TinyLife-Goals-JobType-Types 'TinyLife.Goals.JobType.Types')
  - [WorkHours](#F-TinyLife-Goals-JobType-WorkHours 'TinyLife.Goals.JobType.WorkHours')
  - [Construct(person)](#M-TinyLife-Goals-JobType-Construct-TinyLife-Objects-Person- 'TinyLife.Goals.JobType.Construct(TinyLife.Objects.Person)')
  - [GetDisplayName(level)](#M-TinyLife-Goals-JobType-GetDisplayName-System-Nullable{System-Int32}- 'TinyLife.Goals.JobType.GetDisplayName(System.Nullable{System.Int32})')
  - [IsTimeToWork(time)](#M-TinyLife-Goals-JobType-IsTimeToWork-System-Nullable{System-TimeSpan}- 'TinyLife.Goals.JobType.IsTimeToWork(System.Nullable{System.TimeSpan})')
  - [Register(type)](#M-TinyLife-Goals-JobType-Register-TinyLife-Goals-JobType- 'TinyLife.Goals.JobType.Register(TinyLife.Goals.JobType)')
  - [ToScheduleString()](#M-TinyLife-Goals-JobType-ToScheduleString 'TinyLife.Goals.JobType.ToScheduleString')
- [LnCategory](#T-TinyLife-LnCategory 'TinyLife.LnCategory')
  - [Actions](#F-TinyLife-LnCategory-Actions 'TinyLife.LnCategory.Actions')
  - [BuildMode](#F-TinyLife-LnCategory-BuildMode 'TinyLife.LnCategory.BuildMode')
  - [Clothes](#F-TinyLife-LnCategory-Clothes 'TinyLife.LnCategory.Clothes')
  - [Emotions](#F-TinyLife-LnCategory-Emotions 'TinyLife.LnCategory.Emotions')
  - [Food](#F-TinyLife-LnCategory-Food 'TinyLife.LnCategory.Food')
  - [Jobs](#F-TinyLife-LnCategory-Jobs 'TinyLife.LnCategory.Jobs')
  - [Personalities](#F-TinyLife-LnCategory-Personalities 'TinyLife.LnCategory.Personalities')
  - [Skills](#F-TinyLife-LnCategory-Skills 'TinyLife.LnCategory.Skills')
  - [Ui](#F-TinyLife-LnCategory-Ui 'TinyLife.LnCategory.Ui')
- [Localization](#T-TinyLife-Localization 'TinyLife.Localization')
  - [LanguageNames](#F-TinyLife-Localization-LanguageNames 'TinyLife.Localization.LanguageNames')
  - [Get(category,key)](#M-TinyLife-Localization-Get-TinyLife-LnCategory,System-String- 'TinyLife.Localization.Get(TinyLife.LnCategory,System.String)')
  - [SetLanguage(language)](#M-TinyLife-Localization-SetLanguage-System-String- 'TinyLife.Localization.SetLanguage(System.String)')
- [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot')
  - [#ctor(map,area)](#M-TinyLife-World-Lot-#ctor-TinyLife-World-Map,Microsoft-Xna-Framework-Rectangle- 'TinyLife.World.Lot.#ctor(TinyLife.World.Map,Microsoft.Xna.Framework.Rectangle)')
  - [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area')
  - [Id](#F-TinyLife-World-Lot-Id 'TinyLife.World.Lot.Id')
  - [Type](#F-TinyLife-World-Lot-Type 'TinyLife.World.Lot.Type')
  - [Household](#P-TinyLife-World-Lot-Household 'TinyLife.World.Lot.Household')
  - [AreRequirementsMet()](#M-TinyLife-World-Lot-AreRequirementsMet 'TinyLife.World.Lot.AreRequirementsMet')
  - [CanImport(import)](#M-TinyLife-World-Lot-CanImport-TinyLife-World-ExportedLot- 'TinyLife.World.Lot.CanImport(TinyLife.World.ExportedLot)')
  - [CanMove(direction)](#M-TinyLife-World-Lot-CanMove-MLEM-Misc-Direction2- 'TinyLife.World.Lot.CanMove(MLEM.Misc.Direction2)')
  - [Export()](#M-TinyLife-World-Lot-Export 'TinyLife.World.Lot.Export')
  - [GetCoveredArea()](#M-TinyLife-World-Lot-GetCoveredArea 'TinyLife.World.Lot.GetCoveredArea')
  - [GetFrontDoor()](#M-TinyLife-World-Lot-GetFrontDoor 'TinyLife.World.Lot.GetFrontDoor')
  - [GetHomeLocation(person)](#M-TinyLife-World-Lot-GetHomeLocation-TinyLife-Objects-Person- 'TinyLife.World.Lot.GetHomeLocation(TinyLife.Objects.Person)')
  - [GetObjects\`\`1()](#M-TinyLife-World-Lot-GetObjects``1 'TinyLife.World.Lot.GetObjects``1')
  - [GetPrice()](#M-TinyLife-World-Lot-GetPrice 'TinyLife.World.Lot.GetPrice')
  - [GetRoofs()](#M-TinyLife-World-Lot-GetRoofs 'TinyLife.World.Lot.GetRoofs')
  - [GetWalls()](#M-TinyLife-World-Lot-GetWalls 'TinyLife.World.Lot.GetWalls')
  - [Import(lot)](#M-TinyLife-World-Lot-Import-TinyLife-World-ExportedLot- 'TinyLife.World.Lot.Import(TinyLife.World.ExportedLot)')
  - [Move(direction)](#M-TinyLife-World-Lot-Move-MLEM-Misc-Direction2- 'TinyLife.World.Lot.Move(MLEM.Misc.Direction2)')
  - [Validate()](#M-TinyLife-World-Lot-Validate-TinyLife-World-Map- 'TinyLife.World.Lot.Validate(TinyLife.World.Map)')
- [LotTool](#T-TinyLife-Tools-LotTool 'TinyLife.Tools.LotTool')
  - [#ctor()](#M-TinyLife-Tools-LotTool-#ctor 'TinyLife.Tools.LotTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-LotTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.LotTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-LotTool-ShouldHighlightSelectedObject 'TinyLife.Tools.LotTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-LotTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.LotTool.Update(Microsoft.Xna.Framework.GameTime)')
- [LotType](#T-TinyLife-World-LotType 'TinyLife.World.LotType')
  - [#ctor(name,isResidential,requiredFurniture)](#M-TinyLife-World-LotType-#ctor-System-String,System-Boolean,System-ValueTuple{TinyLife-Objects-FurnitureType,System-Int32}[]- 'TinyLife.World.LotType.#ctor(System.String,System.Boolean,System.ValueTuple{TinyLife.Objects.FurnitureType,System.Int32}[])')
  - [IsResidential](#F-TinyLife-World-LotType-IsResidential 'TinyLife.World.LotType.IsResidential')
  - [Name](#F-TinyLife-World-LotType-Name 'TinyLife.World.LotType.Name')
  - [RequiredFurniture](#F-TinyLife-World-LotType-RequiredFurniture 'TinyLife.World.LotType.RequiredFurniture')
  - [Types](#F-TinyLife-World-LotType-Types 'TinyLife.World.LotType.Types')
  - [Register(type)](#M-TinyLife-World-LotType-Register-TinyLife-World-LotType- 'TinyLife.World.LotType.Register(TinyLife.World.LotType)')
- [Map](#T-TinyLife-World-Map 'TinyLife.World.Map')
  - [#ctor(name,sizeInSections)](#M-TinyLife-World-Map-#ctor-System-String,Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.#ctor(System.String,Microsoft.Xna.Framework.Point)')
  - [Name](#F-TinyLife-World-Map-Name 'TinyLife.World.Map.Name')
  - [RoadRadius](#F-TinyLife-World-Map-RoadRadius 'TinyLife.World.Map.RoadRadius')
  - [Size](#P-TinyLife-World-Map-Size 'TinyLife.World.Map.Size')
  - [SizeInSections](#P-TinyLife-World-Map-SizeInSections 'TinyLife.World.Map.SizeInSections')
  - [StaticVersion](#P-TinyLife-World-Map-StaticVersion 'TinyLife.World.Map.StaticVersion')
  - [AddHousehold(lot,people)](#M-TinyLife-World-Map-AddHousehold-TinyLife-World-Lot,TinyLife-Objects-Person[]- 'TinyLife.World.Map.AddHousehold(TinyLife.World.Lot,TinyLife.Objects.Person[])')
  - [AddLot(area)](#M-TinyLife-World-Map-AddLot-Microsoft-Xna-Framework-Rectangle- 'TinyLife.World.Map.AddLot(Microsoft.Xna.Framework.Rectangle)')
  - [AddObject(obj)](#M-TinyLife-World-Map-AddObject-TinyLife-Objects-MapObject- 'TinyLife.World.Map.AddObject(TinyLife.Objects.MapObject)')
  - [AddRoad(pos)](#M-TinyLife-World-Map-AddRoad-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.AddRoad(Microsoft.Xna.Framework.Point)')
  - [AddRoof(roof)](#M-TinyLife-World-Map-AddRoof-TinyLife-World-Roof- 'TinyLife.World.Map.AddRoof(TinyLife.World.Roof)')
  - [AddWall(pos,secondPos)](#M-TinyLife-World-Map-AddWall-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.AddWall(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point)')
  - [AddWall(wall,initializeRooms)](#M-TinyLife-World-Map-AddWall-TinyLife-World-Wall,System-Boolean- 'TinyLife.World.Map.AddWall(TinyLife.World.Wall,System.Boolean)')
  - [Draw(time,batch,selectionMode)](#M-TinyLife-World-Map-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,System-Boolean- 'TinyLife.World.Map.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,System.Boolean)')
  - [GetClosestEmptyTile(pos,radius,ignorePeople,hasToBeOnLot)](#M-TinyLife-World-Map-GetClosestEmptyTile-Microsoft-Xna-Framework-Vector2,System-Int32,System-Boolean,System-Boolean- 'TinyLife.World.Map.GetClosestEmptyTile(Microsoft.Xna.Framework.Vector2,System.Int32,System.Boolean,System.Boolean)')
  - [GetClosestRoad(pos,radius)](#M-TinyLife-World-Map-GetClosestRoad-Microsoft-Xna-Framework-Point,System-Int32- 'TinyLife.World.Map.GetClosestRoad(Microsoft.Xna.Framework.Point,System.Int32)')
  - [GetClosestSidewalk(road,pos)](#M-TinyLife-World-Map-GetClosestSidewalk-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Vector2- 'TinyLife.World.Map.GetClosestSidewalk(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Vector2)')
  - [GetDeadPerson(id)](#M-TinyLife-World-Map-GetDeadPerson-System-Guid- 'TinyLife.World.Map.GetDeadPerson(System.Guid)')
  - [GetDepth(tilePos,offset,center)](#M-TinyLife-World-Map-GetDepth-Microsoft-Xna-Framework-Vector2,System-Single,System-Boolean- 'TinyLife.World.Map.GetDepth(Microsoft.Xna.Framework.Vector2,System.Single,System.Boolean)')
  - [GetHousehold(person)](#M-TinyLife-World-Map-GetHousehold-TinyLife-Objects-Person- 'TinyLife.World.Map.GetHousehold(TinyLife.Objects.Person)')
  - [GetHousehold(lot)](#M-TinyLife-World-Map-GetHousehold-TinyLife-World-Lot- 'TinyLife.World.Map.GetHousehold(TinyLife.World.Lot)')
  - [GetHouseholds()](#M-TinyLife-World-Map-GetHouseholds 'TinyLife.World.Map.GetHouseholds')
  - [GetLot(id)](#M-TinyLife-World-Map-GetLot-System-Guid- 'TinyLife.World.Map.GetLot(System.Guid)')
  - [GetLot(pos)](#M-TinyLife-World-Map-GetLot-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetLot(Microsoft.Xna.Framework.Point)')
  - [GetLots()](#M-TinyLife-World-Map-GetLots 'TinyLife.World.Map.GetLots')
  - [GetObject\`\`1(id)](#M-TinyLife-World-Map-GetObject``1-System-Guid- 'TinyLife.World.Map.GetObject``1(System.Guid)')
  - [GetObjects\`\`1(area)](#M-TinyLife-World-Map-GetObjects``1-MLEM-Misc-RectangleF- 'TinyLife.World.Map.GetObjects``1(MLEM.Misc.RectangleF)')
  - [GetPathCost(currPos,nextPos)](#M-TinyLife-World-Map-GetPathCost-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetPathCost(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point)')
  - [GetPeople()](#M-TinyLife-World-Map-GetPeople 'TinyLife.World.Map.GetPeople')
  - [GetRoads()](#M-TinyLife-World-Map-GetRoads 'TinyLife.World.Map.GetRoads')
  - [GetRoof(pos)](#M-TinyLife-World-Map-GetRoof-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetRoof(Microsoft.Xna.Framework.Point)')
  - [GetRoom(pos)](#M-TinyLife-World-Map-GetRoom-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetRoom(Microsoft.Xna.Framework.Point)')
  - [GetSection(pos)](#M-TinyLife-World-Map-GetSection-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetSection(Microsoft.Xna.Framework.Point)')
  - [GetSections(point,radiusIncrease)](#M-TinyLife-World-Map-GetSections-Microsoft-Xna-Framework-Point,System-Int32- 'TinyLife.World.Map.GetSections(Microsoft.Xna.Framework.Point,System.Int32)')
  - [GetSections(area,radiusIncrease)](#M-TinyLife-World-Map-GetSections-MLEM-Misc-RectangleF,System-Int32- 'TinyLife.World.Map.GetSections(MLEM.Misc.RectangleF,System.Int32)')
  - [GetTile(pos)](#M-TinyLife-World-Map-GetTile-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetTile(Microsoft.Xna.Framework.Point)')
  - [GetWallBetween(pos,secondPos)](#M-TinyLife-World-Map-GetWallBetween-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetWallBetween(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point)')
  - [IsFreeSpot(pos)](#M-TinyLife-World-Map-IsFreeSpot-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.IsFreeSpot(Microsoft.Xna.Framework.Point)')
  - [IsInBounds(pos)](#M-TinyLife-World-Map-IsInBounds-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.IsInBounds(Microsoft.Xna.Framework.Point)')
  - [IsInSectionBounds(section)](#M-TinyLife-World-Map-IsInSectionBounds-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.IsInSectionBounds(Microsoft.Xna.Framework.Point)')
  - [IsRoad(pos)](#M-TinyLife-World-Map-IsRoad-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.IsRoad(Microsoft.Xna.Framework.Point)')
  - [LoadStaticMap(name)](#M-TinyLife-World-Map-LoadStaticMap-System-String- 'TinyLife.World.Map.LoadStaticMap(System.String)')
  - [MarkDirtyForPathfinding(pos)](#M-TinyLife-World-Map-MarkDirtyForPathfinding-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.MarkDirtyForPathfinding(Microsoft.Xna.Framework.Point)')
  - [PlaySound(sound,pos,volume,pitch,loop)](#M-TinyLife-World-Map-PlaySound-Microsoft-Xna-Framework-Audio-SoundEffect,Microsoft-Xna-Framework-Vector2,System-Single,System-Single,System-Boolean- 'TinyLife.World.Map.PlaySound(Microsoft.Xna.Framework.Audio.SoundEffect,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,System.Boolean)')
  - [PlaySound(sound,emitter,volume,pitch,loop)](#M-TinyLife-World-Map-PlaySound-Microsoft-Xna-Framework-Audio-SoundEffect,Microsoft-Xna-Framework-Audio-AudioEmitter,System-Single,System-Single,System-Boolean- 'TinyLife.World.Map.PlaySound(Microsoft.Xna.Framework.Audio.SoundEffect,Microsoft.Xna.Framework.Audio.AudioEmitter,System.Single,System.Single,System.Boolean)')
  - [RemoveHousehold(household)](#M-TinyLife-World-Map-RemoveHousehold-TinyLife-World-Household- 'TinyLife.World.Map.RemoveHousehold(TinyLife.World.Household)')
  - [RemoveLot(lot)](#M-TinyLife-World-Map-RemoveLot-TinyLife-World-Lot- 'TinyLife.World.Map.RemoveLot(TinyLife.World.Lot)')
  - [RemoveObject(obj)](#M-TinyLife-World-Map-RemoveObject-TinyLife-Objects-MapObject- 'TinyLife.World.Map.RemoveObject(TinyLife.Objects.MapObject)')
  - [RemoveRoof(roof)](#M-TinyLife-World-Map-RemoveRoof-TinyLife-World-Roof- 'TinyLife.World.Map.RemoveRoof(TinyLife.World.Roof)')
  - [RemoveWall(wall)](#M-TinyLife-World-Map-RemoveWall-TinyLife-World-Wall- 'TinyLife.World.Map.RemoveWall(TinyLife.World.Wall)')
  - [SetTile(pos,tile)](#M-TinyLife-World-Map-SetTile-Microsoft-Xna-Framework-Point,TinyLife-World-Tile- 'TinyLife.World.Map.SetTile(Microsoft.Xna.Framework.Point,TinyLife.World.Tile)')
  - [Update(time,passedInGame,speed)](#M-TinyLife-World-Map-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.World.Map.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-World-Map-Validate 'TinyLife.World.Map.Validate')
- [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject')
  - [#ctor(id,map,position)](#M-TinyLife-Objects-MapObject-#ctor-System-Guid,TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.MapObject.#ctor(System.Guid,TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Categories](#F-TinyLife-Objects-MapObject-Categories 'TinyLife.Objects.MapObject.Categories')
  - [Id](#F-TinyLife-Objects-MapObject-Id 'TinyLife.Objects.MapObject.Id')
  - [CurrentLot](#P-TinyLife-Objects-MapObject-CurrentLot 'TinyLife.Objects.MapObject.CurrentLot')
  - [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map')
  - [Position](#P-TinyLife-Objects-MapObject-Position 'TinyLife.Objects.MapObject.Position')
  - [Draw(time,batch,drawPos,overrideColor)](#M-TinyLife-Objects-MapObject-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}- 'TinyLife.Objects.MapObject.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color})')
  - [GetAiPriority(person)](#M-TinyLife-Objects-MapObject-GetAiPriority-TinyLife-Objects-Person- 'TinyLife.Objects.MapObject.GetAiPriority(TinyLife.Objects.Person)')
  - [GetCategories(person)](#M-TinyLife-Objects-MapObject-GetCategories-TinyLife-Objects-Person- 'TinyLife.Objects.MapObject.GetCategories(TinyLife.Objects.Person)')
  - [GetHoverInfo()](#M-TinyLife-Objects-MapObject-GetHoverInfo 'TinyLife.Objects.MapObject.GetHoverInfo')
  - [GetModCategory(name)](#M-TinyLife-Objects-MapObject-GetModCategory-System-String- 'TinyLife.Objects.MapObject.GetModCategory(System.String)')
  - [Intersects(rectangle)](#M-TinyLife-Objects-MapObject-Intersects-MLEM-Misc-RectangleF- 'TinyLife.Objects.MapObject.Intersects(MLEM.Misc.RectangleF)')
  - [OnAdded()](#M-TinyLife-Objects-MapObject-OnAdded 'TinyLife.Objects.MapObject.OnAdded')
  - [OnRemoved()](#M-TinyLife-Objects-MapObject-OnRemoved 'TinyLife.Objects.MapObject.OnRemoved')
  - [SetMapAndValidate(map)](#M-TinyLife-Objects-MapObject-SetMapAndValidate-TinyLife-World-Map- 'TinyLife.Objects.MapObject.SetMapAndValidate(TinyLife.World.Map)')
  - [Validate()](#M-TinyLife-Objects-MapObject-Validate 'TinyLife.Objects.MapObject.Validate')
- [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection')
  - [#ctor(map,sectionPos)](#M-TinyLife-World-MapSection-#ctor-TinyLife-World-Map,Microsoft-Xna-Framework-Point- 'TinyLife.World.MapSection.#ctor(TinyLife.World.Map,Microsoft.Xna.Framework.Point)')
  - [SectionPos](#F-TinyLife-World-MapSection-SectionPos 'TinyLife.World.MapSection.SectionPos')
  - [Size](#F-TinyLife-World-MapSection-Size 'TinyLife.World.MapSection.Size')
  - [Pos](#P-TinyLife-World-MapSection-Pos 'TinyLife.World.MapSection.Pos')
  - [RemoveOutdatedRooms()](#M-TinyLife-World-MapSection-RemoveOutdatedRooms 'TinyLife.World.MapSection.RemoveOutdatedRooms')
  - [Update(time,passedInGame,speed)](#M-TinyLife-World-MapSection-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.World.MapSection.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-World-MapSection-Validate 'TinyLife.World.MapSection.Validate')
- [Mod](#T-TinyLife-Mods-Mod 'TinyLife.Mods.Mod')
  - [Description](#P-TinyLife-Mods-Mod-Description 'TinyLife.Mods.Mod.Description')
  - [Icon](#P-TinyLife-Mods-Mod-Icon 'TinyLife.Mods.Mod.Icon')
  - [Name](#P-TinyLife-Mods-Mod-Name 'TinyLife.Mods.Mod.Name')
  - [AddGameContent(game)](#M-TinyLife-Mods-Mod-AddGameContent-TinyLife-GameImpl- 'TinyLife.Mods.Mod.AddGameContent(TinyLife.GameImpl)')
  - [GetCustomFurnitureTextures()](#M-TinyLife-Mods-Mod-GetCustomFurnitureTextures 'TinyLife.Mods.Mod.GetCustomFurnitureTextures')
  - [Initialize(logger,content,texturePacker)](#M-TinyLife-Mods-Mod-Initialize-ExtremelySimpleLogger-Logger,MLEM-Data-Content-RawContentManager,MLEM-Data-RuntimeTexturePacker- 'TinyLife.Mods.Mod.Initialize(ExtremelySimpleLogger.Logger,MLEM.Data.Content.RawContentManager,MLEM.Data.RuntimeTexturePacker)')
- [ModInfo](#T-TinyLife-Mods-ModInfo 'TinyLife.Mods.ModInfo')
  - [Content](#F-TinyLife-Mods-ModInfo-Content 'TinyLife.Mods.ModInfo.Content')
  - [Id](#F-TinyLife-Mods-ModInfo-Id 'TinyLife.Mods.ModInfo.Id')
  - [Logger](#F-TinyLife-Mods-ModInfo-Logger 'TinyLife.Mods.ModInfo.Logger')
  - [Mod](#F-TinyLife-Mods-ModInfo-Mod 'TinyLife.Mods.ModInfo.Mod')
  - [Dispose()](#M-TinyLife-Mods-ModInfo-Dispose 'TinyLife.Mods.ModInfo.Dispose')
- [ModLoader](#T-TinyLife-Mods-ModLoader 'TinyLife.Mods.ModLoader')
  - [GetModsFolder()](#M-TinyLife-Mods-ModLoader-GetModsFolder 'TinyLife.Mods.ModLoader.GetModsFolder')
  - [TryGetModInfo(id,info)](#M-TinyLife-Mods-ModLoader-TryGetModInfo-System-String,TinyLife-Mods-ModInfo@- 'TinyLife.Mods.ModLoader.TryGetModInfo(System.String,TinyLife.Mods.ModInfo@)')
- [MoveLotTool](#T-TinyLife-Tools-MoveLotTool 'TinyLife.Tools.MoveLotTool')
  - [#ctor()](#M-TinyLife-Tools-MoveLotTool-#ctor 'TinyLife.Tools.MoveLotTool.#ctor')
  - [InitBuildModeUi()](#M-TinyLife-Tools-MoveLotTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.MoveLotTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-MoveLotTool-ShouldHighlightSelectedObject 'TinyLife.Tools.MoveLotTool.ShouldHighlightSelectedObject')
- [MoveTool](#T-TinyLife-Tools-MoveTool 'TinyLife.Tools.MoveTool')
  - [#ctor()](#M-TinyLife-Tools-MoveTool-#ctor 'TinyLife.Tools.MoveTool.#ctor')
  - [CanSaveOrSwitchModes()](#M-TinyLife-Tools-MoveTool-CanSaveOrSwitchModes 'TinyLife.Tools.MoveTool.CanSaveOrSwitchModes')
  - [Draw()](#M-TinyLife-Tools-MoveTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.MoveTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [ForceWallsUp()](#M-TinyLife-Tools-MoveTool-ForceWallsUp 'TinyLife.Tools.MoveTool.ForceWallsUp')
  - [GetMouseCursor()](#M-TinyLife-Tools-MoveTool-GetMouseCursor 'TinyLife.Tools.MoveTool.GetMouseCursor')
  - [InitBuildModeUi()](#M-TinyLife-Tools-MoveTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.MoveTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-MoveTool-ShouldHighlightSelectedObject 'TinyLife.Tools.MoveTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-MoveTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.MoveTool.Update(Microsoft.Xna.Framework.GameTime)')
- [MultiAction](#T-TinyLife-Actions-MultiAction 'TinyLife.Actions.MultiAction')
  - [#ctor()](#M-TinyLife-Actions-MultiAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.MultiAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [FirstActions](#P-TinyLife-Actions-MultiAction-FirstActions 'TinyLife.Actions.MultiAction.FirstActions')
  - [MainElapsedTime](#P-TinyLife-Actions-MultiAction-MainElapsedTime 'TinyLife.Actions.MultiAction.MainElapsedTime')
  - [NextActions](#P-TinyLife-Actions-MultiAction-NextActions 'TinyLife.Actions.MultiAction.NextActions')
  - [AndThenInitialize()](#M-TinyLife-Actions-MultiAction-AndThenInitialize 'TinyLife.Actions.MultiAction.AndThenInitialize')
  - [AndThenIsCompleted()](#M-TinyLife-Actions-MultiAction-AndThenIsCompleted 'TinyLife.Actions.MultiAction.AndThenIsCompleted')
  - [AndThenOnCompleted(type)](#M-TinyLife-Actions-MultiAction-AndThenOnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.AndThenOnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [AndThenUpdate(time,passedInGame,speed)](#M-TinyLife-Actions-MultiAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.MultiAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [CanCancel()](#M-TinyLife-Actions-MultiAction-CanCancel-TinyLife-Actions-Action- 'TinyLife.Actions.MultiAction.CanCancel(TinyLife.Actions.Action)')
  - [CreateFirstActions()](#M-TinyLife-Actions-MultiAction-CreateFirstActions 'TinyLife.Actions.MultiAction.CreateFirstActions')
  - [CreateNextActions(type)](#M-TinyLife-Actions-MultiAction-CreateNextActions-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.CreateNextActions(TinyLife.Actions.Action.CompletionType)')
  - [Initialize()](#M-TinyLife-Actions-MultiAction-Initialize 'TinyLife.Actions.MultiAction.Initialize')
  - [IsCompleted()](#M-TinyLife-Actions-MultiAction-IsCompleted 'TinyLife.Actions.MultiAction.IsCompleted')
  - [OnBetweenActions(time,passedInGame,speed,completedAction,completion)](#M-TinyLife-Actions-MultiAction-OnBetweenActions-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed,TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.OnBetweenActions(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed,TinyLife.Actions.Action,TinyLife.Actions.Action.CompletionType)')
  - [OnCompleted()](#M-TinyLife-Actions-MultiAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.OnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [ShouldFail(completedAction,completion)](#M-TinyLife-Actions-MultiAction-ShouldFail-TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.ShouldFail(TinyLife.Actions.Action,TinyLife.Actions.Action.CompletionType)')
  - [Update()](#M-TinyLife-Actions-MultiAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.MultiAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-Actions-MultiAction-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.MultiAction.Validate(TinyLife.Objects.Person)')
- [Need](#T-TinyLife-Need 'TinyLife.Need')
  - [#ctor(type)](#M-TinyLife-Need-#ctor-TinyLife-NeedType- 'TinyLife.Need.#ctor(TinyLife.NeedType)')
  - [Max](#F-TinyLife-Need-Max 'TinyLife.Need.Max')
  - [Type](#F-TinyLife-Need-Type 'TinyLife.Need.Type')
  - [Percentage](#P-TinyLife-Need-Percentage 'TinyLife.Need.Percentage')
  - [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value')
- [NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType')
  - [#ctor(name,passiveReduction,needLowAction,needLowTime,solveImportance)](#M-TinyLife-NeedType-#ctor-System-String,System-Single,System-Func{TinyLife-Objects-Person,TinyLife-Actions-ActionType},System-Func{TinyLife-Objects-Person,System-TimeSpan},System-Single- 'TinyLife.NeedType.#ctor(System.String,System.Single,System.Func{TinyLife.Objects.Person,TinyLife.Actions.ActionType},System.Func{TinyLife.Objects.Person,System.TimeSpan},System.Single)')
  - [Name](#F-TinyLife-NeedType-Name 'TinyLife.NeedType.Name')
  - [NeedLowAction](#F-TinyLife-NeedType-NeedLowAction 'TinyLife.NeedType.NeedLowAction')
  - [NeedLowTime](#F-TinyLife-NeedType-NeedLowTime 'TinyLife.NeedType.NeedLowTime')
  - [PassiveReduction](#F-TinyLife-NeedType-PassiveReduction 'TinyLife.NeedType.PassiveReduction')
  - [SolveImportance](#F-TinyLife-NeedType-SolveImportance 'TinyLife.NeedType.SolveImportance')
  - [Types](#F-TinyLife-NeedType-Types 'TinyLife.NeedType.Types')
  - [Register(type)](#M-TinyLife-NeedType-Register-TinyLife-NeedType- 'TinyLife.NeedType.Register(TinyLife.NeedType)')
- [Notifications](#T-TinyLife-Uis-Notifications 'TinyLife.Uis.Notifications')
  - [Add(obj,content)](#M-TinyLife-Uis-Notifications-Add-TinyLife-Objects-MapObject,System-String- 'TinyLife.Uis.Notifications.Add(TinyLife.Objects.MapObject,System.String)')
  - [Add(icon,content)](#M-TinyLife-Uis-Notifications-Add-MLEM-Textures-TextureRegion,System-String- 'TinyLife.Uis.Notifications.Add(MLEM.Textures.TextureRegion,System.String)')
- [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory')
  - [Bed](#F-TinyLife-Objects-ObjectCategory-Bed 'TinyLife.Objects.ObjectCategory.Bed')
  - [Bookshelf](#F-TinyLife-Objects-ObjectCategory-Bookshelf 'TinyLife.Objects.ObjectCategory.Bookshelf')
  - [Chair](#F-TinyLife-Objects-ObjectCategory-Chair 'TinyLife.Objects.ObjectCategory.Chair')
  - [Cleanable](#F-TinyLife-Objects-ObjectCategory-Cleanable 'TinyLife.Objects.ObjectCategory.Cleanable')
  - [Computer](#F-TinyLife-Objects-ObjectCategory-Computer 'TinyLife.Objects.ObjectCategory.Computer')
  - [Counter](#F-TinyLife-Objects-ObjectCategory-Counter 'TinyLife.Objects.ObjectCategory.Counter')
  - [CounterObject](#F-TinyLife-Objects-ObjectCategory-CounterObject 'TinyLife.Objects.ObjectCategory.CounterObject')
  - [DeskObject](#F-TinyLife-Objects-ObjectCategory-DeskObject 'TinyLife.Objects.ObjectCategory.DeskObject')
  - [DisallowedOnGround](#F-TinyLife-Objects-ObjectCategory-DisallowedOnGround 'TinyLife.Objects.ObjectCategory.DisallowedOnGround')
  - [Easel](#F-TinyLife-Objects-ObjectCategory-Easel 'TinyLife.Objects.ObjectCategory.Easel')
  - [ForceGridPlacement](#F-TinyLife-Objects-ObjectCategory-ForceGridPlacement 'TinyLife.Objects.ObjectCategory.ForceGridPlacement')
  - [Fridge](#F-TinyLife-Objects-ObjectCategory-Fridge 'TinyLife.Objects.ObjectCategory.Fridge')
  - [GentleCulling](#F-TinyLife-Objects-ObjectCategory-GentleCulling 'TinyLife.Objects.ObjectCategory.GentleCulling')
  - [Gravestone](#F-TinyLife-Objects-ObjectCategory-Gravestone 'TinyLife.Objects.ObjectCategory.Gravestone')
  - [Ground](#F-TinyLife-Objects-ObjectCategory-Ground 'TinyLife.Objects.ObjectCategory.Ground')
  - [Holdable](#F-TinyLife-Objects-ObjectCategory-Holdable 'TinyLife.Objects.ObjectCategory.Holdable')
  - [Mailbox](#F-TinyLife-Objects-ObjectCategory-Mailbox 'TinyLife.Objects.ObjectCategory.Mailbox')
  - [Mirror](#F-TinyLife-Objects-ObjectCategory-Mirror 'TinyLife.Objects.ObjectCategory.Mirror')
  - [NaturalGroundRequired](#F-TinyLife-Objects-ObjectCategory-NaturalGroundRequired 'TinyLife.Objects.ObjectCategory.NaturalGroundRequired')
  - [NonBuyable](#F-TinyLife-Objects-ObjectCategory-NonBuyable 'TinyLife.Objects.ObjectCategory.NonBuyable')
  - [NonColliding](#F-TinyLife-Objects-ObjectCategory-NonColliding 'TinyLife.Objects.ObjectCategory.NonColliding')
  - [NonMovable](#F-TinyLife-Objects-ObjectCategory-NonMovable 'TinyLife.Objects.ObjectCategory.NonMovable')
  - [NonSellable](#F-TinyLife-Objects-ObjectCategory-NonSellable 'TinyLife.Objects.ObjectCategory.NonSellable')
  - [Nothing](#F-TinyLife-Objects-ObjectCategory-Nothing 'TinyLife.Objects.ObjectCategory.Nothing')
  - [People](#F-TinyLife-Objects-ObjectCategory-People 'TinyLife.Objects.ObjectCategory.People')
  - [Self](#F-TinyLife-Objects-ObjectCategory-Self 'TinyLife.Objects.ObjectCategory.Self')
  - [Shower](#F-TinyLife-Objects-ObjectCategory-Shower 'TinyLife.Objects.ObjectCategory.Shower')
  - [Sink](#F-TinyLife-Objects-ObjectCategory-Sink 'TinyLife.Objects.ObjectCategory.Sink')
  - [SmallObject](#F-TinyLife-Objects-ObjectCategory-SmallObject 'TinyLife.Objects.ObjectCategory.SmallObject')
  - [Stove](#F-TinyLife-Objects-ObjectCategory-Stove 'TinyLife.Objects.ObjectCategory.Stove')
  - [Table](#F-TinyLife-Objects-ObjectCategory-Table 'TinyLife.Objects.ObjectCategory.Table')
  - [Toilet](#F-TinyLife-Objects-ObjectCategory-Toilet 'TinyLife.Objects.ObjectCategory.Toilet')
  - [Tree](#F-TinyLife-Objects-ObjectCategory-Tree 'TinyLife.Objects.ObjectCategory.Tree')
  - [WallHanging](#F-TinyLife-Objects-ObjectCategory-WallHanging 'TinyLife.Objects.ObjectCategory.WallHanging')
  - [Wardrobe](#F-TinyLife-Objects-ObjectCategory-Wardrobe 'TinyLife.Objects.ObjectCategory.Wardrobe')
- [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot')
  - [#ctor(offset,isFurnitureAllowed,yOffset,validDirections)](#M-TinyLife-Objects-ObjectSpot-#ctor-Microsoft-Xna-Framework-Vector2,System-Predicate{TinyLife-Objects-FurnitureType},System-Single,MLEM-Misc-Direction2[]- 'TinyLife.Objects.ObjectSpot.#ctor(Microsoft.Xna.Framework.Vector2,System.Predicate{TinyLife.Objects.FurnitureType},System.Single,MLEM.Misc.Direction2[])')
  - [#ctor(offset,visualOffset,isFurnitureAllowed,yOffset,validDirections)](#M-TinyLife-Objects-ObjectSpot-#ctor-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Predicate{TinyLife-Objects-FurnitureType},System-Single,MLEM-Misc-Direction2[]- 'TinyLife.Objects.ObjectSpot.#ctor(Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Predicate{TinyLife.Objects.FurnitureType},System.Single,MLEM.Misc.Direction2[])')
  - [IsFurnitureAllowed](#F-TinyLife-Objects-ObjectSpot-IsFurnitureAllowed 'TinyLife.Objects.ObjectSpot.IsFurnitureAllowed')
  - [CounterSpots(stove)](#M-TinyLife-Objects-ObjectSpot-CounterSpots-System-Boolean- 'TinyLife.Objects.ObjectSpot.CounterSpots(System.Boolean)')
  - [GetContents\`\`1(furniture)](#M-TinyLife-Objects-ObjectSpot-GetContents``1-TinyLife-Objects-Furniture- 'TinyLife.Objects.ObjectSpot.GetContents``1(TinyLife.Objects.Furniture)')
  - [TableSpots(size)](#M-TinyLife-Objects-ObjectSpot-TableSpots-Microsoft-Xna-Framework-Point- 'TinyLife.Objects.ObjectSpot.TableSpots(Microsoft.Xna.Framework.Point)')
- [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening')
  - [#ctor(type,color)](#M-TinyLife-World-Opening-#ctor-TinyLife-World-OpeningType,System-Int32- 'TinyLife.World.Opening.#ctor(TinyLife.World.OpeningType,System.Int32)')
  - [Color](#F-TinyLife-World-Opening-Color 'TinyLife.World.Opening.Color')
  - [Type](#F-TinyLife-World-Opening-Type 'TinyLife.World.Opening.Type')
  - [CanWalkThrough()](#M-TinyLife-World-Opening-CanWalkThrough 'TinyLife.World.Opening.CanWalkThrough')
  - [GetPrice()](#M-TinyLife-World-Opening-GetPrice 'TinyLife.World.Opening.GetPrice')
- [OpeningTool](#T-TinyLife-Tools-OpeningTool 'TinyLife.Tools.OpeningTool')
  - [#ctor()](#M-TinyLife-Tools-OpeningTool-#ctor 'TinyLife.Tools.OpeningTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-OpeningTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.OpeningTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [GetMouseCursor()](#M-TinyLife-Tools-OpeningTool-GetMouseCursor 'TinyLife.Tools.OpeningTool.GetMouseCursor')
  - [InitBuildModeUi()](#M-TinyLife-Tools-OpeningTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.OpeningTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-OpeningTool-ShouldHighlightSelectedObject 'TinyLife.Tools.OpeningTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-OpeningTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.OpeningTool.Update(Microsoft.Xna.Framework.GameTime)')
- [OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType')
  - [#ctor(name,textureRegion,wallMode,price,construct,colorScheme,icon)](#M-TinyLife-World-OpeningType-#ctor-System-String,MLEM-Textures-TextureRegion,TinyLife-World-WallMode,System-Int32,System-Func{TinyLife-World-OpeningType,System-Int32,TinyLife-World-Wall,TinyLife-World-Opening},TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion- 'TinyLife.World.OpeningType.#ctor(System.String,MLEM.Textures.TextureRegion,TinyLife.World.WallMode,System.Int32,System.Func{TinyLife.World.OpeningType,System.Int32,TinyLife.World.Wall,TinyLife.World.Opening},TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)')
  - [ColorScheme](#F-TinyLife-World-OpeningType-ColorScheme 'TinyLife.World.OpeningType.ColorScheme')
  - [Icon](#F-TinyLife-World-OpeningType-Icon 'TinyLife.World.OpeningType.Icon')
  - [Name](#F-TinyLife-World-OpeningType-Name 'TinyLife.World.OpeningType.Name')
  - [Price](#F-TinyLife-World-OpeningType-Price 'TinyLife.World.OpeningType.Price')
  - [Types](#F-TinyLife-World-OpeningType-Types 'TinyLife.World.OpeningType.Types')
  - [WallMode](#F-TinyLife-World-OpeningType-WallMode 'TinyLife.World.OpeningType.WallMode')
  - [Construct(color,wall)](#M-TinyLife-World-OpeningType-Construct-System-Int32,TinyLife-World-Wall- 'TinyLife.World.OpeningType.Construct(System.Int32,TinyLife.World.Wall)')
  - [Draw(time,batch,drawPos,vertical,scale,depth,color)](#M-TinyLife-World-OpeningType-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Boolean,System-Single,System-Single,System-Int32- 'TinyLife.World.OpeningType.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Boolean,System.Single,System.Single,System.Int32)')
  - [DrawUi(e,batch,time,color,drawScale)](#M-TinyLife-World-OpeningType-DrawUi-MLEM-Ui-Elements-Element,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-GameTime,System-Int32,System-Single- 'TinyLife.World.OpeningType.DrawUi(MLEM.Ui.Elements.Element,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.GameTime,System.Int32,System.Single)')
  - [Register(type)](#M-TinyLife-World-OpeningType-Register-TinyLife-World-OpeningType- 'TinyLife.World.OpeningType.Register(TinyLife.World.OpeningType)')
- [Options](#T-TinyLife-Options 'TinyLife.Options')
  - [Fullscreen](#F-TinyLife-Options-Fullscreen 'TinyLife.Options.Fullscreen')
  - [GameSpeeds](#F-TinyLife-Options-GameSpeeds 'TinyLife.Options.GameSpeeds')
  - [Language](#F-TinyLife-Options-Language 'TinyLife.Options.Language')
  - [SoundVolume](#F-TinyLife-Options-SoundVolume 'TinyLife.Options.SoundVolume')
  - [UiScale](#F-TinyLife-Options-UiScale 'TinyLife.Options.UiScale')
  - [VSync](#F-TinyLife-Options-VSync 'TinyLife.Options.VSync')
  - [WallDisplays](#F-TinyLife-Options-WallDisplays 'TinyLife.Options.WallDisplays')
  - [Instance](#P-TinyLife-Options-Instance 'TinyLife.Options.Instance')
  - [WallMode](#P-TinyLife-Options-WallMode 'TinyLife.Options.WallMode')
  - [Apply()](#M-TinyLife-Options-Apply 'TinyLife.Options.Apply')
  - [Load()](#M-TinyLife-Options-Load 'TinyLife.Options.Load')
  - [Save()](#M-TinyLife-Options-Save 'TinyLife.Options.Save')
- [OutOfTownAction](#T-TinyLife-Actions-OutOfTownAction 'TinyLife.Actions.OutOfTownAction')
  - [#ctor(type,info,needsToTakeCareOf)](#M-TinyLife-Actions-OutOfTownAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,TinyLife-NeedType[]- 'TinyLife.Actions.OutOfTownAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,TinyLife.NeedType[])')
  - [NeedsToTakeCareOf](#F-TinyLife-Actions-OutOfTownAction-NeedsToTakeCareOf 'TinyLife.Actions.OutOfTownAction.NeedsToTakeCareOf')
  - [AndThenInitialize()](#M-TinyLife-Actions-OutOfTownAction-AndThenInitialize 'TinyLife.Actions.OutOfTownAction.AndThenInitialize')
  - [AndThenUpdate()](#M-TinyLife-Actions-OutOfTownAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.OutOfTownAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [CanEnqueueConversation()](#M-TinyLife-Actions-OutOfTownAction-CanEnqueueConversation-TinyLife-Objects-Person,TinyLife-Actions-ActionType- 'TinyLife.Actions.OutOfTownAction.CanEnqueueConversation(TinyLife.Objects.Person,TinyLife.Actions.ActionType)')
  - [CausesExtremelyFastSpeed()](#M-TinyLife-Actions-OutOfTownAction-CausesExtremelyFastSpeed 'TinyLife.Actions.OutOfTownAction.CausesExtremelyFastSpeed')
  - [CreateFirstActions()](#M-TinyLife-Actions-OutOfTownAction-CreateFirstActions 'TinyLife.Actions.OutOfTownAction.CreateFirstActions')
  - [GetClosestExitRoad()](#M-TinyLife-Actions-OutOfTownAction-GetClosestExitRoad 'TinyLife.Actions.OutOfTownAction.GetClosestExitRoad')
  - [GetNextAction()](#M-TinyLife-Actions-OutOfTownAction-GetNextAction-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.OutOfTownAction.GetNextAction(TinyLife.Actions.Action.CompletionType)')
- [Painting](#T-TinyLife-Objects-Painting 'TinyLife.Objects.Painting')
- [Painting](#T-TinyLife-Skills-Painting 'TinyLife.Skills.Painting')
  - [#ctor()](#M-TinyLife-Objects-Painting-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Painting.#ctor(System.Guid,TinyLife.Objects.FurnitureType,System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [Creator](#F-TinyLife-Objects-Painting-Creator 'TinyLife.Objects.Painting.Creator')
  - [PaintingType](#F-TinyLife-Objects-Painting-PaintingType 'TinyLife.Objects.Painting.PaintingType')
  - [Progress](#F-TinyLife-Objects-Painting-Progress 'TinyLife.Objects.Painting.Progress')
  - [Quality](#F-TinyLife-Objects-Painting-Quality 'TinyLife.Objects.Painting.Quality')
  - [PaintingTypes](#F-TinyLife-Skills-Painting-PaintingTypes 'TinyLife.Skills.Painting.PaintingTypes')
  - [Draw()](#M-TinyLife-Objects-Painting-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean- 'TinyLife.Objects.Painting.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color},MLEM.Misc.Direction2,System.Int32[],System.Single,System.Boolean,TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot,System.Single,System.Boolean)')
  - [GetHoverInfo()](#M-TinyLife-Objects-Painting-GetHoverInfo 'TinyLife.Objects.Painting.GetHoverInfo')
  - [Validate()](#M-TinyLife-Objects-Painting-Validate 'TinyLife.Objects.Painting.Validate')
  - [RegisterPaintingType(type)](#M-TinyLife-Skills-Painting-RegisterPaintingType-TinyLife-Skills-Painting-PaintingType- 'TinyLife.Skills.Painting.RegisterPaintingType(TinyLife.Skills.Painting.PaintingType)')
- [PaintingType](#T-TinyLife-Skills-Painting-PaintingType 'TinyLife.Skills.Painting.PaintingType')
  - [#ctor(name,levelRange,baseMarkup)](#M-TinyLife-Skills-Painting-PaintingType-#ctor-System-String,MonoGame-Extended-Range{System-Int32},System-Single- 'TinyLife.Skills.Painting.PaintingType.#ctor(System.String,MonoGame.Extended.Range{System.Int32},System.Single)')
  - [BaseMarkup](#F-TinyLife-Skills-Painting-PaintingType-BaseMarkup 'TinyLife.Skills.Painting.PaintingType.BaseMarkup')
  - [LevelRange](#F-TinyLife-Skills-Painting-PaintingType-LevelRange 'TinyLife.Skills.Painting.PaintingType.LevelRange')
  - [Name](#F-TinyLife-Skills-Painting-PaintingType-Name 'TinyLife.Skills.Painting.PaintingType.Name')
  - [Texture](#F-TinyLife-Skills-Painting-PaintingType-Texture 'TinyLife.Skills.Painting.PaintingType.Texture')
- [Particle](#T-TinyLife-Objects-Particle 'TinyLife.Objects.Particle')
  - [#ctor(region,timeToLive,position)](#M-TinyLife-Objects-Particle-#ctor-MLEM-Textures-TextureRegion,System-TimeSpan,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Particle.#ctor(MLEM.Textures.TextureRegion,System.TimeSpan,Microsoft.Xna.Framework.Vector2)')
  - [#ctor(animation,timeToLive,position)](#M-TinyLife-Objects-Particle-#ctor-MLEM-Animations-SpriteAnimation,System-TimeSpan,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Particle.#ctor(MLEM.Animations.SpriteAnimation,System.TimeSpan,Microsoft.Xna.Framework.Vector2)')
  - [Animation](#F-TinyLife-Objects-Particle-Animation 'TinyLife.Objects.Particle.Animation')
  - [DepthOffset](#F-TinyLife-Objects-Particle-DepthOffset 'TinyLife.Objects.Particle.DepthOffset')
  - [DrawOffset](#F-TinyLife-Objects-Particle-DrawOffset 'TinyLife.Objects.Particle.DrawOffset')
  - [Friction](#F-TinyLife-Objects-Particle-Friction 'TinyLife.Objects.Particle.Friction')
  - [Motion](#F-TinyLife-Objects-Particle-Motion 'TinyLife.Objects.Particle.Motion')
  - [Position](#F-TinyLife-Objects-Particle-Position 'TinyLife.Objects.Particle.Position')
  - [Scale](#F-TinyLife-Objects-Particle-Scale 'TinyLife.Objects.Particle.Scale')
  - [TimeLived](#F-TinyLife-Objects-Particle-TimeLived 'TinyLife.Objects.Particle.TimeLived')
  - [TimeToLive](#F-TinyLife-Objects-Particle-TimeToLive 'TinyLife.Objects.Particle.TimeToLive')
  - [Map](#P-TinyLife-Objects-Particle-Map 'TinyLife.Objects.Particle.Map')
  - [Draw(time,batch,drawPos)](#M-TinyLife-Objects-Particle-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Particle.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2)')
  - [Spawn(particle)](#M-TinyLife-Objects-Particle-Spawn-TinyLife-Objects-Particle- 'TinyLife.Objects.Particle.Spawn(TinyLife.Objects.Particle)')
  - [Update(time,passedInGame,speed)](#M-TinyLife-Objects-Particle-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Particle.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [PathfindAction](#T-TinyLife-Actions-PathfindAction 'TinyLife.Actions.PathfindAction')
  - [#ctor()](#M-TinyLife-Actions-PathfindAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.PathfindAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [Path](#P-TinyLife-Actions-PathfindAction-Path 'TinyLife.Actions.PathfindAction.Path')
  - [PathReady](#P-TinyLife-Actions-PathfindAction-PathReady 'TinyLife.Actions.PathfindAction.PathReady')
  - [FindPath(goal)](#M-TinyLife-Actions-PathfindAction-FindPath-Microsoft-Xna-Framework-Point- 'TinyLife.Actions.PathfindAction.FindPath(Microsoft.Xna.Framework.Point)')
  - [GetSpeed()](#M-TinyLife-Actions-PathfindAction-GetSpeed 'TinyLife.Actions.PathfindAction.GetSpeed')
  - [Initialize()](#M-TinyLife-Actions-PathfindAction-Initialize 'TinyLife.Actions.PathfindAction.Initialize')
  - [IsCompleted()](#M-TinyLife-Actions-PathfindAction-IsCompleted 'TinyLife.Actions.PathfindAction.IsCompleted')
  - [OnCompleted()](#M-TinyLife-Actions-PathfindAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.PathfindAction.OnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [OnPathReady()](#M-TinyLife-Actions-PathfindAction-OnPathReady 'TinyLife.Actions.PathfindAction.OnPathReady')
  - [Update()](#M-TinyLife-Actions-PathfindAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.PathfindAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [PerSaveOptions](#T-TinyLife-PerSaveOptions 'TinyLife.PerSaveOptions')
  - [DisableAiHousehold](#F-TinyLife-PerSaveOptions-DisableAiHousehold 'TinyLife.PerSaveOptions.DisableAiHousehold')
  - [DisableAiSelected](#F-TinyLife-PerSaveOptions-DisableAiSelected 'TinyLife.PerSaveOptions.DisableAiSelected')
  - [Instance](#P-TinyLife-PerSaveOptions-Instance 'TinyLife.PerSaveOptions.Instance')
  - [Load()](#M-TinyLife-PerSaveOptions-Load-System-String- 'TinyLife.PerSaveOptions.Load(System.String)')
  - [Save()](#M-TinyLife-PerSaveOptions-Save-System-String- 'TinyLife.PerSaveOptions.Save(System.String)')
- [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')
  - [#ctor(map,position)](#M-TinyLife-Objects-Person-#ctor-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Person.#ctor(TinyLife.World.Map,Microsoft.Xna.Framework.Vector2)')
  - [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue')
  - [Colors](#F-TinyLife-Objects-Person-Colors 'TinyLife.Objects.Person.Colors')
  - [CurrentActions](#F-TinyLife-Objects-Person-CurrentActions 'TinyLife.Objects.Person.CurrentActions')
  - [CurrentPose](#F-TinyLife-Objects-Person-CurrentPose 'TinyLife.Objects.Person.CurrentPose')
  - [EmotionModifiers](#F-TinyLife-Objects-Person-EmotionModifiers 'TinyLife.Objects.Person.EmotionModifiers')
  - [FirstName](#F-TinyLife-Objects-Person-FirstName 'TinyLife.Objects.Person.FirstName')
  - [LastBedSleptIn](#F-TinyLife-Objects-Person-LastBedSleptIn 'TinyLife.Objects.Person.LastBedSleptIn')
  - [LastName](#F-TinyLife-Objects-Person-LastName 'TinyLife.Objects.Person.LastName')
  - [Layers](#F-TinyLife-Objects-Person-Layers 'TinyLife.Objects.Person.Layers')
  - [Needs](#F-TinyLife-Objects-Person-Needs 'TinyLife.Objects.Person.Needs')
  - [PersonalityTypes](#F-TinyLife-Objects-Person-PersonalityTypes 'TinyLife.Objects.Person.PersonalityTypes')
  - [Portrait](#F-TinyLife-Objects-Person-Portrait 'TinyLife.Objects.Person.Portrait')
  - [Relationships](#F-TinyLife-Objects-Person-Relationships 'TinyLife.Objects.Person.Relationships')
  - [Rotation](#F-TinyLife-Objects-Person-Rotation 'TinyLife.Objects.Person.Rotation')
  - [Skills](#F-TinyLife-Objects-Person-Skills 'TinyLife.Objects.Person.Skills')
  - [WornLayers](#F-TinyLife-Objects-Person-WornLayers 'TinyLife.Objects.Person.WornLayers')
  - [AllActions](#P-TinyLife-Objects-Person-AllActions 'TinyLife.Objects.Person.AllActions')
  - [CurrentEmote](#P-TinyLife-Objects-Person-CurrentEmote 'TinyLife.Objects.Person.CurrentEmote')
  - [CurrentRoom](#P-TinyLife-Objects-Person-CurrentRoom 'TinyLife.Objects.Person.CurrentRoom')
  - [CurrentRoomDecorativeRating](#P-TinyLife-Objects-Person-CurrentRoomDecorativeRating 'TinyLife.Objects.Person.CurrentRoomDecorativeRating')
  - [DrawSize](#P-TinyLife-Objects-Person-DrawSize 'TinyLife.Objects.Person.DrawSize')
  - [EmoteTime](#P-TinyLife-Objects-Person-EmoteTime 'TinyLife.Objects.Person.EmoteTime')
  - [Emotion](#P-TinyLife-Objects-Person-Emotion 'TinyLife.Objects.Person.Emotion')
  - [FullName](#P-TinyLife-Objects-Person-FullName 'TinyLife.Objects.Person.FullName')
  - [Household](#P-TinyLife-Objects-Person-Household 'TinyLife.Objects.Person.Household')
  - [Job](#P-TinyLife-Objects-Person-Job 'TinyLife.Objects.Person.Job')
  - [LastVisitedLot](#P-TinyLife-Objects-Person-LastVisitedLot 'TinyLife.Objects.Person.LastVisitedLot')
  - [LotVisitCooldown](#P-TinyLife-Objects-Person-LotVisitCooldown 'TinyLife.Objects.Person.LotVisitCooldown')
  - [OccupiedActionSpot](#P-TinyLife-Objects-Person-OccupiedActionSpot 'TinyLife.Objects.Person.OccupiedActionSpot')
  - [OccupiedFurniture](#P-TinyLife-Objects-Person-OccupiedFurniture 'TinyLife.Objects.Person.OccupiedFurniture')
  - [VisualPosition](#P-TinyLife-Objects-Person-VisualPosition 'TinyLife.Objects.Person.VisualPosition')
  - [AddEmotion(type,amount,time)](#M-TinyLife-Objects-Person-AddEmotion-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan- 'TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)')
  - [CanWalkHere(map,currPos,nextPos)](#M-TinyLife-Objects-Person-CanWalkHere-TinyLife-World-Map,Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point- 'TinyLife.Objects.Person.CanWalkHere(TinyLife.World.Map,Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point)')
  - [CancelAction(action,cancelSource,force)](#M-TinyLife-Objects-Person-CancelAction-TinyLife-Actions-Action,TinyLife-Actions-Action,System-Boolean- 'TinyLife.Objects.Person.CancelAction(TinyLife.Actions.Action,TinyLife.Actions.Action,System.Boolean)')
  - [ChangeFriendship(person,amount)](#M-TinyLife-Objects-Person-ChangeFriendship-TinyLife-Objects-Person,System-Single- 'TinyLife.Objects.Person.ChangeFriendship(TinyLife.Objects.Person,System.Single)')
  - [ChangeRomance(person,amount)](#M-TinyLife-Objects-Person-ChangeRomance-TinyLife-Objects-Person,System-Single- 'TinyLife.Objects.Person.ChangeRomance(TinyLife.Objects.Person,System.Single)')
  - [CleanUpForDeletion()](#M-TinyLife-Objects-Person-CleanUpForDeletion 'TinyLife.Objects.Person.CleanUpForDeletion')
  - [DepleteNeed(type,amount,speed)](#M-TinyLife-Objects-Person-DepleteNeed-TinyLife-NeedType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.DepleteNeed(TinyLife.NeedType,System.Single,TinyLife.GameSpeed)')
  - [Die(reason,createGravestone)](#M-TinyLife-Objects-Person-Die-TinyLife-Objects-Person-DeathReason,System-Boolean- 'TinyLife.Objects.Person.Die(TinyLife.Objects.Person.DeathReason,System.Boolean)')
  - [DisplayEmote(possibleCategories)](#M-TinyLife-Objects-Person-DisplayEmote-TinyLife-Actions-EmoteCategory- 'TinyLife.Objects.Person.DisplayEmote(TinyLife.Actions.EmoteCategory)')
  - [Draw()](#M-TinyLife-Objects-Person-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}- 'TinyLife.Objects.Person.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color})')
  - [DrawUi(batch,pos,scale)](#M-TinyLife-Objects-Person-DrawUi-Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Single- 'TinyLife.Objects.Person.DrawUi(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Single)')
  - [EnqueueAction(type,info,automatic,variety,priority,force)](#M-TinyLife-Objects-Person-EnqueueAction-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-Boolean,System-Nullable{TinyLife-Actions-ActionVariety},System-Boolean,System-Boolean- 'TinyLife.Objects.Person.EnqueueAction(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,System.Boolean,System.Nullable{TinyLife.Actions.ActionVariety},System.Boolean,System.Boolean)')
  - [FindPathAsync(start,goal,costFunction,allowDiagonals)](#M-TinyLife-Objects-Person-FindPathAsync-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point,MLEM-Pathfinding-AStar{Microsoft-Xna-Framework-Point}-GetCost,System-Nullable{System-Boolean}- 'TinyLife.Objects.Person.FindPathAsync(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point,MLEM.Pathfinding.AStar{Microsoft.Xna.Framework.Point}.GetCost,System.Nullable{System.Boolean})')
  - [GainSkill(type,amount,speed)](#M-TinyLife-Objects-Person-GainSkill-TinyLife-Skills-SkillType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)')
  - [GetCategories()](#M-TinyLife-Objects-Person-GetCategories-TinyLife-Objects-Person- 'TinyLife.Objects.Person.GetCategories(TinyLife.Objects.Person)')
  - [GetFreeTalkingSpot(personComingToMe)](#M-TinyLife-Objects-Person-GetFreeTalkingSpot-TinyLife-Objects-Person- 'TinyLife.Objects.Person.GetFreeTalkingSpot(TinyLife.Objects.Person)')
  - [GetFreeTalkingSpots()](#M-TinyLife-Objects-Person-GetFreeTalkingSpots 'TinyLife.Objects.Person.GetFreeTalkingSpots')
  - [GetHeldActionInfo()](#M-TinyLife-Objects-Person-GetHeldActionInfo 'TinyLife.Objects.Person.GetHeldActionInfo')
  - [GetHeldObject\`\`1()](#M-TinyLife-Objects-Person-GetHeldObject``1 'TinyLife.Objects.Person.GetHeldObject``1')
  - [GetHomeLocation()](#M-TinyLife-Objects-Person-GetHomeLocation 'TinyLife.Objects.Person.GetHomeLocation')
  - [GetHoverInfo()](#M-TinyLife-Objects-Person-GetHoverInfo 'TinyLife.Objects.Person.GetHoverInfo')
  - [GetNeed(type)](#M-TinyLife-Objects-Person-GetNeed-TinyLife-NeedType- 'TinyLife.Objects.Person.GetNeed(TinyLife.NeedType)')
  - [GetNeedPercentage(type)](#M-TinyLife-Objects-Person-GetNeedPercentage-TinyLife-NeedType- 'TinyLife.Objects.Person.GetNeedPercentage(TinyLife.NeedType)')
  - [GetRelationship(person,initialize)](#M-TinyLife-Objects-Person-GetRelationship-TinyLife-Objects-Person,System-Boolean- 'TinyLife.Objects.Person.GetRelationship(TinyLife.Objects.Person,System.Boolean)')
  - [GetRelationshipType(person)](#M-TinyLife-Objects-Person-GetRelationshipType-TinyLife-Objects-Person- 'TinyLife.Objects.Person.GetRelationshipType(TinyLife.Objects.Person)')
  - [GetSkillLevel(type)](#M-TinyLife-Objects-Person-GetSkillLevel-TinyLife-Skills-SkillType- 'TinyLife.Objects.Person.GetSkillLevel(TinyLife.Skills.SkillType)')
  - [HasPersonality(type)](#M-TinyLife-Objects-Person-HasPersonality-TinyLife-PersonalityType- 'TinyLife.Objects.Person.HasPersonality(TinyLife.PersonalityType)')
  - [HasSkillLevel(type,level)](#M-TinyLife-Objects-Person-HasSkillLevel-TinyLife-Skills-SkillType,System-Int32- 'TinyLife.Objects.Person.HasSkillLevel(TinyLife.Skills.SkillType,System.Int32)')
  - [Intersects()](#M-TinyLife-Objects-Person-Intersects-MLEM-Misc-RectangleF- 'TinyLife.Objects.Person.Intersects(MLEM.Misc.RectangleF)')
  - [IsCloseForTalking(pos)](#M-TinyLife-Objects-Person-IsCloseForTalking-Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Person.IsCloseForTalking(Microsoft.Xna.Framework.Vector2)')
  - [LowerEmotion(type,percentage,speed)](#M-TinyLife-Objects-Person-LowerEmotion-TinyLife-Emotions-EmotionType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.LowerEmotion(TinyLife.Emotions.EmotionType,System.Single,TinyLife.GameSpeed)')
  - [OccupyActionSpot(furniture,spot,enterSpot,rotation)](#M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})')
  - [RemoveEmotion(type)](#M-TinyLife-Objects-Person-RemoveEmotion-TinyLife-Emotions-EmotionModifier- 'TinyLife.Objects.Person.RemoveEmotion(TinyLife.Emotions.EmotionModifier)')
  - [ResetToStatic(resetRelationships)](#M-TinyLife-Objects-Person-ResetToStatic-System-Boolean- 'TinyLife.Objects.Person.ResetToStatic(System.Boolean)')
  - [RestoreNeed(type,amount,speed)](#M-TinyLife-Objects-Person-RestoreNeed-TinyLife-NeedType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.RestoreNeed(TinyLife.NeedType,System.Single,TinyLife.GameSpeed)')
  - [SetHeldObject(furniture)](#M-TinyLife-Objects-Person-SetHeldObject-TinyLife-Objects-Furniture- 'TinyLife.Objects.Person.SetHeldObject(TinyLife.Objects.Furniture)')
  - [SetHeldObject\`\`1(type,colors,id)](#M-TinyLife-Objects-Person-SetHeldObject``1-TinyLife-Objects-FurnitureType,System-Int32[],System-Nullable{System-Guid}- 'TinyLife.Objects.Person.SetHeldObject``1(TinyLife.Objects.FurnitureType,System.Int32[],System.Nullable{System.Guid})')
  - [SetJob(type)](#M-TinyLife-Objects-Person-SetJob-TinyLife-Goals-JobType- 'TinyLife.Objects.Person.SetJob(TinyLife.Goals.JobType)')
  - [StopEmoting()](#M-TinyLife-Objects-Person-StopEmoting 'TinyLife.Objects.Person.StopEmoting')
  - [ToCreatedByString()](#M-TinyLife-Objects-Person-ToCreatedByString 'TinyLife.Objects.Person.ToCreatedByString')
  - [Update()](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-Objects-Person-Validate 'TinyLife.Objects.Person.Validate')
  - [VisitLot(lot)](#M-TinyLife-Objects-Person-VisitLot-TinyLife-World-Lot- 'TinyLife.Objects.Person.VisitLot(TinyLife.World.Lot)')
- [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi')
- [PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType')
  - [#ctor(name,texture,disallowedOthers)](#M-TinyLife-PersonalityType-#ctor-System-String,MLEM-Textures-TextureRegion,TinyLife-PersonalityType[]- 'TinyLife.PersonalityType.#ctor(System.String,MLEM.Textures.TextureRegion,TinyLife.PersonalityType[])')
  - [AmountPerPerson](#F-TinyLife-PersonalityType-AmountPerPerson 'TinyLife.PersonalityType.AmountPerPerson')
  - [DisallowedOthers](#F-TinyLife-PersonalityType-DisallowedOthers 'TinyLife.PersonalityType.DisallowedOthers')
  - [Name](#F-TinyLife-PersonalityType-Name 'TinyLife.PersonalityType.Name')
  - [Texture](#F-TinyLife-PersonalityType-Texture 'TinyLife.PersonalityType.Texture')
  - [Types](#F-TinyLife-PersonalityType-Types 'TinyLife.PersonalityType.Types')
  - [Register(type)](#M-TinyLife-PersonalityType-Register-TinyLife-PersonalityType- 'TinyLife.PersonalityType.Register(TinyLife.PersonalityType)')
- [PlayModeTool](#T-TinyLife-Tools-PlayModeTool 'TinyLife.Tools.PlayModeTool')
  - [#ctor()](#M-TinyLife-Tools-PlayModeTool-#ctor 'TinyLife.Tools.PlayModeTool.#ctor')
  - [SelectedPerson](#P-TinyLife-Tools-PlayModeTool-SelectedPerson 'TinyLife.Tools.PlayModeTool.SelectedPerson')
  - [Closed()](#M-TinyLife-Tools-PlayModeTool-Closed 'TinyLife.Tools.PlayModeTool.Closed')
  - [Opened()](#M-TinyLife-Tools-PlayModeTool-Opened 'TinyLife.Tools.PlayModeTool.Opened')
  - [Update()](#M-TinyLife-Tools-PlayModeTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.PlayModeTool.Update(Microsoft.Xna.Framework.GameTime)')
- [Pose](#T-TinyLife-Objects-Person-Pose 'TinyLife.Objects.Person.Pose')
  - [Laying](#F-TinyLife-Objects-Person-Pose-Laying 'TinyLife.Objects.Person.Pose.Laying')
  - [Sitting](#F-TinyLife-Objects-Person-Pose-Sitting 'TinyLife.Objects.Person.Pose.Sitting')
  - [SittingLegsClose](#F-TinyLife-Objects-Person-Pose-SittingLegsClose 'TinyLife.Objects.Person.Pose.SittingLegsClose')
  - [Standing](#F-TinyLife-Objects-Person-Pose-Standing 'TinyLife.Objects.Person.Pose.Standing')
  - [Walking](#F-TinyLife-Objects-Person-Pose-Walking 'TinyLife.Objects.Person.Pose.Walking')
  - [WorkingSitting](#F-TinyLife-Objects-Person-Pose-WorkingSitting 'TinyLife.Objects.Person.Pose.WorkingSitting')
  - [WorkingStanding](#F-TinyLife-Objects-Person-Pose-WorkingStanding 'TinyLife.Objects.Person.Pose.WorkingStanding')
- [Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality')
  - [Average](#F-TinyLife-Skills-Quality-Average 'TinyLife.Skills.Quality.Average')
  - [Good](#F-TinyLife-Skills-Quality-Good 'TinyLife.Skills.Quality.Good')
  - [Great](#F-TinyLife-Skills-Quality-Great 'TinyLife.Skills.Quality.Great')
  - [Masterpiece](#F-TinyLife-Skills-Quality-Masterpiece 'TinyLife.Skills.Quality.Masterpiece')
  - [Perfect](#F-TinyLife-Skills-Quality-Perfect 'TinyLife.Skills.Quality.Perfect')
  - [Terrible](#F-TinyLife-Skills-Quality-Terrible 'TinyLife.Skills.Quality.Terrible')
- [Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship')
  - [#ctor(otherPerson)](#M-TinyLife-Relationship-#ctor-System-Guid- 'TinyLife.Relationship.#ctor(System.Guid)')
  - [Dating](#F-TinyLife-Relationship-Dating 'TinyLife.Relationship.Dating')
  - [Genealogy](#F-TinyLife-Relationship-Genealogy 'TinyLife.Relationship.Genealogy')
  - [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max')
  - [PassiveFriendReduction](#F-TinyLife-Relationship-PassiveFriendReduction 'TinyLife.Relationship.PassiveFriendReduction')
  - [PassiveRomanceReduction](#F-TinyLife-Relationship-PassiveRomanceReduction 'TinyLife.Relationship.PassiveRomanceReduction')
  - [DisplayString](#P-TinyLife-Relationship-DisplayString 'TinyLife.Relationship.DisplayString')
  - [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel')
  - [FriendPercentage](#P-TinyLife-Relationship-FriendPercentage 'TinyLife.Relationship.FriendPercentage')
  - [OtherPerson](#P-TinyLife-Relationship-OtherPerson 'TinyLife.Relationship.OtherPerson')
  - [RomanceLevel](#P-TinyLife-Relationship-RomanceLevel 'TinyLife.Relationship.RomanceLevel')
  - [RomancePercentage](#P-TinyLife-Relationship-RomancePercentage 'TinyLife.Relationship.RomancePercentage')
  - [Type](#P-TinyLife-Relationship-Type 'TinyLife.Relationship.Type')
- [RelationshipType](#T-TinyLife-RelationshipType 'TinyLife.RelationshipType')
  - [Acquaintances](#F-TinyLife-RelationshipType-Acquaintances 'TinyLife.RelationshipType.Acquaintances')
  - [Disliked](#F-TinyLife-RelationshipType-Disliked 'TinyLife.RelationshipType.Disliked')
  - [Enemies](#F-TinyLife-RelationshipType-Enemies 'TinyLife.RelationshipType.Enemies')
  - [Friends](#F-TinyLife-RelationshipType-Friends 'TinyLife.RelationshipType.Friends')
  - [GoodFriends](#F-TinyLife-RelationshipType-GoodFriends 'TinyLife.RelationshipType.GoodFriends')
- [RemoveTool](#T-TinyLife-Tools-RemoveTool 'TinyLife.Tools.RemoveTool')
  - [#ctor()](#M-TinyLife-Tools-RemoveTool-#ctor 'TinyLife.Tools.RemoveTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-RemoveTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.RemoveTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [GetMouseCursor()](#M-TinyLife-Tools-RemoveTool-GetMouseCursor 'TinyLife.Tools.RemoveTool.GetMouseCursor')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-RemoveTool-ShouldHighlightSelectedObject 'TinyLife.Tools.RemoveTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-RemoveTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.RemoveTool.Update(Microsoft.Xna.Framework.GameTime)')
- [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof')
  - [#ctor(type,area,rotation,color)](#M-TinyLife-World-Roof-#ctor-TinyLife-World-RoofType,Microsoft-Xna-Framework-Rectangle,MLEM-Misc-Direction2,System-Int32- 'TinyLife.World.Roof.#ctor(TinyLife.World.RoofType,Microsoft.Xna.Framework.Rectangle,MLEM.Misc.Direction2,System.Int32)')
  - [Area](#F-TinyLife-World-Roof-Area 'TinyLife.World.Roof.Area')
  - [Color](#F-TinyLife-World-Roof-Color 'TinyLife.World.Roof.Color')
  - [Type](#F-TinyLife-World-Roof-Type 'TinyLife.World.Roof.Type')
  - [Wallpaper](#F-TinyLife-World-Roof-Wallpaper 'TinyLife.World.Roof.Wallpaper')
  - [Rotation](#P-TinyLife-World-Roof-Rotation 'TinyLife.World.Roof.Rotation')
  - [Draw(time,batch,map,type,area,rotation,colorIndex,wallpaper,depthOffset)](#M-TinyLife-World-Roof-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,TinyLife-World-Map,TinyLife-World-RoofType,Microsoft-Xna-Framework-Rectangle,MLEM-Misc-Direction2,System-Int32,TinyLife-World-Wallpaper,System-Single- 'TinyLife.World.Roof.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,TinyLife.World.Map,TinyLife.World.RoofType,Microsoft.Xna.Framework.Rectangle,MLEM.Misc.Direction2,System.Int32,TinyLife.World.Wallpaper,System.Single)')
  - [DrawUi(batch,element,type,colorIndex,drawScale)](#M-TinyLife-World-Roof-DrawUi-Microsoft-Xna-Framework-Graphics-SpriteBatch,MLEM-Ui-Elements-Element,TinyLife-World-RoofType,System-Int32,System-Single- 'TinyLife.World.Roof.DrawUi(Microsoft.Xna.Framework.Graphics.SpriteBatch,MLEM.Ui.Elements.Element,TinyLife.World.RoofType,System.Int32,System.Single)')
  - [GenerateRoof(room)](#M-TinyLife-World-Roof-GenerateRoof-TinyLife-World-Room- 'TinyLife.World.Roof.GenerateRoof(TinyLife.World.Room)')
  - [GetPrice()](#M-TinyLife-World-Roof-GetPrice 'TinyLife.World.Roof.GetPrice')
  - [GetPriceByType(type)](#M-TinyLife-World-Roof-GetPriceByType-TinyLife-World-RoofType- 'TinyLife.World.Roof.GetPriceByType(TinyLife.World.RoofType)')
- [RoofTool](#T-TinyLife-Tools-RoofTool 'TinyLife.Tools.RoofTool')
  - [#ctor()](#M-TinyLife-Tools-RoofTool-#ctor 'TinyLife.Tools.RoofTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-RoofTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.RoofTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [ForceWallsUp()](#M-TinyLife-Tools-RoofTool-ForceWallsUp 'TinyLife.Tools.RoofTool.ForceWallsUp')
  - [InitBuildModeUi()](#M-TinyLife-Tools-RoofTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.RoofTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-RoofTool-ShouldHighlightSelectedObject 'TinyLife.Tools.RoofTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-RoofTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.RoofTool.Update(Microsoft.Xna.Framework.GameTime)')
- [RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType')
  - [Flat](#F-TinyLife-World-RoofType-Flat 'TinyLife.World.RoofType.Flat')
  - [Gable](#F-TinyLife-World-RoofType-Gable 'TinyLife.World.RoofType.Gable')
- [Room](#T-TinyLife-World-Room 'TinyLife.World.Room')
  - [Center](#F-TinyLife-World-Room-Center 'TinyLife.World.Room.Center')
  - [CoveredSections](#F-TinyLife-World-Room-CoveredSections 'TinyLife.World.Room.CoveredSections')
  - [Map](#F-TinyLife-World-Room-Map 'TinyLife.World.Room.Map')
  - [Tiles](#F-TinyLife-World-Room-Tiles 'TinyLife.World.Room.Tiles')
  - [GetConnectedRooms()](#M-TinyLife-World-Room-GetConnectedRooms 'TinyLife.World.Room.GetConnectedRooms')
  - [GetDecorativeRating()](#M-TinyLife-World-Room-GetDecorativeRating 'TinyLife.World.Room.GetDecorativeRating')
  - [GetObjects\`\`1()](#M-TinyLife-World-Room-GetObjects``1 'TinyLife.World.Room.GetObjects``1')
  - [GetWalls(borderOnly)](#M-TinyLife-World-Room-GetWalls-System-Boolean- 'TinyLife.World.Room.GetWalls(System.Boolean)')
  - [IsFullyRoofed()](#M-TinyLife-World-Room-IsFullyRoofed 'TinyLife.World.Room.IsFullyRoofed')
  - [IsSameRoom(tiles)](#M-TinyLife-World-Room-IsSameRoom-System-Collections-Generic-ICollection{Microsoft-Xna-Framework-Point}- 'TinyLife.World.Room.IsSameRoom(System.Collections.Generic.ICollection{Microsoft.Xna.Framework.Point})')
  - [Validate()](#M-TinyLife-World-Room-Validate 'TinyLife.World.Room.Validate')
- [SellAction](#T-TinyLife-Actions-SellAction 'TinyLife.Actions.SellAction')
  - [#ctor()](#M-TinyLife-Actions-SellAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-Single- 'TinyLife.Actions.SellAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,System.Single)')
  - [AndThenInitialize()](#M-TinyLife-Actions-SellAction-AndThenInitialize 'TinyLife.Actions.SellAction.AndThenInitialize')
  - [AndThenIsCompleted()](#M-TinyLife-Actions-SellAction-AndThenIsCompleted 'TinyLife.Actions.SellAction.AndThenIsCompleted')
  - [CreateFirstActions()](#M-TinyLife-Actions-SellAction-CreateFirstActions 'TinyLife.Actions.SellAction.CreateFirstActions')
  - [GetSoldObject\`\`1(info)](#M-TinyLife-Actions-SellAction-GetSoldObject``1-TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SellAction.GetSoldObject``1(TinyLife.Actions.ActionInfo)')
- [SitAction](#T-TinyLife-Actions-SitAction 'TinyLife.Actions.SitAction')
  - [#ctor()](#M-TinyLife-Actions-SitAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SitAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [AndThenInitialize()](#M-TinyLife-Actions-SitAction-AndThenInitialize 'TinyLife.Actions.SitAction.AndThenInitialize')
  - [AndThenIsCompleted()](#M-TinyLife-Actions-SitAction-AndThenIsCompleted 'TinyLife.Actions.SitAction.AndThenIsCompleted')
  - [AndThenUpdate()](#M-TinyLife-Actions-SitAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.SitAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [CanMultitask()](#M-TinyLife-Actions-SitAction-CanMultitask-TinyLife-Actions-Action- 'TinyLife.Actions.SitAction.CanMultitask(TinyLife.Actions.Action)')
  - [CreateFirstActions()](#M-TinyLife-Actions-SitAction-CreateFirstActions 'TinyLife.Actions.SitAction.CreateFirstActions')
- [SitAtDeskObjectAction](#T-TinyLife-Actions-SitAtDeskObjectAction 'TinyLife.Actions.SitAtDeskObjectAction')
  - [#ctor()](#M-TinyLife-Actions-SitAtDeskObjectAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SitAtDeskObjectAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [AndThenUpdate()](#M-TinyLife-Actions-SitAtDeskObjectAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.SitAtDeskObjectAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [CreateFirstActions()](#M-TinyLife-Actions-SitAtDeskObjectAction-CreateFirstActions 'TinyLife.Actions.SitAtDeskObjectAction.CreateFirstActions')
  - [GetChair(info)](#M-TinyLife-Actions-SitAtDeskObjectAction-GetChair-TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SitAtDeskObjectAction.GetChair(TinyLife.Actions.ActionInfo)')
  - [GetChairSpot(info)](#M-TinyLife-Actions-SitAtDeskObjectAction-GetChairSpot-TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SitAtDeskObjectAction.GetChairSpot(TinyLife.Actions.ActionInfo)')
  - [GetNextAction()](#M-TinyLife-Actions-SitAtDeskObjectAction-GetNextAction-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.SitAtDeskObjectAction.GetNextAction(TinyLife.Actions.Action.CompletionType)')
- [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill')
  - [#ctor(type)](#M-TinyLife-Skills-Skill-#ctor-TinyLife-Skills-SkillType- 'TinyLife.Skills.Skill.#ctor(TinyLife.Skills.SkillType)')
  - [Type](#F-TinyLife-Skills-Skill-Type 'TinyLife.Skills.Skill.Type')
  - [Level](#P-TinyLife-Skills-Skill-Level 'TinyLife.Skills.Skill.Level')
  - [PointPercentage](#P-TinyLife-Skills-Skill-PointPercentage 'TinyLife.Skills.Skill.PointPercentage')
  - [PointsToNextLevel](#P-TinyLife-Skills-Skill-PointsToNextLevel 'TinyLife.Skills.Skill.PointsToNextLevel')
  - [Gain(person,amount)](#M-TinyLife-Skills-Skill-Gain-TinyLife-Objects-Person,System-Single- 'TinyLife.Skills.Skill.Gain(TinyLife.Objects.Person,System.Single)')
  - [GetRequiredPointsToNextLevel()](#M-TinyLife-Skills-Skill-GetRequiredPointsToNextLevel 'TinyLife.Skills.Skill.GetRequiredPointsToNextLevel')
- [SkillCategory](#T-TinyLife-Skills-SkillCategory 'TinyLife.Skills.SkillCategory')
  - [Creative](#F-TinyLife-Skills-SkillCategory-Creative 'TinyLife.Skills.SkillCategory.Creative')
  - [Logical](#F-TinyLife-Skills-SkillCategory-Logical 'TinyLife.Skills.SkillCategory.Logical')
  - [None](#F-TinyLife-Skills-SkillCategory-None 'TinyLife.Skills.SkillCategory.None')
  - [Social](#F-TinyLife-Skills-SkillCategory-Social 'TinyLife.Skills.SkillCategory.Social')
- [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType')
  - [#ctor(name,texture,maxLevel,categories)](#M-TinyLife-Skills-SkillType-#ctor-System-String,MLEM-Textures-TextureRegion,System-Int32,TinyLife-Skills-SkillCategory- 'TinyLife.Skills.SkillType.#ctor(System.String,MLEM.Textures.TextureRegion,System.Int32,TinyLife.Skills.SkillCategory)')
  - [Categories](#F-TinyLife-Skills-SkillType-Categories 'TinyLife.Skills.SkillType.Categories')
  - [MaxLevel](#F-TinyLife-Skills-SkillType-MaxLevel 'TinyLife.Skills.SkillType.MaxLevel')
  - [Name](#F-TinyLife-Skills-SkillType-Name 'TinyLife.Skills.SkillType.Name')
  - [Texture](#F-TinyLife-Skills-SkillType-Texture 'TinyLife.Skills.SkillType.Texture')
  - [Types](#F-TinyLife-Skills-SkillType-Types 'TinyLife.Skills.SkillType.Types')
  - [GetRandomQuality(person,random,modifyEmotions)](#M-TinyLife-Skills-SkillType-GetRandomQuality-TinyLife-Objects-Person,System-Random,System-Boolean,System-Boolean- 'TinyLife.Skills.SkillType.GetRandomQuality(TinyLife.Objects.Person,System.Random,System.Boolean,System.Boolean)')
  - [Register(type)](#M-TinyLife-Skills-SkillType-Register-TinyLife-Skills-SkillType- 'TinyLife.Skills.SkillType.Register(TinyLife.Skills.SkillType)')
- [SocialAction](#T-TinyLife-Actions-SocialAction 'TinyLife.Actions.SocialAction')
  - [#ctor()](#M-TinyLife-Actions-SocialAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SocialAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [PartnerCompletion](#F-TinyLife-Actions-SocialAction-PartnerCompletion 'TinyLife.Actions.SocialAction.PartnerCompletion')
  - [ConversationTime](#P-TinyLife-Actions-SocialAction-ConversationTime 'TinyLife.Actions.SocialAction.ConversationTime')
  - [Id](#P-TinyLife-Actions-SocialAction-Id 'TinyLife.Actions.SocialAction.Id')
  - [IsMain](#P-TinyLife-Actions-SocialAction-IsMain 'TinyLife.Actions.SocialAction.IsMain')
  - [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner')
  - [PartnerAction](#P-TinyLife-Actions-SocialAction-PartnerAction 'TinyLife.Actions.SocialAction.PartnerAction')
  - [CanCancel()](#M-TinyLife-Actions-SocialAction-CanCancel-TinyLife-Actions-Action- 'TinyLife.Actions.SocialAction.CanCancel(TinyLife.Actions.Action)')
  - [CanMultitask()](#M-TinyLife-Actions-SocialAction-CanMultitask-TinyLife-Actions-Action- 'TinyLife.Actions.SocialAction.CanMultitask(TinyLife.Actions.Action)')
  - [DisplayConversationEmotes(time,speed,possibleCategories,totalEmoteAmount)](#M-TinyLife-Actions-SocialAction-DisplayConversationEmotes-Microsoft-Xna-Framework-GameTime,TinyLife-GameSpeed,TinyLife-Actions-EmoteCategory,System-Int32- 'TinyLife.Actions.SocialAction.DisplayConversationEmotes(Microsoft.Xna.Framework.GameTime,TinyLife.GameSpeed,TinyLife.Actions.EmoteCategory,System.Int32)')
  - [GetDisplayName()](#M-TinyLife-Actions-SocialAction-GetDisplayName 'TinyLife.Actions.SocialAction.GetDisplayName')
  - [GetTimeWeWaitForPartner()](#M-TinyLife-Actions-SocialAction-GetTimeWeWaitForPartner 'TinyLife.Actions.SocialAction.GetTimeWeWaitForPartner')
  - [Initialize()](#M-TinyLife-Actions-SocialAction-Initialize 'TinyLife.Actions.SocialAction.Initialize')
  - [InitializeConversation()](#M-TinyLife-Actions-SocialAction-InitializeConversation 'TinyLife.Actions.SocialAction.InitializeConversation')
  - [InvokeForBoth(action)](#M-TinyLife-Actions-SocialAction-InvokeForBoth-System-Action{TinyLife-Objects-Person,TinyLife-Objects-Person}- 'TinyLife.Actions.SocialAction.InvokeForBoth(System.Action{TinyLife.Objects.Person,TinyLife.Objects.Person})')
  - [IsCompleted()](#M-TinyLife-Actions-SocialAction-IsCompleted 'TinyLife.Actions.SocialAction.IsCompleted')
  - [IsConversationCompleted()](#M-TinyLife-Actions-SocialAction-IsConversationCompleted 'TinyLife.Actions.SocialAction.IsConversationCompleted')
  - [OnCompleted()](#M-TinyLife-Actions-SocialAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.SocialAction.OnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [Update()](#M-TinyLife-Actions-SocialAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.SocialAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [UpdateConversation(time,passedInGame,speed)](#M-TinyLife-Actions-SocialAction-UpdateConversation-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.SocialAction.UpdateConversation(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate()](#M-TinyLife-Actions-SocialAction-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.SocialAction.Validate(TinyLife.Objects.Person)')
- [StaticJsonConverter\`1](#T-TinyLife-Utilities-StaticJsonConverter`1 'TinyLife.Utilities.StaticJsonConverter`1')
  - [#ctor(entries)](#M-TinyLife-Utilities-StaticJsonConverter`1-#ctor-System-Collections-Generic-Dictionary{System-String,`0}- 'TinyLife.Utilities.StaticJsonConverter`1.#ctor(System.Collections.Generic.Dictionary{System.String,`0})')
  - [ReadJson()](#M-TinyLife-Utilities-StaticJsonConverter`1-ReadJson-Newtonsoft-Json-JsonReader,System-Type,`0,System-Boolean,Newtonsoft-Json-JsonSerializer- 'TinyLife.Utilities.StaticJsonConverter`1.ReadJson(Newtonsoft.Json.JsonReader,System.Type,`0,System.Boolean,Newtonsoft.Json.JsonSerializer)')
  - [WriteJson()](#M-TinyLife-Utilities-StaticJsonConverter`1-WriteJson-Newtonsoft-Json-JsonWriter,`0,Newtonsoft-Json-JsonSerializer- 'TinyLife.Utilities.StaticJsonConverter`1.WriteJson(Newtonsoft.Json.JsonWriter,`0,Newtonsoft.Json.JsonSerializer)')
- [TalkAction](#T-TinyLife-Actions-TalkAction 'TinyLife.Actions.TalkAction')
  - [#ctor()](#M-TinyLife-Actions-TalkAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.TalkAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [Settings](#P-TinyLife-Actions-TalkAction-Settings 'TinyLife.Actions.TalkAction.Settings')
  - [Create(name,priority,settings)](#M-TinyLife-Actions-TalkAction-Create-System-String,System-Func{TinyLife-Objects-Person,System-Int32},TinyLife-Actions-TalkAction-TalkSettings- 'TinyLife.Actions.TalkAction.Create(System.String,System.Func{TinyLife.Objects.Person,System.Int32},TinyLife.Actions.TalkAction.TalkSettings)')
  - [IsConversationCompleted()](#M-TinyLife-Actions-TalkAction-IsConversationCompleted 'TinyLife.Actions.TalkAction.IsConversationCompleted')
  - [OnCompleted()](#M-TinyLife-Actions-TalkAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.TalkAction.OnCompleted(TinyLife.Actions.Action.CompletionType)')
  - [UpdateConversation()](#M-TinyLife-Actions-TalkAction-UpdateConversation-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.TalkAction.UpdateConversation(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [TalkSettings](#T-TinyLife-Actions-TalkAction-TalkSettings 'TinyLife.Actions.TalkAction.TalkSettings')
  - [CanExecute](#F-TinyLife-Actions-TalkAction-TalkSettings-CanExecute 'TinyLife.Actions.TalkAction.TalkSettings.CanExecute')
  - [EmoteCategory](#F-TinyLife-Actions-TalkAction-TalkSettings-EmoteCategory 'TinyLife.Actions.TalkAction.TalkSettings.EmoteCategory')
  - [FailEmotion](#F-TinyLife-Actions-TalkAction-TalkSettings-FailEmotion 'TinyLife.Actions.TalkAction.TalkSettings.FailEmotion')
  - [FriendshipGain](#F-TinyLife-Actions-TalkAction-TalkSettings-FriendshipGain 'TinyLife.Actions.TalkAction.TalkSettings.FriendshipGain')
  - [GainRomancePercentage](#F-TinyLife-Actions-TalkAction-TalkSettings-GainRomancePercentage 'TinyLife.Actions.TalkAction.TalkSettings.GainRomancePercentage')
  - [GainSkillOnFailure](#F-TinyLife-Actions-TalkAction-TalkSettings-GainSkillOnFailure 'TinyLife.Actions.TalkAction.TalkSettings.GainSkillOnFailure')
  - [GainedSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-GainedSkill 'TinyLife.Actions.TalkAction.TalkSettings.GainedSkill')
  - [GainedSkillAmount](#F-TinyLife-Actions-TalkAction-TalkSettings-GainedSkillAmount 'TinyLife.Actions.TalkAction.TalkSettings.GainedSkillAmount')
  - [GoBadlyChance](#F-TinyLife-Actions-TalkAction-TalkSettings-GoBadlyChance 'TinyLife.Actions.TalkAction.TalkSettings.GoBadlyChance')
  - [LoweredEmotion](#F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotion 'TinyLife.Actions.TalkAction.TalkSettings.LoweredEmotion')
  - [LoweredEmotionAmount](#F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotionAmount 'TinyLife.Actions.TalkAction.TalkSettings.LoweredEmotionAmount')
  - [OnFailure](#F-TinyLife-Actions-TalkAction-TalkSettings-OnFailure 'TinyLife.Actions.TalkAction.TalkSettings.OnFailure')
  - [OnSuccess](#F-TinyLife-Actions-TalkAction-TalkSettings-OnSuccess 'TinyLife.Actions.TalkAction.TalkSettings.OnSuccess')
  - [RequiredEmotion](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredEmotion 'TinyLife.Actions.TalkAction.TalkSettings.RequiredEmotion')
  - [RequiredSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkill 'TinyLife.Actions.TalkAction.TalkSettings.RequiredSkill')
  - [RequiredSkillLevel](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkillLevel 'TinyLife.Actions.TalkAction.TalkSettings.RequiredSkillLevel')
  - [RestoredNeed](#F-TinyLife-Actions-TalkAction-TalkSettings-RestoredNeed 'TinyLife.Actions.TalkAction.TalkSettings.RestoredNeed')
  - [RestoredNeedAmount](#F-TinyLife-Actions-TalkAction-TalkSettings-RestoredNeedAmount 'TinyLife.Actions.TalkAction.TalkSettings.RestoredNeedAmount')
  - [TalkMinutes](#F-TinyLife-Actions-TalkAction-TalkSettings-TalkMinutes 'TinyLife.Actions.TalkAction.TalkSettings.TalkMinutes')
  - [CheckCanExecute(info,automatic)](#M-TinyLife-Actions-TalkAction-TalkSettings-CheckCanExecute-TinyLife-Actions-ActionInfo,System-Boolean- 'TinyLife.Actions.TalkAction.TalkSettings.CheckCanExecute(TinyLife.Actions.ActionInfo,System.Boolean)')
  - [Evaluate(action)](#M-TinyLife-Actions-TalkAction-TalkSettings-Evaluate-TinyLife-Actions-SocialAction- 'TinyLife.Actions.TalkAction.TalkSettings.Evaluate(TinyLife.Actions.SocialAction)')
- [TellPeopleToLeaveRoomAction](#T-TinyLife-Actions-TellPeopleToLeaveRoomAction 'TinyLife.Actions.TellPeopleToLeaveRoomAction')
  - [#ctor()](#M-TinyLife-Actions-TellPeopleToLeaveRoomAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.TellPeopleToLeaveRoomAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [ExcludedPeople](#F-TinyLife-Actions-TellPeopleToLeaveRoomAction-ExcludedPeople 'TinyLife.Actions.TellPeopleToLeaveRoomAction.ExcludedPeople')
  - [Initialize()](#M-TinyLife-Actions-TellPeopleToLeaveRoomAction-Initialize 'TinyLife.Actions.TellPeopleToLeaveRoomAction.Initialize')
  - [IsCompleted()](#M-TinyLife-Actions-TellPeopleToLeaveRoomAction-IsCompleted 'TinyLife.Actions.TellPeopleToLeaveRoomAction.IsCompleted')
  - [OnCompleted()](#M-TinyLife-Actions-TellPeopleToLeaveRoomAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.TellPeopleToLeaveRoomAction.OnCompleted(TinyLife.Actions.Action.CompletionType)')
- [TextureHandler](#T-TinyLife-Utilities-TextureHandler 'TinyLife.Utilities.TextureHandler')
  - [ApplyWallpaperMasks(wallpapers,regionAmountX,regionAmountY,result)](#M-TinyLife-Utilities-TextureHandler-ApplyWallpaperMasks-Microsoft-Xna-Framework-Graphics-Texture2D,System-Int32,System-Int32,System-Action{MLEM-Textures-UniformTextureAtlas}- 'TinyLife.Utilities.TextureHandler.ApplyWallpaperMasks(Microsoft.Xna.Framework.Graphics.Texture2D,System.Int32,System.Int32,System.Action{MLEM.Textures.UniformTextureAtlas})')
- [Tile](#T-TinyLife-World-Tile 'TinyLife.World.Tile')
  - [BaseName](#F-TinyLife-World-Tile-BaseName 'TinyLife.World.Tile.BaseName')
  - [CanBuy](#F-TinyLife-World-Tile-CanBuy 'TinyLife.World.Tile.CanBuy')
  - [ColorScheme](#F-TinyLife-World-Tile-ColorScheme 'TinyLife.World.Tile.ColorScheme')
  - [Height](#F-TinyLife-World-Tile-Height 'TinyLife.World.Tile.Height')
  - [Icon](#F-TinyLife-World-Tile-Icon 'TinyLife.World.Tile.Icon')
  - [Name](#F-TinyLife-World-Tile-Name 'TinyLife.World.Tile.Name')
  - [Natural](#F-TinyLife-World-Tile-Natural 'TinyLife.World.Tile.Natural')
  - [PathCostModifier](#F-TinyLife-World-Tile-PathCostModifier 'TinyLife.World.Tile.PathCostModifier')
  - [Price](#F-TinyLife-World-Tile-Price 'TinyLife.World.Tile.Price')
  - [ReferencePrice](#F-TinyLife-World-Tile-ReferencePrice 'TinyLife.World.Tile.ReferencePrice')
  - [Tiles](#F-TinyLife-World-Tile-Tiles 'TinyLife.World.Tile.Tiles')
  - [Width](#F-TinyLife-World-Tile-Width 'TinyLife.World.Tile.Width')
  - [Draw(batch,drawPos,depth,scale)](#M-TinyLife-World-Tile-Draw-Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Single,System-Single- 'TinyLife.World.Tile.Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Single,System.Single)')
  - [DrawUi(e,batch,drawScale)](#M-TinyLife-World-Tile-DrawUi-MLEM-Ui-Elements-Element,Microsoft-Xna-Framework-Graphics-SpriteBatch,System-Single- 'TinyLife.World.Tile.DrawUi(MLEM.Ui.Elements.Element,Microsoft.Xna.Framework.Graphics.SpriteBatch,System.Single)')
  - [GetPrice()](#M-TinyLife-World-Tile-GetPrice 'TinyLife.World.Tile.GetPrice')
  - [Register(name,price,textureRegion,colors,pathCostModifier,canBuy,natural,icon)](#M-TinyLife-World-Tile-Register-System-String,System-Int32,MLEM-Textures-TextureRegion,TinyLife-Utilities-ColorScheme,System-Single,System-Boolean,System-Boolean,MLEM-Textures-TextureRegion- 'TinyLife.World.Tile.Register(System.String,System.Int32,MLEM.Textures.TextureRegion,TinyLife.Utilities.ColorScheme,System.Single,System.Boolean,System.Boolean,MLEM.Textures.TextureRegion)')
- [TileTool](#T-TinyLife-Tools-TileTool 'TinyLife.Tools.TileTool')
  - [#ctor()](#M-TinyLife-Tools-TileTool-#ctor 'TinyLife.Tools.TileTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-TileTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.TileTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [GetMouseCursor()](#M-TinyLife-Tools-TileTool-GetMouseCursor 'TinyLife.Tools.TileTool.GetMouseCursor')
  - [InitBuildModeUi()](#M-TinyLife-Tools-TileTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.TileTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-TileTool-ShouldHighlightSelectedObject 'TinyLife.Tools.TileTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-TileTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.TileTool.Update(Microsoft.Xna.Framework.GameTime)')
- [Tool](#T-TinyLife-Tools-Tool 'TinyLife.Tools.Tool')
  - [#ctor(texture,displayAsTab)](#M-TinyLife-Tools-Tool-#ctor-MLEM-Textures-TextureRegion,System-Boolean- 'TinyLife.Tools.Tool.#ctor(MLEM.Textures.TextureRegion,System.Boolean)')
  - [BuildTools](#F-TinyLife-Tools-Tool-BuildTools 'TinyLife.Tools.Tool.BuildTools')
  - [DisplayAsTab](#F-TinyLife-Tools-Tool-DisplayAsTab 'TinyLife.Tools.Tool.DisplayAsTab')
  - [MousePos](#F-TinyLife-Tools-Tool-MousePos 'TinyLife.Tools.Tool.MousePos')
  - [MoveTool](#F-TinyLife-Tools-Tool-MoveTool 'TinyLife.Tools.Tool.MoveTool')
  - [PlayModeTool](#F-TinyLife-Tools-Tool-PlayModeTool 'TinyLife.Tools.Tool.PlayModeTool')
  - [RemoveTool](#F-TinyLife-Tools-Tool-RemoveTool 'TinyLife.Tools.Tool.RemoveTool')
  - [Texture](#F-TinyLife-Tools-Tool-Texture 'TinyLife.Tools.Tool.Texture')
  - [Input](#P-TinyLife-Tools-Tool-Input 'TinyLife.Tools.Tool.Input')
  - [Map](#P-TinyLife-Tools-Tool-Map 'TinyLife.Tools.Tool.Map')
  - [Money](#P-TinyLife-Tools-Tool-Money 'TinyLife.Tools.Tool.Money')
  - [SelectedObject](#P-TinyLife-Tools-Tool-SelectedObject 'TinyLife.Tools.Tool.SelectedObject')
  - [BuildModeButton(name,onPressed,onDrawn,price,icon)](#M-TinyLife-Tools-Tool-BuildModeButton-System-String,MLEM-Ui-Elements-Element-GenericCallback,MLEM-Ui-Elements-Element-DrawCallback,System-Single,MLEM-Textures-TextureRegion,TinyLife-LnCategory- 'TinyLife.Tools.Tool.BuildModeButton(System.String,MLEM.Ui.Elements.Element.GenericCallback,MLEM.Ui.Elements.Element.DrawCallback,System.Single,MLEM.Textures.TextureRegion,TinyLife.LnCategory)')
  - [CanSaveOrSwitchModes()](#M-TinyLife-Tools-Tool-CanSaveOrSwitchModes 'TinyLife.Tools.Tool.CanSaveOrSwitchModes')
  - [Closed()](#M-TinyLife-Tools-Tool-Closed 'TinyLife.Tools.Tool.Closed')
  - [ColorSelection(colors,onPressed)](#M-TinyLife-Tools-Tool-ColorSelection-TinyLife-Utilities-ColorScheme,System-Action{System-Int32}- 'TinyLife.Tools.Tool.ColorSelection(TinyLife.Utilities.ColorScheme,System.Action{System.Int32})')
  - [Draw(time,batch)](#M-TinyLife-Tools-Tool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.Tool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [ForceWallsUp()](#M-TinyLife-Tools-Tool-ForceWallsUp 'TinyLife.Tools.Tool.ForceWallsUp')
  - [GetClosestWallDirection(hoveredPos)](#M-TinyLife-Tools-Tool-GetClosestWallDirection-Microsoft-Xna-Framework-Point- 'TinyLife.Tools.Tool.GetClosestWallDirection(Microsoft.Xna.Framework.Point)')
  - [GetMouseCursor()](#M-TinyLife-Tools-Tool-GetMouseCursor 'TinyLife.Tools.Tool.GetMouseCursor')
  - [InitBuildModeUi(content,zoom)](#M-TinyLife-Tools-Tool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.Tool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [IsOnLot(pos)](#M-TinyLife-Tools-Tool-IsOnLot-Microsoft-Xna-Framework-Point- 'TinyLife.Tools.Tool.IsOnLot(Microsoft.Xna.Framework.Point)')
  - [Opened()](#M-TinyLife-Tools-Tool-Opened 'TinyLife.Tools.Tool.Opened')
  - [Update(time)](#M-TinyLife-Tools-Tool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.Tool.Update(Microsoft.Xna.Framework.GameTime)')
- [TypeCategory](#T-TinyLife-Emotions-EmotionType-TypeCategory 'TinyLife.Emotions.EmotionType.TypeCategory')
  - [Negative](#F-TinyLife-Emotions-EmotionType-TypeCategory-Negative 'TinyLife.Emotions.EmotionType.TypeCategory.Negative')
  - [Neutral](#F-TinyLife-Emotions-EmotionType-TypeCategory-Neutral 'TinyLife.Emotions.EmotionType.TypeCategory.Neutral')
  - [Positive](#F-TinyLife-Emotions-EmotionType-TypeCategory-Positive 'TinyLife.Emotions.EmotionType.TypeCategory.Positive')
- [TypeSettings](#T-TinyLife-Actions-ActionType-TypeSettings 'TinyLife.Actions.ActionType.TypeSettings')
- [TypeSettings](#T-TinyLife-Objects-FurnitureType-TypeSettings 'TinyLife.Objects.FurnitureType.TypeSettings')
  - [#ctor(name,context,construct)](#M-TinyLife-Actions-ActionType-TypeSettings-#ctor-System-String,TinyLife-Objects-ObjectCategory,System-Func{TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,TinyLife-Actions-Action}- 'TinyLife.Actions.ActionType.TypeSettings.#ctor(System.String,TinyLife.Objects.ObjectCategory,System.Func{TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,TinyLife.Actions.Action})')
  - [#ctor(name,size,categories,price,colorSchemes)](#M-TinyLife-Objects-FurnitureType-TypeSettings-#ctor-System-String,Microsoft-Xna-Framework-Point,TinyLife-Objects-ObjectCategory,System-Single,TinyLife-Utilities-ColorScheme[]- 'TinyLife.Objects.FurnitureType.TypeSettings.#ctor(System.String,Microsoft.Xna.Framework.Point,TinyLife.Objects.ObjectCategory,System.Single,TinyLife.Utilities.ColorScheme[])')
  - [Ai](#F-TinyLife-Actions-ActionType-TypeSettings-Ai 'TinyLife.Actions.ActionType.TypeSettings.Ai')
  - [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute')
  - [Construct](#F-TinyLife-Actions-ActionType-TypeSettings-Construct 'TinyLife.Actions.ActionType.TypeSettings.Construct')
  - [Context](#F-TinyLife-Actions-ActionType-TypeSettings-Context 'TinyLife.Actions.ActionType.TypeSettings.Context')
  - [IconName](#F-TinyLife-Actions-ActionType-TypeSettings-IconName 'TinyLife.Actions.ActionType.TypeSettings.IconName')
  - [IsInappropriateElsewhere](#F-TinyLife-Actions-ActionType-TypeSettings-IsInappropriateElsewhere 'TinyLife.Actions.ActionType.TypeSettings.IsInappropriateElsewhere')
  - [Name](#F-TinyLife-Actions-ActionType-TypeSettings-Name 'TinyLife.Actions.ActionType.TypeSettings.Name')
  - [Texture](#F-TinyLife-Actions-ActionType-TypeSettings-Texture 'TinyLife.Actions.ActionType.TypeSettings.Texture')
  - [Varieties](#F-TinyLife-Actions-ActionType-TypeSettings-Varieties 'TinyLife.Actions.ActionType.TypeSettings.Varieties')
  - [ActionSpots](#F-TinyLife-Objects-FurnitureType-TypeSettings-ActionSpots 'TinyLife.Objects.FurnitureType.TypeSettings.ActionSpots')
  - [BuyableVariations](#F-TinyLife-Objects-FurnitureType-TypeSettings-BuyableVariations 'TinyLife.Objects.FurnitureType.TypeSettings.BuyableVariations')
  - [Categories](#F-TinyLife-Objects-FurnitureType-TypeSettings-Categories 'TinyLife.Objects.FurnitureType.TypeSettings.Categories')
  - [ColorMap](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorMap 'TinyLife.Objects.FurnitureType.TypeSettings.ColorMap')
  - [ColorSchemes](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorSchemes 'TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes')
  - [Construct](#F-TinyLife-Objects-FurnitureType-TypeSettings-Construct 'TinyLife.Objects.FurnitureType.TypeSettings.Construct')
  - [DecorativeRating](#F-TinyLife-Objects-FurnitureType-TypeSettings-DecorativeRating 'TinyLife.Objects.FurnitureType.TypeSettings.DecorativeRating')
  - [DefaultColors](#F-TinyLife-Objects-FurnitureType-TypeSettings-DefaultColors 'TinyLife.Objects.FurnitureType.TypeSettings.DefaultColors')
  - [DefaultRotation](#F-TinyLife-Objects-FurnitureType-TypeSettings-DefaultRotation 'TinyLife.Objects.FurnitureType.TypeSettings.DefaultRotation')
  - [HeldScale](#F-TinyLife-Objects-FurnitureType-TypeSettings-HeldScale 'TinyLife.Objects.FurnitureType.TypeSettings.HeldScale')
  - [Icon](#F-TinyLife-Objects-FurnitureType-TypeSettings-Icon 'TinyLife.Objects.FurnitureType.TypeSettings.Icon')
  - [Name](#F-TinyLife-Objects-FurnitureType-TypeSettings-Name 'TinyLife.Objects.FurnitureType.TypeSettings.Name')
  - [ObjectSpots](#F-TinyLife-Objects-FurnitureType-TypeSettings-ObjectSpots 'TinyLife.Objects.FurnitureType.TypeSettings.ObjectSpots')
  - [Price](#F-TinyLife-Objects-FurnitureType-TypeSettings-Price 'TinyLife.Objects.FurnitureType.TypeSettings.Price')
  - [Size](#F-TinyLife-Objects-FurnitureType-TypeSettings-Size 'TinyLife.Objects.FurnitureType.TypeSettings.Size')
  - [Categories](#P-TinyLife-Actions-ActionType-TypeSettings-Categories 'TinyLife.Actions.ActionType.TypeSettings.Categories')
  - [NameWithoutCategory](#P-TinyLife-Actions-ActionType-TypeSettings-NameWithoutCategory 'TinyLife.Actions.ActionType.TypeSettings.NameWithoutCategory')
  - [GetDataKeys()](#M-TinyLife-Actions-ActionType-TypeSettings-GetDataKeys 'TinyLife.Actions.ActionType.TypeSettings.GetDataKeys')
  - [GetData\`\`1()](#M-TinyLife-Actions-ActionType-TypeSettings-GetData``1-System-String- 'TinyLife.Actions.ActionType.TypeSettings.GetData``1(System.String)')
  - [SetData()](#M-TinyLife-Actions-ActionType-TypeSettings-SetData-System-String,System-Object- 'TinyLife.Actions.ActionType.TypeSettings.SetData(System.String,System.Object)')
  - [GetDataKeys()](#M-TinyLife-Objects-FurnitureType-TypeSettings-GetDataKeys 'TinyLife.Objects.FurnitureType.TypeSettings.GetDataKeys')
  - [GetData\`\`1()](#M-TinyLife-Objects-FurnitureType-TypeSettings-GetData``1-System-String- 'TinyLife.Objects.FurnitureType.TypeSettings.GetData``1(System.String)')
  - [SetData()](#M-TinyLife-Objects-FurnitureType-TypeSettings-SetData-System-String,System-Object- 'TinyLife.Objects.FurnitureType.TypeSettings.SetData(System.String,System.Object)')
- [UnderlyingAction](#T-TinyLife-Actions-UnderlyingAction 'TinyLife.Actions.UnderlyingAction')
  - [Action](#P-TinyLife-Actions-UnderlyingAction-Action 'TinyLife.Actions.UnderlyingAction.Action')
  - [Initialize(type,info)](#M-TinyLife-Actions-UnderlyingAction-Initialize-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.UnderlyingAction.Initialize(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [Update(time,passedInGame,speed)](#M-TinyLife-Actions-UnderlyingAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.UnderlyingAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
  - [Validate(person)](#M-TinyLife-Actions-UnderlyingAction-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.UnderlyingAction.Validate(TinyLife.Objects.Person)')
- [UpdateEvent\`1](#T-TinyLife-Mods-Events-UpdateEvent`1 'TinyLife.Mods.Events.UpdateEvent`1')
- [WalkAction](#T-TinyLife-Actions-WalkAction 'TinyLife.Actions.WalkAction')
  - [#ctor()](#M-TinyLife-Actions-WalkAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.WalkAction.#ctor(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)')
  - [FindPath()](#M-TinyLife-Actions-WalkAction-FindPath-Microsoft-Xna-Framework-Point- 'TinyLife.Actions.WalkAction.FindPath(Microsoft.Xna.Framework.Point)')
  - [GetSpeed()](#M-TinyLife-Actions-WalkAction-GetSpeed 'TinyLife.Actions.WalkAction.GetSpeed')
  - [Update()](#M-TinyLife-Actions-WalkAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.WalkAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)')
- [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall')
  - [#ctor(positions)](#M-TinyLife-World-Wall-#ctor-Microsoft-Xna-Framework-Point[]- 'TinyLife.World.Wall.#ctor(Microsoft.Xna.Framework.Point[])')
  - [DisplayModes](#F-TinyLife-World-Wall-DisplayModes 'TinyLife.World.Wall.DisplayModes')
  - [Positions](#F-TinyLife-World-Wall-Positions 'TinyLife.World.Wall.Positions')
  - [Price](#F-TinyLife-World-Wall-Price 'TinyLife.World.Wall.Price')
  - [Wallpapers](#F-TinyLife-World-Wall-Wallpapers 'TinyLife.World.Wall.Wallpapers')
  - [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening')
  - [Vertical](#P-TinyLife-World-Wall-Vertical 'TinyLife.World.Wall.Vertical')
  - [Draw(map,time,batch,drawPos)](#M-TinyLife-World-Wall-Draw-TinyLife-World-Map,Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2- 'TinyLife.World.Wall.Draw(TinyLife.World.Map,Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2)')
  - [GetDepth(map,offset)](#M-TinyLife-World-Wall-GetDepth-TinyLife-World-Map,System-Single- 'TinyLife.World.Wall.GetDepth(TinyLife.World.Map,System.Single)')
  - [GetDisplayMode()](#M-TinyLife-World-Wall-GetDisplayMode 'TinyLife.World.Wall.GetDisplayMode')
  - [GetIndexForCamera()](#M-TinyLife-World-Wall-GetIndexForCamera 'TinyLife.World.Wall.GetIndexForCamera')
  - [GetPrice()](#M-TinyLife-World-Wall-GetPrice 'TinyLife.World.Wall.GetPrice')
  - [IsDown()](#M-TinyLife-World-Wall-IsDown 'TinyLife.World.Wall.IsDown')
  - [SetOpening(map,opening)](#M-TinyLife-World-Wall-SetOpening-TinyLife-World-Map,TinyLife-World-Opening- 'TinyLife.World.Wall.SetOpening(TinyLife.World.Map,TinyLife.World.Opening)')
  - [Validate()](#M-TinyLife-World-Wall-Validate 'TinyLife.World.Wall.Validate')
- [WallDisplay](#T-TinyLife-WallDisplay 'TinyLife.WallDisplay')
  - [Auto](#F-TinyLife-WallDisplay-Auto 'TinyLife.WallDisplay.Auto')
  - [Down](#F-TinyLife-WallDisplay-Down 'TinyLife.WallDisplay.Down')
  - [Roofs](#F-TinyLife-WallDisplay-Roofs 'TinyLife.WallDisplay.Roofs')
  - [Up](#F-TinyLife-WallDisplay-Up 'TinyLife.WallDisplay.Up')
- [WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode')
  - [Door](#F-TinyLife-World-WallMode-Door 'TinyLife.World.WallMode.Door')
  - [Full](#F-TinyLife-World-WallMode-Full 'TinyLife.World.WallMode.Full')
  - [Roof](#F-TinyLife-World-WallMode-Roof 'TinyLife.World.WallMode.Roof')
  - [RoofGable](#F-TinyLife-World-WallMode-RoofGable 'TinyLife.World.WallMode.RoofGable')
  - [RoofGableInverse](#F-TinyLife-World-WallMode-RoofGableInverse 'TinyLife.World.WallMode.RoofGableInverse')
  - [SmallWindow](#F-TinyLife-World-WallMode-SmallWindow 'TinyLife.World.WallMode.SmallWindow')
- [WallTool](#T-TinyLife-Tools-WallTool 'TinyLife.Tools.WallTool')
  - [#ctor()](#M-TinyLife-Tools-WallTool-#ctor 'TinyLife.Tools.WallTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-WallTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.WallTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [GetMouseCursor()](#M-TinyLife-Tools-WallTool-GetMouseCursor 'TinyLife.Tools.WallTool.GetMouseCursor')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-WallTool-ShouldHighlightSelectedObject 'TinyLife.Tools.WallTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-WallTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.WallTool.Update(Microsoft.Xna.Framework.GameTime)')
- [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper')
  - [BaseName](#F-TinyLife-World-Wallpaper-BaseName 'TinyLife.World.Wallpaper.BaseName')
  - [ColorScheme](#F-TinyLife-World-Wallpaper-ColorScheme 'TinyLife.World.Wallpaper.ColorScheme')
  - [Icon](#F-TinyLife-World-Wallpaper-Icon 'TinyLife.World.Wallpaper.Icon')
  - [Name](#F-TinyLife-World-Wallpaper-Name 'TinyLife.World.Wallpaper.Name')
  - [Price](#F-TinyLife-World-Wallpaper-Price 'TinyLife.World.Wallpaper.Price')
  - [Wallpapers](#F-TinyLife-World-Wallpaper-Wallpapers 'TinyLife.World.Wallpaper.Wallpapers')
  - [Draw(time,batch,drawPos,mode,isDown,vertical,scale,depth,shadow)](#M-TinyLife-World-Wallpaper-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,TinyLife-World-WallMode,System-Boolean,System-Boolean,System-Single,System-Single,System-Boolean- 'TinyLife.World.Wallpaper.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,TinyLife.World.WallMode,System.Boolean,System.Boolean,System.Single,System.Single,System.Boolean)')
  - [DrawUi(e,batch,time,drawScale)](#M-TinyLife-World-Wallpaper-DrawUi-MLEM-Ui-Elements-Element,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-GameTime,System-Single- 'TinyLife.World.Wallpaper.DrawUi(MLEM.Ui.Elements.Element,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.GameTime,System.Single)')
  - [GetPrice()](#M-TinyLife-World-Wallpaper-GetPrice 'TinyLife.World.Wallpaper.GetPrice')
  - [Register(name,price,texture,textureRegion,colors,icon)](#M-TinyLife-World-Wallpaper-Register-System-String,System-Int32,MLEM-Textures-UniformTextureAtlas,Microsoft-Xna-Framework-Point,TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion- 'TinyLife.World.Wallpaper.Register(System.String,System.Int32,MLEM.Textures.UniformTextureAtlas,Microsoft.Xna.Framework.Point,TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)')
- [WallpaperTool](#T-TinyLife-Tools-WallpaperTool 'TinyLife.Tools.WallpaperTool')
  - [#ctor()](#M-TinyLife-Tools-WallpaperTool-#ctor 'TinyLife.Tools.WallpaperTool.#ctor')
  - [Draw()](#M-TinyLife-Tools-WallpaperTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch- 'TinyLife.Tools.WallpaperTool.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch)')
  - [GetMouseCursor()](#M-TinyLife-Tools-WallpaperTool-GetMouseCursor 'TinyLife.Tools.WallpaperTool.GetMouseCursor')
  - [InitBuildModeUi()](#M-TinyLife-Tools-WallpaperTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.WallpaperTool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)')
  - [ShouldHighlightSelectedObject()](#M-TinyLife-Tools-WallpaperTool-ShouldHighlightSelectedObject 'TinyLife.Tools.WallpaperTool.ShouldHighlightSelectedObject')
  - [Update()](#M-TinyLife-Tools-WallpaperTool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.WallpaperTool.Update(Microsoft.Xna.Framework.GameTime)')

<a name='T-TinyLife-Objects-AbstractSpot'></a>
## AbstractSpot `type`

##### Namespace

TinyLife.Objects

##### Summary

An [AbstractSpot](#T-TinyLife-Objects-AbstractSpot 'TinyLife.Objects.AbstractSpot') is a base class for [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') and [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot').

<a name='M-TinyLife-Objects-AbstractSpot-#ctor-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Single,MLEM-Misc-Direction2[]-'></a>
### #ctor(offset,visualOffset,yOffset,validDirections) `constructor`

##### Summary

Creates a new spot with the given data.
This is called by [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') and [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The offset on both the x and y axis that this spot has |
| visualOffset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The visual offset on both the x and y axis that this spot has |
| yOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The offset on the visual y axis |
| validDirections | [MLEM.Misc.Direction2[]](#T-MLEM-Misc-Direction2[] 'MLEM.Misc.Direction2[]') | The directions that this spot can be accessed from |

<a name='F-TinyLife-Objects-AbstractSpot-Offset'></a>
### Offset `constants`

##### Summary

The offset on both the x and y axis that this spot has from the position of the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') it belongs to

<a name='F-TinyLife-Objects-AbstractSpot-ValidDirections'></a>
### ValidDirections `constants`

##### Summary

The [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') values that this spot can be accessed from.
These directions are relative to the owning [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture')'s [Up](#F-MLEM-Misc-Direction2-Up 'MLEM.Misc.Direction2.Up') direction.

<a name='F-TinyLife-Objects-AbstractSpot-VisualOffset'></a>
### VisualOffset `constants`

##### Summary

The visual offset on both the x and y axis that this spot has from the position of the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') it belongs to.
By default, this gets set to the same value as [Offset](#F-TinyLife-Objects-AbstractSpot-Offset 'TinyLife.Objects.AbstractSpot.Offset').

<a name='F-TinyLife-Objects-AbstractSpot-YOffset'></a>
### YOffset `constants`

##### Summary

The offset on the visual y axis that the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') or [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') slotted into this spot should render with

<a name='M-TinyLife-Objects-AbstractSpot-GetLocation-TinyLife-Objects-Furniture,System-Boolean-'></a>
### GetLocation(furniture,visual) `method`

##### Summary

Returns the location that this spot has in world space, based on the given [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') and its position and rotation.

##### Returns

This spot's location in world space

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furniture that this spot belongs to |
| visual | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whetehr the [VisualOffset](#F-TinyLife-Objects-AbstractSpot-VisualOffset 'TinyLife.Objects.AbstractSpot.VisualOffset') should be used instead of the [Offset](#F-TinyLife-Objects-AbstractSpot-Offset 'TinyLife.Objects.AbstractSpot.Offset') |

<a name='M-TinyLife-Objects-AbstractSpot-GetValidDirections-MLEM-Misc-Direction2-'></a>
### GetValidDirections(rotation) `method`

##### Summary

Returns the [ValidDirections](#F-TinyLife-Objects-AbstractSpot-ValidDirections 'TinyLife.Objects.AbstractSpot.ValidDirections') of this spot, but rotated by the given [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2').

##### Returns

The rotations that are valid for this spot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation |

<a name='T-TinyLife-Actions-Action'></a>
## Action `type`

##### Namespace

TinyLife.Actions

##### Summary

An action is something that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') does.
An action is always derived from an underlying [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') that contains various action settings.
Actions can be queued up for a person ([ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue')) or currently active ([CurrentActions](#F-TinyLife-Objects-Person-CurrentActions 'TinyLife.Objects.Person.CurrentActions')).
To create a more complex action, it is best to extend [MultiAction](#T-TinyLife-Actions-MultiAction 'TinyLife.Actions.MultiAction').

<a name='M-TinyLife-Actions-Action-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor(type,info) `constructor`

##### Summary

Creates a new action from the given [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') | The type to create this action from |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The information for this action |

<a name='F-TinyLife-Actions-Action-ForceFail'></a>
### ForceFail `constants`

##### Summary

This value can be set to true to force [IsCompleted](#M-TinyLife-Actions-Action-IsCompleted 'TinyLife.Actions.Action.IsCompleted') to return [Failed](#F-TinyLife-Actions-Action-CompletionType-Failed 'TinyLife.Actions.Action.CompletionType.Failed').
This is useful if there is an erroring calculation in your [Update](#M-TinyLife-Actions-Action-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.Action.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') code etc.

<a name='F-TinyLife-Actions-Action-Info'></a>
### Info `constants`

##### Summary

The [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') for this action that contains the clicked (or otherwise targeted) objects and more

<a name='F-TinyLife-Actions-Action-Random'></a>
### Random `constants`

##### Summary

A [Random](#F-TinyLife-Actions-Action-Random 'TinyLife.Actions.Action.Random') instance that can be used by actions.
This value has the default seed.

<a name='F-TinyLife-Actions-Action-Type'></a>
### Type `constants`

##### Summary

The [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') that this action instance derives from

<a name='P-TinyLife-Actions-Action-ElapsedTime'></a>
### ElapsedTime `property`

##### Summary

The amount of in-game time that has elapsed since this action has started

<a name='P-TinyLife-Actions-Action-IsCurrent'></a>
### IsCurrent `property`

##### Summary

Returns true if this action instance is currently active.
This is a shorthand for a [CurrentActions](#F-TinyLife-Objects-Person-CurrentActions 'TinyLife.Objects.Person.CurrentActions') containment check.

<a name='P-TinyLife-Actions-Action-Map'></a>
### Map `property`

##### Summary

The [Map](#P-TinyLife-Actions-Action-Map 'TinyLife.Actions.Action.Map') that this action occurs on

<a name='P-TinyLife-Actions-Action-Person'></a>
### Person `property`

##### Summary

The [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person') that this action is being executed by

<a name='P-TinyLife-Actions-Action-StartedAutomatically'></a>
### StartedAutomatically `property`

##### Summary

If this value is true, this action was started using [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi') rather than by the player

<a name='P-TinyLife-Actions-Action-Variety'></a>
### Variety `property`

##### Summary

The [ActionVariety](#T-TinyLife-Actions-ActionVariety 'TinyLife.Actions.ActionVariety') that this action was initialized with.
If this is null, then the underlying [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') has no varieties.

<a name='M-TinyLife-Actions-Action-CanCancel-TinyLife-Actions-Action-'></a>
### CanCancel(cancelSource) `method`

##### Summary

Returns whether or not this action can be canceled by the given outside source.
Note that the outside source can be null, and if it is, it means that the player canceled the action manually.
By default, actions can only be canceled if the `cancelSource` is null.

##### Returns

true if the action can be canceled

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancelSource | [TinyLife.Actions.Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') | The source of the cancelation, or null if the player canceled it |

<a name='M-TinyLife-Actions-Action-CanEnqueueConversation-TinyLife-Objects-Person,TinyLife-Actions-ActionType-'></a>
### CanEnqueueConversation(person,type) `method`

##### Summary

Returns true if the given `person` can (automatically) enqueue a social action with the [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person') that is executing this action.
Note that enqueueing a social action manually is still possible even if this method returns false.
By default, only [SleepAction](#T-TinyLife-Actions-SleepAction 'TinyLife.Actions.SleepAction') returns false on this method.

##### Returns

Whether or not enqueueing a social action is possible

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that wants to converse with us |
| type | [TinyLife.Actions.ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') | The type of action that should be enqueued |

<a name='M-TinyLife-Actions-Action-CanMultitask-TinyLife-Actions-Action-'></a>
### CanMultitask(other) `method`

##### Summary

Return true on this method if this action can be multi-tasked along with the passed [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action').
A multi-tasking is an action that [IsCurrent](#P-TinyLife-Actions-Action-IsCurrent 'TinyLife.Actions.Action.IsCurrent') along with another action.
By default, multi-tasking is disallowed for any action.

##### Returns

Whether this action can be multi-tasked

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [TinyLife.Actions.Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') | The action to multi-task with |

<a name='M-TinyLife-Actions-Action-CausesExtremelyFastSpeed'></a>
### CausesExtremelyFastSpeed() `method`

##### Summary

Returns true if this action, while it [IsCurrent](#P-TinyLife-Actions-Action-IsCurrent 'TinyLife.Actions.Action.IsCurrent'), should cause the [ExtremelyFast](#F-TinyLife-GameSpeed-ExtremelyFast 'TinyLife.GameSpeed.ExtremelyFast') speed to be available.
By default, this method returns false.

##### Returns

Whether the extremely fast speed should be available

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-Action-CompleteIfNeedFull-TinyLife-NeedType,TinyLife-Actions-Action-CompletionType-'></a>
### CompleteIfNeedFull(type,els) `method`

##### Summary

A helper method that returns [Completed](#F-TinyLife-Actions-Action-CompletionType-Completed 'TinyLife.Actions.Action.CompletionType.Completed') if the given [Need](#T-TinyLife-Need 'TinyLife.Need')'s value is at [Max](#F-TinyLife-Need-Max 'TinyLife.Need.Max').

##### Returns

The appropriate completion type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The need that should be completed |
| els | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The action type that is returned if the need is not completed. [Active](#F-TinyLife-Actions-Action-CompletionType-Active 'TinyLife.Actions.Action.CompletionType.Active') by default. |

<a name='M-TinyLife-Actions-Action-FindAllFreeFurniture-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType,System-Boolean,System-Nullable{Microsoft-Xna-Framework-Vector2},System-Int32-'></a>
### FindAllFreeFurniture(person,categories,objectSpotType,needsFreeActionSpot,position,radius) `method`

##### Summary

A helper method to find a set of all [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') instances that are currently valid for interaction with the passed [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person')

##### Returns

A set of valid furniture

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that wants to start the aciton |
| categories | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The categories that the furniture should have |
| objectSpotType | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The type of item that an object spot should be available for, or null if this is not required |
| needsFreeActionSpot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the furniture returned needs a non-occupied [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') |
| position | [System.Nullable{Microsoft.Xna.Framework.Vector2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.Xna.Framework.Vector2}') | The position that we should find people around, or null to use the passed person's position |
| radius | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The radius that should be searched for people in, or 32 by default |

<a name='M-TinyLife-Actions-Action-FindAllFreePeople-TinyLife-Actions-ActionType,TinyLife-Objects-Person,System-Nullable{Microsoft-Xna-Framework-Vector2},System-Int32-'></a>
### FindAllFreePeople(type,person,position,radius) `method`

##### Summary

A helper method to find a set of all [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person') instances that are currently valid for interaction with the passed [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person')

##### Returns

A set of valid interaction partners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') | The type of action we want to start |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that wants to start the aciton |
| position | [System.Nullable{Microsoft.Xna.Framework.Vector2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.Xna.Framework.Vector2}') | The position that we should find people around, or null to use the passed person's position |
| radius | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The radius that should be searched for people in, or 32 by default |

<a name='M-TinyLife-Actions-Action-FindFreeFurniture-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType,System-Nullable{Microsoft-Xna-Framework-Vector2}-'></a>
### FindFreeFurniture(person,categories,objectSpotType,position) `method`

##### Summary

A helper method to find the best [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') instance to interact with based on the given data.
Note that this method always returns a [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') related to the first result from [FindAllFreeFurniture](#M-TinyLife-Actions-Action-FindAllFreeFurniture-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType,System-Boolean,System-Nullable{Microsoft-Xna-Framework-Vector2},System-Int32- 'TinyLife.Actions.Action.FindAllFreeFurniture(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory,TinyLife.Objects.FurnitureType,System.Boolean,System.Nullable{Microsoft.Xna.Framework.Vector2},System.Int32)').

##### Returns

An action info for the best furniture, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that wants to start the aciton |
| categories | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The categories that the furniture should have |
| objectSpotType | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The type of item that an object spot should be available for, or null if this is not required |
| position | [System.Nullable{Microsoft.Xna.Framework.Vector2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.Xna.Framework.Vector2}') | The position that we should find people around, or null to use the passed person's position |

<a name='M-TinyLife-Actions-Action-GetChair-TinyLife-Objects-Furniture-'></a>
### GetChair(deskObject) `method`

##### Summary

A helper method that returns a [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') with the [Chair](#F-TinyLife-Objects-ObjectCategory-Chair 'TinyLife.Objects.ObjectCategory.Chair') category that is closest to the given object which is on a desk or table.
The furniture returned is the one that the person should [Sit](#M-TinyLife-Actions-Action-Sit-TinyLife-Objects-Furniture,TinyLife-GameSpeed- 'TinyLife.Actions.Action.Sit(TinyLife.Objects.Furniture,TinyLife.GameSpeed)') on when interacting with the passed `deskObject`.

##### Returns

The corresponding chair, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deskObject | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The object that is sat on a desk |

<a name='M-TinyLife-Actions-Action-GetDisplayName'></a>
### GetDisplayName() `method`

##### Summary

Returns a localized string that explains this action in short.
By default, this method returns [GetDisplayName](#M-TinyLife-Actions-ActionType-GetDisplayName 'TinyLife.Actions.ActionType.GetDisplayName').

##### Returns

This action's display name

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-Action-GetIconObject'></a>
### GetIconObject() `method`

##### Summary

Returns the map object that is displayed in the action queue in the top left of the screen.
Note that this value is ignored if this action's type has a [Texture](#F-TinyLife-Actions-ActionType-TypeSettings-Texture 'TinyLife.Actions.ActionType.TypeSettings.Texture').
By default, the [GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1') is returned.

##### Returns

The icon object

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-Action-GetNextAction-TinyLife-Actions-Action-CompletionType-'></a>
### GetNextAction(completion) `method`

##### Summary

Returns an action that should be queued up immediately after this action completes.
The queued up action is immediately started in the slot that this action occupied.
Can be null, and is null by default.

##### Returns

The follow-up action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| completion | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The type that this action completed with |

<a name='M-TinyLife-Actions-Action-GetPlaceDirection-TinyLife-Objects-FurnitureType-'></a>
### GetPlaceDirection(item) `method`

##### Summary

Returns a [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') that represents the facing that the given [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') should be placed with.
The direction is determined by the [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person')'s current rotation.

##### Returns

The facing the item should be placed with

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The item to place |

<a name='M-TinyLife-Actions-Action-GetTableSpot-TinyLife-Objects-Furniture-'></a>
### GetTableSpot(chair) `method`

##### Summary

A helper method that returns the [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') on the table or desk that the given chair is connected to.
This is the object spot that should be used for interaction if a person sits on the given chair.

##### Returns

The table spot, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chair | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The chair to get the table spot for |

<a name='M-TinyLife-Actions-Action-Initialize'></a>
### Initialize() `method`

##### Summary

This method is called when the action is first started by a [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person').
Note that it is not called when the action gets added to the [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue'), but when it is moved to [CurrentActions](#F-TinyLife-Objects-Person-CurrentActions 'TinyLife.Objects.Person.CurrentActions').

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-Action-IsCompleted'></a>
### IsCompleted() `method`

##### Summary

This method is called every update frame by a [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person') if this action [IsCurrent](#P-TinyLife-Actions-Action-IsCurrent 'TinyLife.Actions.Action.IsCurrent') to check if it should be stopped.
If this returns a result other than [Completed](#F-TinyLife-Actions-Action-CompletionType-Completed 'TinyLife.Actions.Action.CompletionType.Completed'), [OnCompleted](#M-TinyLife-Actions-Action-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.Action.OnCompleted(TinyLife.Actions.Action.CompletionType)') will be called and the action is stopped.
By default, only [ForceFail](#F-TinyLife-Actions-Action-ForceFail 'TinyLife.Actions.Action.ForceFail') modifies the completion type, otherwise [Active](#F-TinyLife-Actions-Action-CompletionType-Active 'TinyLife.Actions.Action.CompletionType.Active') is returned.

##### Returns

The current completion type of this action

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-Action-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted(type) `method`

##### Summary

This method is called when this action [IsCompleted](#M-TinyLife-Actions-Action-IsCompleted 'TinyLife.Actions.Action.IsCompleted'), or if it is canceled from an outside source.
Note that, if this method is called as a result of [IsCompleted](#M-TinyLife-Actions-Action-IsCompleted 'TinyLife.Actions.Action.IsCompleted'), the [CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') passed will be the same.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The type that this action completed with |

<a name='M-TinyLife-Actions-Action-PutDownOrGoTo-TinyLife-Objects-ObjectCategory,TinyLife-Objects-FurnitureType[]-'></a>
### PutDownOrGoTo(parentToPutOn,items) `method`

##### Summary

A helper method used by [PrepareFoodAction](#T-TinyLife-Actions-PrepareFoodAction 'TinyLife.Actions.PrepareFoodAction') and [CookFoodAction](#T-TinyLife-Actions-CookFoodAction 'TinyLife.Actions.CookFoodAction') that causes the [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person') to walk to a valid surface with the action item on it, plcae the action item down on a valid surface or move the action object from its current location to a valid surface.
The validity of the surface is determined by `parentToPutOn`, and the item to find is any of `items`.

##### Returns

A set of actions that cause the person to set the action object up correctly

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentToPutOn | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | An object category that the object's surface should have |
| items | [TinyLife.Objects.FurnitureType[]](#T-TinyLife-Objects-FurnitureType[] 'TinyLife.Objects.FurnitureType[]') | The items that should be found on the surface |

<a name='M-TinyLife-Actions-Action-Sit-TinyLife-Objects-Furniture,TinyLife-GameSpeed-'></a>
### Sit(chair,speed) `method`

##### Summary

A helper method that causes the [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person') to sit on the given object.
This method causes the action spot to be occupied and the person's [CurrentPose](#F-TinyLife-Objects-Person-CurrentPose 'TinyLife.Objects.Person.CurrentPose') to be changed to [Sitting](#F-TinyLife-Objects-Person-Pose-Sitting 'TinyLife.Objects.Person.Pose.Sitting').
Additionally, the [Energy](#F-TinyLife-NeedType-Energy 'TinyLife.NeedType.Energy') need is restored a little bit.
Note that this method has to be called every [Update](#M-TinyLife-Actions-Action-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.Action.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame for the person to stay sat down.

##### Returns

Whether or not the chair can be sat on

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chair | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The chair to sit on |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The current game speed |

<a name='M-TinyLife-Actions-Action-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

This method is called every update frame if this action [IsCurrent](#P-TinyLife-Actions-Action-IsCurrent 'TinyLife.Actions.Action.IsCurrent').
By default, only the [ElapsedTime](#P-TinyLife-Actions-Action-ElapsedTime 'TinyLife.Actions.Action.ElapsedTime') is modified in this method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed, in game time |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's current speed setting |

<a name='M-TinyLife-Actions-Action-Validate-TinyLife-Objects-Person-'></a>
### Validate(person) `method`

##### Summary

Validates this action's data.
This is called when a map is loaded from disk.
When returning false on this method, the action is removed from the [Person](#P-TinyLife-Actions-Action-Person 'TinyLife.Actions.Action.Person').

##### Returns

Whether or not the action is still valid (or if it has invalid data)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that this action belongs to |

<a name='T-TinyLife-Actions-ActionInfo'></a>
## ActionInfo `type`

##### Namespace

TinyLife.Actions

##### Summary

An action info is a set of information that is required to execute an action

<a name='F-TinyLife-Actions-ActionInfo-ActionLocation'></a>
### ActionLocation `constants`

##### Summary

The location that this action should be executed in.
Note that this is mostly only relevant if there is no [ActionObject](#F-TinyLife-Actions-ActionInfo-ActionObject 'TinyLife.Actions.ActionInfo.ActionObject').

<a name='F-TinyLife-Actions-ActionInfo-ActionObject'></a>
### ActionObject `constants`

##### Summary

The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') of the object that this action is related to. Can be [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty'), which indicates that there is no action object.
To retrieve the actual object, use [GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1').

<a name='P-TinyLife-Actions-ActionInfo-ActionSpot'></a>
### ActionSpot `property`

##### Summary

The [ActionSpot](#P-TinyLife-Actions-ActionInfo-ActionSpot 'TinyLife.Actions.ActionInfo.ActionSpot') that this action is related to. Can be null, even if the [ActionObject](#F-TinyLife-Actions-ActionInfo-ActionObject 'TinyLife.Actions.ActionInfo.ActionObject') exists.

<a name='P-TinyLife-Actions-ActionInfo-Map'></a>
### Map `property`

##### Summary

The [Map](#P-TinyLife-Actions-ActionInfo-Map 'TinyLife.Actions.ActionInfo.Map') that the action is executed on

<a name='P-TinyLife-Actions-ActionInfo-Person'></a>
### Person `property`

##### Summary

The [Person](#P-TinyLife-Actions-ActionInfo-Person 'TinyLife.Actions.ActionInfo.Person') that is currently executing the action

<a name='M-TinyLife-Actions-ActionInfo-FromLocation-TinyLife-Objects-Person,Microsoft-Xna-Framework-Vector2-'></a>
### FromLocation(person,location) `method`

##### Summary

Returns a new [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') based on the given location (and no objects)

##### Returns

A new action info with the given data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that this action info should be related to |
| location | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The location that this action info should have |

<a name='M-TinyLife-Actions-ActionInfo-FromObjectGeneric-TinyLife-Objects-Person,TinyLife-Objects-MapObject-'></a>
### FromObjectGeneric(person,obj) `method`

##### Summary

Returns a new [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') basd on the given object, but no object spot

##### Returns

A new action info with the given data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that this action info should be related to |
| obj | [TinyLife.Objects.MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') | The object that this action info should have |

<a name='M-TinyLife-Actions-ActionInfo-GetActionObject``1'></a>
### GetActionObject\`\`1() `method`

##### Summary

Returns the object that this action is related to, or null if there is none or the object isn't of the given type.

##### Returns

The action object, or null if there is none or the type does not match

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the action object is expected to be of |

<a name='M-TinyLife-Actions-ActionInfo-GetObjectOrChild``1-TinyLife-Objects-ObjectCategory-'></a>
### GetObjectOrChild\`\`1(category) `method`

##### Summary

Returns the action object ([GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1')) or the action object's child if the action object does not have the required category.

##### Returns

The action object, its child, or null if neither match

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The category that the action object (or its child) should have |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that we expect the object (or its child) to be |

<a name='M-TinyLife-Actions-ActionInfo-GetObjectOrParent``1-TinyLife-Objects-ObjectCategory-'></a>
### GetObjectOrParent\`\`1(category) `method`

##### Summary

Returns the action object ([GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1')) or the action object's parent if the action object does not have the required category.

##### Returns

The action object, its parent, or null if neither match

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The category that the action object (or its parent) should have |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that we expect the object (or its parent) to be |

<a name='M-TinyLife-Actions-ActionInfo-OccupyFreeActionSpot-TinyLife-Objects-ObjectCategory,System-Boolean,System-Nullable{MLEM-Misc-Direction2}-'></a>
### OccupyFreeActionSpot(context,enter,rotation) `method`

##### Summary

This is a shorthand method for [GetFreeActionSpot](#M-TinyLife-Objects-Furniture-GetFreeActionSpot-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpot(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)') and [OccupyActionSpot](#M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})').
Note that this method needs to be called every update frame for the person to keep occupying the action spot.

##### Returns

Whether or not we were able to occupy a free action spot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The category that the action spot should have |
| enter | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the action spot should be entered |
| rotation | [System.Nullable{MLEM.Misc.Direction2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{MLEM.Misc.Direction2}') | The rotation that the person should have, or the action spot's rotation by default |

<a name='M-TinyLife-Actions-ActionInfo-ToFreeActionSpot-TinyLife-Objects-ObjectCategory-'></a>
### ToFreeActionSpot(context) `method`

##### Summary

This is a shorthand method for [GetFreeActionSpotInfo](#M-TinyLife-Objects-Furniture-GetFreeActionSpotInfo-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpotInfo(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)') that is applied to our action object ([GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1')).

##### Returns

The corresponding action info, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The category that the action spot should have |

<a name='M-TinyLife-Actions-ActionInfo-Validate-TinyLife-Objects-Person-'></a>
### Validate(person) `method`

##### Summary

Validates this action info.
This method should only be called when this action info is read from disk.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that this action info belongs to |

<a name='T-TinyLife-Objects-ActionSpot'></a>
## ActionSpot `type`

##### Namespace

TinyLife.Objects

##### Summary

An action spot is a [AbstractSpot](#T-TinyLife-Objects-AbstractSpot 'TinyLife.Objects.AbstractSpot') extension that is used by [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') to declare a location that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can interact with the furniture at

<a name='M-TinyLife-Objects-ActionSpot-#ctor-Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2[]-'></a>
### #ctor(offset,validDirections) `constructor`

##### Summary

Creates a new action spot with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The offset on both the x and y axis that this spot has |
| validDirections | [MLEM.Misc.Direction2[]](#T-MLEM-Misc-Direction2[] 'MLEM.Misc.Direction2[]') | The directions that this spot can be accessed from |

<a name='M-TinyLife-Objects-ActionSpot-#ctor-Microsoft-Xna-Framework-Vector2,System-Single,MLEM-Misc-Direction2[]-'></a>
### #ctor(offset,yOffset,validDirections) `constructor`

##### Summary

Creates a new action spot with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The offset on both the x and y axis that this spot has |
| yOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The offset on the visual y axis |
| validDirections | [MLEM.Misc.Direction2[]](#T-MLEM-Misc-Direction2[] 'MLEM.Misc.Direction2[]') | The directions that this spot can be accessed from |

<a name='M-TinyLife-Objects-ActionSpot-#ctor-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Single,MLEM-Misc-Direction2[]-'></a>
### #ctor(offset,visualOffset,yOffset,validDirections) `constructor`

##### Summary

Creates a new action spot with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The offset on both the x and y axis that this spot has |
| visualOffset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The visual offset on both the x and y axis that this spot has |
| yOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The offset on the visual y axis |
| validDirections | [MLEM.Misc.Direction2[]](#T-MLEM-Misc-Direction2[] 'MLEM.Misc.Direction2[]') | The directions that this spot can be accessed from |

<a name='F-TinyLife-Objects-ActionSpot-CategoryRestriction'></a>
### CategoryRestriction `constants`

##### Summary

The categories that this [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') is restricted to.
This is used by things like [ModernBed](#F-TinyLife-Objects-FurnitureType-ModernBed 'TinyLife.Objects.FurnitureType.ModernBed') to declare separate spots for sitting on and sleeping on.
By default, this is set to null.

<a name='F-TinyLife-Objects-ActionSpot-DrawLayer'></a>
### DrawLayer `constants`

##### Summary

The layer that a person slotted into this action spot using [OccupyActionSpot](#M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})') is drawn on.
By default, this is set to 0, meaning it will be drawn on top of the first layer of this furniture.

<a name='F-TinyLife-Objects-ActionSpot-Group'></a>
### Group `constants`

##### Summary

The group that this spot has.
Two action spots with the same group cannot both be occupied by two different people.
This is used by things lke [ModernBed](#F-TinyLife-Objects-FurnitureType-ModernBed 'TinyLife.Objects.FurnitureType.ModernBed') to stop people from sitting on a side there someone is already sleeping.
By default, this is set to null.

<a name='M-TinyLife-Objects-ActionSpot-GetFreeDirections-TinyLife-Objects-Furniture,TinyLife-Objects-Person-'></a>
### GetFreeDirections(furniture,person) `method`

##### Summary

Returns a set of [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') values that this spot can be accessed from.
Valid directions will have an empty space that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can stand in, but not necessarily walk to.
The returned value is used by [GetFreeActionSpots](#M-TinyLife-Objects-Furniture-GetFreeActionSpots-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpots(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)') and [GetFreeActionSpotInfo](#M-TinyLife-Objects-Furniture-GetFreeActionSpotInfo-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpotInfo(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)') to find a location adjacent to this action spot that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can walk to.

##### Returns

A set of directions that are considered free, or an empty set if there are none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furnituret that this action spot belongs to |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person trying to use this action spot |

<a name='M-TinyLife-Objects-ActionSpot-GetOccupants-TinyLife-Objects-Furniture,System-Boolean-'></a>
### GetOccupants(furniture,includeGroup) `method`

##### Summary

Returns a set of the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instances that are currently occupying this action spot.
Note that an action spot is also marked as occupied if the person is currently on their way to it.

##### Returns

A set of people interacting with this action spot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furnituret that this action spot belongs to |
| includeGroup | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to include other action spots that have the same [Group](#F-TinyLife-Objects-ActionSpot-Group 'TinyLife.Objects.ActionSpot.Group') |

<a name='T-TinyLife-Actions-ActionType'></a>
## ActionType `type`

##### Namespace

TinyLife.Actions

##### Summary

Action types are blueprints for [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') instances which can be registered using [Register](#M-TinyLife-Actions-ActionType-Register-TinyLife-Actions-ActionType-TypeSettings- 'TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)').
An action type contains information about its action and can create an instance using [Construct](#F-TinyLife-Actions-ActionType-TypeSettings-Construct 'TinyLife.Actions.ActionType.TypeSettings.Construct').

<a name='F-TinyLife-Actions-ActionType-Types'></a>
### Types `constants`

##### Summary

A list of all available action types.
To register your own action types, use the [Register](#M-TinyLife-Actions-ActionType-Register-TinyLife-Actions-ActionType-TypeSettings- 'TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)') method.

<a name='P-TinyLife-Actions-ActionType-Settings'></a>
### Settings `property`

##### Summary

The [TypeSettings](#T-TinyLife-Actions-ActionType-TypeSettings 'TinyLife.Actions.ActionType.TypeSettings') for this action type, which actually contain this type's properties.

<a name='M-TinyLife-Actions-ActionType-CanPlaceHeldItem-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### CanPlaceHeldItem(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines whether or not the item that is currently held by the given person can be placed in an object spot on the given object.

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if the object has a free object spot, otherwise [Hidden](#F-TinyLife-Actions-ActionType-CanExecuteResult-Hidden 'TinyLife.Actions.ActionType.CanExecuteResult.Hidden')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not this action is started automatically. This property is unused, but present for ease of use with [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute') |

<a name='M-TinyLife-Actions-ActionType-Construct-TinyLife-Actions-ActionInfo,System-Nullable{TinyLife-Actions-ActionVariety}-'></a>
### Construct(info,variety) `method`

##### Summary

Creates a new [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') instance of this [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType').

##### Returns

A new action instance with the given information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The info that this action should be constructed with |
| variety | [System.Nullable{TinyLife.Actions.ActionVariety}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{TinyLife.Actions.ActionVariety}') | The variety, or null if this action has no varieties |

<a name='M-TinyLife-Actions-ActionType-GetDisplayName'></a>
### GetDisplayName() `method`

##### Summary

Returns a localized string that explains this action type in short.
Note that, for instantiated actions, [GetDisplayName](#M-TinyLife-Actions-Action-GetDisplayName 'TinyLife.Actions.Action.GetDisplayName') should be used.

##### Returns

This action type's display name

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-ActionType-GetMatchingActions-TinyLife-Objects-ObjectCategory-'></a>
### GetMatchingActions(contextFlags) `method`

##### Summary

Returns a set of actions that match any the given [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') flag values.
No check occurs that determines whether or not the action is valid in any given circumstance, other than the category.

##### Returns

A set of action types that match the given flag

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextFlags | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The categories that should be checked, can be a combined flag |

<a name='M-TinyLife-Actions-ActionType-HasChair-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### HasChair(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines if the given object is sat on a table or desk that has a chair.

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if there is a chair, [NoChair](#F-TinyLife-Actions-ActionType-CanExecuteResult-NoChair 'TinyLife.Actions.ActionType.CanExecuteResult.NoChair') if there is no valid chair

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not this action is started automatically. This property is unused, but present for ease of use with [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute') |

<a name='M-TinyLife-Actions-ActionType-IsComfortable-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### IsComfortable(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines if the person is comfortable enough to execute an action.
A comfortable person is one that doesn't have the [Uncomfortable](#F-TinyLife-Emotions-EmotionType-Uncomfortable 'TinyLife.Emotions.EmotionType.Uncomfortable') or [Sad](#F-TinyLife-Emotions-EmotionType-Sad 'TinyLife.Emotions.EmotionType.Sad') emotions.

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if the person is comfortable, [TooUncomfortable](#F-TinyLife-Actions-ActionType-CanExecuteResult-TooUncomfortable 'TinyLife.Actions.ActionType.CanExecuteResult.TooUncomfortable') otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is automatic (unused) |

<a name='M-TinyLife-Actions-ActionType-IsDislikedOrMean-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### IsDislikedOrMean(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines if the action is executed manually, the given [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo')'s person has the [Mean](#F-TinyLife-PersonalityType-Mean 'TinyLife.PersonalityType.Mean') personality type, or if the interaction partner has the [Disliked](#F-TinyLife-RelationshipType-Disliked 'TinyLife.RelationshipType.Disliked') relationship type (or lower).

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if any of the conditions are met, otherwise [Hidden](#F-TinyLife-Actions-ActionType-CanExecuteResult-Hidden 'TinyLife.Actions.ActionType.CanExecuteResult.Hidden')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is automatic |

<a name='M-TinyLife-Actions-ActionType-IsEmptyHanded-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### IsEmptyHanded(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines if the person is not holding an item.

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if the person's hands are empty, [HoldingItem](#F-TinyLife-Actions-ActionType-CanExecuteResult-HoldingItem 'TinyLife.Actions.ActionType.CanExecuteResult.HoldingItem') otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is automatic (unused) |

<a name='M-TinyLife-Actions-ActionType-IsHoldingOrPlaceableOn-TinyLife-Actions-ActionInfo,TinyLife-Objects-ObjectCategory,System-Predicate{TinyLife-Objects-FurnitureType}-'></a>
### IsHoldingOrPlaceableOn(info,goalParent,isAllowed) `method`

##### Summary

A helper method to check whether or not the person in the given [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') is an item that matches the predicate (`isAllowed`) and the [GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1') is of the required type (`goalParent`) or if the action object itself matches the predicate.
For example, [PrepareFood](#F-TinyLife-Actions-ActionType-PrepareFood 'TinyLife.Actions.ActionType.PrepareFood') uses this method for its [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute') check:

```
CanExecute = (i, a) =&gt; IsHoldingOrPlaceableOn(i, ObjectCategory.Counter, t =&gt; t == FurnitureType.UnpreparedFood)
```

##### Returns

A result that represents the validity of the action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| goalParent | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The object that the required item should be a child of |
| isAllowed | [System.Predicate{TinyLife.Objects.FurnitureType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{TinyLife.Objects.FurnitureType}') | A predicate that checks if the given item is the one searched for |

<a name='M-TinyLife-Actions-ActionType-IsNotEmbarrassed-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### IsNotEmbarrassed(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines if the person is [Embarrassed](#F-TinyLife-Emotions-EmotionType-Embarrassed 'TinyLife.Emotions.EmotionType.Embarrassed') or not

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if the person is not embarrassed, [TooEmbarrassed](#F-TinyLife-Actions-ActionType-CanExecuteResult-TooEmbarrassed 'TinyLife.Actions.ActionType.CanExecuteResult.TooEmbarrassed') otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is automatic (unused) |

<a name='M-TinyLife-Actions-ActionType-IsReadyForRomance-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### IsReadyForRomance(info,automatic) `method`

##### Summary

A helper method intended to be used with [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate') that determines if the [Person](#P-TinyLife-Actions-ActionInfo-Person 'TinyLife.Actions.ActionInfo.Person') and their interaction partner are [Unrelated](#F-TinyLife-GenealogyType-Unrelated 'TinyLife.GenealogyType.Unrelated') and whether the action is executed manually or their [RomanceLevel](#P-TinyLife-Relationship-RomanceLevel 'TinyLife.Relationship.RomanceLevel') is higher than 0.
This method should be used for [SocialAction](#T-TinyLife-Actions-SocialAction 'TinyLife.Actions.SocialAction') actions that are romantic in nature.

##### Returns

[Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') if any of the conditions are met, otherwise [Hidden](#F-TinyLife-Actions-ActionType-CanExecuteResult-Hidden 'TinyLife.Actions.ActionType.CanExecuteResult.Hidden')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is automatic |

<a name='M-TinyLife-Actions-ActionType-Register-TinyLife-Actions-ActionType-TypeSettings-'></a>
### Register(settings) `method`

##### Summary

Registers a new action type with the given [TypeSettings](#T-TinyLife-Actions-ActionType-TypeSettings 'TinyLife.Actions.ActionType.TypeSettings')

##### Returns

The resulting action type instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settings | [TinyLife.Actions.ActionType.TypeSettings](#T-TinyLife-Actions-ActionType-TypeSettings 'TinyLife.Actions.ActionType.TypeSettings') | The settings that the action type should have |

<a name='T-TinyLife-Actions-ActionVariety'></a>
## ActionVariety `type`

##### Namespace

TinyLife.Actions

##### Summary

An action variety is a modification to a [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') that represents a slightly changed version of the generic action type.
Action varieties are used, for example, by [PrepareFood](#F-TinyLife-Actions-ActionType-PrepareFood 'TinyLife.Actions.ActionType.PrepareFood') to determine the kind of food that should be prepared.

<a name='M-TinyLife-Actions-ActionVariety-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Creates a new action variety with the given name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this action variety |

<a name='F-TinyLife-Actions-ActionVariety-CanExecute'></a>
### CanExecute `constants`

##### Summary

A function that returns whether or not this action variety can currently be chosen.
This is an extension of [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute')

<a name='F-TinyLife-Actions-ActionVariety-Description'></a>
### Description `constants`

##### Summary

A function that is called to describe this action variety in more detail.
This is used in the menu that pops up when the underlying [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') is picked.

<a name='F-TinyLife-Actions-ActionVariety-DisplayName'></a>
### DisplayName `constants`

##### Summary

A function that is called to describe this action variety.
This is used in the menu that pops up when the underlying [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') is picked.

<a name='F-TinyLife-Actions-ActionVariety-Name'></a>
### Name `constants`

##### Summary

The name of this action variety

<a name='F-TinyLife-Actions-ActionVariety-PassivePriority'></a>
### PassivePriority `constants`

##### Summary

A function that returns the passive priority of this action variety.
This is an extension of [PassivePriority](#F-TinyLife-Actions-ActionType-AiSettings-PassivePriority 'TinyLife.Actions.ActionType.AiSettings.PassivePriority')

<a name='T-TinyLife-Actions-ActionType-AiSettings'></a>
## AiSettings `type`

##### Namespace

TinyLife.Actions.ActionType

##### Summary

A set of settings that [TypeSettings](#T-TinyLife-Actions-ActionType-TypeSettings 'TinyLife.Actions.ActionType.TypeSettings') uses to determine how [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi') should deal with this [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType')

<a name='F-TinyLife-Actions-ActionType-AiSettings-CanDoAtAnyPoint'></a>
### CanDoAtAnyPoint `constants`

##### Summary

A value that determines whether or not this action can be started randomly, at any point, by the AI.
Whereas [CanDoRandomly](#F-TinyLife-Actions-ActionType-AiSettings-CanDoRandomly 'TinyLife.Actions.ActionType.AiSettings.CanDoRandomly') actions can only be started when the [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue') is empty, an action with this flag can always be started randomly.
If this value is false, but [SolvedNeed](#F-TinyLife-Actions-ActionType-AiSettings-SolvedNeed 'TinyLife.Actions.ActionType.AiSettings.SolvedNeed') is true, this action will still be started if the need set is low.
Note that, for this value to have an effect, the [PassivePriority](#F-TinyLife-Actions-ActionType-AiSettings-PassivePriority 'TinyLife.Actions.ActionType.AiSettings.PassivePriority') needs to be greater than 0.

<a name='F-TinyLife-Actions-ActionType-AiSettings-CanDoRandomly'></a>
### CanDoRandomly `constants`

##### Summary

A value that determines whether or not this action can be started randomly by the AI.
A random action will only be started if the corresponding person's [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue') is empty.
If this value is false, but [SolvedNeed](#F-TinyLife-Actions-ActionType-AiSettings-SolvedNeed 'TinyLife.Actions.ActionType.AiSettings.SolvedNeed') is true, this action will still be started if the need set is low.
Note that, for this value to have an effect, the [PassivePriority](#F-TinyLife-Actions-ActionType-AiSettings-PassivePriority 'TinyLife.Actions.ActionType.AiSettings.PassivePriority') needs to be greater than 0.

<a name='F-TinyLife-Actions-ActionType-AiSettings-NeedsFreeActionSpot'></a>
### NeedsFreeActionSpot `constants`

##### Summary

A value that determines whether this action needs to find a free [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') on the object that it is invoked on.
This value only has an effect if this action can be executed on any [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture').
This value defaults to true.

<a name='F-TinyLife-Actions-ActionType-AiSettings-PassivePriority'></a>
### PassivePriority `constants`

##### Summary

A function that returns the passive priority of this action type.
By default, the passive priority is 0, meaning this action will never be executed randomly.
The higher the passive priority, the more likely it is that this action will be invoked randomly by a person.

<a name='F-TinyLife-Actions-ActionType-AiSettings-SolvedNeed'></a>
### SolvedNeed `constants`

##### Summary

The need that this action solves when invoked.
The action doesn't need to actually solve this need in its implementation, but instead, this value is used to determine which actions to choose from if a person's needs are low.
Defaults to null.

<a name='T-TinyLife-Actions-ActionType-CanExecuteDelegate'></a>
## CanExecuteDelegate `type`

##### Namespace

TinyLife.Actions.ActionType

##### Summary

A delegate method used for [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [T:TinyLife.Actions.ActionType.CanExecuteDelegate](#T-T-TinyLife-Actions-ActionType-CanExecuteDelegate 'T:TinyLife.Actions.ActionType.CanExecuteDelegate') | The action info |

<a name='T-TinyLife-Actions-ActionType-CanExecuteResult'></a>
## CanExecuteResult `type`

##### Namespace

TinyLife.Actions.ActionType

##### Summary

An enumeration that represents whether or not an action can be executed. This is used by [CanExecuteDelegate](#T-TinyLife-Actions-ActionType-CanExecuteDelegate 'TinyLife.Actions.ActionType.CanExecuteDelegate').

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-Hidden'></a>
### Hidden `constants`

##### Summary

A result that causes the action to be hidden from the actions menu (and thus be unstartable)

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-HoldingItem'></a>
### HoldingItem `constants`

##### Summary

A result that should be returned when the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') in question is currently holding an item which interferes with the action in some way

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-NoChair'></a>
### NoChair `constants`

##### Summary

A result that should be returned when a chair is required for the action, but there is none present

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-NoSpace'></a>
### NoSpace `constants`

##### Summary

A result that should be returned when the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') in question has no space for an item

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-NotEnoughMoney'></a>
### NotEnoughMoney `constants`

##### Summary

A result that should be returned when there is not enough money in the [Household](#T-TinyLife-World-Household 'TinyLife.World.Household') to execute this action

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-NotEnoughSkill'></a>
### NotEnoughSkill `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') in question does not have a skill level high enough to execute this action

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-NotYours'></a>
### NotYours `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') does not own the [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') that this action is executed on

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-TooEmbarrassed'></a>
### TooEmbarrassed `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') is considered too embarrassed to do something

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-TooFar'></a>
### TooFar `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') in question is too far away to execute this action

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-TooSad'></a>
### TooSad `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') is considered too sad to do something

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-TooUncomfortable'></a>
### TooUncomfortable `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') is considered emotionally too uncomfortable to do something

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-Valid'></a>
### Valid `constants`

##### Summary

A result that causes the action to be executable both by [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi') and by a player

<a name='F-TinyLife-Actions-ActionType-CanExecuteResult-WrongRelationshipType'></a>
### WrongRelationshipType `constants`

##### Summary

A result that should be returned if the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') has the wrong [Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship') to a given other person

<a name='T-TinyLife-Objects-Car'></a>
## Car `type`

##### Namespace

TinyLife.Objects

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Objects-Car-#ctor-System-Guid,TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Objects-Car-Driver'></a>
### Driver `constants`

##### Summary

The id of the person driving the car

<a name='F-TinyLife-Objects-Car-Rotation'></a>
### Rotation `constants`

##### Summary

The rotation that this car has

<a name='M-TinyLife-Objects-Car-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Car-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Car-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Uis-CharacterCreator'></a>
## CharacterCreator `type`

##### Namespace

TinyLife.Uis

##### Summary

The character creator is displayed when a person (or household) is being edited in terms of their [Clothes](#T-TinyLife-Objects-Clothes 'TinyLife.Objects.Clothes') and [PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType')s.

<a name='P-TinyLife-Uis-CharacterCreator-Active'></a>
### Active `property`

##### Summary

The currently displayed [CharacterCreator](#T-TinyLife-Uis-CharacterCreator 'TinyLife.Uis.CharacterCreator') instance, or null if the character editor is closed

<a name='M-TinyLife-Uis-CharacterCreator-CanSwitchPeople'></a>
### CanSwitchPeople() `method`

##### Summary

Returns whether or not this character creator instance currently allows switching the selected character.
The return value is based on the selected person's [FullName](#P-TinyLife-Objects-Person-FullName 'TinyLife.Objects.Person.FullName') and [PersonalityTypes](#F-TinyLife-Objects-Person-PersonalityTypes 'TinyLife.Objects.Person.PersonalityTypes').

##### Returns

Whether we can currently switch the active person

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Uis-CharacterCreator-CreatePerson-TinyLife-World-Map,TinyLife-World-Household-'></a>
### CreatePerson(map,household) `method`

##### Summary

Creates a new [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instance on the given map with the given lot.
The person is placed at the top left corner of the lot.
A few settings, like their animation and portrait, are additionally set up.

##### Returns

The created person instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to place the person on |
| household | [TinyLife.World.Household](#T-TinyLife-World-Household 'TinyLife.World.Household') | The household to add the person to |

<a name='M-TinyLife-Uis-CharacterCreator-Open-TinyLife-Objects-Person,System-Boolean-'></a>
### Open(person,full) `method`

##### Summary

Opens a new [CharacterCreator](#T-TinyLife-Uis-CharacterCreator 'TinyLife.Uis.CharacterCreator') for the given person (and their household).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to open in the character creator |
| full | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If this value is true, editing the person's name, skin and eye color and personality is possible |

<a name='T-TinyLife-Objects-Clothes'></a>
## Clothes `type`

##### Namespace

TinyLife.Objects

##### Summary

A set of information and a registry for clothing items (and hair) that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can wear.
Custom clothes can be registered using [Register](#M-TinyLife-Objects-Clothes-Register-TinyLife-Objects-Clothes- 'TinyLife.Objects.Clothes.Register(TinyLife.Objects.Clothes)').

<a name='M-TinyLife-Objects-Clothes-#ctor-System-String,TinyLife-Objects-ClothesLayer,MLEM-Textures-TextureRegion,System-Single,MLEM-Textures-TextureRegion,TinyLife-Utilities-ColorScheme[]-'></a>
### #ctor(name,layer,region,colors,icon) `constructor`

##### Summary

Creates a new clothes item with the given data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this clothes item |
| layer | [TinyLife.Objects.ClothesLayer](#T-TinyLife-Objects-ClothesLayer 'TinyLife.Objects.ClothesLayer') | The [ClothesLayer](#T-TinyLife-Objects-ClothesLayer 'TinyLife.Objects.ClothesLayer') that this clothes item should render on |
| region | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The top left (standing frame 1) [TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') that this clothes item uses in the world |
| colors | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The [ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme') that this clothes item can have its colors selected from |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The character creator icon for this object, which represents the category / theme / mod that it comes from |

<a name='F-TinyLife-Objects-Clothes-Colors'></a>
### Colors `constants`

##### Summary

The set of [ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme')s that this clothes item can have its colors selected from.
The color scheme at index i will be mapped to the [TextureRegions](#F-TinyLife-Objects-Clothes-TextureRegions 'TinyLife.Objects.Clothes.TextureRegions') entry at index i.

<a name='F-TinyLife-Objects-Clothes-Icon'></a>
### Icon `constants`

##### Summary

The character creator icon for this object, which represents the category / theme / mod that it comes from.
If this value is nonnull, the icon will be displayed in the corner of the character creator button for this object.

<a name='F-TinyLife-Objects-Clothes-Layer'></a>
### Layer `constants`

##### Summary

The [ClothesLayer](#T-TinyLife-Objects-ClothesLayer 'TinyLife.Objects.ClothesLayer') that this clothes item should render on

<a name='F-TinyLife-Objects-Clothes-Layers'></a>
### Layers `constants`

##### Summary

A set of all valid [ClothesLayer](#T-TinyLife-Objects-ClothesLayer 'TinyLife.Objects.ClothesLayer') values

<a name='F-TinyLife-Objects-Clothes-Name'></a>
### Name `constants`

##### Summary

The name of this clothes item.
Since this is used for the [Types](#F-TinyLife-Objects-Clothes-Types 'TinyLife.Objects.Clothes.Types') registry, the name must be unique across mods.

<a name='F-TinyLife-Objects-Clothes-TextureRegions'></a>
### TextureRegions `constants`

##### Summary

The [TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') that this clothes item uses in the world.
The texture region specified in the constructor only needs to cover the top left animation frame of the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person'), any remaining frames will automatically be gathered.
Multiple layers will be gathered if [Colors](#F-TinyLife-Objects-Clothes-Colors 'TinyLife.Objects.Clothes.Colors') has multiple entries. Each new layer will be gathered to the right of the passed region's area.

<a name='F-TinyLife-Objects-Clothes-Types'></a>
### Types `constants`

##### Summary

A registry that contains all [Clothes](#T-TinyLife-Objects-Clothes 'TinyLife.Objects.Clothes') in the game and all mods

<a name='M-TinyLife-Objects-Clothes-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Clothes-Register-TinyLife-Objects-Clothes-'></a>
### Register(clothes) `method`

##### Summary

Register the given clothes instance to the [Types](#F-TinyLife-Objects-Clothes-Types 'TinyLife.Objects.Clothes.Types') registry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clothes | [TinyLife.Objects.Clothes](#T-TinyLife-Objects-Clothes 'TinyLife.Objects.Clothes') | The clothes to register |

<a name='T-TinyLife-Objects-ClothesLayer'></a>
## ClothesLayer `type`

##### Namespace

TinyLife.Objects

##### Summary

A flag enumeration that defines a set of layers that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')'s [Clothes](#T-TinyLife-Objects-Clothes 'TinyLife.Objects.Clothes') are rendered with.
The ordering is based on the order that these should be drawn in.

<a name='F-TinyLife-Objects-ClothesLayer-Body'></a>
### Body `constants`

##### Summary

A clothes layer for the body (the person's skin) itself

<a name='F-TinyLife-Objects-ClothesLayer-Eyes'></a>
### Eyes `constants`

##### Summary

A clothes layer for eyes

<a name='F-TinyLife-Objects-ClothesLayer-Hair'></a>
### Hair `constants`

##### Summary

A clothes layer for hair

<a name='F-TinyLife-Objects-ClothesLayer-Pants'></a>
### Pants `constants`

##### Summary

A clothes layer for legwear like pants and skirts

<a name='F-TinyLife-Objects-ClothesLayer-Shirt'></a>
### Shirt `constants`

##### Summary

A clothes layer for t-shirts, shirts etc.

<a name='F-TinyLife-Objects-ClothesLayer-Shoes'></a>
### Shoes `constants`

##### Summary

A clothes layer for footwear like shoes

<a name='T-TinyLife-Utilities-ColorScheme'></a>
## ColorScheme `type`

##### Namespace

TinyLife.Utilities

##### Summary

A color scheme is a list of [Color](#T-Microsoft-Xna-Framework-Color 'Microsoft.Xna.Framework.Color') instances with which an object can be colored.
By default, a set of color schemes exist (defined in this class), but new ones can be created easily using [Create](#M-TinyLife-Utilities-ColorScheme-Create-System-Object[]- 'TinyLife.Utilities.ColorScheme.Create(System.Object[])').

<a name='P-TinyLife-Utilities-ColorScheme-Count'></a>
### Count `property`

##### Summary

Stores the amount of [Color](#T-Microsoft-Xna-Framework-Color 'Microsoft.Xna.Framework.Color') instances that are part of this color scheme

<a name='P-TinyLife-Utilities-ColorScheme-Item-System-Int32-'></a>
### Item `property`

##### Summary

Returns the [Color](#T-Microsoft-Xna-Framework-Color 'Microsoft.Xna.Framework.Color') at the given index in this color scheme

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index to return the color for |

<a name='M-TinyLife-Utilities-ColorScheme-Create-System-Object[]-'></a>
### Create(objs) `method`

##### Summary

Create a new color scheme from the given colors.
The colors passed can be of type [Color](#T-Microsoft-Xna-Framework-Color 'Microsoft.Xna.Framework.Color'), [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') or [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32').

##### Returns

A new color scheme with the given colors

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objs | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The colors that this color scheme should contain |

<a name='M-TinyLife-Utilities-ColorScheme-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Utilities-ColorScheme-Load-MLEM-Textures-TextureRegion-'></a>
### Load(region) `method`

##### Summary

Loads a color scheme from the given texture region.
Each pixel on the texture region is evaluated and any pixels with an alpha value greater than zero are added to the color scheme.

##### Returns

A color scheme with the colors from the texture region

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| region | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture region to turn into a color scheme |

<a name='T-TinyLife-Actions-Action-CompletionType'></a>
## CompletionType `type`

##### Namespace

TinyLife.Actions.Action

##### Summary

An enumeration that represents the various states that an [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') can be in.

<a name='F-TinyLife-Actions-Action-CompletionType-Active'></a>
### Active `constants`

##### Summary

A completion type that represents an active action

<a name='F-TinyLife-Actions-Action-CompletionType-Canceled'></a>
### Canceled `constants`

##### Summary

A completion type that represents an action that has been canceled by an outside source

<a name='F-TinyLife-Actions-Action-CompletionType-Completed'></a>
### Completed `constants`

##### Summary

A completion type that represents a completed action

<a name='F-TinyLife-Actions-Action-CompletionType-Failed'></a>
### Failed `constants`

##### Summary

A completion type that represents an action that has failed to complete

<a name='T-TinyLife-Objects-Computer'></a>
## Computer `type`

##### Namespace

TinyLife.Objects

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Objects-Computer-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Objects-Computer-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-ComputerAction'></a>
## ComputerAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-ComputerAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-ComputerAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-ComputerAction-AndThenOnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### AndThenOnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-ComputerAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### AndThenUpdate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-FurnitureType-Constructor'></a>
## Constructor `type`

##### Namespace

TinyLife.Objects.FurnitureType

##### Summary

A delegate method used for [Construct](#F-TinyLife-Objects-FurnitureType-TypeSettings-Construct 'TinyLife.Objects.FurnitureType.TypeSettings.Construct'), which creates a new [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') instance based on the given furniture type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [T:TinyLife.Objects.FurnitureType.Constructor](#T-T-TinyLife-Objects-FurnitureType-Constructor 'T:TinyLife.Objects.FurnitureType.Constructor') | The id to apply to the created furniture instance |

<a name='T-TinyLife-Skills-Cooking'></a>
## Cooking `type`

##### Namespace

TinyLife.Skills

##### Summary

The Cooking class holds various options and settings related to the [Cooking](#F-TinyLife-Skills-SkillType-Cooking 'TinyLife.Skills.SkillType.Cooking') skill

<a name='F-TinyLife-Skills-Cooking-FoodTypes'></a>
### FoodTypes `constants`

##### Summary

All of the [FoodType](#T-TinyLife-Skills-Cooking-FoodType 'TinyLife.Skills.Cooking.FoodType') instances that are registered by the game and mods

<a name='M-TinyLife-Skills-Cooking-RegisterFoodType-TinyLife-Skills-Cooking-FoodType-'></a>
### RegisterFoodType(type) `method`

##### Summary

Registers a new [FoodType](#T-TinyLife-Skills-Cooking-FoodType 'TinyLife.Skills.Cooking.FoodType') with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.Cooking.FoodType](#T-TinyLife-Skills-Cooking-FoodType 'TinyLife.Skills.Cooking.FoodType') | The food type to register |

<a name='T-TinyLife-Objects-CornerFurniture'></a>
## CornerFurniture `type`

##### Namespace

TinyLife.Objects

##### Summary

Corner furniture is furniture like [SimpleCounter](#F-TinyLife-Objects-FurnitureType-SimpleCounter 'TinyLife.Objects.FurnitureType.SimpleCounter') and [Hedge](#F-TinyLife-Objects-FurnitureType-Hedge 'TinyLife.Objects.FurnitureType.Hedge') that automatically connect to their neighbors

<a name='M-TinyLife-Objects-CornerFurniture-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Objects-CornerFurniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-CornerFurniture-OnNeighborChanged-TinyLife-Objects-Furniture-'></a>
### OnNeighborChanged() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-CornerFurniture-ShouldConnectTo-TinyLife-Objects-Furniture-'></a>
### ShouldConnectTo(neighbor) `method`

##### Summary

This method returns whether this furniture instance should connect to the `neighbor` furniture.
By default, this is only true if the [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') is the same.

##### Returns

Whether they should connect

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| neighbor | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The neighbor furniture |

<a name='M-TinyLife-Objects-CornerFurniture-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-CornerFurniture-Counter'></a>
## Counter `type`

##### Namespace

TinyLife.Objects.CornerFurniture

##### Summary

A counter is a [CornerFurniture](#T-TinyLife-Objects-CornerFurniture 'TinyLife.Objects.CornerFurniture') that can also connect to objects that have the [Stove](#F-TinyLife-Objects-ObjectCategory-Stove 'TinyLife.Objects.ObjectCategory.Stove') category

<a name='M-TinyLife-Objects-CornerFurniture-Counter-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Objects-CornerFurniture-Counter-ShouldConnectTo-TinyLife-Objects-Furniture-'></a>
### ShouldConnectTo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Uis-Cursor'></a>
## Cursor `type`

##### Namespace

TinyLife.Uis

##### Summary

The Cursor class contains ways to change the [MouseCursor](#T-Microsoft-Xna-Framework-Input-MouseCursor 'Microsoft.Xna.Framework.Input.MouseCursor') visuals to different [CursorType](#T-TinyLife-Uis-CursorType 'TinyLife.Uis.CursorType') values

<a name='M-TinyLife-Uis-Cursor-SetCursor-TinyLife-Uis-CursorType-'></a>
### SetCursor(type) `method`

##### Summary

Sets the currently used cursor to the given [CursorType](#T-TinyLife-Uis-CursorType 'TinyLife.Uis.CursorType').
Note that, every [Update](#M-MLEM-Startup-MlemGame-Update-Microsoft-Xna-Framework-GameTime- 'MLEM.Startup.MlemGame.Update(Microsoft.Xna.Framework.GameTime)') frame, the cursor is reset to the default.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Uis.CursorType](#T-TinyLife-Uis-CursorType 'TinyLife.Uis.CursorType') | The cursor type to set |

<a name='T-TinyLife-Uis-CursorType'></a>
## CursorType `type`

##### Namespace

TinyLife.Uis

##### Summary

An enumeration that defines types of cursor graphics that can be set using [SetCursor](#M-TinyLife-Uis-Cursor-SetCursor-TinyLife-Uis-CursorType- 'TinyLife.Uis.Cursor.SetCursor(TinyLife.Uis.CursorType)')

<a name='F-TinyLife-Uis-CursorType-Default'></a>
### Default `constants`

##### Summary

The default cursor graphic, which is just an arrow

<a name='F-TinyLife-Uis-CursorType-Disallowed'></a>
### Disallowed `constants`

##### Summary

The disallowed cursor graphic, which is an arrow with a "disallowed" sign next to it

<a name='F-TinyLife-Uis-CursorType-Hammer'></a>
### Hammer `constants`

##### Summary

The hammer cursor graphic, which is a hammer

<a name='F-TinyLife-Uis-CursorType-None'></a>
### None `constants`

##### Summary

No cursor

<a name='F-TinyLife-Uis-CursorType-Range'></a>
### Range `constants`

##### Summary

The range cursor graphic, which is an arrow with small green arrows next to it, arranged in a way to signify that a range is edited

<a name='F-TinyLife-Uis-CursorType-Wall'></a>
### Wall `constants`

##### Summary

The wall placement cursor graphic, which is an arrow with a little wall next to it

<a name='T-TinyLife-Objects-Person-DeathReason'></a>
## DeathReason `type`

##### Namespace

TinyLife.Objects.Person

##### Summary

An enum that represents a set of possible reasons for a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')'s death

<a name='F-TinyLife-Objects-Person-DeathReason-InexplicableReasons'></a>
### InexplicableReasons `constants`

##### Summary

A death reason that represents that a person died from an unknown reason.
This is only used by the "Die" cheat.

<a name='F-TinyLife-Objects-Person-DeathReason-Starvation'></a>
### Starvation `constants`

##### Summary

A death reason that represents that a person died from hunger.
This value is used by [StarveAction](#T-TinyLife-Actions-StarveAction 'TinyLife.Actions.StarveAction').

<a name='T-TinyLife-World-Door'></a>
## Door `type`

##### Namespace

TinyLife.World

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-World-Door-#ctor-TinyLife-World-OpeningType,System-Int32-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-World-Door-CanWalkThrough'></a>
### CanWalkThrough() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Mods-Events-DrawEvent`1'></a>
## DrawEvent\`1 `type`

##### Namespace

TinyLife.Mods.Events

##### Summary

A delegate used by events that are invoked when something is drawn.
This event has no [EventPhase](#T-TinyLife-Mods-EventPhase 'TinyLife.Mods.EventPhase') attached to it, since drawing is done in a sorted fashion anyway.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [T:TinyLife.Mods.Events.DrawEvent\`1](#T-T-TinyLife-Mods-Events-DrawEvent`1 'T:TinyLife.Mods.Events.DrawEvent`1') | The object being updated |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of object that the event is being invoked for |

<a name='T-TinyLife-Actions-DriveAction'></a>
## DriveAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-DriveAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-DriveAction-FindPath-Microsoft-Xna-Framework-Point-'></a>
### FindPath() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-DriveAction-GetSpeed'></a>
### GetSpeed() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-DriveAction-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-DriveAction-OnPathReady'></a>
### OnPathReady() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-DriveAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-Emote'></a>
## Emote `type`

##### Namespace

TinyLife.Actions

##### Summary

An emote is a graphic that can be displayed in a bubble over a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person'), usually as part of a conversation.

<a name='M-TinyLife-Actions-Emote-#ctor-MLEM-Textures-TextureRegion,TinyLife-Actions-EmoteCategory-'></a>
### #ctor(texture,categories) `constructor`

##### Summary

Initializes a new emote with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| texture | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture that this emote should display |
| categories | [TinyLife.Actions.EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') | The categories that this emote should have. Can be a combined flag. |

<a name='F-TinyLife-Actions-Emote-AllCategories'></a>
### AllCategories `constants`

##### Summary

A set of all valid [EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') values

<a name='F-TinyLife-Actions-Emote-Categories'></a>
### Categories `constants`

##### Summary

A combined [EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') flag that determines the categories that this emote belongs to

<a name='F-TinyLife-Actions-Emote-Texture'></a>
### Texture `constants`

##### Summary

The texture that is displayed for this emote

<a name='M-TinyLife-Actions-Emote-GetEmotes-TinyLife-Actions-EmoteCategory-'></a>
### GetEmotes(possibleCategories) `method`

##### Summary

Returns a set of all of the emotes in the given combined category flag

##### Returns

A set of all emotes that match the categories

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| possibleCategories | [TinyLife.Actions.EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') | The categories |

<a name='M-TinyLife-Actions-Emote-GetRandomEmote-TinyLife-Actions-EmoteCategory-'></a>
### GetRandomEmote(possibleCategories) `method`

##### Summary

Returns a random emote from a combined flag of possible categories

##### Returns

A random emote from the given categories

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| possibleCategories | [TinyLife.Actions.EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') | The possible categories |

<a name='M-TinyLife-Actions-Emote-Register-TinyLife-Actions-Emote-'></a>
### Register(emote) `method`

##### Summary

Registers a new [Emote](#T-TinyLife-Actions-Emote 'TinyLife.Actions.Emote') with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emote | [TinyLife.Actions.Emote](#T-TinyLife-Actions-Emote 'TinyLife.Actions.Emote') | The emote to register |

<a name='T-TinyLife-Actions-EmoteCategory'></a>
## EmoteCategory `type`

##### Namespace

TinyLife.Actions

##### Summary

A flag enumeration that represents the types of [Emote](#T-TinyLife-Actions-Emote 'TinyLife.Actions.Emote') that are available

<a name='F-TinyLife-Actions-EmoteCategory-Flirty'></a>
### Flirty `constants`

##### Summary

An emote category that represents sex related or suggestive emotes

<a name='F-TinyLife-Actions-EmoteCategory-General'></a>
### General `constants`

##### Summary

An emote category that represents emotes for general conversations

<a name='F-TinyLife-Actions-EmoteCategory-Negative'></a>
### Negative `constants`

##### Summary

An emote category that represents negative emotes

<a name='F-TinyLife-Actions-EmoteCategory-Travel'></a>
### Travel `constants`

##### Summary

An emote category that represents travel-related emotes

<a name='T-TinyLife-Emotions-EmotionModifier'></a>
## EmotionModifier `type`

##### Namespace

TinyLife.Emotions

##### Summary

An emotion modifier stores information about a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')'s current or past actions or events that influenced their [Emotion](#P-TinyLife-Objects-Person-Emotion 'TinyLife.Objects.Person.Emotion') in some way.
Each emotion modifier contributes to the person's emotion, and the emotion modifier with the highest combined [Amount](#F-TinyLife-Emotions-EmotionModifier-Instance-Amount 'TinyLife.Emotions.EmotionModifier.Instance.Amount') determines the person's [Emotion](#P-TinyLife-Objects-Person-Emotion 'TinyLife.Objects.Person.Emotion').
Emotion modifiers can be applied automatically using [Condition](#F-TinyLife-Emotions-EmotionModifier-Condition 'TinyLife.Emotions.EmotionModifier.Condition') or manually using [AddEmotion](#M-TinyLife-Objects-Person-AddEmotion-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan- 'TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)').

<a name='M-TinyLife-Emotions-EmotionModifier-#ctor-System-String,MLEM-Textures-TextureRegion,TinyLife-Emotions-EmotionType,System-Func{TinyLife-Objects-Person,System-Int32}-'></a>
### #ctor(name,icon,emotion,condition) `constructor`

##### Summary

Creates a new emotion modifier with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The modifier's name |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The modifier's icon |
| emotion | [TinyLife.Emotions.EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') | The modifier's resulting emotion type |
| condition | [System.Func{TinyLife.Objects.Person,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{TinyLife.Objects.Person,System.Int32}') | An optional condition for this modifier |

<a name='F-TinyLife-Emotions-EmotionModifier-Condition'></a>
### Condition `constants`

##### Summary

An (optional) condition that has to be met for this emotion modifier to be applied to a person.
If this value is non-null, and the value returned by this function is greater than zero, this emotion modifier will be applied to a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') with the [Amount](#F-TinyLife-Emotions-EmotionModifier-Instance-Amount 'TinyLife.Emotions.EmotionModifier.Instance.Amount') set to the return value.
If this value is not set, the emotion modifier has to be applied manually using [AddEmotion](#M-TinyLife-Objects-Person-AddEmotion-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan- 'TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)').

<a name='F-TinyLife-Emotions-EmotionModifier-Emotion'></a>
### Emotion `constants`

##### Summary

The [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') that this emotion modifier causes (if the [Amount](#F-TinyLife-Emotions-EmotionModifier-Instance-Amount 'TinyLife.Emotions.EmotionModifier.Instance.Amount') is high enough)

<a name='F-TinyLife-Emotions-EmotionModifier-Icon'></a>
### Icon `constants`

##### Summary

This emotion modifier's icon which will be displayed in the emotions menu

<a name='F-TinyLife-Emotions-EmotionModifier-Name'></a>
### Name `constants`

##### Summary

This emotion modifier's name

<a name='F-TinyLife-Emotions-EmotionModifier-Types'></a>
### Types `constants`

##### Summary

A registry that contains all [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') instances from the game and mods

<a name='M-TinyLife-Emotions-EmotionModifier-Register-TinyLife-Emotions-EmotionModifier-'></a>
### Register(modifier) `method`

##### Summary

Registers the given emotion type into the [Types](#F-TinyLife-Emotions-EmotionModifier-Types 'TinyLife.Emotions.EmotionModifier.Types') registry

##### Returns

The modifier, for chaining

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modifier | [TinyLife.Emotions.EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') | The modifier to register |

<a name='T-TinyLife-Emotions-EmotionType'></a>
## EmotionType `type`

##### Namespace

TinyLife.Emotions

##### Summary

An emotion type is a type of feeling that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have.
The emotion that a person has results from that person's applied [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier')[Instance](#T-TinyLife-Emotions-EmotionModifier-Instance 'TinyLife.Emotions.EmotionModifier.Instance')s.

<a name='M-TinyLife-Emotions-EmotionType-#ctor-System-String,MLEM-Textures-TextureRegion,Microsoft-Xna-Framework-Color,TinyLife-Emotions-EmotionType-TypeCategory-'></a>
### #ctor(name,icon,color,category) `constructor`

##### Summary

Creates a new emotion type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The emotion type's name |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The emotion type's icon |
| color | [Microsoft.Xna.Framework.Color](#T-Microsoft-Xna-Framework-Color 'Microsoft.Xna.Framework.Color') | The emotion type's color |
| category | [TinyLife.Emotions.EmotionType.TypeCategory](#T-TinyLife-Emotions-EmotionType-TypeCategory 'TinyLife.Emotions.EmotionType.TypeCategory') | This emotion type's category |

<a name='F-TinyLife-Emotions-EmotionType-Category'></a>
### Category `constants`

##### Summary

The [TypeCategory](#T-TinyLife-Emotions-EmotionType-TypeCategory 'TinyLife.Emotions.EmotionType.TypeCategory') that this emotion type fits into.
The category is used for ordering and organizing [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') instances.

<a name='F-TinyLife-Emotions-EmotionType-Color'></a>
### Color `constants`

##### Summary

The color that represents this emotion.
The color is used as a backdrop for [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') instances of this type.

<a name='F-TinyLife-Emotions-EmotionType-Icon'></a>
### Icon `constants`

##### Summary

This emotion's icon, which is used in the portrait section for a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that has this emotion

<a name='F-TinyLife-Emotions-EmotionType-Name'></a>
### Name `constants`

##### Summary

This emotion's name

<a name='F-TinyLife-Emotions-EmotionType-Types'></a>
### Types `constants`

##### Summary

A registry of all [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') instances from the game and mods

<a name='M-TinyLife-Emotions-EmotionType-Register-TinyLife-Emotions-EmotionType-'></a>
### Register(type) `method`

##### Summary

Registers the given emotion type to the [Types](#F-TinyLife-Emotions-EmotionType-Types 'TinyLife.Emotions.EmotionType.Types') registry

##### Returns

The passed type, for chaining

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Emotions.EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') | The type to register |

<a name='T-TinyLife-Mods-EventPhase'></a>
## EventPhase `type`

##### Namespace

TinyLife.Mods

##### Summary

An enumeration that represents the phases that an [Events](#T-TinyLife-Mods-Events 'TinyLife.Mods.Events') event can be invoked in

<a name='F-TinyLife-Mods-EventPhase-Post'></a>
### Post `constants`

##### Summary

A phase that represents an event that is invoked *after* something happens

<a name='F-TinyLife-Mods-EventPhase-Pre'></a>
### Pre `constants`

##### Summary

A phase that represents an event that is invoked *before* something happens

<a name='T-TinyLife-Mods-Events'></a>
## Events `type`

##### Namespace

TinyLife.Mods

##### Summary

A set of events that can be subscribed to by mods to allow for special handling of certain situations.
To have more events added to this list if they're required by your mods, please reach out to Ellpeck.
Note that, for events that use an [EventPhase](#T-TinyLife-Mods-EventPhase 'TinyLife.Mods.EventPhase'), the subscriber needs to make sure that the code only runs for one of the phases, and not both, by checking the current phase.

<a name='T-TinyLife-World-ExportedHousehold'></a>
## ExportedHousehold `type`

##### Namespace

TinyLife.World

##### Summary

This class represents an exported version of a [Household](#T-TinyLife-World-Household 'TinyLife.World.Household'), storing all of the [Map](#T-TinyLife-World-Map 'TinyLife.World.Map')-independent data.

<a name='F-TinyLife-World-ExportedHousehold-Members'></a>
### Members `constants`

##### Summary

The [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instances that are members of this household

<a name='F-TinyLife-World-ExportedHousehold-Money'></a>
### Money `constants`

##### Summary

The money that this household has

<a name='T-TinyLife-World-ExportedLot'></a>
## ExportedLot `type`

##### Namespace

TinyLife.World

##### Summary

An exported lot is all of the relevant data of a [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') that should be exported to a file when clicking the "Export" button in the build menu.
To create an exported lot from a lot, use [Export](#M-TinyLife-World-Lot-Export 'TinyLife.World.Lot.Export').

<a name='F-TinyLife-World-ExportedLot-Area'></a>
### Area `constants`

##### Summary

The area that this lot covers in the world

<a name='F-TinyLife-World-ExportedLot-Furniture'></a>
### Furniture `constants`

##### Summary

The [Furniture](#F-TinyLife-World-ExportedLot-Furniture 'TinyLife.World.ExportedLot.Furniture') that is present on this lot

<a name='F-TinyLife-World-ExportedLot-Roofs'></a>
### Roofs `constants`

##### Summary

The roofs that are present on this lot

<a name='F-TinyLife-World-ExportedLot-Tiles'></a>
### Tiles `constants`

##### Summary

The ground tiles of this lot

<a name='F-TinyLife-World-ExportedLot-Type'></a>
### Type `constants`

##### Summary

This lot's [LotType](#T-TinyLife-World-LotType 'TinyLife.World.LotType')

<a name='F-TinyLife-World-ExportedLot-Walls'></a>
### Walls `constants`

##### Summary

The walls that are present on this lot

<a name='M-TinyLife-World-ExportedLot-GetCoveredArea'></a>
### GetCoveredArea() `method`

##### Summary

Returns a [RectangleF](#T-MLEM-Misc-RectangleF 'MLEM.Misc.RectangleF') that represents the area that this lot actually covers.
The area covered by this lot is always bounded by its [Area](#F-TinyLife-World-ExportedLot-Area 'TinyLife.World.ExportedLot.Area'), but will be smaller if there are fewer objects on the lot.

##### Returns

The area that this lot covers

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-ExportedLot-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Utilities-Extensions'></a>
## Extensions `type`

##### Namespace

TinyLife.Utilities

##### Summary

A set of extensions for dealing with various things required by Tiny Life.

<a name='M-TinyLife-Utilities-Extensions-And-TinyLife-Actions-ActionType-CanExecuteResult,TinyLife-Actions-ActionType-CanExecuteResult-'></a>
### And(result,other) `method`

##### Summary

A helper method to return [Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid') only if both passed [CanExecuteResult](#T-TinyLife-Actions-ActionType-CanExecuteResult 'TinyLife.Actions.ActionType.CanExecuteResult') values are [Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid').
If this is not the case, the validity of the `result` is returned if it is not [Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid'), and otherwise, the validity of the `other` is returned.

##### Returns

The validity of both results

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [TinyLife.Actions.ActionType.CanExecuteResult](#T-TinyLife-Actions-ActionType-CanExecuteResult 'TinyLife.Actions.ActionType.CanExecuteResult') | The first result |
| other | [TinyLife.Actions.ActionType.CanExecuteResult](#T-TinyLife-Actions-ActionType-CanExecuteResult 'TinyLife.Actions.ActionType.CanExecuteResult') | The second result |

<a name='M-TinyLife-Utilities-Extensions-GetDecorativeRating-TinyLife-Skills-Quality-'></a>
### GetDecorativeRating(quality) `method`

##### Summary

Returns the decorative rating of an object with the given [Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality').
The returned values are as follows:
[Terrible](#F-TinyLife-Skills-Quality-Terrible 'TinyLife.Skills.Quality.Terrible'): -2,
[Good](#F-TinyLife-Skills-Quality-Good 'TinyLife.Skills.Quality.Good'): 1,
[Great](#F-TinyLife-Skills-Quality-Great 'TinyLife.Skills.Quality.Great'): 1,
[Perfect](#F-TinyLife-Skills-Quality-Perfect 'TinyLife.Skills.Quality.Perfect'): 2,
[Masterpiece](#F-TinyLife-Skills-Quality-Masterpiece 'TinyLife.Skills.Quality.Masterpiece'): 3,
Else: 0.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quality | [TinyLife.Skills.Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality') |  |

<a name='M-TinyLife-Utilities-Extensions-GetOpposite-TinyLife-GenealogyType-'></a>
### GetOpposite(type) `method`

##### Summary

Returns the opposite of the given [GenealogyType](#T-TinyLife-GenealogyType 'TinyLife.GenealogyType').
The "opposite" is the relationship that the other partner of this [GenealogyType](#T-TinyLife-GenealogyType 'TinyLife.GenealogyType') will have.
For example, the opposite of [Parent](#F-TinyLife-GenealogyType-Parent 'TinyLife.GenealogyType.Parent') is [Child](#F-TinyLife-GenealogyType-Child 'TinyLife.GenealogyType.Child') and vice versa.

##### Returns

The genealogy type's opposite

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.GenealogyType](#T-TinyLife-GenealogyType 'TinyLife.GenealogyType') | The genealogy type |

<a name='M-TinyLife-Utilities-Extensions-GetPriceModifier-TinyLife-Skills-Quality-'></a>
### GetPriceModifier(quality) `method`

##### Summary

Returns a multiplier that an object's price should be multiplied with based on the given [Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality').

##### Returns

The price modifier for the object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quality | [TinyLife.Skills.Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality') | The object's quality |

<a name='M-TinyLife-Utilities-Extensions-IsVertical-MLEM-Misc-Direction2-'></a>
### IsVertical(dir) `method`

##### Summary

Returns whether the passed direction is considered vertical.
A vertical direction is [Up](#F-MLEM-Misc-Direction2-Up 'MLEM.Misc.Direction2.Up') and [Down](#F-MLEM-Misc-Direction2-Down 'MLEM.Misc.Direction2.Down'). All other directions return false.

##### Returns

Whether or not the direction is vertical

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dir | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to check verticalness for |

<a name='M-TinyLife-Utilities-Extensions-JsonCopy``1-``0-'></a>
### JsonCopy\`\`1(obj) `method`

##### Summary

Copies the given object using the [Serializer](#F-TinyLife-SaveHandler-Serializer 'TinyLife.SaveHandler.Serializer').

##### Returns

A copy of the object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The object to copy |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the object |

<a name='M-TinyLife-Utilities-Extensions-RotateBy-MLEM-Misc-Direction2,MLEM-Misc-Direction2,MLEM-Misc-Direction2-'></a>
### RotateBy(dir,reference,start) `method`

##### Summary

Rotates the given direction by a given reference direction.

##### Returns

The direction, rotated by the reference direction

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dir | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to rotate |
| reference | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to rotate by |
| start | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to use as the default direction, Up by default |

<a name='M-TinyLife-Utilities-Extensions-ToLocalizedString-TinyLife-Skills-Quality-'></a>
### ToLocalizedString(quality) `method`

##### Summary

Returns a localized string for the given [Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality').

##### Returns

A localized string representing the quality

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| quality | [TinyLife.Skills.Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality') | The quality |

<a name='M-TinyLife-Utilities-Extensions-ToScreenPos-Microsoft-Xna-Framework-Vector2,System-Boolean-'></a>
### ToScreenPos(position,center) `method`

##### Summary

Converts the given world-space position into a draw-space position

##### Returns

The draw-space position

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to convert |
| center | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If this is true, the position will be offset by half a tile, centering it on the screen |

<a name='M-TinyLife-Utilities-Extensions-ToSellingPriceString-System-Single-'></a>
### ToSellingPriceString(value) `method`

##### Summary

Returns a string of the structure "$0.##" that displays the given value as a price in dollars.

##### Returns

The price as a string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The price |

<a name='M-TinyLife-Utilities-Extensions-ToWallSide-MLEM-Misc-Direction2-'></a>
### ToWallSide(dir) `method`

##### Summary

Returns an integer that represents the given [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') as a side of a [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall').
Specifically, [Up](#F-MLEM-Misc-Direction2-Up 'MLEM.Misc.Direction2.Up') and [Left](#F-MLEM-Misc-Direction2-Left 'MLEM.Misc.Direction2.Left') return 0, any other directions return 1.

##### Returns

The corresponding wall side

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dir | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to convert into a wall side |

<a name='M-TinyLife-Utilities-Extensions-ToWorking-TinyLife-Objects-Person-Pose-'></a>
### ToWorking(pose) `method`

##### Summary

Converts the given [Pose](#T-TinyLife-Objects-Person-Pose 'TinyLife.Objects.Person.Pose') to a version in which a person is looking as if they were working on something.
For all standing poses, this returns [WorkingStanding](#F-TinyLife-Objects-Person-Pose-WorkingStanding 'TinyLife.Objects.Person.Pose.WorkingStanding'), and for all sitting poses, [WorkingSitting](#F-TinyLife-Objects-Person-Pose-WorkingSitting 'TinyLife.Objects.Person.Pose.WorkingSitting') is returned.

##### Returns

The working version of the given pose

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pose | [TinyLife.Objects.Person.Pose](#T-TinyLife-Objects-Person-Pose 'TinyLife.Objects.Person.Pose') | The pose to convert to a working pose |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | If the given pose does not have a working version |

<a name='M-TinyLife-Utilities-Extensions-ToWorldPos-Microsoft-Xna-Framework-Vector2-'></a>
### ToWorldPos(position) `method`

##### Summary

Converts the given draw-space position into a world-space position

##### Returns

The world-space position

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to convert |

<a name='T-TinyLife-Objects-Fence'></a>
## Fence `type`

##### Namespace

TinyLife.Objects

##### Summary

A fence is a furniture used by things like [CountryFence](#F-TinyLife-Objects-FurnitureType-CountryFence 'TinyLife.Objects.FurnitureType.CountryFence') that auto-connects similarly to [CornerFurniture](#T-TinyLife-Objects-CornerFurniture 'TinyLife.Objects.CornerFurniture'), but by actually adding additional connection textures onto the regular object textures

<a name='M-TinyLife-Objects-Fence-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Objects-Fence-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Fence-OnNeighborChanged-TinyLife-Objects-Furniture-'></a>
### OnNeighborChanged() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Fence-ShouldConnectTo-TinyLife-Objects-Furniture-'></a>
### ShouldConnectTo(neighbor) `method`

##### Summary

This method returns whether this furniture instance should connect to the `neighbor` furniture.
By default, this is only true if the [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') is the same.

##### Returns

Whether they should connect

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| neighbor | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The neighbor furniture |

<a name='M-TinyLife-Objects-Fence-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-Food'></a>
## Food `type`

##### Namespace

TinyLife.Objects

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Objects-Food-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Objects-Food-FoodLeft'></a>
### FoodLeft `constants`

##### Summary

The amount of food that this food item has left.
This is set to [FoodAmount](#F-TinyLife-Skills-Cooking-FoodType-FoodAmount 'TinyLife.Skills.Cooking.FoodType.FoodAmount') by default

<a name='M-TinyLife-Objects-Food-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Food-GetHoverInfo'></a>
### GetHoverInfo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Skills-Cooking-FoodType'></a>
## FoodType `type`

##### Namespace

TinyLife.Skills.Cooking

##### Summary

A food type is a type of dish that can be cooked using [GetIngredients](#F-TinyLife-Actions-ActionType-GetIngredients 'TinyLife.Actions.ActionType.GetIngredients').
Food types store information such as their name and texture, but also the cooking level that is required to make them.

<a name='M-TinyLife-Skills-Cooking-FoodType-#ctor-System-String,System-Int32,System-Int32,System-Int32,System-Boolean-'></a>
### #ctor(name,requiredCookingLevel,price,foodAmount) `constructor`

##### Summary

Creates a new food type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The food type's name |
| requiredCookingLevel | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The required cooking skill level |
| price | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The price to prepare this food type |
| foodAmount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of food points that this food gives |

<a name='F-TinyLife-Skills-Cooking-FoodType-FoodAmount'></a>
### FoodAmount `constants`

##### Summary

The amount of food points that this food gives.
This is passed to [FoodLeft](#F-TinyLife-Objects-Food-FoodLeft 'TinyLife.Objects.Food.FoodLeft') when a dish is created.
For reference, the mac and cheese dish has a food amount of 100.

<a name='F-TinyLife-Skills-Cooking-FoodType-Name'></a>
### Name `constants`

##### Summary

This food type's name

<a name='F-TinyLife-Skills-Cooking-FoodType-Price'></a>
### Price `constants`

##### Summary

The price that creating this food type has

<a name='F-TinyLife-Skills-Cooking-FoodType-RequiredCookingLevel'></a>
### RequiredCookingLevel `constants`

##### Summary

The level of the [Cooking](#F-TinyLife-Skills-SkillType-Cooking 'TinyLife.Skills.SkillType.Cooking') skill that is required to prepare this dish

<a name='F-TinyLife-Skills-Cooking-FoodType-Texture'></a>
### Texture `constants`

##### Summary

This food type's texture region.
Since the plate will automatically be rendered below this food type, the texture only needs to contain the dish itself.

<a name='T-TinyLife-Objects-FoodTypedItem'></a>
## FoodTypedItem `type`

##### Namespace

TinyLife.Objects

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Objects-FoodTypedItem-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Objects-FoodTypedItem-Creator'></a>
### Creator `constants`

##### Summary

The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') of the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that created this item

<a name='F-TinyLife-Objects-FoodTypedItem-FoodType'></a>
### FoodType `constants`

##### Summary

The [FoodType](#T-TinyLife-Skills-Cooking-FoodType 'TinyLife.Skills.Cooking.FoodType') that this food-typed item has

<a name='M-TinyLife-Objects-FoodTypedItem-GetHoverInfo'></a>
### GetHoverInfo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-FoodTypedItem-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-Furniture'></a>
## Furniture `type`

##### Namespace

TinyLife.Objects

##### Summary

A furniture is an instance of a [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') which is placed in the world, or in a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')'s hand.
To register a custom furniture, use [Register](#M-TinyLife-Objects-FurnitureType-Register-TinyLife-Objects-FurnitureType-TypeSettings- 'TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)').

<a name='M-TinyLife-Objects-Furniture-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor(id,type,colors,map,pos) `constructor`

##### Summary

Creates a new furniture instance.
By default, this is done using [Constructor](#T-TinyLife-Objects-FurnitureType-Constructor 'TinyLife.Objects.FurnitureType.Constructor').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The id to apply to the created furniture instance |
| type | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The type to create an instance of |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors to apply to the furniture |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to create the furniture on |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that the furniture should have |

<a name='F-TinyLife-Objects-Furniture-Colors'></a>
### Colors `constants`

##### Summary

The indices of the colors that this furniture has.
Refer to [ColorSchemes](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorSchemes 'TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes') for the actual colors that these indices represent.

<a name='F-TinyLife-Objects-Furniture-Rotation'></a>
### Rotation `constants`

##### Summary

The current rotation of this furniture.
Since furniture has a wide variety of looks, the specific value of the rotation doesn't necessarily have much practical meaning.

<a name='F-TinyLife-Objects-Furniture-Type'></a>
### Type `constants`

##### Summary

The [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') that this furniture has

<a name='P-TinyLife-Objects-Furniture-Area'></a>
### Area `property`

##### Summary

A [RectangleF](#T-MLEM-Misc-RectangleF 'MLEM.Misc.RectangleF') that represents the area that this furniture piece is currently taking up, based on its [GetSize](#M-TinyLife-Objects-FurnitureType-GetSize-MLEM-Misc-Direction2- 'TinyLife.Objects.FurnitureType.GetSize(MLEM.Misc.Direction2)') and its [Position](#P-TinyLife-Objects-MapObject-Position 'TinyLife.Objects.MapObject.Position')

<a name='P-TinyLife-Objects-Furniture-ParentFurniture'></a>
### ParentFurniture `property`

##### Summary

The [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') that this furniture is currently latched on to.
If this value is non-null, [ParentObjectSpot](#P-TinyLife-Objects-Furniture-ParentObjectSpot 'TinyLife.Objects.Furniture.ParentObjectSpot') returns the object spot that this furniture is in.

<a name='P-TinyLife-Objects-Furniture-ParentObjectSpot'></a>
### ParentObjectSpot `property`

##### Summary

The [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') that this furniture is currently in.
If this value is non-null, [ParentFurniture](#P-TinyLife-Objects-Furniture-ParentFurniture 'TinyLife.Objects.Furniture.ParentFurniture') returns the furniture that this object spot belongs to.

<a name='M-TinyLife-Objects-Furniture-AddChild-TinyLife-Objects-Furniture,MLEM-Misc-Direction2-'></a>
### AddChild(item,rotation) `method`

##### Summary

Adds a child to this furniture, setting its parent ([SetParent](#M-TinyLife-Objects-Furniture-SetParent-TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot- 'TinyLife.Objects.Furniture.SetParent(TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot)')) to this furniture.
The object spot selected is the first available object spot.

##### Returns

If there was a free object spot to add the furniture to

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furniture to add as the child |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation that the furniture should have, can be the same as the previous rotation |

<a name='M-TinyLife-Objects-Furniture-AddChild``1-TinyLife-Objects-FurnitureType,MLEM-Misc-Direction2,System-Int32[],System-Nullable{System-Guid}-'></a>
### AddChild\`\`1(type,rotation,colors,id) `method`

##### Summary

Adds a child to this furniture, setting its parent ([SetParent](#M-TinyLife-Objects-Furniture-SetParent-TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot- 'TinyLife.Objects.Furniture.SetParent(TinyLife.Objects.Furniture,TinyLife.Objects.ObjectSpot)')) to this furniture.

##### Returns

The child that was added, or null if it doesn't match the type specified

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The type of furniture to construct as the child |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The desired rotation of the child furniture |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors that the child should have |
| id | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | The id that the child should have, random by default |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of furniture that the child is |

<a name='M-TinyLife-Objects-Furniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean-'></a>
### Draw(time,batch,pos,drawPos,overrideColor,rotation,colors,drawScale,pivot,parent,parentSpot,depthOffset) `method`

##### Summary

Draws this furniture in the world with the given settings.
This is a more generalized version of [Draw](#M-TinyLife-Objects-Furniture-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}- 'TinyLife.Objects.Furniture.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2,System.Nullable{Microsoft.Xna.Framework.Color})')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to draw with |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in world space, that the furniture is at |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in draw space, to draw the furniture at |
| overrideColor | [System.Nullable{Microsoft.Xna.Framework.Color}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.Xna.Framework.Color}') | An optional color to override the default colors of the furniture |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation of the furniture |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors to draw the furniture with |
| drawScale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw the furniture with |
| pivot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to move the furniture by its texture's pivot point |
| parent | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The object that this furniture is latched on to, or null if there is none |
| parentSpot | [TinyLife.Objects.ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') | The object spot that this furntiture is in, or null if there is none |
| depthOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | A value that is added onto the calculated depth of the object |

<a name='M-TinyLife-Objects-Furniture-DrawUi-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,MLEM-Ui-Elements-Element,System-Single,System-Int32[]-'></a>
### DrawUi(time,batch,element,drawScale,colors) `method`

##### Summary

Draws this furniture in a ui context, rather than a world context.
Scale is determined based on the element that is passed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to draw with |
| element | [MLEM.Ui.Elements.Element](#T-MLEM-Ui-Elements-Element 'MLEM.Ui.Elements.Element') | The element to calculate scaling based on |
| drawScale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw the furniture with |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors to draw the furniture with |

<a name='M-TinyLife-Objects-Furniture-GetAiPriority-TinyLife-Objects-Person-'></a>
### GetAiPriority() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-GetCategories-TinyLife-Objects-Person-'></a>
### GetCategories() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-GetChildren``1'></a>
### GetChildren\`\`1() `method`

##### Summary

Returns a list of all of the children of this furniture.
Children are all furnitures in the world that have their [ParentFurniture](#P-TinyLife-Objects-Furniture-ParentFurniture 'TinyLife.Objects.Furniture.ParentFurniture') set to this furniture instance.

##### Returns

A list of this furniture's children

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-GetFreeActionSpot-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory-'></a>
### GetFreeActionSpot(person,context) `method`

##### Summary

Returns the first free action spot from [GetFreeActionSpots](#M-TinyLife-Objects-Furniture-GetFreeActionSpots-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpots(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)').

##### Returns

A free action spot and the direction it's free in, or an empty tuple if there is no free action spot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query free action spots for |
| context | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The object category that this action spot needs to have |

<a name='M-TinyLife-Objects-Furniture-GetFreeActionSpotInfo-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory-'></a>
### GetFreeActionSpotInfo(person,context) `method`

##### Summary

Returns the first free action spot from [GetFreeActionSpot](#M-TinyLife-Objects-Furniture-GetFreeActionSpot-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory- 'TinyLife.Objects.Furniture.GetFreeActionSpot(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)'), but packed into an [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo').

##### Returns

The first free action spot as an [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query free action spots for |
| context | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The object category that this action spot needs to have |

<a name='M-TinyLife-Objects-Furniture-GetFreeActionSpots-TinyLife-Objects-Person,TinyLife-Objects-ObjectCategory-'></a>
### GetFreeActionSpots(person,context) `method`

##### Summary

Returns a list of [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') instances that are part of this furniture, which are considered free.
Free, in this instance, is any spot that has the given category and is not currently occupied by another person.

##### Returns

A set of action spots and the directions which they're free in

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query free action spots for |
| context | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The object category that this action spot needs to have |

<a name='M-TinyLife-Objects-Furniture-GetFreeObjectSpot-TinyLife-Objects-FurnitureType-'></a>
### GetFreeObjectSpot(type) `method`

##### Summary

Returns the first free [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') on this furniture.
Free, in this case, is any object spot that isn't already occupied by a different furniture.

##### Returns

A free object spot, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The furniture type to find a free object spot for |

<a name='M-TinyLife-Objects-Furniture-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-Intersects-MLEM-Misc-RectangleF-'></a>
### Intersects() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-OnAdded'></a>
### OnAdded() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-OnNeighborChanged-TinyLife-Objects-Furniture-'></a>
### OnNeighborChanged(neighbor) `method`

##### Summary

This method gets called when any neighboring furniture changes. The neighboring furniture is passed.
By default, this method does nothing, so calling base is not necessary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| neighbor | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The neighbor furniture that changed |

<a name='M-TinyLife-Objects-Furniture-OnRemoved'></a>
### OnRemoved() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Furniture-RemoveChildren``1-System-Predicate{``0}-'></a>
### RemoveChildren\`\`1(predicate) `method`

##### Summary

Removes all of the children from this furniture that match the given predicate.
Children are all furnitures in the world that have their [ParentFurniture](#P-TinyLife-Objects-Furniture-ParentFurniture 'TinyLife.Objects.Furniture.ParentFurniture') set to this furniture instance.

##### Returns

The children that were removed from this furniture

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| predicate | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The predicate to check children against. If null, all children will be removed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of children to remove |

<a name='M-TinyLife-Objects-Furniture-SetChild-TinyLife-Objects-ObjectSpot,TinyLife-Objects-FurnitureType,MLEM-Misc-Direction2,System-Int32[],System-Nullable{System-Guid}-'></a>
### SetChild(spot,type,rotation,colors,id) `method`

##### Summary

Sets the child element in the given object spot to the given furniture.
If there are already children in the given object spot, those are removed prior to adding the new child.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| spot | [TinyLife.Objects.ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') | The spot to add the child to |
| type | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The type of furniture to construct as the child |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The desired rotation of the child furniture |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors that the child should have |
| id | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | The id that the child should have, random by default |

<a name='M-TinyLife-Objects-Furniture-SetChild-TinyLife-Objects-ObjectSpot,TinyLife-Objects-Furniture,MLEM-Misc-Direction2-'></a>
### SetChild(spot,item,rotation) `method`

##### Summary

Sets the child element in the given object spot to the given furniture.
If there are already children in the given object spot, those are removed prior to adding the new child.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| spot | [TinyLife.Objects.ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') | The spot to add the child to |
| item | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furniture to add to the spot |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The desired rotation of the child furniture |

<a name='M-TinyLife-Objects-Furniture-SetParent-TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot-'></a>
### SetParent(parent,spot) `method`

##### Summary

Sets the parent of this furniture, changing its [Position](#P-TinyLife-Objects-MapObject-Position 'TinyLife.Objects.MapObject.Position') and settings its [ParentObjectSpot](#P-TinyLife-Objects-Furniture-ParentObjectSpot 'TinyLife.Objects.Furniture.ParentObjectSpot') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parent | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The parent furniture to slot into |
| spot | [TinyLife.Objects.ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') | The object spot to slot into |

<a name='M-TinyLife-Objects-Furniture-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Tools-FurniturePlacer'></a>
## FurniturePlacer `type`

##### Namespace

TinyLife.Tools

##### Summary

A helper class that represents a tool part which allows the placement and movement of furniture objects.
This class is used by [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool') and [MoveTool](#T-TinyLife-Tools-MoveTool 'TinyLife.Tools.MoveTool').

<a name='P-TinyLife-Tools-FurniturePlacer-SelectedColors'></a>
### SelectedColors `property`

##### Summary

The color indices that are currently selected for the [SelectedFurniture](#P-TinyLife-Tools-FurniturePlacer-SelectedFurniture 'TinyLife.Tools.FurniturePlacer.SelectedFurniture')

<a name='P-TinyLife-Tools-FurniturePlacer-SelectedFurniture'></a>
### SelectedFurniture `property`

##### Summary

The [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') that is currently selected for placement

<a name='P-TinyLife-Tools-FurniturePlacer-SelectedPreview'></a>
### SelectedPreview `property`

##### Summary

An instance of the [SelectedFurniture](#P-TinyLife-Tools-FurniturePlacer-SelectedFurniture 'TinyLife.Tools.FurniturePlacer.SelectedFurniture')

<a name='M-TinyLife-Tools-FurniturePlacer-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw(time,batch) `method`

##### Summary

Draws the [SelectedPreview](#P-TinyLife-Tools-FurniturePlacer-SelectedPreview 'TinyLife.Tools.FurniturePlacer.SelectedPreview') of this furniture placer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |

<a name='M-TinyLife-Tools-FurniturePlacer-ForceWallsUp'></a>
### ForceWallsUp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurniturePlacer-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurniturePlacer-HighlightSelectedObject'></a>
### HighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurniturePlacer-SelectFurniture-TinyLife-Objects-FurnitureType,TinyLife-Objects-Furniture,System-Action{TinyLife-Objects-Furniture},MLEM-Misc-Direction2,System-Int32[],System-Boolean-'></a>
### SelectFurniture(furniture,preview,variation,rotation,colors,exact) `method`

##### Summary

Selects the given [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType').
If `exact` is enabled, the `preview` is the exact furniture instance that will be placed. If it is false, a new instance of the given `furniture` will be created upon placement.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The furniture type to select |
| preview | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | An instance of the given `furniture` |
| variation | [System.Action{TinyLife.Objects.Furniture}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{TinyLife.Objects.Furniture}') | A function that represents a furniture variation to place |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation to select |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors to select |
| exact | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the `preview` is the exact instance that should be placed |

<a name='M-TinyLife-Tools-FurniturePlacer-Update'></a>
### Update() `method`

##### Summary

Updates this furniture placer.
This should be called in [Update](#M-TinyLife-Tools-Tool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.Tool.Update(Microsoft.Xna.Framework.GameTime)') each frame.

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Tools-FurnitureTool'></a>
## FurnitureTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-FurnitureTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-FurnitureTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurnitureTool-ForceWallsUp'></a>
### ForceWallsUp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurnitureTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurnitureTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurnitureTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-FurnitureTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-FurnitureType'></a>
## FurnitureType `type`

##### Namespace

TinyLife.Objects

##### Summary

A furniture type is basically a blueprint for [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') objects.
Each furniture type can create a furniture instance and the type's data will be transferred to the instance.
Furniture types are automatically listed in the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool') if registered using [Register](#M-TinyLife-Objects-FurnitureType-Register-TinyLife-Objects-FurnitureType-TypeSettings- 'TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)').

<a name='F-TinyLife-Objects-FurnitureType-Textures'></a>
### Textures `constants`

##### Summary

The textures that this furniture type has.
Each texture is automatically loaded based on the registered [DataTextureAtlas](#T-MLEM-Data-DataTextureAtlas 'MLEM.Data.DataTextureAtlas') instances.
If a furniture type has multiple [ColorMap](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorMap 'TinyLife.Objects.FurnitureType.TypeSettings.ColorMap') entries (or multiple [ColorSchemes](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorSchemes 'TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes')), additional texture regions will automatically be created to the right of the original texture region.

<a name='F-TinyLife-Objects-FurnitureType-Types'></a>
### Types `constants`

##### Summary

A list of all available furniture types. Register furniture types using [Register](#M-TinyLife-Objects-FurnitureType-Register-TinyLife-Objects-FurnitureType-TypeSettings- 'TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)').

<a name='P-TinyLife-Objects-FurnitureType-ReferenceTexture'></a>
### ReferenceTexture `property`

##### Summary

A reference texture that is used for visual size calculations. Always returns the first available texture of [DefaultRotation](#F-TinyLife-Objects-FurnitureType-TypeSettings-DefaultRotation 'TinyLife.Objects.FurnitureType.TypeSettings.DefaultRotation') in [Textures](#F-TinyLife-Objects-FurnitureType-Textures 'TinyLife.Objects.FurnitureType.Textures')

<a name='P-TinyLife-Objects-FurnitureType-Rotations'></a>
### Rotations `property`

##### Summary

The valid rotations that this furniture has, which are automatically determined based on the available [Textures](#F-TinyLife-Objects-FurnitureType-Textures 'TinyLife.Objects.FurnitureType.Textures')

<a name='P-TinyLife-Objects-FurnitureType-Settings'></a>
### Settings `property`

##### Summary

This furniture type's settings

<a name='M-TinyLife-Objects-FurnitureType-AreWallsInTheWay-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2-'></a>
### AreWallsInTheWay(map,pos,rotation) `method`

##### Summary

Returns whether or not there would be walls in the way if this furniture type was placed at the given position with the given rotation

##### Returns

Whether there are walls in the way if the furniture gets placed in this location

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to place the furniture on |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that the furniture should be placed at |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation that the furniture should have |

<a name='M-TinyLife-Objects-FurnitureType-Construct-System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,System-Nullable{System-Guid}-'></a>
### Construct(colors,map,pos,id) `method`

##### Summary

Constructs a new [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') object from this furniture type

##### Returns

A new furniture instance of this type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The indices of the colors that the furniture should have |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map that the furniture should be added to |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that the furniture should have |
| id | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | The id that the furniture should have, or a random one by defualt |

<a name='M-TinyLife-Objects-FurnitureType-DrawColumns-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,MLEM-Textures-TextureRegion,Microsoft-Xna-Framework-Color,System-Single,Microsoft-Xna-Framework-Point,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean,System-Boolean,System-Boolean-'></a>
### DrawColumns(map,position,rotation,batch,drawPos,texture,color,scale,size,pivot,parent,spot,depthOffset,mirror,wallHanging,groundItem) `method`

##### Summary

Draws the given texture region in columns, which allows for depth calculation in isometric view to be possible.
Bigger objects, including all furniture, are drawn in this matter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map that the object is on |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that the object is on, in world space |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation that this object has, used for some calculations |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to draw with |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to draw at, in draw space |
| texture | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture region to draw |
| color | [Microsoft.Xna.Framework.Color](#T-Microsoft-Xna-Framework-Color 'Microsoft.Xna.Framework.Color') | The color to draw with |
| scale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw at |
| size | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The size, in tiles, that this object has |
| pivot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the object should be translated by the texture's pivot point |
| parent | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The object's parent object |
| spot | [TinyLife.Objects.ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') | The object's parent spot |
| depthOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | A value that is added to the calculated object's depth |
| mirror | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to mirror the texture |
| wallHanging | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not this object is hanging on a wall |
| groundItem | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not this item is considered a ground item (that doesn't have any collisions) |

<a name='M-TinyLife-Objects-FurnitureType-DrawLayers-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2,MLEM-Textures-TextureRegion[],System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Nullable{Microsoft-Xna-Framework-Color},System-Single,System-Boolean-'></a>
### DrawLayers(map,position,batch,drawPos,rotation,layers,colors,scale,pivot,parent,spot,overrideColor,depthOffset) `method`

##### Summary

Draws the furniture type with the given data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to draw the furniture type on |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position on the map that the furniture is at |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch used for drawing |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that this furniture should be drawn at on the screen |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation of the furniture |
| layers | [MLEM.Textures.TextureRegion[]](#T-MLEM-Textures-TextureRegion[] 'MLEM.Textures.TextureRegion[]') | The textures to draw this furniture with |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The indices in the [ColorSchemes](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorSchemes 'TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes') that the furniture should be drawn with |
| scale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale that the furniture should be drawn with |
| pivot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the furniture should be shifted by its pivot point |
| parent | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The parent that the furniture is attached to. Can be null. |
| spot | [TinyLife.Objects.ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') | The object spot that the furniture is on, or null if there is no `parent` |
| overrideColor | [System.Nullable{Microsoft.Xna.Framework.Color}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.Xna.Framework.Color}') | The color that should be used to draw this furniture instead of `colors` |
| depthOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | A value that is added to the depth calculation for drawing this furniture type |

<a name='M-TinyLife-Objects-FurnitureType-GetColumns-MLEM-Misc-Direction2-'></a>
### GetColumns(rotation) `method`

##### Summary

Returns the amount of columns that this furniture should be drawn in, based on the given rotation.

##### Returns

The amount of columns to draw

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation |

<a name='M-TinyLife-Objects-FurnitureType-GetCoveredTiles-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Point-'></a>
### GetCoveredTiles(pos,size) `method`

##### Summary

Returns a rectangle that contains all of the tiles which intersect with the furniture when placed at the given position, with the given size.

##### Returns

A rectangle with all of the tiles that are covered

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to place the furniture at |
| size | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The size of the furniture |

<a name='M-TinyLife-Objects-FurnitureType-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-FurnitureType-GetSize-MLEM-Misc-Direction2-'></a>
### GetSize(rotation) `method`

##### Summary

Returns the [Size](#F-TinyLife-Objects-FurnitureType-TypeSettings-Size 'TinyLife.Objects.FurnitureType.TypeSettings.Size') of this furniture type, modified based on the given rotation.

##### Returns

The modified size

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation to return the size for |

<a name='M-TinyLife-Objects-FurnitureType-GetTexture-System-String-'></a>
### GetTexture(name) `method`

##### Summary

Returns a [TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') with the given name, based on all of the textures in the base game and all [GetCustomFurnitureTextures](#M-TinyLife-Mods-Mod-GetCustomFurnitureTextures 'TinyLife.Mods.Mod.GetCustomFurnitureTextures') textures.

##### Returns

A texture region with the given name, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the texture to get |

<a name='M-TinyLife-Objects-FurnitureType-GetTextures-System-String,System-Int32-'></a>
### GetTextures(name,amount) `method`

##### Summary

Create a dictionary of textures for all [Adjacent](#F-MLEM-Misc-Direction2Helper-Adjacent 'MLEM.Misc.Direction2Helper.Adjacent') directions that have a texture registered for them.
Textures are gathered using [GetCustomFurnitureTextures](#M-TinyLife-Mods-Mod-GetCustomFurnitureTextures 'TinyLife.Mods.Mod.GetCustomFurnitureTextures'), and textures need to be suffixed with the direction's string to be recognized.
This method is used for furniture of all kinds.

##### Returns

A dictionary of directions to texture layers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the texture to load |
| amount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of layers the texture has |

<a name='M-TinyLife-Objects-FurnitureType-GetWallsInTheWay-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,MLEM-Misc-Direction2-'></a>
### GetWallsInTheWay(map,pos,rotation) `method`

##### Summary

Returns a set of walls that would be in the way if this furniture type was placed at the given position with the given rotation

##### Returns

A set of walls that would be in the way

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to place the furniture on |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that the furniture should be placed at |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The rotation that the furniture should have |

<a name='M-TinyLife-Objects-FurnitureType-HasCategory-TinyLife-Objects-ObjectCategory-'></a>
### HasCategory(category) `method`

##### Summary

Returns whether this type's [Settings](#P-TinyLife-Objects-FurnitureType-Settings 'TinyLife.Objects.FurnitureType.Settings') have any of the supplied [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') values

##### Returns

Whether the category is present

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The category to query |

<a name='M-TinyLife-Objects-FurnitureType-Register-TinyLife-Objects-FurnitureType-TypeSettings-'></a>
### Register(settings) `method`

##### Summary

Register a custom furniture type.

##### Returns

The registered furniture type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settings | [TinyLife.Objects.FurnitureType.TypeSettings](#T-TinyLife-Objects-FurnitureType-TypeSettings 'TinyLife.Objects.FurnitureType.TypeSettings') | The settings to apply to the custom furniture type |

<a name='T-TinyLife-GameImpl'></a>
## GameImpl `type`

##### Namespace

TinyLife

##### Summary

The main class for Tiny Life, which houses a set of important game-wide properties.

<a name='F-TinyLife-GameImpl-CurrentTime'></a>
### CurrentTime `constants`

##### Summary

The current in-game total time since the start of the game.

<a name='F-TinyLife-GameImpl-FollowingPerson'></a>
### FollowingPerson `constants`

##### Summary

The [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that the camera is currently locked onto

<a name='P-TinyLife-GameImpl-Camera'></a>
### Camera `property`

##### Summary

The game's in-world camera, created in [LoadContent](#M-TinyLife-GameImpl-LoadContent 'TinyLife.GameImpl.LoadContent')

<a name='P-TinyLife-GameImpl-CurrentHousehold'></a>
### CurrentHousehold `property`

##### Summary

The household that is currently being played, or

```
null
```

if in the main menu, editing a lot or on the map select screen

<a name='P-TinyLife-GameImpl-CurrentLot'></a>
### CurrentLot `property`

##### Summary

The lot that is currently being played on or edited, or

```
null
```

if in the main menu or on the map select screen

<a name='P-TinyLife-GameImpl-CurrentTool'></a>
### CurrentTool `property`

##### Summary

The [Tool](#T-TinyLife-Tools-Tool 'TinyLife.Tools.Tool') that is currently selected. Should always be set to either [PlayModeTool](#F-TinyLife-Tools-Tool-PlayModeTool 'TinyLife.Tools.Tool.PlayModeTool') or any of [BuildTools](#F-TinyLife-Tools-Tool-BuildTools 'TinyLife.Tools.Tool.BuildTools').

<a name='P-TinyLife-GameImpl-GraphicsMetrics'></a>
### GraphicsMetrics `property`

##### Summary

The game's graphics metrics, gathered at the end of every [DoDraw](#M-TinyLife-GameImpl-DoDraw-Microsoft-Xna-Framework-GameTime- 'TinyLife.GameImpl.DoDraw(Microsoft.Xna.Framework.GameTime)') call

<a name='P-TinyLife-GameImpl-Instance'></a>
### Instance `property`

##### Summary

The game's singleton instance

<a name='P-TinyLife-GameImpl-Listener'></a>
### Listener `property`

##### Summary

The game's [AudioListener](#T-Microsoft-Xna-Framework-Audio-AudioListener 'Microsoft.Xna.Framework.Audio.AudioListener') that is automatically moved to the [Camera](#P-TinyLife-GameImpl-Camera 'TinyLife.GameImpl.Camera')'s position

<a name='P-TinyLife-GameImpl-Map'></a>
### Map `property`

##### Summary

The map that the game is currently on, or

```
null
```

if in the main menu

<a name='P-TinyLife-GameImpl-Mode'></a>
### Mode `property`

##### Summary

The [GameMode](#T-TinyLife-GameImpl-GameMode 'TinyLife.GameImpl.GameMode') that is currently active

<a name='P-TinyLife-GameImpl-Money'></a>
### Money `property`

##### Summary

The money that the [CurrentHousehold](#P-TinyLife-GameImpl-CurrentHousehold 'TinyLife.GameImpl.CurrentHousehold') has, or [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single.MaxValue 'System.Single.MaxValue') if there is no active household

<a name='P-TinyLife-GameImpl-SaveName'></a>
### SaveName `property`

##### Summary

The name of the save file that is currently being played, or

```
null
```

if in the main menu

<a name='P-TinyLife-GameImpl-Speed'></a>
### Speed `property`

##### Summary

The current [GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed').
Note that, if the current speed is [VeryFast](#F-TinyLife-GameSpeed-VeryFast 'TinyLife.GameSpeed.VeryFast') and the game [CanBeExtremelyFast](#M-TinyLife-GameImpl-CanBeExtremelyFast 'TinyLife.GameImpl.CanBeExtremelyFast'), [ExtremelyFast](#F-TinyLife-GameSpeed-ExtremelyFast 'TinyLife.GameSpeed.ExtremelyFast') is returned.

<a name='P-TinyLife-GameImpl-Weekday'></a>
### Weekday `property`

##### Summary

The current in-game weekday, based on [CurrentTime](#F-TinyLife-GameImpl-CurrentTime 'TinyLife.GameImpl.CurrentTime')

<a name='M-TinyLife-GameImpl-CanBeExtremelyFast'></a>
### CanBeExtremelyFast() `method`

##### Summary

Returns whether the game allows changing the speed to [ExtremelyFast](#F-TinyLife-GameSpeed-ExtremelyFast 'TinyLife.GameSpeed.ExtremelyFast') at the current time.
If this returns true, and [Speed](#P-TinyLife-GameImpl-Speed 'TinyLife.GameImpl.Speed') is set to [VeryFast](#F-TinyLife-GameSpeed-VeryFast 'TinyLife.GameSpeed.VeryFast'), the [ExtremelyFast](#F-TinyLife-GameSpeed-ExtremelyFast 'TinyLife.GameSpeed.ExtremelyFast') speed is automatically engaged.

##### Returns

Whether the game can become extremely fast

##### Parameters

This method has no parameters.

<a name='M-TinyLife-GameImpl-CanSaveOrSwitchModes'></a>
### CanSaveOrSwitchModes() `method`

##### Summary

Returns whether the game can currently save or if [SwitchGameMode](#M-TinyLife-GameImpl-SwitchGameMode-TinyLife-GameImpl-GameMode- 'TinyLife.GameImpl.SwitchGameMode(TinyLife.GameImpl.GameMode)') is allowed to be used right now.
The return value is influenced by [CanSaveOrSwitchModes](#M-TinyLife-Tools-Tool-CanSaveOrSwitchModes 'TinyLife.Tools.Tool.CanSaveOrSwitchModes') and [AreRequirementsMet](#M-TinyLife-World-Lot-AreRequirementsMet 'TinyLife.World.Lot.AreRequirementsMet').

##### Returns

Whether we can save or switch modes right now

##### Parameters

This method has no parameters.

<a name='M-TinyLife-GameImpl-DoDraw-Microsoft-Xna-Framework-GameTime-'></a>
### DoDraw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-GameImpl-DoUpdate-Microsoft-Xna-Framework-GameTime-'></a>
### DoUpdate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-GameImpl-IsMouseOnUi'></a>
### IsMouseOnUi() `method`

##### Summary

Returns true if the mouse is currently on top of any ui element in the [UiSystem](#T-MLEM-Ui-UiSystem 'MLEM.Ui.UiSystem')

##### Returns

true if the mouse is currently on top of any element

##### Parameters

This method has no parameters.

<a name='M-TinyLife-GameImpl-LoadContent'></a>
### LoadContent() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-GameImpl-SwitchGameMode-TinyLife-GameImpl-GameMode-'></a>
### SwitchGameMode(mode) `method`

##### Summary

Switches the game mode to the given mode, and sets up all of the required data.
Note that some game modes require certain data to be set prior to calling this method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mode | [TinyLife.GameImpl.GameMode](#T-TinyLife-GameImpl-GameMode 'TinyLife.GameImpl.GameMode') | The game mode to switch to |

<a name='T-TinyLife-GameImpl-GameMode'></a>
## GameMode `type`

##### Namespace

TinyLife.GameImpl

##### Summary

An enumeration that contains values representing the different game modes the game can be in

<a name='F-TinyLife-GameImpl-GameMode-BuildOnly'></a>
### BuildOnly `constants`

##### Summary

A game mode that represents the play mode forced to build mode (with no current household)

<a name='F-TinyLife-GameImpl-GameMode-InGameHousehold'></a>
### InGameHousehold `constants`

##### Summary

A game mode that represents the play mode, either in-game or in build mode

<a name='F-TinyLife-GameImpl-GameMode-MainMenu'></a>
### MainMenu `constants`

##### Summary

A game mode that represents the main menu

<a name='F-TinyLife-GameImpl-GameMode-SelectHousehold'></a>
### SelectHousehold `constants`

##### Summary

A game mode that represents the map selection menu

<a name='T-TinyLife-GameSpeed'></a>
## GameSpeed `type`

##### Namespace

TinyLife

##### Summary

An enumeration of all possible game speeds.
The value of each value is the amount that the game's speed is multiplied with.

<a name='F-TinyLife-GameSpeed-ExtremelyFast'></a>
### ExtremelyFast `constants`

##### Summary

A game speed with which things happen at 20 times the [Regular](#F-TinyLife-GameSpeed-Regular 'TinyLife.GameSpeed.Regular') speed.
Note that this option is not selectable and only occurs if every household member is asleep or out of town.

<a name='F-TinyLife-GameSpeed-Fast'></a>
### Fast `constants`

##### Summary

A game speed with which things happen at twice the [Regular](#F-TinyLife-GameSpeed-Regular 'TinyLife.GameSpeed.Regular') speed

<a name='F-TinyLife-GameSpeed-Paused'></a>
### Paused `constants`

##### Summary

A game speed that represents no actions occuring

<a name='F-TinyLife-GameSpeed-Regular'></a>
### Regular `constants`

##### Summary

A game speed that represents the regular speed

<a name='F-TinyLife-GameSpeed-VeryFast'></a>
### VeryFast `constants`

##### Summary

A game speed with which things happen at three times the [Regular](#F-TinyLife-GameSpeed-Regular 'TinyLife.GameSpeed.Regular') speed

<a name='T-TinyLife-GenealogyType'></a>
## GenealogyType `type`

##### Namespace

TinyLife

##### Summary

An enumeration that represents the type that a [Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship')'s genealogy can have.
Note that these typs are deliberately gender-neutral.

<a name='F-TinyLife-GenealogyType-Child'></a>
### Child `constants`

##### Summary

A genealogy type that represents a child of a [Parent](#F-TinyLife-GenealogyType-Parent 'TinyLife.GenealogyType.Parent')

<a name='F-TinyLife-GenealogyType-Grandchild'></a>
### Grandchild `constants`

##### Summary

A genealogy type that represents a grandchild of a [Grandparent](#F-TinyLife-GenealogyType-Grandparent 'TinyLife.GenealogyType.Grandparent')

<a name='F-TinyLife-GenealogyType-Grandparent'></a>
### Grandparent `constants`

##### Summary

A genealogy type that represents a grandparent of a [Grandchild](#F-TinyLife-GenealogyType-Grandchild 'TinyLife.GenealogyType.Grandchild')

<a name='F-TinyLife-GenealogyType-Nibling'></a>
### Nibling `constants`

##### Summary

A genealogy type that represents a nibling (niece or nephew) of a [Pibling](#F-TinyLife-GenealogyType-Pibling 'TinyLife.GenealogyType.Pibling')

<a name='F-TinyLife-GenealogyType-Parent'></a>
### Parent `constants`

##### Summary

A genealogy type that represents a parent of a [Child](#F-TinyLife-GenealogyType-Child 'TinyLife.GenealogyType.Child')

<a name='F-TinyLife-GenealogyType-Pibling'></a>
### Pibling `constants`

##### Summary

A genealogy type that represents a pibling (aunt or uncle) or a [Nibling](#F-TinyLife-GenealogyType-Nibling 'TinyLife.GenealogyType.Nibling')

<a name='F-TinyLife-GenealogyType-Sibling'></a>
### Sibling `constants`

##### Summary

A genealogy type that represents a sibling

<a name='F-TinyLife-GenealogyType-Unrelated'></a>
### Unrelated `constants`

##### Summary

A genealogy type that represents two unrelated people

<a name='T-TinyLife-Actions-GetAndSitDownAction'></a>
## GetAndSitDownAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-GetAndSitDownAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,TinyLife-Objects-FurnitureType,System-Boolean-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-GetAndSitDownAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GetAndSitDownAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### AndThenUpdate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GetAndSitDownAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GetAndSitDownAction-GetChair'></a>
### GetChair() `method`

##### Summary

A helper method that returns the chair that this action is related to.
If there is no chair found, null is returned.

##### Returns

The chair, or null if there is none

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GetAndSitDownAction-GetIconObject'></a>
### GetIconObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GetAndSitDownAction-GetInteractingItem``1'></a>
### GetInteractingItem\`\`1() `method`

##### Summary

A helper method that returns the item instance that is currently being interacted with in this action.
Since this action type is rather complex, this is the favored way over [GetActionObject\`\`1](#M-TinyLife-Actions-ActionInfo-GetActionObject``1 'TinyLife.Actions.ActionInfo.GetActionObject``1').

##### Returns

The object, or null if there is none

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the object is expected to be |

<a name='M-TinyLife-Actions-GetAndSitDownAction-GetNextAction-TinyLife-Actions-Action-CompletionType-'></a>
### GetNextAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-GoHereAction'></a>
## GoHereAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-GoHereAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-GoHereAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GoHereAction-AndThenIsCompleted'></a>
### AndThenIsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GoHereAction-CanCancel-TinyLife-Actions-Action-'></a>
### CanCancel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GoHereAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-GoHereAction-ShouldFail-TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType-'></a>
### ShouldFail() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-Gravestone'></a>
## Gravestone `type`

##### Namespace

TinyLife.Objects

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Objects-Gravestone-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Objects-Gravestone-Reason'></a>
### Reason `constants`

##### Summary

The [DeathReason](#T-TinyLife-Objects-Person-DeathReason 'TinyLife.Objects.Person.DeathReason') for this gravestone's [DeadPerson](#P-TinyLife-Objects-Gravestone-DeadPerson 'TinyLife.Objects.Gravestone.DeadPerson')'s death

<a name='P-TinyLife-Objects-Gravestone-DeadPerson'></a>
### DeadPerson `property`

##### Summary

The [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that is "stored" in this gravestone.
Note that the actual dead person is stored in [GetDeadPerson](#M-TinyLife-World-Map-GetDeadPerson-System-Guid- 'TinyLife.World.Map.GetDeadPerson(System.Guid)').

<a name='M-TinyLife-Objects-Gravestone-GetHoverInfo'></a>
### GetHoverInfo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-Household'></a>
## Household `type`

##### Namespace

TinyLife.World

##### Summary

A household is a set of [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instances that live together on the same [Lot](#P-TinyLife-World-Household-Lot 'TinyLife.World.Household.Lot')

<a name='M-TinyLife-World-Household-#ctor-TinyLife-World-Map,TinyLife-World-Lot-'></a>
### #ctor(map,lot) `constructor`

##### Summary

Creates a new household on the given map and lot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map that this household is on |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot that this household should own (can be null) |

<a name='P-TinyLife-World-Household-IsCurrent'></a>
### IsCurrent `property`

##### Summary

A property that indicates whether or not this household is the same as [CurrentHousehold](#P-TinyLife-GameImpl-CurrentHousehold 'TinyLife.GameImpl.CurrentHousehold')

<a name='P-TinyLife-World-Household-Lot'></a>
### Lot `property`

##### Summary

The [Lot](#P-TinyLife-World-Household-Lot 'TinyLife.World.Household.Lot') that this household lives on.
For exported households, this might be null.

<a name='P-TinyLife-World-Household-Members'></a>
### Members `property`

##### Summary

The [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instances that are members of this household

<a name='P-TinyLife-World-Household-Money'></a>
### Money `property`

##### Summary

The money that this household has, rounded by two digits after the decimal point

<a name='P-TinyLife-World-Household-Name'></a>
### Name `property`

##### Summary

The name of this household.
The name of a household is the [LastName](#F-TinyLife-Objects-Person-LastName 'TinyLife.Objects.Person.LastName') that most people in this household have.

<a name='M-TinyLife-World-Household-Add-TinyLife-Objects-Person-'></a>
### Add(person) `method`

##### Summary

Adds the given person to this household

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to add |

<a name='M-TinyLife-World-Household-Export'></a>
### Export() `method`

##### Summary

Exports this household's data into an [ExportedHousehold](#T-TinyLife-World-ExportedHousehold 'TinyLife.World.ExportedHousehold'), which can be saved to disk independently of the [Map](#T-TinyLife-World-Map 'TinyLife.World.Map') that this household is on.

##### Returns

An exported household

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Household-GetAverageFriendshipTo-TinyLife-Objects-Person-'></a>
### GetAverageFriendshipTo(person) `method`

##### Summary

Returns the average friendship level that the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') has with members of this lot.
This method returns an averaged value of the [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel') that this person has towards each member of this lot.

##### Returns

The average friendship level, out of [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query |

<a name='M-TinyLife-World-Household-HasMember-TinyLife-Objects-Person-'></a>
### HasMember(person) `method`

##### Summary

Returns whether the given person is a part of this household

##### Returns

true if the person is part of this household, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query |

<a name='M-TinyLife-World-Household-Import-TinyLife-World-ExportedHousehold-'></a>
### Import(household) `method`

##### Summary

Imports the given [ExportedHousehold](#T-TinyLife-World-ExportedHousehold 'TinyLife.World.ExportedHousehold') into this household.
Note that existing [Members](#P-TinyLife-World-Household-Members 'TinyLife.World.Household.Members') are not removed or replaced beforehand.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| household | [TinyLife.World.ExportedHousehold](#T-TinyLife-World-ExportedHousehold 'TinyLife.World.ExportedHousehold') | The household to import |

<a name='M-TinyLife-World-Household-IsLotVisible-TinyLife-World-Lot-'></a>
### IsLotVisible(lot) `method`

##### Summary

Returns whether the given lot is considered visible to this household
Note that passing this household's [Lot](#P-TinyLife-World-Household-Lot 'TinyLife.World.Household.Lot') will always cause this method to return true.

##### Returns

Whether the lot is visible

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot to query |

<a name='M-TinyLife-World-Household-MarkLotNonVisible-TinyLife-World-Lot-'></a>
### MarkLotNonVisible(lot) `method`

##### Summary

Marks a lot non-visible if it's currently visible.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot to remove visibility for |

<a name='M-TinyLife-World-Household-MarkLotVisible-TinyLife-World-Lot-'></a>
### MarkLotVisible(lot) `method`

##### Summary

Marks the given lot as visible for members of this household.
[VisitLot](#M-TinyLife-Objects-Person-VisitLot-TinyLife-World-Lot- 'TinyLife.Objects.Person.VisitLot(TinyLife.World.Lot)') should be used in favor of this method in most cases.
By default, visibility lasts for 30 seconds of real time.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot to mark as visible |

<a name='M-TinyLife-World-Household-Remove-TinyLife-Objects-Person-'></a>
### Remove(person) `method`

##### Summary

Removes the given person from this household, if they're part of it

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to remove |

<a name='M-TinyLife-World-Household-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

Updates this household, ticking down the lot visibility times

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time passed in game |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's speed |

<a name='M-TinyLife-World-Household-Validate-TinyLife-World-Map-'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.

##### Returns

false if the object is not valid, true otherwise

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-IPricedObject'></a>
## IPricedObject `type`

##### Namespace

TinyLife.World

##### Summary

A priced object is an object that has a floating point price value attached to it.
In the world of Tiny Life, prices are written as "tiny bucks", but they don't necessarily resemble the prices of the American dollar.

<a name='M-TinyLife-World-IPricedObject-GetPrice'></a>
### GetPrice() `method`

##### Summary

Returns the price that this object can be bought or sold for.
Note that, like in the case of the [Painting](#T-TinyLife-Objects-Painting 'TinyLife.Objects.Painting'), the returned price isn't necessarily the full price that the object can be sold for. Instead, the price returned here should be the price that this object has when bought or sold from the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool') or similar.

##### Returns

The object's price

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-IUpdatingObject'></a>
## IUpdatingObject `type`

##### Namespace

TinyLife.Objects

##### Summary

This is an interface that can be added to [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') classes to make them automatically update each update frame.
This is used by things like [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person'), which needs to update for movement etc.

<a name='M-TinyLife-Objects-IUpdatingObject-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

The update method, which is called every update frame by the underlying [Map](#T-TinyLife-World-Map 'TinyLife.World.Map')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed since the last call |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's speed |

<a name='T-TinyLife-Emotions-EmotionModifier-Instance'></a>
## Instance `type`

##### Namespace

TinyLife.Emotions.EmotionModifier

##### Summary

This class represents an applied instance of a [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier').
It is used by [AddEmotion](#M-TinyLife-Objects-Person-AddEmotion-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan- 'TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)').

<a name='M-TinyLife-Emotions-EmotionModifier-Instance-#ctor-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan-'></a>
### #ctor(type,amount,time) `constructor`

##### Summary

Creates a new [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') instance with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Emotions.EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') | The emotion modifier of this instance |
| amount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount that this instance should yield |
| time | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The time that this instance should last for |

<a name='F-TinyLife-Emotions-EmotionModifier-Instance-Amount'></a>
### Amount `constants`

##### Summary

The amount that this emotion modifier's [Type](#F-TinyLife-Emotions-EmotionModifier-Instance-Type 'TinyLife.Emotions.EmotionModifier.Instance.Type') has

<a name='F-TinyLife-Emotions-EmotionModifier-Instance-TotalTime'></a>
### TotalTime `constants`

##### Summary

The total amount of in-game time that this emotion modifier lasts for

<a name='F-TinyLife-Emotions-EmotionModifier-Instance-Type'></a>
### Type `constants`

##### Summary

The emotion modifier that this instance contains

<a name='P-TinyLife-Emotions-EmotionModifier-Instance-Time'></a>
### Time `property`

##### Summary

The amount of in-game time remaining of this modifier, out of [TotalTime](#F-TinyLife-Emotions-EmotionModifier-Instance-TotalTime 'TinyLife.Emotions.EmotionModifier.Instance.TotalTime')

<a name='M-TinyLife-Emotions-EmotionModifier-Instance-PassTime-System-TimeSpan-'></a>
### PassTime(passedInGame) `method`

##### Summary

Causes [Time](#P-TinyLife-Emotions-EmotionModifier-Instance-Time 'TinyLife.Emotions.EmotionModifier.Instance.Time') to pass by the given [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan').
If [Time](#P-TinyLife-Emotions-EmotionModifier-Instance-Time 'TinyLife.Emotions.EmotionModifier.Instance.Time') is equal to [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan.MaxValue 'System.TimeSpan.MaxValue'), nothing happens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that should pass |

<a name='T-TinyLife-Goals-Job'></a>
## Job `type`

##### Namespace

TinyLife.Goals

##### Summary

A job is a kind of work that a [Person](#P-TinyLife-Goals-Job-Person 'TinyLife.Goals.Job.Person') can have.
The person's current job is accessible using [Job](#P-TinyLife-Objects-Person-Job 'TinyLife.Objects.Person.Job').
A job instance is constructed from its underlying [JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType').

<a name='M-TinyLife-Goals-Job-#ctor-TinyLife-Goals-JobType,TinyLife-Objects-Person-'></a>
### #ctor(type,person) `constructor`

##### Summary

Creates a new job from the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Goals.JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType') | The underlying job type |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that should have this job |

<a name='F-TinyLife-Goals-Job-Type'></a>
### Type `constants`

##### Summary

The underlying [JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType') that this job results from

<a name='P-TinyLife-Goals-Job-CurrentHourlyPay'></a>
### CurrentHourlyPay `property`

##### Summary

The amount of tiny bucks that this job pays per hour. This is based on [HourlyPay](#F-TinyLife-Goals-JobType-HourlyPay 'TinyLife.Goals.JobType.HourlyPay') and the current [Level](#P-TinyLife-Goals-Job-Level 'TinyLife.Goals.Job.Level').

<a name='P-TinyLife-Goals-Job-Level'></a>
### Level `property`

##### Summary

The current level that this job is at.
Note that the default level is 0, and the level goes up to a maximum of 9.

<a name='P-TinyLife-Goals-Job-Performance'></a>
### Performance `property`

##### Summary

This job's current performance, ranging from 0 to 1, representing the percentage of work performance.
The default value is 0.5.

<a name='P-TinyLife-Goals-Job-Person'></a>
### Person `property`

##### Summary

The [Person](#P-TinyLife-Goals-Job-Person 'TinyLife.Goals.Job.Person') that currently has this job

<a name='M-TinyLife-Goals-Job-AddLevel-System-Int32-'></a>
### AddLevel(level) `method`

##### Summary

Adds (or removes) the given amount of levels to this job's [Level](#P-TinyLife-Goals-Job-Level 'TinyLife.Goals.Job.Level').
Note that the level value is automatically clamped between 0 and 9, inclusively.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| level | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The level to add to this job's current level |

<a name='M-TinyLife-Goals-Job-AddPerformance-System-Single-'></a>
### AddPerformance(performance) `method`

##### Summary

Adds (or removes) the given amount of performance to this job's [Performance](#P-TinyLife-Goals-Job-Performance 'TinyLife.Goals.Job.Performance').
If the total [Performance](#P-TinyLife-Goals-Job-Performance 'TinyLife.Goals.Job.Performance') rolls over (below 0 or above 1), [AddLevel](#M-TinyLife-Goals-Job-AddLevel-System-Int32- 'TinyLife.Goals.Job.AddLevel(System.Int32)') is called and the performace is reset accordingly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| performance | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount to add or remove to the current performance |

<a name='M-TinyLife-Goals-Job-Update-System-TimeSpan-'></a>
### Update(passedInGame) `method`

##### Summary

Updates this job, changing the [Performance](#P-TinyLife-Goals-Job-Performance 'TinyLife.Goals.Job.Performance') and [Level](#P-TinyLife-Goals-Job-Level 'TinyLife.Goals.Job.Level') according to this job's person's current actions.
This is called in [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed in game since the last update |

<a name='M-TinyLife-Goals-Job-Validate-TinyLife-Objects-Person-'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.

##### Returns

false if the object is not valid, true otherwise

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Goals-JobType'></a>
## JobType `type`

##### Namespace

TinyLife.Goals

##### Summary

A job type is a singleton containing various kinds of data for a [Job](#T-TinyLife-Goals-Job 'TinyLife.Goals.Job') instance.
New jobs can be registered using [Register](#M-TinyLife-Goals-JobType-Register-TinyLife-Goals-JobType- 'TinyLife.Goals.JobType.Register(TinyLife.Goals.JobType)').

<a name='M-TinyLife-Goals-JobType-#ctor-System-String,System-Single,MonoGame-Extended-Range{System-Int32},System-DayOfWeek[]-'></a>
### #ctor(name,hourlyPay,workHours,offWorkDays) `constructor`

##### Summary

Creates a new job type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the job |
| hourlyPay | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The hourly wage that this job yields |
| workHours | [MonoGame.Extended.Range{System.Int32}](#T-MonoGame-Extended-Range{System-Int32} 'MonoGame.Extended.Range{System.Int32}') | A range of hours to work each day |
| offWorkDays | [System.DayOfWeek[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DayOfWeek[] 'System.DayOfWeek[]') | The days of the week that are off work |

<a name='F-TinyLife-Goals-JobType-HourlyPay'></a>
### HourlyPay `constants`

##### Summary

The amount of dollars that being at the job for an hour pays.
In [WorkAction](#T-TinyLife-Actions-WorkAction 'TinyLife.Actions.WorkAction'), this is automatically added to the household funds.

<a name='F-TinyLife-Goals-JobType-Name'></a>
### Name `constants`

##### Summary

The name of this job type

<a name='F-TinyLife-Goals-JobType-OffWorkDays'></a>
### OffWorkDays `constants`

##### Summary

A set of [DayOfWeek](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DayOfWeek 'System.DayOfWeek') values which are days off of this job.
On [Weekday](#P-TinyLife-GameImpl-Weekday 'TinyLife.GameImpl.Weekday')s contained in this list, the [WorkHours](#F-TinyLife-Goals-JobType-WorkHours 'TinyLife.Goals.JobType.WorkHours') don't apply.

<a name='F-TinyLife-Goals-JobType-Types'></a>
### Types `constants`

##### Summary

A registry of all [JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType') instances in the game and mods.
Register new jobs using [Register](#M-TinyLife-Goals-JobType-Register-TinyLife-Goals-JobType- 'TinyLife.Goals.JobType.Register(TinyLife.Goals.JobType)').

<a name='F-TinyLife-Goals-JobType-WorkHours'></a>
### WorkHours `constants`

##### Summary

A [Range](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Range 'System.Range') of hours that this job requires each day.
Note that the [Min](#P-MonoGame-Extended-Range`1-Min 'MonoGame.Extended.Range`1.Min') value is inclusive, but the [Max](#P-MonoGame-Extended-Range`1-Max 'MonoGame.Extended.Range`1.Max') value is exclusive.

<a name='M-TinyLife-Goals-JobType-Construct-TinyLife-Objects-Person-'></a>
### Construct(person) `method`

##### Summary

Creates a new [Job](#T-TinyLife-Goals-Job 'TinyLife.Goals.Job') from this type's information

##### Returns

A new job instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that should have the job |

<a name='M-TinyLife-Goals-JobType-GetDisplayName-System-Nullable{System-Int32}-'></a>
### GetDisplayName(level) `method`

##### Summary

Returns the display name of this [JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType'), based on the given `level`.
If no level is given, the job's regular name, without the level-based suffix, is returned.

##### Returns

A localized string representing this job's name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| level | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The level |

<a name='M-TinyLife-Goals-JobType-IsTimeToWork-System-Nullable{System-TimeSpan}-'></a>
### IsTimeToWork(time) `method`

##### Summary

Returns whether the given time (or the game's current time) is in the bounds of [WorkHours](#F-TinyLife-Goals-JobType-WorkHours 'TinyLife.Goals.JobType.WorkHours') and outside of the bounds of [OffWorkDays](#F-TinyLife-Goals-JobType-OffWorkDays 'TinyLife.Goals.JobType.OffWorkDays').
If this method returns true, [WorkAction](#T-TinyLife-Actions-WorkAction 'TinyLife.Actions.WorkAction') can be started.

##### Returns

true if it is time to work, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [System.Nullable{System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.TimeSpan}') | The current time. Defaults to [CurrentTime](#F-TinyLife-GameImpl-CurrentTime 'TinyLife.GameImpl.CurrentTime'). |

<a name='M-TinyLife-Goals-JobType-Register-TinyLife-Goals-JobType-'></a>
### Register(type) `method`

##### Summary

Registers the given job type to the [Types](#F-TinyLife-Goals-JobType-Types 'TinyLife.Goals.JobType.Types') registry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Goals.JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType') | The type to register |

<a name='M-TinyLife-Goals-JobType-ToScheduleString'></a>
### ToScheduleString() `method`

##### Summary

Returns a string representation of the schedule.
The string includes a line that states the [WorkHours](#F-TinyLife-Goals-JobType-WorkHours 'TinyLife.Goals.JobType.WorkHours') and a line that states the [OffWorkDays](#F-TinyLife-Goals-JobType-OffWorkDays 'TinyLife.Goals.JobType.OffWorkDays').

##### Returns

A string representation of this job's schedule

##### Parameters

This method has no parameters.

<a name='T-TinyLife-LnCategory'></a>
## LnCategory `type`

##### Namespace

TinyLife

##### Summary

An enumeration that contains a set of localization categories.
These categories are represented in a localization file as JSON objects with the given names.

<a name='F-TinyLife-LnCategory-Actions'></a>
### Actions `constants`

##### Summary

A localization category for [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action')-related localizations

<a name='F-TinyLife-LnCategory-BuildMode'></a>
### BuildMode `constants`

##### Summary

A localization category for build mode items and furniture

<a name='F-TinyLife-LnCategory-Clothes'></a>
### Clothes `constants`

##### Summary

A localization category for clothes and other character creator items

<a name='F-TinyLife-LnCategory-Emotions'></a>
### Emotions `constants`

##### Summary

A localization category for text related to [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') and [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier')

<a name='F-TinyLife-LnCategory-Food'></a>
### Food `constants`

##### Summary

A localization category for food items

<a name='F-TinyLife-LnCategory-Jobs'></a>
### Jobs `constants`

##### Summary

A localization category for text related to [Job](#T-TinyLife-Goals-Job 'TinyLife.Goals.Job')

<a name='F-TinyLife-LnCategory-Personalities'></a>
### Personalities `constants`

##### Summary

A localization category for text related to [PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType')

<a name='F-TinyLife-LnCategory-Skills'></a>
### Skills `constants`

##### Summary

A localization category for text related to [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill')

<a name='F-TinyLife-LnCategory-Ui'></a>
### Ui `constants`

##### Summary

A localization category for UI elements

<a name='T-TinyLife-Localization'></a>
## Localization `type`

##### Namespace

TinyLife

##### Summary

A class that houses the currently loaded language as well as allows for switching the currently selected language

<a name='F-TinyLife-Localization-LanguageNames'></a>
### LanguageNames `constants`

##### Summary

A list of the full names of all of the languages that the game supports

<a name='M-TinyLife-Localization-Get-TinyLife-LnCategory,System-String-'></a>
### Get(category,key) `method`

##### Summary

Gets a localized string in the given category with the given key.
If the localization is not found, the key, surrounded by question marks, is returned instead.

##### Returns

The localization of the key

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [TinyLife.LnCategory](#T-TinyLife-LnCategory 'TinyLife.LnCategory') | The category that contains the localization |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key to localize |

<a name='M-TinyLife-Localization-SetLanguage-System-String-'></a>
### SetLanguage(language) `method`

##### Summary

Switches the current language to the language given.
Note that, for most ui elements to update, they have to be re-created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| language | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The code of the language to set |

<a name='T-TinyLife-World-Lot'></a>
## Lot `type`

##### Namespace

TinyLife.World

##### Summary

A lot is a designated area in the world (created using the [LotTool](#T-TinyLife-Tools-LotTool 'TinyLife.Tools.LotTool')).
In the way it works, it acts similarly to a small [Map](#T-TinyLife-World-Map 'TinyLife.World.Map'), allowing the retrieval of various object types only in its designated area.
A lot has a [LotType](#T-TinyLife-World-LotType 'TinyLife.World.LotType'), which determines what things can be done on the lot.

<a name='M-TinyLife-World-Lot-#ctor-TinyLife-World-Map,Microsoft-Xna-Framework-Rectangle-'></a>
### #ctor(map,area) `constructor`

##### Summary

Creates a new lot on the given map with the given area

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map |
| area | [Microsoft.Xna.Framework.Rectangle](#T-Microsoft-Xna-Framework-Rectangle 'Microsoft.Xna.Framework.Rectangle') | The area |

<a name='F-TinyLife-World-Lot-Area'></a>
### Area `constants`

##### Summary

The area in the world that this lot occupies

<a name='F-TinyLife-World-Lot-Id'></a>
### Id `constants`

##### Summary

The unique id of this lot.
This is randomly generated when the lot is first added to the world, and then persists across savings to disk.

<a name='F-TinyLife-World-Lot-Type'></a>
### Type `constants`

##### Summary

The [LotType](#T-TinyLife-World-LotType 'TinyLife.World.LotType') that this lot has.
This value defaults to the "Residential" lot type.

<a name='P-TinyLife-World-Lot-Household'></a>
### Household `property`

##### Summary

The household that is currently occupying this [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot').
This can only be non-null if the [Type](#F-TinyLife-World-Lot-Type 'TinyLife.World.Lot.Type') has [IsResidential](#F-TinyLife-World-LotType-IsResidential 'TinyLife.World.LotType.IsResidential') set to true.

<a name='M-TinyLife-World-Lot-AreRequirementsMet'></a>
### AreRequirementsMet() `method`

##### Summary

Returns whether this lot [Type](#F-TinyLife-World-Lot-Type 'TinyLife.World.Lot.Type')'s [RequiredFurniture](#F-TinyLife-World-LotType-RequiredFurniture 'TinyLife.World.LotType.RequiredFurniture') requirements are currently met

##### Returns

true if the requirements are met, false otherwise

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-CanImport-TinyLife-World-ExportedLot-'></a>
### CanImport(import) `method`

##### Summary

A method that calculates whether the given [ExportedLot](#T-TinyLife-World-ExportedLot 'TinyLife.World.ExportedLot') can be imported.
A lot can be imported if the [Household](#P-TinyLife-World-Lot-Household 'TinyLife.World.Lot.Household') has enough money, and if this lot's [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area') is greater than or equal to the exported lot's area.

##### Returns

true if the lot can be imported, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| import | [TinyLife.World.ExportedLot](#T-TinyLife-World-ExportedLot 'TinyLife.World.ExportedLot') | The lot to import |

<a name='M-TinyLife-World-Lot-CanMove-MLEM-Misc-Direction2-'></a>
### CanMove(direction) `method`

##### Summary

Returns whether or not the entire lot can be moved in the given direction.
The decision is based on this lot's [GetCoveredArea](#M-TinyLife-World-Lot-GetCoveredArea 'TinyLife.World.Lot.GetCoveredArea') and its [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area').

##### Returns

true if the lot can be moved, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| direction | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to move the lot in |

<a name='M-TinyLife-World-Lot-Export'></a>
### Export() `method`

##### Summary

Exports this lot's data, including all of its [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture'), [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') and [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') obejects and its [Tile](#T-TinyLife-World-Tile 'TinyLife.World.Tile') ground.
Note that this does not change the lot itself, as it doesn't remove or add anything to it.

##### Returns

An exported version of this lot

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-GetCoveredArea'></a>
### GetCoveredArea() `method`

##### Summary

Returns a [RectangleF](#T-MLEM-Misc-RectangleF 'MLEM.Misc.RectangleF') that represents the area that this lot actually covers.
The area covered by this lot is always bounded by its [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area'), but will be smaller if there are fewer objects on the lot.

##### Returns

The area that this lot covers

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-GetFrontDoor'></a>
### GetFrontDoor() `method`

##### Summary

Returns the [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') that this lot's front door is located in.
The front door is the door that is closest to this lot's [Mailbox](#F-TinyLife-Objects-FurnitureType-Mailbox 'TinyLife.Objects.FurnitureType.Mailbox') that also connects a non-room (the outside) to a room (the inside).

##### Returns

The wall that the front door is contained in, or null if there is none

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-GetHomeLocation-TinyLife-Objects-Person-'></a>
### GetHomeLocation(person) `method`

##### Summary

Returns the home location of the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') on this lot.
The home position is the position of the front door on a residential lot ([IsResidential](#F-TinyLife-World-LotType-IsResidential 'TinyLife.World.LotType.IsResidential')) or the closest border position to the passed [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') otherwise.

##### Returns

The person's home location on this lot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person whose home location to retrieve |

<a name='M-TinyLife-World-Lot-GetObjects``1'></a>
### GetObjects\`\`1() `method`

##### Summary

Returns the set of all of the [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') instances on this lot's map that are contained in this lot's [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area').

##### Returns

This lot's objects

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of objects to receive |

<a name='M-TinyLife-World-Lot-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-GetRoofs'></a>
### GetRoofs() `method`

##### Summary

Returns a set of all of the [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') instances on this lot's map that are contained in this lot's [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area')

##### Returns



##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-GetWalls'></a>
### GetWalls() `method`

##### Summary

Returns a set of all of the [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') instances on this lot's map that are contained in this lot's [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area')

##### Returns

This lot's walls

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Lot-Import-TinyLife-World-ExportedLot-'></a>
### Import(lot) `method`

##### Summary

Imports the given [ExportedLot](#T-TinyLife-World-ExportedLot 'TinyLife.World.ExportedLot') onto this lot.
Note that everything that was previously on this lot will be removed (and the money will be returned to this lot's [Household](#P-TinyLife-World-Lot-Household 'TinyLife.World.Lot.Household')).
Also note that the [Household](#P-TinyLife-World-Lot-Household 'TinyLife.World.Lot.Household') stays the same, and all tiles outside of the exported lot's area (if it is smaller) are replaced with Grass.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.ExportedLot](#T-TinyLife-World-ExportedLot 'TinyLife.World.ExportedLot') |  |

<a name='M-TinyLife-World-Lot-Move-MLEM-Misc-Direction2-'></a>
### Move(direction) `method`

##### Summary

Move the entire lot in the given direction (by one tile).
Note that [CanMove](#M-TinyLife-World-Lot-CanMove-MLEM-Misc-Direction2- 'TinyLife.World.Lot.CanMove(MLEM.Misc.Direction2)') is not called internally.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| direction | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The direction to move the lot in |

<a name='M-TinyLife-World-Lot-Validate-TinyLife-World-Map-'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.

##### Returns

false if the object is not valid, true otherwise

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Tools-LotTool'></a>
## LotTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-LotTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-LotTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-LotTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-LotTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-LotType'></a>
## LotType `type`

##### Namespace

TinyLife.World

##### Summary

A lot type is data for a [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') that determines the required furniture on the lot as well as whether the lot is residential or not.
Additionally, custom lot types can define different reasons and interactions for [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') objects to visit lots of the type.

<a name='M-TinyLife-World-LotType-#ctor-System-String,System-Boolean,System-ValueTuple{TinyLife-Objects-FurnitureType,System-Int32}[]-'></a>
### #ctor(name,isResidential,requiredFurniture) `constructor`

##### Summary

Creates a new lot type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this lot type |
| isResidential | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether lots of this type should be considered residential |
| requiredFurniture | [System.ValueTuple{TinyLife.Objects.FurnitureType,System.Int32}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{TinyLife.Objects.FurnitureType,System.Int32}[]') | A set of furniture (and amounts) that have to be present on lots of this type |

<a name='F-TinyLife-World-LotType-IsResidential'></a>
### IsResidential `constants`

##### Summary

Whether this lot is residential.
A residential lot is one that [Household](#T-TinyLife-World-Household 'TinyLife.World.Household')s can move into.

<a name='F-TinyLife-World-LotType-Name'></a>
### Name `constants`

##### Summary

The name of this lot type

<a name='F-TinyLife-World-LotType-RequiredFurniture'></a>
### RequiredFurniture `constants`

##### Summary

A set of furniture that is required on the lot.
Each entry determines the [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') required, as well as the amount of that item that is required on the lot.

<a name='F-TinyLife-World-LotType-Types'></a>
### Types `constants`

##### Summary

A registry for all [LotType](#T-TinyLife-World-LotType 'TinyLife.World.LotType') objects that the game and mods define

<a name='M-TinyLife-World-LotType-Register-TinyLife-World-LotType-'></a>
### Register(type) `method`

##### Summary

Registers a new lot type to the [Types](#F-TinyLife-World-LotType-Types 'TinyLife.World.LotType.Types') registry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.World.LotType](#T-TinyLife-World-LotType 'TinyLife.World.LotType') | The lot type to register |

<a name='T-TinyLife-World-Map'></a>
## Map `type`

##### Namespace

TinyLife.World

##### Summary

A map holds all of the data about a city, like its tiles, its objects and its roads.
A map is split into [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection') objects which allows faster retrieval of objects in an area.

<a name='M-TinyLife-World-Map-#ctor-System-String,Microsoft-Xna-Framework-Point-'></a>
### #ctor(name,sizeInSections) `constructor`

##### Summary

Creates a new map with the given name and size

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this map |
| sizeInSections | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The size, in sections, of this map |

<a name='F-TinyLife-World-Map-Name'></a>
### Name `constants`

##### Summary

The name of this map

<a name='F-TinyLife-World-Map-RoadRadius'></a>
### RoadRadius `constants`

##### Summary

This field holds the radius that roads are required to have (in road tiles) excluding the center dotted line tiles.
It is set to 2.

<a name='P-TinyLife-World-Map-Size'></a>
### Size `property`

##### Summary

The size in tiles that this map has.
This is always [SizeInSections](#P-TinyLife-World-Map-SizeInSections 'TinyLife.World.Map.SizeInSections') multiplied by [Size](#F-TinyLife-World-MapSection-Size 'TinyLife.World.MapSection.Size').

<a name='P-TinyLife-World-Map-SizeInSections'></a>
### SizeInSections `property`

##### Summary

The size, in sections (not tiles) that this map has

<a name='P-TinyLife-World-Map-StaticVersion'></a>
### StaticVersion `property`

##### Summary

The static version of this map.
When a new save file is created, a static version of each map is loaded and used as the save file's basis.
If the static version of the save file is newer, their save file is updated to the new static map version, which causes all non-lot objects to be copied to the saved map.

<a name='M-TinyLife-World-Map-AddHousehold-TinyLife-World-Lot,TinyLife-Objects-Person[]-'></a>
### AddHousehold(lot,people) `method`

##### Summary

Adds a new household to this map by calling the [Household](#T-TinyLife-World-Household 'TinyLife.World.Household') constructor.

##### Returns

The newly created household

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot that the household should live on |
| people | [TinyLife.Objects.Person[]](#T-TinyLife-Objects-Person[] 'TinyLife.Objects.Person[]') | The people to add to the household |

<a name='M-TinyLife-World-Map-AddLot-Microsoft-Xna-Framework-Rectangle-'></a>
### AddLot(area) `method`

##### Summary

Adds a new lot with the given area to this map's lots

##### Returns

The newly created lot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| area | [Microsoft.Xna.Framework.Rectangle](#T-Microsoft-Xna-Framework-Rectangle 'Microsoft.Xna.Framework.Rectangle') | The area that the new lot should have |

<a name='M-TinyLife-World-Map-AddObject-TinyLife-Objects-MapObject-'></a>
### AddObject(obj) `method`

##### Summary

Adds the given object to this map.
Note that, if the object's [Id](#F-TinyLife-Objects-MapObject-Id 'TinyLife.Objects.MapObject.Id') is already present on this map, this method will cause an exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [TinyLife.Objects.MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') | The object to add to this map |

<a name='M-TinyLife-World-Map-AddRoad-Microsoft-Xna-Framework-Point-'></a>
### AddRoad(pos) `method`

##### Summary

Adds a road to the map at the given position.
This doesn't actually add the road tiles, but it notifies the pathfinder that there is a road center at this location.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to add a road to |

<a name='M-TinyLife-World-Map-AddRoof-TinyLife-World-Roof-'></a>
### AddRoof(roof) `method`

##### Summary

Adds the given roof to this map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roof | [TinyLife.World.Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') | The roof to add |

<a name='M-TinyLife-World-Map-AddWall-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point-'></a>
### AddWall(pos,secondPos) `method`

##### Summary

Adds the given wall to the given position.

##### Returns

Whether the wall could be added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position that the new wall should have |
| secondPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The second position that the new wall should have |

<a name='M-TinyLife-World-Map-AddWall-TinyLife-World-Wall,System-Boolean-'></a>
### AddWall(wall,initializeRooms) `method`

##### Summary

Adds the given wall to the given position.
Optionally, the [Room](#T-TinyLife-World-Room 'TinyLife.World.Room') related to that wall is re-calculated.

##### Returns

Whether the wall could be added successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| wall | [TinyLife.World.Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') | The wall to add |
| initializeRooms | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether rooms should be re-calculated. Defaults to true. |

<a name='M-TinyLife-World-Map-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,System-Boolean-'></a>
### Draw(time,batch,selectionMode) `method`

##### Summary

Draws this map and all of its objects.
Note that drawing in this manner uses multiple [RenderTarget2D](#T-Microsoft-Xna-Framework-Graphics-RenderTarget2D 'Microsoft.Xna.Framework.Graphics.RenderTarget2D') objects, for things like the ground and the lightmaps.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| selectionMode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether we're drawing in selection mode ("ShowSelectionEffect" cheat displays this mode) |

<a name='M-TinyLife-World-Map-GetClosestEmptyTile-Microsoft-Xna-Framework-Vector2,System-Int32,System-Boolean,System-Boolean-'></a>
### GetClosestEmptyTile(pos,radius,ignorePeople,hasToBeOnLot) `method`

##### Summary

Returns the position of the closest tile that is empty.
An empty tile is a tile that has no [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') instances on it.

##### Returns

The closest empty tile, or null if there isn't one

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to be close to |
| radius | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The radius to search for empty tiles in |
| ignorePeople | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not people should be ignored. If this is true, the returned empty tile might currently be occupied by a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person'). |
| hasToBeOnLot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the returned tile position has to be part of a [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') |

<a name='M-TinyLife-World-Map-GetClosestRoad-Microsoft-Xna-Framework-Point,System-Int32-'></a>
### GetClosestRoad(pos,radius) `method`

##### Summary

Returns the clost road marker to the given position, keeping the given radius in mind.

##### Returns

The closest road point

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to find the closest road to |
| radius | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The radius, in tiles, to search for roads in |

<a name='M-TinyLife-World-Map-GetClosestSidewalk-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Vector2-'></a>
### GetClosestSidewalk(road,pos) `method`

##### Summary

Returns the closest sidewalk position to the given road position.
A sidewalk is a tile whose name starts with "Concrete" that is [RoadRadius](#F-TinyLife-World-Map-RoadRadius 'TinyLife.World.Map.RoadRadius')+1 tiles away from the road marker.
Note that the road position must have [IsRoad](#M-TinyLife-World-Map-IsRoad-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.IsRoad(Microsoft.Xna.Framework.Point)') return true for it.

##### Returns

The closest sidewalk position

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| road | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The road marker |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to which the distance should be shortest |

<a name='M-TinyLife-World-Map-GetDeadPerson-System-Guid-'></a>
### GetDeadPerson(id) `method`

##### Summary

Returns a dead [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') with the given [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') id

##### Returns

The dead person instance, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The id to get a dead person by |

<a name='M-TinyLife-World-Map-GetDepth-Microsoft-Xna-Framework-Vector2,System-Single,System-Boolean-'></a>
### GetDepth(tilePos,offset,center) `method`

##### Summary

Gets the depth that should be used for drawing an object at the given tile position

##### Returns

The depth to pass to the draw call

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tilePos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to get depth for, in tile coordinates |
| offset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | An offset added to the depth value |
| center | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether the position should be centered on the x axis |

<a name='M-TinyLife-World-Map-GetHousehold-TinyLife-Objects-Person-'></a>
### GetHousehold(person) `method`

##### Summary

Returns the household that the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') lives in

##### Returns

The person's household, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query |

<a name='M-TinyLife-World-Map-GetHousehold-TinyLife-World-Lot-'></a>
### GetHousehold(lot) `method`

##### Summary

Returns the household that lives on the given [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot')

##### Returns

The household that lives on the lot, or null if none lives there

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot to query |

<a name='M-TinyLife-World-Map-GetHouseholds'></a>
### GetHouseholds() `method`

##### Summary

Returns a set of all of the [Household](#T-TinyLife-World-Household 'TinyLife.World.Household') instances that live on this map

##### Returns

This map's households

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Map-GetLot-System-Guid-'></a>
### GetLot(id) `method`

##### Summary

Returns the lot with the given id on this map.
The returned lot's [Id](#F-TinyLife-World-Lot-Id 'TinyLife.World.Lot.Id') will equal the given id.

##### Returns

The lot with the given id

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The id that the lot should have |

<a name='M-TinyLife-World-Map-GetLot-Microsoft-Xna-Framework-Point-'></a>
### GetLot(pos) `method`

##### Summary

Returns the lot that is present at the given position.
The lot returned will always have its [Area](#F-TinyLife-World-Lot-Area 'TinyLife.World.Lot.Area') contain the passed position.

##### Returns

The lot at that position, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to query |

<a name='M-TinyLife-World-Map-GetLots'></a>
### GetLots() `method`

##### Summary

Returns a set of all of the [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') objects on this map

##### Returns

This map's lots

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Map-GetObject``1-System-Guid-'></a>
### GetObject\`\`1(id) `method`

##### Summary

Returns the object with the given id of the given type.
If there is no object with that id, or its type does not match, null is returned.

##### Returns

The object, or null if there is no matching one

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The id that the returned object should have |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the object is expected to have |

<a name='M-TinyLife-World-Map-GetObjects``1-MLEM-Misc-RectangleF-'></a>
### GetObjects\`\`1(area) `method`

##### Summary

Returns a set of objects that are present in the given area.

##### Returns

A set of objects that match the criteria

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| area | [MLEM.Misc.RectangleF](#T-MLEM-Misc-RectangleF 'MLEM.Misc.RectangleF') | The area, in tile coordinates |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the objects need to have |

<a name='M-TinyLife-World-Map-GetPathCost-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point-'></a>
### GetPathCost(currPos,nextPos) `method`

##### Summary

Returns the cost to pathfind from the given current position to the given next position.
Note that, for this method to return a proper result, `nextPos` has to be directly or diagonally adjacent to `currPos`.

##### Returns

The cost to path to this location

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| currPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The current position |
| nextPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The next, neighboring position |

<a name='M-TinyLife-World-Map-GetPeople'></a>
### GetPeople() `method`

##### Summary

Returns all of the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') objects that are on this map

##### Returns

This map's people

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Map-GetRoads'></a>
### GetRoads() `method`

##### Summary

Returns a set of all of the road markers on this map

##### Returns

A set of all road markers on this map

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Map-GetRoof-Microsoft-Xna-Framework-Point-'></a>
### GetRoof(pos) `method`

##### Summary

Gets a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') whose area contains the given position

##### Returns

The roof at that position, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to find a roof at |

<a name='M-TinyLife-World-Map-GetRoom-Microsoft-Xna-Framework-Point-'></a>
### GetRoom(pos) `method`

##### Summary

Returns the room that the given position is contained in

##### Returns

The room at that location, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to query |

<a name='M-TinyLife-World-Map-GetSection-Microsoft-Xna-Framework-Point-'></a>
### GetSection(pos) `method`

##### Summary

Returns the [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection') at the given tile position

##### Returns

The section at that position

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The tile position |

<a name='M-TinyLife-World-Map-GetSections-Microsoft-Xna-Framework-Point,System-Int32-'></a>
### GetSections(point,radiusIncrease) `method`

##### Summary

Returns a set of sections that are contained in (or intersect with) the given area

##### Returns

A set of sections covered by this area

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| point | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to find the section for, in tile coordinates |
| radiusIncrease | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The radius, in sections, that the search area should be extended by |

<a name='M-TinyLife-World-Map-GetSections-MLEM-Misc-RectangleF,System-Int32-'></a>
### GetSections(area,radiusIncrease) `method`

##### Summary

Returns a set of sections that are contained in (or intersect with) the given area

##### Returns

A set of sections covered by this area

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| area | [MLEM.Misc.RectangleF](#T-MLEM-Misc-RectangleF 'MLEM.Misc.RectangleF') | The area to find sections in, in tile coordinates |
| radiusIncrease | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The radius, in sections, that the search area should be extended by |

<a name='M-TinyLife-World-Map-GetTile-Microsoft-Xna-Framework-Point-'></a>
### GetTile(pos) `method`

##### Summary

Returns the tile at the given position on this map

##### Returns

The tile at that position

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to query |

<a name='M-TinyLife-World-Map-GetWallBetween-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point-'></a>
### GetWallBetween(pos,secondPos) `method`

##### Summary

Returns the wall between the `pos` and `secondPos`.
A wall is between two positions if its [Positions](#F-TinyLife-World-Wall-Positions 'TinyLife.World.Wall.Positions') are exactly those two positions, ignoring their order.

##### Returns

The wall between the two positions, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The first position |
| secondPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The second position |

<a name='M-TinyLife-World-Map-IsFreeSpot-Microsoft-Xna-Framework-Point-'></a>
### IsFreeSpot(pos) `method`

##### Summary

Returns whether or not the given position on the given map is free for a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') to stand in

##### Returns

Whether this position is free to stand on

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to query |

<a name='M-TinyLife-World-Map-IsInBounds-Microsoft-Xna-Framework-Point-'></a>
### IsInBounds(pos) `method`

##### Summary

Returns whether the given position is in bounds of this map's [Size](#P-TinyLife-World-Map-Size 'TinyLife.World.Map.Size')

##### Returns

true if the position is in bounds, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to query |

<a name='M-TinyLife-World-Map-IsInSectionBounds-Microsoft-Xna-Framework-Point-'></a>
### IsInSectionBounds(section) `method`

##### Summary

Returns whether the given section position is in bounds of this map's [SizeInSections](#P-TinyLife-World-Map-SizeInSections 'TinyLife.World.Map.SizeInSections').

##### Returns

true if the position is in bounds, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The section position to query |

<a name='M-TinyLife-World-Map-IsRoad-Microsoft-Xna-Framework-Point-'></a>
### IsRoad(pos) `method`

##### Summary

Returns whether the given position contains a road.
This doesn't query road tiles, but it queries for road markers added by [AddRoad](#M-TinyLife-World-Map-AddRoad-Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.AddRoad(Microsoft.Xna.Framework.Point)').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') |  |

<a name='M-TinyLife-World-Map-LoadStaticMap-System-String-'></a>
### LoadStaticMap(name) `method`

##### Summary

Loads a static map with the given name from the game's content directory.
Note that this also validates the map ([Validate](#M-TinyLife-World-Map-Validate 'TinyLife.World.Map.Validate')).

##### Returns

The static map that was loaded

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the static map |

<a name='M-TinyLife-World-Map-MarkDirtyForPathfinding-Microsoft-Xna-Framework-Point-'></a>
### MarkDirtyForPathfinding(pos) `method`

##### Summary

Marks the given position dirty for pathfinding purposes.
When a path is found again close to this position, its cost ([GetPathCost](#M-TinyLife-World-Map-GetPathCost-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point- 'TinyLife.World.Map.GetPathCost(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point)')) will be re-calculated.
This method is called by [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') when it is placed for removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to mark dirty |

<a name='M-TinyLife-World-Map-PlaySound-Microsoft-Xna-Framework-Audio-SoundEffect,Microsoft-Xna-Framework-Vector2,System-Single,System-Single,System-Boolean-'></a>
### PlaySound(sound,pos,volume,pitch,loop) `method`

##### Summary

Plays a sound at the given location (in world space) statically.
If the sound should move while being played, use [PlaySound](#M-TinyLife-World-Map-PlaySound-Microsoft-Xna-Framework-Audio-SoundEffect,Microsoft-Xna-Framework-Audio-AudioEmitter,System-Single,System-Single,System-Boolean- 'TinyLife.World.Map.PlaySound(Microsoft.Xna.Framework.Audio.SoundEffect,Microsoft.Xna.Framework.Audio.AudioEmitter,System.Single,System.Single,System.Boolean)') instead.
Note that the returned [SoundEffectInstance](#T-Microsoft-Xna-Framework-Audio-SoundEffectInstance 'Microsoft.Xna.Framework.Audio.SoundEffectInstance') does not need to be disposed when it is finished playing.

##### Returns

The sound effect instance that is responsible for playing this sound, which can be stopped or paused

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [Microsoft.Xna.Framework.Audio.SoundEffect](#T-Microsoft-Xna-Framework-Audio-SoundEffect 'Microsoft.Xna.Framework.Audio.SoundEffect') | The sound effect to play |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in world space, to play the sound at |
| volume | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The sound's volume, between 0 and 1 (default) |
| pitch | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The sound's pitch, between -1, 0 (default) and 1 |
| loop | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the sound should loop |

<a name='M-TinyLife-World-Map-PlaySound-Microsoft-Xna-Framework-Audio-SoundEffect,Microsoft-Xna-Framework-Audio-AudioEmitter,System-Single,System-Single,System-Boolean-'></a>
### PlaySound(sound,emitter,volume,pitch,loop) `method`

##### Summary

Plays a sound at the given location (in world space) with the given [AudioEmitter](#T-Microsoft-Xna-Framework-Audio-AudioEmitter 'Microsoft.Xna.Framework.Audio.AudioEmitter'), whose [Position](#P-Microsoft-Xna-Framework-Audio-AudioEmitter-Position 'Microsoft.Xna.Framework.Audio.AudioEmitter.Position') can be updated by the caller (in screen space).
If the sound should move in a static locatdion, use [PlaySound](#M-TinyLife-World-Map-PlaySound-Microsoft-Xna-Framework-Audio-SoundEffect,Microsoft-Xna-Framework-Vector2,System-Single,System-Single,System-Boolean- 'TinyLife.World.Map.PlaySound(Microsoft.Xna.Framework.Audio.SoundEffect,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,System.Boolean)') instead.
Note that the returned [SoundEffectInstance](#T-Microsoft-Xna-Framework-Audio-SoundEffectInstance 'Microsoft.Xna.Framework.Audio.SoundEffectInstance') does not need to be disposed when it is finished playing.

##### Returns

The sound effect instance that is responsible for playing this sound, which can be stopped or paused

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [Microsoft.Xna.Framework.Audio.SoundEffect](#T-Microsoft-Xna-Framework-Audio-SoundEffect 'Microsoft.Xna.Framework.Audio.SoundEffect') | The sound effect to play |
| emitter | [Microsoft.Xna.Framework.Audio.AudioEmitter](#T-Microsoft-Xna-Framework-Audio-AudioEmitter 'Microsoft.Xna.Framework.Audio.AudioEmitter') | The audio emitter, whose [Position](#P-Microsoft-Xna-Framework-Audio-AudioEmitter-Position 'Microsoft.Xna.Framework.Audio.AudioEmitter.Position') should be set in screen space |
| volume | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The sound's volume, between 0 and 1 (default) |
| pitch | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The sound's pitch, between -1, 0 (default) and 1 |
| loop | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the sound should loop |

<a name='M-TinyLife-World-Map-RemoveHousehold-TinyLife-World-Household-'></a>
### RemoveHousehold(household) `method`

##### Summary

Removes the given household from this map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| household | [TinyLife.World.Household](#T-TinyLife-World-Household 'TinyLife.World.Household') | The household to remove |

<a name='M-TinyLife-World-Map-RemoveLot-TinyLife-World-Lot-'></a>
### RemoveLot(lot) `method`

##### Summary

Removes the given lot from this map's lots

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot to remove |

<a name='M-TinyLife-World-Map-RemoveObject-TinyLife-Objects-MapObject-'></a>
### RemoveObject(obj) `method`

##### Summary

Removes the given object from this map and its underlying [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection').
This also calls [OnRemoved](#M-TinyLife-Objects-MapObject-OnRemoved 'TinyLife.Objects.MapObject.OnRemoved').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [TinyLife.Objects.MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') | The object to remove |

<a name='M-TinyLife-World-Map-RemoveRoof-TinyLife-World-Roof-'></a>
### RemoveRoof(roof) `method`

##### Summary

Removes the given [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') from this map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roof | [TinyLife.World.Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') | The roof to remove |

<a name='M-TinyLife-World-Map-RemoveWall-TinyLife-World-Wall-'></a>
### RemoveWall(wall) `method`

##### Summary

Removes the given wall from the map

##### Returns

Whether the wall was present on the map and could be removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| wall | [TinyLife.World.Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') | The wall to remove |

<a name='M-TinyLife-World-Map-SetTile-Microsoft-Xna-Framework-Point,TinyLife-World-Tile-'></a>
### SetTile(pos,tile) `method`

##### Summary

Sets the tile at the given position to the given tile

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position |
| tile | [TinyLife.World.Tile](#T-TinyLife-World-Tile 'TinyLife.World.Tile') | The tile |

<a name='M-TinyLife-World-Map-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

Updates this map, its [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection') objects and its [Household](#T-TinyLife-World-Household 'TinyLife.World.Household')s.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed in game |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The speed that the game is set to |

<a name='M-TinyLife-World-Map-Validate'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.
When called on a map, each [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection') is validated, and roads and rooms are generated.

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-MapObject'></a>
## MapObject `type`

##### Namespace

TinyLife.Objects

##### Summary

An instance of this class represents an object that can be, or is, part of a [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map').
If this object's [Position](#P-TinyLife-Objects-MapObject-Position 'TinyLife.Objects.MapObject.Position') is set to -1, -1, that is usually an indicator that the object is currently not in the world.

<a name='M-TinyLife-Objects-MapObject-#ctor-System-Guid,TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor(id,map,position) `constructor`

##### Summary

Creates a new map object with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The object's id |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map the object should be on |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that the object should have |

<a name='F-TinyLife-Objects-MapObject-Categories'></a>
### Categories `constants`

##### Summary

A list of all of the [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') flags that exist

<a name='F-TinyLife-Objects-MapObject-Id'></a>
### Id `constants`

##### Summary

The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') of this object instance

<a name='P-TinyLife-Objects-MapObject-CurrentLot'></a>
### CurrentLot `property`

##### Summary

A property that returns the [CurrentLot](#P-TinyLife-Objects-MapObject-CurrentLot 'TinyLife.Objects.MapObject.CurrentLot') that this object is currently on

<a name='P-TinyLife-Objects-MapObject-Map'></a>
### Map `property`

##### Summary

The map that this object is currently on.
If this is null, the object is not currently on a map.

<a name='P-TinyLife-Objects-MapObject-Position'></a>
### Position `property`

##### Summary

The position on the [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map') of this object.
If this is set to -1, -1, that is usually an indicator that the object is currently not in the world.

<a name='M-TinyLife-Objects-MapObject-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}-'></a>
### Draw(time,batch,drawPos,overrideColor) `method`

##### Summary

Draws this object on the current [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map'), at the current [Position](#P-TinyLife-Objects-MapObject-Position 'TinyLife.Objects.MapObject.Position').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in draw space, to draw this furniture at |
| overrideColor | [System.Nullable{Microsoft.Xna.Framework.Color}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{Microsoft.Xna.Framework.Color}') | The color that should be used instead of this object's actual color. If null, the object's regular color should be used. |

<a name='M-TinyLife-Objects-MapObject-GetAiPriority-TinyLife-Objects-Person-'></a>
### GetAiPriority(person) `method`

##### Summary

Returns an integer that represents a priority for the [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi')'s interaction with this object.
A higher priority means that this object will be picked over other objects (with lower priority).
The default return value is 0, meaning that no special priority is assigned to this object.
For any [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') with the [Bed](#F-TinyLife-Objects-ObjectCategory-Bed 'TinyLife.Objects.ObjectCategory.Bed') category that is the person's [LastBedSleptIn](#F-TinyLife-Objects-Person-LastBedSleptIn 'TinyLife.Objects.Person.LastBedSleptIn'), 10 is returned.

##### Returns

This object's priority

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person whose AI is attempting to interact with this object |

<a name='M-TinyLife-Objects-MapObject-GetCategories-TinyLife-Objects-Person-'></a>
### GetCategories(person) `method`

##### Summary

Returns a set of [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') flags that this object has, based on the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person').

##### Returns

A set of categories that this object has

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to query categories for |

<a name='M-TinyLife-Objects-MapObject-GetHoverInfo'></a>
### GetHoverInfo() `method`

##### Summary

Returns a [Tooltip](#T-MLEM-Ui-Elements-Tooltip 'MLEM.Ui.Elements.Tooltip') object that is displayed whenever the mouse is hovered over this object in the world.
By default, this method returns null, which will cause no tooltip to be displayed.

##### Returns

The tooltip to display

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-MapObject-GetModCategory-System-String-'></a>
### GetModCategory(name) `method`

##### Summary

Adds and returns a custom [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') with the given name.
Note that the returned category is not [IsDefined](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum.IsDefined 'System.Enum.IsDefined(System.Type,System.Object)'), and thus, does not have a name.
The returned category is guaranteed to be unique and mapped to the given name. Additionally, it can be used in combined flags, as it is not a combined flag itself.

##### Returns

A new object category

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name that the category should have |

<a name='M-TinyLife-Objects-MapObject-Intersects-MLEM-Misc-RectangleF-'></a>
### Intersects(rectangle) `method`

##### Summary

Returns whether this map object intersects with the given rectangle.
This is used for [GetObjects\`\`1](#M-TinyLife-World-Map-GetObjects``1-MLEM-Misc-RectangleF- 'TinyLife.World.Map.GetObjects``1(MLEM.Misc.RectangleF)')

##### Returns

true if this object intersects with the given rectangle

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rectangle | [MLEM.Misc.RectangleF](#T-MLEM-Misc-RectangleF 'MLEM.Misc.RectangleF') | The area that should be checked for |

<a name='M-TinyLife-Objects-MapObject-OnAdded'></a>
### OnAdded() `method`

##### Summary

This method is called when this object is added to a [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map').
By default, it does nothing.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-MapObject-OnRemoved'></a>
### OnRemoved() `method`

##### Summary

This method is called when this object is removed from a [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map').
By default, it does nothing.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-MapObject-SetMapAndValidate-TinyLife-World-Map-'></a>
### SetMapAndValidate(map) `method`

##### Summary

This method is the same as [Validate](#M-TinyLife-Objects-MapObject-Validate 'TinyLife.Objects.MapObject.Validate'), but it also sets the [Map](#P-TinyLife-Objects-MapObject-Map 'TinyLife.Objects.MapObject.Map').

##### Returns

false if the object is not valid, true otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to set |

<a name='M-TinyLife-Objects-MapObject-Validate'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.
Returning false on this method causes the object to be removed from the map.
By default, this method does nothing.

##### Returns

false if the object is not valid, true otherwise

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-MapSection'></a>
## MapSection `type`

##### Namespace

TinyLife.World

##### Summary

A map section is a small area in a [Map](#F-TinyLife-World-MapSection-Map 'TinyLife.World.MapSection.Map') that actually contains the area's objects.
A map section is always [Size](#F-TinyLife-World-MapSection-Size 'TinyLife.World.MapSection.Size')x[Size](#F-TinyLife-World-MapSection-Size 'TinyLife.World.MapSection.Size') tiles large.

<a name='M-TinyLife-World-MapSection-#ctor-TinyLife-World-Map,Microsoft-Xna-Framework-Point-'></a>
### #ctor(map,sectionPos) `constructor`

##### Summary

Creates a new map section on the given map, with the given section position.
Also fills this map's tile array with the Grass tile.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map |
| sectionPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The section coordinates |

<a name='F-TinyLife-World-MapSection-SectionPos'></a>
### SectionPos `constants`

##### Summary

The position, in section coordinates, of this section on the map.

<a name='F-TinyLife-World-MapSection-Size'></a>
### Size `constants`

##### Summary

The constant size of each map section.
This value is set to 8.

<a name='P-TinyLife-World-MapSection-Pos'></a>
### Pos `property`

##### Summary

The position, in tile coordinates, of this section's top left corner.

<a name='M-TinyLife-World-MapSection-RemoveOutdatedRooms'></a>
### RemoveOutdatedRooms() `method`

##### Summary

Removes all outdated rooms on this map.
This is called by [AddWall](#M-TinyLife-World-Map-AddWall-TinyLife-World-Wall,System-Boolean- 'TinyLife.World.Map.AddWall(TinyLife.World.Wall,System.Boolean)') and a few other methods.

##### Returns

Whether any outdated rooms were removed

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-MapSection-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

Updates this map section and all of the objects on it

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed in game |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's speed |

<a name='M-TinyLife-World-MapSection-Validate'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.
When called on a map section, each of its [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') instances is validated.

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Mods-Mod'></a>
## Mod `type`

##### Namespace

TinyLife.Mods

##### Summary

The base class for all Tiny Life mods.
For an example mod, see .
Mods are uniquely identified by their ID. The id is the name of the class that extends [Mod](#T-TinyLife-Mods-Mod 'TinyLife.Mods.Mod').

<a name='P-TinyLife-Mods-Mod-Description'></a>
### Description `property`

##### Summary

The description of this mod, which will be visible in the options menu.
To localize the description, use [Localization](#T-TinyLife-Localization 'TinyLife.Localization').

<a name='P-TinyLife-Mods-Mod-Icon'></a>
### Icon `property`

##### Summary

The icon texture region of this mod, which will be visible in the options menu

<a name='P-TinyLife-Mods-Mod-Name'></a>
### Name `property`

##### Summary

The display name of this mod, which will be visible in the options menu

<a name='M-TinyLife-Mods-Mod-AddGameContent-TinyLife-GameImpl-'></a>
### AddGameContent(game) `method`

##### Summary

Add the content that this mod provides for the given [GameImpl](#T-TinyLife-GameImpl 'TinyLife.GameImpl') instance. The following ways of content registration are supported:
[Register](#M-TinyLife-Objects-FurnitureType-Register-TinyLife-Objects-FurnitureType-TypeSettings- 'TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)') to register furniture types,
[Register](#M-TinyLife-Actions-ActionType-Register-TinyLife-Actions-ActionType-TypeSettings- 'TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)') to register action types,
[Register](#M-TinyLife-Objects-Clothes-Register-TinyLife-Objects-Clothes- 'TinyLife.Objects.Clothes.Register(TinyLife.Objects.Clothes)') to register clothes (and hair),
[Register](#M-TinyLife-Skills-SkillType-Register-TinyLife-Skills-SkillType- 'TinyLife.Skills.SkillType.Register(TinyLife.Skills.SkillType)') to register skills,
[Register](#M-TinyLife-World-Wallpaper-Register-System-String,System-Int32,MLEM-Textures-UniformTextureAtlas,Microsoft-Xna-Framework-Point,TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion- 'TinyLife.World.Wallpaper.Register(System.String,System.Int32,MLEM.Textures.UniformTextureAtlas,Microsoft.Xna.Framework.Point,TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)') to register wallpapers,
[Register](#M-TinyLife-World-Tile-Register-System-String,System-Int32,MLEM-Textures-TextureRegion,TinyLife-Utilities-ColorScheme,System-Single,System-Boolean,System-Boolean,MLEM-Textures-TextureRegion- 'TinyLife.World.Tile.Register(System.String,System.Int32,MLEM.Textures.TextureRegion,TinyLife.Utilities.ColorScheme,System.Single,System.Boolean,System.Boolean,MLEM.Textures.TextureRegion)') to register tiles.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| game | [TinyLife.GameImpl](#T-TinyLife-GameImpl 'TinyLife.GameImpl') |  |

<a name='M-TinyLife-Mods-Mod-GetCustomFurnitureTextures'></a>
### GetCustomFurnitureTextures() `method`

##### Summary

Return a list of paths (relative to this mod's Content directory) to textures that contain the texture regions used by this mod's custom [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType')s.
Note that the furniture texture needs to have an associated [DataTextureAtlas](#T-MLEM-Data-DataTextureAtlas 'MLEM.Data.DataTextureAtlas') file in the same location, but with the .atlas file extension.
By default, an empty [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') is returned.

##### Returns

The custom data texture atlases for this mod's furniture

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Mods-Mod-Initialize-ExtremelySimpleLogger-Logger,MLEM-Data-Content-RawContentManager,MLEM-Data-RuntimeTexturePacker-'></a>
### Initialize(logger,content,texturePacker) `method`

##### Summary

Initialize the data for this mod, including textures, sounds and other data.
The [RawContentManager](#T-MLEM-Data-Content-RawContentManager 'MLEM.Data.Content.RawContentManager') is a variation of MonoGame's [ContentManager](#T-Microsoft-Xna-Framework-Content-ContentManager 'Microsoft.Xna.Framework.Content.ContentManager') and should be used to load mod content.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [ExtremelySimpleLogger.Logger](#T-ExtremelySimpleLogger-Logger 'ExtremelySimpleLogger.Logger') | The logger that can be used to write info about this mod to the console |
| content | [MLEM.Data.Content.RawContentManager](#T-MLEM-Data-Content-RawContentManager 'MLEM.Data.Content.RawContentManager') | The content manager for this mod |
| texturePacker | [MLEM.Data.RuntimeTexturePacker](#T-MLEM-Data-RuntimeTexturePacker 'MLEM.Data.RuntimeTexturePacker') | The texture packer that packs added textures into one big texture |

<a name='T-TinyLife-Mods-ModInfo'></a>
## ModInfo `type`

##### Namespace

TinyLife.Mods

##### Summary

A mod info is a set of properties that every [Mod](#F-TinyLife-Mods-ModInfo-Mod 'TinyLife.Mods.ModInfo.Mod') instance is assigned

<a name='F-TinyLife-Mods-ModInfo-Content'></a>
### Content `constants`

##### Summary

A [RawContentManager](#T-MLEM-Data-Content-RawContentManager 'MLEM.Data.Content.RawContentManager') that this mod can use to load its content.
This content manager's base directory automatically points to the mod's Content folder.

<a name='F-TinyLife-Mods-ModInfo-Id'></a>
### Id `constants`

##### Summary

The id of the mod, which is based on the [Mod](#F-TinyLife-Mods-ModInfo-Mod 'TinyLife.Mods.ModInfo.Mod')'s class name

<a name='F-TinyLife-Mods-ModInfo-Logger'></a>
### Logger `constants`

##### Summary

The [Logger](#F-TinyLife-Mods-ModInfo-Logger 'TinyLife.Mods.ModInfo.Logger') that this mod can use to log information about itself.
By default, this logger has the same sinks as the game's logger.

<a name='F-TinyLife-Mods-ModInfo-Mod'></a>
### Mod `constants`

##### Summary

The actual mod instance

<a name='M-TinyLife-Mods-ModInfo-Dispose'></a>
### Dispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Mods-ModLoader'></a>
## ModLoader `type`

##### Namespace

TinyLife.Mods

##### Summary

The mod loader loads [Mod](#T-TinyLife-Mods-Mod 'TinyLife.Mods.Mod') instances from the [GetModsFolder](#M-TinyLife-Mods-ModLoader-GetModsFolder 'TinyLife.Mods.ModLoader.GetModsFolder').

<a name='M-TinyLife-Mods-ModLoader-GetModsFolder'></a>
### GetModsFolder() `method`

##### Summary

Returns a [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') pointing to the directory that mods should be put into and loaded from

##### Returns

The mod directory

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Mods-ModLoader-TryGetModInfo-System-String,TinyLife-Mods-ModInfo@-'></a>
### TryGetModInfo(id,info) `method`

##### Summary

This method can be used to gather a [ModInfo](#T-TinyLife-Mods-ModInfo 'TinyLife.Mods.ModInfo') for a mod that is currently loaded with the given id.
If no mod with that id is currently loaded, this method returns false and assigns null to [ModInfo](#T-TinyLife-Mods-ModInfo 'TinyLife.Mods.ModInfo').

##### Returns

Whether or not the mod was found to be loaded

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the mod to get |
| info | [TinyLife.Mods.ModInfo@](#T-TinyLife-Mods-ModInfo@ 'TinyLife.Mods.ModInfo@') | The info that will be returned about the mod |

<a name='T-TinyLife-Tools-MoveLotTool'></a>
## MoveLotTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-MoveLotTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-MoveLotTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveLotTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Tools-MoveTool'></a>
## MoveTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-MoveTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-MoveTool-CanSaveOrSwitchModes'></a>
### CanSaveOrSwitchModes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveTool-ForceWallsUp'></a>
### ForceWallsUp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-MoveTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-MultiAction'></a>
## MultiAction `type`

##### Namespace

TinyLife.Actions

##### Summary

A multi action is an action that can have different actions executed before and/or after itself.
This is quite useful if an action requires a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') to go somewhere to pick up an item etc.

<a name='M-TinyLife-Actions-MultiAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-TinyLife-Actions-MultiAction-FirstActions'></a>
### FirstActions `property`

##### Summary

The actions that should be executed beore this action

<a name='P-TinyLife-Actions-MultiAction-MainElapsedTime'></a>
### MainElapsedTime `property`

##### Summary

The amount of time that has elapsed of this action, excluding the time that [FirstActions](#P-TinyLife-Actions-MultiAction-FirstActions 'TinyLife.Actions.MultiAction.FirstActions') took.

<a name='P-TinyLife-Actions-MultiAction-NextActions'></a>
### NextActions `property`

##### Summary

The actions that should be executed after this action

<a name='M-TinyLife-Actions-MultiAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

Initializes the main action.
This method is called after [FirstActions](#P-TinyLife-Actions-MultiAction-FirstActions 'TinyLife.Actions.MultiAction.FirstActions') have all completed.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-AndThenIsCompleted'></a>
### AndThenIsCompleted() `method`

##### Summary

MultiAction version of [IsCompleted](#M-TinyLife-Actions-MultiAction-IsCompleted 'TinyLife.Actions.MultiAction.IsCompleted').
This method returns whether or not the main action is completed.

##### Returns

Whether the main action is completed

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-AndThenOnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### AndThenOnCompleted(type) `method`

##### Summary

MultiAction version of [OnCompleted](#M-TinyLife-Actions-MultiAction-OnCompleted-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.OnCompleted(TinyLife.Actions.Action.CompletionType)').
This method gets called when the main action completes.
This is also called before [CreateNextActions](#M-TinyLife-Actions-MultiAction-CreateNextActions-TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.CreateNextActions(TinyLife.Actions.Action.CompletionType)') is called.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The completion of the main action |

<a name='M-TinyLife-Actions-MultiAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### AndThenUpdate(time,passedInGame,speed) `method`

##### Summary

MultiAction version of [Update](#M-TinyLife-Actions-MultiAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.MultiAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)').
This method is called every update frame while the main action is active.
By default, only [MainElapsedTime](#P-TinyLife-Actions-MultiAction-MainElapsedTime 'TinyLife.Actions.MultiAction.MainElapsedTime') is increased.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed, in game time |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's speed |

<a name='M-TinyLife-Actions-MultiAction-CanCancel-TinyLife-Actions-Action-'></a>
### CanCancel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

Return a set of actions that should be executed before this action.
Even if the yield statement is used, all actions will be collected into a list at the start of this action's invocation.
If no action gets returned in this function, this action fails.

##### Returns

A set of actions that sohuld run before this action

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-CreateNextActions-TinyLife-Actions-Action-CompletionType-'></a>
### CreateNextActions(type) `method`

##### Summary

Return a set of actions that should be executed after this action.
Can be empty.

##### Returns

A set of actions after this action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The completion of the main action |

<a name='M-TinyLife-Actions-MultiAction-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-IsCompleted'></a>
### IsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-OnBetweenActions-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed,TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType-'></a>
### OnBetweenActions(time,passedInGame,speed,completedAction,completion) `method`

##### Summary

A method that is called after [ShouldFail](#M-TinyLife-Actions-MultiAction-ShouldFail-TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType- 'TinyLife.Actions.MultiAction.ShouldFail(TinyLife.Actions.Action,TinyLife.Actions.Action.CompletionType)') returns false and before the next action is started.
If this method returns true, the next action is not started yet, meaning that this action can fulfil tasks inbetween sub-actions.

##### Returns

false to start the next sub-action (or the main action), true to wait

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed, in game time |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's current speed setting |
| completedAction | [TinyLife.Actions.Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') | The action that has completed |
| completion | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The completion type of the action that has completed |

<a name='M-TinyLife-Actions-MultiAction-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-ShouldFail-TinyLife-Actions-Action,TinyLife-Actions-Action-CompletionType-'></a>
### ShouldFail(completedAction,completion) `method`

##### Summary

A method that returns whether or not this main action should fail if the previous or next `completedAction` completed with the given `completion`.
By default, this method returns true only if `completion` is not [Completed](#F-TinyLife-Actions-Action-CompletionType-Completed 'TinyLife.Actions.Action.CompletionType.Completed').

##### Returns

true if we should fail due to this completion

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| completedAction | [TinyLife.Actions.Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') | The action that has completed |
| completion | [TinyLife.Actions.Action.CompletionType](#T-TinyLife-Actions-Action-CompletionType 'TinyLife.Actions.Action.CompletionType') | The completion type of the action |

<a name='M-TinyLife-Actions-MultiAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-MultiAction-Validate-TinyLife-Objects-Person-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Need'></a>
## Need `type`

##### Namespace

TinyLife

##### Summary

A need is a desire that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have to a given extent, defined by [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value').
Each need is instantiated through its associated [NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType').

<a name='M-TinyLife-Need-#ctor-TinyLife-NeedType-'></a>
### #ctor(type) `constructor`

##### Summary

Instantiate a new need from the given [NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The type to instantiate the need from |

<a name='F-TinyLife-Need-Max'></a>
### Max `constants`

##### Summary

The maximum value that the [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value') can have

<a name='F-TinyLife-Need-Type'></a>
### Type `constants`

##### Summary

The [NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') that this need instance originates from

<a name='P-TinyLife-Need-Percentage'></a>
### Percentage `property`

##### Summary

The [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value') divided by [Max](#F-TinyLife-Need-Max 'TinyLife.Need.Max'), yielding a floating point number between 0 and 1, representing the percentage fullness of this need

<a name='P-TinyLife-Need-Value'></a>
### Value `property`

##### Summary

The current value of this need.
Automatically gets clamped to a number between 0 and [Max](#F-TinyLife-Need-Max 'TinyLife.Need.Max').

<a name='T-TinyLife-NeedType'></a>
## NeedType `type`

##### Namespace

TinyLife

##### Summary

A need is a desire that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have to a given extent.
To register a custom need type, use [Register](#M-TinyLife-NeedType-Register-TinyLife-NeedType- 'TinyLife.NeedType.Register(TinyLife.NeedType)').

<a name='M-TinyLife-NeedType-#ctor-System-String,System-Single,System-Func{TinyLife-Objects-Person,TinyLife-Actions-ActionType},System-Func{TinyLife-Objects-Person,System-TimeSpan},System-Single-'></a>
### #ctor(name,passiveReduction,needLowAction,needLowTime,solveImportance) `constructor`

##### Summary

Instantiates a new need type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this need |
| passiveReduction | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount that this need instance's [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value') is reduced by automatically every update frame |
| needLowAction | [System.Func{TinyLife.Objects.Person,TinyLife.Actions.ActionType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{TinyLife.Objects.Person,TinyLife.Actions.ActionType}') | The action that is executed when this need's value is very low |
| needLowTime | [System.Func{TinyLife.Objects.Person,System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{TinyLife.Objects.Person,System.TimeSpan}') | The amount of in-game time until `needLowAction` is enqueued |
| solveImportance | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The priority for solving this need over other needs, where higher numbers are more urgent |

<a name='F-TinyLife-NeedType-Name'></a>
### Name `constants`

##### Summary

The name of this need.
Used for [Localization](#T-TinyLife-Localization 'TinyLife.Localization') purposes and saving to disk.

<a name='F-TinyLife-NeedType-NeedLowAction'></a>
### NeedLowAction `constants`

##### Summary

The [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') that is constructed and executed when this need type's [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value') is very low

<a name='F-TinyLife-NeedType-NeedLowTime'></a>
### NeedLowTime `constants`

##### Summary

The amount of in-game time that needs to pass until [NeedLowAction](#F-TinyLife-NeedType-NeedLowAction 'TinyLife.NeedType.NeedLowAction') is constructed and enqueued

<a name='F-TinyLife-NeedType-PassiveReduction'></a>
### PassiveReduction `constants`

##### Summary

The amount that a need instance's [Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value') is reduced by automatically every update frame

<a name='F-TinyLife-NeedType-SolveImportance'></a>
### SolveImportance `constants`

##### Summary

The priority for solving this need over other needs, where higher numbers represent a more urgent need.
This value defaults to 0, meaning it has no special importance.

<a name='F-TinyLife-NeedType-Types'></a>
### Types `constants`

##### Summary

A list of all of the need types that are currently registered.
Register custom need types using [Register](#M-TinyLife-NeedType-Register-TinyLife-NeedType- 'TinyLife.NeedType.Register(TinyLife.NeedType)').

<a name='M-TinyLife-NeedType-Register-TinyLife-NeedType-'></a>
### Register(type) `method`

##### Summary

Register the [NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') specified to the [Types](#F-TinyLife-NeedType-Types 'TinyLife.NeedType.Types') dictionary

##### Returns

The need typep passed, for chaining

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The need type to register |

<a name='T-TinyLife-Uis-Notifications'></a>
## Notifications `type`

##### Namespace

TinyLife.Uis

##### Summary

This class holds information about the current and past notifications that are displayed in the top center of the screen.
To create custom notifications, use [Add](#M-TinyLife-Uis-Notifications-Add-TinyLife-Objects-MapObject,System-String- 'TinyLife.Uis.Notifications.Add(TinyLife.Objects.MapObject,System.String)') or [Add](#M-TinyLife-Uis-Notifications-Add-MLEM-Textures-TextureRegion,System-String- 'TinyLife.Uis.Notifications.Add(MLEM.Textures.TextureRegion,System.String)').

<a name='M-TinyLife-Uis-Notifications-Add-TinyLife-Objects-MapObject,System-String-'></a>
### Add(obj,content) `method`

##### Summary

Adds a new notification related to the given map object.
The passed object is also the one that will be displayed in the notification.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [TinyLife.Objects.MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') | The map object that this notification relates to |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The content of the notification. Should be localized using [Localization](#T-TinyLife-Localization 'TinyLife.Localization') |

<a name='M-TinyLife-Uis-Notifications-Add-MLEM-Textures-TextureRegion,System-String-'></a>
### Add(icon,content) `method`

##### Summary

Adds a new notification related to nothing.
The passed icon is displayed instead of an object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The icon that should be displayed in the notification |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The content of the notification. Should be localized using [Localization](#T-TinyLife-Localization 'TinyLife.Localization') |

<a name='T-TinyLife-Objects-ObjectCategory'></a>
## ObjectCategory `type`

##### Namespace

TinyLife.Objects

##### Summary

An object category is a way to tell the [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') and [AbstractSpot](#T-TinyLife-Objects-AbstractSpot 'TinyLife.Objects.AbstractSpot') system what type an object is.
An object can have any number of categories attached to it, since this is a [FlagsAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FlagsAttribute 'System.FlagsAttribute') enumeration.
Custom modded categories can be added and retrieved using [GetModCategory](#M-TinyLife-Objects-MapObject-GetModCategory-System-String- 'TinyLife.Objects.MapObject.GetModCategory(System.String)').

<a name='F-TinyLife-Objects-ObjectCategory-Bed'></a>
### Bed `constants`

##### Summary

An object category that represents objects where one can sleep

<a name='F-TinyLife-Objects-ObjectCategory-Bookshelf'></a>
### Bookshelf `constants`

##### Summary

An object category that represents things that books are stored in

<a name='F-TinyLife-Objects-ObjectCategory-Chair'></a>
### Chair `constants`

##### Summary

An object category that represents sittable surfaces

<a name='F-TinyLife-Objects-ObjectCategory-Cleanable'></a>
### Cleanable `constants`

##### Summary

An object category that represents objects that can be cleaned in a [Sink](#F-TinyLife-Objects-ObjectCategory-Sink 'TinyLife.Objects.ObjectCategory.Sink')

<a name='F-TinyLife-Objects-ObjectCategory-Computer'></a>
### Computer `constants`

##### Summary

An object category that represents computers

<a name='F-TinyLife-Objects-ObjectCategory-Counter'></a>
### Counter `constants`

##### Summary

An object category that represents objects where one can prepare food and place [CounterObject](#F-TinyLife-Objects-ObjectCategory-CounterObject 'TinyLife.Objects.ObjectCategory.CounterObject') objects

<a name='F-TinyLife-Objects-ObjectCategory-CounterObject'></a>
### CounterObject `constants`

##### Summary

An object category that represents objects that can be placed on [Counter](#F-TinyLife-Objects-ObjectCategory-Counter 'TinyLife.Objects.ObjectCategory.Counter') objects

<a name='F-TinyLife-Objects-ObjectCategory-DeskObject'></a>
### DeskObject `constants`

##### Summary

An object category that represents objects that can be placed on desk-like tables

<a name='F-TinyLife-Objects-ObjectCategory-DisallowedOnGround'></a>
### DisallowedOnGround `constants`

##### Summary

An object category that represents objects that cannot be placed on the ground, but only in object spots

<a name='F-TinyLife-Objects-ObjectCategory-Easel'></a>
### Easel `constants`

##### Summary

An object category that represents places where one can paint paintings

<a name='F-TinyLife-Objects-ObjectCategory-ForceGridPlacement'></a>
### ForceGridPlacement `constants`

##### Summary

An object category that represents objects which cannot be placed off the grid using the ALT key in the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool')

<a name='F-TinyLife-Objects-ObjectCategory-Fridge'></a>
### Fridge `constants`

##### Summary

An object category that represents objects where one can get food ingredients

<a name='F-TinyLife-Objects-ObjectCategory-GentleCulling'></a>
### GentleCulling `constants`

##### Summary

An object category that represents objects that should be culled more gently (in a bigger radius). This property should be assigned to objects that are fairly large in display size.

<a name='F-TinyLife-Objects-ObjectCategory-Gravestone'></a>
### Gravestone `constants`

##### Summary

An object category that represents gravestones

<a name='F-TinyLife-Objects-ObjectCategory-Ground'></a>
### Ground `constants`

##### Summary

An object category that represents the ground

<a name='F-TinyLife-Objects-ObjectCategory-Holdable'></a>
### Holdable `constants`

##### Summary

An object category that represents objects that can be held by a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')

<a name='F-TinyLife-Objects-ObjectCategory-Mailbox'></a>
### Mailbox `constants`

##### Summary

An object category that represents mailboxes

<a name='F-TinyLife-Objects-ObjectCategory-Mirror'></a>
### Mirror `constants`

##### Summary

An object category that represents mirrors

<a name='F-TinyLife-Objects-ObjectCategory-NaturalGroundRequired'></a>
### NaturalGroundRequired `constants`

##### Summary

An object category that represents objects that can only be placed on natural ground, namely grass tiles

<a name='F-TinyLife-Objects-ObjectCategory-NonBuyable'></a>
### NonBuyable `constants`

##### Summary

An object category that represents objects that cannot be bought in the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool')

<a name='F-TinyLife-Objects-ObjectCategory-NonColliding'></a>
### NonColliding `constants`

##### Summary

An object category that represents things that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') does not collide with

<a name='F-TinyLife-Objects-ObjectCategory-NonMovable'></a>
### NonMovable `constants`

##### Summary

An object category that represents things that cannot be moved using [MoveTool](#T-TinyLife-Tools-MoveTool 'TinyLife.Tools.MoveTool')

<a name='F-TinyLife-Objects-ObjectCategory-NonSellable'></a>
### NonSellable `constants`

##### Summary

An object category that represents things that cannot be solved or removed using [RemoveTool](#T-TinyLife-Tools-RemoveTool 'TinyLife.Tools.RemoveTool')

<a name='F-TinyLife-Objects-ObjectCategory-Nothing'></a>
### Nothing `constants`

##### Summary

An object category that reprsents an object without any properties

<a name='F-TinyLife-Objects-ObjectCategory-People'></a>
### People `constants`

##### Summary

An object category that all [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instances hae

<a name='F-TinyLife-Objects-ObjectCategory-Self'></a>
### Self `constants`

##### Summary

An object category that represents the object that contains it

<a name='F-TinyLife-Objects-ObjectCategory-Shower'></a>
### Shower `constants`

##### Summary

An object category that represents objects where one can shower

<a name='F-TinyLife-Objects-ObjectCategory-Sink'></a>
### Sink `constants`

##### Summary

An object category that represents objects where one can clean dishes and wash hands

<a name='F-TinyLife-Objects-ObjectCategory-SmallObject'></a>
### SmallObject `constants`

##### Summary

An object category that represents objects that can sit on [Counter](#F-TinyLife-Objects-ObjectCategory-Counter 'TinyLife.Objects.ObjectCategory.Counter') and [Table](#F-TinyLife-Objects-ObjectCategory-Table 'TinyLife.Objects.ObjectCategory.Table') objects

<a name='F-TinyLife-Objects-ObjectCategory-Stove'></a>
### Stove `constants`

##### Summary

An object category that represents objects where one can cook food

<a name='F-TinyLife-Objects-ObjectCategory-Table'></a>
### Table `constants`

##### Summary

An object category that represents objects where one can place [SmallObject](#F-TinyLife-Objects-ObjectCategory-SmallObject 'TinyLife.Objects.ObjectCategory.SmallObject') objects

<a name='F-TinyLife-Objects-ObjectCategory-Toilet'></a>
### Toilet `constants`

##### Summary

An object category that represents objects where one can use the toilet

<a name='F-TinyLife-Objects-ObjectCategory-Tree'></a>
### Tree `constants`

##### Summary

An object category that represents trees

<a name='F-TinyLife-Objects-ObjectCategory-WallHanging'></a>
### WallHanging `constants`

##### Summary

An object category that represents objects which need to be hung on [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') objects

<a name='F-TinyLife-Objects-ObjectCategory-Wardrobe'></a>
### Wardrobe `constants`

##### Summary

An object category that represents objects where a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can change

<a name='T-TinyLife-Objects-ObjectSpot'></a>
## ObjectSpot `type`

##### Namespace

TinyLife.Objects

##### Summary

An object spot is a [AbstractSpot](#T-TinyLife-Objects-AbstractSpot 'TinyLife.Objects.AbstractSpot') extension that is used by [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') to declare a location that another [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') object can be slotted into.
This behavior is used for things like plates on counters, flower pots on bedside tables etc.

<a name='M-TinyLife-Objects-ObjectSpot-#ctor-Microsoft-Xna-Framework-Vector2,System-Predicate{TinyLife-Objects-FurnitureType},System-Single,MLEM-Misc-Direction2[]-'></a>
### #ctor(offset,isFurnitureAllowed,yOffset,validDirections) `constructor`

##### Summary

Creates a new object spot with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The offset on both the x and y axis that this spot has |
| isFurnitureAllowed | [System.Predicate{TinyLife.Objects.FurnitureType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{TinyLife.Objects.FurnitureType}') | A predicate that determines if the given [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') is allowed to be put into this spot |
| yOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The offset on the visual y axis |
| validDirections | [MLEM.Misc.Direction2[]](#T-MLEM-Misc-Direction2[] 'MLEM.Misc.Direction2[]') | The directions that this spot can be accessed from |

<a name='M-TinyLife-Objects-ObjectSpot-#ctor-Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Predicate{TinyLife-Objects-FurnitureType},System-Single,MLEM-Misc-Direction2[]-'></a>
### #ctor(offset,visualOffset,isFurnitureAllowed,yOffset,validDirections) `constructor`

##### Summary

Creates a new object spot with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| offset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The offset on both the x and y axis that this spot has |
| visualOffset | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The visual offset on both the x and y axis that this spot has |
| isFurnitureAllowed | [System.Predicate{TinyLife.Objects.FurnitureType}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{TinyLife.Objects.FurnitureType}') | A predicate that determines if the given [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') is allowed to be put into this spot |
| yOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The offset on the visual y axis |
| validDirections | [MLEM.Misc.Direction2[]](#T-MLEM-Misc-Direction2[] 'MLEM.Misc.Direction2[]') | The directions that this spot can be accessed from |

<a name='F-TinyLife-Objects-ObjectSpot-IsFurnitureAllowed'></a>
### IsFurnitureAllowed `constants`

##### Summary

A predicate that determines if the given [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') is allowed to be put into this object spot

<a name='M-TinyLife-Objects-ObjectSpot-CounterSpots-System-Boolean-'></a>
### CounterSpots(stove) `method`

##### Summary

A helper method to create a set of [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') instnaces for counters and stoves.
The resulting set contains a single object spot for [SmallObject](#F-TinyLife-Objects-ObjectCategory-SmallObject 'TinyLife.Objects.ObjectCategory.SmallObject') and [CounterObject](#F-TinyLife-Objects-ObjectCategory-CounterObject 'TinyLife.Objects.ObjectCategory.CounterObject') object, or [PreparedFood](#F-TinyLife-Objects-FurnitureType-PreparedFood 'TinyLife.Objects.FurnitureType.PreparedFood') and [Pot](#F-TinyLife-Objects-FurnitureType-Pot 'TinyLife.Objects.FurnitureType.Pot') if `stove` is true.

##### Returns

A set of object spots for the stove or counter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stove | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether the object is a stove (or a counter) |

<a name='M-TinyLife-Objects-ObjectSpot-GetContents``1-TinyLife-Objects-Furniture-'></a>
### GetContents\`\`1(furniture) `method`

##### Summary

Returns the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') objects that are currently slotted into this spot

##### Returns

A set of children of this spot, or an empty set if there are none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furniture that this spot belongs to |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type the child furnitures are expected to be |

<a name='M-TinyLife-Objects-ObjectSpot-TableSpots-Microsoft-Xna-Framework-Point-'></a>
### TableSpots(size) `method`

##### Summary

A helper method to create a set of [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') instances for a table of the given size.
The resulting set of object spots will have spots for [Chair](#F-TinyLife-Objects-ObjectCategory-Chair 'TinyLife.Objects.ObjectCategory.Chair') objects on each side as well as [SmallObject](#F-TinyLife-Objects-ObjectCategory-SmallObject 'TinyLife.Objects.ObjectCategory.SmallObject') objects on each tile position.

##### Returns

A set of object spots for the table

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| size | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The size that the table has in tiles |

<a name='T-TinyLife-World-Opening'></a>
## Opening `type`

##### Namespace

TinyLife.World

##### Summary

An opening is some sort of extrusion in a [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall'), like a window or a door.
Openings are created from their underlying [OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType').

<a name='M-TinyLife-World-Opening-#ctor-TinyLife-World-OpeningType,System-Int32-'></a>
### #ctor(type,color) `constructor`

##### Summary

Creates a new opening from the given opening type and color

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.World.OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType') | The opening type |
| color | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the color |

<a name='F-TinyLife-World-Opening-Color'></a>
### Color `constants`

##### Summary

The index of the [OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType')'s [ColorScheme](#F-TinyLife-World-OpeningType-ColorScheme 'TinyLife.World.OpeningType.ColorScheme') that this opening instance has

<a name='F-TinyLife-World-Opening-Type'></a>
### Type `constants`

##### Summary

The [OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType') that this opening has

<a name='M-TinyLife-World-Opening-CanWalkThrough'></a>
### CanWalkThrough() `method`

##### Summary

Returns whether a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') is able to walk through a [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') that has this opening.
This returns true for [Door](#T-TinyLife-World-Door 'TinyLife.World.Door') and false for [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening').

##### Returns



##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Opening-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Tools-OpeningTool'></a>
## OpeningTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-OpeningTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-OpeningTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-OpeningTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-OpeningTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-OpeningTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-OpeningTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-OpeningType'></a>
## OpeningType `type`

##### Namespace

TinyLife.World

##### Summary

An opening is some sort of extrusion in a [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall'), like a window or a door.
An opening type stores data that can be used to construct a [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening') instance.

<a name='M-TinyLife-World-OpeningType-#ctor-System-String,MLEM-Textures-TextureRegion,TinyLife-World-WallMode,System-Int32,System-Func{TinyLife-World-OpeningType,System-Int32,TinyLife-World-Wall,TinyLife-World-Opening},TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion-'></a>
### #ctor(name,textureRegion,wallMode,price,construct,colorScheme,icon) `constructor`

##### Summary

Creates a new opening type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name |
| textureRegion | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture to use for rendering |
| wallMode | [TinyLife.World.WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode') | The wall mode |
| price | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The price |
| construct | [System.Func{TinyLife.World.OpeningType,System.Int32,TinyLife.World.Wall,TinyLife.World.Opening}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{TinyLife.World.OpeningType,System.Int32,TinyLife.World.Wall,TinyLife.World.Opening}') | The function that is used for constructing an [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening') from this opening type |
| colorScheme | [TinyLife.Utilities.ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme') | The color scheme for this opening |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The build mode category icon of this object |

<a name='F-TinyLife-World-OpeningType-ColorScheme'></a>
### ColorScheme `constants`

##### Summary

The color scheme that opening instances can have when created from this type

<a name='F-TinyLife-World-OpeningType-Icon'></a>
### Icon `constants`

##### Summary

The build mode icon for this object, which represents the category / theme / mod that it comes from.
If this value is nonnull, the icon will be displayed in the corner of the build mode button for this object.

<a name='F-TinyLife-World-OpeningType-Name'></a>
### Name `constants`

##### Summary

The name of this opening type

<a name='F-TinyLife-World-OpeningType-Price'></a>
### Price `constants`

##### Summary

The price of this opening

<a name='F-TinyLife-World-OpeningType-Types'></a>
### Types `constants`

##### Summary

A registry for all [OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType') instances from the game and mods.
Use [Register](#M-TinyLife-World-OpeningType-Register-TinyLife-World-OpeningType- 'TinyLife.World.OpeningType.Register(TinyLife.World.OpeningType)') to register custom opening types.

<a name='F-TinyLife-World-OpeningType-WallMode'></a>
### WallMode `constants`

##### Summary

The [WallMode](#F-TinyLife-World-OpeningType-WallMode 'TinyLife.World.OpeningType.WallMode') that [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') instances with this opening in it should use for rendering

<a name='M-TinyLife-World-OpeningType-Construct-System-Int32,TinyLife-World-Wall-'></a>
### Construct(color,wall) `method`

##### Summary

Constructs a new [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening') instance from this opening type

##### Returns

A new opening instance based on this type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The color index to use |
| wall | [TinyLife.World.Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') | The wall that this opening will be slotted into |

<a name='M-TinyLife-World-OpeningType-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Boolean,System-Single,System-Single,System-Int32-'></a>
### Draw(time,batch,drawPos,vertical,scale,depth,color) `method`

##### Summary

Draws this opening in a wall

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to render with |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in screen space, to draw at |
| vertical | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether the underlying wall is vertical |
| scale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to render with |
| depth | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The depth to use for rendering |
| color | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The color index that should be used for rendering |

<a name='M-TinyLife-World-OpeningType-DrawUi-MLEM-Ui-Elements-Element,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-GameTime,System-Int32,System-Single-'></a>
### DrawUi(e,batch,time,color,drawScale) `method`

##### Summary

Draws this opening in ui space rather than world space

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MLEM.Ui.Elements.Element](#T-MLEM-Ui-Elements-Element 'MLEM.Ui.Elements.Element') | The ui element to draw this opening onto |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game time |
| color | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The color index to draw with |
| drawScale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw with. 0.3 by default. |

<a name='M-TinyLife-World-OpeningType-Register-TinyLife-World-OpeningType-'></a>
### Register(type) `method`

##### Summary

Registers the given [OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType') to the [Types](#F-TinyLife-World-OpeningType-Types 'TinyLife.World.OpeningType.Types') registry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.World.OpeningType](#T-TinyLife-World-OpeningType 'TinyLife.World.OpeningType') | The type to register |

<a name='T-TinyLife-Options'></a>
## Options `type`

##### Namespace

TinyLife

##### Summary

The game's options, which are displayed in the [InitializeOptions](#M-TinyLife-Uis-Menus-InitializeOptions-MLEM-Ui-UiSystem,System-Boolean,System-Boolean- 'TinyLife.Uis.Menus.InitializeOptions(MLEM.Ui.UiSystem,System.Boolean,System.Boolean)') menu and saved to disk

<a name='F-TinyLife-Options-Fullscreen'></a>
### Fullscreen `constants`

##### Summary

Whether the game is currently in fullscreen mode

<a name='F-TinyLife-Options-GameSpeeds'></a>
### GameSpeeds `constants`

##### Summary

An array of all defined [GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') values

<a name='F-TinyLife-Options-Language'></a>
### Language `constants`

##### Summary

The currently selected language's language code.
Determines the language used by [Localization](#T-TinyLife-Localization 'TinyLife.Localization').

<a name='F-TinyLife-Options-SoundVolume'></a>
### SoundVolume `constants`

##### Summary

The current sound volume as a percentage, ranging from 0 to 1

<a name='F-TinyLife-Options-UiScale'></a>
### UiScale `constants`

##### Summary

A modifier that is applied to the game's [UiSystem](#T-MLEM-Ui-UiSystem 'MLEM.Ui.UiSystem')'s [GlobalScale](#P-MLEM-Ui-UiSystem-GlobalScale 'MLEM.Ui.UiSystem.GlobalScale')

<a name='F-TinyLife-Options-VSync'></a>
### VSync `constants`

##### Summary

Whether vertical synchronization is currently turned on

<a name='F-TinyLife-Options-WallDisplays'></a>
### WallDisplays `constants`

##### Summary

An array of all defined [WallDisplay](#T-TinyLife-WallDisplay 'TinyLife.WallDisplay') values

<a name='P-TinyLife-Options-Instance'></a>
### Instance `property`

##### Summary

The static singleton instance of [Options](#T-TinyLife-Options 'TinyLife.Options')

<a name='P-TinyLife-Options-WallMode'></a>
### WallMode `property`

##### Summary

The currently selected [WallMode](#P-TinyLife-Options-WallMode 'TinyLife.Options.WallMode').
Note that this value does not always return the wall mode that has been selected by the user:
If [Mode](#P-TinyLife-GameImpl-Mode 'TinyLife.GameImpl.Mode') is [SelectHousehold](#F-TinyLife-GameImpl-GameMode-SelectHousehold 'TinyLife.GameImpl.GameMode.SelectHousehold'), [Roofs](#F-TinyLife-WallDisplay-Roofs 'TinyLife.WallDisplay.Roofs') is returned.
If the [CurrentTool](#P-TinyLife-GameImpl-CurrentTool 'TinyLife.GameImpl.CurrentTool') overrides [ForceWallsUp](#M-TinyLife-Tools-Tool-ForceWallsUp 'TinyLife.Tools.Tool.ForceWallsUp'), that value is returned.

<a name='M-TinyLife-Options-Apply'></a>
### Apply() `method`

##### Summary

Applies the currently selected options of this instance to the game

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Options-Load'></a>
### Load() `method`

##### Summary

Loads the options from the default options file path and stores them in [Instance](#P-TinyLife-Options-Instance 'TinyLife.Options.Instance').
If there are no options in the default options file, a new instance is created.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Options-Save'></a>
### Save() `method`

##### Summary

Saves the options to the default options file path

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-OutOfTownAction'></a>
## OutOfTownAction `type`

##### Namespace

TinyLife.Actions

##### Summary

An out-of-town action is an action where the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') finds the closest exit road and then exits the city using that road.
Out-of-town actions are things like going to work, where the destination location isn't visible to the player.

<a name='M-TinyLife-Actions-OutOfTownAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,TinyLife-NeedType[]-'></a>
### #ctor(type,info,needsToTakeCareOf) `constructor`

##### Summary

Creates a new out-of-town action with the given settings.
Note that, since some data is not saved to disk, all of the information should be provided by a subclass constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') | The action type |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| needsToTakeCareOf | [TinyLife.NeedType[]](#T-TinyLife-NeedType[] 'TinyLife.NeedType[]') | The needs that should automatically be taken care of |

<a name='F-TinyLife-Actions-OutOfTownAction-NeedsToTakeCareOf'></a>
### NeedsToTakeCareOf `constants`

##### Summary

The needs that should automatically be taken care of while the person is out of town.
A need gets taken care of in [AndThenUpdate](#M-TinyLife-Actions-OutOfTownAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.OutOfTownAction.AndThenUpdate(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') if it is below 35%.
Note that this value is not saved to disk, and should be provided by a subclass constructor.

<a name='M-TinyLife-Actions-OutOfTownAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-OutOfTownAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### AndThenUpdate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-OutOfTownAction-CanEnqueueConversation-TinyLife-Objects-Person,TinyLife-Actions-ActionType-'></a>
### CanEnqueueConversation() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-OutOfTownAction-CausesExtremelyFastSpeed'></a>
### CausesExtremelyFastSpeed() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-OutOfTownAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-OutOfTownAction-GetClosestExitRoad'></a>
### GetClosestExitRoad() `method`

##### Summary

Returns the point of the road that is at the edge of the map and the [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') that the map border is in, and is also closest to the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person').
Since every map is expected to have at least one exit road, no checking is done to ensure that one exists.

##### Returns

The closest exit road

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-OutOfTownAction-GetNextAction-TinyLife-Actions-Action-CompletionType-'></a>
### GetNextAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-Painting'></a>
## Painting `type`

##### Namespace

TinyLife.Objects

##### Summary

*Inherit from parent.*

<a name='T-TinyLife-Skills-Painting'></a>
## Painting `type`

##### Namespace

TinyLife.Skills

##### Summary

The Painting class holds various options and settings related to the [Painting](#F-TinyLife-Skills-SkillType-Painting 'TinyLife.Skills.SkillType.Painting') skill

<a name='M-TinyLife-Objects-Painting-#ctor-System-Guid,TinyLife-Objects-FurnitureType,System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Objects-Painting-Creator'></a>
### Creator `constants`

##### Summary

The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') of the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that created, and is painting this painting.
This value defaults to [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty'), meaning no creator.

<a name='F-TinyLife-Objects-Painting-PaintingType'></a>
### PaintingType `constants`

##### Summary

The type of painting that this object displays

<a name='F-TinyLife-Objects-Painting-Progress'></a>
### Progress `constants`

##### Summary

The progress that has been done on this painting by the [Creator](#F-TinyLife-Objects-Painting-Creator 'TinyLife.Objects.Painting.Creator') so far.
This value defaults to 1, which is 100%.

<a name='F-TinyLife-Objects-Painting-Quality'></a>
### Quality `constants`

##### Summary

The [Quality](#F-TinyLife-Objects-Painting-Quality 'TinyLife.Objects.Painting.Quality') that this painting has.
This value default to [Average](#F-TinyLife-Skills-Quality-Average 'TinyLife.Skills.Quality.Average'), but may be different if there is a [Creator](#F-TinyLife-Objects-Painting-Creator 'TinyLife.Objects.Painting.Creator').

<a name='F-TinyLife-Skills-Painting-PaintingTypes'></a>
### PaintingTypes `constants`

##### Summary

All registered [PaintingType](#T-TinyLife-Skills-Painting-PaintingType 'TinyLife.Skills.Painting.PaintingType') instances in the game and in active mods

<a name='M-TinyLife-Objects-Painting-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color},MLEM-Misc-Direction2,System-Int32[],System-Single,System-Boolean,TinyLife-Objects-Furniture,TinyLife-Objects-ObjectSpot,System-Single,System-Boolean-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Painting-GetHoverInfo'></a>
### GetHoverInfo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Painting-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Skills-Painting-RegisterPaintingType-TinyLife-Skills-Painting-PaintingType-'></a>
### RegisterPaintingType(type) `method`

##### Summary

Registers a painting type with the given settings to the [PaintingTypes](#F-TinyLife-Skills-Painting-PaintingTypes 'TinyLife.Skills.Painting.PaintingTypes') registry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.Painting.PaintingType](#T-TinyLife-Skills-Painting-PaintingType 'TinyLife.Skills.Painting.PaintingType') | The type to register |

<a name='T-TinyLife-Skills-Painting-PaintingType'></a>
## PaintingType `type`

##### Namespace

TinyLife.Skills.Painting

##### Summary

This class represents a type of [Painting](#T-TinyLife-Objects-Painting 'TinyLife.Objects.Painting') that can be created using the [Painting](#F-TinyLife-Skills-SkillType-Painting 'TinyLife.Skills.SkillType.Painting').
Painting types are registered using [RegisterPaintingType](#M-TinyLife-Skills-Painting-RegisterPaintingType-TinyLife-Skills-Painting-PaintingType- 'TinyLife.Skills.Painting.RegisterPaintingType(TinyLife.Skills.Painting.PaintingType)').

<a name='M-TinyLife-Skills-Painting-PaintingType-#ctor-System-String,MonoGame-Extended-Range{System-Int32},System-Single-'></a>
### #ctor(name,levelRange,baseMarkup) `constructor`

##### Summary

Creates a new painting type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this painting type |
| levelRange | [MonoGame.Extended.Range{System.Int32}](#T-MonoGame-Extended-Range{System-Int32} 'MonoGame.Extended.Range{System.Int32}') | The range of levels of the painting skill that should allow for creation of this painting |
| baseMarkup | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The multiplier with which the created painting's price will be marked up |

<a name='F-TinyLife-Skills-Painting-PaintingType-BaseMarkup'></a>
### BaseMarkup `constants`

##### Summary

The multiplier with which the created [Painting](#T-TinyLife-Objects-Painting 'TinyLife.Objects.Painting')'s price will be marked up.
Before this multiplier is applied, the level and quality modifiers are also applied.

<a name='F-TinyLife-Skills-Painting-PaintingType-LevelRange'></a>
### LevelRange `constants`

##### Summary

The [Range\`1](#T-MonoGame-Extended-Range`1 'MonoGame.Extended.Range`1') of levels of the [Painting](#F-TinyLife-Skills-SkillType-Painting 'TinyLife.Skills.SkillType.Painting') skill that allows creating this painting

<a name='F-TinyLife-Skills-Painting-PaintingType-Name'></a>
### Name `constants`

##### Summary

The name of this painting type

<a name='F-TinyLife-Skills-Painting-PaintingType-Texture'></a>
### Texture `constants`

##### Summary

The texture that this painting uses.
Note that this texture is just an overlay; the frame and white background are automatically drawn.

<a name='T-TinyLife-Objects-Particle'></a>
## Particle `type`

##### Namespace

TinyLife.Objects

##### Summary

A particle is a [SpriteAnimation](#T-MLEM-Animations-SpriteAnimation 'MLEM.Animations.SpriteAnimation') that can be moved and displayed in world space.
A particle is simply a [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') that does not collide or interact directly with the world, but has all of the same properties.
A new particle can be added for display using [Spawn](#M-TinyLife-Objects-Particle-Spawn-TinyLife-Objects-Particle- 'TinyLife.Objects.Particle.Spawn(TinyLife.Objects.Particle)').

<a name='M-TinyLife-Objects-Particle-#ctor-MLEM-Textures-TextureRegion,System-TimeSpan,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor(region,timeToLive,position) `constructor`

##### Summary

Creates a new particle with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| region | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture that this particle should display with |
| timeToLive | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of real time that this particle should stay alive for |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that this particle should have, in world space |

<a name='M-TinyLife-Objects-Particle-#ctor-MLEM-Animations-SpriteAnimation,System-TimeSpan,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor(animation,timeToLive,position) `constructor`

##### Summary

Creates a new particle with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| animation | [MLEM.Animations.SpriteAnimation](#T-MLEM-Animations-SpriteAnimation 'MLEM.Animations.SpriteAnimation') | The animation that this particle should display with |
| timeToLive | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of real time that this particle should stay alive for |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position that this particle should have, in world space |

<a name='F-TinyLife-Objects-Particle-Animation'></a>
### Animation `constants`

##### Summary

The [SpriteAnimation](#T-MLEM-Animations-SpriteAnimation 'MLEM.Animations.SpriteAnimation') that this particle displays over its lifespan

<a name='F-TinyLife-Objects-Particle-DepthOffset'></a>
### DepthOffset `constants`

##### Summary

The amount of tiles that this particle's depth display calculation is offset by, from its [Position](#F-TinyLife-Objects-Particle-Position 'TinyLife.Objects.Particle.Position')

<a name='F-TinyLife-Objects-Particle-DrawOffset'></a>
### DrawOffset `constants`

##### Summary

The amount of tiles that this particle's display position is offset by, from its [Position](#F-TinyLife-Objects-Particle-Position 'TinyLife.Objects.Particle.Position')

<a name='F-TinyLife-Objects-Particle-Friction'></a>
### Friction `constants`

##### Summary

The friction that is applied to this particle's [Motion](#F-TinyLife-Objects-Particle-Motion 'TinyLife.Objects.Particle.Motion') every [Update](#M-TinyLife-Objects-Particle-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Particle.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame

<a name='F-TinyLife-Objects-Particle-Motion'></a>
### Motion `constants`

##### Summary

The amount that this particle's [Position](#F-TinyLife-Objects-Particle-Position 'TinyLife.Objects.Particle.Position') is modified by each [Update](#M-TinyLife-Objects-Particle-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Particle.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame

<a name='F-TinyLife-Objects-Particle-Position'></a>
### Position `constants`

##### Summary

The position in the world of this particle

<a name='F-TinyLife-Objects-Particle-Scale'></a>
### Scale `constants`

##### Summary

An [Easing](#T-MLEM-Misc-Easings-Easing 'MLEM.Misc.Easings.Easing') that determines how this particle's scale (display size) changes based on its [TimeToLive](#F-TinyLife-Objects-Particle-TimeToLive 'TinyLife.Objects.Particle.TimeToLive') and [TimeLived](#F-TinyLife-Objects-Particle-TimeLived 'TinyLife.Objects.Particle.TimeLived')

<a name='F-TinyLife-Objects-Particle-TimeLived'></a>
### TimeLived `constants`

##### Summary

The amount of real time that this particle has lived for.
This time span will always be lower than or equal to [TimeToLive](#F-TinyLife-Objects-Particle-TimeToLive 'TinyLife.Objects.Particle.TimeToLive').

<a name='F-TinyLife-Objects-Particle-TimeToLive'></a>
### TimeToLive `constants`

##### Summary

The amount of real time that this particle should stay alive for until it disappears

<a name='P-TinyLife-Objects-Particle-Map'></a>
### Map `property`

##### Summary

The map that this particle is on.
Note that this always returns [Map](#P-TinyLife-GameImpl-Map 'TinyLife.GameImpl.Map')

<a name='M-TinyLife-Objects-Particle-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2-'></a>
### Draw(time,batch,drawPos) `method`

##### Summary

Draws this particle on the current [Map](#P-TinyLife-Objects-Particle-Map 'TinyLife.Objects.Particle.Map'), at the current [Position](#F-TinyLife-Objects-Particle-Position 'TinyLife.Objects.Particle.Position').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in draw space, to draw this furniture at |

<a name='M-TinyLife-Objects-Particle-Spawn-TinyLife-Objects-Particle-'></a>
### Spawn(particle) `method`

##### Summary

Adds a new particle to the map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| particle | [TinyLife.Objects.Particle](#T-TinyLife-Objects-Particle 'TinyLife.Objects.Particle') | The particle to spawn |

<a name='M-TinyLife-Objects-Particle-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

The update method, which is called every update frame by the underlying [Map](#P-TinyLife-Objects-Particle-Map 'TinyLife.Objects.Particle.Map')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed since the last call |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's speed |

<a name='T-TinyLife-Actions-PathfindAction'></a>
## PathfindAction `type`

##### Namespace

TinyLife.Actions

##### Summary

A pathfinding action is an action that first finds a path and then allows that path to be traversed.
The pathfinding is done using [AStar2](#T-MLEM-Pathfinding-AStar2 'MLEM.Pathfinding.AStar2').

<a name='M-TinyLife-Actions-PathfindAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-TinyLife-Actions-PathfindAction-Path'></a>
### Path `property`

##### Summary

The path that this action has found.
WHen [OnPathReady](#M-TinyLife-Actions-PathfindAction-OnPathReady 'TinyLife.Actions.PathfindAction.OnPathReady') is called, this has a value.

<a name='P-TinyLife-Actions-PathfindAction-PathReady'></a>
### PathReady `property`

##### Summary

A property that determines whether or not the [Path](#P-TinyLife-Actions-PathfindAction-Path 'TinyLife.Actions.PathfindAction.Path') has been calculated.

<a name='M-TinyLife-Actions-PathfindAction-FindPath-Microsoft-Xna-Framework-Point-'></a>
### FindPath(goal) `method`

##### Summary

A method called by [Initialize](#M-TinyLife-Actions-PathfindAction-Initialize 'TinyLife.Actions.PathfindAction.Initialize') to start finding a path to the given goal location.

##### Returns

A task that, when finished, returns a path

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| goal | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The goal location |

<a name='M-TinyLife-Actions-PathfindAction-GetSpeed'></a>
### GetSpeed() `method`

##### Summary

Returns the speed that the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') should traverse with.

##### Returns

The speed

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-PathfindAction-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-PathfindAction-IsCompleted'></a>
### IsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-PathfindAction-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-PathfindAction-OnPathReady'></a>
### OnPathReady() `method`

##### Summary

This method is called when the [PathReady](#P-TinyLife-Actions-PathfindAction-PathReady 'TinyLife.Actions.PathfindAction.PathReady') variable is set to true.
At the point of this method being claled, [Path](#P-TinyLife-Actions-PathfindAction-Path 'TinyLife.Actions.PathfindAction.Path') will have a value.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-PathfindAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-PerSaveOptions'></a>
## PerSaveOptions `type`

##### Namespace

TinyLife

##### Summary

The game's per-save options, which are displayed in the [InitializeOptions](#M-TinyLife-Uis-Menus-InitializeOptions-MLEM-Ui-UiSystem,System-Boolean,System-Boolean- 'TinyLife.Uis.Menus.InitializeOptions(MLEM.Ui.UiSystem,System.Boolean,System.Boolean)') menu and saved to disk.
Note that [Instance](#P-TinyLife-PerSaveOptions-Instance 'TinyLife.PerSaveOptions.Instance') is null if there is no [Map](#P-TinyLife-GameImpl-Map 'TinyLife.GameImpl.Map') loaded.

<a name='F-TinyLife-PerSaveOptions-DisableAiHousehold'></a>
### DisableAiHousehold `constants`

##### Summary

Whether the AI of everyone in the [CurrentHousehold](#P-TinyLife-GameImpl-CurrentHousehold 'TinyLife.GameImpl.CurrentHousehold') should be disabled or not

<a name='F-TinyLife-PerSaveOptions-DisableAiSelected'></a>
### DisableAiSelected `constants`

##### Summary

Whether the AI of the [SelectedPerson](#P-TinyLife-Tools-PlayModeTool-SelectedPerson 'TinyLife.Tools.PlayModeTool.SelectedPerson') should be disabled or not

<a name='P-TinyLife-PerSaveOptions-Instance'></a>
### Instance `property`

##### Summary

The static singleton instance of [PerSaveOptions](#T-TinyLife-PerSaveOptions 'TinyLife.PerSaveOptions').
Note that this value is null if there is no [Map](#P-TinyLife-GameImpl-Map 'TinyLife.GameImpl.Map') loaded.

<a name='M-TinyLife-PerSaveOptions-Load-System-String-'></a>
### Load() `method`

##### Summary

Loads the options from the default options file path and stores them in [Instance](#P-TinyLife-PerSaveOptions-Instance 'TinyLife.PerSaveOptions.Instance').
If there are no options in the default options file, a new instance is created.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-PerSaveOptions-Save-System-String-'></a>
### Save() `method`

##### Summary

Applies the currently selected options of this instance to the game

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-Person'></a>
## Person `type`

##### Namespace

TinyLife.Objects

##### Summary

A person is a [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') placed on a [Map](#T-TinyLife-World-Map 'TinyLife.World.Map') that represents a person.
It stores its actions, clothes, data and movement.

<a name='M-TinyLife-Objects-Person-#ctor-TinyLife-World-Map,Microsoft-Xna-Framework-Vector2-'></a>
### #ctor(map,position) `constructor`

##### Summary

Creates a new person with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to place this person on |
| position | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to place this person on |

<a name='F-TinyLife-Objects-Person-ActionQueue'></a>
### ActionQueue `constants`

##### Summary

The actions that are currently enqueued to be executed by this person.
Each entry is the action that is enqueued along with a boolean value that represents whether this action was started automatically (true) or manually (false).
Use [EnqueueAction](#M-TinyLife-Objects-Person-EnqueueAction-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-Boolean,System-Nullable{TinyLife-Actions-ActionVariety},System-Boolean,System-Boolean- 'TinyLife.Objects.Person.EnqueueAction(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,System.Boolean,System.Nullable{TinyLife.Actions.ActionVariety},System.Boolean,System.Boolean)') and [CancelAction](#M-TinyLife-Objects-Person-CancelAction-TinyLife-Actions-Action,TinyLife-Actions-Action,System-Boolean- 'TinyLife.Objects.Person.CancelAction(TinyLife.Actions.Action,TinyLife.Actions.Action,System.Boolean)') to modify this list.

<a name='F-TinyLife-Objects-Person-Colors'></a>
### Colors `constants`

##### Summary

Obsolete, use [WornClothes](#F-TinyLife-Objects-Person-WornClothes 'TinyLife.Objects.Person.WornClothes') instead

<a name='F-TinyLife-Objects-Person-CurrentActions'></a>
### CurrentActions `constants`

##### Summary

The actions that are currently being executed by this person.
Use [EnqueueAction](#M-TinyLife-Objects-Person-EnqueueAction-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-Boolean,System-Nullable{TinyLife-Actions-ActionVariety},System-Boolean,System-Boolean- 'TinyLife.Objects.Person.EnqueueAction(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,System.Boolean,System.Nullable{TinyLife.Actions.ActionVariety},System.Boolean,System.Boolean)') and [CancelAction](#M-TinyLife-Objects-Person-CancelAction-TinyLife-Actions-Action,TinyLife-Actions-Action,System-Boolean- 'TinyLife.Objects.Person.CancelAction(TinyLife.Actions.Action,TinyLife.Actions.Action,System.Boolean)') to modify this list.

<a name='F-TinyLife-Objects-Person-CurrentPose'></a>
### CurrentPose `constants`

##### Summary

This person's current [Pose](#T-TinyLife-Objects-Person-Pose 'TinyLife.Objects.Person.Pose').
Note that this value is not saved to disk, and is reset to [Standing](#F-TinyLife-Objects-Person-Pose-Standing 'TinyLife.Objects.Person.Pose.Standing') every [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame.

<a name='F-TinyLife-Objects-Person-EmotionModifiers'></a>
### EmotionModifiers `constants`

##### Summary

The [Instance](#T-TinyLife-Emotions-EmotionModifier-Instance 'TinyLife.Emotions.EmotionModifier.Instance') objects that are currently applied to this person.
To access this collection efficiently, use [AddEmotion](#M-TinyLife-Objects-Person-AddEmotion-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan- 'TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)'), [RemoveEmotion](#M-TinyLife-Objects-Person-RemoveEmotion-TinyLife-Emotions-EmotionModifier- 'TinyLife.Objects.Person.RemoveEmotion(TinyLife.Emotions.EmotionModifier)') and [LowerEmotion](#M-TinyLife-Objects-Person-LowerEmotion-TinyLife-Emotions-EmotionType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.LowerEmotion(TinyLife.Emotions.EmotionType,System.Single,TinyLife.GameSpeed)').

<a name='F-TinyLife-Objects-Person-FirstName'></a>
### FirstName `constants`

##### Summary

This person's first name

<a name='F-TinyLife-Objects-Person-LastBedSleptIn'></a>
### LastBedSleptIn `constants`

##### Summary

The id of the last bed [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') that this person has slept in, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') if no such bed exists

<a name='F-TinyLife-Objects-Person-LastName'></a>
### LastName `constants`

##### Summary

This person's last name

<a name='F-TinyLife-Objects-Person-Layers'></a>
### Layers `constants`

##### Summary

Obsolete, use [WornClothes](#F-TinyLife-Objects-Person-WornClothes 'TinyLife.Objects.Person.WornClothes') instead

<a name='F-TinyLife-Objects-Person-Needs'></a>
### Needs `constants`

##### Summary

This person's [Need](#T-TinyLife-Need 'TinyLife.Need') data. When this person is instantiated, all of their needs are gathered from [Types](#F-TinyLife-NeedType-Types 'TinyLife.NeedType.Types') automatically.
To access this collection efficiently, use [GetNeed](#M-TinyLife-Objects-Person-GetNeed-TinyLife-NeedType- 'TinyLife.Objects.Person.GetNeed(TinyLife.NeedType)') and [GetNeedPercentage](#M-TinyLife-Objects-Person-GetNeedPercentage-TinyLife-NeedType- 'TinyLife.Objects.Person.GetNeedPercentage(TinyLife.NeedType)').

<a name='F-TinyLife-Objects-Person-PersonalityTypes'></a>
### PersonalityTypes `constants`

##### Summary

The names of the [PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType') values that this person has.
To access this collection efficiently, use [HasPersonality](#M-TinyLife-Objects-Person-HasPersonality-TinyLife-PersonalityType- 'TinyLife.Objects.Person.HasPersonality(TinyLife.PersonalityType)').

<a name='F-TinyLife-Objects-Person-Portrait'></a>
### Portrait `constants`

##### Summary

The [RenderTarget2D](#T-Microsoft-Xna-Framework-Graphics-RenderTarget2D 'Microsoft.Xna.Framework.Graphics.RenderTarget2D') that this person's portrait is rendered onto.
This will automatically be updated and can be used for rendering of any kind.

<a name='F-TinyLife-Objects-Person-Relationships'></a>
### Relationships `constants`

##### Summary

This person's [Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship') data.
To access this collection efficiently, use [GetRelationship](#M-TinyLife-Objects-Person-GetRelationship-TinyLife-Objects-Person,System-Boolean- 'TinyLife.Objects.Person.GetRelationship(TinyLife.Objects.Person,System.Boolean)') and [ChangeFriendship](#M-TinyLife-Objects-Person-ChangeFriendship-TinyLife-Objects-Person,System-Single- 'TinyLife.Objects.Person.ChangeFriendship(TinyLife.Objects.Person,System.Single)').

<a name='F-TinyLife-Objects-Person-Rotation'></a>
### Rotation `constants`

##### Summary

The [Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') that this person is currently facing in

<a name='F-TinyLife-Objects-Person-Skills'></a>
### Skills `constants`

##### Summary

This person's [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill') data.
To access this collection efficiently, use [GetSkill](#M-TinyLife-Objects-Person-GetSkill-TinyLife-Skills-SkillType- 'TinyLife.Objects.Person.GetSkill(TinyLife.Skills.SkillType)'), [GetSkillLevel](#M-TinyLife-Objects-Person-GetSkillLevel-TinyLife-Skills-SkillType- 'TinyLife.Objects.Person.GetSkillLevel(TinyLife.Skills.SkillType)') and [GainSkill](#M-TinyLife-Objects-Person-GainSkill-TinyLife-Skills-SkillType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)').

<a name='F-TinyLife-Objects-Person-WornLayers'></a>
### WornLayers `constants`

##### Summary

The [ClothesLayer](#T-TinyLife-Objects-ClothesLayer 'TinyLife.Objects.ClothesLayer') flags that represent what layers this person is currently wearing.
Note that this value is not saved to disk, and is reset to ~0 (every layer) every [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame.

<a name='P-TinyLife-Objects-Person-AllActions'></a>
### AllActions `property`

##### Summary

A concatenation of [CurrentActions](#F-TinyLife-Objects-Person-CurrentActions 'TinyLife.Objects.Person.CurrentActions') and [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue') that represents all actions that the current person has knowledge about

<a name='P-TinyLife-Objects-Person-CurrentEmote'></a>
### CurrentEmote `property`

##### Summary

The [Emote](#T-TinyLife-Actions-Emote 'TinyLife.Actions.Emote') that this person is currently displaying.
Use [DisplayEmote](#M-TinyLife-Objects-Person-DisplayEmote-TinyLife-Actions-EmoteCategory- 'TinyLife.Objects.Person.DisplayEmote(TinyLife.Actions.EmoteCategory)') to modify this property.

<a name='P-TinyLife-Objects-Person-CurrentRoom'></a>
### CurrentRoom `property`

##### Summary

The [Room](#T-TinyLife-World-Room 'TinyLife.World.Room') that this person is currently in

<a name='P-TinyLife-Objects-Person-CurrentRoomDecorativeRating'></a>
### CurrentRoomDecorativeRating `property`

##### Summary

The decorative rating of the [CurrentRoom](#P-TinyLife-Objects-Person-CurrentRoom 'TinyLife.Objects.Person.CurrentRoom'), resulting from the [DecorativeRating](#F-TinyLife-Objects-FurnitureType-TypeSettings-DecorativeRating 'TinyLife.Objects.FurnitureType.TypeSettings.DecorativeRating') of the contained furniture

<a name='P-TinyLife-Objects-Person-DrawSize'></a>
### DrawSize `property`

##### Summary

The size, in draw space pixels, that this person's texture takes up.
This is gathered from the [Body](#F-TinyLife-Objects-ClothesLayer-Body 'TinyLife.Objects.ClothesLayer.Body') layer of its texture data.

<a name='P-TinyLife-Objects-Person-EmoteTime'></a>
### EmoteTime `property`

##### Summary

The amount of time left for displaying [CurrentEmote](#P-TinyLife-Objects-Person-CurrentEmote 'TinyLife.Objects.Person.CurrentEmote').
Use [DisplayEmote](#M-TinyLife-Objects-Person-DisplayEmote-TinyLife-Actions-EmoteCategory- 'TinyLife.Objects.Person.DisplayEmote(TinyLife.Actions.EmoteCategory)') to modify this property.

<a name='P-TinyLife-Objects-Person-Emotion'></a>
### Emotion `property`

##### Summary

The [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') that this person currently has, resulting from their current [EmotionModifiers](#F-TinyLife-Objects-Person-EmotionModifiers 'TinyLife.Objects.Person.EmotionModifiers')

<a name='P-TinyLife-Objects-Person-FullName'></a>
### FullName `property`

##### Summary

This person's full name, which is a concatenation of their [FirstName](#F-TinyLife-Objects-Person-FirstName 'TinyLife.Objects.Person.FirstName') and [LastName](#F-TinyLife-Objects-Person-LastName 'TinyLife.Objects.Person.LastName').

<a name='P-TinyLife-Objects-Person-Household'></a>
### Household `property`

##### Summary

The [Household](#P-TinyLife-Objects-Person-Household 'TinyLife.Objects.Person.Household') that this person is a part of

<a name='P-TinyLife-Objects-Person-Job'></a>
### Job `property`

##### Summary

The [Job](#P-TinyLife-Objects-Person-Job 'TinyLife.Objects.Person.Job') that this person currently has.
To edit this value, use [SetJob](#M-TinyLife-Objects-Person-SetJob-TinyLife-Goals-JobType- 'TinyLife.Objects.Person.SetJob(TinyLife.Goals.JobType)').

<a name='P-TinyLife-Objects-Person-LastVisitedLot'></a>
### LastVisitedLot `property`

##### Summary

The [Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') that was last visited by this person.
A visited lot is a lot that was actively moved to using [VisitLotAction](#T-TinyLife-Actions-VisitLotAction 'TinyLife.Actions.VisitLotAction'), [GoHomeAction](#T-TinyLife-Actions-GoHomeAction 'TinyLife.Actions.GoHomeAction') or if the person is currently occupying this lot.
To modify this value, use [VisitLot](#M-TinyLife-Objects-Person-VisitLot-TinyLife-World-Lot- 'TinyLife.Objects.Person.VisitLot(TinyLife.World.Lot)').

<a name='P-TinyLife-Objects-Person-LotVisitCooldown'></a>
### LotVisitCooldown `property`

##### Summary

The amount of time that has to pass before this person can visit another lot.
If [LastVisitedLot](#P-TinyLife-Objects-Person-LastVisitedLot 'TinyLife.Objects.Person.LastVisitedLot') is set using [VisitLot](#M-TinyLife-Objects-Person-VisitLot-TinyLife-World-Lot- 'TinyLife.Objects.Person.VisitLot(TinyLife.World.Lot)'), this value will be set to 2 hours or 4 hours of in-game time, based on whether the visited lot is their home lot or not.

<a name='P-TinyLife-Objects-Person-OccupiedActionSpot'></a>
### OccupiedActionSpot `property`

##### Summary

The [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') of the [OccupiedFurniture](#P-TinyLife-Objects-Person-OccupiedFurniture 'TinyLife.Objects.Person.OccupiedFurniture') that this person is currently occupying.
Note that this value is not saved to disk, and is reset to null every [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame.
To edit this value, use [OccupyActionSpot](#M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})').

<a name='P-TinyLife-Objects-Person-OccupiedFurniture'></a>
### OccupiedFurniture `property`

##### Summary

The [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') that this person is currently occupying.
Note that this value is not saved to disk, and is reset to null every [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame.
To edit this value, use [OccupyActionSpot](#M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})').

<a name='P-TinyLife-Objects-Person-VisualPosition'></a>
### VisualPosition `property`

##### Summary

The visual position of this person, which, if nonnull, will override [Position](#P-TinyLife-Objects-MapObject-Position 'TinyLife.Objects.MapObject.Position') as the position that this person is looking to be in.
Note that the visual position does not affect collision detection or interactions.
Also note that this value is not saved to disk, and is reset to null every [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame.
To edit this value, use [OccupyActionSpot](#M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}- 'TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})').

<a name='M-TinyLife-Objects-Person-AddEmotion-TinyLife-Emotions-EmotionModifier,System-Int32,System-TimeSpan-'></a>
### AddEmotion(type,amount,time) `method`

##### Summary

Adds the given [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') with the given intensity and time

##### Returns

Whether the emotion could be added or it was already applied

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Emotions.EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') | The type of emotion to add |
| amount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The intensity of the emotion to add |
| time | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of in-game time the emotion should last for |

<a name='M-TinyLife-Objects-Person-CanWalkHere-TinyLife-World-Map,Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point-'></a>
### CanWalkHere(map,currPos,nextPos) `method`

##### Summary

Returns whether a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can walk between the `currPos` and the `nextPos`.
Note that, since method does not do any pathfinding, the two positions passed have to be adjacent or directly diagonal to each other.

##### Returns

Whether there is an obstruction (false) or the person can walk there (true)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map |
| currPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The current position |
| nextPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position that should be walked to |

<a name='M-TinyLife-Objects-Person-CancelAction-TinyLife-Actions-Action,TinyLife-Actions-Action,System-Boolean-'></a>
### CancelAction(action,cancelSource,force) `method`

##### Summary

Tries to cancel the given action, removing it from [CurrentActions](#F-TinyLife-Objects-Person-CurrentActions 'TinyLife.Objects.Person.CurrentActions') or [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue') in the process.
If the action in question cannot be canceled, this method returns false.

##### Returns

Whether the action could be canceled successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [TinyLife.Actions.Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') | The action to cancel |
| cancelSource | [TinyLife.Actions.Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action') | The action that is responsible for this cancelation, or null by default |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to cancel the action even if [CanCancel](#M-TinyLife-Actions-Action-CanCancel-TinyLife-Actions-Action- 'TinyLife.Actions.Action.CanCancel(TinyLife.Actions.Action)') returns false |

<a name='M-TinyLife-Objects-Person-ChangeFriendship-TinyLife-Objects-Person,System-Single-'></a>
### ChangeFriendship(person,amount) `method`

##### Summary

Changes the [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel')[Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship') wit the given person by the given amount.
Additionally, a friendship [Particle](#T-TinyLife-Objects-Particle 'TinyLife.Objects.Particle') is displayed and a [Notifications](#T-TinyLife-Uis-Notifications 'TinyLife.Uis.Notifications') is displayed if the friendship type changes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to change friendship with |
| amount | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount to change friendship by, can be negative |

<a name='M-TinyLife-Objects-Person-ChangeRomance-TinyLife-Objects-Person,System-Single-'></a>
### ChangeRomance(person,amount) `method`

##### Summary

Changes the [RomanceLevel](#P-TinyLife-Relationship-RomanceLevel 'TinyLife.Relationship.RomanceLevel')[Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship') wit the given person by the given amount.
Additionally, a romance [Particle](#T-TinyLife-Objects-Particle 'TinyLife.Objects.Particle') is displayed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to change romance with |
| amount | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount to change romance by, can be negative |

<a name='M-TinyLife-Objects-Person-CleanUpForDeletion'></a>
### CleanUpForDeletion() `method`

##### Summary

Cleans this person's data up to ready this person for deletion.
This removes the person from its [Household](#P-TinyLife-Objects-Person-Household 'TinyLife.Objects.Person.Household') and removes all [Relationships](#F-TinyLife-Objects-Person-Relationships 'TinyLife.Objects.Person.Relationships') from other people that are associated with this person.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-DepleteNeed-TinyLife-NeedType,System-Single,TinyLife-GameSpeed-'></a>
### DepleteNeed(type,amount,speed) `method`

##### Summary

Depletes this person's [Need](#T-TinyLife-Need 'TinyLife.Need') with the given [NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') by the given amount
Note that, when the "NoNeed" cheat is active, this method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The type of need to deplete |
| amount | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount to deplete the need by |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The speed that the need depletion should be influenced by |

<a name='M-TinyLife-Objects-Person-Die-TinyLife-Objects-Person-DeathReason,System-Boolean-'></a>
### Die(reason,createGravestone) `method`

##### Summary

Causes this person to die, removing it from the world and optionally spawning a [Gravestone](#F-TinyLife-Objects-FurnitureType-Gravestone 'TinyLife.Objects.FurnitureType.Gravestone').
Note thta this method's content is executed at the end of the current [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') frame, and not right away.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [TinyLife.Objects.Person.DeathReason](#T-TinyLife-Objects-Person-DeathReason 'TinyLife.Objects.Person.DeathReason') | The reason for this person's death |
| createGravestone | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to create a gravestone |

<a name='M-TinyLife-Objects-Person-DisplayEmote-TinyLife-Actions-EmoteCategory-'></a>
### DisplayEmote(possibleCategories) `method`

##### Summary

Causes this person to display a [Emote](#T-TinyLife-Actions-Emote 'TinyLife.Actions.Emote') over its head for 1 to 3 seconds

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| possibleCategories | [TinyLife.Actions.EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') | A combined flag that represents the categories to pick emotes from |

<a name='M-TinyLife-Objects-Person-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Nullable{Microsoft-Xna-Framework-Color}-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-DrawUi-Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Single-'></a>
### DrawUi(batch,pos,scale) `method`

##### Summary

Renders this person on a ui level rather than a world level

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in screen space, to draw at |
| scale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw with |

<a name='M-TinyLife-Objects-Person-EnqueueAction-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-Boolean,System-Nullable{TinyLife-Actions-ActionVariety},System-Boolean,System-Boolean-'></a>
### EnqueueAction(type,info,automatic,variety,priority,force) `method`

##### Summary

Enqueues the given action into [ActionQueue](#F-TinyLife-Objects-Person-ActionQueue 'TinyLife.Objects.Person.ActionQueue') to be executed later.

##### Returns

The created action, or null if the action cannot be executed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') | The type of action to enqueue |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action information |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is considered to have started automatically (or envoked by a player) |
| variety | [System.Nullable{TinyLife.Actions.ActionVariety}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{TinyLife.Actions.ActionVariety}') | The variety of the action to start, or null if this action has no varieties |
| priority | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to add this action to the start of the action queue rather than the end |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to start the action even if [CanExecute](#F-TinyLife-Actions-ActionType-TypeSettings-CanExecute 'TinyLife.Actions.ActionType.TypeSettings.CanExecute') returns false |

<a name='M-TinyLife-Objects-Person-FindPathAsync-Microsoft-Xna-Framework-Point,Microsoft-Xna-Framework-Point,MLEM-Pathfinding-AStar{Microsoft-Xna-Framework-Point}-GetCost,System-Nullable{System-Boolean}-'></a>
### FindPathAsync(start,goal,costFunction,allowDiagonals) `method`

##### Summary

Finds a path asynchronously using the A* pathfinding algorithm.
Note that the found path is not automatically embarked on.
Usually, this method should not be used, but [GoHereAction](#T-TinyLife-Actions-GoHereAction 'TinyLife.Actions.GoHereAction') should be used instead.

##### Returns

A task that, when completed, returns the path found or an empty stack if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The start tile position |
| goal | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The goal tile position |
| costFunction | [MLEM.Pathfinding.AStar{Microsoft.Xna.Framework.Point}.GetCost](#T-MLEM-Pathfinding-AStar{Microsoft-Xna-Framework-Point}-GetCost 'MLEM.Pathfinding.AStar{Microsoft.Xna.Framework.Point}.GetCost') | The function to use for determining the cost of tiles |
| allowDiagonals | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | Whether diagonal movement should be allowed |

<a name='M-TinyLife-Objects-Person-GainSkill-TinyLife-Skills-SkillType,System-Single,TinyLife-GameSpeed-'></a>
### GainSkill(type,amount,speed) `method`

##### Summary

Causes this person to gain the skill with the given [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') and raises it by the given amount.
Note that [PersonalityTypes](#F-TinyLife-Objects-Person-PersonalityTypes 'TinyLife.Objects.Person.PersonalityTypes') influence the skinn gain automatically.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') | The type of skill to gain |
| amount | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of skill points to gain |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The speed with which the skill gain should be influenced |

<a name='M-TinyLife-Objects-Person-GetCategories-TinyLife-Objects-Person-'></a>
### GetCategories() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-GetFreeTalkingSpot-TinyLife-Objects-Person-'></a>
### GetFreeTalkingSpot(personComingToMe) `method`

##### Summary

Returns an [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') for a location that this person can be talked to from.
This method returns the best possible location from [GetFreeTalkingSpots](#M-TinyLife-Objects-Person-GetFreeTalkingSpots 'TinyLife.Objects.Person.GetFreeTalkingSpots') as an [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo').

##### Returns

An action info representing a free talking spot, or null if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| personComingToMe | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that wants to talk to this person |

<a name='M-TinyLife-Objects-Person-GetFreeTalkingSpots'></a>
### GetFreeTalkingSpots() `method`

##### Summary

Returns a set of locations, in world space, that this person can be talked to from while standing in its current location

##### Returns

A set of free talking spots

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-GetHeldActionInfo'></a>
### GetHeldActionInfo() `method`

##### Summary

Returns a [ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') for the [GetHeldObject\`\`1](#M-TinyLife-Objects-Person-GetHeldObject``1 'TinyLife.Objects.Person.GetHeldObject``1'), or null if there is none.

##### Returns

The held action info

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-GetHeldObject``1'></a>
### GetHeldObject\`\`1() `method`

##### Summary

Returns the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') that this person is currently holding in their hands.
Note that, if the held object is not of the required type `T`, null is returned.

##### Returns

The held furniture

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the held furniture is expected to have |

<a name='M-TinyLife-Objects-Person-GetHomeLocation'></a>
### GetHomeLocation() `method`

##### Summary

Shorthand method for [GetHomeLocation](#M-TinyLife-World-Lot-GetHomeLocation-TinyLife-Objects-Person- 'TinyLife.World.Lot.GetHomeLocation(TinyLife.Objects.Person)') that returns the home location of this person's [Household](#P-TinyLife-Objects-Person-Household 'TinyLife.Objects.Person.Household')'s lot

##### Returns

This person's home location

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-GetHoverInfo'></a>
### GetHoverInfo() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-GetNeed-TinyLife-NeedType-'></a>
### GetNeed(type) `method`

##### Summary

Returns the [Need](#T-TinyLife-Need 'TinyLife.Need')[Value](#P-TinyLife-Need-Value 'TinyLife.Need.Value') of the given type for this person

##### Returns

This person's need value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The type of need that should be returned |

<a name='M-TinyLife-Objects-Person-GetNeedPercentage-TinyLife-NeedType-'></a>
### GetNeedPercentage(type) `method`

##### Summary

Returns the [Need](#T-TinyLife-Need 'TinyLife.Need')[Percentage](#P-TinyLife-Need-Percentage 'TinyLife.Need.Percentage') of the given type for this person

##### Returns

This person's need percentage

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The type of need that should be returned |

<a name='M-TinyLife-Objects-Person-GetRelationship-TinyLife-Objects-Person,System-Boolean-'></a>
### GetRelationship(person,initialize) `method`

##### Summary

Returns the current relationship level for the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person').
Note that this returns this person's [Relationships](#F-TinyLife-Objects-Person-Relationships 'TinyLife.Objects.Person.Relationships') entry, which might have different values from the passed [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')'s.

##### Returns

The relationship, or null if there is none and `initialize` is false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person to get relationship values for |
| initialize | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether a new relationship should be added to the relationships menu if no relationship exists yet |

<a name='M-TinyLife-Objects-Person-GetRelationshipType-TinyLife-Objects-Person-'></a>
### GetRelationshipType(person) `method`

##### Summary

Returns the [RelationshipType](#T-TinyLife-RelationshipType 'TinyLife.RelationshipType') that this person has to the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person').
This is a helper method that returns the relationship type of [GetRelationship](#M-TinyLife-Objects-Person-GetRelationship-TinyLife-Objects-Person,System-Boolean- 'TinyLife.Objects.Person.GetRelationship(TinyLife.Objects.Person,System.Boolean)'), or [Acquaintances](#F-TinyLife-RelationshipType-Acquaintances 'TinyLife.RelationshipType.Acquaintances') if there is no relationship.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') |  |

<a name='M-TinyLife-Objects-Person-GetSkillLevel-TinyLife-Skills-SkillType-'></a>
### GetSkillLevel(type) `method`

##### Summary

Returns the level of the [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill') of the given type that this person has.
If this person does not have the given skill, 0 is returned.

##### Returns

The person's skill level

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') | The type of skill to query |

<a name='M-TinyLife-Objects-Person-HasPersonality-TinyLife-PersonalityType-'></a>
### HasPersonality(type) `method`

##### Summary

Returns whether this person has the given [PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType')

##### Returns

true if this person has this personality type, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType') | The personality type to query |

<a name='M-TinyLife-Objects-Person-HasSkillLevel-TinyLife-Skills-SkillType,System-Int32-'></a>
### HasSkillLevel(type,level) `method`

##### Summary

Returns whether this person has a [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill') of the given type and whether its value is high enough.

##### Returns

true if the person has this skill level, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') | The type of skill to query |
| level | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The level that the skill has to be |

<a name='M-TinyLife-Objects-Person-Intersects-MLEM-Misc-RectangleF-'></a>
### Intersects() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-IsCloseForTalking-Microsoft-Xna-Framework-Vector2-'></a>
### IsCloseForTalking(pos) `method`

##### Summary

Returns true if `pos` is considered close enough for talking.
For a person to be close enough for talking, they have to be at least 0.25 and at most 2.5 tiles away.

##### Returns

Whether the person is close enough to talk to

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position of the person to query closeness for |

<a name='M-TinyLife-Objects-Person-LowerEmotion-TinyLife-Emotions-EmotionType,System-Single,TinyLife-GameSpeed-'></a>
### LowerEmotion(type,percentage,speed) `method`

##### Summary

Lowers any [EmotionModifiers](#F-TinyLife-Objects-Person-EmotionModifiers 'TinyLife.Objects.Person.EmotionModifiers') of the given [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') by the given percentage.
Each modifier's [Time](#P-TinyLife-Emotions-EmotionModifier-Instance-Time 'TinyLife.Emotions.EmotionModifier.Instance.Time') will be lowered by the percentage of their [TotalTime](#F-TinyLife-Emotions-EmotionModifier-Instance-TotalTime 'TinyLife.Emotions.EmotionModifier.Instance.TotalTime').

##### Returns

Whether the emotion could be lowered, or this person had no emotion modifiers of the given type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Emotions.EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') | The type of emotion to lower |
| percentage | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The percentage to lower the emotion by |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's current speed, or [Regular](#F-TinyLife-GameSpeed-Regular 'TinyLife.GameSpeed.Regular') by default |

<a name='M-TinyLife-Objects-Person-OccupyActionSpot-TinyLife-Objects-Furniture,TinyLife-Objects-ActionSpot,System-Boolean,System-Nullable{MLEM-Misc-Direction2}-'></a>
### OccupyActionSpot(furniture,spot,enterSpot,rotation) `method`

##### Summary

Causes the given action spot of the given furniture to be marked as occupied.
Optionally, the [VisualPosition](#P-TinyLife-Objects-Person-VisualPosition 'TinyLife.Objects.Person.VisualPosition') can also be changed, causing this person to look as if they were sitting, standing or laying on the furniture.
Note that the values set in this method are reset every [Update](#M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Objects.Person.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furniture to occupy |
| spot | [TinyLife.Objects.ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') | The action spot to occupy on the furniture |
| enterSpot | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the visual position should be updated to enter the spot |
| rotation | [System.Nullable{MLEM.Misc.Direction2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{MLEM.Misc.Direction2}') | The rotation that this person should get, or null to use the spot's default rotation |

<a name='M-TinyLife-Objects-Person-RemoveEmotion-TinyLife-Emotions-EmotionModifier-'></a>
### RemoveEmotion(type) `method`

##### Summary

Removes the given [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') from this person's [EmotionModifiers](#F-TinyLife-Objects-Person-EmotionModifiers 'TinyLife.Objects.Person.EmotionModifiers')

##### Returns

Whether the emotion could be removed (or wasn't contained in the first place)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Emotions.EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') | The type of emotion to remove |

<a name='M-TinyLife-Objects-Person-ResetToStatic-System-Boolean-'></a>
### ResetToStatic(resetRelationships) `method`

##### Summary

Resets this person to a static version of itself.
This action clears [AllActions](#P-TinyLife-Objects-Person-AllActions 'TinyLife.Objects.Person.AllActions'), clears the [LastVisitedLot](#P-TinyLife-Objects-Person-LastVisitedLot 'TinyLife.Objects.Person.LastVisitedLot'), resets all [Relationships](#F-TinyLife-Objects-Person-Relationships 'TinyLife.Objects.Person.Relationships') and restores all [Needs](#F-TinyLife-Objects-Person-Needs 'TinyLife.Objects.Person.Needs') to their default value.
This method is used by map and household ex- and imports.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resetRelationships | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not relationships should be reset or not |

<a name='M-TinyLife-Objects-Person-RestoreNeed-TinyLife-NeedType,System-Single,TinyLife-GameSpeed-'></a>
### RestoreNeed(type,amount,speed) `method`

##### Summary

Restores this person's [Need](#T-TinyLife-Need 'TinyLife.Need') of the given type by the given amount

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.NeedType](#T-TinyLife-NeedType 'TinyLife.NeedType') | The type of need to restore |
| amount | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount to restore this need by |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The speed that the need gain should be influenced by |

<a name='M-TinyLife-Objects-Person-SetHeldObject-TinyLife-Objects-Furniture-'></a>
### SetHeldObject(furniture) `method`

##### Summary

Sets this person's held object to the given instance.
Note that this resets the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture')'s position to -1, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| furniture | [TinyLife.Objects.Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') | The furniture to hold |

<a name='M-TinyLife-Objects-Person-SetHeldObject``1-TinyLife-Objects-FurnitureType,System-Int32[],System-Nullable{System-Guid}-'></a>
### SetHeldObject\`\`1(type,colors,id) `method`

##### Summary

Sets the person's held object to the given furniture type, with the given data, and returns the created instance.

##### Returns

The created furniture instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Objects.FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType') | The type of furniture to construct |
| colors | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The colors that the constructed furniture should have, or null to use the defaults |
| id | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | The id that this furniture should have, or null to choose a random one |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the created furniture is expected to have |

<a name='M-TinyLife-Objects-Person-SetJob-TinyLife-Goals-JobType-'></a>
### SetJob(type) `method`

##### Summary

Sets this person's current [Job](#P-TinyLife-Objects-Person-Job 'TinyLife.Objects.Person.Job').
If null is passed, the person's job gets removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Goals.JobType](#T-TinyLife-Goals-JobType 'TinyLife.Goals.JobType') | The job to start |

<a name='M-TinyLife-Objects-Person-StopEmoting'></a>
### StopEmoting() `method`

##### Summary

Causes this person to stop displaying the current emote immediately

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-ToCreatedByString'></a>
### ToCreatedByString() `method`

##### Summary

Returns a string representation of this person using the localized "Created by:" prefix

##### Returns

A "created by" string

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-Validate'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-Person-VisitLot-TinyLife-World-Lot-'></a>
### VisitLot(lot) `method`

##### Summary

Marks the given lot as visited, setting [LotVisitCooldown](#P-TinyLife-Objects-Person-LotVisitCooldown 'TinyLife.Objects.Person.LotVisitCooldown') to 4 hours if the lot is the person's home lot, and 2 otherwise
The passed lot is additionally marked as visible using [MarkLotVisible](#M-TinyLife-World-Household-MarkLotVisible-TinyLife-World-Lot- 'TinyLife.World.Household.MarkLotVisible(TinyLife.World.Lot)'),

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lot | [TinyLife.World.Lot](#T-TinyLife-World-Lot 'TinyLife.World.Lot') | The lot to mark as visited |

<a name='T-TinyLife-Objects-PersonAi'></a>
## PersonAi `type`

##### Namespace

TinyLife.Objects

##### Summary

This class holds the artificial intelligence implementation for a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person').
The AI automatically selects actions based on their [AiSettings](#T-TinyLife-Actions-ActionType-AiSettings 'TinyLife.Actions.ActionType.AiSettings').

<a name='T-TinyLife-PersonalityType'></a>
## PersonalityType `type`

##### Namespace

TinyLife

##### Summary

A personality type is a trait that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have.
Each personality type is meant to influence the person's behavior and abilities slightly in a certain way.

<a name='M-TinyLife-PersonalityType-#ctor-System-String,MLEM-Textures-TextureRegion,TinyLife-PersonalityType[]-'></a>
### #ctor(name,texture,disallowedOthers) `constructor`

##### Summary

Creates a new personality type with the given name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this personality type |
| texture | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The icon texture for this personality type |
| disallowedOthers | [TinyLife.PersonalityType[]](#T-TinyLife-PersonalityType[] 'TinyLife.PersonalityType[]') | A set of personality types that cannot be applied together with this one |

<a name='F-TinyLife-PersonalityType-AmountPerPerson'></a>
### AmountPerPerson `constants`

##### Summary

The amount of personality types that each [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have

<a name='F-TinyLife-PersonalityType-DisallowedOthers'></a>
### DisallowedOthers `constants`

##### Summary

A set of personality types that cannot be applied together with this one

<a name='F-TinyLife-PersonalityType-Name'></a>
### Name `constants`

##### Summary

The name of this personality type.
As this is used for [Types](#F-TinyLife-PersonalityType-Types 'TinyLife.PersonalityType.Types'), this name needs to be unique across all installed mods.

<a name='F-TinyLife-PersonalityType-Texture'></a>
### Texture `constants`

##### Summary

The icon texture for this personality type

<a name='F-TinyLife-PersonalityType-Types'></a>
### Types `constants`

##### Summary

A registry of all of the personality types in the game.
Use [Register](#M-TinyLife-PersonalityType-Register-TinyLife-PersonalityType- 'TinyLife.PersonalityType.Register(TinyLife.PersonalityType)') to register custom personality types.

<a name='M-TinyLife-PersonalityType-Register-TinyLife-PersonalityType-'></a>
### Register(type) `method`

##### Summary

Registers this personality type to the [Types](#F-TinyLife-PersonalityType-Types 'TinyLife.PersonalityType.Types') registry

##### Returns

The personality type, for chaining

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType') | The personality type to register |

<a name='T-TinyLife-Tools-PlayModeTool'></a>
## PlayModeTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-PlayModeTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-TinyLife-Tools-PlayModeTool-SelectedPerson'></a>
### SelectedPerson `property`

##### Summary

Stores the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that is currently selected

<a name='M-TinyLife-Tools-PlayModeTool-Closed'></a>
### Closed() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-PlayModeTool-Opened'></a>
### Opened() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-PlayModeTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Objects-Person-Pose'></a>
## Pose `type`

##### Namespace

TinyLife.Objects.Person

##### Summary

An enumeration that represents a set of poses that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can display

<a name='F-TinyLife-Objects-Person-Pose-Laying'></a>
### Laying `constants`

##### Summary

A pose that represents a person who is lying down.
Note that the default textures for this pose only contain the upper body and head.

<a name='F-TinyLife-Objects-Person-Pose-Sitting'></a>
### Sitting `constants`

##### Summary

A pose that represents a sitting person

<a name='F-TinyLife-Objects-Person-Pose-SittingLegsClose'></a>
### SittingLegsClose `constants`

##### Summary

A pose that represents a person who is sitting, but with their legs close to their body.
This pose is mainly used for the "passed out" stance.

<a name='F-TinyLife-Objects-Person-Pose-Standing'></a>
### Standing `constants`

##### Summary

A pose that represents a standing person

<a name='F-TinyLife-Objects-Person-Pose-Walking'></a>
### Walking `constants`

##### Summary

A pose that represents a person animated to look like they're walking

<a name='F-TinyLife-Objects-Person-Pose-WorkingSitting'></a>
### WorkingSitting `constants`

##### Summary

A pose that represents a person who is sitting and working on something

<a name='F-TinyLife-Objects-Person-Pose-WorkingStanding'></a>
### WorkingStanding `constants`

##### Summary

A pose that represents a person who is standing and working on something

<a name='T-TinyLife-Skills-Quality'></a>
## Quality `type`

##### Namespace

TinyLife.Skills

##### Summary

An enumeration for qualitites of objects like [CustomPainting](#F-TinyLife-Objects-FurnitureType-CustomPainting 'TinyLife.Objects.FurnitureType.CustomPainting').
To receive a random quality based on a person's [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill') level, use [GetRandomQuality](#M-TinyLife-Skills-SkillType-GetRandomQuality-TinyLife-Objects-Person,System-Random,System-Boolean,System-Boolean- 'TinyLife.Skills.SkillType.GetRandomQuality(TinyLife.Objects.Person,System.Random,System.Boolean,System.Boolean)').

<a name='F-TinyLife-Skills-Quality-Average'></a>
### Average `constants`

##### Summary

A quality for objects that have an average quality

<a name='F-TinyLife-Skills-Quality-Good'></a>
### Good `constants`

##### Summary

A quality for objects that have good quality

<a name='F-TinyLife-Skills-Quality-Great'></a>
### Great `constants`

##### Summary

A quality for objects that have great quality

<a name='F-TinyLife-Skills-Quality-Masterpiece'></a>
### Masterpiece `constants`

##### Summary

A quality for objects that are masterpieces.
When an object with this quality is created, a [Notifications](#T-TinyLife-Uis-Notifications 'TinyLife.Uis.Notifications') notification should be displayed to the user

<a name='F-TinyLife-Skills-Quality-Perfect'></a>
### Perfect `constants`

##### Summary

A quality for objects that are considered perfect

<a name='F-TinyLife-Skills-Quality-Terrible'></a>
### Terrible `constants`

##### Summary

A quality for objects that are terrible

<a name='T-TinyLife-Relationship'></a>
## Relationship `type`

##### Namespace

TinyLife

##### Summary

A relationship is a connection between two [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') objects.
It should be noted that a relationship is not always the same between a person and the linked [OtherPerson](#P-TinyLife-Relationship-OtherPerson 'TinyLife.Relationship.OtherPerson').
What this means is that A can have a good relationship to B, but B can have a less good relationship to A.

<a name='M-TinyLife-Relationship-#ctor-System-Guid-'></a>
### #ctor(otherPerson) `constructor`

##### Summary

Creates a new relationship to the given other person

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| otherPerson | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The other person |

<a name='F-TinyLife-Relationship-Dating'></a>
### Dating `constants`

##### Summary

This value is set to true if this relationship is a romantic relationship

<a name='F-TinyLife-Relationship-Genealogy'></a>
### Genealogy `constants`

##### Summary

The [GenealogyType](#T-TinyLife-GenealogyType 'TinyLife.GenealogyType') of this relationship.
Note that the genealogy's value works in the following direction: "I am the [Genealogy] of [OtherPerson]".
Note that [OtherPerson](#P-TinyLife-Relationship-OtherPerson 'TinyLife.Relationship.OtherPerson') will always have the [GenealogyType](#T-TinyLife-GenealogyType 'TinyLife.GenealogyType')'s [GetOpposite](#M-TinyLife-Utilities-Extensions-GetOpposite-TinyLife-GenealogyType- 'TinyLife.Utilities.Extensions.GetOpposite(TinyLife.GenealogyType)').

<a name='F-TinyLife-Relationship-Max'></a>
### Max `constants`

##### Summary

The maximum value that a relationship level can have

<a name='F-TinyLife-Relationship-PassiveFriendReduction'></a>
### PassiveFriendReduction `constants`

##### Summary

The amount of points (out of [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max')) that are removed from each relationship's [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel') each update frame

<a name='F-TinyLife-Relationship-PassiveRomanceReduction'></a>
### PassiveRomanceReduction `constants`

##### Summary

The amount of points (out of [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max')) that are removed from each relationship's [RomanceLevel](#P-TinyLife-Relationship-RomanceLevel 'TinyLife.Relationship.RomanceLevel') each update frame

<a name='P-TinyLife-Relationship-DisplayString'></a>
### DisplayString `property`

##### Summary

An (unlocalized) string that represents a written version of this relationship's status.
If [Dating](#F-TinyLife-Relationship-Dating 'TinyLife.Relationship.Dating') is true, the string "Dating" will be returned. Otherwise, [Type](#P-TinyLife-Relationship-Type 'TinyLife.Relationship.Type') is returned as a string.

<a name='P-TinyLife-Relationship-FriendLevel'></a>
### FriendLevel `property`

##### Summary

The current amount of friendship points (out of [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max')) that this relationship has.
This value is automatically clamped between -[Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max') and [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max').

<a name='P-TinyLife-Relationship-FriendPercentage'></a>
### FriendPercentage `property`

##### Summary

The [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel') of this relationship, divided by [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max'), yielding a percentage between -1 and 1 of how good this friendship is

<a name='P-TinyLife-Relationship-OtherPerson'></a>
### OtherPerson `property`

##### Summary

The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') of the person that this relationship is linked to

<a name='P-TinyLife-Relationship-RomanceLevel'></a>
### RomanceLevel `property`

##### Summary

The current amount of romance points (out of [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max')) that this relationship has.
This value is automatically clamped between 0 and [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max').

<a name='P-TinyLife-Relationship-RomancePercentage'></a>
### RomancePercentage `property`

##### Summary

The [RomanceLevel](#P-TinyLife-Relationship-RomanceLevel 'TinyLife.Relationship.RomanceLevel') of this relationship, divided by [Max](#F-TinyLife-Relationship-Max 'TinyLife.Relationship.Max'), yielding a percentage between 0 and 1 of how good this relationship's romance level is

<a name='P-TinyLife-Relationship-Type'></a>
### Type `property`

##### Summary

The [RelationshipType](#T-TinyLife-RelationshipType 'TinyLife.RelationshipType') that this relationship has, based on the current [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel').

<a name='T-TinyLife-RelationshipType'></a>
## RelationshipType `type`

##### Namespace

TinyLife

##### Summary

An enumeration type that represents the type that a [Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship') can have

<a name='F-TinyLife-RelationshipType-Acquaintances'></a>
### Acquaintances `constants`

##### Summary

A relationship type that represents two people that don't know each other well

<a name='F-TinyLife-RelationshipType-Disliked'></a>
### Disliked `constants`

##### Summary

A relationship type that represents two people that dislike each other

<a name='F-TinyLife-RelationshipType-Enemies'></a>
### Enemies `constants`

##### Summary

A relationship type that represents two people that hate each other

<a name='F-TinyLife-RelationshipType-Friends'></a>
### Friends `constants`

##### Summary

A relationship type that represents two people that know each other well

<a name='F-TinyLife-RelationshipType-GoodFriends'></a>
### GoodFriends `constants`

##### Summary

A relationship type that represents two people that know each other very well

<a name='T-TinyLife-Tools-RemoveTool'></a>
## RemoveTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-RemoveTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-RemoveTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RemoveTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RemoveTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RemoveTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-Roof'></a>
## Roof `type`

##### Namespace

TinyLife.World

##### Summary

A roof is an object on a [Map](#T-TinyLife-World-Map 'TinyLife.World.Map') that is on a higher level and cannot be interacted with by people

<a name='M-TinyLife-World-Roof-#ctor-TinyLife-World-RoofType,Microsoft-Xna-Framework-Rectangle,MLEM-Misc-Direction2,System-Int32-'></a>
### #ctor(type,area,rotation,color) `constructor`

##### Summary

Creates a new roof with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.World.RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType') | The type of the roof |
| area | [Microsoft.Xna.Framework.Rectangle](#T-Microsoft-Xna-Framework-Rectangle 'Microsoft.Xna.Framework.Rectangle') | The area that this roof covers |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | This roof's rotation |
| color | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The color that this roof's wallpaper should have |

<a name='F-TinyLife-World-Roof-Area'></a>
### Area `constants`

##### Summary

The area that this roof covers

<a name='F-TinyLife-World-Roof-Color'></a>
### Color `constants`

##### Summary

The color index in in [WarmDark](#F-TinyLife-Utilities-ColorScheme-WarmDark 'TinyLife.Utilities.ColorScheme.WarmDark') that this roof uses for its top

<a name='F-TinyLife-World-Roof-Type'></a>
### Type `constants`

##### Summary

The [RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType') that this roof has

<a name='F-TinyLife-World-Roof-Wallpaper'></a>
### Wallpaper `constants`

##### Summary

The [Wallpaper](#F-TinyLife-World-Roof-Wallpaper 'TinyLife.World.Roof.Wallpaper') that is applied to this roof.
This defaults to the Default wallpaper.

<a name='P-TinyLife-World-Roof-Rotation'></a>
### Rotation `property`

##### Summary

The rotation that this roof has.
This is only relevant for roofs that don't have the [Flat](#F-TinyLife-World-RoofType-Flat 'TinyLife.World.RoofType.Flat') type.

<a name='M-TinyLife-World-Roof-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,TinyLife-World-Map,TinyLife-World-RoofType,Microsoft-Xna-Framework-Rectangle,MLEM-Misc-Direction2,System-Int32,TinyLife-World-Wallpaper,System-Single-'></a>
### Draw(time,batch,map,type,area,rotation,colorIndex,wallpaper,depthOffset) `method`

##### Summary

Draws the given [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') in world space

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's current time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to draw on |
| type | [TinyLife.World.RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType') | The type of roof to draw |
| area | [Microsoft.Xna.Framework.Rectangle](#T-Microsoft-Xna-Framework-Rectangle 'Microsoft.Xna.Framework.Rectangle') | The area the roof covers |
| rotation | [MLEM.Misc.Direction2](#T-MLEM-Misc-Direction2 'MLEM.Misc.Direction2') | The roof's rotation |
| colorIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The color index in [WarmDark](#F-TinyLife-Utilities-ColorScheme-WarmDark 'TinyLife.Utilities.ColorScheme.WarmDark') |
| wallpaper | [TinyLife.World.Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') | The wallpaper applied to the roof |
| depthOffset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The value that should be added to the depth of this roof |

<a name='M-TinyLife-World-Roof-DrawUi-Microsoft-Xna-Framework-Graphics-SpriteBatch,MLEM-Ui-Elements-Element,TinyLife-World-RoofType,System-Int32,System-Single-'></a>
### DrawUi(batch,element,type,colorIndex,drawScale) `method`

##### Summary

Draws a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') in ui space, only drawing a 1x1 area of it

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| element | [MLEM.Ui.Elements.Element](#T-MLEM-Ui-Elements-Element 'MLEM.Ui.Elements.Element') | The element to draw the roof on |
| type | [TinyLife.World.RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType') | The type of roof to draw |
| colorIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The color index in [WarmDark](#F-TinyLife-Utilities-ColorScheme-WarmDark 'TinyLife.Utilities.ColorScheme.WarmDark') |
| drawScale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw the roof with |

<a name='M-TinyLife-World-Roof-GenerateRoof-TinyLife-World-Room-'></a>
### GenerateRoof(room) `method`

##### Summary

Generates the roofing for the given [Room](#T-TinyLife-World-Room 'TinyLife.World.Room') and adds it to the map.
The generated roofing is split into as few separate parts as possible by ordering the tiles the room covers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| room | [TinyLife.World.Room](#T-TinyLife-World-Room 'TinyLife.World.Room') | The room to add roofing to |

<a name='M-TinyLife-World-Roof-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Roof-GetPriceByType-TinyLife-World-RoofType-'></a>
### GetPriceByType(type) `method`

##### Summary

Returns the price of the given [RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType')

##### Returns

The price for the roof type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.World.RoofType](#T-TinyLife-World-RoofType 'TinyLife.World.RoofType') | The type of roof to query |

<a name='T-TinyLife-Tools-RoofTool'></a>
## RoofTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-RoofTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-RoofTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RoofTool-ForceWallsUp'></a>
### ForceWallsUp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RoofTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RoofTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-RoofTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-RoofType'></a>
## RoofType `type`

##### Namespace

TinyLife.World

##### Summary

An enumeration that represents the various types that a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') can have

<a name='F-TinyLife-World-RoofType-Flat'></a>
### Flat `constants`

##### Summary

A flat roof that no [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') is attached to

<a name='F-TinyLife-World-RoofType-Gable'></a>
### Gable `constants`

##### Summary

A gabled roof that becomes higher the longer it is, and that [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') can be attached to

<a name='T-TinyLife-World-Room'></a>
## Room `type`

##### Namespace

TinyLife.World

##### Summary

A room is an area on a [Map](#F-TinyLife-World-Room-Map 'TinyLife.World.Room.Map') that is surrounded by [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') objects

<a name='F-TinyLife-World-Room-Center'></a>
### Center `constants`

##### Summary

The position that is considered to be the center of this room.
This is the average of all of its covered [Tiles](#F-TinyLife-World-Room-Tiles 'TinyLife.World.Room.Tiles'), and the [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection') that this room is on is determined by this value.

<a name='F-TinyLife-World-Room-CoveredSections'></a>
### CoveredSections `constants`

##### Summary

A set of [MapSection](#T-TinyLife-World-MapSection 'TinyLife.World.MapSection') instances that are covered by this room

<a name='F-TinyLife-World-Room-Map'></a>
### Map `constants`

##### Summary

The map that this room is on

<a name='F-TinyLife-World-Room-Tiles'></a>
### Tiles `constants`

##### Summary

A set of [Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') positions on the [Map](#F-TinyLife-World-Room-Map 'TinyLife.World.Room.Map') that are contained in this room

<a name='M-TinyLife-World-Room-GetConnectedRooms'></a>
### GetConnectedRooms() `method`

##### Summary

Returns a set of [Room](#T-TinyLife-World-Room 'TinyLife.World.Room') objects which are connected to this room.
A connected room is a room that is directly adjacent, and that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can walk into through an [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening').

##### Returns

A set of connected rooms

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Room-GetDecorativeRating'></a>
### GetDecorativeRating() `method`

##### Summary

Returns the combined decorative rating of all of the [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') in this room.
This method uses the [DecorativeRating](#F-TinyLife-Objects-FurnitureType-TypeSettings-DecorativeRating 'TinyLife.Objects.FurnitureType.TypeSettings.DecorativeRating') function.

##### Returns

The combined decorative rating

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Room-GetObjects``1'></a>
### GetObjects\`\`1() `method`

##### Summary

Returns all of the [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') instances that are contained in this room

##### Returns

All of the objects in this room

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Room-GetWalls-System-Boolean-'></a>
### GetWalls(borderOnly) `method`

##### Summary

Returns all of the [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') instances that are border walls or internal walls of this room.
An internal wall is a wall for which both sides are contained in the room, rather than just one.

##### Returns

A set of walls and their included sides of this room

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| borderOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to return border walls only, or include internal walls |

<a name='M-TinyLife-World-Room-IsFullyRoofed'></a>
### IsFullyRoofed() `method`

##### Summary

Returns whether or not this room has a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') on all of its [Tiles](#F-TinyLife-World-Room-Tiles 'TinyLife.World.Room.Tiles')

##### Returns

Whether or not this room is fully roofed

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Room-IsSameRoom-System-Collections-Generic-ICollection{Microsoft-Xna-Framework-Point}-'></a>
### IsSameRoom(tiles) `method`

##### Summary

Returns whether this room has the same covered [Tiles](#F-TinyLife-World-Room-Tiles 'TinyLife.World.Room.Tiles') as the given collection

##### Returns

true if the covered tiles are the same, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tiles | [System.Collections.Generic.ICollection{Microsoft.Xna.Framework.Point}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{Microsoft.Xna.Framework.Point}') | The tiles to query |

<a name='M-TinyLife-World-Room-Validate'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.

##### Returns

false if the object is not valid, true otherwise

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-SellAction'></a>
## SellAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-SellAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,System-Single-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-SellAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SellAction-AndThenIsCompleted'></a>
### AndThenIsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SellAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SellAction-GetSoldObject``1-TinyLife-Actions-ActionInfo-'></a>
### GetSoldObject\`\`1(info) `method`

##### Summary

A helper method that returns the object that is being sold.
This method returns the action object or the person's held object.

##### Returns

The object, or null if there is none or it doesn't match the type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type that the object is expected to be |

<a name='T-TinyLife-Actions-SitAction'></a>
## SitAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-SitAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-SitAction-AndThenInitialize'></a>
### AndThenInitialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SitAction-AndThenIsCompleted'></a>
### AndThenIsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SitAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### AndThenUpdate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SitAction-CanMultitask-TinyLife-Actions-Action-'></a>
### CanMultitask() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SitAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-SitAtDeskObjectAction'></a>
## SitAtDeskObjectAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-SitAtDeskObjectAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-SitAtDeskObjectAction-AndThenUpdate-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### AndThenUpdate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SitAtDeskObjectAction-CreateFirstActions'></a>
### CreateFirstActions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SitAtDeskObjectAction-GetChair-TinyLife-Actions-ActionInfo-'></a>
### GetChair(info) `method`

##### Summary

Helper method that returns [GetChair](#M-TinyLife-Actions-SitAtDeskObjectAction-GetChair-TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SitAtDeskObjectAction.GetChair(TinyLife.Actions.ActionInfo)') for the action object of the given action info.

##### Returns

The chair

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |

<a name='M-TinyLife-Actions-SitAtDeskObjectAction-GetChairSpot-TinyLife-Actions-ActionInfo-'></a>
### GetChairSpot(info) `method`

##### Summary

Helper method that returns the first valid action spot of the chair returned in [GetChair](#M-TinyLife-Actions-SitAtDeskObjectAction-GetChair-TinyLife-Actions-ActionInfo- 'TinyLife.Actions.SitAtDeskObjectAction.GetChair(TinyLife.Actions.ActionInfo)')

##### Returns

An action info, or null if there is none or there is no chair

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |

<a name='M-TinyLife-Actions-SitAtDeskObjectAction-GetNextAction-TinyLife-Actions-Action-CompletionType-'></a>
### GetNextAction() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Skills-Skill'></a>
## Skill `type`

##### Namespace

TinyLife.Skills

##### Summary

A skill is an ability that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have which influences their behavior in some way.
Skill instances are created from their corresponding [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType').

<a name='M-TinyLife-Skills-Skill-#ctor-TinyLife-Skills-SkillType-'></a>
### #ctor(type) `constructor`

##### Summary

Creates a new skill instance from the given [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') | The type of skill to construct |

<a name='F-TinyLife-Skills-Skill-Type'></a>
### Type `constants`

##### Summary

The underlying [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') that this skill instance originates from

<a name='P-TinyLife-Skills-Skill-Level'></a>
### Level `property`

##### Summary

The current level of this skill. Note that this value never goes beyond [MaxLevel](#F-TinyLife-Skills-SkillType-MaxLevel 'TinyLife.Skills.SkillType.MaxLevel').
To modify this value, use [Gain](#M-TinyLife-Skills-Skill-Gain-TinyLife-Objects-Person,System-Single- 'TinyLife.Skills.Skill.Gain(TinyLife.Objects.Person,System.Single)') or [GainSkill](#M-TinyLife-Objects-Person-GainSkill-TinyLife-Skills-SkillType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)').

<a name='P-TinyLife-Skills-Skill-PointPercentage'></a>
### PointPercentage `property`

##### Summary

The percentage of [PointsToNextLevel](#P-TinyLife-Skills-Skill-PointsToNextLevel 'TinyLife.Skills.Skill.PointsToNextLevel') out of the required [GetRequiredPointsToNextLevel](#M-TinyLife-Skills-Skill-GetRequiredPointsToNextLevel 'TinyLife.Skills.Skill.GetRequiredPointsToNextLevel').
Obviously, this value goes between 0 and 1.

<a name='P-TinyLife-Skills-Skill-PointsToNextLevel'></a>
### PointsToNextLevel `property`

##### Summary

The amount of skill points that are required until the next [Level](#P-TinyLife-Skills-Skill-Level 'TinyLife.Skills.Skill.Level') is reached.
To modify this value, use [Gain](#M-TinyLife-Skills-Skill-Gain-TinyLife-Objects-Person,System-Single- 'TinyLife.Skills.Skill.Gain(TinyLife.Objects.Person,System.Single)') or [GainSkill](#M-TinyLife-Objects-Person-GainSkill-TinyLife-Skills-SkillType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)').

<a name='M-TinyLife-Skills-Skill-Gain-TinyLife-Objects-Person,System-Single-'></a>
### Gain(person,amount) `method`

##### Summary

Causes the given person to gain a certain amount of points of this skill.
Note that [GainSkill](#M-TinyLife-Objects-Person-GainSkill-TinyLife-Skills-SkillType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.GainSkill(TinyLife.Skills.SkillType,System.Single,TinyLife.GameSpeed)') is preferred to this method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that has this skill |
| amount | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount to gain the skill by |

<a name='M-TinyLife-Skills-Skill-GetRequiredPointsToNextLevel'></a>
### GetRequiredPointsToNextLevel() `method`

##### Summary

Returns the amount of skill points that is required to reach the next level.
This value is depenedent on the current [Level](#P-TinyLife-Skills-Skill-Level 'TinyLife.Skills.Skill.Level'), meaning higher skill levels are harder to reach.

##### Returns

The points required for the next level

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Skills-SkillCategory'></a>
## SkillCategory `type`

##### Namespace

TinyLife.Skills

##### Summary

A flag enumeration that determines the categories that a [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') has

<a name='F-TinyLife-Skills-SkillCategory-Creative'></a>
### Creative `constants`

##### Summary

A skill category for skills that require creativity.
Skills in this category are boosted by the [Creative](#F-TinyLife-PersonalityType-Creative 'TinyLife.PersonalityType.Creative') personality type.

<a name='F-TinyLife-Skills-SkillCategory-Logical'></a>
### Logical `constants`

##### Summary

A skill category for skills that require logical thinking

<a name='F-TinyLife-Skills-SkillCategory-None'></a>
### None `constants`

##### Summary

A skill category for skills that fit into none of the other categories

<a name='F-TinyLife-Skills-SkillCategory-Social'></a>
### Social `constants`

##### Summary

A skill category for skills that are related to social interaction.
Skills in this category are boosted by the [Likeable](#F-TinyLife-PersonalityType-Likeable 'TinyLife.PersonalityType.Likeable') and [Mean](#F-TinyLife-PersonalityType-Mean 'TinyLife.PersonalityType.Mean') personality types.

<a name='T-TinyLife-Skills-SkillType'></a>
## SkillType `type`

##### Namespace

TinyLife.Skills

##### Summary

A skill is an ability that a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') can have which influences their behavior in some way.
The SkillType class contains underlying data for a [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill') instance, like its name and maximum level.

<a name='M-TinyLife-Skills-SkillType-#ctor-System-String,MLEM-Textures-TextureRegion,System-Int32,TinyLife-Skills-SkillCategory-'></a>
### #ctor(name,texture,maxLevel,categories) `constructor`

##### Summary

Creates a new skill type with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The skill's name |
| texture | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The skill's icon |
| maxLevel | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The skill's maximum level. Should be 5 or 10 for consistency. |
| categories | [TinyLife.Skills.SkillCategory](#T-TinyLife-Skills-SkillCategory 'TinyLife.Skills.SkillCategory') | A combined flag of categories that this skill has |

<a name='F-TinyLife-Skills-SkillType-Categories'></a>
### Categories `constants`

##### Summary

The [SkillCategory](#T-TinyLife-Skills-SkillCategory 'TinyLife.Skills.SkillCategory') combined flag that this skill type has.
The skill categories it has are used to determine skill gain from things like the [Creative](#F-TinyLife-PersonalityType-Creative 'TinyLife.PersonalityType.Creative') personality type.

<a name='F-TinyLife-Skills-SkillType-MaxLevel'></a>
### MaxLevel `constants`

##### Summary

The maximum level that this skill can reach.
Most skills should default to 5 or 10 for consistency.

<a name='F-TinyLife-Skills-SkillType-Name'></a>
### Name `constants`

##### Summary

The name of this skill type

<a name='F-TinyLife-Skills-SkillType-Texture'></a>
### Texture `constants`

##### Summary

The texture region of this skill type's icon

<a name='F-TinyLife-Skills-SkillType-Types'></a>
### Types `constants`

##### Summary

A registry of all skill types that exist in the game and mods.
Use [Register](#M-TinyLife-Skills-SkillType-Register-TinyLife-Skills-SkillType- 'TinyLife.Skills.SkillType.Register(TinyLife.Skills.SkillType)') to register custom skill types.

<a name='M-TinyLife-Skills-SkillType-GetRandomQuality-TinyLife-Objects-Person,System-Random,System-Boolean,System-Boolean-'></a>
### GetRandomQuality(person,random,modifyEmotions) `method`

##### Summary

Returns a semi-randomly generated [Quality](#T-TinyLife-Skills-Quality 'TinyLife.Skills.Quality') for the given [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') based on their level of this skill.
The higher the skill level is, the more likely it is for higher qualities to be returned.

##### Returns

A random quality based on the person's skill level

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') | The person that has this skill |
| random | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') | The random that should be used for calculation |
| modifyEmotions | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether the given person should receive emotions based on the quality |

<a name='M-TinyLife-Skills-SkillType-Register-TinyLife-Skills-SkillType-'></a>
### Register(type) `method`

##### Summary

Registers a new [SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') to the [Types](#F-TinyLife-Skills-SkillType-Types 'TinyLife.Skills.SkillType.Types') registry

##### Returns

The registered type, for chaining

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Skills.SkillType](#T-TinyLife-Skills-SkillType 'TinyLife.Skills.SkillType') | The type to register |

<a name='T-TinyLife-Actions-SocialAction'></a>
## SocialAction `type`

##### Namespace

TinyLife.Actions

##### Summary

A social action is an action that involves two [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') instances.
Before a social action "actually" starts, both parties have to have the action as their current action.
For this to happen, the person that initiates the action follows the [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner') until they reach them (or give up).

<a name='M-TinyLife-Actions-SocialAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Actions-SocialAction-PartnerCompletion'></a>
### PartnerCompletion `constants`

##### Summary

The current completion type of the [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner')'s action.
If this is not set, the partner completion is irrelevant for this action's completion behavior.

<a name='P-TinyLife-Actions-SocialAction-ConversationTime'></a>
### ConversationTime `property`

##### Summary

The amount of time that the actual conversation has been going on for.
This is the total amount of time ([ElapsedTime](#P-TinyLife-Actions-Action-ElapsedTime 'TinyLife.Actions.Action.ElapsedTime')) minus the amount of time it took for the [IsMain](#P-TinyLife-Actions-SocialAction-IsMain 'TinyLife.Actions.SocialAction.IsMain')[Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') to reach the [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner').

<a name='P-TinyLife-Actions-SocialAction-Id'></a>
### Id `property`

##### Summary

The internal id of this action

<a name='P-TinyLife-Actions-SocialAction-IsMain'></a>
### IsMain `property`

##### Summary

Whether or not this is the action that started the social interaction
The [PartnerAction](#P-TinyLife-Actions-SocialAction-PartnerAction 'TinyLife.Actions.SocialAction.PartnerAction') will always have the inverse value of this value.

<a name='P-TinyLife-Actions-SocialAction-Partner'></a>
### Partner `property`

##### Summary

The [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') that we're interacting with

<a name='P-TinyLife-Actions-SocialAction-PartnerAction'></a>
### PartnerAction `property`

##### Summary

The [SocialAction](#T-TinyLife-Actions-SocialAction 'TinyLife.Actions.SocialAction') that the [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner') of this action instantiated as part of the interaction

<a name='M-TinyLife-Actions-SocialAction-CanCancel-TinyLife-Actions-Action-'></a>
### CanCancel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-CanMultitask-TinyLife-Actions-Action-'></a>
### CanMultitask() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-DisplayConversationEmotes-Microsoft-Xna-Framework-GameTime,TinyLife-GameSpeed,TinyLife-Actions-EmoteCategory,System-Int32-'></a>
### DisplayConversationEmotes(time,speed,possibleCategories,totalEmoteAmount) `method`

##### Summary

Helper method to display emotes over each conversation partner in a back and forth fashion to make it seem like they are conversing

##### Returns

If `totalEmoteAmount` is set, true is returned if the emote back-and-forth is completed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's current speed |
| possibleCategories | [TinyLife.Actions.EmoteCategory](#T-TinyLife-Actions-EmoteCategory 'TinyLife.Actions.EmoteCategory') | A combined flag representing the categories that emotes can be picked from |
| totalEmoteAmount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The total amount of emotes that should be shown (not per person, but in total) |

<a name='M-TinyLife-Actions-SocialAction-GetDisplayName'></a>
### GetDisplayName() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-GetTimeWeWaitForPartner'></a>
### GetTimeWeWaitForPartner() `method`

##### Summary

Returns the amount of time that the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') should wait for their [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner') for before the interaction is canceled.
By default, this method returns 30 minutes if the [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner')[IsCloseForTalking](#M-TinyLife-Objects-Person-IsCloseForTalking-Microsoft-Xna-Framework-Vector2- 'TinyLife.Objects.Person.IsCloseForTalking(Microsoft.Xna.Framework.Vector2)'), and 15 minutes otherwise.

##### Returns

The amount of in-game time that this person should wait for their partner

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-InitializeConversation'></a>
### InitializeConversation() `method`

##### Summary

SocialAction version of [Initialize](#M-TinyLife-Actions-SocialAction-Initialize 'TinyLife.Actions.SocialAction.Initialize').
This method is called when the conversation part of this action first starts.
By default, this method does nothing.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-InvokeForBoth-System-Action{TinyLife-Objects-Person,TinyLife-Objects-Person}-'></a>
### InvokeForBoth(action) `method`

##### Summary

Invokes the given action for both the [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') and the [Partner](#P-TinyLife-Actions-SocialAction-Partner 'TinyLife.Actions.SocialAction.Partner'), passing both of them in the following way:

```
action(Person, Partner);
action(Partner, Person);
```

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action{TinyLife.Objects.Person,TinyLife.Objects.Person}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{TinyLife.Objects.Person,TinyLife.Objects.Person}') | The action to invoke for both people of this conversation |

<a name='M-TinyLife-Actions-SocialAction-IsCompleted'></a>
### IsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-IsConversationCompleted'></a>
### IsConversationCompleted() `method`

##### Summary

SocialAction version of [IsCompleted](#M-TinyLife-Actions-SocialAction-IsCompleted 'TinyLife.Actions.SocialAction.IsCompleted').
This method returns whether or not the conversation should be marked as completed.
Note that this method is only called for the [IsMain](#P-TinyLife-Actions-SocialAction-IsMain 'TinyLife.Actions.SocialAction.IsMain') part of the conversation.

##### Returns

Whether or not this conversation is completed

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-SocialAction-UpdateConversation-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### UpdateConversation(time,passedInGame,speed) `method`

##### Summary

SocialAction version of [Update](#M-TinyLife-Actions-SocialAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.SocialAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)').
This method is called every update frame during an active conversation.
By default, this method only increases [ConversationTime](#P-TinyLife-Actions-SocialAction-ConversationTime 'TinyLife.Actions.SocialAction.ConversationTime').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time passed in game time |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The current game speed |

<a name='M-TinyLife-Actions-SocialAction-Validate-TinyLife-Objects-Person-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Utilities-StaticJsonConverter`1'></a>
## StaticJsonConverter\`1 `type`

##### Namespace

TinyLife.Utilities

##### Summary

A [JsonConverter\`1](#T-Newtonsoft-Json-JsonConverter`1 'Newtonsoft.Json.JsonConverter`1') that doesn't actually serialize the object, but instead serializes the name given to it by the underlying [Dictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary`2 'System.Collections.Generic.Dictionary`2').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the object to convert |

<a name='M-TinyLife-Utilities-StaticJsonConverter`1-#ctor-System-Collections-Generic-Dictionary{System-String,`0}-'></a>
### #ctor(entries) `constructor`

##### Summary

Creates a new static json converter using the given underlying [Dictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary`2 'System.Collections.Generic.Dictionary`2').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entries | [System.Collections.Generic.Dictionary{System.String,\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,`0}') | The dictionary to use |

<a name='M-TinyLife-Utilities-StaticJsonConverter`1-ReadJson-Newtonsoft-Json-JsonReader,System-Type,`0,System-Boolean,Newtonsoft-Json-JsonSerializer-'></a>
### ReadJson() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Utilities-StaticJsonConverter`1-WriteJson-Newtonsoft-Json-JsonWriter,`0,Newtonsoft-Json-JsonSerializer-'></a>
### WriteJson() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-TalkAction'></a>
## TalkAction `type`

##### Namespace

TinyLife.Actions

##### Summary

TalkAction is a generic social action with a set of pre-defined parameters.
Things like [PersonalityType](#T-TinyLife-PersonalityType 'TinyLife.PersonalityType') and [Charisma](#F-TinyLife-Skills-SkillType-Charisma 'TinyLife.Skills.SkillType.Charisma') automatically influence this interaction's [FriendshipGain](#F-TinyLife-Actions-TalkAction-TalkSettings-FriendshipGain 'TinyLife.Actions.TalkAction.TalkSettings.FriendshipGain') and [GoBadlyChance](#F-TinyLife-Actions-TalkAction-TalkSettings-GoBadlyChance 'TinyLife.Actions.TalkAction.TalkSettings.GoBadlyChance').
[Create](#M-TinyLife-Actions-TalkAction-Create-System-String,System-Func{TinyLife-Objects-Person,System-Int32},TinyLife-Actions-TalkAction-TalkSettings- 'TinyLife.Actions.TalkAction.Create(System.String,System.Func{TinyLife.Objects.Person,System.Int32},TinyLife.Actions.TalkAction.TalkSettings)') should be used to create a talk action.

<a name='M-TinyLife-Actions-TalkAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-TinyLife-Actions-TalkAction-Settings'></a>
### Settings `property`

##### Summary

The [TalkSettings](#T-TinyLife-Actions-TalkAction-TalkSettings 'TinyLife.Actions.TalkAction.TalkSettings') for this action, derived from its type's settings

<a name='M-TinyLife-Actions-TalkAction-Create-System-String,System-Func{TinyLife-Objects-Person,System-Int32},TinyLife-Actions-TalkAction-TalkSettings-'></a>
### Create(name,priority,settings) `method`

##### Summary

A helper method to create a [TalkAction](#T-TinyLife-Actions-TalkAction 'TinyLife.Actions.TalkAction'), which is a very simple implementation of a [SocialAction](#T-TinyLife-Actions-SocialAction 'TinyLife.Actions.SocialAction')

##### Returns

A new TypeSettings instance with the given settings, which initializes a [TalkAction](#T-TinyLife-Actions-TalkAction 'TinyLife.Actions.TalkAction') when constructed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the action |
| priority | [System.Func{TinyLife.Objects.Person,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{TinyLife.Objects.Person,System.Int32}') | The passive priority of this action |
| settings | [TinyLife.Actions.TalkAction.TalkSettings](#T-TinyLife-Actions-TalkAction-TalkSettings 'TinyLife.Actions.TalkAction.TalkSettings') | The additional settings for this action |

<a name='M-TinyLife-Actions-TalkAction-IsConversationCompleted'></a>
### IsConversationCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-TalkAction-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-TalkAction-UpdateConversation-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### UpdateConversation() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-TalkAction-TalkSettings'></a>
## TalkSettings `type`

##### Namespace

TinyLife.Actions.TalkAction

##### Summary

Additional settings for [TalkAction](#T-TinyLife-Actions-TalkAction 'TinyLife.Actions.TalkAction'), used by [Create](#M-TinyLife-Actions-TalkAction-Create-System-String,System-Func{TinyLife-Objects-Person,System-Int32},TinyLife-Actions-TalkAction-TalkSettings- 'TinyLife.Actions.TalkAction.Create(System.String,System.Func{TinyLife.Objects.Person,System.Int32},TinyLife.Actions.TalkAction.TalkSettings)')

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-CanExecute'></a>
### CanExecute `constants`

##### Summary

A function that returns whether this action can currently be executed.
If this is null, the action can always be executed (if the [RequiredSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkill 'TinyLife.Actions.TalkAction.TalkSettings.RequiredSkill') is present).

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-EmoteCategory'></a>
### EmoteCategory `constants`

##### Summary

The category of emotes that should be displayed as part of this conversation

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-FailEmotion'></a>
### FailEmotion `constants`

##### Summary

A [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') that is added to the person if this talk action fails.
The talk actions fails if the [GoBadlyChance](#F-TinyLife-Actions-TalkAction-TalkSettings-GoBadlyChance 'TinyLife.Actions.TalkAction.TalkSettings.GoBadlyChance') has been randomly reached.

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-FriendshipGain'></a>
### FriendshipGain `constants`

##### Summary

The amount of friendship that can be gained at max

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-GainRomancePercentage'></a>
### GainRomancePercentage `constants`

##### Summary

A function that returns what percentage (between 0 and 1) of [FriendshipGain](#F-TinyLife-Actions-TalkAction-TalkSettings-FriendshipGain 'TinyLife.Actions.TalkAction.TalkSettings.FriendshipGain') is added to the relationship as [RomanceLevel](#P-TinyLife-Relationship-RomanceLevel 'TinyLife.Relationship.RomanceLevel') rather than [FriendLevel](#P-TinyLife-Relationship-FriendLevel 'TinyLife.Relationship.FriendLevel').
If an interaction is romantic in nature, this function should return a value greater than 0.
If this function is null, 0% of the friendship gain will be romantic.

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-GainSkillOnFailure'></a>
### GainSkillOnFailure `constants`

##### Summary

Whether the [GainSkillOnFailure](#F-TinyLife-Actions-TalkAction-TalkSettings-GainSkillOnFailure 'TinyLife.Actions.TalkAction.TalkSettings.GainSkillOnFailure') should be gained on failure rather than success.
This is useful for skills that are considered "mean", where the gained skill is mischievious etc.

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-GainedSkill'></a>
### GainedSkill `constants`

##### Summary

The skill that is gained if this conversation goes well. Higher levels in this skill also reduce the chance of the conversation going badly.

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-GainedSkillAmount'></a>
### GainedSkillAmount `constants`

##### Summary

The amount of the [GainedSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-GainedSkill 'TinyLife.Actions.TalkAction.TalkSettings.GainedSkill') that is gained

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-GoBadlyChance'></a>
### GoBadlyChance `constants`

##### Summary

The chance (from 0 to 1) that this action goes badly and friendship is reduced instead

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotion'></a>
### LoweredEmotion `constants`

##### Summary

An [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') that is lowered when this action is successful for both conversation partners.
This uses [LowerEmotion](#M-TinyLife-Objects-Person-LowerEmotion-TinyLife-Emotions-EmotionType,System-Single,TinyLife-GameSpeed- 'TinyLife.Objects.Person.LowerEmotion(TinyLife.Emotions.EmotionType,System.Single,TinyLife.GameSpeed)') internally.
Note that this value only has an effect if [LoweredEmotionAmount](#F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotionAmount 'TinyLife.Actions.TalkAction.TalkSettings.LoweredEmotionAmount') is greater than 0.

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotionAmount'></a>
### LoweredEmotionAmount `constants`

##### Summary

The amount that [LoweredEmotion](#F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotion 'TinyLife.Actions.TalkAction.TalkSettings.LoweredEmotion') is lowered by when this action is successful for both conversation partners.
Note that this value only has an effect if [LoweredEmotion](#F-TinyLife-Actions-TalkAction-TalkSettings-LoweredEmotion 'TinyLife.Actions.TalkAction.TalkSettings.LoweredEmotion') is non-null.

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-OnFailure'></a>
### OnFailure `constants`

##### Summary

An action that is invoked when this talk action fails

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-OnSuccess'></a>
### OnSuccess `constants`

##### Summary

An action that is invoked when this talk action succeeds

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-RequiredEmotion'></a>
### RequiredEmotion `constants`

##### Summary

The [EmotionType](#T-TinyLife-Emotions-EmotionType 'TinyLife.Emotions.EmotionType') that is required for this action to be available

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkill'></a>
### RequiredSkill `constants`

##### Summary

The [Skill](#T-TinyLife-Skills-Skill 'TinyLife.Skills.Skill') that is required for this action to be available

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkillLevel'></a>
### RequiredSkillLevel `constants`

##### Summary

The skill level of [RequiredSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkill 'TinyLife.Actions.TalkAction.TalkSettings.RequiredSkill') that is required for this action to be available

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-RestoredNeed'></a>
### RestoredNeed `constants`

##### Summary

The need (alongside [Social](#F-TinyLife-NeedType-Social 'TinyLife.NeedType.Social')) that is restored during the conversation

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-RestoredNeedAmount'></a>
### RestoredNeedAmount `constants`

##### Summary

The amount of [RestoredNeed](#F-TinyLife-Actions-TalkAction-TalkSettings-RestoredNeed 'TinyLife.Actions.TalkAction.TalkSettings.RestoredNeed') that is restored each update frame

<a name='F-TinyLife-Actions-TalkAction-TalkSettings-TalkMinutes'></a>
### TalkMinutes `constants`

##### Summary

The amount of in-game minutes that this action should last

<a name='M-TinyLife-Actions-TalkAction-TalkSettings-CheckCanExecute-TinyLife-Actions-ActionInfo,System-Boolean-'></a>
### CheckCanExecute(info,automatic) `method`

##### Summary

Checks whether this [TalkSettings](#T-TinyLife-Actions-TalkAction-TalkSettings 'TinyLife.Actions.TalkAction.TalkSettings') instance is currently able to be executed.
This takes into account all of the parameters, including [CanExecute](#F-TinyLife-Actions-TalkAction-TalkSettings-CanExecute 'TinyLife.Actions.TalkAction.TalkSettings.CanExecute'), [RequiredSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredSkill 'TinyLife.Actions.TalkAction.TalkSettings.RequiredSkill') and [RequiredEmotion](#F-TinyLife-Actions-TalkAction-TalkSettings-RequiredEmotion 'TinyLife.Actions.TalkAction.TalkSettings.RequiredEmotion').

##### Returns

The execution validity result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The action info |
| automatic | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether this action is automatic |

<a name='M-TinyLife-Actions-TalkAction-TalkSettings-Evaluate-TinyLife-Actions-SocialAction-'></a>
### Evaluate(action) `method`

##### Summary

Evaluates these [TalkSettings](#T-TinyLife-Actions-TalkAction-TalkSettings 'TinyLife.Actions.TalkAction.TalkSettings') after a [TalkAction](#T-TinyLife-Actions-TalkAction 'TinyLife.Actions.TalkAction') has completed.
This method causes friendship and romance to be added to the involved people's [Relationship](#T-TinyLife-Relationship 'TinyLife.Relationship'), adds the [GainedSkill](#F-TinyLife-Actions-TalkAction-TalkSettings-GainedSkill 'TinyLife.Actions.TalkAction.TalkSettings.GainedSkill') etc.
This method is automatically called in [TalkAction](#T-TinyLife-Actions-TalkAction 'TinyLife.Actions.TalkAction').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [TinyLife.Actions.SocialAction](#T-TinyLife-Actions-SocialAction 'TinyLife.Actions.SocialAction') | The action |

<a name='T-TinyLife-Actions-TellPeopleToLeaveRoomAction'></a>
## TellPeopleToLeaveRoomAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-TellPeopleToLeaveRoomAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-TinyLife-Actions-TellPeopleToLeaveRoomAction-ExcludedPeople'></a>
### ExcludedPeople `constants`

##### Summary

A list of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') ids of [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') objects that should not be asked to leave the room

<a name='M-TinyLife-Actions-TellPeopleToLeaveRoomAction-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-TellPeopleToLeaveRoomAction-IsCompleted'></a>
### IsCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-TellPeopleToLeaveRoomAction-OnCompleted-TinyLife-Actions-Action-CompletionType-'></a>
### OnCompleted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Utilities-TextureHandler'></a>
## TextureHandler `type`

##### Namespace

TinyLife.Utilities

##### Summary

The texture handler stores data for the game's textures, including all of the game's internal textures and various utility methods.
It also stores the game's [RuntimeTexturePacker](#T-MLEM-Data-RuntimeTexturePacker 'MLEM.Data.RuntimeTexturePacker') which is used to pack all textures into a big texture for performance.

<a name='M-TinyLife-Utilities-TextureHandler-ApplyWallpaperMasks-Microsoft-Xna-Framework-Graphics-Texture2D,System-Int32,System-Int32,System-Action{MLEM-Textures-UniformTextureAtlas}-'></a>
### ApplyWallpaperMasks(wallpapers,regionAmountX,regionAmountY,result) `method`

##### Summary

Applies the game's predefined wallpaper maskings (based on [WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode')) to the given wallpaper texture.
When adding custom [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') types, this method should be used.
Note that, as part of this method, the resulting texture is implicitly added onto the game's [RuntimeTexturePacker](#T-MLEM-Data-RuntimeTexturePacker 'MLEM.Data.RuntimeTexturePacker').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| wallpapers | [Microsoft.Xna.Framework.Graphics.Texture2D](#T-Microsoft-Xna-Framework-Graphics-Texture2D 'Microsoft.Xna.Framework.Graphics.Texture2D') | The texture to mask |
| regionAmountX | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of texture regions on the x axis |
| regionAmountY | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of texture regions on the y axis |
| result | [System.Action{MLEM.Textures.UniformTextureAtlas}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{MLEM.Textures.UniformTextureAtlas}') | A function that is called when the [RuntimeTexturePacker](#T-MLEM-Data-RuntimeTexturePacker 'MLEM.Data.RuntimeTexturePacker') packed the masked texture, which yields the resulting texture atlas |

<a name='T-TinyLife-World-Tile'></a>
## Tile `type`

##### Namespace

TinyLife.World

##### Summary

A tile is an object on a [Map](#T-TinyLife-World-Map 'TinyLife.World.Map') that represents the covering of the ground (or the ground itself)

<a name='F-TinyLife-World-Tile-BaseName'></a>
### BaseName `constants`

##### Summary

The name of this type of tile. Whereas [Name](#F-TinyLife-World-Tile-Name 'TinyLife.World.Tile.Name') has the index of its [color](#F-TinyLife-World-Tile-color 'TinyLife.World.Tile.color') appended to it, this one is just the type's name.

<a name='F-TinyLife-World-Tile-CanBuy'></a>
### CanBuy `constants`

##### Summary

A field that indicates whether this tile can be bought without the "ShowNonBuyable" cheat enabled

<a name='F-TinyLife-World-Tile-ColorScheme'></a>
### ColorScheme `constants`

##### Summary

The color scheme that this tile can have

<a name='F-TinyLife-World-Tile-Height'></a>
### Height `constants`

##### Summary

The height of each tile, in pixels

<a name='F-TinyLife-World-Tile-Icon'></a>
### Icon `constants`

##### Summary

The build mode icon for this object, which represents the category / theme / mod that it comes from.
If this value is nonnull, the icon will be displayed in the corner of the build mode button for this object.

<a name='F-TinyLife-World-Tile-Name'></a>
### Name `constants`

##### Summary

The name of this specific tile. This is comprised of the [BaseName](#F-TinyLife-World-Tile-BaseName 'TinyLife.World.Tile.BaseName') with the [color](#F-TinyLife-World-Tile-color 'TinyLife.World.Tile.color')'s index attached to it.

<a name='F-TinyLife-World-Tile-Natural'></a>
### Natural `constants`

##### Summary

A field that indicates whether this tile is considered natural.
A natural tile is a tile that objects with the [NaturalGroundRequired](#F-TinyLife-Objects-ObjectCategory-NaturalGroundRequired 'TinyLife.Objects.ObjectCategory.NaturalGroundRequired') category can be placed on.

<a name='F-TinyLife-World-Tile-PathCostModifier'></a>
### PathCostModifier `constants`

##### Summary

A field that indicates the "cost" for pathfinding of this tile.
The default modifier is 1, and it should not be set to a value lower than that.

<a name='F-TinyLife-World-Tile-Price'></a>
### Price `constants`

##### Summary

The price of this tile

<a name='F-TinyLife-World-Tile-ReferencePrice'></a>
### ReferencePrice `constants`

##### Summary

The reference price for tiles.
Since Grass is replaced by Concrete in a newly created room, the two tiles have to cost the same. This is that price.
This value is set to 5.

<a name='F-TinyLife-World-Tile-Tiles'></a>
### Tiles `constants`

##### Summary

A registry of all tiles that exist in the game and its mods

<a name='F-TinyLife-World-Tile-Width'></a>
### Width `constants`

##### Summary

The width of each tile, in pixels

<a name='M-TinyLife-World-Tile-Draw-Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,System-Single,System-Single-'></a>
### Draw(batch,drawPos,depth,scale) `method`

##### Summary

Draws this tile at the given position in the world

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in screen space, to draw at |
| depth | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The depth to use for drawing |
| scale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw the tile with |

<a name='M-TinyLife-World-Tile-DrawUi-MLEM-Ui-Elements-Element,Microsoft-Xna-Framework-Graphics-SpriteBatch,System-Single-'></a>
### DrawUi(e,batch,drawScale) `method`

##### Summary

Draws this tile on the given ui element, in ui space

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MLEM.Ui.Elements.Element](#T-MLEM-Ui-Elements-Element 'MLEM.Ui.Elements.Element') | The element to draw on |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to use for drawing |
| drawScale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw the tile with. Defaults to 0.4. |

<a name='M-TinyLife-World-Tile-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Tile-Register-System-String,System-Int32,MLEM-Textures-TextureRegion,TinyLife-Utilities-ColorScheme,System-Single,System-Boolean,System-Boolean,MLEM-Textures-TextureRegion-'></a>
### Register(name,price,textureRegion,colors,pathCostModifier,canBuy,natural,icon) `method`

##### Summary

Registers a new tile with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name that the tile should have |
| price | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The tile's price |
| textureRegion | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture region that this tile should use for rendering |
| colors | [TinyLife.Utilities.ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme') | The color scheme that this tile should have |
| pathCostModifier | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The path cost modifier, >= 1, that this tile should have |
| canBuy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the tile can be bought in the tile tool |
| natural | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the tile is considered natural ground |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The build mode category icon of this object |

<a name='T-TinyLife-Tools-TileTool'></a>
## TileTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-TileTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-TileTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-TileTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-TileTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-TileTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-TileTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Tools-Tool'></a>
## Tool `type`

##### Namespace

TinyLife.Tools

##### Summary

A tool is a type of game mode that is currently active.
Tools are split up into the [PlayModeTool](#F-TinyLife-Tools-Tool-PlayModeTool 'TinyLife.Tools.Tool.PlayModeTool') and [BuildTools](#F-TinyLife-Tools-Tool-BuildTools 'TinyLife.Tools.Tool.BuildTools'), the latter of which holds all tools that can be found in the build menu.

<a name='M-TinyLife-Tools-Tool-#ctor-MLEM-Textures-TextureRegion,System-Boolean-'></a>
### #ctor(texture,displayAsTab) `constructor`

##### Summary

Creates a new tool with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| texture | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The texture of the tool icon |
| displayAsTab | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Wheteher or not this tool should display as a tab. Defaults to false. |

<a name='F-TinyLife-Tools-Tool-BuildTools'></a>
### BuildTools `constants`

##### Summary

A set of [Tool](#T-TinyLife-Tools-Tool 'TinyLife.Tools.Tool') instances that can be activated using the build mode menu.
All tools in this list are automatically added to the menu.

<a name='F-TinyLife-Tools-Tool-DisplayAsTab'></a>
### DisplayAsTab `constants`

##### Summary

Whether or not this tool should be displayed as a tab (like the [RemoveTool](#F-TinyLife-Tools-Tool-RemoveTool 'TinyLife.Tools.Tool.RemoveTool')) or a button in the build menu

<a name='F-TinyLife-Tools-Tool-MousePos'></a>
### MousePos `constants`

##### Summary

The position of the mouse in world coordinates.
This position is set every [Update](#M-TinyLife-Tools-Tool-Update-Microsoft-Xna-Framework-GameTime- 'TinyLife.Tools.Tool.Update(Microsoft.Xna.Framework.GameTime)') call.

<a name='F-TinyLife-Tools-Tool-MoveTool'></a>
### MoveTool `constants`

##### Summary

The [MoveTool](#F-TinyLife-Tools-Tool-MoveTool 'TinyLife.Tools.Tool.MoveTool') singleton

<a name='F-TinyLife-Tools-Tool-PlayModeTool'></a>
### PlayModeTool `constants`

##### Summary

The [PlayModeTool](#F-TinyLife-Tools-Tool-PlayModeTool 'TinyLife.Tools.Tool.PlayModeTool') singleton, which is activated when build mode is inactive.

<a name='F-TinyLife-Tools-Tool-RemoveTool'></a>
### RemoveTool `constants`

##### Summary

The [RemoveTool](#F-TinyLife-Tools-Tool-RemoveTool 'TinyLife.Tools.Tool.RemoveTool') singleton, which is activated using the Remove tab in the build menu or by holding the control key.

<a name='F-TinyLife-Tools-Tool-Texture'></a>
### Texture `constants`

##### Summary

The texture region that should be used to display this tool in the build menu

<a name='P-TinyLife-Tools-Tool-Input'></a>
### Input `property`

##### Summary

*Inherit from parent.*

<a name='P-TinyLife-Tools-Tool-Map'></a>
### Map `property`

##### Summary

*Inherit from parent.*

<a name='P-TinyLife-Tools-Tool-Money'></a>
### Money `property`

##### Summary

*Inherit from parent.*

<a name='P-TinyLife-Tools-Tool-SelectedObject'></a>
### SelectedObject `property`

##### Summary

The [MapObject](#T-TinyLife-Objects-MapObject 'TinyLife.Objects.MapObject') that is currently below the mouse, or null if there is none.
This object selection mechanic uses pixel-perfect collision based on the object's rendered texture.

<a name='M-TinyLife-Tools-Tool-BuildModeButton-System-String,MLEM-Ui-Elements-Element-GenericCallback,MLEM-Ui-Elements-Element-DrawCallback,System-Single,MLEM-Textures-TextureRegion,TinyLife-LnCategory-'></a>
### BuildModeButton(name,onPressed,onDrawn,price,icon) `method`

##### Summary

Creates a new [Button](#T-MLEM-Ui-Elements-Button 'MLEM.Ui.Elements.Button') in the style of each build mode content button, like the ones that display the furniture that can be bought.

##### Returns

A new button with the passed settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name that should be displayed when hovering the button. This should be unlocalized. |
| onPressed | [MLEM.Ui.Elements.Element.GenericCallback](#T-MLEM-Ui-Elements-Element-GenericCallback 'MLEM.Ui.Elements.Element.GenericCallback') | A fucntion that is called when the created button is pressed |
| onDrawn | [MLEM.Ui.Elements.Element.DrawCallback](#T-MLEM-Ui-Elements-Element-DrawCallback 'MLEM.Ui.Elements.Element.DrawCallback') | A function that is called when the created button is drawn |
| price | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The price that should be displayed for this object |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The build mode category icon of this object |

<a name='M-TinyLife-Tools-Tool-CanSaveOrSwitchModes'></a>
### CanSaveOrSwitchModes() `method`

##### Summary

Whether or not the game [CanSaveOrSwitchModes](#M-TinyLife-GameImpl-CanSaveOrSwitchModes 'TinyLife.GameImpl.CanSaveOrSwitchModes') currently, while this tool is selected

##### Returns

Whether the game can be saved or mode switched right now

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-Tool-Closed'></a>
### Closed() `method`

##### Summary

Called when this build tool is closed.
By default, this method removes its elements from the ui.

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-Tool-ColorSelection-TinyLife-Utilities-ColorScheme,System-Action{System-Int32}-'></a>
### ColorSelection(colors,onPressed) `method`

##### Summary

Creates a new [Group](#T-MLEM-Ui-Elements-Group 'MLEM.Ui.Elements.Group') that resembles a set of color selection buttons.
This is used by [CharacterCreator](#T-TinyLife-Uis-CharacterCreator 'TinyLife.Uis.CharacterCreator'), as well as tools like the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool').

##### Returns

A group of buttons with the given settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colors | [TinyLife.Utilities.ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme') | The color scheme to create buttons for |
| onPressed | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | A function that returns the index of the button (and color) that has been pressed |

<a name='M-TinyLife-Tools-Tool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw(time,batch) `method`

##### Summary

This method is called every draw frame for the [CurrentTool](#P-TinyLife-GameImpl-CurrentTool 'TinyLife.GameImpl.CurrentTool').
Note that this method is only called if the mouse is not hovering over any ui elements.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch used for drawing |

<a name='M-TinyLife-Tools-Tool-ForceWallsUp'></a>
### ForceWallsUp() `method`

##### Summary

Returns whether the [WallDisplay](#T-TinyLife-WallDisplay 'TinyLife.WallDisplay') should be forcibly changed by this tool.
If it shouldn't be changed, null should be returned. Otherwise, the required [WallDisplay](#T-TinyLife-WallDisplay 'TinyLife.WallDisplay') should be returned.

##### Returns

The required wall display, or null if the default should be used

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-Tool-GetClosestWallDirection-Microsoft-Xna-Framework-Point-'></a>
### GetClosestWallDirection(hoveredPos) `method`

##### Summary

Returns the direction of the wall that the mouse position is currently closest to.

##### Returns

The closest wall direction, or [Up](#F-MLEM-Misc-Direction2-Up 'MLEM.Misc.Direction2.Up') if there is none

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hoveredPos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position that the mouse is on, in world space |

<a name='M-TinyLife-Tools-Tool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

Returns the [CursorType](#T-TinyLife-Uis-CursorType 'TinyLife.Uis.CursorType') that this tool should currently display.
By default, [Default](#F-TinyLife-Uis-CursorType-Default 'TinyLife.Uis.CursorType.Default') is returned.

##### Returns

The cursor type

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-Tool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi(content,zoom) `method`

##### Summary

Override this method to add custom content to the passed ui elements.
By default, this method does nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [MLEM.Ui.Elements.Panel](#T-MLEM-Ui-Elements-Panel 'MLEM.Ui.Elements.Panel') | The main content panel. Add custom [BuildModeButton](#M-TinyLife-Tools-Tool-BuildModeButton-System-String,MLEM-Ui-Elements-Element-GenericCallback,MLEM-Ui-Elements-Element-DrawCallback,System-Single,MLEM-Textures-TextureRegion,TinyLife-LnCategory- 'TinyLife.Tools.Tool.BuildModeButton(System.String,MLEM.Ui.Elements.Element.GenericCallback,MLEM.Ui.Elements.Element.DrawCallback,System.Single,MLEM.Textures.TextureRegion,TinyLife.LnCategory)') instances here. |
| zoom | [MLEM.Ui.Elements.Panel](#T-MLEM-Ui-Elements-Panel 'MLEM.Ui.Elements.Panel') | The zoom panel that contains [ColorSelection](#M-TinyLife-Tools-Tool-ColorSelection-TinyLife-Utilities-ColorScheme,System-Action{System-Int32}- 'TinyLife.Tools.Tool.ColorSelection(TinyLife.Utilities.ColorScheme,System.Action{System.Int32})') and object previews |

<a name='M-TinyLife-Tools-Tool-IsOnLot-Microsoft-Xna-Framework-Point-'></a>
### IsOnLot(pos) `method`

##### Summary

Returns whether or not the passed position is on the currently edited lot ([CurrentLot](#P-TinyLife-GameImpl-CurrentLot 'TinyLife.GameImpl.CurrentLot'))

##### Returns

Whether or not the position is on the current lot

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The position to check |

<a name='M-TinyLife-Tools-Tool-Opened'></a>
### Opened() `method`

##### Summary

Called when this build tool is opened.
By default, this method initializes several settings and calls [InitBuildModeUi](#M-TinyLife-Tools-Tool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel- 'TinyLife.Tools.Tool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)').

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-Tool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update(time) `method`

##### Summary

This method is called every update frame for the [CurrentTool](#P-TinyLife-GameImpl-CurrentTool 'TinyLife.GameImpl.CurrentTool').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game's time |

<a name='T-TinyLife-Emotions-EmotionType-TypeCategory'></a>
## TypeCategory `type`

##### Namespace

TinyLife.Emotions.EmotionType

##### Summary

An enumeration used for [Category](#F-TinyLife-Emotions-EmotionType-Category 'TinyLife.Emotions.EmotionType.Category') that represents a general category an emotion can fit into.
The values are ordered in a way such that, if two emotion amounts sum to the same value, the one with the lower category will be chosen.

<a name='F-TinyLife-Emotions-EmotionType-TypeCategory-Negative'></a>
### Negative `constants`

##### Summary

A negative emotion, like [Sad](#F-TinyLife-Emotions-EmotionType-Sad 'TinyLife.Emotions.EmotionType.Sad') or [Embarrassed](#F-TinyLife-Emotions-EmotionType-Embarrassed 'TinyLife.Emotions.EmotionType.Embarrassed')

<a name='F-TinyLife-Emotions-EmotionType-TypeCategory-Neutral'></a>
### Neutral `constants`

##### Summary

A neutral emotion, like [Fine](#F-TinyLife-Emotions-EmotionType-Fine 'TinyLife.Emotions.EmotionType.Fine') or [Asleep](#F-TinyLife-Emotions-EmotionType-Asleep 'TinyLife.Emotions.EmotionType.Asleep')

<a name='F-TinyLife-Emotions-EmotionType-TypeCategory-Positive'></a>
### Positive `constants`

##### Summary

A positive emotion, like [Happy](#F-TinyLife-Emotions-EmotionType-Happy 'TinyLife.Emotions.EmotionType.Happy')

<a name='T-TinyLife-Actions-ActionType-TypeSettings'></a>
## TypeSettings `type`

##### Namespace

TinyLife.Actions.ActionType

##### Summary

A struct that contains information about an [ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType')

<a name='T-TinyLife-Objects-FurnitureType-TypeSettings'></a>
## TypeSettings `type`

##### Namespace

TinyLife.Objects.FurnitureType

##### Summary

A set of settings that define the properties of a [FurnitureType](#T-TinyLife-Objects-FurnitureType 'TinyLife.Objects.FurnitureType')

<a name='M-TinyLife-Actions-ActionType-TypeSettings-#ctor-System-String,TinyLife-Objects-ObjectCategory,System-Func{TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo,TinyLife-Actions-Action}-'></a>
### #ctor(name,context,construct) `constructor`

##### Summary

Creates a new type settings instance with the given values

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of this action type |
| context | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | A combined [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') flag that represents all of the objects that this action can be executed on |
| construct | [System.Func{TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,TinyLife.Actions.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo,TinyLife.Actions.Action}') | A function that is called in [Construct](#M-TinyLife-Actions-ActionType-Construct-TinyLife-Actions-ActionInfo,System-Nullable{TinyLife-Actions-ActionVariety}- 'TinyLife.Actions.ActionType.Construct(TinyLife.Actions.ActionInfo,System.Nullable{TinyLife.Actions.ActionVariety})') to create a new action instance. |

<a name='M-TinyLife-Objects-FurnitureType-TypeSettings-#ctor-System-String,Microsoft-Xna-Framework-Point,TinyLife-Objects-ObjectCategory,System-Single,TinyLife-Utilities-ColorScheme[]-'></a>
### #ctor(name,size,categories,price,colorSchemes) `constructor`

##### Summary

Initializes a new [TypeSettings](#T-TinyLife-Objects-FurnitureType-TypeSettings 'TinyLife.Objects.FurnitureType.TypeSettings') instance with the given data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name that this furniture type should have |
| size | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The size that this furniture type should have |
| categories | [TinyLife.Objects.ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') | The categories that this furniture type should have |
| price | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The price of this furniture type |
| colorSchemes | [TinyLife.Utilities.ColorScheme[]](#T-TinyLife-Utilities-ColorScheme[] 'TinyLife.Utilities.ColorScheme[]') | The color schemes that this furniture type should have. Cannot be empty. |

<a name='F-TinyLife-Actions-ActionType-TypeSettings-Ai'></a>
### Ai `constants`

##### Summary

A set of settings for [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi') invocation of this action.
This value defaults to default.

<a name='F-TinyLife-Actions-ActionType-TypeSettings-CanExecute'></a>
### CanExecute `constants`

##### Summary

A delegate that returns a [CanExecuteResult](#T-TinyLife-Actions-ActionType-CanExecuteResult 'TinyLife.Actions.ActionType.CanExecuteResult') based on whether the given situation allows this action to be executed.
This value is initialized always return [Valid](#F-TinyLife-Actions-ActionType-CanExecuteResult-Valid 'TinyLife.Actions.ActionType.CanExecuteResult.Valid').

<a name='F-TinyLife-Actions-ActionType-TypeSettings-Construct'></a>
### Construct `constants`

##### Summary

A function that is called in [Construct](#M-TinyLife-Actions-ActionType-Construct-TinyLife-Actions-ActionInfo,System-Nullable{TinyLife-Actions-ActionVariety}- 'TinyLife.Actions.ActionType.Construct(TinyLife.Actions.ActionInfo,System.Nullable{TinyLife.Actions.ActionVariety})') to create a new action instance.
This should return a new instance of your custom type that extends [Action](#T-TinyLife-Actions-Action 'TinyLife.Actions.Action').

<a name='F-TinyLife-Actions-ActionType-TypeSettings-Context'></a>
### Context `constants`

##### Summary

A combined [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') flag that represents all of the objects that this action can be executed on

<a name='F-TinyLife-Actions-ActionType-TypeSettings-IconName'></a>
### IconName `constants`

##### Summary

The name of the icon that this action type should display in front of its name.
To make the icon work, its name needs to be added to the [UiSystem](#T-MLEM-Ui-UiSystem 'MLEM.Ui.UiSystem')'s [TextFormatter](#T-MLEM-Formatting-TextFormatter 'MLEM.Formatting.TextFormatter') using [AddImage](#M-MLEM-Formatting-Codes-ImageCodeExtensions-AddImage-MLEM-Formatting-TextFormatter,System-String,MLEM-Textures-TextureRegion,System-Boolean- 'MLEM.Formatting.Codes.ImageCodeExtensions.AddImage(MLEM.Formatting.TextFormatter,System.String,MLEM.Textures.TextureRegion,System.Boolean)').

<a name='F-TinyLife-Actions-ActionType-TypeSettings-IsInappropriateElsewhere'></a>
### IsInappropriateElsewhere `constants`

##### Summary

If this value is true, this action will not automatically be invoked by [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi') on lots that the person does not own.
Additionally, when the player invokes an action with this value set to true, the lot's owner will come up to them and tell them to stop.

<a name='F-TinyLife-Actions-ActionType-TypeSettings-Name'></a>
### Name `constants`

##### Summary

The name of this action type

<a name='F-TinyLife-Actions-ActionType-TypeSettings-Texture'></a>
### Texture `constants`

##### Summary

The texture region used in the top left action queue display in-game.
If this value is null, [GetIconObject](#M-TinyLife-Actions-Action-GetIconObject 'TinyLife.Actions.Action.GetIconObject') is used for the icon instead.

<a name='F-TinyLife-Actions-ActionType-TypeSettings-Varieties'></a>
### Varieties `constants`

##### Summary

A set of [ActionVariety](#T-TinyLife-Actions-ActionVariety 'TinyLife.Actions.ActionVariety') instances that represent different versions of this action.
If this is set, a menu pops up (like when cooking food) that displays all of the varieties as options to the user.
When the [PersonAi](#T-TinyLife-Objects-PersonAi 'TinyLife.Objects.PersonAi') invokes an action with a variety, it chooses a variety randomly based on its [PassivePriority](#F-TinyLife-Actions-ActionVariety-PassivePriority 'TinyLife.Actions.ActionVariety.PassivePriority')

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-ActionSpots'></a>
### ActionSpots `constants`

##### Summary

An array of [ActionSpot](#T-TinyLife-Objects-ActionSpot 'TinyLife.Objects.ActionSpot') instances that this furniture type should have.
By default, every tile that this furniture covers has an action spot reachable from all sides.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-BuyableVariations'></a>
### BuyableVariations `constants`

##### Summary

An array of actions that can modify the passed [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') instance.
If this is set, additional variations of this furniture type will show up in the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool'), and buying them will invoke this action that can then modify the furniture type.
This is used, for example, for [FoodPlate](#F-TinyLife-Objects-FurnitureType-FoodPlate 'TinyLife.Objects.FurnitureType.FoodPlate') and [CustomPainting](#F-TinyLife-Objects-FurnitureType-CustomPainting 'TinyLife.Objects.FurnitureType.CustomPainting').

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-Categories'></a>
### Categories `constants`

##### Summary

A set of [ObjectCategory](#T-TinyLife-Objects-ObjectCategory 'TinyLife.Objects.ObjectCategory') flags that this furniture should have

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-ColorMap'></a>
### ColorMap `constants`

##### Summary

An array of indices that determines which layers should use which color schemes.
A furniture will always have the same amount of layers as there are color map entries.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-ColorSchemes'></a>
### ColorSchemes `constants`

##### Summary

An array of color schemes that this furniture type should have.
If [ColorMap](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorMap 'TinyLife.Objects.FurnitureType.TypeSettings.ColorMap') is not set, its value is determined automatically by the amount of color schemes supplied.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-Construct'></a>
### Construct `constants`

##### Summary

A delegate to a [Construct](#F-TinyLife-Objects-FurnitureType-TypeSettings-Construct 'TinyLife.Objects.FurnitureType.TypeSettings.Construct') method that is invoked when this furniture type is instantiated using [Construct](#M-TinyLife-Objects-FurnitureType-Construct-System-Int32[],TinyLife-World-Map,Microsoft-Xna-Framework-Vector2,System-Nullable{System-Guid}- 'TinyLife.Objects.FurnitureType.Construct(System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,System.Nullable{System.Guid})')

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-DecorativeRating'></a>
### DecorativeRating `constants`

##### Summary

A function that returns an integer for a given [Furniture](#T-TinyLife-Objects-Furniture 'TinyLife.Objects.Furniture') instance of this type.
The integer represents the decoration (or prettiness) rating of the object. The rating determines [EmotionModifier](#T-TinyLife-Emotions-EmotionModifier 'TinyLife.Emotions.EmotionModifier') values like [UglySurroundings](#F-TinyLife-Emotions-EmotionModifier-UglySurroundings 'TinyLife.Emotions.EmotionModifier.UglySurroundings').
A negative return value makes the object be perceived as ugly, whereas a positive rating makes the object be perceived as pretty.
By default, this function returns 0.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-DefaultColors'></a>
### DefaultColors `constants`

##### Summary

The default color selection for this furniture type.
If not specified, this defaults to the first entries in each of the [ColorSchemes](#F-TinyLife-Objects-FurnitureType-TypeSettings-ColorSchemes 'TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes').

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-DefaultRotation'></a>
### DefaultRotation `constants`

##### Summary

The rotation that this furniture type should have when picked from the [FurnitureTool](#T-TinyLife-Tools-FurnitureTool 'TinyLife.Tools.FurnitureTool'). [Up](#F-MLEM-Misc-Direction2-Up 'MLEM.Misc.Direction2.Up') by default.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-HeldScale'></a>
### HeldScale `constants`

##### Summary

The scale that this furniture should be drawn with when held by a [Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person')

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-Icon'></a>
### Icon `constants`

##### Summary

The build mode icon for this object, which represents the category / theme / mod that it comes from.
If this value is nonnull, the icon will be displayed in the corner of the build mode button for this object.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-Name'></a>
### Name `constants`

##### Summary

The name of the furniture type. Should be unique across all game content, including all mods.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-ObjectSpots'></a>
### ObjectSpots `constants`

##### Summary

An array of [ObjectSpot](#T-TinyLife-Objects-ObjectSpot 'TinyLife.Objects.ObjectSpot') instances that this furniture type should have.
By default, there are no object spots.

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-Price'></a>
### Price `constants`

##### Summary

The price that this furniture should have

<a name='F-TinyLife-Objects-FurnitureType-TypeSettings-Size'></a>
### Size `constants`

##### Summary

The size, in full tiles, that this furniture should take up

<a name='P-TinyLife-Actions-ActionType-TypeSettings-Categories'></a>
### Categories `property`

##### Summary

The categories of this action type. The categories are strings at the start of this action type's [Name](#F-TinyLife-Actions-ActionType-TypeSettings-Name 'TinyLife.Actions.ActionType.TypeSettings.Name') delimited with a slash (/) character.
This property automatically returns a substring of [Name](#F-TinyLife-Actions-ActionType-TypeSettings-Name 'TinyLife.Actions.ActionType.TypeSettings.Name'), converted to an array.

<a name='P-TinyLife-Actions-ActionType-TypeSettings-NameWithoutCategory'></a>
### NameWithoutCategory `property`

##### Summary

The [Name](#F-TinyLife-Actions-ActionType-TypeSettings-Name 'TinyLife.Actions.ActionType.TypeSettings.Name') of this action type, but without a possible category prefix.
This property automatically returns a substring of [Name](#F-TinyLife-Actions-ActionType-TypeSettings-Name 'TinyLife.Actions.ActionType.TypeSettings.Name').

<a name='M-TinyLife-Actions-ActionType-TypeSettings-GetDataKeys'></a>
### GetDataKeys() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-ActionType-TypeSettings-GetData``1-System-String-'></a>
### GetData\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-ActionType-TypeSettings-SetData-System-String,System-Object-'></a>
### SetData() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-FurnitureType-TypeSettings-GetDataKeys'></a>
### GetDataKeys() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-FurnitureType-TypeSettings-GetData``1-System-String-'></a>
### GetData\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Objects-FurnitureType-TypeSettings-SetData-System-String,System-Object-'></a>
### SetData() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-Actions-UnderlyingAction'></a>
## UnderlyingAction `type`

##### Namespace

TinyLife.Actions

##### Summary

An UnderlyingAction is a class that can instantiate a single [Action](#P-TinyLife-Actions-UnderlyingAction-Action 'TinyLife.Actions.UnderlyingAction.Action') that will be executed as part of the action it is used in.
Note that, when using this class, [Update](#M-TinyLife-Actions-UnderlyingAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.UnderlyingAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)') and [Validate](#M-TinyLife-Actions-UnderlyingAction-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.UnderlyingAction.Validate(TinyLife.Objects.Person)') have to be called in the appropriate places.

<a name='P-TinyLife-Actions-UnderlyingAction-Action'></a>
### Action `property`

##### Summary

The underlying action.
This should be initialized using [Initialize](#M-TinyLife-Actions-UnderlyingAction-Initialize-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo- 'TinyLife.Actions.UnderlyingAction.Initialize(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)').

<a name='M-TinyLife-Actions-UnderlyingAction-Initialize-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### Initialize(type,info) `method`

##### Summary

Initializes the underlying action of this action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [TinyLife.Actions.ActionType](#T-TinyLife-Actions-ActionType 'TinyLife.Actions.ActionType') | The type of action to initialize |
| info | [TinyLife.Actions.ActionInfo](#T-TinyLife-Actions-ActionInfo 'TinyLife.Actions.ActionInfo') | The info to pass to the action |

<a name='M-TinyLife-Actions-UnderlyingAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update(time,passedInGame,speed) `method`

##### Summary

Updates the [Action](#P-TinyLife-Actions-UnderlyingAction-Action 'TinyLife.Actions.UnderlyingAction.Action'), if it exists.
This action should be called in [Update](#M-TinyLife-Actions-Action-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed- 'TinyLife.Actions.Action.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| passedInGame | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The amount of time that has passed, in game time |
| speed | [TinyLife.GameSpeed](#T-TinyLife-GameSpeed 'TinyLife.GameSpeed') | The game's current speed setting |

<a name='M-TinyLife-Actions-UnderlyingAction-Validate-TinyLife-Objects-Person-'></a>
### Validate(person) `method`

##### Summary

Validates this action container and its [Action](#P-TinyLife-Actions-UnderlyingAction-Action 'TinyLife.Actions.UnderlyingAction.Action').
This method should be called in [Validate](#M-TinyLife-Actions-Action-Validate-TinyLife-Objects-Person- 'TinyLife.Actions.Action.Validate(TinyLife.Objects.Person)').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| person | [TinyLife.Objects.Person](#T-TinyLife-Objects-Person 'TinyLife.Objects.Person') |  |

<a name='T-TinyLife-Mods-Events-UpdateEvent`1'></a>
## UpdateEvent\`1 `type`

##### Namespace

TinyLife.Mods.Events

##### Summary

A delegate used by events that are invoked when something is updated

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [T:TinyLife.Mods.Events.UpdateEvent\`1](#T-T-TinyLife-Mods-Events-UpdateEvent`1 'T:TinyLife.Mods.Events.UpdateEvent`1') | The object being updated |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of object that the event is being invoked for |

<a name='T-TinyLife-Actions-WalkAction'></a>
## WalkAction `type`

##### Namespace

TinyLife.Actions

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Actions-WalkAction-#ctor-TinyLife-Actions-ActionType,TinyLife-Actions-ActionInfo-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Actions-WalkAction-FindPath-Microsoft-Xna-Framework-Point-'></a>
### FindPath() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-WalkAction-GetSpeed'></a>
### GetSpeed() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Actions-WalkAction-Update-Microsoft-Xna-Framework-GameTime,System-TimeSpan,TinyLife-GameSpeed-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-Wall'></a>
## Wall `type`

##### Namespace

TinyLife.World

##### Summary

A wall is an element of a [Map](#T-TinyLife-World-Map 'TinyLife.World.Map') that stops traversal and that has a [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') and optionally an [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening') attached to it.

<a name='M-TinyLife-World-Wall-#ctor-Microsoft-Xna-Framework-Point[]-'></a>
### #ctor(positions) `constructor`

##### Summary

Creates a new wall at the given position, with the implicitly given verticality

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| positions | [Microsoft.Xna.Framework.Point[]](#T-Microsoft-Xna-Framework-Point[] 'Microsoft.Xna.Framework.Point[]') | The positions that the wall should be placed between |

<a name='F-TinyLife-World-Wall-DisplayModes'></a>
### DisplayModes `constants`

##### Summary

All defined values of the [WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode') enumeration

<a name='F-TinyLife-World-Wall-Positions'></a>
### Positions `constants`

##### Summary

The two positions that this wall is placed in.
The two positions refer to the tile coordinate of the tile on the front face of the wall, and the tile coordinate of the tile on the back face of the wall.

<a name='F-TinyLife-World-Wall-Price'></a>
### Price `constants`

##### Summary

The price of building a single wall element

<a name='F-TinyLife-World-Wall-Wallpapers'></a>
### Wallpapers `constants`

##### Summary

The two wallpapers attached to this [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall'), on either one of its sides

<a name='P-TinyLife-World-Wall-Opening'></a>
### Opening `property`

##### Summary

The [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening') attached to this wall, or null if there is none.
Use [SetOpening](#M-TinyLife-World-Wall-SetOpening-TinyLife-World-Map,TinyLife-World-Opening- 'TinyLife.World.Wall.SetOpening(TinyLife.World.Map,TinyLife.World.Opening)') to set this value.

<a name='P-TinyLife-World-Wall-Vertical'></a>
### Vertical `property`

##### Summary

Stores whether this wall is vertical. A vertical wall is one where the [Positions](#F-TinyLife-World-Wall-Positions 'TinyLife.World.Wall.Positions') have the same y, but different x coordinates.

<a name='M-TinyLife-World-Wall-Draw-TinyLife-World-Map,Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2-'></a>
### Draw(map,time,batch,drawPos) `method`

##### Summary

Draws this wall in the world, along with its [Wallpapers](#F-TinyLife-World-Wall-Wallpapers 'TinyLife.World.Wall.Wallpapers') and [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map to draw this wall on |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The game time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch to draw with |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position to draw the wall at, in draw space |

<a name='M-TinyLife-World-Wall-GetDepth-TinyLife-World-Map,System-Single-'></a>
### GetDepth(map,offset) `method`

##### Summary

Returns the depth that should be used for a wall placed at this wall's positions.
This method is used for rendering [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') and [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map that this wall is on |
| offset | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | An offset that will be added to the depth calculation |

<a name='M-TinyLife-World-Wall-GetDisplayMode'></a>
### GetDisplayMode() `method`

##### Summary

Returns the [WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode') that this wall should be rendered with.
If the [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening') is nonnull, its [WallMode](#F-TinyLife-World-OpeningType-WallMode 'TinyLife.World.OpeningType.WallMode') is returned.

##### Returns

The wall mode

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Wall-GetIndexForCamera'></a>
### GetIndexForCamera() `method`

##### Summary

Returns the side of the wall that should be rendered.
For [Vertical](#P-TinyLife-World-Wall-Vertical 'TinyLife.World.Wall.Vertical') walls, the position with the highest X value is returned.
For non-[Vertical](#P-TinyLife-World-Wall-Vertical 'TinyLife.World.Wall.Vertical') walls, the position with the highest Y value is returned.

##### Returns

The side of the wall that should be rendered

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Wall-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Wall-IsDown'></a>
### IsDown() `method`

##### Summary

Returns whether this wall should be rendered with a lower height than its actual height.
If this value returns true, [Draw](#M-TinyLife-World-Wall-Draw-TinyLife-World-Map,Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2- 'TinyLife.World.Wall.Draw(TinyLife.World.Map,Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2)') only draws the first 5 or so pixels of the wall to allow for a simple view of what is behind the wall.
This value is based on the lot visibility, the [WallMode](#P-TinyLife-Options-WallMode 'TinyLife.Options.WallMode') and more.

##### Returns

Whether the wall should be rendered down

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Wall-SetOpening-TinyLife-World-Map,TinyLife-World-Opening-'></a>
### SetOpening(map,opening) `method`

##### Summary

Changes the [Opening](#P-TinyLife-World-Wall-Opening 'TinyLife.World.Wall.Opening') in this wall to the specified one

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| map | [TinyLife.World.Map](#T-TinyLife-World-Map 'TinyLife.World.Map') | The map that this wall is on |
| opening | [TinyLife.World.Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening') | The opening to set, or null to remove the current one |

<a name='M-TinyLife-World-Wall-Validate'></a>
### Validate() `method`

##### Summary

This method is called when this object is loaded from disk.

##### Returns

false if the object is not valid, true otherwise

##### Parameters

This method has no parameters.

<a name='T-TinyLife-WallDisplay'></a>
## WallDisplay `type`

##### Namespace

TinyLife

##### Summary

The possible modes that a [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall') and [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') can display in.
The ordering of this enumeration is based on how much of the walls (and roofs) can be seen.

<a name='F-TinyLife-WallDisplay-Auto'></a>
### Auto `constants`

##### Summary

A wall display that represents the back walls of buildings being [Up](#F-TinyLife-WallDisplay-Up 'TinyLife.WallDisplay.Up'), but the front wals being [Down](#F-TinyLife-WallDisplay-Down 'TinyLife.WallDisplay.Down')

<a name='F-TinyLife-WallDisplay-Down'></a>
### Down `constants`

##### Summary

A wall display that represents only the lowest few pixels of each wall being displayed

<a name='F-TinyLife-WallDisplay-Roofs'></a>
### Roofs `constants`

##### Summary

A wall display that represents full walls and the roofs of buildings being displayed

<a name='F-TinyLife-WallDisplay-Up'></a>
### Up `constants`

##### Summary

A wall display that represents full walls, but no roofs, being displayed

<a name='T-TinyLife-World-WallMode'></a>
## WallMode `type`

##### Namespace

TinyLife.World

##### Summary

This enumeration defines the possible rendering types for [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper').
By default, [Full](#F-TinyLife-World-WallMode-Full 'TinyLife.World.WallMode.Full') is rendered, but an [Opening](#T-TinyLife-World-Opening 'TinyLife.World.Opening') can change the type to allow for windows, doors etc.

<a name='F-TinyLife-World-WallMode-Door'></a>
### Door `constants`

##### Summary

A wall mode that represents a wall with a door-shaped hole in it

<a name='F-TinyLife-World-WallMode-Full'></a>
### Full `constants`

##### Summary

A wall mode that represents a wall that is rendered in full, without any holes in it

<a name='F-TinyLife-World-WallMode-Roof'></a>
### Roof `constants`

##### Summary

A wall mode that represents a wall used on the faces of a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') that are straight

<a name='F-TinyLife-World-WallMode-RoofGable'></a>
### RoofGable `constants`

##### Summary

A wall mode that represents a wall used on the faces of a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') that are gabled

<a name='F-TinyLife-World-WallMode-RoofGableInverse'></a>
### RoofGableInverse `constants`

##### Summary

A wall mode that represents a wall used on the faces of a [Roof](#T-TinyLife-World-Roof 'TinyLife.World.Roof') that are gabled in the opposite direction as [RoofGable](#F-TinyLife-World-WallMode-RoofGable 'TinyLife.World.WallMode.RoofGable')

<a name='F-TinyLife-World-WallMode-SmallWindow'></a>
### SmallWindow `constants`

##### Summary

A wall mode that represents a wall with a small, rectanglular window in it

<a name='T-TinyLife-Tools-WallTool'></a>
## WallTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-WallTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-WallTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-TinyLife-World-Wallpaper'></a>
## Wallpaper `type`

##### Namespace

TinyLife.World

##### Summary

A wallpaper is a single-instanced object that can be attached to a [Wall](#T-TinyLife-World-Wall 'TinyLife.World.Wall'), which makes the wall render a different texture.
To register custom wallpapers, use [Register](#M-TinyLife-World-Wallpaper-Register-System-String,System-Int32,MLEM-Textures-UniformTextureAtlas,Microsoft-Xna-Framework-Point,TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion- 'TinyLife.World.Wallpaper.Register(System.String,System.Int32,MLEM.Textures.UniformTextureAtlas,Microsoft.Xna.Framework.Point,TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)'). Note that registered wallpapers need to use a texture generated by [ApplyWallpaperMasks](#M-TinyLife-Utilities-TextureHandler-ApplyWallpaperMasks-Microsoft-Xna-Framework-Graphics-Texture2D,System-Int32,System-Int32,System-Action{MLEM-Textures-UniformTextureAtlas}- 'TinyLife.Utilities.TextureHandler.ApplyWallpaperMasks(Microsoft.Xna.Framework.Graphics.Texture2D,System.Int32,System.Int32,System.Action{MLEM.Textures.UniformTextureAtlas})').

<a name='F-TinyLife-World-Wallpaper-BaseName'></a>
### BaseName `constants`

##### Summary

The name of this type of wallpaper. Whereas [Name](#F-TinyLife-World-Wallpaper-Name 'TinyLife.World.Wallpaper.Name') has the index of its [color](#F-TinyLife-World-Wallpaper-color 'TinyLife.World.Wallpaper.color') appended to it, this one is just the type's name.

<a name='F-TinyLife-World-Wallpaper-ColorScheme'></a>
### ColorScheme `constants`

##### Summary

The [ColorScheme](#F-TinyLife-World-Wallpaper-ColorScheme 'TinyLife.World.Wallpaper.ColorScheme') that this wallpaper type uses

<a name='F-TinyLife-World-Wallpaper-Icon'></a>
### Icon `constants`

##### Summary

The build mode icon for this object, which represents the category / theme / mod that it comes from.
If this value is nonnull, the icon will be displayed in the corner of the build mode button for this object.

<a name='F-TinyLife-World-Wallpaper-Name'></a>
### Name `constants`

##### Summary

The name of this specific wallpaper. This is comprised of the [BaseName](#F-TinyLife-World-Wallpaper-BaseName 'TinyLife.World.Wallpaper.BaseName') with the [color](#F-TinyLife-World-Wallpaper-color 'TinyLife.World.Wallpaper.color')'s index attached to it.

<a name='F-TinyLife-World-Wallpaper-Price'></a>
### Price `constants`

##### Summary

The price of this wallpaper. Can be retrieved easily using [GetPrice](#M-TinyLife-World-Wallpaper-GetPrice 'TinyLife.World.Wallpaper.GetPrice').

<a name='F-TinyLife-World-Wallpaper-Wallpapers'></a>
### Wallpapers `constants`

##### Summary

The registry for all [Wallpaper](#T-TinyLife-World-Wallpaper 'TinyLife.World.Wallpaper') objects in the game and mods.
Use [Register](#M-TinyLife-World-Wallpaper-Register-System-String,System-Int32,MLEM-Textures-UniformTextureAtlas,Microsoft-Xna-Framework-Point,TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion- 'TinyLife.World.Wallpaper.Register(System.String,System.Int32,MLEM.Textures.UniformTextureAtlas,Microsoft.Xna.Framework.Point,TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)') to register custom wallpapers.

<a name='M-TinyLife-World-Wallpaper-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-Vector2,TinyLife-World-WallMode,System-Boolean,System-Boolean,System-Single,System-Single,System-Boolean-'></a>
### Draw(time,batch,drawPos,mode,isDown,vertical,scale,depth,shadow) `method`

##### Summary

Draws this wallpaper on the given wall with the given data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The sprite batch used for rendering |
| drawPos | [Microsoft.Xna.Framework.Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') | The position, in screen coordinates, that the wall should be drawn at |
| mode | [TinyLife.World.WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode') | The [WallMode](#T-TinyLife-World-WallMode 'TinyLife.World.WallMode') that the wall should be drawn with |
| isDown | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the wall is rendering with a reduced height |
| vertical | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the wall is vertical (or horizontal) in the world |
| scale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale that the wall should be rendered with |
| depth | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The depth that the wall should be rendered with |
| shadow | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the shadow texture should be applied on top of the texture |

<a name='M-TinyLife-World-Wallpaper-DrawUi-MLEM-Ui-Elements-Element,Microsoft-Xna-Framework-Graphics-SpriteBatch,Microsoft-Xna-Framework-GameTime,System-Single-'></a>
### DrawUi(e,batch,time,drawScale) `method`

##### Summary

Draws this wallpaper on the given [Element](#T-MLEM-Ui-Elements-Element 'MLEM.Ui.Elements.Element') in ui space

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MLEM.Ui.Elements.Element](#T-MLEM-Ui-Elements-Element 'MLEM.Ui.Elements.Element') | The element to draw on |
| batch | [Microsoft.Xna.Framework.Graphics.SpriteBatch](#T-Microsoft-Xna-Framework-Graphics-SpriteBatch 'Microsoft.Xna.Framework.Graphics.SpriteBatch') | The batch to draw with |
| time | [Microsoft.Xna.Framework.GameTime](#T-Microsoft-Xna-Framework-GameTime 'Microsoft.Xna.Framework.GameTime') | The current game time |
| drawScale | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The scale to draw with. Defaults to 0.3. |

<a name='M-TinyLife-World-Wallpaper-GetPrice'></a>
### GetPrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-World-Wallpaper-Register-System-String,System-Int32,MLEM-Textures-UniformTextureAtlas,Microsoft-Xna-Framework-Point,TinyLife-Utilities-ColorScheme,MLEM-Textures-TextureRegion-'></a>
### Register(name,price,texture,textureRegion,colors,icon) `method`

##### Summary

Creates and registers a new wallpaper with the given settings.
Note that the `texture` should be one generated using [ApplyWallpaperMasks](#M-TinyLife-Utilities-TextureHandler-ApplyWallpaperMasks-Microsoft-Xna-Framework-Graphics-Texture2D,System-Int32,System-Int32,System-Action{MLEM-Textures-UniformTextureAtlas}- 'TinyLife.Utilities.TextureHandler.ApplyWallpaperMasks(Microsoft.Xna.Framework.Graphics.Texture2D,System.Int32,System.Int32,System.Action{MLEM.Textures.UniformTextureAtlas})'), as otherwise, graphical issues will occur.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the wallpaper type |
| price | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The price of a single wallpaper of this type |
| texture | [MLEM.Textures.UniformTextureAtlas](#T-MLEM-Textures-UniformTextureAtlas 'MLEM.Textures.UniformTextureAtlas') | The texture that this wallpaper should use. This needs to have been generated using [ApplyWallpaperMasks](#M-TinyLife-Utilities-TextureHandler-ApplyWallpaperMasks-Microsoft-Xna-Framework-Graphics-Texture2D,System-Int32,System-Int32,System-Action{MLEM-Textures-UniformTextureAtlas}- 'TinyLife.Utilities.TextureHandler.ApplyWallpaperMasks(Microsoft.Xna.Framework.Graphics.Texture2D,System.Int32,System.Int32,System.Action{MLEM.Textures.UniformTextureAtlas})'). |
| textureRegion | [Microsoft.Xna.Framework.Point](#T-Microsoft-Xna-Framework-Point 'Microsoft.Xna.Framework.Point') | The top left texture region of this wallpaper (on the original texture, not the mask) |
| colors | [TinyLife.Utilities.ColorScheme](#T-TinyLife-Utilities-ColorScheme 'TinyLife.Utilities.ColorScheme') | The color scheme of the wallpaper |
| icon | [MLEM.Textures.TextureRegion](#T-MLEM-Textures-TextureRegion 'MLEM.Textures.TextureRegion') | The build mode category icon of this object |

<a name='T-TinyLife-Tools-WallpaperTool'></a>
## WallpaperTool `type`

##### Namespace

TinyLife.Tools

##### Summary

*Inherit from parent.*

<a name='M-TinyLife-Tools-WallpaperTool-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-TinyLife-Tools-WallpaperTool-Draw-Microsoft-Xna-Framework-GameTime,Microsoft-Xna-Framework-Graphics-SpriteBatch-'></a>
### Draw() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallpaperTool-GetMouseCursor'></a>
### GetMouseCursor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallpaperTool-InitBuildModeUi-MLEM-Ui-Elements-Panel,MLEM-Ui-Elements-Panel-'></a>
### InitBuildModeUi() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallpaperTool-ShouldHighlightSelectedObject'></a>
### ShouldHighlightSelectedObject() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-TinyLife-Tools-WallpaperTool-Update-Microsoft-Xna-Framework-GameTime-'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
