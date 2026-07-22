namespace System.Net;

internal sealed class HttpListenerRequestUriBuilder
{
	private enum EncodingType
	{
		Primary = 0,
		Secondary = 1,
	}

	private enum ParsingResult
	{
		Success = 0,
		InvalidString = 1,
		EncodingError = 2,
	}

	private static readonly bool useCookedRequestUrl; //Field offset: 0x0
	private static readonly Encoding utf8Encoding; //Field offset: 0x8
	private static readonly Encoding ansiEncoding; //Field offset: 0x10
	private readonly string rawUri; //Field offset: 0x10
	private readonly string cookedUriScheme; //Field offset: 0x18
	private readonly string cookedUriHost; //Field offset: 0x20
	private readonly string cookedUriPath; //Field offset: 0x28
	private readonly string cookedUriQuery; //Field offset: 0x30
	private StringBuilder requestUriString; //Field offset: 0x38
	private List<Byte> rawOctets; //Field offset: 0x40
	private string rawPath; //Field offset: 0x48
	private Uri requestUri; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static HttpListenerRequestUriBuilder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private HttpListenerRequestUriBuilder(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(ParsingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool AddPercentEncodedOctetToRawOctetsList(Encoding encoding, string escapedCharacter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private static string AddSlashToAsteriskOnlyPath(string path) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private static void AppendOctetsPercentEncoded(StringBuilder target, IEnumerable<Byte> octets) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(ParsingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ConvertFromUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendOctetsPercentEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	private bool AppendUnicodeCodePointValuePercentEncoded(string codePoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingCookedPath", ReturnType = typeof(void))]
	private Uri Build() { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetRequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "Build", ReturnType = typeof(Uri))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private void BuildRequestUriUsingCookedPath() { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetRequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "Build", ReturnType = typeof(Uri))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(ParsingResult))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	private void BuildRequestUriUsingRawPath() { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(ParsingResult))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private ParsingResult BuildRequestUriUsingRawPath(Encoding encoding) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "ParseRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(ParsingResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendOctetsPercentEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetOctetsAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 27)]
	private bool EmptyDecodeAndAppendRawOctetsList(Encoding encoding) { }

	[CallerCount(Count = 0)]
	private static Encoding GetEncoding(EncodingType type) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static string GetOctetsAsString(IEnumerable<Byte> octets) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string GetPath(string uriString) { }

	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingCookedPath", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static Uri GetRequestUri(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LogWarning(string methodName, string message, Object[] args) { }

	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(ParsingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AddPercentEncodedOctetToRawOctetsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private ParsingResult ParseRawPath(Encoding encoding) { }

}

