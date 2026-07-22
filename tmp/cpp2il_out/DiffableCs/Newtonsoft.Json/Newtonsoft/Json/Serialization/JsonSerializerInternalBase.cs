namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal abstract class JsonSerializerInternalBase
{
	[NullableContext(0)]
	private class ReferenceEqualsEqualityComparer : IEqualityComparer<Object>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ReferenceEqualsEqualityComparer() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[NullableContext(2)]
		private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	}

	[Nullable(2)]
	private ErrorContext _currentErrorContext; //Field offset: 0x10
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private BidirectionalDictionary<String, Object> _mappings; //Field offset: 0x18
	internal readonly JsonSerializer Serializer; //Field offset: 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; //Field offset: 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; //Field offset: 0x30

	internal BidirectionalDictionary<String, Object> DefaultReferenceMappings
	{
		[CalledBy(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(BidirectionalDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TFirst>", "System.Collections.Generic.IEqualityComparer`1<TSecond>", typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal get { } //Length: 497
	}

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	protected JsonSerializerInternalBase(JsonSerializer serializer) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(int), typeof(JsonProperty), typeof(PropertyPresence), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	protected void ClearErrorContext() { }

	[CalledBy(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(BidirectionalDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TFirst>", "System.Collections.Generic.IEqualityComparer`1<TSecond>", typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal BidirectionalDictionary<String, Object> get_DefaultReferenceMappings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(int), typeof(JsonProperty), typeof(PropertyPresence), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(JsonSerializer), Member = "OnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonContract), Member = "InvokeOnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext), typeof(ErrorContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	[NullableContext(2)]
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonObjectContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

}

