namespace System.Net;

internal sealed class HttpConnection
{
	private enum InputState
	{
		RequestLine = 0,
		Headers = 1,
	}

	private enum LineState
	{
		None = 0,
		CR = 1,
		LF = 2,
	}

	private static AsyncCallback onread_cb; //Field offset: 0x0
	private Socket sock; //Field offset: 0x10
	private Stream stream; //Field offset: 0x18
	private EndPointListener epl; //Field offset: 0x20
	private MemoryStream ms; //Field offset: 0x28
	private Byte[] buffer; //Field offset: 0x30
	private HttpListenerContext context; //Field offset: 0x38
	private StringBuilder current_line; //Field offset: 0x40
	private ListenerPrefix prefix; //Field offset: 0x48
	private RequestStream i_stream; //Field offset: 0x50
	private ResponseStream o_stream; //Field offset: 0x58
	private bool chunked; //Field offset: 0x60
	private int reuses; //Field offset: 0x64
	private bool context_bound; //Field offset: 0x68
	private bool secure; //Field offset: 0x69
	private X509Certificate cert; //Field offset: 0x70
	private int s_timeout; //Field offset: 0x78
	private Timer timer; //Field offset: 0x80
	private IPEndPoint local_ep; //Field offset: 0x88
	private HttpListener last_listener; //Field offset: 0x90
	private Int32[] client_cert_errors; //Field offset: 0x98
	private X509Certificate2 client_cert; //Field offset: 0xA0
	private SslStream ssl_stream; //Field offset: 0xA8
	private InputState input_state; //Field offset: 0xB0
	private LineState line_state; //Field offset: 0xB4
	private int position; //Field offset: 0xB8

	public bool IsSecure
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public IPEndPoint LocalEndPoint
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 232
	}

	public ListenerPrefix Prefix
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int Reuses
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static HttpConnection() { }

	[CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(SslStream))]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public HttpConnection(Socket sock, EndPointListener epl, bool secure, X509Certificate cert) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	private bool <.ctor>b__24_0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void BeginReadRequest() { }

	[CalledBy(Type = typeof(EndPointListener), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(EndPointListener), Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Shutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerRequest), Member = "get_KeepAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpListener), Member = "UnregisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerRequest), Member = "FlushInput", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
	[Calls(Type = typeof(HttpConnection), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal void Close(bool force_close) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "OnTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointListener), Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpConnection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void CloseSocket() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_IsSecure() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
	[CallsUnknownMethods(Count = 4)]
	public IPEndPoint get_LocalEndPoint() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Reuses() { }

	[CalledBy(Type = typeof(HttpListenerRequest), Member = "get_InputStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RequestStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChunkedInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public RequestStream GetRequestStream(bool chunked, long contentlength) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "get_OutputStream", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemoryStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ResponseStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HttpListenerResponse), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public ResponseStream GetResponseStream() { }

	[CalledBy(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(EndPointListener), typeof(bool), typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpConnection)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void OnRead(IAsyncResult ares) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpConnection), Member = "ProcessInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[Calls(Type = typeof(HttpConnection), Member = "RemoveConnection", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "RegisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "UnregisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void OnReadInternal(IAsyncResult ares) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "UnregisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnTimeout(object unused) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerRequest), Member = "SetRequestLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private bool ProcessInput(MemoryStream ms) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string ReadLine(Byte[] buffer, int offset, int len, ref int used) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EndPointListener), Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpConnection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveConnection() { }

	[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "SendError", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public void SendError(string msg, int status) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SendError() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Prefix(ListenerPrefix value) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "UnregisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Unbind() { }

}

