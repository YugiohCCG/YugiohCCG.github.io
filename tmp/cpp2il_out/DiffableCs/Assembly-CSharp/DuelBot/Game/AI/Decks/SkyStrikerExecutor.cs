namespace DuelBot.Game.AI.Decks;

public class SkyStrikerExecutor : DefaultExecutor
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
		[Calls(Type = typeof(SkyStrikerExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int Raye = 26077387; //Field offset: 0x0
		public const int TroymarePhoenix = 2857636; //Field offset: 0x0
		public const int TroymareUnicorn = 38342335; //Field offset: 0x0
		public const int SummonSorceress = 61665245; //Field offset: 0x0
		public const int TopologicTrisbaena = 72529749; //Field offset: 0x0
		public const int TopologicBomberDragon = 5821478; //Field offset: 0x0
		public const int HiSpeedroidChanbara = 42110604; //Field offset: 0x0
		public const int SolemnWarning = 84749824; //Field offset: 0x0
		public const int SolemnJudgment = 41420027; //Field offset: 0x0
		public const int TwinTwisters = 43898403; //Field offset: 0x0
		public const int MetalfoesFusion = 73594093; //Field offset: 0x0
		public const int UpstartGoblin = 70368879; //Field offset: 0x0
		public const int FoolishBurialGoods = 35726888; //Field offset: 0x0
		public const int ReinforcementOfTheArmy = 32807846; //Field offset: 0x0
		public const int EffectVeiler = 97268402; //Field offset: 0x0
		public const int CrystronNeedlefiber = 50588353; //Field offset: 0x0
		public const int JetSynchron = 9742784; //Field offset: 0x0
		public const int GhostRabbit = 59438930; //Field offset: 0x0
		public const int AshBlossom = 14558127; //Field offset: 0x0
		public const int AreaZero = 50005218; //Field offset: 0x0
		public const int HerculesBase = 97616504; //Field offset: 0x0
		public const int Multirole = 24010609; //Field offset: 0x0
		public const int JammingWave = 25955749; //Field offset: 0x0
		public const int Afterburners = 99550630; //Field offset: 0x0
		public const int WidowAnchor = 98338152; //Field offset: 0x0
		public const int HornetDrones = 52340444; //Field offset: 0x0
		public const int Engage = 63166095; //Field offset: 0x0
		public const int Token = 52340445; //Field offset: 0x0
		public const int Hayate = 8491308; //Field offset: 0x0
		public const int Shizuku = 90673288; //Field offset: 0x0
		public const int Kagari = 63288573; //Field offset: 0x0
		public const int MaxxC = 23434538; //Field offset: 0x0
		public const int Linkuriboh = 41999284; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}

	private bool KagariSummoned; //Field offset: 0x78
	private BotClientCard WidowAnchorTarget; //Field offset: 0x80

	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 40)]
	public SkyStrikerExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool AfterburnersEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersExtraZoneCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsSpell", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private bool AreaZeroEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CrystronNeedlefiberEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool CrystronNeedlefiberSummon() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool EmptyMainMonsterZone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "GetCardToSearch", ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool EngageEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "HaveThreeSpellsInGrave", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "GetCardToSearch", ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool EngageEffectFirst() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool FoolishBurialGoodsEffect() { }

	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "EngageEffectFirst", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "EngageEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "ShizukuEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemySpell", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private int GetCardToSearch() { }

	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "TwinTwistersEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "JetSynchronEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int GetDiscardHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCountWithoutField", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool HandFull() { }

	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "EngageEffectFirst", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "WidowAnchorEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "HerculesBaseEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsSpell", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool HaveThreeSpellsInGrave() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool HayateEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool HayateSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "HaveThreeSpellsInGrave", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterInvincible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetGraveyardMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private bool HerculesBaseEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersExtraZoneCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTuner", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool HornetDronesEffect() { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool JammingWaveEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "GetDiscardHand", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool JetSynchronEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemySpell", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool KagariEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool KagariSummon() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool MaxxCEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersExtraZoneCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsSpell", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 17)]
	private bool MultiroleEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectThirdCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool MultiroleEPEffect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool MultiroleHandEffect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnNewTurn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterHasPreventActivationEffectInBattle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool OnPreBattleBetween(BotClientCard attacker, BotClientCard defender) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool OnSelectHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemySpell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool OnSelectYesNo(int desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "RayeSelectTarget", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool RayeEffect() { }

	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "RayeEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RayeSelectTarget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersExtraZoneCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool RayeSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "GetCardToSearch", ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool ShizukuEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ShizukuSummon() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool SummonSorceressEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool TunerSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "GetDiscardHand", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private bool TwinTwistersEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "HaveThreeSpellsInGrave", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool WidowAnchorEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool WidowAnchorEffectFirst() { }

}

