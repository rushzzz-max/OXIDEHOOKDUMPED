using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PHLoader
{
	// Token: 0x0200000A RID: 10
	public static class Loader
	{
		// Token: 0x06000030 RID: 48
		[DllImport("ph.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Login(ref LoginRequest req, bool MTA);

		// Token: 0x06000031 RID: 49
		[DllImport("ph.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr GetUsername();

		// Token: 0x06000032 RID: 50
		[DllImport("ph.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Inject(ref InjectRequest req, int ID);

		// Token: 0x06000033 RID: 51 RVA: 0x000021CE File Offset: 0x000003CE
		public static bool PHLogin(ref LoginRequest req)
		{
			Loader.Login(ref req, false);
			Loader.PHGetModules(req.Modules, req.NumModules);
			return req.Success == 1;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021F1 File Offset: 0x000003F1
		public static string PHGetUsername()
		{
			return Marshal.PtrToStringAnsi(Loader.GetUsername());
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021FD File Offset: 0x000003FD
		public static bool PHInject(ref InjectRequest req, int id)
		{
			if (id <= 0)
			{
				return false;
			}
			Loader.Inject(ref req, id);
			return req.Success == 1;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003380 File Offset: 0x00001580
		private static void PHGetModules(IntPtr Modules, int Count)
		{
			if (!Modules.Equals(null) && Count > 0)
			{
				for (int i = 0; i < Count; i++)
				{
					ModuleClient moduleClient = (ModuleClient)Marshal.PtrToStructure(Modules + i * 40, typeof(ModuleClient));
					Module item = default(Module);
					item.ID = moduleClient.ID;
					item.Method = moduleClient.Method;
					item.Name = Marshal.PtrToStringAnsi(moduleClient.Name);
					item.Version = Marshal.PtrToStringAnsi(moduleClient.Version);
					item.Status = Marshal.PtrToStringAnsi(moduleClient.Status);
					item.Target = Marshal.PtrToStringAnsi(moduleClient.Target);
					Loader.Modules.Add(item);
				}
				return;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003448 File Offset: 0x00001648
		public static Module PHGetModuleByName(string name)
		{
			Module result = default(Module);
			if (Loader.Modules.Count <= 0)
			{
				return result;
			}
			foreach (Module module in Loader.Modules)
			{
				if (module.Name == name)
				{
					result = module;
					break;
				}
			}
			return result;
		}

		// Token: 0x04000023 RID: 35
		public static List<Module> Modules = new List<Module>();
	}
}
