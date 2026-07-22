namespace UnityEngine.Rendering;

internal class ProbeBrickPool
{
	[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
	internal struct BrickChunkAlloc
	{
		public int x; //Field offset: 0x0
		public int y; //Field offset: 0x4
		public int z; //Field offset: 0x8

		[CallerCount(Count = 0)]
		internal int flattenIndex(int sx, int sy) { }

	}

	internal struct DataLocation
	{
		internal Texture TexL0_L1rx; //Field offset: 0x0
		internal Texture TexL1_G_ry; //Field offset: 0x8
		internal Texture TexL1_B_rz; //Field offset: 0x10
		internal Texture TexL2_0; //Field offset: 0x18
		internal Texture TexL2_1; //Field offset: 0x20
		internal Texture TexL2_2; //Field offset: 0x28
		internal Texture TexL2_3; //Field offset: 0x30
		internal Texture TexProbeOcclusion; //Field offset: 0x38
		internal Texture TexValidity; //Field offset: 0x40
		internal Texture TexSkyOcclusion; //Field offset: 0x48
		internal Texture TexSkyShadingDirectionIndices; //Field offset: 0x50
		internal int width; //Field offset: 0x58
		internal int height; //Field offset: 0x5C
		internal int depth; //Field offset: 0x60

		[CalledBy(Type = typeof(ProbeBrickPool), Member = "EnsureTextureValidity", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeBrickPool), Member = "EnsureTextureValidity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ProbeBrickPool), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 11)]
		internal void Cleanup() { }

	}

	internal static readonly int _Out_L0_L1Rx; //Field offset: 0x0
	internal const int kBrickProbeCountPerDim = 4; //Field offset: 0x0
	internal const int kBrickCellCount = 3; //Field offset: 0x0
	private const int kChunkSizeInBricks = 128; //Field offset: 0x0
	private const int kMaxPoolWidth = 2048; //Field offset: 0x0
	internal const int kBrickProbeCountTotal = 64; //Field offset: 0x0
	internal const int kChunkProbeCountPerDim = 512; //Field offset: 0x0
	internal static readonly int _Out_L1G_L1Ry; //Field offset: 0x4
	internal static readonly int _Out_L1B_L1Rz; //Field offset: 0x8
	internal static readonly int _Out_Shared; //Field offset: 0xC
	internal static readonly int _Out_ProbeOcclusion; //Field offset: 0x10
	internal static readonly int _Out_SkyOcclusionL0L1; //Field offset: 0x14
	internal static readonly int _Out_SkyShadingDirectionIndices; //Field offset: 0x18
	internal static readonly int _Out_L2_0; //Field offset: 0x1C
	internal static readonly int _Out_L2_1; //Field offset: 0x20
	internal static readonly int _Out_L2_2; //Field offset: 0x24
	internal static readonly int _Out_L2_3; //Field offset: 0x28
	internal static readonly int _ProbeVolumeScratchBufferLayout; //Field offset: 0x2C
	internal static readonly int _ProbeVolumeScratchBuffer; //Field offset: 0x30
	private static ComputeShader s_DataUploadCS; //Field offset: 0x38
	private static int s_DataUploadKernel; //Field offset: 0x40
	private static ComputeShader s_DataUploadL2CS; //Field offset: 0x48
	private static int s_DataUploadL2Kernel; //Field offset: 0x50
	private static LocalKeyword s_DataUpload_Shared; //Field offset: 0x58
	private static LocalKeyword s_DataUpload_ProbeOcclusion; //Field offset: 0x70
	private static LocalKeyword s_DataUpload_SkyOcclusion; //Field offset: 0x88
	private static LocalKeyword s_DataUpload_SkyShadingDirection; //Field offset: 0xA0
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x10
	internal DataLocation m_Pool; //Field offset: 0x18
	private BrickChunkAlloc m_NextFreeChunk; //Field offset: 0x80
	private Stack<BrickChunkAlloc> m_FreeList; //Field offset: 0x90
	private int m_AvailableChunkCount; //Field offset: 0x98
	private ProbeVolumeSHBands m_SHBands; //Field offset: 0x9C
	private bool m_ContainsValidity; //Field offset: 0xA0
	private bool m_ContainsProbeOcclusion; //Field offset: 0xA1
	private bool m_ContainsRenderingLayers; //Field offset: 0xA2
	private bool m_ContainsSkyOcclusion; //Field offset: 0xA3
	private bool m_ContainsSkyShadingDirection; //Field offset: 0xA4

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static ProbeBrickPool() { }

	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "AllocateResourcesIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ProbeBrickPool), Member = "AllocatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = false, bool allocateRenderingLayerData = false, bool allocateSkyOcclusion = false, bool allocateSkyShadingData = false, bool allocateProbeOcclusionData = false) { }

	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "LoadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ReservePoolChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), Member = "Pop", ReturnType = typeof(BrickChunkAlloc))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeBrickPool), Member = "Deallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog) { }

