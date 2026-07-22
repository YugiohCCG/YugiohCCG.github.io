namespace DuelBot.Game.AI.Decks;

public class AltergeistExecutor : DefaultExecutor
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
		[Calls(Type = typeof(AltergeistExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int Kunquery = 52927340; //Field offset: 0x0
		public const int Borrelsword = 85289965; //Field offset: 0x0
		public const int FWD = 5043010; //Field offset: 0x0
		public const int TripleBurstDragon = 49725936; //Field offset: 0x0
		public const int HeavymetalfoesElectrumite = 24094258; //Field offset: 0x0
		public const int Isolde = 59934749; //Field offset: 0x0
		public const int Hexstia = 1508649; //Field offset: 0x0
		public const int Needlefiber = 50588353; //Field offset: 0x0
		public const int Kagari = 63288573; //Field offset: 0x0
		public const int Shizuku = 90673288; //Field offset: 0x0
		public const int Linkuriboh = 41999284; //Field offset: 0x0
		public const int Anima = 94259633; //Field offset: 0x0
		public const int SecretVillage = 68462976; //Field offset: 0x0
		public const int DarkHole = 53129443; //Field offset: 0x0
		public const int NaturalBeast = 33198837; //Field offset: 0x0
		public const int SwordsmanLV7 = 37267041; //Field offset: 0x0
		public const int RoyalDecreel = 51452091; //Field offset: 0x0
		public const int Anti_Spell = 58921041; //Field offset: 0x0
		public const int Hayate = 8491308; //Field offset: 0x0
		public const int Raye = 26077387; //Field offset: 0x0
		public const int UltimateFalcon = 86221741; //Field offset: 0x0
		public const int NaturalExterio = 99916754; //Field offset: 0x0
		public const int SolemnJudgment = 41420027; //Field offset: 0x0
		public const int SolemnStrike = 40605147; //Field offset: 0x0
		public const int Marionetter = 53143898; //Field offset: 0x0
		public const int Multifaker = 42790071; //Field offset: 0x0
		public const int AB_JS = 14558127; //Field offset: 0x0
		public const int GO_SR = 59438930; //Field offset: 0x0
		public const int GR_WC = 62015408; //Field offset: 0x0
		public const int GB_HM = 73642296; //Field offset: 0x0
		public const int Silquitous = 89538537; //Field offset: 0x0
		public const int MaxxC = 23434538; //Field offset: 0x0
		public const int Meluseek = 25533642; //Field offset: 0x0
		public const int Drones_Token = 52340445; //Field offset: 0x0
		public const int OneForOne = 2295440; //Field offset: 0x0
		public const int PotofIndulgence = 49238328; //Field offset: 0x0
		public const int Impermanence = 10045474; //Field offset: 0x0
		public const int WakingtheDragon = 10813327; //Field offset: 0x0
		public const int EvenlyMatched = 15693423; //Field offset: 0x0
		public const int Storm = 23924608; //Field offset: 0x0
		public const int Manifestation = 35146019; //Field offset: 0x0
		public const int Protocol = 27541563; //Field offset: 0x0
		public const int Spoofing = 53936268; //Field offset: 0x0
		public const int ImperialOrder = 61740673; //Field offset: 0x0
		public const int PotofDesires = 35261759; //Field offset: 0x0
		public const int Iblee = 10158145; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}

	private readonly List<Int32> Impermanence_list; //Field offset: 0x78
	private bool Multifaker_ssfromhand; //Field offset: 0x80
	private bool Multifaker_ssfromdeck; //Field offset: 0x81
	private bool Marionetter_reborn; //Field offset: 0x82
	private bool Hexstia_searched; //Field offset: 0x83
	private bool Meluseek_searched; //Field offset: 0x84
	private bool summoned; //Field offset: 0x85
	private bool Silquitous_bounced; //Field offset: 0x86
	private bool Silquitous_recycled; //Field offset: 0x87
	private bool ss_other_monster; //Field offset: 0x88
	private readonly List<BotClientCard> attacked_Meluseek; //Field offset: 0x90
	private readonly List<Int32> SkyStrike_list; //Field offset: 0x98
	private readonly List<Int32> cards_improper; //Field offset: 0xA0
	private readonly List<Int32> normal_counter; //Field offset: 0xA8
	private readonly List<Int32> should_not_negate; //Field offset: 0xB0

	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 59)]
	[CallsUnknownMethods(Count = 49)]
	public AltergeistExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeMonsterTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersExtraZoneCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CardExtension), Member = "IsFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool Anima_ss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool Anti_Spell_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public bool Borrelsword_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersInExtraZone", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public bool Borrelsword_ss() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool Bot_can_s_Meluseek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public bool ChickenGame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public bool EvenlyMatched_activate() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_Repos", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Meluseek_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Multifaker_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Tuner_summon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetFieldCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool EvenlyMatched_ready() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool EvenlyMatched_Repos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemySpell", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSTPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public bool Feather_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool Field_activate() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool G_activate() { }

	[CallerCount(Count = 0)]
	public int Get_Hexstia_linkzone(int zone) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool Get_linked_by_Hexstia(int place) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Meluseek_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetHighestAttackMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "RandomSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public BotClientCard GetBestEnemyCard_random() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public BotClientCard GetFloodgate_Alter(bool canBeTarget = false, bool is_bounce = true) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Kunquery_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Meluseek_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Multifaker_deckss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeMonsterTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CardContainer), Member = "GetInvincibleMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(CardContainer), Member = "GetDangerousMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetFloodgate_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public BotClientCard GetProblematicEnemyCard_Alter(bool canBeTarget = false, bool is_bounce = true) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetSequence(BotClientCard card) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public int GetTotalATK(IList<BotClientCard> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTuner", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInBanished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool GR_WC_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Hand_act_eff() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Manifestation_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Has_altergeist_left() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrHasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public bool Hexstia_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetTotalATK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public bool Hexstia_ss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsSpell", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool ImperialOrder_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Is_should_not_negate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeSpellTrapTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemySpell", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSTPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterShouldBeDisabledBeforeItUseEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 23)]
	public bool Impermanence_activate() { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Is_should_not_negate() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "WakingtheDragon_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	public bool IsAltergeist(int id) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Should_activate_Protocol", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GR_WC_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAltergeist(BotClientCard card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterDangerous", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeMonsterTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(AltergeistExecutor), Member = "RandomSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public bool Kunquery_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool Linkuriboh_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersExtraZoneCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Linkuriboh_ss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Has_altergeist_left", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public bool Manifestation_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetFieldCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemySpell", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSetPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Has_altergeist_left", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public bool Marionetter_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	public bool Marionetter_summon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetBestEnemyCard_random", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "RandomSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrHasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public bool Meluseek_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Meluseek_summon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool MonsterRepos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool MonsterSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool MonsterSummon() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SecretVillage_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Meluseek_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Trap_can_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public bool Multifaker_can_ss() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Multifaker_candeckss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Multifaker_deckss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool Multifaker_handss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Multifaker_summon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool NaturalExterio_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool Needlefiber_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTuner", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersInExtraZone", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	public bool Needlefiber_ss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool OneForOne_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnNewTurn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public virtual BotClientCard OnSelectAttacker(IList<BotClientCard> attackers, IList<BotClientCard> defenders) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "Attack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(BattlePhaseAction))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public virtual BattlePhaseAction OnSelectAttackTarget(BotClientCard attacker, IList<BotClientCard> defenders) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSetPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 54)]
	public virtual IList<BotClientCard> OnSelectCard(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool OnSelectHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual int OnSelectPlace(int cardId, int player, CardLocation location, int available) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsTurn1OrMain2", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSTPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public bool PotofDesires_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSTPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool PotofIndulgence_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_activate_Protocol", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool Protocol_activate_not_use() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Should_activate_Protocol", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_activate_not_use", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public bool Protocol_activing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Get_linked_by_Hexstia", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_activate_Protocol", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	public bool Protocol_negate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanMyBest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public bool Protocol_negate_better() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetBestEnemyCard_random", ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Storm_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Kunquery_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Meluseek_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void RandomSort(List<BotClientCard> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool SecretVillage_activate() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Marionetter_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public int SelectSetPlace(List<Int32> avoid_list = null) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SpellSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Feather_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "PotofDesires_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "PotofIndulgence_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public int SelectSTPlace(BotClientCard card = null, bool avoid_Impermanence = false) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_activate_not_use", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	public bool Should_activate_Protocol() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnStrike_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnJudgment_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Protocol_negate", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	public bool Should_counter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetBestEnemyCard_random", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeMonsterTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Bot_can_s_Meluseek", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	public bool Silquitous_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersInMainZone", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public bool Silquitous_summon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTargetOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultSolemnJudgment", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsMonster", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool SolemnJudgment_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Should_counter", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultExecutor), Member = "DefaultSolemnStrike", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	public bool SolemnStrike_activate() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "ChickenGame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "PotofIndulgence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "PotofDesires_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "OneForOne_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Storm_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Feather_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Hexstia_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "ImperialOrder_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnJudgment_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SolemnStrike_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "SecretVillage_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrHasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsSpell", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Spell_trap_activate(bool isCounter = false, BotClientCard target = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSTPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsSpell", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BotClientCard), Member = "IsMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetGraveyardMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasAttackingMonster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "SelectSetPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool SpellSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spoofing_select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectYesNo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "ChainContainsCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Protocol_activing", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 43)]
	[ContainsUnimplementedInstructions]
	public bool Spoofing_eff() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Spoofing_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 51)]
	public void Spoofing_select(IList<Int32> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Spell_trap_activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "RandomSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetLastChainCard", ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	public bool Storm_activate() { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Multifaker_can_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool Trap_can_activate(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetStringId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool TripleBurstDragon_eff() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetGraveyardSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersInExtraZone", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	public bool TripleBurstDragon_ss() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersInExtraZone", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "EvenlyMatched_ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public bool Tuner_summon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "IsAltergeist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	public bool WakingtheDragon_eff() { }

}

