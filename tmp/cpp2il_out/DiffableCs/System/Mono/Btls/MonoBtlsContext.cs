namespace Mono.Btls;

internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
{
	private X509Certificate2 remoteCertificate; //Field offset: 0x58
	private X509Certificate clientCertificate; //Field offset: 0x60
	private X509CertificateImplBtls nativeServerCertificate; //Field offset: 0x68
	private X509CertificateImplBtls nativeClientCertificate; //Field offset: 0x70
	private MonoBtlsSslCtx ctx; //Field offset: 0x78
	private MonoBtlsSsl ssl; //Field offset: 0x80
	private MonoBtlsBio bio; //Field offset: 0x88
	private MonoBtlsBio errbio; //Field offset: 0x90
	private MonoTlsConnectionInfo connectionInfo; //Field offset: 0x98
	private bool certificateValidated; //Field offset: 0xA0
	private bool isAuthenticated; //Field offset: 0xA1
	private bool connected; //Field offset: 0xA2

	public virtual bool IsAuthenticated
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal virtual X509Certificate LocalClientCertificate
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual X509Certificate2 RemoteCertificate
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(MonoBtlsStream), Member = "CreateContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(MobileTlsContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MobileTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[CallsUnknownMethods(Count = 1)]
	public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsContext), Member = "Dispose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void Dispose(ref T disposable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Connect", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Accept", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Handshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallsUnknownMethods(Count = 1)]
	private MonoBtlsSslError DoProcessHandshake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	public virtual void FinishHandshake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_IsAuthenticated() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal virtual X509Certificate get_LocalClientCertificate() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public virtual X509Certificate2 get_RemoteCertificate() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsError), Member = "GetErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 23)]
	private static Exception GetException(MonoBtlsSslError status) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetPeerCertificate", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "CreateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(X509Certificate2))]
	[CallsUnknownMethods(Count = 5)]
	private void GetPeerCertificate() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSelectCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetCiphers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetMaxVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetMinVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetServerNameCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsServerNameCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsVerifyCallback), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "AddDirectoryLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsX509StoreManager), Member = "GetStorePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "AddCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection), typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void InitializeConnection() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "FinishHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPeerCertificate", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetCipher", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetVersion", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetServerName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void InitializeSession() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void Mono.Btls.IMonoBtlsBioMono.Close() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private override int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private override bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "RenegotiatePending", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool PendingRenegotiation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Connect", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Accept", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Handshake", ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "PrintErrors", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckLastError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool ProcessHandshake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Renegotiate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPeerCertificate", ReturnType = typeof(void))]
	[Calls(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int SelectCallback(String[] acceptableIssuers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetServerName", ReturnType = typeof(string))]
	[Calls(Type = typeof(MobileTlsContext), Member = "SelectServerCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int ServerNameCallback() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_RawData", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainPolicy), Member = "set_RevocationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "AddIntermediateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsKey)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = "get_X509", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetQuietShutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Shutdown", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Shutdown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsBioMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoBtlsBioMono)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetBio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsBio)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetServerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "SetRenegotiateMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslRenegotiateMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void StartHandshake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsContext), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int size) { }

}

