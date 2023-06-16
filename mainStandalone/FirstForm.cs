using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[DesignerGenerated]
public class firstform : Form
{
	static firstform()
	{
		firstform.string_0 = "pgiex";
		firstform.string_1 = "6.0";
	}

	public firstform()
	{
		base..ctor();
		base.Load += this.firstform_Load;
		this.bool_0 = false;
		this.bool_1 = false;
		this.bool_2 = false;
		this.bool_3 = false;
		this.InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected virtual void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(firstform));
		this.buttonUpdate = new Label();
		this.buttonExit = new Label();
		this.msgImage = new PictureBox();
		this.msgLabel = new Label();
		this.buttonRun = new Label();
		this.buttonRestart = new Label();
		this.Timer_0 = new Timer(this.icontainer_0);
		this.Timer_1 = new Timer(this.icontainer_0);
		((ISupportInitialize)this.msgImage).BeginInit();
		base.SuspendLayout();
		this.buttonUpdate.BackColor = Color.Transparent;
		this.buttonUpdate.Cursor = Cursors.Hand;
		this.buttonUpdate.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		this.buttonUpdate.ForeColor = Color.FromArgb(208, 213, 218);
		this.buttonUpdate.Image = Class22.Bitmap_9;
		this.buttonUpdate.Location = new Point(258, 81);
		this.buttonUpdate.Name = "buttonUpdate";
		this.buttonUpdate.Size = new Size(98, 18);
		this.buttonUpdate.TabIndex = 41;
		this.buttonUpdate.Text = "Update";
		this.buttonUpdate.TextAlign = ContentAlignment.MiddleCenter;
		this.buttonUpdate.Visible = false;
		this.buttonExit.BackColor = Color.Transparent;
		this.buttonExit.Cursor = Cursors.Hand;
		this.buttonExit.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		this.buttonExit.ForeColor = Color.FromArgb(208, 213, 218);
		this.buttonExit.Image = Class22.Bitmap_9;
		this.buttonExit.Location = new Point(362, 81);
		this.buttonExit.Name = "buttonExit";
		this.buttonExit.Size = new Size(98, 18);
		this.buttonExit.TabIndex = 40;
		this.buttonExit.Text = "Cancel";
		this.buttonExit.TextAlign = ContentAlignment.MiddleCenter;
		this.msgImage.BackColor = Color.Transparent;
		this.msgImage.Image = Class22.Bitmap_19;
		this.msgImage.Location = new Point(21, 21);
		this.msgImage.Name = "msgImage";
		this.msgImage.Size = new Size(138, 78);
		this.msgImage.SizeMode = PictureBoxSizeMode.CenterImage;
		this.msgImage.TabIndex = 41;
		this.msgImage.TabStop = false;
		this.msgLabel.BackColor = Color.Transparent;
		this.msgLabel.Font = new Font("Malgun Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.msgLabel.ForeColor = Color.FromArgb(96, 137, 140);
		this.msgLabel.Location = new Point(157, 23);
		this.msgLabel.Name = "msgLabel";
		this.msgLabel.Padding = new Padding(3);
		this.msgLabel.Size = new Size(308, 50);
		this.msgLabel.TabIndex = 41;
		this.msgLabel.Text = "Connecting to the server ...";
		this.msgLabel.TextAlign = ContentAlignment.TopRight;
		this.buttonRun.BackColor = Color.Transparent;
		this.buttonRun.Cursor = Cursors.Hand;
		this.buttonRun.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		this.buttonRun.ForeColor = Color.FromArgb(208, 213, 218);
		this.buttonRun.Image = Class22.Bitmap_9;
		this.buttonRun.Location = new Point(258, 129);
		this.buttonRun.Name = "buttonRun";
		this.buttonRun.Size = new Size(98, 18);
		this.buttonRun.TabIndex = 59;
		this.buttonRun.Text = "Run";
		this.buttonRun.TextAlign = ContentAlignment.MiddleCenter;
		this.buttonRun.Visible = false;
		this.buttonRestart.BackColor = Color.Transparent;
		this.buttonRestart.Cursor = Cursors.Hand;
		this.buttonRestart.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
		this.buttonRestart.ForeColor = Color.FromArgb(208, 213, 218);
		this.buttonRestart.Image = Class22.Bitmap_9;
		this.buttonRestart.Location = new Point(362, 129);
		this.buttonRestart.Name = "buttonRestart";
		this.buttonRestart.Size = new Size(98, 18);
		this.buttonRestart.TabIndex = 60;
		this.buttonRestart.Text = "Restart";
		this.buttonRestart.TextAlign = ContentAlignment.MiddleCenter;
		this.buttonRestart.Visible = false;
		this.Timer_0.Interval = 1;
		this.Timer_1.Interval = 3000;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.Indigo;
		this.BackgroundImage = Class22.Bitmap_73;
		this.BackgroundImageLayout = ImageLayout.None;
		base.ClientSize = new Size(486, 118);
		base.Controls.Add(this.buttonRestart);
		base.Controls.Add(this.buttonRun);
		base.Controls.Add(this.msgImage);
		base.Controls.Add(this.buttonUpdate);
		base.Controls.Add(this.msgLabel);
		base.Controls.Add(this.buttonExit);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		this.MinimumSize = new Size(486, 118);
		base.Name = "firstform";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = " Pgiex Client";
		base.TopMost = true;
		base.TransparencyKey = Color.Indigo;
		((ISupportInitialize)this.msgImage).EndInit();
		base.ResumeLayout(false);
	}

