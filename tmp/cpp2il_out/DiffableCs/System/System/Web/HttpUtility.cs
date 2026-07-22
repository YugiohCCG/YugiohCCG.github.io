namespace System.Web;

public sealed class HttpUtility
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private static int GetChar(string str, int offset, int length) { }

	[CallerCount(Count = 0)]
	private static int GetInt(byte b) { }

	[CalledBy(Type = "Manager.DiscordController", Member = "IsValidState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.DiscordController", Member = "ValidateDiscordImplicitGrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.DiscordController", Member = "ParseDiscordImplicitGrantURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int64&), "System.Collections.Generic.Dictionary`2<String, String>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]", typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	public static string UrlDecode(string str) { }

	[CalledBy(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HttpUtility), Member = "WriteCharBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(char), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string UrlDecode(string str, Encoding e) { }

	[CalledBy(Type = "Manager.DiscordController", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[ContainsInvalidInstructions]
	public static string UrlEncode(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(HttpEncoder), Member = "get_Current", ReturnType = typeof(HttpEncoder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static string UrlEncode(string str, Encoding e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpEncoder), Member = "get_Current", ReturnType = typeof(HttpEncoder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpEncoder), Member = "get_Current", ReturnType = typeof(HttpEncoder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string UrlPathEncode(string str) { }

	[CalledBy(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void WriteCharBytes(IList buf, char ch, Encoding e) { }

}

