namespace Mono;

public static class Runtime
{
	private static object dump; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Runtime() { }

}

