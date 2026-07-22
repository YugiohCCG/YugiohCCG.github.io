namespace Mono.Nat.Pmp;

internal class PmpSearcher : Searcher
{
	[CompilerGenerated]
	private struct <SearchAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PmpSearcher <>4__this; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		public IPAddress gatewayAddress; //Field offset: 0x38
		public Nullable<TimeSpan> repeatInterval; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Pmp.PmpSearcher+<SearchOnce>d__12"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SearchOnce>d__12&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken[])}, ReturnType = typeof(CancellationTokenSource))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SearchOnce>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PmpSearcher <>4__this; //Field offset: 0x20
		public IPAddress gatewayAddress; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private Byte[] <buffer>5__2; //Field offset: 0x38
		private TimeSpan <delay>5__3; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SocketGroup), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(IPAddress), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static readonly Logger <Log>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private CancellationTokenSource <CurrentSearchCancellation>k__BackingField; //Field offset: 0x48

	private CancellationTokenSource CurrentSearchCancellation
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	private static Logger Log
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 78
	}

	public virtual NatProtocol Protocol
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Logger))]
	[CallsUnknownMethods(Count = 1)]
	private static PmpSearcher() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Searcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketGroup)}, ReturnType = typeof(void))]
	private PmpSearcher(SocketGroup sockets) { }

	[CalledBy(Type = typeof(NatUtility), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatProtocol)}, ReturnType = typeof(ISearcher))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkInterface), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.Net.Sockets.UdpClient, System.Collections.Generic.List`1<System.Net.IPAddress>>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Searcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketGroup)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 52)]
	internal static PmpSearcher Create() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private CancellationTokenSource get_CurrentSearchCancellation() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static Logger get_Log() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual NatProtocol get_Protocol() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = "NetworkToHostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NatDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint), typeof(NatProtocol)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Searcher), Member = "RaiseDeviceFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatDevice)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual Task HandleMessageReceived(IPAddress localAddress, Byte[] response, IPEndPoint endpoint, bool externalEvent, CancellationToken token) { }

	[AsyncStateMachine(typeof(<SearchAsync>d__11))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SearchAsync>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SearchAsync>d__11&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void SearchAsync(IPAddress gatewayAddress, Nullable<TimeSpan> repeatInterval, CancellationToken token) { }

	[AsyncStateMachine(typeof(<SearchOnce>d__12))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SearchOnce>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SearchOnce>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task SearchOnce(IPAddress gatewayAddress, CancellationToken token) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CurrentSearchCancellation(CancellationTokenSource value) { }

}

