using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompactCord.Types
{
    class Emoji
    {
        public static Snowflake? ID;
        public static string Name;
        // ONLY ROLE OBJECT IDs
        public static Snowflake[] Roles;
        public static User User;
        public static bool RequireColons;
        public static bool Managed;
        public static bool Animated;
    }
}
