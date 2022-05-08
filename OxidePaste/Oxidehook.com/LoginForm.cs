using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PHLoader
{
	// Token: 0x02000004 RID: 4
	public partial class LoginForm : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000020FB File Offset: 0x000002FB
		public LoginForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000252C File Offset: 0x0000072C
		private void Login()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam\\ActiveProcess");
			int num = 0;
			if (registryKey != null)
			{
				this.label1.Text = "Waiting for steam";
				while (num == 0)
				{
					num = Convert.ToInt32(registryKey.GetValue("ActiveUser"));
					if (Convert.ToInt32(registryKey.GetValue("pid")) == 0)
					{
						Process.Start("steam://");
					}
				}
			}
			else
			{
				base.Hide();
				base.Close();
				Application.Exit();
			}
			this.label1.Text = "Logging in...";
			LoginRequest loginRequest = default(LoginRequest);
			if (Loader.PHLogin(ref loginRequest))
			{
				base.Hide();
				MainForm mainForm = new MainForm();
				mainForm.SetModulesListbox(loginRequest.Modules, loginRequest.NumModules);
				mainForm.ShowDialog();
				base.Close();
				return;
			}
			base.Hide();
			if (MessageBox.Show(Marshal.PtrToStringAnsi(loginRequest.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
			{
				base.Hide();
				base.Close();
				Application.Exit();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002109 File Offset: 0x00000309
		private void Form1_Shown(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(this.Login));
			thread.SetApartmentState(ApartmentState.STA);
			thread.Name = "Login Thread";
			thread.Start();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002133 File Offset: 0x00000333
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002133 File Offset: 0x00000333
		private void LoginForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002135 File Offset: 0x00000335
		private void LoginForm_Closing(object sender, CancelEventArgs e)
		{
			base.Hide();
			base.Close();
			Application.Exit();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002135 File Offset: 0x00000335
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
			base.Close();
			Application.Exit();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002133 File Offset: 0x00000333
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002133 File Offset: 0x00000333
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002133 File Offset: 0x00000333
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002133 File Offset: 0x00000333
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}
	}
}
