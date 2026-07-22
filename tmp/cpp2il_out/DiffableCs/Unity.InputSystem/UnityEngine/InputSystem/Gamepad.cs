namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = True)]
public class Gamepad : InputDevice, IDualMotorRumble, IHaptics
{
	[CompilerGenerated]
	private static Gamepad <current>k__BackingField; //Field offset: 0x0
	private static int s_GamepadCount; //Field offset: 0x8
	private static Gamepad[] s_Gamepads; //Field offset: 0x10
	[CompilerGenerated]
	private ButtonControl <buttonWest>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <buttonNorth>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <buttonSouth>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <buttonEast>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <leftStickButton>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <rightStickButton>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private ButtonControl <startButton>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ButtonControl <selectButton>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private DpadControl <dpad>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private ButtonControl <leftShoulder>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private ButtonControl <rightShoulder>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private StickControl <leftStick>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private StickControl <rightStick>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private ButtonControl <leftTrigger>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private ButtonControl <rightTrigger>k__BackingField; //Field offset: 0x200
	private DualMotorRumble m_Rumble; //Field offset: 0x208

	public ButtonControl aButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public static ReadOnlyArray<Gamepad> all
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 109
	}

	public ButtonControl bButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ButtonControl buttonEast
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

	public ButtonControl buttonNorth
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

	public ButtonControl buttonSouth
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

	public ButtonControl buttonWest
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

	public ButtonControl circleButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ButtonControl crossButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public private static Gamepad current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public DpadControl dpad
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

	public ButtonControl Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(InvalidEnumArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 472
	}

	public ButtonControl leftShoulder
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

	public StickControl leftStick
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

	public ButtonControl leftStickButton
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

	public ButtonControl leftTrigger
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

	public ButtonControl rightShoulder
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

	public StickControl rightStick
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

	public ButtonControl rightStickButton
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

	public ButtonControl rightTrigger
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

	public ButtonControl selectButton
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

	public ButtonControl squareButton
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ButtonControl startButton
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

	public ButtonControl triangleButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ButtonControl xButton
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ButtonControl yButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Gamepad() { }

	[CalledBy(Type = typeof(XInputController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShockGamepad), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsUnknownMethods(Count = 15)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ButtonControl get_aButton() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ReadOnlyArray<Gamepad> get_all() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ButtonControl get_bButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_buttonEast() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_buttonNorth() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_buttonSouth() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_buttonWest() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ButtonControl get_circleButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ButtonControl get_crossButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Gamepad get_current() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DpadControl get_dpad() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InvalidEnumArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public ButtonControl get_Item(GamepadButton button) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_leftShoulder() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public StickControl get_leftStick() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_leftStickButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_leftTrigger() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_rightShoulder() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public StickControl get_rightStick() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_rightStickButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_rightTrigger() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_selectButton() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ButtonControl get_squareButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_startButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ButtonControl get_triangleButton() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ButtonControl get_xButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ButtonControl get_yButton() { }

	[CalledBy(Type = typeof(DualShockGamepad), Member = "MakeCurrent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MakeCurrent() { }

	[CalledBy(Type = typeof(SwitchProControllerHID), Member = "OnAdded", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	protected virtual void OnAdded() { }

	[CalledBy(Type = typeof(DualShockGamepad), Member = "OnRemoved", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualMotorRumble), Member = "PauseHaptics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	public override void PauseHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualMotorRumble), Member = "ResetHaptics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	public override void ResetHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualMotorRumble), Member = "ResumeHaptics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	public override void ResumeHaptics() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_buttonEast(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_buttonNorth(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_buttonSouth(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_buttonWest(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_current(Gamepad value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_dpad(DpadControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_leftShoulder(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_leftStick(StickControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_leftStickButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_leftTrigger(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_rightShoulder(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_rightStick(StickControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_rightStickButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_rightTrigger(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_selectButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_startButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualMotorRumble), Member = "SetMotorSpeeds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public override void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

}

