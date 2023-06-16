using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AxShockwaveFlashObjects;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form2 : Form
{
	public Form2()
	{
		base..ctor();
		base.Load += this.Form2_Load;
		base.Closing += this.Form2_Closing;
		this.string_0 = "";
		this.string_1 = "";
		this.int_0 = 0;
		this.byte_0 = 0;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		this.TabControl1 = new TabControl();
		this.ContextMenuStrip1 = new ContextMenuStrip(this.icontainer_0);
		this.YeniSekmeToolStripMenuItem = new ToolStripMenuItem();
		this.YenileToolStripMenuItem = new ToolStripMenuItem();
		this.KapatToolStripMenuItem = new ToolStripMenuItem();
		this.ToolStripSeparator2 = new ToolStripSeparator();
		this.ToolStripMenuItem_0 = new ToolStripMenuItem();
		this.ToolStripSeparator1 = new ToolStripSeparator();
		this.AlignmentToolStripMenuItem = new ToolStripMenuItem();
		this.TopLeftToolStripMenuItem = new ToolStripMenuItem();
		this.TopToolStripMenuItem = new ToolStripMenuItem();
		this.TopRightToolStripMenuItem = new ToolStripMenuItem();
		this.LeftToolStripMenuItem = new ToolStripMenuItem();
		this.CenterToolStripMenuItem = new ToolStripMenuItem();
		this.RightToolStripMenuItem = new ToolStripMenuItem();
		this.BottomLeftToolStripMenuItem = new ToolStripMenuItem();
		this.BottomToolStripMenuItem = new ToolStripMenuItem();
		this.BottomRightToolStripMenuItem = new ToolStripMenuItem();
		this.UseChatCommandToolStripMenuItem = new ToolStripMenuItem();
		this.ToolStripTextBox1 = new ToolStripTextBox();
		this.UygulaToolStripMenuItem = new ToolStripMenuItem();
		this.ConfigToolStripMenuItem = new ToolStripMenuItem();
		this.ToolStripTextBox2 = new ToolStripTextBox();
		this.ToolStripMenuItem_1 = new ToolStripMenuItem();
		this.WebBrowser1 = new WebBrowser();
		this.WebBrowser2 = new WebBrowser();
		this.ContextMenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.ContextMenuStrip = this.ContextMenuStrip1;
		this.TabControl1.Dock = DockStyle.Fill;
		this.TabControl1.Location = new Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new Size(811, 631);
		this.TabControl1.TabIndex = 0;
		this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[]
		{
			this.YeniSekmeToolStripMenuItem,
			this.YenileToolStripMenuItem,
			this.KapatToolStripMenuItem,
			this.ToolStripSeparator2,
			this.ToolStripMenuItem_0,
			this.ToolStripSeparator1,
			this.AlignmentToolStripMenuItem,
			this.UseChatCommandToolStripMenuItem,
			this.ConfigToolStripMenuItem
		});
		this.ContextMenuStrip1.Name = "ContextMenuStrip1";
		this.ContextMenuStrip1.Size = new Size(181, 192);
		this.YeniSekmeToolStripMenuItem.Name = "YeniSekmeToolStripMenuItem";
		this.YeniSekmeToolStripMenuItem.Size = new Size(180, 22);
		this.YeniSekmeToolStripMenuItem.Text = "Yeni sekme";
		this.YenileToolStripMenuItem.Name = "YenileToolStripMenuItem";
		this.YenileToolStripMenuItem.Size = new Size(180, 22);
		this.YenileToolStripMenuItem.Text = "Yenile";
		this.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem";
		this.KapatToolStripMenuItem.Size = new Size(180, 22);
		this.KapatToolStripMenuItem.Text = "Kapat";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new Size(177, 6);
		this.ToolStripMenuItem_0.Name = "SWFGüncelleToolStripMenuItem";
		this.ToolStripMenuItem_0.Size = new Size(180, 22);
		this.ToolStripMenuItem_0.Text = "SWF Güncelle";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new Size(177, 6);
		this.AlignmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.TopLeftToolStripMenuItem,
			this.TopToolStripMenuItem,
			this.TopRightToolStripMenuItem,
			this.LeftToolStripMenuItem,
			this.CenterToolStripMenuItem,
			this.RightToolStripMenuItem,
			this.BottomLeftToolStripMenuItem,
			this.BottomToolStripMenuItem,
			this.BottomRightToolStripMenuItem
		});
		this.AlignmentToolStripMenuItem.Name = "AlignmentToolStripMenuItem";
		this.AlignmentToolStripMenuItem.Size = new Size(180, 22);
		this.AlignmentToolStripMenuItem.Text = "Alignment";
		this.TopLeftToolStripMenuItem.Name = "TopLeftToolStripMenuItem";
		this.TopLeftToolStripMenuItem.Size = new Size(142, 22);
		this.TopLeftToolStripMenuItem.Text = "TopLeft";
		this.TopToolStripMenuItem.Name = "TopToolStripMenuItem";
		this.TopToolStripMenuItem.Size = new Size(142, 22);
		this.TopToolStripMenuItem.Text = "Top";
		this.TopRightToolStripMenuItem.Name = "TopRightToolStripMenuItem";
		this.TopRightToolStripMenuItem.Size = new Size(142, 22);
		this.TopRightToolStripMenuItem.Text = "TopRight";
		this.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem";
		this.LeftToolStripMenuItem.Size = new Size(142, 22);
		this.LeftToolStripMenuItem.Text = "Left";
		this.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem";
		this.CenterToolStripMenuItem.Size = new Size(142, 22);
		this.CenterToolStripMenuItem.Text = "Center";
		this.RightToolStripMenuItem.Name = "RightToolStripMenuItem";
		this.RightToolStripMenuItem.Size = new Size(142, 22);
		this.RightToolStripMenuItem.Text = "Right";
		this.BottomLeftToolStripMenuItem.Name = "BottomLeftToolStripMenuItem";
		this.BottomLeftToolStripMenuItem.Size = new Size(142, 22);
		this.BottomLeftToolStripMenuItem.Text = "BottomLeft";
		this.BottomToolStripMenuItem.Name = "BottomToolStripMenuItem";
		this.BottomToolStripMenuItem.Size = new Size(142, 22);
		this.BottomToolStripMenuItem.Text = "Bottom";
		this.BottomRightToolStripMenuItem.Name = "BottomRightToolStripMenuItem";
		this.BottomRightToolStripMenuItem.Size = new Size(142, 22);
		this.BottomRightToolStripMenuItem.Text = "BottomRight";
		this.UseChatCommandToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.ToolStripTextBox1,
			this.UygulaToolStripMenuItem
		});
		this.UseChatCommandToolStripMenuItem.Name = "UseChatCommandToolStripMenuItem";
		this.UseChatCommandToolStripMenuItem.Size = new Size(180, 22);
		this.UseChatCommandToolStripMenuItem.Text = "Komut";
		this.ToolStripTextBox1.Font = new Font("Segoe UI", 9f);
		this.ToolStripTextBox1.Name = "ToolStripTextBox1";
		this.ToolStripTextBox1.Size = new Size(100, 23);
		this.ToolStripTextBox1.Text = "/room example1";
		this.UygulaToolStripMenuItem.Name = "UygulaToolStripMenuItem";
		this.UygulaToolStripMenuItem.Size = new Size(209, 22);
		this.UygulaToolStripMenuItem.Text = "Tüm sekmeler için uygula";
		this.ConfigToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.ToolStripTextBox2,
			this.ToolStripMenuItem_1
		});
		this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
		this.ConfigToolStripMenuItem.Size = new Size(180, 22);
		this.ConfigToolStripMenuItem.Text = "Config";
		this.ToolStripTextBox2.Font = new Font("Segoe UI", 9f);
		this.ToolStripTextBox2.Name = "ToolStripTextBox2";
		this.ToolStripTextBox2.Size = new Size(100, 23);
		this.ToolStripTextBox2.Text = "<Config>";
		this.ToolStripMenuItem_1.Name = "TümSekmelerİçinUygulaToolStripMenuItem";
		this.ToolStripMenuItem_1.Size = new Size(209, 22);
		this.ToolStripMenuItem_1.Text = "Tüm sekmeler için uygula";
		this.WebBrowser1.Location = new Point(98, -25);
		this.WebBrowser1.MinimumSize = new Size(20, 20);
		this.WebBrowser1.Name = "WebBrowser1";
		this.WebBrowser1.ScriptErrorsSuppressed = true;
		this.WebBrowser1.Size = new Size(20, 20);
		this.WebBrowser1.TabIndex = 1;
		this.WebBrowser1.Visible = false;
		this.WebBrowser2.Location = new Point(138, -27);
		this.WebBrowser2.MinimumSize = new Size(20, 20);
		this.WebBrowser2.Name = "WebBrowser2";
		this.WebBrowser2.ScriptErrorsSuppressed = true;
		this.WebBrowser2.Size = new Size(20, 20);
		this.WebBrowser2.TabIndex = 2;
		this.WebBrowser2.Visible = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(811, 631);
		base.Controls.Add(this.WebBrowser2);
		base.Controls.Add(this.WebBrowser1);
		base.Controls.Add(this.TabControl1);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "Form2";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Pgiex Client";
		this.ContextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}


	internal virtual TabControl TabControl1
	{
		[CompilerGenerated]
		get
		{
			return this.tabControl_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.tabControl_0 = value;
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		[CompilerGenerated]
		get
		{
			return this.webBrowser_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			WebBrowserDocumentCompletedEventHandler value2 = new WebBrowserDocumentCompletedEventHandler(this.method_16);
			WebBrowser webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.DocumentCompleted -= value2;
			}
			this.webBrowser_0 = value;
			webBrowser = this.webBrowser_0;
			if (webBrowser != null)
			{
				webBrowser.DocumentCompleted += value2;
			}
		}
	}

	internal virtual WebBrowser WebBrowser2
	{
		[CompilerGenerated]
		get
		{
			return this.webBrowser_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.webBrowser_1 = value;
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[CompilerGenerated]
		get
		{
			return this.contextMenuStrip_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.contextMenuStrip_0 = value;
		}
	}
	
	internal virtual ToolStripMenuItem YeniSekmeToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_2);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_0 = value;
			toolStripMenuItem = this.toolStripMenuItem_0;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem YenileToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_4);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_1 = value;
			toolStripMenuItem = this.toolStripMenuItem_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem KapatToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_2;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_5);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_2 = value;
			toolStripMenuItem = this.toolStripMenuItem_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripSeparator_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripSeparator_0 = value;
		}
	}

	internal virtual ToolStripMenuItem AlignmentToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_3;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripMenuItem_3 = value;
		}
	}

	internal virtual ToolStripMenuItem TopLeftToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_4;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_7);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_4 = value;
			toolStripMenuItem = this.toolStripMenuItem_4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem TopToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_5;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_8);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_5 = value;
			toolStripMenuItem = this.toolStripMenuItem_5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem TopRightToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_6;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_9);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_6 = value;
			toolStripMenuItem = this.toolStripMenuItem_6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem LeftToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_7;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_10);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_7 = value;
			toolStripMenuItem = this.toolStripMenuItem_7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CenterToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_8;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_11);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_8 = value;
			toolStripMenuItem = this.toolStripMenuItem_8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RightToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_9;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_12);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_9 = value;
			toolStripMenuItem = this.toolStripMenuItem_9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem BottomLeftToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_10;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_13);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_10 = value;
			toolStripMenuItem = this.toolStripMenuItem_10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem BottomToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_11;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_14);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_11 = value;
			toolStripMenuItem = this.toolStripMenuItem_11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem BottomRightToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_12;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_15);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_12 = value;
			toolStripMenuItem = this.toolStripMenuItem_12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}
	
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripSeparator_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripSeparator_1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem_0
	{
		[CompilerGenerated]
		get
		{
	
			return this.toolStripMenuItem_13;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_17);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_13 = value;
			toolStripMenuItem = this.toolStripMenuItem_13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem UseChatCommandToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_14;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripMenuItem_14 = value;
		}
	}

	internal virtual ToolStripMenuItem UygulaToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_15;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_21);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_15;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_15 = value;
			toolStripMenuItem = this.toolStripMenuItem_15;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ConfigToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_16;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripMenuItem_16 = value;
		}
	}

	internal virtual ToolStripTextBox ToolStripTextBox1
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripTextBox_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripTextBox_0 = value;
		}
	}

	internal virtual ToolStripTextBox ToolStripTextBox2
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripTextBox_1;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			this.toolStripTextBox_1 = value;
		}
	}
	
	internal virtual ToolStripMenuItem ToolStripMenuItem_1
	{
		[CompilerGenerated]
		get
		{
			return this.toolStripMenuItem_17;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
	
			EventHandler value2 = new EventHandler(this.method_22);
			ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_17;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			this.toolStripMenuItem_17 = value;
			toolStripMenuItem = this.toolStripMenuItem_17;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	private void method_0()
	{
		try
		{
			this.byte_0 = checked((byte)this.TabControl1.SelectedIndex);
			this.WebBrowser1.Navigate(new Uri("http://checkip.dyndns.org"));
		}
		catch (Exception ex)
		{
		}
	}

	private void method_1()
	{
		checked
		{
			try
			{
				int tabCount = this.TabControl1.TabCount;
				for (int i = 0; i <= tabCount; i++)
				{
					if (this.TabControl1.TabPages[i].Text.Contains("["))
					{
						if (i >= 9)
						{
							this.TabControl1.TabPages[i].Text = this.TabControl1.TabPages[i].Text.Replace(this.TabControl1.TabPages[i].Text.Substring(0, 5), "");
						}
						else
						{
							this.TabControl1.TabPages[i].Text = this.TabControl1.TabPages[i].Text.Replace(this.TabControl1.TabPages[i].Text.Substring(0, 4), "");
						}
					}
					this.TabControl1.TabPages[i].Text = "[" + Conversions.ToString(i + 1) + "] " + this.TabControl1.TabPages[i].Text;
				}
			}
			catch (Exception ex)
			{
			}
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				Class2.Class3_0.Form1_0.Hide();
				if (!Directory.Exists(Conversions.ToString(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
				{
					"swfLocation"
				}, null))))
				{
					Directory.CreateDirectory(Conversions.ToString(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
					{
						"swfLocation"
					}, null)));
				}
				if (!(File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
				{
					"swfLocation"
				}, null), "\\Chargeur"), this.string_1), ".swf"))) & File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
				{
					"swfLocation"
				}, null), "\\"), this.string_1), ".swf")))))
				{
					if (Operators.CompareString(this.string_1, "Transformice", false) == 0)
					{
						this.method_18();
						if (!File.Exists("C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe"))
						{
							Class24.smethod_2("https://transformice.bolcorp.icu/App/exe/Updater.exe", "C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe");
						}
						else
						{
							Interaction.Shell("C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe", AppWinStyle.NormalFocus, false, -1);
						}
					}
					else
					{
						this.YeniSekmeToolStripMenuItem.Enabled = false;
						this.YenileToolStripMenuItem.Enabled = false;
						Class24.bool_0 = true;
						this.method_18();
						object instance = NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
						{
							"privateUpdate"
						}, null);
						Type type = null;
						string memberName = "replace";
						object[] array = new object[2];
						array[0] = "{0}";
						int num = 1;
						ref string ptr = ref this.string_1;
						array[num] = this.string_1;
						object[] array2 = array;
						bool[] array3;
						object instance2 = NewLateBinding.LateGet(instance, type, memberName, array, null, null, array3 = new bool[]
						{
							default(bool),
							true
						});
						if (array3[1])
						{
							ptr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						Class24.smethod_2(Conversions.ToString(NewLateBinding.LateGet(instance2, null, "replace", new object[]
						{
							"{1}",
							"Chargeur" + this.string_1
						}, null, null, null)), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
						{
							"swfLocation"
						}, null), "\\Chargeur"), this.string_1), ".swf")));
						object instance3 = NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
						{
							"privateUpdate"
						}, null);
						Type type2 = null;
						string memberName2 = "replace";
						object[] array4 = new object[2];
						array4[0] = "{0}";
						int num2 = 1;
						ref string ptr2 = ref this.string_1;
						array4[num2] = this.string_1;
						object[] array5 = array4;
						bool[] array6;
						object instance4 = NewLateBinding.LateGet(instance3, type2, memberName2, array4, null, null, array6 = new bool[]
						{
							default(bool),
							true
						});
						if (array6[1])
						{
							ptr2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(string));
						}
						Type type3 = null;
						string memberName3 = "replace";
						object[] array7 = new object[2];
						array7[0] = "{1}";
						int num3 = 1;
						ptr = ref this.string_1;
						array7[num3] = this.string_1;
						array2 = array7;
						object value = NewLateBinding.LateGet(instance4, type3, memberName3, array7, null, null, array3 = new bool[]
						{
							default(bool),
							true
						});
						if (array3[1])
						{
							ptr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						Class24.smethod_2(Conversions.ToString(value), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
						{
							"swfLocation"
						}, null), "\\"), this.string_1), ".swf")));
					}
				}
				else
				{
					try
					{
						if (Operators.CompareString(this.string_1, "Dressroom", false) == 0)
						{
							base.Width += 120;
							base.Location = new Point(base.Location.X - 55, base.Location.Y);
							this.ContextMenuStrip1.Items.Remove(this.ContextMenuStrip1.Items[8]);
							this.ContextMenuStrip1.Items.Remove(this.ContextMenuStrip1.Items[7]);
							this.ContextMenuStrip1.Items.Remove(this.ContextMenuStrip1.Items[4]);
							this.ContextMenuStrip1.Items.Remove(this.ContextMenuStrip1.Items[3]);
						}
					}
					catch (Exception ex)
					{
					}
					this.method_18();
					if (Class23.MySettings_0.ShowIP)
					{
						this.method_0();
					}
					this.method_1();
				}
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox("Activex error. Try AIR version.", MsgBoxStyle.SystemModal, "Activex ERROR");
				Application.Exit();
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (this.TabControl1.TabPages.Count == 6)
		{
			Interaction.MsgBox(RuntimeHelpers.GetObjectValue(GClass0.smethod_4("msgTabWarning")), MsgBoxStyle.SystemModal, "Pgiex Client");
		}
		this.method_18();
		if (Class23.MySettings_0.ShowIP)
		{
			this.method_0();
		}
		this.method_1();
	}

	private void method_3(object object_0, _IShockwaveFlashEvents_FlashCallEvent _IShockwaveFlashEvents_FlashCallEvent_0)
	{
		try
		{
			NewLateBinding.LateCall(object_0, null, "CallFunction", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject("<invoke name=\"SetIncorrect\"returntype=\"xml\"><arguments><string>", GClass0.smethod_4("msgIncorrect")), "</string></arguments></invoke>")
			}, null, null, null, true);
		}
		catch (Exception ex)
		{
		}
		try
		{
			Conversions.ToString(NewLateBinding.LateGet(object_0, null, "CallFunction", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<invoke name=\"setPluginAdress\"returntype=\"xml\"><arguments><string>", NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
				{
					"pluginAdress"
				}, null)), Class24.smethod_7(Conversions.ToString(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
				{
					"settings"
				}, null)))), "</string></arguments></invoke>")
			}, null, null, null));
		}
		catch (Exception ex2)
		{
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"function(){return navigator.appVersion+'-'+navigator.appName;}\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>5.0 (Windows)-Netscape</string>"
			}, null, null, null, true);
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"hwid\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>" + firstform.smethod_4() + "</string>"
			}, null, null, null, true);
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"Check\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>642fff95-0b3d-4b51-89c8-962da4775d3e</string>"
			}, null, null, null, true);
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"Check1\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>" + Conversions.ToString(Class24.bool_1) + "</string>"
			}, null, null, null, true);
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"getSteamId\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>1010101010</string>"
			}, null, null, null, true);
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"navigateur\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>chargeur-electron</string>"
			}, null, null, null, true);
		}
		if (_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString().Contains("defActiviteDiscord") | _IShockwaveFlashEvents_FlashCallEvent_0.request.ToString().Contains("window.location.href.toString"))
		{
			NewLateBinding.LateCall(object_0, null, "SetReturnValue", new object[]
			{
				"<string>http://transformice.com/</string>"
			}, null, null, null, true);
		}
		if (Operators.CompareString(_IShockwaveFlashEvents_FlashCallEvent_0.request.ToString(), "<invoke name=\"Exit\" returntype=\"xml\"><arguments></arguments></invoke>", false) == 0)
		{
			Application.Exit();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		this.method_20();
	}

	private void method_5(object sender, EventArgs e)
	{
		this.method_19();
	}

	private void method_6(ref int int_1)
	{
		try
		{
			((AxShockwaveFlash)this.TabControl1.SelectedTab.Controls[0]).AlignMode = int_1;
		}
		catch (Exception ex)
		{
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		int num = 5;
		this.method_6(ref num);
	}

	private void method_8(object sender, EventArgs e)
	{

		int num = 4;
		this.method_6(ref num);
	}

	private void method_9(object sender, EventArgs e)
	{

		int num = 6;
		this.method_6(ref num);
	}

	private void method_10(object sender, EventArgs e)
	{
		int num = 1;
		this.method_6(ref num);
	}

	private void method_11(object sender, EventArgs e)
	{
		int num = 0;
		this.method_6(ref num);
	}

	private void method_12(object sender, EventArgs e)
	{
		int num = 2;
		this.method_6(ref num);
	}

	private void method_13(object sender, EventArgs e)
	{
		int num = 9;
		this.method_6(ref num);
	}

	private void method_14(object sender, EventArgs e)
	{
		int num = 8;
		this.method_6(ref num);
	}

	private void method_15(object sender, EventArgs e)
	{
		int num = 10;
		this.method_6(ref num);
	}

	private void method_16(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (Operators.CompareString(this.string_1, "Dressroom", false) != 0)
		{
			try
			{
				if (new Regex("\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b").Match(this.WebBrowser1.DocumentText).ToString().Length >= 5)
				{
					this.TabControl1.TabPages[(int)this.byte_0].Text = new Regex("\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b").Match(this.WebBrowser1.DocumentText).ToString();
				}
				else
				{
					this.TabControl1.TabPages[(int)this.byte_0].Text = this.string_1;
				}
				this.method_1();
			}
			catch (Exception ex)
			{
			}
		}
	}

	private void Form2_Closing(object sender, CancelEventArgs e)
	{
		Class2.Class3_0.Form1_0.Show();
	}

	private void method_17(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.string_1, "Transformice", false) != 0)
		{
			this.YeniSekmeToolStripMenuItem.Enabled = false;
			this.YenileToolStripMenuItem.Enabled = false;
			object instance = NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"privateUpdate"
			}, null);
			Type type = null;
			string memberName = "replace";
			object[] array = new object[2];
			array[0] = "{0}";
			int num = 1;
			ref string ptr = ref this.string_1;
			array[num] = this.string_1;
			object[] array2 = array;
			bool[] array3;
			object instance2 = NewLateBinding.LateGet(instance, type, memberName, array, null, null, array3 = new bool[]
			{
				default(bool),
				true
			});
			if (array3[1])
			{
				ptr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
			}
			Class24.smethod_2(Conversions.ToString(NewLateBinding.LateGet(instance2, null, "replace", new object[]
			{
				"{1}",
				"Chargeur" + this.string_1
			}, null, null, null)), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"swfLocation"
			}, null), "\\Chargeur"), this.string_1), ".swf")));
			object instance3 = NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"privateUpdate"
			}, null);
			Type type2 = null;
			string memberName2 = "replace";
			object[] array4 = new object[2];
			array4[0] = "{0}";
			int num2 = 1;
			ref string ptr2 = ref this.string_1;
			array4[num2] = this.string_1;
			object[] array5 = array4;
			bool[] array6;
			object instance4 = NewLateBinding.LateGet(instance3, type2, memberName2, array4, null, null, array6 = new bool[]
			{
				default(bool),
				true
			});
			if (array6[1])
			{
				ptr2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(string));
			}
			Type type3 = null;
			string memberName3 = "replace";
			object[] array7 = new object[2];
			array7[0] = "{1}";
			int num3 = 1;
			ptr = ref this.string_1;
			array7[num3] = this.string_1;
			array2 = array7;
			object value = NewLateBinding.LateGet(instance4, type3, memberName3, array7, null, null, array3 = new bool[]
			{
				default(bool),
				true
			});
			if (array3[1])
			{
				ptr = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
			}
			Class24.smethod_2(Conversions.ToString(value), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"swfLocation"
			}, null), "\\"), this.string_1), ".swf")));
			return;
		}
		if (!File.Exists("C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe"))
		{
			Class24.smethod_2("https://transformice.bolcorp.icu/App/exe/Updater.exe", "C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe");
			return;
		}
		Interaction.Shell("C:\\" + firstform.smethod_4() + "\\Pgiex - Transformice SWF Updater.exe", AppWinStyle.NormalFocus, false, -1);
	}

	private void method_18()
	{
		AxShockwaveFlash axShockwaveFlash = new AxShockwaveFlash();
		if (Operators.CompareString(this.string_1, "Dressroom", false) != 0)
		{
			axShockwaveFlash.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(this.method_3);
		}
		this.TabControl1.TabPages.Add(this.string_1);
		this.TabControl1.SelectTab(this.int_0);
		this.TabControl1.SelectedTab.Name = "tabpage" + Conversions.ToString(this.int_0);
		axShockwaveFlash.Name = this.string_1;
		axShockwaveFlash.Dock = DockStyle.Fill;
		this.TabControl1.SelectedTab.Controls.Add(axShockwaveFlash);
		checked
		{
			this.int_0++;
			axShockwaveFlash.LoadMovie(0, this.string_0 + Class24.smethod_7(Conversions.ToString(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"settings"
			}, null))));
		}
	}

	private void method_19()
	{
		checked
		{
			if (this.TabControl1.TabPages.Count != 1)
			{
				try
				{
					((AxShockwaveFlash)this.TabControl1.SelectedTab.Controls[0]).Movie = "";
					((AxShockwaveFlash)this.TabControl1.SelectedTab.Controls[0]).LoadMovie(0, "aasd");
					((AxShockwaveFlash)this.TabControl1.SelectedTab.Controls[0]).Dispose();
					this.TabControl1.SelectedTab.Controls.Clear();
					this.TabControl1.TabPages.RemoveAt(this.TabControl1.SelectedIndex);
					this.TabControl1.SelectTab(this.TabControl1.TabPages.Count - 1);
					this.int_0--;
					this.method_1();
				}
				catch (Exception ex)
				{
				}
			}
		}
	}

	public void method_20()
	{
		try
		{
			((AxShockwaveFlash)this.TabControl1.SelectedTab.Controls[0]).Dispose();
			this.TabControl1.SelectedTab.Controls.Clear();
			AxShockwaveFlash axShockwaveFlash = new AxShockwaveFlash();
			if (Operators.CompareString(this.string_1, "Dressroom", false) != 0)
			{
				axShockwaveFlash.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(this.method_3);
			}
			axShockwaveFlash.Dock = DockStyle.Fill;
			this.TabControl1.SelectedTab.Controls.Add(axShockwaveFlash);
			axShockwaveFlash.LoadMovie(0, this.string_0 + Class24.smethod_7(Conversions.ToString(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"settings"
			}, null))));
			((AxShockwaveFlash)this.TabControl1.SelectedTab.Controls[0]).LoadMovie(0, this.string_0 + Class24.smethod_7(Conversions.ToString(NewLateBinding.LateIndexGet(Class2.Class3_0.Form1_0.object_0, new object[]
			{
				"settings"
			}, null))));
			if (Class23.MySettings_0.ShowIP)
			{
				this.method_0();
			}
			this.method_1();
		}
		catch (Exception ex)
		{
		}
	}

	private void method_21(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string str = this.ToolStripTextBox1.Text;
				if (Operators.CompareString(this.ToolStripTextBox1.Text.Substring(0, 1), "/", false) == 0)
				{
					str = this.ToolStripTextBox1.Text.Substring(1);
				}
				int tabCount = this.TabControl1.TabCount;
				for (int i = 0; i <= tabCount; i++)
				{
					try
					{
						((AxShockwaveFlash)this.TabControl1.TabPages[i].Controls[0]).CallFunction("<invoke name=\"fromOut\"returntype=\"xml\"><arguments><string>chatCommand###" + str + "</string></arguments></invoke>");
					}
					catch (Exception ex)
					{
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}
	}

	private void method_22(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string text = this.ToolStripTextBox2.Text;
				int tabCount = this.TabControl1.TabCount;
				for (int i = 0; i <= tabCount; i++)
				{
					try
					{
						((AxShockwaveFlash)this.TabControl1.TabPages[i].Controls[0]).CallFunction("<invoke name=\"fromOut\"returntype=\"xml\"><arguments><string>setConfig###" + text + "</string></arguments></invoke>");
					}
					catch (Exception ex)
					{
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("TabControl1")]
	[CompilerGenerated]
	private TabControl tabControl_0;

	[AccessedThroughProperty("WebBrowser1")]
	[CompilerGenerated]
	private WebBrowser webBrowser_0;

	[AccessedThroughProperty("WebBrowser2")]
	[CompilerGenerated]
	private WebBrowser webBrowser_1;

	[AccessedThroughProperty("ContextMenuStrip1")]
	[CompilerGenerated]
	private ContextMenuStrip contextMenuStrip_0;

	[CompilerGenerated]
	[AccessedThroughProperty("YeniSekmeToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_0;

	[CompilerGenerated]
	[AccessedThroughProperty("YenileToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_1;

	[CompilerGenerated]
	[AccessedThroughProperty("KapatToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_2;

	[AccessedThroughProperty("ToolStripSeparator1")]
	[CompilerGenerated]
	private ToolStripSeparator toolStripSeparator_0;

	[AccessedThroughProperty("AlignmentToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem toolStripMenuItem_3;

	[CompilerGenerated]
	[AccessedThroughProperty("TopLeftToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_4;

	[AccessedThroughProperty("TopToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem toolStripMenuItem_5;

	[AccessedThroughProperty("TopRightToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem toolStripMenuItem_6;

	[CompilerGenerated]
	[AccessedThroughProperty("LeftToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_7;

	[AccessedThroughProperty("CenterToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem toolStripMenuItem_8;

	[CompilerGenerated]
	[AccessedThroughProperty("RightToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_9;

	[AccessedThroughProperty("BottomLeftToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem toolStripMenuItem_10;

	[AccessedThroughProperty("BottomToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem toolStripMenuItem_11;

	[CompilerGenerated]
	[AccessedThroughProperty("BottomRightToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_12;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator toolStripSeparator_1;

	[CompilerGenerated]
	[AccessedThroughProperty("SWFGüncelleToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_13;

	[CompilerGenerated]
	[AccessedThroughProperty("UseChatCommandToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_14;

	[CompilerGenerated]
	[AccessedThroughProperty("UygulaToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_15;

	[CompilerGenerated]
	[AccessedThroughProperty("ConfigToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_16;

	[AccessedThroughProperty("ToolStripTextBox1")]
	[CompilerGenerated]
	private ToolStripTextBox toolStripTextBox_0;

	[AccessedThroughProperty("ToolStripTextBox2")]
	[CompilerGenerated]
	private ToolStripTextBox toolStripTextBox_1;

	[CompilerGenerated]
	[AccessedThroughProperty("TümSekmelerİçinUygulaToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_17;

	public string string_0;
	public string string_1;
	public int int_0;
	private byte byte_0;
}
