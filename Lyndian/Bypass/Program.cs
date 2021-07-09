using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Menu;

namespace Bypass
{
	internal class Program
	{
		internal static Program Uh0sIZZzFXt4Walumbr;

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern void BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool AllocConsole();

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

		public static void ShowConsoleWindow()
		{
			IntPtr consoleWindow = GetConsoleWindow();
			if (consoleWindow == IntPtr.Zero)
			{
				AllocConsole();
			}
			else
			{
				ShowWindow(consoleWindow, 5);
			}
		}

		public static void ConsoleHide()
		{
			ShowWindow(GetConsoleWindow(), 0);
		}

		public static void ConsoleShow()
		{
			Console.SetWindowSize(72, 30);
			ShowWindow(GetConsoleWindow(), 5);
		}

		private static void Main(string[] args)
		{
			Console.Title = "Lydian Spoofer 1.8.2";
			Console.SetWindowSize(85, 35);
			if (Process.GetProcessesByName("vgc").Length != 0)
			{
				MessageBox.Show("Vanguard Anti-Cheat is RUNNING!, please unistall Valorant and Vanguard and restart your pc before Use the Spoofer");
				Process[] processesByName = Process.GetProcessesByName("VALORANT");
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
				if (File.Exists("C:\\Program Files\\Riot Vanguard\\uninstall.exe"))
				{
					Process.Start(new ProcessStartInfo("C:\\\\Program Files\\\\Riot Vanguard\\\\uninstall.exe"));
					Environment.Exit(0);
				}
			}
			if (Process.GetProcessesByName("VALORANT").Length != 0)
			{
				Process[] processesByName2 = Process.GetProcessesByName("VALORANT");
				for (int j = 0; j < processesByName2.Length; j++)
				{
					processesByName2[j].Kill();
				}
				MessageBox.Show("Vanguard Anti-Cheat is RUNNING!, please unistall Valorant and Vanguard and restart your pc before Use the Spoofer");
				if (File.Exists("C:\\Program Files\\Riot Vanguard\\uninstall.exe"))
				{
					Process.Start(new ProcessStartInfo("C:\\\\Program Files\\\\Riot Vanguard\\\\uninstall.exe"));
					Environment.Exit(0);
				}
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://aviate.it/Nuova%20cartella/spoofer1.8.2on.txt");
			httpWebRequest.Method = "HEAD";
			try
			{
				_ = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			catch (WebException)
			{
				Console.Clear();
				SystemSounds.Beep.Play();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[+]Spoofer currently offline, Please try again later...");
				Console.ForegroundColor = ConsoleColor.Red;
				Thread.Sleep(5654);
				SystemSounds.Beep.Play();
				using (new WebClient())
				{
				}
				Environment.Exit(0);
			}
			Process[] processesByName3 = Process.GetProcessesByName("HWIDBypass");
			for (int k = 0; k < processesByName3.Length; k++)
			{
				processesByName3[k].Kill();
			}
			Program2.toel();
		}

		public Program()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		internal static bool d1LS5hdLMr2XMq7jUiO()
		{
			return Uh0sIZZzFXt4Walumbr == null;
		}

		internal static void gFtpNndYqf4rtgf9mKa()
		{
		}
	}
}
