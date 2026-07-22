namespace K4os.Compression.LZ4.Internal;

public abstract class UnmanagedResources : IDisposable
{
	private int _disposed; //Field offset: 0x10

	public bool IsDisposed
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 31
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected UnmanagedResources() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public bool get_IsDisposed() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void ReleaseManaged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void ReleaseUnmanaged() { }

	[CalledBy(Type = typeof(LZ4BlockDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4BlockDecoder), Member = "Inject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4BlockDecoder), Member = "Drain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4EncoderBase), Member = "Topup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4EncoderBase), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	protected void ThrowIfDisposed() { }

}

