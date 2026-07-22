namespace System.Security.Cryptography;

internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	private string _hashAlgorithm; //Field offset: 0x30

	[CalledBy(Type = typeof(RSAPKCS1SHA1SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAPKCS1SHA256SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAPKCS1SHA384SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAPKCS1SHA512SignatureDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm) { }

}

