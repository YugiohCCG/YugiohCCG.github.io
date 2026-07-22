namespace Mono.Btls;

internal class X509CertificateImplBtls : X509Certificate2ImplUnix
{
	private MonoBtlsX509 x509; //Field offset: 0xB0
	private MonoBtlsKey nativePrivateKey; //Field offset: 0xB8
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xC0

	public virtual bool HasPrivateKey
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public virtual bool IsValid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
		 get { } //Length: 27
	}

	internal MonoBtlsKey NativePrivateKey
	{
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal get { } //Length: 29
	}

	public virtual AsymmetricAlgorithm PrivateKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
		[DeduplicatedMethod]
		 get { } //Length: 52
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 206
	}

	internal MonoBtlsX509 X509
	{
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetBtlsCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
		[CallerCount(Count = 5)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		internal get { } //Length: 29
	}

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CreateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal X509CertificateImplBtls(MonoBtlsX509 x509) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsKey), Member = "Copy", ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private X509CertificateImplBtls(X509CertificateImplBtls other) { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal X509CertificateImplBtls(Byte[] data, MonoBtlsX509Format format) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = "ImportAuthenticode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	internal X509CertificateImplBtls(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsKey), Member = "Copy", ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual X509CertificateImpl Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool get_HasPrivateKey() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
	public virtual bool get_IsValid() { }

	[CallerCount(Count = 1)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal MonoBtlsKey get_NativePrivateKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
	[DeduplicatedMethod]
	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetBtlsCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CallerCount(Count = 5)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	internal MonoBtlsX509 get_X509() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual DSA GetDSAPrivateKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual Byte[] GetRawCertData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
	[DeduplicatedMethod]
	public virtual RSA GetRSAPrivateKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[CallsUnknownMethods(Count = 2)]
	private void Import(Byte[] data) { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ImportAuthenticode(Byte[] data) { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "GetPrivateKey", ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509), typeof(MonoBtlsX509)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl", typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

