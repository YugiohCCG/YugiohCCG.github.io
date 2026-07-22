namespace System.IO;

internal struct DisableMediaInsertionPrompt : IDisposable
{
	private static bool useUWPFallback; //Field offset: 0x0
	private bool _disableSuccess; //Field offset: 0x0
	private uint _oldMode; //Field offset: 0x4

	[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Kernel32), Member = "SetThreadErrorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static DisableMediaInsertionPrompt Create() { }

	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Kernel32), Member = "SetThreadErrorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	public override void Dispose() { }

}

