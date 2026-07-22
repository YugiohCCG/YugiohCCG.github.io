namespace K4os.Compression.LZ4.Engine;

internal class LL32 : LL
{
	protected static cParams_t[] clTable; //Field offset: 0x0
	protected const int ALGORITHM_ARCH = 4; //Field offset: 0x0
	private static readonly UInt32[] _DeBruijnBytePos; //Field offset: 0x8
	private static readonly UInt32* DeBruijnBytePos; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mem), Member = "CloneAnyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 4)]
	private static LL32() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LL32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public static int LZ4_compress_default(Byte* src, Byte* dst, int srcSize, int maxOutputSize) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_fast_extState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static int LZ4_compress_fast(Byte* source, Byte* dest, int inputSize, int maxOutputSize, int acceleration) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_fast_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_compress_fast_continue(LZ4_stream_t* LZ4_stream, Byte* source, Byte* dest, int inputSize, int maxOutputSize, int acceleration) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LL), Member = "LZ4_initStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*)}, ReturnType = typeof(LZ4_stream_t*))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int LZ4_compress_fast_extState(LZ4_stream_t* state, Byte* source, Byte* dest, int inputSize, int maxOutputSize, int acceleration) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	protected static int LZ4_compress_generic(LZ4_stream_t* cctx, Byte* source, Byte* dest, int inputSize, Int32* inputConsumed, int maxOutputSize, limitedOutput_directive outputDirective, tableType_t tableType, dict_directive dictDirective, dictIssue_directive dictIssue, int acceleration) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LL), Member = "LZ4_initStreamHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*)}, ReturnType = typeof(LZ4_streamHC_t*))]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public static int LZ4_compress_HC(Byte* src, Byte* dst, int srcSize, int dstCapacity, int compressionLevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static int LZ4_compress_HC_continue(LZ4_streamHC_t* LZ4_streamHCPtr, Byte* src, Byte* dst, int srcSize, int dstCapacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	public static int LZ4_compress_HC_continue_destSize(LZ4_streamHC_t* LZ4_streamHCPtr, Byte* src, Byte* dst, Int32* srcSizePtr, int targetDestSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL), Member = "LZ4_initStreamHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*)}, ReturnType = typeof(LZ4_streamHC_t*))]
	[Calls(Type = typeof(LL), Member = "LZ4HC_init_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_noDictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	public static int LZ4_compress_HC_destSize(LZ4_streamHC_t* state, Byte* source, Byte* dest, Int32* sourceSizePtr, int targetDestSize, int cLevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL), Member = "LZ4_initStreamHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*)}, ReturnType = typeof(LZ4_streamHC_t*))]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public static int LZ4_compress_HC_extStateHC(LZ4_streamHC_t* state, Byte* src, Byte* dst, int srcSize, int dstCapacity, int compressionLevel) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LL), Member = "LZ4_resetStreamHC_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4HC_init_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_noDictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int LZ4_compress_HC_extStateHC_fastReset(LZ4_streamHC_t* state, Byte* src, Byte* dst, int srcSize, int dstCapacity, int compressionLevel) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_HC_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_continue_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LL), Member = "LZ4HC_init_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL), Member = "LZ4_loadDictHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL), Member = "LZ4HC_setExternalDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_noDictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_compressHC_continue_generic(LZ4_streamHC_t* LZ4_streamHCPtr, Byte* src, Byte* dst, Int32* srcSizePtr, int dstCapacity, limitedOutput_directive limit) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected static uint LZ4_count(Byte* pIn, Byte* pMatch, Byte* pInLimit) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int LZ4_decompress_generic(Byte* src, Byte* dst, int srcSize, int outputSize, endCondition_directive endOnInput, earlyEnd_directive partialDecoding, dict_directive dict, Byte* lowPrefix, Byte* dictStart, uint dictSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public static int LZ4_decompress_generic(Byte* src, Byte* dst, int srcSize, int outputSize, bool endOnInput, bool partialDecoding, dict_directive dict, Byte* lowPrefix, Byte* dictStart, uint dictSize) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_decompress_safe(Byte* source, Byte* dest, int compressedSize, int maxDecompressedSize) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_forceExtDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Void*), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_withSmallPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_withPrefix64k", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static int LZ4_decompress_safe_continue(LZ4_streamDecode_t* LZ4_streamDecode, Byte* source, Byte* dest, int compressedSize, int maxOutputSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_decompress_safe_doubleDict(Byte* source, Byte* dest, int compressedSize, int maxOutputSize, uint prefixSize, Void* dictStart, uint dictSize) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_decompress_safe_forceExtDict(Byte* source, Byte* dest, int compressedSize, int maxOutputSize, Void* dictStart, uint dictSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_decompress_safe_partial(Byte* src, Byte* dst, int compressedSize, int targetOutputSize, int dstCapacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_forceExtDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Void*), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_withSmallPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_withPrefix64k", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public static int LZ4_decompress_safe_usingDict(Byte* source, Byte* dest, int compressedSize, int maxOutputSize, Byte* dictStart, int dictSize) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_decompress_safe_withPrefix64k(Byte* source, Byte* dest, int compressedSize, int maxOutputSize) { }

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_decompress_safe_withSmallPrefix(Byte* source, Byte* dest, int compressedSize, int maxOutputSize, uint prefixSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected static Byte* LZ4_getPosition(Byte* p, Void* tableBase, tableType_t tableType, Byte* srcBase) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected static uint LZ4_hashPosition(Void* p, tableType_t tableType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL), Member = "LZ4_initStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*)}, ReturnType = typeof(LZ4_stream_t*))]
	[CallsUnknownMethods(Count = 2)]
	public int LZ4_loadDict(LZ4_stream_t* LZ4_dict, Byte* dictionary, int dictSize) { }

	[CallerCount(Count = 0)]
	protected static uint LZ4_NbCommonBytes(uint val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected static void LZ4_putPosition(Byte* p, Void* tableBase, tableType_t tableType, Byte* srcBase) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected static void LZ4_renormDictT(LZ4_stream_t* LZ4_dict, int nextSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static int LZ4HC_compress_generic(LZ4_streamHC_t* ctx, Byte* src, Byte* dst, Int32* srcSizePtr, int dstCapacity, int cLevel, limitedOutput_directive limit) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4HC_compress_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LL), Member = "LZ4HC_setExternalDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LL32), Member = "LZ4HC_compress_generic_noDictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public static int LZ4HC_compress_generic_dictCtx(LZ4_streamHC_t* ctx, Byte* src, Byte* dst, Int32* srcSizePtr, int dstCapacity, int cLevel, limitedOutput_directive limit) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_compress_generic_internal(LZ4_streamHC_t* ctx, Byte* src, Byte* dst, Int32* srcSizePtr, int dstCapacity, int cLevel, limitedOutput_directive limit, dictCtx_directive dict) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4HC_compress_generic_noDictCtx(LZ4_streamHC_t* ctx, Byte* src, Byte* dst, Int32* srcSizePtr, int dstCapacity, int cLevel, limitedOutput_directive limit) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_compress_hashChain(LZ4_streamHC_t* ctx, Byte* source, Byte* dest, Int32* srcSizePtr, int maxOutputSize, int maxNbAttempts, limitedOutput_directive limit, dictCtx_directive dict) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_compress_optimal(LZ4_streamHC_t* ctx, Byte* source, Byte* dst, Int32* srcSizePtr, int dstCapacity, int nbSearches, uint sufficient_len, limitedOutput_directive limit, bool fullUpdate, dictCtx_directive dict, HCfavor_e favorDecSpeed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static uint LZ4HC_countPattern(Byte* ip, Byte* iEnd, uint pattern32) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_encodeSequence(Byte** ip, Byte** op, Byte** anchor, int matchLength, Byte* match, limitedOutput_directive limit, Byte* oend) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static LZ4HC_match_t LZ4HC_FindLongerMatch(LZ4_streamHC_t* ctx, Byte* ip, Byte* iHighLimit, int minLen, int nbSearches, dictCtx_directive dict, HCfavor_e favorDecSpeed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4HC_InsertAndFindBestMatch(LZ4_streamHC_t* hc4, Byte* ip, Byte* iLimit, Byte** matchpos, int maxNbAttempts, bool patternAnalysis, dictCtx_directive dict) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_InsertAndGetWiderMatch(LZ4_streamHC_t* hc4, Byte* ip, Byte* iLowLimit, Byte* iHighLimit, int longest, Byte** matchpos, Byte** startpos, int maxNbAttempts, bool patternAnalysis, bool chainSwap, dictCtx_directive dict, HCfavor_e favorDecSpeed) { }

}

