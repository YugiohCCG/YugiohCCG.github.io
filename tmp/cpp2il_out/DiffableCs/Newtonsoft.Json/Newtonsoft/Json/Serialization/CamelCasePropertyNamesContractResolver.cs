namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
{
	private static readonly object TypeContractCacheLock; //Field offset: 0x0
	private static readonly DefaultJsonNameTable NameTable; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 0, 1, 1, 1})]
	private static Dictionary<StructMultiKey`2<Type, Type>, JsonContract> _contractCache; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultJsonNameTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static CamelCasePropertyNamesContractResolver() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CamelCasePropertyNamesContractResolver() { }

	[CallerCount(Count = 0)]
	internal virtual DefaultJsonNameTable GetNameTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StructMultiKey`2<Object, Object>", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Object, System.Object>, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StructMultiKey`2<Object, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual JsonContract ResolveContract(Type type) { }

}

