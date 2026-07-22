namespace System.Net;

internal class CookieTokenizer
{
	private struct RecognizedAttribute
	{
		private string m_name; //Field offset: 0x0
		private CookieToken m_token; //Field offset: 0x8

		internal CookieToken Token
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		[CallerCount(Count = 19)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal RecognizedAttribute(string name, CookieToken token) { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		internal CookieToken get_Token() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		internal bool IsEqualTo(string value) { }

	}

	private static RecognizedAttribute[] RecognizedAttributes; //Field offset: 0x0
	private static RecognizedAttribute[] RecognizedServerAttributes; //Field offset: 0x8
	private bool m_eofCookie; //Field offset: 0x10
	private int m_index; //Field offset: 0x14
	private int m_length; //Field offset: 0x18
	private string m_name; //Field offset: 0x20
	private bool m_quoted; //Field offset: 0x28
	private int m_start; //Field offset: 0x2C
	private CookieToken m_token; //Field offset: 0x30
	private int m_tokenLength; //Field offset: 0x34
	private string m_tokenStream; //Field offset: 0x38
	private string m_value; //Field offset: 0x40

	internal bool EndOfCookie
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 370
	}

	internal bool Eof
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 10
	}

	internal string Name
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool Quoted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal CookieToken Token
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal string Value
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 36)]
	private static CookieTokenizer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal CookieTokenizer(string tokenStream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string Extract() { }

	[CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_EndOfCookie() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_Eof() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_Quoted() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal CookieToken get_Token() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_Value() { }

	[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookieTokenizer), Member = "FindNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CookieTokenizer), Member = "TokenFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(CookieToken))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void Reset() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void set_EndOfCookie(bool value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Quoted(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Token(CookieToken value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Value(string value) { }

	[CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

}

