namespace System.IO.Compression;

internal sealed class SubReadStream : Stream
{
	private readonly long _startInSuperStream; //Field offset: 0x28
	private long _positionInSuperStream; //Field offset: 0x30
	private readonly long _endInSuperStream; //Field offset: 0x38
	private readonly Stream _superStream; //Field offset: 0x40
	private bool _canRead; //Field offset: 0x48
	private bool _isDisposed; //Field offset: 0x49

	public virtual bool CanRead
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 59
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		 get { } //Length: 30
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 85
	}

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipLocalFileHeader), Member = "GetExtraFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[CalledBy(Type = typeof(ZipCentralDirectoryFileHeader), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(ZipCentralDirectoryFileHeader&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SubReadStream(Stream superStream, long startPosition, long maxLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	public virtual long get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	public virtual long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void SetLength(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfCantRead() { }

	[CalledBy(Type = typeof(SubReadStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SubReadStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SubReadStream), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubReadStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SubReadStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SubReadStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubReadStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubReadStream), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void ThrowIfDisposed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubReadStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

