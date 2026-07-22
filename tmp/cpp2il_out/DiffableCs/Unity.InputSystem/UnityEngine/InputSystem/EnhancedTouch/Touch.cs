namespace UnityEngine.InputSystem.EnhancedTouch;

public struct Touch : IEquatable<Touch>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TypedRestore<GlobalState> <>9__80_0; //Field offset: 0x8
		public static Action <>9__80_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <SaveAndResetState>b__80_0(ref GlobalState state) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <SaveAndResetState>b__80_1() { }

	}

	public struct ExtraDataPerTouchState
	{
		public Vector2 accumulatedDelta; //Field offset: 0x0
		public uint uniqueId; //Field offset: 0x8

	}

	public struct FingerAndTouchState
	{
		public InputUpdateType updateMask; //Field offset: 0x0
		public Finger[] fingers; //Field offset: 0x8
		public Finger[] activeFingers; //Field offset: 0x10
		public Touch[] activeTouches; //Field offset: 0x18
		public int activeFingerCount; //Field offset: 0x20
		public int activeTouchCount; //Field offset: 0x24
		public int totalFingerCount; //Field offset: 0x28
		public uint lastId; //Field offset: 0x2C
		public bool haveBuiltActiveTouches; //Field offset: 0x30
		public bool haveActiveTouchesNeedingRefreshNextUpdate; //Field offset: 0x31
		public InputStateHistory<TouchState> activeTouchState; //Field offset: 0x38

		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touch), Member = "AddTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "EnsureCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public void AddFingers(Touchscreen screen) { }

		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputStateHistory), Member = "Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public void Destroy() { }

		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touch), Member = "RemoveTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputStateHistory), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseSliceWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void RemoveFingers(Touchscreen screen) { }

		[CalledBy(Type = typeof(Touch), Member = "get_activeFingers", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Finger>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
		[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public void UpdateActiveFingers() { }

		[CalledBy(Type = typeof(Touch), Member = "get_activeTouches", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Touch>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		[Calls(Type = typeof(ArrayHelpers), Member = "InsertAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), typeof(int), "TValue", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputStateHistory), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
		[Calls(Type = typeof(RecordHeader), Member = "get_statePtrWithControlIndex", ReturnType = typeof(Byte*))]
		[Calls(Type = typeof(InputStateHistory), Member = "AllocateRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InputExtensions), Member = "IsEndedOrCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchPhase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputStateHistory), Member = "get_bytesPerRecord", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecordUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "set_extraMemoryPerRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Clear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory), Member = "Clear", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public void UpdateActiveTouches() { }

	}

	public struct GlobalState
	{
		internal InlinedArray<Touchscreen> touchscreens; //Field offset: 0x0
		internal int historyLengthPerFinger; //Field offset: 0x18
		internal CallbackArray<Action`1<Finger>> onFingerDown; //Field offset: 0x20
		internal CallbackArray<Action`1<Finger>> onFingerMove; //Field offset: 0x70
		internal CallbackArray<Action`1<Finger>> onFingerUp; //Field offset: 0xC0
		internal FingerAndTouchState playerState; //Field offset: 0x110

	}

	internal static GlobalState s_GlobalState; //Field offset: 0x0
	private readonly Finger m_Finger; //Field offset: 0x0
	internal Record<TouchState> m_TouchRecord; //Field offset: 0x8

	public static event Action<Finger> onFingerDown
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 185
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 185
	}

	public static event Action<Finger> onFingerMove
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 185
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 185
	}

	public static event Action<Finger> onFingerUp
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 188
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 188
	}

	public static ReadOnlyArray<Finger> activeFingers
	{
		[CalledBy(Type = "Manager.Hotkey+<ReadKey>d__82", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Hotkey", Member = "get_TouchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "Manager.Hotkey", Member = "get_IsSingleTouching", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "get_IsTripleTouching", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(FingerAndTouchState), Member = "UpdateActiveFingers", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 164
	}

	public static ReadOnlyArray<Touch> activeTouches
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 164
	}

	public bool began
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 80
	}

	public Vector2 delta
	{
		[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 126
	}

	public int displayIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 112
	}

	public bool ended
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 124
	}

	private ExtraDataPerTouchState extraData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtr", ReturnType = typeof(Void*))]
		private get { } //Length: 58
	}

	public Finger finger
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public static ReadOnlyArray<Finger> fingers
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 136
	}

	public TouchHistory history
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 289
	}

	public bool inProgress
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 160
	}

	public bool isInProgress
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 96
	}

	public bool isTap
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 115
	}

	public static int maxHistoryLengthPerFinger
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public TouchPhase phase
	{
		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CalledBy(Type = typeof(Touch), Member = "get_began", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touch), Member = "get_inProgress", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touch), Member = "get_ended", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touch), Member = "get_isInProgress", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 112
	}

	public float pressure
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 113
	}

	public Vector2 radius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 126
	}

	public Touchscreen screen
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 81
	}

	public Vector2 screenPosition
	{
		[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 126
	}

	public static IEnumerable<Touchscreen> screens
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 123
	}

	public Vector2 startScreenPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 126
	}

	public double startTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 113
	}

	private TouchState state
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		private get { } //Length: 58
	}

	public int tapCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 112
	}

	public double time
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "get_time", ReturnType = typeof(double))]
		 get { } //Length: 58
	}

	public int touchId
	{
		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 110
	}

	internal uint uniqueId
	{
		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtr", ReturnType = typeof(Void*))]
		internal get { } //Length: 111
	}

	internal uint updateStepCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		internal get { } //Length: 111
	}

	public bool valid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
		 get { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Touch() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal Touch(Finger finger, Record<TouchState> touchRecord) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onFingerDown(Action<Finger> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onFingerMove(Action<Finger> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onFingerUp(Action<Finger> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FingerAndTouchState), Member = "AddFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	internal static void AddTouchscreen(Touchscreen screen) { }

	[CallerCount(Count = 0)]
	internal static void BeginUpdate() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static GlobalState CreateGlobalState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Touch other) { }

	[CalledBy(Type = "Manager.Hotkey+<ReadKey>d__82", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "get_TouchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "Manager.Hotkey", Member = "get_IsSingleTouching", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "get_IsTripleTouching", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(FingerAndTouchState), Member = "UpdateActiveFingers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ReadOnlyArray<Finger> get_activeFingers() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ReadOnlyArray<Touch> get_activeTouches() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[ContainsUnimplementedInstructions]
	public bool get_began() { }

	[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public Vector2 get_delta() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public int get_displayIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[ContainsUnimplementedInstructions]
	public bool get_ended() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtr", ReturnType = typeof(Void*))]
	private ExtraDataPerTouchState get_extraData() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Finger get_finger() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ReadOnlyArray<Finger> get_fingers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public TouchHistory get_history() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[ContainsUnimplementedInstructions]
	public bool get_inProgress() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[ContainsUnimplementedInstructions]
	public bool get_isInProgress() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	[ContainsUnimplementedInstructions]
	public bool get_isTap() { }

	[CallerCount(Count = 0)]
	public static int get_maxHistoryLengthPerFinger() { }

	[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
	[CalledBy(Type = typeof(Touch), Member = "get_began", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touch), Member = "get_inProgress", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touch), Member = "get_ended", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touch), Member = "get_isInProgress", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public TouchPhase get_phase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public float get_pressure() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public Vector2 get_radius() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Touchscreen get_screen() { }

	[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public Vector2 get_screenPosition() { }

	[CallerCount(Count = 0)]
	public static IEnumerable<Touchscreen> get_screens() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public Vector2 get_startScreenPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public double get_startTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	private TouchState get_state() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public int get_tapCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "get_time", ReturnType = typeof(double))]
	public double get_time() { }

	[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
	[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public int get_touchId() { }

	[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtr", ReturnType = typeof(Void*))]
	internal uint get_uniqueId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	internal uint get_updateStepCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	public bool get_valid() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onFingerDown(Action<Finger> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onFingerMove(Action<Finger> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onFingerUp(Action<Finger> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FingerAndTouchState), Member = "RemoveFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	internal static void RemoveTouchscreen(Touchscreen screen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.SavedStructState`1<UnityEngine.InputSystem.EnhancedTouch.Touch+GlobalState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalState&), typeof(UnityEngine.InputSystem.Utilities.SavedStructState`1+TypedRestore<UnityEngine.InputSystem.EnhancedTouch.Touch+GlobalState>), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static ISavedState SaveAndResetState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Touch), Member = "get_touchId", ReturnType = typeof(int))]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(Touch), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Touch), Member = "get_delta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Record), Member = "get_time", ReturnType = typeof(double))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 26)]
	public virtual string ToString() { }

}

