using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace HWID
{
	internal class Program
	{
		private static string string_0;

		private static Program rCiVQvZSBh4nuDB6ZUR;

		public static void Main2()
		{
			Console.WriteLine(Value());
		}

		private static string Value()
		{
			if (string.IsNullOrEmpty(string_0))
			{
				string_0 = smethod_0("CPU >> " + smethod_4() + "\nBIOS >> " + smethod_5() + "\nBASE >> " + smethod_6() + "\nDISK >> " + DiskId() + "\nVIDEO >> " + smethod_7() + "\nMAC >> " + smethod_8());
			}
			return string_0;
		}

		private static string smethod_0(string string_1)
		{
			return smethod_1(new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(string_1)));
		}

		private static string smethod_1(IList<byte> ilist_0)
		{
			string text = string.Empty;
			for (int i = 0; i < ilist_0.Count; i++)
			{
				int num = ilist_0[i];
				int num2 = num & 0xF;
				int num3 = (num >> 4) & 0xF;
				text = ((num3 <= 9) ? (text + num3.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
				text = ((num2 <= 9) ? (text + num2.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
				if (i + 1 != ilist_0.Count && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}

		private static string smethod_2(string string_1, string string_2, string string_3)
		{
			string text = "";
			foreach (ManagementBaseObject instance in new ManagementClass(string_1).GetInstances())
			{
				if (!(instance[string_3].ToString() != "True") && !(text != ""))
				{
					try
					{
						text = instance[string_2].ToString();
					}
					catch
					{
						continue;
					}
					break;
				}
			}
			return text;
		}

		private static string smethod_3(string string_1, string string_2)
		{
			string text = "";
			foreach (ManagementBaseObject instance in new ManagementClass(string_1).GetInstances())
			{
				if (!(text != ""))
				{
					try
					{
						text = instance[string_2].ToString();
					}
					catch
					{
						continue;
					}
					break;
				}
			}
			return text;
		}

		private static string smethod_4()
		{
			string text = smethod_3("Win32_Processor", "UniqueId");
			if (!(text != ""))
			{
				text = smethod_3("Win32_Processor", "ProcessorId");
				if (!(text != ""))
				{
					text = smethod_3("Win32_Processor", "Name");
					if (text == "")
					{
						text = smethod_3("Win32_Processor", "Manufacturer");
					}
					return text + smethod_3("Win32_Processor", "MaxClockSpeed");
				}
				return text;
			}
			return text;
		}

		private static string smethod_5()
		{
			return smethod_3("Win32_BIOS", "Manufacturer") + smethod_3("Win32_BIOS", "SMBIOSBIOSVersion") + smethod_3("Win32_BIOS", "IdentificationCode") + smethod_3("Win32_BIOS", "SerialNumber") + smethod_3("Win32_BIOS", "ReleaseDate") + smethod_3("Win32_BIOS", "Version");
		}

		public static string DiskId()
		{
			return smethod_3("Win32_DiskDrive", "Model") + smethod_3("Win32_DiskDrive", "Manufacturer") + smethod_3("Win32_DiskDrive", "Signature") + smethod_3("Win32_DiskDrive", "TotalHeads");
		}

		private static string smethod_6()
		{
			return smethod_3("Win32_BaseBoard", "Model") + smethod_3("Win32_BaseBoard", "Manufacturer") + smethod_3("Win32_BaseBoard", "Name") + smethod_3("Win32_BaseBoard", "SerialNumber");
		}

		private static string smethod_7()
		{
			return smethod_3("Win32_VideoController", "DriverVersion") + smethod_3("Win32_VideoController", "Name");
		}

		private static string smethod_8()
		{
			return smethod_2("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		public Program()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		static Program()
		{
			Class15.smethod_0();
			string_0 = string.Empty;
		}

		internal static bool TFJntQZDDeWYN4ncZRk()
		{
			return rCiVQvZSBh4nuDB6ZUR == null;
		}

		internal static void IADBeYZO8yaVbtKPhbN()
		{
		}
	}
}
