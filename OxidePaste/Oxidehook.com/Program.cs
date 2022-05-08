using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace PHLoader
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000034C0 File Offset: 0x000016C0
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Process[] processesByName = Process.GetProcessesByName("csgo");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			if (Process.GetProcessesByName("steam").Length != 0)
			{
				DialogResult dialogResult = MessageBox.Show(" Steam is running\n press yes to restart steam\n press no to exit the loader", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult != DialogResult.Yes)
				{
					if (dialogResult == DialogResult.No)
					{
						Application.Exit();
						return;
					}
				}
				else
				{
					processesByName = Process.GetProcessesByName("steam");
					for (int i = 0; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
					Process.Start("steam://");
					Thread.Sleep(10000);
				}
			}
			Application.Run(new LoginForm());
		}
	}
}
