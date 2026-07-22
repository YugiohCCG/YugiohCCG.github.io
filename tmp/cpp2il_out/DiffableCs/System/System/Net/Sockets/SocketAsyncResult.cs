namespace System.Net.Sockets;

internal sealed class SocketAsyncResult : IOAsyncResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WaitCallback <>9__27_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <Complete>b__27_0(object state) { }

	}

	public Socket socket; //Field offset: 0x30
	public SocketOperation operation; //Field offset: 0x38
	private Exception DelayedException; //Field offset: 0x40
	public EndPoint EndPoint; //Field offset: 0x48
	public Memory<Byte> Buffer; //Field offset: 0x50
	public int Offset; //Field offset: 0x60
	public int Size; //Field offset: 0x64
	public SocketFlags SockFlags; //Field offset: 0x68
	public Socket AcceptSocket; //Field offset: 0x70
	public IPAddress[] Addresses; //Field offset: 0x78
	public int Port; //Field offset: 0x80
	public IList<ArraySegment`1<Byte>> Buffers; //Field offset: 0x88
	public bool ReuseSocket; //Field offset: 0x90
	public int CurrentAddress; //Field offset: 0x94
	public Socket AcceptedSocket; //Field offset: 0x98
	public int Total; //Field offset: 0xA0
	internal int error; //Field offset: 0xA4
	public int EndCalled; //Field offset: 0xA8

	public SocketError ErrorCode
	{
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		 get { } //Length: 131
	}

	public IntPtr Handle
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 45
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SocketAsyncResult() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void CheckIfThrowDelayedException() { }

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "CompleteDisposed", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<IPAddress[]>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOAsyncResult), Member = "set_IsCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Complete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	public void Complete(bool synch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	public void Complete(int total) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Complete(Exception e, bool synch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Complete(Exception e) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void Complete(Socket s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Complete(Socket s, int total) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	internal virtual void CompleteDisposed() { }

	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	public SocketError get_ErrorCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IntPtr get_Handle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IOAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

}

