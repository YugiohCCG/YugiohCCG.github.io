namespace System.IO.Compression;

public class GZipStream : Stream
{
	private DeflateStream _deflateStream; //Field offset: 0x28

	public virtual bool CanRead
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 29
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 29
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 29
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 78
	}

	[CalledBy(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(Stream), typeof(Mode)}, ReturnType = typeof(ContentDecodeStream))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GZipStream(Stream stream, CompressionMode mode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	private void CheckDeflateStream() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void CopyTo(Stream destination, int bufferSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "TResult")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int Read(Byte[] array, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int Read(Span<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task<Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int ReadByte() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void SetLength(long value) { }

	[CalledBy(Type = typeof(GZipStream), Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "CheckDeflateStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(GZipStream), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(GZipStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(GZipStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(GZipStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(GZipStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GZipStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GZipStream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowStreamClosedException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Write(Byte[] array, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Stream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[Calls(Type = typeof(GZipStream), Member = "ThrowStreamClosedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

}

