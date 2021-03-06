using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Fuerety corpse" )]
	public class Fuerety : BaseCreature
	{
		public override WeaponAbility GetWeaponAbility()
		{
			return WeaponAbility.MortalStrike;
		}

		[Constructable]
		public Fuerety() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "A Fuerety";
			Body = 748;
            Hue = 1922;
			BaseSoundID = 0x482;

			SetStr( 226, 250 );
			SetDex( 176, 200 );
			SetInt( 86, 110 );

			SetHits( 375, 575 );

			SetDamage( 25, 35 );

			SetDamageType( ResistanceType.Physical, 40 );
			SetDamageType( ResistanceType.Cold, 60 );

			SetResistance( ResistanceType.Physical, 50, 60 );
			SetResistance( ResistanceType.Fire, 25, 30 );
			SetResistance( ResistanceType.Cold, 70, 80 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.MagicResist, 70.1, 95.0 );
			SetSkill( SkillName.Tactics, 90.1, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 8500;
			Karma = -6500;

			VirtualArmor = 45;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager );
		}

		public override bool BleedImmune{ get{ return true; } }

		public Fuerety( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}