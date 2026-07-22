namespace UnityEngine.Events;

public sealed class UnityAction : MulticastDelegate
{

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public UnityAction`3(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

