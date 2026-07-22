namespace DuelBot.Game;

public class GameAI
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BotClientCard, Int32> <>9__20_0; //Field offset: 0x8

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
		internal int <OnSelectBattleCmd>b__20_0(BotClientCard c) { }

	}

	[CompilerGenerated]
	private GameBehavior <Game>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private BotDuel <Duel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Executor <Executor>k__BackingField; //Field offset: 0x20
	private CardSelector m_materialSelector; //Field offset: 0x28
	private int m_place; //Field offset: 0x30
	private int m_option; //Field offset: 0x34
	private int m_number; //Field offset: 0x38
	private int m_announce; //Field offset: 0x3C
	private int m_yesno; //Field offset: 0x40
	private readonly IList<CardAttribute> m_attributes; //Field offset: 0x48
	private readonly IList<CardSelector> m_selector; //Field offset: 0x50
	private readonly IList<CardPosition> m_position; //Field offset: 0x58
	private int m_selector_pointer; //Field offset: 0x60
	private readonly IList<CardRace> m_races; //Field offset: 0x68

	public private BotDuel Duel
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

	public Executor Executor
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public private GameBehavior Game
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public GameAI(GameBehavior game, BotDuel duel) { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(BlueEyesMaxDragonExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Executor), Member = "SetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public BattlePhaseAction Attack(BotClientCard attacker, BotClientCard defender) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void CleanSelectMaterials() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotDuel get_Duel() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Executor get_Executor() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameBehavior get_Game() { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public CardSelector GetSelectedCards() { }

	[CalledBy(Type = typeof(PureWindsExecutor), Member = "WindwitchIceBelleff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "WindwitchWinterBellsp", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public CardPosition GetSelectedPosition() { }

	[CalledBy(Type = typeof(DinocarriageDynarmixExecutor), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(MokeyMokeyKingExecutor), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool HaveSelectedCards() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32Enum>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override IList<CardAttribute> OnAnnounceAttrib(int count, IList<CardAttribute> attributes) { }

	[CallerCount(Count = 0)]
	public int OnAnnounceCard() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int OnAnnounceNumber(IList<Int32> numbers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32Enum>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.UInt32Enum>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override IList<CardRace> OnAnnounceRace(int count, IList<CardRace> races) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IList<BotClientCard> OnCardSorting(IList<BotClientCard> cards) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnChainEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnChaining(BotClientCard card, int player) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnDraw(int player) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnNewPhase() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnNewTurn() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public byte OnRockPaperScissors() { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "ToMainPhase2", ReturnType = typeof(BattlePhaseAction))]
	[Calls(Type = typeof(GameAI), Member = "ToEndPhase", ReturnType = typeof(BattlePhaseAction))]
	[Calls(Type = typeof(Executor), Member = "SetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(GameAI), Member = "Attack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(BattlePhaseAction))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	public BattlePhaseAction OnSelectBattleCmd(BotBattlePhase battle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool OnSelectBattleReplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "GetSelectedCards", ReturnType = typeof(CardSelector))]
	[Calls(Type = typeof(CardSelector), Member = "Select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	public IList<BotClientCard> OnSelectCard(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Executor), Member = "SetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public int OnSelectChain(IList<BotClientCard> cards, IList<Int32> descs, bool forced) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public IList<Int16> OnSelectCounter(short type, short quantity, IList<BotClientCard> cards, IList<Int16> counters) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectEffectYn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Executor), Member = "SetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public bool OnSelectEffectYn(BotClientCard card, int desc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool OnSelectHand() { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectIdleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Executor), Member = "SetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 102)]
	public MainPhaseAction OnSelectIdleCmd(BotMainPhase main) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int OnSelectOption(IList<Int32> options) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int OnSelectPlace(int cardId, int player, CardLocation location, int available) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardSelector), Member = "Select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(CardContainer), Member = "GetCombinations", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<IEnumerable`1<T>>")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 124)]
	public IList<BotClientCard> OnSelectSum(IList<BotClientCard> cards, int sum, int min, int max, int hint, bool mode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public IList<BotClientCard> OnSelectTribute(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool OnSelectYesNo(int desc) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void SelectAnnounceID(int id) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SelectAttribute(CardAttribute attribute) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SelectAttributes(CardAttribute[] attributes) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Storm_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "TG_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Eater_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "HerculesBaseEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "CoralDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "BlackRoseMoonlightDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "FairyTailSnoweff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "ScarlightRedDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "HeavyStormDustereff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FrogExecutor), Member = "FlipFlopFrog", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "DarkMagicInheritanceeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "MagicianNavigationeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "EternalSouleff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "EaterOfMillionssp", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SelectCard(IList<BotClientCard> cards) { }

	[CallerCount(Count = 418)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SelectCard(int cardId) { }

	[CalledBy(Type = typeof(FrogExecutor), Member = "DupeFrog", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SelectCard(CardLocation loc) { }

	[CallerCount(Count = 183)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SelectCard(Int32[] ids) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SelectCard(IList<Int32> ids) { }

	[CallerCount(Count = 187)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SelectCard(BotClientCard card) { }

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMaterials(IList<BotClientCard> cards) { }

	[CalledBy(Type = typeof(DragunExecutor), Member = "RedEyesFusionEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "MagicalizedFusionEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "PredaplantVerteAnacondaEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMaterials(CardLocation loc) { }

	[CalledBy(Type = typeof(DragunExecutor), Member = "SalamangreatAlmirajSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "PredaplantVerteAnacondaSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "CrystronNeedlefiberSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "ScrapWyvernSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "CrystronNeedlefiberSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "MekkKnightCrusadiaAstramSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "NeedlefiberSummonFirst", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "KnightmarePhoenixSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "SunlightWolf_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "BroadbullXYZSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "DridentSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "DaigustoEmeralSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMaterials(IList<Int32> ids) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Anima_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "LinkSpiderSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Stallio_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Veilynx_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "ChakanineSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "TigermortarSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "BroadbullSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMaterials(int cardId) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Anima_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesMaxDragonExecutor), Member = "Linkuribohsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunityExecutor), Member = "DragunityArmaMysletainnTribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "Linkuribohsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "AlmirajSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "Linkuribohsp", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMaterials(BotClientCard card) { }

	[CalledBy(Type = typeof(DragunityExecutor), Member = "DragonsMirror", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "MinervaTheExaltedEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "MinervaTheExaltedEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ST1732Executor), Member = "LinkslayerEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Rage_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "TwinTwistersEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Unicorn_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DinocarriageDynarmixExecutor), Member = "大恐龙驾Effect", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextCard(IList<BotClientCard> cards) { }

	[CalledBy(Type = typeof(IgnisterExecutor), Member = "TransCodeSp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "CrystronNeedlefibersp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResonatorExecutor), Member = "demonsEff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "SunlightWolf_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "MultiroleEPEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "ConstellarPtolemyM7", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextCard(IList<Int32> ids) { }

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextCard(BotClientCard card) { }

	[CallerCount(Count = 89)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextCard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextCard(CardLocation loc) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectNextCard(Int32[] ids) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SelectNumber(int number) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SelectOption(int opt) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void SelectPlace(int zones) { }

	[CallerCount(Count = 107)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectPosition(CardPosition pos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SelectRace(CardRace race) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SelectRaces(CardRace[] races) { }

	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "DoubleEvolutionPilleff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "TigermortarEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Awaken_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectThirdCard(Int32[] ids) { }

	[CalledBy(Type = typeof(PureWindsExecutor), Member = "MistWurmeff", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectThirdCard(BotClientCard card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectThirdCard(IList<BotClientCard> cards) { }

	[CalledBy(Type = typeof(AdamatiaExecutor), Member = "when_blockdragon_add", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IgnisterExecutor), Member = "DarkfluidSp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MathmechExecutor), Member = "mathchalenEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResonatorExecutor), Member = "demonsEff", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectThirdCard(int cardId) { }

	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "MultiroleEPEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectThirdCard(IList<Int32> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardSelector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SelectThirdCard(CardLocation loc) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyKingExecutor), Member = "火星心少女Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = "火星心少女Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VW_Lili", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VW_Laolao", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VW_Lulu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Snake_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "FireFormationTenkiEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "BroadbullXYZSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "BroadbullSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "TigermortarSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "ChakanineSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "SeaStealthAttackeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "EngageEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "LightStageEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "UltimateConductorTytannoeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "MagiciansSoulsEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "EternalSouleff", ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectYesNo(bool opt) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Duel(BotDuel value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Executor(Executor value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Game(GameBehavior value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Executor), Member = "SetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldExecute(CardExecutor exec, BotClientCard card, ExecutorType type, int desc = -1) { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(BattlePhaseAction))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BattlePhaseAction ToEndPhase() { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(BattlePhaseAction))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BattlePhaseAction ToMainPhase2() { }

}

