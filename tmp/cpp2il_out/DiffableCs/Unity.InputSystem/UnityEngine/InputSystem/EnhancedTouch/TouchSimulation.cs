namespace UnityEngine.InputSystem.EnhancedTouch;

[AddComponentMenu("Input/Debug/Touch Simulation")]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/Touch.html#touch-simulation")]
public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor
{
	internal static TouchSimulation s_Instance; //Field offset: 0x0
	[CompilerGenerated]
	private Touchscreen <simulatedTouchscreen>k__BackingField; //Field offset: 0x20
	private int m_NumPointers; //Field offset: 0x28
	private Pointer[] m_Pointers; //Field offset: 0x30
	private Vector2[] m_CurrentPositions; //Field offset: 0x38
	private Int32[] m_CurrentDisplayIndices; //Field offset: 0x40
	private ButtonControl[] m_Touches; //Field offset: 0x48
	private Int32[] m_TouchIds; //Field offset: 0x50
	private int m_LastTouchId; //Field offset: 0x58
	private Action<InputDevice, InputDeviceChange> m_OnDeviceChange; //Field offset: 0x60
	private Action<InputEventPtr, InputDevice> m_OnEvent; //Field offset: 0x68

	public static TouchSimulation instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 54
	}

	public private Touchscreen simulatedTouchscreen
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TouchSimulation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", typeof(int), "TSecond"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]&), typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputSystem), Member = "DisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected void AddPointer(Pointer pointer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TouchSimulation), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Destroy() { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "Destroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Disable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Enable() { }

	[CallerCount(Count = 0)]
	public static TouchSimulation get_instance() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Touchscreen get_simulatedTouchscreen() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected void InstallStateChangeMonitors(int startIndex = 0) { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TouchSimulation), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "ContainsReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", typeof(int), "TSecond"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]&), typeof(Vector2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputSystem), Member = "DisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "EnableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Clear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Clear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventListener), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputSystem), Member = "AddDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TDevice")]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(TouchSimulation), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	protected void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputControl`1), Member = "ReadValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = "TValue")]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TouchSimulation), Member = "UpdateTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TouchPhase), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[Calls(Type = typeof(InputEventControlCollection), Member = "GetEnumerator", ReturnType = typeof(InputEventControlEnumerator))]
	[Calls(Type = typeof(InputEventControlEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_isButton", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex) { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TouchSimulation), Member = "UpdateTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TouchPhase), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "EnableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	protected void RemovePointer(Pointer pointer) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_simulatedTouchscreen(Touchscreen value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected void UninstallStateChangeMonitors(int startIndex = 0) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputSystem), Member = "QueueStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState", typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputExtensions), Member = "IsEndedOrCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchPhase)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr = null) { }

}

