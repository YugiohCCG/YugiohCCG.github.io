namespace TMPro;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Settings.html")]
public class TMP_Settings : ScriptableObject
{
	internal class LineBreakingTable
	{
		public HashSet<UInt32> leadingCharacters; //Field offset: 0x10
		public HashSet<UInt32> followingCharacters; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LineBreakingTable() { }

	}

	private static TMP_Settings s_Instance; //Field offset: 0x0
	internal static string s_CurrentAssetVersion; //Field offset: 0x8
	[SerializeField]
	internal string assetVersion; //Field offset: 0x18
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	private TextWrappingModes m_TextWrappingMode; //Field offset: 0x20
	[SerializeField]
	private bool m_enableKerning; //Field offset: 0x24
	[SerializeField]
	private List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x28
	[SerializeField]
	private bool m_enableExtraPadding; //Field offset: 0x30
	[SerializeField]
	private bool m_enableTintAllSprites; //Field offset: 0x31
	[SerializeField]
	private bool m_enableParseEscapeCharacters; //Field offset: 0x32
	[SerializeField]
	private bool m_EnableRaycastTarget; //Field offset: 0x33
	[SerializeField]
	private bool m_GetFontFeaturesAtRuntime; //Field offset: 0x34
	[SerializeField]
	private int m_missingGlyphCharacter; //Field offset: 0x38
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x3C
	[SerializeField]
	private bool m_warningsDisabled; //Field offset: 0x3D
	[SerializeField]
	private TMP_FontAsset m_defaultFontAsset; //Field offset: 0x40
	[SerializeField]
	private string m_defaultFontAssetPath; //Field offset: 0x48
	[SerializeField]
	private float m_defaultFontSize; //Field offset: 0x50
	[SerializeField]
	private float m_defaultAutoSizeMinRatio; //Field offset: 0x54
	[SerializeField]
	private float m_defaultAutoSizeMaxRatio; //Field offset: 0x58
	[SerializeField]
	private Vector2 m_defaultTextMeshProTextContainerSize; //Field offset: 0x5C
	[SerializeField]
	private Vector2 m_defaultTextMeshProUITextContainerSize; //Field offset: 0x64
	[SerializeField]
	private bool m_autoSizeTextContainer; //Field offset: 0x6C
	[SerializeField]
	private bool m_IsTextObjectScaleStatic; //Field offset: 0x6D
	[SerializeField]
	private List<TMP_FontAsset> m_fallbackFontAssets; //Field offset: 0x70
	[SerializeField]
	private bool m_matchMaterialPreset; //Field offset: 0x78
	[SerializeField]
	private bool m_HideSubTextObjects; //Field offset: 0x79
	[SerializeField]
	private TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x80
	[SerializeField]
	private string m_defaultSpriteAssetPath; //Field offset: 0x88
	[SerializeField]
	private bool m_enableEmojiSupport; //Field offset: 0x90
	[SerializeField]
	private uint m_MissingCharacterSpriteUnicode; //Field offset: 0x94
	[SerializeField]
	private List<TMP_Asset> m_EmojiFallbackTextAssets; //Field offset: 0x98
	[SerializeField]
	private string m_defaultColorGradientPresetsPath; //Field offset: 0xA0
	[SerializeField]
	private TMP_StyleSheet m_defaultStyleSheet; //Field offset: 0xA8
	[SerializeField]
	private string m_StyleSheetsResourcePath; //Field offset: 0xB0
	[SerializeField]
	private TextAsset m_leadingCharacters; //Field offset: 0xB8
	[SerializeField]
	private TextAsset m_followingCharacters; //Field offset: 0xC0
	[SerializeField]
	private LineBreakingTable m_linebreakingRules; //Field offset: 0xC8
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0xD0

