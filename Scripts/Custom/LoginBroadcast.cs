/*#Login/logout broadcasting
# * Author: mordero
# * Email: mordero@gmail.com
# * Description: Will broadcast to current online players when someone has logged in/out. If the person who has logged in/out is above the player access level, it only broadcasts to the staff.
# * Description of Edit: When a new character is created, a message with their name, will be broadcasted to current online players. 
# * Additional Info: You may edit the New Player Message to your liking. Remember that the {0} denotes the player's name.
# * Installation: Just drag into your custom scripts folder.
# * Additional edits made by Orbit Storm to include a New Player Login Broadcast (and cleanup of wording for easier understanding).
# * All credit goes to mordero for developing this script and releasing it on RunUO. Please leave this header intact if you redistribute!
*/

// DOC - Sent messages to Bittiez Chat instead of broadcast
using System;
using System.Text;
using Server;
using Server.Commands;

using Server.Gumps;

namespace mordero.Custom
{
    class Broadcast
    {
        //{0} is the name of the player
        private readonly static string m_LoginMessage = "has joined UOSunrise.";//Login Message
        private readonly static string m_LogoutMessage = "logged out.";//Logout Message
        private readonly static int m_LoginHue = 0x482;//Login Message Hue
        private readonly static int m_LogoutHue = 0x482;//Logout Message Hue
        private readonly static string m_NewPlayerMessage = "Hello! I am a new player!"; //New Player Message
        private readonly static int m_NewPlayerHue = 33; //New Player Message Hue
        //maximum access level to announce
        private static AccessLevel m_AnnounceLevel = AccessLevel.Player;



        /// <summary>
        /// Subscribes to the login and out event
        /// </summary>
        public static void Initialize()
        {
          //  Init CS = Init.Chat_Server;
          //  CS.LastMessage = CHAN.WORLD;
            EventSink.Login += new LoginEventHandler(EventSink_Login);
            EventSink.Logout += new LogoutEventHandler(EventSink_Logout);
            EventSink.CharacterCreated += new CharacterCreatedEventHandler(EventSink_CharacterCreated);
        }
        /// <summary>
        /// On player logout, broadcast a message.
        /// </summary>
        public static void EventSink_Logout(LogoutEventArgs e)
        {
            if (e.Mobile.Player )
            {
                if (e.Mobile.AccessLevel <= m_AnnounceLevel)
               {
                   
                   
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LogoutHue, String.Format(m_LogoutMessage, e.Mobile.Name));
                    CommandHandlers.BroadcastMessage(AccessLevel.Counselor, m_LoginHue, String.Format(m_LogoutMessage, e.Mobile.Name));
                   
               }
                else //broadcast any other level to the staff
                    CommandHandlers.BroadcastMessage(AccessLevel.Counselor, m_LogoutHue, String.Format(m_LogoutMessage, e.Mobile.Name));
            }
        }
        /// <summary>
        /// On player login, broadcast a message.
        /// </summary>
        public static void EventSink_Login(LoginEventArgs e)
        {
            if (e.Mobile.Player )
            {
                if (e.Mobile.AccessLevel <= m_AnnounceLevel)
                {
                   
                   
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LoginHue, String.Format(m_LoginMessage, e.Mobile.Name));
                    
               }
               else //broadcast any other level to the staff
                   // DocLib.ipinfodb.WebAPI();
                   CommandHandlers.BroadcastMessage(AccessLevel.Counselor, m_LoginHue, String.Format(m_LoginMessage, e.Mobile.Name));
                }
            }
        
    
		/// Edit by Orbit Storm
		/// <summary> 
		/// On new player login, broadcast a message.
		/// </summary>
		public static void EventSink_CharacterCreated( CharacterCreatedEventArgs e )
        {
            if ( e.Mobile != null ) {
                if ( e.Mobile.AccessLevel == AccessLevel.Player ) {
                  
                    CommandHandlers.BroadcastMessage( AccessLevel.Player, m_NewPlayerHue, String.Format(m_NewPlayerMessage, e.Mobile.Name));
                    
                }
            }
        }
	}
}
