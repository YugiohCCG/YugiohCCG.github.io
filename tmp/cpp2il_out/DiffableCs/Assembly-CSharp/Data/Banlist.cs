namespace Data;

public class Banlist : ISerializable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ValueTuple`2<Int32, BanflagLocation>, ValueTuple`2<SByte, SByte>>, Int32> <>9__41_1; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		internal int <GetAllIDsMaxLimited>b__41_1(KeyValuePair<ValueTuple`2<Int32, BanflagLocation>, ValueTuple`2<SByte, SByte>> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public byte limitation; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass41_0() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <GetAllIDsMaxLimited>b__0(KeyValuePair<ValueTuple`2<Int32, BanflagLocation>, ValueTuple`2<SByte, SByte>> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public IEnumerable<UInt16> setcodes; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass67_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(ushort)}, ReturnType = typeof(bool))]
		internal bool <FilterBySetcode>b__0(ushort x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public IEnumerable<UInt16> setcodes; //Field offset: 0x10
		public Func<UInt16, Boolean> <>9__0; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass76_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(ushort)}, ReturnType = typeof(bool))]
		internal bool <Get>b__0(ushort x) { }

	}

	[CompilerGenerated]
	private struct <CreateBanlistPacket>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public Banlist <>4__this; //Field offset: 0x20
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "SerializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const uint UnlimitedHash = 2113728106; //Field offset: 0x0
	private static readonly Int32[] TCG_BANLISTS; //Field offset: 0x0
	[CompilerGenerated]
	private uint <Hash>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsWhitelist>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private sbyte <ForceDateOT>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private short <GenesysMaxPoints>k__BackingField; //Field offset: 0x22
	private readonly Dictionary<ValueTuple`2<Int32, BanflagLocation>, ValueTuple`2<SByte, SByte>> IDLimitation; //Field offset: 0x28
	private readonly Dictionary<ValueTuple`2<CardType, BanflagLocation>, ValueTuple`2<SByte, SByte>> TypeLimitation; //Field offset: 0x30
	private readonly Dictionary<ValueTuple`2<CardRace, BanflagLocation>, ValueTuple`2<SByte, SByte>> RaceLimitation; //Field offset: 0x38
	private readonly Dictionary<ValueTuple`2<CardAttribute, BanflagLocation>, ValueTuple`2<SByte, SByte>> AttributeLimitation; //Field offset: 0x40
	private readonly Dictionary<ValueTuple`2<Category, BanflagLocation>, ValueTuple`2<SByte, SByte>> CategoryLimitation; //Field offset: 0x48
	private readonly Dictionary<BanflagLocation, ValueTuple`2<SByte, SByte>> DeckLimitation; //Field offset: 0x50
	private readonly Dictionary<ValueTuple`2<Int64, BanflagLocation>, ValueTuple`2<SByte, SByte>> ArchetypeLimitation; //Field offset: 0x58
	private readonly Dictionary<UInt32, Int16> GenesysPointsLimitation; //Field offset: 0x60
	[CompilerGenerated]
	private int <BanlistID>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsCustom>k__BackingField; //Field offset: 0x6C

	public int BanlistID
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public sbyte ForceDateOT
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

	public bool ForceUseOCGDate
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool ForceUseTCGDate
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public private short GenesysMaxPoints
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

	public private uint Hash
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool IsCustom
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

	public bool IsDLBanlist
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool IsRushBanlist
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool IsSPDBanlist
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool IsTCG
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckFilters), Member = "DateSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Deck), Member = "GetDateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
		 get { } //Length: 107
	}

	public bool IsUnlimited
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsWhitelist
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string ListableName
	{
		[CalledBy(Type = "HostSettings+<>c", Member = "<DefineBanlistDropdown>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
		[CalledBy(Type = "HostSettings+<>c", Member = "<DefineBanlistDropdown>b__45_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c", Member = "<OnEnable>b__310_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c", Member = "<OnEnable>b__310_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 95
	}

	public string Name
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Banlist() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32Enum, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int64, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public Banlist(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(BanlistManager), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BanlistManager), Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32Enum, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int64, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public Banlist() { }

	[CalledBy(Type = "Card.Manager+<ReadBanlist>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32Enum, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int64, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public Banlist(int id, string name) { }

	[CalledBy(Type = typeof(BanlistManager), Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass24_0", Member = "<ReadBanlist>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bandatas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	public void Add(long flag, sbyte limit, BanlistMode mode = 0, BanflagType type = 0, BanflagLocation location = 0) { }

	[AsyncStateMachine(typeof(<CreateBanlistPacket>d__78))]
	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateBanlistPacket>d__78)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateBanlistPacket>d__78&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Byte[]> CreateBanlistPacket() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.ValueTuple`2<System.Int64, System.ByteEnum>, System.ValueTuple`2<System.SByte, System.SByte>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt32, System.Int16>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public int DeckCheck(Deck deck) { }

	[CalledBy(Type = "Card.Deck+<>c__DisplayClass81_0", Member = "<GetAmountOf>g__filterByAttribute|2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasOneAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(bool))]
	public static bool FilterByAttribute(int cid, CardAttribute cattribute) { }

	[CalledBy(Type = "Card.Deck+<>c__DisplayClass81_0", Member = "<GetAmountOf>g__filterByCategory|4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasOneCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	public static bool FilterByCategory(int cid, Category ccat) { }

	[CalledBy(Type = "Card.Deck+<>c__DisplayClass81_0", Member = "<GetAmountOf>g__filterByID|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool FilterByID(int cid, Card card) { }

	[CalledBy(Type = "Card.Deck+<>c__DisplayClass81_0", Member = "<GetAmountOf>g__filterByRace|3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasOneRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace)}, ReturnType = typeof(bool))]
	public static bool FilterByRace(int cid, CardRace crace) { }

	[CalledBy(Type = "Card.Deck+<>c__DisplayClass81_0", Member = "<GetAmountOf>g__filterBySetcode|5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(System.Func`2<System.UInt16, System.Boolean>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool FilterBySetcode(int cid, IEnumerable<UInt16> setcodes) { }

	[CalledBy(Type = "Card.Deck+<>c__DisplayClass81_0", Member = "<GetAmountOf>g__filterByType|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasOneType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	public static bool FilterByType(int cid, CardType ctype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ValueTuple`2<SByte, SByte>&), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	public bool Get(int cid, out sbyte maxLimit) { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.ValueTuple`2<System.SByte, System.SByte>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Get(out ValueTuple<SByte, SByte>& limit, BanflagLocation location = 1) { }

	[CalledBy(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[CalledBy(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SByte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SByte&), typeof(BanlistMode), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "GetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "GetForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(BanflagType), typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public bool Get(long flag, out ValueTuple<SByte, SByte>& limit, BanflagType type = 0, BanflagLocation location = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ValueTuple`2<SByte, SByte>&), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	public bool Get(long flag, out sbyte limit, BanlistMode mode = 0, BanflagType type = 0, BanflagLocation location = 0) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_BanlistID() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public sbyte get_ForceDateOT() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_ForceUseOCGDate() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_ForceUseTCGDate() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public short get_GenesysMaxPoints() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public uint get_Hash() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsCustom() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsDLBanlist() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_IsRushBanlist() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsSPDBanlist() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckFilters), Member = "DateSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Deck), Member = "GetDateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	public bool get_IsTCG() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_IsUnlimited() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsWhitelist() { }

	[CalledBy(Type = "HostSettings+<>c", Member = "<DefineBanlistDropdown>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
	[CalledBy(Type = "HostSettings+<>c", Member = "<DefineBanlistDropdown>b__45_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c", Member = "<OnEnable>b__310_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c", Member = "<OnEnable>b__310_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public string get_ListableName() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CalledBy(Type = typeof(Banlist), Member = "IsBannedByRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ValueTuple`2<SByte, SByte>&), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	public bool GetAll(Card c, out ValueTuple<SByte, SByte>& limit) { }

	[CalledBy(Type = typeof(Deck), Member = "CanAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Int32[] GetAllIDsMaxLimited(byte limitation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ValueTuple`2<SByte, SByte>&), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetForCard(Card c, BanflagType type, out ValueTuple<SByte, SByte>& limit) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "GenesysFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "RefreshGenesys", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Int16>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool GetGenesysCost(int cardId, out short pts) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "IsBannedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "GetQuantityOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Deck), Member = "CanAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ValueTuple`2<SByte, SByte>&), typeof(BanflagType), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "GetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public BanScope GetMaxQuantity(int cardId, out byte quantity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	public byte GetQuantityOnly(int cardId) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshGenesysCounter", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt32, System.Int16>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public short GetSpentGenesysPoints(Deck deck) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool InRange(int val, int min, int max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Banlist), Member = "GetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool IsBannedByRule(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[ContainsUnimplementedInstructions]
	public bool IsBannedCard(int cid) { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_BanlistID(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ForceDateOT(sbyte value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GenesysMaxPoints(short value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Hash(uint value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsCustom(bool value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsWhitelist(bool value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

}

