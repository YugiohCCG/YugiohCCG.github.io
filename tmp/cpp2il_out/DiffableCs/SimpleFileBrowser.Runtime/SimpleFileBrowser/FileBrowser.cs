namespace SimpleFileBrowser;

public class FileBrowser : MonoBehaviour, IListViewAdapter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<FileSystemEntry> <>9__222_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int <RefreshFiles>b__222_0(FileSystemEntry entry1, FileSystemEntry entry2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass227_0
	{
		public FileSystemEntry fileInfo; //Field offset: 0x10
		public FileBrowser <>4__this; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass227_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DirectoryInfo), Member = "get_Parent", ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal void <RenameSelectedFile>b__0(string newName) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass244_0
	{
		public bool directoryExists; //Field offset: 0x10
		public string path; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass244_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		internal void <CheckDirectoryExistsWithTimeout>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <CreateNewFolderCoroutine>d__226 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FileBrowser <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <CreateNewFolderCoroutine>d__226(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(FileBrowserRenamedItem), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), typeof(OnRenameCompleted)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <WaitForLoadDialog>d__250 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PickMode pickMode; //Field offset: 0x20
		public bool allowMultiSelection; //Field offset: 0x24
		public string initialPath; //Field offset: 0x28
		public string initialFilename; //Field offset: 0x30
		public string title; //Field offset: 0x38
		public string loadButtonText; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <WaitForLoadDialog>d__250(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <WaitForSaveDialog>d__249 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PickMode pickMode; //Field offset: 0x20
		public bool allowMultiSelection; //Field offset: 0x24
		public string initialPath; //Field offset: 0x28
		public string initialFilename; //Field offset: 0x30
		public string title; //Field offset: 0x38
		public string saveButtonText; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <WaitForSaveDialog>d__249(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class FileSystemEntryFilter : MulticastDelegate
	{

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FileSystemEntryFilter(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(FileSystemEntry entry, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool Invoke(FileSystemEntry entry) { }

	}

	private struct FiletypeIcon
	{
		public string extension; //Field offset: 0x0
		public Sprite icon; //Field offset: 0x8

	}

	internal class Filter
	{
		public readonly string name; //Field offset: 0x10
		public readonly String[] extensions; //Field offset: 0x18
		public readonly HashSet<String> extensionsSet; //Field offset: 0x20
		public readonly string defaultExtension; //Field offset: 0x28
		public readonly bool allExtensionsHaveSingleSuffix; //Field offset: 0x30

		[CalledBy(Type = typeof(FileBrowser), Member = "set_AllFilesFilterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal Filter(string name) { }

		[CalledBy(Type = "Manager.Customization+<OpenFileBrowserDialogAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		public Filter(string name, string extension) { }

		[CalledBy(Type = "Manager.Customization+<OpenFileBrowserDialogAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public Filter(string name, String[] extensions) { }

		[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public bool MatchesExtension(string extension, bool extensionMayHaveMultipleSuffixes) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		public virtual string ToString() { }

	}

	internal sealed class OnCancel : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnCancel(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	internal sealed class OnSuccess : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnSuccess(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(String[] paths, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(String[] paths) { }

	}

	internal enum Permission
	{
		Denied = 0,
		Granted = 1,
		ShouldAsk = 2,
	}

	internal enum PickMode
	{
		Files = 0,
		Folders = 1,
		FilesAndFolders = 2,
	}

	private struct QuickLink
	{
		public SpecialFolder target; //Field offset: 0x0
		public string name; //Field offset: 0x8
		public Sprite icon; //Field offset: 0x10

	}

	private const int FILENAME_INPUT_FIELD_MAX_FILE_COUNT = 7; //Field offset: 0x0
	private const string SAF_PICK_FOLDER_QUICK_LINK_PATH = "SAF_PICK_FOLDER"; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsOpen>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <Success>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	private static String[] <Result>k__BackingField; //Field offset: 0x8
	private static bool m_askPermissions; //Field offset: 0x10
	private static bool m_singleClickMode; //Field offset: 0x11
	private static FileSystemEntryFilter m_displayedEntriesFilter; //Field offset: 0x18
	private static float m_drivesRefreshInterval; //Field offset: 0x20
	private static bool m_displayHiddenFilesToggle; //Field offset: 0x24
	private static string m_allFilesFilterText; //Field offset: 0x28
	private static string m_foldersFilterText; //Field offset: 0x30
	private static string m_pickFolderQuickLinkText; //Field offset: 0x38
	private static FileBrowser m_instance; //Field offset: 0x40
	private static bool quickLinksInitialized; //Field offset: 0x48
	[SerializeField]
	private UISkin m_skin; //Field offset: 0x20
	private int m_skinVersion; //Field offset: 0x28
	private Sprite m_skinPrevDriveIcon; //Field offset: 0x30
	private Sprite m_skinPrevFolderIcon; //Field offset: 0x38
	[Header("Settings")]
	[SerializeField]
	internal int minWidth; //Field offset: 0x40
	[SerializeField]
	internal int minHeight; //Field offset: 0x44
	[SerializeField]
	private float narrowScreenWidth; //Field offset: 0x48
	[SerializeField]
	private float quickLinksMaxWidthPercentage; //Field offset: 0x4C
	[SerializeField]
	private bool sortFilesByName; //Field offset: 0x50
	[FormerlySerializedAs("excludeExtensions")]
	[SerializeField]
	private String[] excludedExtensions; //Field offset: 0x58
	[SerializeField]
	private QuickLink[] quickLinks; //Field offset: 0x60
	private readonly HashSet<String> excludedExtensionsSet; //Field offset: 0x68
	[SerializeField]
	private bool generateQuickLinksForDrives; //Field offset: 0x70
	[SerializeField]
	private bool contextMenuShowDeleteButton; //Field offset: 0x71
	[SerializeField]
	private bool contextMenuShowRenameButton; //Field offset: 0x72
	[SerializeField]
	private bool showResizeCursor; //Field offset: 0x73
	[Header("Internal References")]
	[SerializeField]
	private FileBrowserMovement window; //Field offset: 0x78
	private RectTransform windowTR; //Field offset: 0x80
	[SerializeField]
	private RectTransform topViewNarrowScreen; //Field offset: 0x88
	[SerializeField]
	private RectTransform middleView; //Field offset: 0x90
	private Vector2 middleViewOriginalPosition; //Field offset: 0x98
	private Vector2 middleViewOriginalSize; //Field offset: 0xA0
	[SerializeField]
	private RectTransform middleViewQuickLinks; //Field offset: 0xA8
	private Vector2 middleViewQuickLinksOriginalSize; //Field offset: 0xB0
	[SerializeField]
	private RectTransform middleViewFiles; //Field offset: 0xB8
	[SerializeField]
	private RectTransform middleViewSeparator; //Field offset: 0xC0
	[SerializeField]
	private FileBrowserItem itemPrefab; //Field offset: 0xC8
	private readonly List<FileBrowserItem> allItems; //Field offset: 0xD0
	[SerializeField]
	private FileBrowserQuickLink quickLinkPrefab; //Field offset: 0xD8
	private readonly List<FileBrowserQuickLink> allQuickLinks; //Field offset: 0xE0
	[SerializeField]
	private Text titleText; //Field offset: 0xE8
	[SerializeField]
	private Button backButton; //Field offset: 0xF0
	[SerializeField]
	private Button forwardButton; //Field offset: 0xF8
	[SerializeField]
	private Button upButton; //Field offset: 0x100
	[SerializeField]
	private Button moreOptionsButton; //Field offset: 0x108
	[SerializeField]
	private InputField pathInputField; //Field offset: 0x110
	[SerializeField]
	private RectTransform pathInputFieldSlotTop; //Field offset: 0x118
	[SerializeField]
	private RectTransform pathInputFieldSlotBottom; //Field offset: 0x120
	[SerializeField]
	private InputField searchInputField; //Field offset: 0x128
	[SerializeField]
	private RectTransform quickLinksContainer; //Field offset: 0x130
	[SerializeField]
	private ScrollRect quickLinksScrollRect; //Field offset: 0x138
	[SerializeField]
	private RectTransform filesContainer; //Field offset: 0x140
	[SerializeField]
	private ScrollRect filesScrollRect; //Field offset: 0x148
	[SerializeField]
	private RecycledListView listView; //Field offset: 0x150
	[SerializeField]
	private InputField filenameInputField; //Field offset: 0x158
	[SerializeField]
	private Text filenameInputFieldOverlayText; //Field offset: 0x160
	[SerializeField]
	private Image filenameImage; //Field offset: 0x168
	[SerializeField]
	private Dropdown filtersDropdown; //Field offset: 0x170
	[SerializeField]
	private RectTransform filtersDropdownContainer; //Field offset: 0x178
	[SerializeField]
	private Text filterItemTemplate; //Field offset: 0x180
	[SerializeField]
	private Toggle showHiddenFilesToggle; //Field offset: 0x188
	[SerializeField]
	private Text submitButtonText; //Field offset: 0x190
	[SerializeField]
	private Button[] allButtons; //Field offset: 0x198
	[SerializeField]
	private RectTransform moreOptionsContextMenuPosition; //Field offset: 0x1A0
	[SerializeField]
	private FileBrowserRenamedItem renameItem; //Field offset: 0x1A8
	[SerializeField]
	private FileBrowserContextMenu contextMenu; //Field offset: 0x1B0
	[SerializeField]
	private FileBrowserDeleteConfirmationPanel deleteConfirmationPanel; //Field offset: 0x1B8
	[SerializeField]
	private FileBrowserCursorHandler resizeCursorHandler; //Field offset: 0x1C0
	internal RectTransform rectTransform; //Field offset: 0x1C8
	private Canvas canvas; //Field offset: 0x1D0
	private FileAttributes ignoredFileAttributes; //Field offset: 0x1D8
	private FileSystemEntry[] allFileEntries; //Field offset: 0x1E0
	private readonly List<FileSystemEntry> validFileEntries; //Field offset: 0x1E8
	private readonly List<Int32> selectedFileEntries; //Field offset: 0x1F0
	private readonly List<String> pendingFileEntrySelection; //Field offset: 0x1F8
	private int multiSelectionPivotFileEntry; //Field offset: 0x200
	private StringBuilder multiSelectionFilenameBuilder; //Field offset: 0x208
	private readonly List<Filter> filters; //Field offset: 0x210
	private Filter allFilesFilter; //Field offset: 0x218
	private bool showAllFilesFilter; //Field offset: 0x220
	private bool allFiltersHaveSingleSuffix; //Field offset: 0x221
	private bool allExcludedExtensionsHaveSingleSuffix; //Field offset: 0x222
	private string defaultInitialPath; //Field offset: 0x228
	private int currentPathIndex; //Field offset: 0x230
	private readonly List<String> pathsFollowed; //Field offset: 0x238
	private HashSet<Char> invalidFilenameChars; //Field offset: 0x240
	private float drivesNextRefreshTime; //Field offset: 0x248
	private String[] driveQuickLinks; //Field offset: 0x250
	private int numberOfDriveQuickLinks; //Field offset: 0x258
	private readonly List<String> timedOutDirectoryExistsRequests; //Field offset: 0x260
	private bool canvasDimensionsChanged; //Field offset: 0x268
	private readonly CompareInfo textComparer; //Field offset: 0x270
	private readonly CompareOptions textCompareOptions; //Field offset: 0x278
	private PointerEventData nullPointerEventData; //Field offset: 0x280
	private string m_currentPath; //Field offset: 0x288
	private string m_searchString; //Field offset: 0x290
	private bool m_acceptNonExistingFilename; //Field offset: 0x298
	private PickMode m_pickerMode; //Field offset: 0x29C
	private bool m_allowMultiSelection; //Field offset: 0x2A0
	private bool m_multiSelectionToggleSelectionMode; //Field offset: 0x2A1
	private OnSuccess onSuccess; //Field offset: 0x2A8
	private OnCancel onCancel; //Field offset: 0x2B0

	public static event FileSystemEntryFilter DisplayedEntriesFilter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 add { } //Length: 589
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 411
	}

	private bool AcceptNonExistingFilename
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		private set { } //Length: 7
	}

	private bool AllExtensionsHaveSingleSuffix
	{
		[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 84
	}

	public static string AllFilesFilterText
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 904
	}

	internal bool AllowMultiSelection
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		private set { } //Length: 7
	}

	public static bool AskPermissions
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		 set { } //Length: 84
	}

	private string CurrentPath
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnBackButtonPressed", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnForwardButtonPressed", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnUpButtonPressed", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnPathChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "GetPathWithoutTrailingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		private set { } //Length: 1193
	}

	public static bool DisplayHiddenFilesToggle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 487
	}

	public static float DrivesRefreshInterval
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 80
		[CallerCount(Count = 0)]
		 set { } //Length: 93
	}

	public static string FoldersFilterText
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 513
	}

	private static FileBrowser Instance
	{
		[CalledBy(Type = typeof(<WaitForLoadDialog>d__250), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetExcludedExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "HideDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "set_ShowHiddenFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "get_ShowHiddenFiles", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
		[CalledBy(Type = typeof(<WaitForSaveDialog>d__249), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 466
	}

	public private static bool IsOpen
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 83
	}

	private string LastBrowsedFolder
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		private get { } //Length: 53
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		private set { } //Length: 60
	}

	internal bool MultiSelectionToggleSelectionMode
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(<CreateNewFolderCoroutine>d__226), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "DeselectAllFiles", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowser), Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileBrowserItem), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 359
	}

	internal PickMode PickerMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
		[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private set { } //Length: 661
	}

	public static string PickFolderQuickLinkText
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
		[Calls(Type = typeof(FileBrowserQuickLink), Member = "SetQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 596
	}

	public private static String[] Result
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 110
	}

	private string SearchString
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 113
	}

	public static bool ShowHiddenFiles
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 103
	}

	private override int SimpleFileBrowser.IListViewAdapter.Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 63
	}

	private override float SimpleFileBrowser.IListViewAdapter.ItemHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 31
	}

	private override OnItemClickedHandler SimpleFileBrowser.IListViewAdapter.OnItemClicked
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	public static bool SingleClickMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		 set { } //Length: 84
	}

	public static UISkin Skin
	{
		[CalledBy(Type = typeof(FileBrowser), Member = "set_PickFolderQuickLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 307
	}

	private string SubmitButtonText
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 42
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 42
	}

	public private static bool Success
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 84
	}

	private string Title
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 42
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static FileBrowser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public FileBrowser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <CreateNewFolderCoroutine>b__226_0(string folderName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <DeleteSelectedFiles>b__228_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static void add_DisplayedEntriesFilter(FileSystemEntryFilter value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool AddQuickLink(string name, string path, Sprite icon = null) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(FileBrowserQuickLink), Member = "SetQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(FileBrowser), Member = "GetPathWithoutTrailingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "CheckDirectoryExistsWithTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool AddQuickLink(Sprite icon, string name, string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_onValidateInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnValidateInput)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetExcludedExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(Text), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_fontStyle", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FontStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CharacterInfo&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int CalculateLengthOfDropdownText(string str) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool CheckDirectoryExistsWithTimeout(string path, int timeout = 750) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public static Permission CheckPermission() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "ClearQuickLinksInternal", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearQuickLinks() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void ClearQuickLinksInternal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void CreateNewFolder() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CreateNewFolderCoroutine>d__226))]
	private IEnumerator CreateNewFolderCoroutine() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnDeleteButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Sort", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(System.Collections.Generic.List`1<SimpleFileBrowser.FileSystemEntry>), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(OnDeletionConfirmed)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void DeleteSelectedFiles() { }

	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnDeselectAllButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DeselectAllFiles() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnWindowDimensionsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureScrollViewIsWithinBounds() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnEndResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void EnsureWindowIsWithinBounds() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int ExtractFilenameFromInput(string input, ref int startIndex, out int nextStartIndex) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FilenameInputToFileEntryIndex(string input, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	private bool get_AcceptNonExistingFilename() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_AllExtensionsHaveSingleSuffix() { }

	[CallerCount(Count = 0)]
	public static string get_AllFilesFilterText() { }

	[CallerCount(Count = 0)]
	internal bool get_AllowMultiSelection() { }

	[CallerCount(Count = 0)]
	public static bool get_AskPermissions() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private string get_CurrentPath() { }

	[CallerCount(Count = 0)]
	public static bool get_DisplayHiddenFilesToggle() { }

	[CallerCount(Count = 0)]
	public static float get_DrivesRefreshInterval() { }

	[CallerCount(Count = 0)]
	public static string get_FoldersFilterText() { }

	[CalledBy(Type = typeof(<WaitForLoadDialog>d__250), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<WaitForSaveDialog>d__249), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "get_ShowHiddenFiles", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_ShowHiddenFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "HideDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetExcludedExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ClearQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static FileBrowser get_Instance() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_IsOpen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string get_LastBrowsedFolder() { }

	[CallerCount(Count = 0)]
	internal bool get_MultiSelectionToggleSelectionMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal PickMode get_PickerMode() { }

	[CallerCount(Count = 0)]
	public static string get_PickFolderQuickLinkText() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static String[] get_Result() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private string get_SearchString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_ShowHiddenFiles() { }

	[CallerCount(Count = 0)]
	public static bool get_SingleClickMode() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "set_PickFolderQuickLinkText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[CallsUnknownMethods(Count = 1)]
	public static UISkin get_Skin() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string get_SubmitButtonText() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_Success() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string get_Title() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserHelpers), Member = "GetEntriesInDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileSystemEntry[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetExtensionFromFilename(string filename, bool extractOnlyLastSuffix) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "SimpleFileBrowser.IListViewAdapter.SetItemContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowser), typeof(System.Collections.Generic.List`1<SimpleFileBrowser.FileSystemEntry>), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(OnDeletionConfirmed)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Sprite GetIconForFileEntry(FileSystemEntry fileInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private string GetInitialPath(string initialPath) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetPathWithoutTrailingDirectorySeparator(string path) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnOperationSuccessful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Hide() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void HideDialog(bool invokeCancelCallback = false) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Sprite)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeQuickLinks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "SelectAllFiles", ReturnType = typeof(void))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "DeleteSelectedFiles", ReturnType = typeof(void))]
	[Calls(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "OnWindowDimensionsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureWindowIsWithinBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	private void OnApplicationFocus(bool focus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnBackButtonPressed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void OnCancelButtonClicked() { }

	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecycledListView), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "ShowContextMenuAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void OnContextMenuTriggered(Vector2 pointerPos) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnFilenameInputChanged(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_AllExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFilterChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnForwardButtonPressed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnItemHeld(FileBrowserItem item) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(FileBrowser), Member = "UpdateFilenameInputFieldWithSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void OnItemSelected(FileBrowserItem item, bool isDoubleClick) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(FileBrowser), Member = "ShowContextMenuAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnMoreOptionsButtonClicked() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnCancelButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "HideDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileBrowser), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnOperationCanceled(bool invokeCancelCallback) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnOperationSuccessful(String[] paths) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void OnPathChanged(string newPath) { }

	[CallerCount(Count = 0)]
	private void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnSearchStringChanged(string newSearchString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void OnShowHiddenFilesToggleChanged() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnValidateFilenameInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "ChangeExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Filter), Member = "MatchesExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "GetExtensionFromFilename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "get_AllExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "FilenameInputToFileEntryIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileBrowser), Member = "VerifyFilenameInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "ExtractFilenameFromInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileBrowser), Member = "OnOperationSuccessful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public void OnSubmitButtonClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnUpButtonPressed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	private char OnValidateFilenameInput(string text, int charIndex, char addedChar) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserMovement), Member = "OnResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateItemsInTheList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void OnWindowDimensionsChanged(Vector2 size) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "add_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "remove_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnApplicationFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSearchStringChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnShowHiddenFilesToggleChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void PersistFileEntrySelection() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "GetPathRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(FileBrowser), Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "GetLogicalDrives", ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshDriveQuickLinks() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnShowHiddenFilesToggleChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass227_0), Member = "<RenameSelectedFile>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "add_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "remove_DisplayedEntriesFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntryFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "set_SearchString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnApplicationFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSearchStringChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnFilterChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "<CreateNewFolderCoroutine>b__226_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Filter), Member = "MatchesExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry[]), typeof(System.Comparison`1<SimpleFileBrowser.FileSystemEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserHelpers), Member = "GetEntriesInDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileSystemEntry[]))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "EnsureScrollViewIsWithinBounds", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	public void RefreshFiles(bool pathChanged) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "set_Skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "DestroyItemsBetweenIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserContextMenu), Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(FileBrowserRenamedItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(FileBrowserItem), Member = "get_TransformComponent", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(UISkin), Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshSkin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "PersistFileEntrySelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_DisplayedEntriesFilter(FileSystemEntryFilter value) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnRenameButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileBrowser), Member = "set_MultiSelectionToggleSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(FileBrowserRenamedItem), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), typeof(OnRenameCompleted)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void RenameSelectedFile() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public static Permission RequestPermission() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserContextMenu), Member = "OnSelectAllButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "UpdateFilenameInputFieldWithSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(RecycledListView), Member = "UpdateList", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SelectAllFiles() { }

	[CallerCount(Count = 0)]
	private void set_AcceptNonExistingFilename(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static void set_AllFilesFilterText(string value) { }

	[CallerCount(Count = 0)]
	private void set_AllowMultiSelection(bool value) { }

	[CallerCount(Count = 0)]
	public static void set_AskPermissions(bool value) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshDriveQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnBackButtonPressed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnForwardButtonPressed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnUpButtonPressed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnPathChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "GetPathWithoutTrailingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void set_CurrentPath(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_DisplayHiddenFilesToggle(bool value) { }

	[CallerCount(Count = 0)]
	public static void set_DrivesRefreshInterval(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void set_FoldersFilterText(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_IsOpen(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void set_LastBrowsedFolder(string value) { }

	[CalledBy(Type = typeof(<CreateNewFolderCoroutine>d__226), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemHeld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "DeselectAllFiles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RenameSelectedFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "<DeleteSelectedFiles>b__228_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserItem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void set_MultiSelectionToggleSelectionMode(bool value) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>))]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void set_PickerMode(PickMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Skin", ReturnType = typeof(UISkin))]
	[Calls(Type = typeof(FileBrowserQuickLink), Member = "SetQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_PickFolderQuickLinkText(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_Result(String[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void set_SearchString(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_ShowHiddenFiles(bool value) { }

	[CallerCount(Count = 0)]
	public static void set_SingleClickMode(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_Skin(UISkin value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void set_SubmitButtonText(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_Success(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void set_Title(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool SetDefaultFilter(string defaultFilter) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static void SetExcludedExtensions(String[] excludedExtensions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static void SetFilters(bool showAllFilesFilter, IEnumerable<String> filters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void SetFilters(bool showAllFilesFilter, Filter[] filters) { }

	[CalledBy(Type = "Manager.Customization+<OpenFileBrowserDialogAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static void SetFilters(bool showAllFilesFilter, IEnumerable<Filter> filters) { }

	[CalledBy(Type = "Manager.Customization+<OpenFileBrowserDialogAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void SetFilters(bool showAllFilesFilter, String[] filters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPreProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	public static void SetFilters(bool showAllFilesFilter) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CharacterInfo), Member = "get_advance", ReturnType = typeof(int))]
	[Calls(Type = typeof(Font), Member = "GetCharacterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CharacterInfo&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_fontStyle", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(Font), Member = "RequestCharactersInTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FontStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Text), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private static void SetFiltersPostProcessing() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void SetFiltersPreProcessing(bool showAllFilesFilter) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileBrowser), Member = "set_CurrentPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Show(string initialPath, string initialFilename) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnMoreOptionsButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FileBrowserContextMenu), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ShowContextMenuAt(Vector2 position, bool isMoreOptionsMenu) { }

	[CalledBy(Type = typeof(<WaitForLoadDialog>d__250), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<WaitForSaveDialog>d__249), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowSaveDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "ShowLoadDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FileBrowser), Member = "get_Instance", ReturnType = typeof(FileBrowser))]
	[Calls(Type = typeof(FileBrowser), Member = "set_PickerMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static bool ShowDialogInternal(OnSuccess onSuccess, OnCancel onCancel, PickMode pickMode, bool allowMultiSelection, bool acceptNonExistingFilename, string initialPath, string initialFilename, string title, string submitButtonText) { }

	[CalledBy(Type = "Manager.Customization+<OpenFileBrowserDialogAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	public static bool ShowLoadDialog(OnSuccess onSuccess, OnCancel onCancel, PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Load", string loadButtonText = "Select") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowser), Member = "ShowDialogInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool ShowSaveDialog(OnSuccess onSuccess, OnCancel onCancel, PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Save", string saveButtonText = "Save") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(FileBrowserItem), Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override ListItem SimpleFileBrowser.IListViewAdapter.CreateItem() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override int SimpleFileBrowser.IListViewAdapter.get_Count() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override float SimpleFileBrowser.IListViewAdapter.get_ItemHeight() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override OnItemClickedHandler SimpleFileBrowser.IListViewAdapter.get_OnItemClicked() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void SimpleFileBrowser.IListViewAdapter.set_OnItemClicked(OnItemClickedHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FileBrowser), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowserItem), Member = "SetSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private override void SimpleFileBrowser.IListViewAdapter.SetItemContent(ListItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileBrowserItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "SelectAllFiles", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void UpdateFilenameInputFieldWithSelection() { }

	[CalledBy(Type = typeof(FileBrowser), Member = "OnSubmitButtonClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool VerifyFilenameInput(string input, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[IteratorStateMachine(typeof(<WaitForLoadDialog>d__250))]
	public static IEnumerator WaitForLoadDialog(PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Load", string loadButtonText = "Select") { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[IteratorStateMachine(typeof(<WaitForSaveDialog>d__249))]
	public static IEnumerator WaitForSaveDialog(PickMode pickMode, bool allowMultiSelection = false, string initialPath = null, string initialFilename = null, string title = "Save", string saveButtonText = "Save") { }

}

