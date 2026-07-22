namespace UnityEngine.InputSystem.UI;

public class ExtendedPointerEventData : PointerEventData
{
	[CompilerGenerated]
	private InputControl <control>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private int <touchId>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private UIPointerType <pointerType>k__BackingField; //Field offset: 0x194
	[CompilerGenerated]
	private int <uiToolkitPointerId>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private Vector3 <trackedDevicePosition>k__BackingField; //Field offset: 0x19C
	[CompilerGenerated]
	private Quaternion <trackedDeviceOrientation>k__BackingField; //Field offset: 0x1A8

	public InputControl control
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public InputDevice device
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public UIPointerType pointerType
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int touchId
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Quaternion trackedDeviceOrientation
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public Vector3 trackedDevicePosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public int uiToolkitPointerId
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	public ExtendedPointerEventData(EventSystem eventSystem) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public InputControl get_control() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public InputDevice get_device() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public UIPointerType get_pointerType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public int get_touchId() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Quaternion get_trackedDeviceOrientation() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector3 get_trackedDevicePosition() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_uiToolkitPointerId() { }

	[CalledBy(Type = typeof(ExtendedPointerEventData), Member = "ReadDeviceState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetPenPointerId(Pen pen) { }

	[CalledBy(Type = typeof(ExtendedPointerEventData), Member = "ReadDeviceState", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static int GetTouchPointerId(TouchControl touchControl) { }

	[CallerCount(Count = 0)]
	internal static int MakePointerIdForTouch(int deviceId, int touchId) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "FilterPointerStatesByType", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExtendedPointerEventData), Member = "GetPenPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pen)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "get_value", ReturnType = typeof(Vector2&))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExtendedPointerEventData), Member = "GetTouchPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchControl)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReadDeviceState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_control(InputControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_device(InputDevice value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_pointerType(UIPointerType value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_touchId(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_trackedDeviceOrientation(Quaternion value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_trackedDevicePosition(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_uiToolkitPointerId(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual string ToString() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal static int TouchIdFromPointerId(int pointerId) { }

}

