namespace Extensions;

public class LockScreen : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Create>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool withoutInfo; //Field offset: 0x20
		public bool invisible; //Field offset: 0x21
		public Action onFinish; //Field offset: 0x28
		public short sortOrder; //Field offset: 0x30
		private ResourceRequest <rr>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<LockScreen> <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LockScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object LockScreenPrefab; //Field offset: 0x0
	public static LockScreen Instance; //Field offset: 0x8
	private static readonly Color FadeColor; //Field offset: 0x10
	public TextMeshProUGUI Message; //Field offset: 0x20
	public Image Frame; //Field offset: 0x28
	public Button Fade; //Field offset: 0x30
	private bool WithoutInfo; //Field offset: 0x38
	private bool Invisible; //Field offset: 0x39
	private Action OnFinish; //Field offset: 0x40

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = typeof(OptionBox), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass52_0", Member = "<DeckSync>b__4", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass33_0", Member = "<EndReasonAnimation>g__finishAnimation|0", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<>c__DisplayClass48_0", Member = "<OpenFileBrowserDialogAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<>c__DisplayClass48_0", Member = "<OpenFileBrowserDialogAsync>b__1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<Create>d__11), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	[CallerCount(Count = 0)]
	private static LockScreen() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LockScreen() { }

	[AsyncStateMachine(typeof(<Create>d__11))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<OpenFileBrowserDialogAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey+<ReadKey>d__82", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__11&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task Create(bool withoutInfo = false, bool invisible = false, Action onFinish = null, short sortOrder = 32767) { }

	[CalledBy(Type = typeof(OptionBox), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass52_0", Member = "<DeckSync>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass33_0", Member = "<EndReasonAnimation>g__finishAnimation|0", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<>c__DisplayClass48_0", Member = "<OpenFileBrowserDialogAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<>c__DisplayClass48_0", Member = "<OpenFileBrowserDialogAsync>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__11), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnClickFade() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void Start() { }

}

