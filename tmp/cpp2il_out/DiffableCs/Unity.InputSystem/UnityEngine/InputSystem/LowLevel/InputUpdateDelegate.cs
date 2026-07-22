namespace UnityEngine.InputSystem.LowLevel;

internal sealed class InputUpdateDelegate : MulticastDelegate
{

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public InputUpdateDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndInvoke(ref InputEventBuffer eventBuffer, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

}

