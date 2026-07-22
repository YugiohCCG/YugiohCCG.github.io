namespace UnityEngine.UIElements;

[HelpURL("UIE-Runtime-Panel-Settings")]
public class PanelSettings : ScriptableObject
{
	private class RuntimePanelAccess
	{
		private readonly PanelSettings m_Settings; //Field offset: 0x10
		private BaseRuntimePanel m_RuntimePanel; //Field offset: 0x18

		internal bool isInitialized
		{
			[CallerCount(Count = 14)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			internal get { } //Length: 9
		}

		internal BaseRuntimePanel panel
		{
			[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
			[CalledBy(Type = typeof(PanelSettings), Member = "set_bindingLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
			[CalledBy(Type = typeof(PanelSettings), Member = "get_visualTree", ReturnType = typeof(VisualElement))]
			[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UIDocument), Member = "AddOrRemoveRendererComponent", ReturnType = typeof(void))]
			[CallerCount(Count = 17)]
			[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
			[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
			[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
			[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 7)]
			internal get { } //Length: 971
		}

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal RuntimePanelAccess(PanelSettings settings) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private BaseRuntimePanel CreateRelatedRuntimePanel() { }

		[CalledBy(Type = typeof(PanelSettings), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "DisposePanel", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void DisposePanel() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
		private void DisposeRelatedPanel() { }

		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool get_isInitialized() { }

		[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = typeof(PanelSettings), Member = "set_bindingLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = typeof(PanelSettings), Member = "get_visualTree", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "AddOrRemoveRendererComponent", ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		internal BaseRuntimePanel get_panel() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MarkPotentiallyEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
		internal void MarkPotentiallyEmpty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void SetPanelChangeReceiver() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void SetSortingPriority() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void SetTargetDisplay() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void SetTargetTexture() { }

	}

	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	private const float k_DefaultScaleValue = 1; //Field offset: 0x0
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; //Field offset: 0x0
	private const float DefaultDpi = 96; //Field offset: 0x0
	[SerializeField]
	private ThemeStyleSheet themeUss; //Field offset: 0x18
	[SerializeField]
	private bool m_DisableNoThemeWarning; //Field offset: 0x20
	[SerializeField]
	private RenderTexture m_TargetTexture; //Field offset: 0x28
	[SerializeField]
	private PanelRenderMode m_RenderMode; //Field offset: 0x30
	[SerializeField]
	private int m_WorldSpaceLayer; //Field offset: 0x34
	[SerializeField]
	private PanelScaleMode m_ScaleMode; //Field offset: 0x38
	[SerializeField]
	private float m_ReferenceSpritePixelsPerUnit; //Field offset: 0x3C
	[SerializeField]
	private float m_PixelsPerUnit; //Field offset: 0x40
	[SerializeField]
	private float m_Scale; //Field offset: 0x44
	[SerializeField]
	private float m_ReferenceDpi; //Field offset: 0x48
	[SerializeField]
	private float m_FallbackDpi; //Field offset: 0x4C
	[SerializeField]
	private Vector2Int m_ReferenceResolution; //Field offset: 0x50
	[SerializeField]
	private PanelScreenMatchMode m_ScreenMatchMode; //Field offset: 0x58
	[Range(0, 1)]
	[SerializeField]
	private float m_Match; //Field offset: 0x5C
	[SerializeField]
	private float m_SortingOrder; //Field offset: 0x60
	[SerializeField]
	private int m_TargetDisplay; //Field offset: 0x64
	[SerializeField]
	private BindingLogLevel m_BindingLogLevel; //Field offset: 0x68
	[SerializeField]
	private bool m_ClearDepthStencil; //Field offset: 0x6C
	[SerializeField]
	private bool m_ClearColor; //Field offset: 0x6D
	[SerializeField]
	private Color m_ColorClearValue; //Field offset: 0x70
	[SerializeField]
	private uint m_VertexBudget; //Field offset: 0x80
	private RuntimePanelAccess m_PanelAccess; //Field offset: 0x88
	internal UIDocumentList m_AttachedUIDocumentsList; //Field offset: 0x90
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasSettings m_DynamicAtlasSettings; //Field offset: 0x98
	[HideInInspector]
	[SerializeField]
	private Shader m_AtlasBlitShader; //Field offset: 0xA0
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeShader; //Field offset: 0xA8
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeWorldShader; //Field offset: 0xB0
	[HideInInspector]
	[SerializeField]
	private Shader m_SDFShader; //Field offset: 0xB8
	[HideInInspector]
	[SerializeField]
	private Shader m_BitmapShader; //Field offset: 0xC0
	[HideInInspector]
	[SerializeField]
	private Shader m_SpriteShader; //Field offset: 0xC8
	[HideInInspector]
	[SerializeField]
	internal TextAsset m_ICUDataAsset; //Field offset: 0xD0
	[SerializeField]
	public bool forceGammaRendering; //Field offset: 0xD8
	[SerializeField]
	public PanelTextSettings textSettings; //Field offset: 0xE0
	private Rect m_TargetRect; //Field offset: 0xE8
	private float m_ResolvedScale; //Field offset: 0xF8
	private StyleSheet m_OldThemeUss; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <ScreenDPI>k__BackingField; //Field offset: 0x108
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0x110
	private Func<Vector2, Vector2> m_AssignedScreenToPanel; //Field offset: 0x118

	public BindingLogLevel bindingLogLevel
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(Binding), Member = "SetPanelLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(BindingLogLevel)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 64
	}

	public bool clearColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool clearDepthStencil
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Color colorClearValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public float depthClearValue
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public DynamicAtlasSettings dynamicAtlasSettings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public float fallbackDpi
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 41
	}

	internal bool isInitialized
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 22
	}

	public float match
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	internal BaseRuntimePanel panel
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 32
	}

	internal float pixelsPerUnit
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 6
	}

	public float referenceDpi
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 41
	}

