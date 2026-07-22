namespace DuelBot.Game;

public class GameBehavior
{
	internal class YGOClient
	{
		[CompilerGenerated]
		private byte <BotID>k__BackingField; //Field offset: 0x10
		private GameBehavior Bot; //Field offset: 0x18

		public private byte BotID
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
			[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 370
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public YGOClient(GameBehavior bot, byte botId) { }

		[CalledBy(Type = typeof(GameBehavior), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnLeaveGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnTypeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnDuelEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnErrorMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BotCore), Member = "DestroyBot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		public void Close() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public byte get_BotID() { }

		[CalledBy(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "SurrenderGame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "SendReady", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "ReadyCustomBot", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnChangeSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnTypeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "OnRetry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public void Send(CtosMessage msg) { }

		[CallerCount(Count = 35)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public void Send(CtosMessage msg, int val) { }

		[CalledBy(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "SendUpdateDeck", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsInvalidInstructions]
		public void Send(BinaryWriter packet) { }

		[CalledBy(Type = typeof(GameBehavior), Member = "OnCardSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "PostSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "PostSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "PostSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameBehavior), Member = "PostSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AI_Custom), Member = "CustomSortCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AI_Custom), Member = "SendCustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AI_Custom), Member = "CustomInternalSelectCardResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectSumResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public void Send(CtosMessage msg, Byte[] data) { }

		[CalledBy(Type = typeof(AIUtil), Member = "SendPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void Send(Byte[] data) { }

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_BotID(byte value) { }

	}

	public readonly YGOClient Connection; //Field offset: 0x10
	public readonly short DeckIndex; //Field offset: 0x18
	private readonly GameAI _ai; //Field offset: 0x20
	private readonly IDictionary<StocMessage, Action`1<BinaryReader>> _packets; //Field offset: 0x28
	private readonly IDictionary<GameMessage, Action`1<BinaryReader>> _messages; //Field offset: 0x30
	private readonly BotDuel _duel; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsCustomBot>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsReady>k__BackingField; //Field offset: 0x41
	private int _select_hint; //Field offset: 0x44
	private GameMessage _lastMessage; //Field offset: 0x48

	public AI_Custom CustomAI
	{
		[CallerCount(Count = 31)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 128
	}

	public Deck Deck
	{
		[CalledBy(Type = "ClientAPI.WebServer+BotInfo+<Create>d__4", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 26
		[CalledBy(Type = "ClientAPI.WebServer+<OnSetCustomBotData>d__83", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 36
	}

	public BotDuel DuelInfo
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private bool IsCustomBot
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private bool IsReady
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(BotCore), Member = "CreateBot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "RegisterPackets", ReturnType = typeof(void))]
	[Calls(Type = typeof(BotDuel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecksManager), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameAI), typeof(BotDuel)}, ReturnType = typeof(Executor))]
	[Calls(Type = typeof(GameBehavior), Member = "RegisterMessages", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int16>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public GameBehavior(short deckIndex, byte botId) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(AI_Custom), Member = "get_CurrentStateName", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public void DefineCustomBotStateInfo(out byte code, out string name) { }

	[CallerCount(Count = 31)]
	[CallsUnknownMethods(Count = 1)]
	public AI_Custom get_CustomAI() { }

	[CalledBy(Type = "ClientAPI.WebServer+BotInfo+<Create>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public Deck get_Deck() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public BotDuel get_DuelInfo() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsCustomBot() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsReady() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public byte GetLocalPlayer(byte player) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnAnnounceCardFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnAnnounceCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomAnnounceCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomAnnounceCardFilterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalAnnounceCard(BinaryReader packet, bool isFilter) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectTribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectTributeRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void InternalOnSelectCard(BinaryReader packet, Func<IList`1<BotClientCard>, Int32, Int32, Int32, Boolean, IList`1<BotClientCard>> func, bool isTribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	private void InternalOnSelectPlace(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectUnselectCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void InternalOnSelectUnselectCard(BinaryReader packet, Func<IList`1<BotClientCard>, Int32, Int32, Int32, Boolean, IList`1<BotClientCard>> func) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomAnnounceAttributeRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardAttribute>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnnounceAttrib(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "InternalAnnounceCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	private void OnAnnounceCard(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "InternalAnnounceCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	private void OnAnnounceCardFilter(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomAnnounceNumberRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void OnAnnounceNumber(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomAnnounceRaceRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardRace>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void OnAnnounceRace(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	private void OnAttack(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void OnAttackDisabled(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void OnBattle(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void OnBecomeTarget(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCancelTarget(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSortCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	private void OnCardSorting(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void OnCardTarget(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnChainEnd(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private void OnChaining(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnChainSorting(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnChangeSide(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDamage(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDraw(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnDuelEnd(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEquip(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnErrorMsg(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnHint(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "SendUpdateDeck", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnJoinGame(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnLeaveGame(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnLpUpdate(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotDuel), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(BotClientCard), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotDuel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(BotClientCard), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotDuel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	private void OnMove(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void OnNewPhase(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnNewTurn(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void OnPacket(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "ClearCardTargets", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPosChange(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnRecover(BinaryReader packet) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnReplay(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnRetry(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnRockPaperScissors(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameAI), Member = "OnSelectBattleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(BattlePhaseAction))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectBattleCmdRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void OnSelectBattleCmd(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`6), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	private void OnSelectCard(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "OnSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectChainRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void OnSelectChain(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectCounterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 8)]
	private void OnSelectCounter(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	private void OnSelectDisfield(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "OnSelectEffectYn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectEffectYnRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelectEffectYn(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelectHand(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(GameAI), Member = "OnSelectIdleCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(MainPhaseAction))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectIdleCmdRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private void OnSelectIdleCmd(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectOptionRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void OnSelectOption(BinaryReader packet) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectDisfield", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectPlaceRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectDisfieldRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelectPlace(BinaryReader packet, bool disfield) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectPositionRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardPosition>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void OnSelectPosition(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameAI), Member = "OnSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[Calls(Type = typeof(GameBehavior), Member = "PostSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI_Custom), Member = "CustomSelectSumRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void OnSelectSum(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnSelectTp(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`6), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	private void OnSelectTribute(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`6), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "InternalOnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>)}, ReturnType = typeof(void))]
	private void OnSelectUnselectCard(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnSelectYesNo(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnShuffleDeck(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void OnShuffleExtra(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnShuffleHand(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	private void OnShuffleSetCard(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void OnSpSummoned(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void OnSpSummoning(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int16>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnStart(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void OnSummoned(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void OnSummoning(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotDuel), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(BotClientCard), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotDuel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(BotClientCard), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSwap(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSystemMsg(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void OnTagSwap(BinaryReader packet) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnTimeLimit(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(AI_Custom), Member = "WaitForDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTypeChange(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnUnEquip(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	[Calls(Type = typeof(BotClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnUpdateCard(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(BotDuel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	private void OnUpdateData(BinaryReader packet) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnWin(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PostAnnounceAttribute(IList<CardAttribute> attributes, byte count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PostAnnounceRace(IList<CardRace> races, byte count) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "InternalOnSelectUnselectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(System.Func`6<System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>, System.Int32, System.Int32, System.Int32, System.Boolean, System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public void PostSelectCard(IList<BotClientCard> selected, IList<BotClientCard> cards, int min, int max, int hint, bool cancelable, byte count) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectCounterResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void PostSelectCounter(IList<Int16> used) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectDisfieldResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectPlaceResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void PostSelectPlace(int selected, byte player, CardLocation location, int filter) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void PostSelectSum(IList<BotClientCard> selected, IList<BotClientCard> mandatoryCards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(AI_Custom), Member = "OnDeckSet", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "SendUpdateDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ReadyCustomBot() { }

	[CalledBy(Type = typeof(GameBehavior), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 59)]
	[CallsUnknownMethods(Count = 60)]
	private void RegisterMessages() { }

	[CalledBy(Type = typeof(GameBehavior), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	private void RegisterPackets() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SendReady() { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnJoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "ReadyCustomBot", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Packet), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void SendUpdateDeck() { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnSetCustomBotData>d__83", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_Deck(Deck value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsCustomBot(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsReady(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(YGOClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SurrenderGame() { }

}

