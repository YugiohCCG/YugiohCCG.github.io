namespace SimpleFileBrowser;

public class FileBrowserQuickLink : FileBrowserItem
{
	private string m_targetPath; //Field offset: 0x88

	public string TargetPath
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FileBrowserQuickLink() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_TargetPath() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "set_PickFolderQuickLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetQuickLink(Sprite icon, string name, string targetPath) { }

}

