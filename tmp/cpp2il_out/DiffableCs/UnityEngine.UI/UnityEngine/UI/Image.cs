namespace UnityEngine.UI;

[AddComponentMenu("UI/Image", 11)]
[RequireComponent(typeof(CanvasRenderer))]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	internal enum FillMethod
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4,
	}

	internal enum Origin180
	{
		Bottom = 0,
		Left = 1,
		Top = 2,
		Right = 3,
	}

	internal enum Origin360
	{
		Bottom = 0,
		Right = 1,
		Top = 2,
		Left = 3,
	}

	internal enum Origin90
	{
		BottomLeft = 0,
		TopLeft = 1,
		TopRight = 2,
		BottomRight = 3,
	}

	internal enum OriginHorizontal
	{
		Left = 0,
		Right = 1,
	}

	internal enum OriginVertical
	{
		Bottom = 0,
		Top = 1,
	}

	internal enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
	}

	protected static Material s_ETC1DefaultUI; //Field offset: 0x0
	private static readonly Vector2[] s_VertScratch; //Field offset: 0x8
	private static readonly Vector2[] s_UVScratch; //Field offset: 0x10
	private static readonly Vector3[] s_Xy; //Field offset: 0x18
	private static readonly Vector3[] s_Uv; //Field offset: 0x20
	private static List<Image> m_TrackedTexturelessImages; //Field offset: 0x28
	private static bool s_Initialized; //Field offset: 0x30
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	private Sprite m_Sprite; //Field offset: 0xE0
	private Sprite m_OverrideSprite; //Field offset: 0xE8
	[SerializeField]
	private Type m_Type; //Field offset: 0xF0
	[SerializeField]
	private bool m_PreserveAspect; //Field offset: 0xF4
	[SerializeField]
	private bool m_FillCenter; //Field offset: 0xF5
	[SerializeField]
	private FillMethod m_FillMethod; //Field offset: 0xF8
	[Range(0, 1)]
	[SerializeField]
	private float m_FillAmount; //Field offset: 0xFC
	[SerializeField]
	private bool m_FillClockwise; //Field offset: 0x100
	[SerializeField]
	private int m_FillOrigin; //Field offset: 0x104
	private float m_AlphaHitTestMinimumThreshold; //Field offset: 0x108
	private bool m_Tracked; //Field offset: 0x10C
	[SerializeField]
	private bool m_UseSpriteMesh; //Field offset: 0x10D
	[SerializeField]
	private float m_PixelsPerUnitMultiplier; //Field offset: 0x110
	private float m_CachedReferencePixelsPerUnit; //Field offset: 0x114

	private Sprite activeSprite
	{
		[CallerCount(Count = 61)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		private get { } //Length: 122
	}

	public float alphaHitTestMinimumThreshold
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 342
	}

	public static Material defaultETC1GraphicMaterial
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 242
	}

	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	public float eventAlphaThreshold
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 358
	}

	public float fillAmount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "UpdatedTimerFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LoadingInfo", Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LoadingInfo", Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "OnStartHoldingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "OnStartHoldingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "OnStopHolding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass5_0", Member = "<DOFillAmount>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 130
	}

	public bool fillCenter
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	public bool fillClockwise
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	public FillMethod fillMethod
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 108
	}

	public int fillOrigin
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 98
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

	public bool hasBorder
	{
		[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 206
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 381
	}

	public virtual Material material
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 534
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 143
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

	protected float multipliedPixelsPerUnit
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		 get { } //Length: 30
	}

	public Sprite overrideSprite
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		 get { } //Length: 7
		[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 110
	}

	public float pixelsPerUnit
	{
		[CalledBy(Type = typeof(Image), Member = "get_multipliedPixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Image), Member = "SetNativeSize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Image), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 318
	}

	public float pixelsPerUnitMultiplier
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 257
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 256
	}

	public bool preserveAspect
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = "UI.Dates.DatePickerButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	public Sprite sprite
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 85)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
		[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 728
	}

	public Type type
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = "Manager.Helper", Member = "SetImageSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 98
	}

	public bool useSpriteMesh
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 101
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static Image() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	protected Image() { }

	[CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }

	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	public void DisableSpriteOptimizations() { }

	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Image), Member = "RadialCut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Vector3[]), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_triangles", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Sprite), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	[CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Texture), Member = "get_wrapMode", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void GenerateTiledSprite(VertexHelper toFill) { }

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	private Sprite get_activeSprite() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_alphaHitTestMinimumThreshold() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
	[CallsUnknownMethods(Count = 1)]
	public static Material get_defaultETC1GraphicMaterial() { }

	[CallerCount(Count = 0)]
	public float get_eventAlphaThreshold() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fillAmount() { }

	[CallerCount(Count = 0)]
	public bool get_fillCenter() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_fillClockwise() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FillMethod get_fillMethod() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_fillOrigin() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_flexibleWidth() { }

	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_hasBorder() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Texture get_mainTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual Material get_material() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_minWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	protected float get_multipliedPixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	public Sprite get_overrideSprite() { }

	[CalledBy(Type = typeof(Image), Member = "get_multipliedPixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "SetNativeSize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public float get_pixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_pixelsPerUnitMultiplier() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public override float get_preferredWidth() { }

	[CallerCount(Count = 0)]
	public bool get_preserveAspect() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_sprite() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Type get_type() { }

	[CallerCount(Count = 0)]
	public bool get_useSpriteMesh() { }

	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Vector4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	[CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 26)]
	[ContainsUnimplementedInstructions]
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	[CallerCount(Count = 0)]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnCanvasHierarchyChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[CalledBy(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 3)]
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Image), Member = "RadialCut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(float), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	[CalledBy(Type = typeof(Image), Member = "RadialCut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Vector3[]), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(SpriteAtlas), Member = "CanBindTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_alphaHitTestMinimumThreshold(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_eventAlphaThreshold(float value) { }

	[CalledBy(Type = "Scenes.General.LifePoints", Member = "UpdatedTimerFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LoadingInfo", Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LoadingInfo", Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "OnStartHoldingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "OnStartHoldingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "OnStopHolding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldCenter", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass5_0", Member = "<DOFillAmount>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_fillAmount(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_fillCenter(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_fillClockwise(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_fillMethod(FillMethod value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_fillOrigin(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_material(Material value) { }

	[CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_overrideSprite(Sprite value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_pixelsPerUnitMultiplier(float value) { }

	[CalledBy(Type = "UI.Dates.DatePickerButtonConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_preserveAspect(bool value) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_sprite(Sprite value) { }

	[CalledBy(Type = "Manager.Helper", Member = "SetImageSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_type(Type value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_useSpriteMesh(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void SetNativeSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void TrackImage(Image g) { }

	[CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void TrackSprite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static void UnTrackImage(Image g) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetAlphaTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UpdateMaterial() { }

}

