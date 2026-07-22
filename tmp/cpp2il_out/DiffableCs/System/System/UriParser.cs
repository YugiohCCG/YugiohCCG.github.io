namespace System;

public abstract class UriParser
{
	private class BuiltInUriParser : UriParser
	{

		[CalledBy(Type = typeof(UriParser), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriParser), Member = "FindOrFetchAsUnknownV1Syntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UriParser))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(UriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

	}

	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3,
	}

	private static readonly Dictionary<String, UriParser> m_Table; //Field offset: 0x0
	private static Dictionary<String, UriParser> m_TempTable; //Field offset: 0x8
	internal static UriParser HttpUri; //Field offset: 0x10
	internal static UriParser HttpsUri; //Field offset: 0x18
	internal static UriParser WsUri; //Field offset: 0x20
	internal static UriParser WssUri; //Field offset: 0x28
	internal static UriParser FtpUri; //Field offset: 0x30
	internal static UriParser FileUri; //Field offset: 0x38
	internal static UriParser GopherUri; //Field offset: 0x40
	internal static UriParser NntpUri; //Field offset: 0x48
	internal static UriParser NewsUri; //Field offset: 0x50
	internal static UriParser MailToUri; //Field offset: 0x58
	internal static UriParser UuidUri; //Field offset: 0x60
	internal static UriParser TelnetUri; //Field offset: 0x68
	internal static UriParser LdapUri; //Field offset: 0x70
	internal static UriParser NetTcpUri; //Field offset: 0x78
	internal static UriParser NetPipeUri; //Field offset: 0x80
	internal static UriParser VsMacrosUri; //Field offset: 0x88
	private static readonly UriQuirksVersion s_QuirksVersion; //Field offset: 0x90
	private static readonly UriSyntaxFlags HttpSyntaxFlags; //Field offset: 0x94
	private static readonly UriSyntaxFlags FileSyntaxFlags; //Field offset: 0x98
	private UriSyntaxFlags m_Flags; //Field offset: 0x10
	private UriSyntaxFlags m_UpdatableFlags; //Field offset: 0x14
	private bool m_UpdatableFlagsUsed; //Field offset: 0x18
	private int m_Port; //Field offset: 0x1C
	private string m_Scheme; //Field offset: 0x20

	internal int DefaultPort
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal UriSyntaxFlags Flags
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool IsSimple
	{
		[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
		[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 13
	}

	internal string SchemeName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal static bool ShouldUseLegacyV2Quirks
	{
		[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
		[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
		[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 85
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuiltInUriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private static UriParser() { }

	[CalledBy(Type = typeof(BuiltInUriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal UriParser(UriSyntaxFlags flags) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuiltInUriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_DefaultPort() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	internal UriSyntaxFlags get_Flags() { }

	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsSimple() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_SchemeName() { }

	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_UserDrivenParsing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	protected override string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	[CalledBy(Type = typeof(Uri), Member = "IriParsingStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "StaticIsFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = "System.Uri+Check")]
	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 54)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool InFact(UriSyntaxFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
	[CallsUnknownMethods(Count = 2)]
	protected override void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal UriParser InternalOnNewUri() { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected override bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected override bool IsWellFormedOriginalString(Uri uri) { }

	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool NotAny(UriSyntaxFlags flags) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	protected override UriParser OnNewUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_UserDrivenParsing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	protected override string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

}

