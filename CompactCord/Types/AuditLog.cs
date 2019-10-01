using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CompactCord.Types
{

    public enum AuditLogEvents
    {
        GUILD_UPDATE = 1,
        CHANNEL_CREATE = 10,
        CHANNEL_UPDATE = 11,
        CHANNEL_DELETE = 12,
        CHANNEL_OVERWRITE_CREATE = 13,
        CHANNEL_OVERWRITE_UPDATE = 14,
        CHANNEL_OVERWRITE_DELETE = 15,
        MEMBER_KICK = 20,
        MEMBER_PRUNE = 21,
        MEMBER_BAN_ADD = 22,
        MEMBER_BAN_REMOVE = 23,
        MEMBER_UPDATE = 24,
        MEMBER_ROLE_UPDATE = 25,
        ROLE_CREATE = 30,
        ROLE_UPDATE = 31,
        ROLE_DELETE = 32,
        INVITE_CREATE = 40,
        INVITE_UPDATE = 41,
        INVITE_DELETE = 42,
        WEBHOOK_CREATE = 50,
        WEBHOOK_UPDATE = 51,
        WEBHOOK_DELETE = 52,
        EMOJI_CREATE = 60,
        EMOJI_UPDATE = 61,
        EMOJI_DELETE = 62,
        MESSAGE_DELETE = 72
    }

    class AuditLog
    {
        public static Webhook[] Webhooks;
        public static User[] Users;
        public static AuditLogEntry[] AuditLogEntries;
    }
    
    class AuditLogEntry
    {
        public static string? TargetID;
        public static AuditLogChange[] Changes;
        public static Snowflake UserID;
        public static Snowflake ID;
        public static int ActionType;
        public static OptionalAuditEntryInfo Options;
        public static string Reason;
    }

    class OptionalAuditEntryInfo
    {
        public static string DeleteMemberDays;
        public static string MembersRemoved;
        public static Snowflake ChannelID;
        public static string Count;
        public static Snowflake ID;
        public static string Type;
        public static string RoleName;
    }

    class AuditLogChange
    {
        public static object NewValue;
        public static object OldValue;
        public static string Key;
    }

    class AuditLogChangeKey
    {

    }
}
