namespace TMPro;

[AddComponentMenu("Mesh/TextMeshPro - Text")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
[RequireComponent(typeof(MeshRenderer))]
public class TextMeshPro : TMP_Text, ILayoutElement
{
	private static ProfilerMarker k_GenerateTextMarker; //Field offset: 0x0
	private static ProfilerMarker k_SetArraySizesMarker; //Field offset: 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; //Field offset: 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; //Field offset: 0x18
	private static ProfilerMarker k_CharacterLookupMarker; //Field offset: 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; //Field offset: 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; //Field offset: 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; //Field offset: 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; //Field offset: 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; //Field offset: 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; //Field offset: 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; //Field offset: 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; //Field offset: 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; //Field offset: 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; //Field offset: 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; //Field offset: 0x78
	private static ProfilerMarker k_SavePageInfoMarker; //Field offset: 0x80
	private static ProfilerMarker k_SaveTextExtentMarker; //Field offset: 0x88
	private static ProfilerMarker k_SaveProcessingStatesMarker; //Field offset: 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; //Field offset: 0x98
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; //Field offset: 0xA0
	[SerializeField]
	internal int _SortingLayer; //Field offset: 0x6F0
	[SerializeField]
	internal int _SortingLayerID; //Field offset: 0x6F4
	[SerializeField]
	internal int _SortingOrder; //Field offset: 0x6F8
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x700
	[SerializeField]
	private bool m_hasFontAssetChanged; //Field offset: 0x708
	private float m_previousLossyScaleY; //Field offset: 0x70C
	[SerializeField]
	private Renderer m_renderer; //Field offset: 0x710
	private MeshFilter m_meshFilter; //Field offset: 0x718
	private bool m_isFirstAllocation; //Field offset: 0x720
	private int m_max_characters; //Field offset: 0x724
	private int m_max_numberOfLines; //Field offset: 0x728
	private TMP_SubMesh[] m_subTextObjects; //Field offset: 0x730
	[SerializeField]
	private MaskingTypes m_maskType; //Field offset: 0x738
	private Matrix4x4 m_EnvMapMatrix; //Field offset: 0x73C
	private Vector3[] m_RectTransformCorners; //Field offset: 0x780
	private bool m_isRegisteredForEvents; //Field offset: 0x788
	private Dictionary<Int32, Int32> materialIndexPairs; //Field offset: 0x790

	public virtual event Action<TMP_TextInfo> OnPreRenderText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public virtual bool autoSizeTextContainer
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 345
	}

	public MaskingTypes maskType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextMeshPro), Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes)}, ReturnType = typeof(void))]
		 set { } //Length: 14
	}

	public virtual Mesh mesh
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 193
	}

	public MeshFilter meshFilter
	{
		[CalledBy(Type = typeof(TextMeshPro), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 296
	}

	public Renderer renderer
	{
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	public int sortingLayerID
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Renderer), Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 139
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Renderer), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 436
	}

	public int sortingOrder
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Renderer), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 139
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 436
	}

	[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
	public TextContainer textContainer
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public Transform transform
	{
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static TextMeshPro() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextMeshPro() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TextMeshPro), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Character), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	protected virtual void Awake() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ClearMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void ClearMesh(bool updateMesh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void ComputeMarginSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void CreateMaterialInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void DestroySubMeshObjects() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisableMasking() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "UpdateMask", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnableMasking() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector3), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Vector3), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TMP_Text), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset), typeof(TMP_SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAnimator), Member = "StopAllAnimations", ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ClearPageInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ClearLineInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "set_firstVisibleCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 83)]
	[CallsUnknownMethods(Count = 121)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	protected override void GenerateTextMesh() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_autoSizeTextContainer() { }

	[CallerCount(Count = 0)]
	public MaskingTypes get_maskType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Mesh get_mesh() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public MeshFilter get_meshFilter() { }

	[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Renderer get_renderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int get_sortingLayerID() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int get_sortingOrder() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public TextContainer get_textContainer() { }

	[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Transform get_transform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual Bounds GetCompoundBounds() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual Material GetMaterial(Material mat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(TMP_Text), Member = "get_fontMaterial", ReturnType = typeof(Material))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	protected virtual Material[] GetMaterials(Material[] mats) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual Material[] GetSharedMaterials() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsDeduplicatedMethods(Count = 4)]
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TextMeshPro), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal virtual void InternalUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowCastingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "set_receiveShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_atlasTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void LoadFontAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "get_meshFilter", ReturnType = typeof(MeshFilter))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "get_meshFilter", ReturnType = typeof(MeshFilter))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "ForceMeshUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "InternalUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextMeshPro), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Renderer), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "UpdateMask", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPreRenderObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void OnTransformParentChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Rebuild(CanvasUpdate update) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void set_autoSizeTextContainer(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes)}, ReturnType = typeof(void))]
	public void set_maskType(MaskingTypes value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[CallsUnknownMethods(Count = 2)]
	public void set_sortingLayerID(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[CallsUnknownMethods(Count = 2)]
	public void set_sortingOrder(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void SetActiveSubMeshes(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Renderer), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual void SetAllDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_missingGlyphCharacter", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsIgnorableForLigature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "set_fallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "DoMissingGlyphCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset), typeof(TMP_SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_matchMaterialPreset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ClearUnusedVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteCharacter>))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsEmojiPresentationForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsEmoji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_emojiFallbackTextAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Asset>))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetTextElementFromTextAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_Asset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 71)]
	[ContainsUnimplementedInstructions]
	internal virtual int SetArraySizes(TextProcessingElement[] textProcessingArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void SetCulling() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void SetFaceColor(Color32 color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void SetLayoutDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "set_maskType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskingTypes), typeof(Vector4), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetMask(MaskingTypes maskType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetMaskCoordinates(Vector4 coords) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetMaterialDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_meshFilter", ReturnType = typeof(MeshFilter))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[CallsUnknownMethods(Count = 2)]
	private void SetMeshFilters(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void SetOutlineColor(Color32 color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void SetOutlineThickness(float thickness) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetPerspectiveCorrection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void SetShaderDepth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void SetSharedMaterial(Material mat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	protected virtual void SetSharedMaterials(Material[] materials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetVerticesDirty() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "InternalUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "GetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Material), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateEnvMapMatrix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void UpdateFontAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "EnableMasking", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UpdateMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMeshPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void UpdateMeshPadding() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "InternalUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void UpdateSDFScale(float scaleDelta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateSubMeshSortingLayerID(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateSubMeshSortingOrder(int order) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ClearUnusedVertices", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void UpdateVertexData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateEnvMapProperty() { }

}

