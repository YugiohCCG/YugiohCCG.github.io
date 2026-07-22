namespace UnityEngine.Rendering;

internal class ProbeGlobalIndirection
{
	public struct IndexMetaData
	{
		private static UInt32[] s_PackedValues; //Field offset: 0x0
		internal Vector3Int minLocalIdx; //Field offset: 0x0
		internal Vector3Int maxLocalIdxPlusOne; //Field offset: 0xC
		internal int firstChunkIndex; //Field offset: 0x18
		internal int minSubdiv; //Field offset: 0x1C

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static IndexMetaData() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		internal void Pack(out UInt32[] vals) { }

	}

	private const int kUintPerEntry = 3; //Field offset: 0x0
	internal const int kEntryMaxSubdivLevel = 3; //Field offset: 0x0
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x10
	private ComputeBuffer m_IndexOfIndicesBuffer; //Field offset: 0x18
	private UInt32[] m_IndexOfIndicesData; //Field offset: 0x20
	private int m_CellSizeInMinBricks; //Field offset: 0x28
	private Vector3Int m_EntriesCount; //Field offset: 0x2C
	private Vector3Int m_EntryMin; //Field offset: 0x38
	private Vector3Int m_EntryMax; //Field offset: 0x44
	private bool m_NeedUpdateComputeBuffer; //Field offset: 0x50

	internal int entriesPerCellDimension
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ProbeVolumeShadingParameters)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 64
	}

	private int entrySizeInBricks
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 40
	}

	internal int estimatedVMemCost
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitializeGlobalIndirection", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal ProbeGlobalIndirection(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetSubdivisionDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitializeGlobalIndirection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetMaxSubdivision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CoreUtils), Member = "SafeRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ProbeVolumeShadingParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int get_entriesPerCellDimension() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int get_entrySizeInBricks() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_estimatedVMemCost() { }

	[CallerCount(Count = 0)]
	internal int GetFlatIdxForEntry(Vector3Int entryPosition) { }

	[CallerCount(Count = 0)]
	private int GetFlatIndex(Vector3Int normalizedPos) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal Int32[] GetFlatIndicesForCell(Vector3Int cellPosition) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Vector3Int GetGlobalIndirectionDimension() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Vector3Int GetGlobalIndirectionMinEntry() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ProbeVolumeShadingParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void GetMinMaxEntry(out Vector3Int minEntry, out Vector3Int maxEntry) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "BindAPVRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "GetRuntimeResources", ReturnType = typeof(RuntimeResources))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RemoveCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void MarkEntriesAsUnloaded(Int32[] entriesFlatIndices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void PushComputeData() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_estimatedVMemCost(int value) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void UpdateCell(CellIndexInfo cellInfo) { }

}

