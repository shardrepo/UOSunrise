
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class LgWoodenCounterSouthAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LgWoodenCounterSouthAddonDeed();
			}
		}

		[ Constructable ]
		public LgWoodenCounterSouthAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2877, -1, 0, 5, 1135, -1, "Butcher Block Counter", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2878, -1, -1, 5, 1135, -1, "Butcher Block Counter", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2878, 1, -1, 5, 1135, -1, "Butcher Block Counter", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2878, 0, -1, 5, 1135, -1, "Butcher Block Counter", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2878, 2, -1, 5, 1135, -1, "Butcher Block Counter", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1801, -1, 0, 4, 1141, -1, "Cabinet", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1801, -1, -1, 4, 1141, -1, "Cabinet", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1801, 0, -1, 4, 1141, -1, "Cabinet", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1801, 1, -1, 4, 1141, -1, "Cabinet", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1801, 2, -1, 4, 1141, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 9232, 0, 0, 0, 0, -1, "door", 1);// 11
			AddComplexComponent( (BaseAddon) this, 9231, 0, 0, 0, 0, -1, "door", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9231, 1, 0, 0, 0, -1, "door", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9231, 2, 0, 0, 0, -1, "door", 1);// 14
			AddComplexComponent( (BaseAddon) this, 10013, -1, -2, 9, 1135, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10013, 0, -2, 9, 1135, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10013, 1, -2, 9, 1135, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10013, 2, -2, 9, 1135, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 10010, -2, -1, 9, 1135, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 10010, -2, 0, 9, 1135, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1801, -1, 1, 4, 1141, -1, "Cabinet", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1801, -1, 2, 4, 1141, -1, "Cabinet", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9232, 0, 1, 0, 0, -1, "door", 1);// 23
			AddComplexComponent( (BaseAddon) this, 9232, 0, 2, 0, 0, -1, "door", 1);// 24
			AddComplexComponent( (BaseAddon) this, 10010, -2, 1, 9, 1135, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 10010, -2, 2, 9, 1135, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2877, -1, 2, 5, 1135, -1, "Butcher Block Counter", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2877, -1, 1, 5, 1135, -1, "Butcher Block Counter", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1801, -1, 3, 4, 1141, -1, "Cabinet", 1);// 29
			AddComplexComponent( (BaseAddon) this, 9232, 0, 3, 0, 0, -1, "door", 1);// 30
			AddComplexComponent( (BaseAddon) this, 10010, -2, 3, 9, 1135, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2877, -1, 3, 5, 1135, -1, "Butcher Block Counter", 1);// 32

		}

		public LgWoodenCounterSouthAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class LgWoodenCounterSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LgWoodenCounterSouthAddon();
			}
		}

		[Constructable]
		public LgWoodenCounterSouthAddonDeed()
		{
			Name = "LgWoodenCounterSouth";
		}

		public LgWoodenCounterSouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}