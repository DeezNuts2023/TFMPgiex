using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Approve.Properties;

namespace Approve
{
	public partial class Form2 : Form
	{
		public static string kalanOnaylanmasiGerekenSite = "?";
		public static double sayfadaBeklemeSuresi = 26.4 + (double)DateTime.Now.Hour;
		public static int sayfadaBeklemeSuresiF = 15;
		public static int reklamdaBeklemeSuresi = 10;
		private static string site_id;
		public static string site_domain;
		public static string site_keyword;
		private static string site_keyword_with_plus;
		private static string site_title;
		private static string site_home_title;
		private static string site_title_detect;
		private static string site_yapilacak_onay_turu;
		private string ActiveWindowsTitles = "";
		
		public Form2()
		{
			this.InitializeComponent();
		}

		private void _7575639453569785155993624336795()
		{
			Form2.sayfadaBeklemeSuresi = 71.953214 + (double)DateTime.Now.Hour;
			Form2.sayfadaBeklemeSuresiF = 60;
			this.Step5Text.Visible = false;
			this.Step5Image.Visible = false;
			this.Step6Text.Visible = false;
			this.Step6Image.Visible = false;
			this.PanelOnaylar.Size = new Size(this.PanelOnaylar.Width, 168);
			this.PanelAlt.Location = new Point(this.PanelAlt.Location.X, this.PanelOnaylar.Location.Y + this.PanelOnaylar.Height);
			this.PanelOnayBasarili.Location = this.PanelOnaylar.Location;
			this.PanelOnayFinish.Location = this.PanelOnaylar.Location;
			base.Height -= this.PanelAlt.Height;
			base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height);
		}

		private void _87172184287(string hwid)
		{
			string[] array = Program.GetRemoteContent("http://localhost/pgiex/sonsite.php?hwid=" + hwid, 10000).Split(new char[]
			{
				','
			});
			Form2.site_id = array[0];
			Form2.site_domain = array[1];
			Form2.site_keyword = array[2];
			Form2.site_title = array[3];
			Form2.site_home_title = array[4];
			Form2.site_title_detect = array[5];
			Form2.site_yapilacak_onay_turu = array[6];
			Form2.site_keyword_with_plus = Form2.site_keyword.Replace(" ", "+");
		}

