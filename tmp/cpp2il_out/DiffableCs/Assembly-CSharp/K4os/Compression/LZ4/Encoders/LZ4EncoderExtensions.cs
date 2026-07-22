namespace K4os.Compression.LZ4.Encoders;

[Extension]
public static class LZ4EncoderExtensions
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static int Decode(ILZ4Decoder decoder, Byte[] buffer, int offset, int length, int blockSize = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static bool DecodeAndDrain(ILZ4Decoder decoder, ReadOnlySpan<Byte> source, Span<Byte> target, out int decoded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static bool DecodeAndDrain(ILZ4Decoder decoder, Byte[] source, int sourceOffset, int sourceLength, Byte[] target, int targetOffset, int targetLength, out int decoded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static bool DecodeAndDrain(ILZ4Decoder decoder, Byte* source, int sourceLength, Byte* target, int targetLength, out int decoded) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static void Drain(ILZ4Decoder decoder, Span<Byte> target, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static void Drain(ILZ4Decoder decoder, Byte[] target, int targetOffset, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static int Encode(ILZ4Encoder encoder, Byte[] target, int offset, int length, bool allowCopy) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static EncoderAction Encode(ILZ4Encoder encoder, Byte[] target, ref int offset, int length, bool allowCopy) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static EncoderAction Encode(ILZ4Encoder encoder, ref Byte* target, int length, bool allowCopy) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static EncoderAction FlushAndEncode(ILZ4Encoder encoder, Span<Byte> target, bool allowCopy, out int encoded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static EncoderAction FlushAndEncode(ILZ4Encoder encoder, Byte[] target, int targetOffset, int targetLength, bool allowCopy, out int encoded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static EncoderAction FlushAndEncode(ILZ4Encoder encoder, Byte* target, int targetLength, bool forceEncode, bool allowCopy, int loaded, out int encoded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static EncoderAction FlushAndEncode(ILZ4Encoder encoder, Byte* target, int targetLength, bool allowCopy, out int encoded) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static int Inject(ILZ4Decoder decoder, Byte[] buffer, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool Topup(ILZ4Encoder encoder, Byte[] source, ref int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static int Topup(ILZ4Encoder encoder, Byte[] source, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool Topup(ILZ4Encoder encoder, ref Byte* source, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderExtensions), Member = "TopupAndEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Encoder), typeof(Byte*), typeof(int), typeof(Byte*), typeof(int), typeof(bool), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(EncoderAction))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	public static EncoderAction TopupAndEncode(ILZ4Encoder encoder, ReadOnlySpan<Byte> source, Span<Byte> target, bool forceEncode, bool allowCopy, out int loaded, out int encoded) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderExtensions), Member = "TopupAndEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Encoder), typeof(Byte*), typeof(int), typeof(Byte*), typeof(int), typeof(bool), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(EncoderAction))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static EncoderAction TopupAndEncode(ILZ4Encoder encoder, Byte[] source, int sourceOffset, int sourceLength, Byte[] target, int targetOffset, int targetLength, bool forceEncode, bool allowCopy, out int loaded, out int encoded) { }

	[CalledBy(Type = typeof(LZ4EncoderExtensions), Member = "TopupAndEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Encoder), typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(EncoderAction))]
	[CalledBy(Type = typeof(LZ4EncoderExtensions), Member = "TopupAndEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Encoder), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(EncoderAction))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static EncoderAction TopupAndEncode(ILZ4Encoder encoder, Byte* source, int sourceLength, Byte* target, int targetLength, bool forceEncode, bool allowCopy, out int loaded, out int encoded) { }

}

