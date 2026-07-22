namespace TMPro;

public abstract class TMP_Text : MaskableGraphic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<TMP_TextInfo> <>9__648_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__648_0(TMP_TextInfo <p0>) { }

	}

	internal struct CharacterSubstitution
	{
		public int index; //Field offset: 0x0
		public uint unicode; //Field offset: 0x4

		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		public CharacterSubstitution(int index, uint unicode) { }

	}

	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public MissingCharacterEventCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent) { }

	}

	internal struct SpecialCharacter
	{
		public TMP_Character character; //Field offset: 0x0
		public TMP_FontAsset fontAsset; //Field offset: 0x8
		public Material material; //Field offset: 0x10
		public int materialIndex; //Field offset: 0x18

		[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		public SpecialCharacter(TMP_Character character, int materialIndex) { }

	}

	[DefaultMember("Item")]
	private struct TextBackingContainer
	{
		private UInt32[] m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x8

		public int Capacity
		{
			[CallerCount(Count = 24)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 25
		}

		public int Count
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public uint Item
		{
			[CallerCount(Count = 49)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 42
			[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
			[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
			[CalledBy(Type = typeof(TMP_Text), Member = "AddIntegerToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 36)]
			[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			 set { } //Length: 91
		}

		public UInt32[] Text
		{
			[CallerCount(Count = 138)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CalledBy(Type = typeof(TMP_Text), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public TextBackingContainer(int size) { }

		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int get_Capacity() { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		public int get_Count() { }

		[CallerCount(Count = 49)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public uint get_Item(int index) { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public UInt32[] get_Text() { }

		[CalledBy(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		public void Resize(int size) { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		public void set_Count(int value) { }

		[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "AddIntegerToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void set_Item(int index, uint value) { }

	}

	public enum TextInputSources
	{
		TextInputBox = 0,
		SetText = 1,
		SetTextArray = 2,
		TextString = 3,
	}

	[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
	public struct TextProcessingElement
	{
		public TextProcessingElementType elementType; //Field offset: 0x0
		public uint unicode; //Field offset: 0x4
		public int stringIndex; //Field offset: 0x8
		public int length; //Field offset: 0xC

	}

	protected static MaterialReference[] m_materialReferences; //Field offset: 0x0
	protected static Dictionary<Int32, Int32> m_materialReferenceIndexLookup; //Field offset: 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; //Field offset: 0x10
	protected static Color32 s_colorWhite; //Field offset: 0x68
	[CompilerGenerated]
	private static Func<Int32, String, TMP_FontAsset> OnFontAssetRequest; //Field offset: 0x70
	[CompilerGenerated]
	private static Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest; //Field offset: 0x78
	[CompilerGenerated]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x80
	private static Char[] m_htmlTag; //Field offset: 0x88
	private static RichTextTagAttribute[] m_xmlAttribute; //Field offset: 0x90
	private static Single[] m_attributeParameterValues; //Field offset: 0x98
	internal static WordWrapState m_SavedWordWrapState; //Field offset: 0xA0
	internal static WordWrapState m_SavedLineState; //Field offset: 0x458
	internal static WordWrapState m_SavedEllipsisState; //Field offset: 0x810
	internal static WordWrapState m_SavedLastValidState; //Field offset: 0xBC8
	internal static WordWrapState m_SavedSoftLineBreakState; //Field offset: 0xF80
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_text; //Field offset: 0xE0
	private bool m_IsTextBackingStringDirty; //Field offset: 0xE8
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; //Field offset: 0xF0
	[SerializeField]
	protected bool m_isRightToLeft; //Field offset: 0xF8
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; //Field offset: 0x100
	protected TMP_FontAsset m_currentFontAsset; //Field offset: 0x108
	protected bool m_isSDFShader; //Field offset: 0x110
	[SerializeField]
	protected Material m_sharedMaterial; //Field offset: 0x118
	protected Material m_currentMaterial; //Field offset: 0x120
	protected int m_currentMaterialIndex; //Field offset: 0x128
	[SerializeField]
	protected Material[] m_fontSharedMaterials; //Field offset: 0x130
	[SerializeField]
	protected Material m_fontMaterial; //Field offset: 0x138
	[SerializeField]
	protected Material[] m_fontMaterials; //Field offset: 0x140
	protected bool m_isMaterialDirty; //Field offset: 0x148
	[SerializeField]
	protected Color32 m_fontColor32; //Field offset: 0x14C
	[SerializeField]
	protected Color m_fontColor; //Field offset: 0x150
	protected Color32 m_underlineColor; //Field offset: 0x160
	protected Color32 m_strikethroughColor; //Field offset: 0x164
	internal HighlightState m_HighlightState; //Field offset: 0x168
	internal bool m_ConvertToLinearSpace; //Field offset: 0x17C
	[SerializeField]
	protected bool m_enableVertexGradient; //Field offset: 0x17D
	[SerializeField]
	protected ColorMode m_colorMode; //Field offset: 0x180
	[SerializeField]
	protected VertexGradient m_fontColorGradient; //Field offset: 0x184
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; //Field offset: 0x1C8
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; //Field offset: 0x1D0
	[SerializeField]
	protected bool m_tintAllSprites; //Field offset: 0x1D8
	protected bool m_tintSprite; //Field offset: 0x1D9
	protected Color32 m_spriteColor; //Field offset: 0x1DC
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; //Field offset: 0x1E0
	internal TMP_Style m_TextStyle; //Field offset: 0x1E8
	[SerializeField]
	protected int m_TextStyleHashCode; //Field offset: 0x1F0
	[SerializeField]
	protected bool m_overrideHtmlColors; //Field offset: 0x1F4
	[SerializeField]
	protected Color32 m_faceColor; //Field offset: 0x1F8
	protected Color32 m_outlineColor; //Field offset: 0x1FC
	protected float m_outlineWidth; //Field offset: 0x200
	protected Vector3 m_currentEnvMapRotation; //Field offset: 0x204
	protected bool m_hasEnvMapProperty; //Field offset: 0x210
	[SerializeField]
	protected float m_fontSize; //Field offset: 0x214
	protected float m_currentFontSize; //Field offset: 0x218
	[SerializeField]
	protected float m_fontSizeBase; //Field offset: 0x21C
	protected TMP_TextProcessingStack<Single> m_sizeStack; //Field offset: 0x220
	[SerializeField]
	protected FontWeight m_fontWeight; //Field offset: 0x240
	protected FontWeight m_FontWeightInternal; //Field offset: 0x244
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; //Field offset: 0x248
	[SerializeField]
	protected bool m_enableAutoSizing; //Field offset: 0x268
	protected float m_maxFontSize; //Field offset: 0x26C
	protected float m_minFontSize; //Field offset: 0x270
	protected int m_AutoSizeIterationCount; //Field offset: 0x274
	protected int m_AutoSizeMaxIterationCount; //Field offset: 0x278
	protected bool m_IsAutoSizePointSizeSet; //Field offset: 0x27C
	[SerializeField]
	protected float m_fontSizeMin; //Field offset: 0x280
	[SerializeField]
	protected float m_fontSizeMax; //Field offset: 0x284
	[SerializeField]
	protected FontStyles m_fontStyle; //Field offset: 0x288
	protected FontStyles m_FontStyleInternal; //Field offset: 0x28C
	protected TMP_FontStyleStack m_fontStyleStack; //Field offset: 0x290
	protected bool m_isUsingBold; //Field offset: 0x29A
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; //Field offset: 0x29C
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; //Field offset: 0x2A0
	[FormerlySerializedAs("m_lineJustification")]
	[SerializeField]
	protected TextAlignmentOptions m_textAlignment; //Field offset: 0x2A4
	protected HorizontalAlignmentOptions m_lineJustification; //Field offset: 0x2A8
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; //Field offset: 0x2B0
	protected Vector3[] m_textContainerLocalCorners; //Field offset: 0x2D0
	[SerializeField]
	protected float m_characterSpacing; //Field offset: 0x2D8
	protected float m_cSpacing; //Field offset: 0x2DC
	protected float m_monoSpacing; //Field offset: 0x2E0
	protected bool m_duoSpace; //Field offset: 0x2E4
	[SerializeField]
	 float m_characterHorizontalScale; //Field offset: 0x2E8
	[SerializeField]
	protected float m_wordSpacing; //Field offset: 0x2EC
	[SerializeField]
	protected float m_lineSpacing; //Field offset: 0x2F0
	protected float m_lineSpacingDelta; //Field offset: 0x2F4
	protected float m_lineHeight; //Field offset: 0x2F8
	protected bool m_IsDrivenLineSpacing; //Field offset: 0x2FC
	[SerializeField]
	protected float m_lineSpacingMax; //Field offset: 0x300
	[SerializeField]
	protected float m_paragraphSpacing; //Field offset: 0x304
	[SerializeField]
	protected float m_charWidthMaxAdj; //Field offset: 0x308
	protected float m_charWidthAdjDelta; //Field offset: 0x30C
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	protected TextWrappingModes m_TextWrappingMode; //Field offset: 0x310
	protected bool m_isCharacterWrappingEnabled; //Field offset: 0x314
	protected bool m_isNonBreakingSpace; //Field offset: 0x315
	protected bool m_isIgnoringAlignment; //Field offset: 0x316
	[SerializeField]
	protected float m_wordWrappingRatios; //Field offset: 0x318
	[SerializeField]
	protected TextOverflowModes m_overflowMode; //Field offset: 0x31C
	protected int m_firstOverflowCharacterIndex; //Field offset: 0x320
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; //Field offset: 0x328
	[SerializeField]
	internal TMP_Text parentLinkedComponent; //Field offset: 0x330
	protected bool m_isTextTruncated; //Field offset: 0x338
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0x1338
	[SerializeField]
	protected bool m_enableKerning; //Field offset: 0x339
	protected int m_LastBaseGlyphIndex; //Field offset: 0x33C
	[SerializeField]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x340
	[SerializeField]
	protected bool m_enableExtraPadding; //Field offset: 0x348
	[SerializeField]
	protected bool checkPaddingRequired; //Field offset: 0x349
	[SerializeField]
	protected bool m_isRichText; //Field offset: 0x34A
	[SerializeField]
	private bool m_EmojiFallbackSupport; //Field offset: 0x34B
	[SerializeField]
	protected bool m_parseCtrlCharacters; //Field offset: 0x34C
	protected bool m_isOverlay; //Field offset: 0x34D
	[SerializeField]
	protected bool m_isOrthographic; //Field offset: 0x34E
	[SerializeField]
	protected bool m_isCullingEnabled; //Field offset: 0x34F
	protected bool m_isMaskingEnabled; //Field offset: 0x350
	protected bool isMaskUpdateRequired; //Field offset: 0x351
	protected bool m_ignoreCulling; //Field offset: 0x352
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; //Field offset: 0x354
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; //Field offset: 0x358
	[SerializeField]
	protected float m_uvLineOffset; //Field offset: 0x35C
	protected TextRenderFlags m_renderMode; //Field offset: 0x360
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; //Field offset: 0x364
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; //Field offset: 0x368
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x369
	protected int m_firstVisibleCharacter; //Field offset: 0x36C
	protected int m_maxVisibleCharacters; //Field offset: 0x370
	protected int m_maxVisibleWords; //Field offset: 0x374
	protected int m_maxVisibleLines; //Field offset: 0x378
	[SerializeField]
	protected bool m_useMaxVisibleDescender; //Field offset: 0x37C
	[SerializeField]
	protected int m_pageToDisplay; //Field offset: 0x380
	protected bool m_isNewPage; //Field offset: 0x384
	[SerializeField]
	protected Vector4 m_margin; //Field offset: 0x388
	protected float m_marginLeft; //Field offset: 0x398
	protected float m_marginRight; //Field offset: 0x39C
	protected float m_marginWidth; //Field offset: 0x3A0
	protected float m_marginHeight; //Field offset: 0x3A4
	protected float m_width; //Field offset: 0x3A8
	protected TMP_TextInfo m_textInfo; //Field offset: 0x3B0
	protected bool m_havePropertiesChanged; //Field offset: 0x3B8
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; //Field offset: 0x3B9
	protected Transform m_transform; //Field offset: 0x3C0
	protected RectTransform m_rectTransform; //Field offset: 0x3C8
	protected Vector2 m_PreviousRectTransformSize; //Field offset: 0x3D0
	protected Vector2 m_PreviousPivotPosition; //Field offset: 0x3D8
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; //Field offset: 0x3E0
	protected bool m_autoSizeTextContainer; //Field offset: 0x3E1
	protected Mesh m_mesh; //Field offset: 0x3E8
	[SerializeField]
	protected bool m_isVolumetricText; //Field offset: 0x3F0
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x3F8
	protected TMP_SpriteAnimator m_spriteAnimator; //Field offset: 0x400
	protected float m_flexibleHeight; //Field offset: 0x408
	protected float m_flexibleWidth; //Field offset: 0x40C
	protected float m_minWidth; //Field offset: 0x410
	protected float m_minHeight; //Field offset: 0x414
	protected float m_maxWidth; //Field offset: 0x418
	protected float m_maxHeight; //Field offset: 0x41C
	protected LayoutElement m_LayoutElement; //Field offset: 0x420
	protected float m_preferredWidth; //Field offset: 0x428
	protected float m_RenderedWidth; //Field offset: 0x42C
	protected bool m_isPreferredWidthDirty; //Field offset: 0x430
	protected float m_preferredHeight; //Field offset: 0x434
	protected float m_RenderedHeight; //Field offset: 0x438
	protected bool m_isPreferredHeightDirty; //Field offset: 0x43C
	protected bool m_isCalculatingPreferredValues; //Field offset: 0x43D
	protected int m_layoutPriority; //Field offset: 0x440
	protected bool m_isLayoutDirty; //Field offset: 0x444
	protected bool m_isAwake; //Field offset: 0x445
	internal bool m_isWaitingOnResourceLoad; //Field offset: 0x446
	internal TextInputSources m_inputSource; //Field offset: 0x448
	protected float m_fontScaleMultiplier; //Field offset: 0x44C
	protected float tag_LineIndent; //Field offset: 0x450
	protected float tag_Indent; //Field offset: 0x454
	protected TMP_TextProcessingStack<Single> m_indentStack; //Field offset: 0x458
	protected bool tag_NoParsing; //Field offset: 0x478
	protected bool m_isTextLayoutPhase; //Field offset: 0x479
	protected Quaternion m_FXRotation; //Field offset: 0x47C
	protected Vector3 m_FXScale; //Field offset: 0x48C
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x498
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x4A0
	private TMP_CharacterInfo[] m_internalCharacterInfo; //Field offset: 0x4A8
	protected int m_totalCharacterCount; //Field offset: 0x4B0
	protected int m_characterCount; //Field offset: 0x4B4
	protected int m_firstCharacterOfLine; //Field offset: 0x4B8
	protected int m_firstVisibleCharacterOfLine; //Field offset: 0x4BC
	protected int m_lastCharacterOfLine; //Field offset: 0x4C0
	protected int m_lastVisibleCharacterOfLine; //Field offset: 0x4C4
	protected int m_lineNumber; //Field offset: 0x4C8
	protected int m_lineVisibleCharacterCount; //Field offset: 0x4CC
	protected int m_lineVisibleSpaceCount; //Field offset: 0x4D0
	protected int m_pageNumber; //Field offset: 0x4D4
	protected float m_PageAscender; //Field offset: 0x4D8
	protected float m_maxTextAscender; //Field offset: 0x4DC
	protected float m_maxCapHeight; //Field offset: 0x4E0
	protected float m_ElementAscender; //Field offset: 0x4E4
	protected float m_ElementDescender; //Field offset: 0x4E8
	protected float m_maxLineAscender; //Field offset: 0x4EC
	protected float m_maxLineDescender; //Field offset: 0x4F0
	protected float m_startOfLineAscender; //Field offset: 0x4F4
	protected float m_startOfLineDescender; //Field offset: 0x4F8
	protected float m_lineOffset; //Field offset: 0x4FC
	protected Extents m_meshExtents; //Field offset: 0x500
	protected Color32 m_htmlColor; //Field offset: 0x510
	protected TMP_TextProcessingStack<Color32> m_colorStack; //Field offset: 0x518
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; //Field offset: 0x538
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; //Field offset: 0x558
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x578
	protected TMP_ColorGradient m_colorGradientPreset; //Field offset: 0x5A8
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; //Field offset: 0x5B0
	protected bool m_colorGradientPresetIsTinted; //Field offset: 0x5D8
	protected float m_tabSpacing; //Field offset: 0x5DC
	protected float m_spacing; //Field offset: 0x5E0
	protected TMP_TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x5E8
	protected int m_TextStyleStackDepth; //Field offset: 0x5F0
	protected TMP_TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x5F8
	protected int m_ItalicAngle; //Field offset: 0x618
	protected TMP_TextProcessingStack<Int32> m_actionStack; //Field offset: 0x620
	protected float m_padding; //Field offset: 0x640
	protected float m_baselineOffset; //Field offset: 0x644
	protected TMP_TextProcessingStack<Single> m_baselineOffsetStack; //Field offset: 0x648
	protected float m_xAdvance; //Field offset: 0x668
	protected TMP_TextElementType m_textElementType; //Field offset: 0x66C
	protected TMP_TextElement m_cached_TextElement; //Field offset: 0x670
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x678
	protected SpecialCharacter m_Underline; //Field offset: 0x698
	protected TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x6B8
	protected TMP_SpriteAsset m_currentSpriteAsset; //Field offset: 0x6C0
	protected int m_spriteCount; //Field offset: 0x6C8
	protected int m_spriteIndex; //Field offset: 0x6CC
	protected int m_spriteAnimationID; //Field offset: 0x6D0
	protected bool m_ignoreActiveState; //Field offset: 0x6D4
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x6D8
	private readonly Decimal[] k_Power; //Field offset: 0x6E8
	private static ProfilerMarker k_ParseTextMarker; //Field offset: 0x1710
	private static ProfilerMarker k_InsertNewLineMarker; //Field offset: 0x1718
	protected static Vector2 k_LargePositiveVector2; //Field offset: 0x1720
	protected static Vector2 k_LargeNegativeVector2; //Field offset: 0x1728
	protected static float k_LargePositiveFloat; //Field offset: 0x1730
	protected static float k_LargeNegativeFloat; //Field offset: 0x1734
	protected static int k_LargePositiveInt; //Field offset: 0x1738
	protected static int k_LargeNegativeInt; //Field offset: 0x173C

	public static event Func<Int32, String, TMP_FontAsset> OnFontAssetRequest
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 263
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 263
	}

	public static event MissingCharacterEventCallback OnMissingCharacter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public override event Action<TMP_TextInfo> OnPreRenderText
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

	public static event Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 263
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 263
	}

	public TextAlignmentOptions alignment
	{
		[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 13
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProDefaults", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ApplyDefaultTextMeshProProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickConsole", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Localization", Member = "DefineRTLText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 22)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 62
	}

	public float alpha
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CalledBy(Type = "Scenes.General.LPChange+<Animation>d__17", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 48
	}

	public override bool autoSizeTextContainer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Bounds bounds
	{
		[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 184
	}

	public float characterHorizontalScale
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public float characterSpacing
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public float characterWidthAdjustment
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public virtual Color color
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 129
	}

	public VertexGradient colorGradient
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 47
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 67
	}

	public TMP_ColorGradient colorGradientPreset
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 60
	}

	public bool emojiFallbackSupport
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public bool enableAutoSizing
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_DayHeader", Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 70
	}

	public bool enableCulling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 52
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled on the text component.")]
	public bool enableKerning
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 76
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 327
	}

	public bool enableVertexGradient
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	public bool enableWordWrapping
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 80
	}

	public bool extraPadding
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public Color32 faceColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 228
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		 set { } //Length: 116
	}

	public int firstOverflowCharacterIndex
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public int firstVisibleCharacter
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public override float flexibleHeight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public TMP_FontAsset font
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_fontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 197
	}

	public List<OTL_FeatureTag> fontFeatures
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 83
	}

	public Material fontMaterial
	{
		[CalledBy(Type = typeof(TextMeshPro), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 24
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 253
	}

	public override Material[] fontMaterials
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 24
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 76
	}

	public override Material fontSharedMaterial
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		 set { } //Length: 178
	}

	public override Material[] fontSharedMaterials
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 76
	}

	public float fontSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CalledBy(Type = "Extensions.DisplayCard", Member = "SetupBox", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineCardStrings", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_pointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ChatWindow", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
		[CalledBy(Type = "PhaseChange", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalPointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 103
	}

	public float fontSizeMax
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_DayHeader", Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 79
	}

	public float fontSizeMin
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_DayHeader", Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 79
	}

	public FontStyles fontStyle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = "Scenes.Battle.AttributeSelection+<>c__DisplayClass17_0", Member = "<SetAttributeState>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.AttributeSelection", Member = "OnToggleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(TextMeshProUGUI)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.AttributeSelection", Member = "SetAttributeState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), "Enumerator.CardAttribute"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.RaceSelection+<>c__DisplayClass42_0", Member = "<Start>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.RaceSelection", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.RaceSelection", Member = "OnToggleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(TextMeshProUGUI)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FilterCheck", Member = "ChangeState", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineCardStrings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public FontWeight fontWeight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public VertexSortingOrder geometrySortingOrder
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 30
	}

	public bool havePropertiesChanged
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 32
	}

	public HorizontalAlignmentOptions horizontalAlignment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public TextureMappingOptions horizontalMapping
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public bool ignoreVisibility
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 22
	}

	public bool isOrthographic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public bool isOverlay
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public bool isRightToLeftText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "Manager.Localization", Member = "DefineRTLText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public bool isTextObjectScaleStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		 set { } //Length: 131
	}

	public bool isTextOverflowing
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool isTextTruncated
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public bool isUsingBold
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public bool isUsingLegacyAnimationComponent
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public bool isVolumetricText
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_TextInfo), Member = "ResetVertexLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 98
	}

	protected LayoutElement layoutElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	public override int layoutPriority
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public float lineSpacing
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public float lineSpacingAdjustment
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public TMP_Text linkedTextComponent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 270
	}

	public float mappingUvLineOffset
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 48
	}

	public override Vector4 margin
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 165
	}

	public float maxHeight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public int maxVisibleCharacters
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public int maxVisibleLines
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public int maxVisibleWords
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public float maxWidth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public override Mesh mesh
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override float minHeight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public override float minWidth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public Color32 outlineColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 228
		[CalledBy(Type = "Extensions.General+<ChangeOutline>d__80", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 97
	}

	public float outlineWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 205
		[CalledBy(Type = "Extensions.General+<ChangeOutline>d__80", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 93
	}

	public TextOverflowModes overflowMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public bool overrideColorTags
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public int pageToDisplay
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public float paragraphSpacing
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public bool parseCtrlCharacters
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public float pixelsPerUnit
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 539
	}

	public override float preferredHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
		 get { } //Length: 30
	}

	public override float preferredWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
		 get { } //Length: 30
	}

	public RectTransform rectTransform
	{
		[CallerCount(Count = 105)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	public override float renderedHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
		[DeduplicatedMethod]
		 get { } //Length: 34
	}

	public override float renderedWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
		[DeduplicatedMethod]
		 get { } //Length: 34
	}

	public TextRenderFlags renderMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 22
	}

	public bool richText
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = "Card.Template", Member = "DefineCardTypes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentRichTextMode", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	protected TMP_SpriteAnimator spriteAnimator
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 271
	}

	public TMP_SpriteAsset spriteAsset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 79
	}

	public TMP_StyleSheet styleSheet
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 79
	}

	public override string text
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 226
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 170
	}

	public Bounds textBounds
	{
		[CalledBy(Type = "Extensions.SliceButton", Member = "SetSizeToFitText", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
		 get { } //Length: 78
	}

	public TMP_TextInfo textInfo
	{
		[CallerCount(Count = 193)]
		[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 121
	}

	public ITextPreprocessor textPreprocessor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public TMP_Style textStyle
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
		[Calls(Type = typeof(TMP_Style), Member = "get_NormalStyle", ReturnType = typeof(TMP_Style))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 123
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 105
	}

	public TextWrappingModes textWrappingMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 77
	}

	public bool tintAllSprites
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public Transform transform
	{
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "EnableButtonsForUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "CloseDuelForEnd", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineChainAngle", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "SetFaceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMeshUI))]
		[CalledBy(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	public bool useMaxVisibleDescender
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public bool vertexBufferAutoSizeReduction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 30
	}

	public VerticalAlignmentOptions verticalAlignment
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public TextureMappingOptions verticalMapping
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 39
	}

	public float wordSpacing
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	public float wordWrappingRatios
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 86
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static TMP_Text() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(VertexGradient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBackingContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 24)]
	protected TMP_Text() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_linebreakingRules", ReturnType = typeof(LineBreakingTable))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_useModernHangulLineBreakingRules", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FaceInfo), Member = "get_tabWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Math), Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Text), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset), typeof(TMP_SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 54)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ClearMesh(bool uploadGeometry) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ClearMesh() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ComputeMarginSize() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	protected float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override Material CreateMaterialInstance(Material source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "CrossFadeAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void DestroySubMeshObjects() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	protected override void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	protected override void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected override void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 2)]
	protected override void FillCharacterVertexBuffers(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 2)]
	protected override void FillSpriteVertexBuffers(int i) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public TextAlignmentOptions get_alignment() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float get_alpha() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public override bool get_autoSizeTextContainer() { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Bounds get_bounds() { }

	[CallerCount(Count = 0)]
	public float get_characterHorizontalScale() { }

	[CallerCount(Count = 0)]
	public float get_characterSpacing() { }

	[CallerCount(Count = 0)]
	public float get_characterWidthAdjustment() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual Color get_color() { }

	[CallerCount(Count = 0)]
	public VertexGradient get_colorGradient() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public TMP_ColorGradient get_colorGradientPreset() { }

	[CallerCount(Count = 0)]
	public bool get_emojiFallbackSupport() { }

	[CallerCount(Count = 0)]
	public bool get_enableAutoSizing() { }

	[CallerCount(Count = 0)]
	public bool get_enableCulling() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_enableKerning() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_enableVertexGradient() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_enableWordWrapping() { }

	[CallerCount(Count = 0)]
	public bool get_extraPadding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 1)]
	public Color32 get_faceColor() { }

	[CallerCount(Count = 0)]
	public int get_firstOverflowCharacterIndex() { }

	[CallerCount(Count = 0)]
	public int get_firstVisibleCharacter() { }

	[CallerCount(Count = 0)]
	public override float get_flexibleHeight() { }

	[CallerCount(Count = 0)]
	public override float get_flexibleWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_FontAsset get_font() { }

	[CallerCount(Count = 0)]
	public List<OTL_FeatureTag> get_fontFeatures() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Material get_fontMaterial() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Material[] get_fontMaterials() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override Material get_fontSharedMaterial() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Material[] get_fontSharedMaterials() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fontSize() { }

	[CallerCount(Count = 0)]
	public float get_fontSizeMax() { }

	[CallerCount(Count = 0)]
	public float get_fontSizeMin() { }

	[CallerCount(Count = 0)]
	public FontStyles get_fontStyle() { }

	[CallerCount(Count = 0)]
	public FontWeight get_fontWeight() { }

	[CallerCount(Count = 0)]
	public VertexSortingOrder get_geometrySortingOrder() { }

	[CallerCount(Count = 0)]
	public bool get_havePropertiesChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	[CallerCount(Count = 0)]
	public TextureMappingOptions get_horizontalMapping() { }

	[CallerCount(Count = 0)]
	public bool get_ignoreVisibility() { }

	[CallerCount(Count = 0)]
	public bool get_isOrthographic() { }

	[CallerCount(Count = 0)]
	public bool get_isOverlay() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isRightToLeftText() { }

	[CallerCount(Count = 0)]
	public bool get_isTextObjectScaleStatic() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isTextOverflowing() { }

	[CallerCount(Count = 0)]
	public bool get_isTextTruncated() { }

	[CallerCount(Count = 0)]
	public bool get_isUsingBold() { }

	[CallerCount(Count = 0)]
	public bool get_isUsingLegacyAnimationComponent() { }

	[CallerCount(Count = 0)]
	public bool get_isVolumetricText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected LayoutElement get_layoutElement() { }

	[CallerCount(Count = 0)]
	public override int get_layoutPriority() { }

	[CallerCount(Count = 0)]
	public float get_lineSpacing() { }

	[CallerCount(Count = 0)]
	public float get_lineSpacingAdjustment() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_Text get_linkedTextComponent() { }

	[CallerCount(Count = 0)]
	public float get_mappingUvLineOffset() { }

	[CallerCount(Count = 0)]
	public override Vector4 get_margin() { }

	[CallerCount(Count = 0)]
	public float get_maxHeight() { }

	[CallerCount(Count = 0)]
	public int get_maxVisibleCharacters() { }

	[CallerCount(Count = 0)]
	public int get_maxVisibleLines() { }

	[CallerCount(Count = 0)]
	public int get_maxVisibleWords() { }

	[CallerCount(Count = 0)]
	public float get_maxWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override Mesh get_mesh() { }

	[CallerCount(Count = 0)]
	public override float get_minHeight() { }

	[CallerCount(Count = 0)]
	public override float get_minWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 1)]
	public Color32 get_outlineColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float get_outlineWidth() { }

	[CallerCount(Count = 0)]
	public TextOverflowModes get_overflowMode() { }

	[CallerCount(Count = 0)]
	public bool get_overrideColorTags() { }

	[CallerCount(Count = 0)]
	public int get_pageToDisplay() { }

	[CallerCount(Count = 0)]
	public float get_paragraphSpacing() { }

	[CallerCount(Count = 0)]
	public bool get_parseCtrlCharacters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float get_pixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
	public override float get_preferredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
	public override float get_preferredWidth() { }

	[CallerCount(Count = 105)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public RectTransform get_rectTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	public override float get_renderedHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	public override float get_renderedWidth() { }

	[CallerCount(Count = 0)]
	public TextRenderFlags get_renderMode() { }

	[CallerCount(Count = 0)]
	public bool get_richText() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_SpriteAsset get_spriteAsset() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_StyleSheet get_styleSheet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override string get_text() { }

	[CalledBy(Type = "Extensions.SliceButton", Member = "SetSizeToFitText", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	public Bounds get_textBounds() { }

	[CallerCount(Count = 193)]
	[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TMP_TextInfo get_textInfo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ITextPreprocessor get_textPreprocessor() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Style), Member = "get_NormalStyle", ReturnType = typeof(TMP_Style))]
	[CallsUnknownMethods(Count = 3)]
	public TMP_Style get_textStyle() { }

	[CallerCount(Count = 0)]
	public TextWrappingModes get_textWrappingMode() { }

	[CallerCount(Count = 0)]
	public bool get_tintAllSprites() { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "EnableButtonsForUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "CloseDuelForEnd", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineChainAngle", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "SetFaceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMeshUI))]
	[CalledBy(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Transform get_transform() { }

	[CallerCount(Count = 0)]
	public bool get_useMaxVisibleDescender() { }

	[CallerCount(Count = 0)]
	public bool get_vertexBufferAutoSizeReduction() { }

	[CallerCount(Count = 0)]
	public VerticalAlignmentOptions get_verticalAlignment() { }

	[CallerCount(Count = 0)]
	public TextureMappingOptions get_verticalMapping() { }

	[CallerCount(Count = 0)]
	public float get_wordSpacing() { }

	[CallerCount(Count = 0)]
	public float get_wordWrappingRatios() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	private int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override Rect GetCanvasSpaceClippingRect() { }

	[CallerCount(Count = 941)]
	[DeduplicatedMethod]
	protected override Bounds GetCompoundBounds() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Character), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 2)]
	private int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected override Material GetMaterial(Material mat) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected override Material[] GetMaterials(Material[] mats) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected override float GetPaddingForMaterial(Material mat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected override float GetPaddingForMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public override string GetParsedText() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetPreferredHeight(Vector2 margin) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected float GetPreferredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 GetPreferredValues(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
	public Vector2 GetPreferredValues() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	public Vector2 GetPreferredValues(float width, float height) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected float GetPreferredWidth() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetPreferredWidth(Vector2 margin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Bounds))]
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	private float GetRenderedHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	public Vector2 GetRenderedValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Bounds))]
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	private float GetRenderedWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Bounds))]
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected override Material[] GetSharedMaterials() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultStyleSheet", ReturnType = typeof(TMP_StyleSheet))]
	[CallsUnknownMethods(Count = 1)]
	private TMP_Style GetStyle(int hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	private int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 5)]
	private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "get_textBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_renderedWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_renderedHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedValues", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected Bounds GetTextBounds() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected override Vector3[] GetTextContainerLocalCorners() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character), typeof(FontStyles), typeof(FontWeight), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_SpriteAsset), typeof(bool)}, ReturnType = typeof(TMP_SpriteCharacter))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAsset", ReturnType = typeof(TMP_SpriteAsset))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override TMP_TextInfo GetTextInfo(string text) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Character), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 4)]
	private uint GetUTF16(TextBackingContainer text, int i) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private uint GetUTF16(UInt32[] text, int i) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 8)]
	private uint GetUTF32(TextBackingContainer text, int i) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private uint GetUTF32(UInt32[] text, int i) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	protected Color32 HexCharsToColor(Char[] hexChars, int tagCount) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	protected Color32 HexCharsToColor(Char[] hexChars, int startIndex, int length) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 84)]
	[CallsUnknownMethods(Count = 2)]
	protected uint HexToInt(char hex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InsertClosingTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "AdjustLineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeLineExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InsertOpeningStyleTag(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InsertOpeningTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertOpeningTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Style), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertClosingTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Style), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Style), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private string InternalTextBackingArrayToString() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void InternalUpdate() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "set_linkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsValidUTF16(TextBackingContainer text, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsValidUTF32(TextBackingContainer text, int index) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextAutoSizingMaxRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextAutoSizingMinRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableParseEscapeCharacters", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableTintAllSprites", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableExtraPadding", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32Enum>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fontFeatures", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.OTL_FeatureTag>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_textWrappingMode", ReturnType = typeof(TextWrappingModes))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextMeshProTextContainerSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextMeshProUITextContainerSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableRaycastTarget", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_autoSizeTextContainer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_Compatibility), Member = "ConvertTextAlignmentEnumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(TextAlignmentOptions))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_isTextObjectScaleStatic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected void LoadDefaultSettings() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void LoadFontAsset() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected Vector2 PackUV(float x, float y, float scale) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected float PackUV(float x, float y) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected void ParseInputText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PopulateTextBackingArray(string sourceText) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PopulateTextBackingArray(Char[] sourceText, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ConvertToUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void PopulateTextProcessingArray() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "set_linkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_linkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected void ReplaceTagWithCharacter(Int32[] chars, int insertionIndex, int tagLength, char c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void ResizeInternalArray(ref T[] array) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void ResizeInternalArray(ref T[] array, int size) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void ResizeLineExtents(int size) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 18)]
	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "MinAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected override void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	protected override void SaveSpriteVertexInfo(Color32 vertexColor) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 18)]
	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProDefaults", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ApplyDefaultTextMeshProProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickConsole", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnClickLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization", Member = "DefineRTLText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_alignment(TextAlignmentOptions value) { }

	[CalledBy(Type = "Scenes.General.LPChange+<Animation>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_alpha(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public override void set_autoSizeTextContainer(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_characterHorizontalScale(float value) { }

	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_characterSpacing(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_characterWidthAdjustment(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void set_color(Color value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_colorGradient(VertexGradient value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_emojiFallbackSupport(bool value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_DayHeader", Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_enableAutoSizing(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_enableCulling(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_enableKerning(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_enableVertexGradient(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_enableWordWrapping(bool value) { }

	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_extraPadding(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	public void set_faceColor(Color32 value) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_firstVisibleCharacter(int value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_fontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void set_font(TMP_FontAsset value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void set_fontMaterial(Material value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void set_fontMaterials(Material[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void set_fontSharedMaterial(Material value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void set_fontSharedMaterials(Material[] value) { }

	[CalledBy(Type = "Extensions.DisplayCard", Member = "SetupBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalPointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "PhaseChange", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceInputFieldWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(TMP_InputField))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_pointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_fontSize(float value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_DayHeader", Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_fontSizeMax(float value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateDaySection", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerWeekDaysConfig", Member = "ApplyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayHeader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_DayHeader", Member = "get_HeaderText", ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "ReplaceTextElementWithTextMeshPro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(TextMeshProUGUI))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_fontSizeMin(float value) { }

	[CalledBy(Type = "Scenes.Battle.AttributeSelection+<>c__DisplayClass17_0", Member = "<SetAttributeState>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.AttributeSelection", Member = "OnToggleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(TextMeshProUGUI)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.AttributeSelection", Member = "SetAttributeState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), "Enumerator.CardAttribute"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.RaceSelection+<>c__DisplayClass42_0", Member = "<Start>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.RaceSelection", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.RaceSelection", Member = "OnToggleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(TextMeshProUGUI)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FilterCheck", Member = "ChangeState", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_fontStyle(FontStyles value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_fontWeight(FontWeight value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	[CalledBy(Type = typeof(TMP_SubMesh), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_havePropertiesChanged(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_horizontalMapping(TextureMappingOptions value) { }

	[CallerCount(Count = 0)]
	public void set_ignoreVisibility(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_isOrthographic(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_isOverlay(bool value) { }

	[CalledBy(Type = "Manager.Localization", Member = "DefineRTLText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_isRightToLeftText(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	public void set_isTextObjectScaleStatic(bool value) { }

	[CallerCount(Count = 0)]
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ResetVertexLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_isVolumetricText(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_lineSpacing(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_lineSpacingAdjustment(float value) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void set_linkedTextComponent(TMP_Text value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_mappingUvLineOffset(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void set_margin(Vector4 value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxVisibleCharacters(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxVisibleLines(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_maxVisibleWords(int value) { }

	[CalledBy(Type = "Extensions.General+<ChangeOutline>d__80", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_outlineColor(Color32 value) { }

	[CalledBy(Type = "Extensions.General+<ChangeOutline>d__80", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_outlineWidth(float value) { }

	[CalledBy(Type = "Card.Template", Member = "DefineStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_overflowMode(TextOverflowModes value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_overrideColorTags(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_pageToDisplay(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_paragraphSpacing(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_parseCtrlCharacters(bool value) { }

	[CallerCount(Count = 0)]
	public void set_renderMode(TextRenderFlags value) { }

	[CalledBy(Type = "Card.Template", Member = "DefineCardTypes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentRichTextMode", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_richText(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_styleSheet(TMP_StyleSheet value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_text(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_textPreprocessor(ITextPreprocessor value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_textStyle(TMP_Style value) { }

	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_textWrappingMode(TextWrappingModes value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_tintAllSprites(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_useMaxVisibleDescender(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_verticalMapping(TextureMappingOptions value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_wordSpacing(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_wordWrappingRatios(float value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetActiveSubMeshes(bool state) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override int SetArraySizes(TextProcessingElement[] unicodeChars) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SetCharArray(Char[] sourceText, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void SetCharArray(Char[] sourceText) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetCulling() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetFaceColor(Color32 color) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetFontBaseMaterial(Material mat) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetOutlineColor(Color32 color) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetOutlineThickness(float thickness) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetShaderDepth() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetSharedMaterial(Material mat) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void SetSharedMaterials(Material[] materials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0, float arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void SetText(Char[] sourceText, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void SetText(Char[] sourceText) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void SetText(StringBuilder sourceText, int start, int length) { }

	[CalledBy(Type = "Card.Template", Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public void SetText(StringBuilder sourceText) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	[CallerCount(Count = 493)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void SetText(string sourceText) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	[CallerCount(Count = 493)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Obsolete("Use the SetText(string) function instead.")]
	public void SetText(string sourceText, bool syncTextInputBox = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetTextInternal(string sourceText) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected void SetTextSortingOrder(Int32[] order) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetVertices(Vector3[] vertices) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void UpdateCulling() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UpdateGeometry(Mesh mesh, int index) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UpdateMeshPadding() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UpdateVertexData() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_Text), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAsset", ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteCharacter>))]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "get_spriteAnimator", ReturnType = typeof(TMP_SpriteAnimator))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<System.Single>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<System.Object>), Member = "Remove", ReturnType = typeof(object))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAnimator), Member = "DoSpriteAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_LinkInfo), Member = "SetLinkID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "ToUpperFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_TextProcessingStack`1), Member = "Remove", ReturnType = "T")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>), Member = "Remove", ReturnType = typeof(MaterialReference))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState>), Member = "Remove", ReturnType = typeof(HighlightState))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultColorGradientPresetsPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 68)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	internal bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex) { }

}

