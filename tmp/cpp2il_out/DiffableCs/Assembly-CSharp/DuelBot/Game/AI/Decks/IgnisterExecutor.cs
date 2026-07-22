namespace DuelBot.Game.AI.Decks;

internal class IgnisterExecutor : DefaultExecutor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameAI, BotDuel, Executor> <>9__0_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IgnisterExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int ParallelExceed = 71278040; //Field offset: 0x0
		public const int Cybersewicckid = 52698008; //Field offset: 0x0
		public const int Splashmage = 59859086; //Field offset: 0x0
		public const int UpdateJammer = 88093706; //Field offset: 0x0
		public const int DarkTemplar = 97383507; //Field offset: 0x0
		public const int TransCode = 46947713; //Field offset: 0x0
		public const int AccessCode = 86066372; //Field offset: 0x0
		public const int Zeroboros = 66403530; //Field offset: 0x0
		public const int Avramax = 21887175; //Field offset: 0x0
		public const int Darkfluid = 68934651; //Field offset: 0x0
		public const int Arrival = 11738489; //Field offset: 0x0
		public const int LightDragon = 61399402; //Field offset: 0x0
		public const int WindPegasus = 98506199; //Field offset: 0x0
		public const int IgnisterAIland = 59054773; //Field offset: 0x0
		public const int CalledByTheGrave = 24224830; //Field offset: 0x0
		public const int AIdlereborn = 22933016; //Field offset: 0x0
		public const int Terraforming = 73628505; //Field offset: 0x0
		public const int PotOfAvarice = 67169062; //Field offset: 0x0
		public const int CynetMining = 57160136; //Field offset: 0x0
		public const int FoolishBurialGoods = 35726888; //Field offset: 0x0
		public const int PotOfDesires = 35261759; //Field offset: 0x0
		public const int LightningStorm = 14532163; //Field offset: 0x0
		public const int Achichi = 15808381; //Field offset: 0x0
		public const int Bururu = 42429678; //Field offset: 0x0
		public const int Doyon = 88413677; //Field offset: 0x0
		public const int Pikari = 16020923; //Field offset: 0x0
		public const int BalancerLord = 8567955; //Field offset: 0x0
		public const int LadyDebug = 16188701; //Field offset: 0x0
		public const int LinkDisciple = 32995276; //Field offset: 0x0
		public const int Linguriboh = 24842059; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}

	private bool WasPikariSummoned; //Field offset: 0x78
	private bool WasDoyonSummoned; //Field offset: 0x79
	private bool WasBururuSummoned; //Field offset: 0x7A
	private bool WasAchichiSummoned; //Field offset: 0x7B
	private List<Int32> AvariceList; //Field offset: 0x80
	private List<Int32> Junk; //Field offset: 0x88
	private List<Int32> Cyberse; //Field offset: 0x90
	private List<Int32> TransCodeList; //Field offset: 0x98
	private List<Int32> LinkClimbing; //Field offset: 0xA0

	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallsUnknownMethods(Count = 7)]
	public IgnisterExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool AchichiEff() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool AchichiSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool BalancerEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool BururuEff() { }

	[CallerCount(Count = 0)]
	private bool BururuSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool CynetEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectThirdCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool DarkfluidSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool DebugEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool DiscipleSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool DoyonEff() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool DoyonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool fieldSpellEff() { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private bool KuribohEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool KuribohSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool LightDragonEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool LightDragonSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool MageEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool MageSp() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void OnNewTurn() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool OnSelectHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool ParallelEff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool PegasusEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool PegasusSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool PikariEff() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool PikariSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool stormEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool TemplarEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool TemplarSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool terraformingEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool TransCodeEff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool TransCodeSp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool when_avarice() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool when_foolish() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool whenFieldSpell() { }

}

