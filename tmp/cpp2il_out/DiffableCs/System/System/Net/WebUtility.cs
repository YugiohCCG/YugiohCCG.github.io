namespace System.Net;

public static class WebUtility
{
	private class UrlDecoder
	{
		private int _bufferSize; //Field offset: 0x10
		private int _numChars; //Field offset: 0x14
		private Char[] _charBuffer; //Field offset: 0x18
		private int _numBytes; //Field offset: 0x20
		private Byte[] _byteBuffer; //Field offset: 0x28
		private Encoding _encoding; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal UrlDecoder(int bufferSize, Encoding encoding) { }

		[CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void AddByte(byte b) { }

		[CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UrlDecoder), Member = "FlushBytes", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void AddChar(char ch) { }

		[CalledBy(Type = typeof(UrlDecoder), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UrlDecoder), Member = "GetString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void FlushBytes() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UrlDecoder), Member = "FlushBytes", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		internal string GetString() { }

	}

	private static readonly Char[] _htmlEntityEndingChars; //Field offset: 0x0
	private static UnicodeDecodingConformance _htmlDecodeConformance; //Field offset: 0x8
	private static UnicodeEncodingConformance _htmlEncodeConformance; //Field offset: 0xC

	private static UnicodeEncodingConformance HtmlEncodeConformance
	{
		[CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextWriter)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 270
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static WebUtility() { }

	[CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static UnicodeEncodingConformance get_HtmlEncodeConformance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(bool))]
	private static int GetNextUnicodeScalarValueFromUtf16Surrogate(ref Char* pch, ref int charsRemaining) { }

	[CalledBy(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	private static int HexToInt(char h) { }

	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string HtmlEncode(string value) { }

	[CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebUtility), Member = "IndexOfHtmlEncodingChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WebUtility), Member = "get_HtmlEncodeConformance", ReturnType = typeof(UnicodeEncodingConformance))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	public static void HtmlEncode(string value, TextWriter output) { }

	[CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WebUtility), Member = "get_HtmlEncodeConformance", ReturnType = typeof(UnicodeEncodingConformance))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int IndexOfHtmlEncodingChars(string s, int startPos) { }

	[CallerCount(Count = 0)]
	private static char IntToHex(int n) { }

	[CalledBy(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsUrlSafeChar(char ch) { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnAddDeck>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WebUtility), Member = "UrlDecodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	public static string UrlDecode(string encodedValue) { }

	[CalledBy(Type = typeof(WebUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(WebUtility), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UrlDecoder), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UrlDecoder), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UrlDecoder), Member = "FlushBytes", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string UrlDecodeInternal(string value, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] UrlEncode(Byte[] bytes, int offset, int count, bool alwaysCreateNewReturnValue) { }

	[CalledBy(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WebUtility), Member = "IsUrlSafeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private static Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	[CalledBy(Type = "Card.Card", Member = "get_TCGPlayerSearchLink", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string UrlEncode(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static bool ValidateUrlEncodingParameters(Byte[] bytes, int offset, int count) { }

}

