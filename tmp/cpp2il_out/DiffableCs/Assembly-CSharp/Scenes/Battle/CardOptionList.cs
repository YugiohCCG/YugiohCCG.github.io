namespace Scenes.Battle;

public class CardOptionList : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Card, Boolean> <>9__70_0; //Field offset: 0x8
		public static Func<Card, String> <>9__70_1; //Field offset: 0x10
		public static Func<Card, Int32> <>9__70_2; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Card), Member = "IsReferenceCard", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnSpecialSummon>b__70_0(Card c) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string <OnSpecialSummon>b__70_1(Card c) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int <OnSpecialSummon>b__70_2(Card c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public CardOptionList <>4__this; //Field offset: 0x10
		public int actIndex; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass65_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <OnActivate>b__0(ClientCard cc) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		internal void <OnActivate>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public int cardId; //Field offset: 0x10
		public CardOptionList <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass70_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnSpecialSummon>b__4(CardPosition p) { }

	}

	[CompilerGenerated]
	private struct <Build>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private ResourceRequest <rr>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Create>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Template card; //Field offset: 0x28
		public bool isTap; //Field offset: 0x30
		public Action<ReasonOptionFinish> onClose; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<CardOptionList> <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardOptionList), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReasonOptionFinish)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardOptionList), Member = "Build", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 39)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Create>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public FieldSlot fs; //Field offset: 0x28
		public bool isTap; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<CardOptionList> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardOptionList), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReasonOptionFinish)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(CardOptionList), Member = "Build", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 43)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ReasonOptionFinish
	{
		None = 0,
		LackOfActions = 1,
		Sent = 2,
	}

	public static object CardOptionListPrefab; //Field offset: 0x0
	public static CardOptionList Instance; //Field offset: 0x8
	private static readonly Vector3 InCardScale; //Field offset: 0x10
	private static readonly Vector3 InSlotScale; //Field offset: 0x1C
	private static readonly Vector3 InListScale; //Field offset: 0x28
	private static readonly SemaphoreSlim Semaphore; //Field offset: 0x38
	public static bool ShowOnHover; //Field offset: 0x40
	private static readonly Vector3 HAND_POS; //Field offset: 0x44
	private static readonly Vector3 SLOT_POS; //Field offset: 0x50
	private static readonly Vector3 LIST_POS; //Field offset: 0x5C
	public Button NormalSummon; //Field offset: 0x20
	public Button SpecialSummon; //Field offset: 0x28
	public Button PendulumSummon; //Field offset: 0x30
	public Button MonsterSet; //Field offset: 0x38
	public Button STSet; //Field offset: 0x40
	public Button ActivateAction; //Field offset: 0x48
	public Button Attack; //Field offset: 0x50
	public Button ChangePosition; //Field offset: 0x58
	public Button DrawCard; //Field offset: 0x60
	public Button ViewInfo; //Field offset: 0x68
	public Button EditInfo; //Field offset: 0x70
	public Button Move; //Field offset: 0x78
	public Button BlockZone; //Field offset: 0x80
	public Image Background; //Field offset: 0x88
	public Canvas DrawCanvas; //Field offset: 0x90
	public bool Hovering; //Field offset: 0x98
	public Template CardTarget; //Field offset: 0xA0
	public FieldSlot SlotTarget; //Field offset: 0xA8
	private bool IsAttackMsg; //Field offset: 0xB0
	private EdgeGlow Glow; //Field offset: 0xB8
	public Action<ReasonOptionFinish> OnClose; //Field offset: 0xC0

	private byte ActiveButtonCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 204
	}

	public static bool CanAppear
	{
		[CalledBy(Type = typeof(<Create>d__46), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardOptionList), Member = "InitActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(OptionBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Duel), Member = "get_IsMainPhase", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DisplayCard), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Duel), Member = "get_IsInChain", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RaceSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 1759
	}

	public bool IsMainOrExtra
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 131
	}

	public bool IsMyExtraDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsMyExtraDeck", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 131
	}

	public bool IsMyMainDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 131
	}

	public bool IsOppExtraDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsOppExtraDeck", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 131
	}

	public bool IsOppMainDeck
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsOppMainDeck", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 131
	}

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = "Scenes.Battle.CardListDisplay+<OnClose>d__49", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnEditInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnMove", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectBattleCmd>d__147", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectIdleCmd>d__172", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "set_SelectHint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static CardOptionList() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CardOptionList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <AutoModeInit>b__48_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <AutoModeInit>b__48_1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectCardPosition), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardPosition>), typeof(System.Action`1<Enumerator.CardPosition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[CompilerGenerated]
	private void <OnSpecialSummon>b__70_3() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "InitActions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(ClientCard), Member = "IsInDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(ClientCard), Member = "IsInPendulumZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CardOptionList), Member = "ParseAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Card.ClientCard>), typeof(Button)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void AutoModeInit() { }

	[AsyncStateMachine(typeof(<Build>d__44))]
	[CalledBy(Type = typeof(<Create>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Build>d__44)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Build>d__44&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Task Build() { }

	[AsyncStateMachine(typeof(<Create>d__45))]
	[CalledBy(Type = typeof(HandCards), Member = "EndDraggingClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragClone), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BattlePhase), Member = "ParseData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainPhase), Member = "ParseData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__45&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void Create(Template card, Action<ReasonOptionFinish> onClose = null, bool isTap = false) { }

	[AsyncStateMachine(typeof(<Create>d__46))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<OnEventTrigger>d__128", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__46&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Create(FieldSlot fs, bool isTap) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 16)]
	private void DefineTooltips() { }

	[CalledBy(Type = typeof(HandCards), Member = "CanDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragClone), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HandCards), Member = "EndDraggingClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragClone), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "TryFinish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Finish(ReasonOptionFinish reason = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private byte get_ActiveButtonCount() { }

	[CalledBy(Type = typeof(<Create>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardOptionList), Member = "InitActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RaceSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Duel), Member = "get_IsInChain", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DisplayCard), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMainPhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OptionBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool get_CanAppear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMainOrExtra() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsMyExtraDeck", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMyExtraDeck() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMyMainDeck() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsOppExtraDeck", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsOppExtraDeck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsOppMainDeck", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsOppMainDeck() { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<OnClose>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnViewInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnEditInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnMove", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectBattleCmd>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectIdleCmd>d__172", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "set_SelectHint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "AutoModeInit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void InitActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsOppMainDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsOppExtraDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsMyExtraDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsCenterOppCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void ManualModeInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "ManualActivateCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Int32>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetFieldZoneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	public void OnActivate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnAttack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Zones), Member = "IsAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnBlockZone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDrawCard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualStatus), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void OnEditInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void OnMove() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnNormalSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardOptionList), Member = "OnSpecialSummon", ReturnType = typeof(void))]
	public void OnPendulumSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsMyExtraDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void OnReposition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSet(bool monster) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "OnPendulumSummon", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<Card.Card, System.Boolean>), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.Card>))]
	[Calls(Type = typeof(General), Member = "ToDistinctDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Int32>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public void OnSpecialSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsOppExtraDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void OnViewInfo() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "AutoModeInit", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ParseAction(IList<ClientCard> targets, Button trigger) { }

	[CalledBy(Type = typeof(<>c__DisplayClass65_0), Member = "<OnActivate>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "<AutoModeInit>b__48_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnSpecialSummon", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnNormalSummon", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "<AutoModeInit>b__48_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnReposition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnAttack", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMainPhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainPhase), Member = "ClearData", ReturnType = typeof(void))]
	[Calls(Type = typeof(BattlePhase), Member = "ClearData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void SendSelection(int value) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "SendSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnDrawCard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReasonOptionFinish)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendSelection(BinaryWriter value) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetRotation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldAppear(FieldSlot fs) { }

	[CalledBy(Type = typeof(<Create>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInOppHand", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldAppear(Template card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardOptionList), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReasonOptionFinish)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "DefineTooltips", ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "SetRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Canvas), Member = "set_worldCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CardOptionList), Member = "InitActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start() { }

	[CalledBy(Type = typeof(DragClone), Member = "MakeClone", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReasonOptionFinish)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void TryFinish() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReasonOptionFinish)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardOptionList), Member = "SetRotation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

}

