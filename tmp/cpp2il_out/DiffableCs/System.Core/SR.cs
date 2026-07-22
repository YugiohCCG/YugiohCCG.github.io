//Type is in global namespace

internal static class SR
{

	[CalledBy(Type = typeof(Strings), Member = "DynamicObjectResultNotAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, Object[] args) { }

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1) { }

	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2) { }

	[CalledBy(Type = typeof(Error), Member = "BinderNotCompatibleWithCallSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Strings), Member = "ExpressionTypeDoesNotMatchMethodParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "MustRewriteChildToSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "MustRewriteToSameNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "InstanceAndMethodTypeMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "FieldInfoNotDefinedForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "DynamicBinderResultNotAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Strings), Member = "BinderNotCompatibleWithCallSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchMethodParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "MustRewriteChildToSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "MustRewriteToSameNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "InstanceAndMethodTypeMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "FieldInfoNotDefinedForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "DynamicBinderResultNotAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchMethodParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static string GetString(string name) { }

}

