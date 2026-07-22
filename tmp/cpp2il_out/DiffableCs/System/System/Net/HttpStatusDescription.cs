namespace System.Net;

internal static class HttpStatusDescription
{

	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(HttpStatusCode), typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	internal static string Get(HttpStatusCode code) { }

	[CalledBy(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal static string Get(int code) { }

}

