namespace PgiexClientUpdater
{
	//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PgiexClientUpdater.Form1));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Closer = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.PictureBox1.Image = global::PgiexClientUpdater.My.Resources.Resources.up;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(158, 158);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.ProgressBar1.Location = new global::System.Drawing.Point(47, 112);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(64, 16);
			this.ProgressBar1.Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
			this.ProgressBar1.TabIndex = 1;
			this.ProgressBar1.Value = 100;
			this.Timer1.Interval = 1;
			this.Closer.Enabled = true;
			this.Closer.Interval = 15000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(158, 158);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.PictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private global::System.ComponentModel.IContainer components;
	}
}
