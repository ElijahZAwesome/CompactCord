using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CompactCord.Types
{
    class VoiceState
    {
        public static Snowflake GuildID;
        public static Snowflake? ChannelID;
        public static Snowflake UserID;
        public static GuildMember Member;
        public static string SessionID;
        public static bool Deaf;
        public static bool Mute;
        public static bool SelfDeaf;
        public static bool SelfMute;
        public static bool SelfStream;
        public static bool Suppress;
    }

    class VoiceRegion
    {
        public static string ID;
        public static string Name;
        public static bool VIP;
        public static bool Optimal;
        public static bool Deprecated;
        public static bool Custom;
    }
}
