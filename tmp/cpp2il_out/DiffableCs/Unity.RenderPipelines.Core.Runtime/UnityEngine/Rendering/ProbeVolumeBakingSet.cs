namespace UnityEngine.Rendering;

public sealed class ProbeVolumeBakingSet : ScriptableObject, ISerializationCallbackReceiver
{
	public struct CellCounts
	{
		public int bricksCount; //Field offset: 0x0
		public int chunksCount; //Field offset: 0x4

		[CallerCount(Count = 0)]
		public void Add(CellCounts o) { }

	}

	public class PerScenarioDataInfo
	{
		public int sceneHash; //Field offset: 0x10
		public ProbeVolumeStreamableAsset cellDataAsset; //Field offset: 0x18
		public ProbeVolumeStreamableAsset cellOptionalDataAsset; //Field offset: 0x20
		public ProbeVolumeStreamableAsset cellProbeOcclusionDataAsset; //Field offset: 0x28
		private bool m_HasValidData; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PerScenarioDataInfo() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool ComputeHasValidData(ProbeVolumeSHBands shBands) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public bool HasValidData(ProbeVolumeSHBands shBands) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public void Initialize(ProbeVolumeSHBands shBands) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		public bool IsValid() { }

	}

	public struct ProbeLayerMask
	{
		public RenderingLayerMask mask; //Field offset: 0x0
		public string name; //Field offset: 0x8

	}

	private struct SerializedPerSceneCellList
	{
		public string sceneGUID; //Field offset: 0x0
		public List<Int32> cellList; //Field offset: 0x8

	}

	public enum Version
	{
		Initial = 0,
		RemoveProbeVolumeSceneData = 1,
		AssetsAlwaysReferenced = 2,
	}

