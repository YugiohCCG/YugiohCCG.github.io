namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal struct Memory
{
	[GenerateTestsForBurstCompatibility]
	public struct Array
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		internal static void Clear(T* pointer, long count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		internal static void Copy(T* dest, T* src, long count) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		internal static void Set(T* pointer, long count, T t = null) { }

	}

	[GenerateTestsForBurstCompatibility]
	public struct Unmanaged
	{
		[GenerateTestsForBurstCompatibility]
		public struct Array
		{

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			internal static T* Allocate(long count, AllocatorHandle allocator) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 2)]
			private static Void* CustomResize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			internal static void Free(T* pointer, long count, AllocatorHandle allocator) { }

			[CallerCount(Count = 4)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			private static bool IsCustom(AllocatorHandle allocator) { }

			[CalledBy(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(long), typeof(long), typeof(AllocatorHandle)}, ReturnType = "T*")]
			[CalledBy(Type = typeof(UnsafeText), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText*))]
			[CalledBy(Type = typeof(UnsafeBitArray), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeBitArray*))]
			[CalledBy(Type = typeof(UnsafeAppendBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(NativeBitArrayUnsafeUtility), Member = "ConvertExistingDataToNativeBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(NativeBitArray))]
			[CalledBy(Type = typeof(UnsafeAppendBuffer), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(NativeBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
			[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
			[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 4)]
			internal static Void* Resize(Void* oldPointer, long oldCount, long newCount, AllocatorHandle allocator, long size, int align) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
			internal static T* Resize(T* oldPointer, long oldCount, long newCount, AllocatorHandle allocator) { }

		}


		[CalledBy(Type = typeof(AllocatorManager), Member = "TryLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue`1<T>*")]
		[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeParallelHashMapData), Member = "ReallocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(int), typeof(long), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeParallelHashMapData), Member = "AllocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), typeof(AllocatorHandle), typeof(UnsafeParallelHashMapData*&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HashMapHelper`1), Member = "ResizeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HashMapHelper`1), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*")]
		[CalledBy(Type = typeof(HashMapHelper`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.UnsafeQueue`1<T>*")]
		[CalledBy(Type = typeof(UnsafeQueueData), Member = "AllocateQueue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(UnsafeQueueData*&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SegmentSortMerge), Member = "Execute", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SegmentSortMerge), Member = "Execute", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeReference`1), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), "Unity.Collections.NativeReference`1<T>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ArrayOfArrays`1), Member = "LockfreeAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayOfArrays`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "CreateAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(bool), typeof(int)}, ReturnType = "T&")]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UnsafeQueueData), Member = "AllocateWriteBlockMT", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(UnsafeQueueBlockHeader*))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		internal static Void* Allocate(long size, int align, AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		internal static T* Allocate(AllocatorHandle allocator) { }

		[CalledBy(Type = typeof(AllocatorManager), Member = "TryLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayOfArrays`1), Member = "LockfreeAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayOfArrays`1), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayOfArrays`1), Member = "TrimExcess", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoFreeAllocator), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoFreeAllocator), Member = "FreeAll", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeReference`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		internal static void Free(Void* pointer, AllocatorHandle allocator) { }

		[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue`1<T>*"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HashMapHelper`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeBitArray), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeBitArray), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeBitArray*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeText), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnsafeQueueData), Member = "DeallocateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeTextDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeText), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeBitArrayDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeBitArray), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayOfArrays`1), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		internal static void Free(T* pointer, AllocatorHandle allocator) { }

	}

	internal const long k_MaximumRamSizeInBytes = 1099511627776; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckByteCountIsReasonable(long size) { }

}

