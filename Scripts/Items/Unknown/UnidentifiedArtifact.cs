using System;
using Server;
using Server.Network;
using System.Text;
using Server.Items;
using Server.Mobiles;
using Server.Misc;

namespace Server.Items
{
	public class UnidentifiedArtifact : LockableContainer
	{
		public int IDAttempt;

		[CommandProperty(AccessLevel.Owner)]
		public int ID_Attempt { get { return IDAttempt; } set { IDAttempt = value; InvalidateProperties(); } }

		[Constructable]
		public UnidentifiedArtifact() : base( 0x9A8 )
		{
			Name = "unknown artifact";
			Locked = true;
			LockLevel = 1000;
			MaxLockLevel = 1000;
			RequiredSkill = 1000;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Sage Can Identify");
			list.Add( 1049644, "Use Item Identification To Determine What It Is"); // PARENTHESIS
        }

		public override void OnDoubleClick( Mobile from )
		{
			from.SendMessage( "This artifact is unidentified and cannot be used." );
		}

		public UnidentifiedArtifact( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
            writer.Write( IDAttempt );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            IDAttempt = reader.ReadInt();
		}
	}
}