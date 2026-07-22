namespace K4os.Compression.LZ4.Encoders;

public class LZ4ChainDecoder : UnmanagedResources, ILZ4Decoder, IDisposable
{
	private readonly LZ4_streamDecode_t* _context; //Field offset: 0x18
	private readonly int _blockSize; //Field offset: 0x20
	private readonly Byte* _outputBuffer; //Field offset: 0x28
	private readonly int _outputLength; //Field offset: 0x30
	private int _outputIndex; //Field offset: 0x34

	public override int BlockSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override int BytesReady
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStreamDecode", ReturnType = typeof(LZ4_streamDecode_t*))]
	[CallsDeduplicatedMethods(Count = 1)]
	public LZ4ChainDecoder(int blockSize, int extraBlocks) { }

	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "Inject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL), Member = "LZ4_setStreamDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	private int ApplyDict(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_setStreamDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	private int CopyDict(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_setStreamDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override int Decode(Byte* source, int length, int blockSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	private int DecodeBlock(Byte* source, int sourceLength, Byte* target, int targetLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Drain(Byte* target, int offset, int length) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_BlockSize() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override int get_BytesReady() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4ChainDecoder), Member = "ApplyDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override int Inject(Byte* source, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_setStreamDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	private void Prepare(int blockSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL), Member = "LZ4_freeStreamDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void ReleaseUnmanaged() { }

}

