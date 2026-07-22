namespace UnityEngine.InputSystem;

public class InputDevice : InputControl
{
	public struct ControlBitRangeNode
	{
		public ushort endBitOffset; //Field offset: 0x0
		public short leftChildIndex; //Field offset: 0x2
		public ushort controlStartIndex; //Field offset: 0x4
		public byte controlCount; //Field offset: 0x6

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public ControlBitRangeNode(ushort endOffset) { }

	}

	[Flags]
	public enum DeviceFlags
	{
		UpdateBeforeRender = 1,
		HasStateCallbacks = 2,
		HasControlsWithDefaultState = 4,
		HasDontResetControls = 1024,
		HasEventMerger = 8192,
		HasEventPreProcessor = 16384,
		Remote = 8,
		Native = 16,
		DisabledInFrontend = 32,
		DisabledInRuntime = 128,
		DisabledWhileInBackground = 256,
		DisabledStateHasBeenQueriedFromRuntime = 64,
		CanRunInBackground = 2048,
		CanRunInBackgroundHasBeenQueried = 4096,
	}

	public const int InvalidDeviceId = 0; //Field offset: 0x0
	internal const int kControlIndexBits = 10; //Field offset: 0x0
	internal const int kStateOffsetBits = 13; //Field offset: 0x0
	internal const int kStateSizeBits = 9; //Field offset: 0x0
	internal const int kInvalidDeviceIndex = -1; //Field offset: 0x0
	internal const int kLocalParticipantId = 0; //Field offset: 0x0
	internal DeviceFlags m_DeviceFlags; //Field offset: 0xE0
	internal int m_DeviceId; //Field offset: 0xE4
	internal int m_ParticipantId; //Field offset: 0xE8
	internal int m_DeviceIndex; //Field offset: 0xEC
	internal uint m_CurrentProcessedEventBytesOnUpdate; //Field offset: 0xF0
	internal InputDeviceDescription m_Description; //Field offset: 0xF8
	internal double m_LastUpdateTimeInternal; //Field offset: 0x130
	internal uint m_CurrentUpdateStepCount; //Field offset: 0x138
	internal InternedString[] m_AliasesForEachControl; //Field offset: 0x140
	internal InternedString[] m_UsagesForEachControl; //Field offset: 0x148
	internal InputControl[] m_UsageToControl; //Field offset: 0x150
	internal InputControl[] m_ChildrenForEachControl; //Field offset: 0x158
	internal HashSet<Int32> m_UpdatedButtons; //Field offset: 0x160
	internal List<ButtonControl> m_ButtonControlsCheckingPressState; //Field offset: 0x168
	internal bool m_UseCachePathForButtonPresses; //Field offset: 0x170
	internal UInt32[] m_StateOffsetToControlMap; //Field offset: 0x178
	internal ControlBitRangeNode[] m_ControlTreeNodes; //Field offset: 0x180
	internal UInt16[] m_ControlTreeIndices; //Field offset: 0x188

