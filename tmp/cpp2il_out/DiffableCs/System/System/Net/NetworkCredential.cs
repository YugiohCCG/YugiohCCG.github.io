namespace System.Net;

public class NetworkCredential : ICredentials
{
	private string m_domain; //Field offset: 0x10
	private string m_userName; //Field offset: 0x18
	private SecureString m_password; //Field offset: 0x20

	public string Domain
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 38
	}

	public string Password
	{
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(SecureStringHelper), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public string UserName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 38
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public NetworkCredential(string userName, string password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public NetworkCredential(string userName, string password, string domain) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Domain() { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public string get_Password() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_UserName() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override NetworkCredential GetCredential(Uri uri, string authType) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal string InternalGetDomain() { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	internal string InternalGetPassword() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal string InternalGetUserName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_Domain(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecureStringHelper), Member = "CreateSecureString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SecureString))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Password(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_UserName(string value) { }

}

