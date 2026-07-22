namespace UnityEngine.InputSystem.LowLevel;

internal struct InputEventStream
{
	private InputEventBuffer m_NativeBuffer; //Field offset: 0x0
	private InputEvent* m_CurrentNativeEventReadPtr; //Field offset: 0x20
	private InputEvent* m_CurrentNativeEventWritePtr; //Field offset: 0x28
	private int m_RemainingNativeEventCount; //Field offset: 0x30
	private readonly int m_MaxAppendedEvents; //Field offset: 0x34
	private InputEventBuffer m_AppendBuffer; //Field offset: 0x38
	private InputEvent* m_CurrentAppendEventReadPtr; //Field offset: 0x58
	private InputEvent* m_CurrentAppendEventWritePtr; //Field offset: 0x60
	private int m_RemainingAppendEventCount; //Field offset: 0x68
	private int m_NumEventsRetainedInBuffer; //Field offset: 0x6C
	private bool m_IsOpen; //Field offset: 0x70

	public InputEvent* currentEventPtr
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 25
	}

	public bool isOpen
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public uint numBytesRetainedInBuffer
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 85
	}

	public int numEventsRetainedInBuffer
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int remainingEventCount
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 7
	}

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputEventBuffer), Member = "AdvanceToNextEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*&), typeof(InputEvent*&), typeof(Int32&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	public InputEvent* Advance(bool leaveEventInBuffer) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	public void CleanUpAfterException() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputEventBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Close(ref InputEventBuffer eventBuffer) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public InputEvent* get_currentEventPtr() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isOpen() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public uint get_numBytesRetainedInBuffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_numEventsRetainedInBuffer() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public int get_remainingEventCount() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public InputEvent* Peek() { }

	[CalledBy(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputEventBuffer), Member = "AllocateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(InputEvent*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Write(InputEvent* eventPtr) { }

}

