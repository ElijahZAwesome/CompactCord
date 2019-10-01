using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CompactCord.Types
{
    class PresenceUpdate
    {
        public static User User;
        public static Snowflake[] Roles;
        public static Activity? Game;
        public static Snowflake GuildID;
        public static string Status;
        public static Activity[] Activities;
        public static ClientStatus ClientStatus;
    }
}
