namespace UnityEngine.InputSystem.LowLevel;

public struct DeviceConfigurationEvent : IInputEventTypeInfo
{
	public const int Type = 1145259591; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(InputSystem), Member = "QueueConfigChangeEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static DeviceConfigurationEvent Create(int deviceId, double time) { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public InputEventPtr ToEventPtr() { }

}

