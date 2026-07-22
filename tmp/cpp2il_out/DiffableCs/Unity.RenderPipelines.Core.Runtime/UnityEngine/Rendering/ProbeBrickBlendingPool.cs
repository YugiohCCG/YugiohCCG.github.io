namespace UnityEngine.Rendering;

internal class ProbeBrickBlendingPool
{
	private static ComputeShader stateBlendShader; //Field offset: 0x0
	private static int scenarioBlendingKernel; //Field offset: 0x8
	private static readonly int _PoolDim_LerpFactor; //Field offset: 0xC
	private static readonly int _ChunkList; //Field offset: 0x10
	private static readonly int _State0_L0_L1Rx; //Field offset: 0x14
	private static readonly int _State0_L1G_L1Ry; //Field offset: 0x18
	private static readonly int _State0_L1B_L1Rz; //Field offset: 0x1C
	private static readonly int _State0_L2_0; //Field offset: 0x20
	private static readonly int _State0_L2_1; //Field offset: 0x24
	private static readonly int _State0_L2_2; //Field offset: 0x28
	private static readonly int _State0_L2_3; //Field offset: 0x2C
	private static readonly int _State0_ProbeOcclusion; //Field offset: 0x30
	private static readonly int _State1_L0_L1Rx; //Field offset: 0x34
	private static readonly int _State1_L1G_L1Ry; //Field offset: 0x38
	private static readonly int _State1_L1B_L1Rz; //Field offset: 0x3C
	private static readonly int _State1_L2_0; //Field offset: 0x40
	private static readonly int _State1_L2_1; //Field offset: 0x44
	private static readonly int _State1_L2_2; //Field offset: 0x48
	private static readonly int _State1_L2_3; //Field offset: 0x4C
	private static readonly int _State1_ProbeOcclusion; //Field offset: 0x50
	private Vector4[] m_ChunkList; //Field offset: 0x10
	private int m_MappedChunks; //Field offset: 0x18
	private ProbeBrickPool m_State0; //Field offset: 0x20
	private ProbeBrickPool m_State1; //Field offset: 0x28
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; //Field offset: 0x30
	private ProbeVolumeSHBands m_ShBands; //Field offset: 0x34
	private bool m_ProbeOcclusion; //Field offset: 0x38

	internal int estimatedVMemCost
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "GetVideoMemoryCost", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 549
	}

	internal bool isAllocated
	{
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static ProbeBrickBlendingPool() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool probeOcclusion) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "AddBlendingBricks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProbeBrickPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeTextureMemoryBudget), typeof(ProbeVolumeSHBands), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeBrickPool), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeBrickPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeTextureMemoryBudget), typeof(ProbeVolumeSHBands), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void AllocateResourcesIfNeeded() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateBlendingCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	internal void BlendChunks(Cell cell, ProbeBrickPool dstPool) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataLocation), Member = "Cleanup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RemoveCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadBlendingCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllBlendingCells", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ProbeBrickPool), Member = "Deallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Deallocate(List<BrickChunkAlloc> allocations) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "PerformPendingLoading", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProbeBrickPool), Member = "EnsureTextureValidity", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void EnsureTextureValidity() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "GetVideoMemoryCost", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_estimatedVMemCost() { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_isAllocated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetPoolDepth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetPoolHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetPoolWidth() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSystemParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void Initialize() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateBlendingCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(CellStreamingScratchBuffer), typeof(CellStreamingScratchBufferLayout), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProbeBrickPool), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CellStreamingScratchBuffer), typeof(CellStreamingScratchBufferLayout), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(bool), typeof(Texture), typeof(ProbeVolumeSHBands), typeof(bool), typeof(Texture), typeof(bool), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void Update(CommandBuffer cmd, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, List<BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands, int state, Texture validityTexture, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(PerScenarioData), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProbeBrickPool), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataLocation), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ProbeBrickPool+BrickChunkAlloc>), typeof(int), typeof(ProbeVolumeSHBands)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state) { }

}

