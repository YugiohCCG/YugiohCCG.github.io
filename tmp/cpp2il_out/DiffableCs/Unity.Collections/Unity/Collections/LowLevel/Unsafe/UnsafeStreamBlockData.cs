namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
internal struct UnsafeStreamBlockData
{
	internal const int AllocationSize = 4096; //Field offset: 0x0
	internal AllocatorHandle Allocator; //Field offset: 0x0
	internal UnsafeStreamBlock** Blocks; //Field offset: 0x8
	internal int BlockCount; //Field offset: 0x10
	internal Block Ranges; //Field offset: 0x18
	internal int RangeCount; //Field offset: 0x38

	[CalledBy(Type = typeof(Writer), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal UnsafeStreamBlock* Allocate(UnsafeStreamBlock* oldBlock, int threadIndex) { }

	[CalledBy(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	internal void Free(UnsafeStreamBlock* oldBlock) { }

}

