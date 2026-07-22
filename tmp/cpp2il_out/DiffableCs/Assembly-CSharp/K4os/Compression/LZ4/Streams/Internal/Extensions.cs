namespace K4os.Compression.LZ4.Streams.Internal;

[Extension]
internal static class Extensions
{
	[CompilerGenerated]
	private struct <TryReadBlockAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public Stream stream; //Field offset: 0x20
		public Byte[] buffer; //Field offset: 0x28
		public int offset; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public CancellationToken token; //Field offset: 0x38
		public bool optional; //Field offset: 0x40
		private int <progress>5__2; //Field offset: 0x44
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Peek8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "TryPeek4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(System.Nullable`1<System.UInt32>))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Peek4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Peek2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Peek1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<TryReadBlockAsync>d__10), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Extensions), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "InnerReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken&), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Stash), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static EndOfStreamException EndOfStream() { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Extension]
	public static ReadOnlySpan<Byte> ToSpan(ReadOnlySpan<Byte> span) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
	[Extension]
	public static ReadOnlySpan<Byte> ToSpan(ReadOnlyMemory<Byte> span) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Extension]
	public static Span<Byte> ToSpan(Span<Byte> span) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
	[Extension]
	public static Span<Byte> ToSpan(Memory<Byte> span) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static int TryReadBlock(Stream stream, Byte[] buffer, int offset, int count, bool optional) { }

	[AsyncStateMachine(typeof(<TryReadBlockAsync>d__10))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek1>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek2>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek4>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek8>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<ReadBlock>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream+<TryPeek4>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4StreamBase), Member = "InnerReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken&), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(Stash), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(int), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryReadBlockAsync>d__10)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryReadBlockAsync>d__10&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static Task<Int32> TryReadBlockAsync(Stream stream, Byte[] buffer, int offset, int count, bool optional, CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static ConfiguredTaskAwaitable<T> Weave(Task<T> task) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static ConfiguredTaskAwaitable Weave(Task task) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static ConfiguredValueTaskAwaitable<T> Weave(ValueTask<T> task) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static ConfiguredValueTaskAwaitable Weave(ValueTask task) { }

}

