using System;
using Server.Items;
using Server.Network;
using Server.Targeting;
using Server.Engines.Craft;
using Server.Mobiles;
using Server.Engines.XmlSpawner2;


namespace Server.Engines.Craft
{
	public class DefBlacksmithy : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Blacksmith;	}
		}

		public override int GumpTitleNumber
		{
			get { return 1044002; } // <CENTER>BLACKSMITHY MENU</CENTER>
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefBlacksmithy();

				return m_CraftSystem;
			}
		}

		public override CraftECA ECA{ get{ return CraftECA.ChanceMinusSixtyToFourtyFive; } }

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.0; // 0%
		}

		private DefBlacksmithy() : base( 1, 1, 1.25 )// base( 1, 2, 1.7 )
		{
			/*
			
			base( MinCraftEffect, MaxCraftEffect, Delay )
			
			MinCraftEffect	: The minimum number of time the mobile will play the craft effect
			MaxCraftEffect	: The maximum number of time the mobile will play the craft effect
			Delay			: The delay between each craft effect
			
			Example: (3, 6, 1.7) would make the mobile do the PlayCraftEffect override
			function between 3 and 6 time, with a 1.7 second delay each time.
			
			*/ 
		}

		private static Type typeofAnvil = typeof( AnvilAttribute );
		private static Type typeofForge = typeof( ForgeAttribute );

		public static bool IsForge( object obj )
		{
			if ( Core.ML && obj is Mobile && ((Mobile)obj).IsDeadBondedPet )
				return false;

			if ( obj.GetType().IsDefined( typeof( ForgeAttribute ), false ) )
				return true;

			int itemID = 0;

			if ( obj is Item )
				itemID = ((Item)obj).ItemID;
			else if ( obj is StaticTarget )
				itemID = ((StaticTarget)obj).ItemID;

			if ( itemID >= 6896 && itemID <= 6898 )
			{
				if ( obj is FireGiantForge )
				{
					FireGiantForge kettle = (FireGiantForge)obj;
					Server.Items.FireGiantForge.ConsumeCharge( kettle );
					return true;
				}
			}

			return ( itemID == 4017 || (itemID >= 0x10DE && itemID <= 0x10E0) || (itemID >= 6522 && itemID <= 6569) );
		}

		public static void CheckAnvilAndForge( Mobile from, int range, out bool anvil, out bool forge )
		{
			anvil = false;
			forge = false;

			Map map = from.Map;

			if ( map == null )
				return;

			IPooledEnumerable eable = map.GetItemsInRange( from.Location, range );

			foreach ( Item item in eable )
			{
				Type type = item.GetType();

				bool isAnvil = ( type.IsDefined( typeofAnvil, false ) || item.ItemID == 4015 || item.ItemID == 4016 || item.ItemID == 0x2DD5 || item.ItemID == 0x2DD6 || item.ItemID == 0x2B55 || item.ItemID == 0x2B57 );
				bool isForge = ( type.IsDefined( typeofForge, false ) || item.ItemID == 4017 || (item.ItemID >= 0x10DE && item.ItemID <= 0x10E0) || (item.ItemID >= 6522 && item.ItemID <= 6569) || item.ItemID == 0x2DD8 );

				if ( isAnvil || isForge )
				{
					if ( (from.Z + 16) < item.Z || (item.Z + 16) < from.Z || !from.InLOS( item ) )
						continue;

					anvil = anvil || isAnvil;
					forge = forge || isForge;

					if ( anvil && forge )
						break;
				}
			}

			eable.Free();

			for ( int x = -range; (!anvil || !forge) && x <= range; ++x )
			{
				for ( int y = -range; (!anvil || !forge) && y <= range; ++y )
				{
					StaticTile[] tiles = map.Tiles.GetStaticTiles( from.X+x, from.Y+y, true );

					for ( int i = 0; (!anvil || !forge) && i < tiles.Length; ++i )
					{
						int id = tiles[i].ID;

						bool isAnvil = ( id == 4015 || id == 4016 || id == 0x2DD5 || id == 0x2DD6 || id == 0x2B55 || id == 0x2B57 );
						bool isForge = ( id == 4017 || (id >= 0x10DE && id <= 0x10E0) || (id >= 6522 && id <= 6569) || id == 0x2DD8 );

						if ( isAnvil || isForge )
						{
							if ( (from.Z + 16) < tiles[i].Z || (tiles[i].Z + 16) < from.Z || !from.InLOS( new Point3D( from.X+x, from.Y+y, tiles[i].Z + (tiles[i].Height/2) + 1 ) ) )
								continue;

							anvil = anvil || isAnvil;
							forge = forge || isForge;
						}
					}
				}
			}
		}

		public override object CanCraft( Mobile from, BaseTool tool, Type itemType )
		{
			if ( tool == null || tool.Deleted || tool.UsesRemaining < 0 )
				return 1044038; // You have worn out your tool!
			else if ( !BaseTool.CheckTool( tool, from ) )
				return 1048146; // If you have a tool equipped, you must use that tool.
			else if ( !BaseTool.CheckAccessible( tool, from ) )
				return 1044263; // The tool must be on your person to use.

			bool anvil, forge;
			CheckAnvilAndForge( from, 2, out anvil, out forge );

			if ( anvil && forge )
				return 0;

			return 1044267; // You must be near an anvil and a forge to smith items.
		}

		public override void PlayCraftEffect( Mobile from )
		{
			// no animation, instant sound
			//if ( from.Body.Type == BodyType.Human && !from.Mounted )
			//	from.Animate( 9, 5, 1, true, false, 0 );
			//new InternalTimer( from ).Start();

			from.PlaySound( 0x541 );
		}

		// Delay to synchronize the sound with the hit on the anvil
		private class InternalTimer : Timer
		{
			private Mobile m_From;

			public InternalTimer( Mobile from ) : base( TimeSpan.FromSeconds( 0.7 ) )
			{
				m_From = from;
			}

			protected override void OnTick()
			{
				m_From.PlaySound( 0x541 );
			}
		}

		public override int PlayEndingEffect( Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality, bool makersMark, CraftItem item )
		{
			if ( toolBroken )
				from.SendLocalizedMessage( 1044038 ); // You have worn out your tool

			if ( failed )
			{
				if ( lostMaterial )
					return 1044043; // You failed to create the item, and some of your materials are lost.
				else
					return 1044157; // You failed to create the item, but no materials were lost.
			}
			else
			{
				if ( quality == 0 )
					return 502785; // You were barely able to make this item.  It's quality is below average.
				else if ( makersMark && quality == 2 )
			
				
					return 1044156; // You create an exceptional quality item and affix your maker's mark.
				
				else if ( quality == 2 )
				
					return 1044155; // You create an exceptional quality item.
				
				else				
					return 1044154; // You create the item.
			}
		}

		public override void InitCraftList()
		{
			/*
			Synthax for a SIMPLE craft item
			AddCraft( ObjectType, Group, MinSkill, MaxSkill, ResourceType, Amount, Message )
			
			ObjectType		: The type of the object you want to add to the build list.
			Group			: The group in wich the object will be showed in the craft menu.
			MinSkill		: The minimum of skill value
			MaxSkill		: The maximum of skill value
			ResourceType	: The type of the resource the mobile need to create the item
			Amount			: The amount of the ResourceType it need to create the item
			Message			: String or Int for Localized.  The message that will be sent to the mobile, if the specified resource is missing.
			
			Synthax for a COMPLEXE craft item.  A complexe item is an item that need either more than
			only one skill, or more than only one resource.
			
			Coming soon....
			*/

			#region Chainmail
			AddCraft( typeof( ChainCoif ), "Chain/Ring/Banded", 1025051, 14.5, 64.5, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( ChainLegs ), "Chain/Ring/Banded", 1025054, 36.7, 86.7, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( ChainChest ), "Chain/Ring/Banded", 1025055, 39.1, 89.1, typeof( IronIngot ), 1044036, 20, 1044037 );
			#endregion

			#region Ringmail
			AddCraft( typeof( RingmailGloves ), "Chain/Ring/Banded", 1025099, 12.0, 62.0, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( RingmailLegs ), "Chain/Ring/Banded", 1025104, 19.4, 69.4, typeof( IronIngot ), 1044036, 16, 1044037 );
			AddCraft( typeof( RingmailArms ), "Chain/Ring/Banded", 1025103, 16.9, 66.9, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( RingmailChest ), "Chain/Ring/Banded", 1025100, 21.9, 71.9, typeof( IronIngot ), 1044036, 18, 1044037 );
			#endregion

			AddCraft( typeof( RingmailSkirt ), "Chain/Ring/Banded", "banded mail skirt", 19.4, 69.4, typeof( IronIngot ), 1044036, 16, 1044037 );
			AddCraft( typeof( ChainSkirt ), "Chain/Ring/Banded", "metal skirt", 36.7, 86.7, typeof( IronIngot ), 1044036, 18, 1044037 );

			int index = -1;

			#region Platemail
			AddCraft( typeof( PlateArms ), 1011078, 1025136, 66.3, 116.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( PlateGloves ), 1011078, 1025140, 58.9, 108.9, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( PlateGorget ), 1011078, 1025139, 56.4, 106.4, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( PlateLegs ), 1011078, 1025137, 68.8, 118.8, typeof( IronIngot ), 1044036, 20, 1044037 );
			AddCraft( typeof( PlateSkirt ), 1011078, "platemail skirt", 68.8, 118.8, typeof( IronIngot ), 1044036, 20, 1044037 );
			AddCraft( typeof( PlateChest ), 1011078, 1046431, 75.0, 125.0, typeof( IronIngot ), 1044036, 25, 1044037 );
			AddCraft( typeof( FemalePlateChest ), 1011078, 1046430, 44.1, 94.1, typeof( IronIngot ), 1044036, 20, 1044037 );

			if ( Core.AOS ) // exact pre-aos functionality unknown
				AddCraft( typeof( DragonBardingDeed ), 1011078, 1053012, 72.5, 122.5, typeof( IronIngot ), 1044036, 750, 1044037 );

			if( Core.SE )
			{
				
				index = AddCraft( typeof( PlateMempo ), 1011078, 1030180, 80.0, 130.0, typeof( IronIngot ), 1044036, 18, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( PlateDo ), 1011078, 1030184, 80.0, 130.0, typeof( IronIngot ), 1044036, 28, 1044037 ); //Double check skill
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( PlateHiroSode ), 1011078, 1030187, 80.0, 130.0, typeof( IronIngot ), 1044036, 16, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( PlateSuneate ), 1011078, 1030195, 65.0, 115.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( PlateHaidate ), 1011078, 1030200, 65.0, 115.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				
			}
			#endregion

			#region Royal
			AddCraft( typeof( RoyalBoots ), "Royal Armor", "royal boots", 88.9, 118.9, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( RoyalGloves ), "Royal Armor", "royal bracers", 88.9, 118.9, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( RoyalGorget ), "Royal Armor", "royal gorget", 86.4, 116.4, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( RoyalHelm ), "Royal Armor", "royal helm", 92.6, 122.6, typeof( IronIngot ), 1044036, 15, 1044037 );
			AddCraft( typeof( RoyalsLegs ), "Royal Armor", "royal leggings", 96.8, 125.0, typeof( IronIngot ), 1044036, 20, 1044037 );
			AddCraft( typeof( RoyalArms ), "Royal Armor", "royal mantle", 96.3, 125.0, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( RoyalChest ), "Royal Armor", "royal tunic", 98.0, 125.0, typeof( IronIngot ), 1044036, 25, 1044037 );
			#endregion

			#region Helmets
			AddCraft( typeof( Bascinet ), 1011079, 1025132, 8.3, 58.3, typeof( IronIngot ), 1044036, 15, 1044037 );
			AddCraft( typeof( CloseHelm ), 1011079, 1025128, 37.9, 87.9, typeof( IronIngot ), 1044036, 15, 1044037 );
			AddCraft( typeof( Helmet ), 1011079, 1025130, 37.9, 87.9, typeof( IronIngot ), 1044036, 15, 1044037 );
			AddCraft( typeof( NorseHelm ), 1011079, 1025134, 37.9, 87.9, typeof( IronIngot ), 1044036, 15, 1044037 );
			AddCraft( typeof( PlateHelm ), 1011079, 1025138, 62.6, 112.6, typeof( IronIngot ), 1044036, 15, 1044037 );
			AddCraft( typeof( DreadHelm ), 1011079, "dread helm", 62.6, 112.6, typeof( IronIngot ), 1044036, 15, 1044037 );
			
			if( Core.SE )
			{
				index = AddCraft( typeof( ChainHatsuburi ), 1011079, 1030175, 30.0, 80.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( PlateHatsuburi ), 1011079, 1030176, 45.0, 95.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( HeavyPlateJingasa ), 1011079, 1030178, 45.0, 95.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				
				index = AddCraft( typeof( LightPlateJingasa ), 1011079, 1030188, 45.0, 95.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				
				index = AddCraft( typeof( SmallPlateJingasa ), 1011079, 1030191, 45.0, 95.0, typeof( IronIngot ), 1044036, 20, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( DecorativePlateKabuto ), 1011079, 1030179, 90.0, 140.0, typeof( IronIngot ), 1044036, 25, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				
				index = AddCraft( typeof( PlateBattleKabuto ), 1011079, 1030192, 90.0, 140.0, typeof( IronIngot ), 1044036, 25, 1044037 );
				SetNeededExpansion( index, Expansion.SE );

				index = AddCraft( typeof( StandardPlateKabuto ), 1011079, 1030196, 90.0, 140.0, typeof( IronIngot ), 1044036, 25, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
			}
			#endregion

			#region Shields
			AddCraft( typeof( Buckler ), 1011080, 1027027, -25.0, 25.0, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( BronzeShield ), 1011080, "round shield", -15.2, 34.8, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( HeaterShield ), 1011080, 1027030, 24.3, 74.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( MetalShield ), 1011080, 1027035, -10.2, 39.8, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( MetalKiteShield ), 1011080, 1027028, 4.6, 54.6, typeof( IronIngot ), 1044036, 16, 1044037 );
			AddCraft( typeof( WoodenKiteShield ), 1011080, 1027032, -15.2, 34.8, typeof( IronIngot ), 1044036, 8, 1044037 );
			AddCraft( typeof( RoyalShield ), 1011080, "royal shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( GuardsmanShield ), 1011080, "guardsman shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( ElvenShield ), 1011080, "elven shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( DarkShield ), 1011080, "dark shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( CrestedShield ), 1011080, "crested shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddCraft( typeof( ChampionShield ), 1011080, "champion shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			index = AddCraft( typeof( JeweledShield ), 1011080, "jeweled shield", 54.3, 84.3, typeof( IronIngot ), 1044036, 18, 1044037 );
			AddRes( index, typeof( StarSapphire ), 1023855, 1, 1044037 );

			if ( Core.AOS )
			{
				AddCraft( typeof( ChaosShield ), 1011080, "chaos shield", 85.0, 135.0, typeof( IronIngot ), 1044036, 25, 1044037 );
				AddCraft( typeof( OrderShield ), 1011080, "order shield", 85.0, 135.0, typeof( IronIngot ), 1044036, 25, 1044037 );
			}
			#endregion

			#region Bladed

			AddCraft( typeof( AssassinSpike ), 1011081, "assassin dagger", 10.0, 49.6, typeof( IronIngot ), 1044036, 3, 1044037 );
			AddCraft( typeof( ElvenSpellblade ), 1011081, "assassin sword", 44.1, 94.1, typeof( IronIngot ), 1044036, 8, 1044037 );
			AddCraft( typeof( BoneHarvester ), 1011081, 1029915, 33.0, 83.0, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( Broadsword ), 1011081, 1023934, 35.4, 85.4, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( CrescentBlade ), 1011081, 1029921, 45.0, 95.0, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( Cutlass ), 1011081, 1025185, 24.3, 74.3, typeof( IronIngot ), 1044036, 8, 1044037 );
			AddCraft( typeof( Dagger ), 1011081, 1023921, -0.4, 49.6, typeof( IronIngot ), 1044036, 3, 1044037 );
			AddCraft( typeof( RadiantScimitar ), 1011081, "falchion", 35.4, 85.4, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( Katana ),1011081, 1025119, 44.1, 94.1, typeof( IronIngot ), 1044036, 8, 1044037 );
			AddCraft( typeof( Kryss ), 1011081, 1025121, 36.7, 86.7, typeof( IronIngot ), 1044036, 8, 1044037 );
			AddCraft( typeof( Longsword ), 1011081, 1023937, 28.0, 78.0, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( ElvenMachete ), 1011081, "machete", 33.0, 83.0, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( RoyalSword ), 1011081, "royal sword", 54.3, 84.3, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( Scimitar ), 1011081, 1025046, 31.7, 81.7, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( VikingSword ), 1011081, 1025049, 24.3, 74.3, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( RuneBlade ), 1011081, "war blades", 28.0, 78.0, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( WarCleaver ), 1011081, "war cleaver", 10.0, 49.6, typeof( IronIngot ), 1044036, 3, 1044037 );
			AddCraft( typeof( Leafblade ), 1011081, "war dagger", 20.0, 59.6, typeof( IronIngot ), 1044036, 5, 1044037 );

			if( Core.SE )
			{
				index = AddCraft( typeof( NoDachi ), 1011081, 1030221, 75.0, 125.0, typeof( IronIngot ), 1044036, 18, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Wakizashi ), 1011081, 1030223, 50.0, 100.0, typeof( IronIngot ), 1044036, 8, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Lajatang ), 1011081, 1030226, 80.0, 130.0, typeof( IronIngot ), 1044036, 25, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Daisho ), 1011081, 1030228, 60.0, 110.0, typeof( IronIngot ), 1044036, 15, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Tekagi ), 1011081, 1030230, 55.0, 105.0, typeof( IronIngot ), 1044036, 12, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Shuriken ), 1011081, 1030231, 45.0, 95.0, typeof( IronIngot ), 1044036, 5, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Kama ), 1011081, 1030232, 40.0, 90.0, typeof( IronIngot ), 1044036, 14, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
				index = AddCraft( typeof( Sai ), 1011081, 1030234, 50.0, 100.0, typeof( IronIngot ), 1044036, 12, 1044037 );
				SetNeededExpansion( index, Expansion.SE );
			}
			#endregion

			#region Axes

			AddCraft( typeof( Hatchet ), 1011082, 1029584, 24.2, 74.2, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( LumberAxe ), 1011082, "lumber axe", 24.2, 74.2, typeof( IronIngot ), 1044036, 10, 1044037 );
			AddCraft( typeof( Axe ), 1011082, 1023913, 34.2, 84.2, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( BattleAxe ), 1011082, 1023911, 30.5, 80.5, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( DoubleAxe ), 1011082, 1023915, 29.3, 79.3, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( ExecutionersAxe ), 1011082, 1023909, 34.2, 84.2, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( LargeBattleAxe ), 1011082, 1025115, 28.0, 78.0, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( TwoHandedAxe ), 1011082, 1025187, 33.0, 83.0, typeof( IronIngot ), 1044036, 16, 1044037 );
			AddCraft( typeof( WarAxe ), 1011082, 1025040, 39.1, 89.1, typeof( IronIngot ), 1044036, 16, 1044037 );
			AddCraft( typeof( OrnateAxe ), 1011082, "barbarian axe", 39.1, 89.1, typeof( IronIngot ), 1044036, 16, 1044037 );

			#endregion

			#region Pole Arms

			AddCraft( typeof( Bardiche ), 1011083, 1023917, 31.7, 81.7, typeof( IronIngot ), 1044036, 18, 1044037 );

			if ( Core.AOS )
				AddCraft( typeof( BladedStaff ), 1011083, 1029917, 40.0, 90.0, typeof( IronIngot ), 1044036, 12, 1044037 );

			if ( Core.AOS )
				AddCraft( typeof( DoubleBladedStaff ), 1011083, 1029919, 45.0, 95.0, typeof( IronIngot ), 1044036, 16, 1044037 );

			AddCraft( typeof( Halberd ), 1011083, 1025183, 39.1, 89.1, typeof( IronIngot ), 1044036, 20, 1044037 );

			if ( Core.AOS )
				AddCraft( typeof( Lance ), 1011083, 1029920, 48.0, 98.0, typeof( IronIngot ), 1044036, 20, 1044037 );

			if ( Core.AOS )
				AddCraft( typeof( Pike ), 1011083, 1029918, 47.0, 97.0, typeof( IronIngot ), 1044036, 12, 1044037 );

			AddCraft( typeof( ShortSpear ), 1011083, 1025123, 45.3, 95.3, typeof( IronIngot ), 1044036, 6, 1044037 );

			if ( Core.AOS )
				AddCraft( typeof( Scythe ), 1011083, 1029914, 39.0, 89.0, typeof( IronIngot ), 1044036, 14, 1044037 );

			AddCraft( typeof( Spear ), 1011083, 1023938, 49.0, 99.0, typeof( IronIngot ), 1044036, 12, 1044037 );
			AddCraft( typeof( WarFork ), 1011083, 1025125, 42.9, 92.9, typeof( IronIngot ), 1044036, 12, 1044037 );

			// Not craftable (is this an AOS change ??)
			//AddCraft( typeof( Pitchfork ), 1011083, 1023720, 36.1, 86.1, typeof( IronIngot ), 1044036, 12, 1044037 );
			#endregion

			#region Bashing
			AddCraft( typeof( DiamondMace ), 1011084, "battle mace", 28.0, 78.0, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( HammerPick ), 1011084, 1025181, 34.2, 84.2, typeof( IronIngot ), 1044036, 16, 1044037 );
			AddCraft( typeof( Mace ), 1011084, 1023932, 14.5, 64.5, typeof( IronIngot ), 1044036, 6, 1044037 );
			AddCraft( typeof( Maul ), 1011084, 1025179, 19.4, 69.4, typeof( IronIngot ), 1044036, 10, 1044037 );

			if ( Core.AOS )
				AddCraft( typeof( Scepter ), 1011084, 1029916, 21.4, 71.4, typeof( IronIngot ), 1044036, 10, 1044037 );

			AddCraft( typeof( WarMace ), 1011084, 1025127, 28.0, 78.0, typeof( IronIngot ), 1044036, 14, 1044037 );
			AddCraft( typeof( WarHammer ), 1011084, 1025177, 34.2, 84.2, typeof( IronIngot ), 1044036, 16, 1044037 );

			if( Core.SE )
			{
				index = AddCraft( typeof( Tessen ), 1011084, 1030222, 85.0, 135.0, typeof( IronIngot ), 1044036, 16, 1044037 );
				AddSkill( index, SkillName.Tailoring, 50.0, 55.0 );
				AddRes( index, typeof( Cloth ), 1044286, 10, 1044287 );
				SetNeededExpansion( index, Expansion.SE );
			}

			#endregion

			#region Dragon Scale Armor
			index = AddCraft( typeof( DragonGloves ), "Scalemail Armor", "scalemail gloves", 68.9, 118.9, typeof( RedScales ), "Reptile Scales", 16, 1042081 );
			SetUseSubRes2( index, true );

			index = AddCraft( typeof( DragonHelm ), "Scalemail Armor", "scalemail helm", 72.6, 122.6, typeof( RedScales ), "Reptile Scales", 20, 1042081 );
			SetUseSubRes2( index, true );

			index = AddCraft( typeof( DragonLegs ), "Scalemail Armor", "scalemail leggings", 78.8, 128.8, typeof( RedScales ), "Reptile Scales", 28, 1042081 );
			SetUseSubRes2( index, true );

			index = AddCraft( typeof( DragonArms ), "Scalemail Armor", "scalemail arms", 76.3, 126.3, typeof( RedScales ), "Reptile Scales", 24, 1042081 );
			SetUseSubRes2( index, true );

			index = AddCraft( typeof( DragonChest ), "Scalemail Armor", "scalemail tunic", 85.0, 135.0, typeof( RedScales ), "Reptile Scales", 36, 1042081 );
			SetUseSubRes2( index, true );
			#endregion
			
			index = AddCraft( typeof( LevelBoneHarvester ), "Level Weapons", "Bone Harvester", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelBroadsword ), "Level Weapons", "Broadsword", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelCrescentBlade ), "Level Weapons", "Crescent Blade", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelCutlass ), "Level Weapons", "Cutlass", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelKatana ), "Level Weapons", "Katana", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelKryss ), "Level Weapons", "Kryss", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelLance ), "Level Weapons", "Lance", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelLongsword ), "Level Weapons", "Longsword", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelRoyalSword ), "Level Weapons", "Royal Sword", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelScimitar ), "Level Weapons", "Scimitar", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelThinLongsword ), "Level Weapons", "Thin Longsword", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelVikingSword ), "Level Weapons", "Viking Sword", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelWarFork ), "Level Weapons", "War Fork", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelDoubleBladedStaff ), "Level Weapons", "Double Bladed Staff", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelHammerPick ), "Level Weapons", "Hammer Pick", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelWarHammer ), "Level Weapons", "War Hammer", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelDoubleAxe ), "Level Weapons", "Double Axe", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelTwoHandedAxe ), "Level Weapons", "Two Handed Axe", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			
			
			
			// Set the overridable material
			SetSubRes( typeof( IronIngot ), 1044022 );

			// Add every material you want the player to be able to choose from
			// This will override the overridable material
			AddSubRes( typeof( IronIngot ),			1044022, 00.0, 1044036, 1044267 );
			AddSubRes( typeof( DullCopperIngot ),	1044023, 65.0, 1044036, 1044268 );
			AddSubRes( typeof( ShadowIronIngot ),	1044024, 70.0, 1044036, 1044268 );
			AddSubRes( typeof( CopperIngot ),		1044025, 75.0, 1044036, 1044268 );
			AddSubRes( typeof( BronzeIngot ),		1044026, 80.0, 1044036, 1044268 );
			AddSubRes( typeof( GoldIngot ),			1044027, 85.0, 1044036, 1044268 );
			AddSubRes( typeof( AgapiteIngot ),		1044028, 90.0, 1044036, 1044268 );
			AddSubRes( typeof( VeriteIngot ),		1044029, 95.0, 1044036, 1044268 );
			AddSubRes( typeof( ValoriteIngot ),		1044030, 99.0, 1044036, 1044268 );
			AddSubRes( typeof( NepturiteIngot ),	1036173, 99.0, 1044036, 1044268 );
			AddSubRes( typeof( ObsidianIngot ),		1036162, 99.0, 1044036, 1044268 );
			AddSubRes( typeof( SteelIngot ),		1036144, 99.0, 1044036, 1044268 );
			AddSubRes( typeof( BrassIngot ),		1036152, 105.0, 1044036, 1044268 );
			AddSubRes( typeof( MithrilIngot ),		1036137, 110.0, 1044036, 1044268 );
			AddSubRes( typeof( XormiteIngot ),		1034437, 115.0, 1044036, 1044268 );
			AddSubRes( typeof( DwarvenIngot ),		1036181, 120.0, 1044036, 1044268 );

			SetSubRes2( typeof( RedScales ), 1060875 );

			AddSubRes2( typeof( RedScales ),		1060875, 0.0, 1053137, 1054018 );
			AddSubRes2( typeof( YellowScales ),		1060876, 0.0, 1053137, 1054018 );
			AddSubRes2( typeof( BlackScales ),		1060877, 0.0, 1053137, 1054018 );
			AddSubRes2( typeof( GreenScales ),		1060878, 0.0, 1053137, 1054018 );
			AddSubRes2( typeof( WhiteScales ),		1060879, 0.0, 1053137, 1054018 );
			AddSubRes2( typeof( BlueScales ),		1060880, 0.0, 1053137, 1054018 );
			AddSubRes2( typeof( DinosaurScales ),	1054017, 0.0, 1053137, 1054018 );

			Resmelt = true;
			Repair = true;
			MarkOption = true;
			CanEnhance = Core.AOS;
		}
	}

	public class ForgeAttribute : Attribute
	{
		public ForgeAttribute()
		{
		}
	}

	public class AnvilAttribute : Attribute
	{
		public AnvilAttribute()
		{
		}
	}
}
