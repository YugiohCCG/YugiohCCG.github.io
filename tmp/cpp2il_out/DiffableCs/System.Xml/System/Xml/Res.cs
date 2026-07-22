namespace System.Xml;

internal static class Res
{

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static string GetString(string name) { }

	[CallerCount(Count = 95)]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	public static string GetString(string name, Object[] args) { }

}

