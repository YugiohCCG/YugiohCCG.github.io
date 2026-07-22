namespace UnityEngine.InputSystem.LowLevel;

[Extension]
public static class InputState
{
	private class StateChangeMonitorDelegate : IInputStateChangeMonitor
	{
		public Action<InputControl, Double, InputEventPtr, Int64> valueChangeCallback; //Field offset: 0x10
		public Action<InputControl, Double, Int64, Int32> timerExpiredCallback; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public StateChangeMonitorDelegate() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	}


	public static event Action<InputDevice, InputEventPtr> onChange
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "add_onDeviceStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 add { } //Length: 105
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "remove_onDeviceStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 remove { } //Length: 105
	}

	public static double currentTime
	{
		[CalledBy(Type = typeof(InputAction), Member = "GetTimeoutCompletionPercentage", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnAfterUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touchscreen), Member = "OnNextUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualMouseInput), Member = "UpdateMotion", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "UpdateTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TouchPhase), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 112
	}

	public static InputUpdateType currentUpdateType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 54
	}

	public static uint updateCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 53
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "add_onDeviceStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void add_onChange(Action<InputDevice, InputEventPtr> value) { }

	[CalledBy(Type = typeof(InputState), Member = "AddChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(System.Action`4<UnityEngine.InputSystem.InputControl, System.Double, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Int64>), typeof(int), typeof(System.Action`4<UnityEngine.InputSystem.InputControl, System.Double, System.Int64, System.Int32>)}, ReturnType = typeof(IInputStateChangeMonitor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1, uint groupIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputState), Member = "AddChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Action<InputControl, Double, InputEventPtr, Int64> valueChangeCallback, int monitorIndex = -1, Action<InputControl, Double, Int64, Int32> timerExpiredCallback = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "AddStateChangeMonitorTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(double), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1, int timerIndex = -1) { }

	[CalledBy(Type = typeof(Mouse), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pointer), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pointer), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SwitchProControllerHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShock4GamepadHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputManager), Member = "get_defaultUpdateType", ReturnType = typeof(InputUpdateType))]
	[Calls(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = 0) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnNextUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void Change(InputControl control, TState state, InputUpdateType updateType = 0, InputEventPtr eventPtr = null) { }

	[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InputManager), Member = "get_defaultUpdateType", ReturnType = typeof(InputUpdateType))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_internalTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public static void Change(InputControl control, ref TState state, InputUpdateType updateType = 0, InputEventPtr eventPtr = null) { }

	[CalledBy(Type = typeof(InputAction), Member = "GetTimeoutCompletionPercentage", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "OnAfterUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "OnNextUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "UpdateMotion", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "UpdateTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TouchPhase), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static double get_currentTime() { }

	[CallerCount(Count = 0)]
	public static InputUpdateType get_currentUpdateType() { }

	[CallerCount(Count = 0)]
	public static uint get_updateCount() { }

	[CalledBy(Type = typeof(DiscreteButtonControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchPressControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsIntegerFormat(FourCC format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "remove_onDeviceStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void remove_onChange(Action<InputDevice, InputEventPtr> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "RemoveStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "RemoveStateChangeMonitorTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputStateChangeMonitor), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1, int timerIndex = -1) { }

}

