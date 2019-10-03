using System;

namespace CompactCord
{
	namespace PublicVariables
	{

		public class Constants
		{
			// Blank means use the latest
			public const int APIVERSION = 6;
			public const string APIURL = "https://discordapp.com/api/";
            // MAKE SURE YOU ADD THE ABILITY TO UPDATE AND CACHE THIS
            public static string GATEWAYURL = "wss://gateway.discord.gg";
            public const int GATEWAYVERSION = 6;
            // Should never be changed
            public const string GATEWAYENCODING = "json";
            public const string CDNURL = "https://cdn.discordapp.com/";
			public const UInt64 DISCORDEPOCH = 1420070400000;
			public static string USERAGENT = $"User-Agent: DiscordBot ({APIURL}, {APIVERSION.ToString()})";
		}
	}
}
