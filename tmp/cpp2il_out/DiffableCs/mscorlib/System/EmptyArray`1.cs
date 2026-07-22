namespace System;

internal static class EmptyArray
{
	public static readonly T[] Value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static EmptyArray`1() { }

}

