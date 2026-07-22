namespace K4os.Compression.LZ4.Encoders;

public abstract class LZ4EncoderBase : UnmanagedResources, ILZ4Encoder, IDisposable
{
	private readonly Byte* _inputBuffer; //Field offset: 0x18
	private readonly int _inputLength; //Field offset: 0x20
	private readonly int _blockSize; //Field offset: 0x24
	private int _inputIndex; //Field offset: 0x28
	private int _inputPointer; //Field offset: 0x2C

	public override int BlockSize
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override int BytesReady
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	[CalledBy(Type = typeof(LZ4BlockEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "CreateBlockEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "CreateFastEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "CreateHighEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4FastChainEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4Stream+<>c__DisplayClass1_0", Member = "<Encode>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Descriptor)}, ReturnType = typeof(ILZ4Encoder))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected LZ4EncoderBase(bool chaining, int blockSize, int extraBlocks) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Commit() { }

	protected abstract int CopyDict(Byte* target, int dictionaryLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedResources), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override int Encode(Byte* target, int length, bool allowCopy) { }

	protected abstract int EncodeBlock(Byte* source, int sourceLength, Byte* target, int targetLength) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_BlockSize() { }

	[CallerCount(Count = 0)]
	public override int get_BytesReady() { }

	[CalledBy(Type = typeof(LZ4FastChainEncoder), Member = "ReleaseUnmanaged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = "ReleaseUnmanaged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void ReleaseUnmanaged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedResources), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	public override int Topup(Byte* source, int length) { }

}

