namespace DuelBot;

public class BotCore
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameBehavior, Boolean> <>9__8_0; //Field offset: 0x8

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
		internal bool <GetNextBotID>b__8_0(GameBehavior bot) { }

	}

	private const byte MAX_BOTS = 6; //Field offset: 0x0
	internal static Random Rand; //Field offset: 0x0
	public static readonly GameBehavior[] BotInstances; //Field offset: 0x8
	public static readonly Queue<Int16> LastBotDecks; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static BotCore() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BotCore() { }

	[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void ClearAllBots() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelEnd), Member = "OnOtherPlayerUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int16>), Member = "Peek", ReturnType = typeof(short))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static void CreateBot() { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnClickAddBot", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BotCore), Member = "CreateTestBot", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RoomData), Member = "get_IsFull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int16>), Member = "Dequeue", ReturnType = typeof(short))]
	[Calls(Type = typeof(GameBehavior), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "AddBot", ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void CreateBot(short deckIndex) { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnClickAddBot", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<ConnectToTest>d__339", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotCore), Member = "CreateBot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	public static void CreateTestBot() { }

	[CalledBy(Type = typeof(YGOClient), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void DestroyBot(byte botId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static byte GetNextBotID() { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static void HandleMessage(BinaryReader packet) { }

	[CalledBy(Type = "Manager.Helper+<DatabaseDeserialize>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecksManager), Member = "InitAllDecks", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Packet), Member = "AddBot", ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	public static void SendAddBot() { }

}

