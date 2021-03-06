using System;
using Server.Items;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	[CorpseName( "an Icy AIcyMyrmidex corpse" )]
	public class AIcyMyrmidex : BaseCreature
	{
		[Constructable]
		public AIcyMyrmidex () : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "an Icy Myrmidex";
			Body = 1293;
			BaseSoundID = 362;
			Hue = 0;

			SetStr( 300 );
			SetDex( 153, 172 );
			SetInt( 250, 300 );

			SetHits( 50, 150 );

			SetDamage( 30, 35 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Poison, 50 );
			SetDamageType( ResistanceType.Fire, 60 );
			SetDamageType( ResistanceType.Energy, 50 );
			SetDamageType( ResistanceType.Cold, 100 );

			SetResistance( ResistanceType.Physical, 60, 75 );
			SetResistance( ResistanceType.Fire, 65, 70 );
			SetResistance( ResistanceType.Cold, 70, 75 );
			SetResistance( ResistanceType.Poison, 90, 100 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.Poisoning, 60.1, 80.0 );
			SetSkill( SkillName.MagicResist, 65.1, 80.0 );
			SetSkill( SkillName.Tactics, 65.1, 90.0 );
			SetSkill( SkillName.Wrestling, 65.1, 80.0 );
            this.SetSkill(SkillName.EvalInt, 60.1, 80.0);
            this.SetSkill(SkillName.Magery, 60.1, 80.0);

            Fame = 400;
			Karma = -400;

			VirtualArmor = 45;

		}

		public override void GenerateLoot()
		{
			if (this.Region is ChampionSpawnRegion)
			{
			return;
			}
			else
			{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Meager );
			AddLoot( LootPack.MedScrolls );
		}
        }
        /*public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (0.20 > Utility.RandomDouble())
            {
                switch (Utility.Random(3))
                {
                    case 0: c.DropItem(new FalseHalf()); break;
                    case 1: c.DropItem(new ThiefHalf()); break;
                    case 2: c.DropItem(new TrueHalf()); break;
                }
            }
        }*/
		//public override bool ReaquireOnMovement{ get{ return true; } }

		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override Poison HitPoison{ get{ return Poison.Deadly; } }
		public override int TreasureMapLevel{ get{ return 2; } }

		public override int Meat{ get{ return 10; } }
		public override int Hides{ get{ return 20; } }
		public override HideType HideType{ get{ return HideType.Horned; } }

		public override int GetAttackSound()
		{
			return 713;
		}

		public override int GetAngerSound()
		{
			return 718;
		}

		public override int GetDeathSound()
		{
			return 716;
		}

		public override int GetHurtSound()
		{
			return 721;
		}

		public override int GetIdleSound()
		{
			return 725;
		}

		public AIcyMyrmidex( Serial serial ) : base( serial )
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