namespace System.Security.Cryptography.X509Certificates;

internal class X509ChainImplMono : X509ChainImpl
{
	private static X509ChainStatus[] Empty; //Field offset: 0x0
	private StoreLocation location; //Field offset: 0x10
	private X509ChainElementCollection elements; //Field offset: 0x18
	private X509ChainPolicy policy; //Field offset: 0x20
	private X509ChainStatus[] status; //Field offset: 0x28
	private int max_path_length; //Field offset: 0x30
	private X500DistinguishedName working_issuer_name; //Field offset: 0x38
	private AsymmetricAlgorithm working_public_key; //Field offset: 0x40
	private X509ChainElement bce_restriction; //Field offset: 0x48
	private X509Certificate2Collection roots; //Field offset: 0x50
	private X509Certificate2Collection cas; //Field offset: 0x58
	private X509Store root_store; //Field offset: 0x60
	private X509Store ca_store; //Field offset: 0x68
	private X509Store user_root_store; //Field offset: 0x70
	private X509Store user_ca_store; //Field offset: 0x78
	private X509Certificate2Collection collection; //Field offset: 0x80

	private X509Certificate2Collection CertificateAuthorities
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		private get { } //Length: 423
	}

	private X509Certificate2Collection CertificateCollection
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate2))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(X509ChainPolicy), Member = "get_ExtraStore", ReturnType = typeof(X509Certificate2Collection))]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 23)]
		private get { } //Length: 953
	}

	public virtual X509ChainElementCollection ChainElements
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual X509ChainPolicy ChainPolicy
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual bool IsValid
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	private X509Store LMCAStore
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 158
	}

	private X509Store LMRootStore
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 158
	}

	private X509Certificate2Collection Roots
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
		[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		private get { } //Length: 423
	}

	private X509Store UserCAStore
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 158
	}

	private X509Store UserRootStore
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 158
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static X509ChainImplMono() { }

	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Chain), Member = "Create", ReturnType = typeof(X509Chain))]
	[CalledBy(Type = typeof(X509Helper2), Member = "CreateChainImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(X509ChainImpl))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(OidCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public X509ChainImplMono(bool useMachineContext) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void AddStatus(X509ChainStatusFlags error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	public virtual bool Build(X509Certificate2 certificate) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(X509Store), Member = "get_Crls", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Crl)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocationOnChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(int), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCrlExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Crl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCrlEntryExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CrlEntry)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Crl), Member = "GetCrlEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CrlEntry))]
	[Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "get_KeyUsages", ReturnType = typeof(X509KeyUsageFlags))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(int), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "get_SubjectKeyIdentifier", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "CheckCrls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509Store)}, ReturnType = typeof(X509Crl))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
	[CallsUnknownMethods(Count = 1)]
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private X509Certificate2Collection get_CertificateAuthorities() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(X509ChainPolicy), Member = "get_ExtraStore", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 23)]
	private X509Certificate2Collection get_CertificateCollection() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_IsValid() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private X509Store get_LMCAStore() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private X509Store get_LMRootStore() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private X509Certificate2Collection get_Roots() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private X509Store get_UserCAStore() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private X509Store get_UserRootStore() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuthorityKeyIdentifierExtension), Member = "get_Identifier", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckCrls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509Store)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Extension)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "get_SubjectKeyIdentifier", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsChainComplete(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
	[Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509BasicConstraintsExtension), Member = "get_PathLengthConstraint", ReturnType = typeof(int))]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "get_KeyUsages", ReturnType = typeof(X509KeyUsageFlags))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsInvalidInstructions]
	private void PrepareForNextCertificate(int n) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X500DistinguishedName), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName), typeof(X500DistinguishedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
	[Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	private void Process(int n) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "GetEnumerator", ReturnType = typeof(X509ExtensionEnumerator))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private bool ProcessCrlExtensions(X509Crl crl) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public virtual void Reset() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "get_SubjectKeyIdentifier", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
	[Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "CheckRevocationOnChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void ValidateChain(X509ChainStatusFlags flag) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void WrapUp() { }

}

