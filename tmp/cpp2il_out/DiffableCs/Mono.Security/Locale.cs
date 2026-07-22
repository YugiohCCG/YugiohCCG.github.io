//Type is in global namespace

internal sealed class Locale
{

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static string GetText(string msg) { }

	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public static string GetText(string fmt, Object[] args) { }

}

