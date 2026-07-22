namespace UnityEngine.InputSystem.LowLevel;

public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo
{
	internal enum Result
	{
		SuccessfullyInitiated = 1,
		ErrorNotSupported = -1,
		ErrorAlreadyInProgress = -2,
	}

	internal const int kSize = 8; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	public static FourCC Type
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	[CalledBy(Type = typeof(InputUser), Member = "InitiateUserAccountSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(InputUserPairingOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "InitiateUserAccountSelectionAtPlatformLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static InitiateUserAccountPairingCommand Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

}

