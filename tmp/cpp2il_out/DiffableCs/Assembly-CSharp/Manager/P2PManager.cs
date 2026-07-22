namespace Manager;

[Extension]
public static class P2PManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__57_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <OnNetworkPacket>b__57_0() { }

	}

	[CompilerGenerated]
	private struct <CloseConnectionEntirely>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<DisconnectP2P>d__27"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisconnectP2P>d__27&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<StopListener>d__14"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StopListener>d__14&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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
	private struct <ConnectP2P>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string address; //Field offset: 0x20
		public int port; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(TcpClient), Member = "ConnectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectToHosting>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string ip; //Field offset: 0x20
		public int port; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Boolean>), typeof(<ConnectToHosting>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Boolean>&), typeof(<ConnectToHosting>d__8&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "CloseConnectionEntirely", ReturnType = typeof(Task))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Packet), Member = "MakeLocalAuthPacket", ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<ReceiveData>d__25"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__25&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<ConnectP2P>d__15"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectP2P>d__15&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "SendCtosDirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisconnectP2P>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private ValueTaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter), typeof(<DisconnectP2P>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter&), typeof(<DisconnectP2P>d__27&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainMenu), Member = "ToMainMenu", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FixedUpdateTick>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(P2PManager), Member = "get_ConnectionReady", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<SendDirectPacket>d__49"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendDirectPacket>d__49&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDeckHash>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary<Deck, String> hashes; //Field offset: 0x20
		public Deck d; //Field offset: 0x28
		private Dictionary<Deck, String> <>7__wrap1; //Field offset: 0x30
		private Deck <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "GetHash", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListenForConnections>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<TcpClient> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TcpListener), Member = "AcceptTcpClientAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Sockets.TcpClient>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(BinaryClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<RegisterClient>d__32"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RegisterClient>d__32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDisconnected>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryClient bc; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<UnregisterClient>d__33"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnregisterClient>d__33&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnNetworkPacket>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] data; //Field offset: 0x28
		public long userId; //Field offset: 0x30
		public Player sender; //Field offset: 0x38
		public C2CMode method; //Field offset: 0x40
		private MemoryStream <ms>5__2; //Field offset: 0x48
		private BinaryReader <packet>5__3; //Field offset: 0x50
		private object <>7__wrap3; //Field offset: 0x58
		private int <>7__wrap4; //Field offset: 0x60
		private long <>7__wrap5; //Field offset: 0x68
		private Player <>7__wrap6; //Field offset: 0x70
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80
		private TaskAwaiter<Banlist> <>u__3; //Field offset: 0x88
		private ValueTaskAwaiter <>u__4; //Field offset: 0x90

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RoomData), Member = "get_IsCustomBanlist", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "BsonDeserializeAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
		[Calls(Type = typeof(Player), Member = "get_CanDisplayMyInfo", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Player), Member = "SetCanDisplayInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "OnNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Player), typeof(Byte[]), typeof(C2CMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter), typeof(<OnNetworkPacket>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter&), typeof(<OnNetworkPacket>d__57&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(Player), Member = "ParseRarities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(User), Member = "get_HasRarities", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientReplay), Member = "ReceiveReplaySharing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "ReadToEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PackedBinaryData), Member = "DecompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long), typeof(C2CMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MousePositionDebug), Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 21)]
		[CallsUnknownMethods(Count = 84)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseDirectPacket>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] data; //Field offset: 0x20
		public BinaryClient sender; //Field offset: 0x28
		private MemoryStream <ms>5__2; //Field offset: 0x30
		private BinaryReader <packet>5__3; //Field offset: 0x38
		private object <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<ReceiveSyncPacket>d__42"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveSyncPacket>d__42&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+<ParseLocalCtos>d__43"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalCtos>d__43&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 36)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseLocalCtos>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryClient sender; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalPlayer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryClient)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseLocalStoc>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] data; //Field offset: 0x20
		private MemoryStream <ms>5__2; //Field offset: 0x28
		private BinaryReader <packet>5__3; //Field offset: 0x30
		private object <>7__wrap3; //Field offset: 0x38
		private int <>7__wrap4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<Byte[]> <>u__2; //Field offset: 0x50
		private ValueTaskAwaiter <>u__3; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Packet), Member = "MakeLocalCreateGame", ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(P2PManager), Member = "SendCtosDirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BotCore), Member = "HandleMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnUpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "OnRelayNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PackedBinaryData), Member = "DecompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalStoc>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalStoc>d__45&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<ParseLocalStoc>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<ParseLocalStoc>d__45&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnChooseBoss", ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "SetLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ReceiveTimeLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
		[Calls(Type = typeof(GameRoom), Member = "UpdateRoomRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "ReadUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Network), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(UserRank), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "MakeLocalJoinGame", ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Player), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "ReadToEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Network), Member = "OnGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnErrorMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnSelectHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnSelectTp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnHandResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Packet), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Network), Member = "OnChangeSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Deck)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnWaitingSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnJoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(P2PManager), Member = "CloseConnectionEntirely", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnDuelStart", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnDuelEnd", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "OnReceiveServerReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnTimeLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalExt), Member = "ReadLocalUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(User))]
		[Calls(Type = typeof(Network), Member = "OnHsPlayerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "OnHsWatchChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Network), Member = "OnTypeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 65)]
		[CallsUnknownMethods(Count = 89)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveData>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private int <readSize>5__2; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x2C
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Byte>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "TryGetPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(P2PManager), Member = "get_ConnectionReady", ReturnType = typeof(bool))]
		[Calls(Type = typeof(P2PManager), Member = "ParseLocalStoc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(P2PManager), Member = "CloseConnectionEntirely", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveSyncPacket>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "Manager.P2PManager+DeckSyncRcv", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = "Manager.P2PManager+DeckSyncRcv", Member = "RegisterDeck", ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Manager), Member = "AddFavoriteCardWithoutSaving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Customization), Member = "SavePlayerData", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InfoBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegisterClient>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryClient client; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCtosDirectPacket>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryWriter packet; //Field offset: 0x28
		private Byte[] <data>5__2; //Field offset: 0x30
		private ValueTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(P2PManager), Member = "SendCtosDirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCtosDirectPacket>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalExt), Member = "AddDirectHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(DirectMessage)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(P2PManager), Member = "SendDirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendDirectPacket>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] packet; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private int <>7__wrap1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(P2PManager), Member = "get_ConnectionReady", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "CloseConnectionEntirely", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendNetworkPacket>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryWriter packet; //Field offset: 0x20
		public long userId; //Field offset: 0x28
		public C2CMode preferedMethod; //Field offset: 0x30
		private Byte[] <data>5__2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long), typeof(C2CMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendRelayPacket>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public long userId; //Field offset: 0x28
		public Byte[] packet; //Field offset: 0x30
		private BinaryWriter <pkt>5__2; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendSyncPacket>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private MemoryStream <ms>5__2; //Field offset: 0x20
		private BinaryWriter <packet>5__3; //Field offset: 0x28
		private object <>7__wrap3; //Field offset: 0x30
		private int <>7__wrap4; //Field offset: 0x38
		private object <>7__wrap5; //Field offset: 0x40
		private int <>7__wrap6; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "WriteAllFullDecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(P2PManager), Member = "WriteFavoriteList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "SendDirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 35)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartHostingLocally>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x20
		private TaskAwaiter <>u__2; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(P2PManager), Member = "StartListener", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "ConnectToHosting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(P2PManager), Member = "CloseConnectionEntirely", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartListener>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TcpListener), Member = "Start", ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "ListenForConnections", ReturnType = typeof(void))]
		[Calls(Type = typeof(NATHandler), Member = "CreateMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Boolean>), typeof(<StartListener>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Boolean>&), typeof(<StartListener>d__13&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StopListener>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(NATHandler), Member = "ClearDeviceMap", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnregisterClient>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryClient client; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAllFullDecks>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryWriter packet; //Field offset: 0x20
		private Dictionary<Deck, String> <hashes>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "WriteFullDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(P2PManager), Member = "GetDeckHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(System.Collections.Generic.Dictionary`2<Card.Deck, System.String>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct DeckSyncRcv
	{
		[CompilerGenerated]
		private struct <RegisterDeck>d__5 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public DeckSyncRcv <>4__this; //Field offset: 0x20
			private TaskAwaiter<Deck> <>u__1; //Field offset: 0x40

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Deck), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.Deck>))]
			[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[Calls(Type = typeof(Deck), Member = "set_Tags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(Deck), Member = "AddRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rarity), typeof(bool)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
			[Calls(Type = typeof(Manager), Member = "AddDeckWithoutSaving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Deck)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 7)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public string Hash; //Field offset: 0x0
		public string Name; //Field offset: 0x8
		public string Tags; //Field offset: 0x10
		public Dictionary<Int32, Byte> Rarities; //Field offset: 0x18

		[CalledBy(Type = "Manager.P2PManager+<ReceiveSyncPacket>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Packet), Member = "ReadASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Packet), Member = "ReadUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		public DeckSyncRcv(BinaryReader packet) { }

		[AsyncStateMachine(typeof(<RegisterDeck>d__5))]
		[CalledBy(Type = "Manager.P2PManager+<ReceiveSyncPacket>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.P2PManager+DeckSyncRcv+<RegisterDeck>d__5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RegisterDeck>d__5&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Task RegisterDeck() { }

	}

	[CompilerGenerated]
	private static P2PAction <CurrentAction>k__BackingField; //Field offset: 0x0
	public const int MAX_SIZE = 4096; //Field offset: 0x0
	public const byte HEADER_SIZE = 4; //Field offset: 0x0
	public const float BEAT_TIMER = 10; //Field offset: 0x0
	public const string LOCALHOST = "127.0.0.1"; //Field offset: 0x0
	public const int HOSTING_PORT = 19997; //Field offset: 0x0
	private const long MAX_VIP_SYNC_PACKET_SIZE = 786432; //Field offset: 0x0
	private static TcpListener Listener; //Field offset: 0x8
	private static readonly Byte[] ReceiveBuffer; //Field offset: 0x10
	private static float HeartbeatTimer; //Field offset: 0x18
	private static readonly object HeartbeatSync; //Field offset: 0x20
	private static readonly Byte[] HeartbeatPacket; //Field offset: 0x28
	private static readonly List<Byte> PacketBuffer; //Field offset: 0x30
	private static int CurrentPacketLength; //Field offset: 0x38
	private static TcpClient P2PConnection; //Field offset: 0x40
	private static NetworkStream P2PStream; //Field offset: 0x48
	private static readonly List<BinaryClient> Clients; //Field offset: 0x50
	private static readonly SemaphoreSlim ConSem; //Field offset: 0x58

	public static bool ConnectionReady
	{
		[CalledBy(Type = "Manager.Network+<Send>d__47", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Network), Member = "get_IsLocalConnected", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(<FixedUpdateTick>d__44), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<ReceiveData>d__25), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<SendDirectPacket>d__49), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 134
	}

	public static P2PAction CurrentAction
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private static P2PManager() { }

	[AsyncStateMachine(typeof(<CloseConnectionEntirely>d__9))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<<OnClickLocal>g__showMainSelector|33_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ConnectToHosting>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseLocalStoc>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReceiveData>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendDirectPacket>d__49), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<StartHostingLocally>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseConnectionEntirely>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseConnectionEntirely>d__9&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task CloseConnectionEntirely() { }

	[AsyncStateMachine(typeof(<ConnectP2P>d__15))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass52_0+<<DeckSync>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectP2P>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectP2P>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Boolean> ConnectP2P(string address, int port = 19997) { }

	[AsyncStateMachine(typeof(<ConnectToHosting>d__8))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<<OnClickLocal>b__33_2>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<StartHostingLocally>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectToHosting>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectToHosting>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Boolean> ConnectToHosting(string ip, int port = 19997) { }

	[AsyncStateMachine(typeof(<DisconnectP2P>d__27))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisconnectP2P>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisconnectP2P>d__27&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task DisconnectP2P() { }

	[AsyncStateMachine(typeof(<FixedUpdateTick>d__44))]
	[CalledBy(Type = typeof(Helper), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixedUpdateTick>d__44)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixedUpdateTick>d__44&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void FixedUpdateTick() { }

	[CalledBy(Type = "Manager.Network+<Send>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "get_IsLocalConnected", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<FixedUpdateTick>d__44), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReceiveData>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendDirectPacket>d__49), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_ConnectionReady() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static P2PAction get_CurrentAction() { }

	[AsyncStateMachine(typeof(<GetDeckHash>d__37))]
	[CalledBy(Type = typeof(<WriteAllFullDecks>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetDeckHash>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetDeckHash>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task GetDeckHash(Deck d, Dictionary<Deck, String> hashes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 2)]
	public static Player GetSenderByID(long userId) { }

	[AsyncStateMachine(typeof(<ListenForConnections>d__34))]
	[CalledBy(Type = typeof(<StartListener>d__13), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenForConnections>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenForConnections>d__34&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void ListenForConnections() { }

	[AsyncStateMachine(typeof(<OnDisconnected>d__35))]
	[CalledBy(Type = typeof(BinaryClient), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDisconnected>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDisconnected>d__35&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void OnDisconnected(BinaryClient bc) { }

	[AsyncStateMachine(typeof(<OnNetworkPacket>d__57))]
	[CalledBy(Type = typeof(<OnNetworkPacket>d__57), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(P2PManager), Member = "OnRelayNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNetworkPacket>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNetworkPacket>d__57&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void OnNetworkPacket(long userId, Player sender, Byte[] data, C2CMode method) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseLocalStoc>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Packet), Member = "ReadToEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(P2PManager), Member = "OnNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Player), typeof(Byte[]), typeof(C2CMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnRelayNetworkPacket(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<ParseDirectPacket>d__46))]
	[CalledBy(Type = "Data.BinaryClient+<ParsePacket>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseDirectPacket>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseDirectPacket>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task ParseDirectPacket(BinaryClient sender, Byte[] data) { }

	[AsyncStateMachine(typeof(<ParseLocalCtos>d__43))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalCtos>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalCtos>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task ParseLocalCtos(BinaryClient sender, BinaryReader packet) { }

	[AsyncStateMachine(typeof(<ParseLocalStoc>d__45))]
	[CalledBy(Type = typeof(<ReceiveData>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalStoc>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseLocalStoc>d__45&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task ParseLocalStoc(Byte[] data) { }

	[AsyncStateMachine(typeof(<ReceiveData>d__25))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__25)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveData>d__25&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ReceiveData() { }

	[AsyncStateMachine(typeof(<ReceiveSyncPacket>d__42))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveSyncPacket>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveSyncPacket>d__42&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task ReceiveSyncPacket(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<RegisterClient>d__32))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RegisterClient>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RegisterClient>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task RegisterClient(BinaryClient client) { }

	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long), typeof(C2CMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void RequestUserInfo(Int64[] ids) { }

	[AsyncStateMachine(typeof(<SendCtosDirectPacket>d__47))]
	[CalledBy(Type = typeof(<ConnectToHosting>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseLocalStoc>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendCtosDirectPacket>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendCtosDirectPacket>d__47&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SendCtosDirectPacket(BinaryWriter packet) { }

	[AsyncStateMachine(typeof(<SendCtosDirectPacket>d__48))]
	[CalledBy(Type = typeof(<SendCtosDirectPacket>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendCtosDirectPacket>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendCtosDirectPacket>d__48&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SendCtosDirectPacket(Byte[] packet) { }

	[AsyncStateMachine(typeof(<SendDirectPacket>d__49))]
	[CalledBy(Type = typeof(<SendCtosDirectPacket>d__48), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendSyncPacket>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendDirectPacket>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendDirectPacket>d__49&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task SendDirectPacket(Byte[] packet) { }

	[AsyncStateMachine(typeof(<SendNetworkPacket>d__50))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<RequestC2CData>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendNetworkPacket>d__50)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendNetworkPacket>d__50&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task SendNetworkPacket(BinaryWriter packet, long userId, C2CMode preferedMethod = 1) { }

	[CalledBy(Type = typeof(Player), Member = "set_SafeOpt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "OnChangeDisplayMyInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long), typeof(C2CMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SendNetworkPacket(Byte[] packet, C2CMode preferedMethod = 1, Int64[] ids) { }

	[CalledBy(Type = typeof(<OnNetworkPacket>d__57), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendNetworkPacket>d__50), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(P2PManager), Member = "RequestUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(C2CMode), typeof(Int64[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendRelayPacket>d__52)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendRelayPacket>d__52&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SendNetworkPacket(Byte[] packet, long userId, C2CMode preferedMethod = 1) { }

	[AsyncStateMachine(typeof(<SendRelayPacket>d__52))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendRelayPacket>d__52)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendRelayPacket>d__52&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SendRelayPacket(Byte[] packet, long userId) { }

	[AsyncStateMachine(typeof(<SendSyncPacket>d__40))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass52_0+<<DeckSync>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendSyncPacket>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendSyncPacket>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task SendSyncPacket() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_CurrentAction(P2PAction value) { }

	[AsyncStateMachine(typeof(<StartHostingLocally>d__7))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<<OnClickLocal>b__33_1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnTestRoom>d__340", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartHostingLocally>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartHostingLocally>d__7&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<Boolean> StartHostingLocally() { }

	[AsyncStateMachine(typeof(<StartListener>d__13))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<StartHostingLocally>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartListener>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartListener>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<Boolean> StartListener() { }

	[AsyncStateMachine(typeof(<StopListener>d__14))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StopListener>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StopListener>d__14&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void StopListener() { }

	[CalledBy(Type = typeof(<ReceiveData>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Byte>), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static bool TryGetPacket(out Byte[] packet) { }

	[AsyncStateMachine(typeof(<UnregisterClient>d__33))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnregisterClient>d__33)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnregisterClient>d__33&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task UnregisterClient(BinaryClient client) { }

	[AsyncStateMachine(typeof(<WriteAllFullDecks>d__38))]
	[CalledBy(Type = typeof(<SendSyncPacket>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllFullDecks>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllFullDecks>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	private static Task WriteAllFullDecks(BinaryWriter packet) { }

	[CalledBy(Type = typeof(<SendSyncPacket>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	private static void WriteFavoriteList(BinaryWriter packet) { }

	[CalledBy(Type = typeof(<WriteAllFullDecks>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_Tags", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	private static void WriteFullDeck(BinaryWriter packet, Deck d, string hash) { }

}

