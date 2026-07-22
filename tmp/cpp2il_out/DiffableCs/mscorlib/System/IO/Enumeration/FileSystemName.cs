namespace System.IO.Enumeration;

public static class FileSystemName
{
	private static readonly Char[] s_wildcardChars; //Field offset: 0x0
	private static readonly Char[] s_simpleWildcardChars; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static FileSystemName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public static bool MatchesSimpleExpression(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public static bool MatchesWin32Expression(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase = true) { }

	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "MatchesPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(EnumerationOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchesWin32Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchesSimpleExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "T&", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool MatchPattern(ReadOnlySpan<Char> expression, ReadOnlySpan<Char> name, bool ignoreCase, bool useExtendedWildcards) { }

	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "NormalizeInputs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static string TranslateWin32Expression(string expression) { }

}

