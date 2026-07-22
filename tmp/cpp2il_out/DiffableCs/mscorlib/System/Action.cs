namespace System;

public sealed class Action : MulticastDelegate
{

	[CallerCount(Count = 536)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Action(object object, IntPtr method) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke() { }

}

