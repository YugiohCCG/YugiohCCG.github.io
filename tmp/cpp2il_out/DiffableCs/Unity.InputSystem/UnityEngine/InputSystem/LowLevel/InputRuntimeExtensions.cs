namespace UnityEngine.InputSystem.LowLevel;

[Extension]
internal static class InputRuntimeExtensions
{

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(bool), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static long DeviceCommand(IInputRuntime runtime, int deviceId, ref TCommand command) { }

}

