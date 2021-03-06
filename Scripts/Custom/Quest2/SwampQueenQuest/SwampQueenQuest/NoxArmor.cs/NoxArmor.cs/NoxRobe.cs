/////////////////////////////////////
//**Generated by Ryans Scripts**//
/////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class NoxRobe : HoodedShroudOfShadows
	{
	 	public override int ArtifactRarity{ get{ return 10; } }

	 	[Constructable]
	 	public NoxRobe()
	 	{
	 	 	Name = "Robe of the Swamp Queen";
	 	 	Hue = 2210;
			Attributes.BonusInt = 10;
			Attributes.BonusMana = 15;
			Attributes.BonusStam = 10;
			Attributes.CastRecovery = 0;
			Attributes.CastSpeed = 0;
			Attributes.DefendChance = 15;
			Attributes.Luck = 150;
			Attributes.NightSight = 0;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 3;
			Attributes.RegenMana = 3;

	 	}

	 	public NoxRobe(Serial serial) : base( serial )
	 	{
	 	}
	 	public override void Serialize( GenericWriter writer )
	 	{
	 	 	base.Serialize( writer );

	 	 	writer.Write( (int) 0 );
	 	}
	 	public override void Deserialize(GenericReader reader)
	 	{
	 	 	base.Deserialize( reader );

	 	 	int version = reader.ReadInt();
	 	}
	}
}
