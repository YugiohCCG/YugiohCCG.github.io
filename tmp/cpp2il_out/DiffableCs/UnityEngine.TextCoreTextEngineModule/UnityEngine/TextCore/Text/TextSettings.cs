namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextSettings.h")]
public class TextSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public List<IntPtr> globalFontAssetFallbacks; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass96_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
		[Calls(Type = typeof(FontAsset), Member = "get_characterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character>))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[CallsUnknownMethods(Count = 2)]
		internal void <GetGlobalFallbacks>b__0(FontAsset fallback) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
		[Calls(Type = typeof(FontAsset), Member = "get_characterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character>))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[CallsUnknownMethods(Count = 2)]
		internal void <GetGlobalFallbacks>b__1(FontAsset fallback) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
		[Calls(Type = typeof(FontAsset), Member = "get_characterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character>))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[CallsUnknownMethods(Count = 2)]
		internal void <GetGlobalFallbacks>b__2(TextAsset fallback) { }

	}

	public struct FontReferenceMap
	{
		public Font font; //Field offset: 0x0
		public FontAsset fontAsset; //Field offset: 0x8

		[CallerCount(Count = 68)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public FontReferenceMap(Font font, FontAsset fontAsset) { }

	}

	private static List<FontAsset> s_FallbackOSFontAssetInternal; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; //Field offset: 0x8
	[SerializeField]
	protected string m_Version; //Field offset: 0x18
	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	protected FontAsset m_DefaultFontAsset; //Field offset: 0x20
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	[SerializeField]
	protected string m_DefaultFontAssetPath; //Field offset: 0x28
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	protected List<FontAsset> m_FallbackFontAssets; //Field offset: 0x30
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	protected bool m_MatchMaterialPreset; //Field offset: 0x38
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	protected int m_MissingCharacterUnicode; //Field offset: 0x3C
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; //Field offset: 0x40
	[SerializeField]
	private bool m_EnableEmojiSupport; //Field offset: 0x41
	[SerializeField]
	private List<TextAsset> m_EmojiFallbackTextAssets; //Field offset: 0x48
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	protected SpriteAsset m_DefaultSpriteAsset; //Field offset: 0x50
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	[SerializeField]
	protected string m_DefaultSpriteAssetPath; //Field offset: 0x58
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; //Field offset: 0x60
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; //Field offset: 0x68
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	protected TextStyleSheet m_DefaultStyleSheet; //Field offset: 0x70
	[SerializeField]
	protected string m_StyleSheetsResourcePath; //Field offset: 0x78
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	protected string m_DefaultColorGradientPresetsPath; //Field offset: 0x80
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; //Field offset: 0x88
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings; //Field offset: 0x90
	internal Dictionary<Int32, FontAsset> m_FontLookup; //Field offset: 0x98
	internal List<FontReferenceMap> m_FontReferences; //Field offset: 0xA0
	private IntPtr m_NativeTextSettings; //Field offset: 0xA8
	private bool m_IsNativeTextSettingsDirty; //Field offset: 0xB0

	public bool clearDynamicDataOnBuild
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string defaultColorGradientPresetsPath
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public FontAsset defaultFontAsset
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string defaultFontAssetPath
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public SpriteAsset defaultSpriteAsset
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string defaultSpriteAssetPath
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public TextStyleSheet defaultStyleSheet
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool displayWarnings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public List<TextAsset> emojiFallbackTextAssets
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 35
	}

	public bool enableEmojiSupport
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public List<FontAsset> fallbackFontAssets
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 35
	}

	internal List<FontAsset> fallbackOSFontAssets
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
		[CallsDeduplicatedMethods(Count = 3)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 162
	}

	[Obsolete("The Fallback Sprite Assets list is now obsolete. Use the emojiFallbackTextAssets instead.", True)]
	public List<SpriteAsset> fallbackSpriteAssets
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public UnicodeLineBreakingRules lineBreakingRules
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 141
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public bool matchMaterialPreset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int missingCharacterUnicode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public uint missingSpriteCharacterUnicode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal IntPtr nativeTextSettings
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 29
	}

	internal static SpriteAsset s_GlobalSpriteAsset
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 86
	}

	public string styleSheetsResourcePath
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public internal string version
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CalledBy(Type = "UnityEngine.UIElements.PanelTextSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RuntimeTextSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TextSettings() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSettings::Create")]
	private static IntPtr CreateNativeObject(IntPtr[] fallbacks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateNativeObject_Injected(ref ManagedSpanWrapper fallbacks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSettings::Destroy")]
	private static void DestroyNativeObject(IntPtr m_NativeTextSettings) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public bool get_clearDynamicDataOnBuild() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_defaultColorGradientPresetsPath() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FontAsset get_defaultFontAsset() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_defaultFontAssetPath() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public SpriteAsset get_defaultSpriteAsset() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_defaultSpriteAssetPath() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public TextStyleSheet get_defaultStyleSheet() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_displayWarnings() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public List<TextAsset> get_emojiFallbackTextAssets() { }

	[CallerCount(Count = 0)]
	public bool get_enableEmojiSupport() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public List<FontAsset> get_fallbackFontAssets() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal List<FontAsset> get_fallbackOSFontAssets() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_matchMaterialPreset() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_missingCharacterUnicode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint get_missingSpriteCharacterUnicode() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeTextSettings() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string get_styleSheetsResourcePath() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_version() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSettings), Member = "InitializeFontReferenceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetFactory), Member = "ConvertFontToFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal FontAsset GetCachedFontAsset(Font font) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal override List<FontAsset> GetFallbackFontAssets(int textPixelSize = -1) { }

	[CalledBy(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private IntPtr[] GetGlobalFallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	private List<FontAsset> GetOSFontAssetList() { }

	[CallerCount(Count = 0)]
	internal override List<FontAsset> GetStaticFallbackOSFontAsset() { }

	[CalledBy(Type = typeof(TextSettings), Member = "GetCachedFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected void InitializeFontReferenceLookup() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_clearDynamicDataOnBuild(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultColorGradientPresetsPath(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultFontAsset(FontAsset value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultFontAssetPath(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultSpriteAssetPath(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_displayWarnings(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_emojiFallbackTextAssets(List<TextAsset> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_enableEmojiSupport(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_matchMaterialPreset(bool value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_missingCharacterUnicode(int value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public void set_missingSpriteCharacterUnicode(uint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_styleSheetsResourcePath(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_version(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSettings), Member = "get_nativeTextSettings", ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSettings), Member = "GetGlobalFallbacks", ReturnType = typeof(IntPtr[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void UpdateNativeTextSettings() { }

}

