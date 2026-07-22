namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal abstract class ReflectionDelegateFactory
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ReflectionDelegateFactory() { }

	public abstract Func<T> CreateDefaultConstructor(Type type) { }

	[CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), typeof(String[])}, ReturnType = typeof(ReflectionObject))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public Func<T, Object> CreateGet(MemberInfo memberInfo) { }

	public abstract Func<T, Object> CreateGet(PropertyInfo propertyInfo) { }

	public abstract Func<T, Object> CreateGet(FieldInfo fieldInfo) { }

	public abstract MethodCall<T, Object> CreateMethodCall(MethodBase method) { }

	public abstract ObjectConstructor<Object> CreateParameterizedConstructor(MethodBase method) { }

	[CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), typeof(String[])}, ReturnType = typeof(ReflectionObject))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public Action<T, Object> CreateSet(MemberInfo memberInfo) { }

	public abstract Action<T, Object> CreateSet(FieldInfo fieldInfo) { }

	public abstract Action<T, Object> CreateSet(PropertyInfo propertyInfo) { }

}

