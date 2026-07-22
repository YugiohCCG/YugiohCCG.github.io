namespace UnityEngine.InputSystem;

public static class InputSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<InputEventPtr, InputControl> <>9__80_0; //Field offset: 0x8
		public static Func<InputControl, Boolean> <>9__80_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
		internal InputControl <get_onAnyButtonPress>b__80_0(InputEventPtr e) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_onAnyButtonPress>b__80_1(InputControl c) { }

	}

	private struct DeltaStateEventBuffer
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <data>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		public const int kMaxSize = 512; //Field offset: 0x0
		public DeltaStateEvent stateEvent; //Field offset: 0x0
		[FixedBuffer(typeof(byte), 511)]
		public <data>e__FixedBuffer data; //Field offset: 0x1D

	}

	private struct StateEventBuffer
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <data>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		public const int kMaxSize = 512; //Field offset: 0x0
		public StateEvent stateEvent; //Field offset: 0x0
		[FixedBuffer(typeof(byte), 511)]
		public <data>e__FixedBuffer data; //Field offset: 0x19

	}

	internal const string kAssemblyVersion = "1.19.0"; //Field offset: 0x0
	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19"; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputResetMarker; //Field offset: 0x0
	internal static InputManager s_Manager; //Field offset: 0x8
	internal static InputRemoting s_Remote; //Field offset: 0x10

	public static event Action<Object, InputActionChange> onActionChange
	{
		[CalledBy(Type = typeof(InputUser), Member = "AssociateActionsWithUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "HookIntoActionChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "HookOnActionChange", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 185
		[CalledBy(Type = typeof(InputUser), Member = "UnhookFromActionChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "UnhookOnActionChange", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 185
	}

	public static event Action onActionsChange
	{
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputManager), Member = "add_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 add { } //Length: 105
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Shutdown", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputManager), Member = "remove_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 remove { } //Length: 105
	}

	public static event Action onAfterUpdate
	{
		[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "HookOnAfterUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 add { } //Length: 276
		[CalledBy(Type = typeof(RebindingOperation), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "UnhookOnAfterUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 remove { } //Length: 276
	}

	public static event Action onBeforeUpdate
	{
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "PlayAllFramesOneByOne", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "PlayAllEventsAccordingToTimestamps", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "set_recordFrameMarkers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "Enable", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 add { } //Length: 276
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "Finished", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "set_recordFrameMarkers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "Disable", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 remove { } //Length: 276
	}

	public static event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "StartListeningForDeviceChanges", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "HookIntoDeviceChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 add { } //Length: 358
		[CalledBy(Type = typeof(PlayerInput), Member = "StopListeningForDeviceChanges", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "UnhookFromDeviceChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 remove { } //Length: 358
	}

	public static event InputDeviceCommandDelegate onDeviceCommand
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "add_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 add { } //Length: 358
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 remove { } //Length: 358
	}

	public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice
	{
		[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HIDSupport), Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "add_onFindControlLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 add { } //Length: 276
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onFindControlLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 remove { } //Length: 276
	}

	public static event Action<String, InputControlLayoutChange> onLayoutChange
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "add_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 add { } //Length: 276
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 remove { } //Length: 276
	}

	public static event Action onSettingsChange
	{
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputManager), Member = "add_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 add { } //Length: 105
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputManager), Member = "remove_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 remove { } //Length: 105
	}

	public static InputActionAsset actions
	{
		[CalledBy(Type = typeof(InputSystem), Member = "EnableActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "SelectInputActionAsset", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputManager), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 338
	}

	public static ReadOnlyArray<InputDevice> devices
	{
		[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
		[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ExtendedPointerEventData), Member = "GetPenPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pen)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "SetUpState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "TearDownState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	public static ReadOnlyArray<InputDevice> disconnectedDevices
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 154
	}

	internal static bool isProcessingEvents
	{
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "IsPointerOverGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputManager), Member = "get_isProcessingEvents", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 95
	}

	public static InputMetrics metrics
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "get_metrics", ReturnType = typeof(InputMetrics))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 143
	}

	public static IObservable<InputControl> onAnyButtonPress
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Observable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IObservable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.IObservable`1<TResult>")]
		[Calls(Type = typeof(Observable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IObservable`1<TValue>", "System.Func`2<TValue, Boolean>"}, ReturnType = "System.IObservable`1<TValue>")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 559
	}

	public static InputEventListener onEvent
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public static float pollingFrequency
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "set_pollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 112
	}

	public static InputRemoting remoting
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static bool runInBackground
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 129
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 257
	}

	internal static float scrollWheelDeltaPerTick
	{
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnScrollCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 213
	}

	public static InputSettings settings
	{
		[CallerCount(Count = 40)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputManager), Member = "set_settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 345
	}

	public static Version version
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 get { } //Length: 88
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	private static InputSystem() { }

	[CalledBy(Type = typeof(InputUser), Member = "AssociateActionsWithUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputActionCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "HookIntoActionChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "HookOnActionChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void add_onActionChange(Action<Object, InputActionChange> value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "add_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void add_onActionsChange(Action value) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "HookOnAfterUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void add_onAfterUpdate(Action value) { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "PlayAllFramesOneByOne", ReturnType = typeof(ReplayController))]
	[CalledBy(Type = typeof(ReplayController), Member = "PlayAllEventsAccordingToTimestamps", ReturnType = typeof(ReplayController))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "set_recordFrameMarkers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "Enable", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void add_onBeforeUpdate(Action value) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "StartListeningForDeviceChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "HookIntoDeviceChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HIDSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onFindControlLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void add_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "add_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void add_onSettingsChange(Action value) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void AddDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceDescription), Member = "get_empty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static InputDevice AddDevice(InputDeviceDescription description) { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputSystem), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public static TDevice AddDevice(string name = null) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static InputDevice AddDevice(string layout, string name = null, string variants = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void AddDeviceUsage(InputDevice device, string usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void DisableActions(bool triggerSetupChanged = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "DisableAllActions", ReturnType = typeof(void))]
	public static void DisableAllEnabledActions() { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "AddPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void DisableDevice(InputDevice device, bool keepSendingEvents = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "get_actions", ReturnType = typeof(InputActionAsset))]
	[Calls(Type = typeof(InputActionAsset), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void EnableActions() { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_cursorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void EnableDevice(InputDevice device) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void EnsureInitialized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static InputControl FindControl(string path) { }

	[CalledBy(Type = typeof(InputStateHistory), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystem), Member = "FindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputControlList`1<TControl>")]
	public static InputControlList<InputControl> FindControls(string path) { }

	[CalledBy(Type = typeof(InputSystem), Member = "FindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static InputControlList<TControl> FindControls(string path) { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static int FindControls(string path, ref InputControlList<TControl>& controls) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "FlushDisconnectedDevices", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void FlushDisconnectedDevices() { }

	[CalledBy(Type = typeof(InputSystem), Member = "EnableActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "SelectInputActionAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public static InputActionAsset get_actions() { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ExtendedPointerEventData), Member = "GetPenPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pen)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "SetUpState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "TearDownState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CallsUnknownMethods(Count = 1)]
	public static ReadOnlyArray<InputDevice> get_devices() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ReadOnlyArray<InputDevice> get_disconnectedDevices() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "IsPointerOverGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "get_isProcessingEvents", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool get_isProcessingEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "get_metrics", ReturnType = typeof(InputMetrics))]
	[CallsUnknownMethods(Count = 1)]
	public static InputMetrics get_metrics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Observable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IObservable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.IObservable`1<TResult>")]
	[Calls(Type = typeof(Observable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IObservable`1<TValue>", "System.Func`2<TValue, Boolean>"}, ReturnType = "System.IObservable`1<TValue>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static IObservable<InputControl> get_onAnyButtonPress() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static InputEventListener get_onEvent() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float get_pollingFrequency() { }

	[CallerCount(Count = 0)]
	public static InputRemoting get_remoting() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_runInBackground() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnScrollCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static float get_scrollWheelDeltaPerTick() { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 1)]
	public static InputSettings get_settings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static Version get_version() { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[CallsUnknownMethods(Count = 1)]
	public static InputDevice GetDevice(string nameOrLayout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputDevice))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static TDevice GetDevice() { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static InputDevice GetDevice(Type type) { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(XRController), Member = "get_leftHand", ReturnType = typeof(XRController))]
	[CalledBy(Type = typeof(XRController), Member = "get_rightHand", ReturnType = typeof(XRController))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static TDevice GetDevice(InternedString usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static TDevice GetDevice(string usage) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.ForDeviceEventObservable+ForDevice", Member = "OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[CallsUnknownMethods(Count = 1)]
	public static InputDevice GetDeviceById(int deviceId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string GetNameOfBaseLayout(string layoutName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetUnsupportedDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputDeviceDescription>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static List<InputDeviceDescription> GetUnsupportedDevices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetUnsupportedDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputDeviceDescription>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	[CalledBy(Type = typeof(InputSystem), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RunInitializeInPlayer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionAsset), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_actions", ReturnType = typeof(InputActionAsset))]
	[Calls(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(SwitchSupportHID), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(HIDSupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(UISupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XInputSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "IsBasedOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "FindAllEnabledActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputAction>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static int ListEnabledActions(List<InputAction> actions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "FindAllEnabledActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputAction>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static List<InputAction> ListEnabledActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeTable), Member = "get_names", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<String> ListInteractions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ListControlLayouts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<String> ListLayouts() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ListControlLayouts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static IEnumerable<String> ListLayoutsBasedOn(string baseLayout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeTable), Member = "get_names", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<String> ListProcessors() { }

	[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "TryLoadControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static InputControlLayout LoadLayout(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputManager), Member = "TryLoadControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputControlLayout))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static InputControlLayout LoadLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static void PauseHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XInputSupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(HIDSupport), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(SwitchSupportHID), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	private static void PerformDefaultPluginInitialization() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeviceConfigurationEvent), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double)}, ReturnType = typeof(DeviceConfigurationEvent))]
	[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static void QueueConfigChangeEvent(InputDevice device, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 46)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static void QueueDeltaStateEvent(InputControl control, TDelta delta, double time = -1) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "QueueValueChange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SendValueToControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SentDefaultValueToControl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void QueueEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void QueueEvent(ref TEvent inputEvent) { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "UpdateTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TouchPhase), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchState), Member = "get_format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static void QueueStateEvent(InputDevice device, TState state, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEvent), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(double)}, ReturnType = typeof(TextEvent))]
	[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static void QueueTextEvent(InputDevice device, char character, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void RegisterBindingComposite(string name = null) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterBindingComposite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeTable), Member = "AddTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void RegisterBindingComposite(Type type, string name) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterInteraction", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeTable), Member = "AddTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void RegisterInteraction(Type type, string name = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void RegisterInteraction(string name = null) { }

	[CalledBy(Type = typeof(UISupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterLayout(string json, string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void RegisterLayout(Type type, string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XInputSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SwitchSupportHID), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HIDSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void RegisterLayout(string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	[CalledBy(Type = typeof(XRLayoutBuilder), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, Nullable<InputDeviceMatcher> matches = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	[CalledBy(Type = typeof(SwitchSupportHID), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShockSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterLayoutOverride(string json, string name = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "RegisterPrecompiledLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void RegisterPrecompiledLayout(string metadata) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void RegisterProcessor(string name = null) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterProcessor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Utilities.InternedString>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(StringHelpers), Member = "CharacterSeparatedListsHaveAtLeastOneCommonElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTable), Member = "AddTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public static void RegisterProcessor(Type type, string name = null) { }

	[CalledBy(Type = typeof(InputUser), Member = "UnhookFromActionChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnhookOnActionChange", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void remove_onActionChange(Action<Object, InputActionChange> value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "remove_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void remove_onActionsChange(Action value) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "UnhookOnAfterUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void remove_onAfterUpdate(Action value) { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "Finished", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "set_recordFrameMarkers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "Disable", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void remove_onBeforeUpdate(Action value) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "StopListeningForDeviceChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnhookFromDeviceChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onFindControlLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void remove_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "remove_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void remove_onSettingsChange(Action value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenControl+OnScreenDeviceInfo", Member = "Destroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "RemoveControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveLayout(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static void ResetHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static void ResumeHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void RunInitializeInPlayer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void RunInitialUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void set_actions(InputActionAsset value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void set_onEvent(InputEventListener value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "set_pollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_pollingFrequency(float value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_runInBackground(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "set_settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void set_settings(InputSettings value) { }

	[CalledBy(Type = typeof(XRController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetDeviceUsage(InputDevice device, string usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static Type TryGetBindingComposite(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static Type TryGetInteraction(string name) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static Type TryGetProcessor(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RequestResetCommand), Member = "Create", ReturnType = typeof(RequestResetCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestResetCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestResetCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Obsolete("Use 'ResetDevice' instead.", False)]
	public static bool TryResetDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RequestSyncCommand), Member = "Create", ReturnType = typeof(RequestSyncCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestSyncCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestSyncCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static bool TrySyncDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "Update", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal static void Update(InputUpdateType updateType) { }

}

