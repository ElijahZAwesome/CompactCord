using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CompactCord.Types
{

    public enum ChannelTypes {
        GUILD_TEXT = 0,
        DM = 1,
        GUILD_VOICE = 2,
        GROUP_DM = 3,
        GUILD_CATEGORY = 4,
        GUILD_NEWS = 5,
        GUILD_STORE = 6
    }

    class Channel
    {
        public static Snowflake ID;
        public static int Type;
        public static Snowflake GuildID;
        public static int Position;
        public static Overwrite[] PermissionOverwrites;
        public static string Name;
        public static string? Topic;
        public static bool NSFW;
        public static Snowflake? LastMessageID;
        public static int Bitrate;
        public static int UserLimit;
        public static int RateLimitPerUser;
        public static User[] Recipients;
        public static string? Icon;
        public static Snowflake OwnerID;
        public static Snowflake ApplicationID;
        public static Snowflake? ParentID;
        /// <summary>
        /// The timestamp of the last pinned message in unix ISO8601 epoch format
        /// </summary>
        public static float LastPinTimestamp;
    }
}
