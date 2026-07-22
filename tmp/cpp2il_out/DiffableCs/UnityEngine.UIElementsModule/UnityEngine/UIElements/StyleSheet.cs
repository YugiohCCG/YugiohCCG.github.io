namespace UnityEngine.UIElements;

[HelpURL("UIE-USS")]
public class StyleSheet : ScriptableObject
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct ImportStruct
	{
		public StyleSheet styleSheet; //Field offset: 0x0
		public String[] mediaQueries; //Field offset: 0x8

	}

	public enum OrderedSelectorType
	{
		None = -1,
		Name = 0,
		Type = 1,
		Class = 2,
		Length = 3,
	}

	private static string kCustomPropertyMarker; //Field offset: 0x0
	[SerializeField]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; //Field offset: 0x19
	[SerializeField]
	private StyleRule[] m_Rules; //Field offset: 0x20
	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors; //Field offset: 0x28
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Single[] floats; //Field offset: 0x30
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Dimension[] dimensions; //Field offset: 0x38
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Color[] colors; //Field offset: 0x40
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal String[] strings; //Field offset: 0x48
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Object[] assets; //Field offset: 0x50
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ImportStruct[] imports; //Field offset: 0x58
	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; //Field offset: 0x60
	[SerializeField]
	private int m_ContentHash; //Field offset: 0x68
	[SerializeField]
	internal ScalableImage[] scalableImages; //Field offset: 0x70
	internal Dictionary<String, StyleComplexSelector>[] tables; //Field offset: 0x78
	internal int nonEmptyTablesMask; //Field offset: 0x80
	internal StyleComplexSelector firstRootSelector; //Field offset: 0x88
	internal StyleComplexSelector firstWildCardSelector; //Field offset: 0x90
	private bool m_IsDefaultStyleSheet; //Field offset: 0x98

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleComplexSelector[] complexSelectors
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 37
	}

	public int contentHash
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal List<StyleSheet> flattenedRecursiveImports
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 7
	}

	public internal bool importedWithErrors
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public internal bool importedWithWarnings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool isDefaultStyleSheet
	{
		[CalledBy(Type = typeof(SelectorMatchRecord), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 10
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThemeStyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 287
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleRule[] rules
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 37
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static StyleSheet() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public StyleSheet() { }

	[CalledBy(Type = typeof(StyleSheet), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CustomStartsWith(string originalString, string pattern) { }

	[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void FlattenImportedStyleSheetsRecursive() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal StyleComplexSelector[] get_complexSelectors() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public int get_contentHash() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_importedWithErrors() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_importedWithWarnings() { }

	[CalledBy(Type = typeof(SelectorMatchRecord), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	internal bool get_isDefaultStyleSheet() { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	internal StyleRule[] get_rules() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	internal override void OnEnable() { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object ReadAssetReference(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = "T")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Color ReadColor(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(BackgroundPositionKeyword)}, ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchTime", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchPercentage", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchLength", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue)}, ReturnType = typeof(Angle))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchAngle", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TransformOrigin))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextShadow))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TimeValue))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOriginEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(Length))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListEasingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadEnum(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.StyleVariableResolver+Result")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Cursor))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Scale))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Rotate))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchLength", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchPercentage", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchAngle", ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal float ReadFloat(StyleValueHandle handle) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadFunctionName(StyleValueHandle handle) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadResourcePath(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScalableImage[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(ScalableImage))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadString(StyleValueHandle handle) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.StyleVariableResolver+Result")]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string ReadVariable(StyleValueHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public void set_contentHash(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_importedWithErrors(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_importedWithWarnings(bool value) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "FlattenImportedStyleSheetsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThemeStyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_isDefaultStyleSheet(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_rules(StyleRule[] value) { }

	[CalledBy(Type = typeof(StyleSheet), Member = "set_rules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "set_complexSelectors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThemeStyleSheet), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleSheet), Member = "CustomStartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheetExtensions), Member = "IsVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleComplexSelector), Member = "CachePseudoStateMasks", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleComplexSelector), Member = "CalculateHashes", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsInvalidInstructions]
	private void SetupReferences() { }

	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Color&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	internal bool TryReadAssetReference(StyleValueHandle handle, out object value) { }

	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color>), typeof(Color&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(StyleValueType), typeof(StyleValueHandle), "T&"}, ReturnType = typeof(bool))]
	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	[CalledBy(Type = typeof(ScrollView), Member = "ReadSingleLineHeight", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dimension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Unit)}, ReturnType = typeof(void))]
	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Single>), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSheet), Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle), typeof(Object&)}, ReturnType = typeof(bool))]
	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

}

