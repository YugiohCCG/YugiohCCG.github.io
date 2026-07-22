namespace System;

[TypeConverter(typeof(UriTypeConverter))]
public class Uri : ISerializable
{
	[Flags]
	private enum Check
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 128,
		BackslashInPath = 16,
		ReservedFound = 32,
		NotIriCanonical = 64,
		FoundNonAscii = 8,
	}

	[Flags]
	private enum Flags
	{
		Zero = 0,
		SchemeNotCanonical = 1,
		UserNotCanonical = 2,
		HostNotCanonical = 4,
		PortNotCanonical = 8,
		PathNotCanonical = 16,
		QueryNotCanonical = 32,
		FragmentNotCanonical = 64,
		CannotDisplayCanonical = 127,
		E_UserNotCanonical = 128,
		E_HostNotCanonical = 256,
		E_PortNotCanonical = 512,
		E_PathNotCanonical = 1024,
		E_QueryNotCanonical = 2048,
		E_FragmentNotCanonical = 4096,
		E_CannotDisplayCanonical = 8064,
		ShouldBeCompressed = 8192,
		FirstSlashAbsent = 16384,
		BackslashInPath = 32768,
		IndexMask = 65535,
		HostTypeMask = 458752,
		HostNotParsed = 0,
		IPv6HostType = 65536,
		IPv4HostType = 131072,
		DnsHostType = 196608,
		UncHostType = 262144,
		BasicHostType = 327680,
		UnusedHostType = 393216,
		UnknownHostType = 458752,
		UserEscaped = 524288,
		AuthorityFound = 1048576,
		HasUserInfo = 2097152,
		LoopbackHost = 4194304,
		NotDefaultPort = 8388608,
		UserDrivenParsing = 16777216,
		CanonicalDnsHost = 33554432,
		ErrorOrParsingRecursion = 67108864,
		DosPath = 134217728,
		UncPath = 268435456,
		ImplicitFile = 536870912,
		MinimalUriInfoSet = 1073741824,
		AllUriInfoSet = 2147483648,
		IdnHost = 4294967296,
		HasUnicode = 8589934592,
		HostUnicodeNormalized = 17179869184,
		RestUnicodeNormalized = 34359738368,
		UnicodeHost = 68719476736,
		IntranetUri = 137438953472,
		UseOrigUncdStrOffset = 274877906944,
		UserIriCanonical = 549755813888,
		PathIriCanonical = 1099511627776,
		QueryIriCanonical = 2199023255552,
		FragmentIriCanonical = 4398046511104,
		IriCanonical = 8246337208320,
		CompressedSlashes = 17592186044416,
	}

	private class MoreInfo
	{
		public string Path; //Field offset: 0x10
		public string Query; //Field offset: 0x18
		public string Fragment; //Field offset: 0x20
		public string AbsoluteUri; //Field offset: 0x28
		public int Hash; //Field offset: 0x30
		public string RemoteUrl; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public MoreInfo() { }

	}

	private struct Offset
	{
		public ushort Scheme; //Field offset: 0x0
		public ushort User; //Field offset: 0x2
		public ushort Host; //Field offset: 0x4
		public ushort PortValue; //Field offset: 0x6
		public ushort Path; //Field offset: 0x8
		public ushort Query; //Field offset: 0xA
		public ushort Fragment; //Field offset: 0xC
		public ushort End; //Field offset: 0xE

	}

	private class UriInfo
	{
		public string Host; //Field offset: 0x10
		public string ScopeId; //Field offset: 0x18
		public string String; //Field offset: 0x20
		public Offset Offset; //Field offset: 0x28
		public string DnsSafeHost; //Field offset: 0x38
		public MoreInfo MoreInfo; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UriInfo() { }

	}

	public static readonly string UriSchemeFile; //Field offset: 0x0
	public static readonly string UriSchemeFtp; //Field offset: 0x8
	public static readonly string UriSchemeGopher; //Field offset: 0x10
	public static readonly string UriSchemeHttp; //Field offset: 0x18
	public static readonly string UriSchemeHttps; //Field offset: 0x20
	internal static readonly string UriSchemeWs; //Field offset: 0x28
	internal static readonly string UriSchemeWss; //Field offset: 0x30
	public static readonly string UriSchemeMailto; //Field offset: 0x38
	public static readonly string UriSchemeNews; //Field offset: 0x40
	public static readonly string UriSchemeNntp; //Field offset: 0x48
	public static readonly string UriSchemeNetTcp; //Field offset: 0x50
	public static readonly string UriSchemeNetPipe; //Field offset: 0x58
	public static readonly string SchemeDelimiter; //Field offset: 0x60
	private static bool s_ConfigInitialized; //Field offset: 0x68
	private static bool s_ConfigInitializing; //Field offset: 0x69
	private static UriIdnScope s_IdnScope; //Field offset: 0x6C
	private static bool s_IriParsing; //Field offset: 0x70
	private static bool useDotNetRelativeOrAbsolute; //Field offset: 0x71
	internal static readonly bool IsWindowsFileSystem; //Field offset: 0x72
	private static object s_initLock; //Field offset: 0x78
	internal static readonly Char[] HexLowerChars; //Field offset: 0x80
	private static readonly Char[] _WSchars; //Field offset: 0x88
	private string m_String; //Field offset: 0x10
	private string m_originalUnicodeString; //Field offset: 0x18
	private UriParser m_Syntax; //Field offset: 0x20
	private string m_DnsSafeHost; //Field offset: 0x28
	private Flags m_Flags; //Field offset: 0x30
	private UriInfo m_Info; //Field offset: 0x38
	private bool m_iriParsing; //Field offset: 0x40

	public string AbsolutePath
	{
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool), typeof(int), typeof(CookieCollection), typeof(System.Collections.Generic.List`1<System.String>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 193
	}

	public string AbsoluteUri
	{
		[CalledBy(Type = "System.Xml.Schema.XsdValidator", Member = "ProcessInlineSchema", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
		[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 326
	}

	private bool AllowIdn
	{
		[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimalIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 229
	}

	public string Authority
	{
		[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 139
	}

	public string DnsSafeHost
	{
		[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 776
	}

	public string Fragment
	{
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 326
	}

	internal bool HasAuthority
	{
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 13
	}

	public string Host
	{
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 139
	}

	public UriHostNameType HostNameType
	{
		[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 334
	}

	private Flags HostType
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 9
	}

	private static object InitializeLock
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 234
	}

	public bool IsAbsoluteUri
	{
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public bool IsDefaultPort
	{
		[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 249
	}

	private bool IsDosPath
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 13
	}

	public bool IsFile
	{
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 197
	}

	private bool IsImplicitFile
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 13
	}

	public bool IsLoopback
	{
		[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 186
	}

	private bool IsNotAbsoluteUri
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 9
	}

	public bool IsUnc
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 133
	}

	private bool IsUncOrDosPath
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 13
	}

	private bool IsUncPath
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 13
	}

	public string LocalPath
	{
		[CalledBy(Type = "System.Xml.XmlDownloadManager+<>c__DisplayClass4_0", Member = "<GetStreamAsync>b__0", ReturnType = typeof(Stream))]
		[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(XmlUrlResolver), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileWebRequest), typeof(Uri), typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 127
	}

	public string OriginalString
	{
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		 get { } //Length: 94
	}

	private bool OriginalStringSwitched
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 95
	}

	public string PathAndQuery
	{
		[CalledBy(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 205
	}

	public int Port
	{
		[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(CookieCollection))]
		[CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 265
	}

	private string PrivateAbsolutePath
	{
		[CalledBy(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "get_Segments", ReturnType = typeof(String[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 224
	}

	public string Query
	{
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 326
	}

	public string Scheme
	{
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 129
	}

	private ushort SecuredPathIndex
	{
		[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 84
	}

	public String[] Segments
	{
		[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 477
	}

	private UriParser Syntax
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	internal bool UserDrivenParsing
	{
		[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 13
	}

	public bool UserEscaped
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 13
	}

	public string UserInfo
	{
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 139
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	private static Uri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public Uri(Uri baseUri, string relativeUri) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlValidatingReaderImpl", Member = "SetupValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "System.Xml.Schema.Parser", Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Uri(string uriString, UriKind uriKind) { }

	[CallerCount(Count = 49)]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Uri(string uriString) { }

	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public Uri(Uri baseUri, Uri relativeUri) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Uri(Flags flags, UriParser uriParser, string uri) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IsValidByIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Int32&), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser), typeof(Flags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Int32&), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UncNameHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	private ushort CheckAuthorityHelper(Char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser), typeof(Flags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser), typeof(Flags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Check CheckCanonical(Char* str, ref ushort idx, ushort end, char delim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckForConfigLoad(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckForEscapedUnreserved(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckForUnicode(string data) { }

	[CalledBy(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool CheckKnownSchemes(Int64* lptr, ushort nChars, ref UriParser syntax) { }

	[CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "FindOrFetchAsUnknownV1Syntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UriParser))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static ParsingError CheckSchemeSyntax(Char* ptr, ushort length, ref UriParser syntax) { }

	[CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(ParsingError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Char[] Compress(Char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(Check))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void CreateHostString() { }

	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UncNameHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[CallsUnknownMethods(Count = 5)]
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId) { }

	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	private void CreateThisFromUri(Uri otherUri) { }

	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[CalledBy(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "EnsureUriInfo", ReturnType = typeof(UriInfo))]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void CreateUriInfo(Flags cF) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void EnsureHostString(bool allowDnsOptimization) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void EnsureParseRemaining() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private UriInfo EnsureUriInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object comparand) { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnClickStatistics>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string EscapeDataString(string stringToEscape) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	private void FindEndOfComponent(Char* str, ref ushort idx, ushort end, char delim) { }

	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int FromHex(char digit) { }

	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool), typeof(int), typeof(CookieCollection), typeof(System.Collections.Generic.List`1<System.String>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string get_AbsolutePath() { }

	[CalledBy(Type = "System.Xml.Schema.XsdValidator", Member = "ProcessInlineSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public string get_AbsoluteUri() { }

	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimalIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	private bool get_AllowIdn() { }

	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_Authority() { }

	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public string get_DnsSafeHost() { }

	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public string get_Fragment() { }

	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasAuthority() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_Host() { }

	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public UriHostNameType get_HostNameType() { }

	[CallerCount(Count = 0)]
	private Flags get_HostType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object get_InitializeLock() { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsAbsoluteUri() { }

	[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool get_IsDefaultPort() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_IsDosPath() { }

	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool get_IsFile() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_IsImplicitFile() { }

	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool get_IsLoopback() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_IsNotAbsoluteUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool get_IsUnc() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_IsUncOrDosPath() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_IsUncPath() { }

	[CalledBy(Type = "System.Xml.XmlDownloadManager+<>c__DisplayClass4_0", Member = "<GetStreamAsync>b__0", ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(XmlUrlResolver), Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileWebRequest), typeof(Uri), typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_LocalPath() { }

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	public string get_OriginalString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool get_OriginalStringSwitched() { }

	[CalledBy(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string get_PathAndQuery() { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
	[CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(CookieCollection))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public int get_Port() { }

	[CalledBy(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Segments", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private string get_PrivateAbsolutePath() { }

	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public string get_Query() { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_Scheme() { }

	[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private ushort get_SecuredPathIndex() { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public String[] get_Segments() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	private UriParser get_Syntax() { }

	[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_UserDrivenParsing() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_UserEscaped() { }

	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string get_UserInfo() { }

	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Uri), Member = "UnescapeOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Char[] GetCanonicalPath(Char[] dest, ref int pos, UriFormat formatAs) { }

	[CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InternalGetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetRelativeSerializationString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public string GetComponents(UriComponents components, UriFormat format) { }

	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetEscapedParts(UriComponents uriParts) { }

	[CalledBy(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static UriFormatException GetException(ParsingError err) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CalculateCaseInsensitiveHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriParser), Member = "InternalGetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	private void GetHostViaCustomSyntax() { }

	[CalledBy(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private string GetLocalPath() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private string GetRelativeSerializationString(UriFormat format) { }

	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool InFact(Flags flags) { }

	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(UriParser), Member = "InternalValidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "InternalOnNewUri", ReturnType = typeof(UriParser))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void InitializeUriConfig() { }

	[CalledBy(Type = typeof(UriBuilder), Member = "set_Path", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	internal static string InternalEscapeString(string rawString) { }

	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriParser), Member = "IsWellFormedOriginalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(Check))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	internal bool InternalIsWellFormedOriginalString() { }

	[CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IriParsingStatic(UriParser syntax) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsAsciiLetter(char character) { }

	[CalledBy(Type = typeof(UriHelper), Member = "IsUnreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsAsciiLetterOrDigit(char character) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InternalIsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public bool IsBaseOf(Uri uri) { }

	[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriParser), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "TestForSubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Char*), typeof(ushort), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsBaseOfHelper(Uri uriLink) { }

	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsBidiControlCharacter(char ch) { }

	[CalledBy(Type = typeof(IriHelper), Member = "CheckIsReserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UriComponents)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsGenDelim(char ch) { }

	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool IsHexDigit(char character) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private bool IsIntranet(string schemeHost) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsLWS(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsWellFormedOriginalString() { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextEventHandler", Member = "HyperlinkOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool NotAny(Flags flags) { }

	[CallerCount(Count = 45)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	[CalledBy(Type = typeof(UriParser), Member = "InitializeAndValidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	internal UriFormatException ParseMinimal() { }

	[CalledBy(Type = typeof(Uri), Member = "EnsureParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(Check))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	private void ParseRemaining() { }

	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[CallsUnknownMethods(Count = 1)]
	private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) { }

	[CalledBy(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "CheckKnownSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static ushort ParseSchemeCheckImplicitFile(Char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax) { }

	[CalledBy(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriParser), Member = "IsAllSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private ParsingError PrivateParseMinimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(ParsingError))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void SetUserDrivenParsing() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool StaticIsFile(UriParser syntax) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	[CalledBy(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingCookedPath", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = "System.Net.HttpListenerRequestUriBuilder+ParsingResult")]
	[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaBuilder", Member = "UnescapeReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string UnescapeDataString(string stringToUnescape) { }

	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	private static void UnescapeOnly(Char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

}

