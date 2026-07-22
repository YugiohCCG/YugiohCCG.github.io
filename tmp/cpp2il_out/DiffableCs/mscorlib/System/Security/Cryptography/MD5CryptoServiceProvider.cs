namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5
{
	private static readonly UInt32[] K; //Field offset: 0x0
	private UInt32[] _H; //Field offset: 0x28
	private UInt32[] buff; //Field offset: 0x30
	private ulong count; //Field offset: 0x38
	private Byte[] _ProcessingBuffer; //Field offset: 0x40
	private int _ProcessingBufferCount; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static MD5CryptoServiceProvider() { }

	[CalledBy(Type = typeof(HMACMD5), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMACMD5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public MD5CryptoServiceProvider() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual Byte[] HashFinal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Initialize() { }

	[CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessBlock(Byte[] inputBuffer, int inputOffset) { }

	[CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

