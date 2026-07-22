namespace System.Net;

public class Authorization
{
	private string m_Message; //Field offset: 0x10
	private bool m_Complete; //Field offset: 0x18
	internal string ModuleAuthenticationType; //Field offset: 0x20

	public bool Complete
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Message
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Authorization(string token) { }

	[CalledBy(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Authorization(string token, bool finished) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Complete() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Message() { }

}

