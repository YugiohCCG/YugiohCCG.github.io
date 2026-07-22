namespace Utilities.Async;

[Extension]
public static class Awaiters
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public TaskCompletionSource<Object> tcs; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeoutException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetCanceled", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <WaitUntil>g__Exception|0() { }

	}

	[CompilerGenerated]
	private struct <WaitUntil_Indefinite>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public Func<T, Boolean> predicate; //Field offset: 0x0
		public T element; //Field offset: 0x0
		private TaskCompletionSource<Object> <tcs>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<Object> <>u__2; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 98)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitUntil>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public int timeout; //Field offset: 0x0
		public T element; //Field offset: 0x0
		public Func<T, Boolean> predicate; //Field offset: 0x0
		private <>c__DisplayClass6_0<T> <>8__1; //Field offset: 0x0
		private CancellationTokenSource <cancellationTokenSource>5__2; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private TaskAwaiter<Object> <>u__3; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(CancellationTokenRegistration))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 176)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static readonly UnityMainThread <UnityMainThread>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly BackgroundThread <BackgroundThread>k__BackingField; //Field offset: 0x8

	public static BackgroundThread BackgroundThread
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static UnityMainThread UnityMainThread
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static Awaiters() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static BackgroundThread get_BackgroundThread() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static UnityMainThread get_UnityMainThread() { }

	[AsyncStateMachine(typeof(<WaitUntil>d__6`1))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	[Extension]
	public static Task<T> WaitUntil(T element, Func<T, Boolean> predicate, int timeout = 10) { }

	[AsyncStateMachine(typeof(<WaitUntil_Indefinite>d__7`1))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	private static Task<T> WaitUntil_Indefinite(T element, Func<T, Boolean> predicate) { }

}

