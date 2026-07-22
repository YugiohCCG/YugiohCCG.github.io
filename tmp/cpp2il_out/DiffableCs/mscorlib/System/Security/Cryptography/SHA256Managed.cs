namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA256Managed : SHA256
{
	private static readonly UInt32[] _K; //Field offset: 0x0
	private Byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private UInt32[] _stateSHA256; //Field offset: 0x38
	private UInt32[] _W; //Field offset: 0x40

	[CalledBy(Type = typeof(SHA256Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "DWORDToBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Byte[] _EndHash() { }

	[CalledBy(Type = typeof(SHA256Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SHA256Managed() { }

	[CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256), Member = "Create", ReturnType = typeof(SHA256))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SHA256Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public SHA256Managed() { }

	[CallerCount(Count = 0)]
	private static uint Ch(uint x, uint y, uint z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	protected virtual Byte[] HashFinal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA256Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Initialize() { }

	[CalledBy(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA256Managed), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeState() { }

	[CallerCount(Count = 0)]
	private static uint Maj(uint x, uint y, uint z) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint RotateRight(uint x, int n) { }

	[CallerCount(Count = 0)]
	private static void SHA256Expand(UInt32* x) { }

	[CalledBy(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DWORDFromBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

	[CallerCount(Count = 0)]
	private static uint sigma_0(uint x) { }

	[CallerCount(Count = 0)]
	private static uint Sigma_0(uint x) { }

	[CallerCount(Count = 0)]
	private static uint sigma_1(uint x) { }

	[CallerCount(Count = 0)]
	private static uint Sigma_1(uint x) { }

}

