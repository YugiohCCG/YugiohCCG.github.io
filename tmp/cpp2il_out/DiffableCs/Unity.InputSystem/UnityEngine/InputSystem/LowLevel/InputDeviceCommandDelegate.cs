namespace UnityEngine.InputSystem.LowLevel;

public sealed class InputDeviceCommandDelegate : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public InputDeviceCommandDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override Nullable<Int64> EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override Nullable<Int64> Invoke(InputDevice device, InputDeviceCommand* command) { }

}

