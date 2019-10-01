using System;
using System.Linq;
using System.Text;

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
	}
}