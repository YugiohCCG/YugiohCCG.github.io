namespace UnityEngine.InputSystem.LowLevel;

public sealed class InputDeviceExecuteCommandDelegate : MulticastDelegate
{

	[CallerCount(Count = 204)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public InputDeviceExecuteCommandDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(ref InputDeviceCommand command, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override long EndInvoke(ref InputDeviceCommand command, IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override long Invoke(ref InputDeviceCommand command) { }

}

