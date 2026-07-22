namespace UnityEngine.InputSystem.LowLevel;

public struct DeviceRemoveEvent : IInputEventTypeInfo
{
	public const int Type = 1146242381; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static DeviceRemoveEvent Create(int deviceId, double time = -1) { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public InputEventPtr ToEventPtr() { }

}

