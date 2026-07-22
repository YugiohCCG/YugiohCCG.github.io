namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected RandomNumberGenerator() { }

	[CalledBy(Type = typeof(KeyBuilder), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "Mono.Math.BigInteger", Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Mono.Math.BigInteger")]
	[CalledBy(Type = "Mono.Math.BigInteger", Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+EncryptedPrivateKeyInfo", Member = "get_Salt", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "Mono.Security.Cryptography.ARC4Managed", Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", "System.Byte[]&", "System.Byte[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_RNG", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = "System.Net.DigestSession", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = typeof(DSAManaged), Member = "get_Random", ReturnType = typeof(RandomNumberGenerator))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymmetricTransform), Member = "FinalEncrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SymmetricTransform), Member = "Random", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "EncryptedContentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1", typeof(string)}, ReturnType = "Mono.Security.PKCS7+ContentInfo")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	public static RandomNumberGenerator Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	public abstract void GetBytes(Byte[] data) { }

}

