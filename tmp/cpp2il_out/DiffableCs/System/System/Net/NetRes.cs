namespace System.Net;

internal class NetRes
{

	[CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpStatusCode), typeof(string), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	[CalledBy(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

}

