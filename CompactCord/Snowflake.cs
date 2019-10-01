using System;
using System.Text;
using CompactCord.PublicMethods;
using CompactCord.PublicVariables;

namespace CompactCord {

	public class Snowflake
	{

		public static Byte[] AsBytes;
		public static UInt64 AsUint64;
		public static String AsString;
		public static String OriginalID;
		public static DateTime TimeStamp;
		public static float TimeStampAsEpoch;

		/// <summary>
		/// This constructor constructs a Snowflake object from an EXISTING SNOWFLAKE STRING.
		/// Use this in conjunction with Discord's API.
		/// </summary>
		/// <param name="input">A snowflake ID string.</param>
		public Snowflake(string input)
		{
			OriginalID = input;
			Byte[] bytesVer = Bytes.ConvertToByteArray(input, Encoding.ASCII);
			AsBytes = bytesVer;
			AsString = bytesVer.ToString();
			AsUint64 = UInt64.Parse(input);
			byte[] results = new byte[22];
			int index = Array.IndexOf(AsBytes, (byte)0x55);
			Array.Copy(AsBytes, index, results, 0, 22);
			float epochTime = (float)Bytes.ByteArrayToDecimal(results, 0) + Constants.DISCORDEPOCH;
			TimeStampAsEpoch = epochTime;
			DateTime dateTime = DateTime.Parse(epochTime.ToString());
			TimeStamp = dateTime;
		}

		/// <summary>
		/// Generates a new Snowflake object from a passed epoch time (will subtract discord epoch time)
		/// </summary>
		/// <param name="epoch">A Unix Epoch time to pass.</param>
		public Snowflake(float epoch)
		{
			// Not really sure how im supposed to get the processor/worker IDs so just gonna stub this for now
			// timestamp_ms - DISCORD_EPOCH << 22
		}

		/// <summary>
		/// Generates a new Snowflake object using a DateTime object (subtracts the discord epoch time)
		/// </summary>
		/// <param name="timeStamp">Timestamp used to create the snowflake.</param>
		public Snowflake(DateTime timeStamp)
		{
			// Not really sure how im supposed to get the processor/worker IDs so just gonna stub this for now
			// timestamp_ms - DISCORD_EPOCH << 22
		}
	}
}