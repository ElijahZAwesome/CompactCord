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
	}
}