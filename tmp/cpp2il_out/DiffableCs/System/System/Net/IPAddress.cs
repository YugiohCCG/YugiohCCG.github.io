namespace System.Net;

public class IPAddress
{
	private sealed class ReadOnlyIPAddress : IPAddress
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		public ReadOnlyIPAddress(long newAddress) { }

	}

	public static readonly IPAddress Any; //Field offset: 0x0
	internal const long LoopbackMask = 255; //Field offset: 0x0
	internal const int NumberOfLabels = 8; //Field offset: 0x0
	public static readonly IPAddress Loopback; //Field offset: 0x8
	public static readonly IPAddress Broadcast; //Field offset: 0x10
	public static readonly IPAddress None; //Field offset: 0x18
	public static readonly IPAddress IPv6Any; //Field offset: 0x20
	public static readonly IPAddress IPv6Loopback; //Field offset: 0x28
	public static readonly IPAddress IPv6None; //Field offset: 0x30
	private uint _addressOrScopeId; //Field offset: 0x10
	private readonly UInt16[] _numbers; //Field offset: 0x18
	private string _toString; //Field offset: 0x20
	private int _hashCode; //Field offset: 0x28

	public AddressFamily AddressFamily
	{
		[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
		[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "Create", ReturnType = "Mono.Nat.Pmp.PmpSearcher")]
		[CalledBy(Type = "Manager.NATHandler+<>c", Member = "<GetAllLocalAddresses>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Network+<>c", Member = "<CreateConnection>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "Win32FromUnicast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(UnicastIPAddressInformationCollection))]
		[CalledBy(Type = typeof(Win32UnicastIPAddressInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_UNICAST_ADDRESS)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UdpClient), Member = "IsBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UdpClient), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CallerCount(Count = 22)]
		 get { } //Length: 19
	}

	private bool IsIPv4
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 9
	}

	private bool IsIPv6
	{
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 9
	}

	private uint PrivateAddress
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		private get { } //Length: 4
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 55
	}

	private uint PrivateScopeId
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		private get { } //Length: 4
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 55
	}

	public long ScopeId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 91
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private static IPAddress() { }

	[CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public IPAddress(ReadOnlySpan<Byte> address) { }

	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "Create", ReturnType = "Mono.Nat.Pmp.PmpSearcher")]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "HandleMessageReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), "System.Byte[]", typeof(IPEndPoint), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Manager.NATHandler+<ParseSecret>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "Win32FromUnicast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(UnicastIPAddressInformationCollection))]
	[CalledBy(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(Win32UnicastIPAddressInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_UNICAST_ADDRESS)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32UnicastIPAddressInformation), Member = "PrefixLengthToSubnetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(AddressFamily)}, ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public IPAddress(Byte[] address) { }

	[CalledBy(Type = typeof(ReadOnlyIPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public IPAddress(long newAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public IPAddress(Byte[] address, long scopeid) { }

	[CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IPAddress), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public IPAddress(ReadOnlySpan<Byte> address, long scopeid) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal IPAddress(UInt16* numbers, int numbersLength, uint scopeid) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private IPAddress(UInt16[] numbers, uint scopeid) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual bool Equals(object comparand) { }

	[CalledBy(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "Create", ReturnType = "Mono.Nat.Pmp.PmpSearcher")]
	[CalledBy(Type = "Manager.NATHandler+<>c", Member = "<GetAllLocalAddresses>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Network+<>c", Member = "<CreateConnection>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "Win32FromUnicast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(UnicastIPAddressInformationCollection))]
	[CalledBy(Type = typeof(Win32UnicastIPAddressInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_UNICAST_ADDRESS)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "IsBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UdpClient), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 22)]
	public AddressFamily get_AddressFamily() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_IsIPv4() { }

	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_IsIPv6() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	private uint get_PrivateAddress() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	private uint get_PrivateScopeId() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public long get_ScopeId() { }

	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "Create", ReturnType = "Mono.Nat.Pmp.PmpSearcher")]
	[CalledBy(Type = "Manager.NATHandler+<GetSecret>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "FormatAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Byte[] GetAddressBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverter), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "System.Marvin", Member = "ComputeHash32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(ulong)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "Mono.Nat.Pmp.PortMappingMessage", Member = "Encode", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static short HostToNetworkOrder(short host) { }

	[CalledBy(Type = "Mono.Nat.Pmp.PortMappingMessage", Member = "Encode", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int HostToNetworkOrder(int host) { }

	[CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsLoopback(IPAddress address) { }

	[CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public IPAddress MapToIPv6() { }

	[CalledBy(Type = "Mono.Nat.Pmp.ResponseMessage", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "Mono.Nat.Pmp.MappingResponseMessage")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static int NetworkToHostOrder(int network) { }

	[CalledBy(Type = "Mono.Nat.Pmp.ResponseMessage", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "Mono.Nat.Pmp.MappingResponseMessage")]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "HandleMessageReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), "System.Byte[]", typeof(IPEndPoint), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static short NetworkToHostOrder(short network) { }

	[CalledBy(Type = "Mono.Nat.Upnp.GetExternalIPAddressResponseMessage", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.ResponseMessage", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Upnp.UpnpNatDevice", typeof(string)}, ReturnType = "Mono.Nat.Upnp.ResponseMessage")]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Win32IPAddressCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32IPAddressCollection), Member = "AddSubsequentlyString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32IPAddressCollection), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IPAddress Parse(string ipString) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_PrivateAddress(uint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void set_PrivateScopeId(uint value) { }

	[CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IPAddress), Member = "IsLoopback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPAddress), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static Byte[] ThrowAddressNullException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = "Manager.NATHandler+<GetExternalAddress>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress[]))]
	[CalledBy(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(HttpListener), typeof(bool)}, ReturnType = typeof(EndPointListener))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool TryParse(string ipString, out IPAddress address) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = "WriteIPv6Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteIPv4Bytes(Span<Byte> destination) { }

	[CalledBy(Type = typeof(IPAddress), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteIPv6Bytes(Span<Byte> destination) { }

}

