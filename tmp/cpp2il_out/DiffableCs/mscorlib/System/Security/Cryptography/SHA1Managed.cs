namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA1Managed : SHA1
{
	private Byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private UInt32[] _stateSHA1; //Field offset: 0x38
	private UInt32[] _expandedBuffer; //Field offset: 0x40

	[CalledBy(Type = typeof(SHA1Managed), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "DWORDToBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Byte[] _EndHash() { }

	[CalledBy(Type = typeof(SHA1Managed), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[CalledBy(Type = typeof(HMAC), Member = "Create", ReturnType = typeof(HMAC))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public SHA1Managed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(Byte[]))]
	protected virtual Byte[] HashFinal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Initialize() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void InitializeState() { }

	[CallerCount(Count = 0)]
	private static void SHAExpand(UInt32* x) { }

	[CalledBy(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DWORDFromBigEndian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(Byte*)}, ReturnType = typeof(void))]
	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

}

