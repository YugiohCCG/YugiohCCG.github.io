namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(displayName = "PlayStation Controller")]
public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics
{
	[CompilerGenerated]
	private static DualShockGamepad <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ButtonControl <touchpadButton>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private ButtonControl <optionsButton>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	private ButtonControl <shareButton>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private ButtonControl <L1>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private ButtonControl <R1>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	private ButtonControl <L2>k__BackingField; //Field offset: 0x238
	[CompilerGenerated]
	private ButtonControl <R2>k__BackingField; //Field offset: 0x240
	[CompilerGenerated]
	private ButtonControl <L3>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	private ButtonControl <R3>k__BackingField; //Field offset: 0x250
	[CompilerGenerated]
	private HIDDeviceDescriptor <hidDescriptor>k__BackingField; //Field offset: 0x258

	public private static DualShockGamepad current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	internal HIDDeviceDescriptor hidDescriptor
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 36
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 46
	}

	[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
	public ButtonControl L1
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

	[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
	public ButtonControl L2
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

	[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
	public ButtonControl L3
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

	[InputControl(name = "start", displayName = "Options")]
	public ButtonControl optionsButton
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

	[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
	public ButtonControl R1
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

	[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
	public ButtonControl R2
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

	[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
	public ButtonControl R3
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

	[InputControl(name = "select", displayName = "Share")]
	public ButtonControl shareButton
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

	[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
	[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
	[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
	[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
	[InputControl]
	public ButtonControl touchpadButton
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

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DualShockGamepad() { }

	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShock4GamepadHID), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShock3GamepadHID), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Gamepad), Member = "FinishSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static DualShockGamepad get_current() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal HIDDeviceDescriptor get_hidDescriptor() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_L1() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_L2() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_L3() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_optionsButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_R1() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_R2() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_R3() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_shareButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_touchpadButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gamepad), Member = "MakeCurrent", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MakeCurrent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gamepad), Member = "OnRemoved", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_current(DualShockGamepad value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_hidDescriptor(HIDDeviceDescriptor value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_L1(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_L2(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_L3(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_optionsButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_R1(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_R2(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_R3(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_shareButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_touchpadButton(ButtonControl value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetLightBarColor(Color color) { }

}

