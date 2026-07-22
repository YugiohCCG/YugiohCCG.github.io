namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredTaskAwaitable
{
	[IsReadOnly]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task<TResult> m_task; //Field offset: 0x0
		private readonly bool m_continueOnCapturedContext; //Field offset: 0x0

		public bool IsCompleted
		{
			[CallerCount(Count = 1436)]
			[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 28
		}

		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext) { }

		[CallerCount(Count = 1436)]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public bool get_IsCompleted() { }

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[StackTraceHidden]
		public TResult GetResult() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override void OnCompleted(Action continuation) { }

		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; //Field offset: 0x0

	[CalledBy(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal ConfiguredTaskAwaitable`1(Task<TResult> task, bool continueOnCapturedContext) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public ConfiguredTaskAwaiter<TResult> GetAwaiter() { }

}

