namespace Scenes.Battle.DuelLogging;

public static class LogManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UInt32, Boolean> <>9__32_0; //Field offset: 0x8
		public static Func<UInt32, UInt32> <>9__32_1; //Field offset: 0x10
		public static Func<UInt32, Boolean> <>9__32_2; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <OnCardDraw>b__32_0(uint id) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal uint <OnCardDraw>b__32_1(uint id) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <OnCardDraw>b__32_2(uint id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public IGrouping<UInt32, UInt32> draw; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass32_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal bool <OnCardDraw>b__3(uint id) { }

	}

	private static readonly Color OWN_COLOR; //Field offset: 0x0
	private static readonly Color OPP_COLOR; //Field offset: 0x10

	private static ChatWindow Chat
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 79
	}

	private static DuelLogger Logging
	{
		[CallerCount(Count = 47)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 181
	}

	private static Duel Match
	{
		[CalledBy(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(LogManager), Member = "PrependPlayerInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(String&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnCardSpSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnChainNegated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 190
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ToRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	private static LogManager() { }

	[CallerCount(Count = 0)]
	private static ChatWindow get_Chat() { }

	[CallerCount(Count = 47)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static DuelLogger get_Logging() { }

	[CalledBy(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LogManager), Member = "PrependPlayerInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardSpSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnChainNegated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static Duel get_Match() { }

	[CalledBy(Type = "Game.DuelManager+<OnChaining>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetChainingEventString(ClientCard card, int desc) { }

	[CalledBy(Type = typeof(LogCardMoved), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardShuffled), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static string GetLocationIconName(CardLocation loc) { }

	[CalledBy(Type = "Scenes.General.ChatWindow+<>c__DisplayClass64_0", Member = "<OnChatMessage>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "GetIndexOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(LogManager), Member = "GetTeamColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetPlayerColor(long playerId) { }

	[CalledBy(Type = "Game.DuelManager+<DiceTosser>d__94", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnTossCoin>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsInvalidInstructions]
	public static string GetPlayerColoredName(byte pid) { }

	[CalledBy(Type = typeof(LogManager), Member = "PrependPlayerInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LogManager), Member = "GetTeamColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static string GetPlayerColoredName(sbyte pid) { }

	[CalledBy(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LogManager), Member = "GetPlayerColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RoomData), Member = "GetTeamOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(sbyte))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetTeamColor(sbyte pid) { }

	[CalledBy(Type = "Game.DuelManager+<OnAddCounter>d__89", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetCounterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CounterTypes), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogAddCounterData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public static void OnAddCounter(ClientCard card, CounterTypes counter, ushort amount, ushort prev) { }

	[CalledBy(Type = "Game.DuelManager+<OnBattle>d__136", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogAttackTargetChangedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	public static void OnAttackTargetChanged(ClientCard oldTarget, ClientCard newTarget) { }

	[CalledBy(Type = "Game.DuelManager+<OnBecomeTarget>d__146", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogBecameTargetData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	public static void OnBecameTarget(ClientCard targeter, ClientCard card) { }

	[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardAttackData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static void OnCardAttack(ClientCard attacker, ClientCard defender) { }

	[CalledBy(Type = "Game.DuelManager+<OnAttackDisabled>d__137", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogAttackDisabledData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static void OnCardAttackDisabled(ClientCard attacker) { }

	[CalledBy(Type = "Game.DuelManager+<OnDraw>d__114", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogCardDrawData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "GroupBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<IGrouping`2<TKey, TSource>>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.UInt32>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 34)]
	public static void OnCardDraw(byte player, byte count, bool bottom, UInt32[] cards) { }

	[CalledBy(Type = "Game.DuelManager+<OnEquip>d__194", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardEquippedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static void OnCardEquipped(ClientCard equip, ClientCard target) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardHintAttribute(byte player, ClientCard hinted, string atts, CardAttribute attributes) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardHintCardData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void OnCardHintCard(byte player, ClientCard declarer, int declared) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardHintNumberData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardHintNumber(byte player, ClientCard hinted, int number) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardHintRaceData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardHintRace(byte player, ClientCard hinted, string rcs, CardRace races) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardHintTurnData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardHintTurn(byte player, ClientCard hinted, int turn) { }

	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardMovedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardMoved(ClientCard card, Reason reason, int cid, byte prevCont, CardLocation prevLoc, byte prevSeq, byte curCont, CardLocation curLoc, byte curSeq, string msg) { }

	[CalledBy(Type = "Game.DuelManager+<OnPosChange>d__138", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetPositionString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardRepositionData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static void OnCardPositionChanged(ClientCard card, CardPosition prevPos, CardPosition curPos) { }

	[CalledBy(Type = "Game.DuelManager+<OnConfirmCards>d__105", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardRevealedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public static void OnCardRevealed(byte player, ClientCard card, int cid, byte cont) { }

	[CalledBy(Type = "Game.DuelManager+<OnSet>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardSetData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public static void OnCardSet(byte player, ClientCard card) { }

	[CalledBy(Type = "Game.DuelManager+<OnShuffleSetCard>d__118", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetFieldZoneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardShuffledData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static void OnCardShuffled(byte player, CardLocation loc, int amt) { }

	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardSpSummonedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardSpSummoned(byte player, ClientCard card) { }

	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardSummonedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void OnCardSummoned(ClientCard card, bool flip) { }

	[CalledBy(Type = "Game.DuelManager+<OnSwap>d__134", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardSwapData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	public static void OnCardSwap(ClientCard card1, ClientCard card2) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogCardTargetData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public static void OnCardTarget(ClientCard targeter, ClientCard target) { }

	[CalledBy(Type = "Game.DuelManager+<OnChaining>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static void OnChaining(byte player, ClientCard card, int desc, byte tloc, byte tsq) { }

	[CalledBy(Type = "Game.DuelManager+<OnChainNegated>d__83", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogChainNegatedData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static void OnChainNegated(ClientCard negator, ClientCard negated, bool disabled) { }

	[CalledBy(Type = "Game.DuelManager+<OnTossCoin>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static void OnCoinToss(byte player, Boolean[] results) { }

	[CalledBy(Type = "Game.DuelManager+<OnConfirmTop>d__87", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogConfirmTopData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static void OnConfirmTop(byte player, ClientCard card, bool isExtra) { }

	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnDeclareAttribute(byte player, CardAttribute attribute) { }

	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void OnDeclareCard(byte player, int cid) { }

	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogDeclareCodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void OnDeclareCode(byte player, int code) { }

	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(LogDeclareNumberData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void OnDeclareNumber(byte player, int number) { }

	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnDeclareRace(byte player, CardRace race) { }

	[CalledBy(Type = "Game.DuelManager+<DiceTosser>d__94", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void OnDiceRoll(byte player, Int32[] results) { }

	[CalledBy(Type = "Game.DuelManager+<OnHandResult>d__193", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetRPSLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(sbyte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(Duel), Member = "get_LocalPlayer", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void OnJankenResult(byte h0, byte h1) { }

	[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnLPDamage(byte player, int dmg, bool cost, int oldLp, int newLp) { }

	[CalledBy(Type = "Game.DuelManager+<OnRecover>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnLPRecover(byte player, int rcv, int oldLp, int newLp) { }

	[CalledBy(Type = "Game.DuelManager+<OnLpUpdate>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnLPUpdate(byte player, int oldLp, int newLp, int diff) { }

	[CalledBy(Type = "Game.DuelManager+<OnMissedEffect>d__91", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void OnMissedTiming(ClientCard card) { }

	[CalledBy(Type = "Game.DuelManager+<OnNewPhase>d__127", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(Localization), Member = "GetPhaseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Duel), Member = "get_LocalPlayer", ReturnType = typeof(byte))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnNewPhase() { }

	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Duel), Member = "get_LocalPlayer", ReturnType = typeof(byte))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void OnNewTurn() { }

	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnOpSelection(byte player, int desc) { }

	[CalledBy(Type = "Game.DuelManager+<OnRandomSelected>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void OnRandomSelect(byte player, ClientCard card) { }

	[CalledBy(Type = "Game.DuelManager+<OnRemoveCounter>d__90", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetCounterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CounterTypes), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static void OnRemoveCounter(ClientCard card, CounterTypes counter, ushort amount, ushort prev) { }

	[CalledBy(Type = "Game.DuelManager+<OnShuffleDeck>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static void OnShuffleDeck(byte player) { }

	[CalledBy(Type = "Game.DuelManager+<OnShuffleExtra>d__117", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static void OnShuffleExtraDeck(byte player) { }

	[CalledBy(Type = "Game.DuelManager+<OnShuffleHand>d__116", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static void OnShuffleHand(byte player) { }

	[CalledBy(Type = "Game.DuelManager+<OnSwapGraveDeck>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnSwapDeckGY(byte player) { }

	[CalledBy(Type = "Game.DuelManager+<OnTagSwap>d__125", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogManager), Member = "get_Logging", ReturnType = typeof(DuelLogger))]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "AddLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void OnTeamSwap(byte player) { }

	[CalledBy(Type = typeof(LogCardReposition), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static string PositionChangeIconName(CardPosition p, CardPosition c) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(sbyte), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LogManager), Member = "get_Match", ReturnType = typeof(Duel))]
	[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static void PrependPlayerInMessage(sbyte pid, ref string msg) { }

}

