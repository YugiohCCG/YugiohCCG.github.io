namespace Unity.Collections;

[DefaultMember("Item")]
internal struct ArrayOfArrays : IDisposable
{
	private AllocatorHandle m_backingAllocatorHandle; //Field offset: 0x0
	private int m_lengthInElements; //Field offset: 0x0
	private int m_capacityInElements; //Field offset: 0x0
	private int m_log2BlockSizeInElements; //Field offset: 0x0
	private int m_blocks; //Field offset: 0x0
	private IntPtr* m_block; //Field offset: 0x0

	private int BlockMask
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 45
	}

	private int BlockSizeInBytes
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 43
	}

	private int BlockSizeInElements
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 11
	}

	public int Capacity
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public T Item
	{
		[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoFreeAllocator), Member = "FreeAll", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 146
	}

	public int Length
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ArrayOfArrays`1(int capacityInElements, AllocatorHandle backingAllocatorHandle, int log2BlockSizeInElements = 12) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int BlockIndexOfElement(int elementIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void CheckBlockIndex(int blockIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void CheckBlockIsNotNull(int blockIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void CheckElementIndex(int elementIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int get_BlockMask() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int get_BlockSizeInBytes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int get_BlockSizeInElements() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "FreeAll", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T get_Item(int elementIndex) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void LockfreeAdd(T t) { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void RemoveAtSwapBack(int elementIndex) { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "FreeAll", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Rewind() { }

	[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void TrimExcess() { }

}

