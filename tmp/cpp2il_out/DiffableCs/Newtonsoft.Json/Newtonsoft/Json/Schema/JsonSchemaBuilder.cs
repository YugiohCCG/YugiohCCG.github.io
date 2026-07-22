namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaBuilder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public JsonSchemaType type; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass23_0() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <MapType>b__0(KeyValuePair<String, JsonSchemaType> kv) { }

	}

	private readonly IList<JsonSchema> _stack; //Field offset: 0x10
	private readonly JsonSchemaResolver _resolver; //Field offset: 0x18
	private readonly IDictionary<String, JsonSchema> _documentSchemas; //Field offset: 0x20
	private JsonSchema _currentSchema; //Field offset: 0x28
	private JObject _rootSchema; //Field offset: 0x30

	private JsonSchema CurrentSchema
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public JsonSchemaBuilder(JsonSchemaResolver resolver) { }

	[CalledBy(Type = typeof(JsonSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSchemaResolver)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessExtends", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessAdditionalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessAdditionalItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(JsonException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(JsonException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSchema), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private JsonSchema BuildSchema(JToken token) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	private JsonSchema get_CurrentSchema() { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Nullable`1<Newtonsoft.Json.Schema.JsonSchemaType>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal static JsonSchemaType MapType(string type) { }

	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonWriter), typeof(JsonSchemaType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Single", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static string MapType(JsonSchemaType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsUnknownMethods(Count = 4)]
	private JsonSchema Pop() { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessAdditionalItems(JToken token) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessAdditionalProperties(JToken token) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(JsonException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	private void ProcessEnum(JToken token) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private void ProcessExtends(JToken token) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(JsonException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	private void ProcessItems(JToken token) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JProperty), Member = "get_Value", ReturnType = typeof(JToken))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(JsonException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	private IDictionary<String, JsonSchema> ProcessProperties(JToken token) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessAdditionalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessAdditionalItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Nullable`1<Newtonsoft.Json.Schema.JsonSchemaType>))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessExtends", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ProcessProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JObject), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>))]
	[CallsDeduplicatedMethods(Count = 41)]
	[CallsUnknownMethods(Count = 42)]
	private void ProcessSchemaProperties(JObject schemaObject) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessSchemaProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "MapType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonSchemaType))]
	[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(JsonException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 28)]
	private Nullable<JsonSchemaType> ProcessType(JToken token) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private void Push(JsonSchema value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchema))]
	[CallsUnknownMethods(Count = 1)]
	internal JsonSchema Read(JsonReader reader) { }

	[CalledBy(Type = typeof(JsonSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSchemaResolver)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "UnescapeReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 23)]
	private JsonSchema ResolveReferences(JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "UnescapeDataString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string UnescapeReference(string reference) { }

}

