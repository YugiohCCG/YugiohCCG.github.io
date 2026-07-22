namespace System.Threading.Tasks;

internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__7_0(object state) { }

	}

	private static readonly SendOrPostCallback s_postCallback; //Field offset: 0x0
	private static ContextCallback s_postActionCallback; //Field offset: 0x8
	private readonly SynchronizationContext m_syncContext; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static SynchronizationContextAwaitTaskContinuation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ContextCallback GetPostActionCallback() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void PostAction(object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

