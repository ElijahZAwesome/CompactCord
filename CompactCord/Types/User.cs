using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable enable
namespace CompactCord.Types
{
    class User
    {
        public static Snowflake ID;
        public static string Username;
        public static string Discriminator;
        public static bool Bot;
        public static bool MFA;
        public static string Locale;
        public static bool Verified;
        public static string Email;
        public static int Flags;
        public static int PremiumType;

        public static string? Avatar;

    }
}
