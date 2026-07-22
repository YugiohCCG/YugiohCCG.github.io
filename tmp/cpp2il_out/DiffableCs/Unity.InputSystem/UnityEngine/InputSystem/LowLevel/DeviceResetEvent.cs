namespace UnityEngine.InputSystem.LowLevel;

public struct DeviceResetEvent : IInputEventTypeInfo
{
	public const int Type = 1146245972; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0
	public bool hardReset; //Field offset: 0x8

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "CreateResetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(Message))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static DeviceResetEvent Create(int deviceId, bool hardReset = false, double time = -1) { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

}

