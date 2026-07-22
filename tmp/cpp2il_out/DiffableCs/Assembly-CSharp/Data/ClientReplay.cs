namespace Data;

public class ClientReplay : ISerializable
{
	[CompilerGenerated]
	private struct <BuildReplaySharing>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientReplay <>4__this; //Field offset: 0x20
		private MemoryStream <packetMemory>5__2; //Field offset: 0x28
		private BinaryWriter <packet>5__3; //Field offset: 0x30
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 20)]
		[CallsUnknownMethods(Count = 50)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportCode>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string replayName; //Field offset: 0x20
		private string <result>5__2; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly List<GameMessage> IgnoredMessages; //Field offset: 0x0
	public const string LAST_DUEL_REPLAY_NAME = "_Last_Duel_Replay"; //Field offset: 0x0
	private static readonly List<GameMessage> FFRWIgnoredMessages; //Field offset: 0x8
	public static bool ReplaySharingEnabled; //Field offset: 0x10
	public static bool AutoSaveReplay; //Field offset: 0x11
	public static Byte[] ReplaySharingBuffer; //Field offset: 0x18
	public static ClientReplay ReplaySharingInstance; //Field offset: 0x20
	public RoomData GameRoom; //Field offset: 0x10
	public Deck[] Decks; //Field offset: 0x18
	public List<Byte[]> GameMessages; //Field offset: 0x20
	public List<Byte[]> SharedGameMessages; //Field offset: 0x28
	public PlayerCustomization[] PlayedPlayersRarities; //Field offset: 0x30

	public bool HasSharedData
	{
		[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "get_CanSwapPerspective", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DuelZone), Member = "SwapPerspective", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		 get { } //Length: 73
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static ClientReplay() { }

	[CalledBy(Type = typeof(DuelManager), Member = "InitializeReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientReplay), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "GetMyIndex", ReturnType = typeof(byte))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayedPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public ClientReplay(RoomData gameRoom) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RoomData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(User), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(User), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 47)]
	public ClientReplay(SerializationInfo info, StreamingContext context) { }

	[AsyncStateMachine(typeof(<BuildReplaySharing>d__17))]
	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BuildReplaySharing>d__17)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BuildReplaySharing>d__17&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task BuildReplaySharing() { }

	[AsyncStateMachine(typeof(<ExportCode>d__16))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<OnClickExport>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportSingleReplay>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportCode>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportCode>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> ExportCode(string replayName) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "get_CanSwapPerspective", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DuelZone), Member = "SwapPerspective", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	public bool get_HasSharedData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "GetHashSync", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayedPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Deck), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomData), Member = "IsPlayedTAGAlly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void ReceiveReplaySharing(BinaryReader packet, long senderId) { }

	[CalledBy(Type = "Game.DuelManager+<OnPacket>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ShouldRecord(GameMessage msg, BinaryReader packet) { }

	[CalledBy(Type = "Game.DuelManager+<OnPacket>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldStopFFRW(GameMessage msg) { }

}

