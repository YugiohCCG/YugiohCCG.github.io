namespace Utilities.Async.AwaitYieldInstructions;

public sealed class BackgroundThread : CustomYieldInstruction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		private struct <<GetAwaiter>b__0_0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
			[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Task))]
			[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<<GetAwaiter>b__0_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<<GetAwaiter>b__0_0>d&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Task> <>9__0_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[AsyncStateMachine(typeof(<<GetAwaiter>b__0_0>d))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Utilities.Async.AwaitYieldInstructions.BackgroundThread+<>c+<<GetAwaiter>b__0_0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<GetAwaiter>b__0_0>d&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Task <GetAwaiter>b__0_0() { }

	}


	public virtual bool keepWaiting
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BackgroundThread() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_keepWaiting() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static ConfiguredTaskAwaiter GetAwaiter() { }

}

