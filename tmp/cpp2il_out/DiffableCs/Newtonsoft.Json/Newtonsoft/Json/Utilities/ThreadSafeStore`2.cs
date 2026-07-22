namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class ThreadSafeStore
{
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; //Field offset: 0x0
	private readonly Func<TKey, TValue> _creator; //Field offset: 0x0

	[CalledBy(Type = typeof(ConvertUtils), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumUtils), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultSerializationBinder), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultSerializationBinder), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public ThreadSafeStore`2(Func<TKey, TValue> creator) { }

	[CalledBy(Type = typeof(ConvertUtils), Member = "EnsureTypeAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EnumUtils), Member = "TryToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumUtils), Member = "TryToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(NamingStrategy), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumUtils), Member = "GetEnumValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EnumInfo))]
	[CalledBy(Type = typeof(EnumUtils), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(NamingStrategy), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultSerializationBinder), Member = "GetGenericTypeFromTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(DefaultSerializationBinder), Member = "GetTypeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.Utilities.StructMultiKey`2<System.String, System.String>)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(DefaultSerializationBinder), Member = "BindToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Func`2<TKey, TValue>"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue Get(TKey key) { }

}

