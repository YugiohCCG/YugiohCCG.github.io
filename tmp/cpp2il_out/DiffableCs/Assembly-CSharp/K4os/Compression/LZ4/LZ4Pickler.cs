namespace K4os.Compression.LZ4;

public static class LZ4Pickler
{
	private const int MAX_STACKALLOC = 1024; //Field offset: 0x0
	private const byte VersionMask = 7; //Field offset: 0x0

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Buffers.IBufferWriter`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "UnpickledSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "UnpickleCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickleHeader&), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "DecodeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "DecodeHeaderV0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "PeekN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception CorruptedPickle(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "DecodeHeaderV0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	private static PickleHeader DecodeHeader(ReadOnlySpan<Byte> source) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Buffers.IBufferWriter`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "UnpickledSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "DecodeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[CallerCount(Count = 5)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private static PickleHeader DecodeHeaderV0(ReadOnlySpan<Byte> source) { }

	[CallerCount(Count = 0)]
	private static int EffectiveSizeOf(int value) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "PickleWithBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Buffers.IBufferWriter`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnexpectedVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static int EncodeCompressedHeader(Span<Byte> target, int version, int headerSize, int sourceLength, int encodedLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static int EncodeCompressedHeaderV0(Span<Byte> target, int headerSize, int sourceLength, int encodedLength) { }

	[CallerCount(Count = 0)]
	private static byte EncodeHeaderByteV0(int sizeOfDiff) { }

	[CallerCount(Count = 0)]
	private static int EncodeSizeOf(int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnexpectedVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private static int EncodeUncompressedHeader(Span<Byte> target, int version, int sourceLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int EncodeUncompressedHeaderV0(Span<Byte> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnexpectedVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private static int GetCompressedHeaderSize(int version, int sourceLength, int encodedLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnexpectedVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private static int GetPessimisticHeaderSize(int version, int sourceLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnexpectedVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private static int GetUncompressedHeaderSize(int version, int sourceLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static int PeekN(ReadOnlySpan<Byte> bytes, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] Pickle(Byte[] source, LZ4Level level = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4Codec), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LZ4Pickler), Member = "EncodeCompressedHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void Pickle(ReadOnlySpan<Byte> source, IBufferWriter<Byte> writer, LZ4Level level = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] Pickle(Byte[] source, int sourceIndex, int sourceLength, LZ4Level level = 0) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LZ4Pickler), Member = "PickleWithBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 4)]
	public static Byte[] Pickle(ReadOnlySpan<Byte> source, LZ4Level level = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	public static Byte[] Pickle(Byte* source, int length, LZ4Level level = 0) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Pickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(LZ4Level)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LZ4Pickler), Member = "EncodeCompressedHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static Byte[] PickleWithBuffer(ReadOnlySpan<Byte> source, LZ4Level level, Span<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void PokeN(Span<Byte> target, int value, int size) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "GetPessimisticHeaderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "GetUncompressedHeaderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "GetCompressedHeaderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "EncodeUncompressedHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "EncodeCompressedHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception UnexpectedVersion(int version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	public static Byte[] Unpickle(Byte* source, int count) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LZ4Pickler), Member = "DecodeHeaderV0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnpickleCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickleHeader&), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Byte[] Unpickle(ReadOnlySpan<Byte> source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "DecodeHeaderV0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnpickleCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickleHeader&), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 11)]
	public static void Unpickle(ReadOnlySpan<Byte> source, IBufferWriter<Byte> writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "DecodeHeaderV0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[Calls(Type = typeof(LZ4Pickler), Member = "UnpickleCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickleHeader&), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static void Unpickle(ReadOnlySpan<Byte> source, Span<Byte> output) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] Unpickle(Byte[] source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] Unpickle(Byte[] source, int index, int count) { }

	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Buffers.IBufferWriter`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Pickler), Member = "Unpickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(LLxx), Member = "LZ4_decompress_safe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void UnpickleCore(in PickleHeader header, ReadOnlySpan<Byte> source, Span<Byte> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4Pickler), Member = "DecodeHeaderV0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(PickleHeader))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LZ4Pickler), Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static int UnpickledSize(ReadOnlySpan<Byte> source) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static int UnpickledSize(in PickleHeader header) { }

}

