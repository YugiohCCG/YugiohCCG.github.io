namespace K4os.Compression.LZ4.Encoders;

public class LZ4BlockEncoder : LZ4EncoderBase
{
	private readonly LZ4Level _level; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public LZ4BlockEncoder(LZ4Level level, int blockSize) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected virtual int CopyDict(Byte* target, int dictionaryLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(int))]
	protected virtual int EncodeBlock(Byte* source, int sourceLength, Byte* target, int targetLength) { }

}

