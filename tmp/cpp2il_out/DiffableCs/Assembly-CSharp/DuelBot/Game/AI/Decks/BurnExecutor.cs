namespace DuelBot.Game.AI.Decks;

public class BurnExecutor : DefaultExecutor
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
		[Calls(Type = typeof(BurnExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int LavaGolem = 102380; //Field offset: 0x0
		public const int MinorGoblinOfficial = 1918087; //Field offset: 0x0
		public const int MagicCylinder = 62279055; //Field offset: 0x0
		public const int Ceasefire = 36468556; //Field offset: 0x0
		public const int OjamaTrio = 29843091; //Field offset: 0x0
		public const int PoisonOfTheOldMan = 8842266; //Field offset: 0x0
		public const int DarkRoomofNightmare = 85562745; //Field offset: 0x0
		public const int ChainEnergy = 79323590; //Field offset: 0x0
		public const int SupremacyBerry = 98380593; //Field offset: 0x0
		public const int SwordsOfRevealingLight = 72302403; //Field offset: 0x0
		public const int TremendousFire = 46918794; //Field offset: 0x0
		public const int GoblinThief = 45311864; //Field offset: 0x0
		public const int Ookazi = 19523799; //Field offset: 0x0
		public const int ThunderShort = 20264508; //Field offset: 0x0
		public const int NaturiaBeans = 44789585; //Field offset: 0x0
		public const int SpiritReaper = 23205979; //Field offset: 0x0
		public const int Marshmallon = 31305911; //Field offset: 0x0
		public const int BlastSphere = 26302522; //Field offset: 0x0
		public const int FencingFireFerret = 97396380; //Field offset: 0x0
		public const int ReflectBounder = 2851070; //Field offset: 0x0
		public const int ChainBurst = 48276469; //Field offset: 0x0
		public const int SkullInvitation = 98139712; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}


	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	public BurnExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool Ceasefire() { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool LavaGolem() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool OnSelectHand() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool PoisonOfTheOldMan() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultMonsterRepos", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ReposEverything() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private bool SetInvincibleMonster() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool SupremacyBerry() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardContainer), Member = "GetCardCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool SwordsOfRevealingLight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ThunderShort() { }

}

