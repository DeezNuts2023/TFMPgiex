using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AdApproveUpdater.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AdApproveUpdater
{
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
		Timer _Timer1;
		Timer _Closer;
		
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}
		private void DownloadFile(string url, string dest)
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(url)).GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			httpWebResponse.GetResponseStream();
			checked
			{
				byte[] array = new byte[(int)httpWebResponse.ContentLength + 1];
				FileStream fileStream = new FileStream(dest, FileMode.Create, FileAccess.Write);
				int i = 1;
				int num = 0;
				int offset = 0;
				while (i > 0)
				{
					i = responseStream.Read(array, offset, (int)(httpWebResponse.ContentLength - unchecked((long)num)));
					num = i + num;
					fileStream.Write(array, offset, i);
					offset = i;
				}
				fileStream.Flush();
				fileStream.Close();
				responseStream.Dispose();
			}
		}
		public void guncelSurumuIndir()
		{
			this.DownloadFile("https://raw.githubusercontent.com/hilebolonline/updates/master/AdApprove/ad_approve.exe", Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ad_approve.exe"));
		}
		public void guncelSurumuCalistir()
		{
			Process.Start(FileSystem.CurDir() + "/ad_approve.exe");
		}
		public void adApproveKapat()
		{
			Process[] processesByName = Process.GetProcessesByName("ad_approve");
			checked
			{
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Timer1.Start();
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.adApproveKapat();
				this.guncelSurumuIndir();
				this.guncelSurumuCalistir();
				Application.Exit();
			}
			catch (Exception ex)
			{
			}
		}
		private void Closer_Tick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual Timer Closer
		{
			[CompilerGenerated]
			get
			{
				return this._Closer;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Closer_Tick);
				Timer closer = this._Closer;
				if (closer != null)
				{
					closer.Tick -= value2;
				}
				this._Closer = value;
				closer = this._Closer;
				if (closer != null)
				{
					closer.Tick += value2;
				}
			}
		}
	}
}
