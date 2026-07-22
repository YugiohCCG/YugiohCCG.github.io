namespace DuelBot.Game.AI;

public class AIUtil
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BotClientCard, Boolean> <>9__17_0; //Field offset: 0x8
		public static Func<BotClientCard, Nullable`1<Int32>> <>9__17_1; //Field offset: 0x10
		public static Func<BotClientCard, Nullable`1<Int32>> <>9__18_1; //Field offset: 0x18
		public static Func<BotClientCard, Int32> <>9__24_1; //Field offset: 0x20
		public static Func<BotClientCard, Int32> <>9__25_1; //Field offset: 0x28
		public static Func<BotClientCard, Int32> <>9__33_1; //Field offset: 0x30
		public static Func<BotClientCard, Boolean> <>9__34_0; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetBestBotMonster>b__24_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetBestEnemySpell>b__34_0(BotClientCard ecard) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Nullable<Int32> <GetBestPower>b__18_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetTotalAttackingMonsterAttack>b__17_0(BotClientCard m) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Nullable<Int32> <GetTotalAttackingMonsterAttack>b__17_1(BotClientCard m) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetWorstBotMonster>b__25_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetWorstEnemyMonster>b__33_1(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public bool onlyATK; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass18_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetBestPower>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public int value; //Field offset: 0x10
		public bool onlyATK; //Field offset: 0x14

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass20_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <IsOneEnemyBetterThanValue>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public int value; //Field offset: 0x10
		public bool onlyATK; //Field offset: 0x14

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass21_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <IsAllEnemyBetterThanValue>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public bool onlyATK; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass24_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetBestBotMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public bool onlyATK; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass25_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetWorstBotMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public int value; //Field offset: 0x10
		public bool onlyATK; //Field offset: 0x14
		public bool canBeTarget; //Field offset: 0x15

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass26_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetOneEnemyBetterThanValue>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public bool onlyATK; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass33_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetWorstEnemyMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public int id; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass43_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <ChainContainsCard>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Int32[] ids; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass44_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <ChainContainsCard>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public int player; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass45_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <ChainCountPlayer>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public int player; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass46_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <ChainContainPlayer>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public int player; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass47_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <HasChainedTrap>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private BotDuel <BotDuel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private BotClientField <Bot>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private BotClientField <Enemy>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GameBehavior <Behavior>k__BackingField; //Field offset: 0x28

	public GameBehavior Behavior
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public private BotClientField Bot
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

	public private BotDuel BotDuel
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

	public private BotClientField Enemy
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public AIUtil(BotDuel duel) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "OnChainEnd", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool ChainContainPlayer(int player) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool ChainContainsCard(Int32[] ids) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool ChainContainsCard(int id) { }

	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "EternalSouleff", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int ChainCountPlayer(int player) { }

	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(Rank5Executor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(PhantomKnights), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public IList<BotClientCard> CheckSelectCount(IList<BotClientCard> _selected, IList<BotClientCard> cards, int min, int max) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameBehavior get_Behavior() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotClientField get_Bot() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotDuel get_BotDuel() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotClientField get_Enemy() { }

	[CalledBy(Type = typeof(ST1732Executor), Member = "LinkSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "SkyCavalryCentaureaSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Stage_act", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "DarkRebellionXyzDragonSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "DarkRebellionXyzDragonEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	public int GetBestAttack(BotClientField field) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "HerculesBaseEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Rage_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Spinny_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "OrcustKnightmareEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MathmechExecutor), Member = "mathmech_equation_target", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MathmechExecutor), Member = "whom_addition", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "HeatLeo_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Tuner_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Borrelsword_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Needlefiber_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "TripleBurstDragon_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "WonderWandeff", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public BotClientCard GetBestBotMonster(bool onlyATK = false) { }

	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "DarkMagicalCircleeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VW_JiuJiu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VermillionDragonMech", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VWGate_ChuchePopEff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "DridentEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Rank5Executor), Member = "PanzerDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Rank5Executor), Member = "TirasKeeperOfGenesisEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "StealthEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "MistWurmeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "PhantasmSprialBattleeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "RustyBardicheEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "Michaeleff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "ShaddollDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "MekkKnightCrusadiaAstramEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "ScrapWyvernEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "Dracossackeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhotonExecutor), Member = "DestructionEff", ReturnType = typeof(bool))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemySpell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	public BotClientCard GetBestEnemyCard(bool onlyFaceup = false, bool canBeTarget = false) { }

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetHighestAttackMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BotClientCard GetBestEnemyMonster(bool onlyFaceup = false, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(AIUtil), Member = "GetBestEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "GalaxyCyclone", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "OnSelectYesNo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Rage_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Foxy_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MathmechExecutor), Member = "when_cosmic", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "CoralDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "HelixEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "ShaddollDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "MinervaTheExaltedEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "DragonSpiritOfWhiteEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdamatiaExecutor), Member = "when_dragite_excavate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultGalaxyCyclone", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "MinervaTheExaltedEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public BotClientCard GetBestEnemySpell(bool onlyFaceup = false) { }

	[CalledBy(Type = typeof(AIUtil), Member = "GetBestAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "GiganticastleSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultScarlightRedDragonArchfiendSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultStardustDragonSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultNumberS39UtopiaTheLightningSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultSmashingGround", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultRaigeki", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultInterruptedKaijuSlumber", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultHammerShot", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "IsOneEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultDarkHole", ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Nullable`1<Int32>>"}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public int GetBestPower(BotClientField field, bool onlyATK = false) { }

	[CalledBy(Type = typeof(Rank5Executor), Member = "HaveOtherLV5OnField", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	public int GetBotAvailZonesFromExtraDeck(BotClientCard remove) { }

	[CalledBy(Type = typeof(PureWindsExecutor), Member = "PilicaDescendantOfGustosu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "RedEyesFusionEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "MagicalizedFusionEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "Reasoningeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "GustoGulldosu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "GustoEgulsu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "WindaPriestessOfGustosu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "SpeedroidRedEyedDicesu", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "EmergencyTeleporteff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "SpeedroidTaketomborgsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "SuperTeamBuddyForceUniteeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "WindwitchSnowBellsp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "RescueRabbitSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Rank5Executor), Member = "NeedLV5", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public int GetBotAvailZonesFromExtraDeck() { }

	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "AlternativeWhiteDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "NeedlefiberSummonSecond", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "GalateaSummonSecond", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "BorrelswordDragonSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 10)]
	public int GetBotAvailZonesFromExtraDeck(IList<BotClientCard> remove) { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsUnknownMethods(Count = 1)]
	public BotClientCard GetLastChainCard() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetBestEnemyCard_random", ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Meluseek_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Multifaker_handss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate_better", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_activate_not_use", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "MonsterSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Red_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	public BotClientCard GetOneEnemyBetterThanMyBest(bool onlyATK = false, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultKaijuSpsummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "MagicianNavigationeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "StarliegePaladynamoSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "StarliegePaladynamoEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Red_SelectPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Crown_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "DarkRebellionXyzDragonEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BotClientCard GetOneEnemyBetterThanValue(int value, bool onlyATK = false, bool canBeTarget = false) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetDangerousMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetInvincibleMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsUnknownMethods(Count = 1)]
	public BotClientCard GetProblematicEnemyCard(int attack = 0, bool canBeTarget = false) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetDangerousMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetInvincibleMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsUnknownMethods(Count = 1)]
	public BotClientCard GetProblematicEnemyMonster(int attack = 0, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Phoneix_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Phoneix_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "TG_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Crystal_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Feather_Act", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "KagariEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "GetCardToSearch", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "SheorcustDingirsuEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "CoralDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "CrystronNeedlefibereff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Feather_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsUnknownMethods(Count = 1)]
	public BotClientCard GetProblematicEnemySpell() { }

	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "HeavyStormDustereff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "UnendingNightmareeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "SaqlificeEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ScoutActivate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ScaleActivate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ShouldPendulum", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	public BotClientCard GetPZone(int player, int id) { }

	[CallerCount(Count = 37)]
	public int GetStringId(int id, int option) { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultScapegoat", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "DrowningMirrorForceeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "GoToBattlePhase", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "DrowningMirrorForceeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "Number39UtopiaBeyond", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Nullable`1<Int32>>"}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int GetTotalAttackingMonsterAttack(int player) { }

	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "MagiciansRodeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MathmechExecutor), Member = "how_to_cynet_mine", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public BotClientCard GetWorstBotMonster(bool onlyATK = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public BotClientCard GetWorstEnemyMonster(bool onlyATK = false) { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultEffectVeiler", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultInfiniteImpermanence", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultBreakthroughSkill", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultTorrentialTribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultUniqueTrap", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "FogBladeEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "Number39Utopia", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasChainedTrap(int player) { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectIdleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(MainPhaseAction))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultBookOfMoon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultCallOfTheHaunted", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultTorrentialTribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultMonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "Repos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "Repos", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAllEnemyBetter(bool onlyATK = false) { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectIdleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(MainPhaseAction))]
	[CalledBy(Type = typeof(FrogExecutor), Member = "SwapFrogSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HorusExecutor), Member = "WhiteNightDragon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "DecisiveArmorEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "BrionacEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "ThousandHandsEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "SelectNekrozWhoInvoke", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "Number37HopeWovenDragonSpiderSharkSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "EvolzarLaggiaSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "IsAllEnemyBetter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAllEnemyBetterThanValue(int value, bool onlyATK) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsChainTarget(BotClientCard card) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnJudgment_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "SolemnJudgment_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsChainTargetOnly(BotClientCard card) { }

	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsEndPhase() { }

	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsMyTurn() { }

	[CalledBy(Type = typeof(FrogExecutor), Member = "PotOfDuality", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "Reborneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "ShaddollFusioneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "GungnirEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OldSchoolExecutor), Member = "SwordsOfRevealingLight", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "Reborneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "Number59CrookedCookSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ST1732Executor), Member = "LinkSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "AleisterTheInvokerEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "CatSharkSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "SkyCavalryCentaureaSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "DaigustoPhoenixSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	public bool IsOneEnemyBetter(bool onlyATK = false) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CardContainer), Member = "GetMonsters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsOneEnemyBetterThanValue(int value, bool onlyATK) { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsTurn1OrMain2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public IList<BotClientCard> SelectPreferredCards(BotClientCard preferred, IList<BotClientCard> cards, int min, int max) { }

	[CalledBy(Type = typeof(YosenjuExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public IList<BotClientCard> SelectPreferredCards(int preferred, IList<BotClientCard> cards, int min, int max) { }

	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 9)]
	public IList<BotClientCard> SelectPreferredCards(IList<BotClientCard> preferred, IList<BotClientCard> cards, int min, int max) { }

	[CalledBy(Type = typeof(Rank5Executor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(PhantomKnights), Member = "OnSelectXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public IList<BotClientCard> SelectPreferredCards(IList<Int32> preferred, IList<BotClientCard> cards, int min, int max) { }

	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnSelectYesNo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualTestExecutor), Member = "OnRockPaperScissors", ReturnType = typeof(byte))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SendPacket(Byte[] data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Behavior(GameBehavior value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Bot(BotClientField value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BotDuel(BotDuel value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Enemy(BotClientField value) { }

}

