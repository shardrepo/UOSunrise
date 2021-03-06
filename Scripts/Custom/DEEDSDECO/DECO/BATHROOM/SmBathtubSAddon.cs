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
	public class SmBathtubSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmBathtubSAddonDeed();
			}
		}

		[ Constructable ]
		public SmBathtubSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 7379 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 1, 1, 10 );
			ac = new AddonComponent( 1804 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1815 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 7383 );
			ac.Hue = 1154;
			AddComponent( ac, 2, 0, 10 );
			ac = new AddonComponent( 1817 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 5172 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, -1, 8 );
			ac = new AddonComponent( 7385 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 1814 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 7381 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 0, -1, 10 );
			ac = new AddonComponent( 7376 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 2, -1, 10 );
			ac = new AddonComponent( 7375 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, -1, -1, 10 );
			ac = new AddonComponent( 7374 );
			ac.Hue = 1154;
			ac.Name = "water";
			AddComponent( ac, 2, 1, 10 );
			ac = new AddonComponent( 1802 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7373 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, -1, 1, 10 );
			ac = new AddonComponent( 7381 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 1, -1, 10 );
			ac = new AddonComponent( 5164 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, -1, 7 );
			ac = new AddonComponent( 3146 );
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 7385 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 5168 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, -1, 10 );
			ac = new AddonComponent( 7377 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, -1, 0, 10 );
			ac = new AddonComponent( 1816 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7379 );
			ac.Hue = 1154;
			ac.Name = "Water";
			AddComponent( ac, 0, 1, 10 );

		}

		public SmBathtubSAddon( Serial serial ) : base( serial )
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

	public class SmBathtubSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmBathtubSAddon();
			}
		}

		[Constructable]
		public SmBathtubSAddonDeed()
		{
			Name = "SmBathtubS";
		}

		public SmBathtubSAddonDeed( Serial serial ) : base( serial )
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