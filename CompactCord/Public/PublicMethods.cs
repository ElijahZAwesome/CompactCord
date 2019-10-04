using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace CompactCord
{
	/// <summary>
	/// This namespace will house all methods that might be used later, using classes named
	/// after the type used or the actions being performed.
	/// </summary>
	namespace PublicMethods
	{

		public static class Bytes
		{

            public static bool ByteArrayToFile(string fileName, byte[] byteArray)
            {
                try
                {
                    using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(byteArray, 0, byteArray.Length);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught in process: {0}", ex);
                    return false;
                }
            }
            public static decimal ByteArrayToDecimal(byte[] src, int offset)
			{
				var i1 = BitConverter.ToInt32(src, offset);
				var i2 = BitConverter.ToInt32(src, offset + 4);
				var i3 = BitConverter.ToInt32(src, offset + 8);
				var i4 = BitConverter.ToInt32(src, offset + 12);

				return new decimal(new int[] { i1, i2, i3, i4 });
			}

			public static byte[] ConvertToByteArray(string str, Encoding encoding)
			{
				return encoding.GetBytes(str);
			}

			public static String ToBinary(Byte[] data)
			{
				return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')).ToArray());
			}
		}

        public static class Strings
        {

            private static Random random = new Random();
            public static string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }

            public static string StripPrefix(string text, string prefix)
            {
                return text.StartsWith(prefix) ? text.Substring(prefix.Length) : text;
            }

            public static string Base64Encode(string plainText)
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }

            public static string Base64Decode(string base64EncodedData)
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes, 0, base64EncodedBytes.Length);
            }

        }

        public static class DiscordSockets
        {
            public static string ConstructURI(string baseURI, List<KeyValuePair<string, object>> parameters)
            {
                if(baseURI.Substring(baseURI.Length - 1) != "/")
                {
                    baseURI += "/";
                }
                string finalURI = baseURI + "?";
                for(int i = 0; i < parameters.Count; i++)
                {
                    finalURI += parameters[i].Key + "=" + parameters[i].Value.ToString() + "&";
                }
                finalURI = finalURI.Remove(finalURI.Length - 1, 1);
                return finalURI;
            }
        }
	}
}