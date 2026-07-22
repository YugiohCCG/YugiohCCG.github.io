namespace Mono.Security.Cryptography;

public sealed class PKCS8
{
	internal class EncryptedPrivateKeyInfo
	{
		private string _algorithm; //Field offset: 0x10
		private Byte[] _salt; //Field offset: 0x18
		private int _iterations; //Field offset: 0x20
		private Byte[] _data; //Field offset: 0x28

		public string Algorithm
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Byte[] EncryptedData
		{
			[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 121
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 152
		}

		public int IterationCount
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			 set { } //Length: 126
		}

		public Byte[] Salt
		{
			[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 198
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public EncryptedPrivateKeyInfo() { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(EncryptedPrivateKeyInfo), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public EncryptedPrivateKeyInfo(Byte[] data) { }

		[CalledBy(Type = typeof(EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 32)]
		private void Decode(Byte[] data) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_Algorithm() { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Byte[] get_EncryptedData() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public int get_IterationCount() { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public Byte[] get_Salt() { }

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		public Byte[] GetBytes() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_Algorithm(string value) { }

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public void set_EncryptedData(Byte[] value) { }

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public void set_IterationCount(int value) { }

	}

	internal class PrivateKeyInfo
	{
		private int _version; //Field offset: 0x10
		private string _algorithm; //Field offset: 0x18
		private Byte[] _key; //Field offset: 0x20
		private ArrayList _list; //Field offset: 0x28

		public string Algorithm
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Byte[] PrivateKey
		{
			[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 123
			[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 9)]
			 set { } //Length: 252
		}

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public PrivateKeyInfo() { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public PrivateKeyInfo(Byte[] data) { }

		[CalledBy(Type = typeof(PrivateKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 20)]
		private void Decode(Byte[] data) { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "RemoveLeadingZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

		[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "GetRSAPrivateKey", ReturnType = typeof(RSA))]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspProviderFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CspParameters), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "RemoveLeadingZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(Byte[]))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 24)]
		public static RSA DecodeRSA(Byte[] keypair) { }

		[CalledBy(Type = "Mono.Btls.MonoBtlsKey", Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = "Mono.Btls.MonoBtlsKey")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ASN1))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public static Byte[] Encode(RSA rsa) { }

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ASN1))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public static Byte[] Encode(DSA dsa) { }

		[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		public static Byte[] Encode(AsymmetricAlgorithm aa) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public string get_Algorithm() { }

		[CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Byte[] get_PrivateKey() { }

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 12)]
		public Byte[] GetBytes() { }

		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		private static Byte[] Normalize(Byte[] bigInt, int length) { }

		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
		[CalledBy(Type = typeof(PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(DSAParameters)}, ReturnType = typeof(DSA))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_Algorithm(string value) { }

		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		public void set_PrivateKey(Byte[] value) { }

	}


}

