namespace Scenes.Battle;

public class DuelZone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ClientCard, Boolean> <>9__82_10; //Field offset: 0x8
		public static Func<ClientCard, Boolean> <>9__82_11; //Field offset: 0x10
		public static Action <>9__90_0; //Field offset: 0x18
		public static Func<ChainMethod, String> <>9__108_0; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
		internal string <GetRadialChainLabels>b__108_0(ChainMethod cm) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MainMenu), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		internal void <OnExit>b__90_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_IsUseable", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <SetupZoneCallbacks>b__82_10(ClientCard c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_IsUseable", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <SetupZoneCallbacks>b__82_11(ClientCard c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass101_0
	{
		public ClientCard card; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass101_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <SetFieldBackground>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass84_0
	{
		public Image radial; //Field offset: 0x10
		public DuelZone <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass84_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(DuelZone), Member = "GetRadialChainOptions", ReturnType = typeof(ChainMethod[]))]
		[Calls(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <Awake>b__0(PointerEventData e) { }

	}

	[CompilerGenerated]
	private struct <ClearAllCards>d__135 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private Enumerator<FieldSlot> <>7__wrap1; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private HandCards[] <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "DestroySlotCards", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HandCards), Member = "DestroyHand", ReturnType = typeof(Task))]
		[Calls(Type = typeof(ChatWindow), Member = "ClearLog", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 21)]
		[CallsUnknownMethods(Count = 48)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAllDuelWindows>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool cards; //Field offset: 0x20
		public bool self; //Field offset: 0x21
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualStatus), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DisplayCard), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(RaceSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(AttributeSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(InfoBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(TextBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(OptionBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(SettingsMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DuelEnd), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Janken), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DuelManager), Member = "ClearPacketQueue", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.DuelZone+<ClearAllCards>d__135"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ClearAllCards>d__135&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardListDisplay), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 91)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DefineBG>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelZone <>4__this; //Field offset: 0x28
		public ClientCard card; //Field offset: 0x30
		public byte player; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.DuelZone+<SetFieldBackground>d__101"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetFieldBackground>d__101&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelZone), Member = "DefineBGState", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoParse>d__145 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public DuelZone <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "GetQueuedPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(General), Member = "IsInitializationMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "OnPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage), typeof(BinaryReader)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "get_DEF_AT", ReturnType = typeof(float))]
		[Calls(Type = typeof(ClientField), Member = "GetLinkedZones", ReturnType = typeof(int))]
		[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(byte), typeof(byte)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FixedUpdate>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelZone <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyles)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "ShouldParseReplay", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(DuelZone), Member = "DoParse", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(DuelManager), Member = "get_HasGamePackets", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ToCountdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "get_EOMPTimeLeft", ReturnType = typeof(double))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Tournament), Member = "get_RoundTimeLeft", ReturnType = typeof(double))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 60)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnExit>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelZone <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "CloseAllDuelWindows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ReplayList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareDuel>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isReplay; //Field offset: 0x20
		public ClientReplay replayFile; //Field offset: 0x28
		public ulong readingSteinerStep; //Field offset: 0x30
		public Byte[] lastPacket; //Field offset: 0x38
		public ulong step; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<DuelZone> <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CameraController), Member = "CameraBootstrap", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "InitializeReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientReplay), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LifePoints), Member = "SetTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientReplay), Member = "get_HasSharedData", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "RegisterPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.DuelField+<Create>d__39"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__39&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Janken), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 60)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadingSteiner>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public long steps; //Field offset: 0x28
		private ulong <maxStep>5__2; //Field offset: 0x30
		private ulong <currentStep>5__3; //Field offset: 0x38
		private ClientReplay <replay>5__4; //Field offset: 0x40
		private Byte[] <lastPacket>5__5; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "get_CanReadingSteiner", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "StopReplaySkipping", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "CloseAllDuelWindows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelZone), Member = "PrepareDuel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ClientReplay), typeof(ulong), typeof(ulong), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 42)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Rewind>d__134 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ulong steps; //Field offset: 0x28
		private ulong <currentStep>5__2; //Field offset: 0x30
		private ClientReplay <replay>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "CloseAllDuelWindows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelZone), Member = "PrepareDuel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ClientReplay), typeof(ulong), typeof(ulong), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetFieldBackground>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientCard card; //Field offset: 0x20
		public byte player; //Field offset: 0x28
		public DuelZone <>4__this; //Field offset: 0x30
		private <>c__DisplayClass101_0 <>8__1; //Field offset: 0x38
		private ParticleSystem <target>5__2; //Field offset: 0x40
		private bool <enableOpFlag>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldBG), Member = "SetFieldSpellMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldBG), Member = "SetOpponentFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldBG), Member = "SetPSSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 61)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static bool _af; //Field offset: 0x0
	public const string CFieldName = "Center"; //Field offset: 0x0
	public const string OPFieldName = "Opponent"; //Field offset: 0x0
	public const string PFieldName = "Player"; //Field offset: 0x0
	public static bool AutoZone; //Field offset: 0x1
	private static FieldBGMode _fieldSpellBG; //Field offset: 0x4
	private static Vector3 _dcs; //Field offset: 0x8
	[CompilerGenerated]
	private static DuelZone <Instance>k__BackingField; //Field offset: 0x18
	public static object DuelZonePrefab; //Field offset: 0x20
	private static readonly Vector2 ChatWindowPos; //Field offset: 0x28
	private static readonly Vector2 DuelDisplayCard; //Field offset: 0x30
	private static readonly Vector2 LP0Pos; //Field offset: 0x38
	private static readonly Vector2 LP1Pos; //Field offset: 0x40
	private static readonly Vector2 ChatWindowSize; //Field offset: 0x48
	private static readonly Vector2 DuelDisplayCardSize; //Field offset: 0x50
	public static bool IsDisplayUnlocked; //Field offset: 0x58
	private static readonly bool UseRadialCycling; //Field offset: 0x59
	[Header("Duel Area")]
	public FieldSide PlayerSide; //Field offset: 0x20
	public FieldSide OpponentSide; //Field offset: 0x28
	public FieldCenter CenterZone; //Field offset: 0x30
	public Transform P1Target; //Field offset: 0x38
	public Transform P2Target; //Field offset: 0x40
	public FieldBG FieldBackground; //Field offset: 0x48
	[Header("Overlay")]
	public Canvas Overlay; //Field offset: 0x50
	public PhaseSelect PhaseSelector; //Field offset: 0x58
	public Template DisplayCard; //Field offset: 0x60
	public LifePoints[] LifeGauges; //Field offset: 0x68
	public HandCards[] PlayersHand; //Field offset: 0x70
	public Button FinishSelection; //Field offset: 0x78
	public TextMeshProUGUI Hint; //Field offset: 0x80
	public TextMeshProUGUI RoundTimer; //Field offset: 0x88
	public DuelLogger DuelVisualLog; //Field offset: 0x90
	public CameraController CameraControls; //Field offset: 0x98
	[Header("Options")]
	public Button SettingsButton; //Field offset: 0xA0
	public Button ManualShuffleHandButton; //Field offset: 0xA8
	public Button Surrender; //Field offset: 0xB0
	public Toggle ShowDisplayPic; //Field offset: 0xB8
	public Toggle VisualLog; //Field offset: 0xC0
	public Button RedrawHand; //Field offset: 0xC8
	public Button ResetManual; //Field offset: 0xD0
	[Header("Chains")]
	public Image ChainCycle; //Field offset: 0xD8
	public TextMeshProUGUI ChainCycleLabel; //Field offset: 0xE0
	private Image[] ChainRadials; //Field offset: 0xE8
	private TextMeshProUGUI[] ChainRadialLabels; //Field offset: 0xF0
	public VerticalLayoutGroup RadialChain; //Field offset: 0xF8
	public Button TopViewButton; //Field offset: 0x100
	private Action _finishButtonAction; //Field offset: 0x108
	public Image FinishActionIcon; //Field offset: 0x110
	public FinishIcon CurrentFinishIcon; //Field offset: 0x118
	public readonly DuelManager DuelSystem; //Field offset: 0x120
	private List<FieldSlot> _allFieldSlots; //Field offset: 0x128
	public DraggableFrame HintDrag; //Field offset: 0x130
	private sbyte FieldMask; //Field offset: 0x138
	private bool RadialChangedThisFrame; //Field offset: 0x139
	private bool LastChainWasUserInitiated; //Field offset: 0x13A
	private readonly List<ChainMethod> HeldChain; //Field offset: 0x140
	private bool OpponentPerspective; //Field offset: 0x148
	private Byte[] ReadingSteinerPacket; //Field offset: 0x150
	public bool ReEnableGFX; //Field offset: 0x158
	private readonly SemaphoreSlim ReadingSteinerSemaphore; //Field offset: 0x160
	private readonly SemaphoreSlim Semaphore; //Field offset: 0x168

	public List<FieldSlot> AllFieldZones
	{
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__clear|0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 15)]
		 get { } //Length: 1852
	}

	public static bool AutoFlip
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		 set { } //Length: 83
	}

	public static bool CanReadingSteiner
	{
		[CalledBy(Type = typeof(<ReadingSteiner>d__133), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "get_HasGamePackets", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 484
	}

	public bool CanSwapPerspective
	{
		[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientReplay), Member = "get_HasSharedData", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 121
	}

	public static Vector2 DisplayCardSize
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 93
		[CalledBy(Type = typeof(DuelZone), Member = "SetUpOptimizedView", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "DragDisplayCardBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 439
	}

	public static FieldBGMode FieldSpellBG
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "DefineBGState", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 204
	}

	public string HintText
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(General), Member = "ReplaceUnderline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 196
	}

	public private static DuelZone Instance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 110
	}

	public static bool IsDueling
	{
		[CallerCount(Count = 92)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 173
	}

	public bool IsHoldingChain
	{
		[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 112
	}

	private bool IsReplaySkipping
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 37
	}

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass33_0", Member = "<EndReasonAnimation>g__finishAnimation|0", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<Start>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<CloseAllDuelWindows>d__79), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<PrepareDuel>d__77), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 290
	}

	public Action OnClickFinishAction
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelEnd), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 365
	}

	private bool WasReplaySkipping
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 34
	}

	[CallerCount(Count = 0)]
	private static DuelZone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public DuelZone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <GetRadialChainOptions>b__107_0(ChainMethod lcm) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnExit>d__90)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnExit>d__90&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <OnClickExit>b__91_0(bool r) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_5() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_6() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_7() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_8() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <SetupZoneCallbacks>b__82_9() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "get_ChainOption", ReturnType = typeof(ChainSetting))]
	[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DuelZone), Member = "OnRadialChain", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Start>b__88_0(PointerEventData data) { }

	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AllowChain(bool allow) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "set_worldCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientField), Member = "GetLinkedZones", ReturnType = typeof(int))]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(byte), typeof(byte)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	private void CalculateLinkedZones() { }

	[AsyncStateMachine(typeof(<ClearAllCards>d__135))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ClearAllCards>d__135)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ClearAllCards>d__135&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task ClearAllCards() { }

	[CalledBy(Type = "Game.DuelManager+<OnChainEnd>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChaining>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FieldSide), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[Calls(Type = typeof(HandCards), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClearAllTargeting() { }

	[AsyncStateMachine(typeof(<CloseAllDuelWindows>d__79))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<GoBackToGameRoom>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<OnLeave>d__41", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<OnRewatch>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnExit>d__90), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadingSteiner>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Rewind>d__134), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnWaitingSide>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseAllDuelWindows>d__79)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseAllDuelWindows>d__79&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task CloseAllDuelWindows(bool self = true, bool cards = true) { }

	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InfoBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(OptionBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RaceSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(AttributeSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DuelEnd), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LineArc), Member = "ClearAllLines", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsUnimplementedInstructions]
	public static void CloseDuelForEnd() { }

	[AsyncStateMachine(typeof(<DefineBG>d__99))]
	[CalledBy(Type = typeof(DuelZone), Member = "SetFieldBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSide), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "SetFieldBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineBG>d__99)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineBG>d__99&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DefineBG(ClientCard card = null, byte player = 0) { }

	[CalledBy(Type = typeof(<DefineBG>d__99), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "set_FieldSpellBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldBGMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldBG), Member = "SetFieldSpellMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldBG), Member = "SetOpponentFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DefineBGState() { }

	[CalledBy(Type = typeof(<>c__DisplayClass84_0), Member = "<Awake>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnRadialSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnAvailableChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DuelZone), Member = "SetRadialState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "get_ChainOption", ReturnType = typeof(ChainSetting))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DefineChain(bool down, bool userInitiated, bool radial, ChainMethod chain) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineChainIcon() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineFinishIcon(FinishIcon ic) { }

	[AsyncStateMachine(typeof(<DoParse>d__145))]
	[CalledBy(Type = typeof(<FixedUpdate>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoParse>d__145)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoParse>d__145&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<Boolean> DoParse() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(DuelZone), Member = "set_DisplayCardSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DragDisplayCardBorder(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	private void DragDisplayCardBorderEnd(PointerEventData data) { }

	[AsyncStateMachine(typeof(<FixedUpdate>d__147))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixedUpdate>d__147)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixedUpdate>d__147&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void FixedUpdate() { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__clear|0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	public List<FieldSlot> get_AllFieldZones() { }

	[CallerCount(Count = 0)]
	public static bool get_AutoFlip() { }

	[CalledBy(Type = typeof(<ReadingSteiner>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelManager), Member = "get_HasGamePackets", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool get_CanReadingSteiner() { }

	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientReplay), Member = "get_HasSharedData", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_CanSwapPerspective() { }

	[CallerCount(Count = 0)]
	public static Vector2 get_DisplayCardSize() { }

	[CallerCount(Count = 0)]
	public static FieldBGMode get_FieldSpellBG() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_HintText() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static DuelZone get_Instance() { }

	[CallerCount(Count = 92)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public static bool get_IsDueling() { }

	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsHoldingChain() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IsReplaySkipping() { }

	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass33_0", Member = "<EndReasonAnimation>g__finishAnimation|0", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<Start>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CloseAllDuelWindows>d__79), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<PrepareDuel>d__77), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action get_OnClickFinishAction() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_WasReplaySkipping() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "GetRadialChainOptions", ReturnType = typeof(ChainMethod[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private String[] GetRadialChainLabels() { }

	[CalledBy(Type = typeof(<>c__DisplayClass84_0), Member = "<Awake>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnRadialChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnRadialSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "GetRadialChainLabels", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(General), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(Int32Enum[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	private ChainMethod[] GetRadialChainOptions() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapAutoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	public void OnAvailableChain(bool down, bool key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "get_ChainOption", ReturnType = typeof(ChainSetting))]
	[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DuelZone), Member = "OnRadialChain", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void OnClickChainIcon() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "CanSurrender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickExit() { }

	[CalledBy(Type = "Scenes.Battle.FieldSlot+<OnEventTrigger>d__128", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapFinish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickFinish() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnClickManualShuffleHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickRedrawHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsMenu), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void OnClickSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCyclicChain() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CardPool), Member = "DisableCardAndForget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnExit>d__90))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnExit>d__90)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnExit>d__90&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnExit() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapFullChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	public void OnFullChain(bool down, bool key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnManualReset() { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapNoChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	public void OnNoChain(bool down, bool key) { }

	[CalledBy(Type = typeof(DuelZone), Member = "OnClickChainIcon", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "<Start>b__88_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "SetRadialState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "GetRadialChainOptions", ReturnType = typeof(ChainMethod[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnRadialChain() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "GetRadialChainOptions", ReturnType = typeof(ChainMethod[]))]
	[Calls(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnRadialSelected(int opt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_LinkInfo), Member = "GetLinkID", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DisplayCard), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnTappingHint(PointerEventData pointerData) { }

	[AsyncStateMachine(typeof(<PrepareDuel>d__77))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<PlayClient>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<OnRewatch>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadingSteiner>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Rewind>d__134), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnGameMessage>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PrepareDuel>d__77)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PrepareDuel>d__77&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task PrepareDuel(bool isReplay = false, ClientReplay replayFile = null, ulong step = 0, ulong readingSteinerStep = 0, Byte[] lastPacket = null) { }

	[AsyncStateMachine(typeof(<ReadingSteiner>d__133))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadingSteiner>d__133)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadingSteiner>d__133&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ReadingSteiner(long steps) { }

	[AsyncStateMachine(typeof(<Rewind>d__134))]
	[CalledBy(Type = typeof(DuelZone), Member = "SwapPerspective", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldCenter+<>c", Member = "<OnLeftPhaseButton>b__35_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Rewind>d__134)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Rewind>d__134&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Rewind(ulong steps) { }

	[CallerCount(Count = 0)]
	public static void set_AutoFlip(bool value) { }

	[CalledBy(Type = typeof(DuelZone), Member = "SetUpOptimizedView", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DragDisplayCardBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_DisplayCardSize(Vector2 value) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "DefineBGState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_FieldSpellBG(FieldBGMode value) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "ReplaceUnderline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_HintText(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_Instance(DuelZone value) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelEnd), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_OnClickFinishAction(Action value) { }

	[CalledBy(Type = "Game.DuelManager+<OnChainSolved>d__104", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "DefineBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(byte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetFieldBackground(ClientCard card = null) { }

	[AsyncStateMachine(typeof(<SetFieldBackground>d__101))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetFieldBackground>d__101)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetFieldBackground>d__101&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task SetFieldBackground(ClientCard card = null, byte player = 0) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "DefineBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(byte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SetFieldBackground(FieldSide fs, ClientCard card = null) { }

	[CalledBy(Type = typeof(DuelZone), Member = "DefineBGState", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnTagSwap>d__125", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "SetCanDisplayInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "set_SafeOpt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(FieldBG), Member = "EnablePlayerPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldBG), Member = "SetPSSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetPlaymats() { }

	[CalledBy(Type = typeof(DuelZone), Member = "OnRadialChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetRadialState(bool state) { }

	[CalledBy(Type = typeof(DuelZone), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DraggableFrame), Member = "LoadPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetupDuelZone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "LoadPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "SetAndStoreSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_DisplayCardSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetUpOptimizedView() { }

	[CalledBy(Type = typeof(DuelZone), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void SetupZoneCallbacks() { }

	[CalledBy(Type = typeof(<FixedUpdate>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "StopReplaySkipping", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelManager), Member = "get_HasGamePackets", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldParseReplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DuelZone), Member = "SetupZoneCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "SetupDuelZone", ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetChainMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "StopReplaySkipping", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void StopReadingSteiner() { }

	[CalledBy(Type = typeof(<ReadingSteiner>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "StopReadingSteiner", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "ShouldParseReplay", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StopReplaySkipping() { }

	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientReplay), Member = "get_HasSharedData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SwapPerspective() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ToggleDisplayPic(bool val) { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelLogger), Member = "ToggleLog", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelLogger), Member = "get_IsDisplaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleVisualLog() { }

	[CallerCount(Count = 0)]
	private void Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "GetFormatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "GetModeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DiscordController), Member = "UpdateRichPresence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void UpdateDiscordPresence() { }

}