	internal virtual Label buttonExit
	{
		[CompilerGenerated]
		get
		{
			return this.label_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_12);
			MouseEventHandler value3 = new MouseEventHandler(this.method_27);
			EventHandler value4 = new EventHandler(this.method_28);
			MouseEventHandler value5 = new MouseEventHandler(this.method_29);
			MouseEventHandler value6 = new MouseEventHandler(this.method_30);
			Label label = this.label_0;
			if (label != null)
			{
				label.Click -= value2;
				label.MouseMove -= value3;
				label.MouseLeave -= value4;
				label.MouseDown -= value5;
				label.MouseUp -= value6;
			}
			this.label_0 = value;
			label = this.label_0;
			if (label != null)
			{
				label.Click += value2;
				label.MouseMove += value3;
				label.MouseLeave += value4;
				label.MouseDown += value5;
				label.MouseUp += value6;
			}
		}
	}

	internal virtual Label buttonUpdate
	{
		[CompilerGenerated]
		get
		{
			return this.label_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_13);
			MouseEventHandler value3 = new MouseEventHandler(this.method_23);
			EventHandler value4 = new EventHandler(this.method_24);
			MouseEventHandler value5 = new MouseEventHandler(this.method_25);
			MouseEventHandler value6 = new MouseEventHandler(this.method_26);
			Label label = this.label_1;
			if (label != null)
			{
				label.Click -= value2;
				label.MouseMove -= value3;
				label.MouseLeave -= value4;
				label.MouseDown -= value5;
				label.MouseUp -= value6;
			}
			this.label_1 = value;
			label = this.label_1;
			if (label != null)
			{
				label.Click += value2;
				label.MouseMove += value3;
				label.MouseLeave += value4;
				label.MouseDown += value5;
				label.MouseUp += value6;
			}
		}
	}

	internal virtual PictureBox msgImage
	{
		[CompilerGenerated]
		get
		{
			return this.pictureBox_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_17);
			PictureBox pictureBox = this.pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.DoubleClick -= value2;
			}
			this.pictureBox_0 = value;
			pictureBox = this.pictureBox_0;
			if (pictureBox != null)
			{
				pictureBox.DoubleClick += value2;
			}
		}
	}

	internal virtual Label msgLabel
	{
		[CompilerGenerated]
		get
		{
			return this.label_2;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.label_2 = value;
		}
	}

	internal virtual Label buttonRun
	{
		[CompilerGenerated]
		get
		{
			return this.label_3;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_15);
			MouseEventHandler value3 = new MouseEventHandler(this.method_23);
			EventHandler value4 = new EventHandler(this.method_24);
			MouseEventHandler value5 = new MouseEventHandler(this.method_25);
			MouseEventHandler value6 = new MouseEventHandler(this.method_26);
			Label label = this.label_3;
			if (label != null)
			{
				label.Click -= value2;
				label.MouseMove -= value3;
				label.MouseLeave -= value4;
				label.MouseDown -= value5;
				label.MouseUp -= value6;
			}
			this.label_3 = value;
			label = this.label_3;
			if (label != null)
			{
				label.Click += value2;
				label.MouseMove += value3;
				label.MouseLeave += value4;
				label.MouseDown += value5;
				label.MouseUp += value6;
			}
		}
	}

	internal virtual Label buttonRestart
	{
		[CompilerGenerated]
		get
		{
			return this.label_4;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_16);
			MouseEventHandler value3 = new MouseEventHandler(this.method_31);
			EventHandler value4 = new EventHandler(this.method_32);
			MouseEventHandler value5 = new MouseEventHandler(this.method_33);
			MouseEventHandler value6 = new MouseEventHandler(this.method_34);
			Label label = this.label_4;
			if (label != null)
			{
				label.Click -= value2;
				label.MouseMove -= value3;
				label.MouseLeave -= value4;
				label.MouseDown -= value5;
				label.MouseUp -= value6;
			}
			this.label_4 = value;
			label = this.label_4;
			if (label != null)
			{
				label.Click += value2;
				label.MouseMove += value3;
				label.MouseLeave += value4;
				label.MouseDown += value5;
				label.MouseUp += value6;
			}
		}
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return this.timer_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_35);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			this.timer_0 = value;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return this.timer_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_14);
			Timer timer = this.timer_1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			this.timer_1 = value;
			timer = this.timer_1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	public static string smethod_0()
	{
		return firstform.string_0;
	}

	public static string smethod_1()
	{
		return firstform.string_1;
	}

	public static bool smethod_2()
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
		catch (Exception ex)
		{
			result = false;
		}
		return result;
	}

	public static bool smethod_3(string string_3)
	{
		Guid guid = default(Guid);
		return Guid.TryParse(string_3, out guid);
	}

	public static string smethod_4()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Bolcorp");
		registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Bolcorp", true);
		if (registryKey.GetValue("hbid") == null || !firstform.smethod_3(registryKey.GetValue("hbid").ToString()))
		{
			registryKey.SetValue("hbid", Guid.NewGuid().ToString());
		}
		return registryKey.GetValue("hbid").ToString();
	}

	public static string smethod_5(string string_3, int int_0)
	{
		string result = "";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_3);
		httpWebRequest.Method = "GET";
		httpWebRequest.Timeout = int_0;
		try
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			result = streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (WebException ex)
		{
			if (ex.Status == WebExceptionStatus.Timeout)
			{
				result = "-1";
			}
			else
			{
				result = "-1";
			}
		}
		return result;
	}

	private static object smethod_6()
	{
		return Class2.Class1_0.FileSystem.FileExists(Environment.CurrentDirectory + "\\AxInterop.ShockwaveFlashObjects.dll");
	}

	private static object smethod_7()
	{
		return Class2.Class1_0.FileSystem.FileExists(Environment.CurrentDirectory + "\\Interop.ShockwaveFlashObjects.dll");
	}

	private void method_0()
	{
		this.method_11("https://bolcorp.icu/url.php?tag=AxInterop", Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "AxInterop.ShockwaveFlashObjects.dll"));
	}

	private void method_1()
	{
		this.method_11("https://bolcorp.icu/url.php?tag=Interop", Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Interop.ShockwaveFlashObjects.dll"));
	}

	public void method_2(string string_3)
	{
		try
		{
			Process.Start(string_3);
		}
		catch (Exception ex)
		{
			this.method_9("Bağlantı açılırken bir hata oluştu. Lütfen işletim sisteminiz için bir varsayılan tarayıcı seçiniz. \\n \\n URL: " + string_3, "Hata: URL");
		}
	}

	private void method_3()
	{
		try
		{
			RuntimeHelpers.GetObjectValue(new JavaScriptSerializer().Deserialize<object>("{ \"Not\":\"Ayıp di mi lan, utanmıyonuz mu pgiex abinizin kodlarını okumaya.\", \"age\":30, \"car\":null }"));
		}
		catch (Exception ex)
		{
			this.method_9("Json çözümleme sırasında bir hata oluştu. Lütfen bilgisayarınıza \"Net Framework 4.5 Runtime\" programını kurun. İndirme linkine yönlendiriliyorsunuz..", "Pgiex");
			this.method_2("https://bolcorp.icu/url.php?tag=dotnet-4.5");
		}
	}

	private bool method_4()
	{
		bool result;
		try
		{
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(new JavaScriptSerializer().Deserialize<object>(firstform.smethod_5("https://bolcorp.icu/program.php?name=" + firstform.smethod_0(), 10000))), new object[]
			{
				"lastVersion"
			}, null));
			if (Operators.CompareString(text, "-1", false) != 0 & !string.IsNullOrEmpty(text))
			{
				if (Operators.CompareString(text, firstform.smethod_1(), false) == 0)
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
				this.method_9("Sürüm kontrolü sırasında bir hata oluştu. \n\n Programdan çıkılıyor..", "Hata: Sürüm kontrolü");
				Application.Exit();
				result = false;
			}
		}
		catch (Exception ex)
		{
			this.method_9("Sürüm kontrolü sırasında bir hata oluştu. \n\n Programdan çıkılıyor..", "Hata: Sürüm kontrolü");
			Application.Exit();
			result = false;
		}
		return result;
	}

	private void method_5()
	{
		try
		{
			if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "PgiexClientUpdater.exe")))
			{
				File.Delete(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "PgiexClientUpdater.exe"));
			}
		}
		catch (Exception ex)
		{
		}
	}

	private void method_6()
	{
		try
		{
			object instance = new WebClient();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			object objectValue = RuntimeHelpers.GetObjectValue(new JavaScriptSerializer().Deserialize<object>(firstform.smethod_5("https://bolcorp.icu/program.php?name=" + firstform.smethod_0(), 10000)));
			Type type = null;
			string memberName = "DownloadFile";
			object[] array = new object[2];
			int num = 0;
			object obj = objectValue;
			object instance2 = obj;
			object[] array2 = new object[1];
			object obj2 = array2[0] = "updaterURL";
			array[num] = NewLateBinding.LateIndexGet(instance2, array2, null);
			array[1] = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "PgiexClientUpdater.exe");
			object[] array3 = array;
			string[] argumentNames = null;
			Type[] typeArguments = null;
			bool[] array4 = new bool[2];
			array4[0] = true;
			bool[] array5 = array4;
			NewLateBinding.LateCall(instance, type, memberName, array, argumentNames, typeArguments, array4, true);
			if (array5[0])
			{
				NewLateBinding.LateIndexSetComplex(obj, new object[]
				{
					obj2,
					array3[0]
				}, null, true, false);
			}
			this.Timer_1.Start();
		}
		catch (Exception ex)
		{
			this.method_9("Updater indirilemedi. Antivirüs programınızı devredışı bırakıp tekrar deneyin. \n\n Programdan çıkılıyor..", "Hata: Updater İndirilemedi");
			Application.Exit();
		}
	}

	private void method_7()
	{
		try
		{
			Process.Start("PgiexClientUpdater.exe");
		}
		catch (Exception ex)
		{
			this.method_9("Updater çalıştırılırken bir hata ile karşılaşıldı. Antivirüs programınızı devredışı bırakıp tekrar deneyin. \n\n Programdan çıkılıyor..", "Hata: Updater Açılamadı");
			Application.Exit();
		}
	}

	private object method_8()
	{
		object result;
		if (Path.GetDirectoryName(Application.ExecutablePath).Contains("\\AppData\\Local\\Temp"))
		{
			result = true;
		}
		else
		{
			result = false;
		}
		return result;
	}

	public void method_9(string string_3, string string_4 = "Pgiex")
	{
		MessageBox.Show(string_3, string_4, MessageBoxButtons.OK, MessageBoxIcon.None);
	}

	private void firstform_Load(object sender, EventArgs e)
	{
		this.method_18();
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		this.Timer_0.Start();
		GClass0.smethod_5();
		GClass0.smethod_2(GClass0.smethod_0());
		this.msgLabel.Location = new Point(157, 29);
	}

	public bool method_10()
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(new JavaScriptSerializer().Deserialize<object>(firstform.smethod_5("https://bolcorp.icu/program.php?name=" + firstform.smethod_0() + "&ver=" + firstform.smethod_1(), 5000)));
			"v" + firstform.smethod_1();
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, new object[]
			{
				"activeStatus"
			}, null), true, false))
			{
				return true;
			}
			this.method_21();
			return false;
		}
		catch (Exception ex)
		{
			this.method_21();
		}
		return false;
	}

	public void method_11(string string_3, string string_4)
	{
		try
		{
			new WebClient().DownloadFileAsync(new Uri(string_3), string_4);
		}
		catch (Exception ex)
		{
			Application.Exit();
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void method_13(object sender, EventArgs e)
	{
		try
		{
			this.method_6();
		}
		catch (Exception ex)
		{
			Interaction.MsgBox(RuntimeHelpers.GetObjectValue(GClass0.smethod_4("f0UpdaterNotFound")), MsgBoxStyle.SystemModal, "Pgiex Client");
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		this.Timer_1.Stop();
		this.method_7();
	}

	private void method_15(object sender, EventArgs e)
	{

	}

	private void method_16(object sender, EventArgs e)
	{
		Application.Restart();
	}

	private void method_17(object sender, EventArgs e)
	{
		if (Interaction.MsgBox(Operators.AddObject(firstform.smethod_4() + "\r\n", GClass0.smethod_4("f0WantCopyHWID")), MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Hile Bol HWID") == MsgBoxResult.Yes)
		{
			Clipboard.SetText(firstform.smethod_4());
			Interaction.MsgBox(RuntimeHelpers.GetObjectValue(GClass0.smethod_4("f0HWIDCopied")), MsgBoxStyle.SystemModal, "Hile Bol HWID");
		}
	}

	private void method_18()
	{
		this.msgLabel.Location = new Point(157, 29);
		this.msgLabel.Text = Conversions.ToString(GClass0.smethod_4("f0Connecting"));
		this.msgImage.Image = Class22.Bitmap_19;
		this.buttonExit.Text = Conversions.ToString(GClass0.smethod_4("f0CancelBtn"));
		this.buttonUpdate.Visible = false;
		this.buttonRun.Visible = false;
		this.buttonRestart.Visible = false;
	}

	private void method_19()
	{
		this.msgLabel.Location = new Point(157, 23);
		this.msgLabel.Text = Conversions.ToString(GClass0.smethod_4("f0adApprove"));
		this.msgImage.Image = Class22.Bitmap_17;
		this.buttonExit.Text = Conversions.ToString(GClass0.smethod_4("f0ExitBtn"));
		this.buttonRun.Location = this.buttonUpdate.Location;
		this.buttonUpdate.Visible = false;
		this.buttonRun.Visible = true;
		this.buttonRestart.Visible = false;
		this.buttonExit.Visible = true;
	}

	private void method_20()
	{
		this.msgLabel.Location = new Point(157, 23);
		this.msgLabel.Text = Conversions.ToString(GClass0.smethod_4("f0Banned"));
		this.msgImage.Image = Class22.Bitmap_18;
		this.buttonExit.Text = Conversions.ToString(GClass0.smethod_4("f0ExitBtn"));
		this.buttonUpdate.Visible = false;
		this.buttonRun.Visible = false;
		this.buttonRestart.Visible = false;
	}

	private void method_21()
	{
		this.msgLabel.Location = new Point(157, 23);
		this.msgLabel.Text = Conversions.ToString(GClass0.smethod_4("f0Error"));
		if (Class24.smethod_3())
		{
			this.method_9(Conversions.ToString(GClass0.smethod_4("f0ProxifierError")), "Connection Error");
		}
		this.msgImage.Image = Class22.Bitmap_20;
		this.buttonExit.Text = Conversions.ToString(GClass0.smethod_4("f0ExitBtn"));
		this.buttonUpdate.Visible = false;
		this.buttonRun.Visible = false;
		this.buttonRestart.Text = this.buttonRestart.Text;
		this.buttonRestart.Visible = true;
		this.buttonRestart.Location = this.buttonUpdate.Location;
	}

	private void method_22()
	{
		this.msgLabel.Location = new Point(157, 23);
		this.msgLabel.Text = Conversions.ToString(GClass0.smethod_4("f0UpdateMsg"));
		this.msgImage.Image = Class22.Bitmap_21;
		this.buttonExit.Text = Conversions.ToString(GClass0.smethod_4("f0ExitBtn"));
		this.buttonUpdate.Visible = true;
		this.buttonRun.Visible = false;
		this.buttonRestart.Visible = false;
	}

	private void method_23(object sender, MouseEventArgs e)
	{
		if (!this.bool_2)
		{
			this.buttonUpdate.Image = Class22.Bitmap_8;
			this.buttonRun.Image = Class22.Bitmap_8;
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		if (!this.bool_2)
		{
			this.buttonUpdate.Image = Class22.Bitmap_9;
			this.buttonRun.Image = Class22.Bitmap_9;
		}
	}

	private void method_25(object sender, MouseEventArgs e)
	{
		this.bool_2 = true;
		this.buttonUpdate.Image = Class22.Bitmap_7;
		this.buttonRun.Image = Class22.Bitmap_7;
	}

	private void method_26(object sender, MouseEventArgs e)
	{
		this.bool_2 = false;
		this.buttonUpdate.Image = Class22.Bitmap_9;
		this.buttonRun.Image = Class22.Bitmap_9;
	}

	private void method_27(object sender, MouseEventArgs e)
	{
		if (!this.bool_0)
		{
			this.buttonExit.Image = Class22.Bitmap_8;
		}
	}

	private void method_28(object sender, EventArgs e)
	{
		if (!this.bool_0)
		{
			this.buttonExit.Image = Class22.Bitmap_9;
		}
	}

	private void method_29(object sender, MouseEventArgs e)
	{
		this.bool_0 = true;
		this.buttonExit.Image = Class22.Bitmap_7;
	}

	private void method_30(object sender, MouseEventArgs e)
	{
		this.bool_0 = false;
		this.buttonExit.Image = Class22.Bitmap_9;
	}

	private void method_31(object sender, MouseEventArgs e)
	{
		if (!this.bool_1)
		{
			this.buttonRestart.Image = Class22.Bitmap_8;
		}
	}

	private void method_32(object sender, EventArgs e)
	{
		if (!this.bool_1)
		{
			this.buttonRestart.Image = Class22.Bitmap_9;
		}
	}

	private void method_33(object sender, MouseEventArgs e)
	{
		this.bool_1 = true;
		this.buttonRestart.Image = Class22.Bitmap_7;
	}

	private void method_34(object sender, MouseEventArgs e)
	{
		this.bool_1 = false;
		this.buttonRestart.Image = Class22.Bitmap_9;
	}

	private void method_35(object sender, EventArgs e)
	{
		this.Timer_0.Stop();
		this.method_3();
		if (!firstform.smethod_2())
		{
			this.method_9("Please check your internet connection.", "Error: Connection");
			this.method_21();
			return;
		}
		if (!Operators.ConditionalCompareObjectEqual(this.method_8(), false, false))
		{
			this.method_9("Please take the cheat out of the zip.", "Error: ZIP");
			Application.Exit();
			return;
		}
		if (!this.method_4())
		{
			this.method_22();
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(firstform.smethod_6(), false, false))
		{
			this.method_0();
		}
		if (Operators.ConditionalCompareObjectEqual(firstform.smethod_7(), false, false))
		{
			this.method_1();
		}
		this.method_5();
		if (this.method_10())
		{
			base.Hide();
			Class2.Class3_0.Form1_0.Show();
			return;
		}
		this.method_21();
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("buttonExit")]
	[CompilerGenerated]
	private Label label_0;

	[CompilerGenerated]
	[AccessedThroughProperty("buttonUpdate")]
	private Label label_1;

	[AccessedThroughProperty("msgImage")]
	[CompilerGenerated]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("msgLabel")]
	private Label label_2;

	[CompilerGenerated]
	[AccessedThroughProperty("buttonRun")]
	private Label label_3;

	[AccessedThroughProperty("buttonRestart")]
	[CompilerGenerated]
	private Label label_4;

	[AccessedThroughProperty("flow")]
	[CompilerGenerated]
	private Timer timer_0;

	[AccessedThroughProperty("openUpdaterTimer")]
	[CompilerGenerated]
	private Timer timer_1;

	private static string string_0;

	private static string string_1;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private string string_2;
}
