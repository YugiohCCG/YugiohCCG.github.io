namespace Card;

public class Card
{
	[DefaultMember("Item")]
	internal struct CardData
	{
		public const int SIZE = 88; //Field offset: 0x0
		public const int SIZE_WITH_LEN = 92; //Field offset: 0x0
		public const int SETCODE_SIZE = 16; //Field offset: 0x0
		public int Code; //Field offset: 0x0
		public int Alias; //Field offset: 0x4
		public ushort SetCode0; //Field offset: 0x8
		public ushort SetCode1; //Field offset: 0xA
		public ushort SetCode2; //Field offset: 0xC
		public ushort SetCode3; //Field offset: 0xE
		public ushort SetCode4; //Field offset: 0x10
		public ushort SetCode5; //Field offset: 0x12
		public ushort SetCode6; //Field offset: 0x14
		public ushort SetCode7; //Field offset: 0x16
		public ushort SetCode8; //Field offset: 0x18
		public ushort SetCode9; //Field offset: 0x1A
		public ushort SetCode10; //Field offset: 0x1C
		public ushort SetCode11; //Field offset: 0x1E
		public ushort SetCode12; //Field offset: 0x20
		public ushort SetCode13; //Field offset: 0x22
		public ushort SetCode14; //Field offset: 0x24
		public ushort SetCode15; //Field offset: 0x26
		public int Type; //Field offset: 0x28
		public int Level; //Field offset: 0x2C
		public int Attribute; //Field offset: 0x30
		public int Race; //Field offset: 0x34
		public int Attack; //Field offset: 0x38
		public int Defense; //Field offset: 0x3C
		public int LScale; //Field offset: 0x40
		public int RScale; //Field offset: 0x44
		public int LinkMarker; //Field offset: 0x48
		public int RuleCode; //Field offset: 0x4C
		public int Category; //Field offset: 0x50
		public int Cover; //Field offset: 0x54

		public ushort Item
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 112
			[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 124
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ushort get_Item(byte index) { }

		[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void set_Item(byte index, ushort value) { }

	}

	public const int UNKNOWN_CARD_ID = 11738490; //Field offset: 0x0
	public const int ALL_RACES = 33554431; //Field offset: 0x0
	private static readonly Int32[] RUSH_IGNORE_ALIAS; //Field offset: 0x0
	private const CardType EXTRA_CARD = 75505728; //Field offset: 0x0
	private const Category RUSH_CARD = 2099328; //Field offset: 0x0
	private const CardType NORMAL_MONSTER = 17; //Field offset: 0x0
	private const Category HAS_CATEGORY = 12715208; //Field offset: 0x0
	internal CardData Data; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsCustomCard>k__BackingField; //Field offset: 0x68
	public int KoID; //Field offset: 0x6C
	[CompilerGenerated]
	private byte <OT>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private CardArchetype <Setcode>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private long <SupportSetCodes>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <TCGPlayerPrice>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <CardMarketPrice>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private int <AvgPrice>k__BackingField; //Field offset: 0x90
	public RarityTypes ReleasedRarities; //Field offset: 0x98
	[CompilerGenerated]
	private string <PriceText>k__BackingField; //Field offset: 0xA0
	private DateTime tcgdt; //Field offset: 0xA8
	private DateTime ocgdt; //Field offset: 0xB0
	[CompilerGenerated]
	private int <MAXAttack>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private string <SetID>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private long <Genre>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private CardLocalization <CardText>k__BackingField; //Field offset: 0xD0
	private IntPtr _script; //Field offset: 0xD8
	private int _scriptLength; //Field offset: 0xE0

	public int Alias
	{
		[CallerCount(Count = 43)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
		 get { } //Length: 137
	}

	public int Attack
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public byte Attribute
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private int AvgPrice
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public int CardCategory
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public private int CardMarketPrice
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public private CardLocalization CardText
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public int CardTypeSortOrder
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "GetCardTypeSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DeckFilters), Member = "GetCardTypeSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Deck), Member = "GetCardTypeSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 395
	}

	public bool ContainsCategory
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "SubTypeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 25
	}

