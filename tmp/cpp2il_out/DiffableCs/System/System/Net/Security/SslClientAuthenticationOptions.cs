namespace System.Net.Security;

public class SslClientAuthenticationOptions
{
	private EncryptionPolicy _encryptionPolicy; //Field offset: 0x10
	private X509RevocationMode _checkCertificateRevocation; //Field offset: 0x14
	private SslProtocols _enabledSslProtocols; //Field offset: 0x18
	private bool _allowRenegotiation; //Field offset: 0x1C
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x28

	public bool AllowRenegotiation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public X509RevocationMode CertificateRevocationCheckMode
	{
		[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 156
	}

	public X509CertificateCollection ClientCertificates
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public SslProtocols EnabledSslProtocols
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public EncryptionPolicy EncryptionPolicy
	{
		[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 156
	}

	public string TargetHost
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SslClientAuthenticationOptions() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowRenegotiation() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public X509CertificateCollection get_ClientCertificates() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public SslProtocols get_EnabledSslProtocols() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_TargetHost() { }

	[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ClientCertificates(X509CertificateCollection value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_EnabledSslProtocols(SslProtocols value) { }

	[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TargetHost(string value) { }

}

