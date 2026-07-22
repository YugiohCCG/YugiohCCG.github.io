namespace System.Net;

internal class FtpMethodInfo
{
	private static readonly FtpMethodInfo[] s_knownMethodInfo; //Field offset: 0x0
	internal string Method; //Field offset: 0x10
	internal FtpOperation Operation; //Field offset: 0x18
	internal FtpMethodFlags Flags; //Field offset: 0x1C
	internal string HttpCommand; //Field offset: 0x20

	internal bool IsCommandOnly
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal bool IsDownload
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	internal bool IsUpload
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal bool ShouldParseForResponseUri
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 81)]
	private static FtpMethodInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsCommandOnly() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal bool get_IsDownload() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsUpload() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_ShouldParseForResponseUri() { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool HasFlag(FtpMethodFlags flags) { }

}

