/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FlowerBenchPinkSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FlowerBenchPinkSouthAddonDeed();
			}
		}

		[ Constructable ]
		public FlowerBenchPinkSouthAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2187 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 925 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 0, 18 );
			ac = new AddonComponent( 11514 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 924 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 1, 18 );
			ac = new AddonComponent( 6023 );
			AddComponent( ac, 0, 1, 21 );
			ac = new AddonComponent( 926 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 18 );
			ac = new AddonComponent( 2187 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 7 );
			ac = new AddonComponent( 924 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 1, 18 );
			ac = new AddonComponent( 6025 );
			AddComponent( ac, -1, 1, 21 );
			ac = new AddonComponent( 6025 );
			AddComponent( ac, 0, 1, 21 );
			ac = new AddonComponent( 6023 );
			AddComponent( ac, -1, 1, 21 );
			ac = new AddonComponent( 925 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 0, 18 );
			ac = new AddonComponent( 2861 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 927 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 0, 18 );
			ac = new AddonComponent( 2861 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 924 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 1, 18 );
			ac = new AddonComponent( 3141 );
			AddComponent( ac, 1, 1, 22 );
			ac = new AddonComponent( 3141 );
			AddComponent( ac, -1, 1, 22 );
			ac = new AddonComponent( 2187 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 6025 );
			AddComponent( ac, 1, 1, 21 );
			ac = new AddonComponent( 925 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 0, 18 );
			ac = new AddonComponent( 2187 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 1, 8 );
			ac = new AddonComponent( 6023 );
			AddComponent( ac, 1, 1, 21 );
			ac = new AddonComponent( 11514 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 3143 );
			AddComponent( ac, 0, 1, 21 );

		}

		public FlowerBenchPinkSouthAddon( Serial serial ) : base( serial )
		{
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

	public class FlowerBenchPinkSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FlowerBenchPinkSouthAddon();
			}
		}

		[Constructable]
		public FlowerBenchPinkSouthAddonDeed()
		{
			Name = "FlowerBenchPinkSouth";
		}

		public FlowerBenchPinkSouthAddonDeed( Serial serial ) : base( serial )
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