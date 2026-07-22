namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonArrayContract : JsonContainerContract
{
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; //Field offset: 0xC8
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0xD0
	private Type _genericWrapperType; //Field offset: 0xD8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _genericWrapperCreator; //Field offset: 0xE0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Func<Object> _genericTemporaryCollectionCreator; //Field offset: 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; //Field offset: 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0xF8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x100
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x110

	internal bool CanDeserialize
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public Type CollectionItemType
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool HasParameterizedCreator
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

	internal bool HasParameterizedCreatorInternal
	{
		[CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonArrayContract), typeof(Boolean&)}, ReturnType = typeof(IList))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
		internal get { } //Length: 110
	}

	internal bool IsArray
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public bool IsMultidimensionalArray
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor<Object> OverrideCreator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 41
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 218
	}

	internal bool ShouldCreateWrapper
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonArrayContract))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetCollectionItemType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonArrayContract), Member = "get_HasParameterizedCreatorInternal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonArrayContract), Member = "StoreFSharpListCreatorIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionUtils), Member = "ResolveEnumerableCollectionConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ImmutableCollectionsUtils), Member = "TryBuildImmutableForArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&), typeof(ObjectConstructor`1<Object>&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 68)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	public JsonArrayContract(Type underlyingType) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonArrayContract), typeof(Boolean&)}, ReturnType = typeof(IList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[NullableContext(1)]
	internal IList CreateTemporaryCollection() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonArrayContract), typeof(Boolean&)}, ReturnType = typeof(IList))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	[NullableContext(1)]
	internal IWrappedCollection CreateWrapper(object list) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_CanDeserialize() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_CollectionItemType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_HasParameterizedCreator() { }

	[CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonArrayContract), typeof(Boolean&)}, ReturnType = typeof(IList))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	internal bool get_HasParameterizedCreatorInternal() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_IsArray() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsMultidimensionalArray() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ObjectConstructor<Object> get_OverrideCreator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_ShouldCreateWrapper() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CanDeserialize(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_HasParameterizedCreator(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	[CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FSharpUtils), Member = "EnsureInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FSharpUtils), Member = "CreateSeq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }

}

