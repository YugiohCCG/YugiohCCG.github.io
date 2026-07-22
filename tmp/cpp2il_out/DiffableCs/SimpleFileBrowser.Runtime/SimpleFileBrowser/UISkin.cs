namespace SimpleFileBrowser;

[CreateAssetMenu(fileName = "UI Skin", menuName = "yasirkula/SimpleFileBrowser/UI Skin", order = 111)]
public class UISkin : ScriptableObject
{
	private int m_version; //Field offset: 0x18
	[Header("General")]
	[SerializeField]
	private Font m_font; //Field offset: 0x20
	[SerializeField]
	private int m_fontSize; //Field offset: 0x28
	[Header("File Browser Window")]
	[SerializeField]
	private Color m_windowColor; //Field offset: 0x2C
	[SerializeField]
	private Color m_filesListColor; //Field offset: 0x3C
	[SerializeField]
	private Color m_filesVerticalSeparatorColor; //Field offset: 0x4C
	[SerializeField]
	private Color m_titleBackgroundColor; //Field offset: 0x5C
	[SerializeField]
	private Color m_titleTextColor; //Field offset: 0x6C
	[SerializeField]
	private Color m_windowResizeGizmoColor; //Field offset: 0x7C
	[SerializeField]
	private Color m_headerButtonsColor; //Field offset: 0x8C
	[SerializeField]
	private Sprite m_windowResizeGizmo; //Field offset: 0xA0
	[SerializeField]
	private Sprite m_headerBackButton; //Field offset: 0xA8
	[SerializeField]
	private Sprite m_headerForwardButton; //Field offset: 0xB0
	[SerializeField]
	private Sprite m_headerUpButton; //Field offset: 0xB8
	[SerializeField]
	private Sprite m_headerContextMenuButton; //Field offset: 0xC0
	[Header("Input Fields")]
	[SerializeField]
	private Color m_inputFieldNormalBackgroundColor; //Field offset: 0xC8
	[SerializeField]
	private Color m_inputFieldInvalidBackgroundColor; //Field offset: 0xD8
	[SerializeField]
	private Color m_inputFieldTextColor; //Field offset: 0xE8
	[SerializeField]
	private Color m_inputFieldPlaceholderTextColor; //Field offset: 0xF8
	[SerializeField]
	private Color m_inputFieldSelectedTextColor; //Field offset: 0x108
	[SerializeField]
	private Color m_inputFieldCaretColor; //Field offset: 0x118
	[SerializeField]
	private Sprite m_inputFieldBackground; //Field offset: 0x128
	[Header("Buttons")]
	[SerializeField]
	private Color m_buttonColor; //Field offset: 0x130
	[SerializeField]
	private Color m_buttonTextColor; //Field offset: 0x140
	[SerializeField]
	private Sprite m_buttonBackground; //Field offset: 0x150
	[Header("Dropdowns")]
	[SerializeField]
	private Color m_dropdownColor; //Field offset: 0x158
	[SerializeField]
	private Color m_dropdownTextColor; //Field offset: 0x168
	[SerializeField]
	private Color m_dropdownArrowColor; //Field offset: 0x178
	[SerializeField]
	private Color m_dropdownCheckmarkColor; //Field offset: 0x188
	[SerializeField]
	private Sprite m_dropdownBackground; //Field offset: 0x198
	[SerializeField]
	private Sprite m_dropdownArrow; //Field offset: 0x1A0
	[SerializeField]
	private Sprite m_dropdownCheckmark; //Field offset: 0x1A8
	[Header("Toggles")]
	[SerializeField]
	private Color m_toggleColor; //Field offset: 0x1B0
	[SerializeField]
	private Color m_toggleTextColor; //Field offset: 0x1C0
	[SerializeField]
	private Color m_toggleCheckmarkColor; //Field offset: 0x1D0
	[SerializeField]
	private Sprite m_toggleBackground; //Field offset: 0x1E0
	[SerializeField]
	private Sprite m_toggleCheckmark; //Field offset: 0x1E8
	[Header("Scrollbars")]
	[SerializeField]
	private Color m_scrollbarBackgroundColor; //Field offset: 0x1F0
	[SerializeField]
	private Color m_scrollbarColor; //Field offset: 0x200
	[Header("Files")]
	[SerializeField]
	private float m_fileHeight; //Field offset: 0x210
	[SerializeField]
	private float m_fileIconsPadding; //Field offset: 0x214
	[SerializeField]
	private Color m_fileNormalBackgroundColor; //Field offset: 0x218
	[SerializeField]
	private Color m_fileAlternatingBackgroundColor; //Field offset: 0x228
	[SerializeField]
	private Color m_fileHoveredBackgroundColor; //Field offset: 0x238
	[SerializeField]
	private Color m_fileSelectedBackgroundColor; //Field offset: 0x248
	[SerializeField]
	private Color m_fileNormalTextColor; //Field offset: 0x258
	[SerializeField]
	private Color m_fileSelectedTextColor; //Field offset: 0x268
	[Header("File Icons")]
	[SerializeField]
	private Sprite m_folderIcon; //Field offset: 0x278
	[SerializeField]
	private Sprite m_driveIcon; //Field offset: 0x280
	[SerializeField]
	private Sprite m_defaultFileIcon; //Field offset: 0x288
	[SerializeField]
	private FiletypeIcon[] m_filetypeIcons; //Field offset: 0x290
	private bool initializedFiletypeIcons; //Field offset: 0x298
	private Dictionary<String, Sprite> filetypeToIcon; //Field offset: 0x2A0
	private bool m_allIconExtensionsHaveSingleSuffix; //Field offset: 0x2A8
	[SerializeField]
	private Sprite m_fileMultiSelectionToggleOffIcon; //Field offset: 0x2B0
	[SerializeField]
	private Sprite m_fileMultiSelectionToggleOnIcon; //Field offset: 0x2B8
	[Header("Context Menu")]
	[SerializeField]
	private Color m_contextMenuBackgroundColor; //Field offset: 0x2C0
	[SerializeField]
	private Color m_contextMenuTextColor; //Field offset: 0x2D0
	[SerializeField]
	private Color m_contextMenuSeparatorColor; //Field offset: 0x2E0
	[Header("Delete Confirmation Panel")]
	[SerializeField]
	private Color m_deletePanelBackgroundColor; //Field offset: 0x2F0
	[SerializeField]
	private Color m_deletePanelTextColor; //Field offset: 0x300
	[SerializeField]
	private Sprite m_deletePanelBackground; //Field offset: 0x310

