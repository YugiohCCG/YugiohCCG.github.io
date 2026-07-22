namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
internal struct StringBuffer
{
	private Char[] _buffer; //Field offset: 0x0
	private int _position; //Field offset: 0x8

	public Char[] InternalBuffer
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public int Position
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(JsonTextReader), Member = "EnsureBufferNotEmpty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 1)]
	public StringBuffer(IArrayPool<Char> bufferPool, int initalSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	private StringBuffer(Char[] buffer) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "WriteCharToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Append(IArrayPool<Char> bufferPool, char value) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "WriteCharToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	public void Append(IArrayPool<Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Clear(IArrayPool<Char> bufferPool) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureSize(IArrayPool<Char> bufferPool, int appendLength) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Char[] get_InternalBuffer() { }

	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Position() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_Position(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	public string ToString(int start, int length) { }

}

