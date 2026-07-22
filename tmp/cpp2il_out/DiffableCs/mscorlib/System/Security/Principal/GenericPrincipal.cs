namespace System.Security.Principal;

[ComVisible(True)]
public class GenericPrincipal : ClaimsPrincipal
{
	private IIdentity m_identity; //Field offset: 0x28
	private String[] m_roles; //Field offset: 0x30

	[CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseBasicAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPrincipal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClaimsPrincipal), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public GenericPrincipal(IIdentity identity, String[] roles) { }

}

