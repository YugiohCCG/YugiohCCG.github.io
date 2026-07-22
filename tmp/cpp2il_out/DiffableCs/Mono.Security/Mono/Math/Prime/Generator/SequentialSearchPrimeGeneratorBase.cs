namespace Mono.Math.Prime.Generator;

public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SequentialSearchPrimeGeneratorBase() { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual BigInteger GenerateNewPrime(int bits) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override BigInteger GenerateNewPrime(int bits, object context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 2)]
	protected override BigInteger GenerateSearchBase(int bits, object context) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected override bool IsPrimeAcceptable(BigInteger bi, object context) { }

}

