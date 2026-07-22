namespace System.Globalization;

public static class CharUnicodeInfo
{

	private static ReadOnlySpan<Byte> CategoriesValue
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 76
	}

	private static ReadOnlySpan<Byte> CategoryLevel1Index
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 76
	}

	private static ReadOnlySpan<Byte> CategoryLevel2Index
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 76
	}

	private static ReadOnlySpan<Byte> CategoryLevel3Index
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 76
	}

	[CallerCount(Count = 0)]
	private static ReadOnlySpan<Byte> get_CategoriesValue() { }

	[CallerCount(Count = 0)]
	private static ReadOnlySpan<Byte> get_CategoryLevel1Index() { }

	[CallerCount(Count = 0)]
	private static ReadOnlySpan<Byte> get_CategoryLevel2Index() { }

	[CallerCount(Count = 0)]
	private static ReadOnlySpan<Byte> get_CategoryLevel3Index() { }

	[CalledBy(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "CharInClassInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "CharInCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	[CalledBy(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	[CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static int InternalConvertToUtf32(string s, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	[CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 1)]
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	[CalledBy(Type = typeof(StringInfo), Member = "GetCurrentTextElementLen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(UnicodeCategory&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToTitleCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 1)]
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	[CalledBy(Type = typeof(StringInfo), Member = "GetCurrentTextElementLen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(UnicodeCategory&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	[CalledBy(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal static bool IsWhiteSpace(string s, int index) { }

	[CalledBy(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[ContainsUnimplementedInstructions]
	internal static bool IsWhiteSpace(char c) { }

}

