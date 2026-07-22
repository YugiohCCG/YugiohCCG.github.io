namespace System.Threading;

[ComVisible(True)]
public sealed class TimerCallback : MulticastDelegate
{

	[CallerCount(Count = 412)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public TimerCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object state) { }

}

