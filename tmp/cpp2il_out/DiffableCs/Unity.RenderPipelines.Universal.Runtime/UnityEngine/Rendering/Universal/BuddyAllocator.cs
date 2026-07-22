namespace UnityEngine.Rendering.Universal;

internal struct BuddyAllocator : IDisposable
{
	private struct Header
	{
		public int branchingOrder; //Field offset: 0x0
		public int levelCount; //Field offset: 0x4
		public int allocationCount; //Field offset: 0x8
		public int freeAllocationIdsCount; //Field offset: 0xC

	}

	private Void* m_Data; //Field offset: 0x0
	private ValueTuple<Int32, Int32> m_ActiveFreeMaskCounts; //Field offset: 0x8
	private ValueTuple<Int32, Int32> m_FreeMasksStorage; //Field offset: 0x10
	private ValueTuple<Int32, Int32> m_FreeMaskIndicesStorage; //Field offset: 0x18
	private Allocator m_Allocator; //Field offset: 0x20

	private NativeArray<Int32> freeMaskCounts
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		private get { } //Length: 99
	}

	private NativeArray<Int32> freeMaskIndicesStorage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		private get { } //Length: 99
	}

	private NativeArray<UInt64> freeMasksStorage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		private get { } //Length: 99
	}

	private Header header
	{
		[CalledBy(Type = typeof(BuddyAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BuddyAllocation&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BuddyAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuddyAllocation)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		private get { } //Length: 55
	}

	public int levelCount
	{
		[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReflectionProbeManager), Member = "GetScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(float4))]
		[CallerCount(Count = 4)]
		 get { } //Length: 61
	}

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuddyAllocator), Member = "AllocateRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(BuddyAllocator), Member = "AllocateRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuddyAllocator), Member = "FreeMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt64>))]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[ContainsUnimplementedInstructions]
	public BuddyAllocator(int levelCount, int branchingOrder, Allocator allocator = 4) { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = "AllocateRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int AlignForward(int offset, int alignment) { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BuddyAllocator), Member = "AlignForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static ValueTuple<Int32, Int32> AllocateRange(int length, ref int dataSize) { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BuddyAllocator), Member = "FreeMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt64>))]
	[Calls(Type = typeof(BuddyAllocator), Member = "FreeMaskIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(BuddyAllocator), Member = "get_header", ReturnType = typeof(Header&))]
	[ContainsUnimplementedInstructions]
	public void Free(BuddyAllocation allocation) { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BuddyAllocation&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuddyAllocation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[ContainsUnimplementedInstructions]
	private NativeArray<Int32> FreeMaskIndices(int level) { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BuddyAllocation&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuddyAllocation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[ContainsUnimplementedInstructions]
	private NativeArray<UInt64> FreeMasks(int level) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	private NativeArray<Int32> get_freeMaskCounts() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	private NativeArray<Int32> get_freeMaskIndicesStorage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	private NativeArray<UInt64> get_freeMasksStorage() { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BuddyAllocation&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuddyAllocation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private Header get_header() { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "GetScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(float4))]
	[CallerCount(Count = 4)]
	public int get_levelCount() { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = "get_freeMaskCounts", ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "get_freeMasksStorage", ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt64>))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "FreeMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt64>))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "get_freeMaskIndicesStorage", ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "FreeMaskIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BuddyAllocation&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BuddyAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuddyAllocation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BuddyAllocator), Member = "PtrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private NativeArray<T> GetNativeArray(int offset, int length) { }

	[CallerCount(Count = 0)]
	private static int LevelLength(int level, int branchingOrder) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int LevelLength64(int level, int branchingOrder) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int LevelOffset(int level, int branchingOrder) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int LevelOffset64(int level, int branchingOrder) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static int Pow2(int n) { }

	[CallerCount(Count = 0)]
	private static int Pow2N(int x, int n) { }

	[CalledBy(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static Void* PtrAdd(Void* ptr, int bytes) { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuddyAllocator), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(BuddyAllocator), Member = "FreeMaskIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[Calls(Type = typeof(BuddyAllocator), Member = "FreeMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt64>))]
	[Calls(Type = typeof(BuddyAllocator), Member = "get_header", ReturnType = typeof(Header&))]
	[ContainsUnimplementedInstructions]
	public bool TryAllocate(int requestedLevel, out BuddyAllocation allocation) { }

}