		private string _1524416735861()
		{
			IntPtr zero = IntPtr.Zero;
			StringBuilder stringBuilder = new StringBuilder(256);
			if (Form2.GetWindowText(Form2.GetForegroundWindow(), stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
			return "";
		}

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();
		
		[DllImport("user32.dll")]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		private void _466834198884668499628(object sender, EventArgs e)
		{
			this.Text = Program.rm.GetString("f2Title");
			this.LoadingImage.Location = this.PanelOnaylar.Location;
			this.PanelOnayBasarili.Location = new Point(this.PanelOnaylar.Location.X, this.PanelOnayBasarili.Location.Y);
			this.PanelOnayFinish.Location = new Point(this.PanelOnaylar.Location.X, this.PanelOnayFinish.Location.Y);
			base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height);
			this.LanguagesCombobox.Text = Program.rm.GetString("f2ThisLang");
			this.load.Start();
		}

		private string _6466532217815398515455()
		{
			string text = "";
			foreach (Process process in Process.GetProcesses())
			{
				if (!string.IsNullOrEmpty(process.MainWindowTitle))
				{
					text = text + process.MainWindowTitle + Environment.NewLine;
				}
			}
			return text;
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void _15196523939467576776864(string hwid, string language)
		{
			try
			{
				if (!string.IsNullOrEmpty(language))
				{
					Program.GetRemoteContent("http://localhost/pgiex/language_git.php?hwid=" + hwid + "&dil=" + language, 10000);
				}
			}
			catch (Exception)
			{
			}
		}

		private void _11231817761(object sender, EventArgs e)
		{
			string a = this.LanguagesCombobox.SelectedItem.ToString();
			if (a == "Türkçe")
			{
				Settings.Default.language = "TR";
			}
			else if (a == "English")
			{
				Settings.Default.language = "EN";
			}
			else if (a == "Français")
			{
				Settings.Default.language = "FR";
			}
			else if (a == "Deutsch")
			{
				Settings.Default.language = "DE";
			}
			else if (a == "Español")
			{
				Settings.Default.language = "ES";
			}
			else if (a == "Português")
			{
				Settings.Default.language = "PT";
			}
			else if (a == "Brazil")
			{
				Settings.Default.language = "BR";
			}
			else if (a == "Român")
			{
				Settings.Default.language = "RO";
			}
			else if (a == "русский")
			{
				Settings.Default.language = "RU";
			}
			else if (a == "العربية")
			{
				Settings.Default.language = "AR";
			}
			else if (a == "български")
			{
				Settings.Default.language = "BG";
			}
			else if (a == "Polski")
			{
				Settings.Default.language = "PL";
			}
			else if (a == "Magyar")
			{
				Settings.Default.language = "HU";
			}
			else if (a == "Čeština")
			{
				Settings.Default.language = "CZ";
			}
			else
			{
				Settings.Default.language = "EN";
			}
			Settings.Default.Save();
			this._15196523939467576776864(Form1.hwid, Settings.Default.language);
			Program.languageToRM(0);
		}

		private bool _66662335385(string content, params string[] list)
		{
			for (int i = 0; i < list.Length; i++)
			{
				if (content.Contains(list[i]))
				{
					return true;
				}
			}
			return false;
		}

		private void _879251995499849692464221342858365(object sender, EventArgs e)
		{
			try
			{
				this.ActiveWindowsTitles = this._1524416735861();
				if (this.ActiveWindowsTitles.Contains(Form2.site_keyword) && this.ActiveWindowsTitles.Contains("Google"))
				{
					this.Step1Image.Image = Resources._checked;
					this.Step2Image.Image = Resources.now;
					this.step1.Stop();
					this.step2.Start();
				}
			}
			catch (Exception)
			{
			}
		}

		private void _3751923226638(object sender, EventArgs e)
		{
			try
			{
				this.ActiveWindowsTitles = this._1524416735861();
				if (this.ActiveWindowsTitles.Contains(Form2.site_title))
				{
					this.Step2Image.Image = Resources._checked;
					this.Step3Image.Image = Resources.now;
					this.step2.Stop();
					this.step3.Start();
				}
			}
			catch (Exception)
			{
			}
		}

		private void _37133769819246235556841(object sender, EventArgs e)
		{
			try
			{
				this.ActiveWindowsTitles = this._1524416735861();
				if (this.ActiveWindowsTitles.Contains(Form2.site_title) && !this.ActiveWindowsTitles.Contains(Form2.site_home_title) && !this.ActiveWindowsTitles.Contains(Form2.site_title_detect))
				{
					this.Step3Image.Image = Resources._checked;
					this.Step4Image.Image = Resources.now;
					this.step3.Stop();
					this.step4.Start();
				}
			}
			catch (Exception)
			{
			}
		}

		private void _2114723566562137869918(object sender, EventArgs e)
		{
			try
			{
				this.ActiveWindowsTitles = this._6466532217815398515455();
				if (Form2.site_yapilacak_onay_turu == "click")
				{
					if (!this.ActiveWindowsTitles.Contains(Form2.site_title_detect))
					{
						if (this.ActiveWindowsTitles.Contains(Form2.site_title) & !this.ActiveWindowsTitles.Contains(Form2.site_home_title))
						{
							Form2.sayfadaBeklemeSuresi -= 1.0;
							if (Form2.sayfadaBeklemeSuresiF > 1)
							{
								Form2.sayfadaBeklemeSuresiF--;
							}
							Program.languageToRM(0);
							if (Form2.sayfadaBeklemeSuresi <= (double)(12 + DateTime.Now.Hour))
							{
								this.Step4Image.Image = Resources._checked;
								this.Step5Image.Image = Resources.now;
								this.step5.Start();
								this.step4.Stop();
							}
						}
					}
					else
					{
						this.step4.Stop();
						MessageBox.Show(Program.rm.GetString("f2EarlyClick"), "Early Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Form2.sayfadaBeklemeSuresi = 26.3 + (double)DateTime.Now.Hour;
						Form2.sayfadaBeklemeSuresiF = 15;
						Program.languageToRM(0);
						this.step3.Start();
					}
				}
				else if (!this.ActiveWindowsTitles.Contains(Form2.site_home_title) && (this.ActiveWindowsTitles.Contains(Form2.site_title) & !this.ActiveWindowsTitles.Contains(Form2.site_home_title)))
				{
					Form2.sayfadaBeklemeSuresi -= 1.0;
					if (Form2.sayfadaBeklemeSuresiF > 0)
					{
						Form2.sayfadaBeklemeSuresiF--;
					}
					Program.languageToRM(0);
					if (Form2.sayfadaBeklemeSuresi <= (double)(12 + DateTime.Now.Hour))
					{
						this.Step4Image.Image = Resources._checked;
						this.Step5Image.Image = Resources.now;
						this.step4.Stop();
						this._31847186682755297689673();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void _917254351164975799485(object sender, EventArgs e)
		{
			try
			{
				this.ActiveWindowsTitles = this._1524416735861();
				if (this.ActiveWindowsTitles.Contains(Form2.site_title) && this.ActiveWindowsTitles.Contains(Form2.site_title_detect))
				{
					this.Step5Image.Image = Resources._checked;
					this.Step6Image.Image = Resources.now;
					this.step5.Stop();
					this.step6.Start();
				}
			}
			catch (Exception)
			{
			}
		}

		private void _49349546732(object sender, EventArgs e)
		{
			string[] list = new string[]
			{
				"Browser",
				"Chromium",
				"Google Chrome",
				"Brave",
				"UC Browser",
				"Avast Secure Browser",
				"Microsoft​ Edge",
				"Microsoft Edge",
				"Yandex Browser",
				"Internet Explorer",
				"Windows Internet Explorer",
				"Mozilla Firefox",
				"max5",
				"Opera",
				"Yandex.Browser",
				"CCleaner Browser",
				"Vivaldi"
			};
			try
			{
				this.ActiveWindowsTitles = this._6466532217815398515455();
				if (!this.ActiveWindowsTitles.Contains(Form2.site_title) && !this.ActiveWindowsTitles.Contains(Form2.site_title_detect) && this._66662335385(this.ActiveWindowsTitles, list))
				{
					Form2.reklamdaBeklemeSuresi--;
					Program.languageToRM(0);
					if (Form2.reklamdaBeklemeSuresi <= 0)
					{
						this.Step6Image.Image = Resources._checked;
						this.step6.Stop();
						this._31847186682755297689673();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void _31847186682755297689673()
		{
			Program.GetRemoteContent(string.Concat(new string[]
			{
				"http://localhost/pgiex/end.php?hwid=",
				Form1.hwid,
				"&onayprogram=",
				Form1.kayitOlunanProgram,
				"&onaysite=",
				Form2.site_id,
				"&onayturu=",
				Form2.site_yapilacak_onay_turu
			}), 10000);
			string a = Form1._5814324214581761742558779927612(Form1.hwid);
			Form2.kalanOnaylanmasiGerekenSite = Program.GetRemoteContent("http://localhost/pgiex/kalanCount.php?hwid=" + Form1.hwid, 3000);
			Program.languageToRM(0);
			if (a == "1" || a == "5" || a == "6")
			{
				this.PanelOnaylar.Visible = false;
				this.PanelOnayFinish.Visible = true;
				this.exiting.Start();
				return;
			}
			if (a == "2")
			{
				this.PanelOnaylar.Visible = false;
				this.PanelOnayBasarili.Visible = true;
				this.restart.Start();
				this.countdownGif.Image = Resources.countdown;
				return;
			}
			MessageBox.Show(Program.rm.GetString("f1ConnectionError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}

		private void exiting_Tick(object sender, EventArgs e)
		{
			if (this.noktanokta.Text.Length <= 1)
			{
				this.exiting.Stop();
				Application.Exit();
				return;
			}
			this.noktanokta.Text = this.noktanokta.Text.Substring(1, this.noktanokta.Text.Length - 1);
		}

		private void restart_Tick(object sender, EventArgs e)
		{
			this.restart.Stop();
			Application.Restart();
		}

		private void Step1Text_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://www.google.com/search?q=" + Form2.site_keyword_with_plus);
			}
			catch (Exception)
			{
				MessageBox.Show(Program.rm.GetString("f2DefaultBrowser"), "Default Browser Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void load_Tick(object sender, EventArgs e)
		{
			this.load.Stop();
			try
			{
				this._87172184287(Form1.hwid);
				if (Form2.site_yapilacak_onay_turu == "view")
				{
					this._7575639453569785155993624336795();
				}
				Program.languageToRM(2);
				this.LoadingImage.Visible = false;
				this.step1.Start();
			}
			catch (Exception ee)
			{
				MessageBox.Show(Program.rm.GetString("f1ConnectionError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
		}

		private void YoutubeText_Click(object sender, EventArgs e)
		{
			string fileName = "";
			try
			{
				fileName = Program.GetRemoteContent("https://raw.githubusercontent.com/hilebolonline/urls/master/approve-tutorial.txt", 10000);
			}
			catch (Exception)
			{
				MessageBox.Show(Program.rm.GetString("f1ConnectionError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			try
			{
				Process.Start(fileName);
			}
			catch (Exception)
			{
				MessageBox.Show(Program.rm.GetString("f2DefaultBrowser"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void buyPremiumText_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Program.rm.GetString("f2PremiumContent"), "Premium", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				string fileName = "";
				try
				{
					fileName = Program.GetRemoteContent("https://raw.githubusercontent.com/hilebolonline/urls/master/pgiex-discord.txt", 10000);
				}
				catch (Exception)
				{
					MessageBox.Show(Program.rm.GetString("f1ConnectionError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Program.rm.GetString("f2DefaultBrowser") + Environment.NewLine + "Go manuel: https://discord.io/pgiex", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		private void iCantSeeAdText_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://hilebol.space/i-cant-see-ad");
			}
			catch (Exception)
			{
				MessageBox.Show(Program.rm.GetString("f2DefaultBrowser") + Environment.NewLine + Environment.NewLine + "https://hilebol.space/i-cant-see-ad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}
}
