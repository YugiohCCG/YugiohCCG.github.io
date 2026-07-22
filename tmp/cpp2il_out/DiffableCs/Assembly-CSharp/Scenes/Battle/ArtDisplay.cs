namespace Scenes.Battle;

public class ArtDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__26_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <Create>b__26_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public Sprite tgt; //Field offset: 0x10
		public bool loaded; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass28_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <ProcessEvent>b__0(Sprite s, object o) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool <ProcessEvent>b__1() { }

	}

	[CompilerGenerated]
	private struct <Build>d__24 : IAsyncStateMachine
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
	private struct <Create>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public int tc; //Field offset: 0x28
		public float timer; //Field offset: 0x2C
		public Template target; //Field offset: 0x30
		public bool negated; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<ArtDisplay> <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArtDisplay), Member = "Build", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 28)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Create>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public int cardId; //Field offset: 0x28
		public float timer; //Field offset: 0x2C
		public bool negated; //Field offset: 0x30
		public int tc; //Field offset: 0x34
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<ArtDisplay> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(ArtDisplay), Member = "Build", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessEvent>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtDisplay <>4__this; //Field offset: 0x28
		private <>c__DisplayClass28_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Template), Member = "SetTargetingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "GetLargestSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(ArtDisplay), Member = "get_ShowCard", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArtDisplay), Member = "get_ShowHologram", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DOTweenModuleUI), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
		[Calls(Type = typeof(DOTweenModuleUI), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
		[CallsDeduplicatedMethods(Count = 21)]
		[CallsUnknownMethods(Count = 62)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static byte PopupMode; //Field offset: 0x0
	private static object ArtDisplayPrefab; //Field offset: 0x8
	public static ArtDisplay Instance; //Field offset: 0x10
	private static readonly SemaphoreSlim Semaphore; //Field offset: 0x18
	public GameObject Scaler; //Field offset: 0x20
	public Image Negation; //Field offset: 0x28
	public Image Holo; //Field offset: 0x30
	public Template CardObject; //Field offset: 0x38
	public Image TC; //Field offset: 0x40
	public TextMeshProUGUI TCAmt; //Field offset: 0x48
	public Image TCFade; //Field offset: 0x50
	private Template Target; //Field offset: 0x58
	private int CardID; //Field offset: 0x60
	private float Timer; //Field offset: 0x64
	private bool Negated; //Field offset: 0x68
	private int TurnCounters; //Field offset: 0x6C

	public static GameObject ObjectInstance
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	public static bool PopupDisabled
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 81
	}

	public static bool ShowCard
	{
		[CalledBy(Type = typeof(<ProcessEvent>d__28), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 118
	}

	public static bool ShowHologram
	{
		[CalledBy(Type = typeof(<ProcessEvent>d__28), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 118
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ArtDisplay() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ArtDisplay() { }

	[AsyncStateMachine(typeof(<Build>d__24))]
	[CalledBy(Type = typeof(<Create>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__26), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Build>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Build>d__24&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Task Build() { }

	[AsyncStateMachine(typeof(<Create>d__25))]
	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainNegated>d__83", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChaining>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoning>d__203", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoning>d__199", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__25)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__25&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Create(Template target, float timer, bool negated = false, int tc = -1) { }

	[AsyncStateMachine(typeof(<Create>d__26))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<CardHinted>d__109", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__26)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__26&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Create(int cardId, float timer, bool negated = false, int tc = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool get_PopupDisabled() { }

	[CalledBy(Type = typeof(<ProcessEvent>d__28), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_ShowCard() { }

	[CalledBy(Type = typeof(<ProcessEvent>d__28), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_ShowHologram() { }

	[AsyncStateMachine(typeof(<ProcessEvent>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessEvent>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessEvent>d__28&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "set_PlayerOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessEvent>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessEvent>d__28&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void Start() { }

}

