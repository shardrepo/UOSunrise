using System;
using Server;

namespace Server.Items
{
	public class HealPotion : BaseHealPotion
	{
		public override int MinHeal { get{ return 75; } }
		public override int MaxHeal { get{ return 125; } }
		// public override double Delay{ get{ return (Core.AOS ? 8.0 : 10.0); } }
		public override double Delay { get{ return 4; } }

		[Constructable]
		public HealPotion() : base( PotionEffect.Heal )
		{
		}

		public HealPotion( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}