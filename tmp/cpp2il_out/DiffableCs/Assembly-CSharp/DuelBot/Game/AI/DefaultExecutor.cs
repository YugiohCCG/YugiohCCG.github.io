namespace DuelBot.Game.AI;

public abstract class DefaultExecutor : Executor
{
	internal class _CardId
	{
		public const int JizukirutheStarDestroyingKaiju = 63941210; //Field offset: 0x0
		public const int PhantomKnightsFogBlade = 25542642; //Field offset: 0x0
		public const int VampireFraeulein = 6039967; //Field offset: 0x0
		public const int InjectionFairyLily = 79575620; //Field offset: 0x0
		public const int BlueEyesChaosMAXDragon = 55410871; //Field offset: 0x0
		public const int AshBlossom = 14558127; //Field offset: 0x0
		public const int MaxxC = 23434538; //Field offset: 0x0
		public const int LockBird = 94145021; //Field offset: 0x0
		public const int GhostOgreAndSnowRabbit = 59438930; //Field offset: 0x0
		public const int GhostBelle = 73642296; //Field offset: 0x0
		public const int EffectVeiler = 63845230; //Field offset: 0x0
		public const int ArtifactLancea = 34267821; //Field offset: 0x0
		public const int CalledByTheGrave = 24224830; //Field offset: 0x0
		public const int InfiniteImpermanence = 10045474; //Field offset: 0x0
		public const int GalaxySoldier = 46659709; //Field offset: 0x0
		public const int MacroCosmos = 30241314; //Field offset: 0x0
		public const int UpstartGoblin = 70368879; //Field offset: 0x0
		public const int CyberEmergency = 60600126; //Field offset: 0x0
		public const int EaterOfMillions = 63845230; //Field offset: 0x0
		public const int InvokedPurgatrio = 12307878; //Field offset: 0x0
		public const int ChaosAncientGearGiant = 51788412; //Field offset: 0x0
		public const int UltimateAncientGearGolem = 12652643; //Field offset: 0x0
		public const int RedDragonArchfiend = 70902743; //Field offset: 0x0
		public const int ImperialOrder = 61740673; //Field offset: 0x0
		public const int MoonMirrorShield = 19508728; //Field offset: 0x0
		public const int MekkKnightCrusadiaAstram = 21887175; //Field offset: 0x0
		public const int UltimayaTzolkin = 1686814; //Field offset: 0x0
		public const int Number39Utopia = 84013237; //Field offset: 0x0
		public const int ThunderKingtheLightningstrikeKaiju = 48770333; //Field offset: 0x0
		public const int DogorantheMadFlameKaiju = 93332803; //Field offset: 0x0
		public const int RadiantheMultidimensionalKaiju = 28674152; //Field offset: 0x0
		public const int GadarlatheMysteryDustKaiju = 36956512; //Field offset: 0x0
		public const int KumongoustheStickyStringKaiju = 29726552; //Field offset: 0x0
		public const int GamecieltheSeaTurtleKaiju = 55063751; //Field offset: 0x0
		public const int SuperAntiKaijuWarMachineMechaDogoran = 84769941; //Field offset: 0x0
		public const int UltimateConductorTytanno = 18940556; //Field offset: 0x0
		public const int ElShaddollConstruct = 20366274; //Field offset: 0x0
		public const int AllyOfJusticeCatastor = 26593852; //Field offset: 0x0
		public const int DupeFrog = 46239604; //Field offset: 0x0
		public const int NaturiaBeast = 33198837; //Field offset: 0x0
		public const int MaraudingCaptain = 2460565; //Field offset: 0x0
		public const int JudgmentDragon = 57774843; //Field offset: 0x0
		public const int TopologicTrisbaena = 72529749; //Field offset: 0x0
		public const int EvilswarmExcitonKnight = 46772449; //Field offset: 0x0
		public const int HarpiesFeatherDuster = 18144506; //Field offset: 0x0
		public const int DarkMagicAttack = 2314238; //Field offset: 0x0
		public const int MysticalSpaceTyphoon = 5318639; //Field offset: 0x0
		public const int CosmicCyclone = 8267140; //Field offset: 0x0
		public const int ChickenGame = 67616300; //Field offset: 0x0
		public const int CastelTheSkyblasterMusketeer = 82633039; //Field offset: 0x0
		public const int CrystalWingSynchroDragon = 50954680; //Field offset: 0x0
		public const int NumberS39UtopiaTheLightning = 56832966; //Field offset: 0x0
		public const int BlackRoseDragon = 73580471; //Field offset: 0x0
		public const int AntiSpellFragrance = 58921041; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public _CardId() { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BotClientCard, Boolean> <>9__4_1; //Field offset: 0x8
		public static Func<BotClientCard, Boolean> <>9__8_0; //Field offset: 0x10
		public static Func<BotClientCard, Boolean> <>9__8_1; //Field offset: 0x18
		public static Func<BotClientCard, Boolean> <>9__8_2; //Field offset: 0x20
		public static Func<BotClientCard, Boolean> <>9__10_0; //Field offset: 0x28
		public static Func<BotClientCard, Boolean> <>9__13_0; //Field offset: 0x30
		public static Func<BotClientCard, Int32> <>9__13_1; //Field offset: 0x38
		public static Func<BotClientCard, Boolean> <>9__49_0; //Field offset: 0x40
		public static Func<BotClientCard, Nullable`1<Int32>> <>9__56_0; //Field offset: 0x48
		public static Func<BotClientCard, Nullable`1<Int32>> <>9__56_1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <DefaultAllureofDarkness>b__49_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCanRevive", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <DefaultCallOfTheHaunted>b__13_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <DefaultCallOfTheHaunted>b__13_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Nullable<Int32> <DefaultEvilswarmExcitonKnightEffect>b__56_0(BotClientCard monster) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Nullable<Int32> <DefaultEvilswarmExcitonKnightEffect>b__56_1(BotClientCard monster) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <DefaultGalaxyCyclone>b__10_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <DefaultMysticalSpaceTyphoon>b__8_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <DefaultMysticalSpaceTyphoon>b__8_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <DefaultMysticalSpaceTyphoon>b__8_2(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnPreBattleBetween>b__4_1(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public BotClientCard defender; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass4_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnPreBattleBetween>b__0(BotClientCard monster) { }

	}

