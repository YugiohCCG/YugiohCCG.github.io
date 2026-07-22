namespace Mono.Btls;

internal class X509ChainImplBtls : X509ChainImpl
{
	private MonoBtlsX509StoreCtx storeCtx; //Field offset: 0x10
	private MonoBtlsX509Chain chain; //Field offset: 0x18
	private MonoBtlsX509Chain untrustedChain; //Field offset: 0x20
	private X509ChainElementCollection elements; //Field offset: 0x28
	private X509Certificate2Collection untrusted; //Field offset: 0x30
	private X509Certificate2[] certificates; //Field offset: 0x38
	private X509ChainPolicy policy; //Field offset: 0x40
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x48

	public virtual X509ChainElementCollection ChainElements
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
		[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
		[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		 get { } //Length: 689
	}

	public virtual X509ChainPolicy ChainPolicy
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual bool IsValid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
		 get { } //Length: 21
	}

	internal MonoBtlsX509StoreCtx StoreCtx
	{
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		internal get { } //Length: 26
	}

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetManagedChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain)}, ReturnType = typeof(X509Chain))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal X509ChainImplBtls(MonoBtlsX509Chain chain) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void AddStatus(X509ChainStatusFlags errorCode) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool Build(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "get_Current", ReturnType = typeof(X509Certificate2))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
	public virtual bool get_IsValid() { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Reset() { }

}

