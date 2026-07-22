namespace System;

internal static class UriHelper
{
	private static readonly Char[] HexUpperChars; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static UriHelper() { }

	[CalledBy(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	internal static void EscapeAsciiChar(char ch, Char[] to, ref int pos) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = "System.Uri+Check")]
	[CalledBy(Type = typeof(Uri), Member = "UnescapeOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckForEscapedUnreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal static char EscapedAscii(char digit, char next) { }

	[CalledBy(Type = typeof(Uri), Member = "InternalEscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "EscapeDataString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetRelativeSerializationString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "IsUnreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EnsureDestinationSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(int), typeof(short), typeof(short), typeof(Int32&), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeAsciiChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "IsReservedUnreservedOrHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckForEscapedUnreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "IsAsciiLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool Is3986Unreserved(char c) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool IsNotSafeForUnescape(char ch) { }

	[CalledBy(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriHelper), Member = "IsUnreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsReservedUnreservedOrHash(char c) { }

	[CalledBy(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(UriHelper), Member = "IsReservedUnreservedOrHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "IsAsciiLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsUnreserved(char c) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeAsciiChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "IsBidiControlCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, ref int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	[CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CultureInfo)}, ReturnType = typeof(char))]
	internal static bool TestForSubPath(Char* pMe, ushort meLength, Char* pShe, ushort sheLength, bool ignoreCase) { }

	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckForUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "UnescapeDataString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetRelativeSerializationString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "IriParsingStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(UriHelper), Member = "IsNotSafeForUnescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

}

