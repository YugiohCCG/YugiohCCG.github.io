namespace System.Diagnostics;

public abstract class TraceListener : MarshalByRefObject, IDisposable
{
	private int indentLevel; //Field offset: 0x18
	private int indentSize; //Field offset: 0x1C
	private TraceOptions traceOptions; //Field offset: 0x20
	private bool needIndent; //Field offset: 0x24
	private string listenerName; //Field offset: 0x28
	private TraceFilter filter; //Field offset: 0x30

	[ComVisible(False)]
	public TraceFilter Filter
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int IndentLevel
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 29
	}

	public int IndentSize
	{
		[CalledBy(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		[CalledBy(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceListener)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 179
	}

	public override bool IsThreadSafe
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	protected bool NeedIndent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[ComVisible(False)]
	public TraceOptions TraceOutputOptions
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected TraceListener(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Flush() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public TraceFilter get_Filter() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsThreadSafe() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected bool get_NeedIndent() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public TraceOptions get_TraceOutputOptions() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool IsEnabled(TraceOptions opts) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_IndentLevel(int value) { }

	[CalledBy(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
	[CalledBy(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_IndentSize(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void set_NeedIndent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TraceListener), Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceEventCache)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ComVisible(False)]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	public abstract void Write(string message) { }

	[CalledBy(Type = typeof(TraceListener), Member = "TraceEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TraceEventCache), typeof(string), typeof(TraceEventType), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TraceEventCache), Member = "InitProcessInfo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 18)]
	private void WriteFooter(TraceEventCache eventCache) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void WriteIndent() { }

	public abstract void WriteLine(string message) { }

}

