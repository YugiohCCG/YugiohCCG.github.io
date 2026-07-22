namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Text", 100)]
[RequireComponent(typeof(CanvasRenderer))]
public class Text : MaskableGraphic, ILayoutElement
{
	protected static Material s_DefaultText; //Field offset: 0x0
	[SerializeField]
	private FontData m_FontData; //Field offset: 0xE0
	[SerializeField]
	[TextArea(3, 10)]
	protected string m_Text; //Field offset: 0xE8
	private TextGenerator m_TextCache; //Field offset: 0xF0
	private TextGenerator m_TextCacheForLayout; //Field offset: 0xF8
	protected bool m_DisableFontTextureRebuiltCallback; //Field offset: 0x100
	private readonly UIVertex[] m_TempVerts; //Field offset: 0x108

	public bool alignByGeometry
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 55
	}

	public TextAnchor alignment
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public TextGenerator cachedTextGenerator
	{
		[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 172
	}

	public TextGenerator cachedTextGeneratorForLayout
	{
		[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 115
	}

	public override float flexibleHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public Font font
	{
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = "TMPro.TMP_InputField")]
		[CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "IsValidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "AssignDefaultFont", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 282
	}

	public int fontSize
	{
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = "TMPro.TMP_InputField")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerFoldout", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public FontStyle fontStyle
	{
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public HorizontalWrapMode horizontalOverflow
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CalledBy(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public float lineSpacing
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 31
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 90
	}

	public virtual Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Font), Member = "get_material", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 499
	}

	public override float minHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override float minWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public float pixelsPerUnit
	{
		[CalledBy(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 363
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 260
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 284
	}

	public bool resizeTextForBestFit
	{
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public int resizeTextMaxSize
	{
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public int resizeTextMinSize
	{
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public bool supportRichText
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	public override string text
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 229
	}

	public VerticalWrapMode verticalOverflow
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 81
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontData), Member = "get_defaultFontData", ReturnType = typeof(FontData))]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected Text() { }

	[CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	internal void AssignDefaultFont() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void AssignDefaultFontIfNecessary() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputVertical() { }

	[CalledBy(Type = typeof(FontUpdateTracker), Member = "RebuildForFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "Invalidate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void FontTextureChanged() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_alignByGeometry() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TextAnchor get_alignment() { }

	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public TextGenerator get_cachedTextGenerator() { }

	[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleWidth() { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = "TMPro.TMP_InputField")]
	[CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "IsValidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	public Font get_font() { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = "TMPro.TMP_InputField")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public int get_fontSize() { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public FontStyle get_fontStyle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public HorizontalWrapMode get_horizontalOverflow() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float get_lineSpacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Font), Member = "get_material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Texture get_mainTexture() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minWidth() { }

	[CalledBy(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public float get_pixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredWidth() { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_resizeTextForBestFit() { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_resizeTextMaxSize() { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = "TMPro.TextMeshProUGUI")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_resizeTextMinSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_supportRichText() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string get_text() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public VerticalWrapMode get_verticalOverflow() { }

	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "Invalidate", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings), typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "get_verts", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UIVertex>))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_alignByGeometry(bool value) { }

	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_alignment(TextAnchor value) { }

	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "AssignDefaultFont", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void set_font(Font value) { }

	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerFoldout", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fontSize(int value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fontStyle(FontStyle value) { }

	[CalledBy(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_lineSpacing(float value) { }

	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_resizeTextForBestFit(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_resizeTextMaxSize(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_resizeTextMinSize(int value) { }

	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_supportRichText(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override void set_text(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalOverflow(VerticalWrapMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UpdateGeometry() { }

}

