namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
public struct NativeStream : INativeDisposable, IDisposable
{
	[BurstCompile]
	private struct ConstructJob : IJob
	{
		public NativeStream Container; //Field offset: 0x0
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
		public NativeStream Container; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		public UntypedUnsafeList* List; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Execute() { }

	}

	[GenerateTestsForBurstCompatibility]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct Reader
	{
		private Reader m_Reader; //Field offset: 0x0

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
		internal Reader(ref NativeStream stream) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Reader), Member = "BeginForEachIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		public int BeginForEachIndex(int foreachIndex) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		private void CheckBeginForEachIndex(int forEachIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckEndForEachIndex() { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		private void CheckNotReadingOutOfBounds(int size) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[DeduplicatedMethod]
		private void CheckRead() { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		private void CheckReadSize(int size) { }

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
		[CallsUnknownMethods(Count = 1)]
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
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	internal struct Writer
	{
		private Writer m_Writer; //Field offset: 0x0

		public int ForEachCount
		{
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 32
		}

		[CallerCount(Count = 0)]
		internal Writer(ref NativeStream stream) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Writer), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public T Allocate() { }

		[CalledBy(Type = typeof(Writer), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T&")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Writer), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
		public Byte* Allocate(int size) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void BeginForEachIndex(int foreachIndex) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		private void CheckAllocateSize(int size) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		private void CheckBeginForEachIndex(int foreachIndex) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		private void CheckEndForEachIndex() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Writer), Member = "EndForEachIndex", ReturnType = typeof(void))]
		public void EndForEachIndex() { }

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int get_ForEachCount() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public void PatchMinMaxRange(int foreEachIndex) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public void Write(T value) { }

	}

	private UnsafeStream m_Stream; //Field offset: 0x0

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
	public NativeStream(int bufferCount, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeStream), Member = "ScheduleConstruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeStream&), "Unity.Collections.NativeList`1<T>", typeof(JobHandle), typeof(AllocatorHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	private static void AllocateBlock(out NativeStream stream, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private void AllocateForEach(int forEachCount) { }

	[CallerCount(Count = 0)]
	public Reader AsReader() { }

	[CallerCount(Count = 0)]
	public Writer AsWriter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckForEachCountGreaterThanZero(int forEachCount) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	private void CheckRead() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Count", ReturnType = typeof(int))]
	public int Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeStreamDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeStreamDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "IsEmpty", ReturnType = typeof(bool))]
	[IsReadOnly]
	public bool IsEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJobList)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJobList), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static JobHandle ScheduleConstruct(out NativeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public static JobHandle ScheduleConstruct(out NativeStream stream, NativeArray<Int32> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

