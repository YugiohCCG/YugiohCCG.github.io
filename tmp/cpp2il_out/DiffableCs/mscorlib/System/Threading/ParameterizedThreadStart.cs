namespace System.Threading;

public sealed class ParameterizedThreadStart : MulticastDelegate
{

	[CallerCount(Count = 60)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public ParameterizedThreadStart(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object obj) { }

}

