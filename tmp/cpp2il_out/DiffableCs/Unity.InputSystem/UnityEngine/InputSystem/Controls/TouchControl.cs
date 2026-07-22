namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(stateType = typeof(TouchState))]
public class TouchControl : InputControl<TouchState>
{
	[CompilerGenerated]
	private TouchPressControl <press>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private IntegerControl <displayIndex>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private IntegerControl <touchId>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private Vector2Control <position>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private DeltaControl <delta>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private AxisControl <pressure>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private Vector2Control <radius>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private TouchPhaseControl <phase>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <indirectTouch>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <tap>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private IntegerControl <tapCount>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private DoubleControl <startTime>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private Vector2Control <startPosition>k__BackingField; //Field offset: 0x1D0

	public DeltaControl delta
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public IntegerControl displayIndex
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

	public ButtonControl indirectTouch
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

	public bool isInProgress
	{
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32Enum>), Member = "get_value", ReturnType = typeof(Int32Enum&))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 96
	}

	public TouchPhaseControl phase
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

	public Vector2Control position
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

	public TouchPressControl press
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

	public AxisControl pressure
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

	public Vector2Control radius
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

	public Vector2Control startPosition
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

	public DoubleControl startTime
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ButtonControl tap
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

	public IntegerControl tapCount
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

	public IntegerControl touchId
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

	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreenprimaryTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchControl))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	public TouchControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.InputSystem.LowLevel.TouchState>), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DeltaControl get_delta() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_displayIndex() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_indirectTouch() { }

	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32Enum>), Member = "get_value", ReturnType = typeof(Int32Enum&))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isInProgress() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TouchPhaseControl get_phase() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Control get_position() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TouchPressControl get_press() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AxisControl get_pressure() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Control get_radius() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Control get_startPosition() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DoubleControl get_startTime() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_tap() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_tapCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_touchId() { }

	[CallerCount(Count = 0)]
	public virtual TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_delta(DeltaControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_displayIndex(IntegerControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_indirectTouch(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_phase(TouchPhaseControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_position(Vector2Control value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_press(TouchPressControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_pressure(AxisControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_radius(Vector2Control value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_startPosition(Vector2Control value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_startTime(DoubleControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_tap(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_tapCount(IntegerControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_touchId(IntegerControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public virtual void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

