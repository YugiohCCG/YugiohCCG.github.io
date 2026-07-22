namespace Mono.Math.Prime.Generator;

internal abstract class PrimeGeneratorBase
{

	public override ConfidenceFactor Confidence
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override PrimalityTest PrimalityTest
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 303
	}

	public override int TrialDivisionBounds
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected PrimeGeneratorBase() { }

	public abstract BigInteger GenerateNewPrime(int bits) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public override ConfidenceFactor get_Confidence() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public override PrimalityTest get_PrimalityTest() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int get_TrialDivisionBounds() { }

}

