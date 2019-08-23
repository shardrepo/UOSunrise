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
	public class SimpleWiccanCircleAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SimpleWiccanCircleAddonDeed();
			}
		}

		[ Constructable ]
		public SimpleWiccanCircleAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4073 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 14133 );
			ac.Hue = 1153;
			ac.Name = "sweet smoke";
			AddComponent( ac, 2, -2, 5 );
			ac = new AddonComponent( 4076 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4070 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 4075 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 3205 );
			AddComponent( ac, -1, -1, 9 );
			ac = new AddonComponent( 4963 );
			ac.Hue = 1028;
			ac.Name = "Earth";
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 4078 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4074 );
			ac.Name = "Spirit";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3554 );
			ac.Name = "sticks of sage";
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 5637 );
			ac.Name = "Large wooden bowl";
			AddComponent( ac, 2, -2, 2 );
			ac = new AddonComponent( 4071 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4077 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 4963 );
			ac.Hue = 961;
			ac.Name = "Air";
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 4072 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2886 );
			ac.Hue = 43;
			ac.Name = "tera cotta vase";
			AddComponent( ac, -1, -1, 6 );
			ac = new AddonComponent( 4963 );
			ac.Hue = 1745;
			ac.Name = "Water";
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 4963 );
			ac.Hue = 1741;
			ac.Name = "Fire";
			AddComponent( ac, 2, 2, 3 );
			ac = new AddonComponent( 4973 );
			ac.Hue = 961;
			AddComponent( ac, 2, 2, 6 );
			ac = new AddonComponent( 3555 );
			ac.Light = LightType.Circle225;
			ac.Name = "fire";
			AddComponent( ac, 2, 2, 11 );
			ac = new AddonComponent( 4104 );
			ac.Name = "Bowl of Sea Water";
			AddComponent( ac, -2, 2, 4 );
			ac = new AddonComponent( 4044 );
			ac.Name = "Sea Shell";
			AddComponent( ac, -2, 2, 3 );
			ac = new AddonComponent( 4040 );
			ac.Name = "Sea Shell";
			AddComponent( ac, -2, 2, 2 );
			ac = new AddonComponent( 4039 );
			AddComponent( ac, -2, 2, 5 );
			ac = new AddonComponent( 7979 );
			AddComponent( ac, 2, 2, 9 );

		}

		public SimpleWiccanCircleAddon( Serial serial ) : base( serial )
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

	public class SimpleWiccanCircleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SimpleWiccanCircleAddon();
			}
		}

		[Constructable]
		public SimpleWiccanCircleAddonDeed()
		{
			Name = "SimpleWiccanCircle";
		}

		public SimpleWiccanCircleAddonDeed( Serial serial ) : base( serial )
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