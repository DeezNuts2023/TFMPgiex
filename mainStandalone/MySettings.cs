using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace tfmclient5.My
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings mySettings_var;
		private static bool isOpen;
		private static object object_0;
		
		static MySettings()
		{
			MySettings.mySettings_var = (MySettings)SettingsBase.Synchronized(new MySettings());
			MySettings.object_0 = RuntimeHelpers.GetObjectValue(new object());
		}

		public MySettings() {}

		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void smethod_0(object sender, EventArgs e)
		{
			if (Class2.Form0_0.SaveMySettingsOnExit)
			{
				Class23.mySettings_var.Save();
			}
		}

		public static MySettings Default
		{
			get
			{
				if (!MySettings.isOpen)
				{
					object obj = MySettings.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.isOpen)
						{
							Class2.Form0_0.Shutdown += MySettings.smethod_0;
							MySettings.isOpen = true;
						}
					}
				}
				return MySettings.mySettings_var;
			}
		}

		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ShowIP
		{
			get
			{
				return Conversions.ToBoolean(this["ShowIP"]);
			}
			set
			{
				this["ShowIP"] = value;
			}
		}

		[UserScopedSetting]
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		public string swfTime
		{
			get
			{
				return Conversions.ToString(this["swfTime"]);
			}
			set
			{
				this["swfTime"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("AIR")]
		public string flashOption
		{
			get
			{
				return Conversions.ToString(this["flashOption"]);
			}
			set
			{
				this["flashOption"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool firstOpen
		{
			get
			{
				return Conversions.ToBoolean(this["firstOpen"]);
			}
			set
			{
				this["firstOpen"] = value;
			}
		}
	}
}
