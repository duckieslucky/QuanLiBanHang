using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL.Methods
{
    public class Base64Convert
    {
		public static string ToBase64Encode(string text)
		{
			if (String.IsNullOrEmpty(text))
			{
				return text;
			}

			byte[] textBytes = Encoding.UTF8.GetBytes(text);
			return Convert.ToBase64String(textBytes);
		}

		public static string ToBase64Decode(string base64EncodedText)
		{
			if (String.IsNullOrEmpty(base64EncodedText))
			{
				return base64EncodedText;
			}

			byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedText);
			return Encoding.UTF8.GetString(base64EncodedBytes);
		}
	}
}
