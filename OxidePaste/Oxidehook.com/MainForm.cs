using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PHLoader
{
	// Token: 0x02000005 RID: 5
	public partial class MainForm : Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002167 File Offset: 0x00000367
		public MainForm()
		{
			this.BackColor = Color.LavenderBlush;
			base.TransparencyKey = Color.LavenderBlush;
			this.InitializeComponent();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000028D0 File Offset: 0x00000AD0
		private void Inject()
		{
			this.InjectButton.Enabled = false;
			this.ModuleListbox.Enabled = false;
			Module module = Loader.PHGetModuleByName(this.ModuleListbox.SelectedItem.ToString());
			if (module.ID > 0)
			{
				Process[] processesByName = Process.GetProcessesByName("csgo");
				while (processesByName.Length == 0)
				{
					processesByName = Process.GetProcessesByName("csgo");
					this.InjectResponseLabel.Text = "Response: Opening CS:GO...";
				}
				this.InjectResponseLabel.Text = "Response: Waiting for CS:GO...";
				Thread.Sleep(2000);
				this.InjectResponseLabel.Text = "Response: Injecting...";
				InjectRequest injectRequest = default(InjectRequest);
				if (Loader.PHInject(ref injectRequest, module.ID))
				{
					this.InjectResponseLabel.Text = "Response: " + Marshal.PtrToStringAnsi(injectRequest.Message);
					if (Marshal.PtrToStringAnsi(injectRequest.Message) != "Successfully Injected")
					{
						MessageBox.Show(Marshal.PtrToStringAnsi(injectRequest.Message), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
					}
					else
					{
						Application.Exit();
					}
				}
				this.InjectButton.Enabled = true;
				this.ModuleListbox.Enabled = true;
				return;
			}
			this.InjectResponseLabel.Text = "Response: Module not found!";
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002A04 File Offset: 0x00000C04
		private void InjectButton_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("csgo");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			this.InjectResponseLabel.Text = "Response: waiting for CSGO";
			Process.Start("steam://rungameid/730");
			Thread thread = new Thread(new ThreadStart(this.Inject));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Name = "Inject Thread";
			thread.Start();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002A78 File Offset: 0x00000C78
		public void SetModulesListbox(IntPtr Modules, int Count)
		{
			this.BackColor = Color.LavenderBlush;
			base.TransparencyKey = Color.LavenderBlush;
			if (!Modules.Equals(null) && Count > 0)
			{
				foreach (Module module in Loader.Modules)
				{
					this.ModuleListbox.Items.Add(module.Name);
				}
				return;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000218B File Offset: 0x0000038B
		private void Main_Load(object sender, EventArgs e)
		{
			Label welcomeLabel = this.WelcomeLabel;
			welcomeLabel.Text += Loader.PHGetUsername();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021A8 File Offset: 0x000003A8
		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002B00 File Offset: 0x00000D00
		private void ModuleListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ModuleListbox.SelectedItems.Count > 0)
			{
				this.InjectResponseLabel.Text = "Response: Ready!";
				this.InjectButton.Enabled = true;
				Module module = Loader.PHGetModuleByName(this.ModuleListbox.SelectedItem.ToString());
				if (module.ID > 0)
				{
					this.NameLabel.Text = "Name: " + module.Name;
					this.VersionLabel.Text = "Version: " + module.Version;
					this.StatusLabel.Text = "Status: " + module.Status;
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002135 File Offset: 0x00000335
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
			base.Close();
			Application.Exit();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002133 File Offset: 0x00000333
		private void WelcomeLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002133 File Offset: 0x00000333
		private void InjectButton_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002133 File Offset: 0x00000333
		private void ModuleListbox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002133 File Offset: 0x00000333
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002133 File Offset: 0x00000333
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002133 File Offset: 0x00000333
		private void StatusLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002133 File Offset: 0x00000333
		private void WelcomeLabel_Click_1(object sender, EventArgs e)
		{
		}
	}
}
