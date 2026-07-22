namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct UnsafeQueue : INativeDisposable, IDisposable
{
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeQueueBlockHeader* m_FirstBlock; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeQueueBlockHeader* m_Block; //Field offset: 0x0
		internal int m_Index; //Field offset: 0x0
		private T value; //Field offset: 0x0

		public override T Current
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 94
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public override T get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
		internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0
		[NativeSetThreadIndex]
		internal int m_ThreadIndex; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeQueueData), Member = "AllocateWriteBlockMT", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(UnsafeQueueBlockHeader*))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void Enqueue(T value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeQueueData), Member = "AllocateWriteBlockMT", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(UnsafeQueueBlockHeader*))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void Enqueue(T value, int threadIndexOverride) { }

	}

	[DefaultMember("Item")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[NativeDisableUnsafePtrRestriction]
		private UnsafeQueueData* m_Buffer; //Field offset: 0x0

		public int Count
		{
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 88
		}

		public bool IsCreated
		{
			[CallerCount(Count = 19)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 8
		}

		public T Item
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 163
		}

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal ReadOnly(ref UnsafeQueue<T>& data) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Count() { }

		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsCreated() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public T get_Item(int index) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Enumerator<T> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool IsEmpty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		[IsReadOnly]
		private void ThrowIndexOutOfRangeException(int index) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		private bool TryGetValue(int index, out T item) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public int Count
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 88
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
	[Calls(Type = typeof(UnsafeQueueData), Member = "AllocateQueue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(UnsafeQueueData*&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafeQueue`1(AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeQueue`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static UnsafeQueue<T>* Alloc(AllocatorHandle allocator) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ParallelWriter<T> AsParallelWriter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnly<T> AsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void CheckNotEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T Dequeue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeQueueData), Member = "DeallocateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeQueueData), Member = "AllocateWriteBlockMT", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(UnsafeQueueBlockHeader*))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Enqueue(T value) { }

	[CalledBy(Type = typeof(NativeQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeQueueDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeQueueData), Member = "DeallocateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeQueueData*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static void Free(UnsafeQueue<T>* data) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Count() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CalledBy(Type = typeof(NativeQueue`1), Member = "IsEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool IsEmpty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T Peek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void ThrowEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public NativeArray<T> ToArray(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryDequeue(out T item) { }

}

