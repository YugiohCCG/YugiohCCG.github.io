namespace System.IO;

public sealed class DirectoryInfo : FileSystemInfo
{

	public DirectoryInfo Parent
	{
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<>c__DisplayClass227_0", Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "RenameDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>", typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		 get { } //Length: 348
	}

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public DirectoryInfo(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private DirectoryInfo(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "get_Parent", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "IsDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	[CalledBy(Type = "Card.Manager+<LoadCustomScripts>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public virtual void Delete() { }

	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public void Delete(bool recursive) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallsUnknownMethods(Count = 2)]
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	[CalledBy(Type = "Game.CardAnimationPlayer+<GetAtlasText>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetSkeletonJson>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextures>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<FileInfo>")]
	[CalledBy(Type = "Card.Manager+<LoadCustomScripts>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallsUnknownMethods(Count = 2)]
	public IEnumerable<FileInfo> EnumerateFiles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions) { }

	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>", typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<>c__DisplayClass227_0", Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "RenameDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>", typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public DirectoryInfo get_Parent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions) { }

	[CalledBy(Type = "Manager.Updater", Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	public DirectoryInfo[] GetDirectories() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	[CalledBy(Type = "Manager.Helper+<ReserializeAllData>d__100`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	public FileInfo[] GetFiles() { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "GetEntriesInDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "SimpleFileBrowser.FileSystemEntry[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	public FileSystemInfo[] GetFileSystemInfos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DirectoryInfo), Member = "InternalEnumerateInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	public FileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions) { }

	[CalledBy(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(PathInternal), Member = "IsRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "IsDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFiles", ReturnType = typeof(FileInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "EnumerateFileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "EnumerateFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "EnumerateFiles", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(DirectoryInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "EnumerateFileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SearchOption)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(FileSystemInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", ReturnType = typeof(FileSystemInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(FileInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetDirectories", ReturnType = typeof(DirectoryInfo[]))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "FileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "DirectoryInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "FileInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

}