	public string DateString
	{
		[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Card), Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Card), Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 441
	}

	public int Defense
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public private long Genre
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool HasOCGRelease
	{
		[CalledBy(Type = typeof(Card), Member = "get_HasRelease", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
		[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		 get { } //Length: 205
	}

	public bool HasPendulumEffect
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		 get { } //Length: 62
	}

	public bool HasRelease
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Card), Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Card), Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
		 get { } //Length: 43
	}

	public bool HasScript
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Card), Member = "get_ScriptLength", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 21
	}

	public bool HasTCGRelease
	{
		[CalledBy(Type = typeof(Card), Member = "get_HasRelease", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
		[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		 get { } //Length: 205
	}

	public int ID
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool IsBeta
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 9
	}

	public bool IsCommon
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "PoolFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		 get { } //Length: 24
	}

	public private bool IsCustomCard
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

	public bool IsDLExclusive
	{
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 18
	}

	public bool IsExtraCard
	{
		[CalledBy(Type = "Extensions.DeckTrunk+<>c", Member = "<get_SwapReady>b__30_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Extensions.DeckTrunk+<>c__DisplayClass25_0", Member = "<SwapFromList>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "RemoveMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Manager), Member = "DeckFromRecipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Deck))]
		[CalledBy(Type = typeof(Manager), Member = "FixInvalidCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		 get { } //Length: 147
	}

	public bool IsIllegal
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 10
	}

	public bool IsOCG
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
	}

	public bool IsRushCard
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckFilters), Member = "PoolFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		 get { } //Length: 62
	}

	public bool IsRushLegend
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		 get { } //Length: 62
	}

	public bool IsScriptless
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "PoolFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Card), Member = "get_ScriptLength", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 106
	}

	public bool IsTCG
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 9
	}

	public bool IsTrinityUnbound
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		 get { } //Length: 82
	}

	public bool IsWCS
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 12
	}

	public sbyte Level
	{
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public sbyte LinkLevel
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "LinkFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckFilters), Member = "LevelSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Card), Member = "get_ValidLevel", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Card), Member = "get_CardTypeSortOrder", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CardLocalization), Member = "StarText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
		[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		 get { } //Length: 637
	}

	public ushort LinkMarker
	{
		[CalledBy(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BotClientCard), Member = "SetDefaultData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 5
	}

	public sbyte LScale
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private int MAXAttack
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public bool NeedScript
	{
		[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
		 get { } //Length: 94
	}

	public DateTime OCGReleaseDate
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckFilters), Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Card), Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(Card), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Packs), typeof(Relations)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
		 get { } //Length: 176
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public private byte OT
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

	public private string PriceText
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public int Race
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public sbyte RScale
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int RuleCode
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public private IntPtr Script
	{
		[CalledBy(Type = typeof(CoreAPI), Member = "OnScriptReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32*)}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(Card), Member = "get_Script", ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Card), Member = "get_Script", ReturnType = typeof(IntPtr))]
		 get { } //Length: 502
		[CalledBy(Type = typeof(Card), Member = "LoadScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		private set { } //Length: 120
	}

	public private int ScriptLength
	{
		[CalledBy(Type = typeof(CoreAPI), Member = "OnScriptReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32*)}, ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(Card), Member = "get_IsScriptless", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "get_HasScript", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		 get { } //Length: 147
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public CardArchetype Setcode
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public private string SetID
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public private long SupportSetCodes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private int TCGPlayerPrice
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public string TCGPlayerSearchLink
	{
		[CalledBy(Type = typeof(DisplayCard), Member = "OnTapBuy", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 285
	}

	public DateTime TCGReleaseDate
	{
		[CalledBy(Type = typeof(DeckFilters), Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckFilters), Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Card), Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(Card), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Packs), typeof(Relations)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
		 get { } //Length: 176
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public int Type
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int ValidLevel
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
		 get { } //Length: 37
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Card() { }

	[CalledBy(Type = typeof(Manager), Member = "ReadCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "ReadCustomCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(CardData), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "ToPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(Card), Member = "set_Script", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardArchetype), Member = "get_MainArchetypes", ReturnType = typeof(long))]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal Card(Cards reader, bool isCustom = false) { }

	[CalledBy(Type = typeof(Manager), Member = "ReadRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Relations)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 2)]
	public void AddSet(Packs set, Relations rel) { }

	[CalledBy(Type = "Card.Manager+<>c__DisplayClass47_0", Member = "<InitCardLocalization>g__parseCard|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(Texts)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass47_0", Member = "<InitCardLocalization>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texts)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass47_0", Member = "<InitCardLocalization>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texts)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<InitCardLocalization>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CardLocalization), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocalization)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ChangeLocale(CardLocalization locale) { }

	[CalledBy(Type = "Card.Manager+<LoadCustomScript>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public void ClearScript() { }

	[CalledBy(Type = typeof(Manager), Member = "ReadErratas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Errata)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DefineErrata(Packs set, Errata errata) { }

	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "ReadPrice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Prices)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CallsUnknownMethods(Count = 2)]
	public void DefinePrices(int tp, int cm, bool defineOnMain) { }

	[CalledBy(Type = typeof(Manager), Member = "ReadRulings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ruling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DefineRuling(Ruling ruling) { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	public int get_Alias() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public int get_Attack() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public byte get_Attribute() { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_AvgPrice() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_CardCategory() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_CardMarketPrice() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CardLocalization get_CardText() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "GetCardTypeSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DeckFilters), Member = "GetCardTypeSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Deck), Member = "GetCardTypeSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	[ContainsUnimplementedInstructions]
	public int get_CardTypeSortOrder() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "SubTypeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_ContainsCategory() { }

	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DatePickerUtilities), Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_DateString() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public int get_Defense() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public long get_Genre() { }

	[CalledBy(Type = typeof(Card), Member = "get_HasRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	public bool get_HasOCGRelease() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool get_HasPendulumEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
	public bool get_HasRelease() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "get_ScriptLength", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public bool get_HasScript() { }

	[CalledBy(Type = typeof(Card), Member = "get_HasRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	public bool get_HasTCGRelease() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_ID() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public bool get_IsBeta() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "PoolFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	public bool get_IsCommon() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsCustomCard() { }

	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public bool get_IsDLExclusive() { }

	[CalledBy(Type = "Extensions.DeckTrunk+<>c", Member = "<get_SwapReady>b__30_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Extensions.DeckTrunk+<>c__DisplayClass25_0", Member = "<SwapFromList>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "RemoveMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "DeckFromRecipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(Manager), Member = "FixInvalidCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool get_IsExtraCard() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public bool get_IsIllegal() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	public bool get_IsOCG() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "PoolFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool get_IsRushCard() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LimitationFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool get_IsRushLegend() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "PoolFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_ScriptLength", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public bool get_IsScriptless() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public bool get_IsTCG() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool get_IsTrinityUnbound() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsWCS() { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public sbyte get_Level() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LinkFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "LevelSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Card), Member = "get_ValidLevel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Card), Member = "get_CardTypeSortOrder", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CardLocalization), Member = "StarText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public sbyte get_LinkLevel() { }

	[CalledBy(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotClientCard), Member = "SetDefaultData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public ushort get_LinkMarker() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public sbyte get_LScale() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_MAXAttack() { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool get_NeedScript() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Card), Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Card), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Packs), typeof(Relations)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	public DateTime get_OCGReleaseDate() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_OT() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_PriceText() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public int get_Race() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public sbyte get_RScale() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public int get_RuleCode() { }

	[CalledBy(Type = typeof(CoreAPI), Member = "OnScriptReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32*)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Card), Member = "get_Script", ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "get_Script", ReturnType = typeof(IntPtr))]
	public IntPtr get_Script() { }

	[CalledBy(Type = typeof(CoreAPI), Member = "OnScriptReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32*)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Card), Member = "get_IsScriptless", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_HasScript", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	public int get_ScriptLength() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CardArchetype get_Setcode() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_SetID() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public long get_SupportSetCodes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_TCGPlayerPrice() { }

	[CalledBy(Type = typeof(DisplayCard), Member = "OnTapBuy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_TCGPlayerSearchLink() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Card), Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Card), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Packs), typeof(Relations)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	public DateTime get_TCGReleaseDate() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	public int get_ValidLevel() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "DateSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Deck), Member = "GetDateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	public DateTime GetReleaseDateFor(bool tcg) { }

	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(TextDataManager), Member = "TryGetSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public String[] GetSetCodesData() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "AttributeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "DefineGFX", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	public bool HasAttribute(CardAttribute attribute) { }

	[CallerCount(Count = 65)]
	[ContainsUnimplementedInstructions]
	public bool HasCategory(Category category) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "GenreFilterInclusive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "GenreFilterExclusive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 70)]
	[ContainsUnimplementedInstructions]
	public bool HasGenre(Genre genre) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "LinkFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineArrows", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public bool HasLinkMarker(CardLinkMarker dir) { }

	[CalledBy(Type = typeof(Banlist), Member = "FilterByAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardAttribute)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool HasOneAttribute(CardAttribute attribute) { }

	[CalledBy(Type = typeof(Banlist), Member = "FilterByCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Category)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool HasOneCategory(Category category) { }

	[CalledBy(Type = typeof(Banlist), Member = "FilterByRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardRace)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum", "System.UInt32Enum"}, ReturnType = typeof(bool))]
	public bool HasOneRace(CardRace race) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "SubTypeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "FilterByType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineAttribute", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(General), Member = "HasOneFlag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	public bool HasOneType(CardType type) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "RaceFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 32)]
	[ContainsUnimplementedInstructions]
	public bool HasRace(CardRace race) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool HasSetID(string setId) { }

	[CallerCount(Count = 172)]
	[ContainsUnimplementedInstructions]
	public bool HasType(CardType type) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool IsCollected() { }

	[CalledBy(Type = typeof(DeckFilters), Member = "GenreFilterInclusive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "GenreFilterExclusive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsHandTrap() { }

	[CalledBy(Type = "Scenes.Battle.CardOptionList+<>c", Member = "<OnSpecialSummon>b__70_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass58_0", Member = "<GetAllCards>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsReferenceCard() { }

	[CalledBy(Type = "Card.Manager+<LoadCustomScript>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsReferenceCard(int id) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "SupportFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(General), Member = "ToSetCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>))]
	[Calls(Type = typeof(Enumerable), Member = "Concat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(ushort)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSupportFor(Card card) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "SubTypeFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsTrapMonster() { }

	[CalledBy(Type = "Card.Manager+<LoadCustomScript>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "ToPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(Card), Member = "set_Script", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public void LoadScript(Byte[] script) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_AvgPrice(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CardMarketPrice(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CardText(CardLocalization value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_Genre(long value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsCustomCard(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_MAXAttack(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OCGReleaseDate(DateTime value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_OT(byte value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PriceText(string value) { }

	[CalledBy(Type = typeof(Card), Member = "LoadScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	private void set_Script(IntPtr value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void set_ScriptLength(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_Setcode(CardArchetype value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_SetID(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_SupportSetCodes(long value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_TCGPlayerPrice(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_TCGReleaseDate(DateTime value) { }

}

