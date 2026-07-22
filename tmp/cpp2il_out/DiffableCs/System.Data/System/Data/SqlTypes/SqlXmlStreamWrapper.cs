namespace System.Data.SqlTypes;

internal sealed class SqlXmlStreamWrapper : Stream
{
	private Stream _stream; //Field offset: 0x28
	private long _lPosition; //Field offset: 0x30
	private bool _isClosed; //Field offset: 0x38

	public virtual bool CanRead
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 64
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 64
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 64
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 195
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 168
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 299
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal SqlXmlStreamWrapper(Stream stream) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual long get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual long get_Position() { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_CanRead", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_CanSeek", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_CanWrite", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsStreamClosed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public virtual int ReadByte() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "InvalidSeekOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void SetLength(long value) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ReadByte", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamNonReadable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfStreamCannotRead(string method) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamNonSeekable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfStreamCannotSeek(string method) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamNonWritable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfStreamCannotWrite(string method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ThrowIfStreamClosed(string method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "IsStreamClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "InvalidOpStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteByte(byte value) { }

}

