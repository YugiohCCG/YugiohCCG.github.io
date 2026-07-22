namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class SHA384 : HashAlgorithm
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected SHA384() { }

	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
	public static SHA384 Create() { }

}

