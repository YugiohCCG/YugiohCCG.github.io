namespace UnityEngine.Rendering;

internal class ProbeBrickIndex
{
	[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
	internal struct Brick : IEquatable<Brick>
	{
		public Vector3Int position; //Field offset: 0x0
		public int subdivisionLevel; //Field offset: 0xC

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Brick(Vector3Int position, int subdivisionLevel) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool Equals(Brick other) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool IntersectArea(Bounds boundInBricksToCheck) { }

	}

	internal struct CellIndexUpdateInfo
	{
		public IndirectionEntryUpdateInfo[] entriesInfo; //Field offset: 0x0

		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DefragComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(Cell)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		public int GetNumberOfChunks() { }

	}

	internal struct IndirectionEntryUpdateInfo
	{
		public int firstChunkIndex; //Field offset: 0x0
		public int numberOfChunks; //Field offset: 0x4
		public int minSubdivInCell; //Field offset: 0x8
		public Vector3Int minValidBrickIndexForCellAtMaxRes; //Field offset: 0xC
		public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne; //Field offset: 0x18
		public Vector3Int entryPositionInBricksAtMaxRes; //Field offset: 0x24
		public bool hasOnlyBiggerBricks; //Field offset: 0x30

	}

	internal const int kMaxSubdivisionLevels = 7; //Field offset: 0x0
	internal const int kIndexChunkSize = 243; //Field offset: 0x0
	internal const int kFailChunkIndex = -1; //Field offset: 0x0
	internal const int kEmptyIndex = -2; //Field offset: 0x0
	private BitArray m_IndexChunks; //Field offset: 0x10
	private BitArray m_IndexChunksCopyForChecks; //Field offset: 0x18
	private int m_ChunksCount; //Field offset: 0x20
	private int m_AvailableChunkCount; //Field offset: 0x24
	private ComputeBuffer m_PhysicalIndexBuffer; //Field offset: 0x28
	private NativeArray<Int32> m_PhysicalIndexBufferData; //Field offset: 0x30
	private ComputeBuffer m_DebugFragmentationBuffer; //Field offset: 0x40
	private Int32[] m_DebugFragmentationData; //Field offset: 0x48
	private bool m_NeedUpdateIndexComputeBuffer; //Field offset: 0x50
	private int m_UpdateMinIndex; //Field offset: 0x54
	private int m_UpdateMaxIndex; //Field offset: 0x58
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private float <fragmentationRate>k__BackingField; //Field offset: 0x60
	private Vector3Int m_CenterRS; //Field offset: 0x64

	internal int estimatedVMemCost
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	internal float fragmentationRate
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "SetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "GetEntrySubdivLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ProbeBrickIndex), Member = "MarkBrickInPhysicalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndirectionEntryUpdateInfo&), typeof(Vector3Int), typeof(Vector3Int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void AddBricks(CellIndexInfo cellInfo, NativeArray<Brick> bricks, List<BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeEntryMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndirectionEntryInfo&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.ProbeBrickIndex+Brick>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool BrickOverlapEntry(Vector3Int brickMin, Vector3Int brickMax, Vector3Int entryMin, Vector3Int entryMax) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SafeRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "StartIndexDefragmentation", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "SetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(ProbeVolumesOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void ComputeFragmentationRate() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "LoadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "SetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	internal bool FindSlotsForEntries(ref IndirectionEntryUpdateInfo[] entriesInfo) { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_estimatedVMemCost() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal float get_fragmentationRate() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal ComputeBuffer GetDebugFragmentationBuffer() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "LoadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetNumberOfChunks(int brickCount) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int GetRemainingChunkCount() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "BindAPVRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "GetRuntimeResources", ReturnType = typeof(RuntimeResources))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeBrickIndex), Member = "UpdateDebugData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	[CallerCount(Count = 0)]
	private static int LocationToIndex(int x, int y, int z, Vector3Int sizeOfValid) { }

	[CalledBy(Type = typeof(ProbeBrickIndex), Member = "AddBricks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CellIndexInfo), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ProbeBrickIndex+Brick>), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void MarkBrickInPhysicalBuffer(in IndirectionEntryUpdateInfo entry, Vector3Int brickMin, Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx) { }

	[CallerCount(Count = 0)]
	private int MergeIndex(int index, int size) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CancelStreamingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RemoveCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ReleaseBricks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BitArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveBricks(CellIndexInfo cellInfo) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "LoadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal bool ReserveChunks(IndirectionEntryUpdateInfo[] entriesInfo, bool ignoreErrorLog) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_estimatedVMemCost(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_fragmentationRate(float value) { }

	[CallerCount(Count = 0)]
	private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	[CalledBy(Type = typeof(ProbeBrickIndex), Member = "GetRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeResources&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUtils), Member = "SafeRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateDebugData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UploadIndexData() { }

}

