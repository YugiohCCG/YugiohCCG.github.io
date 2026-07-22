namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JsonSchema, String> <>9__26_0; //Field offset: 0x8
		public static Func<String, String> <>9__26_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string <GetId>b__26_0(JsonSchema s) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal string <GetId>b__26_1(string id) { }

	}

	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<JsonSchema> <Schemas>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Dictionary<String, JsonSchemaNode> <Properties>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Dictionary<String, JsonSchemaNode> <PatternProperties>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly List<JsonSchemaNode> <Items>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalProperties>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalItems>k__BackingField; //Field offset: 0x40

	public JsonSchemaNode AdditionalItems
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public JsonSchemaNode AdditionalProperties
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string Id
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public List<JsonSchemaNode> Items
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Dictionary<String, JsonSchemaNode> PatternProperties
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Dictionary<String, JsonSchemaNode> Properties
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ReadOnlyCollection<JsonSchema> Schemas
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaNode), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Schema.JsonSchema>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public JsonSchemaNode(JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CalledBy(Type = typeof(JsonSchemaNode), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Union", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaNode), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Schema.JsonSchema>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(void))]
	public JsonSchemaNode Combine(JsonSchema schema) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonSchemaNode get_AdditionalItems() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonSchemaNode get_AdditionalProperties() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Id() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public List<JsonSchemaNode> get_Items() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Dictionary<String, JsonSchemaNode> get_PatternProperties() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Dictionary<String, JsonSchemaNode> get_Properties() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ReadOnlyCollection<JsonSchema> get_Schemas() { }

	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CalledBy(Type = typeof(JsonSchemaNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetId(IEnumerable<JsonSchema> schemata) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AdditionalItems(JsonSchemaNode value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AdditionalProperties(JsonSchemaNode value) { }

}

