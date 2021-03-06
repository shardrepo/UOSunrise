// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class KitchenStoveEAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new KitchenStoveEAddonDeed();}}
		[ Constructable ]
		public KitchenStoveEAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 9230 );
			ac.Hue = 1;
			ac.Name = "door";
			AddComponent( ac, 1, 0, 0 );

			ac = new AddonComponent( 7027 );
			ac.Hue = 962;
			ac.Name = "Burner";
			AddComponent( ac, 0, 0, 10 );

			ac = new AddonComponent( 678 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, -1, 0, 10 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, 0, 0, 5 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 4234 );
			ac.Hue = 962;
			ac.Name = "dial";
			AddComponent( ac, 0, 1, 17 );

			ac = new AddonComponent( 9230 );
			ac.Hue = 1;
			ac.Name = "door";
			AddComponent( ac, 1, 1, 0 );

			ac = new AddonComponent( 7027 );
			ac.Hue = 962;
			ac.Name = "Burner";
			AddComponent( ac, 0, 1, 10 );

			ac = new AddonComponent( 676 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 678 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, -1, 1, 10 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, 0, 1, 5 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, 0, 1, 0 );


		}
		public KitchenStoveEAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class KitchenStoveEAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new KitchenStoveEAddon();}}
		[Constructable]
		public KitchenStoveEAddonDeed(){Name = "KitchenStoveE";}
		public KitchenStoveEAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}