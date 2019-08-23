
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
	public class JukeBoxBarEastAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JukeBoxBarEastAddonDeed();
			}
		}

		[ Constructable ]
		public JukeBoxBarEastAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1184, 0, -1, 5, 1157, -1, "Bar", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2602, 2, -1, 0, 1157, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1801, 1, -1, 0, 1153, -1, "Bar", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1801, 0, -1, 0, 1153, -1, "Bar", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1184, 1, -1, 5, 1157, -1, "Bar", 1);// 5
			AddComplexComponent( (BaseAddon) this, 16427, 0, -2, 2, 0, -1, "Juke Box", 1);// 6
			AddComplexComponent( (BaseAddon) this, 16428, 1, -2, 2, 0, -1, "Juke Box", 1);// 7
			AddComplexComponent( (BaseAddon) this, 18782, 0, -1, 5, 0, -1, "MoonShine", 1);// 8
			AddComplexComponent( (BaseAddon) this, 18878, -1, -1, 0, 0, -1, "Home Town Tavern", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2602, 2, 1, 0, 1157, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2602, 2, 0, 0, 1157, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2602, 2, 2, 0, 1157, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1801, 1, 2, 0, 1153, -1, "Bar", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1801, 1, 0, 0, 1153, -1, "Bar", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1801, 1, 1, 0, 1153, -1, "Bar", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1801, 0, 2, 0, 1153, -1, "Bar", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1184, 1, 0, 5, 1157, -1, "Bar", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1184, 1, 2, 5, 1157, -1, "Bar", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1184, 1, 1, 5, 1157, -1, "Bar", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1184, 0, 2, 5, 1157, -1, "Bar", 1);// 20
			AddComplexComponent( (BaseAddon) this, 18878, -1, 2, 0, 0, -1, "Home Town Tavern", 1);// 21
			AddComplexComponent( (BaseAddon) this, 18881, 0, 2, 5, 0, 0, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2458, 1, 0, 5, 1161, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2458, 1, 1, 5, 1161, -1, "", 1);// 24

		}

		public JukeBoxBarEastAddon( Serial serial ) : base( serial )
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

	public class JukeBoxBarEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JukeBoxBarEastAddon();
			}
		}

		[Constructable]
		public JukeBoxBarEastAddonDeed()
		{
			Name = "JukeBoxBarEast";
		}

		public JukeBoxBarEastAddonDeed( Serial serial ) : base( serial )
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