namespace DuelBot.Game.AI.Decks;

public class HorusExecutor : DefaultExecutor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameAI, BotDuel, Executor> <>9__0_0; //Field offset: 0x8
		public static Func<BotClientCard, Boolean> <>9__5_0; //Field offset: 0x10
		public static Func<BotClientCard, Boolean> <>9__5_1; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HorusExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCanRevive", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <MonsterReborn>b__5_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCanRevive", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <MonsterReborn>b__5_1(BotClientCard card) { }

	}

	internal class CardId
	{
		public const int AlexandriteDragon = 43096270; //Field offset: 0x0
		public const int DragonsRebirth = 20638610; //Field offset: 0x0
		public const int Mountain = 50913601; //Field offset: 0x0
		public const int BellowOfTheSilverDragon = 80600103; //Field offset: 0x0
		public const int MysticalSpaceTyphoon = 5318639; //Field offset: 0x0
		public const int MonsterReborn = 83764718; //Field offset: 0x0
		public const int FoolishBurial = 81439173; //Field offset: 0x0
		public const int StampingDestruction = 81385346; //Field offset: 0x0
		public const int Fissure = 66788016; //Field offset: 0x0
		public const int DarkHole = 53129443; //Field offset: 0x0
		public const int HammerShot = 26412047; //Field offset: 0x0
		public const int Raigeki = 12580477; //Field offset: 0x0
		public const int GolemDragon = 9666558; //Field offset: 0x0
		public const int DodgerDragon = 47013502; //Field offset: 0x0
		public const int AxeDragonute = 84914462; //Field offset: 0x0
		public const int CyberDragon = 70095154; //Field offset: 0x0
		public const int HorusTheBlackFlameDragonLv6 = 11224103; //Field offset: 0x0
		public const int HorusTheBlackFlameDragonLv8 = 48229808; //Field offset: 0x0
		public const int WhiteNightDragon = 79473793; //Field offset: 0x0
		public const int LusterDragon = 11091375; //Field offset: 0x0
		public const int MirrorForce = 44095762; //Field offset: 0x0
		public const int DimensionalPrison = 70342110; //Field offset: 0x0

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
	[CallsDeduplicatedMethods(Count = 17)]
	public HorusExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool BellowOfTheSilverDragon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private bool DragonsRebirth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool FoolishBurial() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HorusTheBlackFlameDragonLv8() { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardContainer), Member = "GetMatchingCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(System.Func`2<DuelBot.Game.BotClientCard, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private bool MonsterReborn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultTributeSummon", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 11)]
	private bool WhiteNightDragon() { }

}

