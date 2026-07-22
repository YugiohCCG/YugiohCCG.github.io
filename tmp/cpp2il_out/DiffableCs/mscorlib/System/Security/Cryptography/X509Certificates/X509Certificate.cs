namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
{
	private X509CertificateImpl impl; //Field offset: 0x10
	private Byte[] lazyCertHash; //Field offset: 0x18
	private Byte[] lazySerialNumber; //Field offset: 0x20
	private string lazyIssuer; //Field offset: 0x28
	private string lazySubject; //Field offset: 0x30
	private string lazyKeyAlgorithm; //Field offset: 0x38
	private Byte[] lazyKeyAlgorithmParameters; //Field offset: 0x40
	private Byte[] lazyPublicKey; //Field offset: 0x48
	private DateTime lazyNotBefore; //Field offset: 0x50
	private DateTime lazyNotAfter; //Field offset: 0x58

	internal X509CertificateImpl Impl
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public string Issuer
	{
		[CalledBy(Type = typeof(X509Certificate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(int), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocationOnChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "WrapUp", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSelfIssued", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "FindParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[CalledBy(Type = "Mono.Net.Security.MobileTlsContext", Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 159
	}

	internal bool IsValid
	{
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 29
	}

	public string Subject
	{
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSelfIssued", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "WrapUp", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocationOnChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(int), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 159
	}

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public X509Certificate(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public X509Certificate() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public X509Certificate(Byte[] data) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	public X509Certificate(Byte[] rawData, string password) { }

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = "ValidateKeyStorageFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafePasswordHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509CertificateImpl))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public X509Certificate(Byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CalledBy(Type = "Mono.Unity.CertHelper", Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"unitytls_x509list*", typeof(X509Certificate), "unitytls_errorstate*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2Impl"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal X509Certificate(X509CertificateImpl impl) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	public X509Certificate(string fileName) { }

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = "ValidateKeyStorageFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SafePasswordHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509CertificateImpl))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainPolicy", Member = "get_ExtraStore", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public X509Certificate(X509Certificate cert) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate), Member = "GetRawSerialNumber", ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(X509Certificate other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafePasswordHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public override Byte[] Export(X509ContentType contentType, string password) { }

	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static string FormatDate(DateTime date) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal X509CertificateImpl get_Impl() { }

	[CalledBy(Type = typeof(X509Certificate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Net.Security.MobileTlsContext", Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "FindParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "WrapUp", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocationOnChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(int), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSelfIssued", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public string get_Issuer() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool get_IsValid() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSelfIssued", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "WrapUp", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocationOnChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509ChainStatusFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(int), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public string get_Subject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override Byte[] GetCertHash() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "ToHexStringUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override string GetCertHashString() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override string GetKeyAlgorithm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override Byte[] GetKeyAlgorithmParameters() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_NotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal DateTime GetNotAfter() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_NotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal DateTime GetNotBefore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override Byte[] GetPublicKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Byte[] GetRawCertData() { }

	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Byte[] GetRawCertHash() { }

	[CalledBy(Type = typeof(X509Certificate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Byte[] GetRawSerialNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override Byte[] GetSerialNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helpers), Member = "ToHexStringUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override string GetSerialNumberString() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ImportHandle(X509CertificateImpl impl) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Extensions", ReturnType = "System.Security.Cryptography.X509Certificates.X509ExtensionCollection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "Mono.Security.X509.X509Certificate")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_SubjectName", ReturnType = "System.Security.Cryptography.X509Certificates.X500DistinguishedName")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Version", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_RawData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_PublicKey", ReturnType = "System.Security.Cryptography.X509Certificates.PublicKey")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_IssuerName", ReturnType = "System.Security.Cryptography.X509Certificates.X500DistinguishedName")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_SignatureAlgorithm", ReturnType = "System.Security.Cryptography.Oid")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void ThrowIfInvalid() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "GetRawCertHash", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Helpers), Member = "ToHexArrayUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public override string ToString(bool fVerbose) { }

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void VerifyContentType(X509ContentType contentType) { }

}

