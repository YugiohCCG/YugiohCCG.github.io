namespace System.Security.Cryptography;

public sealed class AesCryptoServiceProvider : Aes
{

	public virtual int FeedbackSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual Byte[] IV
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_IV", ReturnType = typeof(Byte[]))]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	public virtual Byte[] Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_Key", ReturnType = typeof(Byte[]))]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	public virtual int KeySize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	public virtual CipherMode Mode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 103
	}

	public virtual PaddingMode Padding
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Aes), Member = ".ctor", ReturnType = typeof(void))]
	public AesCryptoServiceProvider() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual ICryptoTransform CreateDecryptor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Aes), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual ICryptoTransform CreateEncryptor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Aes), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void GenerateIV() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Mono.Security.Cryptography.KeyBuilder", Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void GenerateKey() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int get_FeedbackSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_IV", ReturnType = typeof(Byte[]))]
	public virtual Byte[] get_IV() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "get_Key", ReturnType = typeof(Byte[]))]
	public virtual Byte[] get_Key() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_KeySize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual CipherMode get_Mode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual PaddingMode get_Padding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_IV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	public virtual void set_IV(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	public virtual void set_Key(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void set_KeySize(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CipherMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_Mode(CipherMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_Padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PaddingMode)}, ReturnType = typeof(void))]
	public virtual void set_Padding(PaddingMode value) { }

}

