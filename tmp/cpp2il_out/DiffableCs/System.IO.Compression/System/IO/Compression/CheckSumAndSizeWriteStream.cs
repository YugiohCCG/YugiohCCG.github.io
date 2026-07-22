namespace System.IO.Compression;

internal sealed class CheckSumAndSizeWriteStream : Stream
{
	private readonly Stream _baseStream; //Field offset: 0x28
	private readonly Stream _baseBaseStream; //Field offset: 0x30
	private long _position; //Field offset: 0x38
	private uint _checksum; //Field offset: 0x40
	private readonly bool _leaveOpenOnClose; //Field offset: 0x44
	private bool _canWrite; //Field offset: 0x45
	private bool _isDisposed; //Field offset: 0x46
	private bool _everWritten; //Field offset: 0x47
	private long _initialPosition; //Field offset: 0x48
	private readonly ZipArchiveEntry _zipArchiveEntry; //Field offset: 0x50
	private readonly EventHandler _onClose; //Field offset: 0x58
	private readonly Action<Int64, Int64, UInt32, Stream, ZipArchiveEntry, EventHandler> _saveCrcAndSizes; //Field offset: 0x60

	public virtual bool CanRead
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 85
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 85
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public CheckSumAndSizeWriteStream(Stream baseStream, Stream baseBaseStream, bool leaveOpenOnClose, ZipArchiveEntry entry, EventHandler onClose, Action<Int64, Int64, UInt32, Stream, ZipArchiveEntry, EventHandler> saveCrcAndSizes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Flush() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	public virtual long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void SetLength(long value) { }

	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CheckSumAndSizeWriteStream), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void ThrowIfDisposed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckSumAndSizeWriteStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Crc32Helper), Member = "ManagedCrc32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

