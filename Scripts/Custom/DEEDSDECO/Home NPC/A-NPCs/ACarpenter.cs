using System;
using System.Collections;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
	public class ACarpenter : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
        protected override List<SBInfo> SBInfos { get { return m_SBInfos; } }
public override bool NoHouseRestrictions{ get{ return true; } }
		[Constructable]
		public ACarpenter() : base( "The Carpenter" )
		{
		    CantWalk = true;
		
			SetSkill( SkillName.Carpentry, 85.0, 100.0 );
			SetSkill( SkillName.Lumberjacking, 60.0, 83.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBStavesWeapon() );
			m_SBInfos.Add( new SBCarpenter() );
			m_SBInfos.Add( new SBWoodenShields() );
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Server.Items.HalfApron() );
		}

		public ACarpenter( Serial serial ) : base( serial )
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