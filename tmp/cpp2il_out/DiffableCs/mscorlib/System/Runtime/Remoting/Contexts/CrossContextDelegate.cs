namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public sealed class CrossContextDelegate : MulticastDelegate
{

	[CallerCount(Count = 536)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public CrossContextDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke() { }

}

