using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Approve.Properties;

namespace Approve
{
	public partial class Form1 : Form
	{
		public static Form2 form2 = new Form2();
		private string currentVersion = "29";
		public static string kayitOlunanProgram = "tfmclient4";
		public static string hwid = "";
		private string kalanOnay = "?";
		
		public Form1()
		{
			this.InitializeComponent();
		}
		private static string _54572484767423326841431()
		{
			string result = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					result = ((ManagementObject)enumerator.Current).Properties["processorID"].Value.ToString();
				}
			}
			return result;
		}
		private static string _47987949355597764284845(string diskLetter = "C")
		{
			if (!string.IsNullOrEmpty(diskLetter) && diskLetter.EndsWith(":\\"))
			{
				diskLetter = diskLetter.Substring(0, diskLetter.Length - 2);
			}
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + diskLetter + ":\"");
			managementObject.Get();
			string result = managementObject["VolumeSerialNumber"].ToString();
			managementObject.Dispose();
			return result;
		}
		private static string HashFunction(string input)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(input);
				byte[] array = md.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}
		private static string _5913299243491()
		{
			string text = "";
			try
			{
				string text2 = Form1._54572484767423326841431();
				text = Form1.HashFunction(string.Concat(new string[]
				{
					text2,
					text2,
					Form1._47987949355597764284845("C"),
					Environment.MachineName,
					Environment.UserName
				}));
			}
			catch (Exception)
			{
				text = Form1.HashFunction(Environment.MachineName + Environment.UserName);
				text = "PPP" + text.Substring(3);
			}
			return text;
		}
		private static string getOS()
		{
			object obj = (from ManagementObject x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()
			select x.GetPropertyValue("Caption")).FirstOrDefault<object>();
			if (obj != null)
			{
				string text = obj.ToString();
				string result;
				if (text.Contains("XP"))
				{
					result = "Windows XP";
				}
				else if (text.Contains("Vista"))
				{
					result = "Windows Vista";
				}
				else if (text.Contains("2003"))
				{
					result = "Windows 2003 Server";
				}
				else if (text.Contains("2008"))
				{
					result = "Windows 2008 Server";
				}
				else if (text.Contains("2012"))
				{
					result = "Windows 2012 Server";
				}
				else if (text.Contains("2016"))
				{
					result = "Windows 2016 Server";
				}
				else if (text.Contains("2019"))
				{
					result = "Windows 2019 Server";
				}
				else if (text.Contains("7"))
				{
					result = "Windows 7";
				}
				else if (text.Contains("8.1"))
				{
					result = "Windows 8.1";
				}
				else if (text.Contains("8"))
				{
					result = "Windows 8";
				}
				else if (text.Contains("10"))
				{
					result = "Windows 10";
				}
				else
				{
					result = text;
				}
				return result;
			}
			return "Unknown";
		}
		private void _8554774816617277291255563794641(object sender, EventArgs e)
		{
			this.Text = Program.rm.GetString("f2Title");
			Form1.hwid = Form1._5913299243491();
			if (Settings.Default.language == "first_opening")
			{
				Settings.Default.language = this._9253555765228(Form1.hwid);
				Settings.Default.Save();
			}
			Program.languageToRM(0);
			this.mevcutSurumLabel.Text = "ver: " + this.currentVersion;
			this.TitleLabel.Text = Program.rm.GetString("f1Connecting");
			this.AltLabel.Text = Program.rm.GetString("f1PleaseWait");
			this.runGo.Start();
		}
		private static string Update()
		{
			string remoteContent = Program.GetRemoteContent("https://raw.githubusercontent.com/hilebolonline/updates/master/AdApprove/version.txt", 10000);
			if (remoteContent != "TIMEOUT" && !string.IsNullOrEmpty(remoteContent))
			{
				return remoteContent;
			}
			return "-1";
		}
		private static void _DownloadFile(string url, string dest)
		{
			new WebClient().DownloadFile(url, dest);
		}
		private void _86773766584353856274757112382398()
		{
			try
			{
				Form1._DownloadFile("https://raw.githubusercontent.com/hilebolonline/updates/master/AdApproveUpdater.exe", Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "adApproveUpdater.exe"));
				Thread.Sleep(3000);
			}
			catch (Exception)
			{
				MessageBox.Show(Program.rm.GetString("f2UpdaterCantDownloaded"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		private void _2667539869999567839563()
		{
			Process.Start("adApproveUpdater.exe");
			Application.Exit();
		}
		public void _615843867912986448972238254681997()
		{
			try
			{
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "adApproveUpdater.exe")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "adApproveUpdater.exe"));
				}
			}
			catch (Exception)
			{
			}
		}

		public static string _5814324214581761742558779927612(string hwid)
		{
			string result = "";
			try
			{
				result = Program.GetRemoteContent(string.Concat(new string[] { "http://127.0.0.1/pgiex/hwidcheck.php?hwid=", hwid, "&kayitprogram=", Form1.kayitOlunanProgram, "&os=", Form1.getOS() }), 10000);
			}
			catch (Exception)
			{
				result = "TIMEOUT";
			}
			return result;
		}

		private string _9253555765228(string hwid)
		{
			string remoteContent = Program.GetRemoteContent("https://localhost/pgiex/get_language.php?hwid=" + hwid, 10000);
			if (remoteContent.Length > 2 || remoteContent == "TIMEOUT" || string.IsNullOrEmpty(remoteContent))
			{
				return "EN";
			}
			if(remoteContent == "US" || remoteContent == "UK" || remoteContent == "AU") return "EN";
			return remoteContent;
		}

		private void os_hereWeGo()
		{
			string text = Form1.Update();
			if (text != "TIMEOUT" && !string.IsNullOrEmpty(text))
			{
				if (!(text == this.currentVersion))
				{
					this._86773766584353856274757112382398();
					this._2667539869999567839563();
					return;
				}
				this._615843867912986448972238254681997();
			}
			else
			{
				MessageBox.Show(Program.rm.GetString("f1ConnectionError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
			string text2 = Form1._5814324214581761742558779927612(Form1.hwid);
			if (Path.GetFileNameWithoutExtension(Application.ExecutablePath).Contains("maint"))
			{
				text2 = "2";
			}
			if (text2 != null)
			{
				if (text2 == "1")
				{
					this.TitleLabel.Text = Program.rm.GetString("f1NotNeedApprove");
					this.AltLabel.Text = Program.rm.GetString("f1Exiting");
					this.closeProgram.Start();
					return;
				}
				if (text2 == "2")
				{
					this.kalanOnay = Program.GetRemoteContent("http://localhost/pgiex/kalanCount.php?hwid=" + Form1.hwid, 3000).Substring(0, 1);
					this.TitleLabel.Text = Program.rm.GetString("f1NeedApprove").Replace("{0}", this.kalanOnay);
					this.AltLabel.Text = Program.rm.GetString("f1ApproveOpening");
					this.redirectToForm2.Start();
					return;
				}
				if (text2 == "3")
				{
					this.TitleLabel.Text = Program.rm.GetString("f1BannedUser");
					this.AltLabel.Text = Program.rm.GetString("f1Exiting");
					this.closeProgram.Start();
					return;
				}
				if (text2 == "5")
				{
					this.TitleLabel.Text = Program.rm.GetString("f1PremiumUser");
					this.AltLabel.Text = Program.rm.GetString("f1Exiting");
					this.closeProgram.Start();
					this.Refresh();
					return;
				}
				if (text2 == "6")
				{
					this.TitleLabel.Text = Program.rm.GetString("f1PremiumUser");
					this.AltLabel.Text = Program.rm.GetString("f1Exiting");
					this.closeProgram.Start();
					return;
				}
			}
			this.TitleLabel.Text = Program.rm.GetString("f1ConnectionError");
			this.AltLabel.Text = Program.rm.GetString("f1Exiting");
			this.closeProgram.Start();
		}

		private void closeProgram_Tick(object sender, EventArgs e)
		{
			if (this.dotdot.Text.Length <= 1)
			{
				this.redirectToForm2.Stop();
				Application.Exit();
				return;
			}
			this.dotdot.Text = this.dotdot.Text.Substring(1, this.dotdot.Text.Length - 1);
		}

		private void redirectToForm2_Tick(object sender, EventArgs e)
		{
			if (this.dotdot.Text.Length <= 1)
			{
				this.redirectToForm2.Stop();
				Form1.form2.Show();
				base.Hide();
				return;
			}
			this.dotdot.Text = this.dotdot.Text.Substring(1, this.dotdot.Text.Length - 1);
		}

		private void _72645668924764931256477(object sender, EventArgs e)
		{
			bool flag = false;
			bool flag2 = false;
			if (this.closeProgram.Enabled)
			{
				flag = true;
				this.closeProgram.Stop();
			}
			if (this.redirectToForm2.Enabled)
			{
				flag2 = true;
				this.redirectToForm2.Stop();
			}
			if (MessageBox.Show(Form1.hwid + Environment.NewLine + "Do you want to copy the hwid number?", "Hile Bol HWID", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				Clipboard.SetText(Form1.hwid);
				MessageBox.Show("HWID copied.", "Hile Bol HWID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (flag)
			{
				this.closeProgram.Start();
			}
			if (flag2)
			{
				this.redirectToForm2.Start();
			}
		}

		private void _549659219451(object sender, EventArgs e)
		{
			this.runGo.Stop();
			Form1.hwid = Form1._5913299243491();
			this.os_hereWeGo();
		}

		private void exitLabel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
