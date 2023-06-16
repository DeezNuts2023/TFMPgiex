using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Approve.Properties;

namespace Approve
{
	internal static class Program
	{
		public static ResourceManager rm = new ResourceManager("Approve.Languages.lang_en", Assembly.GetExecutingAssembly());
		
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
		public static string GetRemoteContent(string url, int reqtimeout)
		{
			string text = "";
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "GET";
			webRequest.Timeout = reqtimeout;
			try
			{
				StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
				text = streamReader.ReadToEnd();
				streamReader.Close();
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.Timeout)
				{
					text = "TIMEOUT";
				}
				else
				{
					text = "TIMEOUT";
				}
			}
			return text.Trim();
		}
		public static void languageToRM(int formNo = 0)
		{
			string language = Settings.Default.language;
			if (language == "EN" || language == "CO")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_en", Assembly.GetExecutingAssembly());
			}
			else if (language == "TR")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_tr", Assembly.GetExecutingAssembly());
			}
			else if (language == "FR")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_fr", Assembly.GetExecutingAssembly());
			}
			else if (language == "DE")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_de", Assembly.GetExecutingAssembly());
			}
			else if (language == "ES")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_es", Assembly.GetExecutingAssembly());
			}
			else if (language == "PT" || language == "BR")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_br", Assembly.GetExecutingAssembly());
			}
			else if (language == "RO")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_ro", Assembly.GetExecutingAssembly());
			}
			else if (language == "RU")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_ru", Assembly.GetExecutingAssembly());
			}
			else if (language == "AR" || language == "EG")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_ar", Assembly.GetExecutingAssembly());
			}
			else if (language == "BG")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_bg", Assembly.GetExecutingAssembly());
			}
			else if (language == "PL")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_pl", Assembly.GetExecutingAssembly());
			}
			else if (language == "HU")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_hu", Assembly.GetExecutingAssembly());
			}
			else if (language == "CZ")
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_cz", Assembly.GetExecutingAssembly());
			}
			else
			{
				Program.rm = new ResourceManager("Approve.Languages.lang_en", Assembly.GetExecutingAssembly());
			}
			if (formNo != 0)
			{
			}
			if (formNo == 0 || formNo == 2)
			{
				Form1.form2.Step1Text.Text = Program.rm.GetString("f2Step1").Replace("{0}", Form2.site_keyword);
				Form1.form2.Step1AltText.Text = Program.rm.GetString("f2Step1Alt");
				Form1.form2.Step2Text.Text = Program.rm.GetString("f2Step2").Replace("{0}", Form2.site_domain);
				Form1.form2.Step3Text.Text = Program.rm.GetString("f2Step3");
				Form1.form2.Step4Text.Text = Program.rm.GetString("f2Step4").Replace("{0}", Form2.sayfadaBeklemeSuresiF.ToString());
				Form1.form2.Step5Text.Text = Program.rm.GetString("f2Step5");
				Form1.form2.Step6Text.Text = Program.rm.GetString("f2Step6").Replace("{0}", Form2.reklamdaBeklemeSuresi.ToString());
				Form1.form2.YoutubeText.Text = Program.rm.GetString("f2Youtube");
				Form1.form2.buyPremiumText.Text = Program.rm.GetString("f2Premium");
				Form1.form2.iCantSeeAdText.Text = Program.rm.GetString("f2ICantSeeAd");
				if (string.IsNullOrEmpty(Program.rm.GetString("f2ICantSeeAd")))
				{
					Form1.form2.iCantSeeAdText.Text = "I can't see ad!";
				}
				Form1.form2.onayBasarili.Text = Program.rm.GetString("f2ApproveSuccessful");
				Form1.form2.yapilmasiGerekenXonayKaldi.Text = Program.rm.GetString("f2RemainingApprove").Replace("{0}", Form2.kalanOnaylanmasiGerekenSite);
				Form1.form2.programYenidenBaslatiliyor.Text = Program.rm.GetString("f2Restarting");
				Form1.form2.tumOnaylariTamamladin.Text = Program.rm.GetString("f2AllApproveCompleted");
				Form1.form2.programdanCikiliyor.Text = Program.rm.GetString("f1Exiting");
			}
		}
	}
}
