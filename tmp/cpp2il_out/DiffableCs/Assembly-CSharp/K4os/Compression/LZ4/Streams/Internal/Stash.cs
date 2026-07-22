namespace K4os.Compression.LZ4.Streams.Internal;

internal struct Stash
{
	private readonly Stream _stream; //Field offset: 0x0
	private readonly Byte[] _buffer; //Field offset: 0x8
	private int _head; //Field offset: 0x10
	private readonly int _size; //Field offset: 0x14

	public bool Empty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public int Length
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Stash(Stream innerStream, int bufferSize) { }

	[CallerCount(Count = 0)]
	public int Advance(int loaded) { }

	[CalledBy(Type = typeof(cParams_t), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(lz4hc_strat_e), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "DigestOfStash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.DateTimeResult", Member = "SetDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3Int), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(bool4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4), typeof(bool4), typeof(bool4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(int3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(uint3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.OutputBuffer+BufferState", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Span<Byte> AsSpan(int offset = 0) { }

	[CallerCount(Count = 0)]
	public int Clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Flush(EmptyToken _) { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<CloseFrame>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<WriteBlock>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<WriteImpl>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Task Flush(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_Empty() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public byte Last1(int loaded = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ushort Last2(int loaded = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public uint Last4(int loaded = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ulong Last8(int loaded = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int Load(EmptyToken _, int count, bool optional = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	public Task<Int32> Load(CancellationToken token, int count, bool optional = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Span<Byte> OneByteSpan() { }

	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Span<Byte> OneByteSpan(byte value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public byte OneByteValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Stash1(byte value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Stash2(ushort value) { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<CloseFrame>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<WriteBlock>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(BlockInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "CloseFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "DisposeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stash), Member = "TryStash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public void Stash4(uint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Stash8(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public void TryStash4(Nullable<UInt32> value) { }

}