	private int HonestEffectCount; //Field offset: 0x70

	[CallerCount(Count = 59)]
	[Calls(Type = typeof(Executor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected DefaultExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool <DefaultChickenGame>b__48_0(CardExecutor exec) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool <DefaultDontChainMyself>b__47_0(CardExecutor exec) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <DefaultScarlightRedDragonArchfiendEffect>b__62_0(BotClientCard monster) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <DefaultScarlightRedDragonArchfiendEffect>b__62_1(BotClientCard monster) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <UniqueFaceupMonster>b__46_0(BotClientCard card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <UniqueFaceupSpell>b__45_0(BotClientCard card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultAllureofDarkness() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultAshBlossomAndJoyousSpring() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(CardContainer), Member = "GetHighestAttackMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultBookOfMoon() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AIUtil), Member = "HasChainedTrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupSpell", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultDisableMonster", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected bool DefaultBreakthroughSkill() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupSpell", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	protected bool DefaultCalledByTheGrave() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected bool DefaultCallOfTheHaunted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultCastelTheSkyblasterMusketeerEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected bool DefaultCastelTheSkyblasterMusketeerSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultChickenGame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultCompulsoryEvacuationDevice() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultMysticalSpaceTyphoon", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 11)]
	protected bool DefaultCosmicCyclone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected bool DefaultDarkHole() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsOneForXyz", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	protected bool DefaultDimensionalBarrier() { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultEffectVeiler", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultInfiniteImpermanence", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultBreakthroughSkill", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "FogBladeEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultDisableMonster() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultDontChainMyself() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "HasChainedTrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupSpell", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultDisableMonster", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultEffectVeiler() { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultEvilswarmExcitonKnightSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Nullable`1<Int32>>"}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultEvilswarmExcitonKnightEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetHandCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultEvilswarmExcitonKnightEffect", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultEvilswarmExcitonKnightSummon() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected bool DefaultField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemySpell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected bool DefaultGalaxyCyclone() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected bool DefaultGhostBelleAndHauntedMansion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultGhostOgreAndSnowRabbit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultHammerShot() { }

	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "DarkMagicAttackeff", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultHarpiesFeatherDusterFirst() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultHeavyStorm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultHonestEffect() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AIUtil), Member = "HasChainedTrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupSpell", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultDisableMonster", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected bool DefaultInfiniteImpermanence() { }

	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "InterruptedKaijuSlumbereff", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultInterruptedKaijuSlumber() { }

	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "GamecieltheSeaTurtleKaijusp", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "RadiantheMultidimensionalKaijusp", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetDangerousMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultKaijuSpsummon() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected bool DefaultMaxxC() { }

	[CalledBy(Type = typeof(BurnExecutor), Member = "ReposEverything", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "MonsterRepos", ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultMonsterRepos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultMonsterSummon() { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultCosmicCyclone", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "CosmicCycloneeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "CosmicCycloneeff", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected bool DefaultMysticalSpaceTyphoon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultNumberS39UtopiaTheLightningEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultNumberS39UtopiaTheLightningSummon() { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected bool DefaultOnBecomeTarget() { }

	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "PotOfDesires", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultPotOfDesires() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected bool DefaultRaigeki() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetTotalAttackingMonsterAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected bool DefaultScapegoat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultScarlightRedDragonArchfiendEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultScarlightRedDragonArchfiendSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected bool DefaultSmashingGround() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnJudgment_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultSolemnJudgment() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnStrike_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "SolemnStrike_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultSolemnStrike() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultSolemnWarning() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected bool DefaultSpellMustSetFirst() { }

	[CalledBy(Type = typeof(TrickstarExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCountWithoutField", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultSpellSet() { }

	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "UpstartGoblineff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "PotOfDualityeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "PotOfDesireseff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "CardOfDemiseeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "MoonMirrorShieldeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "CardOfDemiseeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "FossilDigeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "Terraformingeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "PacifisThePhantasmCityeff", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultSpellWillBeNegated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultStardustDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultStardustDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "HasChainedTrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultTorrentialTribute() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected bool DefaultTrap() { }

	[CalledBy(Type = typeof(HorusExecutor), Member = "WhiteNightDragon", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected bool DefaultTributeSummon() { }

	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "ThreateningRoareff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "Wabokueff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "BlazingMirrorForceeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "MagicCylindereff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "DrowningMirrorForceeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "PhatomKnightsSwordeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "SkillDrainEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Called_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(AIUtil), Member = "HasChainedTrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "UniqueFaceupSpell", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool DefaultUniqueTrap() { }

	[CalledBy(Type = typeof(BlueEyesMaxDragonExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public virtual void OnNewTurn() { }

	[CalledBy(Type = typeof(ChainBurnExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DarkMagicianExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PhantasmExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterHasPreventActivationEffectInBattle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterInvincible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterDangerous", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	public virtual bool OnPreBattleBetween(BotClientCard attacker, BotClientCard defender) { }

	[CalledBy(Type = typeof(BlueEyesMaxDragonExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "Attack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(BattlePhaseAction))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public virtual BattlePhaseAction OnSelectAttackTarget(BotClientCard attacker, IList<BotClientCard> defenders) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool OnSelectBattleReplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions) { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultMonsterSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultTributeSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected bool UniqueFaceupMonster() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected bool UniqueFaceupSpell() { }

}

