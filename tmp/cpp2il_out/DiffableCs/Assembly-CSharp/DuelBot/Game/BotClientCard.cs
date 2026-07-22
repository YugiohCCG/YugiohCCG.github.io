namespace DuelBot.Game;

public class BotClientCard
{
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Card <Data>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Position>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <Sequence>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private CardLocation <Location>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <Alias>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <Level>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <Rank>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <Type>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <Attribute>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <Race>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <Attack>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private int <Defense>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private int <LScale>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private int <RScale>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <LinkCount>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private int <LinkMarker>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <Cover>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private int <BaseAttack>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private int <BaseDefense>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private int <RealPower>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private List<Int32> <Overlays>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private int <Owner>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private int <Controller>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private int <Disabled>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <ProcCompleted>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private int <SelectSeq>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private int <OpParam1>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private int <OpParam2>k__BackingField; //Field offset: 0x98
	public readonly List<BotClientCard> EquipCards; //Field offset: 0xA0
	public BotClientCard EquipTarget; //Field offset: 0xA8
	public readonly List<BotClientCard> OwnTargets; //Field offset: 0xB0
	public readonly List<BotClientCard> TargetCards; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <CanDirectAttack>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private bool <ShouldDirectAttack>k__BackingField; //Field offset: 0xC1
	[CompilerGenerated]
	private bool <Attacked>k__BackingField; //Field offset: 0xC2
	[CompilerGenerated]
	private bool <IsLastAttacker>k__BackingField; //Field offset: 0xC3
	[CompilerGenerated]
	private bool <IsSpecialSummoned>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Int32[] <ActionIndex>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private IDictionary<Int32, Int32> <ActionActivateIndex>k__BackingField; //Field offset: 0xD0

	public private IDictionary<Int32, Int32> ActionActivateIndex
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

	public Int32[] ActionIndex
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public private int Alias
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int Attack
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool Attacked
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public private int Attribute
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int BaseAttack
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int BaseDefense
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool CanDirectAttack
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public private int Controller
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

	public private int Cover
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private Card Data
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private int Defense
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int Disabled
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

	public private int Id
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

