namespace Manager;

[Extension]
public static class Packet
{

	[CalledBy(Type = typeof(BotCore), Member = "CreateBot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotCore), Member = "SendAddBot", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter AddBot() { }

	[CalledBy(Type = "Manager.Network+<>c", Member = "<StartAuth>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<TrySeamlessAuth>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter AuthPacket(ushort clientVersion, string authToken) { }

	[CalledBy(Type = "Scenes.Lobby.Shop+<>c__DisplayClass36_0", Member = "<OnBuy>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter BuyGoods(ushort goodsId) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ExecuteConsoleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	public static BinaryWriter ConsoleCommand(string cmd) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter Create(CtosMessage message) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "ManualTargetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "ManualTargetSelf", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "ManualActivateCard", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c", Member = "<OnSelectYesNo>b__184_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualStatus), Member = "OnConfirm", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnDrawCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnBlockZone", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardOptionList+<>c__DisplayClass70_0", Member = "<OnSpecialSummon>b__4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints+<>c", Member = "<OnClickLPBar>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter Create(GameMessage message) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<RequestC2CData>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter Create(CtocMessage message) { }

	[CalledBy(Type = typeof(Network), Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static Byte[] CreateChatPacket(string msg) { }

	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<ConnectToTest>d__339", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter CreateGame(uint banlist, GameSettings settings) { }

	[CalledBy(Type = "HostSettings+<>c__DisplayClass44_0", Member = "<OnCreateRoomButton>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryWriter CreateTournament(uint banlist, GameSettings settings, bool passOnly, bool rewardTp, bool singleElim, Int64[] whitelist) { }

	[CalledBy(Type = typeof(DisplayCard), Member = "SetupBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "ToRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 6)]
	[Extension]
	public static int GetBits(int mask, byte size, byte start) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "CalculateLinkedZones", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Extension]
	public static uint GetBits(uint mask, byte size, byte start) { }

	[CalledBy(Type = typeof(General), Member = "SetULongPlayerPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
	[CalledBy(Type = typeof(RoomData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Extension]
	public static ulong GetBits(ulong mask, byte size, byte start) { }

	[CalledBy(Type = typeof(General), Member = "ToSetCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>))]
	[CallerCount(Count = 1)]
	[Extension]
	public static long GetBits(long mask, byte size, byte start) { }

	[CalledBy(Type = typeof(BinaryExtensions), Member = "ReadRoomData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(RoomData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Extension]
	public static ushort GetBits(ushort mask, byte size, byte start) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnHandResult>d__59", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnHandResult>d__193", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "SetLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Extension]
	public static byte GetBits(byte mask, byte size, byte start) { }

	[CalledBy(Type = typeof(Janken), Member = "OnSelectHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter HandResult(byte choice, bool game = false) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c__DisplayClass124_0", Member = "<OnTryEnterSeletedRoom>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "EnterRoomByCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnTryEnterSeletedRoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter JoinGame(int roomId = -1, ulong secret = 0, bool spectate = false) { }

	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivitySpectate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnJoinRoom>d__96", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RoomData), Member = "GetPwd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.UInt64>))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter JoinGame(int roomId = -1, string secret = "", bool spectate = false) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "set_LastUsedDeckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static BinaryWriter JoinGame(byte queue, Deck deck) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "set_LastUsedDeckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter JoinTournament(Deck deck) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter LocalAuthPacket(ushort clientVersion, long uid, string username, string avatar) { }

	[CalledBy(Type = "Manager.P2PManager+<ConnectToHosting>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DiscordController), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter MakeLocalAuthPacket() { }

	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryExtensions), Member = "GetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter MakeLocalCreateGame() { }

	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	public static BinaryWriter MakeLocalJoinGame() { }

	[CalledBy(Type = typeof(GameRoom), Member = "SetupNewRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter MakeRoomSetupRulesPacket(GameSettings gs, uint bl) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnErrorMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+DeckSyncRcv", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalExt), Member = "ReadLocalUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(User))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnAddBot>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnPlayerInfo>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "ReadUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(User))]
	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ReadASCII(BinaryReader reader) { }

	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "ReadUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(User))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static DateTime ReadDateTime(BinaryReader reader, bool full = false, bool year = true) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Deck), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Deck ReadDeck(BinaryReader reader, bool allowInvalid = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ReadReplayName(BinaryReader r) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnReceiveServerReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(P2PManager), Member = "OnRelayNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnReloadField>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnResponse>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalPlayer), Member = "MakeRedirectPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(BinaryWriter))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Byte[] ReadToEnd(BinaryReader reader) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+DeckSyncRcv", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalExt), Member = "ReadLocalUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(User))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnPlayerInfo>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "ReadUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(User))]
	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ReadUnicode(BinaryReader reader) { }

	[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter RematchRequest(bool toRoom, Deck updateDeck) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static ulong SetBit(ulong val, int pos, bool value) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static long SetBit(long val, int pos, bool value) { }

	[CalledBy(Type = typeof(GameSettings), Member = "ToUInt64", ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(RoomData), Member = "get_GameData", ReturnType = typeof(ulong))]
	[CallerCount(Count = 11)]
	[Extension]
	public static ulong SetBits(ulong mask, ulong val, byte size) { }

	[CalledBy(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalGame)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Extension]
	public static ushort SetBits(ushort mask, ushort val, byte size) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static uint SetBits(uint mask, uint val, byte size) { }

	[CalledBy(Type = "Game.Local.LocalGame+<HandResult>d__171", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnHandResult>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Extension]
	public static byte SetBits(byte mask, byte val, byte size) { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnClickAddBot", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreAPI), Member = "get_RandomPuzzleName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter SetPuzzle(string puzzleName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static DateTime ToDateTime(uint val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static DateTime ToDateTime(ushort val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Extension]
	public static ushort ToUInt16(DateTime dt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Extension]
	public static uint ToUInt32(DateTime dt) { }

	[CalledBy(Type = typeof(Janken), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Janken), Member = "OnClickFirst", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Janken), Member = "OnClickSecond", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter TurnSelect(bool first) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<ConnectToTest>d__339", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c", Member = "<GoToSiding>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "SendUpdateDeck", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "set_LastUsedDeckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter UpdateDeck(Deck deck = null, bool updateLastUsed = true) { }

	[CalledBy(Type = typeof(Packet), Member = "RematchRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "JoinTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = "Game.Local.LocalGame+<SendChangingSide>d__212", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RoomData), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "Shuffle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(Random)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Write(BinaryWriter writer, Deck deck) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Write(BinaryWriter writer, MainPhaseAction mpa) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Write(BinaryWriter writer, BattlePhaseAction bpa) { }

	[CalledBy(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "SetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Write(BinaryWriter writer, DateTime dt, bool full = false, bool year = true) { }

	[CalledBy(Type = typeof(P2PManager), Member = "WriteFullDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Packet), Member = "AuthPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "MakeLocalAuthPacket", ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "LocalAuthPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "ConsoleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "SetPuzzle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalUser)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<AddPlayer>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<HandleError>d__246", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void WriteASCII(BinaryWriter writer, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static void WriteReplayName(BinaryWriter w, string n) { }

	[CalledBy(Type = typeof(P2PManager), Member = "WriteFullDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Packet), Member = "MakeLocalAuthPacket", ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "LocalAuthPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "CreateChatPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalUser)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<AddPlayer>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<OnChatMessage>d__127", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void WriteUnicode(BinaryWriter writer, string text) { }

}

