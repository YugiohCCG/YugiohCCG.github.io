namespace Data;

public class User
{
	public static User CurrentUser; //Field offset: 0x0
	public const float DEFAULT_MU = 100; //Field offset: 0x0
	public const long BotID = 195913226997858305; //Field offset: 0x0
	public UserRank AccountRank; //Field offset: 0x10
	public SleeveRarity Sleeves; //Field offset: 0x12
	public AccountFlags Flags; //Field offset: 0x14
	public byte Rare; //Field offset: 0x15
	public byte Super; //Field offset: 0x16
	public byte Ultra; //Field offset: 0x17
	public byte Secret; //Field offset: 0x18
	public byte Ultimate; //Field offset: 0x19
	public byte Parallel; //Field offset: 0x1A
	public byte Ghost; //Field offset: 0x1B
	public byte Fire; //Field offset: 0x1C
	public byte Water; //Field offset: 0x1D
	public byte Wind; //Field offset: 0x1E
	public byte Earth; //Field offset: 0x1F
	public byte Dark; //Field offset: 0x20
	public byte Light; //Field offset: 0x21
	public ushort TournamentPoints; //Field offset: 0x22
	public ushort DuelPoints; //Field offset: 0x24
	public long ID; //Field offset: 0x28
	public long UnbanDate; //Field offset: 0x30
	public ushort TCGWins; //Field offset: 0x38
	public ushort OCGWins; //Field offset: 0x3A
	public ushort TCGLoses; //Field offset: 0x3C
	public ushort OCGLoses; //Field offset: 0x3E
	public ushort TCGDraws; //Field offset: 0x40
	public ushort OCGDraws; //Field offset: 0x42
	public string Username; //Field offset: 0x48
	public string Avatar; //Field offset: 0x50
	public DateTime PassDueDate; //Field offset: 0x58
	public float TCGRating; //Field offset: 0x60
	public float OCGRating; //Field offset: 0x64

	public string DuelLinksBadgeName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
		[Calls(Type = typeof(User), Member = "get_DuelLinksBracket", ReturnType = typeof(Bracket))]
		[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 218
	}

	public Bracket DuelLinksBracket
	{
		[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(User), Member = "get_DuelLinksBadgeName", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 91
	}

	public bool HasRarities
	{
		[CalledBy(Type = "Manager.Network+<RequestC2CData>d__49", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(User), Member = "HasSeasonPass", ReturnType = typeof(bool))]
		 get { } //Length: 94
	}

	public bool IsBot
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 18
	}

	public bool IsCensored
	{
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool IsSeasonPassExpired
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		 get { } //Length: 88
	}

	public string OCGBadgeName
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(User), Member = "GetRating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
		[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 174
	}

	public Bracket OCGBracket
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(User), Member = "GetRating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
		 get { } //Length: 25
	}

	public int PassDaysLeft
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateUserInfo", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalDays", ReturnType = typeof(double))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 237
	}

	public string TCGBadgeName
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(User), Member = "get_TCGBracket", ReturnType = typeof(Bracket))]
		[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 154
	}

	public Bracket TCGBracket
	{
		[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(User), Member = "get_TCGBadgeName", ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 218
	}

	[CalledBy(Type = typeof(LocalExt), Member = "ReadLocalUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(User))]
	[CalledBy(Type = typeof(General), Member = "ReadUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(User))]
	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public User() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(User), Member = "get_DuelLinksBracket", ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public string get_DuelLinksBadgeName() { }

	[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_DuelLinksBadgeName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Bracket get_DuelLinksBracket() { }

	[CalledBy(Type = "Manager.Network+<RequestC2CData>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(User), Member = "HasSeasonPass", ReturnType = typeof(bool))]
	public bool get_HasRarities() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsBot() { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCensored() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	public bool get_IsSeasonPassExpired() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(User), Member = "GetRating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public string get_OCGBadgeName() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(User), Member = "GetRating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
	public Bracket get_OCGBracket() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateUserInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalDays", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_PassDaysLeft() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(User), Member = "get_TCGBracket", ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public string get_TCGBadgeName() { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_TCGBadgeName", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public Bracket get_TCGBracket() { }

	[CalledBy(Type = typeof(Janken), Member = "DefinePlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(User), Member = "GetBracket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(User), Member = "get_DuelLinksBracket", ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(Localization), Member = "GetBracketName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bracket), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(User), Member = "get_TCGBracket", ReturnType = typeof(Bracket))]
	[Calls(Type = typeof(User), Member = "GetRating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public string GetBadgeName(CardSet ranking) { }

	[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_OCGBracket", ReturnType = typeof(Bracket))]
	[CalledBy(Type = typeof(User), Member = "get_TCGBracket", ReturnType = typeof(Bracket))]
	[CalledBy(Type = typeof(User), Member = "get_DuelLinksBracket", ReturnType = typeof(Bracket))]
	[CalledBy(Type = typeof(User), Member = "get_OCGBadgeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_DuelLinksBadgeName", ReturnType = typeof(string))]
	[CallerCount(Count = 13)]
	public static Bracket GetBracket(float rating) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "ParseRarities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.Int32, System.Byte>), typeof(Dictionary`2<Int32, Byte>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "ParseRarities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "AddRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rarity), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(User), Member = "HasSeasonPass", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public byte GetRarityQuantity(Rarity rarity) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_OCGBracket", ReturnType = typeof(Bracket))]
	[CalledBy(Type = typeof(User), Member = "get_OCGBadgeName", ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public float GetRating(CardSet ranking) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool HasFlag(AccountFlags flag) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateUserInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.Player+<UpdateMyRarities>d__55", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(User), Member = "get_HasRarities", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	public bool HasSeasonPass() { }

	[CalledBy(Type = typeof(Shop), Member = "IsPurchasable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Lobby.Shop+ShopItemData"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickSleeve", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCoverRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SleeveRarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	public bool HasSleeve(SleeveRarity slv) { }

	[CallerCount(Count = 0)]
	public void RemoveFlag(AccountFlags flag) { }

	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateUser(User u) { }

}

