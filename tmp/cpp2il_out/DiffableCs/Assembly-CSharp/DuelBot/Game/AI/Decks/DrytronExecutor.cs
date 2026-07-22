namespace DuelBot.Game.AI.Decks;

public class DrytronExecutor : DefaultExecutor
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
		public const int DivinerOfTheHerald = 92919429; //Field offset: 0x0
		public const int BowOfTheGoddess = 4280258; //Field offset: 0x0
		public const int LadyOfTheEternal = 27552504; //Field offset: 0x0
		public const int DivineArsenalSkyThunder = 90448279; //Field offset: 0x0
		public const int DownerdMagician = 72167543; //Field offset: 0x0
		public const int DrytronMuBetaFafnir = 1174075; //Field offset: 0x0
		public const int ElderEntityNtss = 80532587; //Field offset: 0x0
		public const int HeraldOfTheArcLight = 79606837; //Field offset: 0x0
		public const int IPMasquerena = 65741789; //Field offset: 0x0
		public const int KnightmarePhoenix = 2857636; //Field offset: 0x0
		public const int KnightmareUnicorn = 38342335; //Field offset: 0x0
		public const int Linkuriboh = 41999284; //Field offset: 0x0
		public const int AssembledNightingale = 48608796; //Field offset: 0x0
		public const int MillenniumEyesRestrict = 41578483; //Field offset: 0x0
		public const int AllyOfJusticeCycleReader = 8233522; //Field offset: 0x0
		public const int DarkRulerNoMore = 54693926; //Field offset: 0x0
		public const int DrollLockBird = 94145021; //Field offset: 0x0
		public const int LightingStorm = 14532163; //Field offset: 0x0
		public const int PreparationOfRites = 96729612; //Field offset: 0x0
		public const int PrePreparationOfRites = 13048472; //Field offset: 0x0
		public const int PotOfProsperity = 84211599; //Field offset: 0x0
		public const int MeteonisDrytron = 22398665; //Field offset: 0x0
		public const int DrytronAlphaThuban = 97148796; //Field offset: 0x0
		public const int DrytronDeltaAltais = 22420202; //Field offset: 0x0
		public const int DrytronGammaEltanin = 60037599; //Field offset: 0x0
		public const int DrytronZetaAldhibah = 96026108; //Field offset: 0x0
		public const int Eva = 40177746; //Field offset: 0x0
		public const int HeraldOfOrangeLight = 17266660; //Field offset: 0x0
		public const int CyberAngelBenten = 77235086; //Field offset: 0x0
		public const int CyberAngelIdaten = 3629090; //Field offset: 0x0
		public const int Prohibition = 43711255; //Field offset: 0x0
		public const int CyberAngelNatasha = 99427357; //Field offset: 0x0
		public const int HeraldOfProfection = 44665365; //Field offset: 0x0
		public const int CalledByTheGrave = 24224830; //Field offset: 0x0
		public const int CyberEnergency = 60600126; //Field offset: 0x0
		public const int DawnOfTheHerald = 27383110; //Field offset: 0x0
		public const int ExtraFoolishBurial = 57995165; //Field offset: 0x0
		public const int FoolishBurial = 81439173; //Field offset: 0x0
		public const int ForbiddenDroplet = 24299458; //Field offset: 0x0
		public const int InstantFusion = 1845204; //Field offset: 0x0
		public const int DrytronMeteonisDraconids = 69815951; //Field offset: 0x0
		public const int RedReboot = 23002292; //Field offset: 0x0

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
	public DrytronExecutor(GameAI ai, BotDuel duel) { }

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

