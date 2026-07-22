namespace Mono.Nat;

internal abstract class Searcher : ISearcher, IDisposable
{
	[CompilerGenerated]
	private struct <ListenAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Searcher <>4__this; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Searcher+<ListenOneAsync>d__30"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenOneAsync>d__30&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Logger), Member = "ExceptionFormated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 29)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListenOneAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UdpClient udpClient; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public Searcher <>4__this; //Field offset: 0x30
		private UdpReceiveResult <data>5__2; //Field offset: 0x38
		private IPEndPoint <localEndPoint>5__3; //Field offset: 0x48
		private TaskAwaiter<UdpReceiveResult> <>u__1; //Field offset: 0x50
		private IDisposable <>7__wrap3; //Field offset: 0x58
		private TaskAwaiter<IDisposable> <>u__2; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__3; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UdpClient), Member = "ReceiveAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Sockets.UdpReceiveResult>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "EnterAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.IDisposable>))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 24)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static readonly Logger <Log>k__BackingField; //Field offset: 0x0
	protected static readonly TimeSpan SearchPeriod; //Field offset: 0x8
	[CompilerGenerated]
	private EventHandler<DeviceEventArgs> DeviceFound; //Field offset: 0x10
	[CompilerGenerated]
	private EventHandler<DeviceEventUnknownArgs> UnknownDeviceFound; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Listening>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Dictionary<NatDevice, NatDevice> <Devices>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly SocketGroup <Clients>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly CancellationTokenSource <Cancellation>k__BackingField; //Field offset: 0x38
	private SemaphoreSlim Locker; //Field offset: 0x40

	public override event EventHandler<DeviceEventArgs> DeviceFound
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public override event EventHandler<DeviceEventUnknownArgs> UnknownDeviceFound
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	protected CancellationTokenSource Cancellation
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected SocketGroup Clients
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private Dictionary<NatDevice, NatDevice> Devices
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public private override bool Listening
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

	private static Logger Log
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 78
	}

	public abstract NatProtocol Protocol
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Logger))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 1)]
	private static Searcher() { }

	[CalledBy(Type = typeof(PmpSearcher), Member = "Create", ReturnType = typeof(PmpSearcher))]
	[CalledBy(Type = typeof(PmpSearcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected Searcher(SocketGroup clients) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void add_DeviceFound(EventHandler<DeviceEventArgs> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void add_UnknownDeviceFound(EventHandler<DeviceEventUnknownArgs> value) { }

	[CalledBy(Type = typeof(Searcher), Member = "BeginSearching", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Searcher), Member = "BeginSearching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenAsync>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenAsync>d__29&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected void BeginListening() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Searcher), Member = "BeginListening", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void BeginSearching(IPAddress gatewayAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Searcher), Member = "BeginListening", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void BeginSearching() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketGroup), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected CancellationTokenSource get_Cancellation() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected SocketGroup get_Clients() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private Dictionary<NatDevice, NatDevice> get_Devices() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_Listening() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static Logger get_Log() { }

	public abstract NatProtocol get_Protocol() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task HandleMessageReceived(IPAddress localAddress, Byte[] response, IPEndPoint endpoint, CancellationToken token) { }

	protected abstract Task HandleMessageReceived(IPAddress localAddress, Byte[] response, IPEndPoint endpoint, bool externalEvent, CancellationToken token) { }

	[AsyncStateMachine(typeof(<ListenAsync>d__29))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenAsync>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenAsync>d__29&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ListenAsync(CancellationToken token) { }

	[AsyncStateMachine(typeof(<ListenOneAsync>d__30))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenOneAsync>d__30)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ListenOneAsync>d__30&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task ListenOneAsync(UdpClient udpClient, CancellationToken token) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PmpSearcher), Member = "HandleMessageReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(Byte[]), typeof(IPEndPoint), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected void RaiseDeviceFound(NatDevice device) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected void RaiseDeviceUnknown(IPAddress address, EndPoint remote, string response, NatProtocol protocol) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void remove_DeviceFound(EventHandler<DeviceEventArgs> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void remove_UnknownDeviceFound(EventHandler<DeviceEventUnknownArgs> value) { }

	protected abstract void SearchAsync(IPAddress gatewayAddress, Nullable<TimeSpan> repeatInterval, CancellationToken token) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Listening(bool value) { }

}

