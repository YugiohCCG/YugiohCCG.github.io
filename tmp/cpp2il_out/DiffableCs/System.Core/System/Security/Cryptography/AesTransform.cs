namespace System.Security.Cryptography;

internal class AesTransform : SymmetricTransform
{
	private static readonly UInt32[] Rcon; //Field offset: 0x0
	private static readonly Byte[] SBox; //Field offset: 0x8
	private static readonly Byte[] iSBox; //Field offset: 0x10
	private static readonly UInt32[] T0; //Field offset: 0x18
	private static readonly UInt32[] T1; //Field offset: 0x20
	private static readonly UInt32[] T2; //Field offset: 0x28
	private static readonly UInt32[] T3; //Field offset: 0x30
	private static readonly UInt32[] iT0; //Field offset: 0x38
	private static readonly UInt32[] iT1; //Field offset: 0x40
	private static readonly UInt32[] iT2; //Field offset: 0x48
	private static readonly UInt32[] iT3; //Field offset: 0x50
	private UInt32[] expandedKey; //Field offset: 0x58
	private int Nk; //Field offset: 0x60
	private int Nr; //Field offset: 0x64

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	private static AesTransform() { }

	[CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 2)]
	[Calls(Type = "Mono.Security.Cryptography.SymmetricTransform", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AesTransform), Member = "SubByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	public AesTransform(Aes algo, bool encryption, Byte[] key, Byte[] iv) { }

	[CalledBy(Type = typeof(AesTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Decrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AesTransform), Member = "Decrypt128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AesTransform), Member = "Encrypt128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

	[CalledBy(Type = typeof(AesTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Encrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	[CalledBy(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Aes), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private uint SubByte(uint a) { }

}

