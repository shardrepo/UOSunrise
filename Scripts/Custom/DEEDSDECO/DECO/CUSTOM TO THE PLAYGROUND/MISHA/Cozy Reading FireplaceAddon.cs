
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
	public class CozyReadingFireplaceAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2713, -1, -4, 3}, {2713, -1, -3, 3}, {11514, 0, 2, 3}// 13	14	69	
			, {11514, 0, -2, 3}, {3553, -1, 0, 4}, {3553, -1, -1, 4}// 70	74	75	
			, {2227, -1, 0, 0}, {2227, -1, -1, 0}, {7761, 1, -1, 3}// 85	86	87	
			, {7760, 2, -1, 3}, {7759, 3, -1, 3}, {7753, 3, 1, 3}// 88	89	90	
			, {7754, 2, 1, 3}, {7756, 1, 0, 3}, {7757, 2, 0, 3}// 91	92	93	
			, {7755, 1, 1, 3}, {7758, 3, 0, 3}, {2227, -1, 1, 0}// 94	95	96	
			, {2713, -1, 3, 3}, {2713, -1, 4, 3}// 103	104	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CozyReadingFireplaceAddonDeed();
			}
		}

		[ Constructable ]
		public CozyReadingFireplaceAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 10683, -2, -3, 3, 0, 0, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1295, -1, -3, 3, 1085, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1295, 3, -3, 3, 1085, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1295, 2, -3, 3, 1085, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1295, 1, -3, 3, 1085, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1295, 0, -3, 3, 1085, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 10683, -2, -4, 3, 0, 0, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1295, -1, -4, 3, 1085, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1295, 0, -4, 3, 1085, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1295, 1, -4, 3, 1085, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1295, 2, -4, 3, 1085, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1295, 3, -4, 3, 1085, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2854, 3, -4, 3, 0, 1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1295, 3, 2, 3, 1085, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1295, 3, 1, 3, 1085, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1295, 3, 0, 3, 1085, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1295, -1, 4, 3, 1085, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1295, 3, -2, 3, 1085, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1295, 2, 2, 3, 1085, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1295, 2, 1, 3, 1085, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1295, 2, 0, 3, 1085, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1295, 2, -1, 3, 1085, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1295, 2, -2, 3, 1085, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1295, 1, 2, 3, 1085, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1295, 1, 1, 3, 1085, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1295, 1, 0, 3, 1085, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1295, 1, -1, 3, 1085, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1295, 1, -2, 3, 1085, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1295, 0, 2, 3, 1085, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1295, 0, 1, 3, 1085, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1295, 0, 0, 3, 1085, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1295, 0, -1, 3, 1085, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1296, -1, 1, 20, 1096, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1296, -1, 0, 20, 1096, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1296, -1, -1, 20, 1096, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 15921, -1, 1, 1, 0, 1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 15921, -1, 0, 1, 0, 1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 15921, -1, -1, 1, 0, 1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 63, -2, 1, 3, 1096, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1295, -1, 1, 3, 1085, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 7, 1096, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 15, 1096, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1295, -1, -2, 12, 1096, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 7, 1096, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 5, 1096, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 3, 1096, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 11, 1096, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 63, -2, 0, 3, 1096, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1295, 0, -2, 3, 1085, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 11, 1096, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1295, -1, 2, 3, 1096, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1295, 3, -1, 3, 1085, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 63, -2, -1, 3, 1096, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 13, 1096, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 9, 1096, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 9, 1096, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 5, 1096, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1006, -1, -2, 13, 1096, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 3, 1096, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1295, -1, -2, 3, 1096, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1295, -1, -1, 3, 1085, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1295, -1, 0, 3, 1085, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1295, -1, 2, 12, 1096, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1296, -1, -2, 20, 1096, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1006, -1, 2, 15, 1096, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1296, -1, 2, 20, 1096, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 10683, -2, 3, 3, 0, 1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 10683, -2, -2, 3, 0, 0, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 10683, -2, 4, 3, 0, 1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 10683, -2, -1, 3, 0, 0, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 6571, -1, 0, 3, 0, 1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 10683, -2, 0, 3, 0, 0, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 6571, -1, -1, 3, 0, 1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1295, 3, 3, 3, 1085, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1295, 2, 3, 3, 1085, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1295, 1, 3, 3, 1085, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1295, 0, 3, 3, 1085, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1295, -1, 3, 3, 1085, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1295, 0, 4, 3, 1085, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1295, 1, 4, 3, 1085, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 1295, 2, 4, 3, 1085, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1295, 3, 4, 3, 1085, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 10683, -2, 1, 3, 0, 0, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 10683, -2, 2, 3, 0, 0, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 2854, 3, 4, 3, 0, 1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 7712, 2, 0, 3, 0, -1, "fifty shades of grey", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2503, 1, 1, 3, 1372, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 2503, 1, 1, 3, 1372, -1, "", 1);// 108

		}

		public CozyReadingFireplaceAddon( Serial serial ) : base( serial )
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

	public class CozyReadingFireplaceAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CozyReadingFireplaceAddon();
			}
		}

		[Constructable]
		public CozyReadingFireplaceAddonDeed()
		{
			Name = "Cozy Reading Fireplace";
		}

		public CozyReadingFireplaceAddonDeed( Serial serial ) : base( serial )
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