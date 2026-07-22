namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredValueTaskAwaitable
{
	[IsReadOnly]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly ValueTask _value; //Field offset: 0x0

		public bool IsCompleted
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 73
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ConfiguredValueTaskAwaiter(ValueTask value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public bool get_IsCompleted() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[StackTraceHidden]
		public void GetResult() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		public override void OnCompleted(Action continuation) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[Calls(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ValueTask _value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ConfiguredValueTaskAwaitable(ValueTask value) { }

	[CallerCount(Count = 99)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ConfiguredValueTaskAwaiter GetAwaiter() { }

}

