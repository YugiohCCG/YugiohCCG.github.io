namespace Game;

public class ClientField
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ClientCard, Boolean> <>9__38_0; //Field offset: 0x8
		public static Func<ClientCard, Boolean> <>9__39_0; //Field offset: 0x10
		public static Func<ClientCard, Boolean> <>9__49_0; //Field offset: 0x18
		public static Func<ClientCard, Boolean> <>9__50_0; //Field offset: 0x20
		public static Func<ClientCard, Boolean> <>9__70_0; //Field offset: 0x28
		public static Func<ClientCard, Boolean> <>9__74_0; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <GetCards>b__74_0(ClientCard card) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <GetCount>b__70_0(ClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetMonstersInExtraZone>b__38_0(ClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetMonstersInMainZone>b__39_0(ClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <HasAttackingMonster>b__49_0(ClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <HasDefendingMonster>b__50_0(ClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		private struct <<Init>g__initCard|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public CardLocation loc; //Field offset: 0x20
			public byte i; //Field offset: 0x24
			public <>c__DisplayClass22_0 <>4__this; //Field offset: 0x28
			public SortedDictionary<Byte, ClientCard> st; //Field offset: 0x30
			private TaskAwaiter<ClientCard> <>u__1; //Field offset: 0x38

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CardPool), Member = "RequestNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int), typeof(Player), typeof(ClientCard)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.ClientCard>))]
			[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[Calls(Type = typeof(ClientCard), Member = "UpdateLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(SortedDictionary`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 7)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public Player p; //Field offset: 0x10
		public byte owner; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass22_0() { }

		[AsyncStateMachine(typeof(<<Init>g__initCard|0>d))]
		[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.ClientField+<>c__DisplayClass22_0+<<Init>g__initCard|0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<Init>g__initCard|0>d&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal Task <Init>g__initCard|0(byte i, CardLocation loc, SortedDictionary<Byte, ClientCard> st) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public int cardId; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass69_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetRemainingCount>b__0(ClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetRemainingCount>b__1(ClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetRemainingCount>b__2(ClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetRemainingCount>b__3(ClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public int cardId; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass71_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetCountCardInZone>b__0(ClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public List<Int32> cardId; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass72_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
		internal bool <GetCountCardInZone>b__0(ClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public CardType type; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass73_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		internal bool <GetCards>b__0(ClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public int cardId; //Field offset: 0x10
		public bool notDisabled; //Field offset: 0x14
		public bool hasXyzMaterial; //Field offset: 0x15
		public bool faceUp; //Field offset: 0x16

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass75_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasXyzMaterial", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
		internal bool <HasInCards>b__0(ClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public IList<Int32> cardId; //Field offset: 0x10
		public bool notDisabled; //Field offset: 0x18
		public bool hasXyzMaterial; //Field offset: 0x19
		public bool faceUp; //Field offset: 0x1A

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass76_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasXyzMaterial", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
		internal bool <HasInCards>b__0(ClientCard card) { }

	}

	[CompilerGenerated]
	private struct <CreateField>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ClientField> <>t__builder; //Field offset: 0x8
		public int deck; //Field offset: 0x20
		public int extra; //Field offset: 0x24
		public Player p; //Field offset: 0x28
		public int player; //Field offset: 0x30
		private ClientField <field>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.ClientField+<Init>d__22"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__22&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player p; //Field offset: 0x20
		public ClientField <>4__this; //Field offset: 0x28
		public int player; //Field offset: 0x30
		public int deck; //Field offset: 0x34
		public int extra; //Field offset: 0x38
		private SortedDictionary<Byte, ClientCard> <main>5__2; //Field offset: 0x40
		private SortedDictionary<Byte, ClientCard> <ext>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldSide), Member = "get_IsPlayerSide", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = "Game.ClientField+<>c__DisplayClass22_0", Member = "<Init>g__initCard|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(System.Collections.Generic.SortedDictionary`2<System.Byte, Card.ClientCard>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 62)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly ObservableCollection<ClientCard> Hand; //Field offset: 0x10
	public readonly ObservableCollection<ClientCard> MonsterZone; //Field offset: 0x18
	public readonly ObservableCollection<ClientCard> SpellZone; //Field offset: 0x20
	public readonly ObservableCollection<ClientCard> Graveyard; //Field offset: 0x28
	public readonly ObservableCollection<ClientCard> Banished; //Field offset: 0x30
	public readonly ObservableCollection<ClientCard> Deck; //Field offset: 0x38
	public readonly ObservableCollection<ClientCard> ExtraDeck; //Field offset: 0x40
	private int _lp; //Field offset: 0x48
	public ushort DisabledZones; //Field offset: 0x4C
	public ushort LinkedZones; //Field offset: 0x4E
	public ClientCard BattlingMonster; //Field offset: 0x50
	public bool UnderAttack; //Field offset: 0x58
	public bool ReceivedBattleDamage; //Field offset: 0x59
	public bool BattlingMonsterDestroyed; //Field offset: 0x5A
	public LifePoints LPGauge; //Field offset: 0x60
	public HandCards PHand; //Field offset: 0x68
	public FieldSide PlayerField; //Field offset: 0x70

	public int LifePoints
	{
		[CalledBy(Type = "Scenes.General.LifePoints+<CheckLPTrigger>d__27", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "GetSceneTypeForLP", ReturnType = typeof(SceneType))]
		[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnLpUpdate>d__132", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnRecover>d__131", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		 get { } //Length: 13
		[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnLpUpdate>d__132", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnRecover>d__131", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(LifePoints), Member = "OnChangeLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LifePoints), Member = "CheckLPTrigger", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 70
	}

	[CalledBy(Type = typeof(<CreateField>d__21), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObservableCollection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private ClientField() { }

	[AsyncStateMachine(typeof(<CreateField>d__21))]
	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateField>d__21)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateField>d__21&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<ClientField> CreateField(int deck, int extra, Player p, int player) { }

	[CalledBy(Type = "Scenes.General.LifePoints+<CheckLPTrigger>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "GetSceneTypeForLP", ReturnType = typeof(SceneType))]
	[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnLpUpdate>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnRecover>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	public int get_LifePoints() { }

	[CalledBy(Type = typeof(ClientField), Member = "IsFieldEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CalledBy(Type = typeof(ClientField), Member = "GetSpells", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CalledBy(Type = typeof(ClientField), Member = "GetMonstersInExtraZone", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CalledBy(Type = typeof(ClientField), Member = "GetMonstersInMainZone", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CalledBy(Type = typeof(ClientField), Member = "HasAttackingMonster", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasDefendingMonster", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static List<ClientCard> GetCards(IEnumerable<ClientCard> cards) { }

	[CalledBy(Type = typeof(ClientField), Member = "GetGraveyardMonsters", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CalledBy(Type = typeof(ClientField), Member = "GetGraveyardSpells", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CalledBy(Type = typeof(ClientField), Member = "GetGraveyardTraps", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static List<ClientCard> GetCards(IEnumerable<ClientCard> cards, CardType type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int GetColumnCount(int zone, bool IncludeExtraMonsterZone = true) { }

	[CalledBy(Type = typeof(ClientField), Member = "GetMonsterCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ClientField), Member = "GetSpellCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ClientField), Member = "GetHandCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ClientField), Member = "GetFieldCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ClientField), Member = "GetFieldHandCount", ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetCount(IEnumerable<ClientCard> cards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int GetCountCardInZone(IEnumerable<ClientCard> cards, int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public int GetCountCardInZone(IEnumerable<ClientCard> cards, List<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(int))]
	public int GetFieldCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(int))]
	public int GetFieldHandCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ClientCard GetFieldSpellCard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(CardType)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	public List<ClientCard> GetGraveyardMonsters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(CardType)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	public List<ClientCard> GetGraveyardSpells() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(CardType)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	public List<ClientCard> GetGraveyardTraps() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(int))]
	public int GetHandCount() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "CalculateLinkedZones", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ClientCard), Member = "GetLinkedZones", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetLinkedZones() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(int))]
	public int GetMonsterCount() { }

	[CalledBy(Type = "Game.DuelManager+<OnNewPhase>d__127", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectBattleCmd>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	public List<ClientCard> GetMonsters() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int GetMonstersExtraZoneCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<ClientCard> GetMonstersInExtraZone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<ClientCard> GetMonstersInMainZone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public int GetRemainingCount(int cardId, int initialCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(int))]
	public int GetSpellCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int GetSpellCountWithoutField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	public List<ClientCard> GetSpells() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasAttackingMonster() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasDefendingMonster() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInBanished(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInBanished(int cardId) { }

	[CalledBy(Type = typeof(ClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInSpellZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInSpellZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrHasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInBanished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasInCards(IEnumerable<ClientCard> cards, IList<Int32> cardId, bool notDisabled = false, bool hasXyzMaterial = false, bool faceUp = false) { }

	[CalledBy(Type = typeof(ClientField), Member = "HasInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInSpellZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInSpellZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInMonstersZoneOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrHasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInMonstersZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInBanished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientField), Member = "HasInHandOrInSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool HasInCards(IEnumerable<ClientCard> cards, int cardId, bool notDisabled = false, bool hasXyzMaterial = false, bool faceUp = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInExtra(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInExtra(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInGraveyard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInGraveyard(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHand(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHand(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrHasInMonstersZone(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrHasInMonstersZone(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInGraveyard(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInGraveyard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInMonstersZoneOrInGraveyard(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInMonstersZoneOrInGraveyard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInSpellZone(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInSpellZone(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInSpellZoneOrInGraveyard(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInHandOrInSpellZoneOrInGraveyard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInMonstersZone(int cardId, bool notDisabled = false, bool hasXyzMaterial = false, bool faceUp = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInMonstersZone(IList<Int32> cardId, bool notDisabled = false, bool hasXyzMaterial = false, bool faceUp = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInMonstersZoneOrInGraveyard(IList<Int32> cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInMonstersZoneOrInGraveyard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInSpellZone(IList<Int32> cardId, bool notDisabled = false, bool faceUp = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInSpellZone(int cardId, bool notDisabled = false, bool faceUp = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInSpellZoneOrInGraveyard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "HasInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	public bool HasInSpellZoneOrInGraveyard(IList<Int32> cardId) { }

	[AsyncStateMachine(typeof(<Init>d__22))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__22)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__22&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task Init(int deck, int extra, Player p, int player) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientField), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsFieldEmpty() { }

	[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnLpUpdate>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnRecover>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(LifePoints), Member = "OnChangeLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LifePoints), Member = "CheckLPTrigger", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_LifePoints(int value) { }

}

