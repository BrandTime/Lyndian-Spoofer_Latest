using System;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Xeno
{
	internal class SystemBIOS
	{
		public static string Serials;

		private static Random random_0;

		internal static SystemBIOS bOTBRN3572YZKHxewhH;

		public static void SystemBiosSpoofID()
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.Start();
			process.StandardInput.WriteLine("cd C:\\Windows");
			process.StandardInput.WriteLine("AMIDEWINx64.exe /BS " + Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SS " + Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SU auto");
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SK " + Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /SF " + Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /CS " + Serials);
			process.StandardInput.WriteLine("AMIDEWINx64.exe /PSN " + Serials);
			process.StandardInput.WriteLine("exit");
			process.WaitForExit();
		}

		public static void DownloadDriver()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811326672242606120/AMIDEWINx64.exe", "C:\\Windows\\AMIDEWINx64.exe");
			webClient.Proxy = null;
		}

		public static void DownloadSys2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811326669230964776/amide.sys", "C:\\Windows\\amide.sys");
			webClient.Proxy = null;
		}

		public static void DownloadDriver2()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811326668463276052/AMIDEWIN.EXE", "C:\\Windows\\AMIDEWIN.exe");
			webClient.Proxy = null;
		}

		public static void DownloadSys()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811326666260873306/amifldrv64.sys", "C:\\Windows\\amifldrv64.sys");
			webClient.Proxy = null;
		}

		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat("0123456789", length)
				select s[random_0.Next(s.Length)]).ToArray());
		}

		public SystemBIOS()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		static SystemBIOS()
		{
			Class15.smethod_0();
			Serials = Console.ReadLine();
			random_0 = new Random();
		}

		internal static bool b3cHPy3zFt8wRtx68iJ()
		{
			return bOTBRN3572YZKHxewhH == null;
		}

		internal static void aQT7GjZYpxp3Hn1CsAU()
		{
		}
	}
}
