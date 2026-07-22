namespace Mono.Btls;

internal abstract class MonoBtlsObject : IDisposable
{
	private abstract class MonoBtlsHandle : SafeHandle
	{

		public virtual bool IsInvalid
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 9
		}

		[CallerCount(Count = 46)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		internal MonoBtlsHandle(IntPtr handle, bool ownsHandle) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public virtual bool get_IsInvalid() { }

	}

	private MonoBtlsHandle handle; //Field offset: 0x10
	private Exception lastError; //Field offset: 0x18

	internal MonoBtlsHandle Handle
	{
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
		[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "get_Handle", ReturnType = typeof(BoringX509LookupMonoHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		internal get { } //Length: 26
	}

	public bool IsValid
	{
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 48
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MonoBtlsObject(MonoBtlsHandle handle) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	protected void CheckError(bool ok, string callerName = null) { }

	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetServerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "AddExplicitTrust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	protected void CheckError(int ret, string callerName = null) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	protected private void CheckLastError(string callerName = null) { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected void CheckThrow() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Close() { }

	[CalledBy(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsObject), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(MonoBtlsX509Lookup))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddDirectoryLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "set_PrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected void FreeDataPtr(IntPtr data) { }

	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetClientCertificateIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[CalledBy(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = "get_Handle", ReturnType = typeof(BoringX509LookupMonoHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	internal MonoBtlsHandle get_Handle() { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsValid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_free(IntPtr data) { }

	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeSelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeServerNameCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected Exception SetException(Exception ex) { }

}

