
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
	public class EndTablePlantEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4556, 1, 1, 12}// 4	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EndTablePlantEastAddonDeed();
			}
		}

		[ Constructable ]
		public EndTablePlantEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 11, 1153, -1, "daisies", 1);// 1
			AddComplexComponent( (BaseAddon) this, 19641, 0, 1, 0, 1141, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 19643, 1, 0, 0, 1141, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 19642, 0, 0, 0, 1141, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6094, 1, 1, 15, 0, -1, "daisies", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4180, 1, 1, 10, 1153, -1, "daisies", 1);// 7
			AddComplexComponent( (BaseAddon) this, 19640, 1, 1, 0, 1141, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 6094, 1, 1, 19, 0, -1, "daisies", 1);// 9

		}

		public EndTablePlantEastAddon( Serial serial ) : base( serial )
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

	public class EndTablePlantEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EndTablePlantEastAddon();
			}
		}

		[Constructable]
		public EndTablePlantEastAddonDeed()
		{
			Name = "EndTablePlantEast";
		}

		public EndTablePlantEastAddonDeed( Serial serial ) : base( serial )
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