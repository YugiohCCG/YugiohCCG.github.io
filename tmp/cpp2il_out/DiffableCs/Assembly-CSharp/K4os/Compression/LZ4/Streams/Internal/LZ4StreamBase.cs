namespace K4os.Compression.LZ4.Streams.Internal;

public abstract class LZ4StreamBase : Stream
{
	private readonly Stream _inner; //Field offset: 0x28
	private readonly bool _leaveOpen; //Field offset: 0x30
	private Stash _stash; //Field offset: 0x38

	public virtual bool CanRead
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 20
	}

	public virtual int ReadTimeout
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 39
	}

	 Stash Stash
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual int WriteTimeout
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 39
	}

	[CalledBy(Type = typeof(LZ4DecoderStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(System.Func`2<K4os.Compression.LZ4.Streams.ILZ4Descriptor, K4os.Compression.LZ4.Encoders.ILZ4Decoder>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ILZ4Descriptor), typeof(System.Func`2<K4os.Compression.LZ4.Streams.ILZ4Descriptor, K4os.Compression.LZ4.Encoders.ILZ4Encoder>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Stream), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(LZ4EncoderSettings), typeof(bool)}, ReturnType = typeof(LZ4EncoderStream))]
	[CalledBy(Type = typeof(LZ4Stream), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(LZ4Level), typeof(int), typeof(bool)}, ReturnType = typeof(LZ4EncoderStream))]
	[CalledBy(Type = typeof(LZ4Stream), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(LZ4DecoderSettings), typeof(bool), typeof(bool)}, ReturnType = typeof(LZ4DecoderStream))]
	[CalledBy(Type = typeof(LZ4Stream), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(LZ4DecoderStream))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	 LZ4StreamBase(Stream inner, bool leaveOpen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stash), Member = "AsSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Span`1<System.Byte>))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(XXH32), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(uint))]
	 uint DigestOfStash(int offset = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_CanTimeout() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_ReadTimeout() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	 Stash get_Stash() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_WriteTimeout() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 void InnerDispose(in EmptyToken _, bool force) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 ValueTask InnerDispose(in CancellationToken _, bool force) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 Task InnerFlush(in CancellationToken token) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	 void InnerFlush(in EmptyToken _) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	 int InnerReadBlock(in EmptyToken _, Byte[] buffer, int offset, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	 Task<Int32> InnerReadBlock(in CancellationToken token, Byte[] buffer, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 void InnerWriteBlock(in EmptyToken _, Byte[] buffer, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 Task InnerWriteBlock(in CancellationToken token, Byte[] buffer, int offset, int length) { }

	[CalledBy(Type = typeof(LZ4StreamBase), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 InvalidOperationException InvalidOperation(string operation) { }

	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "CreateEncoder", ReturnType = typeof(ILZ4Encoder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	static ArgumentException InvalidValue(string description) { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<ReadFrame>d__6", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream+<WriteBlock>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(BlockInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "BlockChecksum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockInfo)}, ReturnType = typeof(System.Nullable`1<System.UInt32>))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "ContentChecksum", ReturnType = typeof(System.Nullable`1<System.UInt32>))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 NotImplementedException NotImplemented(string operation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int Read(Span<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int ReadByte() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_ReadTimeout(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_WriteTimeout(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void SetLength(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteByte(byte value) { }

}

