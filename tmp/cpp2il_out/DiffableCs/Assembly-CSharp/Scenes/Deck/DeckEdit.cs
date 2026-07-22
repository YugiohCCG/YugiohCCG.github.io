namespace Scenes.Deck;

public class DeckEdit : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Deck> <>9__304_0; //Field offset: 0x8
		public static Func<Boolean> <>9__304_1; //Field offset: 0x10
		public static Func<Banlist, String> <>9__310_0; //Field offset: 0x18
		public static Func<Banlist, String> <>9__310_1; //Field offset: 0x20
		public static Action <>9__338_5; //Field offset: 0x28
		public static Func<Boolean> <>9__339_0; //Field offset: 0x30
		public static Action<Boolean> <>9__368_0; //Field offset: 0x38

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
		internal bool <ConnectToTest>b__339_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <GetTestInfo>b__338_5() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
		internal void <OnCloseButton>b__368_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "get_ListableName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <OnEnable>b__310_0(Banlist bl) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "get_ListableName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <OnEnable>b__310_1(Banlist bl) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeckSelection), Member = "GoToDeckList", ReturnType = typeof(void))]
		internal void <ShowEditor>b__304_0(Deck d) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <ShowEditor>b__304_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass321_0
	{
		public int cardId; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass321_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <GetCurDisplayedCardIndex>b__0(Template c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass327_0
	{
		public Toggle t; //Field offset: 0x10
		public DeckEdit <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass327_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Awake>b__34(bool state) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass338_0
	{
		public bool noShuffle; //Field offset: 0x10
		public byte startHand; //Field offset: 0x11
		public bool picked; //Field offset: 0x12
		public bool cancel; //Field offset: 0x13
		public Action<Boolean> <>9__3; //Field offset: 0x18
		public Action<String> <>9__4; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass338_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.General.TextBox+<Create>d__16"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 16)]
		internal void <GetTestInfo>b__0() { }

		[CallerCount(Count = 0)]
		internal void <GetTestInfo>b__1() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <GetTestInfo>b__2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <GetTestInfo>b__3(bool shuffle) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <GetTestInfo>b__4(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass368_0
	{
		public DeckEdit <>4__this; //Field offset: 0x10
		public Deck orgDeck; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass368_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnCloseButton>b__2(bool r) { }

		[CalledBy(Type = typeof(DeckEdit), Member = "OnCloseButton", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnCloseButton>g__finish|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass393_0
	{
		public Dictionary<Int32, Byte> lastIndex; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass393_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(DeckEdit), Member = "OrganizeCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <RepositionCards>b__0(Template c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(DeckEdit), Member = "OrganizeCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <RepositionCards>b__1(Template c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(DeckEdit), Member = "OrganizeCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <RepositionCards>b__2(Template c) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass414_0
	{
		public int tmp; //Field offset: 0x0
		public List<Int32> src; //Field offset: 0x8
		public int cid; //Field offset: 0x10
		public int min; //Field offset: 0x14
		public int max; //Field offset: 0x18
		public Template ct; //Field offset: 0x20
		public Template[] deck; //Field offset: 0x28

	}

	[CompilerGenerated]
	private struct <ConnectToTest>d__339 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte startHand; //Field offset: 0x20
		public bool noShuffle; //Field offset: 0x21
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Packet), Member = "CreateGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameSettings)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(BotCore), Member = "CreateTestBot", ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Player), Member = "UpdateMyPlaymat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Create>d__307 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private ResourceRequest <rr>5__2; //Field offset: 0x30
		private TaskAwaiter<DeckEdit> <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 20)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateEditor>d__305 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Action<Deck> onFinish; //Field offset: 0x28
		public string deck; //Field offset: 0x30
		public bool reducedUi; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeckEdit), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Card.Deck>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DiscordController), Member = "UpdateRichPresence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EmptyDeckAnimation>d__389 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private IEnumerator<Template> <>7__wrap1; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Concat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTestInfo>d__338 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`3<Boolean, Boolean, Byte>> <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass338_0 <>8__1; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<GetTestInfo>d__338)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<GetTestInfo>d__338&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 23)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAutoDeck>d__370 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private TaskAwaiter<Deck> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeckAPI), Member = "RequestAutoDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.Deck>))]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "UpdateAllDisplays", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnEnable>d__310 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "get_DeckCard", ReturnType = typeof(int))]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(DeckEdit), Member = "EnableButtonsForUI", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Player), Member = "UpdateMySleeve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "ResetFilters", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Dropdown), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Enumerable), Member = "Union", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
		[Calls(Type = typeof(Banlist), Member = "get_ListableName", ReturnType = typeof(string))]
		[Calls(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DeckEdit), Member = "HideCalendars", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "LoadFilters", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFavoriteChanged>d__359 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		public bool value; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Manager), Member = "RemoveFavoriteCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Manager), Member = "AddFavoriteCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSaveButton>d__372 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private bool <changedName>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "OnSaveNewButton", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "get_DeckCard", ReturnType = typeof(int))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Manager), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Deck), typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Manager), Member = "DeckExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 17)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSaveNewButton>d__371 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private string <newName>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Manager), Member = "AddDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Deck)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "SetDeckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTestRoom>d__340 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private ValueTuple<Boolean, Boolean, Byte> <input>5__2; //Field offset: 0x30
		private TaskAwaiter<ValueTuple`3<Boolean, Boolean, Byte>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "get_ConnectionIsReady", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeckEdit), Member = "GetTestInfo", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "get_IsLocalConnected", ReturnType = typeof(bool))]
		[Calls(Type = typeof(P2PManager), Member = "StartHostingLocally", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(DeckEdit), Member = "ConnectToTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshDisplayedCards>d__362 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DeckEdit <>4__this; //Field offset: 0x28
		private object <obj>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		private object <>u__3; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Manager), Member = "GetAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.Card>))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(AwaiterExtensions), Member = "GetAwaiter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityMainThread)}, ReturnType = typeof(SimpleCoroutineAwaiter))]
		[Calls(Type = typeof(SimpleCoroutineAwaiter), Member = "GetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "OnEndRefresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(<RefreshDisplayedCards>d__362)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(<RefreshDisplayedCards>d__362&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<RefreshDisplayedCards>d__362)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<RefreshDisplayedCards>d__362&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 21)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowEditor>d__304 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private Deck <deck>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(DeckEdit), Member = "CreateEditor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Card.Deck>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DeckEdit), Member = "UpdateCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static bool SaveFilterState; //Field offset: 0x0
	private static object DeckEditPrefab; //Field offset: 0x8
	public static bool IgnoreDeckValidation; //Field offset: 0x10
	public static DeckEdit Instance; //Field offset: 0x18
	public static Deck ServerSideDeck; //Field offset: 0x20
	private static readonly SemaphoreSlim DeckMaker; //Field offset: 0x28
	private static readonly Vector3 AscendingRotation; //Field offset: 0x30
	private static Deck _sidingDeck; //Field offset: 0x40
	public static Deck LastTestDeck; //Field offset: 0x48
	[Header("Deck Paging")]
	private int DeckPage; //Field offset: 0x20
	public Button PrevDeckPage; //Field offset: 0x28
	public Button NextDeckPage; //Field offset: 0x30
	public TextMeshProUGUI DeckPageLabel; //Field offset: 0x38
	[Header("General")]
	public TextMeshProUGUI Title; //Field offset: 0x40
	[Header("Top Left Bar")]
	public Button CloseButton; //Field offset: 0x48
	public Button SaveButton; //Field offset: 0x50
	public Button AutoDeckButton; //Field offset: 0x58
	public Button SettingsButton; //Field offset: 0x60
	public Button EmptyButton; //Field offset: 0x68
	public Button SortButton; //Field offset: 0x70
	public Button ShuffleButton; //Field offset: 0x78
	public Button TestRoom; //Field offset: 0x80
	[Header("Top Right Bar")]
	public TextMeshProUGUI SearchStringLabel; //Field offset: 0x88
	public Button FilterBoxButton; //Field offset: 0x90
	[Header("Card Trunk")]
	public LayoutElement TrunkBox; //Field offset: 0x98
	public Image TrunkBG; //Field offset: 0xA0
	public Button UpArrow; //Field offset: 0xA8
	public Button DownArrow; //Field offset: 0xB0
	public TextMeshProUGUI PageCount; //Field offset: 0xB8
	public Transform TrunkCardList; //Field offset: 0xC0
	private readonly Template[] CardTrunk; //Field offset: 0xC8
	[Header("Card Display")]
	public Template DisplayCard; //Field offset: 0xD0
	[Header("Deck Box Labels")]
	public TextMeshProUGUI MainLabel; //Field offset: 0xD8
	public TextMeshProUGUI ExtraLabel; //Field offset: 0xE0
	public TextMeshProUGUI SideLabel; //Field offset: 0xE8
	public TextMeshProUGUI MainPriceLabel; //Field offset: 0xF0
	public TextMeshProUGUI ExtraPriceLabel; //Field offset: 0xF8
	public TextMeshProUGUI SidePriceLabel; //Field offset: 0x100
	public TextMeshProUGUI DeckPriceLabel; //Field offset: 0x108
	[Header("Deck Box Counters")]
	public TextMeshProUGUI GenesysCounter; //Field offset: 0x110
	public TextMeshProUGUI MainCounter; //Field offset: 0x118
	public TextMeshProUGUI NormalCounter; //Field offset: 0x120
	public TextMeshProUGUI EffectCounter; //Field offset: 0x128
	public TextMeshProUGUI RitualCounter; //Field offset: 0x130
	public TextMeshProUGUI SpellCounter; //Field offset: 0x138
	public TextMeshProUGUI TrapCounter; //Field offset: 0x140
	public TextMeshProUGUI FusionCounter; //Field offset: 0x148
	public TextMeshProUGUI SynchroCounter; //Field offset: 0x150
	public TextMeshProUGUI XYZCounter; //Field offset: 0x158
	public TextMeshProUGUI LinkCounter; //Field offset: 0x160
	public TextMeshProUGUI ExtraCounter; //Field offset: 0x168
	public TextMeshProUGUI SideCounter; //Field offset: 0x170
	[Header("Banlist Box")]
	public GameObject SidingBox; //Field offset: 0x178
	public Button FinishButton; //Field offset: 0x180
	public Button ResetSidingButton; //Field offset: 0x188
	public TextMeshProUGUI TimeLeft; //Field offset: 0x190
	public TMP_InputField DeckName; //Field offset: 0x198
	public TMP_Dropdown BanlistDropdown; //Field offset: 0x1A0
	public Button SaveNewButton; //Field offset: 0x1A8
	public BoxSlot DeckCardButton; //Field offset: 0x1B0
	public GameObject RarityLabel; //Field offset: 0x1B8
	public GridLayoutGroup Rarities; //Field offset: 0x1C0
	public TextMeshProUGUI OfflineRarities; //Field offset: 0x1C8
	public BoxSlot CommonCards; //Field offset: 0x1D0
	public BoxSlot RareCards; //Field offset: 0x1D8
	public BoxSlot SuperRareCards; //Field offset: 0x1E0
	public BoxSlot UltraRareCards; //Field offset: 0x1E8
	public BoxSlot SecretRareCards; //Field offset: 0x1F0
	public BoxSlot UltimateRareCards; //Field offset: 0x1F8
	public BoxSlot ParallelRareCards; //Field offset: 0x200
	public BoxSlot GhostRareCards; //Field offset: 0x208
	public BoxSlot FireRareCards; //Field offset: 0x210
	public BoxSlot WaterRareCards; //Field offset: 0x218
	public BoxSlot WindRareCards; //Field offset: 0x220
	public BoxSlot EarthRareCards; //Field offset: 0x228
	public BoxSlot LightRareCards; //Field offset: 0x230
	public BoxSlot DarkRareCards; //Field offset: 0x238
	public Toggle FavoriteCard; //Field offset: 0x240
	public DatePicker ReleaseDateFrom; //Field offset: 0x248
	public DatePicker ReleaseDateTo; //Field offset: 0x250
	public TMP_InputField Budget; //Field offset: 0x258
	[Header("Deck Box")]
	public GridLayoutGroup MainDeckBox; //Field offset: 0x260
	public Transform ExtraDeckBox; //Field offset: 0x268
	public Transform SideDeckBox; //Field offset: 0x270
	private Template[] MainDeck; //Field offset: 0x278
	private Template[] ExtraDeck; //Field offset: 0x280
	private Template[] SideDeck; //Field offset: 0x288
	[Header("Filter Box")]
	public ScrollRect FilterBox; //Field offset: 0x290
	public GameObject FilterContent; //Field offset: 0x298
	public Button ApplyButton; //Field offset: 0x2A0
	public Button ResetButton; //Field offset: 0x2A8
	[Header("Sort Box")]
	public GameObject SortTab; //Field offset: 0x2B0
	public Toggle Ascending; //Field offset: 0x2B8
	public Button SortType; //Field offset: 0x2C0
	[Header("Search Filter")]
	public TMP_InputField SearchString; //Field offset: 0x2C8
	[Header("Filter Parents")]
	public GameObject Categories; //Field offset: 0x2D0
	public GameObject Options; //Field offset: 0x2D8
	[Header("Filter Categories")]
	public Toggle CardType; //Field offset: 0x2E0
	public Toggle SubType; //Field offset: 0x2E8
	public Toggle MonsterType; //Field offset: 0x2F0
	public Toggle MonsterSubType; //Field offset: 0x2F8
	public Toggle Attribute; //Field offset: 0x300
	public Toggle Attack; //Field offset: 0x308
	public Toggle Defense; //Field offset: 0x310
	public Toggle LevelRank; //Field offset: 0x318
	public Toggle PendulumScale; //Field offset: 0x320
	public Toggle LinkLevel; //Field offset: 0x328
	public Toggle CardPool; //Field offset: 0x330
	public Toggle Limitation; //Field offset: 0x338
	[Header("Card Type Filter")]
	public GameObject CardTypeTab; //Field offset: 0x340
	public Toggle MonsterCard; //Field offset: 0x348
	public Toggle SpellCard; //Field offset: 0x350
	public Toggle TrapCard; //Field offset: 0x358
	public Toggle IncludeSkill; //Field offset: 0x360
	[Header("Sub Type Filter")]
	public GameObject SubTypeTab; //Field offset: 0x368
	public GameObject MonsterOnly; //Field offset: 0x370
	public Toggle NormalMonster; //Field offset: 0x378
	public Toggle EffectMonster; //Field offset: 0x380
	public Toggle RitualMonster; //Field offset: 0x388
	public Toggle FusionMonster; //Field offset: 0x390
	public Toggle SynchroMonster; //Field offset: 0x398
	public Toggle XYZMonster; //Field offset: 0x3A0
	public Toggle LinkMonster; //Field offset: 0x3A8
	public Toggle PendulumNormal; //Field offset: 0x3B0
	public Toggle PendulumEffect; //Field offset: 0x3B8
	public Toggle PendulumFusion; //Field offset: 0x3C0
	public Toggle PendulumSynchro; //Field offset: 0x3C8
	public Toggle PendulumXYZ; //Field offset: 0x3D0
	public Toggle PendulumRitual; //Field offset: 0x3D8
	public GameObject SpellOnly; //Field offset: 0x3E0
	public Toggle NormalSpell; //Field offset: 0x3E8
	public Toggle ContinuousSpell; //Field offset: 0x3F0
	public Toggle EquipSpell; //Field offset: 0x3F8
	public Toggle FieldSpell; //Field offset: 0x400
	public Toggle QuickplaySpell; //Field offset: 0x408
	public Toggle RitualSpell; //Field offset: 0x410
	public Toggle ActionSpell; //Field offset: 0x418
	public Toggle SpeedSpell; //Field offset: 0x420
	public Toggle CommandSpell; //Field offset: 0x428
	public GameObject TrapOnly; //Field offset: 0x430
	public Toggle NormalTrap; //Field offset: 0x438
	public Toggle ContinuousTrap; //Field offset: 0x440
	public Toggle CounterTrap; //Field offset: 0x448
	public Toggle TrapMonster; //Field offset: 0x450
	public Toggle TokenCard; //Field offset: 0x458
	public Toggle DarkCard; //Field offset: 0x460
	[Header("Monster Type Filter")]
	public GameObject MonsterTypeTab; //Field offset: 0x468
	public Toggle Aqua; //Field offset: 0x470
	public Toggle Beast; //Field offset: 0x478
	public Toggle BeastWarrior; //Field offset: 0x480
	public Toggle CreatorGod; //Field offset: 0x488
	public Toggle Cyberse; //Field offset: 0x490
	public Toggle Dinosaur; //Field offset: 0x498
	public Toggle DivineBeast; //Field offset: 0x4A0
	public Toggle Dragon; //Field offset: 0x4A8
	public Toggle Fairy; //Field offset: 0x4B0
	public Toggle Fiend; //Field offset: 0x4B8
	public Toggle Fish; //Field offset: 0x4C0
	public Toggle Insect; //Field offset: 0x4C8
	public Toggle Machine; //Field offset: 0x4D0
	public Toggle Plant; //Field offset: 0x4D8
	public Toggle Psychic; //Field offset: 0x4E0
	public Toggle Pyro; //Field offset: 0x4E8
	public Toggle Reptile; //Field offset: 0x4F0
	public Toggle Rock; //Field offset: 0x4F8
	public Toggle SeaSerpent; //Field offset: 0x500
	public Toggle Spellcaster; //Field offset: 0x508
	public Toggle Thunder; //Field offset: 0x510
	public Toggle Warrior; //Field offset: 0x518
	public Toggle WingedBeast; //Field offset: 0x520
	public Toggle Wyrm; //Field offset: 0x528
	public Toggle Zombie; //Field offset: 0x530
	public Toggle Cyborg; //Field offset: 0x538
	public Toggle MagicalKnight; //Field offset: 0x540
	public Toggle HighDragon; //Field offset: 0x548
	public Toggle OmegaPsycho; //Field offset: 0x550
	public Toggle CelestialKnight; //Field offset: 0x558
	public Toggle Galaxy; //Field offset: 0x560
	public Toggle Illusion; //Field offset: 0x568
	[Header("Monster Sub Type Filter")]
	public GameObject MonsterSubTypeTab; //Field offset: 0x570
	public Toggle Flip; //Field offset: 0x578
	public Toggle Gemini; //Field offset: 0x580
	public Toggle Spirit; //Field offset: 0x588
	public Toggle Toon; //Field offset: 0x590
	public Toggle Tuner; //Field offset: 0x598
	public Toggle Union; //Field offset: 0x5A0
	[Header("Genre Filter")]
	public Toggle GDestroyST; //Field offset: 0x5A8
	public Toggle GDstroyMonster; //Field offset: 0x5B0
	public Toggle GBanish; //Field offset: 0x5B8
	public Toggle GSendToGraveyard; //Field offset: 0x5C0
	public Toggle GReturnToHand; //Field offset: 0x5C8
	public Toggle GReturnToDeck; //Field offset: 0x5D0
	public Toggle GDestroyHand; //Field offset: 0x5D8
	public Toggle GDestroyDeck; //Field offset: 0x5E0
	public Toggle GHelpDraw; //Field offset: 0x5E8
	public Toggle GHandTrap; //Field offset: 0x5F0
	public Toggle GSearchDeck; //Field offset: 0x5F8
	public Toggle GRecoverFromGY; //Field offset: 0x600
	public Toggle GChangePosition; //Field offset: 0x608
	public Toggle GChangeControl; //Field offset: 0x610
	public Toggle GChangeATKDEF; //Field offset: 0x618
	public Toggle GPiercing; //Field offset: 0x620
	public Toggle GAttackMultiple; //Field offset: 0x628
	public Toggle GLimitAttack; //Field offset: 0x630
	public Toggle GDirectAttack; //Field offset: 0x638
	public Toggle GSpecialSummon; //Field offset: 0x640
	public Toggle GToken; //Field offset: 0x648
	public Toggle GTypeRelated; //Field offset: 0x650
	public Toggle GAttributeRelated; //Field offset: 0x658
	public Toggle GDamageLP; //Field offset: 0x660
	public Toggle GGainLP; //Field offset: 0x668
	public Toggle GCannotBeDestroyed; //Field offset: 0x670
	public Toggle GCannotSummon; //Field offset: 0x678
	public Toggle GCounter; //Field offset: 0x680
	public Toggle GGamble; //Field offset: 0x688
	public Toggle GFusionRelated; //Field offset: 0x690
	public Toggle GSynchroRelated; //Field offset: 0x698
	public Toggle GXyzRelated; //Field offset: 0x6A0
	public Toggle GNegateEffect; //Field offset: 0x6A8
	public Toggle GRitualRelated; //Field offset: 0x6B0
	public Toggle GPendulumRelated; //Field offset: 0x6B8
	public Toggle GLinkRelated; //Field offset: 0x6C0
	[Header("Attribute Filter")]
	public GameObject AttributeTab; //Field offset: 0x6C8
	public Toggle Dark; //Field offset: 0x6D0
	public Toggle Divine; //Field offset: 0x6D8
	public Toggle Earth; //Field offset: 0x6E0
	public Toggle Fire; //Field offset: 0x6E8
	public Toggle Light; //Field offset: 0x6F0
	public Toggle Water; //Field offset: 0x6F8
	public Toggle Wind; //Field offset: 0x700
	[Header("Attack Filter")]
	public GameObject AttackTab; //Field offset: 0x708
	public TMP_InputField AtkMin; //Field offset: 0x710
	public TMP_InputField AtkMax; //Field offset: 0x718
	public Toggle AtkEqualize; //Field offset: 0x720
	[Header("Defense Filter")]
	public GameObject DefenseTab; //Field offset: 0x728
	public TMP_InputField DefMin; //Field offset: 0x730
	public TMP_InputField DefMax; //Field offset: 0x738
	public Toggle DefEqualize; //Field offset: 0x740
	[Header("Level/Rank Filter")]
	public GameObject LRTab; //Field offset: 0x748
	public TMP_Dropdown LRMin; //Field offset: 0x750
	public TMP_Dropdown LRMax; //Field offset: 0x758
	public Toggle LREqualize; //Field offset: 0x760
	[Header("Pendulum Scale Filter")]
	public GameObject ScaleTab; //Field offset: 0x768
	public TMP_Dropdown ScaleMin; //Field offset: 0x770
	public TMP_Dropdown ScaleMax; //Field offset: 0x778
	public Toggle ScaleEqualize; //Field offset: 0x780
	[Header("Link Filter")]
	public GameObject LinkTab; //Field offset: 0x788
	public TMP_Dropdown LinkMin; //Field offset: 0x790
	public TMP_Dropdown LinkMax; //Field offset: 0x798
	public Toggle Bottom; //Field offset: 0x7A0
	public Toggle BottomLeft; //Field offset: 0x7A8
	public Toggle BottomRight; //Field offset: 0x7B0
	public Toggle Left; //Field offset: 0x7B8
	public Toggle Right; //Field offset: 0x7C0
	public Toggle Top; //Field offset: 0x7C8
	public Toggle TopLeft; //Field offset: 0x7D0
	public Toggle TopRight; //Field offset: 0x7D8
	public Toggle LinkEqualize; //Field offset: 0x7E0
	[Header("Limitation Filter")]
	public GameObject LimitationTab; //Field offset: 0x7E8
	public Toggle Banned; //Field offset: 0x7F0
	public Toggle Limited; //Field offset: 0x7F8
	public Toggle SemiLimited; //Field offset: 0x800
	public Toggle Unlimited; //Field offset: 0x808
	public Toggle Limited1; //Field offset: 0x810
	public Toggle Limited2; //Field offset: 0x818
	public Toggle Limited3; //Field offset: 0x820
	public Toggle Beta; //Field offset: 0x828
	public Toggle Illegal; //Field offset: 0x830
	public Toggle RushLegend; //Field offset: 0x838
	public TMP_InputField GenesysMin; //Field offset: 0x840
	public TMP_InputField GenesysMax; //Field offset: 0x848
	public Toggle GenesysEqualize; //Field offset: 0x850
	[Header("Pool Filters")]
	public GameObject PoolTab; //Field offset: 0x858
	public Toggle IncludeOCG; //Field offset: 0x860
	public Toggle IncludeTCG; //Field offset: 0x868
	public Toggle IncludeWCS; //Field offset: 0x870
	public Toggle DuelLinks; //Field offset: 0x878
	public Toggle IncludeRush; //Field offset: 0x880
	public Toggle IncludeNewUpdated; //Field offset: 0x888
	public Toggle IncludeCollected; //Field offset: 0x890
	public Toggle Favorites; //Field offset: 0x898
	public Toggle Custom; //Field offset: 0x8A0
	public Toggle IncludeCommon; //Field offset: 0x8A8
	public Toggle PreErrata; //Field offset: 0x8B0
	public Toggle Scriptless; //Field offset: 0x8B8
	public Toggle DoubleScript; //Field offset: 0x8C0
	public Toggle HideAltArts; //Field offset: 0x8C8
	[Header("Script")]
	private Card[] DisplayedCards; //Field offset: 0x8D0
	private int DisplayedCardsCount; //Field offset: 0x8D8
	public SortTypes CurrentSortType; //Field offset: 0x8DC
	private Action<Deck> OnFinish; //Field offset: 0x8E0
	private string OriginalDeckName; //Field offset: 0x8E8
	private ushort CurrentPage; //Field offset: 0x8F0
	private float LastRepositioning; //Field offset: 0x8F4
	private RealtimeSearch RTSearchModule; //Field offset: 0x8F8
	private sbyte RepositionQueued; //Field offset: 0x900
	public bool IsReducedUI; //Field offset: 0x901
	public byte MainSize; //Field offset: 0x902
	public byte ExtraSize; //Field offset: 0x903
	public byte SideSize; //Field offset: 0x904
	private bool IsFirstEnable; //Field offset: 0x905
	private readonly SemaphoreSlim RefreshSemaphore; //Field offset: 0x908
	private DateTime LastRequest; //Field offset: 0x910
	private bool _isDefiningDeckCard; //Field offset: 0x918
	private bool _isDefiningRarity; //Field offset: 0x919
	public Rarity RarityDefine; //Field offset: 0x91C

	private int CurrentDeckPages
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "EnsureCorrectDeckPaging", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnNextDeckPage", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnDeckCardAmountChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[CallsUnknownMethods(Count = 5)]
		private get { } //Length: 537
	}

	public static bool IsActive
	{
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c", Member = "<Create>b__83_0", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DraggableFrame), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DisplayCard), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "SaveDeckOnDeckEdit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapZoomCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DiscordController), Member = "get_CanInviteJoin", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(<RefreshDisplayedCards>d__362), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "get_AllowCard", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hotkey), Member = "FavoriteCardOnDeckEdit", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 174
	}

	public bool IsDefiningDeckCard
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 48
	}

	public bool IsDefiningRarity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 296
	}

	public static bool IsSiding
	{
		[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameRoom), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 246
	}

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = typeof(<>c), Member = "<ShowEditor>b__304_1", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "IsPreloaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c", Member = "<GoToSiding>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Card.Deck>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(<CreateEditor>d__305), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<Create>d__307), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>g__finish|1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "get_IsSiding", ReturnType = typeof(bool))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	public static Deck SidingDeck
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<Start>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 248
	}

	private int TrunkPageCount
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "GetNextDisplayedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnTrunkDownArrow", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "Scrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 130
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DeckEdit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public DeckEdit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_0(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_1(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_10(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_11(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_12(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_13(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_14(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_15(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_16(string i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Awake>b__327_17(string i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_18(string i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Awake>b__327_19(string i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_2(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_20(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Awake>b__327_21(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_22(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Awake>b__327_23(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_24(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Awake>b__327_25(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_26(string i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Awake>b__327_27(string i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_28(bool i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_29(bool i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_3(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_30(bool i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_31(bool i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_32(bool i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <Awake>b__327_33(bool i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_4(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_5(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_6(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_7(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_8(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Awake>b__327_9(PointerEventData data) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "InsertCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static void <InsertCard>g__DoCardChange|414_0(int cp, ref <>c__DisplayClass414_0 unnamed_param_1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "ClearDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EmptyDeckAnimation>d__389)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EmptyDeckAnimation>d__389&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private void <OnEmptyButton>b__388_0(bool r) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "InsertCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnRightTap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "OnDeckCardAmountChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "CanAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Deck), Member = "IsFull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(ClientCard), Member = "IsExtraCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	public bool AddCardToDeck(DeckType type, Template card) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "ParseTextSearch", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void AddFilter(Func<Card, Boolean> filter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "SortOrderDisplayUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckFilters), Member = "GetCurrentSortMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortTypes)}, ReturnType = typeof(System.Func`2<System.Collections.Generic.IEnumerable`1<Card.Card>, System.Collections.Generic.IEnumerable`1<Card.Card>>))]
	[Calls(Type = typeof(DeckEdit), Member = "SetupCards", ReturnType = typeof(void))]
	[Calls(Type = typeof(RealtimeSearch), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Action), typeof(TMP_InputField)}, ReturnType = typeof(RealtimeSearch))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Template), Member = "DefinePermanent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 60)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void CalculateMainDeckOverlap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckGenreSubType() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckRace() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckSubType() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetButton", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearFilter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "ClearRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ClearRarity(Rarity rar) { }

	[AsyncStateMachine(typeof(<ConnectToTest>d__339))]
	[CalledBy(Type = typeof(<OnTestRoom>d__340), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectToTest>d__339)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ConnectToTest>d__339&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Task ConnectToTest(bool noShuffle, byte startHand) { }

	[AsyncStateMachine(typeof(<Create>d__307))]
	[CalledBy(Type = "Manager.Helper+<Preload>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__307)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__307&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Create(Action<Deck> onFinish = null, string deck = null, bool reducedUi = false) { }

	[AsyncStateMachine(typeof(<CreateEditor>d__305))]
	[CalledBy(Type = typeof(<ShowEditor>d__304), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelEnd), Member = "GoToSiding", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateEditor>d__305)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateEditor>d__305&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void CreateEditor(Action<Deck> onFinish = null, string deck = null, bool reducedUi = false) { }

	[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>g__finish|1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_DeckCard", ReturnType = typeof(int))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "DefineDeckCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(DeckEdit), Member = "set_IsDefiningRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void DefineDeckCardButton(int cardId = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	private void DefineDeckPage(int page) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeckEdit), Member = "set_IsDefiningRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rarity), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool DefineRarity(int cardId = -1) { }

	[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>g__finish|1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "RarityCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(DeckEdit), Member = "set_IsDefiningRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DefineRarity(Rarity rarity) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 61)]
	private void DefineTooltips() { }

	[AsyncStateMachine(typeof(<EmptyDeckAnimation>d__389))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EmptyDeckAnimation>d__389)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EmptyDeckAnimation>d__389&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EmptyDeckAnimation() { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Network), Member = "get_ConnectionIsReady", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void EnableButtonsForUI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_CurrentDeckPages", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private bool EnsureCorrectDeckPaging() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FillRarity(Rarity rar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "get_CanSwap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "EnsureCorrectDeckPaging", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnNextDeckPage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnDeckCardAmountChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[CallsUnknownMethods(Count = 5)]
	private int get_CurrentDeckPages() { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<>c", Member = "<Create>b__83_0", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "FavoriteCardOnDeckEdit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "get_AllowCard", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<RefreshDisplayedCards>d__362), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "get_CanInviteJoin", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapZoomCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapEnterInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "SaveDeckOnDeckEdit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsActive() { }

	[CallerCount(Count = 0)]
	public bool get_IsDefiningDeckCard() { }

	[CallerCount(Count = 0)]
	public bool get_IsDefiningRarity() { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<Awake>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsSiding() { }

	[CalledBy(Type = typeof(<>c), Member = "<ShowEditor>b__304_1", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "get_IsSiding", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>g__finish|1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Create>d__307), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateEditor>d__305), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<>c", Member = "<GoToSiding>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "IsPreloaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Card.Deck>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	public static Deck get_SidingDeck() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "GetNextDisplayedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnTrunkDownArrow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Scrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private int get_TrunkPageCount() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "GetPrevDisplayedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DeckEdit), Member = "GetNextDisplayedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DisplayCard), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int GetCurDisplayedCardIndex(int cardId) { }

	[CallerCount(Count = 0)]
	private Template[] GetDeckTemplates(DeckType dt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public int GetFirstDisplayCard() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "SwapCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType), typeof(DeckType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	private int GetIndexInDeckView(Template c, DeckType dt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public int GetLastDisplayCard() { }

	[CalledBy(Type = typeof(DisplayCard), Member = "OnNextBtn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeckEdit), Member = "GetCurDisplayedCardIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_TrunkPageCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "OnTrunkDownArrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNextDisplayedCard(int currentId) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	private static Vector2[] GetPositions(Template[] cards) { }

	[CalledBy(Type = typeof(DisplayCard), Member = "OnPrevBtn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeckEdit), Member = "GetCurDisplayedCardIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public int GetPrevDisplayedCard(int currentId) { }

	[AsyncStateMachine(typeof(<GetTestInfo>d__338))]
	[CalledBy(Type = typeof(<OnTestRoom>d__340), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTestInfo>d__338)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTestInfo>d__338&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Task<ValueTuple`3<Boolean, Boolean, Byte>> GetTestInfo() { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void HideCalendars() { }

	[CalledBy(Type = typeof(<CreateEditor>d__305), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void Init(Action<Deck> onFinish, string deck, bool reducedUi) { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnEmptyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeCurrentDeck(bool ignoreSiding = false) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnHoldTap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "GetDeckByType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(DeckEdit), Member = "<InsertCard>g__DoCardChange|414_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass414_0&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool InsertCard(Template c1, Template c2, DeckType dt) { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckEdit), Member = "TryLoadFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[CallsUnknownMethods(Count = 1)]
	private void LoadFilters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FilterCheck), Member = "ChangeState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void LoadToggle(Toggle tg) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void MoveRepositionedCards(Vector2[] originalPositions, Template[] updated) { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "ParseTextSearch", ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_IsUnlimited", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_IsTCG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "CheckRace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "CheckSubType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "AddFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "ClearFilter", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 9)]
	public void OnApplyButton() { }

	[AsyncStateMachine(typeof(<OnAutoDeck>d__370))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAutoDeck>d__370)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAutoDeck>d__370&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnAutoDeck() { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BanlistManager), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(BanlistManager), Member = "set_CurrentBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshGenesysCounter", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnChangeBanlist(int val = -1) { }

	[CalledBy(Type = typeof(Hotkey), Member = "TapEscape", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(<>c__DisplayClass368_0), Member = "<OnCloseButton>g__finish|1", ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void OnCloseButton() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeckEdit), Member = "get_CurrentDeckPages", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	private void OnDeckCardAmountChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "SaveFilters", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "set_IsDefiningRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnEmptyButton() { }

	[AsyncStateMachine(typeof(<OnEnable>d__310))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnEnable>d__310)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnEnable>d__310&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable() { }

	[CalledBy(Type = typeof(<RefreshDisplayedCards>d__362), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	private void OnEndRefresh(object displayCards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnEqualizedValueChanged(int type, bool max) { }

	[AsyncStateMachine(typeof(<OnFavoriteChanged>d__359))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFavoriteChanged>d__359)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFavoriteChanged>d__359&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnFavoriteChanged(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void OnFilterButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnFilterCategoryChanged(int index, bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckTrunk), Member = "HasMarks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(GameSettings)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnFinishSiding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_CurrentDeckPages", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	private void OnNextDeckPage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	private void OnPrevDeckPage() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<Awake>b__327_15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(General), Member = "IsRightTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "IsMiddleTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "RarityCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(DeckEdit), Member = "set_IsDefiningRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsHoldingCtrl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "ClearRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnRarity(PointerEventData data, Rarity rar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "ResetFilters", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "ClearFilter", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	public void OnResetButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
	private void OnResetSiding() { }

	[AsyncStateMachine(typeof(<OnSaveButton>d__372))]
	[CalledBy(Type = typeof(Hotkey), Member = "SaveDeckOnDeckEdit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSaveButton>d__372)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSaveButton>d__372&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnSaveButton() { }

	[AsyncStateMachine(typeof(<OnSaveNewButton>d__371))]
	[CalledBy(Type = typeof(<OnSaveButton>d__372), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSaveNewButton>d__371)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSaveNewButton>d__371&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnSaveNewButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_TrunkPageCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnScroll(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsMenu), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void OnSettingsButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "Shuffle", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnShuffleButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "Sort", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnSortButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "SortOrderDisplayUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	public void OnSortOrderChange(bool val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckFilters), Member = "GetCurrentSortMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortTypes)}, ReturnType = typeof(System.Func`2<System.Collections.Generic.IEnumerable`1<Card.Card>, System.Collections.Generic.IEnumerable`1<Card.Card>>))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Localization), Member = "GetSortName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortTypes)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnSortTypeButton() { }

	[AsyncStateMachine(typeof(<OnTestRoom>d__340))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTestRoom>d__340)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTestRoom>d__340&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void OnTestRoom() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "GetNextDisplayedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeckEdit), Member = "get_TrunkPageCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	public void OnTrunkDownArrow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	public void OnTrunkUpArrow() { }

	[CalledBy(Type = typeof(<>c__DisplayClass393_0), Member = "<RepositionCards>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<>c__DisplayClass393_0), Member = "<RepositionCards>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<>c__DisplayClass393_0), Member = "<RepositionCards>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static int OrganizeCards(Template c, List<Int32> deck, Dictionary<Int32, Byte> lastIndex) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "TextSearch", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeckEdit), Member = "RemoveFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(General), Member = "WildCardToRegular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "AddFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void ParseTextSearch() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateAllDisplays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnEmptyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "SwapCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType), typeof(DeckType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<OnEmptyButton>b__388_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Deck), Member = "get_SideDeckPrice", ReturnType = typeof(float))]
	[Calls(Type = typeof(Deck), Member = "get_ExtraDeckPrice", ReturnType = typeof(float))]
	[Calls(Type = typeof(Deck), Member = "get_MainDeckPrice", ReturnType = typeof(float))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshGenesysCounter", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_DeckPrice", ReturnType = typeof(float))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateDeckPageLabel", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void RefreshCardCounters() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateAllDisplays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnPrevDeckPage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnNextDeckPage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnDeckCardAmountChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnEmptyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DeckEdit), Member = "get_CurrentDeckPages", ReturnType = typeof(int))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDeckCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template[]), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void RefreshCurrentDeck() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshDeckCards(Template[] deck, List<Int32> deckList) { }

	[AsyncStateMachine(typeof(<RefreshDisplayedCards>d__362))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortOrderChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateAllDisplays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "TextSearch", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnEmptyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortTypeButton", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshDisplayedCards>d__362)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshDisplayedCards>d__362&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshDisplayedCards() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnChangeBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Banlist), Member = "GetSpentGenesysPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void RefreshGenesysCounter() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "GetPrevDisplayedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnEndRefresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnTrunkUpArrow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnTrunkDownArrow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Scrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DeckEdit), Member = "get_TrunkPageCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateFavorite", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void RefreshTrunkDisplay() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnRightTap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "RemoveMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "RemoveSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "OnDeckCardAmountChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public void RemoveCardFromDeck(DeckType type, Template card) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "ParseTextSearch", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveFilter(Func<Card, Boolean> filter) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnShuffleButton", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "GetPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template[])}, ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DeckEdit), Member = "MoveRepositionedCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]), typeof(Template[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void RepositionCards(sbyte deck = 3) { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetButton", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckEdit), Member = "TryResetFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
	[Calls(Type = typeof(SerializableDate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SerializableDate))]
	[Calls(Type = typeof(DatePicker), Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializableDate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ResetFilters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FilterCheck), Member = "ChangeState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ResetToggle(Toggle target, bool state = false) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckEdit), Member = "TrySaveFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[CallsUnknownMethods(Count = 1)]
	private void SaveFilters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SaveToggle(Toggle tg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "get_TrunkPageCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	private void Scrolling(float val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_IsDefiningDeckCard(bool value) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_IsDefiningRarity(bool value) { }

	[CalledBy(Type = "Scenes.Battle.DuelEnd+<Start>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnDuelEnd>d__61", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_SidingDeck(Deck value) { }

	[CalledBy(Type = typeof(<OnSaveNewButton>d__371), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetDeckName(string deck) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetRarityBoxState() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "ClearRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "EnableButtonsForUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BoxSlot), Member = "SetRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "RarityCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetRarityCounters() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Template), Member = "DefinePermanent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 18)]
	private void SetupCards() { }

	[AsyncStateMachine(typeof(<ShowEditor>d__304))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ShowEditor>d__304)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ShowEditor>d__304&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowEditor() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortOrderChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SortOrderDisplayUpdate() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClientCard), Member = "IsExtraCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "GetDeckByType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(DeckEdit), Member = "GetIndexInDeckView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(DeckType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SwapCards(Template c1, Template c2, DeckType c1d, DeckType c2d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "ParseTextSearch", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void TextSearch() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "LoadFilters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilterCheck), Member = "ChangeState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void TryLoadFilter(Transform filter) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "ResetFilters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilterCheck), Member = "ChangeState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void TryResetFilter(Transform filter) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "SaveFilters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void TrySaveFilter(Transform filter) { }

	[CalledBy(Type = typeof(<OnAutoDeck>d__370), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshDisplayedCards", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	private void UpdateAllDisplays() { }

	[CalledBy(Type = typeof(<ShowEditor>d__304), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey+<PasteDeckFromClipboard>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCurrentDeck", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	public void UpdateCurrentDeck(Deck deck) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnPrevDeckPage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnNextDeckPage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DeckEdit), Member = "get_CurrentDeckPages", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateDeckPageLabel() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "RefreshDisplayPic", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard+<OnFavoriteChanged>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Manager), Member = "IsCardFavorite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "SetIsOnWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateFavorite() { }

	[CalledBy(Type = typeof(<OnEnable>d__310), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetSortName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortTypes)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DeckEdit), Member = "DefineTooltips", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 109)]
	[CallsUnknownMethods(Count = 46)]
	public void UpdateLanguage() { }

}

