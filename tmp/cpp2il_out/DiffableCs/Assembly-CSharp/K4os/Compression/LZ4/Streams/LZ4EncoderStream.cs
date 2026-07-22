namespace K4os.Compression.LZ4.Streams;

public class LZ4EncoderStream : LZ4StreamBase
{
	[CompilerGenerated]
	private struct <CloseFrame>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LZ4EncoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "FlushAndEncode", ReturnType = typeof(BlockInfo))]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(BlockInfo)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "ContentChecksum", ReturnType = typeof(System.Nullable`1<System.UInt32>))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(Stash), Member = "Flush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LZ4EncoderStream <>4__this; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4EncoderStream+<DisposeImpl>d__2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeImpl>d__2&)}, ReturnType = typeof(void))]
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
	private struct <DisposeImpl>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LZ4EncoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Streams.LZ4EncoderStream+<CloseFrame>d__1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseFrame>d__1&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteBlock>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BlockInfo block; //Field offset: 0x20
		public LZ4EncoderStream <>4__this; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "BlockLengthCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockInfo&)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Stash), Member = "Flush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteImpl>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LZ4EncoderStream <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public ReadOnlyMemory<Byte> buffer; //Field offset: 0x30
		private int <offset>5__2; //Field offset: 0x40
		private int <count>5__3; //Field offset: 0x44
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Stash), Member = "Flush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "TopupAndEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(BlockInfo))]
		[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(BlockInfo)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private ILZ4Encoder _encoder; //Field offset: 0x50
	private readonly Func<ILZ4Descriptor, ILZ4Encoder> _encoderFactory; //Field offset: 0x58
	private readonly ILZ4Descriptor _descriptor; //Field offset: 0x60
	private Byte[] _buffer; //Field offset: 0x68
	private long _position; //Field offset: 0x70

	public virtual bool CanRead
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual long Length
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual long Position
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public LZ4EncoderStream(Stream inner, ILZ4Descriptor descriptor, Func<ILZ4Descriptor, ILZ4Encoder> encoderFactory, bool leaveOpen = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stream), Member = "DisposeAsync", ReturnType = typeof(ValueTask))]
	[CompilerGenerated]
	[DebuggerHidden]
	[DeduplicatedMethod]
	private ValueTask <>n__0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 5)]
	private Nullable<UInt32> BlockChecksum(BlockInfo block) { }

	[CalledBy(Type = typeof(<WriteBlock>d__0), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	private static uint BlockLengthCode(in BlockInfo block) { }

	[AsyncStateMachine(typeof(<CloseFrame>d__1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseFrame>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseFrame>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task CloseFrame(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "FlushAndEncode", ReturnType = typeof(BlockInfo))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(BlockInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "ContentChecksum", ReturnType = typeof(System.Nullable`1<System.UInt32>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CloseFrame(EmptyToken token) { }

	[CalledBy(Type = typeof(<CloseFrame>d__1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "CloseFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "DisposeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 5)]
	private Nullable<UInt32> ContentChecksum() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private ILZ4Encoder CreateEncoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "FlushAndEncode", ReturnType = typeof(BlockInfo))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(BlockInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "ContentChecksum", ReturnType = typeof(System.Nullable`1<System.UInt32>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__31))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeAsync>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeAsync>d__31&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncValueTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(ValueTask))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual ValueTask DisposeAsync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "FlushAndEncode", ReturnType = typeof(BlockInfo))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(BlockInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "ContentChecksum", ReturnType = typeof(System.Nullable`1<System.UInt32>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl(EmptyToken token) { }

	[AsyncStateMachine(typeof(<DisposeImpl>d__2))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeImpl>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DisposeImpl>d__2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task DisposeImpl(CancellationToken token) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Flush() { }

	[CalledBy(Type = typeof(<CloseFrame>d__1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "CloseFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "DisposeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private BlockInfo FlushAndEncode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual long get_Length() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual long get_Position() { }

	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "MaxBlockSizeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	 ArgumentException InvalidBlockSize(int blockSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "InvalidBlockSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 2)]
	private int MaxBlockSizeCode(int blockSize) { }

	[CalledBy(Type = typeof(<WriteImpl>d__3), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private BlockInfo TopupAndEncode(ReadOnlySpan<Byte> buffer, ref int offset, ref int count) { }

	[CalledBy(Type = typeof(<WriteImpl>d__3), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4Codec), Member = "MaximumOutputSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LZ4StreamBase), Member = "InvalidValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "InvalidBlockSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArgumentException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	private bool TryStashFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(System.ReadOnlyMemory`1<System.Byte>)}, ReturnType = typeof(Task))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryExtensions), Member = "AsMemory", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = "System.Memory`1<T>")]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(System.ReadOnlyMemory`1<System.Byte>)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteBlock>d__0))]
	[CalledBy(Type = typeof(<CloseFrame>d__1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteImpl>d__3), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteBlock>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteBlock>d__0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task WriteBlock(CancellationToken token, BlockInfo block) { }

	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "CloseFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "DisposeImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Stash), Member = "Stash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(LZ4StreamBase), Member = "NotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotImplementedException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void WriteBlock(EmptyToken token, BlockInfo block) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stash), Member = "OneByteSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(System.Span`1<System.Byte>))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	public virtual void WriteByte(byte value) { }

	[AsyncStateMachine(typeof(<WriteImpl>d__3))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteImpl>d__3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteImpl>d__3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task WriteImpl(CancellationToken token, ReadOnlyMemory<Byte> buffer) { }

	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "TryStashFrame", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "TopupAndEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(BlockInfo))]
	[Calls(Type = typeof(LZ4EncoderStream), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EmptyToken), typeof(BlockInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteImpl(EmptyToken token, ReadOnlySpan<Byte> buffer) { }

}

