namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
{
	private static readonly Byte[] s_Sbox; //Field offset: 0x0
	private static readonly Int32[] s_Rcon; //Field offset: 0x8
	private static readonly Int32[] s_T; //Field offset: 0x10
	private static readonly Int32[] s_TF; //Field offset: 0x18
	private static readonly Int32[] s_iT; //Field offset: 0x20
	private static readonly Int32[] s_iTF; //Field offset: 0x28
	private CipherMode m_cipherMode; //Field offset: 0x10
	private PaddingMode m_paddingValue; //Field offset: 0x14
	private RijndaelManagedTransformMode m_transformMode; //Field offset: 0x18
	private int m_blockSizeBits; //Field offset: 0x1C
	private int m_blockSizeBytes; //Field offset: 0x20
	private int m_inputBlockSize; //Field offset: 0x24
	private int m_outputBlockSize; //Field offset: 0x28
	private Int32[] m_encryptKeyExpansion; //Field offset: 0x30
	private Int32[] m_decryptKeyExpansion; //Field offset: 0x38
	private int m_Nr; //Field offset: 0x40
	private int m_Nb; //Field offset: 0x44
	private int m_Nk; //Field offset: 0x48
	private Int32[] m_encryptindex; //Field offset: 0x50
	private Int32[] m_decryptindex; //Field offset: 0x58
	private Int32[] m_IV; //Field offset: 0x60
	private Int32[] m_lastBlockBuffer; //Field offset: 0x68
	private Byte[] m_depadBuffer; //Field offset: 0x70
	private Byte[] m_shiftRegister; //Field offset: 0x78

	public override bool CanTransformMultipleBlocks
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override int OutputBlockSize
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static RijndaelManagedTransform() { }

	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "GenerateKeyExpansion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	internal RijndaelManagedTransform(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	private void Dec(Int32* decryptindex, Int32* decryptKeyExpansion, Int32* iT, Int32* iTF, Int32* work, Int32* temp) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Dec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Enc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 48)]
	[ContainsUnimplementedInstructions]
	private int DecryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	private void Enc(Int32* encryptindex, Int32* encryptKeyExpansion, Int32* T, Int32* TF, Int32* work, Int32* temp) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Enc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*), typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	private int EncryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(int), typeof(PaddingMode), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "SubWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void GenerateKeyExpansion(Byte[] rgbKey) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_CanTransformMultipleBlocks() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_InputBlockSize() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override int get_OutputBlockSize() { }

	[CallerCount(Count = 0)]
	private static int MulX(int x) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void Reset() { }

	[CallerCount(Count = 0)]
	private static int rot1(int val) { }

	[CallerCount(Count = 0)]
	private static int rot2(int val) { }

	[CallerCount(Count = 0)]
	private static int rot3(int val) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "GenerateKeyExpansion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static int SubWord(int a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

