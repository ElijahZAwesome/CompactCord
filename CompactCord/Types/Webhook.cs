using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CompactCord.Types
{
    class Webhook
    {
        public static Snowflake ID;
        public static Snowflake GuildID;
        public static Snowflake ChannelID;
        public static User User;
        public static string? Name;
        public static string? Avatar;
        public static string Token;
    }
}
