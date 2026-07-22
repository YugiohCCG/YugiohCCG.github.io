namespace System.Security.Cryptography;

[ComVisible(True)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	private RSA rsa; //Field offset: 0x10
	private string hashName; //Field offset: 0x18

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RSAPKCS1SignatureDeformatter() { }

	[CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual void SetHashAlgorithm(string strName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public virtual void SetKey(AsymmetricAlgorithm key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(string), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

