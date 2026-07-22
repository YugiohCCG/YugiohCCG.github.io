namespace TMPro;

public class TMP_TextParsingUtilities
{
	private static readonly TMP_TextParsingUtilities s_Instance; //Field offset: 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; //Field offset: 0x0
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; //Field offset: 0x0
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x8
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x10

	public static TMP_TextParsingUtilities instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 347)]
	[CallsUnknownMethods(Count = 2301)]
	private static TMP_TextParsingUtilities() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TMP_TextParsingUtilities() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	[CallerCount(Count = 0)]
	public static TMP_TextParsingUtilities get_instance() { }

	[CalledBy(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Style), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static int GetHashCode(string s) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int GetHashCodeCaseSensitive(string s) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool IsBaseGlyph(uint c) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	internal static bool IsCJK(uint c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsDiacriticalMark(uint c) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsEmoji(uint c) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsEmojiPresentationForm(uint c) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsHangul(uint c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsHighSurrogate(uint c) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static bool IsIgnorableForLigature(uint cp) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsLowSurrogate(uint c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static uint ToLowerASCIIFast(uint c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToLowerASCIIFast(char c) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToUpperASCIIFast(char c) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_Text+TextBackingContainer", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static uint ToUpperASCIIFast(uint c) { }

}

