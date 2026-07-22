namespace System.Buffers;

public abstract class MemoryPool : IDisposable
{
	private static readonly MemoryPool<T> s_shared; //Field offset: 0x0

	public static MemoryPool<T> Shared
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 153
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayMemoryPool`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static MemoryPool`1() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected MemoryPool`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	protected abstract void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static MemoryPool<T> get_Shared() { }

	public abstract IMemoryOwner<T> Rent(int minBufferSize = -1) { }

}

