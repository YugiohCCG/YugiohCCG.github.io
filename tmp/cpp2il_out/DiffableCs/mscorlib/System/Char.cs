namespace System;

[IsReadOnly]
public struct char : IComparable, IComparable<Char>, IEquatable<Char>, IConvertible
{
	private static readonly Byte[] s_categoryForLatin1; //Field offset: 0x0
	private readonly char m_value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Char() { }

	[CalledBy(Type = typeof(TextInfo), Member = "ToTitleCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckLetter(UnicodeCategory uc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckNumber(UnicodeCategory uc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckSymbol(UnicodeCategory uc) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_char", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public override int CompareTo(char value) { }

	[CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string ConvertFromUtf32(int utf32) { }

	[CalledBy(Type = typeof(EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Char*&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAssetUtilities", Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "TMPro.TMP_FontAssetUtilities", Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", typeof(Int32&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Char>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.UInt32[]&", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAssetUtilities", Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAssetUtilities", Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public override bool Equals(char obj) { }

	[CalledBy(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4", "T5", "T6"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4", "T5", "T6"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "IsNameChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "MakePascal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "MakeValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "IsValidStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	[CalledBy(Type = typeof(IdnMapping), Member = "NamePrep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IdnMapping), Member = "VerifyProhibitedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsAscii(char ch) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.StringHelpers", Member = "IsPrintable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsControl(char c) { }

	[CalledBy(Type = "Card.Manager+<LoadCustomScript>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool IsDigit(string s, int index) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[ContainsUnimplementedInstructions]
	public static bool IsDigit(char c) { }

	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsHighSurrogate(char c) { }

	[CalledBy(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool IsHighSurrogate(string s, int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsLatin1(char ch) { }

	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "SpanToEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", "TagType&", typeof(String&), "System.ReadOnlySpan`1<Char>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "tagMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ReadRegexString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.UncNameHelper", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(ushort), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "IsNextLetterOrDash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "UnityEngine.UIElements.Column+UxmlObjectTraits`1", Member = "ParseLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.UIElements.Length"}, ReturnType = "UnityEngine.UIElements.Length")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "SkipWhiteSpacesAndNonLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Path), Member = "WindowsDriveAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsLetter(char c) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher+<>c", Member = "<With>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.CSharpCodeHelpers", Member = "IsProperIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.CSharpCodeHelpers", Member = "IsEmptyOrProperIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.CSharpCodeHelpers", Member = "MakeIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParseConstructorAsync>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseProperty", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ValidIdentifierChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseUnquotedProperty", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ReadUnquotedPropertyReportIfDone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "ClassifyChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextSelectingUtilities+CharacterType")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsLetterOrDigit(char c) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "InjectSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "MakePascal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.CSharpCodeHelpers", Member = "MakeTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.XR.XRLayoutBuilder", Member = "SanitizeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ArabicSupport.ArabicFixer", Member = "Fix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsLeadingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsIgnoredCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsLower(char c) { }

	[CallerCount(Count = 21)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsLowSurrogate(char c) { }

	[CalledBy(Type = "ArabicFixerTool", Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsIgnoredCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsLeadingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsMiddleLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "IsNextNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParseValueAsync>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Plural.Ast.AstTokenParser", Member = "GetNextToken", ReturnType = "NGettext.Plural.Ast.Token")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsNumber(char c) { }

	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(char), Member = "GetLatin1UnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool IsNumber(string s, int index) { }

	[CalledBy(Type = "ArabicFixerTool", Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsIgnoredCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsLeadingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsFinishingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsMiddleLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "GetCompleteWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "System.Nullable`1<ValueTuple`3<Int32, Int32, String>>")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsPunctuation(char c) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToCamelCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[ContainsUnimplementedInstructions]
	public static bool IsSeparator(char c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsSeparatorLatin1(char c) { }

	[CalledBy(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool IsSurrogate(string s, int index) { }

	[CalledBy(Type = typeof(DecoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte*), typeof(Char*&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BinaryWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlWellFormedWriter", Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebUtility", Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebUtility", Member = "IndexOfHtmlEncodingChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool IsSurrogate(char c) { }

	[CalledBy(Type = "System.Xml.CharEntityEncoderFallbackBuffer", Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlWellFormedWriter", Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IriHelper", Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebUtility", Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebUtility", Member = "GetNextUnicodeScalarValueFromUtf16Surrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*&", typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	[CalledBy(Type = "ArabicFixerTool", Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsIgnoredCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsLeadingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsFinishingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsMiddleLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsSymbol(char c) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToSeparatedCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToCamelCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "InjectSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.XR.XRLayoutBuilder", Member = "SanitizeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Extensions.General", Member = "AddSpacesToSentence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsLeadingLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "IsIgnoredCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ArabicFixerTool", Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsUpper(char c) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XmlDataTreeWriter", Member = "PreserveSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool IsWhiteSpace(string s, int index) { }

	[CallerCount(Count = 116)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool IsWhiteSpace(char c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsWhiteSpaceLatin1(char c) { }

	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static char Parse(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static char ToLower(char c) { }

	[CalledBy(Type = "System.UriHelper", Member = "TestForSubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(ushort), "System.Char*", typeof(ushort), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToSeparatedCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static char ToLower(char c, CultureInfo culture) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "IsHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath+ParsedPathComponent", Member = "ComparePathElementToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.Substring", typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath", Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.Substring", "UnityEngine.InputSystem.Utilities.InternedString"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath", Member = "MatchPathComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), "UnityEngine.InputSystem.InputControlPath+PathComponentType", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDElementDescriptor", Member = "DetermineName", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.StringHelpers", Member = "CharacterSeparatedListsHaveAtLeastOneCommonElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static char ToLowerInvariant(char c) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	public static string ToString(char c) { }

	[CallerCount(Count = 95)]
	[Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public override string ToString(IFormatProvider provider) { }

	[CallerCount(Count = 95)]
	[Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "MakePascal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Serialization.TypeTranslator", Member = "GetArrayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X501", Member = "IsHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X501", Member = "ReadHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static char ToUpper(char c, CultureInfo culture) { }

	[CalledBy(Type = "ZXing.OneD.CodaBarWriter", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Boolean[]")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), "UnityEngine.Vector2", typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = "UnityEngine.Vector2")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static char ToUpper(char c) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.CSharpCodeHelpers", Member = "MakeTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonString", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.JsonParser+JsonString"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static char ToUpperInvariant(char c) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	public static bool TryParse(string s, out char result) { }

}

