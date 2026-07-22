namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonObjectContract : JsonContainerContract
{
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	[Nullable(1)]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func<String, String> <ExtensionDataNameResolver>k__BackingField; //Field offset: 0xF8
	internal bool ExtensionDataIsJToken; //Field offset: 0x100
	private Nullable<Boolean> _hasRequiredOrDefaultValueProperties; //Field offset: 0x101
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x108
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x110
	private JsonPropertyCollection _creatorParameters; //Field offset: 0x118
	private Type _extensionDataValueType; //Field offset: 0x120

	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters
	{
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonProperty), typeof(string), typeof(Boolean&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HasCreatorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(ISerializable), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(1)]
		 get { } //Length: 135
	}

	public ExtensionDataGetter ExtensionDataGetter
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

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func<String, String> ExtensionDataNameResolver
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

	public ExtensionDataSetter ExtensionDataSetter
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

	public Type ExtensionDataValueType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 214
	}

	internal bool HasRequiredOrDefaultValueProperties
	{
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Nullable`1), Member = "GetValueOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 735
	}

	public Nullable<NullValueHandling> ItemNullValueHandling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Required> ItemRequired
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MemberSerialization MemberSerialization
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public Nullable<MissingMemberHandling> MissingMemberHandling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor<Object> OverrideCreator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[Nullable(1)]
	public JsonPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public JsonObjectContract(Type underlyingType) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonProperty), typeof(string), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HasCreatorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(ISerializable), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public JsonPropertyCollection get_CreatorParameters() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<String, String> get_ExtensionDataNameResolver() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Type get_ExtensionDataValueType() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Nullable`1), Member = "GetValueOrDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Required> get_ItemRequired() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MemberSerialization get_MemberSerialization() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ObjectConstructor<Object> get_OverrideCreator() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public JsonPropertyCollection get_Properties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_FullyTrusted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[NullableContext(1)]
	internal object GetUninitializedObject() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ExtensionDataNameResolver(Func<String, String> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_ExtensionDataValueType(Type value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ItemRequired(Nullable<Required> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_MemberSerialization(MemberSerialization value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ParameterizedCreator(ObjectConstructor<Object> value) { }

}

