namespace UnityEngine.UIElements;

public sealed class EventCallback : MulticastDelegate
{

	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public EventCallback`2(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(TEventType evt, TCallbackArgs userArgs) { }

}

