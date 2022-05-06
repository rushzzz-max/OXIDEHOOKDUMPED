namespace PHLoader
{
	// Token: 0x02000005 RID: 5
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000021AF File Offset: 0x000003AF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PHLoader.MainForm));
			this.NameLabel = new global::System.Windows.Forms.Label();
			this.VersionLabel = new global::System.Windows.Forms.Label();
			this.StatusLabel = new global::System.Windows.Forms.Label();
			this.InjectResponseLabel = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.WelcomeLabel = new global::System.Windows.Forms.Label();
			this.InjectButton = new global::System.Windows.Forms.Button();
			this.ModuleListbox = new global::System.Windows.Forms.ListBox();
			base.SuspendLayout();
			this.NameLabel.AutoSize = true;
			this.NameLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.NameLabel.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.NameLabel.Location = new global::System.Drawing.Point(342, 259);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new global::System.Drawing.Size(83, 22);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Update:";
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.VersionLabel.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.VersionLabel.Location = new global::System.Drawing.Point(342, 290);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new global::System.Drawing.Size(90, 22);
			this.VersionLabel.TabIndex = 2;
			this.VersionLabel.Text = "Version: ";
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.StatusLabel.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.StatusLabel.Location = new global::System.Drawing.Point(342, 226);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new global::System.Drawing.Size(80, 22);
			this.StatusLabel.TabIndex = 3;
			this.StatusLabel.Text = "Status: ";
			this.StatusLabel.Click += new global::System.EventHandler(this.StatusLabel_Click);
			this.InjectResponseLabel.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.InjectResponseLabel.AutoSize = true;
			this.InjectResponseLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.InjectResponseLabel.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.InjectResponseLabel.ForeColor = global::System.Drawing.Color.White;
			this.InjectResponseLabel.Location = new global::System.Drawing.Point(78, 343);
			this.InjectResponseLabel.Name = "InjectResponseLabel";
			this.InjectResponseLabel.Size = new global::System.Drawing.Size(179, 22);
			this.InjectResponseLabel.TabIndex = 16;
			this.InjectResponseLabel.Text = "Waiting for Input...";
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.button1.Location = new global::System.Drawing.Point(646, -9);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(32, 35);
			this.button1.TabIndex = 18;
			this.button1.Text = "x";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.WelcomeLabel.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.WelcomeLabel.AutoSize = true;
			this.WelcomeLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.WelcomeLabel.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.WelcomeLabel.ForeColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.WelcomeLabel.Location = new global::System.Drawing.Point(342, 173);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.Size = new global::System.Drawing.Size(64, 22);
			this.WelcomeLabel.TabIndex = 17;
			this.WelcomeLabel.Text = "User: ";
			this.WelcomeLabel.Click += new global::System.EventHandler(this.WelcomeLabel_Click_1);
			this.InjectButton.BackColor = global::System.Drawing.Color.FromArgb(33, 172, 245);
			this.InjectButton.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.InjectButton.FlatAppearance.BorderSize = 0;
			this.InjectButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.InjectButton.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.InjectButton.ForeColor = global::System.Drawing.Color.White;
			this.InjectButton.Location = new global::System.Drawing.Point(378, 338);
			this.InjectButton.Name = "InjectButton";
			this.InjectButton.Size = new global::System.Drawing.Size(143, 32);
			this.InjectButton.TabIndex = 19;
			this.InjectButton.Text = "Load";
			this.InjectButton.UseVisualStyleBackColor = false;
			this.InjectButton.Click += new global::System.EventHandler(this.InjectButton_Click);
			this.ModuleListbox.BackColor = global::System.Drawing.Color.FromArgb(6, 9, 18);
			this.ModuleListbox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ModuleListbox.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 14.25f);
			this.ModuleListbox.ForeColor = global::System.Drawing.Color.White;
			this.ModuleListbox.FormattingEnabled = true;
			this.ModuleListbox.ItemHeight = 22;
			this.ModuleListbox.Location = new global::System.Drawing.Point(84, 171);
			this.ModuleListbox.Name = "ModuleListbox";
			this.ModuleListbox.Size = new global::System.Drawing.Size(213, 110);
			this.ModuleListbox.TabIndex = 14;
			this.ModuleListbox.SelectedIndexChanged += new global::System.EventHandler(this.ModuleListbox_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(670, 390);
			base.ControlBox = false;
			base.Controls.Add(this.WelcomeLabel);
			base.Controls.Add(this.NameLabel);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.StatusLabel);
			base.Controls.Add(this.VersionLabel);
			base.Controls.Add(this.InjectResponseLabel);
			base.Controls.Add(this.InjectButton);
			base.Controls.Add(this.ModuleListbox);
			this.DoubleBuffered = true;
			this.ForeColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainForm";
			base.Padding = new global::System.Windows.Forms.Padding(3);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label InjectResponseLabel;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label WelcomeLabel;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button InjectButton;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label NameLabel;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label StatusLabel;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label VersionLabel;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ListBox ModuleListbox;
	}
}
