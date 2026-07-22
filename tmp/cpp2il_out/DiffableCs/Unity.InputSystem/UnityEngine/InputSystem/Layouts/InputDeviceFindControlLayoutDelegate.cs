namespace UnityEngine.InputSystem.Layouts;

public sealed class InputDeviceFindControlLayoutDelegate : MulticastDelegate
{

	[CalledBy(Type = typeof(XRSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HIDSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public InputDeviceFindControlLayoutDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string EndInvoke(ref InputDeviceDescription description, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string Invoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

}

