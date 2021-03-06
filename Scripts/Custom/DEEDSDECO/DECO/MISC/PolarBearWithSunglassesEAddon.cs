
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class PolarBearWithSunglassesEAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PolarBearWithSunglassesEAddonDeed();
			}
		}

		[ Constructable ]
		public PolarBearWithSunglassesEAddon()
		{



			AddComplexComponent( (BaseAddon) this, 7763, 1, 1, 0, 0, -1, "polarbear", 1);// 1
			AddComplexComponent( (BaseAddon) this, 7764, 1, 0, 0, 0, -1, "polarbear", 1);// 2
			AddComplexComponent( (BaseAddon) this, 7765, 1, -1, 0, 0, -1, "polarbear", 1);// 3
			AddComplexComponent( (BaseAddon) this, 7766, 0, -1, 0, 0, -1, "polarbear", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7767, 0, 0, 0, 0, -1, "polarbear", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7768, 0, 1, 0, 0, -1, "polar", 1);// 6
			AddComplexComponent( (BaseAddon) this, 7769, -1, 1, 0, 0, -1, "polarbear", 1);// 7
			AddComplexComponent( (BaseAddon) this, 7770, -1, 0, 0, 0, -1, "polarbear", 1);// 8
			AddComplexComponent( (BaseAddon) this, 7771, -1, -1, 0, 0, -1, "polarbear", 1);// 9
			AddComplexComponent( (BaseAddon) this, 12592, 1, 0, 0, 0, -1, "sunglasses", 1);// 10

		}

		public PolarBearWithSunglassesEAddon( Serial serial ) : base( serial )
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

	public class PolarBearWithSunglassesEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PolarBearWithSunglassesEAddon();
			}
		}

		[Constructable]
		public PolarBearWithSunglassesEAddonDeed()
		{
			Name = "PolarBearWithSunglassesE";
		}

		public PolarBearWithSunglassesEAddonDeed( Serial serial ) : base( serial )
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