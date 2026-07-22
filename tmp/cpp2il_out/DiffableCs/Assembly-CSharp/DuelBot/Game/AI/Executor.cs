namespace DuelBot.Game.AI;

public abstract class Executor
{
	[CompilerGenerated]
	private Deck <Deck>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private BotDuel <BotDuel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private IList<CardExecutor> <Executors>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GameAI <AI>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private AIUtil <Util>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private BotMainPhase <Main>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private BotBattlePhase <Battle>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ExecutorType <Type>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private BotClientCard <DynamicCard>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private int <ActivateDescription>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private BotClientField <Bot>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private BotClientField <Enemy>k__BackingField; //Field offset: 0x68

	protected private int ActivateDescription
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

	public private GameAI AI
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	protected private BotBattlePhase Battle
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	protected private BotClientField Bot
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private BotDuel BotDuel
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

	public Deck Deck
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	protected private BotClientCard DynamicCard
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	protected private BotClientField Enemy
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private IList<CardExecutor> Executors
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

	protected private BotMainPhase Main
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	protected private ExecutorType Type
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

	public private AIUtil Util
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CalledBy(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.AI_Custom+<>c", Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.AI_Custom+<>c", Member = "<Init>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.AI_Custom+<>c", Member = "<Init>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CalledBy(Type = typeof(AI_Custom), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	protected Executor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <DefaultNoExecutor>b__82_0(CardExecutor exec) { }

	[CalledBy(Type = typeof(QliphortExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EvilswarmExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraydleExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.MokeyMokeyExecutor+<>c", Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.DrytronExecutor+<>c", Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CalledBy(Type = typeof(DrytronExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.TribrigadeExecutor+<>c", Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CalledBy(Type = typeof(TribrigadeExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DinocarriageDynarmixExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MokeyMokeyKingExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddExecutor(ExecutorType type) { }

	[CallerCount(Count = 91)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddExecutor(ExecutorType type, Func<Boolean> func) { }

	[CallerCount(Count = 481)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddExecutor(ExecutorType type, int cardId) { }

	[CallerCount(Count = 1658)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddExecutor(ExecutorType type, int cardId, Func<Boolean> func) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool DefaultNoExecutor() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected int get_ActivateDescription() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameAI get_AI() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected BotBattlePhase get_Battle() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected BotClientField get_Bot() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotDuel get_BotDuel() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Deck get_Deck() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected BotClientCard get_DynamicCard() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected BotClientField get_Enemy() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IList<CardExecutor> get_Executors() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected BotMainPhase get_Main() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected ExecutorType get_Type() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AIUtil get_Util() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override BattlePhaseAction OnBattle(IList<BotClientCard> attackers, IList<BotClientCard> defenders) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnCardSorting(IList<BotClientCard> cards) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnChainEnd() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnChaining(int player, BotClientCard card) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnDraw(int player) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnNewPhase() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnNewTurn() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool OnPreBattleBetween(BotClientCard attacker, BotClientCard defender) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override byte OnRockPaperScissors() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override BotClientCard OnSelectAttacker(IList<BotClientCard> attackers, IList<BotClientCard> defenders) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override BattlePhaseAction OnSelectAttackTarget(BotClientCard attacker, IList<BotClientCard> defenders) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool OnSelectBattleReplay() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectCard(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectFusionMaterial(IList<BotClientCard> cards, int min, int max) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool OnSelectHand() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectLinkMaterial(IList<BotClientCard> cards, int min, int max) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int OnSelectOption(IList<Int32> options) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectPendulumSummon(IList<BotClientCard> cards, int max) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int OnSelectPlace(int cardId, int player, CardLocation location, int available) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectRitualTribute(IList<BotClientCard> cards, int sum, int min, int max) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectSum(IList<BotClientCard> cards, int sum, int min, int max, int hint, bool mode) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectSynchroMaterial(IList<BotClientCard> cards, int sum, int min, int max) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IList<BotClientCard> OnSelectXyzMaterial(IList<BotClientCard> cards, int min, int max) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool OnSelectYesNo(int desc) { }

	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void ResetExecutors() { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ActivateDescription(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_AI(GameAI value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Battle(BotBattlePhase value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Bot(BotClientField value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BotDuel(BotDuel value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Deck(Deck value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_DynamicCard(BotClientCard value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Enemy(BotClientField value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Executors(IList<CardExecutor> value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Main(BotMainPhase value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Type(ExecutorType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Util(AIUtil value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetBattle(BotBattlePhase battle) { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(GameAI), Member = "OnSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GameAI), Member = "OnSelectEffectYn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GameAI), Member = "OnSelectIdleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(MainPhaseAction))]
	[CalledBy(Type = typeof(GameAI), Member = "Attack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(GameAI), Member = "ShouldExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardExecutor), typeof(BotClientCard), typeof(ExecutorType), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	public void SetCard(ExecutorType type, BotClientCard card, int description) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetMain(BotMainPhase main) { }

}

