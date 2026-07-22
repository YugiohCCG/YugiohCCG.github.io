namespace System.IO.Compression;

public static class ZipFile
{

	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipFile), Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>), typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName) { }

	[CalledBy(Type = typeof(ZipFile), Member = "CreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ZipFile), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ZipArchiveMode), typeof(Encoding)}, ReturnType = typeof(ZipArchive))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryInfo), Member = "get_Parent", ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(DirectoryInfo), Member = "EnumerateFileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SearchOption)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(ZipFile), Member = "IsDirEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipFile), Member = "EntryFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]&), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ZipArchive), Member = "CreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ZipArchiveEntry))]
	[Calls(Type = typeof(ZipFileExtensions), Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>)}, ReturnType = typeof(ZipArchiveEntry))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 26)]
	private static void DoCreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, Nullable<CompressionLevel> compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void EnsureCapacity(ref Char[] buffer, int min) { }

	[CalledBy(Type = typeof(ZipFile), Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>), typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static string EntryFromPath(string entry, int offset, int length, ref Char[] buffer, bool appendPathSeparator = false) { }

	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding) { }

	[CalledBy(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipFile), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ZipArchiveMode), typeof(Encoding)}, ReturnType = typeof(ZipArchive))]
	[Calls(Type = typeof(ZipFileExtensions), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding, bool overwrite) { }

	[CalledBy(Type = typeof(ZipFile), Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>), typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "EnumerateFileSystemEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static bool IsDirEmpty(DirectoryInfo possiblyEmptyDir) { }

	[CalledBy(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipFile), Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>), typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveMode), typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = "System.Text.ValueStringBuilder", Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Text.ValueStringBuilder", Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding) { }

}

