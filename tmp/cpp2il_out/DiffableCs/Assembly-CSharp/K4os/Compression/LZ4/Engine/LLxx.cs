namespace K4os.Compression.LZ4.Engine;

internal static class LLxx
{

	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_fast_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LLxx), Member = "LZ4_compress_HC_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static NotImplementedException AlgorithmNotImplemented(string action) { }

	[CalledBy(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "PickleWithBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_compress_fast(Byte* source, Byte* target, int sourceLength, int targetLength, int acceleration) { }

	[CalledBy(Type = typeof(Pubternal), Member = "CompressFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FastContext), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4FastChainEncoder), Member = "EncodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_fast_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_compress_fast_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_compress_fast_continue(LZ4_stream_t* context, Byte* source, Byte* target, int sourceLength, int targetLength, int acceleration) { }

	[CalledBy(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "PickleWithBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_compress_HC(Byte* source, Byte* target, int sourceLength, int targetLength, int level) { }

	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = "EncodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int LZ4_compress_HC_continue(LZ4_streamHC_t* context, Byte* source, Byte* target, int sourceLength, int targetLength) { }

	[CalledBy(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "UnpickleCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickleHeader&), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_decompress_safe(Byte* source, Byte* target, int sourceLength, int targetLength) { }

	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_decompress_safe_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamDecode_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_decompress_safe_continue(LZ4_streamDecode_t* context, Byte* source, Byte* target, int sourceLength, int targetLength) { }

	[CalledBy(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_forceExtDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Void*), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_withSmallPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe_withPrefix64k", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL32), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_decompress_safe_forceExtDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Void*), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_decompress_safe_withSmallPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_decompress_safe_withPrefix64k", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LL64), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "AlgorithmNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 4)]
	public static int LZ4_decompress_safe_usingDict(Byte* source, Byte* target, int sourceLength, int targetLength, Byte* dictionary, int dictionaryLength) { }

}

