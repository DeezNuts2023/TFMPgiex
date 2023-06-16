namespace linkapprove
{
	public partial class FirstForm : global::System.Windows.Forms.Form
	{
		private global::System.ComponentModel.IContainer components;
		internal global::System.Windows.Forms.Label mevcutSurumLabel;
		internal global::System.Windows.Forms.Label AltLabel;
		internal global::System.Windows.Forms.Label TitleLabel;
		internal global::System.Windows.Forms.PictureBox owlImage;
		internal global::System.Windows.Forms.Label dotdot;
		internal global::System.Windows.Forms.Label exitLabel;
		private global::System.Windows.Forms.Timer redirectToForm2;
		private global::System.Windows.Forms.Timer flow;
		private global::System.Windows.Forms.Timer openUpdaterTimer;
		
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::linkapprove.FirstForm));
			this.mevcutSurumLabel = new global::System.Windows.Forms.Label();
			this.AltLabel = new global::System.Windows.Forms.Label();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.owlImage = new global::System.Windows.Forms.PictureBox();
			this.dotdot = new global::System.Windows.Forms.Label();
			this.exitLabel = new global::System.Windows.Forms.Label();
			this.redirectToForm2 = new global::System.Windows.Forms.Timer(this.components);
			this.flow = new global::System.Windows.Forms.Timer(this.components);
			this.openUpdaterTimer = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.owlImage).BeginInit();
			base.SuspendLayout();
			this.mevcutSurumLabel.BackColor = global::System.Drawing.Color.White;
			this.mevcutSurumLabel.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.mevcutSurumLabel.Location = new global::System.Drawing.Point(384, 132);
			this.mevcutSurumLabel.Name = "mevcutSurumLabel";
			this.mevcutSurumLabel.Size = new global::System.Drawing.Size(72, 17);
			this.mevcutSurumLabel.TabIndex = 9;
			this.mevcutSurumLabel.Text = "ver: 00";
			this.mevcutSurumLabel.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.AltLabel.BackColor = global::System.Drawing.Color.White;
			this.AltLabel.Font = new global::System.Drawing.Font("Microsoft YaHei", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.AltLabel.Location = new global::System.Drawing.Point(13, 109);
			this.AltLabel.Name = "AltLabel";
			this.AltLabel.Size = new global::System.Drawing.Size(444, 23);
			this.AltLabel.TabIndex = 12;
			this.AltLabel.Text = "internet bağlantısı kontrol ediliyor";
			this.AltLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabel.BackColor = global::System.Drawing.Color.White;
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft YaHei", 12.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.TitleLabel.Location = new global::System.Drawing.Point(13, 86);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(444, 23);
			this.TitleLabel.TabIndex = 11;
			this.TitleLabel.Text = "HİLEBOL";
			this.TitleLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.owlImage.BackColor = global::System.Drawing.Color.White;
			this.owlImage.Image = global::linkapprove.Properties.Resources.opening_owl;
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
			this.dotdot.Text = "•••";
			this.dotdot.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
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
			this.redirectToForm2.Interval = 1;
			this.redirectToForm2.Tick += new global::System.EventHandler(this.redirectToForm3_Tick);
			this.flow.Interval = 1;
			this.flow.Tick += new global::System.EventHandler(this.flow_Tick);
			this.openUpdaterTimer.Interval = 3000;
			this.openUpdaterTimer.Tick += new global::System.EventHandler(this.openUpdaterTimer_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::linkapprove.Properties.Resources.opening;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(468, 158);
			base.Controls.Add(this.exitLabel);
			base.Controls.Add(this.mevcutSurumLabel);
			base.Controls.Add(this.AltLabel);
			base.Controls.Add(this.TitleLabel);
			base.Controls.Add(this.owlImage);
			base.Controls.Add(this.dotdot);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FirstForm";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hile Bol - Ad Approve";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.owlImage).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
