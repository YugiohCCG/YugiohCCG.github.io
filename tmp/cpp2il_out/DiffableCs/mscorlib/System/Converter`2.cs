namespace System;

public sealed class Converter : MulticastDelegate
{

	[CallerCount(Count = 131)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public Converter`2(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TOutput Invoke(TInput input) { }

}

