namespace K4os.Compression.LZ4.Encoders;

public class LZ4FastChainEncoder : LZ4EncoderBase
{
	private readonly LZ4_stream_t* _context; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStream", ReturnType = typeof(LZ4_stream_t*))]
	public LZ4FastChainEncoder(int blockSize, int extraBlocks = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL), Member = "LZ4_saveDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	protected virtual int CopyDict(Byte* target, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_fast_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	protected virtual int EncodeBlock(Byte* source, int sourceLength, Byte* target, int targetLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = "ReleaseUnmanaged", ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_freeStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*)}, ReturnType = typeof(void))]
	protected virtual void ReleaseUnmanaged() { }

}

