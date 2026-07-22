namespace UnityEngineInternal.Input;

internal sealed class NativeUpdateCallback : MulticastDelegate
{

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public NativeUpdateCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

}

