namespace System.Threading.Tasks;

[IsReadOnly]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task _task; //Field offset: 0x0

	public bool IsCompleted
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ForceAsyncAwaiter(Task task) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_IsCompleted() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public ForceAsyncAwaiter GetAwaiter() { }

	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<ReadAsyncInternal>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<WriteAsyncInternal>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void GetResult() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnCompleted(Action action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void UnsafeOnCompleted(Action action) { }

}

