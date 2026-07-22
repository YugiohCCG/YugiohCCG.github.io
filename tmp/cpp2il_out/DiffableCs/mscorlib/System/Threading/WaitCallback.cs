namespace System.Threading;

[ComVisible(True)]
public sealed class WaitCallback : MulticastDelegate
{

	[CallerCount(Count = 60)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public WaitCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object state) { }

}

