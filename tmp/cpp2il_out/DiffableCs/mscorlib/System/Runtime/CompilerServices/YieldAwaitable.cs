namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct YieldAwaitable
{
	[IsReadOnly]
	internal struct YieldAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private static readonly WaitCallback s_waitCallbackRunAction; //Field offset: 0x0
		private static readonly SendOrPostCallback s_sendOrPostCallbackRunAction; //Field offset: 0x8

		public bool IsCompleted
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private static YieldAwaiter() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public bool get_IsCompleted() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public void GetResult() { }

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		public override void OnCompleted(Action continuation) { }

		[CalledBy(Type = typeof(YieldAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(SynchronizationContext))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private static void QueueContinuation(Action continuation, bool flowContext) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private static void RunAction(object state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		public override void UnsafeOnCompleted(Action continuation) { }

	}


	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public YieldAwaiter GetAwaiter() { }

}

