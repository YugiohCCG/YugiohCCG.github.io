namespace System.Net;

internal class NtlmClient : IAuthenticationModule
{
	private IAuthenticationModule authObject; //Field offset: 0x10

	public override string AuthenticationType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[CalledBy(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public NtlmClient() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[CallerCount(Count = 0)]
	public override string get_AuthenticationType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

