namespace UnityEngine.Rendering;

internal class ProbeVolumeScratchBufferPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<ScratchBufferPool> <>9__26_0; //Field offset: 0x8
		public static Predicate<ScratchBufferPool> <>9__27_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <AllocateScratchBuffer>b__26_0(ScratchBufferPool o) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ReleaseScratchBuffer>b__27_0(ScratchBufferPool o) { }

	}

	[DebuggerDisplay("ChunkCount = {chunkCount} ElementCount = {pool.Count}")]
	private class ScratchBufferPool : IComparable<ScratchBufferPool>
	{
		public int chunkCount; //Field offset: 0x10
		public Stack<CellStreamingScratchBuffer> pool; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public ScratchBufferPool(int chunkCount) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private ScratchBufferPool() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override int CompareTo(ScratchBufferPool other) { }

	}

	private static int s_ChunkCount; //Field offset: 0x0
	[CompilerGenerated]
	private int <chunkSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <maxChunkCount>k__BackingField; //Field offset: 0x14
	private int m_L0Size; //Field offset: 0x18
	private int m_L1Size; //Field offset: 0x1C
	private int m_ValiditySize; //Field offset: 0x20
	private int m_ValidityLayerCount; //Field offset: 0x24
	private int m_L2Size; //Field offset: 0x28
	private int m_ProbeOcclusionSize; //Field offset: 0x2C
	private int m_SkyOcclusionSize; //Field offset: 0x30
	private int m_SkyShadingDirectionSize; //Field offset: 0x34
	private int m_CurrentlyAllocatedChunkCount; //Field offset: 0x38
	private List<ScratchBufferPool> m_Pools; //Field offset: 0x40
	private Dictionary<Int32, CellStreamingScratchBufferLayout> m_Layouts; //Field offset: 0x48

	public int allocatedMemory
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public private int chunkSize
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int maxChunkCount
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AllocateScratchBufferPoolIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateDiskStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public ProbeVolumeScratchBufferPool(ProbeVolumeBakingSet bakingSet, ProbeVolumeSHBands shBands) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ProcessDiskStreamingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CellStreamingRequest)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProbeVolumeScratchBufferPool), Member = "GetOrCreateScratchBufferLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CellStreamingScratchBufferLayout))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeScratchBufferPool), Member = "CreateScratchBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(CellStreamingScratchBuffer))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public bool AllocateScratchBuffer(int chunkCount, out CellStreamingScratchBuffer scratchBuffer, out CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CleanupStreaming", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AllocateScratchBufferPoolIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateDiskStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadBakingSet", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CellStreamingScratchBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Cleanup() { }

	[CalledBy(Type = typeof(ProbeVolumeScratchBufferPool), Member = "AllocateScratchBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CellStreamingScratchBuffer&), typeof(CellStreamingScratchBufferLayout&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(UsageFlags), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers) { }

	[CallerCount(Count = 0)]
	public int get_allocatedMemory() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_chunkSize() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_maxChunkCount() { }

	[CalledBy(Type = typeof(ProbeVolumeScratchBufferPool), Member = "AllocateScratchBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CellStreamingScratchBuffer&), typeof(CellStreamingScratchBufferLayout&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBufferLayout>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CellStreamingScratchBufferLayout&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBufferLayout>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CellStreamingScratchBufferLayout)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateActiveRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CellStreamingScratchBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ReleaseScratchBuffer(CellStreamingScratchBuffer scratchBuffer) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_chunkSize(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_maxChunkCount(int value) { }

}

