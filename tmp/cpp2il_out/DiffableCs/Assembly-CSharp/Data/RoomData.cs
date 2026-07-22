namespace Data;

public class RoomData : IPooledData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Player, Boolean> <>9__25_0; //Field offset: 0x8
		public static Func<Player, Boolean> <>9__27_0; //Field offset: 0x10
		public static Func<Player, Int64> <>9__89_0; //Field offset: 0x18
		public static Func<Player, Boolean> <>9__99_0; //Field offset: 0x20
		public static Func<Player, Boolean> <>9__103_0; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_BotCount>b__27_0(Player p) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_HasBot>b__25_0(Player p) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_IsFull>b__99_0(Player p) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_PlayerCount>b__103_0(Player p) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal long <GetAllLobbyIds>b__89_0(Player p) { }

	}

	[CompilerGenerated]
	private struct <GenPwd>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public RoomData <>4__this; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private string <>7__wrap3; //Field offset: 0x40
		private ValueTaskAwaiter <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameSettings), Member = "ToUInt64", ReturnType = typeof(ulong))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(NATHandler), Member = "GetSecret", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Setup>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RoomData> <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public RoomData <>4__this; //Field offset: 0x28
		public bool list; //Field offset: 0x30
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "InitializePlayers", ReturnType = typeof(void))]
		[Calls(Type = typeof(DiscordController), Member = "GetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Packet), Member = "ReadASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Packet), Member = "ReadUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Banlist), Member = "CreateBanlistPacket", ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BinaryExtensions), Member = "ReadRoomData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(RoomData)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 20)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly List<RoomData> RoomList; //Field offset: 0x0
	public const byte DEF_DL_SH = 4; //Field offset: 0x0
	public const short DEF_T = 180; //Field offset: 0x0
	public const byte DEF_DC = 1; //Field offset: 0x0
	public const ushort DEF_DL_LP = 4000; //Field offset: 0x0
	public const ushort DEF_LP = 8000; //Field offset: 0x0
	public const byte DEF_SH = 5; //Field offset: 0x0
	public static readonly Dictionary<DuelRules, List`1<String>> BotDecks; //Field offset: 0x8
	public static RoomData CurrentRoom; //Field offset: 0x10
	public bool IsReplay; //Field offset: 0x10
	public bool IsTestRoom; //Field offset: 0x11
	public int RoomID; //Field offset: 0x14
	public Banlist Banlist; //Field offset: 0x18
	public uint LFListHash; //Field offset: 0x20
	private bool _customBanlistLoaded; //Field offset: 0x24
	public short ElapsedThreshold; //Field offset: 0x26
	public byte TickMultiplier; //Field offset: 0x28
	public bool EOMPEnabled; //Field offset: 0x29
	public ushort EOMPTime; //Field offset: 0x2A
	public DateTime EOMPStart; //Field offset: 0x30
	public long HostID; //Field offset: 0x38
	public GameState State; //Field offset: 0x40
	public bool IsRanked; //Field offset: 0x44
	public bool IsTournament; //Field offset: 0x45
	public string HostName; //Field offset: 0x48
	public string HostAvatar; //Field offset: 0x50
	public string EnemyName; //Field offset: 0x58
	public float HostRating; //Field offset: 0x60
	public float EnemyRating; //Field offset: 0x64
	public ushort SpectatorCount; //Field offset: 0x68
	public Player[] Players; //Field offset: 0x70
	public Boolean[] Locked; //Field offset: 0x78
	public Int64[] PlayedPlayers; //Field offset: 0x80
	public byte DuelCount; //Field offset: 0x88
	public SByte[] Winner; //Field offset: 0x90
	public byte PlayerAmount; //Field offset: 0x98
	public GameSettings Info; //Field offset: 0xA0
	public Byte[] CustomBanlistDataPacket; //Field offset: 0xE0

	public byte BotCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 273
	}

	public byte DrawCount
	{
		[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 8
	}

	public DuelRules DuelRule
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public double EOMPTimeLeft
	{
		[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 183
	}

	public ExtraRules ExtraRule
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ulong GameData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Packet), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(byte)}, ReturnType = typeof(ulong))]
		 get { } //Length: 55
	}

	public bool HasBot
	{
		[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 273
	}

	public static bool HasPwd
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Network), Member = "get_ConnectionIsReady", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 297
	}

	public bool IsCustom
	{
		[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameSettings), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 188
	}

	public bool IsCustomBanlist
	{
		[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	public bool IsFull
	{
		[CalledBy(Type = typeof(GameRoom), Member = "OnClickSpectate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BotCore), Member = "CreateBot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 276
	}

	public bool IsManual
	{
		[CallerCount(Count = 52)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsMatch
	{
		[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsRelay
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsSingle
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsTag
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsTeam
	{
		[CalledBy(Type = typeof(GameRoom), Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameRoom), Member = "SetupRoomForRules", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameRoom), Member = "TapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Janken), Member = "LoadPlayers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Duel), Member = "IsOpponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DuelManager), Member = "CalculateWinner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public bool Joinable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 302
	}

	public byte MasterRule
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public DuelMode Mode
	{
		[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 8
	}

	public bool NoShuffleDeck
	{
		[CalledBy(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameSettings), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
		 get { } //Length: 77
	}

	public byte PlayedBotCount
	{
		[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 148
	}

	public byte PlayerCount
	{
		[CalledBy(Type = "Manager.DiscordController+<UpdateRichPresence>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 273
	}

	public CardSet Region
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string RuleString
	{
		[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		 get { } //Length: 89
	}

	public int SortOrder
	{
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c", Member = "<UpdateRoomList>b__104_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(int))]
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c", Member = "<SpectateRandomRoom>b__132_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 738
	}

	public bool Started
	{
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public byte StartHand
	{
		[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 8
	}

	public int StartLp
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public short Timer
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static RoomData() { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RoomData() { }

	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomData), Member = "InitializePlayers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RoomData(GameSettings gameData) { }

	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(byte)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(RoomData), Member = "InitializePlayers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public RoomData(ulong gameData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Setup>b__115_0(string name) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c__DisplayClass124_0", Member = "<OnTryEnterSeletedRoom>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameSettings), Member = "ToUInt64", ReturnType = typeof(ulong))]
	[ContainsUnimplementedInstructions]
	public bool CheckPwd(ValueTuple<Int32, UInt64> pwd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "GetPwd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.UInt64>))]
	[Calls(Type = typeof(GameSettings), Member = "ToUInt64", ReturnType = typeof(ulong))]
	[ContainsUnimplementedInstructions]
	public bool CheckPwd(string pwd) { }

	[AsyncStateMachine(typeof(<GenPwd>d__12))]
	[CalledBy(Type = "Scenes.General.ChatWindow+<OnClickRoomPwd>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.DiscordController+<UpdateRichPresence>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GenPwd>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GenPwd>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task<String> GenPwd() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public byte get_BotCount() { }

	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public byte get_DrawCount() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public DuelRules get_DuelRule() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public double get_EOMPTimeLeft() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public ExtraRules get_ExtraRule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Packet), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(byte)}, ReturnType = typeof(ulong))]
	public ulong get_GameData() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_HasBot() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Network), Member = "get_ConnectionIsReady", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_HasPwd() { }

	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameSettings), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public bool get_IsCustom() { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsCustomBanlist() { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnClickSpectate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotCore), Member = "CreateBot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsFull() { }

	[CallerCount(Count = 52)]
	[ContainsUnimplementedInstructions]
	public bool get_IsManual() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool get_IsMatch() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsRelay() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsSingle() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsTag() { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "SetupRoomForRules", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "TapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Janken), Member = "LoadPlayers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Duel), Member = "IsOpponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DuelManager), Member = "CalculateWinner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool get_IsTeam() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_Joinable() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public byte get_MasterRule() { }

	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public DuelMode get_Mode() { }

	[CalledBy(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameSettings), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
	public bool get_NoShuffleDeck() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public byte get_PlayedBotCount() { }

	[CalledBy(Type = "Manager.DiscordController+<UpdateRichPresence>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public byte get_PlayerCount() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public CardSet get_Region() { }

	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	public string get_RuleString() { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c", Member = "<UpdateRoomList>b__104_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c", Member = "<SpectateRandomRoom>b__132_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public int get_SortOrder() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_Started() { }

	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public byte get_StartHand() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_StartLp() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public short get_Timer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int64>)}, ReturnType = typeof(Int64[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Int64[] GetAllLobbyIds() { }

	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelManager), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	public sbyte GetFirstIndexOfTeam(sbyte team, bool allowBot) { }

	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelManager), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	public Player GetFirstPlayerOfTeam(sbyte team, bool allowBot) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<UpdateDiscordPresence>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "UpdateDiscordPresence", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "GetCardSetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
	public string GetFormatString() { }

	[CalledBy(Type = typeof(ClientReplay), Member = "ReceiveReplaySharing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public byte GetIndexOfPlayedPlayer(long id) { }

	[CalledBy(Type = typeof(LogManager), Member = "GetPlayerColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DiscordController), Member = "IsMessageBlocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(P2PManager), Member = "OnRelayNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(P2PManager), Member = "GetSenderByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Player))]
	[CalledBy(Type = typeof(RoomData), Member = "GetMyIndex", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(RoomData), Member = "IsTAGAlly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public byte GetIndexOfPlayer(long id) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<UpdateDiscordPresence>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "UpdateDiscordPresence", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetGameModeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelMode)}, ReturnType = typeof(string))]
	public string GetModeString() { }

	[CalledBy(Type = typeof(DuelManager), Member = "CalculateWinner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 1)]
	public byte GetMyIndex() { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c__DisplayClass124_0", Member = "<OnTryEnterSeletedRoom>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "EnterRoomByCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(RoomData), Member = "CheckPwd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PackedBinaryData), Member = "DecompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static ValueTuple<Int32, UInt64> GetPwd(string pwd) { }

	[CalledBy(Type = typeof(LogManager), Member = "GetTeamColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelManager), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	public sbyte GetTeamOfPlayer(byte pos) { }

	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Setup>d__115), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void InitializePlayers() { }

	[CalledBy(Type = typeof(GameRoom), Member = "TapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsLockedSlot(sbyte pos) { }

	[CalledBy(Type = typeof(ClientReplay), Member = "ReceiveReplaySharing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelManager), Member = "IsSameTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool IsPlayedTAGAlly(long id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(DuelManager), Member = "IsSameTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTAGAlly(long id) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "UpdateRoomList", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void OnListUpdate() { }

	[CalledBy(Type = "Scenes.Battle.DuelEnd+<Start>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetMatchResults() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_StartLp(int value) { }

	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Setup>d__115), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	public void SetEOMP(DateTime start) { }

	[CalledBy(Type = typeof(<Setup>d__115), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void SetEOMP(ushort eomp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public void SetEOMP(ushort eomp, DateTime start) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameRoom), Member = "SetLockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void SetLock(byte data) { }

	[AsyncStateMachine(typeof(<Setup>d__115))]
	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Setup>d__115)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Setup>d__115&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task<RoomData> Setup(BinaryReader packet, bool list) { }

	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateHost(byte pos) { }

	[CalledBy(Type = typeof(Network), Member = "OnTypeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateHost(Player host) { }

	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WasBot(byte pos) { }

}

