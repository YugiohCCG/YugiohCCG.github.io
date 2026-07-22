namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class MD5 : HashAlgorithm
{

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected MD5() { }

	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", "System.Byte[]&", "System.Byte[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MD5CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	public static MD5 Create() { }

}

