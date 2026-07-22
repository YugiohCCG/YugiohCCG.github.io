namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextGenerator
{
	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public MissingCharacterEventCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }

	}

	internal struct SpecialCharacter
	{
		public Character character; //Field offset: 0x0
		public FontAsset fontAsset; //Field offset: 0x8
		public Material material; //Field offset: 0x10
		public int materialIndex; //Field offset: 0x18

		[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		public SpecialCharacter(Character character, int materialIndex) { }

	}

	private const int k_Tab = 9; //Field offset: 0x0
	private const int k_ParagraphSeparator = 8233; //Field offset: 0x0
	private const int k_RightSingleQuote = 8217; //Field offset: 0x0
	private const int k_Square = 9633; //Field offset: 0x0
	private const int k_HangulJamoStart = 4352; //Field offset: 0x0
	private const int k_HangulJamoEnd = 4607; //Field offset: 0x0
	private const int k_CjkStart = 11904; //Field offset: 0x0
	private const int k_CjkEnd = 40959; //Field offset: 0x0
	private const int k_HangulJameExtendedStart = 43360; //Field offset: 0x0
	private const int k_HangulJameExtendedEnd = 43391; //Field offset: 0x0
	private const int k_LineSeparator = 8232; //Field offset: 0x0
	private const int k_HangulSyllablesStart = 44032; //Field offset: 0x0
	private const int k_CjkIdeographsStart = 63744; //Field offset: 0x0
	private const int k_CjkIdeographsEnd = 64255; //Field offset: 0x0
	private const int k_CjkFormsStart = 65072; //Field offset: 0x0
	private const int k_CjkHalfwidthStart = 65280; //Field offset: 0x0
	private const int k_CjkHalfwidthEnd = 65519; //Field offset: 0x0
	private const int k_EndOfText = 3; //Field offset: 0x0
	private const float k_FloatUnset = -32767; //Field offset: 0x0
	private const int k_MaxCharacters = 8; //Field offset: 0x0
	private static TextGenerator s_TextGenerator; //Field offset: 0x0
	private const int k_HangulSyllablesEnd = 55295; //Field offset: 0x0
	private const int k_HorizontalEllipsis = 8230; //Field offset: 0x0
	private const int k_CjkFormsEnd = 65103; //Field offset: 0x0
	private const int k_NarrowNoBreakSpace = 8239; //Field offset: 0x0
	private const int k_LineFeed = 10; //Field offset: 0x0
	private const int k_VerticalTab = 11; //Field offset: 0x0
	private const int k_CarriageReturn = 13; //Field offset: 0x0
	private const int k_Space = 32; //Field offset: 0x0
	private const int k_DoubleQuotes = 34; //Field offset: 0x0
	private const int k_NumberSign = 35; //Field offset: 0x0
	private const int k_PercentSign = 37; //Field offset: 0x0
	private const int k_Plus = 43; //Field offset: 0x0
	private const int k_Period = 46; //Field offset: 0x0
	private const int k_LesserThan = 60; //Field offset: 0x0
	private const int k_SingleQuote = 39; //Field offset: 0x0
	private const int k_GreaterThan = 62; //Field offset: 0x0
	private const int k_ZeroWidthSpace = 8203; //Field offset: 0x0
	private const int k_NonBreakingHyphen = 8209; //Field offset: 0x0
	private const int k_Equal = 61; //Field offset: 0x0
	private const int k_FigureSpace = 8199; //Field offset: 0x0
	private const int k_HyphenMinus = 45; //Field offset: 0x0
	private const int k_Hyphen = 8208; //Field offset: 0x0
	private const int k_NoBreakSpace = 160; //Field offset: 0x0
	private const int k_Underline = 95; //Field offset: 0x0
	private const int k_SoftHyphen = 173; //Field offset: 0x0
	private const int k_WordJoiner = 8288; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <IsExecutingJob>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x10
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x10
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x20
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x28
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x2C
	private Char[] m_HtmlTag; //Field offset: 0x30
	internal HighlightState m_HighlightState; //Field offset: 0x38
	protected bool m_IsIgnoringAlignment; //Field offset: 0x4C
	protected bool m_IsTextTruncated; //Field offset: 0x4D
	private Vector3[] m_RectTransformCorners; //Field offset: 0x50
	private float m_MarginWidth; //Field offset: 0x58
	private float m_MarginHeight; //Field offset: 0x5C
	private float m_PreferredWidth; //Field offset: 0x60
	private float m_PreferredHeight; //Field offset: 0x64
	private FontAsset m_CurrentFontAsset; //Field offset: 0x68
	private Material m_CurrentMaterial; //Field offset: 0x70
	private int m_CurrentMaterialIndex; //Field offset: 0x78
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; //Field offset: 0x80
	private float m_Padding; //Field offset: 0xD8
	private SpriteAsset m_CurrentSpriteAsset; //Field offset: 0xE0
	private int m_TotalCharacterCount; //Field offset: 0xE8
	private float m_FontSize; //Field offset: 0xEC
	private float m_FontScaleMultiplier; //Field offset: 0xF0
	private float m_CurrentFontSize; //Field offset: 0xF4
	private TextProcessingStack<Single> m_SizeStack; //Field offset: 0xF8
	protected TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x118
	protected int m_TextStyleStackDepth; //Field offset: 0x120
	private FontStyles m_FontStyleInternal; //Field offset: 0x124
	private FontStyleStack m_FontStyleStack; //Field offset: 0x128
	private TextFontWeight m_FontWeightInternal; //Field offset: 0x134
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; //Field offset: 0x138
	private TextAlignment m_LineJustification; //Field offset: 0x158
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; //Field offset: 0x160
	private float m_BaselineOffset; //Field offset: 0x180
	private TextProcessingStack<Single> m_BaselineOffsetStack; //Field offset: 0x188
	private Color32 m_FontColor32; //Field offset: 0x1A8
	private Color32 m_HtmlColor; //Field offset: 0x1AC
	private Color32 m_UnderlineColor; //Field offset: 0x1B0
	private Color32 m_StrikethroughColor; //Field offset: 0x1B4
	private TextProcessingStack<Color32> m_ColorStack; //Field offset: 0x1B8
	private TextProcessingStack<Color32> m_UnderlineColorStack; //Field offset: 0x1D8
	private TextProcessingStack<Color32> m_StrikethroughColorStack; //Field offset: 0x1F8
	private TextProcessingStack<Color32> m_HighlightColorStack; //Field offset: 0x218
	private TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x238
	private TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x268
	private TextColorGradient m_ColorGradientPreset; //Field offset: 0x288
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; //Field offset: 0x290
	private bool m_ColorGradientPresetIsTinted; //Field offset: 0x2B8
	private TextProcessingStack<Int32> m_ActionStack; //Field offset: 0x2C0
	private float m_LineOffset; //Field offset: 0x2E0
	private float m_LineHeight; //Field offset: 0x2E4
	private bool m_IsDrivenLineSpacing; //Field offset: 0x2E8
	private float m_CSpacing; //Field offset: 0x2EC
	private float m_MonoSpacing; //Field offset: 0x2F0
	private bool m_DuoSpace; //Field offset: 0x2F4
	private float m_XAdvance; //Field offset: 0x2F8
	private float m_TagLineIndent; //Field offset: 0x2FC
	private float m_TagIndent; //Field offset: 0x300
	private TextProcessingStack<Single> m_IndentStack; //Field offset: 0x308
	private bool m_TagNoParsing; //Field offset: 0x328
	private int m_CharacterCount; //Field offset: 0x32C
	private int m_FirstCharacterOfLine; //Field offset: 0x330
	private int m_LastCharacterOfLine; //Field offset: 0x334
	private int m_FirstVisibleCharacterOfLine; //Field offset: 0x338
	private int m_LastVisibleCharacterOfLine; //Field offset: 0x33C
	private float m_MaxLineAscender; //Field offset: 0x340
	private float m_MaxLineDescender; //Field offset: 0x344
	private int m_LineNumber; //Field offset: 0x348
	private int m_LineVisibleCharacterCount; //Field offset: 0x34C
	private int m_LineVisibleSpaceCount; //Field offset: 0x350
	private int m_FirstOverflowCharacterIndex; //Field offset: 0x354
	private float m_MarginLeft; //Field offset: 0x358
	private float m_MarginRight; //Field offset: 0x35C
	private float m_Width; //Field offset: 0x360
	private Extents m_MeshExtents; //Field offset: 0x364
	private float m_MaxCapHeight; //Field offset: 0x374
	private float m_MaxAscender; //Field offset: 0x378
	private float m_MaxDescender; //Field offset: 0x37C
	private bool m_IsNonBreakingSpace; //Field offset: 0x380
	private WordWrapState m_SavedWordWrapState; //Field offset: 0x388
	private WordWrapState m_SavedLineState; //Field offset: 0x720
	private WordWrapState m_SavedEllipsisState; //Field offset: 0xAB8
	private WordWrapState m_SavedLastValidState; //Field offset: 0xE50
	private WordWrapState m_SavedSoftLineBreakState; //Field offset: 0x11E8
	private TextElementType m_TextElementType; //Field offset: 0x1580
	private bool m_isTextLayoutPhase; //Field offset: 0x1581
	private int m_SpriteIndex; //Field offset: 0x1584
	private Color32 m_SpriteColor; //Field offset: 0x1588
	private TextElement m_CachedTextElement; //Field offset: 0x1590
	private Color32 m_HighlightColor; //Field offset: 0x1598
	private float m_CharWidthAdjDelta; //Field offset: 0x159C
	private float m_MaxFontSize; //Field offset: 0x15A0
	private float m_MinFontSize; //Field offset: 0x15A4
	private int m_AutoSizeIterationCount; //Field offset: 0x15A8
	private int m_AutoSizeMaxIterationCount; //Field offset: 0x15AC
	private float m_StartOfLineAscender; //Field offset: 0x15B0
	private float m_LineSpacingDelta; //Field offset: 0x15B4
	internal MaterialReference[] m_MaterialReferences; //Field offset: 0x15B8
	private int m_SpriteCount; //Field offset: 0x15C0
	private TextProcessingStack<Int32> m_StyleStack; //Field offset: 0x15C8
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0x15E8
	private int m_SpriteAnimationId; //Field offset: 0x19A0
	private int m_ItalicAngle; //Field offset: 0x19A4
	private Vector3 m_FXScale; //Field offset: 0x19A8
	private Quaternion m_FXRotation; //Field offset: 0x19B4
	private int m_LastBaseGlyphIndex; //Field offset: 0x19C4
	private float m_PageAscender; //Field offset: 0x19C8
	private RichTextTagAttribute[] m_XmlAttribute; //Field offset: 0x19D0
	private Single[] m_AttributeParameterValues; //Field offset: 0x19D8
	private Dictionary<Int32, Int32> m_MaterialReferenceIndexLookup; //Field offset: 0x19E0
	private bool m_IsCalculatingPreferredValues; //Field offset: 0x19E8
	private bool m_TintSprite; //Field offset: 0x19E9
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x19F0
	protected SpecialCharacter m_Underline; //Field offset: 0x1A10
	private TextElementInfo[] m_InternalTextElementInfo; //Field offset: 0x1A30

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool IsExecutingJob
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[ContainsInvalidInstructions]
		internal set { } //Length: 136
	}

	public bool isTextTruncated
	{
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CallerCount(Count = 1)]
		 get { } //Length: 7
	}

	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<InitThreadArrays>b__4_1", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<get_generators>b__10_0", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextBackingContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 29)]
	public TextGenerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_boldStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(TextInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_regularStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(FaceInfo), Member = "get_tabWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(FontAsset), Member = "get_tabMultiple", ReturnType = typeof(byte))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_lineBreakingRules", ReturnType = typeof(UnicodeLineBreakingRules))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "get_leadingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "get_followingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SpriteAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[CallsDeduplicatedMethods(Count = 91)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearMarkupTagAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "ClearMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void CloseAllLinkTags(TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void CloseLastLinkTag(TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CloseLinkTag(TextInfo textInfo, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "EnsureMeshInfoCapacityForMaterialReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasRenderMode", ReturnType = typeof(GlyphRenderMode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void EnsureMeshInfoCapacityForMaterialReferences(TextInfo textInfo, TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextInfo), Member = "ClearMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(TextInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshInfo), Member = "ClearUnusedVertices", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_IsExecutingJob() { }

	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 1)]
	public bool get_isTextTruncated() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Character), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	protected bool GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "GetSpriteFromFallbacksThreadSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(System.Collections.Generic.HashSet`1<System.Int32>)}, ReturnType = typeof(SpriteCharacter))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static SpriteCharacter GetSpriteCharacterFromSpriteAssetThreadSafe(uint unicode, SpriteAsset spriteAsset) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GetSpriteCharacterFromSpriteAssetThreadSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset)}, ReturnType = typeof(SpriteCharacter))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetSpriteFromFallbacksThreadSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(System.Collections.Generic.HashSet`1<System.Int32>)}, ReturnType = typeof(SpriteCharacter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetSpriteFromFallbacksThreadSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(System.Collections.Generic.HashSet`1<System.Int32>)}, ReturnType = typeof(SpriteCharacter))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static SpriteCharacter GetSpriteFromFallbacksThreadSafe(uint unicode, List<SpriteAsset> fallbacks, HashSet<Int32> searched) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetSpriteCharacterFromSpriteAssetThreadSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset)}, ReturnType = typeof(SpriteCharacter))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Character), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "AdjustLineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_regularStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeLineExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HighlightState), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HighlightState), typeof(HighlightState)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ColorUtilities), Member = "CompareColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FaceInfo), Member = "get_strikethroughOffset", ReturnType = typeof(float))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "FillSpriteVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "IsBitmap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 122)]
	[ContainsUnimplementedInstructions]
	public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasRenderMode", ReturnType = typeof(GlyphRenderMode))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPadding", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_boldStyleWeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(FontAsset), Member = "get_boldStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(FontAsset), Member = "get_italicStyleSlant", ReturnType = typeof(byte))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TextGenerator), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(TextInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "ClearLineInfo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 125)]
	[CallsUnknownMethods(Count = 100)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_elementType", ReturnType = typeof(TextElementType))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryGetGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset), typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmojiPresentationForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmoji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetTextElementFromTextAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.TextAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private bool PopulateFontAsset(TextGenerationSettings generationSettings, TextProcessingElement[] textProcessingArray) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderedText), Member = "get_CharacterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderedText), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private void PopulateTextBackingArray(in RenderedText sourceText) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsValidUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsValidUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 3)]
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool PrepareFontAsset(TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	private int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "MinAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorUtilities), Member = "MultiplyColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsInvalidInstructions]
	internal static void set_IsExecutingJob(bool value) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextElement), Member = "get_elementType", ReturnType = typeof(TextElementType))]
	[Calls(Type = typeof(FontAsset), Member = "TryGetGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset), typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(TextGenerator), Member = "DoMissingGlyphCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(FontAsset), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter>))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmojiPresentationForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmoji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetTextElementFromTextAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.TextAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasRenderMode", ReturnType = typeof(GlyphRenderMode))]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LinkInfo), Member = "SetLinkId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<System.Single>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_italicStyleSlant", ReturnType = typeof(byte))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<System.Object>), Member = "Remove", ReturnType = typeof(object))]
	[Calls(Type = typeof(SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter>))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "CloseLastLinkTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextProcessingStack`1), Member = "Remove", ReturnType = "T")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.MaterialReference>), Member = "Remove", ReturnType = typeof(MaterialReference))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.HighlightState>), Member = "Remove", ReturnType = typeof(HighlightState))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 76)]
	[CallsUnknownMethods(Count = 42)]
	[ContainsUnimplementedInstructions]
	private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess) { }

}

