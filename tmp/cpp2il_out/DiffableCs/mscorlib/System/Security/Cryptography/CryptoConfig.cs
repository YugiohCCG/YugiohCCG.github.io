namespace System.Security.Cryptography;

[ComVisible(True)]
public class CryptoConfig
{
	private static readonly object lockObject; //Field offset: 0x0
	private static Dictionary<String, Type> algorithms; //Field offset: 0x8

	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static CryptoConfig() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	public static object CreateFromName(string name) { }

	[CalledBy(Type = typeof(SymmetricAlgorithm), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymmetricAlgorithm))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RIPEMD160Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DSASignatureFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMACSHA384), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMACSHA256), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Internal), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(TripleDESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RC2CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMACSHA512), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DSASignatureDeformatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMACRIPEMD160), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSAPKCS1SignatureDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HMACMD5), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 71)]
	[CallsUnknownMethods(Count = 18)]
	public static object CreateFromName(string name, Object[] args) { }

	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static Byte[] EncodeLongNumber(long x) { }

	[CalledBy(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.PublicKey", "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.ASN1Convert", Member = "FromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Mono.Security.ASN1")]
	[CalledBy(Type = "Mono.Security.PKCS7+ContentInfo", Member = "GetASN1", ReturnType = "Mono.Security.ASN1")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = "Mono.Security.ASN1")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.X509.X509Certificate", typeof(IDictionary)}, ReturnType = "Mono.Security.ASN1")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "EncryptedContentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1", typeof(string)}, ReturnType = "Mono.Security.PKCS7+ContentInfo")]
	[CalledBy(Type = "Mono.Security.X509.X501", Member = "IsOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X520+AttributeTypeAndValue", Member = "GetASN1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = "Mono.Security.ASN1")]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), "System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CryptoConfig), Member = "EncodeLongNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	public static Byte[] EncodeOID(string str) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static bool get_AllowOnlyFipsAlgorithms() { }

	[CalledBy(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DSASignatureDeformatter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSASignatureDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSASignatureDeformatter), Member = "SetHashAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSASignatureFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "Encode_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm), "System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignedData", "System.Byte[]", typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 4)]
	public static string MapNameToOID(string name) { }

}

