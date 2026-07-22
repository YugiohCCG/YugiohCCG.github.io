namespace System.IO.Enumeration;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct FileSystemEntry
{
	internal FILE_FULL_DIR_INFORMATION* _info; //Field offset: 0x0
	[CompilerGenerated]
	private ReadOnlySpan<Char> <Directory>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ReadOnlySpan<Char> <RootDirectory>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ReadOnlySpan<Char> <OriginalRootDirectory>k__BackingField; //Field offset: 0x28

	public FileAttributes Attributes
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 25
	}

	public private ReadOnlySpan<Char> Directory
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public ReadOnlySpan<Char> FileName
	{
		[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		 get { } //Length: 40
	}

	public bool IsDirectory
	{
		[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 29
	}

	public private ReadOnlySpan<Char> OriginalRootDirectory
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 11
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private ReadOnlySpan<Char> RootDirectory
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 11
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public FileAttributes get_Attributes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public ReadOnlySpan<Char> get_Directory() { }

	[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	public ReadOnlySpan<Char> get_FileName() { }

	[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsDirectory() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public ReadOnlySpan<Char> get_OriginalRootDirectory() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public ReadOnlySpan<Char> get_RootDirectory() { }

	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal static void Initialize(ref FileSystemEntry entry, FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<Char> directory, ReadOnlySpan<Char> rootDirectory, ReadOnlySpan<Char> originalRootDirectory) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Directory(ReadOnlySpan<Char> value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_OriginalRootDirectory(ReadOnlySpan<Char> value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RootDirectory(ReadOnlySpan<Char> value) { }

	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<FileInfos>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<DirectoryInfos>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<FileSystemInfos>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	public FileSystemInfo ToFileSystemInfo() { }

	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<UserFiles>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<UserDirectories>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerableFactory+<>c", Member = "<UserEntries>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(PathInternal), Member = "EndsInDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathInternal), Member = "StartsWithDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public string ToSpecifiedFullPath() { }

}

