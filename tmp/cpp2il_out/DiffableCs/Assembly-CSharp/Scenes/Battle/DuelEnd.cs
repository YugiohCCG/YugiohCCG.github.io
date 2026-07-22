namespace Scenes.Battle;

public class DuelEnd : MonoBehaviour
{
	[CompilerGenerated]
	private struct <<OnSaveReplay>b__48_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string inputName; //Field offset: 0x28
		public DuelEnd <>4__this; //Field offset: 0x30
		private string <finalName>5__2; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelEnd), Member = "OnSaveReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelEnd), Member = "StoreReplayOnDisk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelEnd), Member = "DeleteReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__31_0; //Field offset: 0x8
		public static Func<Boolean> <>9__31_1; //Field offset: 0x10
		public static Action<Deck> <>9__39_0; //Field offset: 0x18
		public static Action <>9__41_0; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <Create>b__31_0() { }

		[CallerCount(Count = 0)]
		internal bool <Create>b__31_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Packet), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Janken), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <GoToSiding>b__39_0(Deck d) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MainMenu), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		internal void <OnLeave>b__41_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public string anim; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass33_0() { }

		[CalledBy(Type = "Scenes.Battle.DuelEnd+<EndReasonAnimation>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LockScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AudioSource), Member = "set_mute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AudioSource), Member = "Stop", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <EndReasonAnimation>g__finishAnimation|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		private struct <<StoreReplayOnDisk>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public bool r; //Field offset: 0x28
			public <>c__DisplayClass47_0 <>4__this; //Field offset: 0x30
			private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DuelEnd), Member = "StoreReplayOnDisk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
			[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(DuelEnd), Member = "OnSaveReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 7)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public DuelEnd <>4__this; //Field offset: 0x10
		public string fileName; //Field offset: 0x18
		public bool result; //Field offset: 0x20
		public bool done; //Field offset: 0x21

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass47_0() { }

		[AsyncStateMachine(typeof(<<StoreReplayOnDisk>b__0>d))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.DuelEnd+<>c__DisplayClass47_0+<<StoreReplayOnDisk>b__0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<StoreReplayOnDisk>b__0>d&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <StoreReplayOnDisk>b__0(bool r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool <StoreReplayOnDisk>b__1() { }

	}

	[CompilerGenerated]
	private struct <Create>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public byte win; //Field offset: 0x28
		public byte reason; //Field offset: 0x29
		public bool isRanked; //Field offset: 0x2A
		public bool isReplay; //Field offset: 0x2B
		public bool isOver; //Field offset: 0x2C
		public bool hasReplay; //Field offset: 0x2D
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private bool <tie>5__2; //Field offset: 0x38
		private ResourceRequest <rr>5__3; //Field offset: 0x40
		private TaskAwaiter<DuelEnd> <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelEnd), Member = "OnLeave", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelEnd), Member = "EndReasonAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelEndReason)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 37)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EndReasonAnimation>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelEndReason reason; //Field offset: 0x28
		private <>c__DisplayClass33_0 <>8__1; //Field offset: 0x30
		private float <timer>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass33_0", Member = "<EndReasonAnimation>g__finishAnimation|0", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LockScreen), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Action), typeof(short)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SettingsMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CardListDisplay), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AudioSource), Member = "set_mute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 37)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoBackToGameRoom>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "CloseAllDuelWindows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(GameRoom), Member = "Create", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnLeave>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelEnd <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelEnd), Member = "GoBackToLobby", ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "CloseAllDuelWindows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelEnd), Member = "GoToSiding", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ReplayList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRewatch>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelEnd <>4__this; //Field offset: 0x28
		private ClientReplay <rp>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "CloseAllDuelWindows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelZone), Member = "PrepareDuel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ClientReplay), typeof(ulong), typeof(ulong), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelEnd <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DuelEnd), Member = "UpdateLanguage", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "ResetMatchResults", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelEnd), Member = "get_HasSomeoneLeft", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DeckEdit), Member = "set_SidingDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelEnd), Member = "StoreReplayOnDisk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 29)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StoreReplayOnDisk>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public DuelEnd <>4__this; //Field offset: 0x20
		public string fileName; //Field offset: 0x28
		public bool overwrite; //Field offset: 0x30
		private <>c__DisplayClass47_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelEnd), Member = "DeleteReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "SerializeFile", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 23)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object DuelEndPrefab; //Field offset: 0x0
	public static DuelEnd Instance; //Field offset: 0x8
	private static readonly SemaphoreSlim Semaphore; //Field offset: 0x10
	public static bool IsPlayingEndAnimation; //Field offset: 0x18
	[Header("Buttons")]
	public Button Rematch; //Field offset: 0x20
	public Button RoomScreen; //Field offset: 0x28
	public Button SaveReplay; //Field offset: 0x30
	public Button Leave; //Field offset: 0x38
	public Button CheckField; //Field offset: 0x40
	[Header("Images")]
	public Image Logo; //Field offset: 0x48
	public RawImage Fade; //Field offset: 0x50
	public Image TextFade; //Field offset: 0x58
	[Header("Texts")]
	public TextMeshProUGUI Reason; //Field offset: 0x60
	public TextMeshProUGUI Result; //Field offset: 0x68
	public TextMeshProUGUI RatingChange; //Field offset: 0x70
	private bool WasReplay; //Field offset: 0x78
	private bool WasRanked; //Field offset: 0x79
	private bool HasWon; //Field offset: 0x7A
	private bool HasDraw; //Field offset: 0x7B
	private bool IsMatchOver; //Field offset: 0x7C
	private byte EndReason; //Field offset: 0x7D
	private bool HasReplay; //Field offset: 0x7E
	private bool IsWaitingForRematch; //Field offset: 0x7F
	private string ReplayNameAutoSaved; //Field offset: 0x80

	private bool HasSomeoneLeft
	{
		[CalledBy(Type = typeof(<Start>d__37), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 391
	}

	private byte HowManyLeft
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 405
	}

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	private bool ShowRatingChange
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 234
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DuelEnd() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DuelEnd() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <OnCheckField>b__38_0() { }

	[AsyncStateMachine(typeof(<<OnSaveReplay>b__48_0>d))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<OnSaveReplay>b__48_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<OnSaveReplay>b__48_0>d&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private void <OnSaveReplay>b__48_0(string inputName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>), typeof(string), typeof(bool), typeof(string), typeof(bool), typeof(Action), typeof(bool), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__37_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__37_1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__37_2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Start>b__37_3() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <UpdateLanguage>b__35_0(Material m, object o) { }

	[AsyncStateMachine(typeof(<Create>d__31))]
	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__31&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Create(byte win, byte reason, bool isRanked, bool isReplay, bool isOver, bool hasReplay = true) { }

	[CalledBy(Type = typeof(<<OnSaveReplay>b__48_0>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<StoreReplayOnDisk>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DeleteReplay(string fileName) { }

	[AsyncStateMachine(typeof(<EndReasonAnimation>d__33))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EndReasonAnimation>d__33)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EndReasonAnimation>d__33&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void EndReasonAnimation(DuelEndReason reason) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(<Start>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool get_HasSomeoneLeft() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private byte get_HowManyLeft() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_ShowRatingChange() { }

	[CalledBy(Type = typeof(DuelField), Member = "SetVariables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void GetEndFieldData(out bool won, out bool lost, out bool tied) { }

	[AsyncStateMachine(typeof(<GoBackToGameRoom>d__44))]
	[CalledBy(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelEnd), Member = "OnOtherPlayerUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GoBackToGameRoom>d__44)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GoBackToGameRoom>d__44&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void GoBackToGameRoom() { }

	[CalledBy(Type = typeof(<OnLeave>d__41), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "LeaveRoomLobby", ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_IsReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LobbyScreen), Member = "GoToLobby", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void GoBackToLobby() { }

	[CalledBy(Type = typeof(<OnLeave>d__41), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnChangeSide>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Deck), Member = "get_LastUsedDeckName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DeckEdit), Member = "CreateEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Card.Deck>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void GoToSiding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnCheckField() { }

	[AsyncStateMachine(typeof(<OnLeave>d__41))]
	[CalledBy(Type = typeof(<Create>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLeave>d__41)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLeave>d__41&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnLeave() { }

	[CalledBy(Type = typeof(Network), Member = "OnHsPlayerChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelEnd), Member = "GoBackToGameRoom", ReturnType = typeof(void))]
	[Calls(Type = typeof(BotCore), Member = "CreateBot", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnOtherPlayerUpdate(bool isBot) { }

	[CalledBy(Type = typeof(DuelEnd), Member = "<Start>b__37_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelEnd), Member = "<Start>b__37_2", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnRematchDuel>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RoomData), Member = "get_IsMatch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Packet), Member = "RematchRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelEnd), Member = "GoBackToGameRoom", ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomData), Member = "get_HasBot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_PlayedBotCount", ReturnType = typeof(byte))]
	[Calls(Type = typeof(BotCore), Member = "CreateBot", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRewatch>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRewatch>d__42&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void OnRematch(bool toRoom) { }

	[AsyncStateMachine(typeof(<OnRewatch>d__42))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRewatch>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRewatch>d__42&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnRewatch() { }

	[CalledBy(Type = typeof(<<OnSaveReplay>b__48_0>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass47_0+<<StoreReplayOnDisk>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>), typeof(string), typeof(bool), typeof(string), typeof(bool), typeof(Action), typeof(bool), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnSaveReplay(string replayName = null) { }

	[AsyncStateMachine(typeof(<Start>d__37))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__37&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Start() { }

	[AsyncStateMachine(typeof(<StoreReplayOnDisk>d__47))]
	[CalledBy(Type = typeof(<<OnSaveReplay>b__48_0>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c__DisplayClass47_0+<<StoreReplayOnDisk>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Start>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StoreReplayOnDisk>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StoreReplayOnDisk>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> StoreReplayOnDisk(string fileName, bool overwrite = false) { }

	[CalledBy(Type = typeof(<Start>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetVictoryMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelEndReason)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LastChanges), Member = "GetRatingChange", ReturnType = typeof(float))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public void UpdateLanguage() { }

}

