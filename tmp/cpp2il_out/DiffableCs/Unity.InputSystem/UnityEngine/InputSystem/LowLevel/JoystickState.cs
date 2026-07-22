namespace UnityEngine.InputSystem.LowLevel;

internal struct JoystickState : IInputStateTypeInfo
{
	internal enum Button
	{
		HatSwitchUp = 0,
		HatSwitchDown = 1,
		HatSwitchLeft = 2,
		HatSwitchRight = 3,
		Trigger = 4,
	}

	[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new IL2CPP_TYPE_STRING[] {"PrimaryTrigger", "PrimaryAction", "Submit"}, bit = 4)]
	public int buttons; //Field offset: 0x0
	[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
	public Vector2 stick; //Field offset: 0x4

	public override FourCC format
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public static FourCC kFormat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_format() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_kFormat() { }

}

