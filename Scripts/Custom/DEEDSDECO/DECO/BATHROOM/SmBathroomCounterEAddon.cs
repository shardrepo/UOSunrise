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
	public class SmBathroomCounterEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmBathroomCounterEAddonDeed();
			}
		}

		[ Constructable ]
		public SmBathroomCounterEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 7617 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 7618 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7619 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4104 );
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 6420 );
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 4979 );
			AddComponent( ac, 0, -1, 4 );
			ac = new AddonComponent( 3625 );
			ac.Name = "shaving cream";
			AddComponent( ac, 0, -1, 8 );
			ac = new AddonComponent( 3626 );
			ac.Name = "hand lotion";
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 3836 );
			ac.Name = "perfume";
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 5155 );
			ac.Name = "bar of soap";
			AddComponent( ac, 0, 0, 8 );

		}

		public SmBathroomCounterEAddon( Serial serial ) : base( serial )
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

	public class SmBathroomCounterEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmBathroomCounterEAddon();
			}
		}

		[Constructable]
		public SmBathroomCounterEAddonDeed()
		{
			Name = "SmBathroomCounterE";
		}

		public SmBathroomCounterEAddonDeed( Serial serial ) : base( serial )
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