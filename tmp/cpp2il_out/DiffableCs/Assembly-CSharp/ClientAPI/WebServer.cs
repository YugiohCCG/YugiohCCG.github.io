namespace ClientAPI;

public class WebServer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Int32> <>9__32_0; //Field offset: 0x8
		public static Func<String, Int32> <>9__52_0; //Field offset: 0x10
		public static Func<String, Int32> <>9__53_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal int <OnCardInfo>b__52_0(string id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal int <OnCardList>b__53_0(string id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		internal int <OnSetFavoriteCard>b__32_0(string x) { }

	}

	[CompilerGenerated]
	private struct <ListenRequests>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public WebServer <>4__this; //Field offset: 0x28
		private HttpListenerContext <ctx>5__2; //Field offset: 0x30
		private TaskAwaiter<HttpListenerContext> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListener), Member = "GetContextAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.HttpListenerContext>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(WebServer), Member = "ParseRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAddDeck>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public String[] args; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28
		private string <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<Deck> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebServer), Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Deck), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.Deck>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Manager), Member = "AddDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Deck)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnBotFieldCardInfo>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebServer), Member = "GetBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(GameBehavior&), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(BotClientCard))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnBotFieldInfo>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebServer), Member = "GetBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(GameBehavior&), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+FieldInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(BotClientField)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnBotList>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		private TaskAwaiter<BotList> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+BotList+<Create>d__2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__2&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<ClientAPI.WebServer+BotList>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCardInfo>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public String[] args; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DBCardList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Int32[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCardList>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public String[] args; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DBCardList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 17)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChatMessage>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ChatWindow), Member = "get_AllowChat", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebServer), Member = "Get64Msg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ChatWindow), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCurrentDeck>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		private TaskAwaiter<DeckData> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+DeckData", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(System.Threading.Tasks.Task`1<ClientAPI.WebServer+DeckData>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCustomPath>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDeckList>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+DeckList", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedDictionary`2<System.String, Card.Deck>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDeleteDeck>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public String[] args; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "DeleteDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(DeckSelection), Member = "get_IsActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeckSelection), Member = "RefreshDeckList", ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDiscordAuth>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public String[] args; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(DiscordController), Member = "ParseDiscordImplicitGrantURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(Int64&), typeof(String[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DiscordController), Member = "RequestAuthenticationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeepLink), Member = "MakeJSRedirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebServer), Member = "ResponseScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DiscordController), Member = "RequestAuthenticationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFavoriteList>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+FavoriteList", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFieldCardInfo>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFieldInfo>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+FieldInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField), typeof(ClientField)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFieldPosition>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+FieldPositionData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelZone)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFocus>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(OmegaWindowsPlugin), Member = "FocusApp", ReturnType = typeof(void))]
		[Calls(Type = typeof(DeepLink), Member = "MakeJSRedirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebServer), Member = "ResponseScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DeepLink), Member = "MakeDeepLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGetBotState>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebServer), Member = "GetCustomBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(GameBehavior&), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGetBotStateHeader>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebServer), Member = "GetCustomBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(GameBehavior&), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGetDuelLog>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ChatWindow), Member = "get_DuelLogString", ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnHelp>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnJoinRoom>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "get_ConnectionIsReady", ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRematchDuel>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelEnd), Member = "OnRematch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRoomInfo>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRoomList>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "get_ConnectionIsReady", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+RoomList", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Data.RoomData>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSetBotResponse>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebServer), Member = "GetCustomBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(GameBehavior&), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebServer), Member = "GetBotResponseData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[Calls(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSetCustomBotData>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28
		private GameBehavior <bot>5__2; //Field offset: 0x30
		private TaskAwaiter<Deck> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebServer), Member = "GetCustomBotFromArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(GameBehavior&), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebServer), Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Deck), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.Deck>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(GameBehavior), Member = "set_Deck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EZThread), Member = "ExecuteOnMainThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSetFavoriteCard>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20
		public String[] args; //Field offset: 0x28
		private bool <on>5__2; //Field offset: 0x30
		private Int32[] <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Manager), Member = "AddFavoriteCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Manager), Member = "RemoveFavoriteCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Manager), Member = "IsCardFavorite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 24)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSpectatorMode>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public String[] args; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "set_IsSpectatorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnUserInfo>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerResponse response; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "ClientAPI.WebServer+UserData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseRequest>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HttpListenerContext ctx; //Field offset: 0x20
		private Encoding <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_ContentEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "SendResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerRequest), typeof(HttpListenerResponse)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(HttpListenerResponse), Member = "AddHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "set_ContentLength64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "get_OutputStream", ReturnType = typeof(Stream))]
		[Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 24)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendResponse>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public HttpListenerRequest request; //Field offset: 0x20
		public HttpListenerResponse response; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Enumerable), Member = "Skip", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "OnHelp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerRequest), typeof(HttpListenerResponse), typeof(String[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct ActivationCardIndex : ISerializable
	{
		public int ActionDescription; //Field offset: 0x0
		public int ActionIndex; //Field offset: 0x4

		[CallerCount(Count = 0)]
		public ActivationCardIndex(KeyValuePair<Int32, Int32> data) { }

		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		public ActivationCardIndex(int description, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct AnnounceAttributeState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public AnnounceAttributeData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public AnnounceAttributeState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct AnnounceCardFilterState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public AnnounceCardFilterData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public AnnounceCardFilterState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct AnnounceCardState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public AnnounceCardData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public AnnounceCardState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct AnnounceNumberState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public AnnounceNumberData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public AnnounceNumberState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct AnnounceRaceState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public AnnounceRaceData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public AnnounceRaceState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct BattleCmdState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public BattleCmdStateData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public BattleCmdState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct BotGeneralState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public BotGeneralStateData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 2)]
		public BotGeneralState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct BotInfo : ISerializable
	{
		[CompilerGenerated]
		private struct <Create>d__4 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<BotInfo> <>t__builder; //Field offset: 0x8
			public GameBehavior bot; //Field offset: 0x20
			private BotInfo <bi>5__2; //Field offset: 0x28
			private TaskAwaiter<String> <>u__1; //Field offset: 0x48

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(GameBehavior), Member = "get_Deck", ReturnType = typeof(Deck))]
			[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
			[Calls(Type = typeof(Deck), Member = "GetHash", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
			[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+BotInfo"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<Create>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<Create>d__4&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 13)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public byte BotID; //Field offset: 0x0
		public string DeckName; //Field offset: 0x8
		public short DeckIndex; //Field offset: 0x10
		public string DeckHash; //Field offset: 0x18

		[AsyncStateMachine(typeof(<Create>d__4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+BotInfo+<Create>d__4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<ClientAPI.WebServer+BotInfo>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static Task<BotInfo> Create(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct BotList
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<GameBehavior, Boolean> <>9__2_0; //Field offset: 0x8

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
			[DeduplicatedMethod]
			internal bool <Create>b__2_0(GameBehavior b) { }

		}

		[CompilerGenerated]
		private struct <Create>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<BotList> <>t__builder; //Field offset: 0x8
			public IEnumerable<GameBehavior> bots; //Field offset: 0x20
			private BotList <bl>5__2; //Field offset: 0x28
			private IEnumerable<GameBehavior> <botList>5__3; //Field offset: 0x38
			private byte <b>5__4; //Field offset: 0x40
			private BotInfo[] <>7__wrap4; //Field offset: 0x48
			private int <>7__wrap5; //Field offset: 0x50
			private TaskAwaiter<BotInfo> <>u__1; //Field offset: 0x58

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
			[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
			[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+BotInfo+<Create>d__4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__4&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotInfo>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<ClientAPI.WebServer+BotInfo>))]
			[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<ClientAPI.WebServer+BotInfo>), typeof(<Create>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<BotInfo>&), typeof(<Create>d__2&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+BotList"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 18)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public byte BotCount; //Field offset: 0x0
		public BotInfo[] Bots; //Field offset: 0x8

		[AsyncStateMachine(typeof(<Create>d__2))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+BotList+<Create>d__2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__2&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+BotList>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<ClientAPI.WebServer+BotList>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static Task<BotList> Create(IEnumerable<GameBehavior> bots) { }

	}

	internal struct BotStateHeader : ISerializable
	{
		public byte CurrentStateCode; //Field offset: 0x0
		public string CurrentStateName; //Field offset: 0x8
		public int CurrentTurn; //Field offset: 0x10
		public int CurrentPhase; //Field offset: 0x14
		public int LastChainPlayer; //Field offset: 0x18
		public int LastSummonPlayer; //Field offset: 0x1C
		public int CurrentPlayer; //Field offset: 0x20
		public bool IsFirst; //Field offset: 0x24

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public BotStateHeader(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(General), Member = "SetCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(byte), typeof(string)}, ReturnType = typeof(void))]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct CardArray : ISerializable
	{
		public Int32[] Cards; //Field offset: 0x0

		[CalledBy(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public CardArray(IList<Template> cards) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public CardArray(BotClientCard[] cards) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal struct CardCoordinate : ISerializable
	{
		public static CardCoordinate InvalidCoordinate; //Field offset: 0x0
		public byte Controller; //Field offset: 0x0
		public byte Location; //Field offset: 0x1
		public byte Sequence; //Field offset: 0x2

		[CallerCount(Count = 0)]
		private static CardCoordinate() { }

		[CallerCount(Count = 0)]
		public CardCoordinate(BotClientCard c) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public CardCoordinate(byte controller, byte location, byte sequence) { }

		[CallerCount(Count = 0)]
		public CardCoordinate(ClientCard c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

		[CalledBy(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 2)]
		public static CardCoordinate[] InitMultiple(IEnumerable<BotClientCard> cs) { }

		[CalledBy(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 2)]
		public static CardCoordinate[] InitMultiple(IEnumerable<ClientCard> cs) { }

	}

	private struct CardInfo : ISerializable
	{
		public int LifePoints; //Field offset: 0x0
		public int LinkedZones; //Field offset: 0x4
		public bool UnderAttack; //Field offset: 0x8
		public bool HasBattlingMonster; //Field offset: 0x9
		public DynamicCard BattlingMonster; //Field offset: 0x10
		public Int32[] Main; //Field offset: 0xC8
		public Int32[] Extra; //Field offset: 0xD0
		public Int32[] Grave; //Field offset: 0xD8
		public Int32[] Banish; //Field offset: 0xE0
		public Int32[] Hand; //Field offset: 0xE8
		public CardArray[] MonsterZones; //Field offset: 0xF0
		public CardArray[] SpellZones; //Field offset: 0xF8

		[CalledBy(Type = "ClientAPI.WebServer+FieldInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(BotClientField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BotClientField), Member = "GetLinkedZones", ReturnType = typeof(int))]
		[Calls(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 28)]
		[ContainsUnimplementedInstructions]
		public CardInfo(BotClientField fi) { }

		[CalledBy(Type = "ClientAPI.WebServer+FieldInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField), typeof(ClientField)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
		[Calls(Type = typeof(ClientField), Member = "GetLinkedZones", ReturnType = typeof(int))]
		[Calls(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = "ClientAPI.WebServer+CardArray", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Card.Template>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 18)]
		[ContainsUnimplementedInstructions]
		public CardInfo(ClientField fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 5)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static void WriteIndex(ref int id, Template card) { }

		[CallerCount(Count = 0)]
		public static void WriteIndex(ref int id, BotClientCard card) { }

	}

	private struct CustomPath
	{
		public string DirectoryPath; //Field offset: 0x0

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public CustomPath(string dir) { }

	}

	internal struct DBCardInfo : ISerializable
	{
		public int ID; //Field offset: 0x0
		public byte OT; //Field offset: 0x4
		public int Alias; //Field offset: 0x8
		public long SetCode; //Field offset: 0x10
		public int Type; //Field offset: 0x18
		public sbyte Level; //Field offset: 0x1C
		public int LScale; //Field offset: 0x20
		public int RScale; //Field offset: 0x24
		public ushort LinkMarker; //Field offset: 0x28
		public int Category; //Field offset: 0x2C
		public DateTime TCGReleaseDate; //Field offset: 0x30
		public DateTime OCGReleaseDate; //Field offset: 0x38
		public byte Attribute; //Field offset: 0x40
		public int Race; //Field offset: 0x44
		public int Attack; //Field offset: 0x48
		public int Defense; //Field offset: 0x4C
		public string SetID; //Field offset: 0x50
		public long Genre; //Field offset: 0x58
		public long Support; //Field offset: 0x60
		public string Name; //Field offset: 0x68
		public string CardText; //Field offset: 0x70
		public string PendulumText; //Field offset: 0x78
		public int Cover; //Field offset: 0x80
		public int RuleCode; //Field offset: 0x84

		[CalledBy(Type = typeof(DBCardList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DBCardList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
		[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(Card), Member = "get_LinkMarker", ReturnType = typeof(ushort))]
		[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 5)]
		public DBCardInfo(Card c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal struct DBCardList
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public Int32[] filters; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass2_0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
			[Calls(Type = typeof(DuelManager), Member = "IsDeclarable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(Int32[])}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			internal bool <.ctor>b__0(Card c) { }

		}

		public DBCardInfo[] Cards; //Field offset: 0x0

		[CalledBy(Type = "ClientAPI.WebServer+<OnCardInfo>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public DBCardList(bool custom, Int32[] ids) { }

		[CalledBy(Type = "ClientAPI.WebServer+<OnCardList>d__53", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Manager), Member = "GetAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.Card>))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		public DBCardList(Int32[] filters) { }

	}

	private struct DeckData : ISerializable
	{
		[CompilerGenerated]
		private struct <Create>d__5 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<DeckData> <>t__builder; //Field offset: 0x8
			public Deck deck; //Field offset: 0x20
			private DeckData <>7__wrap1; //Field offset: 0x28
			private TaskAwaiter<String> <>u__1; //Field offset: 0x50

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
			[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
			[Calls(Type = typeof(Deck), Member = "GetHash", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
			[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+DeckData>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+DeckData"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+DeckData>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<Create>d__5)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<Create>d__5&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+DeckData>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 17)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public string Name; //Field offset: 0x0
		public string Hash; //Field offset: 0x8
		public Int32[] Main; //Field offset: 0x10
		public Int32[] Extra; //Field offset: 0x18
		public Int32[] Side; //Field offset: 0x20

		[AsyncStateMachine(typeof(<Create>d__5))]
		[CalledBy(Type = "ClientAPI.WebServer+<OnCurrentDeck>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+DeckData>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.WebServer+DeckData+<Create>d__5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__5&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<ClientAPI.WebServer+DeckData>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<ClientAPI.WebServer+DeckData>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static Task<DeckData> Create(Deck deck) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct DeckList
	{
		public Deck[] Decks; //Field offset: 0x0

		[CalledBy(Type = "ClientAPI.WebServer+<OnDeckList>d__34", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Values", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+ValueCollection<TKey, TValue>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[CallsUnknownMethods(Count = 2)]
		public DeckList(SortedDictionary<String, Deck> decks) { }

	}

	internal struct DuelLog
	{
		public string Log; //Field offset: 0x0

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public DuelLog(string log) { }

	}

	internal struct DynamicCard : ISerializable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<KeyValuePair`2<Int32, Int32>, ActivationCardIndex> <>9__42_0; //Field offset: 0x8
			public static Func<KeyValuePair`2<Int32, Int32>, ActivationCardIndex> <>9__43_0; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal ActivationCardIndex <.ctor>b__42_0(KeyValuePair<Int32, Int32> kvp) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal ActivationCardIndex <.ctor>b__43_0(KeyValuePair<Int32, Int32> kvp) { }

		}

		public int ID; //Field offset: 0x0
		public int Alias; //Field offset: 0x4
		public int Type; //Field offset: 0x8
		public sbyte Level; //Field offset: 0xC
		public sbyte Rank; //Field offset: 0xD
		public sbyte LScale; //Field offset: 0xE
		public sbyte RScale; //Field offset: 0xF
		public ushort LinkMarker; //Field offset: 0x10
		public byte Attribute; //Field offset: 0x12
		public int Race; //Field offset: 0x14
		public int Attack; //Field offset: 0x18
		public int BaseAttack; //Field offset: 0x1C
		public int Defense; //Field offset: 0x20
		public int BaseDefense; //Field offset: 0x24
		public CardCoordinate CurrentCoordinates; //Field offset: 0x28
		public byte Position; //Field offset: 0x2B
		public byte Owner; //Field offset: 0x2C
		public byte SelectSeq; //Field offset: 0x2D
		public int OpParam1; //Field offset: 0x30
		public int OpParam2; //Field offset: 0x34
		public int Reason; //Field offset: 0x38
		public Int32[] ActionIndex; //Field offset: 0x40
		public ActivationCardIndex[] ActionActivateIndex; //Field offset: 0x48
		public CardCoordinate ReasonCard; //Field offset: 0x50
		public CardCoordinate EquipTarget; //Field offset: 0x53
		public CardCoordinate Negator; //Field offset: 0x56
		public CardCoordinate Negating; //Field offset: 0x59
		public CardCoordinate[] EquipCards; //Field offset: 0x60
		public CardCoordinate[] OwnTargets; //Field offset: 0x68
		public CardCoordinate[] ChainOnlyOwnTargets; //Field offset: 0x70
		public CardCoordinate[] TargetCards; //Field offset: 0x78
		public CardCoordinate[] CurrentChainTargets; //Field offset: 0x80
		public Int32[] Overlays; //Field offset: 0x88
		public Int32[] AdditionalDescs; //Field offset: 0x90
		public String[] AdditionalTexts; //Field offset: 0x98
		public UInt16[][] Counters; //Field offset: 0xA0
		public bool CanDirectAttack; //Field offset: 0xA8
		public bool Attacked; //Field offset: 0xA9
		public bool IsSpecialSummoned; //Field offset: 0xAA
		public int Status; //Field offset: 0xAC
		public int Cover; //Field offset: 0xB0

		[CalledBy(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SelectEffectYnData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+<OnBotFieldCardInfo>d__50", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivationCardIndex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ClientAPI.WebServer+ActivationCardIndex>)}, ReturnType = typeof(ActivationCardIndex[]))]
		[Calls(Type = typeof(CardCoordinate), Member = "InitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(CardCoordinate[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 13)]
		public DynamicCard(BotClientCard c) { }

		[CalledBy(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+<OnFieldCardInfo>d__51", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivationCardIndex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ClientAPI.WebServer+ActivationCardIndex>)}, ReturnType = typeof(ActivationCardIndex[]))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(CardCoordinate), Member = "InitMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(CardCoordinate[]))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.UInt16, System.UInt16>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.UInt16, System.UInt16>>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.UInt16, System.UInt16>))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		public DynamicCard(ClientCard c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct FavoriteList
	{
		public Int32[] Cards; //Field offset: 0x0

		[CalledBy(Type = "ClientAPI.WebServer+<OnFavoriteList>d__31", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[CallsUnknownMethods(Count = 2)]
		public FavoriteList(List<Int32> cards) { }

	}

	private struct FieldInfo
	{
		public CardInfo OwnSide; //Field offset: 0x0
		public CardInfo EnemySide; //Field offset: 0x100

		[CalledBy(Type = "ClientAPI.WebServer+<OnFieldInfo>d__88", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientField)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public FieldInfo(ClientField own, ClientField enemy) { }

		[CalledBy(Type = "ClientAPI.WebServer+<OnBotFieldInfo>d__87", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "ClientAPI.WebServer+CardInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public FieldInfo(BotClientField own, BotClientField enemy) { }

	}

	private struct FieldPositionData : ISerializable
	{
		public Vector3 PlayerSidePosition; //Field offset: 0x0
		public Vector3 PlayerHandPosition; //Field offset: 0xC
		public FullRotation PlayerHandRotation; //Field offset: 0x18
		public Vector3 OpponentSidePosition; //Field offset: 0x34
		public Vector3 OpponentHandPosition; //Field offset: 0x40
		public FullRotation OpponentHandRotation; //Field offset: 0x4C
		public Vector3 FieldPosition; //Field offset: 0x68
		public FullRotation FieldRotation; //Field offset: 0x74
		public Vector3 CameraPosition; //Field offset: 0x90
		public FullRotation CameraRotation; //Field offset: 0x9C
		public Vector3[] PlayerHandCards; //Field offset: 0xB8
		public Vector3[] OpponentHandCards; //Field offset: 0xC0
		public Vector2 ScreenResolution; //Field offset: 0xC8

		[CalledBy(Type = "ClientAPI.WebServer+<OnFieldPosition>d__25", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public FieldPositionData(DuelZone dz) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct FullRotation : ISerializable
	{
		public Quaternion Quaternion; //Field offset: 0x0
		public Vector3 Euler; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 1)]
		public FullRotation(Transform t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct HandInfo
	{
		public int p1Count; //Field offset: 0x0
		public int p2Count; //Field offset: 0x4
		public Int32[] p1Ids; //Field offset: 0x8
		public Int32[] p2Ids; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 4)]
		public HandInfo(List<Template> p1, List<Template> p2) { }

	}

	private struct IdleCmdState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public IdleCmdStateData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public IdleCmdState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal struct ResponseReason
	{
		public int Code; //Field offset: 0x0
		public string Reason; //Field offset: 0x8

		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ResponseReason(int code, string reason) { }

	}

	private struct RoomList
	{
		public RoomListItem[] Rooms; //Field offset: 0x0

		[CalledBy(Type = "ClientAPI.WebServer+<OnRoomList>d__91", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public RoomList(List<RoomData> rooms) { }

	}

	private struct RoomListItem : ISerializable
	{
		public int RoomID; //Field offset: 0x0
		public uint LFListHash; //Field offset: 0x4
		public long HostID; //Field offset: 0x8
		public byte State; //Field offset: 0x10
		public bool IsRanked; //Field offset: 0x11
		public string HostName; //Field offset: 0x18
		public byte PlayerCount; //Field offset: 0x20
		public byte DuelCount; //Field offset: 0x21
		public SByte[] Winner; //Field offset: 0x28
		public GameSettings Settings; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public RoomListItem(RoomData r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectCardState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectCardStateData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectCardState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectChainState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectChainData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectChainState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectCounterState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectCounterData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectCounterState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectDisfieldState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectDisfieldData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 2)]
		public SelectDisfieldState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectEffectYnState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectEffectYnData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectEffectYnState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectOptionState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectOptionData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectOptionState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectPlaceState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectPlaceData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 2)]
		public SelectPlaceState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectPositionState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectPositionData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectPositionState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectSumState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectSumData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectSumState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectTributeState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectTributeData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectTributeState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectUnselectCardState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectUnselectCardData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SelectUnselectCardState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SelectYesNoState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SelectYesNoStateData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 2)]
		public SelectYesNoState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct SortCardState : ISerializable
	{
		public BotStateHeader CurrentStateHeader; //Field offset: 0x0
		public SortCardData CurrentStateData; //Field offset: 0x28

		[CalledBy(Type = typeof(WebServer), Member = "GenerateBotState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameBehavior), Member = "DefineCustomBotStateInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
		[CallsUnknownMethods(Count = 3)]
		public SortCardState(GameBehavior bot) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private struct UserData
	{
		public long UserID; //Field offset: 0x0
		public string Username; //Field offset: 0x8
		public ushort TCGWins; //Field offset: 0x10
		public ushort TCGLoses; //Field offset: 0x12
		public ushort TCGDraws; //Field offset: 0x14
		public ushort OCGWins; //Field offset: 0x16
		public ushort OCGLoses; //Field offset: 0x18
		public ushort OCGDraws; //Field offset: 0x1A
		public ushort DuelPoints; //Field offset: 0x1C
		public byte UserRank; //Field offset: 0x1E
		public byte Rare; //Field offset: 0x1F
		public byte Super; //Field offset: 0x20
		public byte Ultra; //Field offset: 0x21
		public byte Secret; //Field offset: 0x22
		public byte Ultimate; //Field offset: 0x23
		public byte Parallel; //Field offset: 0x24
		public byte Ghost; //Field offset: 0x25
		public ushort TournamentPoints; //Field offset: 0x26
		public float OCGRating; //Field offset: 0x28
		public float TCGRating; //Field offset: 0x2C
		public byte Flags; //Field offset: 0x30
		public string DTK; //Field offset: 0x38

		[CalledBy(Type = "ClientAPI.WebServer+<OnUserInfo>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public UserData(Player p) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private static string GetDLT() { }

	}

	private static WebServer Instance; //Field offset: 0x0
	private const string PREFIX_URL = "http://localhost:19999/"; //Field offset: 0x0
	private const string PREFIX_URL_127 = "http://127.0.0.1:19999/"; //Field offset: 0x0
	private static bool _enableClientAPI; //Field offset: 0x8
	private static readonly bool CAN_DISABLE_API; //Field offset: 0x9
	private static readonly Dictionary<String, Func`4<HttpListenerRequest, HttpListenerResponse, String[], Task`1<String>>> RequestHandlers; //Field offset: 0x10
	private static readonly string HELP_STRING; //Field offset: 0x18
	private readonly HttpListener _listener; //Field offset: 0x10

	public static bool EnableClientAPI
	{
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 94
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(WebServer), Member = "Close", ReturnType = typeof(void))]
		[Calls(Type = typeof(WebServer), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(HttpListenerResponse), Member = "get_OutputStream", ReturnType = typeof(Stream))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 448
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static WebServer() { }

	[CalledBy(Type = typeof(WebServer), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "get_Prefixes", ReturnType = typeof(HttpListenerPrefixCollection))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpListenerPrefixCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "set_AuthenticationSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthenticationSchemes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "set_UnsafeConnectionNtlmAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "set_IgnoreWriteExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private WebServer(IReadOnlyCollection<String> prefixes) { }

	[CalledBy(Type = typeof(Helper), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebServer), Member = "set_EnableClientAPI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebServer), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebServer), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Create() { }

	[CalledBy(Type = typeof(<OnGetBotState>d__82), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotGeneralState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortCardState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectYesNoState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnnounceCardFilterState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnnounceRaceState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnnounceNumberState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnnounceCardState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnnounceAttributeState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectTributeState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectSumState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectPositionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectPlaceState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectOptionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IdleCmdState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectEffectYnState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectDisfieldState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectCounterState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectChainState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectUnselectCardState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SelectCardState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BattleCmdState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameBehavior), Member = "get_CustomAI", ReturnType = typeof(AI_Custom))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static string GenerateBotState(GameBehavior bot) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool get_EnableClientAPI() { }

	[CalledBy(Type = typeof(<OnChatMessage>d__22), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string Get64Msg(string b64) { }

	[CalledBy(Type = typeof(<OnAddDeck>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnChatMessage>d__22), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSetCustomBotData>d__83), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebServer), Member = "GetBotResponseData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(General), Member = "B64Safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HttpUtility), Member = "UrlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static string GetB64(String[] args, int start, int end = -1) { }

	[CalledBy(Type = typeof(<OnBotFieldCardInfo>d__50), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnBotFieldInfo>d__87), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	private static string GetBotFromArguments(HttpListenerResponse response, out GameBehavior bot, String[] args) { }

	[CalledBy(Type = typeof(<OnSetBotResponse>d__80), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebServer), Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	private static Byte[] GetBotResponseData(String[] args) { }

	[CalledBy(Type = typeof(<OnGetBotState>d__82), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnGetBotStateHeader>d__81), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSetBotResponse>d__80), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSetCustomBotData>d__83), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(General), Member = "ResponseReason", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerResponse), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	private static string GetCustomBotFromArguments(HttpListenerResponse response, out GameBehavior bot, String[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static String[] GetEndPoints() { }

	[CalledBy(Type = typeof(WebServer), Member = "set_EnableClientAPI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebServer), Member = "Create", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WebServer), Member = "RegisterHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(WebServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyCollection`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenRequests>d__100)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenRequests>d__100&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebServer), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsSafeB64(ref string b64) { }

	[AsyncStateMachine(typeof(<ListenRequests>d__100))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenRequests>d__100)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenRequests>d__100&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ListenRequests() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static string MergeArgs(String[] args, int start, int end = -1) { }

	[AsyncStateMachine(typeof(<OnAddDeck>d__38))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAddDeck>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAddDeck>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnAddDeck(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnBotFieldCardInfo>d__50))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBotFieldCardInfo>d__50)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBotFieldCardInfo>d__50&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnBotFieldCardInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnBotFieldInfo>d__87))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBotFieldInfo>d__87)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBotFieldInfo>d__87&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnBotFieldInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnBotList>d__86))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBotList>d__86)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBotList>d__86&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnBotList(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnCardInfo>d__52))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardInfo>d__52)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardInfo>d__52&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnCardInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnCardList>d__53))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardList>d__53)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardList>d__53&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnCardList(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnChatMessage>d__22))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChatMessage>d__22)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChatMessage>d__22&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnChatMessage(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnCurrentDeck>d__43))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCurrentDeck>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCurrentDeck>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnCurrentDeck(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnCustomPath>d__93))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCustomPath>d__93)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCustomPath>d__93&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnCustomPath(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnDeckList>d__34))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDeckList>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDeckList>d__34&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnDeckList(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnDeleteDeck>d__39))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDeleteDeck>d__39)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDeleteDeck>d__39&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnDeleteDeck(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnDiscordAuth>d__27))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDiscordAuth>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDiscordAuth>d__27&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnDiscordAuth(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnFavoriteList>d__31))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFavoriteList>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFavoriteList>d__31&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnFavoriteList(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnFieldCardInfo>d__51))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldCardInfo>d__51)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldCardInfo>d__51&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnFieldCardInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnFieldInfo>d__88))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldInfo>d__88)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldInfo>d__88&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnFieldInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnFieldPosition>d__25))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldPosition>d__25)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldPosition>d__25&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnFieldPosition(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnFocus>d__26))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFocus>d__26)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFocus>d__26&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnFocus(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnGetBotState>d__82))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnGetBotState>d__82)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnGetBotState>d__82&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnGetBotState(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnGetBotStateHeader>d__81))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnGetBotStateHeader>d__81)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnGetBotStateHeader>d__81&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnGetBotStateHeader(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnGetDuelLog>d__23))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnGetDuelLog>d__23)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnGetDuelLog>d__23&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnGetDuelLog(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnHelp>d__16))]
	[CalledBy(Type = typeof(<SendResponse>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHelp>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHelp>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Task<String> OnHelp(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnJoinRoom>d__96))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnJoinRoom>d__96)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnJoinRoom>d__96&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnJoinRoom(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnRematchDuel>d__24))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRematchDuel>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRematchDuel>d__24&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnRematchDuel(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnRoomInfo>d__94))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRoomInfo>d__94)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRoomInfo>d__94&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnRoomInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnRoomList>d__91))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRoomList>d__91)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRoomList>d__91&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnRoomList(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnSetBotResponse>d__80))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSetBotResponse>d__80)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSetBotResponse>d__80&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnSetBotResponse(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnSetCustomBotData>d__83))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSetCustomBotData>d__83)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSetCustomBotData>d__83&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnSetCustomBotData(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnSetFavoriteCard>d__32))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSetFavoriteCard>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSetFavoriteCard>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnSetFavoriteCard(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnSpectatorMode>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpectatorMode>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpectatorMode>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> OnSpectatorMode(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<OnUserInfo>d__29))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUserInfo>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUserInfo>d__29&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<String> OnUserInfo(HttpListenerRequest request, HttpListenerResponse response, String[] args) { }

	[AsyncStateMachine(typeof(<ParseRequest>d__101))]
	[CalledBy(Type = typeof(<ListenRequests>d__100), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseRequest>d__101)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseRequest>d__101&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task ParseRequest(HttpListenerContext ctx) { }

	[CalledBy(Type = typeof(WebServer), Member = "RegisterHandlers", ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void RegisterHandler(string endpoint, Func<HttpListenerRequest, HttpListenerResponse, String[], Task`1<String>> handler) { }

	[CalledBy(Type = typeof(WebServer), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebServer), Member = "RegisterHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`4<System.Net.HttpListenerRequest, System.Net.HttpListenerResponse, String[], System.Threading.Tasks.Task`1<System.String>>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void RegisterHandlers() { }

	[CalledBy(Type = typeof(<OnDiscordAuth>d__27), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnFocus>d__26), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerResponse), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static string ResponseScript(HttpListenerResponse resp, string script) { }

	[AsyncStateMachine(typeof(<SendResponse>d__105))]
	[CalledBy(Type = typeof(<ParseRequest>d__101), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendResponse>d__105)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendResponse>d__105&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task<String> SendResponse(HttpListenerRequest request, HttpListenerResponse response) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WebServer), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebServer), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListenerResponse), Member = "get_OutputStream", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_EnableClientAPI(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenRequests>d__100)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenRequests>d__100&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpListener), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Stop() { }

}

