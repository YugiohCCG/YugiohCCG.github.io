namespace Unity.IntegerTime;

[Extension]
public static class RationalTimeExtensions
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	[FreeFunction("IntegerTime::RationalTime::ConvertRate", IsFreeFunction = True, ThrowsException = True)]
	public static RationalTime Convert(RationalTime time, TicksPerSecond rate) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Convert_Injected(in RationalTime time, in TicksPerSecond rate, out RationalTime ret) { }

}

