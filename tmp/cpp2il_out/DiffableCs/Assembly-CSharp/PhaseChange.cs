//Type is in global namespace

public class PhaseChange : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Create>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool opponent; //Field offset: 0x28
		public DuelPhase phase; //Field offset: 0x2C
		public bool turn; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private ResourceRequest <rr>5__2; //Field offset: 0x40
		private TaskAwaiter<PhaseChange> <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(PhaseChange), Member = "OnEnd", ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(General), Member = "GetRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(RectTransform))]
		[Calls(Type = typeof(General), Member = "GetScreenPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 27)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object Prefab; //Field offset: 0x0
	private const float FontSizeStart = 56; //Field offset: 0x0
	private const float FontSizeEnd = 72; //Field offset: 0x0
	private const float MaxSpawnTime = 0.25; //Field offset: 0x0
	private static readonly SemaphoreSlim Semaphore; //Field offset: 0x8
	private static readonly Color SELF; //Field offset: 0x10
	private static readonly Color OP; //Field offset: 0x20
	private bool IsOpponent; //Field offset: 0x20
	private DuelPhase Phase; //Field offset: 0x24
	private bool IsTurn; //Field offset: 0x28
	private Image BG; //Field offset: 0x30
	private TextMeshProUGUI Label; //Field offset: 0x38
	private float TimeSinceSpawn; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "ToRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[CallsUnknownMethods(Count = 1)]
	private static PhaseChange() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PhaseChange() { }

	[AsyncStateMachine(typeof(<Create>d__7))]
	[CalledBy(Type = typeof(FieldCenter), Member = "UpdateTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "UpdatePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__7&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Create(DuelPhase phase, bool opponent, bool turn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PhaseChange), Member = "OnEnd", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(<Create>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhaseChange), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnd() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetPhaseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Start() { }

}

