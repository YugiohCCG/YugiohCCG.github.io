namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/FontAsset.h")]
public class FontAsset : TextAsset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Character, UInt32> <>9__190_0; //Field offset: 0x8
		public static Func<Glyph, UInt32> <>9__191_0; //Field offset: 0x10

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
		internal uint <SortCharacterTable>b__190_0(Character c) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal uint <SortGlyphTable>b__191_0(Glyph c) { }

	}

	private static Dictionary<Int32, FontAsset> kFontAssetByInstanceId; //Field offset: 0x0
	private static readonly List<WeakReference`1<FontAsset>> s_CallbackInstances; //Field offset: 0x8
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x10
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x18
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x20
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x28
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x30
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x38
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x40
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x48
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x50
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x58
	private static string s_DefaultMaterialSuffix; //Field offset: 0x60
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x68
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x70
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x78
	private static List<FontAsset> k_FontAssets_KerningUpdateQueue; //Field offset: 0x80
	private static HashSet<Int32> k_FontAssets_KerningUpdateQueueLookup; //Field offset: 0x88
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x90
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x98
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0xA0
	private static HashSet<Int32> visitedFontAssets; //Field offset: 0xA8
	[SerializeField]
	internal string m_SourceFontFileGUID; //Field offset: 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; //Field offset: 0x40
	[SerializeField]
	private Font m_SourceFontFile; //Field offset: 0x98
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal string m_SourceFontFilePath; //Field offset: 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; //Field offset: 0xAC
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsEditorFont; //Field offset: 0xAD
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0xB0
	private int m_FamilyNameHashCode; //Field offset: 0x110
	private int m_StyleNameHashCode; //Field offset: 0x114
	[Nullable(1)]
	[SerializeField]
	internal List<Glyph> m_GlyphTable; //Field offset: 0x118
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0x120
	[SerializeField]
	internal List<Character> m_CharacterTable; //Field offset: 0x128
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Dictionary<UInt32, Character> m_CharacterLookupDictionary; //Field offset: 0x130
	internal Texture2D m_AtlasTexture; //Field offset: 0x138
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x140
	[SerializeField]
	internal int m_AtlasTextureIndex; //Field offset: 0x148
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x14C
	[SerializeField]
	private bool m_GetFontFeatures; //Field offset: 0x14D
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x14E
	[SerializeField]
	internal int m_AtlasWidth; //Field offset: 0x150
	[SerializeField]
	internal int m_AtlasHeight; //Field offset: 0x154
	[SerializeField]
	internal int m_AtlasPadding; //Field offset: 0x158
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x15C
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x160
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x168
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; //Field offset: 0x170
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x178
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; //Field offset: 0x180
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; //Field offset: 0x188
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; //Field offset: 0x190
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing; //Field offset: 0x194
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	internal float m_BoldStyleWeight; //Field offset: 0x198
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; //Field offset: 0x19C
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	internal byte m_ItalicStyleSlant; //Field offset: 0x1A0
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple; //Field offset: 0x1A1
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1A2
	private IntPtr m_NativeFontAsset; //Field offset: 0x1A8
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x1B0
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x1B8
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x1C0
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x1C8
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x1D0
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x1D8
	internal List<Character> m_CharactersToAdd; //Field offset: 0x1E0
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x1E8
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x1F0
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x1F8
	internal Dictionary<ValueTuple`2<UInt32, UInt32>, UInt32> m_VariantGlyphIndexes; //Field offset: 0x200
	internal bool m_IsClone; //Field offset: 0x208

	public internal int atlasHeight
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public internal int atlasPadding
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
		[CallerCount(Count = 5)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public AtlasPopulationMode atlasPopulationMode
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
		[CallerCount(Count = 6)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public internal GlyphRenderMode atlasRenderMode
	{
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "EnsureMeshInfoCapacityForMaterialReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CallerCount(Count = 9)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public Texture2D atlasTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 156
	}

	public int atlasTextureCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
	}

	public Texture2D[] atlasTextures
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public internal int atlasWidth
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public float boldStyleSpacing
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public float boldStyleWeight
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public Dictionary<UInt32, Character> characterLookupTable
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		 get { } //Length: 52
	}

	public internal List<Character> characterTable
	{
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal bool clearDynamicDataOnBuild
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public FaceInfo faceInfo
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandle), Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextHandle), Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[CallerCount(Count = 40)]
		 get { } //Length: 69
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 466
	}

	public List<FontAsset> fallbackFontAssetTable
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal int familyNameHashCode
	{
		[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 66
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 59
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 66
	}

	public internal FontFeatureTable fontFeatureTable
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public internal FontWeightPair[] fontWeightTable
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal List<GlyphRect> freeGlyphRects
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public bool getFontFeatures
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		 get { } //Length: 52
	}

	[Nullable(1)]
	public internal List<Glyph> glyphTable
	{
		[CallerCount(Count = 0)]
		[NullableContext(1)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		internal set { } //Length: 19
	}

	public bool isMultiAtlasTexturesEnabled
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public byte italicStyleSlant
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	internal IntPtr nativeFontAsset
	{
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FontAsset), Member = "set_faceInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
		[CalledBy(Type = typeof(FontAsset), Member = "UpdateFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "UpdateWeightFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "UpdateFaceInfo", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
		[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo), typeof(Font), typeof(Font), typeof(string), typeof(int), typeof(IntPtr[]), typeof(IntPtr[]), typeof(IntPtr[])}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 445
	}

	public float regularStyleSpacing
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public float regularStyleWeight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public internal Font sourceFontFile
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal int styleNameHashCode
	{
		[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 66
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public byte tabMultiple
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	internal List<GlyphRect> usedGlyphRects
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private static FontAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32, System.UInt32>, System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 15)]
	public FontAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	[CalledBy(Type = typeof(FontAsset), Member = "CreateCharacterAndAddToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(Character))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateLigatureSubstitutionRecords", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord", "UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 3)]
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 3)]
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	[CalledBy(Type = typeof(FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontEngine), Member = "TryGetGlyphWithUnicodeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphLoadFlags), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphMetrics), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphRect), Member = "get_zero", ReturnType = typeof(GlyphRect))]
	[Calls(Type = typeof(Glyph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 26)]
	[ContainsUnimplementedInstructions]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ClearCharacterAndGlyphTables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	internal void ClearCharacterAndGlyphTablesInternal() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	internal void ClearFallbackCharacterTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "ClearFallbackCharacterTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventManager), Member = "ON_FONT_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private void ClearFontFeaturesTables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[CalledBy(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create_Injected(in FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private uint CreateCompositeKey(uint unicode, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAssetFactory), Member = "ConvertFontToFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	public static FontAsset CreateFontAsset(Font font) { }

	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(GlyphRenderMode)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[NullableContext(1)]
	internal static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode) { }

	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetWithOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetFactory), Member = "SetHideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90) { }

	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextShaderUtilities), Member = "get_ShaderRef_MobileBitmap", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextShaderUtilities), Member = "get_ShaderRef_Sprite", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextShaderUtilities), Member = "get_ShaderRef_MobileSDF", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "IsColorFontFace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[NullableContext(1)]
	internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90) { }

	[CalledBy(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CalledBy(Type = typeof(TextSettings), Member = "GetOSFontAssetList", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CalledBy(Type = typeof(TextSettings), Member = "GetGlobalFallbacks", ReturnType = typeof(IntPtr[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static List<FontAsset> CreateFontAssetOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static FontAsset CreateFontAssetWithOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateHbFaceIfNeeded() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("FontAsset::Destroy")]
	private static void Destroy(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DestroyAtlasTextures() { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void EnsureAdditionalCapacity(List<T> container, int additionalCapacity) { }

	[CalledBy(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void EnsureAdditionalCapacity(Dictionary<TKey, TValue> container, int additionalCapacity) { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo), typeof(Font), typeof(Font), typeof(string), typeof(int), typeof(IntPtr[]), typeof(IntPtr[]), typeof(IntPtr[])}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void EnsureNativeFontAssetIsCreated() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public int get_atlasHeight() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	public int get_atlasPadding() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CallerCount(Count = 6)]
	public AtlasPopulationMode get_atlasPopulationMode() { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "EnsureMeshInfoCapacityForMaterialReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	public GlyphRenderMode get_atlasRenderMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public Texture2D get_atlasTexture() { }

	[CallerCount(Count = 0)]
	public int get_atlasTextureCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Texture2D[] get_atlasTextures() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public int get_atlasWidth() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	public float get_boldStyleSpacing() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public float get_boldStyleWeight() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	public Dictionary<UInt32, Character> get_characterLookupTable() { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public List<Character> get_characterTable() { }

	[CallerCount(Count = 0)]
	internal bool get_clearDynamicDataOnBuild() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[CallerCount(Count = 40)]
	public FaceInfo get_faceInfo() { }

	[CallerCount(Count = 0)]
	public List<FontAsset> get_fallbackFontAssetTable() { }

	[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal int get_familyNameHashCode() { }

	[CallerCount(Count = 0)]
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	public FontFeatureTable get_fontFeatureTable() { }

	[CallerCount(Count = 0)]
	public FontWeightPair[] get_fontWeightTable() { }

	[CallerCount(Count = 0)]
	internal List<GlyphRect> get_freeGlyphRects() { }

	[CallerCount(Count = 0)]
	public bool get_getFontFeatures() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[CallerCount(Count = 0)]
	[NullableContext(1)]
	public List<Glyph> get_glyphTable() { }

	[CallerCount(Count = 0)]
	public bool get_isMultiAtlasTexturesEnabled() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public byte get_italicStyleSlant() { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFaceInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateWeightFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "set_faceInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo), typeof(Font), typeof(Font), typeof(string), typeof(int), typeof(IntPtr[]), typeof(IntPtr[]), typeof(IntPtr[])}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeFontAsset() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	public float get_regularStyleSpacing() { }

	[CallerCount(Count = 0)]
	public float get_regularStyleWeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Font get_sourceFontFile() { }

	[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal int get_styleNameHashCode() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	public byte get_tabMultiple() { }

	[CallerCount(Count = 0)]
	internal List<GlyphRect> get_usedGlyphRects() { }

	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetCharacters(FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Int32[] GetCharactersArray(FontAsset fontAsset) { }

	[CalledBy(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal IntPtr[] GetFallbacks() { }

	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static FontAsset GetFontAssetByID(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal uint GetGlyphIndex(uint unicode) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal uint GetGlyphIndex(uint unicode, out bool success) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetVariantGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	[CalledBy(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateWeightFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ValueTuple<IntPtr[], IntPtr[]> GetWeightFallbacks() { }

	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	public bool HasCharacter(int character) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool HasCharacter_Internal(uint character, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCharacters(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CalledBy(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool HasRecursion(FontAsset fontAsset) { }

	[CalledBy(Type = typeof(FontAsset), Member = "HasRecursion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasRecursionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private bool HasRecursionInternal(FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	internal void ImportFontFeatures() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, Object>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	internal void InitializeCharacterLookupDictionary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeCharacterLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLigatureSubstitutionLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToBaseAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToMarkAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	internal void InitializeDictionaryLookupTables() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, Object>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), "System.Collections.Generic.List`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal void InitializeGlyphLookupDictionary() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), "System.Collections.Generic.Dictionary`2<UInt32, T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, Object>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	[CalledBy(Type = typeof(FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void InitializeList(ICollection source, ref List<T>& list, int defaultCapacity = 16) { }

	[CalledBy(Type = typeof(FontAsset), Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void InitializeLookup(ICollection source, ref Dictionary<UInt32, T>& lookup, int defaultCapacity = 16) { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, MarkToBaseAdjustmentRecord>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, MarkToMarkAdjustmentRecord>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsBitmap() { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	internal FontEngineError LoadFontFace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy() { }

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FontAsset), Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FaceInfo), Member = "get_strikethroughOffset", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToMarkAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLigatureSubstitutionLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeCharacterLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToBaseAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void ReadFontAssetDefinition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RegisterCallbackInstance(FontAsset instance) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[CallerCount(Count = 0)]
	internal void set_atlasHeight(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_atlasPadding(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_atlasTextures(Texture2D[] value) { }

	[CallerCount(Count = 0)]
	internal void set_atlasWidth(int value) { }

	[CallerCount(Count = 0)]
	public void set_boldStyleSpacing(float value) { }

	[CallerCount(Count = 0)]
	public void set_boldStyleWeight(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_characterTable(List<Character> value) { }

	[CallerCount(Count = 0)]
	internal void set_clearDynamicDataOnBuild(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 3)]
	public void set_faceInfo(FaceInfo value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_familyNameHashCode(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	[CallerCount(Count = 0)]
	public void set_getFontFeatures(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	internal void set_glyphTable(List<Glyph> value) { }

	[CallerCount(Count = 0)]
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	[CallerCount(Count = 0)]
	public void set_italicStyleSlant(byte value) { }

	[CallerCount(Count = 0)]
	public void set_regularStyleSpacing(float value) { }

	[CallerCount(Count = 0)]
	public void set_regularStyleWeight(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_sourceFontFile(Font value) { }

	[CallerCount(Count = 0)]
	internal void set_styleNameHashCode(int value) { }

	[CallerCount(Count = 0)]
	public void set_tabMultiple(byte value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void SetupNewAtlasTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void SortAllTables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SortCharacterTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SortFontFeatureTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SortGlyphTable() { }

	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FontAsset), Member = "CreateCharacterAndAddToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	internal bool TryAddCharacterInternal(uint unicode, out Character character) { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Character), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 82)]
	[ContainsUnimplementedInstructions]
	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	private bool TryAddGlyphsToNewAtlasTexture() { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "SetTextureUploadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "SetTextureUploadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32, System.UInt32>, System.UInt32>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.UInt32, System.UInt32>), typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32, System.UInt32>, System.UInt32>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.UInt32, System.UInt32>), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void UpdateAtlasTexturesInQueue() { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateFaceInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateFaceInfo_Injected(IntPtr ptr, in FaceInfo faceInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateFallbacks() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateFontAssetData() { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecordsForNewGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	internal void UpdateGlyphAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	internal void UpdateLigatureSubstitutionRecords() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateWeightFallbacks() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

}

