namespace System.Threading;

public sealed class ThreadStart : MulticastDelegate
{

	[CallerCount(Count = 536)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ThreadStart(object object, IntPtr method) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke() { }

}

