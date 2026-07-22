namespace System.Dynamic.Utils;

[Extension]
internal static class TypeExtensions
{
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheDict`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static TypeExtensions() { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeExtensions), Member = "MatchesArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Type[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CacheDict`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CacheDict`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsConstructor", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Type GetReturnType(MethodBase mi) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Extension]
	public static TypeCode GetTypeCode(Type type) { }

	[CalledBy(Type = typeof(TypeExtensions), Member = "GetAnyStaticMethodValidated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(TypeUtils), Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

}

