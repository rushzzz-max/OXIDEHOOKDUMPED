using System;

namespace PHLoader
{
	// Token: 0x02000008 RID: 8
	public struct LoginRequest
	{
		// Token: 0x0400001D RID: 29
		public IntPtr Message;

		// Token: 0x0400001E RID: 30
		public IntPtr Modules;

		// Token: 0x0400001F RID: 31
		public int NumModules;

		// Token: 0x04000020 RID: 32
		public int Success;
	}
}
