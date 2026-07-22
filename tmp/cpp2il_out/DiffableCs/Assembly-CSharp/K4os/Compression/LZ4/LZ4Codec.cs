namespace K4os.Compression.LZ4;

public static class LZ4Codec
{
	public const int Version = 192; //Field offset: 0x0

	public static bool Enforce32
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 137
		[CallerCount(Count = 0)]
		 set { } //Length: 142
	}

	[CalledBy(Type = typeof(LZ4BlockDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public static int Decode(Byte* source, int sourceLength, Byte* target, int targetLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	public static int Decode(Byte* source, int sourceLength, Byte* target, int targetLength, Byte* dictionary, int dictionaryLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static int Decode(ReadOnlySpan<Byte> source, Span<Byte> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	public static int Decode(ReadOnlySpan<Byte> source, Span<Byte> target, ReadOnlySpan<Byte> dictionary) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "Validate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int Decode(Byte[] source, int sourceOffset, int sourceLength, Byte[] target, int targetOffset, int targetLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "Validate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe_usingDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int Decode(Byte[] source, int sourceOffset, int sourceLength, Byte[] target, int targetOffset, int targetLength, Byte[] dictionary, int dictionaryOffset, int dictionaryLength) { }

	[CalledBy(Type = typeof(LZ4BlockEncoder), Member = "EncodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public static int Encode(Byte* source, int sourceLength, Byte* target, int targetLength, LZ4Level level = 0) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Buffers.IBufferWriter`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static int Encode(ReadOnlySpan<Byte> source, Span<Byte> target, LZ4Level level = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "Validate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int Encode(Byte[] source, int sourceOffset, int sourceLength, Byte[] target, int targetOffset, int targetLength, LZ4Level level = 0) { }

	[CallerCount(Count = 0)]
	public static bool get_Enforce32() { }

	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int MaximumOutputSize(int length) { }

	[CallerCount(Count = 0)]
	public static void set_Enforce32(bool value) { }

}

