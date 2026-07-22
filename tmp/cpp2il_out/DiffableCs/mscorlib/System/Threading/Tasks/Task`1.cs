namespace System.Threading.Tasks;

[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView`1))]
public class Task : Task
{
	private static TaskFactory<TResult> s_defaultFactory; //Field offset: 0x0
	internal TResult m_result; //Field offset: 0x0

	public static TaskFactory<TResult> Factory
	{
		[CalledBy(Type = "System.Net.WebRequest", Member = "<GetResponseAsync>b__79_0", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
		[CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), "System.Net.IPEndPoint"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[CalledBy(Type = "System.Net.Sockets.TcpListener", Member = "AcceptTcpClientAsync", ReturnType = "System.Threading.Tasks.Task`1<TcpClient>")]
		[CalledBy(Type = "System.Net.HttpListener", Member = "GetContextAsync", ReturnType = "System.Threading.Tasks.Task`1<HttpListenerContext>")]
		[CalledBy(Type = "System.Net.Dns", Member = "GetHostEntryAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<IPHostEntry>")]
		[CalledBy(Type = "System.Net.Dns", Member = "GetHostAddressesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<IPAddress[]>")]
		[CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "ReceiveAsync", ReturnType = "System.Threading.Tasks.Task`1<UdpReceiveResult>")]
		[CalledBy(Type = "System.Net.WebRequest", Member = "<GetRequestStreamAsync>b__78_0", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
		[CalledBy(Type = "System.Net.WebRequest+<>c__DisplayClass78_0", Member = "<GetRequestStreamAsync>b__1", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
		[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextReader), Member = "ReadAsyncInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(TextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(TextReader), Member = "ReadLineAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[CalledBy(Type = typeof(StreamReader), Member = "ReadLineAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[CalledBy(Type = "System.Net.WebRequest+<>c__DisplayClass79_0", Member = "<GetResponseAsync>b__1", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskFactory`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 336
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public TResult Result
	{
		[CalledBy(Type = "System.Net.WebConnectionStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "DoReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Boolean>")]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebReadStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
		[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "ThrowOnError", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "FinishInitUriString", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 131
	}

	internal TResult ResultOnSuccess
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Task`1() { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Task`1(object state, TaskCreationOptions options) { }

	[CalledBy(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "GetTaskForResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Task`1(TResult result) { }

	[CalledBy(Type = typeof(AsyncTaskCache), Member = "CreateCacheableTask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Task`1(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.AsyncUtils", Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Task`1(Func<TResult> function, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Task`1(Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Task`1(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Task`1(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[CallerCount(Count = 163)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TResult>", typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions), typeof(TaskCreationOptions&), typeof(InternalTaskOptions&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContinuationTaskFromResultTask`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal Task ContinueWith(Action<Task`1<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions), typeof(TaskCreationOptions&), typeof(InternalTaskOptions&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContinuationTaskFromResultTask`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public Task ContinueWith(Action<Task`1<TResult>> continuationAction, TaskScheduler scheduler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions), typeof(TaskCreationOptions&), typeof(InternalTaskOptions&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContinuationResultTaskFromResultTask`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal Task<TNewResult> ContinueWith(Func<Task`1<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
	[Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions), typeof(TaskCreationOptions&), typeof(InternalTaskOptions&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContinuationResultTaskFromResultTask`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public Task<TNewResult> ContinueWith(Func<Task`1<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }

	[CalledBy(Type = "System.Threading.Tasks.TaskFactory`1+FromAsyncTrimPromise`1", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>", typeof(IAsyncResult), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleDataRef`1", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>", "UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ContingentProperties), Member = "SetCompleted", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal void DangerousSetResult(TResult result) { }

	[CalledBy(Type = "System.Net.WebRequest", Member = "<GetResponseAsync>b__79_0", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
	[CalledBy(Type = "System.Net.WebRequest+<>c__DisplayClass79_0", Member = "<GetResponseAsync>b__1", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadLineAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
	[CalledBy(Type = typeof(TextReader), Member = "ReadLineAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
	[CalledBy(Type = typeof(TextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(TextReader), Member = "ReadAsyncInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = "System.Net.WebRequest+<>c__DisplayClass78_0", Member = "<GetRequestStreamAsync>b__1", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
	[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "ReceiveAsync", ReturnType = "System.Threading.Tasks.Task`1<UdpReceiveResult>")]
	[CalledBy(Type = "System.Net.Dns", Member = "GetHostAddressesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<IPAddress[]>")]
	[CalledBy(Type = "System.Net.Dns", Member = "GetHostEntryAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<IPHostEntry>")]
	[CalledBy(Type = "System.Net.HttpListener", Member = "GetContextAsync", ReturnType = "System.Threading.Tasks.Task`1<HttpListenerContext>")]
	[CalledBy(Type = "System.Net.Sockets.TcpListener", Member = "AcceptTcpClientAsync", ReturnType = "System.Threading.Tasks.Task`1<TcpClient>")]
	[CalledBy(Type = "System.Net.Sockets.UdpClient", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), "System.Net.IPEndPoint"}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "<GetRequestStreamAsync>b__78_0", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskFactory`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public static TaskFactory<TResult> get_Factory() { }

	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "DoReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "ThrowOnError", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TResult get_Result() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal TResult get_ResultOnSuccess() { }

	[CallerCount(Count = 340)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TaskAwaiter<TResult> GetAwaiter() { }

	[CalledBy(Type = "System.Threading.Tasks.Task+WhenAllPromise`1", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal TResult GetResultCore(bool waitCompletionNotification) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal virtual void InnerInvoke() { }

	[CalledBy(Type = typeof(TaskFactory`1), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static Task<TResult> StartNew(Task parent, Func<Object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[CalledBy(Type = "System.Threading.Tasks.Task+WhenAllPromise", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+TaskNode", Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.TaskFactory`1+FromAsyncTrimPromise`1", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>", typeof(IAsyncResult), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleDataRef`1", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>", "UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContingentProperties), Member = "SetCompleted", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool TrySetResult(TResult result) { }

}