	public bool added
	{
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateHistory), Member = "StartRecording", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "CheckForRemovedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "PurgeStalePointers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputAction), Member = "ActiveControlIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator), typeof(bool)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
		[CalledBy(Type = typeof(InputState), Member = "AddChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	[Obsolete("Use 'InputSystem.devices' instead. (UnityUpgradable) -> InputSystem.devices", False)]
	public static ReadOnlyArray<InputDevice> all
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 163
	}

	public ReadOnlyArray<InputControl> allControls
	{
		[CalledBy(Type = typeof(InputManager), Member = "get_metrics", ReturnType = typeof(InputMetrics))]
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Finish", ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 86
	}

	internal bool canDeviceRunInBackground
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(QueryCanRunInBackground), Member = "Create", ReturnType = typeof(QueryCanRunInBackground))]
		[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground&)}, ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 187
	}

	public bool canRunInBackground
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(QueryCanRunInBackground), Member = "Create", ReturnType = typeof(QueryCanRunInBackground))]
		[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground&)}, ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 187
	}

	public InputDeviceDescription description
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 49
	}

	public int deviceId
	{
		[CalledBy(Type = typeof(InputManager), Member = "AssignUniqueDeviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 7
	}

	internal bool disabledInFrontend
	{
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
		[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal set { } //Length: 31
	}

	internal bool disabledInRuntime
	{
		[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 14
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 33
	}

	internal bool disabledWhileInBackground
	{
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 14
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 33
	}

	public bool enabled
	{
		[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(QueryEnabledStateCommand), Member = "Create", ReturnType = typeof(QueryEnabledStateCommand))]
		[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryEnabledStateCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryEnabledStateCommand&)}, ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 191
	}

	internal bool hasControlsWithDefaultState
	{
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 12
		[CalledBy(Type = typeof(FastMouse), Member = "Initialize_ctrlMousepressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(AxisControl))]
		[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreenpressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(AxisControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 3)]
		internal set { } //Length: 31
	}

	internal bool hasDontResetControls
	{
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 12
		[CallerCount(Count = 51)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 33
	}

	internal bool hasEventMerger
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 12
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 33
	}

	internal bool hasEventPreProcessor
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 12
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 33
	}

	internal bool hasStateCallbacks
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 11
		[CallerCount(Count = 0)]
		internal set { } //Length: 31
	}

	public double lastUpdateTime
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 70
	}

	public bool native
	{
		[CalledBy(Type = typeof(Mouse), Member = "OnAdded", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 get { } //Length: 12
	}

	public bool remote
	{
		[CalledBy(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 12
	}

	public bool updateBeforeRender
	{
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 get { } //Length: 10
	}

	public virtual int valueSizeInBytes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
		 get { } //Length: 74
	}

	public virtual Type valueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	public bool wasUpdatedThisFrame
	{
		[CalledBy(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ButtonControl), Member = "get_wasReleasedThisFrame", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 68
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputDevice() { }

	[CalledBy(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), "TValue", typeof(int)}, ReturnType = typeof(int))]
	internal void AddDeviceUsage(InternedString usage) { }

	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(int), typeof(string), typeof(InputDeviceDescription), typeof(DeviceFlags), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(RefInstance), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "Finish", ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "get_instance", ReturnType = typeof(InputDeviceBuilder&))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "Ref", ReturnType = typeof(RefInstance))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 32)]
	[DeduplicatedMethod]
	internal static TDevice Build(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = null, bool noPrecompiledLayouts = false) { }

	[CalledBy(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void ClearDeviceUsages() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[CallerCount(Count = 0)]
	internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize) { }

	[CalledBy(Type = typeof(InputDevice), Member = "DumpControlTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(uint), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	private void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<String> output) { }

	[CalledBy(Type = typeof(InputDevice), Member = "DumpControlTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(uint), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "DumpControlTree", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputDevice), Member = "DumpControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ControlBitRangeNode), typeof(uint), typeof(uint), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "DumpControlTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(uint), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<String> output) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "DumpControlTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(uint), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal string DumpControlTree() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override long ExecuteCommand(InputDeviceCommand* commandPtr) { }

	[CalledBy(Type = typeof(InputDevice), Member = "ExecuteDisableCommand", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TDelegate")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "UnlockForChanges", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public long ExecuteCommand(ref TCommand command) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DisableDeviceCommand), Member = "Create", ReturnType = typeof(DisableDeviceCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand&"}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	internal bool ExecuteDisableCommand() { }

	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EnableDeviceCommand), Member = "Create", ReturnType = typeof(EnableDeviceCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EnableDeviceCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EnableDeviceCommand&)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	internal bool ExecuteEnableCommand() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "AddChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator), typeof(bool)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CalledBy(Type = typeof(InputAction), Member = "ActiveControlIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "PurgeStalePointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "CheckForRemovedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "StartRecording", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public bool get_added() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CallsUnknownMethods(Count = 1)]
	public static ReadOnlyArray<InputDevice> get_all() { }

	[CalledBy(Type = typeof(InputManager), Member = "get_metrics", ReturnType = typeof(InputMetrics))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Finish", ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<InputControl> get_allControls() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(QueryCanRunInBackground), Member = "Create", ReturnType = typeof(QueryCanRunInBackground))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_canDeviceRunInBackground() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(QueryCanRunInBackground), Member = "Create", ReturnType = typeof(QueryCanRunInBackground))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryCanRunInBackground&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_canRunInBackground() { }

	[CallerCount(Count = 0)]
	public InputDeviceDescription get_description() { }

	[CalledBy(Type = typeof(InputManager), Member = "AssignUniqueDeviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public int get_deviceId() { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal bool get_disabledInFrontend() { }

	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal bool get_disabledInRuntime() { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal bool get_disabledWhileInBackground() { }

	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(QueryEnabledStateCommand), Member = "Create", ReturnType = typeof(QueryEnabledStateCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryEnabledStateCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryEnabledStateCommand&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public bool get_enabled() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal bool get_hasControlsWithDefaultState() { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal bool get_hasDontResetControls() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal bool get_hasEventMerger() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal bool get_hasEventPreProcessor() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal bool get_hasStateCallbacks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double get_lastUpdateTime() { }

	[CalledBy(Type = typeof(Mouse), Member = "OnAdded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public bool get_native() { }

	[CalledBy(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public bool get_remote() { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public bool get_updateBeforeRender() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	public virtual int get_valueSizeInBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_valueType() { }

	[CalledBy(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonControl), Member = "get_wasReleasedThisFrame", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_wasUpdatedThisFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint)}, ReturnType = typeof(bool))]
	private static bool HasDataChangedInRange(Byte* deviceStatePtr, Void* statePtr, uint startOffset, uint sizeInBits) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void MakeCurrent() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void NotifyAdded() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void NotifyConfigurationChanged() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void NotifyRemoved() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnAdded() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnConfigurationChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRemoved() { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryEnabledStateCommand), Member = "Create", ReturnType = typeof(QueryEnabledStateCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryEnabledStateCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryEnabledStateCommand&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	internal bool QueryEnabledStateFromRuntime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual object ReadValueFromStateAsObject(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public virtual void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	[CalledBy(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	internal void RemoveDeviceUsage(InternedString usage) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RequestResetCommand), Member = "Create", ReturnType = typeof(RequestResetCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestResetCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestResetCommand&)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	internal bool RequestReset() { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RequestSyncCommand), Member = "Create", ReturnType = typeof(RequestSyncCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestSyncCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestSyncCommand&)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	internal bool RequestSync() { }

	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void set_disabledInFrontend(bool value) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal void set_disabledInRuntime(bool value) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal void set_disabledWhileInBackground(bool value) { }

	[CalledBy(Type = typeof(FastMouse), Member = "Initialize_ctrlMousepressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(AxisControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreenpressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(AxisControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 3)]
	internal void set_hasControlsWithDefaultState(bool value) { }

	[CallerCount(Count = 51)]
	[ContainsUnimplementedInstructions]
	internal void set_hasDontResetControls(bool value) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_hasEventMerger(bool value) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_hasEventPreProcessor(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_hasStateCallbacks(bool value) { }

	[CalledBy(Type = typeof(InputManager), Member = "WriteStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(int), typeof(InputStateBlock&), typeof(uint), typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "WriteChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "WritePartialChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteChangedControlStates(Byte* deviceStateBuffer, Void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice) { }

	[CalledBy(Type = typeof(InputDevice), Member = "WriteChangedControlStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "WriteChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "WriteChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void WriteChangedControlStatesInternal(Void* statePtr, Byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset) { }

	[CalledBy(Type = typeof(InputDevice), Member = "WriteChangedControlStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "WritePartialChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputDevice), Member = "WritePartialChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset) { }

}

