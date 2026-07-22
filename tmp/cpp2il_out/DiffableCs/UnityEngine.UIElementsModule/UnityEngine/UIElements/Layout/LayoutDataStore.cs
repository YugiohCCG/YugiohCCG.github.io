namespace UnityEngine.UIElements.Layout;

internal struct LayoutDataStore : IDisposable
{
	private struct Chunk
	{
		[NativeDisableUnsafePtrRestriction]
		public Byte* Buffer; //Field offset: 0x0

	}

	private struct ComponentDataStore : IDisposable
	{
		public Allocator Allocator; //Field offset: 0x0
		public int Size; //Field offset: 0x4
		public int ComponentCountPerChunk; //Field offset: 0x8
		public int ChunkCount; //Field offset: 0xC
		[NativeDisableUnsafePtrRestriction]
		private Chunk* m_Chunks; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public ComponentDataStore(int size, Allocator allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

		[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetTypedNodeDataRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutNodeDataType)}, ReturnType = "T&")]
		[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetTypedConfigDataRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutConfigDataType)}, ReturnType = "T&")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public Byte* GetComponentDataPtr(int index) { }

		[CalledBy(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutDataStore), Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public void ResizeCapacity(int capacity) { }

	}

	private struct Data
	{
		public int Capacity; //Field offset: 0x0
		public int NextFreeIndex; //Field offset: 0x4
		public int ComponentCount; //Field offset: 0x8
		[NativeDisableUnsafePtrRestriction]
		public Int32* Versions; //Field offset: 0x10
		[NativeDisableUnsafePtrRestriction]
		public ComponentDataStore* Components; //Field offset: 0x18

	}

	private const int k_ChunkSize = 32768; //Field offset: 0x0
	private readonly Allocator m_Allocator; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	private Data* m_Data; //Field offset: 0x8

	public bool IsValid
	{
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public LayoutDataStore(ComponentType[] components, int initialCapacity, Allocator allocator) { }

	[CalledBy(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&"}, ReturnType = typeof(LayoutHandle))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(LayoutHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private LayoutHandle Allocate(Byte** data, int count) { }

	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "CreateConfig", ReturnType = typeof(LayoutConfig))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(int)}, ReturnType = typeof(LayoutHandle))]
	[DeduplicatedMethod]
	public LayoutHandle Allocate(in T0 component0) { }

	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(int)}, ReturnType = typeof(LayoutHandle))]
	[DeduplicatedMethod]
	public LayoutHandle Allocate(in T0 component0, in T1 component1, in T2 component2, in T3 component3) { }

	[CalledBy(Type = typeof(LayoutManager), Member = "Shutdown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Exists(in LayoutHandle handle) { }

	[CalledBy(Type = typeof(LayoutManager), Member = "DestroyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "TryFreeNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = "FreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void Free(in LayoutHandle handle) { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsValid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	internal Void* GetComponentDataPtr(int index, int componentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int GetNextFreeIndex(ComponentDataStore* ptr, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void IncreaseCapacity() { }

	[CalledBy(Type = typeof(ComponentDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private static Void* ResizeArray(Void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator) { }

	[CalledBy(Type = typeof(LayoutDataStore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComponentType[]), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte**), typeof(int)}, ReturnType = typeof(LayoutHandle))]
	[CalledBy(Type = typeof(LayoutDataStore), Member = "IncreaseCapacity", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ComponentDataStore), Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ResizeCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void SetNextFreeIndex(ComponentDataStore* ptr, int index, int value) { }

}

