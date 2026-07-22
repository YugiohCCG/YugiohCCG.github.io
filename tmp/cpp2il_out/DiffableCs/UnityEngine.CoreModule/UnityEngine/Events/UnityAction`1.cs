namespace UnityEngine.Events;

public sealed class UnityAction : MulticastDelegate
{

	[CallerCount(Count = 128)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public UnityAction`1(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(T0 arg0) { }

}

