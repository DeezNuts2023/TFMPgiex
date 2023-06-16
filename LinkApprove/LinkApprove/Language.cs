using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Microsoft.Win32;

namespace linkapprove
{
	internal class Language
	{
		public static ResourceManager rm = new ResourceManager("linkapprove.Languages.lang_EN", Assembly.GetExecutingAssembly());
		public static ResourceManager rmKurtarici = new ResourceManager("linkapprove.Languages.lang_EN", Assembly.GetExecutingAssembly());
		public static string eksikCeviriler = "";
		
		public static string getLanguage()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bolcorp");
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bolcorp", true);
			if (registryKey.GetValue("language") == null)
			{
				registryKey.SetValue("language", CultureInfo.CurrentCulture.ToString().ToUpper().Substring(0, 2));
			}
			return registryKey.GetValue("language").ToString();
		}
		public static void setLanguage(string languageCode)
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bolcorp");
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bolcorp", true).SetValue("language", languageCode);
			Language.languageToRM();
			Language.setStringFromRM();
		}
		public static void languageToRM()
		{
			string language = Language.getLanguage();
			uint num = PrivateImplementationDetails.ComputeStringHash(language);
			if (num <= 620754425U)
			{
				if (num <= 433934950U)
				{
					if (num != 432802117U)
					{
						if (num != 433934950U)
						{
							return;
						}
						if (!(language == "BG"))
						{
							return;
						}
						Language.rm = new ResourceManager("linkapprove.Languages.lang_BG", Assembly.GetExecutingAssembly());
						return;
					}
					else
					{
						if (!(language == "EG"))
						{
							return;
						}
						Language.rm = new ResourceManager("linkapprove.Languages.lang_AR", Assembly.GetExecutingAssembly());
						return;
					}
				}
				else if (num != 550245450U)
				{
					if (num != 620754425U)
					{
						return;
					}
					if (!(language == "PL"))
					{
						return;
					}
					Language.rm = new ResourceManager("linkapprove.Languages.lang_PL", Assembly.GetExecutingAssembly());
					return;
				}
				else
				{
					if (!(language == "EN"))
					{
						return;
					}
					Language.rm = new ResourceManager("linkapprove.Languages.lang_EN", Assembly.GetExecutingAssembly());
					return;
				}
			}
			else if (num <= 1023417281U)
			{
				if (num != 653618115U)
				{
					if (num != 1023417281U)
					{
						return;
					}
					if (!(language == "PT"))
					{
						return;
					}
					Language.rm = new ResourceManager("linkapprove.Languages.lang_BR", Assembly.GetExecutingAssembly());
					return;
				}
				else
				{
					if (!(language == "TR"))
					{
						return;
					}
					Language.rm = new ResourceManager("linkapprove.Languages.lang_TR", Assembly.GetExecutingAssembly());
					return;
				}
			}
			else if (num != 1745149088U)
			{
				if (num != 1993561969U)
				{
					if (num != 2181367182U)
					{
						return;
					}
					if (!(language == "RO"))
					{
						return;
					}
					Language.rm = new ResourceManager("linkapprove.Languages.lang_RO", Assembly.GetExecutingAssembly());
					return;
				}
				else
				{
					if (!(language == "FR"))
					{
						return;
					}
					Language.rm = new ResourceManager("linkapprove.Languages.lang_FR", Assembly.GetExecutingAssembly());
					return;
				}
			}
			else
			{
				if (!(language == "RU"))
				{
					return;
				}
				Language.rm = new ResourceManager("linkapprove.Languages.lang_RU", Assembly.GetExecutingAssembly());
				return;
			}
		}
		public static string getRMValue(string stringName)
		{
			if (Language.rm.GetString(stringName) == null || Language.rm.GetString(stringName).Length <= 0)
			{
				Language.rmKurtarici.GetString(stringName);
				Language.eksikCeviriler = Language.eksikCeviriler + stringName + "\n";
			}
			return Language.rm.GetString(stringName);
		}
		public static void setStringFromRM()
		{
			Language.eksikCeviriler = "";
			Program.form1.AltLabel.Text = Language.getRMValue("f1CheckingInternet");
			Language.getRMValue("f1CheckingCurrentVersion");
			FirstForm.form2.son24SaatLabel.Text = Language.getRMValue("f2Last24Hours").Replace("{0}", Program.GetRemoteContent("https://bolcorp.icu/last24h.php?source=" + FirstForm.getSourceName(), 2000));
			FirstForm.form2.onayPeriyoduLabel.Text = Language.getRMValue("f2PassLinksForApproval") + Environment.NewLine + Language.getRMValue("f2ApprovalPeriod");
			FirstForm.form2.linkOnayiNasilYapilirButton.Text = Language.getRMValue("f2HowToDone");
			FirstForm.form2.ustteTutButton.Text = Language.getRMValue("f2KeepOnTop");
			FirstForm.form2.tebriklerLabel.Text = Language.getRMValue("f2Congratulations");
			FirstForm.form2.licenseCodeEnterLabel.Text = Language.getRMValue("f2UseLicenseCode");
			FirstForm.form2.premiumInfoLabel.Text = Language.getRMValue("f2PremiumInfo");
			FirstForm.form2.premiumRemainingTime.Text = Language.getRMValue("f2TimeRemaning");
			FirstForm.form2.buyLicenseButton.Text = Language.getRMValue("f2BuyLicense");
			FirstForm.form2.copyHBIDButton.Text = Language.getRMValue("f2CopyHBID");
			FirstForm.form2.languageContentLabel.Text = Language.getRMValue("f2LanguageName");
			Language.getRMValue("f2HBIDCopied");
			Language.getRMValue("msgErrorURL");
			Language.getRMValue("msgErrorNET");
			Language.getRMValue("msgErrorCheckingVersion");
			Language.getRMValue("msgProgramExits");
			Language.getRMValue("msgError");
			Language.getRMValue("msgVersionControl");
			Language.getRMValue("msgUpdaterCantDownloaded");
			Language.getRMValue("msgDisableAntivirus");
			Language.getRMValue("msgUpdaterCantRun");
			Language.getRMValue("msgErrorConnect");
			Language.getRMValue("msgLinkCantOpened");
			Language.getRMValue("msgSelectADefaultBrowser");
			Language.getRMValue("msgChristNo");
			Language.getRMValue("msgContactUsIfProblem");
			Language.getRMValue("msgPleaseTryAgain");
		}
	}
}
