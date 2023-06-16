using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using linkapprove.Properties;
using Microsoft.CSharp.RuntimeBinder;

namespace linkapprove
{
	public partial class FirstForm : Form
	{
		public static SecondForm form2 = new SecondForm();
		private static string programName = "pLinkApprove";
		private static string sourceName = "pgiex";
		private static string currentVersion = "1";
		
		[CompilerGenerated]
		private static class Class_0
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, string>> var_2;
		}

		[CompilerGenerated]
		private static class Class_1
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Action<CallSite, WebClient, object, string>> var_2;
		}

		[CompilerGenerated]
		private static class Class_2
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, bool, object>> var_2;
			public static CallSite<Func<CallSite, object, bool>> var_3;
			public static CallSite<Func<CallSite, object, string, object>> var_4;
			public static CallSite<Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon>> var_5;
			public static CallSite<Func<CallSite, object, string, object>> var_6;
			public static CallSite<Func<CallSite, object, bool, object>> var_7;
			public static CallSite<Func<CallSite, object, bool>> var_8;
			public static CallSite<Func<CallSite, object, string, object>> var_9;
			public static CallSite<Action<CallSite, FirstForm, object>> var_10;
			public static CallSite<Func<CallSite, object, string, object>> var_20;
			public static CallSite<Func<CallSite, object, bool, object>> var_21;
			public static CallSite<Func<CallSite, object, bool>> var_22;
		}

		public FirstForm()
		{
			this.InitializeComponent();
		}

		public static string aaLamerNot()
		{
			return "Şşt olum ayıp di mi lan, hilebol abinizin kodlarını okumaya utanmıyonuz mu";
		}

		public static string getProgramName()
		{
			return FirstForm.programName;
		}

		public static string getSourceName()
		{
			return FirstForm.sourceName;
		}

		public static string getVersion()
		{
			return FirstForm.currentVersion;
		}

		public static bool internetConnectionIsExists()
		{
			bool result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("http://google.com/generate_204"))
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public static void openURL(string url)
		{
			try
			{
				Process.Start(url);
			}
			catch (Exception)
			{
				Program.form1.TopMost = false;
				MessageBox.Show(Language.getRMValue("msgErrorURL") + Language.getRMValue("msgSelectADefaultBrowser") + "\n \n URL: " + url, Language.getRMValue("msgError") + " URL", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		private static void jsonWorkingCheck()
		{
			try
			{
				new JavaScriptSerializer().Deserialize<object>("{ \"not\":\"Ayıp di mi lan, utanmıyonuz mu hilebol abinizin kodlarını okumaya.\", \"age\":30, \"car\":null }");
			}
			catch (Exception)
			{
				Program.form1.TopMost = false;
				MessageBox.Show(Language.getRMValue("msgErrorNET"));
				FirstForm.openURL("https://bolcorp.icu/url.php?tag=dotnet-4.5");
			}
		}

		private static bool versionIsLatest()
		{
			bool result;
			try
			{
				object arg = new JavaScriptSerializer().Deserialize<object>(Program.GetRemoteContent("https://bolcorp.icu/program.php?name=" + FirstForm.getProgramName(), 10000));
				if (FirstForm.Class_0.var_2 == null)
				{
					FirstForm.Class_0.var_2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(FirstForm)));
				}
				Func<CallSite, object, string> target = FirstForm.Class_0.var_2.Target;
				CallSite CurrentVar = FirstForm.Class_0.var_2;
				if (FirstForm.Class_0.var_1 == null)
				{
					FirstForm.Class_0.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				string text = target(CurrentVar, FirstForm.Class_0.var_1.Target(FirstForm.Class_0.var_1, arg, "lastVersion"));
				if (text != "-1" && !string.IsNullOrEmpty(text))
				{
					if (text == FirstForm.getVersion())
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else
				{
					MessageBox.Show(Language.getRMValue("msgErrorCheckingVersion") + "\n \n" + Language.getRMValue("msgProgramExits"), "Hata: Sürüm kontrolü", MessageBoxButtons.OK, MessageBoxIcon.None);
					Application.Exit();
					result = false;
				}
			}
			catch (Exception)
			{
				Program.form1.TopMost = false;
				MessageBox.Show(Language.getRMValue("msgErrorCheckingVersion") + "\n \n" + Language.getRMValue("msgProgramExits"), "Hata: Sürüm kontrolü", MessageBoxButtons.OK, MessageBoxIcon.None);
				Application.Exit();
				result = false;
			}
			return result;
		}

		private void downloadUpdater()
		{
			try
			{
				WebClient webClient = new WebClient();
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				object arg = new JavaScriptSerializer().Deserialize<object>(Program.GetRemoteContent("https://bolcorp.icu/program.php?name=" + FirstForm.getProgramName(), 10000));
				if (FirstForm.Class_1.var_2 == null)
				{
					FirstForm.Class_1.var_2 = CallSite<Action<CallSite, WebClient, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DownloadFile", null, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Action<CallSite, WebClient, object, string> target = FirstForm.Class_1.var_2.Target;
				CallSite CurrentVar = FirstForm.Class_1.var_2;
				WebClient arg2 = webClient;
				if (FirstForm.Class_1.var_1 == null)
				{
					FirstForm.Class_1.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				target(CurrentVar, arg2, FirstForm.Class_1.var_1.Target(FirstForm.Class_1.var_1, arg, "updaterURL"), Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "LinkApproveUpdater.exe"));
				this.openUpdaterTimer.Start();
			}
			catch (Exception)
			{
				base.TopMost = false;
				MessageBox.Show(string.Concat(new string[]
				{
					Language.getRMValue("msgUpdaterCantDownloaded"),
					Language.getRMValue("msgDisableAntivirus"),
					Language.getRMValue("msgProgramExits"),
					Environment.NewLine,
					Environment.NewLine,
					Language.getRMValue("msgProgramExits")
				}), Language.getRMValue("msgError") + " UpdaterDown", MessageBoxButtons.OK, MessageBoxIcon.None);
				Application.Exit();
			}
		}

		private void openUpdaterTimer_Tick(object sender, EventArgs e)
		{
			this.openUpdaterTimer.Stop();
			this.openUpdater();
			Application.Exit();
		}

		private void openUpdater()
		{
			try
			{
				Process.Start("LinkApproveUpdater.exe");
			}
			catch (Exception)
			{
				base.TopMost = false;
				MessageBox.Show(string.Concat(new string[]
				{
					Language.getRMValue("msgUpdaterCantRun"),
					Language.getRMValue("msgDisableAntivirus"),
					Language.getRMValue("msgProgramExits"),
					Environment.NewLine,
					Environment.NewLine,
					Language.getRMValue("msgProgramExits")
				}), Language.getRMValue("msgError") + " UpdaterRun", MessageBoxButtons.OK, MessageBoxIcon.None);
				Application.Exit();
			}
		}
		public void deleteUpdater()
		{
			try
			{
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "LinkApproveUpdater.exe")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "LinkApproveUpdater.exe"));
				}
			}
			catch (Exception)
			{
			}
		}

		private void versionInfoProcess()
		{
			try
			{
				object arg = new JavaScriptSerializer().Deserialize<object>(Program.GetRemoteContent("https://bolcorp.icu/program.php?name=" + FirstForm.getProgramName() + "&ver=" + FirstForm.currentVersion, 5000)); //"v" + FirstForm.currentVersion;
				if (FirstForm.Class_2.var_3 == null)
				{
					FirstForm.Class_2.var_3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = FirstForm.Class_2.var_3.Target;
				CallSite CurrentVar = FirstForm.Class_2.var_3;
				if (FirstForm.Class_2.var_2 == null)
				{
					FirstForm.Class_2.var_2 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target2 = FirstForm.Class_2.var_2.Target;
				CallSite var_3 = FirstForm.Class_2.var_2;
				if (FirstForm.Class_2.var_1 == null)
				{
					FirstForm.Class_2.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target(CurrentVar, target2(var_3, FirstForm.Class_2.var_1.Target(FirstForm.Class_2.var_1, arg, "showMessage"), true)))
				{
					base.TopMost = false;
					if (FirstForm.Class_2.var_5 == null)
					{
						FirstForm.Class_2.var_5 = CallSite<Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Show", null, typeof(FirstForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Action<CallSite, Type, object, string, MessageBoxButtons, MessageBoxIcon> target3 = FirstForm.Class_2.var_5.Target;
					CallSite var_4 = FirstForm.Class_2.var_5;
					Type typeFromHandle = typeof(MessageBox);
					if (FirstForm.Class_2.var_4 == null)
					{
						FirstForm.Class_2.var_4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					target3(var_4, typeFromHandle, FirstForm.Class_2.var_4.Target(FirstForm.Class_2.var_4, arg, "message"), "HILEBOL", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				if (FirstForm.Class_2.var_8 == null)
				{
					FirstForm.Class_2.var_8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target4 = FirstForm.Class_2.var_8.Target;
				CallSite var_5 = FirstForm.Class_2.var_8;
				if (FirstForm.Class_2.var_7 == null)
				{
					FirstForm.Class_2.var_7 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target5 = FirstForm.Class_2.var_7.Target;
				CallSite var_6 = FirstForm.Class_2.var_7;
				if (FirstForm.Class_2.var_6 == null)
				{
					FirstForm.Class_2.var_6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target4(var_5, target5(var_6, FirstForm.Class_2.var_6.Target(FirstForm.Class_2.var_6, arg, "openURL"), true)))
				{
					if (FirstForm.Class_2.var_10 == null)
					{
						FirstForm.Class_2.var_10 = CallSite<Action<CallSite, FirstForm, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "openURL", null, typeof(FirstForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, FirstForm, object> target6 = FirstForm.Class_2.var_10.Target;
					CallSite var_7 = FirstForm.Class_2.var_10;
					if (FirstForm.Class_2.var_9 == null)
					{
						FirstForm.Class_2.var_9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					target6(var_7, this, FirstForm.Class_2.var_9.Target(FirstForm.Class_2.var_9, arg, "targetURL"));
				}
				if (FirstForm.Class_2.var_22 == null)
				{
					FirstForm.Class_2.var_22 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target7 = FirstForm.Class_2.var_22.Target;
				CallSite var_8 = FirstForm.Class_2.var_22;
				if (FirstForm.Class_2.var_21 == null)
				{
					FirstForm.Class_2.var_21 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target8 = FirstForm.Class_2.var_21.Target;
				CallSite var_9 = FirstForm.Class_2.var_21;
				if (FirstForm.Class_2.var_20 == null)
				{
					FirstForm.Class_2.var_20 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(FirstForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target7(var_8, target8(var_9, FirstForm.Class_2.var_20.Target(FirstForm.Class_2.var_20, arg, "activeStatus"), false)))
				{
					Application.Exit();
				}
			}
			catch (Exception)
			{
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Language.languageToRM();
			Language.setStringFromRM();
			this.mevcutSurumLabel.Text = "ver: " + FirstForm.currentVersion;
			this.flow.Start();
		}

		private void exitLabel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void redirectToForm3_Tick(object sender, EventArgs e)
		{
			if (this.dotdot.Text.Length <= 1)
			{
				this.redirectToForm2.Stop();
				FirstForm.form2.Show();
				base.Hide();
				return;
			}
			this.dotdot.Text = this.dotdot.Text.Substring(1, this.dotdot.Text.Length - 1);
		}

		private void flow_Tick(object sender, EventArgs e)
		{
			this.flow.Stop();
			FirstForm.jsonWorkingCheck();
			if (!FirstForm.internetConnectionIsExists())
			{
				base.TopMost = false;
				MessageBox.Show(Language.getRMValue("msgErrorConnect") + "\n \n" + Language.getRMValue("msgProgramExits"), Language.getRMValue("msgError") + "InternetConnection", MessageBoxButtons.OK, MessageBoxIcon.None);
				Application.Exit();
				return;
			}
			this.AltLabel.Text = Language.getRMValue("f1CheckingCurrentVersion");
			if (!FirstForm.versionIsLatest())
			{
				this.downloadUpdater();
				return;
			}
			this.deleteUpdater();
			this.versionInfoProcess();
			this.redirectToForm2.Start();
		}
	}
}
