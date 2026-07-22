namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2023.3/Documentation/Manual/UIE-sprite.html")]
public class SpriteAsset : TextAsset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SpriteGlyph, UInt32> <>9__44_0; //Field offset: 0x8
		public static Func<SpriteCharacter, UInt32> <>9__45_0; //Field offset: 0x10

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
		internal uint <SortCharacterTable>b__45_0(SpriteCharacter c) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal uint <SortGlyphTable>b__44_0(SpriteGlyph item) { }

	}

	internal Dictionary<Int32, Int32> m_NameLookup; //Field offset: 0x38
	internal Dictionary<UInt32, Int32> m_GlyphIndexLookup; //Field offset: 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <width>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <height>k__BackingField; //Field offset: 0xB4
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; //Field offset: 0xB8
	internal Dictionary<UInt32, SpriteCharacter> m_SpriteCharacterLookup; //Field offset: 0xC0
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; //Field offset: 0xC8
	internal Dictionary<UInt32, SpriteGlyph> m_SpriteGlyphLookup; //Field offset: 0xD0
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; //Field offset: 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; //Field offset: 0xE0

	public internal FaceInfo faceInfo
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 5)]
		 get { } //Length: 57
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 64
	}

	internal float height
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public internal Dictionary<UInt32, SpriteCharacter> spriteCharacterLookupTable
	{
		[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
		[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		 get { } //Length: 52
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public internal List<SpriteCharacter> spriteCharacterTable
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		 get { } //Length: 49
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public internal List<SpriteGlyph> spriteGlyphTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public internal Texture spriteSheet
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 125
	}

	internal float width
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public SpriteAsset() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void Awake() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 5)]
	public FaceInfo get_faceInfo() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal float get_height() { }

	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	public Dictionary<UInt32, SpriteCharacter> get_spriteCharacterLookupTable() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Texture get_spriteSheet() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal float get_width() { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int GetSpriteIndexFromName(string name) { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null) { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallsUnknownMethods(Count = 1)]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_faceInfo(FaceInfo value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_height(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_spriteCharacterLookupTable(Dictionary<UInt32, SpriteCharacter> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_spriteSheet(Texture value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_width(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SortCharacterTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void SortGlyphAndCharacterTables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SortGlyphTable() { }

	[CalledBy(Type = typeof(SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter>))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "get_spriteCharacterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.SpriteCharacter>))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateLookupTables() { }

}

