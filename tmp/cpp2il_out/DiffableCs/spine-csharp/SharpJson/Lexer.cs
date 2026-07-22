namespace SharpJson;

internal class Lexer
{
	internal enum Token
	{
		None = 0,
		Null = 1,
		True = 2,
		False = 3,
		Colon = 4,
		Comma = 5,
		String = 6,
		Number = 7,
		CurlyOpen = 8,
		CurlyClose = 9,
		SquaredOpen = 10,
		SquaredClose = 11,
	}

	[CompilerGenerated]
	private int <lineNumber>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <parseNumbersAsFloat>k__BackingField; //Field offset: 0x14
	private Char[] json; //Field offset: 0x18
	private int index; //Field offset: 0x20
	private bool success; //Field offset: 0x24
	private Char[] stringBuffer; //Field offset: 0x28

	public bool hasError
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public private int lineNumber
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool parseNumbersAsFloat
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Lexer(string text) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_hasError() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_lineNumber() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_parseNumbersAsFloat() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int GetLastIndexOfNumber(int index) { }

	[CalledBy(Type = typeof(Lexer), Member = "ParseFloatNumber", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Lexer), Member = "ParseDoubleNumber", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private string GetNumberString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "NextToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(Token))]
	public Token LookAhead() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "NextToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(Token))]
	public Token NextToken() { }

	[CalledBy(Type = typeof(Lexer), Member = "LookAhead", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(Lexer), Member = "NextToken", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseObject", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseArray", ReturnType = typeof(System.Collections.Generic.IList`1<System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 3)]
	private static Token NextToken(Char[] json, ref int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "GetNumberString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	public double ParseDoubleNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "GetNumberString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	public float ParseFloatNumber() { }

	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseObject", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string ParseString() { }

	[CallerCount(Count = 0)]
	public void Reset() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lineNumber(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_parseNumbersAsFloat(bool value) { }

	[CalledBy(Type = typeof(Lexer), Member = "ParseString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Lexer), Member = "GetNumberString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Lexer), Member = "LookAhead", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(Lexer), Member = "NextToken", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseObject", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseArray", ReturnType = typeof(System.Collections.Generic.IList`1<System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void SkipWhiteSpaces() { }

}

