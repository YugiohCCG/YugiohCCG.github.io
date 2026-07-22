namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafePtrListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct UnsafePtrList : INativeDisposable, IDisposable, IEnumerable<IntPtr>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ParallelReader
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly T** Ptr; //Field offset: 0x0
		public readonly int Length; //Field offset: 0x0

		[CallerCount(Count = 371)]
		[DeduplicatedMethod]
		internal ParallelReader(T** ptr, int length) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool Contains(Void* ptr) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int IndexOf(Void* ptr) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly T** Ptr; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		public UnsafeList<IntPtr>* ListData; //Field offset: 0x0

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal ParallelWriter(T** ptr, UnsafeList<IntPtr>* listData) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void AddNoResize(T* value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeList`1), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public void AddRangeNoResize(T** ptr, int count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeList`1), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void AddRangeNoResize(UnsafePtrList<T> list) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ReadOnly
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly T** Ptr; //Field offset: 0x0
		public readonly int Length; //Field offset: 0x0

		public bool IsCreated
		{
			[CallerCount(Count = 19)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 8
		}

		public bool IsEmpty
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 138
		}

		[CallerCount(Count = 371)]
		[DeduplicatedMethod]
		internal ReadOnly(T** ptr, int length) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool Contains(Void* ptr) { }

		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsCreated() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsEmpty() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int IndexOf(Void* ptr) { }

	}

	[NativeDisableUnsafePtrRestriction]
	public readonly T** Ptr; //Field offset: 0x0
	public readonly int m_length; //Field offset: 0x0
	public readonly int m_capacity; //Field offset: 0x0
	public readonly AllocatorHandle Allocator; //Field offset: 0x0
	private readonly int padding; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 185
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 142
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 208
	}

	public T* Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 11
	}

	public int Length
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 185
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 142
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UnsafePtrList`1(T** ptr, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public UnsafePtrList`1(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void Add(in IntPtr value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void Add(Void* value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void AddNoResize(Void* value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void AddRange(UnsafePtrList<T> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void AddRange(Void* ptr, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void AddRangeNoResize(Void** ptr, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void AddRangeNoResize(UnsafePtrList<T> list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ParallelReader<T> AsParallelReader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ParallelWriter<T> AsParallelWriter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ReadOnly<T> AsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Contains(Void* ptr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static UnsafePtrList<T>* Create(T** ptr, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static UnsafePtrList<T>* Create(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public static void Destroy(UnsafePtrList<T>* listData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T* ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Capacity() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T* get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int IndexOf(Void* ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void RemoveAtSwapBack(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void RemoveRange(int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveRangeSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void RemoveRangeSwapBack(int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Resize(int length, NativeArrayOptions options = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Item(int index, T* value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<IntPtr> System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.IntPtr>), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void TrimExcess() { }

}

