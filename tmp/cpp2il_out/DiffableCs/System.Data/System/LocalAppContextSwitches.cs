namespace System;

internal static class LocalAppContextSwitches
{
	private static int s_allowArbitraryTypeInstantiation; //Field offset: 0x0

	public static bool AllowArbitraryTypeInstantiation
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		 get { } //Length: 98
	}

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static bool get_AllowArbitraryTypeInstantiation() { }

}

