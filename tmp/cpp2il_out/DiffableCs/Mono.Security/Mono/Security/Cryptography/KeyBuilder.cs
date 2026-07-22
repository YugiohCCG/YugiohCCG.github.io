namespace Mono.Security.Cryptography;

public sealed class KeyBuilder
{
	private static RandomNumberGenerator rng; //Field offset: 0x0

	private static RandomNumberGenerator Rng
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 120
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[CallsUnknownMethods(Count = 1)]
	private static RandomNumberGenerator get_Rng() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] Key(int size) { }

}

