namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonContract
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		[Nullable(0)]
		public MethodInfo callbackMethodInfo; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass57_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 6)]
		internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		[Nullable(0)]
		public MethodInfo callbackMethodInfo; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass58_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 10)]
		internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

	}

	internal bool IsNullable; //Field offset: 0x10
	internal bool IsConvertable; //Field offset: 0x11
	internal bool IsEnum; //Field offset: 0x12
	internal Type NonNullableUnderlyingType; //Field offset: 0x18
	internal ReadType InternalReadType; //Field offset: 0x20
	internal JsonContractType ContractType; //Field offset: 0x24
	internal bool IsReadOnlyOrFixedSize; //Field offset: 0x28
	internal bool IsSealed; //Field offset: 0x29
	internal bool IsInstantiable; //Field offset: 0x2A
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<SerializationCallback> _onDeserializedCallbacks; //Field offset: 0x30
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<SerializationCallback> _onDeserializingCallbacks; //Field offset: 0x38
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<SerializationCallback> _onSerializedCallbacks; //Field offset: 0x40
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<SerializationCallback> _onSerializingCallbacks; //Field offset: 0x48
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List<SerializationErrorCallback> _onErrorCallbacks; //Field offset: 0x50
	private Type _createdType; //Field offset: 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Nullable<Boolean> <IsReference>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[Nullable(2)]
	private JsonConverter <Converter>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(2)]
	private JsonConverter <InternalConverter>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Func<Object> <DefaultCreator>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; //Field offset: 0x88

	[Nullable(2)]
	public JsonConverter Converter
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public Type CreatedType
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 229
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Func<Object> DefaultCreator
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public bool DefaultCreatorNonPublic
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[Nullable(2)]
	public internal JsonConverter InternalConverter
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		internal set { } //Length: 13
	}

	public Nullable<Boolean> IsReference
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public IList<SerializationCallback> OnDeserializedCallbacks
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public IList<SerializationCallback> OnDeserializingCallbacks
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public IList<SerializationErrorCallback> OnErrorCallbacks
	{
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public IList<SerializationCallback> OnSerializedCallbacks
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public IList<SerializationCallback> OnSerializingCallbacks
	{
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
		[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public Type UnderlyingType
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePrimitiveContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonPrimitiveContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateLinqContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonLinqContract))]
	[CalledBy(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonLinqContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonPrimitiveContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ReflectionUtils), Member = "EnsureNotByRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConvertUtils), Member = "IsConvertible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal JsonContract(Type underlyingType) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationErrorCallback>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationErrorCallback>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public JsonConverter get_Converter() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Type get_CreatedType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<Object> get_DefaultCreator() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_DefaultCreatorNonPublic() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public JsonConverter get_InternalConverter() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Nullable<Boolean> get_IsReference() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_UnderlyingType() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	[CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonContract), typeof(object), typeof(IJsonLineInfo), typeof(string), typeof(Exception)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public void set_Converter(JsonConverter value) { }

	[CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_CreatedType(Type value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DefaultCreator(Func<Object> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_DefaultCreatorNonPublic(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	internal void set_InternalConverter(JsonConverter value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_IsReference(Nullable<Boolean> value) { }

}

