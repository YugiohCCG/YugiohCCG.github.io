namespace System.Net;

internal class ChunkedInputStream : RequestStream
{
	private class ReadBufferState
	{
		public Byte[] Buffer; //Field offset: 0x10
		public int Offset; //Field offset: 0x18
		public int Count; //Field offset: 0x1C
		public int InitialCount; //Field offset: 0x20
		public HttpStreamAsyncResult Ares; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public ReadBufferState(Byte[] buffer, int offset, int count, HttpStreamAsyncResult ares) { }

	}

	private bool disposed; //Field offset: 0x50
	private MonoChunkParser decoder; //Field offset: 0x58
	private HttpListenerContext context; //Field offset: 0x60
	private bool no_more_data; //Field offset: 0x68

	[CalledBy(Type = typeof(HttpConnection), Member = "GetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(long)}, ReturnType = typeof(RequestStream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RequestStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollection)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public ChunkedInputStream(HttpListenerContext context, Stream stream, Byte[] buffer, int offset, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpStreamAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoChunkParser), Member = "get_WantMore", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cback, object state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RequestStream), Member = "Close", ReturnType = typeof(void))]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public virtual int EndRead(IAsyncResult ares) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RequestStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoChunkParser), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoChunkParser), Member = "get_WantMore", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoChunkParser), Member = "get_ChunkLeft", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void OnRead(IAsyncResult base_ares) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int Read(out Byte[] buffer, int offset, int count) { }

}

