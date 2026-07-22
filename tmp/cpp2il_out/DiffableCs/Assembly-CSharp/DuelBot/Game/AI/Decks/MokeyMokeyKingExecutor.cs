namespace DuelBot.Game.AI.Decks;

public class MokeyMokeyKingExecutor : DefaultExecutor
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
		[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int BlazingInpachi = 5464695; //Field offset: 0x0
		public const int ScrapArchfiend = 45815891; //Field offset: 0x0
		public const int Forest = 87430998; //Field offset: 0x0
		public const int Sogen = 86318356; //Field offset: 0x0
		public const int Umiiruika = 82999629; //Field offset: 0x0
		public const int GaiaPower = 56594520; //Field offset: 0x0
		public const int Mountain = 50913601; //Field offset: 0x0
		public const int RisingAirCurrent = 45778932; //Field offset: 0x0
		public const int AcidicDownpour = 35956022; //Field offset: 0x0
		public const int Wasteland = 23424603; //Field offset: 0x0
		public const int Umi = 22702055; //Field offset: 0x0
		public const int GemknightPearl = 71594310; //Field offset: 0x0
		public const int MoltenDestruction = 19384334; //Field offset: 0x0
		public const int LeoWizard = 4392470; //Field offset: 0x0
		public const int MokeyMokey = 27288416; //Field offset: 0x0
		public const int GenexController = 68505803; //Field offset: 0x0
		public const int TuneWarrior = 74093656; //Field offset: 0x0
		public const int AquaMadoor = 85639257; //Field offset: 0x0
		public const int HarpieLady = 76812113; //Field offset: 0x0
		public const int CelticGuardian = 91152256; //Field offset: 0x0
		public const int AlphaMagnetWarrior = 99785935; //Field offset: 0x0
		public const int GammaMagnetWarrior = 11549357; //Field offset: 0x0
		public const int BetaMagnetWarrior = 39256679; //Field offset: 0x0
		public const int Bunilla = 69380702; //Field offset: 0x0
		public const int LightingShadow = 67598234; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public MokeyMokeyKingExecutor(GameAI ai, BotDuel duel) { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

}

