namespace Manager;

public static class BanlistManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Banlist, Int32> <>9__12_0; //Field offset: 0x8
		public static Func<Banlist, Int32> <>9__13_0; //Field offset: 0x10
		public static Func<FileInfo, Boolean> <>9__15_0; //Field offset: 0x18
		public static Func<Banlist, Boolean> <>9__28_0; //Field offset: 0x20
		public static Func<Banlist, Boolean> <>9__28_1; //Field offset: 0x28
		public static Func<Banlist, Boolean> <>9__28_2; //Field offset: 0x30
		public static Func<Banlist, Boolean> <>9__28_3; //Field offset: 0x38
		public static Func<Banlist, Boolean> <>9__28_4; //Field offset: 0x40
		public static Func<Banlist, Boolean> <>9__28_5; //Field offset: 0x48
		public static Func<Banlist, Boolean> <>9__28_6; //Field offset: 0x50
		public static Func<Banlist, Boolean> <>9__28_7; //Field offset: 0x58
		public static Func<Banlist, Boolean> <>9__28_8; //Field offset: 0x60
		public static Func<Banlist, Boolean> <>9__28_9; //Field offset: 0x68
		public static Func<Banlist, Boolean> <>9__28_10; //Field offset: 0x70
		public static Func<Banlist, Boolean> <>9__28_11; //Field offset: 0x78
		public static Func<Banlist, Boolean> <>9__28_12; //Field offset: 0x80
		public static Func<Banlist, Boolean> <>9__28_13; //Field offset: 0x88

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
		internal bool <GetBanlistForLimit>b__28_0(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_1(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_10(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_11(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_12(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_13(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_2(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_3(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_4(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_5(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_6(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_7(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_8(Banlist bl) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetBanlistForLimit>b__28_9(Banlist bl) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <InitCustomBanlists>b__15_0(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <SortBanlists>b__12_0(Banlist b) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <SortCustomBanlists>b__13_0(Banlist b) { }

	}

	private static Banlist _currentBanlist; //Field offset: 0x0
	[CompilerGenerated]
	private static List<Banlist> <Banlists>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static List<Banlist> <CustomBanlists>k__BackingField; //Field offset: 0x10

	private static long AllTypeMask
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
		[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		private get { } //Length: 561
	}

	public private static List<Banlist> Banlists
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 110
	}

	public static Banlist CurrentBanlist
	{
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshGenesysCounter", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckFilters), Member = "GenesysFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckFilters), Member = "DateSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Deck), Member = "CanAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Deck), Member = "GetDateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "RefreshGenesys", ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 329
		[CalledBy(Type = typeof(DeckEdit), Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 305
	}

	public private static List<Banlist> CustomBanlists
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 110
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static BanlistManager() { }

	[CalledBy(Type = typeof(BanlistManager), Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private static BanflagLocation BanLocationFromString(string text) { }

	[CalledBy(Type = typeof(BanlistManager), Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private static BanflagType BanTypeFromString(string text) { }

	[CallerCount(Count = 0)]
	public static long CreateGenesysFlag(uint cardId, short genesysPoints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static long get_AllTypeMask() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static List<Banlist> get_Banlists() { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshGenesysCounter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckFilters), Member = "GenesysFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "DateSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Deck), Member = "CanAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Deck), Member = "GetDateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshGenesys", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
	[CallsUnknownMethods(Count = 1)]
	public static Banlist get_CurrentBanlist() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static List<Banlist> get_CustomBanlists() { }

	[CalledBy(Type = typeof(HostSettings), Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(UInt32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "ParseFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelRules&), typeof(Int32&), typeof(Int16&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(UInt32&), typeof(DuelMode&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[CallsUnknownMethods(Count = 1)]
	public static Banlist GetBanlist(ushort index) { }

	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[CalledBy(Type = "Game.Local.LocalGame+<UpdateRules>d__128", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tournament), Member = "DefineTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Tournament))]
	[CalledBy(Type = typeof(Tournament), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameSettings), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Banlist), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static bool GetBanlist(uint hash, out Banlist bl) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Banlist GetBanlistByID(int id) { }

	[CalledBy(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnCurrentDeckTap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Banlist), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 20)]
	public static Banlist GetBanlistForLimit(Limitation limit) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static ushort GetIndex(string name) { }

	[CalledBy(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(Banlist)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetIndex(uint hash) { }

	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Banlist), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Init() { }

	[CalledBy(Type = "Card.Manager+<LoadCustomDatabases>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(BanlistManager), Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public static void InitCustomBanlists() { }

	[CalledBy(Type = typeof(BanlistManager), Member = "InitCustomBanlists", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Banlist), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SByte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BanlistManager), Member = "BanTypeFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BanflagType))]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Banlist), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(sbyte), typeof(BanlistMode), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BanlistManager), Member = "BanLocationFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BanflagLocation))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(StreamReader), Member = "get_EndOfStream", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 48)]
	private static void ReadBanlistFile(string path) { }

	[CallerCount(Count = 0)]
	public static void ReadGenesysFlag(long flag, out uint cardId, out short genesysPoints) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_Banlists(List<Banlist> value) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_CurrentBanlist(Banlist value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_CustomBanlists(List<Banlist> value) { }

	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SortBanlists() { }

	[CalledBy(Type = "Card.Manager+<LoadCustomDatabases>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SortCustomBanlists() { }

}

