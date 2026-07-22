namespace System.Buffers;

internal sealed class ArrayMemoryPool : MemoryPool<T>
{
	private sealed class ArrayMemoryPoolBuffer : IMemoryOwner<T>, IDisposable
	{
		private T[] _array; //Field offset: 0x0

		public override Memory<T> Memory
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException_ArrayMemoryPoolBuffer", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 99
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ArrayMemoryPoolBuffer(int size) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowObjectDisposedException_ArrayMemoryPoolBuffer", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override Memory<T> get_Memory() { }

	}


	[CalledBy(Type = typeof(MemoryPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ArrayMemoryPool`1() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual IMemoryOwner<T> Rent(int minimumBufferSize = -1) { }

}