	[CalledBy(Type = typeof(ProbeBrickPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeTextureMemoryBudget), typeof(ProbeVolumeSHBands), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeBrickPool), Member = "EnsureTextureValidity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeBrickPool), Member = "EnsureTextureValidity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ProbeBrickPool), Member = "CreateDataLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ProbeVolumeSHBands), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(DataLocation))]
	[CallsUnknownMethods(Count = 1)]
	internal void AllocatePool(int width, int height, int depth) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataLocation), Member = "Cleanup", ReturnType = typeof(void))]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CalledBy(Type = typeof(ProbeBrickPool), Member = "AllocatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProbeBrickPool), Member = "CreateDataTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 14)]
	public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, out int allocatedBytes) { }

	[CalledBy(Type = typeof(ProbeBrickPool), Member = "CreateDataLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ProbeVolumeSHBands), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(DataLocation))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes) { }

	[CalledBy(Type = typeof(ProbeBrickPool), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "Deallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CancelStreamingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RemoveCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "LoadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ReleasePoolChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ReleaseBricks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BrickChunkAlloc)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void Deallocate(List<BrickChunkAlloc> allocations) { }

	[CallerCount(Count = 0)]
	private static void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth) { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static int DivRoundUp(int x, int y) { }

	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "EnsureTextureValidity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "PerformPendingLoading", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataLocation), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeBrickPool), Member = "AllocatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal void EnsureTextureValidity() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataLocation), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeBrickPool), Member = "AllocatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion) { }

	[CallerCount(Count = 0)]
	private static int EstimateMemoryCost(int width, int height, int depth, GraphicsFormat format) { }

	[CallerCount(Count = 0)]
	internal static int EstimateMemoryCostForBlending(ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, ProbeVolumeSHBands bands) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_estimatedVMemCost() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal static int GetChunkCount(int brickCount) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal static int GetChunkSizeInBrickCount() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal static int GetChunkSizeInProbeCount() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ProbeVolumeShadingParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal Vector3Int GetPoolDimensions() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int GetPoolHeight() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int GetPoolWidth() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal Texture GetProbeOcclusionTexture() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetRemainingChunkCount() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "BindAPVRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "GetRuntimeResources", ReturnType = typeof(RuntimeResources))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal Texture GetSkyOcclusionTexture() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal Texture GetSkyShadingDirectionIndicesTexture() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal Texture GetValidityTexture() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSystemParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static void Initialize() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CreateInstancedProbes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(CellInstancedDebugProbes))]
	[CallerCount(Count = 1)]
	internal static Vector3Int ProbeCountToDataLocSize(int numProbes) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_estimatedVMemCost(int value) { }

	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataLocation), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(int), typeof(ProbeVolumeSHBands), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(PerScenarioData), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Graphics), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands) { }

	[CalledBy(Type = typeof(ProbeBrickBlendingPool), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CellStreamingScratchBuffer), typeof(CellStreamingScratchBufferLayout), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(ProbeVolumeSHBands), typeof(int), typeof(Texture), typeof(bool), typeof(Texture), typeof(bool), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(CellStreamingScratchBuffer), typeof(CellStreamingScratchBufferLayout), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstantBuffer), Member = "Push", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CellStreamingScratchBufferLayout)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CellStreamingScratchBufferLayout&), typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	internal void Update(CommandBuffer cmd, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, List<BrickChunkAlloc> dstLocations, bool updateSharedData, Texture validityTexture, ProbeVolumeSHBands bands, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateSharedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Graphics), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex) { }

}

