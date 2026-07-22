namespace UnityEngine.UIElements;

public sealed class EventDispatcher
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal Queue<EventRecord> <.cctor>b__35_0() { }

	}

	private struct DispatchContext
	{
		public uint m_GateCount; //Field offset: 0x0
		public Queue<EventRecord> m_Queue; //Field offset: 0x8

	}

	private struct EventRecord
	{
		public EventBase m_Event; //Field offset: 0x0
		public BaseVisualElementPanel m_Panel; //Field offset: 0x8

	}

	private static readonly ObjectPool<Queue`1<EventRecord>> k_EventQueuePool; //Field offset: 0x0
	internal const int k_MaxGateDepth = 500; //Field offset: 0x0
	internal const int k_NumberOfEventsWithStackInfo = 10; //Field offset: 0x0
	internal const int k_NumberOfEventsWithEventInfo = 100; //Field offset: 0x0
	internal ClickDetector m_ClickDetector; //Field offset: 0x10
	private Queue<EventRecord> m_Queue; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly PointerDispatchState <pointerState>k__BackingField; //Field offset: 0x20
	private uint m_GateCount; //Field offset: 0x28
	private uint m_GateDepth; //Field offset: 0x2C
	private int m_DispatchStackFrame; //Field offset: 0x30
	private EventBase m_CurrentEvent; //Field offset: 0x38
	private Stack<DispatchContext> m_DispatchContexts; //Field offset: 0x40
	private bool m_Immediate; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <processingEvents>k__BackingField; //Field offset: 0x49

	private bool dispatchImmediately
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 21
	}

	internal PointerDispatchState pointerState
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	private bool processingEvents
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static EventDispatcher() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClickDetector), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDispatchState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Obsolete("Please use EventDispatcher.CreateDefault().")]
	internal EventDispatcher() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal void CloseGate() { }

	[CalledBy(Type = typeof(RuntimeEventDispatcher), Member = "Create", ReturnType = typeof(EventDispatcher))]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClickDetector), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDispatchState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static EventDispatcher CreateDefault() { }

	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Queue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcher), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void Dispatch(EventBase evt, BaseVisualElementPanel panel, DispatchMode dispatchMode) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_dispatchImmediately() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal PointerDispatchState get_pointerState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Debug), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private bool HandleRecursiveState(EventBase evt) { }

	[CalledBy(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcher), Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void OpenGate() { }

	[CalledBy(Type = typeof(EventDispatcher), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcher), Member = "OpenGate", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void ProcessEvent(EventBase evt, BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(EventDispatcher), Member = "OpenGate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(EventDispatcher), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void ProcessEventQueue() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_processingEvents(bool value) { }

}

