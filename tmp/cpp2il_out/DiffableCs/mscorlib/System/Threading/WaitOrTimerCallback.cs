namespace System.Threading;

[ComVisible(True)]
public sealed class WaitOrTimerCallback : MulticastDelegate
{

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public WaitOrTimerCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object state, bool timedOut) { }

}

