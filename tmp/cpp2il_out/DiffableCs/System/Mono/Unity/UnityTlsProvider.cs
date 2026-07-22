namespace Mono.Unity;

internal class UnityTlsProvider : MobileTlsProvider
{

	public virtual Guid ID
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 91
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public virtual SslProtocols SupportedProtocols
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	internal virtual bool SupportsCleanShutdown
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual bool SupportsConnectionInfo
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool SupportsMonoExtensions
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool SupportsSslStream
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnityTlsProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferOffsetSize2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[CallerCount(Count = 0)]
	public virtual Guid get_ID() { }

	[CallerCount(Count = 0)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual SslProtocols get_SupportedProtocols() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_SupportsCleanShutdown() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_SupportsConnectionInfo() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_SupportsMonoExtensions() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_SupportsSslStream() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(X509Chain), Member = "get_Impl", ReturnType = typeof(X509ChainImpl))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(unitytls_x509verify_callback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	internal virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(unitytls_x509verify_callback))]
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

}

