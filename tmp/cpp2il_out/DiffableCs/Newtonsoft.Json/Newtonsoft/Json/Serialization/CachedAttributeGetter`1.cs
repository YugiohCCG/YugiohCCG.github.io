namespace Newtonsoft.Json.Serialization;

internal static class CachedAttributeGetter
{
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	private static readonly ThreadSafeStore<Object, T> TypeAttributeCache; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private static CachedAttributeGetter`1() { }

	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DataContractAttribute))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(DataMemberAttribute))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(MemberSerialization))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public static T GetAttribute(object type) { }

}

