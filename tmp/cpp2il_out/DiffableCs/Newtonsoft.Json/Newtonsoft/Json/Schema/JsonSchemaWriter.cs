namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaWriter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JsonSchemaType, Boolean> <>9__7_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <WriteType>b__7_0(JsonSchemaType v) { }

	}

	private readonly JsonWriter _writer; //Field offset: 0x10
	private readonly JsonSchemaResolver _resolver; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver) { }

	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteSchemaDictionaryIfNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void ReferenceOrWriteSchema(JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "ReferenceOrWriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void WriteItems(JsonSchema schema) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value) { }

	[CalledBy(Type = typeof(JsonSchema), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchema), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonSchemaResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchema), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "ReferenceOrWriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonWriter), typeof(JsonSchemaType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "ReferenceOrWriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteSchemaDictionaryIfNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 56)]
	[CallsUnknownMethods(Count = 29)]
	public void WriteSchema(JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "ReferenceOrWriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<String, JsonSchema> properties) { }

	[CalledBy(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EnumUtils), Member = "GetFlagsValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.IList`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "MapType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaType)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type) { }

}

