namespace System.Reflection;

[Extension]
internal static class SignatureTypeExtensions
{

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Type TryMakeArrayType(Type type) { }

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Type TryMakeArrayType(Type type, int rank) { }

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Type TryMakeByRefType(Type type) { }

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Type TryMakePointerType(Type type) { }

	[CalledBy(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakePointerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeByRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryMakeArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Extension]
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

}

