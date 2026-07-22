//Type is in global namespace

internal static class SR
{

	[CallerCount(Count = 145)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1) { }

	[CallerCount(Count = 92)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2) { }

	[CalledBy(Type = "System.ComponentModel.InvalidEnumArgumentException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.IPEndPoint", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.SocketAddress"}, ReturnType = "System.Net.EndPoint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static string GetResourceString(string str) { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	internal static string GetString(string name, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	internal static string GetString(CultureInfo culture, string name, Object[] args) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static string GetString(string name) { }

}

