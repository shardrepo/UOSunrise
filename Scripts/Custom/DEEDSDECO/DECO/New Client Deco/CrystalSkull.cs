using System;
 
namespace Server.Items
{
    public class CrystalSkull : Item
    {
        [Constructable]
        public CrystalSkull() : base( 39450 )
        {
            this.Name = "Crystal Skull";
            this.Hue = 0;
        }
 
        public CrystalSkull( Serial serial ) : base( serial )
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
