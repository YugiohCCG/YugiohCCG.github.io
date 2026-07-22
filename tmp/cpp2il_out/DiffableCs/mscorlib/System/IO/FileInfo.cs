namespace System.IO;

public sealed class FileInfo : FileSystemInfo
{

	public DirectoryInfo Directory
	{
		[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "LaunchAsAdmin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 get { } //Length: 166
	}

	public string DirectoryName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 77
	}

	public long Length
	{
		[CalledBy(Type = "Manager.Helper+<TryUnpackDB>d__124", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "GetFileSize", ReturnType = typeof(long))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "GetFilesize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 246
	}

	public virtual string Name
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private FileInfo() { }

	[CalledBy(Type = "Scenes.Menu.ReplayList+<<OnClickPlay>g__playSelected|43_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "GetLastModifiedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "GetFilesize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "GetFileSize", ReturnType = typeof(long))]
	[CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteLogFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.TextDataManager+<ReadFileForLanguage>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "ClearAndroidCachedUpdateAPK", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<CheckForDatasUpdate>d__50", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<CheckForClientUpdate>d__97", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadUpdaterToTemp>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization", Member = "GetPrefered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Customization", Member = "get_LogFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "Manager.Customization+<GetLogText>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<>c__DisplayClass48_0", Member = "<OpenFileBrowserDialogAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Plugins.CoreAPI", Member = "DefineNativeCore", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<TryUnpackDB>d__124", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public FileInfo(string fileName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private FileInfo(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteLogFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_NormalizedPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public StreamWriter AppendText() { }

	[CalledBy(Type = "Manager.Helper+<TryUnpackDB>d__124", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public FileInfo CopyTo(string destFileName) { }

	[CalledBy(Type = "Manager.Updater", Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public FileInfo CopyTo(string destFileName, bool overwrite) { }

	[CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteLogFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_NormalizedPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public StreamWriter CreateText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "DeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void Delete() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "LaunchAsAdmin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DirectoryInfo get_Directory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	public string get_DirectoryName() { }

	[CalledBy(Type = "Manager.Helper+<TryUnpackDB>d__124", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "GetFileSize", ReturnType = typeof(long))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "GetFilesize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public long get_Length() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

}

