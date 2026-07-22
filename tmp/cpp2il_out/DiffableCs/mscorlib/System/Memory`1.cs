namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
public struct Memory : IEquatable<Memory`1<T>>
{
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public int Length
	{
		[CallerCount(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Span<T> Span
	{
		[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<ReadImpl>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "K4os.Compression.LZ4.Streams.Internal.Extensions", Member = "ToSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>"}, ReturnType = "System.Span`1<Byte>")]
		[CalledBy(Type = typeof(Memory`1), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Memory`1), Member = "ToArray", ReturnType = "T[]")]
		[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 951
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Memory`1(T[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Memory`1(T[] array, int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Memory`1(T[] array, int start, int length) { }

	[CallerCount(Count = 94)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Memory`1(object obj, int start, int length) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static int CombineHashCodes(int left, int right) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static int CombineHashCodes(int h1, int h2, int h3) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Memory<T> other) { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<ReadImpl>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.Internal.Extensions", Member = "ToSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>"}, ReturnType = "System.Span`1<Byte>")]
	[CalledBy(Type = typeof(Memory`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Memory`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public Span<T> get_Span() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static Memory<T> op_Implicit(T[] array) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IOAsyncResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint&", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncResult", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint"}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(MemoryHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(GCHandle), typeof(IPinnable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public MemoryHandle Pin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public Memory<T> Slice(int start, int length) { }

	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "System.Net.Sockets.Socket")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&", typeof(Int32&), typeof(IAsyncResult)}, ReturnType = "System.Net.Sockets.Socket")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
	[Calls(Type = typeof(System.Span`1<System.Byte>), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

