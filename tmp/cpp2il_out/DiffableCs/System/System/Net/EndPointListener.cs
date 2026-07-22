namespace System.Net;

internal sealed class EndPointListener
{
	private HttpListener listener; //Field offset: 0x10
	private IPEndPoint endpoint; //Field offset: 0x18
	private Socket sock; //Field offset: 0x20
	private Hashtable prefixes; //Field offset: 0x28
	private ArrayList unhandled; //Field offset: 0x30
	private ArrayList all; //Field offset: 0x38
	private X509Certificate cert; //Field offset: 0x40
	private bool secure; //Field offset: 0x48
	private Dictionary<HttpConnection, HttpConnection> unregistered; //Field offset: 0x50

	internal HttpListener Listener
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(HttpListener), typeof(bool)}, ReturnType = typeof(EndPointListener))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = "LoadCertificateAndKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncEventArgs), Member = "add_Completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(SocketAsyncEventArgs), typeof(Socket&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public EndPointListener(HttpListener listener, IPAddress addr, int port, bool secure) { }

	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void Accept(Socket socket, SocketAsyncEventArgs e, ref Socket accepted) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointListener), Member = "AddSpecial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(ListenerPrefix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	public void AddPrefix(ListenerPrefix prefix, HttpListener listener) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "AddPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListenerPrefix), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void AddSpecial(ArrayList coll, ListenerPrefix prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[CallsUnknownMethods(Count = 3)]
	public bool BindContext(HttpListenerContext context) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "RemovePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListenerPrefix), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EndPointManager), Member = "RemoveEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPointListener), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckIfRemove() { }

	[CalledBy(Type = typeof(EndPointManager), Member = "RemoveEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPointListener), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void Close() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal HttpListener get_Listener() { }

	[CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private HttpListener MatchFromList(string host, string path, ArrayList list, out ListenerPrefix prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	private static void OnAccept(object sender, SocketAsyncEventArgs e) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(SocketAsyncEventArgs), typeof(Socket&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "OnAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(SocketAsyncEventArgs), typeof(Socket&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(EndPointListener), typeof(bool), typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ProcessAccept(SocketAsyncEventArgs args) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "RemoveConnection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void RemoveConnection(HttpConnection conn) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EndPointListener), Member = "CheckIfRemove", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 9)]
	public void RemovePrefix(ListenerPrefix prefix, HttpListener listener) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private bool RemoveSpecial(ArrayList coll, ListenerPrefix prefix) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "BindContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(WebUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EndPointListener), Member = "MatchFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(ArrayList), typeof(ListenerPrefix&)}, ReturnType = typeof(HttpListener))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private HttpListener SearchListener(Uri uri, out ListenerPrefix prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "UnregisterContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UnbindContext(HttpListenerContext context) { }

}

