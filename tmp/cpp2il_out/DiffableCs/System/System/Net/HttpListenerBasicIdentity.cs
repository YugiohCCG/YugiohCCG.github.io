namespace System.Net;

public class HttpListenerBasicIdentity : GenericIdentity
{
	private string password; //Field offset: 0x88

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public HttpListenerBasicIdentity(string username, string password) { }

}

