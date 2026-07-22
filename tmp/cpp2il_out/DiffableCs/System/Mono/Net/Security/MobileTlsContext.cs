namespace Mono.Net.Security;

internal abstract class MobileTlsContext : IDisposable
{
	private ChainValidationHelper certificateValidator; //Field offset: 0x10
	[CompilerGenerated]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <TargetHost>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <ServerName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly bool <AskForClientCertificate>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private X509Certificate <LocalServerCertificate>k__BackingField; //Field offset: 0x50

	protected bool AskForClientCertificate
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected X509CertificateCollection ClientCertificates
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	protected SslProtocols EnabledProtocols
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public abstract bool IsAuthenticated
	{
		 get { } //Length: 0
	}

	public bool IsServer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal abstract X509Certificate LocalClientCertificate
	{
		internal get { } //Length: 0
	}

	internal X509Certificate LocalServerCertificate
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal MonoSslAuthenticationOptions Options
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal MobileAuthenticatedStream Parent
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public abstract X509Certificate2 RemoteCertificate
	{
		 get { } //Length: 0
	}

	protected string ServerName
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public MonoTlsSettings Settings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	internal string TargetHost
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	public abstract void FinishHandshake() { }

	public abstract void Flush() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected bool get_AskForClientCertificate() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected X509CertificateCollection get_ClientCertificates() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected SslProtocols get_EnabledProtocols() { }

	public abstract bool get_IsAuthenticated() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsServer() { }

	internal abstract X509Certificate get_LocalClientCertificate() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal X509Certificate get_LocalServerCertificate() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal MonoSslAuthenticationOptions get_Options() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal MobileAuthenticatedStream get_Parent() { }

	public abstract X509Certificate2 get_RemoteCertificate() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected string get_ServerName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public MonoTlsSettings get_Settings() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal string get_TargetHost() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void GetProtocolVersions(out Nullable<TlsProtocolCode>& min, out Nullable<TlsProtocolCode>& max) { }

	public abstract bool PendingRenegotiation() { }

	public abstract bool ProcessHandshake() { }

	public abstract ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	public abstract void Renegotiate() { }

	[CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_tlsctx*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_x509name*), typeof(IntPtr), typeof(unitytls_x509list_ref*), typeof(unitytls_key_ref*), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ChainPolicy), Member = "set_VerificationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509VerificationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainPolicy), Member = "set_RevocationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 21)]
	protected X509Certificate SelectClientCertificate(String[] acceptableIssuers) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LocalServerCertificate(X509Certificate value) { }

	public abstract void Shutdown() { }

	public abstract void StartHandshake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	public abstract ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

}

