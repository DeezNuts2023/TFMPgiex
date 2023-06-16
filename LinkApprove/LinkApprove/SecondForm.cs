using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using linkapprove.Properties;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;

namespace linkapprove
{
	public partial class SecondForm : Form
	{
		// Nested Types
		[CompilerGenerated]
		private static class class_3
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, string, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, string, string, object, object>> var_4;
			public static CallSite<Func<CallSite, object, string, object, object>> var_5;
			public static CallSite<Func<CallSite, object, string, object, object>> var_6;
			public static CallSite<Func<CallSite, object, string>> var_7;
		}

		[CompilerGenerated]
		private static class class_4
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, bool, object>> var_4;
			public static CallSite<Func<CallSite, object, bool>> var_5;
		}

		[CompilerGenerated]
		private static class class_5
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, bool, object>> var_4;
			public static CallSite<Func<CallSite, object, bool>> var_5;
		}

		[CompilerGenerated]
		private static class class_6
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_7
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, object>> var_2;
			public static CallSite<Func<CallSite, string, string, object, object>> var_3;
			public static CallSite<Func<CallSite, object, string, object>> var_4;
			public static CallSite<Func<CallSite, object, string, object>> var_5;
			public static CallSite<Func<CallSite, object, string>> var_6;
		}

		[CompilerGenerated]
		private static class class_33
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_34
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_35
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_36
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_37
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_38
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_39
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_40
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_41
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_42
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_43
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_44
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, int, object>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
			public static CallSite<Func<CallSite, object, string>> var_4;
		}

		[CompilerGenerated]
		private static class class_50
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, object>> var_2;
			public static CallSite<Func<CallSite, string, string, object, object>> var_3;
			public static CallSite<Func<CallSite, object, string, object>> var_4;
			public static CallSite<Func<CallSite, object, string, object>> var_5;
			public static CallSite<Func<CallSite, object, string>> var_6;
		}

		[CompilerGenerated]
		private static class class_65
		{
			// Fields
			public static CallSite<Func<CallSite, object, string, object>> var_1;
			public static CallSite<Func<CallSite, object, string>> var_2;
			public static CallSite<Func<CallSite, object, string, object>> var_3;
		}

		public SecondForm()
		{
			this.InitializeComponent();
		}
		public static bool IsHBID(string value)
		{
			Guid guid;
			return Guid.TryParse(value, out guid);
		}
		public static string getHBID()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bolcorp");
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bolcorp", true);
			if (registryKey.GetValue("hbid") == null || !SecondForm.IsHBID(registryKey.GetValue("hbid").ToString()))
			{
				registryKey.SetValue("hbid", Guid.NewGuid().ToString());
			}
			return registryKey.GetValue("hbid").ToString();
		}
		private void setTitle()
		{
			this.Text = "BOL LINK APPROVE v" + FirstForm.getVersion();
		}
		private void fixFormSize()
		{
			base.Size = new Size(465, this.altPanel.Location.Y + this.altPanel.Height + 65);
		}
		private void hideAllPanels()
		{
			this.linkApprovePanel.Visible = false;
			this.licensePanel.Visible = false;
			this.linkApproveYoPanel.Visible = false;
			this.languagePanel.Visible = false;
		}
		private void fixFormForApprove()
		{
			this.hideAllPanels();
			Panel panel = this.linkApprovePanel;
			panel.Visible = true;
			panel.Location = this.ImageLoading.Location;
			this.altPanel.Location = new Point(panel.Location.X, panel.Location.Y + panel.Height + 24);
			this.fixFormSize();
		}
		private void fixFormForLicense()
		{
			this.hideAllPanels();
			Panel panel = this.licensePanel;
			panel.Visible = true;
			panel.Location = this.ImageLoading.Location;
			this.altPanel.Location = new Point(panel.Location.X, panel.Location.Y + panel.Height + 24);
			this.fixFormSize();
		}
		private void fixFormForClaps()
		{
			this.hideAllPanels();
			Panel panel = this.linkApproveYoPanel;
			panel.Visible = true;
			panel.Location = this.ImageLoading.Location;
			this.altPanel.Location = new Point(panel.Location.X, panel.Location.Y + panel.Height + 24);
			this.fixFormSize();
		}
		private void fixFormForLanguage()
		{
			this.hideAllPanels();
			Panel panel = this.languagePanel;
			panel.Visible = true;
			panel.Location = this.ImageLoading.Location;
			this.altPanel.Location = new Point(panel.Location.X, panel.Location.Y + panel.Height + 24);
			this.fixFormSize();
		}
		private void setPreRemainingTime()
		{
			try
			{
				object arg = new JavaScriptSerializer().Deserialize<object>(Program.GetRemoteContent("https://bolcorp.icu/premium.php?hbid=" + SecondForm.getHBID(), 10000));
				Control control = this.premiumRemainingTime;
				if (SecondForm.class_3.var_7 == null)
				{
					SecondForm.class_3.var_7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
				}
				Func<CallSite, object, string> target = SecondForm.class_3.var_7.Target;
				CallSite CurrentVar = SecondForm.class_3.var_7;
				if (SecondForm.class_3.var_6 == null)
				{
					SecondForm.class_3.var_6 = CallSite<Func<CallSite, object, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Replace", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, string, object, object> target2 = SecondForm.class_3.var_6.Target;
				CallSite var_3 = SecondForm.class_3.var_6;
				if (SecondForm.class_3.var_5 == null)
				{
					SecondForm.class_3.var_5 = CallSite<Func<CallSite, object, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Replace", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, string, object, object> target3 = SecondForm.class_3.var_5.Target;
				CallSite var_4 = SecondForm.class_3.var_5;
				if (SecondForm.class_3.var_4 == null)
				{
					SecondForm.class_3.var_4 = CallSite<Func<CallSite, string, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Replace", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, string, object, object> target4 = SecondForm.class_3.var_4.Target;
				CallSite var_5 = SecondForm.class_3.var_4;
				string rmvalue = Language.getRMValue("f2TimeRemaning");
				string arg2 = "{0}";
				if (SecondForm.class_3.var_3 == null)
				{
					SecondForm.class_3.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object arg3 = target4(var_5, rmvalue, arg2, SecondForm.class_3.var_3.Target(SecondForm.class_3.var_3, arg, "days"));
				string arg4 = "{1}";
				if (SecondForm.class_3.var_2 == null)
				{
					SecondForm.class_3.var_2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object arg5 = target3(var_4, arg3, arg4, SecondForm.class_3.var_2.Target(SecondForm.class_3.var_2, arg, "hours"));
				string arg6 = "{2}";
				if (SecondForm.class_3.var_1 == null)
				{
					SecondForm.class_3.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				control.Text = target(CurrentVar, target2(var_3, arg5, arg6, SecondForm.class_3.var_1.Target(SecondForm.class_3.var_1, arg, "mins")));
			}
			catch (Exception)
			{
				this.premiumRemainingTime.Text = Language.getRMValue("msgSomethingWentWrong") + " (o,o)";
			}
		}
		private void Form3_Load(object sender, EventArgs e)
		{
			this.setTitle();
			this.flow.Start();
		}
		private bool linkOnayiGerekliMi(string log = "yesLog")
		{
			string remoteContent;
			if (log == "noLog")
			{
				remoteContent = Program.GetRemoteContent(string.Concat(new string[]
				{
					"https://bolcorp.icu/check.php?hbid=",
					SecondForm.getHBID(),
					"&source=",
					FirstForm.getSourceName(),
					"&log=no"
				}), 5000);
			}
			else
			{
				remoteContent = Program.GetRemoteContent("https://bolcorp.icu/check.php?hbid=" + SecondForm.getHBID() + "&source=" + FirstForm.getSourceName(), 5000);
			}
			return !(remoteContent == "1");
		}
		private void setJsonLinks(ref dynamic jLinks)
		{
			try
			{
				jLinks = new JavaScriptSerializer().Deserialize<object>(Program.GetRemoteContent("https://bolcorp.icu/links.php?source=" + FirstForm.getSourceName(), 10000));
			}
			catch (Exception)
			{
				base.TopMost = false;
				MessageBox.Show(string.Concat(new string[]
				{
					Language.getRMValue("msgErrorJson"),
					" ",
					Language.getRMValue("msgCheckInternet"),
					"\n \n",
					Language.getRMValue("msgProgramExits")
				}), Language.getRMValue("msgError") + " setJson", MessageBoxButtons.OK, MessageBoxIcon.None);
				Application.Exit();
			}
		}
		private void setFormForApprove()
		{
			base.Size = new Size(455, 580);
			this.linkApprovePanel.Visible = true;
		}
		private void setFormForApproveFinish()
		{
			base.Size = new Size(455, 510);
			this.altPanel.Location = new Point(45, 356);
			this.linkApprovePanel.Visible = false;
		}
		private void setLinkActives()
		{
			for (int i = 0; i < 12; i++)
			{
				Control[] array = base.Controls.Find("linkLabel" + (i + 1).ToString(), true);
				Control[] array2 = base.Controls.Find("linkIcon" + (i + 1).ToString(), true);
				if (SecondForm.class_4.var_5 == null)
				{
					SecondForm.class_4.var_5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = SecondForm.class_4.var_5.Target;
				CallSite CurrentVar = SecondForm.class_4.var_5;
				if (SecondForm.class_4.var_4 == null)
				{
					SecondForm.class_4.var_4 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target2 = SecondForm.class_4.var_4.Target;
				CallSite var_3 = SecondForm.class_4.var_4;
				if (SecondForm.class_4.var_3 == null)
				{
					SecondForm.class_4.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target3 = SecondForm.class_4.var_3.Target;
				CallSite var_4 = SecondForm.class_4.var_3;
				if (SecondForm.class_4.var_2 == null)
				{
					SecondForm.class_4.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target4 = SecondForm.class_4.var_2.Target;
				CallSite var_5 = SecondForm.class_4.var_2;
				if (SecondForm.class_4.var_1 == null)
				{
					SecondForm.class_4.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target(CurrentVar, target2(var_3, target3(var_4, target4(var_5, SecondForm.class_4.var_1.Target(SecondForm.class_4.var_1, this.jLinks, "links"), i), "active"), false)))
				{
					((Label)array[0]).Visible = false;
					((PictureBox)array2[0]).Visible = false;
				}
				else
				{
					((Label)array[0]).Visible = true;
					((PictureBox)array2[0]).Visible = true;
				}
			}
		}
		private void setLinkDones()
		{
			for (int i = 0; i < 12; i++)
			{
				PictureBox pictureBox = (PictureBox)base.Controls.Find("linkIcon" + (i + 1).ToString(), true)[0];
				if (SecondForm.class_5.var_5 == null)
				{
					SecondForm.class_5.var_5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = SecondForm.class_5.var_5.Target;
				CallSite CurrentVar = SecondForm.class_5.var_5;
				if (SecondForm.class_5.var_4 == null)
				{
					SecondForm.class_5.var_4 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, bool, object> target2 = SecondForm.class_5.var_4.Target;
				CallSite var_3 = SecondForm.class_5.var_4;
				if (SecondForm.class_5.var_3 == null)
				{
					SecondForm.class_5.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target3 = SecondForm.class_5.var_3.Target;
				CallSite var_4 = SecondForm.class_5.var_3;
				if (SecondForm.class_5.var_2 == null)
				{
					SecondForm.class_5.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target4 = SecondForm.class_5.var_2.Target;
				CallSite var_5 = SecondForm.class_5.var_2;
				if (SecondForm.class_5.var_1 == null)
				{
					SecondForm.class_5.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target(CurrentVar, target2(var_3, target3(var_4, target4(var_5, SecondForm.class_5.var_1.Target(SecondForm.class_5.var_1, this.jLinks, "links"), i), "done"), true)))
				{
					pictureBox.Image = Resources.link_done;
					pictureBox.Cursor = Cursors.Default;
					this.linkStatus[i] = 3;
				}
				else
				{
					if (this.linkStatus[i] == 3)
					{
						this.linkStatus[i] = 1;
						pictureBox.Image = Resources.link_open;
					}
					else if (this.linkStatus[i] == 2)
					{
						pictureBox.Image = Resources.link_waiting;
					}
					pictureBox.Cursor = Cursors.Hand;
				}
			}
		}
		private void setLinkNames()
		{
			for (int i = 0; i < 12; i++)
			{
				Control control = (Label)base.Controls.Find("linkLabel" + (i + 1).ToString(), true)[0];
				if (SecondForm.class_6.var_4 == null)
				{
					SecondForm.class_6.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
				}
				Func<CallSite, object, string> target = SecondForm.class_6.var_4.Target;
				CallSite CurrentVar = SecondForm.class_6.var_4;
				if (SecondForm.class_6.var_3 == null)
				{
					SecondForm.class_6.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = SecondForm.class_6.var_3.Target;
				CallSite var_3 = SecondForm.class_6.var_3;
				if (SecondForm.class_6.var_2 == null)
				{
					SecondForm.class_6.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = SecondForm.class_6.var_2.Target;
				CallSite var_4 = SecondForm.class_6.var_2;
				if (SecondForm.class_6.var_1 == null)
				{
					SecondForm.class_6.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				control.Text = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_6.var_1.Target(SecondForm.class_6.var_1, this.jLinks, "links"), i), "name"));
			}
		}
		private void ApproveTimer_Tick(object sender, EventArgs e)
		{
			if (!FirstForm.internetConnectionIsExists())
			{
				this.approveTimer.Stop();
				base.TopMost = false;
				MessageBox.Show(Language.getRMValue("msgErrorConnect") + "\n \n" + Language.getRMValue("msgProgramExits"), Language.getRMValue("msgError") + "InternetConnection", MessageBoxButtons.OK, MessageBoxIcon.None);
				Application.Exit();
				Application.Exit();
				return;
			}
			if (this.linkOnayiGerekliMi("noLog"))
			{
				this.setJsonLinks(ref this.jLinks);
				Control control = this.onayPeriyoduLabel;
				if (SecondForm.class_7.var_6 == null)
				{
					SecondForm.class_7.var_6 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
				}
				Func<CallSite, object, string> target = SecondForm.class_7.var_6.Target;
				CallSite CurrentVar = SecondForm.class_7.var_6;
				if (SecondForm.class_7.var_5 == null)
				{
					SecondForm.class_7.var_5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = SecondForm.class_7.var_5.Target;
				CallSite var_3 = SecondForm.class_7.var_5;
				if (SecondForm.class_7.var_4 == null)
				{
					SecondForm.class_7.var_4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target3 = SecondForm.class_7.var_4.Target;
				CallSite var_4 = SecondForm.class_7.var_4;
				if (SecondForm.class_7.var_3 == null)
				{
					SecondForm.class_7.var_3 = CallSite<Func<CallSite, string, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Replace", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, string, object, object> target4 = SecondForm.class_7.var_3.Target;
				CallSite var_5 = SecondForm.class_7.var_3;
				string rmvalue = Language.getRMValue("f2PassLinksForApproval");
				string arg = "{0}";
				if (SecondForm.class_7.var_2 == null)
				{
					SecondForm.class_7.var_2 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target5 = SecondForm.class_7.var_2.Target;
				CallSite var_6 = SecondForm.class_7.var_2;
				if (SecondForm.class_7.var_1 == null)
				{
					SecondForm.class_7.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				control.Text = target(CurrentVar, target2(var_3, target3(var_4, target4(var_5, rmvalue, arg, target5(var_6, SecondForm.class_7.var_1.Target(SecondForm.class_7.var_1, this.jLinks, "linkCountForDone"))), "\n"), Language.getRMValue("f2ApprovalPeriod")));
				this.setLinkActives();
				this.setLinkDones();
				this.setLinkNames();
				this.changeLinkIcons();
				return;
			}
			this.approveTimer.Stop();
			this.fixFormForClaps();
			this.onayPeriyoduLabel.Text = "Şuan için onay yapmanıza gerek yok.";
		}
		private void changeLinkIcons()
		{
			for (int i = 0; i < 12; i++)
			{
				Control[] array = base.Controls.Find("linkIcon" + (i + 1).ToString(), true);
				if (this.linkStatus[i] == 2)
				{
					((PictureBox)array[0]).Image = Resources.link_waiting;
				}
				else if (this.linkStatus[i] == 3)
				{
					PictureBox pictureBox = (PictureBox)array[0];
					pictureBox.Image = Resources.link_done;
					pictureBox.Cursor = Cursors.Default;
				}
			}
		}
		private void ImageHilebol_Click(object sender, EventArgs e)
		{
			Process.Start("https://bolcorp.icu/url.php?tag=hilebol-web");
		}
		private void ImageInstagram_Click(object sender, EventArgs e)
		{
			Process.Start("https://bolcorp.icu/url.php?tag=hilebol-instagram");
		}
		private void ImageYoutube_Click(object sender, EventArgs e)
		{
			Process.Start("https://bolcorp.icu/url.php?tag=hilebol-youtube");
		}
		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private void linkOnayiNasilYapilirButton_MouseEnter(object sender, EventArgs e)
		{
			this.linkOnayiNasilYapilirButton.BackColor = Color.FromArgb(23, 127, 236);
		}
		private void linkOnayiNasilYapilirButton_MouseLeave(object sender, EventArgs e)
		{
			this.linkOnayiNasilYapilirButton.BackColor = Color.FromArgb(28, 117, 239);
		}
		private void ustteTutButton_MouseEnter(object sender, EventArgs e)
		{
			this.ustteTutButton.BackColor = Color.FromArgb(245, 248, 248);
		}
		private void ustteTutButton_MouseLeave(object sender, EventArgs e)
		{
			this.ustteTutButton.BackColor = Color.FromArgb(241, 242, 246);
		}
		private void linkIcon1_Click(object sender, EventArgs e)
		{
			if (this.linkIcon1.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 1;
				try
				{
					if (SecondForm.class_33.var_4 == null)
					{
						SecondForm.class_33.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_33.var_4.Target;
					CallSite CurrentVar = SecondForm.class_33.var_4;
					if (SecondForm.class_33.var_3 == null)
					{
						SecondForm.class_33.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_33.var_3.Target;
					CallSite var_3 = SecondForm.class_33.var_3;
					if (SecondForm.class_33.var_2 == null)
					{
						SecondForm.class_33.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_33.var_2.Target;
					CallSite var_4 = SecondForm.class_33.var_2;
					if (SecondForm.class_33.var_1 == null)
					{
						SecondForm.class_33.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_33.var_1.Target(SecondForm.class_33.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}
		private void linkIcon2_Click(object sender, EventArgs e)
		{
			if (this.linkIcon2.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 2;
				try
				{
					if (SecondForm.class_34.var_4 == null)
					{
						SecondForm.class_34.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_34.var_4.Target;
					CallSite CurrentVar = SecondForm.class_34.var_4;
					if (SecondForm.class_34.var_3 == null)
					{
						SecondForm.class_34.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_34.var_3.Target;
					CallSite var_3 = SecondForm.class_34.var_3;
					if (SecondForm.class_34.var_2 == null)
					{
						SecondForm.class_34.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_34.var_2.Target;
					CallSite var_4 = SecondForm.class_34.var_2;
					if (SecondForm.class_34.var_1 == null)
					{
						SecondForm.class_34.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_34.var_1.Target(SecondForm.class_34.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}
		private void linkIcon3_Click(object sender, EventArgs e)
		{
			if (this.linkIcon3.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 3;
				try
				{
					if (SecondForm.class_35.var_4 == null)
					{
						SecondForm.class_35.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_35.var_4.Target;
					CallSite CurrentVar = SecondForm.class_35.var_4;
					if (SecondForm.class_35.var_3 == null)
					{
						SecondForm.class_35.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_35.var_3.Target;
					CallSite var_3 = SecondForm.class_35.var_3;
					if (SecondForm.class_35.var_2 == null)
					{
						SecondForm.class_35.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_35.var_2.Target;
					CallSite var_4 = SecondForm.class_35.var_2;
					if (SecondForm.class_35.var_1 == null)
					{
						SecondForm.class_35.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_35.var_1.Target(SecondForm.class_35.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}
		private void linkIcon4_Click(object sender, EventArgs e)
		{
			if (this.linkIcon4.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 4;
				try
				{
					if (SecondForm.class_36.var_4 == null)
					{
						SecondForm.class_36.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_36.var_4.Target;
					CallSite CurrentVar = SecondForm.class_36.var_4;
					if (SecondForm.class_36.var_3 == null)
					{
						SecondForm.class_36.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_36.var_3.Target;
					CallSite var_3 = SecondForm.class_36.var_3;
					if (SecondForm.class_36.var_2 == null)
					{
						SecondForm.class_36.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_36.var_2.Target;
					CallSite var_4 = SecondForm.class_36.var_2;
					if (SecondForm.class_36.var_1 == null)
					{
						SecondForm.class_36.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_36.var_1.Target(SecondForm.class_36.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon5_Click(object sender, EventArgs e)
		{
			if (this.linkIcon5.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 5;
				try
				{
					if (SecondForm.class_37.var_4 == null)
					{
						SecondForm.class_37.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_37.var_4.Target;
					CallSite CurrentVar = SecondForm.class_37.var_4;
					if (SecondForm.class_37.var_3 == null)
					{
						SecondForm.class_37.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_37.var_3.Target;
					CallSite var_3 = SecondForm.class_37.var_3;
					if (SecondForm.class_37.var_2 == null)
					{
						SecondForm.class_37.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_37.var_2.Target;
					CallSite var_4 = SecondForm.class_37.var_2;
					if (SecondForm.class_37.var_1 == null)
					{
						SecondForm.class_37.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_37.var_1.Target(SecondForm.class_37.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon6_Click(object sender, EventArgs e)
		{
			if (this.linkIcon6.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 6;
				try
				{
					if (SecondForm.class_38.var_4 == null)
					{
						SecondForm.class_38.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_38.var_4.Target;
					CallSite CurrentVar = SecondForm.class_38.var_4;
					if (SecondForm.class_38.var_3 == null)
					{
						SecondForm.class_38.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_38.var_3.Target;
					CallSite var_3 = SecondForm.class_38.var_3;
					if (SecondForm.class_38.var_2 == null)
					{
						SecondForm.class_38.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_38.var_2.Target;
					CallSite var_4 = SecondForm.class_38.var_2;
					if (SecondForm.class_38.var_1 == null)
					{
						SecondForm.class_38.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_38.var_1.Target(SecondForm.class_38.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon7_Click(object sender, EventArgs e)
		{
			if (this.linkIcon7.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 7;
				try
				{
					if (SecondForm.class_39.var_4 == null)
					{
						SecondForm.class_39.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_39.var_4.Target;
					CallSite CurrentVar = SecondForm.class_39.var_4;
					if (SecondForm.class_39.var_3 == null)
					{
						SecondForm.class_39.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_39.var_3.Target;
					CallSite var_3 = SecondForm.class_39.var_3;
					if (SecondForm.class_39.var_2 == null)
					{
						SecondForm.class_39.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_39.var_2.Target;
					CallSite var_4 = SecondForm.class_39.var_2;
					if (SecondForm.class_39.var_1 == null)
					{
						SecondForm.class_39.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_39.var_1.Target(SecondForm.class_39.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon8_Click(object sender, EventArgs e)
		{
			if (this.linkIcon8.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 8;
				try
				{
					if (SecondForm.class_40.var_4 == null)
					{
						SecondForm.class_40.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_40.var_4.Target;
					CallSite CurrentVar = SecondForm.class_40.var_4;
					if (SecondForm.class_40.var_3 == null)
					{
						SecondForm.class_40.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_40.var_3.Target;
					CallSite var_3 = SecondForm.class_40.var_3;
					if (SecondForm.class_40.var_2 == null)
					{
						SecondForm.class_40.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_40.var_2.Target;
					CallSite var_4 = SecondForm.class_40.var_2;
					if (SecondForm.class_40.var_1 == null)
					{
						SecondForm.class_40.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_40.var_1.Target(SecondForm.class_40.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon9_Click(object sender, EventArgs e)
		{
			if (this.linkIcon9.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 9;
				try
				{
					if (SecondForm.class_41.var_4 == null)
					{
						SecondForm.class_41.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_41.var_4.Target;
					CallSite CurrentVar = SecondForm.class_41.var_4;
					if (SecondForm.class_41.var_3 == null)
					{
						SecondForm.class_41.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_41.var_3.Target;
					CallSite var_3 = SecondForm.class_41.var_3;
					if (SecondForm.class_41.var_2 == null)
					{
						SecondForm.class_41.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_41.var_2.Target;
					CallSite var_4 = SecondForm.class_41.var_2;
					if (SecondForm.class_41.var_1 == null)
					{
						SecondForm.class_41.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_41.var_1.Target(SecondForm.class_41.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon10_Click(object sender, EventArgs e)
		{
			if (this.linkIcon10.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 10;
				try
				{
					if (SecondForm.class_42.var_4 == null)
					{
						SecondForm.class_42.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_42.var_4.Target;
					CallSite CurrentVar = SecondForm.class_42.var_4;
					if (SecondForm.class_42.var_3 == null)
					{
						SecondForm.class_42.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_42.var_3.Target;
					CallSite var_3 = SecondForm.class_42.var_3;
					if (SecondForm.class_42.var_2 == null)
					{
						SecondForm.class_42.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_42.var_2.Target;
					CallSite var_4 = SecondForm.class_42.var_2;
					if (SecondForm.class_42.var_1 == null)
					{
						SecondForm.class_42.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_42.var_1.Target(SecondForm.class_42.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon11_Click(object sender, EventArgs e)
		{
			if (this.linkIcon11.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 11;
				try
				{
					if (SecondForm.class_43.var_4 == null)
					{
						SecondForm.class_43.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_43.var_4.Target;
					CallSite CurrentVar = SecondForm.class_43.var_4;
					if (SecondForm.class_43.var_3 == null)
					{
						SecondForm.class_43.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_43.var_3.Target;
					CallSite var_3 = SecondForm.class_43.var_3;
					if (SecondForm.class_43.var_2 == null)
					{
						SecondForm.class_43.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_43.var_2.Target;
					CallSite var_4 = SecondForm.class_43.var_2;
					if (SecondForm.class_43.var_1 == null)
					{
						SecondForm.class_43.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_43.var_1.Target(SecondForm.class_43.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkIcon12_Click(object sender, EventArgs e)
		{
			if (this.linkIcon12.Cursor == Cursors.Hand)
			{
				string fileName = "";
				int num = 12;
				try
				{
					if (SecondForm.class_44.var_4 == null)
					{
						SecondForm.class_44.var_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_44.var_4.Target;
					CallSite CurrentVar = SecondForm.class_44.var_4;
					if (SecondForm.class_44.var_3 == null)
					{
						SecondForm.class_44.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = SecondForm.class_44.var_3.Target;
					CallSite var_3 = SecondForm.class_44.var_3;
					if (SecondForm.class_44.var_2 == null)
					{
						SecondForm.class_44.var_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> target3 = SecondForm.class_44.var_2.Target;
					CallSite var_4 = SecondForm.class_44.var_2;
					if (SecondForm.class_44.var_1 == null)
					{
						SecondForm.class_44.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					fileName = target(CurrentVar, target2(var_3, target3(var_4, SecondForm.class_44.var_1.Target(SecondForm.class_44.var_1, this.jLinks, "links"), num - 1), "url"));
					this.linkStatus[num - 1] = 2;
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgErrorJson") + " " + Language.getRMValue("msgPleaseTryAgain"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
					this.setJsonLinks(ref this.jLinks);
				}
				try
				{
					Process.Start(fileName);
				}
				catch (Exception)
				{
					MessageBox.Show(Language.getRMValue("msgLinkCantOpened") + " " + Language.getRMValue("msgSelectADefaultBrowser"), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
				this.changeLinkIcons();
			}
		}

		private void linkApproveFinished()
		{
			base.TopMost = false;
			base.Size = new Size(455, 510);
			this.altPanel.Location = new Point(45, 356);
			this.linkApprovePanel.Visible = false;
		}

		private void ustteTutButton_Click(object sender, EventArgs e)
		{
			base.TopMost = !base.TopMost;
			if (base.TopMost)
			{
				this.ustteTutButton.Text = Language.getRMValue("f2KeepOnTop") + " ✖";
				return;
			}
			this.ustteTutButton.Text = Language.getRMValue("f2KeepOnTop");
		}

		private void linkOnayiNasilYapilirButton_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://bolcorp.icu/url.php?tag=pgiex-link-approve");
			}
			catch (Exception)
			{
				MessageBox.Show("Link açılırken bir hata meydana geldi. Muhtemelen bu sorunun sebebi bir varsayılan tarayıcı seçmemenizdir. İşletim sisteminiz için bir varsayılan tarayıcı seçerek tekrar deneyin.", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		private void ImageCSBOL_Click(object sender, EventArgs e)
		{
			this.hwidGosterSayac++;
			int num = this.hwidGosterSayac;
		}

		private void firstTimer_Tick(object sender, EventArgs e)
		{
			this.flow.Stop();
			this.licensePanel.Location = this.ImageLoading.Location;
			this.linkApproveYoPanel.Location = this.ImageLoading.Location;
			this.son24SaatLabel.Text = Language.getRMValue("f2Last24Hours").Replace("{0}", Program.GetRemoteContent("https://bolcorp.icu/last24h.php?source=" + FirstForm.getSourceName(), 2000));
			if (this.linkOnayiGerekliMi("yesLog"))
			{
				this.approveTimer.Start();
				this.fixFormForApprove();
				this.setJsonLinks(ref this.jLinks);
				Control control = this.onayPeriyoduLabel;
				if (SecondForm.class_50.var_6 == null)
				{
					SecondForm.class_50.var_6 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
				}
				Func<CallSite, object, string> target = SecondForm.class_50.var_6.Target;
				CallSite CurrentVar = SecondForm.class_50.var_6;
				if (SecondForm.class_50.var_5 == null)
				{
					SecondForm.class_50.var_5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = SecondForm.class_50.var_5.Target;
				CallSite var_3 = SecondForm.class_50.var_5;
				if (SecondForm.class_50.var_4 == null)
				{
					SecondForm.class_50.var_4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target3 = SecondForm.class_50.var_4.Target;
				CallSite var_4 = SecondForm.class_50.var_4;
				if (SecondForm.class_50.var_3 == null)
				{
					SecondForm.class_50.var_3 = CallSite<Func<CallSite, string, string, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Replace", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, string, string, object, object> target4 = SecondForm.class_50.var_3.Target;
				CallSite var_5 = SecondForm.class_50.var_3;
				string rmvalue = Language.getRMValue("f2PassLinksForApproval");
				string arg = "{0}";
				if (SecondForm.class_50.var_2 == null)
				{
					SecondForm.class_50.var_2 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target5 = SecondForm.class_50.var_2.Target;
				CallSite var_6 = SecondForm.class_50.var_2;
				if (SecondForm.class_50.var_1 == null)
				{
					SecondForm.class_50.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				control.Text = target(CurrentVar, target2(var_3, target3(var_4, target4(var_5, rmvalue, arg, target5(var_6, SecondForm.class_50.var_1.Target(SecondForm.class_50.var_1, this.jLinks, "linkCountForDone"))), "\n"), Language.getRMValue("f2ApprovalPeriod")));
				this.setLinkActives();
				this.setLinkDones();
				this.setLinkNames();
				this.changeLinkIcons();
			}
			else
			{
				this.setJsonLinks(ref this.jLinks);
				this.onayPeriyoduLabel.Text = "Şuan için onay yapmanıza gerek yok.";
				this.approveTimer.Stop();
				this.fixFormForApprove();
			}
			this.ImageLoading.Visible = false;
			this.altPanel.Visible = true;
			this.menuLink_Click(sender, e);
		}

		private void selectMenu(string menuName = "")
		{
			if (menuName.Length > 0)
			{
				this.selectedMenu = menuName;
			}
			this.menuLink.Image = Resources.m_link_0;
			this.menuLicense.Image = Resources.m_key_0;
			this.menuLanguage.Image = Resources.m_translate_0;
			string a = this.selectedMenu;
			if (a == "link")
			{
				this.menuLink.Image = Resources.m_link_1;
				return;
			}
			if (a == "license")
			{
				this.menuLicense.Image = Resources.m_key_1;
				return;
			}
			if (!(a == "language"))
			{
				return;
			}
			this.menuLanguage.Image = Resources.m_translate_1;
		}

		private void menuLink_Click(object sender, EventArgs e)
		{
			this.selectMenu("link");
			if (this.linkOnayiGerekliMi("noLog"))
			{
				this.fixFormForApprove();
				return;
			}
			this.fixFormForClaps();
		}

		private void menuLicense_Click(object sender, EventArgs e)
		{
			this.setPreRemainingTime();
			this.fixFormForLicense();
			this.selectMenu("license");
		}

		private void menuLanguage_Click(object sender, EventArgs e)
		{
			this.selectMenu("language");
			this.fixFormForLanguage();
		}

		private void doLinkApproveLabel_Click(object sender, EventArgs e)
		{
			if (FirstForm.internetConnectionIsExists())
			{
				this.fixFormForApprove();
				this.ApproveTimer_Tick(sender, e);
				this.approveTimer.Start();
				return;
			}
			MessageBox.Show(Language.getRMValue("msgErrorConnect"), "Error: Internet connection", MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		private void useLicenseCodeLabel_Click(object sender, EventArgs e)
		{
			this.fixFormForLicense();
			this.selectMenu("license");
		}

		private void hideLicenseMessageButton_Click(object sender, EventArgs e)
		{
			this.licenseMessage.Visible = false;
			this.licenseMessageLeft.Visible = false;
			this.hideLicenseMessageButton.Visible = false;
		}
		private void buyLicenseButton_Click(object sender, EventArgs e)
		{
			FirstForm.openURL("https://bolcorp.icu/url.php?tag=pgiex-buy-license");
		}

		private void buyLicenseButton_MouseEnter(object sender, EventArgs e)
		{
			this.buyLicenseButton.BackColor = Color.FromArgb(244, 244, 246);
		}

		private void buyLicenseButton_MouseLeave(object sender, EventArgs e)
		{
			this.buyLicenseButton.BackColor = Color.FromArgb(230, 230, 233);
		}

		private void copyHBIDButton_MouseEnter(object sender, EventArgs e)
		{
			this.copyHBIDButton.BackColor = Color.FromArgb(244, 244, 246);
		}

		private void copyHBIDButton_MouseLeave(object sender, EventArgs e)
		{
			this.copyHBIDButton.BackColor = Color.FromArgb(230, 230, 233);
		}

		private void copyHBIDButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(SecondForm.getHBID());
			this.copyHBIDButton.Text = Language.getRMValue("f2HBIDCopied");
			this.HBIDCopiedFixer.Start();
		}

		private void HBIDCopiedFixer_Tick(object sender, EventArgs e)
		{
			this.HBIDCopiedFixer.Stop();
			this.copyHBIDButton.Text = Language.getRMValue("f2CopyHBID");
		}

		private void licenseCodeEnterButton_Click(object sender, EventArgs e)
		{
			if (this.licenseCodeTextbox.TextLength > 0)
			{
				try
				{
					object arg = new JavaScriptSerializer().Deserialize<object>(Program.GetRemoteContent("https://bolcorp.icu/license.php?hbid=" + SecondForm.getHBID() + "&code=" + this.licenseCodeTextbox.Text, 10000));
					Control control = this.licenseMessage;
					if (SecondForm.class_65.var_2 == null)
					{
						SecondForm.class_65.var_2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(SecondForm)));
					}
					Func<CallSite, object, string> target = SecondForm.class_65.var_2.Target;
					CallSite CurrentVar = SecondForm.class_65.var_2;
					if (SecondForm.class_65.var_1 == null)
					{
						SecondForm.class_65.var_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					control.Text = target(CurrentVar, SecondForm.class_65.var_1.Target(SecondForm.class_65.var_1, arg, "message"));
					if (SecondForm.class_65.var_3 == null)
					{
						SecondForm.class_65.var_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(SecondForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					object obj = SecondForm.class_65.var_3.Target(SecondForm.class_65.var_3, arg, "messageStatus");
					if (obj is int)
					{
						switch ((int)obj)
						{
						case 1:
							this.licenseMessage.ForeColor = Color.FromArgb(0, 148, 50);
							this.licenseMessageLeft.BackColor = Color.FromArgb(0, 148, 50);
							break;
						case 2:
							this.licenseMessage.ForeColor = Color.FromArgb(238, 90, 36);
							this.licenseMessageLeft.BackColor = Color.FromArgb(238, 90, 36);
							break;
						case 3:
							this.licenseMessage.ForeColor = Color.FromArgb(234, 32, 39);
							this.licenseMessageLeft.BackColor = Color.FromArgb(234, 32, 39);
							break;
						}
					}
				}
				catch (Exception)
				{
					this.licenseMessage.Text = Language.getRMValue("msgSomethingWentWrong") + " (o,o)";
					this.licenseMessage.ForeColor = Color.FromArgb(234, 32, 39);
					this.licenseMessageLeft.BackColor = Color.FromArgb(234, 32, 39);
				}
				this.licenseMessage.Visible = true;
				this.licenseMessageLeft.Visible = true;
				this.hideLicenseMessageButton.Visible = true;
			}
		}

		private void bayraklar_MouseLeave(object sender, EventArgs e)
		{
			string[] array = new string[]
			{
				"en",
				"tr",
				"br",
				"es",
				"eg",
				"fr",
				"ro",
				"ru",
				"bg",
				"pl",
				"de",
				"hu",
				"cz",
				"lt"
			};
			for (int i = 0; i < array.Length; i++)
			{
				((PictureBox)base.Controls.Find("bayrak_" + array[i], true)[0]).BackColor = Color.White;
			}
			string language = Language.getLanguage();
			this.languageContentLabel.Text = Language.getRMValue("f2LanguageName");
			uint num = PrivateImplementationDetails.ComputeStringHash(language);
			if (num <= 786264949U)
			{
				if (num <= 550245450U)
				{
					if (num != 432802117U)
					{
						if (num != 433934950U)
						{
							if (num != 550245450U)
							{
								return;
							}
							if (!(language == "EN"))
							{
								return;
							}
							this.bayrak_en.BackColor = SecondForm.Renkler.primary;
							return;
						}
						else
						{
							if (!(language == "BG"))
							{
								return;
							}
							this.bayrak_bg.BackColor = SecondForm.Renkler.primary;
							return;
						}
					}
					else
					{
						if (!(language == "EG"))
						{
							return;
						}
						this.bayrak_eg.BackColor = SecondForm.Renkler.primary;
						return;
					}
				}
				else if (num <= 634133545U)
				{
					if (num != 620754425U)
					{
						if (num != 634133545U)
						{
							return;
						}
						if (!(language == "ES"))
						{
							return;
						}
						this.bayrak_es.BackColor = SecondForm.Renkler.primary;
						return;
					}
					else
					{
						if (!(language == "PL"))
						{
							return;
						}
						this.bayrak_pl.BackColor = SecondForm.Renkler.primary;
						return;
					}
				}
				else if (num != 653618115U)
				{
					if (num != 786264949U)
					{
						return;
					}
					if (!(language == "BR"))
					{
						return;
					}
					this.bayrak_br.BackColor = SecondForm.Renkler.primary;
					return;
				}
				else
				{
					if (!(language == "TR"))
					{
						return;
					}
					this.bayrak_tr.BackColor = SecondForm.Renkler.primary;
					return;
				}
			}
			else if (num <= 1745149088U)
			{
				if (num != 1003388258U)
				{
					if (num != 1708783731U)
					{
						if (num != 1745149088U)
						{
							return;
						}
						if (!(language == "RU"))
						{
							return;
						}
						this.bayrak_ru.BackColor = SecondForm.Renkler.primary;
						return;
					}
					else
					{
						if (!(language == "CS"))
						{
							return;
						}
						this.bayrak_cz.BackColor = SecondForm.Renkler.primary;
						return;
					}
				}
				else
				{
					if (!(language == "DE"))
					{
						return;
					}
					this.bayrak_de.BackColor = SecondForm.Renkler.primary;
					return;
				}
			}
			else if (num <= 1993561969U)
			{
				if (num != 1810582278U)
				{
					if (num != 1993561969U)
					{
						return;
					}
					if (!(language == "FR"))
					{
						return;
					}
					this.bayrak_fr.BackColor = SecondForm.Renkler.primary;
					return;
				}
				else
				{
					if (!(language == "HU"))
					{
						return;
					}
					this.bayrak_hu.BackColor = SecondForm.Renkler.primary;
					return;
				}
			}
			else if (num != 2095213421U)
			{
				if (num != 2181367182U)
				{
					return;
				}
				if (!(language == "RO"))
				{
					return;
				}
				this.bayrak_ro.BackColor = SecondForm.Renkler.primary;
				return;
			}
			else
			{
				if (!(language == "LT"))
				{
					return;
				}
				this.bayrak_lt.BackColor = SecondForm.Renkler.primary;
				return;
			}
		}

		private void bayrak_en_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_en.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "English";
		}
		private void bayrak_tr_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_tr.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Türkçe";
		}
		private void bayrak_br_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_br.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Português";
		}

		private void bayrak_es_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_es.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Español";
		}

		private void bayrak_eg_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_eg.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "العربية";
		}

		private void bayrak_fr_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_fr.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Français";
		}

		private void bayrak_ro_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_ro.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Română";
		}

		private void bayrak_ru_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_ru.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Русский";
		}

		private void bayrak_bg_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_bg.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Български";
		}

		private void bayrak_pl_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_pl.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Polska";
		}

		private void bayrak_de_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_de.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Deutsch";
		}

		private void bayrak_hu_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_hu.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Magyar";
		}

		private void bayrak_cz_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_cz.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Čeština";
		}

		private void bayrak_lt_MouseEnter(object sender, EventArgs e)
		{
			this.bayrak_lt.BackColor = SecondForm.Renkler.tertiary;
			this.languageContentLabel.Text = "Lietuviškai";
		}

		private void bayrak_en_Click(object sender, EventArgs e)
		{
			Language.setLanguage("EN");
		}

		private void bayrak_tr_Click(object sender, EventArgs e)
		{
			Language.setLanguage("TR");
		}

		private void bayrak_br_Click(object sender, EventArgs e)
		{
			Language.setLanguage("PT");
		}

		private void bayrak_es_Click(object sender, EventArgs e)
		{
			Language.setLanguage("ES");
		}

		private void bayrak_eg_Click(object sender, EventArgs e)
		{
			Language.setLanguage("EG");
		}

		private void bayrak_fr_Click(object sender, EventArgs e)
		{
			Language.setLanguage("FR");
		}

		private void bayrak_ro_Click(object sender, EventArgs e)
		{
			Language.setLanguage("RO");
		}

		private void bayrak_ru_Click(object sender, EventArgs e)
		{
			Language.setLanguage("RU");
		}

		private void bayrak_bg_Click(object sender, EventArgs e)
		{
			Language.setLanguage("BG");
		}

		private void bayrak_pl_Click(object sender, EventArgs e)
		{
			Language.setLanguage("PL");
		}
		private void bayrak_de_Click(object sender, EventArgs e)
		{
			Language.setLanguage("DE");
		}
		private void bayrak_hu_Click(object sender, EventArgs e)
		{
			Language.setLanguage("HU");
		}

		private void bayrak_cz_Click(object sender, EventArgs e)
		{
			Language.setLanguage("CS");
		}

		private void bayrak_lt_Click(object sender, EventArgs e)
		{
			Language.setLanguage("LT");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Language.eksikCeviriler);
		}

		public int[] linkStatus = new int[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1
		};

		public bool[] logSent = new bool[12];
		private string selectedMenu = "home";
		private dynamic jLinks;
		private int hwidGosterSayac;
		public struct Renkler
		{
			public static Color primary
			{
				get
				{
					return Color.FromArgb(28, 117, 239);
				}
			}
			public static Color secondary
			{
				get
				{
					return Color.FromArgb(230, 230, 233);
				}
			}
			public static Color tertiary
			{
				get
				{
					return Color.FromArgb(47, 53, 66);
				}
			}
		}
	}
}
