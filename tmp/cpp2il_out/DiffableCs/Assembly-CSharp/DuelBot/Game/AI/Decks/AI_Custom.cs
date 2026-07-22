namespace DuelBot.Game.AI.Decks;

public class AI_Custom : Executor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameAI, BotDuel, Executor> <>9__0_0; //Field offset: 0x8
		public static Func<GameAI, BotDuel, Executor> <>9__0_1; //Field offset: 0x10
		public static Func<GameAI, BotDuel, Executor> <>9__0_2; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Executor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_0(GameAI ai, BotDuel duel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Executor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_1(GameAI ai, BotDuel duel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Executor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
		internal Executor <Init>b__0_2(GameAI ai, BotDuel duel) { }

	}

	[CompilerGenerated]
	private BattleCmdStateData <CurrentBattleCmdStateData>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private BotGeneralStateData <CurrentBotGeneralStateData>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private IdleCmdStateData <CurrentIdleCmdStateData>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private SelectCardStateData <CurrentSelectCardData>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private SelectUnselectCardData <CurrentSelectUnselectCardData>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private SelectChainData <CurrentSelectChainData>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private SelectCounterData <CurrentSelectCounterData>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private SelectDisfieldData <CurrentSelectDisfieldData>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private SelectEffectYnData <CurrentSelectEffectYnData>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private SelectOptionData <CurrentSelectOptionData>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private SelectPlaceData <CurrentSelectPlaceData>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private SelectPositionData <CurrentSelectPositionData>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private SelectSumData <CurrentSelectSumData>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	private SelectTributeData <CurrentSelectTributeData>k__BackingField; //Field offset: 0x258
	[CompilerGenerated]
	private AnnounceAttributeData <CurrentAnnounceAttributeData>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	private AnnounceCardData <CurrentAnnounceCardData>k__BackingField; //Field offset: 0x280
	[CompilerGenerated]
	private AnnounceNumberData <CurrentAnnounceNumberData>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	private AnnounceRaceData <CurrentAnnounceRaceData>k__BackingField; //Field offset: 0x298
	[CompilerGenerated]
	private AnnounceCardFilterData <CurrentAnnounceCardFilterData>k__BackingField; //Field offset: 0x2A8
	[CompilerGenerated]
	private SelectYesNoStateData <CurrentSelectYesNoStateData>k__BackingField; //Field offset: 0x2B8
	[CompilerGenerated]
	private SortCardData <CurrentSortCardData>k__BackingField; //Field offset: 0x2C0
	[CompilerGenerated]
	private BotState <CurrentState>k__BackingField; //Field offset: 0x2C8

	public private AnnounceAttributeData CurrentAnnounceAttributeData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private AnnounceCardData CurrentAnnounceCardData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private AnnounceCardFilterData CurrentAnnounceCardFilterData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private AnnounceNumberData CurrentAnnounceNumberData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 21
	}

	public private AnnounceRaceData CurrentAnnounceRaceData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private BattleCmdStateData CurrentBattleCmdStateData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 22
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 29
	}

	public private BotGeneralStateData CurrentBotGeneralStateData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public private IdleCmdStateData CurrentIdleCmdStateData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 47
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 57
	}

	public private SelectCardStateData CurrentSelectCardData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 37
	}

	public private SelectChainData CurrentSelectChainData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 37
	}

	public private SelectCounterData CurrentSelectCounterData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 37
	}

	public private SelectDisfieldData CurrentSelectDisfieldData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private SelectEffectYnData CurrentSelectEffectYnData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 147
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 157
	}

	public private SelectOptionData CurrentSelectOptionData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 21
	}

	public private SelectPlaceData CurrentSelectPlaceData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private SelectPositionData CurrentSelectPositionData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private SelectSumData CurrentSelectSumData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 38
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 48
	}

	public private SelectTributeData CurrentSelectTributeData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 37
	}

	public private SelectUnselectCardData CurrentSelectUnselectCardData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 37
	}

	public private SelectYesNoStateData CurrentSelectYesNoStateData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private SortCardData CurrentSortCardData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 21
	}

	public private BotState CurrentState
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public string CurrentStateName
	{
		[CalledBy(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 644
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Executor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(void))]
	public AI_Custom(GameAI ai, BotDuel duel) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnAnnounceAttrib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnnounceAttributeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardAttribute>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomAnnounceAttributeRequest(int count, IList<CardAttribute> attributes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomAnnounceAttributeResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalAnnounceCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void CustomAnnounceCardFilterRequest(byte count, Int32[] filters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomAnnounceCardFilterResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalAnnounceCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void CustomAnnounceCardRequest(byte count, Int32[] filters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomAnnounceCardResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnAnnounceNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	public void CustomAnnounceNumberRequest(IList<Int32> numbers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomAnnounceNumberResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnAnnounceRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnnounceRaceData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardRace>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomAnnounceRaceRequest(int count, IList<CardRace> races) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomAnnounceRaceResponse(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomInternalAnnounceCardResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectUnselectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectTributeResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CustomInternalSelectCardResponse(BinaryReader packet) { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnSetBotResponse>d__80", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BattlePhaseAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BattleAction), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomInternalSelectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectSumResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	public bool CustomResponse(Byte[] data) { }

	[CallerCount(Count = 0)]
	public void CustomRockPaperScissorsRequest() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomRockPaperScissorsResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 3)]
	public void CustomSelectBattleCmdRequest(BotBattlePhase battle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BattlePhaseAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BattleAction), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool CustomSelectBattleCmdResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomSelectCardRequest(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable, byte count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AI_Custom), Member = "CustomInternalSelectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private bool CustomSelectCardResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	public void CustomSelectChainRequest(IList<BotClientCard> cards, IList<Int32> descs, bool forced) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomSelectChainResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int16>)}, ReturnType = typeof(Int16[]))]
	[CallsUnknownMethods(Count = 2)]
	public void CustomSelectCounterRequest(short type, short quantity, IList<BotClientCard> cards, IList<Int16> counters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CustomSelectCounterResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void CustomSelectDisfieldRequest(int cardId, int player, CardLocation location, int available) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomSelectDisfieldResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectEffectYn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SelectEffectYnData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void CustomSelectEffectYnRequest(BotClientCard card, int desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool CustomSelectEffectYnResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectIdleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 3)]
	public void CustomSelectIdleCmdRequest(BotMainPhase main) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool CustomSelectIdleCmdResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	public void CustomSelectOptionRequest(IList<Int32> options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomSelectOptionResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void CustomSelectPlaceRequest(int cardId, int player, CardLocation location, int available) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomSelectPlaceResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SelectPositionData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardPosition>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomSelectPositionRequest(int cardId, IList<CardPosition> positions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private bool CustomSelectPositionResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomSelectSumRequest(IList<BotClientCard> cards, int sum, int min, int max, int hint, bool mode, IList<BotClientCard> mandatoryCards) { }

	[CalledBy(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CustomSelectSumResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomSelectTributeRequest(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable, byte count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AI_Custom), Member = "CustomInternalSelectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private bool CustomSelectTributeResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomSelectUnselectCardRequest(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable, byte count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AI_Custom), Member = "CustomInternalSelectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private bool CustomSelectUnselectCardResponse(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	public void CustomSelectYesNoRequest(int description) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool CustomSelectYesNoResponse(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnCardSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CustomSortCardRequest(IList<BotClientCard> cards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CustomSortCardResponse(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool EnsureConnection() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public AnnounceAttributeData get_CurrentAnnounceAttributeData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public AnnounceCardData get_CurrentAnnounceCardData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public AnnounceCardFilterData get_CurrentAnnounceCardFilterData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AnnounceNumberData get_CurrentAnnounceNumberData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public AnnounceRaceData get_CurrentAnnounceRaceData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public BattleCmdStateData get_CurrentBattleCmdStateData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotGeneralStateData get_CurrentBotGeneralStateData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public IdleCmdStateData get_CurrentIdleCmdStateData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectCardStateData get_CurrentSelectCardData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectChainData get_CurrentSelectChainData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectCounterData get_CurrentSelectCounterData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectDisfieldData get_CurrentSelectDisfieldData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectEffectYnData get_CurrentSelectEffectYnData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public SelectOptionData get_CurrentSelectOptionData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectPlaceData get_CurrentSelectPlaceData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectPositionData get_CurrentSelectPositionData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectSumData get_CurrentSelectSumData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectTributeData get_CurrentSelectTributeData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectUnselectCardData get_CurrentSelectUnselectCardData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SelectYesNoStateData get_CurrentSelectYesNoStateData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SortCardData get_CurrentSortCardData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public BotState get_CurrentState() { }

	[CalledBy(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_CurrentStateName() { }

	[CalledBy(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void Init() { }

	[CalledBy(Type = typeof(GameBehavior), Member = "ReadyCustomBot", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void OnDeckSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	private bool SendCustomResponse(Byte[] response) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	private bool SendCustomResponse(int response) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentAnnounceAttributeData(AnnounceAttributeData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentAnnounceCardData(AnnounceCardData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentAnnounceCardFilterData(AnnounceCardFilterData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentAnnounceNumberData(AnnounceNumberData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentAnnounceRaceData(AnnounceRaceData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentBattleCmdStateData(BattleCmdStateData value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CurrentBotGeneralStateData(BotGeneralStateData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentIdleCmdStateData(IdleCmdStateData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectCardData(SelectCardStateData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectChainData(SelectChainData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectCounterData(SelectCounterData value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_CurrentSelectDisfieldData(SelectDisfieldData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectEffectYnData(SelectEffectYnData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectOptionData(SelectOptionData value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_CurrentSelectPlaceData(SelectPlaceData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectPositionData(SelectPositionData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectSumData(SelectSumData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectTributeData(SelectTributeData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSelectUnselectCardData(SelectUnselectCardData value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_CurrentSelectYesNoStateData(SelectYesNoStateData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_CurrentSortCardData(SortCardData value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_CurrentState(BotState value) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnTypeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void WaitForDeck() { }

}

