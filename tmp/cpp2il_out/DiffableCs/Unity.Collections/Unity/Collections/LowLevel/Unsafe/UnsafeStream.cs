namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
public struct UnsafeStream : INativeDisposable, IDisposable
{
	[BurstCompile]
	private struct ConstructJob : IJob
	{
		public UnsafeStream Container; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<Int32> Length; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override void Execute() { }

	}

	[BurstCompile]
	private struct ConstructJobList : IJob
	{
		public UnsafeStream Container; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		public UntypedUnsafeList* List; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Execute() { }

	}

	[BurstCompile]
	private struct DisposeJob : IJob
	{
		public UnsafeStream Container; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
		public override void Execute() { }

	}

	[GenerateTestsForBurstCompatibility]
	internal struct Reader
	{
		[NativeDisableUnsafePtrRestriction]
		internal Block m_BlockData; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeStreamBlock* m_CurrentBlock; //Field offset: 0x20
		[NativeDisableUnsafePtrRestriction]
		internal Byte* m_CurrentPtr; //Field offset: 0x28
		[NativeDisableUnsafePtrRestriction]
		internal Byte* m_CurrentBlockEnd; //Field offset: 0x30
		internal int m_RemainingItemCount; //Field offset: 0x38
		internal int m_LastBlockSize; //Field offset: 0x3C

		public int ForEachCount
		{
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 32
		}

		public int RemainingItemCount
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		internal Reader(ref UnsafeStream stream) { }

		[CalledBy(Type = typeof(Reader), Member = "BeginForEachIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UnsafeStream), Member = "ToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public int BeginForEachIndex(int foreachIndex) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int Count() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public void EndForEachIndex() { }

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int get_ForEachCount() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public int get_RemainingItemCount() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public T Peek() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Reader), Member = "ReadUnsafePtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public T Read() { }

		[CalledBy(Type = typeof(Reader), Member = "Read", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T&")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public Byte* ReadUnsafePtr(int size) { }

	}

	[GenerateTestsForBurstCompatibility]
	internal struct Writer
	{
		[NativeDisableUnsafePtrRestriction]
		internal Block m_BlockData; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		private UnsafeStreamBlock* m_CurrentBlock; //Field offset: 0x20
		[NativeDisableUnsafePtrRestriction]
		private Byte* m_CurrentPtr; //Field offset: 0x28
		[NativeDisableUnsafePtrRestriction]
		private Byte* m_CurrentBlockEnd; //Field offset: 0x30
		internal int m_ForeachIndex; //Field offset: 0x38
		private int m_ElementCount; //Field offset: 0x3C
		[NativeDisableUnsafePtrRestriction]
		private UnsafeStreamBlock* m_FirstBlock; //Field offset: 0x40
		private int m_FirstOffset; //Field offset: 0x48
		private int m_NumberOfBlocks; //Field offset: 0x4C
		[NativeSetThreadIndex]
		private int m_ThreadIndex; //Field offset: 0x50

		public int ForEachCount
		{
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 32
		}

		[CallerCount(Count = 0)]
		internal Writer(ref UnsafeStream stream) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Writer), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public T Allocate() { }

		[CalledBy(Type = typeof(Writer), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
		[CalledBy(Type = typeof(Writer), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T&")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnsafeStreamBlockData), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*), typeof(int)}, ReturnType = typeof(UnsafeStreamBlock*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public Byte* Allocate(int size) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void BeginForEachIndex(int foreachIndex) { }

		[CalledBy(Type = typeof(Writer), Member = "EndForEachIndex", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public void EndForEachIndex() { }

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int get_ForEachCount() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public void Write(T value) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal Block m_BlockData; //Field offset: 0x0

	public int ForEachCount
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 32
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public UnsafeStream(int bufferCount, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStream), Member = "ScheduleConstruct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeStream&), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(JobHandle), typeof(AllocatorHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(NativeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStream), Member = "ScheduleConstruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), "Unity.Collections.NativeList`1<T>", typeof(JobHandle), typeof(AllocatorHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(UnsafeStream), Member = "ScheduleConstruct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(JobHandle), typeof(AllocatorHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
	[Calls(Type = typeof(Block), Member = "get_AllocatedBytes", ReturnType = typeof(long))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static void AllocateBlock(out UnsafeStream stream, AllocatorHandle allocator) { }

	[CalledBy(Type = "Unity.Collections.NativeStream+ConstructJobList", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeStream+ConstructJob", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstructJobList), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstructJob), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
	[Calls(Type = typeof(Block), Member = "get_AllocatedBytes", ReturnType = typeof(long))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void AllocateForEach(int forEachCount) { }

	[CalledBy(Type = typeof(UnsafeStream), Member = "ToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	public Reader AsReader() { }

	[CallerCount(Count = 0)]
	public Writer AsWriter() { }

	[CalledBy(Type = typeof(NativeStream), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnsafeStream), Member = "ToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int Count() { }

	[CalledBy(Type = typeof(NativeStream), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStreamDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeStreamDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStream), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeStreamBlockData), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Deallocate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_ForEachCount() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CalledBy(Type = typeof(NativeStream), Member = "IsEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IsReadOnly]
	public bool IsEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJobList)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJobList), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static JobHandle ScheduleConstruct(out UnsafeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public static JobHandle ScheduleConstruct(out UnsafeStream stream, NativeArray<Int32> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeStream), Member = "AsReader", ReturnType = typeof(Reader))]
	[Calls(Type = typeof(Reader), Member = "BeginForEachIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