	internal const int k_MaxSkyOcclusionBakingSamples = 8192; //Field offset: 0x0
	[SerializeField]
	internal bool singleSceneMode; //Field offset: 0x18
	[SerializeField]
	internal bool dialogNoProbeVolumeInSetShown; //Field offset: 0x19
	[SerializeField]
	internal ProbeVolumeBakingProcessSettings settings; //Field offset: 0x1C
	[SerializeField]
	private List<String> m_SceneGUIDs; //Field offset: 0x50
	[FormerlySerializedAs("scenesToNotBake")]
	[Obsolete("This is now contained in the SceneBakeData structure")]
	[SerializeField]
	internal List<String> obsoleteScenesToNotBake; //Field offset: 0x58
	[FormerlySerializedAs("lightingScenarios")]
	[SerializeField]
	internal List<String> m_LightingScenarios; //Field offset: 0x60
	[SerializeField]
	internal SerializedDictionary<Int32, CellDesc> cellDescs; //Field offset: 0x68
	internal Dictionary<Int32, CellData> cellDataMap; //Field offset: 0x70
	private List<Int32> m_TotalIndexList; //Field offset: 0x78
	[SerializeField]
	private List<SerializedPerSceneCellList> m_SerializedPerSceneCellList; //Field offset: 0x80
	internal Dictionary<String, List`1<Int32>> perSceneCellLists; //Field offset: 0x88
	[SerializeField]
	internal ProbeVolumeStreamableAsset cellSharedDataAsset; //Field offset: 0x90
	[SerializeField]
	internal SerializedDictionary<String, PerScenarioDataInfo> scenarios; //Field offset: 0x98
	[SerializeField]
	internal ProbeVolumeStreamableAsset cellBricksDataAsset; //Field offset: 0xA0
	[SerializeField]
	internal ProbeVolumeStreamableAsset cellSupportDataAsset; //Field offset: 0xA8
	[SerializeField]
	internal int chunkSizeInBricks; //Field offset: 0xB0
	[SerializeField]
	internal Vector3Int maxCellPosition; //Field offset: 0xB4
	[SerializeField]
	internal Vector3Int minCellPosition; //Field offset: 0xC0
	[SerializeField]
	internal Bounds globalBounds; //Field offset: 0xCC
	[SerializeField]
	internal int bakedSimplificationLevels; //Field offset: 0xE4
	[SerializeField]
	internal float bakedMinDistanceBetweenProbes; //Field offset: 0xE8
	[SerializeField]
	internal bool bakedProbeOcclusion; //Field offset: 0xEC
	[SerializeField]
	internal int bakedSkyOcclusionValue; //Field offset: 0xF0
	[SerializeField]
	internal int bakedSkyShadingDirectionValue; //Field offset: 0xF4
	[SerializeField]
	internal Vector3 bakedProbeOffset; //Field offset: 0xF8
	[SerializeField]
	internal int bakedMaskCount; //Field offset: 0x104
	[SerializeField]
	internal uint4 bakedLayerMasks; //Field offset: 0x108
	[SerializeField]
	internal int maxSHChunkCount; //Field offset: 0x118
	[SerializeField]
	internal int L0ChunkSize; //Field offset: 0x11C
	[SerializeField]
	internal int L1ChunkSize; //Field offset: 0x120
	[SerializeField]
	internal int L2TextureChunkSize; //Field offset: 0x124
	[SerializeField]
	internal int ProbeOcclusionChunkSize; //Field offset: 0x128
	[SerializeField]
	internal int sharedValidityMaskChunkSize; //Field offset: 0x12C
	[SerializeField]
	internal int sharedSkyOcclusionL0L1ChunkSize; //Field offset: 0x130
	[SerializeField]
	internal int sharedSkyShadingDirectionIndicesChunkSize; //Field offset: 0x134
	[SerializeField]
	internal int sharedDataChunkSize; //Field offset: 0x138
	[SerializeField]
	internal int supportPositionChunkSize; //Field offset: 0x13C
	[SerializeField]
	internal int supportValidityChunkSize; //Field offset: 0x140
	[SerializeField]
	internal int supportTouchupChunkSize; //Field offset: 0x144
	[SerializeField]
	internal int supportLayerMaskChunkSize; //Field offset: 0x148
	[SerializeField]
	internal int supportOffsetsChunkSize; //Field offset: 0x14C
	[SerializeField]
	internal int supportDataChunkSize; //Field offset: 0x150
	[SerializeField]
	internal string lightingScenario; //Field offset: 0x158
	private string m_OtherScenario; //Field offset: 0x160
	private float m_ScenarioBlendingFactor; //Field offset: 0x168
	private ReadCommandArray m_ReadCommandArray; //Field offset: 0x170
	private NativeArray<ReadCommand> m_ReadCommandBuffer; //Field offset: 0x180
	private Stack<NativeArray`1<Byte>> m_ReadOperationScratchBuffers; //Field offset: 0x190
	private List<Int32> m_PrunedIndexList; //Field offset: 0x198
	private List<Int32> m_PrunedScenarioIndexList; //Field offset: 0x1A0
	[SerializeField]
	private Version version; //Field offset: 0x1A8
	[SerializeField]
	internal bool freezePlacement; //Field offset: 0x1AC
	[SerializeField]
	public Vector3 probeOffset; //Field offset: 0x1B0
	[Range(2, 5)]
	public int simplificationLevels; //Field offset: 0x1BC
	[Min(0.1)]
	public float minDistanceBetweenProbes; //Field offset: 0x1C0
	public LayerMask renderersLayerMask; //Field offset: 0x1C4
	[Min(0)]
	public float minRendererVolumeSize; //Field offset: 0x1C8
	public bool skyOcclusion; //Field offset: 0x1CC
	[Logarithmic(1, 8192)]
	public int skyOcclusionBakingSamples; //Field offset: 0x1D0
	[Range(0, 5)]
	public int skyOcclusionBakingBounces; //Field offset: 0x1D4
	[Range(0, 1)]
	public float skyOcclusionAverageAlbedo; //Field offset: 0x1D8
	public bool skyOcclusionBackFaceCulling; //Field offset: 0x1DC
	public bool skyOcclusionShadingDirection; //Field offset: 0x1DD
	[SerializeField]
	internal bool useRenderingLayers; //Field offset: 0x1DE
	[SerializeField]
	internal ProbeLayerMask[] renderingLayerMasks; //Field offset: 0x1E0
	private bool m_HasSupportData; //Field offset: 0x1E8
	private bool m_SharedDataIsValid; //Field offset: 0x1E9
	private bool m_UseStreamingAsset; //Field offset: 0x1EA

