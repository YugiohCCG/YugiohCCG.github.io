namespace TMPro;

[ExcludeFromPreset]
public class TMP_FontAsset : TMP_Asset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TMP_Character, UInt32> <>9__145_0; //Field offset: 0x8
		public static Func<Glyph, UInt32> <>9__146_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal uint <SortCharacterTable>b__145_0(TMP_Character c) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal uint <SortGlyphTable>b__146_0(Glyph c) { }

	}

	private static readonly List<WeakReference`1<TMP_FontAsset>> s_CallbackInstances; //Field offset: 0x0
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x8
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x10
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x18
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x20
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x28
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x30
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x38
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x40
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x48
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x50
	private static string s_DefaultMaterialSuffix; //Field offset: 0x58
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x60
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x68
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x70
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x78
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x80
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0x88
	[SerializeField]
	internal string m_SourceFontFileGUID; //Field offset: 0x98
	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings; //Field offset: 0xA0
	[SerializeField]
	private Font m_SourceFontFile; //Field offset: 0x100
	[SerializeField]
	private string m_SourceFontFilePath; //Field offset: 0x108
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0x110
	[SerializeField]
	internal bool InternalDynamicOS; //Field offset: 0x114
	private int m_FamilyNameHashCode; //Field offset: 0x118
	private int m_StyleNameHashCode; //Field offset: 0x11C
	[SerializeField]
	internal List<Glyph> m_GlyphTable; //Field offset: 0x120
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0x128
	[SerializeField]
	internal List<TMP_Character> m_CharacterTable; //Field offset: 0x130
	internal Dictionary<UInt32, TMP_Character> m_CharacterLookupDictionary; //Field offset: 0x138
	internal Texture2D m_AtlasTexture; //Field offset: 0x140
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x148
	[SerializeField]
	internal int m_AtlasTextureIndex; //Field offset: 0x150
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x154
	[SerializeField]
	private bool m_GetFontFeatures; //Field offset: 0x155
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x156
	[SerializeField]
	internal int m_AtlasWidth; //Field offset: 0x158
	[SerializeField]
	internal int m_AtlasHeight; //Field offset: 0x15C
	[SerializeField]
	internal int m_AtlasPadding; //Field offset: 0x160
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x164
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x168
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x170
	[SerializeField]
	internal TMP_FontFeatureTable m_FontFeatureTable; //Field offset: 0x178
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x180
	[SerializeField]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; //Field offset: 0x188
	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable; //Field offset: 0x190
	[SerializeField]
	private TMP_FontWeightPair[] fontWeights; //Field offset: 0x198
	public float normalStyle; //Field offset: 0x1A0
	public float normalSpacingOffset; //Field offset: 0x1A4
	public float boldStyle; //Field offset: 0x1A8
	public float boldSpacing; //Field offset: 0x1AC
	public byte italicStyle; //Field offset: 0x1B0
	public byte tabSize; //Field offset: 0x1B1
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1B2
	[SerializeField]
	private FaceInfo_Legacy m_fontInfo; //Field offset: 0x1B8
	[SerializeField]
	internal List<TMP_Glyph> m_glyphInfoList; //Field offset: 0x1C0
	[FormerlySerializedAs("m_kerningInfo")]
	[SerializeField]
	internal KerningTable m_KerningTable; //Field offset: 0x1C8
	[SerializeField]
	private List<TMP_FontAsset> fallbackFontAssets; //Field offset: 0x1D0
	[SerializeField]
	public Texture2D atlas; //Field offset: 0x1D8
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x1E0
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x1E8
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x1F0
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x1F8
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x200
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x208
	internal List<TMP_Character> m_CharactersToAdd; //Field offset: 0x210
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x218
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x220
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x228

	public internal int atlasHeight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal int atlasPadding
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public AtlasPopulationMode atlasPopulationMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public internal GlyphRenderMode atlasRenderMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public Texture2D atlasTexture
	{
		[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 156
	}

	public int atlasTextureCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public Texture2D[] atlasTextures
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public internal int atlasWidth
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public Dictionary<UInt32, TMP_Character> characterLookupTable
	{
		[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
		[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
		[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		 get { } //Length: 52
	}

	public internal List<TMP_Character> characterTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal bool clearDynamicDataOnBuild
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public FontAssetCreationSettings creationSettings
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 79
	}

	public List<TMP_FontAsset> fallbackFontAssetTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal int familyNameHashCode
	{
		[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 119
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public internal TMP_FontFeatureTable fontFeatureTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public internal TMP_FontWeightPair[] fontWeightTable
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal List<GlyphRect> freeGlyphRects
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public bool getFontFeatures
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		 get { } //Length: 52
	}

	public internal List<Glyph> glyphTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public bool isMultiAtlasTexturesEnabled
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	public internal Font sourceFontFile
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal int styleNameHashCode
	{
		[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 119
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	internal List<GlyphRect> usedGlyphRects
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static TMP_FontAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(KerningTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	public TMP_FontAsset() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character, FontStyles fontStyle = 0, FontWeight fontWeight = 400, bool isAlternativeTypeface = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	internal bool AddGlyphInternal(uint glyphIndex) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateLigatureSubstitutionRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToBaseAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 3)]
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToMarkAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 3)]
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontEngine), Member = "TryGetGlyphWithUnicodeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphLoadFlags), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphMetrics), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphRect), Member = "get_zero", ReturnType = typeof(GlyphRect))]
	[Calls(Type = typeof(Glyph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "RebuildFontAssetCache", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ClearCharacterAndGlyphTables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	internal void ClearCharacterAndGlyphTablesInternal() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	internal void ClearFallbackCharacterTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFallbackCharacterTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro_EventManager), Member = "ON_FONT_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	internal void ClearFontFeaturesInternal() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private void ClearFontFeaturesTables() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private void CopyListDataToArray(List<T> srcList, ref T[] dstArray) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallsUnknownMethods(Count = 7)]
	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderUtilities), Member = "get_ShaderRef_MobileBitmap", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_clearDynamicDataOnBuild", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ShaderUtilities), Member = "get_ShaderRef_MobileSDF", ReturnType = typeof(Shader))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DestroyAtlasTextures() { }

	[CallerCount(Count = 0)]
	public int get_atlasHeight() { }

	[CallerCount(Count = 0)]
	public int get_atlasPadding() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AtlasPopulationMode get_atlasPopulationMode() { }

	[CallerCount(Count = 0)]
	public GlyphRenderMode get_atlasRenderMode() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public Texture2D get_atlasTexture() { }

	[CallerCount(Count = 0)]
	public int get_atlasTextureCount() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Texture2D[] get_atlasTextures() { }

	[CallerCount(Count = 0)]
	public int get_atlasWidth() { }

	[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	public Dictionary<UInt32, TMP_Character> get_characterLookupTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<TMP_Character> get_characterTable() { }

	[CallerCount(Count = 0)]
	internal bool get_clearDynamicDataOnBuild() { }

	[CallerCount(Count = 0)]
	public FontAssetCreationSettings get_creationSettings() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal int get_familyNameHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FaceInfo_Legacy get_fontInfo() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal List<GlyphRect> get_freeGlyphRects() { }

	[CallerCount(Count = 0)]
	public bool get_getFontFeatures() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<Glyph> get_glyphTable() { }

	[CallerCount(Count = 0)]
	public bool get_isMultiAtlasTexturesEnabled() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Font get_sourceFontFile() { }

	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal int get_styleNameHashCode() { }

	[CallerCount(Count = 0)]
	internal List<GlyphRect> get_usedGlyphRects() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Int32[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal uint GetGlyphIndex(uint unicode) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetVariantGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	public bool HasCharacter(int character) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCharacters(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	internal void ImportFontFeatures() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "RebuildFontAssetCache", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void InitializeCharacterLookupDictionary() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToBaseAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeLigatureSubstitutionLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeCharacterLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToMarkAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void InitializeDictionaryLookupTables() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void InitializeGlyphLookupDictionary() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GlyphPairAdjustmentRecord))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToBaseAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToMarkAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[CallsDeduplicatedMethods(Count = 7)]
	internal FontEngineError LoadFontFace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy() { }

	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "get_glyphLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Glyph>))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(List`1<Char>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FaceInfo), Member = "get_strikethroughOffset", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void ReadFontAssetDefinition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RegisterCallbackInstance(TMP_FontAsset instance) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_atlasHeight(int value) { }

	[CallerCount(Count = 0)]
	internal void set_atlasPadding(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	[CallerCount(Count = 0)]
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_atlasTextures(Texture2D[] value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_atlasWidth(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_characterTable(List<TMP_Character> value) { }

	[CallerCount(Count = 0)]
	internal void set_clearDynamicDataOnBuild(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_creationSettings(FontAssetCreationSettings value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_familyNameHashCode(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	[CallerCount(Count = 0)]
	public void set_getFontFeatures(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_glyphTable(List<Glyph> value) { }

	[CallerCount(Count = 0)]
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_sourceFontFile(Font value) { }

	[CallerCount(Count = 0)]
	internal void set_styleNameHashCode(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void SetupNewAtlasTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
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
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SortFontFeatureTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SortGlyphTable() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterFontAssetForFontFeatureUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32>)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TMP_Character), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "UintToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TMP_Character), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterFontAssetForFontFeatureUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void TryAddGlyphsToAtlasTextures() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private bool TryAddGlyphsToNewAtlasTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "TryGetGlyphWithIndexValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphLoadFlags), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterFontAssetForFontFeatureUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateAtlasTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void UpdateAtlasTexturesInQueue() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateFontAssetData() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphPairAdjustmentTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	internal void UpdateGlyphAdjustmentRecords(UInt32[] glyphIndexes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	internal void UpdateGlyphAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	internal void UpdateLigatureSubstitutionRecords() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphAdjustmentRecord), typeof(GlyphAdjustmentRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

}

