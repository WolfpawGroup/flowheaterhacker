using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flowheaterhacker
{
	class gen
	{
		byte[][] arrays = new byte[6][];

		byte[] b1		= new byte[5];
		byte[] b2		= new byte[5];
		byte[] b3		= new byte[5];
		byte[] b4		= new byte[5];
		byte[] b5		= new byte[5];
		byte[] b6		= new byte[5];

		char[] bytes	= "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
		string bytestr	= "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public gen(string lastKey)
		{
			if (lastKey.Split('-').Length == 6)
			{
				setKey(lastKey);
			}

			arrays = new byte[][] { b1, b2, b3, b4, b5, b6 };
		}

		public void setKey(string key)
		{
			string[] ss = key.Split('-');
			b1 = Encoding.ASCII.GetBytes(ss[0]);
			b2 = Encoding.ASCII.GetBytes(ss[1]);
			b3 = Encoding.ASCII.GetBytes(ss[2]);
			b4 = Encoding.ASCII.GetBytes(ss[3]);
			b5 = Encoding.ASCII.GetBytes(ss[4]);
			b6 = Encoding.ASCII.GetBytes(ss[5]);
		}

		public string incrementKey(string key)
		{
			if (key.Split('-').Length == 6)
			{
				setKey(key);
			}

			for(int i = arrays.Length - 1; i > 0; i--)
			{
				byte[] b = arrays[i];
				string s = $"{b[0]}{b[1]}{b[2]}{b[3]}{b[4]}";
				if(s == "ZZZZZ") { b = new byte[] { 0, 0, 0, 0, 0 }; }
				else { b = incrementArray(b[0], b[1], b[2], b[3], b[4] ); arrays[i] = b; break; }
			}

			string ret = getString(arrays[0], arrays[1], arrays[2], arrays[3], arrays[4], arrays[5]);

			return ret;
		}

		private string getString(byte[] b1, byte[] b2, byte[] b3, byte[] b4, byte[] b5, byte[] b6  )
		{
			return $"{(char)b1[0]}{(char)b1[1]}{(char)b1[2]}{(char)b1[3]}{(char)b1[4]}-{(char)b2[0]}{(char)b2[1]}{(char)b2[2]}{(char)b2[3]}{(char)b2[4]}-{(char)b3[0]}{(char)b3[1]}{(char)b3[2]}{(char)b3[3]}{(char)b3[4]}-{(char)b4[0]}{(char)b4[1]}{(char)b4[2]}{(char)b4[3]}{(char)b4[4]}-{(char)b5[0]}{(char)b5[1]}{(char)b5[2]}{(char)b5[3]}{(char)b5[4]}-{(char)b6[0]}{(char)b6[1]}{(char)b6[2]}{(char)b6[3]}{(char)b6[4]}";
		}

		private byte[] incrementArray(byte b1, byte b2, byte b3, byte b4, byte b5)
		{
			b5 = incrementByte(b5);
			if (b5 == '0')
			{
				b4 = incrementByte(b4);
				if (b4 == '0')
				{
					b3 = incrementByte(b3);
					if (b3 == '0')
					{
						b2 = incrementByte(b2);
						if (b2 == '0')
						{
							b1 = incrementByte(b1);
						}
					}
				}
			}

			return new byte[] { b1, b2, b3, b4, b5 };
		}

		public byte incrementByte(byte b)
		{
			if (((char)b) == 'Z') { return (byte)'0'; }
			else
			{
				int i = bytestr.IndexOf((char)b);
				i++;
				return (byte)bytestr[i];
			}
		}

	}
}
