namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaResolver
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string reference; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass5_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetSchema>b__0(JsonSchema s) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetSchema>b__1(JsonSchema s) { }

	}

	[CompilerGenerated]
	private IList<JsonSchema> <LoadedSchemas>k__BackingField; //Field offset: 0x10

	public IList<JsonSchema> LoadedSchemas
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(JsonSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchema), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchema), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchema), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public JsonSchemaResolver() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IList<JsonSchema> get_LoadedSchemas() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override JsonSchema GetSchema(string reference) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_LoadedSchemas(IList<JsonSchema> value) { }

}

