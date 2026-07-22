namespace System;

internal class DomainNameHelper
{

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "StripBidiControlCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	[CallerCount(Count = 0)]
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsIdnAce(string input, int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsIdnAce(Char* input, int index) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsValid(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsValidByIri(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "StripBidiControlCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

}

