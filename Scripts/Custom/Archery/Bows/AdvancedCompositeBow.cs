using System;
using Server.Network;
using Server.Items;
using Server.Targeting;


namespace Server.Items
{
	[FlipableAttribute( 0x26C2, 0x26CC )]
	public class AdvancedCompositeBow : CBaseRanged
	{
		private BaseRanged m_branged;
		public override int EffectID{ get{ return 0xF42; } }
		public override Type AmmoType { get { return GetArrowSelected(); } }
		public override Item Ammo { get { return AmmoSelected(); } }
		private ArrowType m_ArrowType;
		
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MovingShot; } }
		
		public override int AosStrengthReq{ get{ return 45; } }
		public override int AosMinDamage{ get{ return 15; } }
		public override int AosMaxDamage{ get{ return 17; } }
		public override int AosSpeed{ get{ return 25; } }
		
		public override int OldStrengthReq{ get{ return 45; } }
		public override int OldMinDamage{ get{ return 15; } }
		public override int OldMaxDamage{ get{ return 17; } }
		public override int OldSpeed{ get{ return 25; } }
		
		public override int DefMaxRange{ get{ return 10; } }
		
		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 70; } }
		
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.ShootBow; } }
		
		[CommandProperty(AccessLevel.GameMaster)]
		public ArrowType ArrowSelection
		{
			get { return m_ArrowType; }
			set { m_ArrowType = value; InvalidateProperties(); }
		}
		
		[Constructable]
		public AdvancedCompositeBow() : base( 0x26C2 )
		{
			Weight = 5.0;
		}

        public AdvancedCompositeBow(Serial serial)
            : base(serial)
		{
		}
		
		public virtual Item AmmoSelected()
		{
			switch (m_ArrowType)
			{
				case ArrowType.Normal:
					return new Arrow();
				case ArrowType.Poison:
					return new PoisonArrow();
				case ArrowType.Explosive:
					return new ExplosiveArrow();
				case ArrowType.ArmorPiercing:
					return new ArmorPiercingArrow();
				case ArrowType.Freeze:
					return new FreezeArrow();
				case ArrowType.Lightning:
					return new ALightningArrow();
					
				default:
					return new Arrow();
			}
		}
		
		public virtual Type GetArrowSelected()
		{
			switch (m_ArrowType)
			{
				case ArrowType.Normal:
					return typeof(Arrow);
				case ArrowType.Poison:
					return typeof(PoisonArrow);
				case ArrowType.Explosive:
					return typeof(ExplosiveArrow);
				case ArrowType.ArmorPiercing:
					return typeof(ArmorPiercingArrow);
				case ArrowType.Freeze:
					return typeof(FreezeArrow);
				case ArrowType.Lightning:
					return typeof(ALightningArrow);
					
				default:
					return typeof(Arrow);
			}
		}
		
		public override void OnDoubleClick(Mobile from)
		{
			if (IsChildOf(from.Backpack) || Parent == from)
			{
				from.SendMessage("Please choose which type of arrows you wish to use.");
				from.Target = new InternalTarget(this);
			}
			
			else
				return;
		}
		
		private class InternalTarget : Target
		{
            private AdvancedCompositeBow it_Bow;

            public InternalTarget(AdvancedCompositeBow bow)
                : base(1, false, TargetFlags.None)
			{
				it_Bow = bow;
			}
			
			protected override void OnTarget(Mobile from, object targeted)
			{
				if (targeted is Item)
				{
					Item item = (Item)targeted;
					
					if (item.GetType() == typeof(Arrow))
						it_Bow.ArrowSelection = ArrowType.Normal;
					else if (item.GetType() == typeof(PoisonArrow) )
						it_Bow.ArrowSelection = ArrowType.Poison;
					else if (item.GetType() == typeof(ExplosiveArrow) )
						it_Bow.ArrowSelection = ArrowType.Explosive;
					else if (item.GetType() == typeof(ArmorPiercingArrow) )
						it_Bow.ArrowSelection = ArrowType.ArmorPiercing;
					else if (item.GetType() == typeof(FreezeArrow) )
						it_Bow.ArrowSelection = ArrowType.Freeze;
					else if (item.GetType() == typeof(ALightningArrow) )
						it_Bow.ArrowSelection = ArrowType.Lightning;
					
					else
						from.SendMessage("Must select an Arrow Type");
					
				}
				else
					from.SendMessage("Can Only Target Arrow Items");
			}
		}
		
		public override void GetProperties(ObjectPropertyList list)
		{
			base.GetProperties(list);
			list.Add("Advanced Composite Bow");
			list.Add("Dbl-click Select Ammo");
			list.Add(1060662, "{0}\t{1}", "Arrow Type", m_ArrowType.ToString());
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write((int)1); // version
			
			writer.WriteEncodedInt((int)m_ArrowType);
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
			
			if (Weight == 7.0)
				Weight = 6.0;

			if (version == 0)
				version = 1;

			switch ( version )
			{
				case 1:
				{
					m_ArrowType = (ArrowType)reader.ReadEncodedInt();
					goto case 0;
				}

				case 0:
				{
					break;
				}
			}
		}
	}
}
