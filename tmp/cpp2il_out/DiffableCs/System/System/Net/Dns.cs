namespace System.Net;

public static class Dns
{
	private sealed class GetHostAddressesCallback : MulticastDelegate
	{

		[CallerCount(Count = 23)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public GetHostAddressesCallback(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IPAddress[] EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IPAddress[] Invoke(string hostName) { }

	}

	private sealed class GetHostEntryIPCallback : MulticastDelegate
	{

		[CallerCount(Count = 39)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public GetHostEntryIPCallback(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(IPAddress hostAddress, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IPHostEntry EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IPHostEntry Invoke(IPAddress hostAddress) { }

	}

	private sealed class GetHostEntryNameCallback : MulticastDelegate
	{

		[CallerCount(Count = 23)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public GetHostEntryNameCallback(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IPHostEntry EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IPHostEntry Invoke(string hostName) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public static IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static IPHostEntry EndGetHostEntry(IAsyncResult asyncResult) { }

	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void Error_11001(string hostName) { }

	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[CalledBy(Type = "Manager.Network+<CreateConnection>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", "TArg1", typeof(object)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetHostByAddr_icall(string addr, out string h_name, out String[] h_aliases, out String[] h_addr_list, int hint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	[CalledBy(Type = typeof(NclUtilities), Member = "GetLocalHost", ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(NclUtilities), Member = "get_LocalAddresses", ReturnType = typeof(IPAddress[]))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(HttpListener), typeof(bool)}, ReturnType = typeof(EndPointListener))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Obsolete("Use GetHostEntry instead")]
	public static IPHostEntry GetHostByName(string hostName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetHostByName_icall(string host, out string h_name, out String[] h_aliases, out String[] h_addr_list, int hint) { }

	[CalledBy(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress[]))]
	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[CalledBy(Type = "Manager.NATHandler+<GetAllLocalAddresses>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`4<TArg1, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", "TArg1", typeof(object)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress) { }

	[CalledBy(Type = "Manager.NATHandler+<GetAllLocalAddresses>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NclUtilities), Member = "GetLocalHost", ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(NclUtilities), Member = "get_LocalAddresses", ReturnType = typeof(IPAddress[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetHostName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetHostName_icall(out string h_name) { }

	[CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(IPHostEntry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, String[] h_aliases, String[] h_addrlist) { }

}

