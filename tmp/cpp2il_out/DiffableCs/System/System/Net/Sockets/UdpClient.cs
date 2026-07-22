namespace System.Net.Sockets;

public class UdpClient : IDisposable
{
	private Socket m_ClientSocket; //Field offset: 0x10
	private bool m_Active; //Field offset: 0x18
	private Byte[] m_Buffer; //Field offset: 0x20
	private AddressFamily m_Family; //Field offset: 0x28
	private bool m_CleanedUp; //Field offset: 0x2C
	private bool m_IsBroadcast; //Field offset: 0x2D

	public Socket Client
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UdpClient() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public UdpClient(AddressFamily family) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AddressFamily)}, ReturnType = typeof(void))]
	public UdpClient(int port) { }

	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public UdpClient(int port, AddressFamily family) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "Create", ReturnType = "Mono.Nat.Pmp.PmpSearcher")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public UdpClient(IPEndPoint localEP) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private IAsyncResult <ReceiveAsync>b__65_0(AsyncCallback callback, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[CompilerGenerated]
	private UdpReceiveResult <ReceiveAsync>b__65_1(IAsyncResult ar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "BeginSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public IAsyncResult BeginSend(Byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForBroadcast(IPAddress ipAddress) { }

	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AddressFamily)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void createClientSocket() { }

	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(UdpClient), Member = "<ReceiveAsync>b__65_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(UdpReceiveResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public int EndSend(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FreeResources() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Socket get_Client() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsBroadcast(IPAddress address) { }

	[CalledBy(Type = "Mono.Nat.Searcher+<ListenOneAsync>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<ReceiveMessageAsync>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Net.Sockets.UdpReceiveResult>), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Net.Sockets.UdpReceiveResult>), typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Sockets.UdpReceiveResult>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Task<UdpReceiveResult> ReceiveAsync() { }

	[CalledBy(Type = "Mono.Nat.SocketGroup+<SendAsync>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(System.Func`6<System.Object, System.Int32, System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory`1), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2", "TArg3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`6<TArg1, TArg2, TArg3, AsyncCallback, Object, IAsyncResult>", "System.Func`2<IAsyncResult, TResult>", "TArg1", "TArg2", "TArg3", typeof(object)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Task<Int32> SendAsync(Byte[] datagram, int bytes, IPEndPoint endPoint) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Client(Socket value) { }

}

