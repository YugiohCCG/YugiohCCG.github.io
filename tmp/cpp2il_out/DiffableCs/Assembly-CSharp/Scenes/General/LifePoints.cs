namespace Scenes.General;

public class LifePoints : DraggableFrame
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__39_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <OnClickLPBar>b__39_0(string s) { }

	}

	[CompilerGenerated]
	private struct <CheckLPTrigger>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MakeLPBar>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LifePoints <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Player), Member = "get_Avatar", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Sprite), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float LPSFXTimer = 2.399; //Field offset: 0x0
	public TextMeshProUGUI Username; //Field offset: 0x98
	public Image AvatarFrame; //Field offset: 0xA0
	public Image Avatar; //Field offset: 0xA8
	public Image BarsFrame; //Field offset: 0xB0
	public Image LPBar; //Field offset: 0xB8
	public TextMeshProUGUI LPValue; //Field offset: 0xC0
	public Image TimeBar; //Field offset: 0xC8
	public TextMeshProUGUI TimeValue; //Field offset: 0xD0
	public TextMeshProUGUI TurnValue; //Field offset: 0xD8
	public Image Frame; //Field offset: 0xE0
	public ParticleSystem MatchCounter; //Field offset: 0xE8
	public ParticleSystem Hourglass; //Field offset: 0xF0
	public Image ActivePlayerFrame; //Field offset: 0xF8
	public int PlayerID; //Field offset: 0x100
	public Player Owner; //Field offset: 0x108
	public byte Controller; //Field offset: 0x110
	public readonly List<Int32> Descriptions; //Field offset: 0x118
	private int CurrentLP; //Field offset: 0x120
	private float CurrentTimer; //Field offset: 0x124
	public bool TimerActive; //Field offset: 0x128
	private int LPTarget; //Field offset: 0x12C
	private float LPChangeRate; //Field offset: 0x130
	public bool FrameState; //Field offset: 0x134
	private bool TimerPermanentlyDisabled; //Field offset: 0x135
	private int LastTimerVal; //Field offset: 0x138
	private float _elapsedTime; //Field offset: 0x13C
	private float _lastTickRate; //Field offset: 0x140
	private DateTime LastQuickTimer; //Field offset: 0x148

	private float ElapsedTime
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 9
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 18
	}

	private bool IncreasedTickRate
	{
		[CalledBy(Type = typeof(LifePoints), Member = "get_TickRate", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 170
	}

	private bool IncreasedTickRate2
	{
		[CalledBy(Type = typeof(LifePoints), Member = "get_TickRate", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 183
	}

	private bool IncreasedTickRate3
	{
		[CalledBy(Type = typeof(LifePoints), Member = "get_TickRate", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 172
	}

	private byte TickRate
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate2", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate3", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 189
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LifePoints() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[Calls(Type = typeof(Player), Member = "get_Avatar", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <MakeLPBar>b__23_0() { }

	[AsyncStateMachine(typeof(<CheckLPTrigger>d__27))]
	[CalledBy(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckLPTrigger>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckLPTrigger>d__27&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void CheckLPTrigger() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_timeScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate3", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LifePoints), Member = "SetTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LifePoints), Member = "SetLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void FixedUpdate() { }

	[CallerCount(Count = 0)]
	private float get_ElapsedTime() { }

	[CalledBy(Type = typeof(LifePoints), Member = "get_TickRate", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IncreasedTickRate() { }

	[CalledBy(Type = typeof(LifePoints), Member = "get_TickRate", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IncreasedTickRate2() { }

	[CalledBy(Type = typeof(LifePoints), Member = "get_TickRate", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(LifePoints), Member = "SetHourglassColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IncreasedTickRate3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate3", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private byte get_TickRate() { }

	[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static SceneType GetSceneTypeForLP() { }

	[AsyncStateMachine(typeof(<MakeLPBar>d__23))]
	[CalledBy(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MakeLPBar>d__23)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MakeLPBar>d__23&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void MakeLPBar() { }

	[CalledBy(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.General.LPChange+<Create>d__12"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void OnChangeLP(int oldLp, int newLp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "SwapPerspective", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.General.InfoBox+<Create>d__9"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__9&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>), typeof(string), typeof(bool), typeof(string), typeof(bool), typeof(Action), typeof(bool), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_CanSwapPerspective", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "set_Clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "IsRightTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public void OnClickLPBar(PointerEventData data) { }

	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnEndTurn() { }

	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnStartTurn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void OnTickRateIncreased() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private void set_ElapsedTime(float value) { }

	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "SwapTeamPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MakeLPBar>d__23)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MakeLPBar>d__23&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetData(int pid) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void SetElapsed(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetFrame(bool active) { }

	[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "get_startColor", ReturnType = typeof(MinMaxGradient))]
	[Calls(Type = typeof(MinMaxGradient), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(MinMaxGradient))]
	[Calls(Type = typeof(MainModule), Member = "set_startColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxGradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate2", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LifePoints), Member = "get_IncreasedTickRate3", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainModule), Member = "set_simulationSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetHourglassColor() { }

	[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void SetLP(int value) { }

	[CalledBy(Type = typeof(DuelManager), Member = "UpdateWaiting", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetState(bool state) { }

	[CalledBy(Type = typeof(LifePoints), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnTimeLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LifePoints), Member = "UpdatedTimerFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void SetTimer(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

	[CalledBy(Type = typeof(LifePoints), Member = "SetTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdatedTimerFill(float amt) { }

}

