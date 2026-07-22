namespace System.Net;

internal sealed class NetEventSource : EventSource
{
	internal class Keywords
	{
		public const EventKeywords Default = 1; //Field offset: 0x0
		public const EventKeywords Debug = 2; //Field offset: 0x0
		public const EventKeywords EnterExit = 4; //Field offset: 0x0

	}

	public static readonly NetEventSource Log; //Field offset: 0x0

	public static bool IsEnabled
	{
		[CalledBy(Type = "System.Net.ContextAwareResult+<>c", Member = "<Complete>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "AttemptedRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ContextAwareResult), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static NetEventSource() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NetEventSource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetEventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Event(3, Level = EventLevel::Informational (4), Keywords = 1, Message = "[{2}]<-->[{3}]")]
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Associate(object first, object second, string memberName = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Event(6, Level = EventLevel::Critical (1), Keywords = 2)]
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebResponse), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormattableString)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Enter(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName = null) { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(long), typeof(Uri), typeof(FtpStatusCode), typeof(string), typeof(DateTime), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Enter(object thisOrContextObject, object arg0, string memberName = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Event(1, Level = EventLevel::Informational (4), Keywords = 4)]
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Error(object thisOrContextObject, object message, string memberName = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Event(5, Level = EventLevel::Warning (3), Keywords = 1)]
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(FtpWebResponse), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormattableString)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Exit(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Exit(object thisOrContextObject, object arg0, string memberName = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Event(2, Level = EventLevel::Informational (4), Keywords = 4)]
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Fail(object thisOrContextObject, object message, string memberName = null) { }

	[CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormattableString)}, ReturnType = typeof(string))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsInvalidInstructions]
	[NonEvent]
	public static object Format(object value) { }

	[CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 6)]
	[NonEvent]
	private static string Format(FormattableString s) { }

	[CalledBy(Type = "System.Net.ContextAwareResult+<>c", Member = "<Complete>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReceiveState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "AttemptedRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_IsEnabled() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NonEvent]
	public static int GetHashCode(object value) { }

	[CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static string IdOf(object value) { }

	[CalledBy(Type = "System.Net.ContextAwareResult+<>c", Member = "<Complete>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandStream), Member = "Abort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "TimerCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Info(object thisOrContextObject, object message, string memberName = null) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormattableString)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	public static void Info(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Event(4, Level = EventLevel::Informational (4), Keywords = 1)]
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[NonEvent]
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

}

