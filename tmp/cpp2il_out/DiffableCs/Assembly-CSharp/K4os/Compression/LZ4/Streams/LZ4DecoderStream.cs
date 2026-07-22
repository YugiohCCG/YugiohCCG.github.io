namespace K4os.Compression.LZ4.Streams;

public class LZ4DecoderStream : LZ4StreamBase
{
	[CompilerGenerated]
	private struct <DisposeAsync>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<DisposeImpl>d__9"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeImpl>d__9&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(Stream), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncValueTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisposeImpl>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "CloseFrame", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter), typeof(<DisposeImpl>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredValueTaskAwaiter&), typeof(<DisposeImpl>d__9&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureFrame>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<ReadFrame>d__6"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFrame>d__6&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Peek1>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<Peek1>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<Peek1>d__4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Peek2>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UInt16> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<Peek2>d__3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<Peek2>d__3&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Peek4>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UInt32> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<Peek4>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<Peek4>d__2&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Peek8>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UInt64> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<Peek8>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<Peek8>d__0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadBlock>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private int <blockLength>5__2; //Field offset: 0x30
		private bool <uncompressed>5__3; //Field offset: 0x34
		private ConfiguredTaskAwaiter<UInt32> <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "Peek4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "InjectOrDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "CloseFrame", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 24)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFrame>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private int <headerOffset>5__2; //Field offset: 0x30
		private bool <blockChaining>5__3; //Field offset: 0x34
		private bool <blockChecksum>5__4; //Field offset: 0x35
		private bool <contentChecksum>5__5; //Field offset: 0x36
		private bool <hasDictionary>5__6; //Field offset: 0x37
		private int <blockSizeCode>5__7; //Field offset: 0x38
		private Nullable<Int64> <contentLength>5__8; //Field offset: 0x40
		private Nullable<UInt32> <dictionaryId>5__9; //Field offset: 0x50
		private byte <actualHC>5__10; //Field offset: 0x58
		private ConfiguredTaskAwaiter<Nullable<UInt32>> <>u__1; //Field offset: 0x60
		private ConfiguredTaskAwaiter<UInt16> <>u__2; //Field offset: 0x70
		private ConfiguredTaskAwaiter<UInt64> <>u__3; //Field offset: 0x80
		private ConfiguredTaskAwaiter<UInt32> <>u__4; //Field offset: 0x90
		private ConfiguredTaskAwaiter<Byte> <>u__5; //Field offset: 0xA0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "Peek4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt32>))]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "InvalidHeaderChecksum", ReturnType = typeof(InvalidDataException))]
		[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Byte>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek1>d__4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek1>d__4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "UnknownFrameVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InvalidDataException))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt64>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt16>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek2>d__3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek2>d__3&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.UInt32>>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<TryPeek4>d__1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryPeek4>d__1&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<Peek8>d__0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek8>d__0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "MagicNumberExpected", ReturnType = typeof(InvalidDataException))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 50)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadImpl>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public Memory<Byte> buffer; //Field offset: 0x30
		private int <offset>5__2; //Field offset: 0x40
		private int <count>5__3; //Field offset: 0x44
		private int <read>5__4; //Field offset: 0x48
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4DecoderStream+<EnsureFrame>d__5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EnsureFrame>d__5&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "Drain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 14)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryPeek4>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Nullable`1<UInt32>> <>t__builder; //Field offset: 0x8
		public LZ4DecoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Extensions), Member = "TryReadBlockAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<TryPeek4>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<TryPeek4>d__1&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly bool _interactive; //Field offset: 0x50
	private readonly Func<ILZ4Descriptor, ILZ4Decoder> _decoderFactory; //Field offset: 0x58
	private ILZ4Descriptor _frameInfo; //Field offset: 0x60
	private ILZ4Decoder _decoder; //Field offset: 0x68
	private int _decoded; //Field offset: 0x70
	private Byte[] _buffer; //Field offset: 0x78
	private long _position; //Field offset: 0x80

	public virtual bool CanWrite
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 332
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public LZ4DecoderStream(Stream inner, Func<ILZ4Descriptor, ILZ4Decoder> decoderFactory, bool leaveOpen = false, bool interactive = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
	[CompilerGenerated]
	[DebuggerHidden]
	[DeduplicatedMethod]
	private ValueTask <>n__0() { }

	[CalledBy(Type = typeof(<DisposeImpl>d__9), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadBlock>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "DisposeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void CloseFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "CloseFrame", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__44))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeAsync>d__44)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeAsync>d__44&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(ValueTask))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual ValueTask DisposeAsync() { }

	[AsyncStateMachine(typeof(<DisposeImpl>d__9))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeImpl>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeImpl>d__9&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task DisposeImpl(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "CloseFrame", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl(EmptyToken token) { }

	[CalledBy(Type = typeof(<ReadImpl>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool Drain(Span<Byte> buffer, ref int offset, ref int count, ref int read) { }

	[AsyncStateMachine(typeof(<EnsureFrame>d__5))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EnsureFrame>d__5)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EnsureFrame>d__5&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> EnsureFrame(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	private bool EnsureFrame(EmptyToken token) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual long get_Length() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private long GetLength(EmptyToken token) { }

	[CalledBy(Type = typeof(<ReadBlock>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private int InjectOrDecode(int blockLength, bool uncompressed) { }

	[CalledBy(Type = typeof(<ReadFrame>d__6), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static InvalidDataException InvalidHeaderChecksum() { }

	[CalledBy(Type = typeof(<ReadFrame>d__6), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static InvalidDataException MagicNumberExpected() { }

	[CallerCount(Count = 0)]
	private static int MaxBlockSize(int blockSizeCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private byte Peek1(EmptyToken token) { }

	[AsyncStateMachine(typeof(<Peek1>d__4))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek1>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek1>d__4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Byte>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Byte>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Byte> Peek1(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private ushort Peek2(EmptyToken token) { }

	[AsyncStateMachine(typeof(<Peek2>d__3))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek2>d__3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek2>d__3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt16>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt16>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<UInt16> Peek2(CancellationToken token) { }

	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private uint Peek4(EmptyToken token) { }

	[AsyncStateMachine(typeof(<Peek4>d__2))]
	[CalledBy(Type = typeof(<ReadBlock>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFrame>d__6), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek4>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek4>d__2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<UInt32> Peek4(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Peek8>d__0))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek8>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Peek8>d__0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.UInt64>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.UInt64>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<UInt64> Peek8(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private ulong Peek8(EmptyToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	public virtual int Read(Span<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryExtensions), Member = "AsMemory", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = "System.Memory`1<T>")]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "Peek4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "InjectOrDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "CloseFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private int ReadBlock(EmptyToken token) { }

	[AsyncStateMachine(typeof(<ReadBlock>d__7))]
	[CalledBy(Type = typeof(<ReadImpl>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadBlock>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadBlock>d__7&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Int32> ReadBlock(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int ReadByte() { }

	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "EnsureFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "get_Length", ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "Peek4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "InvalidHeaderChecksum", ReturnType = typeof(InvalidDataException))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "UnknownFrameVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InvalidDataException))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "MagicNumberExpected", ReturnType = typeof(InvalidDataException))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	private bool ReadFrame(EmptyToken token) { }

	[AsyncStateMachine(typeof(<ReadFrame>d__6))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFrame>d__6)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFrame>d__6&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Boolean> ReadFrame(CancellationToken token) { }

	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "ReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LZ4DecoderStream), Member = "Drain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	private int ReadImpl(EmptyToken token, Span<Byte> buffer) { }

	[AsyncStateMachine(typeof(<ReadImpl>d__8))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadImpl>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadImpl>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Int32> ReadImpl(CancellationToken token, Memory<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "EndOfStream", ReturnType = typeof(EndOfStreamException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private Nullable<UInt32> TryPeek4(EmptyToken token) { }

	[AsyncStateMachine(typeof(<TryPeek4>d__1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryPeek4>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryPeek4>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.UInt32>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.UInt32>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Nullable`1<UInt32>> TryPeek4(CancellationToken token) { }

	[CalledBy(Type = typeof(<ReadFrame>d__6), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4DecoderStream), Member = "ReadFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static InvalidDataException UnknownFrameVersion(int version) { }

}

