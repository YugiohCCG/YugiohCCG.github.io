namespace UnityEngine.InputSystem.OnScreen;

public abstract class OnScreenControl : MonoBehaviour
{
	private struct OnScreenDeviceInfo
	{
		public InputEventPtr eventPtr; //Field offset: 0x0
		public NativeArray<Byte> buffer; //Field offset: 0x8
		public InputDevice device; //Field offset: 0x18
		public OnScreenControl firstControl; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public OnScreenDeviceInfo AddControl(OnScreenControl control) { }

		[CalledBy(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenControl), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Destroy() { }

		[CalledBy(Type = typeof(OnScreenControl), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		public OnScreenDeviceInfo RemoveControl(OnScreenControl control) { }

	}

	private static int s_nbActiveInstances; //Field offset: 0x0
	private static InlinedArray<OnScreenDeviceInfo> s_OnScreenDevices; //Field offset: 0x8
	private InputControl m_Control; //Field offset: 0x20
	private OnScreenControl m_NextControlOnDevice; //Field offset: 0x28
	private InputEventPtr m_InputEventPtr; //Field offset: 0x30

	public InputControl control
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string controlPath
	{
		[CallerCount(Count = 51)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 60
	}

	protected abstract string controlPathInternal
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal static bool HasAnyActive
	{
		[CalledBy(Type = typeof(PlayerInput), Member = "OnPreFilterUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 57
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected OnScreenControl() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public InputControl get_control() { }

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_controlPath() { }

	protected abstract string get_controlPathInternal() { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnPreFilterUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool get_HasAnyActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal string GetWarningMessage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(OnScreenDeviceInfo), Member = "RemoveControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnScreenControl)}, ReturnType = typeof(OnScreenDeviceInfo))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.OnScreen.OnScreenControl+OnScreenDeviceInfo>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OnScreenDeviceInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OnScreenControl), Member = "SentDefaultValueToControl", ReturnType = typeof(void))]
	[Calls(Type = typeof(OnScreenDeviceInfo), Member = "Destroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.OnScreen.OnScreenControl+OnScreenDeviceInfo>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerInput), Member = "get_isSinglePlayer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerInput), Member = "GetPlayerByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PlayerInput))]
	[Calls(Type = typeof(PlayerInput), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(PlayerInput), Member = "SwitchCurrentControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnEnable() { }

	[CalledBy(Type = typeof(OnScreenButton), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenButton), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputEventPtr), Member = "set_internalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlExtensions), Member = "WriteValueIntoEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	[DeduplicatedMethod]
	protected void SendValueToControl(TValue value) { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputEventPtr), Member = "set_internalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlExtensions), Member = "ResetToDefaultStateInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void SentDefaultValueToControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_controlPath(string value) { }

	protected abstract void set_controlPathInternal(string value) { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "set_controlPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.OnScreen.OnScreenControl+OnScreenDeviceInfo>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OnScreenDeviceInfo), Member = "Destroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.OnScreen.OnScreenControl+OnScreenDeviceInfo>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(OnScreenDeviceInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.OnScreen.OnScreenControl+OnScreenDeviceInfo>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnScreenDeviceInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[Calls(Type = typeof(InputSystem), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlPath), Member = "TryGetDeviceLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 28)]
	private void SetupInputControl() { }

}

