// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class PottedColumbineGreenAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new PottedColumbineGreenAddonDeed();}}
		[ Constructable ]
		public PottedColumbineGreenAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 7870 );
			ac.Hue = 81;
			ac.Name = "columbine";
			AddComponent( ac, 0, 0, 7 );

			ac = new AddonComponent( 3332 );
			ac.Name = "leaves";
			AddComponent( ac, 0, 0, 3 );

			ac = new AddonComponent( 4551 );
			ac.Name = "Potted Columbine";
			AddComponent( ac, 0, 0, 0 );


		}
		public PottedColumbineGreenAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class PottedColumbineGreenAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new PottedColumbineGreenAddon();}}
		[Constructable]
		public PottedColumbineGreenAddonDeed(){Name = "PottedColumbineGreen";}
		public PottedColumbineGreenAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}