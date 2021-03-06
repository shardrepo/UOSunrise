using System;
using Server;

namespace Server.Items
{
	public class BloodwoodSpirit : MagicTalisman
	{
		public override int LabelNumber{ get{ return 1075034; } } // Bloodwood Spirit

		[Constructable]
		public BloodwoodSpirit() : base( 0x2F5A )
		{
			Hue = 0x27;
			SkillBonuses.SetValues( 0, SkillName.SpiritSpeak, 30.0 );
			SkillBonuses.SetValues( 1, SkillName.Necromancy, 20.0 );
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artifact");
        }

		public BloodwoodSpirit( Serial serial ) :  base( serial )
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
