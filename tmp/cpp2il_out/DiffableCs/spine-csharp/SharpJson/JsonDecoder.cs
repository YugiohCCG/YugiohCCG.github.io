namespace SharpJson;

public class JsonDecoder
{
	[CompilerGenerated]
	private string <errorMessage>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <parseNumbersAsFloat>k__BackingField; //Field offset: 0x18
	private Lexer lexer; //Field offset: 0x20

	public private string errorMessage
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
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

	[CalledBy(Type = typeof(Json), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JsonDecoder() { }

	[CalledBy(Type = typeof(Json), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public object Decode(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static object DecodeText(string text) { }

	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonDecoder), Member = "TriggerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private T EvalLexer(T value) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_errorMessage() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_parseNumbersAsFloat() { }

	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "NextToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonDecoder), Member = "TriggerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private IList<Object> ParseArray() { }

	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(Lexer), Member = "NextToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "ParseString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonDecoder), Member = "EvalLexer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonDecoder), Member = "TriggerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private IDictionary<String, Object> ParseObject() { }

	[CalledBy(Type = typeof(JsonDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "DecodeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseObject", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseArray", ReturnType = typeof(System.Collections.Generic.IList`1<System.Object>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonDecoder), Member = "ParseArray", ReturnType = typeof(System.Collections.Generic.IList`1<System.Object>))]
	[Calls(Type = typeof(JsonDecoder), Member = "ParseObject", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.Object>))]
	[Calls(Type = typeof(JsonDecoder), Member = "EvalLexer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonDecoder), Member = "EvalLexer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Lexer), Member = "GetNumberString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonDecoder), Member = "TriggerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonDecoder), Member = "EvalLexer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Lexer), Member = "ParseString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Lexer), Member = "NextToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(Lexer), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseValue() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_errorMessage(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_parseNumbersAsFloat(bool value) { }

	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseObject", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseArray", ReturnType = typeof(System.Collections.Generic.IList`1<System.Object>))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "ParseValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonDecoder), Member = "EvalLexer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private void TriggerError(string message) { }

}

