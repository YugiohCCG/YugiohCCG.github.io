namespace System.Threading;

internal class CancellationCallbackInfo
{
	public sealed class WithSyncContext : CancellationCallbackInfo
	{
		internal readonly SynchronizationContext TargetSyncContext; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal WithSyncContext(Action<Object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) { }

	}

	private static ContextCallback s_executionContextCallback; //Field offset: 0x0
	internal readonly Action<Object> Callback; //Field offset: 0x10
	internal readonly object StateForCallback; //Field offset: 0x18
	internal readonly ExecutionContext TargetExecutionContext; //Field offset: 0x20
	internal readonly CancellationTokenSource CancellationTokenSource; //Field offset: 0x28

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal CancellationCallbackInfo(Action<Object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void ExecuteCallback() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void ExecutionContextCallback(object obj) { }

}

