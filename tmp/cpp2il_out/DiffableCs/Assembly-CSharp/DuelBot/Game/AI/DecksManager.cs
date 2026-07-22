namespace DuelBot.Game.AI;

public static class DecksManager
{
	private static readonly Random _rand; //Field offset: 0x0
	public static readonly Dictionary<DuelRules, Dictionary`2<String, Tuple`2<Func`3<GameAI, BotDuel, Executor>, Deck>>> DeckTypes; //Field offset: 0x8
	public static short TestIndex; //Field offset: 0x10
	public static readonly Dictionary<DuelRules, List`1<Int16>> CustomIndexes; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static DecksManager() { }

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void AddDeckType(string name, DuelRules rule, Func<GameAI, BotDuel, Executor> creator, string deckHash, bool test = false, bool custom = false) { }

	[CalledBy(Type = typeof(BotCore), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrcustExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(PhantasmExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(PureWindsExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(QliphortExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(RainbowExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(Rank5Executor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(SalamangreatExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkyStrikerExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ST1732Executor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeThiefExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ToadallyAwesomeExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrickstarExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualWorldExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(YosenjuExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZexalWeaponsExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZoodiacExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResonatorExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(RushExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(DinocarriageDynarmixExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(MokeyMokeyExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(MokeyMokeyKingExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(OldSchoolExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(NekrozExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(MokeyMokeyKingExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(MokeyMokeyExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AltergeistExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(BlueEyesMaxDragonExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(BurnExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChainBurnExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CyberDragonExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(DarkMagicianExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(DragunExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(DragunityExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(EvilswarmExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(FurHireExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(GravekeeperExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(HorusExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(IgnisterExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(Level8Executor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightswornExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightswornShaddoldinosour), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualTestExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(MathmechExecutor), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(FrogExecutor), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static void InitAllDecks() { }

	[CalledBy(Type = typeof(GameBehavior), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static Executor Instantiate(GameAI ai, BotDuel duel) { }

}

