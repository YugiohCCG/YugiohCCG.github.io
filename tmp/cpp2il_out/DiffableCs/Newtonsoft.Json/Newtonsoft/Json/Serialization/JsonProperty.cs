namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonProperty
{
	internal Nullable<Required> _required; //Field offset: 0x10
	internal bool _hasExplicitDefaultValue; //Field offset: 0x18
	private object _defaultValue; //Field offset: 0x20
	private bool _hasGeneratedDefaultValue; //Field offset: 0x28
	private string _propertyName; //Field offset: 0x30
	internal bool _skipPropertyNameEscape; //Field offset: 0x38
	private Type _propertyType; //Field offset: 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Nullable<Int32> <Order>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; //Field offset: 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; //Field offset: 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; //Field offset: 0x83
	[CompilerGenerated]
	private Nullable<Boolean> <IsReference>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Predicate<Object> <ShouldSerialize>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Predicate<Object> <ShouldDeserialize>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Predicate<Object> <GetIsSpecified>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	private Action<Object, Object> <SetIsSpecified>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Nullable<Boolean> <ItemIsReference>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; //Field offset: 0xE4

	public IAttributeProvider AttributeProvider
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public JsonConverter Converter
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Type DeclaringType
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public object DefaultValue
	{
		[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonObjectContract)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 17
	}

	public Nullable<DefaultValueHandling> DefaultValueHandling
	{
		[CallerCount(Count = 57)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Predicate<Object> GetIsSpecified
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

	public bool HasMemberAttribute
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool Ignored
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

	public Nullable<Boolean> IsReference
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool IsRequiredSpecified
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 57
	}

	public JsonConverter ItemConverter
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

	public Nullable<Boolean> ItemIsReference
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<TypeNameHandling> ItemTypeNameHandling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Obsolete("MemberConverter is obsolete. Use Converter instead.")]
	public JsonConverter MemberConverter
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Nullable<NullValueHandling> NullValueHandling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<ObjectCreationHandling> ObjectCreationHandling
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Nullable<Int32> Order
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	internal JsonContract PropertyContract
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public string PropertyName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(ParameterInfo)}, ReturnType = typeof(JsonProperty))]
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberSerialization)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(JavaScriptUtils), Member = "ShouldEscapeJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean[])}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 133
	}

	public Type PropertyType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 100
	}

	public bool Readable
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

	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Required Required
	{
		[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonObjectContract)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	public Action<Object, Object> SetIsSpecified
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

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Predicate<Object> ShouldDeserialize
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

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Predicate<Object> ShouldSerialize
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

	public Nullable<TypeNameHandling> TypeNameHandling
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public string UnderlyingName
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public IValueProvider ValueProvider
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool Writable
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

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonProperty() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IAttributeProvider get_AttributeProvider() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonConverter get_Converter() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_DeclaringType() { }

	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonObjectContract)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public object get_DefaultValue() { }

	[CallerCount(Count = 57)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Predicate<Object> get_GetIsSpecified() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_HasMemberAttribute() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Ignored() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Boolean> get_IsReference() { }

	[CallerCount(Count = 0)]
	public bool get_IsRequiredSpecified() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonConverter get_ItemConverter() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Boolean> get_ItemIsReference() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public JsonConverter get_MemberConverter() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<Int32> get_Order() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal JsonContract get_PropertyContract() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_PropertyName() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Readable() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonObjectContract)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public Required get_Required() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action<Object, Object> get_SetIsSpecified() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Predicate<Object> get_ShouldDeserialize() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Predicate<Object> get_ShouldSerialize() { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_UnderlyingName() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IValueProvider get_ValueProvider() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Writable() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonConverter), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonReader), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonConverter&), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonReader), typeof(object), typeof(Boolean&), typeof(Object&), typeof(JsonContract&), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ShouldSetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonObjectContract), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(int), typeof(JsonProperty), typeof(PropertyPresence), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonObjectContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object GetResolvedDefaultValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AttributeProvider(IAttributeProvider value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Converter(JsonConverter value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DeclaringType(Type value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_DefaultValue(object value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_GetIsSpecified(Predicate<Object> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_HasMemberAttribute(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Ignored(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_IsReference(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ItemConverter(JsonConverter value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ItemIsReference(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MemberConverter(JsonConverter value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Order(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_PropertyContract(JsonContract value) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(ParameterInfo)}, ReturnType = typeof(JsonProperty))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberSerialization)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ShouldEscapeJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_PropertyName(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_PropertyType(Type value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Readable(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_Required(Required value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SetIsSpecified(Action<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ShouldDeserialize(Predicate<Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ShouldSerialize(Predicate<Object> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_UnderlyingName(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ValueProvider(IValueProvider value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Writable(bool value) { }

	[CallerCount(Count = 0)]
	[NullableContext(1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	internal void WritePropertyName(JsonWriter writer) { }

}

