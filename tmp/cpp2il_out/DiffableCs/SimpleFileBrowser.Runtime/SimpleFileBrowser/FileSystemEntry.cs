namespace SimpleFileBrowser;

public struct FileSystemEntry
{
	public readonly string Path; //Field offset: 0x0
	public readonly string Name; //Field offset: 0x8
	public readonly string Extension; //Field offset: 0x10
	public readonly FileAttributes Attributes; //Field offset: 0x18

	public bool IsDirectory
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public FileSystemEntry(string path, string name, string extension, bool isDirectory) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Attributes", ReturnType = typeof(FileAttributes))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public FileSystemEntry(FileSystemInfo fileInfo, string extension) { }

	[CallerCount(Count = 0)]
	public bool get_IsDirectory() { }

}

