namespace UnityEngine.EventSystems;

public class PointerEventData : BaseEventData
{
	internal enum FramePressState
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3,
	}

	internal enum InputButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}

	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; //Field offset: 0x20
	private GameObject m_PointerPress; //Field offset: 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; //Field offset: 0xA0
	public List<GameObject> hovered; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private int <pointerId>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; //Field offset: 0x10C
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private float <clickTime>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private int <clickCount>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private bool <dragging>k__BackingField; //Field offset: 0x145
	[CompilerGenerated]
	private InputButton <button>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private float <pressure>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private float <twist>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; //Field offset: 0x16C
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x174
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; //Field offset: 0x17C
	[CompilerGenerated]
	private bool <reentered>k__BackingField; //Field offset: 0x17D

	public float altitudeAngle
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float azimuthAngle
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public InputButton button
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

	public int clickCount
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float clickTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public Vector2 delta
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int displayIndex
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool dragging
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool eligibleForClick
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public Camera enterEventCamera
	{
		[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 143
	}

	public bool fullyExited
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private GameObject lastPress
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public PenStatus penStatus
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public GameObject pointerClick
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public RaycastResult pointerCurrentRaycast
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 49
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 56
	}

	public GameObject pointerDrag
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public GameObject pointerEnter
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int pointerId
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

	public GameObject pointerPress
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", "UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "RemovePointerAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputSystem.UI.PointerModel+ButtonState", Member = "CopyPressStateTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointerInputModule), Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseButtonEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 141
	}

	public RaycastResult pointerPressRaycast
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 58
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 68
	}

	public Vector2 position
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Camera pressEventCamera
	{
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnResizeStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnDragStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField+<MouseDragOutsideRect>d__314", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 149
	}

	public Vector2 pressPosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float pressure
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public Vector2 radius
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Vector2 radiusVariance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public GameObject rawPointerPress
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool reentered
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Vector2 scrollDelta
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float tangentialPressure
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public Vector2 tilt
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float twist
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public bool useDragThreshold
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 22
	}

	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 22
	}

	[CalledBy(Type = "Manager.Hotkey", Member = "SimulateClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "SimulateHover", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "SimulateUnhover", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "SimulateTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "SimulateClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.ExtendedPointerEventData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "AllocatePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), "UnityEngine.InputSystem.UI.UIPointerType", "UnityEngine.InputSystem.InputControl", "UnityEngine.InputSystem.InputDevice", "UnityEngine.InputSystem.InputControl"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public PointerEventData(EventSystem eventSystem) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_altitudeAngle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_azimuthAngle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public InputButton get_button() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_clickCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_clickTime() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_delta() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public int get_displayIndex() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_dragging() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_eligibleForClick() { }

	[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "ClickRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Camera get_enterEventCamera() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_fullyExited() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameObject get_lastPress() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public PenStatus get_penStatus() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameObject get_pointerClick() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public RaycastResult get_pointerCurrentRaycast() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameObject get_pointerDrag() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameObject get_pointerEnter() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_pointerId() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public GameObject get_pointerPress() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public RaycastResult get_pointerPressRaycast() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_position() { }

	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField+<MouseDragOutsideRect>d__314", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnDragStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserMovement", Member = "OnResizeStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Camera get_pressEventCamera() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_pressPosition() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_pressure() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_radius() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_radiusVariance() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameObject get_rawPointerPress() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_reentered() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_scrollDelta() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_tangentialPressure() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_tilt() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_twist() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_useDragThreshold() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector3 get_worldNormal() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector3 get_worldPosition() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", "UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsPointerMoving() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsScrolling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_altitudeAngle(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_azimuthAngle(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_button(InputButton value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_clickCount(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_clickTime(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_delta(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_displayIndex(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_dragging(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_eligibleForClick(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_fullyExited(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lastPress(GameObject value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_penStatus(PenStatus value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_pointerClick(GameObject value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_pointerDrag(GameObject value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_pointerEnter(GameObject value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_pointerId(int value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", "UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "RemovePointerAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.PointerModel+ButtonState", Member = "CopyPressStateTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseButtonEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_pointerPress(GameObject value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_position(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_pressPosition(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_pressure(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_radius(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_radiusVariance(Vector2 value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_rawPointerPress(GameObject value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_reentered(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_scrollDelta(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_tangentialPressure(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_tilt(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_twist(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_useDragThreshold(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_worldNormal(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_worldPosition(Vector3 value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.ExtendedPointerEventData", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public virtual string ToString() { }

}

