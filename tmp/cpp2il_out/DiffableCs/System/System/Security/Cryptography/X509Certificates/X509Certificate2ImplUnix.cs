namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
{
	private bool readCertData; //Field offset: 0x10
	private CertificateData certData; //Field offset: 0x18

	public virtual IEnumerable<X509Extension> Extensions
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 29
	}

	public virtual string Issuer
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public virtual X500DistinguishedName IssuerName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual string KeyAlgorithm
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual Byte[] KeyAlgorithmParameters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual DateTime NotAfter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		 get { } //Length: 84
	}

	public virtual DateTime NotBefore
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		 get { } //Length: 84
	}

	public virtual Byte[] PublicKeyValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual Byte[] RawData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual Byte[] SerialNumber
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual string SignatureAlgorithm
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 29
	}

	public virtual string Subject
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public virtual X500DistinguishedName SubjectName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual Byte[] Thumbprint
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 211
	}

	public virtual int Version
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		 get { } //Length: 27
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected X509Certificate2ImplUnix() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void AppendPrivateKeyInfo(StringBuilder sb) { }

	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_KeyAlgorithm", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_NotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_NotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Extensions", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Security.Cryptography.X509Certificates.X509Extension>))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_RawData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Thumbprint", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Version", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SignatureAlgorithm", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SerialNumber", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_PublicKeyValue", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_KeyAlgorithmParameters", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[CallerCount(Count = 14)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureCertData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "ExportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public virtual Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PKCS12), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private Byte[] ExportPkcs12(string password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual IEnumerable<X509Extension> get_Extensions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Issuer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual X500DistinguishedName get_IssuerName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual string get_KeyAlgorithm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual Byte[] get_KeyAlgorithmParameters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	public virtual DateTime get_NotAfter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	public virtual DateTime get_NotBefore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual Byte[] get_PublicKeyValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual Byte[] get_RawData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual Byte[] get_SerialNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual string get_SignatureAlgorithm() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Subject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual X500DistinguishedName get_SubjectName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 4)]
	public virtual Byte[] get_Thumbprint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	public virtual int get_Version() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	public virtual string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	protected abstract Byte[] GetRawCertData() { }

}

