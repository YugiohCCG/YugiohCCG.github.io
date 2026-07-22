namespace DuelBot.Game.AI.Decks;

public class PhantomKnights : DefaultExecutor
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
		[Calls(Type = typeof(PhantomKnights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

	}

	internal class CardId
	{
		public const int DarkMagician = 36996508; //Field offset: 0x0
		public const int EmergencyTeleport = 67723438; //Field offset: 0x0
		public const int PKWing = 98431356; //Field offset: 0x0
		public const int FogBlade = 25542642; //Field offset: 0x0
		public const int PKsword = 61936647; //Field offset: 0x0
		public const int SolemnStrike = 40605147; //Field offset: 0x0
		public const int Triphy = 79864860; //Field offset: 0x0
		public const int Dragoon = 37818794; //Field offset: 0x0
		public const int StarvingVenom = 41209827; //Field offset: 0x0
		public const int Zeus = 90448279; //Field offset: 0x0
		public const int ArcRebellion = 64276752; //Field offset: 0x0
		public const int RaidersKnight = 28781003; //Field offset: 0x0
		public const int BreakSword = 62709239; //Field offset: 0x0
		public const int Rusty = 26692769; //Field offset: 0x0
		public const int Cherubini = 58699500; //Field offset: 0x0
		public const int Verte = 70369116; //Field offset: 0x0
		public const int Almiraj = 60303245; //Field offset: 0x0
		public const int AccessCode = 86066372; //Field offset: 0x0
		public const int Megaclops = 69073023; //Field offset: 0x0
		public const int ArtifactLancea = 34267821; //Field offset: 0x0
		public const int GateBlocker = 8102334; //Field offset: 0x0
		public const int IDP = 20899496; //Field offset: 0x0
		public const int PKRankUpMagicLaunch = 3298689; //Field offset: 0x0
		public const int MagicalMeltdown = 47679935; //Field offset: 0x0
		public const int PKRankUpMagicForce = 88504133; //Field offset: 0x0
		public const int SuperPoly = 48130397; //Field offset: 0x0
		public const int RedEyes = 74677422; //Field offset: 0x0
		public const int Aleister = 86120751; //Field offset: 0x0
		public const int Tracker = 30227494; //Field offset: 0x0
		public const int StainedGreaves = 88544390; //Field offset: 0x0
		public const int Wheelder = 3233859; //Field offset: 0x0
		public const int RaggedGloves = 63821877; //Field offset: 0x0
		public const int AncientCloak = 90432163; //Field offset: 0x0
		public const int TornScales = 2538345; //Field offset: 0x0
		public const int Boots = 36426778; //Field offset: 0x0
		public const int AshBlossom = 14558127; //Field offset: 0x0
		public const int TTT = 25311006; //Field offset: 0x0
		public const int Goblindbergh = 25259669; //Field offset: 0x0
		public const int PhotonThrasher = 65367484; //Field offset: 0x0
		public const int PerformageTrickClown = 67696066; //Field offset: 0x0
		public const int JetSynchron = 9742784; //Field offset: 0x0
		public const int MechaPhantomBeastOLion = 72291078; //Field offset: 0x0
		public const int ScrapBeast = 19139516; //Field offset: 0x0
		public const int REFusion = 6172122; //Field offset: 0x0
		public const int FeatherDuster = 18144506; //Field offset: 0x0
		public const int ROTA = 32807846; //Field offset: 0x0
		public const int Foolish = 81439173; //Field offset: 0x0
		public const int TwinTwisters = 43898403; //Field offset: 0x0
		public const int RaidenHandofTheLightsworn = 77558536; //Field offset: 0x0
		public const int Nibiru = 27204311; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CardId() { }

	}

	private bool wasTornScalesSummonedThisTurn; //Field offset: 0x78
	private bool NormalSummoned; //Field offset: 0x79
	private bool TornscalesHitGY; //Field offset: 0x7A
	private bool RaggedGlovesHitGY; //Field offset: 0x7B
	private bool BootsHitGY; //Field offset: 0x7C
	private bool AncientCloakHitGY; //Field offset: 0x7D
	private bool TornScalesUsedThisTurn; //Field offset: 0x7E
	private bool wasBootsActivatedThisTurn; //Field offset: 0x7F
	private bool wasRaggedGlovesActivatedThisTurn; //Field offset: 0x80
	private bool ScorpioActivatedThisTurn; //Field offset: 0x81
	private List<Int32> CombosInHand; //Field offset: 0x88
	private readonly List<Int32> Combo_cards; //Field offset: 0x90
	private readonly List<Int32> normal_counter; //Field offset: 0x98
	private readonly List<Int32> should_not_negate; //Field offset: 0xA0
	private readonly Int32[] PK_combo; //Field offset: 0xA8
	private readonly Int32[] PK_Spell_Trap; //Field offset: 0xB0

	[CalledBy(Type = typeof(<>c), Member = "<Init>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultExecutor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Executor), Member = "AddExecutor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutorType), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 48)]
	[CallsUnknownMethods(Count = 11)]
	public PhantomKnights(GameAI ai, BotDuel duel) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool AccessCode_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool AccessCode_summon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Almiraj_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Almirajsummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool AncientCloak_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Boots_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Boots_SPSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Breaksword_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool BreakSword_summon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Cherubini_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool CherubiniSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Dragoon_Activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Dragoon_summon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool FogBlade_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool Fogblade_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Foolish_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHandOrInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientField), Member = "GetRemainingCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool FoolishBurialEffect() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool GoblindberghSummonFirst() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Hand_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool HarpieFeatherDuster() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool IDPactivate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool L4NonTunerSummonFirst() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool MegaClops_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Megaclops_summon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Niburu_activate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool NormalSummon() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool OnSelectHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AIUtil), Member = "SelectPreferredCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(AIUtil), Member = "CheckSelectCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CallsUnknownMethods(Count = 1)]
	public virtual IList<BotClientCard> OnSelectXyzMaterial(IList<BotClientCard> cards, int min, int max) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool PKRankUpMagicForce_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool PKWing_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool PKWing_Trap_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool RaggedGloves_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool RaidersKnight_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool REFusion_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool ReinforcementofTheArmyEffect() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool ROTA_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Rusty_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool RustySummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool solemnStrike_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool SpellSet() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool SPSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool StainedGreaves_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool StaringVenom_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Superpoly_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "SelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "SelectNextCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool TornScales_activate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool TornScales_GY_act_eff() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Tracker_SPSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool TwinTwisters_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Verte_activate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Verte_Summon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Wheelder_SPSummon() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Zeus_eff_act() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool Zeus_SPSummon() { }

}

