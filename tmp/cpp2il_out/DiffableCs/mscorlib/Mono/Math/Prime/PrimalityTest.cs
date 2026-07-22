namespace Mono.Math.Prime;

internal sealed class PrimalityTest : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public PrimalityTest(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }

}

