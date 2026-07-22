namespace Scenes.Battle;

public class SelectCardPosition : DraggableFrame
{
	[CompilerGenerated]
	private struct <Create>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public int cardId; //Field offset: 0x28
		public Action<CardPosition> onSelect; //Field offset: 0x30
		public IList<CardPosition> available; //Field offset: 0x38
		private ResourceRequest <rr>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<SelectCardPosition> <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object SelectPositionPrefab; //Field offset: 0x0
	public static SelectCardPosition Instance; //Field offset: 0x8
	public Template FaceDownDefense; //Field offset: 0x98
	public Template FaceUpDefense; //Field offset: 0xA0
	public Template FaceUpAttack; //Field offset: 0xA8
	public Template FaceDownAttack; //Field offset: 0xB0
	public IList<CardPosition> Available; //Field offset: 0xB8
	public Action<CardPosition> OnSelect; //Field offset: 0xC0
	public int CardID; //Field offset: 0xC8

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_2", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_3", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 150
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	public SelectCardPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	private void <Start>b__12_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	private void <Start>b__12_1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	private void <Start>b__12_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	private void <Start>b__12_3() { }

	[AsyncStateMachine(typeof(<Create>d__11))]
	[CalledBy(Type = typeof(CardOptionList), Member = "<OnSpecialSummon>b__70_3", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectPosition>d__181", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__11&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void Create(int cardId, IList<CardPosition> available, Action<CardPosition> onSelect) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_CanAppear", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_2", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = "<Start>b__12_3", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "set_PlayerOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void Start() { }

}

