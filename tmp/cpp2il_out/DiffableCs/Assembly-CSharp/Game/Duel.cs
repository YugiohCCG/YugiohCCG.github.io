namespace Game;

public class Duel
{
	[CompilerGenerated]
	private struct <AddCard>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ClientCard> <>t__builder; //Field offset: 0x8
		public int cardId; //Field offset: 0x20
		public CardLocation loc; //Field offset: 0x24
		public byte seq; //Field offset: 0x28
		public byte pos; //Field offset: 0x29
		public Duel <>4__this; //Field offset: 0x30
		public byte player; //Field offset: 0x38
		public ClientCard cc; //Field offset: 0x40
		public byte overlayCount; //Field offset: 0x48
		private TaskAwaiter<ClientCard> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private byte <b>5__2; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardPool), Member = "RequestNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int), typeof(Player), typeof(ClientCard)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.ClientCard>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<AddCard>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<AddCard>d__45&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Duel+<AddCard>d__48"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddCard>d__48&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(ClientCard), Member = "OverlayAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<AddCard>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<AddCard>d__45&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AddCard>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CardLocation loc; //Field offset: 0x20
		public ClientCard card; //Field offset: 0x28
		public int id; //Field offset: 0x30
		public byte player; //Field offset: 0x34
		public byte seq; //Field offset: 0x35
		public byte pos; //Field offset: 0x36
		public Duel <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "UpdateLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "GetCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(System.Collections.Generic.IList`1<Card.ClientCard>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Duel+<OverlayCard>d__47"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OverlayCard>d__47&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardPool), Member = "DisableCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 22)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OverlayCard>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientCard card; //Field offset: 0x20
		public ClientCard overlay; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Collection`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "OverlayAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Collection`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 31)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public bool IsFirst; //Field offset: 0x10
	public readonly ClientField[] Fields; //Field offset: 0x18
	public bool Started; //Field offset: 0x20
	public ushort Turn; //Field offset: 0x22
	public byte Player; //Field offset: 0x24
	public bool DeckReversed; //Field offset: 0x25
	public DuelPhase Phase; //Field offset: 0x28
	public MainPhase MainPhase; //Field offset: 0x30
	public BattlePhase BattlePhase; //Field offset: 0x38
	public byte ChainCount; //Field offset: 0x40
	public bool WasInChain; //Field offset: 0x41
	public sbyte LastChainPlayer; //Field offset: 0x42
	public readonly ObservableCollection<ClientCard> CurrentChain; //Field offset: 0x48
	public readonly ObservableCollection<ClientCard> ChainTargets; //Field offset: 0x50
	public readonly ObservableCollection<ClientCard> ChainTargetOnly; //Field offset: 0x58
	public sbyte LastSummonPlayer; //Field offset: 0x60
	public readonly ObservableCollection<ClientCard> SummoningCards; //Field offset: 0x68
	public readonly ObservableCollection<ClientCard> LastSummonedCards; //Field offset: 0x70
	public HintTiming DuelState; //Field offset: 0x78
	public CardType SPSummonType; //Field offset: 0x7C
	public ushort SPSummonMaterialCount; //Field offset: 0x80

	public bool CanPhaseShift
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 206
	}

	public bool IsBattlePhase
	{
		[CalledBy(Type = "Scenes.Battle.CardOptionList+<>c__DisplayClass65_0", Member = "<OnActivate>b__1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardOptionList), Member = "AutoModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldCenter), Member = "CanRightPhaseShift", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_IsUseable", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ClientCard), Member = "UpdateActions", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 38
	}

	public bool IsInChain
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool IsMainPhase
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldCenter), Member = "CanRightPhaseShift", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_IsUseable", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 20
	}

	public bool IsMyTurn
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "OnTapCurrentPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "UpdateTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "UpdatePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectChain>d__166", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 27
	}

	public byte LocalPlayer
	{
		[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		 get { } //Length: 19
	}

	public List<DuelPhase> PossiblePhases
	{
		[CalledBy(Type = typeof(PhaseSelect), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 709
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObservableCollection`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Duel() { }

	[AsyncStateMachine(typeof(<AddCard>d__48))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass79_0+<<OnSwapGraveDeck>g__doSwap|0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSwap>d__134", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddCard>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddCard>d__48&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task AddCard(CardLocation loc, ClientCard card, byte player, byte seq, byte pos, int id) { }

	[AsyncStateMachine(typeof(<AddCard>d__45))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddCard>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddCard>d__45&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task<ClientCard> AddCard(CardLocation loc, int cardId, byte player, byte seq, byte pos, byte overlayCount = 0, ClientCard cc = null) { }

	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Collection`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "OverlayRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ClientCard DetachCard(ClientCard card, int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_CanPhaseShift() { }

	[CalledBy(Type = "Scenes.Battle.CardOptionList+<>c__DisplayClass65_0", Member = "<OnActivate>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardOptionList), Member = "AutoModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanRightPhaseShift", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_IsUseable", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "UpdateActions", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	public bool get_IsBattlePhase() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsInChain() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanRightPhaseShift", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_IsUseable", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool get_IsMainPhase() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnTapCurrentPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "UpdateTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "UpdatePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectChain>d__166", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[ContainsUnimplementedInstructions]
	public bool get_IsMyTurn() { }

	[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	public byte get_LocalPlayer() { }

	[CalledBy(Type = typeof(PhaseSelect), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public List<DuelPhase> get_PossiblePhases() { }

	[CalledBy(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(ClientCard))]
	[CalledBy(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Duel), Member = "GetCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(System.Collections.Generic.IList`1<Card.ClientCard>))]
	[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ClientCard GetCard(byte player, byte loc, byte seq, byte subSeq) { }

	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnFieldCardInfo>d__51", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(ClientCard))]
	public ClientCard GetCard(byte player, CardLocation loc, byte seq) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public ClientCard GetCard(byte player, CardLocation loc, byte seq, byte subSeq) { }

	[CalledBy(Type = typeof(<AddCard>d__48), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(ClientCard))]
	[CalledBy(Type = typeof(Duel), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnUpdateData>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public IList<ClientCard> GetCardList(byte player, CardLocation location) { }

	[CalledBy(Type = "Game.DuelManager+<OnSwap>d__134", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Duel), Member = "GetFieldSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte), typeof(byte)}, ReturnType = typeof(FieldSlot))]
	[CallsUnknownMethods(Count = 1)]
	public FieldSlot GetFieldSlot(ClientCard card) { }

	[CalledBy(Type = typeof(Duel), Member = "GetFieldSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(FieldSlot))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public FieldSlot GetFieldSlot(CardLocation loc, byte player, byte seq) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Zones), Member = "IsAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public List<FieldSlot> GetFieldSlots(CardLocation loc, byte player, int filter) { }

	[CalledBy(Type = typeof(ClientCard), Member = "get_HandOwner", ReturnType = typeof(HandCards))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public HandCards GetHand(byte player) { }

	[CallerCount(Count = 47)]
	public byte GetLocalPlayer(byte player) { }

	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsInOverlay(byte position) { }

	[CalledBy(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "set_TargetingIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RoomData), Member = "get_IsTeam", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsOpponent(byte player) { }

	[AsyncStateMachine(typeof(<OverlayCard>d__47))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OverlayCard>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OverlayCard>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OverlayCard(ClientCard card, ClientCard overlay) { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass79_0+<<OnSwapGraveDeck>g__doSwap|0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSwap>d__134", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Duel), Member = "GetCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(System.Collections.Generic.IList`1<Card.ClientCard>))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "UpdateLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveCard(CardLocation loc, ClientCard card, int player, int seq) { }

}

