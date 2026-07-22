namespace Extensions;

[Extension]
public static class General
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UInt16, Boolean> <>9__26_0; //Field offset: 0x8
		public static Func<Entry, Boolean> <>9__79_0; //Field offset: 0x10
		public static Func<Entry, Boolean> <>9__79_1; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ClearTooltip>b__79_0(Entry t) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ClearTooltip>b__79_1(Entry t) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <ToSetCodes>b__26_0(ushort code) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Action<PointerEventData> callback; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass71_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <AddTrigger>b__0(BaseEventData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public string tooltip; //Field offset: 0x10
		public GameObject obj; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass73_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Tooltip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector2), typeof(GameObject)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <AddTooltip>b__0(PointerEventData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public TextMeshProUGUI txt; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass80_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <ChangeOutline>b__0() { }

	}

	[CompilerGenerated]
	private struct <ChangeOutline>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TextMeshProUGUI txt; //Field offset: 0x28
		private <>c__DisplayClass80_0 <>8__1; //Field offset: 0x30
		public Color32 color; //Field offset: 0x38
		public float thickness; //Field offset: 0x3C
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Extensions.AsyncExtensions+<WaitUntil>d__5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitUntil>d__5&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(TMP_Text), Member = "set_outlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_outlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 22)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Fade>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float time; //Field offset: 0x20
		public float alphaTarget; //Field offset: 0x24
		public VideoPlayer vp; //Field offset: 0x28
		private int <steps>5__2; //Field offset: 0x30
		private float <alphaPerStep>5__3; //Field offset: 0x34
		private int <i>5__4; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(VideoPlayer), Member = "get_targetCameraAlpha", ReturnType = typeof(float))]
		[Calls(Type = typeof(VideoPlayer), Member = "set_targetCameraAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Fade>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Image img; //Field offset: 0x20
		public float alphaTarget; //Field offset: 0x28
		public float time; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DOTweenModuleUI), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetUniqueFlags>d__19 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private T flags; //Field offset: 0x0
		public T <>3__flags; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[CallerCount(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 41
		}

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetUniqueFlags>d__19`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
		[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(Enum), Member = "HasFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass9_0`1", Member = "<CreateSet>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}


	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static Byte[] <ReadPacket>g__read|58_0(NetworkStream stream, int length) { }

	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	[Extension]
	public static void AddRange(IDictionary<T, S> source, IDictionary<T, S> collection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string AddSpacesToSentence(string text, bool preserveAcronyms = false) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualStatus), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnSlotDataSet", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainMenu), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 147)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void AddTooltip(MonoBehaviour obj, string tooltip) { }

	[CalledBy(Type = typeof(DisplayCard), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "ClearTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static void AddTooltip(GameObject obj, string tooltip) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QRCode), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotativeOptionImage), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "PassThrough", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(DraggableFrame)}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = typeof(DisplayCard), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "UpdateProducts", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Janken), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Janken), Member = "StartTip", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "DefineDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 53)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static EventTrigger AddTrigger(MonoBehaviour obj, EventTriggerType type, Action<PointerEventData> callback) { }

	[CalledBy(Type = typeof(Texturizable), Member = "InitializeButtonHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "SetHostSlotData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static EventTrigger AddTrigger(GameObject obj, EventTriggerType type, Action<PointerEventData> callback) { }

	[CalledBy(Type = typeof(Texturizable), Member = "InitializeButtonHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(General), Member = "ReplaceTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = typeof(General), Member = "ReplaceTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Entry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static EventTrigger AddTrigger(EventTrigger obj, EventTriggerType type, Action<PointerEventData> callback) { }

	[CalledBy(Type = typeof(WebServer), Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string B64Safe(string b64) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnTossDice>d__95", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "YDKEHashDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool CanRead(BinaryReader rdr, int len) { }

	[CalledBy(Type = typeof(DuelZone), Member = "OnClickExit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool CanSurrender(SceneType type) { }

	[AsyncStateMachine(typeof(<ChangeOutline>d__80))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeOutline>d__80)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeOutline>d__80&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static void ChangeOutline(TextMeshProUGUI txt, Color32 color, float thickness = -1) { }

	[CalledBy(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventTrigger), Member = "get_triggers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.EventTrigger+Entry>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(General), Member = "RemoveRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static void ClearTooltip(GameObject obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tooltip), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void ClearTooltipCallback(BaseEventData data) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(General), Member = "ClearTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void ClearTriggers(MonoBehaviour obj) { }

	[CalledBy(Type = typeof(General), Member = "ReplaceTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = typeof(General), Member = "ReplaceTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CalledBy(Type = typeof(General), Member = "ClearTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Extension]
	public static void ClearTriggers(GameObject obj) { }

	[CalledBy(Type = typeof(HandCards), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnShuffle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.CardPool+<DisableCard>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(int))]
	[Extension]
	public static void ClearTweens(Component t, bool callback = true) { }

	[CallerCount(Count = 48)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void DefineTexture(Image img, Texture2D txt) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Vector3 Divide(Vector3 self, Vector3 target) { }

	[CalledBy(Type = typeof(Sound), Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool Equals(AudioClip clip, AudioClip compare, bool metadata) { }

	[AsyncStateMachine(typeof(<Fade>d__92))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Fade>d__92)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Fade>d__92&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task Fade(VideoPlayer vp, float time, float alphaTarget) { }

	[AsyncStateMachine(typeof(<Fade>d__93))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Fade>d__93)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Fade>d__93&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task Fade(Image img, float time, float alphaTarget) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Extension]
	public static Color FadeColor(Color color, float alpha) { }

	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string FixFileName(string fileName) { }

	[CalledBy(Type = "Effects.EffectHandler+<MoveHandler>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EffectHandler), Member = "DefinePosition", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static Vector3 GetAbsolutePosition(Transform self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Quaternion GetAbsoluteRotation(Transform self) { }

	[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefinePendulumBottom", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Extension]
	public static string GetAssetSubset(CardLayout layout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 GetChildLocalPosition(RectTransform rectTransformGrid, RectTransform rectTransformChild) { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetupDuelZone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpineSummon), Member = "TryPassToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<TournyUpdated>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static T GetComponentInChildrenOnly(Component comp, bool includeInactive = true) { }

	[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Vector2 GetDynamicConstraintCount(GridLayoutGroup glg) { }

	[CalledBy(Type = typeof(Customization), Member = "CheckDirBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CustomTheme), Member = "ListOfThemes", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = "Data.CustomTheme+<LoadThemeResourcesFromDisk>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<LoadFiles>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(Updater), Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomSFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "GetRandomFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(System.Func`2<System.IO.FileInfo, System.Boolean>), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "CheckDirBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "GetImportFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable`1<FileInfo>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomDatabaseFiles", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[CalledBy(Type = "Manager.Customization+<LoadCustomThemeFiles>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllReplays>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<BackupPlayerData>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BanlistManager), Member = "InitCustomBanlists", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "LoadReplayList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "ClearImportFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.IO.FileInfo, System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(DirectoryInfo), Member = "EnumerateFiles", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static IEnumerable<FileInfo> GetFileList(DirectoryInfo di) { }

	[CalledBy(Type = typeof(Hologram), Member = "SetScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ArtDisplay+<ProcessEvent>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Extension]
	public static float GetLargestSize(Vector2 v) { }

	[CalledBy(Type = "Manager.Network+<TrySeamlessAuth>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "GetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static long GetLongPlayerPref(string entry) { }

	[CalledBy(Type = typeof(ReplayList), Member = "LoadReplayList", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllReplays>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<LoadCustomThemeFiles>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "ToFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater+<UpdateDatasFile>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextures>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<LoadThemeResourcesFromDisk>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string GetNameWithoutExtension(FileInfo fi) { }

	[CalledBy(Type = "PhaseChange+<Create>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "UpdateChainValuePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static RectTransform GetRectTransform(MonoBehaviour script) { }

	[CalledBy(Type = "PhaseChange+<Create>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 GetScreenPos(Transform self) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_FirstAddedAttribute", ReturnType = typeof(CardAttribute))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_FirstAddedRace", ReturnType = typeof(CardRace))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[IteratorStateMachine(typeof(<GetUniqueFlags>d__19`1))]
	public static IEnumerable<T> GetUniqueFlags(T flags) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Int32[] GetUniqueRandomArray(int min, int max, int count) { }

	[CalledBy(Type = typeof(Card), Member = "HasOneType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_HasPendulumEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_IsScriptless", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_NeedScript", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_IsTrinityUnbound", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_IsRushCard", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_IsRushLegend", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "HasOneCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "HasOneAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_IsRush", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "IsExtraCard", ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Enum), Member = "HasFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static bool HasOneFlag(T flags, T flag) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool HasViewCode(SceneType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void InvertRotation(Transform obj1, Transform obj2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void InvertRotation(Component obj1, Component obj2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void InvertRotation(GameObject obj1, GameObject obj2) { }

	[CalledBy(Type = typeof(Customization), Member = "StructureThemeDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Data.CustomTheme+<LoadThemeResourcesFromDisk>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsBattleScene(SceneType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsDoubleTap(PointerEventData ped) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnGameMessage>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsInitializationMessage(GameMessage gmsg) { }

	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnTapCurrentPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "OnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Hotkey), Member = "get_IsSingleTouching", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsLeftTap(PointerEventData ped) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hotkey), Member = "get_IsTripleTouching", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsMiddleTap(PointerEventData ped) { }

	[CalledBy(Type = typeof(GameSettings), Member = "GetSettingsForQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelQueue)}, ReturnType = typeof(GameSettings))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsRanked(DuelQueue q) { }

	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsRightTap(PointerEventData ped) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DOTween), Member = "IsTweening", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Extension]
	public static bool IsTweening(Component t) { }

	[CalledBy(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	[Extension]
	public static T KeyByValue(IDictionary<T, W> dict, W val) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.HandCards+<>c__DisplayClass25_1", Member = "<OnShuffle>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.HandCards+<OnShuffle>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HandCards), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "MoveRepositionedCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]), typeof(Template[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass112_1", Member = "<OnShuffle>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass112_1", Member = "<OnShuffle>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass112_1", Member = "<OnShuffle>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnShuffle", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass98_0", Member = "<AttackCardMoveAnimation>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectHandler+<MoveHandler>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Ease)}, ReturnType = "T")]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Extension]
	public static TweenerCore<Vector3, Vector3, VectorOptions> MoveAnimation(Transform target, Vector3 endValue, float duration, bool snapping = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOLocalMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Ease)}, ReturnType = "T")]
	[Extension]
	public static TweenerCore<Vector3, Vector3, VectorOptions> MoveLocalAnimation(Transform target, Vector3 endValue, float duration, bool snapping = false) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Vector3 Multiply(Vector3 v1, Vector3 v2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static EventTrigger PassThrough(MonoBehaviour obj, DraggableFrame target) { }

	[CalledBy(Type = "Manager.Network+<ReceiveData>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "TryGetPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(P2PManager), Member = "TryGetPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Data.BinaryClient+<ReceiveData>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryClient), Member = "TryGetPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(List`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Byte[] ReadBytes(List<Byte> from, int length) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Byte[] ReadPacket(NetworkStream netstream) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(User), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "ReadUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Packet), Member = "ReadASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Packet), Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static User ReadUser(BinaryReader pkt, bool readRatings) { }

	[CalledBy(Type = typeof(BattlePhase), Member = "ClearData", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReverseDeck>d__75", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainPhase), Member = "ClearData", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static void RemoveAll(IList list) { }

	[CalledBy(Type = typeof(General), Member = "ClearTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	[Extension]
	public static void RemoveRange(IList<T> list, IEnumerable<T> selection) { }

	[CalledBy(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_1", Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetRPSLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetCounterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CounterTypes), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetTournamentMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TournyMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "FillLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetRarityName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetSpellTrapTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "get_GameModeNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(Localization), Member = "get_DuelRuleNamesLocal", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(Localization), Member = "get_DuelRuleNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetDescriptionForGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ReplaceFirst(string text, string search, string replace) { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_1", Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static bool ReplaceFirst(ref string text, string search, string replace) { }

	[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ReplaceLast(string text, string search, string replace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ClearTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static EventTrigger ReplaceTriggers(GameObject obj, EventTriggerType type, Action<PointerEventData> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(General), Member = "ClearTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static EventTrigger ReplaceTriggers(MonoBehaviour obj, EventTriggerType type, Action<PointerEventData> callback) { }

	[CalledBy(Type = "Scenes.General.OptionBox+<Create>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ReplaceUnderline(string msg) { }

	[CallerCount(Count = 55)]
	[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string ResponseReason(HttpListenerResponse response, int code, string reason) { }

	[CalledBy(Type = typeof(DuelLogger), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollRect), Member = "set_normalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void ScrollToBottom(ScrollRect scrollRect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "set_normalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void ScrollToTop(ScrollRect scrollRect) { }

	[CalledBy(Type = typeof(Template), Member = "SetFaceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SelfActive(GameObject obj, bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetBottom(RectTransform rt, float bottom) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_renderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "set_worldCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetCameraRenderMode(Canvas cv) { }

	[CalledBy(Type = typeof(BotStateHeader), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetCustomBotStateInfo(SerializationInfo info, byte code, string name) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "DefineTextPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OptionBox), Member = "SetupCardPrompt", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetLeft(RectTransform rt, float left) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "DefineTextPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetRight(RectTransform rt, float right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetTop(RectTransform rt, float top) { }

	[CalledBy(Type = "Manager.Network+<>c", Member = "<StartAuth>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "SetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(byte)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void SetULongPlayerPref(string entry, ulong value) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitGraphics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitSound", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitSocial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Setup(TMP_Dropdown td, int val, String[] opts) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "UpdateResolutions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitGraphics", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Setup(TMP_Dropdown td, string val, String[] opts) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static Vector2 SetY(Vector2 v, float y) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetY(RectTransform r, float y) { }

	[CalledBy(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<InitPlayerForDuel>d__180", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+PlayerCards", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(ManualDuel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static List<T> Shuffle(IEnumerable<T> list, Random rand) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "GetRadialChainOptions", ReturnType = typeof(ChainMethod[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static T[] ToArray(Array a) { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "CalculateCamera", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "ViewportToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void ToCenterOfScreen(Transform self, float height = 0) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static string ToCountdown(double val) { }

	[CalledBy(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "GetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static DateTime ToDateTime(string date, DateTime def) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "OnSpecialSummon", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	[Extension]
	public static Dictionary<TKey, TElement> ToDistinctDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer = null) { }

	[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Vector2Int ToInteger(Vector2 v) { }

	[CalledBy(Type = typeof(CoreAPI), Member = "ReadScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Card), Member = "LoadScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	public static ValueTuple<Int32, IntPtr> ToPointer(Byte[] data) { }

	[CalledBy(Type = typeof(PhaseChange), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(int))]
	[Extension]
	public static Color ToRGB(int color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector2 ToScreenPosition(Vector3 wp) { }

	[CalledBy(Type = typeof(Card), Member = "IsSupportFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(byte), typeof(byte)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static IEnumerable<UInt16> ToSetCodes(long code) { }

	[CalledBy(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "GetGoodSleeveRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(SleeveRarity))]
	[CalledBy(Type = typeof(Shop), Member = "DisplayPreview", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickSleeve", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static SleeveRarity ToSleeve(Rarity rar) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "UpdateResolutions", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	public static string ToText(Resolution res) { }

	[CalledBy(Type = typeof(DragClone), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 ToWorldPosition(Vector2 sp) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "ParseTextSearch", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "UpdateDeckList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static string WildCardToRegular(string value, out bool descOnly) { }

	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectBattleCmdRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectTributeRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectSumRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectIdleCmdRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectCounterRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectChainRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectUnselectCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IdleCmdStateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotMainPhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSortCardRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectSumData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCounterData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int16>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectChainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectUnselectCardData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardStateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortCardData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BattleCmdStateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotBattlePhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectTributeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static void WriteBotDynamicCardList(IList<BotClientCard> src, out DynamicCard[] dest) { }

}

