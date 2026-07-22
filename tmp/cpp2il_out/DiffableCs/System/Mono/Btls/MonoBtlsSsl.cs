namespace Mono.Btls;

internal class MonoBtlsSsl : MonoBtlsObject
{
	public class BoringSslHandle : MonoBtlsHandle
	{

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BoringSslHandle(IntPtr handle) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual bool ReleaseHandle() { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class PrintErrorsCallbackFunc : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public PrintErrorsCallbackFunc(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(IntPtr str, IntPtr len, IntPtr ctx) { }

	}

	private MonoBtlsBio bio; //Field offset: 0x20
	private PrintErrorsCallbackFunc printErrorsFunc; //Field offset: 0x28
	private IntPtr printErrorsFuncPtr; //Field offset: 0x30

	internal BoringSslHandle Handle
	{
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 113
	}

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public MonoBtlsSsl(MonoBtlsSslCtx ctx) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "DoProcessHandshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallsUnknownMethods(Count = 3)]
	public MonoBtlsSslError Accept() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Close() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "DoProcessHandshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallsUnknownMethods(Count = 3)]
	public MonoBtlsSslError Connect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsSslCtx), Member = "get_Handle", ReturnType = typeof(BoringSslCtxHandle))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[CallsUnknownMethods(Count = 1)]
	internal BoringSslHandle get_Handle() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int GetCipher() { }

	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Accept", ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Connect", ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Handshake", ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckLastError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "mono_btls_ssl_get_error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private MonoBtlsSslError GetError(int ret_code) { }

	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "PrintErrors", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public string GetErrors() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "GetPeerCertificate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public MonoBtlsX509 GetPeerCertificate() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public string GetServerName() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CallsUnknownMethods(Count = 3)]
	public int GetVersion() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "DoProcessHandshake", ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallsUnknownMethods(Count = 3)]
	public MonoBtlsSslError Handshake() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_accept(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_ssl_close(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_connect(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_ssl_destroy(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_get_cipher(IntPtr handle) { }

	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Int32&)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_get_version(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_handshake(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_ssl_new(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_shutdown(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetErrors", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PrintErrors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[MonoPInvokeCallback(typeof(PrintErrorsCallbackFunc))]
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsSslError))]
	[CallsUnknownMethods(Count = 3)]
	public MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "PendingRenegotiation", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool RenegotiatePending() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsBio), Member = "get_Handle", ReturnType = typeof(BoringBioHandle))]
	[CallsUnknownMethods(Count = 4)]
	public void SetBio(MonoBtlsBio bio) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public void SetCertificate(MonoBtlsX509 x509) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsKey), Member = "get_Handle", ReturnType = typeof(BoringKeyHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public void SetPrivateKey(MonoBtlsKey key) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CallsUnknownMethods(Count = 3)]
	public void SetQuietShutdown() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetServerName(string name) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public void Shutdown() { }

	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsKey)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "AddIntermediateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "GetErrors", ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private Exception ThrowError(string callerName = null) { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "get_Handle", ReturnType = typeof(BoringSslHandle))]
	[Calls(Type = typeof(MonoBtlsSsl), Member = "mono_btls_ssl_get_error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

}

