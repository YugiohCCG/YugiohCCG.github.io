namespace System.IO.Enumeration;

internal static class FileSystemEnumerableFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static FindTransform<String> <>9__3_0; //Field offset: 0x8
		public static FindTransform<String> <>9__4_0; //Field offset: 0x10
		public static FindTransform<String> <>9__5_0; //Field offset: 0x18
		public static FindTransform<FileInfo> <>9__6_0; //Field offset: 0x20
		public static FindTransform<DirectoryInfo> <>9__7_0; //Field offset: 0x28
		public static FindTransform<FileSystemInfo> <>9__8_0; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
		[CallsUnknownMethods(Count = 1)]
		internal DirectoryInfo <DirectoryInfos>b__7_0(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
		[CallsUnknownMethods(Count = 1)]
		internal FileInfo <FileInfos>b__6_0(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToFileSystemInfo", ReturnType = typeof(FileSystemInfo))]
		internal FileSystemInfo <FileSystemInfos>b__8_0(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <UserDirectories>b__4_0(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <UserEntries>b__5_0(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemEntry), Member = "ToSpecifiedFullPath", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <UserFiles>b__3_0(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <UserFiles>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass4_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <UserDirectories>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass5_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		internal bool <UserEntries>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <FileInfos>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <DirectoryInfos>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass8_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
		internal bool <FileSystemInfos>b__1(ref FileSystemEntry entry) { }

	}

	private static readonly Char[] s_unixEscapeChars; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static FileSystemEnumerableFactory() { }

	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options) { }

	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options) { }

	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options) { }

	[CalledBy(Type = typeof(<>c__DisplayClass3_0), Member = "<UserFiles>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass4_0), Member = "<UserDirectories>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass5_0), Member = "<UserEntries>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass6_0), Member = "<FileInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass7_0), Member = "<DirectoryInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass8_0), Member = "<FileSystemInfos>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool MatchesPattern(string expression, ReadOnlySpan<Char> name, EnumerationOptions options) { }

	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static IEnumerable<String> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static IEnumerable<String> UserEntries(string directory, string expression, EnumerationOptions options) { }

	[CalledBy(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static IEnumerable<String> UserFiles(string directory, string expression, EnumerationOptions options) { }

}

