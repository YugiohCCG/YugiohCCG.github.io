namespace System.IO.Compression;

[Extension]
internal static class ZipHelper
{
	private static readonly DateTime s_invalidDateIndicator; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private static ZipHelper() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Extension]
	internal static void AdvanceToPosition(Stream stream, long position) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	internal static uint DateTimeToDosTime(DateTime dateTime) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(ZipCentralDirectoryFileHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static DateTime DosTimeToDateTime(uint dateTime) { }

	[CalledBy(Type = typeof(ZipHelper), Member = "SeekBackwardsToSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZipHelper), Member = "SeekBackwardsAndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static void ReadBytes(Stream stream, Byte[] buffer, int bytesToRead) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool RequiresUnicode(string test) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipHelper), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static bool SeekBackwardsAndRead(Stream stream, Byte[] buffer, out int bufferPointer) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "ReadEndOfCentralDirectory", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipHelper), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind) { }

}