	public bool AllIconExtensionsHaveSingleSuffix
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
		 get { } //Length: 51
	}

	public Sprite ButtonBackground
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color ButtonColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ButtonTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ContextMenuBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ContextMenuSeparatorColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ContextMenuTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Sprite DefaultFileIcon
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite DeletePanelBackground
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color DeletePanelBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color DeletePanelTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Sprite DriveIcon
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite DropdownArrow
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color DropdownArrowColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Sprite DropdownBackground
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite DropdownCheckmark
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color DropdownCheckmarkColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color DropdownColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color DropdownTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color FileAlternatingBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public float FileHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 27
	}

	public Color FileHoveredBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public float FileIconsPadding
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 27
	}

	public Sprite FileMultiSelectionToggleOffIcon
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite FileMultiSelectionToggleOnIcon
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color FileNormalBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color FileNormalTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color FileSelectedBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color FileSelectedTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color FilesListColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 100
	}

	public Color FilesVerticalSeparatorColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 100
	}

	public FiletypeIcon[] FiletypeIcons
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 53
	}

	public Sprite FolderIcon
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Font Font
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 127
	}

	public int FontSize
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 12
	}

	public Sprite HeaderBackButton
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color HeaderButtonsColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Sprite HeaderContextMenuButton
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite HeaderForwardButton
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite HeaderUpButton
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite InputFieldBackground
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color InputFieldCaretColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color InputFieldInvalidBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color InputFieldNormalBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color InputFieldPlaceholderTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color InputFieldSelectedTextColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color InputFieldTextColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ScrollbarBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ScrollbarColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color TitleBackgroundColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 100
	}

	public Color TitleTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 100
	}

	public Sprite ToggleBackground
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Sprite ToggleCheckmark
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color ToggleCheckmarkColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ToggleColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public Color ToggleTextColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 115
	}

	public int Version
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Color WindowColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 100
	}

	public Sprite WindowResizeGizmo
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 136
	}

	public Color WindowResizeGizmoColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 109
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	public UISkin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTo(Scrollbar scrollbar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTo(Text text, Color textColor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyTo(Toggle toggle) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_selectionColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputField), Member = "set_caretColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyTo(InputField inputField) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTo(Dropdown dropdown) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserDeleteConfirmationPanel), Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UISkin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTo(Button button) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	public bool get_AllIconExtensionsHaveSingleSuffix() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_ButtonBackground() { }

	[CallerCount(Count = 0)]
	public Color get_ButtonColor() { }

	[CallerCount(Count = 0)]
	public Color get_ButtonTextColor() { }

	[CallerCount(Count = 0)]
	public Color get_ContextMenuBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_ContextMenuSeparatorColor() { }

	[CallerCount(Count = 0)]
	public Color get_ContextMenuTextColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_DefaultFileIcon() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_DeletePanelBackground() { }

	[CallerCount(Count = 0)]
	public Color get_DeletePanelBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_DeletePanelTextColor() { }

	[CallerCount(Count = 0)]
	public Sprite get_DriveIcon() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_DropdownArrow() { }

	[CallerCount(Count = 0)]
	public Color get_DropdownArrowColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_DropdownBackground() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_DropdownCheckmark() { }

	[CallerCount(Count = 0)]
	public Color get_DropdownCheckmarkColor() { }

	[CallerCount(Count = 0)]
	public Color get_DropdownColor() { }

	[CallerCount(Count = 0)]
	public Color get_DropdownTextColor() { }

	[CallerCount(Count = 0)]
	public Color get_FileAlternatingBackgroundColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_FileHeight() { }

	[CallerCount(Count = 0)]
	public Color get_FileHoveredBackgroundColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_FileIconsPadding() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_FileMultiSelectionToggleOffIcon() { }

	[CallerCount(Count = 0)]
	public Sprite get_FileMultiSelectionToggleOnIcon() { }

	[CallerCount(Count = 0)]
	public Color get_FileNormalBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_FileNormalTextColor() { }

	[CallerCount(Count = 0)]
	public Color get_FileSelectedBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_FileSelectedTextColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_FilesListColor() { }

	[CallerCount(Count = 0)]
	public Color get_FilesVerticalSeparatorColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FiletypeIcon[] get_FiletypeIcons() { }

	[CallerCount(Count = 0)]
	public Sprite get_FolderIcon() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Font get_Font() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_FontSize() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public Sprite get_HeaderBackButton() { }

	[CallerCount(Count = 0)]
	public Color get_HeaderButtonsColor() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Sprite get_HeaderContextMenuButton() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Sprite get_HeaderForwardButton() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public Sprite get_HeaderUpButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_InputFieldBackground() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_InputFieldCaretColor() { }

	[CallerCount(Count = 0)]
	public Color get_InputFieldInvalidBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_InputFieldNormalBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_InputFieldPlaceholderTextColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_InputFieldSelectedTextColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_InputFieldTextColor() { }

	[CallerCount(Count = 0)]
	public Color get_ScrollbarBackgroundColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_ScrollbarColor() { }

	[CallerCount(Count = 0)]
	public Color get_TitleBackgroundColor() { }

	[CallerCount(Count = 0)]
	public Color get_TitleTextColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_ToggleBackground() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_ToggleCheckmark() { }

	[CallerCount(Count = 0)]
	public Color get_ToggleCheckmarkColor() { }

	[CallerCount(Count = 0)]
	public Color get_ToggleColor() { }

	[CallerCount(Count = 0)]
	public Color get_ToggleTextColor() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Version() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_WindowColor() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Sprite get_WindowResizeGizmo() { }

	[CallerCount(Count = 0)]
	public Color get_WindowResizeGizmoColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISkin), Member = "InitializeFiletypeIcons", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public Sprite GetIconForFileEntry(FileSystemEntry fileInfo, bool extensionMayHaveMultipleSuffixes) { }

	[CalledBy(Type = typeof(FileBrowser), Member = "get_AllExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowser), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(UISkin), Member = "get_AllIconExtensionsHaveSingleSuffix", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UISkin), Member = "GetIconForFileEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry), typeof(bool)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void InitializeFiletypeIcons() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContextMenu("Refresh UI")]
	private void Invalidate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_ButtonBackground(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ButtonColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ButtonTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ContextMenuBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ContextMenuSeparatorColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ContextMenuTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_DefaultFileIcon(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_DeletePanelBackground(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_DeletePanelBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_DeletePanelTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_DriveIcon(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_DropdownArrow(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_DropdownArrowColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_DropdownBackground(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_DropdownCheckmark(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_DropdownCheckmarkColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_DropdownColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_DropdownTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileAlternatingBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileHeight(float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileHoveredBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileIconsPadding(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_FileMultiSelectionToggleOffIcon(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_FileMultiSelectionToggleOnIcon(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileNormalBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileNormalTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileSelectedBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FileSelectedTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FilesListColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_FilesVerticalSeparatorColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_FiletypeIcons(FiletypeIcon[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_FolderIcon(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Font(Font value) { }

	[CallerCount(Count = 0)]
	public void set_FontSize(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_HeaderBackButton(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_HeaderButtonsColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_HeaderContextMenuButton(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_HeaderForwardButton(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_HeaderUpButton(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_InputFieldBackground(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_InputFieldCaretColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_InputFieldInvalidBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_InputFieldNormalBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_InputFieldPlaceholderTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_InputFieldSelectedTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_InputFieldTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ScrollbarBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ScrollbarColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_TitleBackgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_TitleTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_ToggleBackground(Sprite value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_ToggleCheckmark(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ToggleCheckmarkColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ToggleColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_ToggleTextColor(Color value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_WindowColor(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_WindowResizeGizmo(Sprite value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_WindowResizeGizmoColor(Color value) { }

}

