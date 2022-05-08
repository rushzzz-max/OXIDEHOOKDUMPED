namespace PHLoader
{
	// Token: 0x02000004 RID: 4
	public partial class LoginForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002148 File Offset: 0x00000348
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002624 File Offset: 0x00000824
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PHLoader.LoginForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			base.SuspendLayout();
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 17.25f);
			this.label1.ForeColor = global::System.Drawing.Color.Transparent;
			this.label1.Location = new global::System.Drawing.Point(50, 134);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(290, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Checking for updates...";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.progressBar1.Location = new global::System.Drawing.Point(12, 170);
			this.progressBar1.MarqueeAnimationSpeed = 50;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.progressBar1.Size = new global::System.Drawing.Size(370, 23);
			this.progressBar1.Step = 20;
			this.progressBar1.Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 1;
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(23, 23, 23);
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(394, 227);
			base.ControlBox = false;
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoginForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.LoginForm_Closing);
			base.Load += new global::System.EventHandler(this.LoginForm_Load);
			base.Shown += new global::System.EventHandler(this.Form1_Shown);
			base.ResumeLayout(false);
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x04000007 RID: 7
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}
