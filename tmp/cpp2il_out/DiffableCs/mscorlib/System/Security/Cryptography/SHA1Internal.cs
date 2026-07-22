namespace System.Security.Cryptography;

internal class SHA1Internal
{
	private UInt32[] _H; //Field offset: 0x10
	private ulong count; //Field offset: 0x18
	private Byte[] _ProcessingBuffer; //Field offset: 0x20
	private int _ProcessingBufferCount; //Field offset: 0x28
	private UInt32[] buff; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Internal), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public SHA1Internal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	[CalledBy(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void FillBuff(UInt32[] buff) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	public void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public Byte[] HashFinal() { }

	[CalledBy(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void InitialiseBuff(UInt32[] buff, Byte[] input, uint inputOffset) { }

	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SHA1Internal), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize() { }

	[CalledBy(Type = typeof(SHA1Internal), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SHA1Internal), Member = "InitialiseBuff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Internal), Member = "FillBuff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessBlock(Byte[] inputBuffer, uint inputOffset) { }

	[CalledBy(Type = typeof(SHA1Internal), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