	internal bool bakedSkyOcclusion
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_skyOcclusion", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 28
	}

	internal bool bakedSkyShadingDirection
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_skyOcclusionShadingDirection", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 28
	}

	public int cellSizeInBricks
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 37
	}

	public float cellSizeInMeters
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 82
	}

	internal bool hasDilation
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 24
	}

	public IReadOnlyList<String> lightingScenarios
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int maxSubdivision
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 9
	}

	public float minBrickSize
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 31
	}

	internal string otherScenario
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal float scenarioBlendingFactor
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 9
	}

	public IReadOnlyList<String> sceneGUIDs
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "GetLastEnumValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	public ProbeVolumeBakingSet() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "GetSubArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(int), typeof(Int32&)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	private static int AlignUp16(int count) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "set_scenarioBlendingFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "BlendLightingScenario", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "<RegisterDebug>b__42_84", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "ScenarioBlendingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool CheckCompatibleCellLayout() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadBakingSet", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileHandle), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Stack`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	internal void Cleanup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool ComputeHasSupportData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool ComputeHasValidSharedData() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal uint4 ComputeRegionMasks() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncReadManager), Member = "GetFileInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfoResult*)}, ReturnType = typeof(ReadHandle))]
	[Calls(Type = typeof(ReadHandle), Member = "get_JobHandle", ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private bool FileExists(string path) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_skyOcclusion", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_bakedSkyOcclusion() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_skyOcclusionShadingDirection", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_bakedSkyShadingDirection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_cellSizeInBricks() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_cellSizeInMeters() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_hasDilation() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public IReadOnlyList<String> get_lightingScenarios() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public int get_maxSubdivision() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public float get_minBrickSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal string get_otherScenario() { }

	[CallerCount(Count = 0)]
	internal float get_scenarioBlendingFactor() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public IReadOnlyList<String> get_sceneGUIDs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3Int), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int GetBakingHashCode() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal CellData GetCellData(int cellIndex) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal CellDesc GetCellDesc(int cellIndex) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static int GetCellSizeInBricks(int simplificationLevels) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AllocateScratchBufferPoolIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateDiskStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal int GetChunkGPUMemory(ProbeVolumeSHBands shBands) { }

	[CallerCount(Count = 0)]
	internal static int GetMaxSubdivision(int simplificationLevels) { }

	[CallerCount(Count = 0)]
	internal static float GetMinBrickSize(float minDistanceBetweenProbes) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddPendingSceneLoading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddPendingSceneRemoval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "PerformPendingLoading", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal List<Int32> GetSceneCellIndexList(string sceneGUID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "AlignUp16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private NativeArray<T> GetSubArray(NativeArray<Byte> input, int count, ref int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool HasBakedData(string scenario = null) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddPendingSceneLoading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal bool HasSameSceneGUIDs(ProbeVolumeBakingSet other) { }

	[CallerCount(Count = 0)]
	internal bool HasSupportData() { }

	[CallerCount(Count = 0)]
	internal bool HasValidSharedData() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "BlendLightingScenario", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	internal void Initialize(bool useStreamingAsset) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadHandle), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "CloseFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadHandle), Member = "get_JobHandle", ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(AsyncReadManager), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileHandle&), typeof(ReadCommandArray)}, ReturnType = typeof(ReadHandle))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "OpenFile", ReturnType = typeof(FileHandle))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "RequestScratchBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "HasValidAssetReference", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "RefreshAssetPath", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "FileExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "GetAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextAsset), Member = "GetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private NativeArray<T> LoadStreambleAssetData(ProbeVolumeStreamableAsset asset, List<Int32> cellIndices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUtils), Member = "GetLastEnumValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void Migrate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUtils), Member = "GetLastEnumValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void OnValidate() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void PruneCellIndexList(List<Int32> cellIndices, List<Int32> prunedIndexList) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void PruneCellIndexListForScenario(List<Int32> cellIndices, PerScenarioDataInfo scenarioData, List<Int32> prunedIndexList) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RemoveCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CellData), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void ReleaseCell(int cellIndex) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void ReleaseStreamableAssetData(NativeArray<T> buffer) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private NativeArray<Byte> RequestScratchBuffer(int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	private bool ResolveAllCellData() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "LoadCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumePerSceneData), Member = "ResolveCellData", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "PruneCellIndexList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "get_diskStreamingEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CellData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Rendering.ProbeReferenceVolume+CellData+PerScenarioData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PerScenarioData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	internal bool ResolveCellData(List<Int32> cellIndices) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveAllCellData", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "PruneCellIndexListForScenario", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(PerScenarioDataInfo), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(string), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ReleaseStreamableAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	internal bool ResolvePerScenarioCellData(List<Int32> cellIndices) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Byte>), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt16>))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Rendering.ProbeReferenceVolume+CellData+PerScenarioData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PerScenarioData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool ResolvePerScenarioCellData(NativeArray<Byte> cellData, NativeArray<Byte> cellOptionalData, NativeArray<Byte> cellProbeOcclusionData, string scenario, List<Int32> cellIndices) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "get_skyOcclusion", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Byte>), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt16>))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "get_skyOcclusionShadingDirection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Byte>), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ResolveSharedCellData(List<Int32> cellIndices, NativeArray<Brick> bricksData, NativeArray<Byte> cellSharedData, NativeArray<Byte> cellSupportData) { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveAllCellData", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Brick)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ProbeBrickIndex+Brick>))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ProbeBrickIndex+Brick>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ReleaseStreamableAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ReleaseStreamableAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Brick)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ProbeBrickIndex+Brick>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	internal bool ResolveSharedCellData(List<Int32> cellIndices) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_bakedSkyOcclusion(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_bakedSkyShadingDirection(bool value) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "set_lightingScenario", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetActiveScenario", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "ScenarioBlendingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void SetActiveScenario(string scenario, bool verbose = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 7)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

