namespace System.IO.Compression;

internal sealed class WrappedStream : Stream
{
	private readonly Stream _baseStream; //Field offset: 0x28
	private readonly bool _closeBaseStream; //Field offset: 0x30
	private readonly Action<ZipArchiveEntry> _onClosed; //Field offset: 0x38
	private readonly ZipArchiveEntry _zipArchiveEntry; //Field offset: 0x40
	private bool _isDisposed; //Field offset: 0x48

	public virtual bool CanRead
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 52
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 163
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(ZipArchiveEntry), typeof(System.Action`1<System.IO.Compression.ZipArchiveEntry>)}, ReturnType = typeof(void))]
	internal WrappedStream(Stream baseStream, bool closeBaseStream) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInWriteMode", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInUpdateMode", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(WrappedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WrappedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveEntry), typeof(System.Action`1<System.IO.Compression.ZipArchiveEntry>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private WrappedStream(Stream baseStream, bool closeBaseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(ZipArchiveEntry), typeof(System.Action`1<System.IO.Compression.ZipArchiveEntry>)}, ReturnType = typeof(void))]
	internal WrappedStream(Stream baseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual long get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void SetLength(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfCantRead() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfCantSeek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfCantWrite() { }

	[CalledBy(Type = typeof(WrappedStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(WrappedStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(WrappedStream), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WrappedStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WrappedStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(WrappedStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WrappedStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WrappedStream), Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void ThrowIfDisposed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

