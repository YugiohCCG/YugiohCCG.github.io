namespace Data;

public class Tournament
{
	public static Tournament Instance; //Field offset: 0x0
	private static bool isInTournament; //Field offset: 0x8
	[CompilerGenerated]
	private bool <AllowRegistering>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Started>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <RequireSeasonPass>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private bool <RewardTP>k__BackingField; //Field offset: 0x13
	[CompilerGenerated]
	private DateTime <RoundStartTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ushort <RoundTimer>k__BackingField; //Field offset: 0x20
	private bool _nextRoundSoon; //Field offset: 0x22
	private bool _receivedBye; //Field offset: 0x23
	public readonly Banlist LFList; //Field offset: 0x28
	public readonly GameSettings Settings; //Field offset: 0x30
	[CompilerGenerated]
	private int <PlayerCount>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private byte <MaxPhase>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private byte <CurrentPhase>k__BackingField; //Field offset: 0x75

	public private bool AllowRegistering
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 370
	}

	public byte CurrentPhase
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static bool HasTournament
	{
		[CalledBy(Type = typeof(HostSettings), Member = "get_CanDisplayTourny", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<TournyUpdated>d__74", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnClickJoinExtraRules", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateTournamentState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnRoomSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnStartTournamentButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnTournyButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnCurrentDeckTap", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		 get { } //Length: 79
	}

	public static bool IsInTournament
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 130
	}

	public byte MaxPhase
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool NextRoundSoon
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 116
	}

	public DateTime NextRoundStartTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "AddMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 182
	}

	public double NextRoundTimeLeft
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "AddMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 314
	}

	public int PlayerCount
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

	public bool ReceivedBye
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 116
	}

	public private bool RequireSeasonPass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private bool RewardTP
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public DateTime RoundEndTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 98
	}

	public private DateTime RoundStartTime
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public double RoundTimeLeft
	{
		[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 230
	}

	public private ushort RoundTimer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public private bool Started
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public TournyMode TournamentMode
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	private Tournament(uint lfList, GameSettings settings, bool tp, bool pass) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static Tournament DefineTournament(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_AllowRegistering() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_CurrentPhase() { }

	[CalledBy(Type = typeof(HostSettings), Member = "get_CanDisplayTourny", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<TournyUpdated>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnClickJoinExtraRules", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateTournamentState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnRoomSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnStartTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnTournyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnCurrentDeckTap", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	public static bool get_HasTournament() { }

	[CallerCount(Count = 0)]
	public static bool get_IsInTournament() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_MaxPhase() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_NextRoundSoon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public DateTime get_NextRoundStartTime() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public double get_NextRoundTimeLeft() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_PlayerCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ReceivedBye() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_RequireSeasonPass() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_RewardTP() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public DateTime get_RoundEndTime() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DateTime get_RoundStartTime() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public double get_RoundTimeLeft() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ushort get_RoundTimer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Started() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public TournyMode get_TournamentMode() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_AllowRegistering(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CurrentPhase(byte value) { }

	[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_IsInTournament(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_MaxPhase(byte value) { }

	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_NextRoundSoon(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PlayerCount(int value) { }

	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyScreen), Member = "TournyUpdated", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_ReceivedBye(bool value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RequireSeasonPass(bool value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RewardTP(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RoundStartTime(DateTime value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RoundTimer(ushort value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Started(bool value) { }

}

