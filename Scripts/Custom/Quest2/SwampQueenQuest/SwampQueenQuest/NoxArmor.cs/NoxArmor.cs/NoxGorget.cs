/////////////////////////////////////
//**Generated by Ryans Scripts**//
/////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class NoxGorget : LeatherGorget
	{
	 	public override int ArtifactRarity{ get{ return 10; } }
	 	public override int InitMinHits{ get{ return 255; } }
	 	public override int InitMaxHits{ get{ return 255; } }

	 	[Constructable]
	 	public NoxGorget()
	 	{
	 	 	Name = "Gorget of the Swamp Queen";
	 	 	Hue = 2210;
	 	 	ArmorAttributes.MageArmor = 0;
	 	 	ArmorAttributes.SelfRepair = 5;
            PhysicalBonus = 10;
            PoisonBonus = 10;
            EnergyBonus = 10;
            ColdBonus = 10;
            FireBonus = 10;
	 	 	Attributes.AttackChance = 15;
	 	 	Attributes.RegenHits = 2;
	 	 	Attributes.RegenMana = 3;
	 	 	Attributes.RegenStam = 2;
	 	 	Attributes.SpellDamage = 25;
	 	 	Attributes.WeaponSpeed = 10;
	 	 	Attributes.NightSight = 0;
	 	}

	 	public NoxGorget(Serial serial) : base( serial )
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
