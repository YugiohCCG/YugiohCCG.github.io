namespace K4os.Compression.LZ4.Streams;

public static class LZ4Stream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public LZ4Level level; //Field offset: 0x10
		public int extraMemory; //Field offset: 0x14

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(LZ4EncoderBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LL), Member = "LZ4_createStream", ReturnType = typeof(LZ4_stream_t*))]
		[Calls(Type = typeof(LL), Member = "LZ4_createStreamHC", ReturnType = typeof(LZ4_streamHC_t*))]
		[Calls(Type = typeof(LL), Member = "LZ4_resetStreamHC_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		internal ILZ4Encoder <Encode>b__0(ILZ4Descriptor i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int extraMemory; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(LZ4Decoder), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Decoder))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		internal ILZ4Decoder <Decode>b__0(ILZ4Descriptor i) { }

	}

	internal static readonly Task CompletedTask; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static LZ4Stream() { }

	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Unpack>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Unpack>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LZ4StreamBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static LZ4DecoderStream Decode(Stream stream, LZ4DecoderSettings settings = null, bool leaveOpen = false, bool interactive = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static LZ4DecoderStream Decode(Stream stream, int extraMemory, bool leaveOpen = false, bool interactive = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static LZ4EncoderStream Encode(Stream stream, LZ4EncoderSettings settings = null, bool leaveOpen = false) { }

	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Pack>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Pack>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LZ4StreamBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static LZ4EncoderStream Encode(Stream stream, LZ4Level level, int extraMemory = 0, bool leaveOpen = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static int ExtraBlocks(int blockSize, int extraMemory) { }

}

