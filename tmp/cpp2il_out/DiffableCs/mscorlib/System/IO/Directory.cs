namespace System.IO;

public static class Directory
{

	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass49_0+<<ImportReplay>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "CreateFolderInDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.X509Store", Member = "CheckStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Network+<>c__DisplayClass68_0+<<OnReceiveServerReplay>b__1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static DirectoryInfo CreateDirectory(string path) { }

	[CalledBy(Type = "Scenes.Menu.ReplayList", Member = "<OnClickDeleteAll>b__46_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = "Data.CustomTheme", Member = "DeleteTempThemesPath", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "DeleteDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Delete(string path, bool recursive) { }

	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "IsDirEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	public static IEnumerable<String> EnumerateFileSystemEntries(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	public static IEnumerable<String> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "DirectoryExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool Exists(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
	public static string GetCurrentDirectory() { }

	[CalledBy(Type = typeof(FileSystem), Member = "OpenHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(SafeFileHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(PathInternal), Member = "GetRootLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string GetDirectoryRoot(string path) { }

	[CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Mono.Security.X509.X509CertificateCollection")]
	[CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCrlsCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	public static String[] GetFiles(string path, string searchPattern) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(SearchTarget), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[Calls(Type = typeof(MonoLinqHelper), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	public static String[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystem), Member = "GetLogicalDrives", ReturnType = typeof(String[]))]
	public static String[] GetLogicalDrives() { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnUpButtonPressed", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static DirectoryInfo GetParent(string path) { }

	[CalledBy(Type = typeof(Environment), Member = "get_CurrentDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "WindowsDriveAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	internal static string InsecureGetCurrentDirectory() { }

	[CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "EnumerateFileSystemEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(Directory), Member = "EnumerateFileSystemEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "UserEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "UserDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[Calls(Type = typeof(FileSystemEnumerableFactory), Member = "UserFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal static IEnumerable<String> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	[CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(PathInternal), Member = "GetRootLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	internal static string InternalGetDirectoryRoot(string path) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser+<>c__DisplayClass227_0", Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "MoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "RenameDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystem), Member = "MoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystem), Member = "FileExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PathInternal), Member = "get_StringComparison", ReturnType = typeof(StringComparison))]
	[Calls(Type = typeof(PathInternal), Member = "EnsureTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "DirectoryExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 34)]
	public static void Move(string sourceDirName, string destDirName) { }

}

