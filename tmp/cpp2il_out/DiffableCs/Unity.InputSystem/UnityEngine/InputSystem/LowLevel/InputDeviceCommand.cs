namespace UnityEngine.InputSystem.LowLevel;

public struct InputDeviceCommand : IInputDeviceCommandInfo
{
	internal const int kBaseCommandSize = 8; //Field offset: 0x0
	public const int BaseCommandSize = 8; //Field offset: 0x0
	public const long GenericFailure = -1; //Field offset: 0x0
	public const long GenericSuccess = 1; //Field offset: 0x0
	public FourCC type; //Field offset: 0x0
	public int sizeInBytes; //Field offset: 0x4

	public Void* payloadPtr
	{
		[CalledBy(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
		[CalledBy(Type = typeof(NativeInputRuntime), Member = "DeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDeviceCommand*)}, ReturnType = typeof(long))]
		[CallerCount(Count = 3)]
		 get { } //Length: 5
	}

	public int payloadSizeInBytes
	{
		[CalledBy(Type = typeof(NativeInputRuntime), Member = "DeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDeviceCommand*)}, ReturnType = typeof(long))]
		[CallerCount(Count = 1)]
		 get { } //Length: 7
	}

	public override FourCC typeStatic
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public InputDeviceCommand(FourCC type, int sizeInBytes = 8) { }

	[CalledBy(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static NativeArray<Byte> AllocateNative(FourCC type, int payloadSize) { }

	[CalledBy(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CalledBy(Type = typeof(NativeInputRuntime), Member = "DeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDeviceCommand*)}, ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	public Void* get_payloadPtr() { }

	[CalledBy(Type = typeof(NativeInputRuntime), Member = "DeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDeviceCommand*)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	public int get_payloadSizeInBytes() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override FourCC get_typeStatic() { }

}

