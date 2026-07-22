namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal static class JsonTypeReflector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<Object, Type> <>9__22_1; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[NullableContext(0)]
		internal Type <GetCreator>b__22_1(object param) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		[Nullable(0)]
		public Type type; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func<Object> defaultConstructor; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass22_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
		[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 23)]
		internal object <GetCreator>b__0(Object[] parameters) { }

	}

	private static Nullable<Boolean> _dynamicCodeGeneration; //Field offset: 0x0
	public const string IdPropertyName = "$id"; //Field offset: 0x0
	public const string RefPropertyName = "$ref"; //Field offset: 0x0
	public const string TypePropertyName = "$type"; //Field offset: 0x0
	public const string ValuePropertyName = "$value"; //Field offset: 0x0
	public const string ArrayValuesPropertyName = "$values"; //Field offset: 0x0
	public const string ShouldSerializePrefix = "ShouldSerialize"; //Field offset: 0x0
	public const string SpecifiedPostfix = "Specified"; //Field offset: 0x0
	public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2"; //Field offset: 0x0
	private static Nullable<Boolean> _fullyTrusted; //Field offset: 0x2
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 1, 2, 1, 1})]
	private static readonly ThreadSafeStore<Type, Func`2<Object[], Object>> CreatorCache; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; //Field offset: 0x10
	[Nullable(2)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; //Field offset: 0x18

	public static bool DynamicCodeGeneration
	{
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 237
	}

	public static bool FullyTrusted
	{
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
		[CalledBy(Type = typeof(JsonObjectContract), Member = "GetUninitializedObject", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 284
	}

	public static ReflectionDelegateFactory ReflectionDelegateFactory
	{
		[CallerCount(Count = 35)]
		 get { } //Length: 137
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static JsonTypeReflector() { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CanConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeConverter), Member = "CanConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static JsonConverter CreateJsonConverterInstance(Type converterType, Object[] args) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, Object[] args) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool get_DynamicCodeGeneration() { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(JsonObjectContract), Member = "GetUninitializedObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_FullyTrusted() { }

	[CallerCount(Count = 35)]
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "T")]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private static Type GetAssociatedMetadataType(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String[])}, ReturnType = typeof(ReflectionObject))]
	[Calls(Type = typeof(ReflectionObject), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAssociatedMetadataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static T GetAttribute(Type type) { }

	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAssociatedMetadataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberInfoFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberInfo)}, ReturnType = typeof(MemberInfo))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static T GetAttribute(MemberInfo memberInfo) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MemberInfo>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDictionaryContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDynamicContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDynamicContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	public static T GetAttribute(object provider) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonContract))]
	[CalledBy(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(MemberSerialization))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JsonConverter))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GetTitle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GetDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GetTypeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Required), typeof(bool)}, ReturnType = typeof(JsonSchema))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CachedAttributeGetter`1), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static T GetCachedAttribute(object attributeProvider) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDictionaryContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDynamicContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDynamicContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static Func<Object[], Object> GetCreator(Type type) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MemberInfo>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CachedAttributeGetter`1), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(TypeExtensions), Member = "BaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeExtensions), Member = "MemberType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(MemberTypes))]
	[Calls(Type = typeof(CachedAttributeGetter`1), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsVirtual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberInfoFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberInfo)}, ReturnType = typeof(MemberInfo))]
	[Calls(Type = typeof(TypeExtensions), Member = "BaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveContractConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonConverter))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MemberInfo>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CachedAttributeGetter`1), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(TypeExtensions), Member = "BaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "T")]
	[ContainsUnimplementedInstructions]
	public static bool IsNonSerializable(object provider) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonContract))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "T")]
	[ContainsUnimplementedInstructions]
	public static bool IsSerializable(object provider) { }

}

