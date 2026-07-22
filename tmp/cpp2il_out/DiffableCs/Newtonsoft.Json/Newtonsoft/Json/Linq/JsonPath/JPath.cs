namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class JPath
{
	private static readonly Char[] FloatCharacters; //Field offset: 0x0
	private readonly string _expression; //Field offset: 0x10
	[CompilerGenerated]
	private readonly List<PathFilter> <Filters>k__BackingField; //Field offset: 0x18
	private int _currentIndex; //Field offset: 0x20

	public List<PathFilter> Filters
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static JPath() { }

	[CalledBy(Type = typeof(JToken), Member = "SelectToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSelectSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "SelectTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(JToken), Member = "SelectTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSelectSettings)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JPath), Member = "ParseMain", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public JPath(string expression) { }

	[CalledBy(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static PathFilter CreatePathFilter(string member, bool scan) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseSide", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private JsonException CreateUnexpectedCharacterException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private void EatWhitespace() { }

	[CalledBy(Type = typeof(JPath), Member = "ParseArrayIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(PathFilter))]
	[CalledBy(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void EnsureLength(string message) { }

	[CalledBy(Type = typeof(JToken), Member = "SelectToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSelectSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "SelectTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(JToken), Member = "SelectTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSelectSettings)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JPath), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(JToken), typeof(JToken), typeof(JsonSelectSettings)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings) { }

	[CalledBy(Type = typeof(JPath), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(JsonSelectSettings)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(object)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public List<PathFilter> get_Filters() { }

	[CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
	[CalledBy(Type = typeof(JPath), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private bool Match(string s) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 36)]
	private PathFilter ParseArrayIndexer(char indexerCloseChar) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JPath), Member = "ParseSide", ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "ParseOperator", ReturnType = typeof(QueryOperator))]
	[Calls(Type = typeof(JPath), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CompositeExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryOperator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JPath), Member = "CreateUnexpectedCharacterException", ReturnType = typeof(JsonException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private QueryExpression ParseExpression() { }

	[CalledBy(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "ParseArrayIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(PathFilter))]
	[Calls(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[Calls(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private PathFilter ParseIndexer(char indexerOpenChar, bool scan) { }

	[CalledBy(Type = typeof(JPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void ParseMain() { }

	[CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private QueryOperator ParseOperator() { }

	[CalledBy(Type = typeof(JPath), Member = "ParseMain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JPath), Member = "TryParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<PathFilter>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JPath), Member = "ParseSide", ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JPath), Member = "CreatePathFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[Calls(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
	[Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	private PathFilter ParseQuery(char indexerCloseChar, bool scan) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JPath), Member = "ReadQuotedString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "CreatePathFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JPath), Member = "CreateUnexpectedCharacterException", ReturnType = typeof(JsonException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private object ParseSide() { }

	[CalledBy(Type = typeof(JPath), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(PathFilter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private string ReadQuotedString() { }

	[CalledBy(Type = typeof(JPath), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private string ReadRegexString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private bool TryParseExpression(out List<PathFilter>& expressionPath) { }

	[CalledBy(Type = typeof(JPath), Member = "ParseSide", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JPath), Member = "ReadRegexString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JPath), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JPath), Member = "ReadQuotedString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[NullableContext(2)]
	private bool TryParseValue(out object value) { }

}

