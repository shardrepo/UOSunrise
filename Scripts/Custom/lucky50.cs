using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class LuckTarget50 : Target
	{
		private LuckyHorseShoes50 m_Deed;

		public LuckTarget50( LuckyHorseShoes50 deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}

		protected override void OnTarget( Mobile from, object target )
		{
			if ( target is BaseWeapon )
			{
				BaseWeapon item = (BaseWeapon)target;

				if ( item.RootParent != from )
				{
					from.SendMessage( "The item must be in your pack." );
				}
				else
				{
					int luck = item.Attributes.Luck;
					if ( luck >= 1000 )
					{
						from.SendMessage( "There is already enough luck on this item." );
					}
					else
					{
						item.Attributes.Luck = luck + 50;
							if ( item.Attributes.Luck > 1000 ){ item.Attributes.Luck = 1000; }
						from.SendMessage( "You add some extra luck to the item." );
						m_Deed.Delete();
					}
				}
			}
			else if ( target is BaseClothing )
			{
				BaseClothing item = (BaseClothing)target;

				if ( item.RootParent != from )
				{
					from.SendMessage( "The item must be in your pack." );
				}
				else
				{
					int luck = item.Attributes.Luck;
					if ( luck >= 1000 )
					{
						from.SendMessage( "There is already enough luck on this item." );
					}
					else
					{
						item.Attributes.Luck = luck + 50;
							if ( item.Attributes.Luck > 1000 ){ item.Attributes.Luck = 1000; }
						from.SendMessage( "You add some extra luck to the item." );
						m_Deed.Delete();
					}
				}
			}
			else if ( target is BaseJewel )
			{
				BaseJewel item = (BaseJewel)target;

				if ( item.RootParent != from )
				{
					from.SendMessage( "The item must be in your pack." );
				}
				else
				{
					int luck = item.Attributes.Luck;
					if ( luck >= 1000 )
					{
						from.SendMessage( "There is already enough luck on this item." );
					}
					else
					{
						item.Attributes.Luck = luck + 50;
							if ( item.Attributes.Luck > 1000 ){ item.Attributes.Luck = 1000; }
						from.SendMessage( "You add some extra luck to the item." );
						m_Deed.Delete();
					}
				}
			}
			else if ( target is BaseArmor )
			{
				BaseArmor item = (BaseArmor)target;

				if ( item.RootParent != from )
				{
					from.SendMessage( "The item must be in your pack." );
				}
				else
				{
					int luck = item.Attributes.Luck;
					if ( luck >= 1000 )
					{
						from.SendMessage( "There is already enough luck on this item." );
					}
					else
					{
						item.Attributes.Luck = luck + 50;
							if ( item.Attributes.Luck > 1000 ){ item.Attributes.Luck = 1000; }
						from.SendMessage( "You add some extra luck to the item." );
						m_Deed.Delete();
					}
				}
			}
			else if ( target is Spellbook )
			{
				Spellbook item = (Spellbook)target;

				if ( item.RootParent != from )
				{
					from.SendMessage( "The item must be in your pack." );
				}
				else
				{
					int luck = item.Attributes.Luck;
					if ( luck >= 1000 )
					{
						from.SendMessage( "There is already enough luck on this item." );
					}
					else
					{
						item.Attributes.Luck = luck + 50;
							if ( item.Attributes.Luck > 1000 ){ item.Attributes.Luck = 1000; }
						from.SendMessage( "You add some extra luck to the item." );
						m_Deed.Delete();
					}
				}
			}
			else
			{
				from.SendMessage( "You cannot enhance that item with luck." );
			}
		}
	}

	public class LuckyHorseShoes50 : Item
	{
		[Constructable]
		public LuckyHorseShoes50() : base( 0xFB6 )
		{
			Weight = 1.0;
			Name = "lucky horse shoes";
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Adds 50 Luck To An Item" );
        }

		public LuckyHorseShoes50(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 );
			}
			else
			{
				from.SendMessage( "What item would you like to add luck to?" );
				from.Target = new LuckTarget50( this );
			}
		}
	}
}