	public Vector2Int referenceResolution
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float referenceSpritePixelsPerUnit
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public PanelRenderMode renderMode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float scale
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public PanelScaleMode scaleMode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	private float ScreenDPI
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public PanelScreenMatchMode screenMatchMode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float sortingOrder
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 68
	}

	public int targetDisplay
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 58
	}

	public RenderTexture targetTexture
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 93
	}

	public ThemeStyleSheet themeStyleSheet
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 40
	}

	public uint vertexBudget
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	internal VisualElement visualTree
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 57
	}

	internal int worldSpaceLayer
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private PanelSettings() { }

	[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(RuntimePanel), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_maxSubTextureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_maxAtlasSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_minAtlasSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "set_logLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(LayoutConfig), Member = "get_PointScaleFactor", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleLength), Member = "get_value", ReturnType = typeof(Length))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_activeFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicAtlasFilters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_customFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicAtlasCustomFilter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal void ApplyPanelSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ApplySortingOrder() { }

	[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(PanelSettings), Member = "set_themeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThemeStyleSheet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleSheets", ReturnType = typeof(VisualElementStyleSheetSet))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyThemeStyleSheet(VisualElement root = null) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal bool AssignICUData() { }

	[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocumentList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MarkPotentiallyEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void DetachUIDocument(UIDocument uiDocument) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "DisposePanel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void DisposePanel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BindingLogLevel get_bindingLogLevel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_clearColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_clearDepthStencil() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_colorClearValue() { }

	[CallerCount(Count = 0)]
	public float get_depthClearValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fallbackDpi() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isInitialized() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_match() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CallsUnknownMethods(Count = 1)]
	internal BaseRuntimePanel get_panel() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	internal float get_pixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_referenceDpi() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Vector2Int get_referenceResolution() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public float get_referenceSpritePixelsPerUnit() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public PanelRenderMode get_renderMode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_scale() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public PanelScaleMode get_scaleMode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private float get_ScreenDPI() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public PanelScreenMatchMode get_screenMatchMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_sortingOrder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_targetDisplay() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public RenderTexture get_targetTexture() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public ThemeStyleSheet get_themeStyleSheet() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint get_vertexBudget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal VisualElement get_visualTree() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_worldSpaceLayer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal Rect GetDisplayRect() { }

	[CallerCount(Count = 0)]
	internal IDebugPanelChangeReceiver GetPanelChangeReceiver() { }

	[CalledBy(Type = typeof(PanelSettings), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeShaders() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "DisposePanel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Calls(Type = typeof(PanelSettings), Member = "InitializeShaders", ReturnType = typeof(void))]
	private void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void Reset() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(Binding), Member = "SetPanelLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(BindingLogLevel)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_bindingLogLevel(BindingLogLevel value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_clearColor(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_clearDepthStencil(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_colorClearValue(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fallbackDpi(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_match(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_pixelsPerUnit(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_referenceDpi(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_referenceResolution(Vector2Int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_renderMode(PanelRenderMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_scale(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_scaleMode(PanelScaleMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_ScreenDPI(float value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_sortingOrder(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_targetDisplay(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void set_targetTexture(RenderTexture value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_vertexBudget(uint value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_worldSpaceLayer(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_PROFILER")]
	public void SetPanelChangeReceiver(IDebugPanelChangeReceiver value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CallsUnknownMethods(Count = 3)]
	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	internal void UpdateScreenDPI() { }

}

