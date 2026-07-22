namespace System.Security.Cryptography;

internal static class Utils
{
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal get { } //Length: 249
	}

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool _ProduceLegacyHmacValues() { }

	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static int ConvertByteArrayToInt(Byte[] input) { }

	[CalledBy(Type = typeof(DSA), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] ConvertIntToByteArray(int dwInput) { }

	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	[CalledBy(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static void DWORDFromBigEndian(UInt32* x, int digits, Byte* block) { }

	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "MDTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void DWORDFromLittleEndian(UInt32* x, int digits, Byte* block) { }

	[CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void DWORDToBigEndian(Byte[] block, UInt32[] x, int digits) { }

	[CalledBy(Type = typeof(RIPEMD160Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void DWORDToLittleEndian(Byte[] block, UInt32[] x, int digits) { }

	[CalledBy(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] FixupKeyParity(Byte[] key) { }

	[CalledBy(Type = typeof(HMAC), Member = "Create", ReturnType = typeof(HMAC))]
	[CalledBy(Type = typeof(HMACMD5), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Byte[] GenerateRandom(int keySize) { }

	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	[CalledBy(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void QuadWordFromBigEndian(UInt64* x, int digits, Byte* block) { }

	[CalledBy(Type = typeof(SHA384Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void QuadWordToBigEndian(Byte[] block, UInt64[] x, int digits) { }

}

