namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class BooleanQueryExpression : QueryExpression
{
	public readonly object Left; //Field offset: 0x18
	[Nullable(2)]
	public readonly object Right; //Field offset: 0x20

	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public BooleanQueryExpression(QueryOperator operator, object left, object right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringWriter))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), typeof(DateFormatHandling), typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTime), typeof(DateFormatHandling), typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue) { }

	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(JsonSelectSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JPath), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Linq.JsonPath.PathFilter>), typeof(JToken), typeof(JToken), typeof(JsonSelectSettings)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CallsUnknownMethods(Count = 9)]
	private IEnumerable<JToken> GetResult(JToken root, JToken t, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BooleanQueryExpression), Member = "GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(object)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(BooleanQueryExpression), Member = "MatchTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(JsonSelectSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken), typeof(JsonSelectSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetRegexOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RegexOptions))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings) { }

}

