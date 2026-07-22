namespace System;

public sealed class Func : MulticastDelegate
{

	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Func`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TResult Invoke() { }

}

