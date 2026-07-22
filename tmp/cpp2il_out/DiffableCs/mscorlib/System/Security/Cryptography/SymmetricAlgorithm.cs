namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable
{
	protected int BlockSizeValue; //Field offset: 0x10
	protected int FeedbackSizeValue; //Field offset: 0x14
	protected Byte[] IVValue; //Field offset: 0x18
	protected Byte[] KeyValue; //Field offset: 0x20
	protected KeySizes[] LegalBlockSizesValue; //Field offset: 0x28
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x30
	protected int KeySizeValue; //Field offset: 0x38
	protected CipherMode ModeValue; //Field offset: 0x3C
	protected PaddingMode PaddingValue; //Field offset: 0x40

	public override int BlockSize
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 set { } //Length: 275
	}

	public override int FeedbackSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override Byte[] IV
	{
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_IV", ReturnType = "System.Byte[]")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 145
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		 set { } //Length: 363
	}

	public override Byte[] Key
	{
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_Key", ReturnType = "System.Byte[]")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 145
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		 set { } //Length: 387
	}

	public override int KeySize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(RC2), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 144
	}

	public override KeySizes[] LegalKeySizes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
	}

	public override CipherMode Mode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 125
	}

	public override PaddingMode Padding
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 125
	}

	[CalledBy(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DES), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Rijndael), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.ARC4Managed", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.RC4", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.RC4", Member = "Create", ReturnType = "Mono.Security.Cryptography.RC4")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected SymmetricAlgorithm() { }

	[CalledBy(Type = typeof(MACTripleDES), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", typeof(int), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_LM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "GetSymmetricAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", typeof(int)}, ReturnType = typeof(SymmetricAlgorithm))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public static SymmetricAlgorithm Create(string algName) { }

	public abstract ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public override ICryptoTransform CreateDecryptor() { }

	public abstract ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public override ICryptoTransform CreateEncryptor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected override void Dispose(bool disposing) { }

	public abstract void GenerateIV() { }

	public abstract void GenerateKey() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_BlockSize() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_FeedbackSize() { }

	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_IV", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Byte[] get_IV() { }

	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "get_Key", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Byte[] get_Key() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_KeySize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override KeySizes[] get_LegalKeySizes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override CipherMode get_Mode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override PaddingMode get_Padding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void set_BlockSize(int value) { }

	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public override void set_IV(Byte[] value) { }

	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public override void set_Key(Byte[] value) { }

	[CalledBy(Type = typeof(RC2), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "ValidKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override void set_KeySize(int value) { }

	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void set_Mode(CipherMode value) { }

	[CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void set_Padding(PaddingMode value) { }

	[CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDES), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ValidKeySize(int bitLength) { }

}

