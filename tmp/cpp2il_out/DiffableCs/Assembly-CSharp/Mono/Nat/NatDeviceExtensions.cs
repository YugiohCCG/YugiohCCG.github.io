namespace Mono.Nat;

[Extension]
public static class NatDeviceExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public TaskAsyncResult result; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass11_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <BeginGetExternalIP>b__0(Task t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public TaskAsyncResult result; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass13_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <BeginGetSpecificMapping>b__0(Task t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TaskAsyncResult result; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass5_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <BeginCreatePortMap>b__0(Task t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TaskAsyncResult result; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <BeginDeletePortMap>b__0(Task t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public TaskAsyncResult result; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass9_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <BeginGetAllMappings>b__0(Task t) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static IAsyncResult BeginCreatePortMap(INatDevice device, Mapping mapping, AsyncCallback callback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static IAsyncResult BeginDeletePortMap(INatDevice device, Mapping mapping, AsyncCallback callback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static IAsyncResult BeginGetAllMappings(INatDevice device, AsyncCallback callback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static IAsyncResult BeginGetExternalIP(INatDevice device, AsyncCallback callback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static IAsyncResult BeginGetSpecificMapping(INatDevice device, Protocol protocol, int externalPort, AsyncCallback callback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Mapping CreatePortMap(INatDevice device, Mapping mapping) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Mapping DeletePortMap(INatDevice device, Mapping mapping) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static Mapping EndCreatePortMap(INatDevice device, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static Mapping EndDeletePortMap(INatDevice device, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static Mapping[] EndGetAllMappings(INatDevice device, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static IPAddress EndGetExternalIP(INatDevice device, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static Mapping EndGetSpecificMapping(INatDevice device, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Mapping[] GetAllMappings(INatDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static IPAddress GetExternalIP(INatDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Mapping GetSpecificMapping(INatDevice device, Protocol protocol, int port) { }

}

