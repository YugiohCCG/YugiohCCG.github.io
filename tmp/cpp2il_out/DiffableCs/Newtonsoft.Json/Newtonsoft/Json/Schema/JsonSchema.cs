namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchema
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<Boolean> <Required>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Nullable<Boolean> <ReadOnly>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	private Nullable<Boolean> <Hidden>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Nullable<Boolean> <Transient>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable<JsonSchemaType> <Type>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Pattern>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable<Int32> <MinimumLength>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable<Int32> <MaximumLength>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Nullable<Double> <DivisibleBy>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Nullable<Double> <Minimum>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Nullable<Double> <Maximum>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Nullable<Boolean> <ExclusiveMinimum>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Nullable<Boolean> <ExclusiveMaximum>k__BackingField; //Field offset: 0x82
	[CompilerGenerated]
	private Nullable<Int32> <MinimumItems>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private Nullable<Int32> <MaximumItems>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private IList<JsonSchema> <Items>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private bool <PositionalItemsValidation>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private JsonSchema <AdditionalItems>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <AllowAdditionalItems>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <UniqueItems>k__BackingField; //Field offset: 0xB1
	[CompilerGenerated]
	private IDictionary<String, JsonSchema> <Properties>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private JsonSchema <AdditionalProperties>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private IDictionary<String, JsonSchema> <PatternProperties>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <AllowAdditionalProperties>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private string <Requires>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private IList<JToken> <Enum>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private Nullable<JsonSchemaType> <Disallow>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private JToken <Default>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private IList<JsonSchema> <Extends>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private string <Format>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private string <Location>k__BackingField; //Field offset: 0x108
	private readonly string _internalId; //Field offset: 0x110
	[CompilerGenerated]
	private string <DeferredReference>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private bool <ReferencesResolved>k__BackingField; //Field offset: 0x120

	public JsonSchema AdditionalItems
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public JsonSchema AdditionalProperties
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public bool AllowAdditionalItems
	{
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool AllowAdditionalProperties
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public JToken Default
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal string DeferredReference
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public string Description
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Nullable<JsonSchemaType> Disallow
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Nullable<Double> DivisibleBy
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IList<JToken> Enum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public Nullable<Boolean> ExclusiveMaximum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Boolean> ExclusiveMinimum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IList<JsonSchema> Extends
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public string Format
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public Nullable<Boolean> Hidden
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public string Id
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

	internal string InternalId
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public IList<JsonSchema> Items
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal string Location
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public Nullable<Double> Maximum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Nullable<Int32> MaximumItems
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Int32> MaximumLength
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public Nullable<Double> Minimum
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Nullable<Int32> MinimumItems
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Int32> MinimumLength
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public string Pattern
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

	public IDictionary<String, JsonSchema> PatternProperties
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public bool PositionalItemsValidation
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public IDictionary<String, JsonSchema> Properties
	{
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public Nullable<Boolean> ReadOnly
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	internal bool ReferencesResolved
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public Nullable<Boolean> Required
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public string Requires
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public string Title
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Nullable<Boolean> Transient
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Nullable<JsonSchemaType> Type
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public bool UniqueItems
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Required), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JsonSchema() { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonSchema get_AdditionalItems() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonSchema get_AdditionalProperties() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_AllowAdditionalItems() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_AllowAdditionalProperties() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JToken get_Default() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal string get_DeferredReference() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Description() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<JsonSchemaType> get_Disallow() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Double> get_DivisibleBy() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IList<JToken> get_Enum() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Boolean> get_ExclusiveMaximum() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Boolean> get_ExclusiveMinimum() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IList<JsonSchema> get_Extends() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Format() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Boolean> get_Hidden() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Id() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal string get_InternalId() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IList<JsonSchema> get_Items() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal string get_Location() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Double> get_Maximum() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Int32> get_MaximumItems() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Int32> get_MaximumLength() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Double> get_Minimum() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Int32> get_MinimumItems() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Int32> get_MinimumLength() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Pattern() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IDictionary<String, JsonSchema> get_PatternProperties() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_PositionalItemsValidation() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IDictionary<String, JsonSchema> get_Properties() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Boolean> get_ReadOnly() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_ReferencesResolved() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Boolean> get_Required() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Requires() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Title() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Boolean> get_Transient() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<JsonSchemaType> get_Type() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_UniqueItems() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSchemaResolver)}, ReturnType = typeof(JsonSchema))]
	[CallsUnknownMethods(Count = 3)]
	public static JsonSchema Parse(string json, JsonSchemaResolver resolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaResolver), Member = ".ctor", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public static JsonSchema Parse(string json) { }

	[CalledBy(Type = typeof(JsonSchema), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaResolver)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(JsonSchemaBuilder), Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchema))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaResolver), Member = ".ctor", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public static JsonSchema Read(JsonReader reader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AdditionalItems(JsonSchema value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AdditionalProperties(JsonSchema value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AllowAdditionalItems(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_AllowAdditionalProperties(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Default(JToken value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_DeferredReference(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Description(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Disallow(Nullable<JsonSchemaType> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_DivisibleBy(Nullable<Double> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Enum(IList<JToken> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ExclusiveMaximum(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ExclusiveMinimum(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Extends(IList<JsonSchema> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Format(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Hidden(Nullable<Boolean> value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Id(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Items(IList<JsonSchema> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_Location(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Maximum(Nullable<Double> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_MaximumItems(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_MaximumLength(Nullable<Int32> value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Minimum(Nullable<Double> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_MinimumItems(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_MinimumLength(Nullable<Int32> value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Pattern(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PatternProperties(IDictionary<String, JsonSchema> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PositionalItemsValidation(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Properties(IDictionary<String, JsonSchema> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ReadOnly(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_ReferencesResolved(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Required(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Requires(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Title(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_Transient(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Type(Nullable<JsonSchemaType> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_UniqueItems(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaResolver), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaResolver), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaWriter), Member = "WriteSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void WriteTo(JsonWriter writer) { }

}

