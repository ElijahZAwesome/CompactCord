using System;

namespace CompactCord
{
	namespace PublicVariables
	{

		public class Constants
		{
			// Blank means use the latest
			public const string APIVERSION = "";
			public const string APIURL = "https://discordapp.com/api/";
			public const string CDNURL = "https://cdn.discordapp.com/";
			public const UInt64 DISCORDEPOCH = 1420070400000;
			public static string USERAGENT = $"User - Agent: DiscordBot({APIURL}, {APIVERSION}";
		}
	}
}
