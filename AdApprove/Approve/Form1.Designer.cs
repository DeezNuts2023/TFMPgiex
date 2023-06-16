namespace Approve
{
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		private global::System.ComponentModel.IContainer components;
		internal global::System.Windows.Forms.Label mevcutSurumLabel;
		internal global::System.Windows.Forms.Label AltLabel;
		internal global::System.Windows.Forms.Label TitleLabel;
		internal global::System.Windows.Forms.PictureBox owlImage;
		internal global::System.Windows.Forms.Label dotdot;
		internal global::System.Windows.Forms.Label hwidLabel;
		private global::System.Windows.Forms.Timer closeProgram;
		private global::System.Windows.Forms.Timer redirectToForm2;
		private global::System.Windows.Forms.Timer runGo;
		internal global::System.Windows.Forms.Label exitLabel;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Approve.Form1));
			this.mevcutSurumLabel = new global::System.Windows.Forms.Label();
			this.AltLabel = new global::System.Windows.Forms.Label();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.owlImage = new global::System.Windows.Forms.PictureBox();
			this.dotdot = new global::System.Windows.Forms.Label();
			this.hwidLabel = new global::System.Windows.Forms.Label();
			this.closeProgram = new global::System.Windows.Forms.Timer(this.components);
			this.redirectToForm2 = new global::System.Windows.Forms.Timer(this.components);
			this.runGo = new global::System.Windows.Forms.Timer(this.components);
			this.exitLabel = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.owlImage).BeginInit();
			base.SuspendLayout();
			this.mevcutSurumLabel.BackColor = global::System.Drawing.Color.White;
			this.mevcutSurumLabel.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.mevcutSurumLabel.Location = new global::System.Drawing.Point(409, 132);
			this.mevcutSurumLabel.Name = "mevcutSurumLabel";
			this.mevcutSurumLabel.Size = new global::System.Drawing.Size(47, 17);
			this.mevcutSurumLabel.TabIndex = 9;
			this.mevcutSurumLabel.Text = "ver: 00";
			this.mevcutSurumLabel.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.AltLabel.BackColor = global::System.Drawing.Color.White;
			this.AltLabel.Font = new global::System.Drawing.Font("Microsoft YaHei", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.AltLabel.Location = new global::System.Drawing.Point(13, 109);
			this.AltLabel.Name = "AltLabel";
			this.AltLabel.Size = new global::System.Drawing.Size(444, 23);
			this.AltLabel.TabIndex = 12;
			this.AltLabel.Text = "Alt Title";
			this.AltLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabel.BackColor = global::System.Drawing.Color.White;
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft YaHei", 12.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.TitleLabel.Location = new global::System.Drawing.Point(13, 86);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(444, 23);
			this.TitleLabel.TabIndex = 11;
			this.TitleLabel.Text = "Title";
			this.TitleLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.owlImage.BackColor = global::System.Drawing.Color.White;
			this.owlImage.Image = global::Approve.Properties.Resources.opening_owl;
			this.owlImage.Location = new global::System.Drawing.Point(193, 16);
			this.owlImage.Name = "owlImage";
			this.owlImage.Size = new global::System.Drawing.Size(83, 62);
			this.owlImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.owlImage.TabIndex = 10;
			this.owlImage.TabStop = false;
			this.dotdot.BackColor = global::System.Drawing.Color.White;
			this.dotdot.Font = new global::System.Drawing.Font("Microsoft YaHei", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.dotdot.Location = new global::System.Drawing.Point(13, 128);
			this.dotdot.Name = "dotdot";
			this.dotdot.Size = new global::System.Drawing.Size(444, 23);
			this.dotdot.TabIndex = 13;
			this.dotdot.Text = "••••";
			this.dotdot.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.hwidLabel.AutoSize = true;
			this.hwidLabel.BackColor = global::System.Drawing.Color.White;
			this.hwidLabel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.hwidLabel.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 162);
			this.hwidLabel.Location = new global::System.Drawing.Point(14, 132);
			this.hwidLabel.Name = "hwidLabel";
			this.hwidLabel.Size = new global::System.Drawing.Size(35, 17);
			this.hwidLabel.TabIndex = 14;
			this.hwidLabel.Text = "hwid";
			this.hwidLabel.Click += new global::System.EventHandler(this._72645668924764931256477);
			this.closeProgram.Interval = 1000;
			this.closeProgram.Tick += new global::System.EventHandler(this.closeProgram_Tick);
			this.redirectToForm2.Interval = 1000;
			this.redirectToForm2.Tick += new global::System.EventHandler(this.redirectToForm2_Tick);
			this.runGo.Interval = 1;
			this.runGo.Tick += new global::System.EventHandler(this._549659219451);
			this.exitLabel.AutoSize = true;
			this.exitLabel.BackColor = global::System.Drawing.Color.White;
			this.exitLabel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.exitLabel.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.exitLabel.Location = new global::System.Drawing.Point(441, 9);
			this.exitLabel.Name = "exitLabel";
			this.exitLabel.Size = new global::System.Drawing.Size(16, 17);
			this.exitLabel.TabIndex = 15;
			this.exitLabel.Text = "X";
			this.exitLabel.Click += new global::System.EventHandler(this.exitLabel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Approve.Properties.Resources.opening;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(468, 158);
			base.Controls.Add(this.exitLabel);
			base.Controls.Add(this.hwidLabel);
			base.Controls.Add(this.mevcutSurumLabel);
			base.Controls.Add(this.AltLabel);
			base.Controls.Add(this.TitleLabel);
			base.Controls.Add(this.owlImage);
			base.Controls.Add(this.dotdot);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hile Bol - Ad Approve";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this._8554774816617277291255563794641);
			((global::System.ComponentModel.ISupportInitialize)this.owlImage).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
