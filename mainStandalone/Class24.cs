using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

[StandardModule]
internal sealed class Class24
{
	static Class24()
	{
		Class24.bool_0 = false;
		Class24.byte_0 = 136;
		Class24.byte_1 = 55;
		Class24.bool_1 = false;
		Class24.int_0 = 0;
		Class24.int_1 = 1;
	}

	public static string smethod_0(string string_2)
	{
		return Convert.ToBase64String(Encoding.ASCII.GetBytes(string_2));
	}

	public static string smethod_1(string string_2)
	{
		return Encoding.ASCII.GetString(Convert.FromBase64String(string_2));
	}

	public static WebClient smethod_2(string string_2, string string_3)
	{
		try
		{
			WebClient webClient = new WebClient();
			if (Operators.ConditionalCompareObjectEqual(string_3, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"swfLocation"
			}, null), "\\"), Class2.Class3_0.Form1_0.string_16), ".swf"), false))
			{
				webClient.DownloadProgressChanged += Class24.smethod_5;
				webClient.DownloadFileCompleted += Class24.smethod_4;
			}
			webClient.DownloadFileAsync(new Uri(string_2), string_3);
			return webClient;
		}
		catch (Exception ex)
		{
			Application.Exit();
		}
		return new WebClient();
	}

	public static bool smethod_3()
	{
		string text = "";
		foreach (Process process in Process.GetProcesses())
		{
			if (Operators.CompareString(process.ProcessName, "", false) != 0)
			{
				text = text + process.ProcessName + "\r\n";
			}
		}
		return text.Contains("Proxifier");
	}

	public static void smethod_4(object sender, AsyncCompletedEventArgs e)
	{
		Class2.Class3_0.Form2_0.YeniSekmeToolStripMenuItem.Enabled = true;
		Class2.Class3_0.Form2_0.YenileToolStripMenuItem.Enabled = true;
		if (Class2.Class3_0.Form1_0.bool_3)
		{
			Class2.Class3_0.Form1_0.updateButton.Text = Conversions.ToString(GClass0.smethod_4("f2UpdateSWF"));
			return;
		}
		Class2.Class3_0.Form2_0.Text = Class2.Class3_0.Form1_0.string_16 + " - " + Regex.Replace(Class24.string_0, "\\{0\\}", DateTime.Now.ToString("HH:mm"));
		Class2.Class3_0.Form2_0.Show();
		Class2.Class3_0.Form2_0.ContextMenuStrip1.Enabled = true;
		if (Class24.int_0 >= 1807152)
		{
			if (Class24.bool_0)
			{
				Class24.bool_0 = false;
				Class2.Class3_0.Form2_0.method_20();
			}
			return;
		}
		if (!Class24.smethod_3())
		{
			Class2.Class3_0.Form2_0.Text = Conversions.ToString(Operators.ConcatenateObject(Class2.Class3_0.Form1_0.string_16 + " - ", GClass0.smethod_4("msgUpdateError")));
			return;
		}
		Class2.Class3_0.Form2_0.Text = Conversions.ToString(Operators.ConcatenateObject(Class2.Class3_0.Form1_0.string_16 + " - ", GClass0.smethod_4("msgUpdateErrorForProxifier")));
	}

	public static void smethod_5(object sender, DownloadProgressChangedEventArgs e)
	{
		if (Class2.Class3_0.Form1_0.bool_3)
		{
			Class2.Class3_0.Form1_0.updateButton.Text = Class24.string_1 + " " + Conversions.ToString(e.ProgressPercentage) + "%";
		}
		else
		{
			Class2.Class3_0.Form2_0.Text = string.Concat(new string[]
			{
				Class2.Class3_0.Form1_0.string_16,
				" - ",
				Class24.string_1,
				" ",
				Conversions.ToString(e.ProgressPercentage),
				"%"
			});
		}
		Class24.int_0 = checked((int)e.BytesReceived);
	}

	private static string smethod_6(string string_2)
	{
		return new WebClient().DownloadString(string_2);
	}

	public static string smethod_7(string string_2)
	{
		string result;
		if (Operators.CompareString(Class2.Class3_0.Form1_0.string_16, "Dressroom", false) == 0)
		{
			result = "";
		}
		else
		{
			if (Operators.CompareString(Class2.Class3_0.Form1_0.string_16, "Transformice", false) == 0)
			{
				string_2 = Regex.Replace(string_2, "newdate", Class23.MySettings_0.swfTime);
			}
			else
			{
				string_2 = Regex.Replace(string_2, "newdate", "0");
			}
			string_2 = Regex.Replace(string_2, "xLanguage", GClass0.smethod_0());
			string_2 = Regex.Replace(string_2, "xHwid", firstform.smethod_4());
			string_2 = Regex.Replace(string_2, "xV", Class24.byte_0.ToString());
			string_2 = Regex.Replace(string_2, "xB", Class24.byte_1.ToString());
			string_2 = Regex.Replace(string_2, "xNum", Conversions.ToString(Class24.int_1));
			result = string_2;
		}
		return result;
	}

	public static string smethod_8(string string_2)
	{
		StreamReader streamReader = new StreamReader(string_2);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		return result;
	}

	public static object smethod_9(int int_2 = 999, int int_3 = 999999999)
	{
		if (Class24.staticLocalInitFlag_0 == null)
		{
			Interlocked.CompareExchange<StaticLocalInitFlag>(ref Class24.staticLocalInitFlag_0, new StaticLocalInitFlag(), null);
		}
		bool flag = false;
		try
		{
			Monitor.Enter(Class24.staticLocalInitFlag_0, ref flag);
			if (Class24.staticLocalInitFlag_0.State == 0)
			{
				Class24.staticLocalInitFlag_0.State = 2;
				Class24.random_0 = new Random();
			}
			else if (Class24.staticLocalInitFlag_0.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			Class24.staticLocalInitFlag_0.State = 1;
			if (flag)
			{
				Monitor.Exit(Class24.staticLocalInitFlag_0);
			}
		}
		return Class24.random_0.Next(int_2, int_3);
	}

	public static void smethod_10()
	{
		try
		{
			Process.GetProcessesByName("Pgiex - Transformice SWF Updater")[0].Kill();
		}
		catch (Exception ex)
		{
		}
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class2.Class3_0.Form1_0.object_0);
			try
			{
				Class2.Class1_0.FileSystem.DeleteDirectory(Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"swfLocation"
				}, null)), DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex2)
			{
			}
			if (!Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[]
			{
				"swfLocation"
			}, null), "META-INF\\AIR"))))
			{
				Directory.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"swfLocation"
				}, null), "META-INF\\AIR")));
			}
			try
			{
				Class24.smethod_2("https://transformice.bolcorp.icu/App/exe/Updater.exe", "C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe");
			}
			catch (Exception ex3)
			{
			}
			try
			{
				Class24.smethod_2("https://transformice.bolcorp.icu/Client/files/AIR/application.xml", Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"swfLocation"
				}, null), "META-INF\\AIR\\application.xml")));
			}
			catch (Exception ex4)
			{
			}
			try
			{
				Class24.smethod_2("https://transformice.bolcorp.icu/Client/files/AIR/Transformice.exe", Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"swfLocation"
				}, null), "TFMClient - Pgiex Tfm.exe"))).DownloadFileCompleted += Class2.Class3_0.Form1_0.method_119;
			}
			catch (Exception ex5)
			{
			}
			Class2.Class3_0.Form1_0.Timer_7.Start();
		}
		catch (Exception ex6)
		{
		}
	}

	public static void smethod_11()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Class2.Class3_0.Form1_0.object_0);
		object obj = Class2.Class3_0.Form1_0.string_16;
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Class2.Class3_0.Form1_0.sekmeLinkOrLicense, null, "Visible", new object[0], null, null, null), false, false))
		{
			if (Operators.ConditionalCompareObjectEqual(obj, "Transformice", false))
			{
				if (!File.Exists("C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe"))
				{
					Class24.smethod_2("https://transformice.bolcorp.icu/App/exe/Updater.exe", "C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe");
					return;
				}
				Interaction.Shell("C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe", AppWinStyle.NormalFocus, false, -1);
				return;
			}
			else
			{
				object[] array;
				bool[] array2;
				object instance = NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"privateUpdate"
				}, null), null, "replace", array = new object[]
				{
					"{0}",
					obj
				}, null, null, array2 = new bool[]
				{
					default(bool),
					true
				});
				if (array2[1])
				{
					obj = RuntimeHelpers.GetObjectValue(array[1]);
				}
				Class24.smethod_2(Conversions.ToString(NewLateBinding.LateGet(instance, null, "replace", new object[]
				{
					"{1}",
					Operators.ConcatenateObject("Chargeur", obj)
				}, null, null, null)), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"swfLocation"
				}, null), "\\Chargeur"), obj), ".swf")));
				object[] array3;
				bool[] array4;
				object instance2 = NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"privateUpdate"
				}, null), null, "replace", array3 = new object[]
				{
					"{0}",
					obj
				}, null, null, array4 = new bool[]
				{
					default(bool),
					true
				});
				if (array4[1])
				{
					obj = RuntimeHelpers.GetObjectValue(array3[1]);
				}
				object value = NewLateBinding.LateGet(instance2, null, "replace", array = new object[]
				{
					"{1}",
					obj
				}, null, null, array2 = new bool[]
				{
					default(bool),
					true
				});
				if (array2[1])
				{
					obj = RuntimeHelpers.GetObjectValue(array[1]);
				}
				Class24.smethod_2(Conversions.ToString(value), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"swfLocation"
				}, null), "\\"), obj), ".swf")));
			}
		}
	}

	public static bool bool_0;
	public static string string_0;
	public static string string_1;
	public static byte byte_0;
	public static byte byte_1;
	public static bool bool_1;
	public static int int_0;
	public static int int_1;
	private static Random random_0;
	private static StaticLocalInitFlag staticLocalInitFlag_0;
}
