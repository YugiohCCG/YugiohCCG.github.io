namespace UnityEngine.InputSystem.XR.Haptics;

public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo
{
	private const int kSize = 16; //Field offset: 0x0
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	public uint samplesQueued; //Field offset: 0x8
	public uint samplesAvailable; //Field offset: 0xC

	public HapticState currentState
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 20
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
	public static GetCurrentHapticStateCommand Create() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HapticState get_currentState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	private static FourCC get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

}

