namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class JsonDynamicContract : JsonContainerContract
{
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func<String, String> <PropertyNameResolver>k__BackingField; //Field offset: 0xC8
	private readonly ThreadSafeStore<String, CallSite`1<Func`3<CallSite, Object, Object>>> _callSiteGetters; //Field offset: 0xD0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 1, 1, 1, 1, 2, 1})]
	private readonly ThreadSafeStore<String, CallSite`1<Func`4<CallSite, Object, Object, Object>>> _callSiteSetters; //Field offset: 0xD8

	public JsonPropertyCollection Properties
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func<String, String> PropertyNameResolver
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public JsonDynamicContract(Type underlyingType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinderWrapper), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(CallSiteBinder))]
	[Calls(Type = typeof(NoThrowGetBinderMember), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetMemberBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallSite`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	private static CallSite<Func`3<CallSite, Object, Object>> CreateCallSiteGetter(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinderWrapper), Member = "SetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(CallSiteBinder))]
	[Calls(Type = typeof(NoThrowSetBinderMember), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallSite`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	private static CallSite<Func`4<CallSite, Object, Object, Object>> CreateCallSiteSetter(string name) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public JsonPropertyCollection get_Properties() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<String, String> get_PropertyNameResolver() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PropertyNameResolver(Func<String, String> value) { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

}

