namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class SHA256 : HashAlgorithm
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected SHA256() { }

	[CalledBy(Type = "Manager.ImageHandler", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.ImageHandler", Member = "get_Hasher", ReturnType = typeof(SHA256))]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	public static SHA256 Create() { }

}

