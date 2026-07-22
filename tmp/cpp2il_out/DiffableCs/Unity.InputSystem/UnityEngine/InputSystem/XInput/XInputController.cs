namespace UnityEngine.InputSystem.XInput;

[InputControlLayout(displayName = "Xbox Controller")]
public class XInputController : Gamepad
{
	public struct Capabilities
	{
		public DeviceType type; //Field offset: 0x0
		public DeviceSubType subType; //Field offset: 0x4
		public DeviceFlags flags; //Field offset: 0x8

	}

	[Flags]
	internal enum DeviceFlags
	{
		ForceFeedbackSupported = 1,
		Wireless = 2,
		VoiceSupported = 4,
		PluginModulesSupported = 8,
		NoNavigation = 16,
	}

	internal enum DeviceSubType
	{
		Unknown = 0,
		Gamepad = 1,
		Wheel = 2,
		ArcadeStick = 3,
		FlightStick = 4,
		DancePad = 5,
		Guitar = 6,
		GuitarAlternate = 7,
		DrumKit = 8,
		GuitarBass = 11,
		ArcadePad = 19,
	}

	public enum DeviceType
	{
		Gamepad = 0,
	}

	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private ButtonControl <view>k__BackingField; //Field offset: 0x218
	private bool m_HaveParsedCapabilities; //Field offset: 0x220
	private DeviceSubType m_SubType; //Field offset: 0x224
	private DeviceFlags m_Flags; //Field offset: 0x228

	public DeviceFlags flags
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XInputController), Member = "ParseCapabilities", ReturnType = typeof(void))]
		 get { } //Length: 49
	}

	[InputControl(name = "buttonSouth", displayName = "A")]
	[InputControl(name = "buttonEast", displayName = "B")]
	[InputControl(name = "buttonWest", displayName = "X")]
	[InputControl(name = "buttonNorth", displayName = "Y")]
	[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
	[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
	[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
	[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
	[InputControl(name = "start", displayName = "Menu", alias = "menu")]
	[InputControl(name = "select", displayName = "View", alias = "view")]
	public ButtonControl menu
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

	public DeviceSubType subType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XInputController), Member = "ParseCapabilities", ReturnType = typeof(void))]
		 get { } //Length: 49
	}

	public ButtonControl view
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
	public XInputController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gamepad), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XInputController), Member = "ParseCapabilities", ReturnType = typeof(void))]
	public DeviceFlags get_flags() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_menu() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XInputController), Member = "ParseCapabilities", ReturnType = typeof(void))]
	public DeviceSubType get_subType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_view() { }

	[CalledBy(Type = typeof(XInputController), Member = "get_subType", ReturnType = typeof(DeviceSubType))]
	[CalledBy(Type = typeof(XInputController), Member = "get_flags", ReturnType = typeof(DeviceFlags))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Capabilities)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Capabilities))]
	private void ParseCapabilities() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_menu(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_view(ButtonControl value) { }

}

