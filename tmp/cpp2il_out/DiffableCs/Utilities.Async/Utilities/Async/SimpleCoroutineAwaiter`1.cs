namespace Utilities.Async;

public class SimpleCoroutineAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private Exception exception; //Field offset: 0x0
	private Action continuation; //Field offset: 0x0
	private T result; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x0

	public private bool IsCompleted
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SimpleCoroutineAwaiter`1() { }

	[CalledBy(Type = "Utilities.Async.AwaiterExtensions+<AssetBundleCreateRequest>d__28", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions+<AssetBundleRequest>d__29", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions+<ResourceRequest>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Utilities.Async.CoroutineWrapper`1+<Run>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AwaiterExtensions), Member = "RunOnUnityScheduler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void Complete(T taskResult, Exception e = null) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsCompleted() { }

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[UsedImplicitly]
	public T GetResult() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public override void OnCompleted(Action notifyContinuation) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsCompleted(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public override void UnsafeOnCompleted(Action notifyContinuation) { }

}

