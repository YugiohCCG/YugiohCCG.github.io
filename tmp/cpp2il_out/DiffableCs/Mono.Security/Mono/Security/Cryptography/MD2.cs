namespace Mono.Security.Cryptography;

public abstract class MD2 : HashAlgorithm
{

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected MD2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static MD2 Create() { }

}

