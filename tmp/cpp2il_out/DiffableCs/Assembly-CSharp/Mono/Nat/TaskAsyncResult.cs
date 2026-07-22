namespace Mono.Nat;

internal class TaskAsyncResult : IAsyncResult
{
	[CompilerGenerated]
	private readonly object <AsyncState>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly AsyncCallback <Callback>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <CompletedSynchronously>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private readonly Task <Task>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ManualResetEvent <WaitHandle>k__BackingField; //Field offset: 0x30

	public override object AsyncState
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AsyncCallback Callback
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool CompletedSynchronously
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private override bool IsCompleted
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

	public Task Task
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private ManualResetEvent WaitHandle
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CalledBy(Type = typeof(NatDeviceExtensions), Member = "BeginCreatePortMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(INatDevice), typeof(Mapping), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(NatDeviceExtensions), Member = "BeginDeletePortMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(INatDevice), typeof(Mapping), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(NatDeviceExtensions), Member = "BeginGetAllMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(INatDevice), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(NatDeviceExtensions), Member = "BeginGetExternalIP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(INatDevice), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(NatDeviceExtensions), Member = "BeginGetSpecificMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(INatDevice), typeof(Protocol), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TaskAsyncResult(Task task, AsyncCallback callback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Complete() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override object get_AsyncState() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override WaitHandle get_AsyncWaitHandle() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AsyncCallback get_Callback() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_CompletedSynchronously() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_IsCompleted() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Task get_Task() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private ManualResetEvent get_WaitHandle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsCompleted(bool value) { }

}

