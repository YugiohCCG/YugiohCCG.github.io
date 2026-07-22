namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaGenerator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Type type; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass23_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GenerateInternal>b__0(TypeSchema tc) { }

	}

	private class TypeSchema
	{
		[CompilerGenerated]
		private readonly Type <Type>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly JsonSchema <Schema>k__BackingField; //Field offset: 0x18

		public JsonSchema Schema
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public Type Type
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public TypeSchema(Type type, JsonSchema schema) { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public JsonSchema get_Schema() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Type get_Type() { }

	}

	[CompilerGenerated]
	private UndefinedSchemaIdHandling <UndefinedSchemaIdHandling>k__BackingField; //Field offset: 0x10
	private IContractResolver _contractResolver; //Field offset: 0x18
	private JsonSchemaResolver _resolver; //Field offset: 0x20
	private readonly IList<TypeSchema> _stack; //Field offset: 0x28
	private JsonSchema _currentSchema; //Field offset: 0x30

	public IContractResolver ContractResolver
	{
		[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Required), typeof(bool)}, ReturnType = typeof(JsonSchema))]
		[CallerCount(Count = 1)]
		 get { } //Length: 147
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	private JsonSchema CurrentSchema
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public JsonSchemaGenerator() { }

	[CallerCount(Count = 0)]
	private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaResolver), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSchemaResolver), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	public JsonSchema Generate(Type type, bool rootSchemaNullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSchemaResolver), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaResolver), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSchemaResolver), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	public JsonSchema Generate(Type type) { }

	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSchemaResolver)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "GenerateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Required), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CallsUnknownMethods(Count = 1)]
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable) { }

	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "Generate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSchemaResolver), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonObjectContract)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "get_ContractResolver", ReturnType = typeof(IContractResolver))]
	[Calls(Type = typeof(JsonSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void GenerateISerializableContract(Type type, JsonISerializableContract contract) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(JsonProperty), Member = "get_Required", ReturnType = typeof(Required))]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "GenerateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Required), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[Calls(Type = typeof(JsonProperty), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(JToken), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(TypeExtensions), Member = "IsSealed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private void GenerateObjectSchema(Type type, JsonObjectContract contract) { }

	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Required), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 1)]
	public IContractResolver get_ContractResolver() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	private JsonSchema get_CurrentSchema() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetDescription(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private string GetTitle(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetTypeId(Type type, bool explicitOnly) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool HasFlag(Nullable<JsonSchemaType> value, JsonSchemaType flag) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private TypeSchema Pop() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Push(TypeSchema typeSchema) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ContractResolver(IContractResolver value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_UndefinedSchemaIdHandling(UndefinedSchemaIdHandling value) { }

}

