using System; 
using Server; 

namespace Server.Items 
{ 
   public class PrizedLeather : Item 
   { 
      [Constructable] 
      public PrizedLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public PrizedLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Prized Leather";
	 Stackable = true;
	 Hue = 1153;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public PrizedLeather( Serial serial ) : base( serial ) 
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