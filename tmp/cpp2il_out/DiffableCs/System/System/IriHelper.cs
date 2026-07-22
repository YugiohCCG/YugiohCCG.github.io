namespace System;

internal static class IriHelper
{

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = "System.Uri+Check")]
	[CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = "System.Uri+Check")]
	[CalledBy(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "IsGenDelim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriHelper), Member = "IsNotSafeForUnescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIsReserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UriComponents)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeAsciiChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "IsBidiControlCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal static string EscapeUnescapeIri(Char* pInput, int start, int end, UriComponents component) { }

}

