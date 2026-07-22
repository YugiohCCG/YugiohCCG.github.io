namespace System.Security.Cryptography.X509Certificates;

internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
{
	private static string empty_error; //Field offset: 0x0
	private static Byte[] signedData; //Field offset: 0x8
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xB0
	private X509Certificate _cert; //Field offset: 0xB8

	private X509Certificate Cert
	{
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private get { } //Length: 29
	}

	public virtual bool HasPrivateKey
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 31
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
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	internal X509Certificate MonoCertificate
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public virtual AsymmetricAlgorithm PrivateKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RSAManaged), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
		[Calls(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 18)]
		 get { } //Length: 1060
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		 set { } //Length: 601
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static X509Certificate2ImplMono() { }

	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public X509Certificate2ImplMono(X509Certificate cert) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplCollection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private X509Certificate2ImplMono(X509Certificate2ImplMono other) { }

	[CalledBy(Type = typeof(X509PalImplMono), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "GetCertContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509ContentType))]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public X509Certificate2ImplMono(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplCollection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual X509CertificateImpl Clone() { }

	[CallerCount(Count = 1)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private X509Certificate get_Cert() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_HasPrivateKey() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool get_IsValid() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	internal X509Certificate get_MonoCertificate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSAManaged), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 18)]
	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual DSA GetDSAPrivateKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual Byte[] GetRawCertData() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual RSA GetRSAPrivateKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallsDeduplicatedMethods(Count = 1)]
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateEnumerator))]
	[Calls(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 21)]
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[MonoTODO("by default this depends on the incomplete X509Chain")]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

