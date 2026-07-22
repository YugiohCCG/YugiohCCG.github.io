namespace DuelBot.Game.AI.Decks;

public class TestAiExecutor : DefaultExecutor
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
		[Calls(Type = typeof(TestAiExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int Kozaky = 99171160; //Field offset: 0x0
		public const int KeyMace = 1929294; //Field offset: 0x0
		public const int BoneMouse = 21239280; //Field offset: 0x0
		public const int FungiMusk = 53830602; //Field offset: 0x0
		public const int AncientJar = 81492226; //Field offset: 0x0
		public const int DarkPlant = 13193642; //Field offset: 0x0
		public const int SkullServant = 32274490; //Field offset: 0x0
		public const int PetitMoth = 58192742; //Field offset: 0x0
		public const int Watapon = 87774234; //Field offset: 0x0
		public const int AForces = 403847; //Field offset: 0x0
		public const int Courage = 10012614; //Field offset: 0x0
		public const int Umi = 22702055; //Field offset: 0x0
		public const int SolemnWishes = 35346968; //Field offset: 0x0
		public const int JarOfGreed = 83968380; //Field offset: 0x0
		public const int Recall = 96404912; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}


	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public TestAiExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool when_jar() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool when_recall() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool when_solemn() { }

}

