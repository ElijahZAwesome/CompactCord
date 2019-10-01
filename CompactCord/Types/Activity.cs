using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompactCord.Types
{

    class Activity
    {
        public static string Name;
        public static int Type;
        public static string? URL;
        public static Timestamps Timestamps;
        public static Snowflake ApplicationID;
        public static string? Details;
        public static string? State;
        public static Party Party;
        public static Assets Assets;
        public static Secrets Secrets;
        public static bool Instance;
        public static int Flags;
    }

    class Timestamps
    {
        // Both are unix time epochs
        public static int Start;
        public static int End;
    }
    
    class Party
    {
        public static string ID;
        /// <summary>
        /// Always 2 ints
        /// </summary>
        public static int[] Size;
    }

    class Assets
    {
        public static string LargeImage;
        public static string LargeText;
        public static string SmallImage;
        public static string SmallText;
    }

    class Secrets
    {
        public static string Join;
        public static string Spectate;
        public static string Match;
    }
}
