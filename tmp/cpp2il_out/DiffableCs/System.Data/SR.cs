//Type is in global namespace

internal static class SR
{

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2) { }

	[CalledBy(Type = typeof(ExceptionBuilder), Member = "DefaultValueDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "UnknownToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokens), typeof(Tokens), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "ArgumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Type)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "TypeMismatchInBinop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "AmbiguousBinop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static string GetString(string name) { }

}

