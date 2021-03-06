//Created By Milva
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
	public class GazeboNewwithbenchesAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2920, 1, -2, 6}, {2921, -1, -2, 6}, {2922, 0, -2, 6}// 35	36	37	
			, {2915, -2, -1, 6}, {3203, 3, -1, 8}, {3203, 3, -2, 8}// 38	39	40	
			, {11516, 2, -2, 9}, {2914, -2, 1, 6}, {2916, -2, 0, 6}// 41	114	115	
			, {3203, -1, 3, 8}, {3203, -2, 3, 8}, {11514, -3, 1, 1}// 116	117	118	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GazeboNewwithbenchesAddonDeed();
			}
		}

		[ Constructable ]
		public GazeboNewwithbenchesAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1824, -2, -1, 1, 0, -1, "Gazebo", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1824, -2, -2, 1, 0, -1, "Gazebo", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1824, -1, -2, 1, 0, -1, "Gazebo", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1824, -1, -1, 1, 0, -1, "Gazebo", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1824, 0, -2, 1, 0, -1, "Gazebo", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1824, 0, -1, 1, 0, -1, "Gazebo", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1824, 1, -2, 1, 0, -1, "Gazebo", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1824, 1, -1, 1, 0, -1, "Gazebo", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1824, 2, -2, 1, 0, -1, "Gazebo", 1);// 9
			AddComplexComponent( (BaseAddon) this, 10076, 2, -3, 5, 0, -1, "Gazebo", 1);// 10
			AddComplexComponent( (BaseAddon) this, 10076, -3, -3, 5, 0, -1, "Gazebo", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2145, 2, -1, 6, 0, -1, "Gazebo", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2145, 2, -2, 6, 0, -1, "Gazebo", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2145, -3, -2, 6, 0, -1, "Gazebo", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2145, -3, -1, 6, 0, -1, "Gazebo", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2144, -2, -3, 6, 0, -1, "Gazebo", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2144, -1, -3, 6, 0, -1, "Gazebo", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2144, 0, -3, 6, 0, -1, "Gazebo", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2144, 2, -3, 6, 0, -1, "Gazebo", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2144, 1, -3, 6, 0, -1, "Gazebo", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2177, 2, -2, 9, 0, -1, "Gazebo", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2177, -2, -2, 9, 0, -1, "Gazebo", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2182, 2, -1, 9, 0, -1, "Gazebo", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2182, 2, -2, 9, 0, -1, "Gazebo", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2183, -2, -2, 9, 0, -1, "Gazebo", 1);// 25
			AddComplexComponent( (BaseAddon) this, 10075, 2, -3, 24, 0, -1, "Gazebo", 1);// 26
			AddComplexComponent( (BaseAddon) this, 10075, -3, -3, 24, 0, -1, "Gazebo", 1);// 27
			AddComplexComponent( (BaseAddon) this, 11152, 3, -1, 43, 0, -1, "Gazebo", 1);// 28
			AddComplexComponent( (BaseAddon) this, 11150, -1, -1, 43, 0, -1, "Gazebo", 1);// 29
			AddComplexComponent( (BaseAddon) this, 11155, 2, -1, 43, 0, -1, "Gazebo", 1);// 30
			AddComplexComponent( (BaseAddon) this, 11155, 1, -1, 43, 0, -1, "Gazebo", 1);// 31
			AddComplexComponent( (BaseAddon) this, 11155, 0, -1, 43, 0, -1, "Gazebo", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1824, -2, -2, 6, 0, -1, "Gazebo", 1);// 33
			AddComplexComponent( (BaseAddon) this, 9406, -2, -2, 14, 0, -1, "Gazebo", 1);// 34
			AddComplexComponent( (BaseAddon) this, 9359, 3, -3, 5, 1501, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 9358, 3, -2, 5, 1501, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 9357, 3, -1, 5, 1501, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1824, -2, 1, 1, 0, -1, "Gazebo", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1824, -2, 0, 1, 0, -1, "Gazebo", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1824, -1, 0, 1, 0, -1, "Gazebo", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1824, -1, 1, 1, 0, -1, "Gazebo", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1824, 0, 0, 1, 0, -1, "Gazebo", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1824, 0, 1, 1, 0, -1, "Gazebo", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1824, 1, 0, 1, 0, -1, "Gazebo", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1824, 1, 1, 1, 0, -1, "Gazebo", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1824, 2, 0, 1, 0, -1, "Gazebo", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1824, 2, 1, 1, 0, -1, "Gazebo", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1824, -2, 2, 1, 0, -1, "Gazebo", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1824, -1, 2, 1, 0, -1, "Gazebo", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1824, 0, 2, 1, 0, -1, "Gazebo", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1824, 1, 2, 1, 0, -1, "Gazebo", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1824, 2, 2, 1, 0, -1, "Gazebo", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1826, 2, 3, 0, 0, -1, "Gazebo", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1827, 3, 2, 0, 0, -1, "Gazebo", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1835, 3, 3, 0, 0, -1, "Gazebo", 1);// 62
			AddComplexComponent( (BaseAddon) this, 10076, 0, 2, 5, 0, -1, "Gazebo", 1);// 63
			AddComplexComponent( (BaseAddon) this, 10076, 2, 0, 5, 0, -1, "Gazebo", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1826, 1, 3, 0, 0, -1, "Gazebo", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1827, 3, 1, 0, 0, -1, "Gazebo", 1);// 66
			AddComplexComponent( (BaseAddon) this, 10076, -3, 2, 5, 0, -1, "Gazebo", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2144, 0, 2, 6, 0, -1, "Gazebo", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2144, -1, 2, 6, 0, -1, "Gazebo", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2144, -2, 2, 4, 0, -1, "Gazebo", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2145, 2, 0, 6, 0, -1, "Gazebo", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2145, -3, 0, 6, 0, -1, "Gazebo", 1);// 72
			AddComplexComponent( (BaseAddon) this, 2145, -3, 2, 6, 0, -1, "Gazebo", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2145, -3, 1, 6, 0, -1, "Gazebo", 1);// 74
			AddComplexComponent( (BaseAddon) this, 2176, 0, 2, 9, 0, -1, "Gazebo", 1);// 75
			AddComplexComponent( (BaseAddon) this, 2176, -1, 2, 9, 0, -1, "Gazebo", 1);// 76
			AddComplexComponent( (BaseAddon) this, 2176, -2, 2, 9, 0, -1, "Gazebo", 1);// 77
			AddComplexComponent( (BaseAddon) this, 2182, 2, 0, 9, 0, -1, "Gazebo", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2183, -2, 2, 8, 0, -1, "Gazebo", 1);// 79
			AddComplexComponent( (BaseAddon) this, 10075, 0, 2, 24, 0, -1, "Gazebo", 1);// 80
			AddComplexComponent( (BaseAddon) this, 10075, 2, 0, 24, 0, -1, "Gazebo", 1);// 81
			AddComplexComponent( (BaseAddon) this, 10075, -3, 2, 24, 0, -1, "Gazebo", 1);// 82
			AddComplexComponent( (BaseAddon) this, 10067, 4, 4, 52, 0, -1, "Gazebo", 1);// 83
			AddComplexComponent( (BaseAddon) this, 10080, 0, 4, 52, 0, -1, "Gazebo", 1);// 84
			AddComplexComponent( (BaseAddon) this, 10080, 1, 4, 52, 0, -1, "Gazebo", 1);// 85
			AddComplexComponent( (BaseAddon) this, 10080, 2, 4, 52, 0, -1, "Gazebo", 1);// 86
			AddComplexComponent( (BaseAddon) this, 10080, 3, 4, 52, 0, -1, "Gazebo", 1);// 87
			AddComplexComponent( (BaseAddon) this, 10077, 4, 2, 52, 0, -1, "Gazebo", 1);// 88
			AddComplexComponent( (BaseAddon) this, 10077, 4, 3, 52, 0, -1, "Gazebo", 1);// 89
			AddComplexComponent( (BaseAddon) this, 11149, 3, 3, 43, 0, -1, "Gazebo", 1);// 90
			AddComplexComponent( (BaseAddon) this, 11151, -1, 3, 43, 0, -1, "Gazebo", 1);// 91
			AddComplexComponent( (BaseAddon) this, 11138, 3, 2, 43, 0, -1, "Gazebo", 1);// 92
			AddComplexComponent( (BaseAddon) this, 11138, 3, 1, 43, 0, -1, "Gazebo", 1);// 93
			AddComplexComponent( (BaseAddon) this, 11138, 3, 0, 43, 0, -1, "Gazebo", 1);// 94
			AddComplexComponent( (BaseAddon) this, 11139, -1, 2, 43, 0, -1, "Gazebo", 1);// 95
			AddComplexComponent( (BaseAddon) this, 11139, -1, 1, 43, 0, -1, "Gazebo", 1);// 96
			AddComplexComponent( (BaseAddon) this, 11139, -1, 0, 43, 0, -1, "Gazebo", 1);// 97
			AddComplexComponent( (BaseAddon) this, 11154, 2, 3, 44, 0, -1, "Gazebo", 1);// 98
			AddComplexComponent( (BaseAddon) this, 11154, 1, 3, 43, 0, -1, "Gazebo", 1);// 99
			AddComplexComponent( (BaseAddon) this, 11154, 0, 3, 43, 0, -1, "Gazebo", 1);// 100
			AddComplexComponent( (BaseAddon) this, 11149, 2, 2, 46, 0, -1, "Gazebo", 1);// 101
			AddComplexComponent( (BaseAddon) this, 11150, 0, 0, 46, 0, -1, "Gazebo", 1);// 102
			AddComplexComponent( (BaseAddon) this, 11151, 0, 2, 46, 0, -1, "Gazebo", 1);// 103
			AddComplexComponent( (BaseAddon) this, 11152, 2, 0, 46, 0, -1, "Gazebo", 1);// 104
			AddComplexComponent( (BaseAddon) this, 11154, 1, 2, 48, 0, -1, "Gazebo", 1);// 105
			AddComplexComponent( (BaseAddon) this, 11138, 2, 1, 48, 0, -1, "Gazebo", 1);// 106
			AddComplexComponent( (BaseAddon) this, 11139, 0, 1, 46, 0, -1, "Gazebo", 1);// 107
			AddComplexComponent( (BaseAddon) this, 11155, 1, 0, 46, 0, -1, "Gazebo", 1);// 108
			AddComplexComponent( (BaseAddon) this, 11149, 1, 1, 49, 0, -1, "Gazebo", 1);// 109
			AddComplexComponent( (BaseAddon) this, 2174, 3, 1, 1, 0, -1, "Gazebo", 1);// 110
			AddComplexComponent( (BaseAddon) this, 2180, 1, 3, 1, 0, -1, "Gazebo", 1);// 111
			AddComplexComponent( (BaseAddon) this, 10077, 4, 1, 52, 0, -1, "Gazebo", 1);// 112
			AddComplexComponent( (BaseAddon) this, 10077, 4, 0, 52, 0, -1, "Gazebo", 1);// 113
			AddComplexComponent( (BaseAddon) this, 9357, -1, 3, 5, 1501, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 9358, -3, 3, 5, 1501, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 9359, -2, 3, 5, 1501, -1, "", 1);// 121

		}

		public GazeboNewwithbenchesAddon( Serial serial ) : base( serial )
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

	public class GazeboNewwithbenchesAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GazeboNewwithbenchesAddon();
			}
		}

		[Constructable]
		public GazeboNewwithbenchesAddonDeed()
		{
			Name = "GazeboNewwithbenches";
		}

		public GazeboNewwithbenchesAddonDeed( Serial serial ) : base( serial )
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