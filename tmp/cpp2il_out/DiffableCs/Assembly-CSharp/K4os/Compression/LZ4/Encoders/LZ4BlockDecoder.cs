namespace K4os.Compression.LZ4.Encoders;

public class LZ4BlockDecoder : UnmanagedResources, ILZ4Decoder, IDisposable
{
	private readonly int _blockSize; //Field offset: 0x18
	private readonly int _outputLength; //Field offset: 0x1C
	private int _outputIndex; //Field offset: 0x20
	private readonly Byte* _outputBuffer; //Field offset: 0x28

	public override int BlockSize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override int BytesReady
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	public LZ4BlockDecoder(int blockSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedResources), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(LZ4Codec), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override int Decode(Byte* source, int length, int blockSize = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedResources), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Drain(Byte* target, int offset, int length) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_BlockSize() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_BytesReady() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnmanagedResources), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override int Inject(Byte* source, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void ReleaseUnmanaged() { }

}

