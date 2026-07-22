namespace DuelBot.Game.AI.Decks;

internal class BlueEyesExecutor : DefaultExecutor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameAI, BotDuel, Executor> <>9__0_0; //Field offset: 0x8
		public static Func<BotClientCard, Boolean> <>9__8_0; //Field offset: 0x10
		public static Func<BotClientCard, Boolean> <>9__8_1; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlueEyesExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnSelectCard>b__8_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnSelectCard>b__8_1(BotClientCard card) { }

	}

	internal class CardId
	{
		public const int WhiteDragon = 89631139; //Field offset: 0x0
		public const int GalaxyEyesCipherDragon = 18963306; //Field offset: 0x0
		public const int GalaxyEyesPrimePhotonDragon = 31801517; //Field offset: 0x0
		public const int GalaxyEyesFullArmorPhotonDragon = 39030163; //Field offset: 0x0
		public const int GalaxyEyesCipherBladeDragon = 2530830; //Field offset: 0x0
		public const int GalaxyEyesDarkMatterDragon = 58820923; //Field offset: 0x0
		public const int BlueEyesSpiritDragon = 59822133; //Field offset: 0x0
		public const int AzureEyesSilverDragon = 40908371; //Field offset: 0x0
		public const int Giganticastle = 63422098; //Field offset: 0x0
		public const int SilversCry = 87025064; //Field offset: 0x0
		public const int MonsterReborn = 83764718; //Field offset: 0x0
		public const int SoulCharge = 54447022; //Field offset: 0x0
		public const int MelodyOfAwakeningDragon = 48800175; //Field offset: 0x0
		public const int DragonShrine = 41620959; //Field offset: 0x0
		public const int CardsOfConsonance = 39701395; //Field offset: 0x0
		public const int TradeIn = 38120068; //Field offset: 0x0
		public const int PotOfDesires = 35261759; //Field offset: 0x0
		public const int ReturnOfTheDragonLords = 6853254; //Field offset: 0x0
		public const int HarpiesFeatherDuster = 18144506; //Field offset: 0x0
		public const int GalaxyCyclone = 5133471; //Field offset: 0x0
		public const int EffectVeiler = 97268402; //Field offset: 0x0
		public const int SageWithEyesOfBlue = 8240199; //Field offset: 0x0
		public const int WhiteStoneOfLegend = 79814787; //Field offset: 0x0
		public const int WhiteStoneOfAncients = 71039903; //Field offset: 0x0
		public const int DragonSpiritOfWhite = 45467446; //Field offset: 0x0
		public const int AlternativeWhiteDragon = 38517737; //Field offset: 0x0
		public const int HopeHarbingerDragonTitanicGalaxy = 63767246; //Field offset: 0x0
		public const int SylvanPrincessprite = 33909817; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}

	private readonly List<BotClientCard> UsedAlternativeWhiteDragon; //Field offset: 0x78
	private BotClientCard UsedGalaxyEyesCipherDragon; //Field offset: 0x80
	private bool AlternativeWhiteDragonSummoned; //Field offset: 0x88
	private bool SoulChargeUsed; //Field offset: 0x89

	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 45)]
	[CallsUnknownMethods(Count = 1)]
	public BlueEyesExecutor(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetBotAvailZonesFromExtraDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetCountCardInZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private bool AlternativeWhiteDragonEffect() { }

	[CallerCount(Count = 0)]
	private bool AlternativeWhiteDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool AzureEyesSilverDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool BlueEyesSpiritDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool BlueEyesSpiritDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool CardsOfConsonanceEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool DragonShrineEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueEyesExecutor), Member = "HasTwoInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "IsChainTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetBestEnemySpell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool DragonSpiritOfWhiteEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	private bool GalaxyEyesCipherBladeDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool GalaxyEyesCipherBladeDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private bool GalaxyEyesCipherDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private bool GalaxyEyesCipherDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool GalaxyEyesDarkMatterDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool GalaxyEyesDarkMatterDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterInvincible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardExtension), Member = "IsMonsterDangerous", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	private bool GalaxyEyesFullArmorPhotonDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private bool GalaxyEyesFullArmorPhotonDragonSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool GalaxyEyesPrimePhotonDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool GalaxyEyesPrimePhotonDragonSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool GiganticastleSummon() { }

	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "TradeInEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "DragonSpiritOfWhiteEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "HaveEnoughWhiteDragonInHand", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool HasTwoInHand(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueEyesExecutor), Member = "HasTwoInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool HaveEnoughWhiteDragonInHand() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool HopeHarbingerDragonTitanicGalaxyEffect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HopeHarbingerDragonTitanicGalaxySummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool MelodyOfAwakeningDragonEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void OnNewTurn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Take", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "CheckSelectCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public virtual IList<BotClientCard> OnSelectCard(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public virtual IList<BotClientCard> OnSelectSynchroMaterial(IList<BotClientCard> cards, int sum, int min, int max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "SelectPreferredCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AIUtil), Member = "CheckSelectCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallsUnknownMethods(Count = 9)]
	public virtual IList<BotClientCard> OnSelectXyzMaterial(IList<BotClientCard> cards, int min, int max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardContainer), Member = "GetFloodgate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool RebornEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsAttack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsFacedown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool Repos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool SageWithEyesOfBlueEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool SageWithEyesOfBlueEffectInHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool SageWithEyesOfBlueSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetGraveyardMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonstersInMainZone", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool SoulChargeEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "IsTrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCountWithoutField", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool SpellSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool SylvanPrincesspriteEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool SylvanPrincesspriteSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BlueEyesExecutor), Member = "HasTwoInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool TradeInEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool WhiteStoneOfAncientsEffect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool WhiteStoneSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool WhiteStoneSummonForSage() { }

}

