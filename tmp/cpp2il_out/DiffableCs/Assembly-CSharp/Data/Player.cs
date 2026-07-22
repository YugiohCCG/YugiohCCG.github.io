namespace Data;

public class Player
{
	[CompilerGenerated]
	private struct <UpdateMyCustomization>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Player+<UpdateMySleeve>d__60"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMySleeve>d__60&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Player+<UpdateMyPlaymat>d__57"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyPlaymat>d__57&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Player+<UpdateMyRarities>d__55"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyRarities>d__55&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMyPlaymat>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool needPacket; //Field offset: 0x20
		private MemoryStream <pmtpktms>5__2; //Field offset: 0x28
		private BinaryWriter <pmpkt>5__3; //Field offset: 0x30
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "InitLocal", ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "GetCustomPlaymat", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(ImageConversion), Member = "EncodeToJPG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 40)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMyRarities>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private MemoryStream <pktms>5__2; //Field offset: 0x20
		private BinaryWriter <pkt>5__3; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(User), Member = "HasSeasonPass", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Player), Member = "ParseRarities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.Int32, System.Byte>), typeof(Dictionary`2<Int32, Byte>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 38)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMySleeve>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool needPacket; //Field offset: 0x20
		private MemoryStream <slvpktms>5__2; //Field offset: 0x28
		private BinaryWriter <slvpkt>5__3; //Field offset: 0x30
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "InitLocal", ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "GetCustomSleeve", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(ImageConversion), Member = "EncodeToJPG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 40)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct LastChanges
	{
		public float TCGRating; //Field offset: 0x0
		public float OCGRating; //Field offset: 0x4
		public int DP; //Field offset: 0x8
		public bool ChangedTCG; //Field offset: 0xC
		public bool ChangedOCG; //Field offset: 0xD

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public LastChanges(User before, User after) { }

		[CalledBy(Type = typeof(DuelEnd), Member = "UpdateLanguage", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public float GetRatingChange() { }

	}

	[CompilerGenerated]
	private static Player <Local>k__BackingField; //Field offset: 0x0
	private static SafeOptions _safeOpt; //Field offset: 0x8
	public static Byte[] RaritiesPacket; //Field offset: 0x10
	public static Byte[] SleevePacket; //Field offset: 0x18
	public static Byte[] PlaymatPacket; //Field offset: 0x20
	public bool IsHost; //Field offset: 0x10
	private bool _isReady; //Field offset: 0x11
	public byte Position; //Field offset: 0x12
	public bool IsObserver; //Field offset: 0x13
	private bool _canDisplayInfo; //Field offset: 0x14
	private Texture2D avatar; //Field offset: 0x18
	private bool HasAvatarLoaded; //Field offset: 0x20
	private bool HasPrivacyLoaded; //Field offset: 0x21
	[CompilerGenerated]
	private User <UserInfo>k__BackingField; //Field offset: 0x28
	public Sprite Sleeve; //Field offset: 0x30
	public Sprite Playmat; //Field offset: 0x38
	public Dictionary<Int32, Byte> Rarities; //Field offset: 0x40
	public SleeveRarity CurSleeve; //Field offset: 0x48
	public LastChanges UserDiff; //Field offset: 0x4C

	public Texture2D Avatar
	{
		[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.Janken+<>c__DisplayClass43_0", Member = "<DefinePlayer>b__0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Scenes.Lobby.Janken+<DefinePlayer>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "<MakeLPBar>b__23_0", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 186
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool CanDisplayInfo
	{
		[CalledBy(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldBG), Member = "EnablePlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Player)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldBG), Member = "EnablePlayerPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldBG), Member = "EnableOpponentPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "get_Avatar", ReturnType = typeof(Texture2D))]
		[CalledBy(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 306
	}

	public static bool CanDisplayMyInfo
	{
		[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 71
	}

	private bool HasLoadedName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 36
	}

	public long ID
	{
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public bool IsBot
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 32
	}

	public bool IsReady
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DuelEnd), Member = "GoBackToLobby", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameRoom), Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 220
	}

	public static Player Local
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 81
	}

	public static bool SafeMode
	{
		[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoomCard), Member = "<PostSetData>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 71
	}

	public static SafeOptions SafeOpt
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 54
		[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(C2CMode), typeof(Int64[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 989
	}

	public User UserInfo
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string Username
	{
		[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+UserData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoomData), Member = "UpdateHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoomData), Member = "UpdateHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "<MakeLPBar>b__23_0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateUserInfo", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.Janken+<DefinePlayer>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.Janken+<>c__DisplayClass43_0", Member = "<DefinePlayer>b__0", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(Helper), Member = "FilterStringWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ChatWindow), Member = "get_FilterName", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 222
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 35
	}

	[CalledBy(Type = typeof(Network), Member = "OnUpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "InitLocal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Player(User user) { }

	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Player(byte pos, User user, bool isReplay = false) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.Janken+<>c__DisplayClass43_0", Member = "<DefinePlayer>b__0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Lobby.Janken+<DefinePlayer>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "<MakeLPBar>b__23_0", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public Texture2D get_Avatar() { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "EnablePlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "EnablePlayerPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldBG), Member = "EnableOpponentPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "get_Avatar", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool get_CanDisplayInfo() { }

	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_CanDisplayMyInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_HasLoadedName() { }

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public long get_ID() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsBot() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsReady() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Player get_Local() { }

	[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "<PostSetData>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_SafeMode() { }

	[CallerCount(Count = 0)]
	public static SafeOptions get_SafeOpt() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public User get_UserInfo() { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.Janken+<>c__DisplayClass43_0", Member = "<DefinePlayer>b__0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Lobby.Janken+<DefinePlayer>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateUserInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "<MakeLPBar>b__23_0", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "UpdateHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "UpdateHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+UserData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ChatWindow), Member = "get_FilterName", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "FilterStringWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public string get_Username() { }

	[CalledBy(Type = typeof(<UpdateMyPlaymat>d__57), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<UpdateMySleeve>d__60), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void InitLocal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnAvatarLoaded(Texture2D t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(C2CMode), typeof(Int64[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void OnChangeDisplayMyInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnUsernameLoaded(string n) { }

	[CalledBy(Type = typeof(<UpdateMyRarities>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public static void ParseRarities(IDictionary<Int32, Byte> input, out Dictionary<Int32, Byte>& result) { }

	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void ParseRarities(BinaryReader packet) { }

	[CalledBy(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "OnUsernameLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "OnAvatarLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameRoom), Member = "SetUsername", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameRoom), Member = "SetAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Janken), Member = "DefinePlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelManager), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(LifePoints), Member = "MakeLPBar", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void RedefineData() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Avatar(Texture2D value) { }

	[CalledBy(Type = typeof(DuelEnd), Member = "GoBackToLobby", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameRoom), Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_IsReady(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public static void set_Local(Player value) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySocial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(C2CMode), typeof(Int64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static void set_SafeOpt(SafeOptions value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_UserInfo(User value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Username(string value) { }

	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "UpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetCanDisplayInfo(bool value) { }

	[AsyncStateMachine(typeof(<UpdateMyCustomization>d__59))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<TournyUpdated>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyCustomization>d__59)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyCustomization>d__59&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task UpdateMyCustomization() { }

	[AsyncStateMachine(typeof(<UpdateMyPlaymat>d__57))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<PlayClient>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<ConnectToTest>d__339", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyPlaymat>d__57)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyPlaymat>d__57&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task UpdateMyPlaymat(bool needPacket) { }

	[AsyncStateMachine(typeof(<UpdateMyRarities>d__55))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyRarities>d__55)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMyRarities>d__55&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task UpdateMyRarities() { }

	[AsyncStateMachine(typeof(<UpdateMySleeve>d__60))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<PlayClient>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMySleeve>d__60)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateMySleeve>d__60&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task UpdateMySleeve(bool needPacket) { }

	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnTypeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "SetCanDisplayInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "set_SafeOpt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(User), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DiscordController), Member = "GetPlayerAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "GetPlayerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(P2PManager), Member = "RequestUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "CacheUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdatePlayerInfo(bool isReplay = false) { }

	[CalledBy(Type = typeof(Network), Member = "OnUpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void UpdateUser(User user) { }

}

