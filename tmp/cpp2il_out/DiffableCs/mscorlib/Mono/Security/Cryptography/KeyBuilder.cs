namespace Mono.Security.Cryptography;

internal sealed class KeyBuilder
{
	private static RandomNumberGenerator rng; //Field offset: 0x0

	private static RandomNumberGenerator Rng
	{
		[CalledBy(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(KeyBuilder), Member = "IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 120
	}

	[CalledBy(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(KeyBuilder), Member = "IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[CallsUnknownMethods(Count = 1)]
	private static RandomNumberGenerator get_Rng() { }

	[CalledBy(Type = typeof(SymmetricTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "GenerateIV", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] IV(int size) { }

	[CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DESTransform), Member = "GetStrongKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(RC2Transform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RC2), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESTransform), Member = "GetStrongKey", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "GenerateKey", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] Key(int size) { }

}