	public bool IsLastAttacker
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsSpecialSummoned
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private int Level
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int LinkCount
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int LinkMarker
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public CardLocation Location
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public private int LScale
	{
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private string Name
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public int OpParam1
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public int OpParam2
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public private List<Int32> Overlays
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private int Owner
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

	public int Position
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public private int ProcCompleted
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

	public private int Race
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int Rank
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int RealPower
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

	public private int RScale
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public int SelectSeq
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public int Sequence
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool ShouldDirectAttack
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public private int Type
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotClientField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotDuel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnTagSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnCardSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public BotClientCard(int id, CardLocation loc, int sequence, int position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public BotClientCard(int id, CardLocation loc, int sequence) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnPosChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void ClearCardTargets() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Equals(BotClientCard card) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IDictionary<Int32, Int32> get_ActionActivateIndex() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Int32[] get_ActionIndex() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Alias() { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Attack() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Attacked() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Attribute() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_BaseAttack() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_BaseDefense() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_CanDirectAttack() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Controller() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Cover() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Card get_Data() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Defense() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Disabled() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Id() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsLastAttacker() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_IsSpecialSummoned() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Level() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LinkCount() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LinkMarker() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CardLocation get_Location() { }

	[CallerCount(Count = 14)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LScale() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_OpParam1() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_OpParam2() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public List<Int32> get_Overlays() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Owner() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Position() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ProcCompleted() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Race() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Rank() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_RealPower() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_RScale() { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_SelectSeq() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Sequence() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ShouldDirectAttack() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Type() { }

	[CallerCount(Count = 54)]
	public int GetDefensePower() { }

	[CalledBy(Type = typeof(BotClientCard), Member = "SetDefaultData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public byte GetLinkCount() { }

	[CalledBy(Type = typeof(BotClientField), Member = "GetLinkedZones", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public int GetLinkedZones() { }

	[CalledBy(Type = "DuelBot.Game.AI.DefaultExecutor+<>c", Member = "<DefaultAllureofDarkness>b__49_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesMaxDragonExecutor), Member = "MissusRadiantsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "MissusRadiantsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "ShaddollFusioneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "GozenMatcheff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "PacifisThePhantasmCityeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "MissusRadiantsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "InvocationEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Missus_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 23)]
	[ContainsUnimplementedInstructions]
	public bool HasAttribute(CardAttribute attribute) { }

	[CallerCount(Count = 25)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool HasLinkMarker(CardLinkMarker dir) { }

	[CallerCount(Count = 25)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool HasLinkMarker(int dir) { }

	[CallerCount(Count = 32)]
	[ContainsUnimplementedInstructions]
	public bool HasPosition(CardPosition position) { }

	[CalledBy(Type = typeof(RushExecutor), Member = "tenacityEff", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool HasRace(CardRace race) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	public bool HasSetcode(int setcode) { }

	[CallerCount(Count = 125)]
	[ContainsUnimplementedInstructions]
	public bool HasType(CardType type) { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool HasXyzMaterial(int count, int cardid) { }

	[CalledBy(Type = typeof(MathmechExecutor), Member = "mathchalenEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "Number39Utopia", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool HasXyzMaterial(int count) { }

	[CalledBy(Type = typeof(Rank5Executor), Member = "GaiaDragonTheThunderChargerSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "WhiptailEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	public bool HasXyzMaterial() { }

	[CallerCount(Count = 59)]
	[ContainsUnimplementedInstructions]
	public bool IsAttack() { }

	[CalledBy(Type = "DuelBot.Game.AI.DefaultExecutor+<>c", Member = "<DefaultCallOfTheHaunted>b__13_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.DragunityExecutor+<>c", Member = "<MonsterReborn>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.DragunityExecutor+<>c", Member = "<MonsterReborn>b__9_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.HorusExecutor+<>c", Member = "<MonsterReborn>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.HorusExecutor+<>c", Member = "<MonsterReborn>b__5_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool IsCanRevive() { }

	[CallerCount(Count = 337)]
	[ContainsUnimplementedInstructions]
	public bool IsCode(int id) { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultKaijuSpsummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Should_activate_Protocol", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Is_should_not_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "WakingtheDragon_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "SelectNekrozWhoInvoke", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ST1732Executor), Member = "KleinantEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "is_should_not_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "ToadallyAwesomeEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Awaken_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsCode(IList<Int32> ids) { }

	[CallerCount(Count = 75)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
	public bool IsCode(Int32[] ids) { }

	[CallerCount(Count = 31)]
	[ContainsUnimplementedInstructions]
	public bool IsDefense() { }

	[CallerCount(Count = 67)]
	[ContainsUnimplementedInstructions]
	public bool IsDisabled() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsExtraCard() { }

	[CallerCount(Count = 71)]
	[ContainsUnimplementedInstructions]
	public bool IsFacedown() { }

	[CallerCount(Count = 95)]
	[ContainsUnimplementedInstructions]
	public bool IsFaceup() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnJudgment_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunityExecutor), Member = "MonsterReborn", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HorusExecutor), Member = "BellowOfTheSilverDragon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HorusExecutor), Member = "MonsterReborn", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OldSchoolExecutor), Member = "DoubleSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ST1732Executor), Member = "CynetUniverseEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "OtherMonsterEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Crown_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "GraveCall_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "DarkHole_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	public bool IsMonster() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "ImperialOrder_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "AreaZeroEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "MultiroleEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "HaveThreeSpellsInGrave", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "OtherSpellEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "spell_trap_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public bool IsSpell() { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultSpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetFloodgate_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_activate_not_use", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "BrunSpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "OtherTrapEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "spell_trap_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	public bool IsTrap() { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c__DisplayClass51_0", Member = "<ShootingRiserDragonEffect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<EmergencyTeleport>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "HornetDronesEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.OrcustExecutor+<>c", Member = "<ShootingRiserDragonEffect>b__35_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.OrcustExecutor+<>c", Member = "<ShootingRiserDragonEffect>b__35_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.OrcustExecutor+<>c", Member = "<ShootingRiserDragonEffect>b__35_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c__DisplayClass51_0", Member = "<ShootingRiserDragonEffect>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<VermillionDragonMech>b__40_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c__DisplayClass51_0", Member = "<ShootingRiserDragonEffect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c", Member = "<ShootingRiserDragonSummon>b__50_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c", Member = "<MaskedChameleonEffect>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c", Member = "<CrystronNeedlefiberEffect>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor+<>c", Member = "<CrystronNeedlefiberSummon>b__27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.DragunExecutor+<>c", Member = "<SummonForMaterial>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Needlefiber_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GR_WC_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<EmergencyTeleport>b__33_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<VermillionDragonMech>b__40_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public bool IsTuner() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ActionActivateIndex(IDictionary<Int32, Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ActionIndex(Int32[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Alias(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Attack(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Attacked(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Attribute(int value) { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BaseAttack(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BaseDefense(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CanDirectAttack(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Controller(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Cover(int value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Data(Card value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Defense(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Disabled(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Id(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_IsLastAttacker(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_IsSpecialSummoned(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Level(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LinkCount(int value) { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LinkMarker(int value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Location(CardLocation value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LScale(int value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_OpParam1(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_OpParam2(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Overlays(List<Int32> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Owner(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Position(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ProcCompleted(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Race(int value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Rank(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RealPower(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RScale(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SelectSeq(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Sequence(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ShouldDirectAttack(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Type(int value) { }

	[CalledBy(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_LinkMarker", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(BotClientCard), Member = "GetLinkCount", ReturnType = typeof(byte))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public void SetDefaultData() { }

	[CalledBy(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectEffectYn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnCardSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnShuffleSetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnShuffleHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnShuffleDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotDuel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(BotClientCard), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnShuffleExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(BotClientCard), Member = "SetDefaultData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public void SetId(int id) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnUpdateCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnUpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 34)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Update(BinaryReader packet, BotDuel duel) { }

}

