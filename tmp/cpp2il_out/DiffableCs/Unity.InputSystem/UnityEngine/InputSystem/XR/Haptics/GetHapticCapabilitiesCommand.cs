namespace UnityEngine.InputSystem.XR.Haptics;

public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo
{
	private const int kSize = 28; //Field offset: 0x0
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	public uint numChannels; //Field offset: 0x8
	public bool supportsImpulse; //Field offset: 0xC
	public bool supportsBuffer; //Field offset: 0xD
	public uint frequencyHz; //Field offset: 0x10
	public uint maxBufferSize; //Field offset: 0x14
	public uint optimalBufferSize; //Field offset: 0x18

	public HapticCapabilities capabilities
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 47
	}

	private static FourCC Type
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		private get { } //Length: 58
	}

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GetHapticCapabilitiesCommand Create() { }

	[CallerCount(Count = 0)]
	public HapticCapabilities get_capabilities() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	private static FourCC get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

}

