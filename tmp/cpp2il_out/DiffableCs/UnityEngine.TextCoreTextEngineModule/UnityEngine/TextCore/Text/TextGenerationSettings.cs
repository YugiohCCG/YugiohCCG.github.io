namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static Func<Boolean> IsEditorTextRenderingModeBitmap; //Field offset: 0x0
	public const bool useMaxVisibleDescender = False; //Field offset: 0x0
	public const int firstVisibleCharacter = 0; //Field offset: 0x0
	public const int maxVisibleLines = 99999; //Field offset: 0x0
	public const int maxVisibleWords = 99999; //Field offset: 0x0
	public const int maxVisibleCharacters = 99999; //Field offset: 0x0
	public const float lineSpacingMax = 0; //Field offset: 0x0
	public const float lineSpacing = 0; //Field offset: 0x0
	public const bool tagNoParsing = False; //Field offset: 0x0
	public const float fontSizeMax = 0; //Field offset: 0x0
	public const float fontSizeMin = 0; //Field offset: 0x0
	public const bool autoSize = False; //Field offset: 0x0
	public const float charWidthMaxAdj = 0; //Field offset: 0x0
	public const float wordWrappingRatio = 0.4; //Field offset: 0x0
	internal static readonly List<OTL_FeatureTag> fontFeatures; //Field offset: 0x8
	private RenderedText m_RenderedText; //Field offset: 0x10
	private string m_CachedRenderedText; //Field offset: 0x30
	public Rect screenRect; //Field offset: 0x38
	public float pixelsPerPoint; //Field offset: 0x48
	public bool isEditorRenderingModeBitmap; //Field offset: 0x4C
	public FontAsset fontAsset; //Field offset: 0x50
	public FontStyles fontStyle; //Field offset: 0x58
	public TextSettings textSettings; //Field offset: 0x60
	public TextAlignment textAlignment; //Field offset: 0x68
	public TextOverflowMode overflowMode; //Field offset: 0x6C
	public Color color; //Field offset: 0x70
	public bool shouldConvertToLinearSpace; //Field offset: 0x80
	public float fontSize; //Field offset: 0x84
	public bool emojiFallbackSupport; //Field offset: 0x88
	public bool richText; //Field offset: 0x89
	public bool isRightToLeft; //Field offset: 0x8A
	public float extraPadding; //Field offset: 0x8C
	public bool parseControlCharacters; //Field offset: 0x90
	public bool isPlaceholder; //Field offset: 0x91
	public float characterSpacing; //Field offset: 0x94
	public float wordSpacing; //Field offset: 0x98
	public float paragraphSpacing; //Field offset: 0x9C
	public TextWrappingMode textWrappingMode; //Field offset: 0xA0
	public TextFontWeight fontWeight; //Field offset: 0xA4
	public bool isIMGUI; //Field offset: 0xA8

	public RenderedText renderedText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement", typeof(RenderedText&), typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 59
	}

	public string text
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderedText), Member = "CreateString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 86
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 261
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static TextGenerationSettings() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<InitThreadArrays>b__4_0", ReturnType = typeof(TextGenerationSettings))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<get_settingsArray>b__7_0", ReturnType = typeof(TextGenerationSettings))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextGenerationSettings() { }

	[CalledBy(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(TextGenerationSettings other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RenderedText get_renderedText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderedText), Member = "CreateString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_text() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "ToHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement", typeof(RenderedText&), typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void set_renderedText(RenderedText value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	public void set_text(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderedText), Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 176)]
	public virtual string ToString() { }

}

