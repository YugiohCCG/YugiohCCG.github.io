namespace System.Security.Principal;

public class GenericIdentity : ClaimsIdentity
{
	private readonly string m_name; //Field offset: 0x78
	private readonly string m_type; //Field offset: 0x80

	public virtual string AuthenticationType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual IEnumerable<Claim> Claims
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClaimsIdentity), Member = "get_Claims", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>))]
		 get { } //Length: 7
	}

	public virtual string Name
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "System.Net.HttpListenerBasicIdentity", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseBasicAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPrincipal))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClaimsIdentity), Member = "AddClaim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Claim)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public GenericIdentity(string name, string type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
	private GenericIdentity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected GenericIdentity(GenericIdentity identity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClaimsIdentity), Member = "AddClaim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Claim)}, ReturnType = typeof(void))]
	private void AddNameClaim() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual ClaimsIdentity Clone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_AuthenticationType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = "get_Claims", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>))]
	public virtual IEnumerable<Claim> get_Claims() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

}

