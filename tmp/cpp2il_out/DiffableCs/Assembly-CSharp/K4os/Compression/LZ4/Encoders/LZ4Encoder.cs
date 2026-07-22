namespace K4os.Compression.LZ4.Encoders;

public static class LZ4Encoder
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStream", ReturnType = typeof(LZ4_stream_t*))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStreamHC", ReturnType = typeof(LZ4_streamHC_t*))]
	[Calls(Type = typeof(LL), Member = "LZ4_resetStreamHC_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(int)}, ReturnType = typeof(void))]
	public static ILZ4Encoder Create(bool chaining, LZ4Level level, int blockSize, int extraBlocks = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private static ILZ4Encoder CreateBlockEncoder(LZ4Level level, int blockSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStream", ReturnType = typeof(LZ4_stream_t*))]
	private static ILZ4Encoder CreateFastEncoder(int blockSize, int extraBlocks) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStreamHC", ReturnType = typeof(LZ4_streamHC_t*))]
	[Calls(Type = typeof(LL), Member = "LZ4_resetStreamHC_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(int)}, ReturnType = typeof(void))]
	private static ILZ4Encoder CreateHighEncoder(LZ4Level level, int blockSize, int extraBlocks) { }

}

