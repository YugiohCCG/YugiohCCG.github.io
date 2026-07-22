namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal struct UnsafeQueueData
{
	internal const int m_BlockSize = 16384; //Field offset: 0x0
	public IntPtr m_FirstBlock; //Field offset: 0x0
	public IntPtr m_LastBlock; //Field offset: 0x8
	public int m_MaxItems; //Field offset: 0x10
	public int m_CurrentRead; //Field offset: 0x14
	public Byte* m_CurrentWriteBlockTLS; //Field offset: 0x18

	[CalledBy(Type = typeof(UnsafeQueue`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionHelper), Member = "Align", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static void AllocateQueue(AllocatorHandle allocator, out UnsafeQueueData* outBuf) { }

	[CalledBy(Type = typeof(ParallelWriter), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParallelWriter), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParallelWriter), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParallelWriter), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static UnsafeQueueBlockHeader* AllocateWriteBlockMT(UnsafeQueueData* data, AllocatorHandle allocator, int threadIndex) { }

	[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DeallocateQueue(UnsafeQueueData* data, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	internal UnsafeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex) { }

	[CallerCount(Count = 0)]
	internal void SetCurrentWriteBlockTLS(int threadIndex, UnsafeQueueBlockHeader* currentWriteBlock) { }

}

