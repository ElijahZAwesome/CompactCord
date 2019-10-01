using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompactCord.Types
{

    public enum DefaultNotificationLevel
    {
        ALL_MESSAGES = 0,
        ONLY_MENTIONS = 1
    }

    public enum ExplicitFilterLevel
    {
        DISABLED = 0,
        MEMBERS_WITHOUT_ROLES = 1,
        ALL_MEMBERS = 2
    }

    public enum MFALevel
    {
        NONE = 0,
        ELEVATED = 1
    }

    public enum VerificationLevel
    {
        NONE = 0,
        LOW = 1,
        MEDIUM = 2,
        HIGH = 3,
        VERY_HIGH = 4
    }

    public enum PremiumTier
    {
        NONE = 0,
        TIER_1 = 1,
        TIER_2 = 2,
        TIER_3 = 3
    }

    class Guild
    {
        public static Snowflake ID;
        public static string Name;
        public static string? Icon;
        public static string? Splash;
        public static bool Owner;
        public static Snowflake OwnerID;
        public static int Permissions;
        public static string Region;
        public static Snowflake? AFKChannelID;
        public static int AFKTimeout;
        public static bool EmbedEnabled;
        public static Snowflake EmbedChannelID;
        public static int VerificationLevel;
        public static int DefaultMessageNotifications;
        public static int ExplicitContentFilter;
        public static Role[] Roles;
        public static Emoji[] Emojis;
        public static string[] Features;
        public static int MFALevel;
        public static Snowflake? ApplicationID;
        public static bool WidgetEnabled;
        public static Snowflake WidgetChannelID;
        public static Snowflake? SystemChannelID;
        // A ISO8601 Unix Epoch time
        public static float JoinedAt;
        public static bool Large;
        public static bool Unavailable;
        public static int MemberCount;
        public static VoiceState[] VoiceStates;
        public static GuildMember[] Members;
        public static Channel[] Channels;
        // Presence update object here
    }

    class GuildMember
    {

    }

    class GuildFeatures
    {
        public const string InviteSplash = "INVITE_SPLASH";
        public const string VIPRegions = "VIP_REGIONS";
        public const string VanityURL = "VANITY_URL";
        public const string Verified = "VERIFIED";
        public const string Partnered = "PARTNERED";
        public const string Lurkable = "LURKABLE";
        public const string Commerce = "COMMERCE";
        public const string News = "NEWS";
        public const string Discoverable = "DISCOVERABLE";
        public const string Featurable = "FEATURABLE";
        public const string AnimationIcon = "ANIMATED_ICON";
        public const string Banner = "BANNER";
    }

}
