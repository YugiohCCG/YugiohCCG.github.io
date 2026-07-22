namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
{
	internal static readonly DefaultSerializationBinder Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 2, 1, 1})]
	private readonly ThreadSafeStore<StructMultiKey`2<String, String>, Type> _typeCache; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadSafeStore`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static DefaultSerializationBinder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadSafeStore`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DefaultSerializationBinder() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadSafeStore`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type BindToType(string assemblyName, string typeName) { }

	[CalledBy(Type = typeof(DefaultSerializationBinder), Member = "GetTypeFromTypeNameKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.Utilities.StructMultiKey`2<System.String, System.String>)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ReflectionUtils), Member = "SplitFullyQualifiedTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Newtonsoft.Json.Utilities.StructMultiKey`2<System.String, System.String>))]
	[Calls(Type = typeof(ThreadSafeStore`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadSafeStore`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	private Type GetTypeByName(StructMultiKey<String, String> typeNameKey) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultSerializationBinder), Member = "GetGenericTypeFromTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 26)]
	private Type GetTypeFromTypeNameKey(StructMultiKey<String, String> typeNameKey) { }

}

