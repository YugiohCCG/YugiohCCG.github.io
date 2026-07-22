namespace System.Security.Cryptography;

public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	private bool _disposed; //Field offset: 0x10
	protected int HashSizeValue; //Field offset: 0x14
	protected private Byte[] HashValue; //Field offset: 0x18
	protected int State; //Field offset: 0x20

	public override bool CanTransformMultipleBlocks
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Byte[] Hash
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 264
	}

	public override int HashSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override int InputBlockSize
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override int OutputBlockSize
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected HashAlgorithm() { }

	[CalledBy(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private Byte[] CaptureHashCodeAndReinitialize() { }

	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CalledBy(Type = "Manager.ImageHandler", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignerInfo", "System.Byte[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignedData", "System.Byte[]", typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLM_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", "System.Byte[]&", "System.Byte[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "HashToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.PublicKey", "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "get_Thumbprint", ReturnType = "System.Byte[]")]
	[CalledBy(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "get_Hash", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Byte[] ComputeHash(Byte[] buffer) { }

	[CalledBy(Type = "Mono.Security.X509.PKCS12+DeriveBytes", Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "MAC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]", typeof(int), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_Hash", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	public Byte[] ComputeHash(Byte[] buffer, int offset, int count) { }

	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignerInfo", "System.Byte[]"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CryptoConfigForwarder), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public static HashAlgorithm Create(string hashName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(HMAC), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyedHashAlgorithm), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MACTripleDES), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_CanTransformMultipleBlocks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public override Byte[] get_Hash() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_HashSize() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_InputBlockSize() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_OutputBlockSize() { }

	protected abstract void HashCore(Byte[] array, int ibStart, int cbSize) { }

	protected abstract Byte[] HashFinal() { }

	public abstract void Initialize() { }

	[CalledBy(Type = typeof(HMAC), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMAC), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12+DeriveBytes", Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(HashAlgorithm), Member = "ValidateTransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[CalledBy(Type = typeof(HMAC), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12+DeriveBytes", Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(HashAlgorithm), Member = "ValidateTransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	[CalledBy(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	private void ValidateTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

