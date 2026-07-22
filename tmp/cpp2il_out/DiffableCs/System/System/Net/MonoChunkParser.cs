namespace System.Net;

internal class MonoChunkParser
{
	private class Chunk
	{
		public Byte[] Bytes; //Field offset: 0x10
		public int Offset; //Field offset: 0x18

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Chunk(Byte[] chunk) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public int Read(Byte[] buffer, int offset, int size) { }

	}

	private enum State
	{
		None = 0,
		PartialSize = 1,
		Body = 2,
		BodyFinished = 3,
		Trailer = 4,
	}

	private WebHeaderCollection headers; //Field offset: 0x10
	private int chunkSize; //Field offset: 0x18
	private int chunkRead; //Field offset: 0x1C
	private int totalWritten; //Field offset: 0x20
	private State state; //Field offset: 0x24
	private StringBuilder saved; //Field offset: 0x28
	private bool sawCR; //Field offset: 0x30
	private bool gotit; //Field offset: 0x31
	private int trailerState; //Field offset: 0x34
	private ArrayList chunks; //Field offset: 0x38

	public int ChunkLeft
	{
		[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 7
	}

	public bool DataAvailable
	{
		[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 267
	}

	public bool WantMore
	{
		[CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 22
	}

	[CalledBy(Type = typeof(ChunkedInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public MonoChunkParser(WebHeaderCollection headers) { }

	[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public int get_ChunkLeft() { }

	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_DataAvailable() { }

	[CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_WantMore() { }

	[CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private State GetChunkSize(Byte[] buffer, ref int offset, int size) { }

	[CalledBy(Type = typeof(MonoChunkParser), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void InternalWrite(Byte[] buffer, ref int offset, int size) { }

	[CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int Read(Byte[] buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private State ReadBody(Byte[] buffer, ref int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private State ReadCRLF(Byte[] buffer, ref int offset, int size) { }

	[CalledBy(Type = typeof(MonoChunkParser), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.MonoChunkStream+<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	[CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private State ReadTrailer(Byte[] buffer, ref int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string RemoveChunkExtension(string input) { }

	[CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "ReadCRLF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(State))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void ThrowProtocolViolation(string message) { }

	[CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	public void Write(Byte[] buffer, int offset, int size) { }

}

