namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA512Managed : SHA512
{
	private static readonly UInt64[] _K; //Field offset: 0x0
	private Byte[] _buffer; //Field offset: 0x28
	private ulong _count; //Field offset: 0x30
	private UInt64[] _stateSHA512; //Field offset: 0x38
	private UInt64[] _W; //Field offset: 0x40

	[CalledBy(Type = typeof(SHA512Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "QuadWordToBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt64[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Byte[] _EndHash() { }

	[CalledBy(Type = typeof(SHA512Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SHA512Managed() { }

	[CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA512), Member = "Create", ReturnType = typeof(SHA512))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SHA512Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public SHA512Managed() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	protected virtual Byte[] HashFinal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA512Managed), Member = "InitializeState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Initialize() { }

	[CalledBy(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA512Managed), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeState() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong RotateRight(ulong x, int n) { }

	[CallerCount(Count = 0)]
	private static void SHA512Expand(UInt64* x) { }

	[CalledBy(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void SHATransform(UInt64* expandedBuffer, UInt64* state, Byte* block) { }

	[CallerCount(Count = 0)]
	private static ulong sigma_0(ulong x) { }

	[CallerCount(Count = 0)]
	private static ulong Sigma_0(ulong x) { }

	[CallerCount(Count = 0)]
	private static ulong sigma_1(ulong x) { }

	[CallerCount(Count = 0)]
	private static ulong Sigma_1(ulong x) { }

}

