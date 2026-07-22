namespace System.Net.Sockets;

public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	private bool disposed; //Field offset: 0x10
	internal int in_progress; //Field offset: 0x14
	private EndPoint remote_ep; //Field offset: 0x18
	private Socket current_socket; //Field offset: 0x20
	internal SocketAsyncResult socket_async_result; //Field offset: 0x28
	[CompilerGenerated]
	private Exception <ConnectByNameError>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <DisconnectReuseSocket>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private int <SendPacketsSendSize>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private object <UserToken>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; //Field offset: 0x80
	private Memory<Byte> _buffer; //Field offset: 0x88
	private int _offset; //Field offset: 0x98
	private int _count; //Field offset: 0x9C
	private bool _bufferIsExplicitArray; //Field offset: 0xA0
	private IList<ArraySegment`1<Byte>> _bufferList; //Field offset: 0xA8
	private List<ArraySegment`1<Byte>> _bufferListInternal; //Field offset: 0xB0

	public event EventHandler<SocketAsyncEventArgs> Completed
	{
		[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public Socket AcceptSocket
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public IList<ArraySegment`1<Byte>> BufferList
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public private int BytesTransferred
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int Count
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	internal Socket CurrentSocket
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	private SocketAsyncOperation LastOperation
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public Memory<Byte> MemoryBuffer
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 14
	}

	public int Offset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public EndPoint RemoteEndPoint
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[MonoTODO("unused property")]
	public int SendPacketsSendSize
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public SocketError SocketError
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public SocketFlags SocketFlags
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public object UserToken
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public SocketAsyncEventArgs() { }

	[CalledBy(Type = "System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal SocketAsyncEventArgs(bool flowExecutionContext) { }

	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void add_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Complete_internal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Socket get_AcceptSocket() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public IList<ArraySegment`1<Byte>> get_BufferList() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_BytesTransferred() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Socket get_CurrentSocket() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Memory<Byte> get_MemoryBuffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Offset() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public SocketError get_SocketError() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_UserToken() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnCompleted(SocketAsyncEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void remove_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AcceptSocket(Socket value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BytesTransferred(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LastOperation(SocketAsyncOperation value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_RemoteEndPoint(EndPoint value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SendPacketsSendSize(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SocketError(SocketError value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SocketFlags(SocketFlags value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_UserToken(object value) { }

	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void SetBuffer(Memory<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetBytesTransferred(int value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetCurrentSocket(Socket socket) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal void SetLastOperation(SocketAsyncOperation op) { }

}

