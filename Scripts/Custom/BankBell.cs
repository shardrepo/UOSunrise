using System;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
	public class BankBell : Item
	{
		[Constructable]
		public BankBell() : base( 7186 )
		{
			Movable = true;
			Name = "Bank Bell";
			Hue = 1151 ;
			LootType=LootType.Blessed;
		}

		public override void OnDoubleClick( Mobile from )
		{

			PlayerMobile pm = from as PlayerMobile;

			
			if ( from.Criminal )
			{
				from.SendMessage( "Thou art a criminal and cannot access thy bank box." );
			}

			else
			{

				BankBox box = from.BankBox;

				if ( box != null )
					box.Open();
			}
 
		        
		{ 
			from.SendLocalizedMessage( 500446 ); // That is too far away. 
		}
		}

		public override bool HandlesOnSpeech { get { return true; } }

		public override void OnSpeech(SpeechEventArgs e)
		{
			if (!e.Handled && this.IsChildOf(e.Mobile.Backpack))
			{
				for (int i = 0; i < e.Keywords.Length; ++i)
				{
					int keyword = e.Keywords[i];

					if ( e.Mobile.Criminal )
					{
						e.Mobile.SendMessage( "Thou art a criminal and cannot access thy bank box." );
					}
					else
					{
						switch (keyword)
						{
							case 0x0000: // *withdraw* 
							{
								e.Handled = true;

								string[] split = e.Speech.Split(' ');

								if (split.Length >= 2)
								{
									int amount;

									try
									{
										amount = Convert.ToInt32(split[1]);
									}
									catch
									{
										break;
									}

									if (amount > 5000)
									{
										this.Say(500381); // Thou canst not withdraw so much at one time! 
									}
									else if (amount > 0)
									{
										BankBox box = e.Mobile.BankBox;

										if (box == null || !box.ConsumeTotal(typeof(Gold), amount))
										{
											this.Say(500384); // Ah, art thou trying to fool me? Thou hast not so much gold! 
										}
										else
										{
											e.Mobile.AddToBackpack(new Gold(amount));

											this.Say(1010005); // Thou hast withdrawn gold from thy account. 
										}
									}
								}

								break;
							}
							case 0x0001: // *balance* 
							{
								e.Handled = true;

								BankBox box = e.Mobile.BankBox;

								if (box != null)
								{
									this.Say(String.Format("Thy current bank balance is {0} gold.", box.TotalGold.ToString()));
								}

								break;
							}
							case 0x0002: // *bank* 
							{
								e.Handled = true;

								BankBox box = e.Mobile.BankBox;

								if (box != null)
									box.Open();

								break;
							}
							case 0x0003: // *check* 
							{
								e.Handled = true;

								string[] split = e.Speech.Split(' ');

								if (split.Length >= 2)
								{
									int amount;

									try
									{
										amount = Convert.ToInt32(split[1]);
									}
									catch
									{
										break;
									}

									if (amount < 5000)
									{
										this.Say(1010006); // We cannot create checks for such a paltry amount of gold! 
									}
									else if (amount > 1000000)
									{
										this.Say(1010007); // Our policies prevent us from creating checks worth that much! 
									}
									else
									{
										BankCheck check = new BankCheck(amount);

										BankBox box = e.Mobile.BankBox;

										if (box == null || !box.TryDropItem(e.Mobile, check, false))
										{
											this.Say(500386); // There's not enough room in your bankbox for the check! 
											check.Delete();
										}
										else if (!box.ConsumeTotal(typeof(Gold), amount))
										{
											this.Say(500384); // Ah, art thou trying to fool me? Thou hast not so much gold! 
											check.Delete();
										}
										else
										{
											this.Say(String.Format("Into your bank box I have placed a check in the amount of: {0}", amount.ToString()));
										}
									}
								}

								break;
							}
						}
					}
				}
			}
		}

		public void Say(int number)
		{
			PublicOverheadMessage(MessageType.Regular, 0x3B2, number);
		}
		
		public void Say(string args)
		{
			PublicOverheadMessage(MessageType.Regular, 0x3B2, false, args);
		} 
		
		public BankBell( Serial serial ) : base( serial )
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