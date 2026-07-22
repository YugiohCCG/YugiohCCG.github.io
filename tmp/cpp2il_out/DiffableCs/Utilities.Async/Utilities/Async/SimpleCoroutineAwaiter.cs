namespace Utilities.Async;

public class SimpleCoroutineAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private Exception exception; //Field offset: 0x10
	private Action continuation; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x20

	public private bool IsCompleted
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SimpleCoroutineAwaiter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AwaiterExtensions), Member = "RunOnUnityScheduler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Complete(Exception e = null) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsCompleted() { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit+<RefreshDisplayedCards>d__362", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.AsyncExtensions+<Instantiate>d__7`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.AsyncExtensions+<WaitForSeconds>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[UsedImplicitly]
	public void GetResult() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override void OnCompleted(Action notifyContinuation) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsCompleted(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override void UnsafeOnCompleted(Action notifyContinuation) { }

}