	public static bool autoSizeTextContainer
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static bool clearDynamicDataOnBuild
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static string defaultColorGradientPresetsPath
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	public static TMP_FontAsset defaultFontAsset
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 96
	}

	public static string defaultFontAssetPath
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static float defaultFontSize
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 80
	}

	public static TMP_SpriteAsset defaultSpriteAsset
	{
		[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
		[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 102
	}

	public static string defaultSpriteAssetPath
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	public static TMP_StyleSheet defaultStyleSheet
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 102
	}

	public static float defaultTextAutoSizingMaxRatio
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 80
	}

	public static float defaultTextAutoSizingMinRatio
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 80
	}

	public static Vector2 defaultTextMeshProTextContainerSize
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 93
	}

	public static Vector2 defaultTextMeshProUITextContainerSize
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 93
	}

	public static List<TMP_Asset> emojiFallbackTextAssets
	{
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 102
	}

	public static bool enableEmojiSupport
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 87
	}

	public static bool enableExtraPadding
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled by default on newly created text components.")]
	public static bool enableKerning
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 187
	}

	public static bool enableParseEscapeCharacters
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static bool enableRaycastTarget
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static bool enableTintAllSprites
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static List<TMP_FontAsset> fallbackFontAssets
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 96
	}

	public static TextAsset followingCharacters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	public static List<OTL_FeatureTag> fontFeatures
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static bool getFontFeaturesAtRuntime
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static bool hideSubTextObjects
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static TMP_Settings instance
	{
		[CallerCount(Count = 63)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_isTMPSettingsNull", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 714
	}

	public static bool isTextObjectScaleStatic
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 84
	}

	internal static bool isTMPSettingsNull
	{
		[CalledBy(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal get { } //Length: 126
	}

	public static TextAsset leadingCharacters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	public static LineBreakingTable linebreakingRules
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Settings), Member = "GetCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 603
	}

	public static bool matchMaterialPreset
	{
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	public static uint missingCharacterSpriteUnicode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 81
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 86
	}

	public static int missingGlyphCharacter
	{
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 83
	}

	public static string styleSheetsResourcePath
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	public static TextWrappingModes textWrappingMode
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 78
	}

	public static bool useModernHangulLineBreakingRules
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 87
	}

	public static string version
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public static bool warningsDisabled
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(Color32)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static TMP_Settings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public TMP_Settings() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_autoSizeTextContainer() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_clearDynamicDataOnBuild() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static string get_defaultColorGradientPresetsPath() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_FontAsset get_defaultFontAsset() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static string get_defaultFontAssetPath() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static float get_defaultFontSize() { }

	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static string get_defaultSpriteAssetPath() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static float get_defaultTextAutoSizingMaxRatio() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static float get_defaultTextAutoSizingMinRatio() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static List<TMP_Asset> get_emojiFallbackTextAssets() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_enableEmojiSupport() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_enableExtraPadding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_enableKerning() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_enableParseEscapeCharacters() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_enableRaycastTarget() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_enableTintAllSprites() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static TextAsset get_followingCharacters() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static List<OTL_FeatureTag> get_fontFeatures() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_getFontFeaturesAtRuntime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_hideSubTextObjects() { }

	[CallerCount(Count = 63)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_isTMPSettingsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public static TMP_Settings get_instance() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_isTextObjectScaleStatic() { }

	[CalledBy(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	internal static bool get_isTMPSettingsNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static TextAsset get_leadingCharacters() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "GetCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static LineBreakingTable get_linebreakingRules() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_matchMaterialPreset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static uint get_missingCharacterSpriteUnicode() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static int get_missingGlyphCharacter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static string get_styleSheetsResourcePath() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static TextWrappingModes get_textWrappingMode() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_useModernHangulLineBreakingRules() { }

	[CallerCount(Count = 0)]
	public static string get_version() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_warningsDisabled() { }

	[CalledBy(Type = typeof(TMP_Settings), Member = "get_linebreakingRules", ReturnType = typeof(LineBreakingTable))]
	[CalledBy(Type = typeof(TMP_Settings), Member = "LoadLinebreakingRules", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_FontAsset GetFontAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public static TMP_Settings GetSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_SpriteAsset GetSpriteAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_StyleSheet GetStyleSheet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_Settings LoadDefaultSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "GetCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void LoadLinebreakingRules() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_defaultFontAsset(TMP_FontAsset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_defaultSpriteAsset(TMP_SpriteAsset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_defaultStyleSheet(TMP_StyleSheet value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_emojiFallbackTextAssets(List<TMP_Asset> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_enableEmojiSupport(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_fallbackFontAssets(List<TMP_FontAsset> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_isTextObjectScaleStatic(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_missingGlyphCharacter(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetAssetVersion() { }

}

