namespace K4os.Compression.LZ4.Encoders;

public static class LZ4Decoder
{

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4Stream+<>c__DisplayClass3_0", Member = "<Decode>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Descriptor)}, ReturnType = typeof(ILZ4Decoder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStreamDecode", ReturnType = typeof(LZ4_streamDecode_t*))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static ILZ4Decoder Create(bool chaining, int blockSize, int extraBlocks = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ILZ4Decoder CreateBlockDecoder(int blockSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LL), Member = "LZ4_createStreamDecode", ReturnType = typeof(LZ4_streamDecode_t*))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ILZ4Decoder CreateChainDecoder(int blockSize, int extraBlocks) { }

}

