namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Store : IDisposable
{
	private string _name; //Field offset: 0x10
	private StoreLocation _location; //Field offset: 0x18
	private X509Certificate2Collection list; //Field offset: 0x20
	private OpenFlags _flags; //Field offset: 0x28
	private X509Store store; //Field offset: 0x30

	public X509Certificate2Collection Certificates
	{
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 133
	}

	private X509Stores Factory
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
		[Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
		private get { } //Length: 20
	}

	internal X509Store Store
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public X509Store(StoreName storeName, StoreLocation storeLocation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public X509Certificate2Collection get_Certificates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
	private X509Stores get_Factory() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal X509Store get_Store() { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(X509Stores), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateEnumerator))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 25)]
	public void Open(OpenFlags flags) { }

}

