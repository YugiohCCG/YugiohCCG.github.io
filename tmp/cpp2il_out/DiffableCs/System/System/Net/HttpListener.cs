namespace System.Net;

public sealed class HttpListener : IDisposable
{
	private MonoTlsProvider tlsProvider; //Field offset: 0x10
	private MonoTlsSettings tlsSettings; //Field offset: 0x18
	private X509Certificate certificate; //Field offset: 0x20
	private AuthenticationSchemes auth_schemes; //Field offset: 0x28
	private HttpListenerPrefixCollection prefixes; //Field offset: 0x30
	private AuthenticationSchemeSelector auth_selector; //Field offset: 0x38
	private string realm; //Field offset: 0x40
	private bool ignore_write_exceptions; //Field offset: 0x48
	private bool unsafe_ntlm_auth; //Field offset: 0x49
	private bool listening; //Field offset: 0x4A
	private bool disposed; //Field offset: 0x4B
	private readonly object _internalLock; //Field offset: 0x50
	private Hashtable registry; //Field offset: 0x58
	private ArrayList ctx_queue; //Field offset: 0x60
	private ArrayList wait_queue; //Field offset: 0x68
	private Hashtable connections; //Field offset: 0x70
	private ServiceNameStore defaultServiceNames; //Field offset: 0x78
	private ExtendedProtectionPolicy extendedProtectionPolicy; //Field offset: 0x80

	public AuthenticationSchemes AuthenticationSchemes
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		 set { } //Length: 36
	}

	public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IgnoreWriteExceptions
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		 set { } //Length: 38
	}

	public bool IsListening
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static bool IsSupported
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public HttpListenerPrefixCollection Prefixes
	{
		[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public string Realm
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[MonoTODO("Support for NTLM needs some loving.")]
	public bool UnsafeConnectionNtlmAuthentication
	{
		[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		 set { } //Length: 38
	}

	[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable)}, ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ServiceNameStore), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public HttpListener() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void AddConnection(HttpConnection cnc) { }

	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	public IAsyncResult BeginGetContext(AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(HttpListener), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "set_UnsafeConnectionNtlmAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "get_Prefixes", ReturnType = typeof(HttpListenerPrefixCollection))]
	[CalledBy(Type = typeof(HttpListener), Member = "set_IgnoreWriteExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "set_AuthenticationSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthenticationSchemes)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 5)]
	internal void CheckDisposed() { }

	[CalledBy(Type = typeof(HttpListener), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 42)]
	private void Cleanup(bool close_existing) { }

	[CalledBy(Type = typeof(HttpListener), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void Close(bool force) { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "Stop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void Close() { }

	[CalledBy(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(EndPointListener), typeof(bool), typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[Calls(Type = typeof(MonoTlsSettings), Member = "get_DefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(CallbackHelpers), Member = "PublicToMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
	[Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(MonoTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "GetContext", ReturnType = typeof(HttpListenerContext))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HttpListenerContext), Member = "ParseBasicAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPrincipal))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public HttpListenerContext EndGetContext(IAsyncResult asyncResult) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public AuthenticationSchemes get_AuthenticationSchemes() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public AuthenticationSchemeSelector get_AuthenticationSchemeSelectorDelegate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IgnoreWriteExceptions() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsListening() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public static bool get_IsSupported() { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	public HttpListenerPrefixCollection get_Prefixes() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Realm() { }

	[CalledBy(Type = "ClientAPI.WebServer+<ListenRequests>d__100", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Task<HttpListenerContext> GetContextAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private HttpListenerContext GetContextFromQueue() { }

	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrivateKey), Member = "CreateFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PrivateKey))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	internal void RegisterContext(HttpListenerContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void RemoveConnection(HttpConnection cnc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context) { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	public void set_AuthenticationSchemes(AuthenticationSchemes value) { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	public void set_IgnoreWriteExceptions(bool value) { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	public void set_UnsafeConnectionNtlmAuthentication(bool value) { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	public void Start() { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "Stop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void Stop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override void System.IDisposable.Dispose() { }

	[CalledBy(Type = typeof(EndPointListener), Member = "UnbindContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "OnTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void UnregisterContext(HttpListenerContext context) { }

}

