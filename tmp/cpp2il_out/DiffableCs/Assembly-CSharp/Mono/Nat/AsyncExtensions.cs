namespace Mono.Nat;

[Extension]
internal static class AsyncExtensions
{
	[CompilerGenerated]
	private struct <EnterAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IDisposable> <>t__builder; //Field offset: 0x8
		public SemaphoreSlim semaphore; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class SemaphoreSlimDisposable : IDisposable
	{
		private SemaphoreSlim Semaphore; //Field offset: 0x10

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public SemaphoreSlimDisposable(SemaphoreSlim semaphore) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

	}

	[CompilerGenerated]
	private static readonly Logger <Log>k__BackingField; //Field offset: 0x0

	private static Logger Log
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Logger))]
	[CallsUnknownMethods(Count = 1)]
	private static AsyncExtensions() { }

	[AsyncStateMachine(typeof(<EnterAsync>d__4))]
	[CalledBy(Type = "Mono.Nat.Searcher+<ListenOneAsync>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.SocketGroup+<SendAsync>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EnterAsync>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EnterAsync>d__4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static Task<IDisposable> EnterAsync(SemaphoreSlim semaphore, CancellationToken token) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static Logger get_Log() { }

}

