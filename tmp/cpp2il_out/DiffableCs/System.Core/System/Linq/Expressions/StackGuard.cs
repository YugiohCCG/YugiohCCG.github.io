namespace System.Linq.Expressions;

internal sealed class StackGuard
{
	[CompilerGenerated]
	private sealed class <>c__3
	{
		public static readonly <>c__3<T1, T2> <>9; //Field offset: 0x0
		public static Func<Object, Object> <>9__3_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c__3`2() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__3`2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal object <RunOnEmptyStack>b__3_0(object s) { }

	}

	private int _executionStackCount; //Field offset: 0x10

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StackGuard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackGuard), Member = "RunOnEmptyStackCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"R"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, R>", typeof(object)}, ReturnType = "R")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public void RunOnEmptyStack(Action<T1, T2> action, T1 arg1, T2 arg2) { }

	[CalledBy(Type = typeof(StackGuard), Member = "RunOnEmptyStack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<T1, T2>", "T1", "T2"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`2<System.Object, System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), "System.Threading.Tasks.InternalTaskOptions", typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private R RunOnEmptyStackCore(Func<Object, R> action, object state) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNoLabelPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InsufficientExecutionStackException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool TryEnterOnCurrentStack() { }

}

