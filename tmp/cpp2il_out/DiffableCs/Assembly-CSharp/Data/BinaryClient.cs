namespace Data;

public class BinaryClient
{
	[CompilerGenerated]
	private struct <ParsePacket>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryClient <>4__this; //Field offset: 0x20
		public Byte[] packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(P2PManager), Member = "ParseDirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryClient), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveData>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryClient <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private ValueTaskAwaiter<Int32> <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ValueTaskAwaiter`1<System.Int32>), typeof(<ReceiveData>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter`1<Int32>&), typeof(<ReceiveData>d__12&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryClient), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Byte>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Byte>), typeof(int)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(BinaryClient), Member = "ParsePacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 36)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Send>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] packet; //Field offset: 0x28
		public BinaryClient <>4__this; //Field offset: 0x30
		private ValueTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryClient), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 12)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const byte HEADER_SIZE = 4; //Field offset: 0x0
	private const ushort MAX_SIZE = 4096; //Field offset: 0x0
	private readonly Byte[] ReceiveBuffer; //Field offset: 0x10
	private readonly List<Byte> PacketBuffer; //Field offset: 0x18
	private int CurrentPacketLength; //Field offset: 0x20
	private readonly TcpClient Connection; //Field offset: 0x28
	private readonly NetworkStream Stream; //Field offset: 0x30
	private bool IsClosed; //Field offset: 0x38
	public LocalPlayer P2PPlayer; //Field offset: 0x40

	public bool Connected
	{
		[CalledBy(Type = "Game.Local.LocalGame+<Surrender>d__191", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalPlayer), Member = "get_IsConnectionAlive", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	[CalledBy(Type = "Manager.P2PManager+<ListenForConnections>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__12&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public BinaryClient(TcpClient client) { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<Disconnect>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReceiveData>d__12), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Send>d__13), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(P2PManager), Member = "OnDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryClient)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Close() { }

	[CalledBy(Type = "Game.Local.LocalGame+<Surrender>d__191", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalPlayer), Member = "get_IsConnectionAlive", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_Connected() { }

	[AsyncStateMachine(typeof(<ParsePacket>d__16))]
	[CalledBy(Type = typeof(<ReceiveData>d__12), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePacket>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePacket>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParsePacket(Byte[] packet) { }

	[AsyncStateMachine(typeof(<ReceiveData>d__12))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__12&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ReceiveData() { }

	[AsyncStateMachine(typeof(<Send>d__13))]
	[CalledBy(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Send>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Send>d__13&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Send(Byte[] packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Byte>), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool TryGetPacket(out Byte[] packet) { }

}

