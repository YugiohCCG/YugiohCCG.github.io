namespace System.Drawing;

internal static class KnownColorTable
{
	private static Int32[] s_colorTable; //Field offset: 0x0
	private static String[] s_colorNameTable; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnownColorTable), Member = "InitColorNameTable", ReturnType = typeof(void))]
	private static void EnsureColorNameTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnownColorTable), Member = "InitColorTable", ReturnType = typeof(void))]
	private static void EnsureColorTable() { }

	[CalledBy(Type = typeof(KnownColorTable), Member = "EnsureColorNameTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KnownColorTable), Member = "KnownColorToName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KnownColor)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Color), Member = "get_Name", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 178)]
	private static void InitColorNameTable() { }

	[CalledBy(Type = typeof(KnownColorTable), Member = "EnsureColorTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KnownColorTable), Member = "KnownColorToArgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KnownColor)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(KnownColorTable), Member = "UpdateSystemColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void InitColorTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnownColorTable), Member = "InitColorTable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static int KnownColorToArgb(KnownColor color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnownColorTable), Member = "InitColorNameTable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static string KnownColorToName(KnownColor color) { }

	[CalledBy(Type = typeof(KnownColorTable), Member = "InitColorTable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateSystemColors(Int32[] colorTable) { }

}

