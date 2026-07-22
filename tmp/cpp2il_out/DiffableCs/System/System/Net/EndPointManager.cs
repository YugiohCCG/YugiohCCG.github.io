namespace System.Net;

internal sealed class EndPointManager
{
	private static Hashtable ip_to_endpoints; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static EndPointManager() { }

	[CalledBy(Type = typeof(HttpListener), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerPrefixCollection), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.String>))]
	[Calls(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "RemovePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	public static void AddListener(HttpListener listener) { }

	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AddPrefix(string prefix, HttpListener listener) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointManager), Member = "AddPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListenerPrefix), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(HttpListener), typeof(bool)}, ReturnType = typeof(EndPointListener))]
	[Calls(Type = typeof(EndPointListener), Member = "AddPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListenerPrefix), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private static void AddPrefixInternal(string p, HttpListener listener) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private static EndPointListener GetEPListener(string host, int port, HttpListener listener, bool secure) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "CheckIfRemove", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointListener), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep) { }

	[CalledBy(Type = typeof(HttpListener), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerPrefixCollection), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.String>))]
	[Calls(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void RemoveListener(HttpListener listener) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemovePrefix(string prefix, HttpListener listener) { }

	[CalledBy(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListenerPrefix), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(HttpListener), typeof(bool)}, ReturnType = typeof(EndPointListener))]
	[Calls(Type = typeof(EndPointListener), Member = "RemovePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListenerPrefix), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void RemovePrefixInternal(string prefix, HttpListener listener) { }

}

