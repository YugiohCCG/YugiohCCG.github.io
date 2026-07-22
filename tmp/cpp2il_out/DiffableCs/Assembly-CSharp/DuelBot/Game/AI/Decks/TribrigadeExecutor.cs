namespace DuelBot.Game.AI.Decks;

public class TribrigadeExecutor : DefaultExecutor
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
		[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int AshBlossomJoyousSpring = 14558127; //Field offset: 0x0
		public const int BowOfTheGoddess = 4280258; //Field offset: 0x0
		public const int DivineArsenalSkyThunder = 90448279; //Field offset: 0x0
		public const int HraesvelgtDoomEagle = 49105782; //Field offset: 0x0
		public const int SalamangreatAlmiraj = 60303245; //Field offset: 0x0
		public const int TriBrigadeRampager = 47163170; //Field offset: 0x0
		public const int TriBrigadeBarrenBlossom = 26847978; //Field offset: 0x0
		public const int AWODoubleDragonLords = 6671158; //Field offset: 0x0
		public const int TriBrigadeSilverSheller = 52331012; //Field offset: 0x0
		public const int ZoodiacBoarbow = 74393852; //Field offset: 0x0
		public const int ZoodiacChakanine = 41375811; //Field offset: 0x0
		public const int ZoodiacTigermortar = 11510448; //Field offset: 0x0
		public const int DrollLockBird = 94145021; //Field offset: 0x0
		public const int NibiruThePrimalBeing = 27204311; //Field offset: 0x0
		public const int SkullMeister = 67750322; //Field offset: 0x0
		public const int TriBrigadeOminousOmen = 99726621; //Field offset: 0x0
		public const int AccesscodeTalker = 86066372; //Field offset: 0x0
		public const int TriBrigadeRevolt = 40975243; //Field offset: 0x0
		public const int SolemnStrike = 40605147; //Field offset: 0x0
		public const int EffectVeiler = 97268402; //Field offset: 0x0
		public const int TriBrigadeFraktall = 87209160; //Field offset: 0x0
		public const int TriBrigadeKerass = 50810455; //Field offset: 0x0
		public const int TriBrigadeKitt = 56196385; //Field offset: 0x0
		public const int TriBrigadeNervall = 14816857; //Field offset: 0x0
		public const int ZoodiacRatpiep = 78872731; //Field offset: 0x0
		public const int ZoodiacThoroughblade = 77150143; //Field offset: 0x0
		public const int CalledByTheGrave = 24224830; //Field offset: 0x0
		public const int FireFormationTenki = 57103969; //Field offset: 0x0
		public const int ForbiddenDroplet = 24299458; //Field offset: 0x0
		public const int PotOfDesires = 35261759; //Field offset: 0x0
		public const int TripleTacticsTalent = 25311006; //Field offset: 0x0
		public const int ZooodiacBarrage = 46060017; //Field offset: 0x0
		public const int ImperialOrder = 61740673; //Field offset: 0x0
		public const int InfiniteImpermanence = 10045474; //Field offset: 0x0
		public const int SolemnJudgment = 41420027; //Field offset: 0x0
		public const int TwinTwisters = 43898403; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public TribrigadeExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool Default() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool InGraveyard(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool InHand(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool InMonsterZone(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInBanished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool IsBanished(int id) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool OnSelectHand() { }

}

