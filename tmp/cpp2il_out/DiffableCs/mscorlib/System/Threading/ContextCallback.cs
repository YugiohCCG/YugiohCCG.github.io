namespace System.Threading;

[ComVisible(True)]
public sealed class ContextCallback : MulticastDelegate
{

	[CallerCount(Count = 60)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public ContextCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object state) { }

}

