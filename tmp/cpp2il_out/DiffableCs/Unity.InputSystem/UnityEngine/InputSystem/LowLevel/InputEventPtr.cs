namespace UnityEngine.InputSystem.LowLevel;

public struct InputEventPtr : IEquatable<InputEventPtr>
{
	private readonly InputEvent* m_EventPtr; //Field offset: 0x0

	public InputEvent* data
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int deviceId
	{
		[CalledBy(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Utilities.ForDeviceEventObservable+ForDevice", Member = "OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 17
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WarpMousePositionCommand), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 104
	}

	public bool handled
	{
		[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 19
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfActionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TriggerState*), typeof(InputActionPhase), typeof(TriggerState&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 127
	}

	public int id
	{
		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 20
		[CalledBy(Type = typeof(WarpMousePositionCommand), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 113
	}

	internal double internalTime
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		internal get { } //Length: 19
		[CalledBy(Type = typeof(OnScreenControl), Member = "SendValueToControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenControl), Member = "SentDefaultValueToControl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WarpMousePositionCommand), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal set { } //Length: 105
	}

	public uint sizeInBytes
	{
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 17
	}

	internal FourCC stateFormat
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SwitchProControllerHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal get { } //Length: 193
	}

	internal uint stateOffset
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeltaStateEvent)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(DeltaStateEvent*))]
		[Calls(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		internal get { } //Length: 203
	}

	internal uint stateSizeInBytes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateEvent)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeltaStateEvent)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(DeltaStateEvent*))]
		[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(StateEvent*))]
		[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
		[Calls(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 252
	}

	public double time
	{
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace+ReplayController+<>c", Member = "<PlayAllEventsAccordingToTimestamps>b__38_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Record))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 88
		[CalledBy(Type = typeof(InputControlExtensions), Member = "QueueValueChange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 158
	}

	public FourCC type
	{
		[CallerCount(Count = 35)]
		 get { } //Length: 15
	}

	public bool valid
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public InputEventPtr(InputEvent* eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InputEventPtr other) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static InputEventPtr From(InputEvent* eventPtr) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static InputEvent* FromInputEventPtr(InputEventPtr eventPtr) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public InputEvent* get_data() { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.ForDeviceEventObservable+ForDevice", Member = "OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public int get_deviceId() { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public bool get_handled() { }

	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_id() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	internal double get_internalTime() { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public uint get_sizeInBytes() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SwitchProControllerHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal FourCC get_stateFormat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeltaStateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(DeltaStateEvent*))]
	[Calls(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal uint get_stateOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeltaStateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(DeltaStateEvent*))]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(StateEvent*))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal uint get_stateSizeInBytes() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace+ReplayController+<>c", Member = "<PlayAllEventsAccordingToTimestamps>b__38_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Record))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public double get_time() { }

	[CallerCount(Count = 35)]
	public FourCC get_type() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_valid() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ActionEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(ActionEvent*))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActionEvent), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool IsA() { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public InputEventPtr Next() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WarpMousePositionCommand), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_deviceId(int value) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfActionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TriggerState*), typeof(InputActionPhase), typeof(TriggerState&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void set_handled(bool value) { }

	[CalledBy(Type = typeof(WarpMousePositionCommand), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_id(int value) { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "SendValueToControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SentDefaultValueToControl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WarpMousePositionCommand), Member = "get_typeStatic", ReturnType = typeof(FourCC))]
	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void set_internalTime(double value) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "QueueValueChange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void set_time(double value) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public InputEvent* ToPointer() { }

	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateFormat", ReturnType = typeof(FourCC))]
	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateOffset", ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputEvent), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

