namespace System.Reflection;

public sealed class AmbiguousMatchException : SystemException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public AmbiguousMatchException() { }

	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = "System.Linq.Expressions.Error", Member = "AmbiguousMatchInExpandoObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(int)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public AmbiguousMatchException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal AmbiguousMatchException(SerializationInfo info, StreamingContext context) { }

}

