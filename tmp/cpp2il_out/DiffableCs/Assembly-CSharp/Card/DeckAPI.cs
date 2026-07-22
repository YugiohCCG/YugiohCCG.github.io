namespace Card;

public class DeckAPI
{
	[CompilerGenerated]
	private struct <RequestAPIDeck>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Deck> <>t__builder; //Field offset: 0x8
		public bool isSealed; //Field offset: 0x20
		private Deck <deck>5__2; //Field offset: 0x28
		private TaskAwaiter<ProDeck> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "DoGetRequest", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestAutoDeck>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Deck> <>t__builder; //Field offset: 0x8
		public Deck currentDeck; //Field offset: 0x20
		private Deck <deck>5__2; //Field offset: 0x28
		private TaskAwaiter<AutoDeck> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(AutoDeck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "DoPostRequest", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestURLDecks>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Deck[]> <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		private URLDecks <api>5__2; //Field offset: 0x28
		private Deck[] <decks>5__3; //Field offset: 0x30
		private TaskAwaiter<URLDecks> <>u__1; //Field offset: 0x38
		private int <i>5__4; //Field offset: 0x40
		private URLDeck <res>5__5; //Field offset: 0x48
		private TaskAwaiter<Deck> <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "DoGetRequest", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Deck+<Create>d__61"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__61&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Deck), Member = "set_Tags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 32)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class AutoDeck
	{
		public Int32[] main; //Field offset: 0x10
		public Int32[] extra; //Field offset: 0x18
		public Int32[] side; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AutoDeck() { }

		[CalledBy(Type = "Card.DeckAPI+<RequestAutoDeck>d__13", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public AutoDeck(Deck currentDeck) { }

	}

	internal class ProDeck
	{
		public String[] packs; //Field offset: 0x10
		public Int32[] ID; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ProDeck() { }

	}

	internal class URLDeck
	{
		public string Code; //Field offset: 0x10
		public string Name; //Field offset: 0x18
		public string Tag; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public URLDeck() { }

	}

	internal class URLDecks
	{
		public URLDeck[] decks; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public URLDecks() { }

	}

	private const string BASE_API = "https://tournament.duelistsunite.org"; //Field offset: 0x0
	private const string SealedAPIURL = "https://db.ygoprodeck.com/api/omega/pack-open.php?num=10&pack=battle"; //Field offset: 0x0
	private const string BoosterAPIURL = "https://db.ygoprodeck.com/api/omega/pack-open.php?num=10"; //Field offset: 0x0
	private const string AutoDeckAPIURL = "https://tournament.duelistsunite.org/api/autodeck"; //Field offset: 0x0
	public const string TournamentURL = "https://tournament.duelistsunite.org/#/#/tournament/live"; //Field offset: 0x0
	public const string ProfileURL = "https://tournament.duelistsunite.org/#/profile"; //Field offset: 0x0
	public const string LeaderboardURL = "https://tournament.duelistsunite.org/#/#/leaderboards"; //Field offset: 0x0
	public const string HomeURL = "https://tournament.duelistsunite.org/#"; //Field offset: 0x0

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DeckAPI() { }

	[AsyncStateMachine(typeof(<RequestAPIDeck>d__12))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestAPIDeck>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestAPIDeck>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<Deck> RequestAPIDeck(bool isSealed) { }

	[AsyncStateMachine(typeof(<RequestAutoDeck>d__13))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnAutoDeck>d__370", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestAutoDeck>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestAutoDeck>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Deck> RequestAutoDeck(Deck currentDeck) { }

	[AsyncStateMachine(typeof(<RequestURLDecks>d__14))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportDecksFromURL>d__53", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestURLDecks>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RequestURLDecks>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Deck[]> RequestURLDecks(string url) { }

}

