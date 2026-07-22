namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct CullingJob : IJobParallelFor
{
	private enum CrossFadeType
	{
		kDisabled = 0,
		kCrossFadeOut = 1,
		kCrossFadeIn = 2,
		kVisible = 3,
	}

	public const int k_BatchSize = 32; //Field offset: 0x0
	private const uint k_LODFadeZeroPacked = 127; //Field offset: 0x0
	private const float k_LODPercentInvisible = 0; //Field offset: 0x0
	private const float k_LODPercentFullyVisible = 1; //Field offset: 0x0
	private const float k_LODPercentSpeedTree = 2; //Field offset: 0x0
	private const float k_SmallMeshTransitionWidth = 0.1; //Field offset: 0x0
	[ReadOnly]
	public BinningConfig binningConfig; //Field offset: 0x0
	[ReadOnly]
	public BatchCullingViewType viewType; //Field offset: 0x8
	[ReadOnly]
	public float3 cameraPosition; //Field offset: 0xC
	[ReadOnly]
	public float sqrScreenRelativeMetric; //Field offset: 0x18
	[ReadOnly]
	public float minScreenRelativeHeight; //Field offset: 0x1C
	[ReadOnly]
	public bool isOrtho; //Field offset: 0x20
	[ReadOnly]
	public bool cullLightmappedShadowCasters; //Field offset: 0x21
	[ReadOnly]
	public int maxLOD; //Field offset: 0x24
	[ReadOnly]
	public uint cullingLayerMask; //Field offset: 0x28
	[ReadOnly]
	public ulong sceneCullingMask; //Field offset: 0x30
	[ReadOnly]
	public NativeArray<PlanePacket4> frustumPlanePackets; //Field offset: 0x38
	[ReadOnly]
	public NativeArray<SplitInfo> frustumSplitInfos; //Field offset: 0x48
	[ReadOnly]
	public NativeArray<Plane> lightFacingFrustumPlanes; //Field offset: 0x58
	[ReadOnly]
	public NativeArray<SplitInfo> receiverSplitInfos; //Field offset: 0x68
	public float3x3 worldToLightSpaceRotation; //Field offset: 0x78
	[ReadOnly]
	public ReadOnly instanceData; //Field offset: 0xA0
	[ReadOnly]
	public ReadOnly sharedInstanceData; //Field offset: 0x178
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	public NativeList<LODGroupCullingData> lodGroupCullingData; //Field offset: 0x218
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	public IntPtr occlusionBuffer; //Field offset: 0x220
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x228
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray<Byte> rendererCrossFadeValues; //Field offset: 0x238

	[CalledBy(Type = typeof(CullingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnly), Member = "UnsafeElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(LODGroupRenderingUtils), Member = "CalculateSqrPerspectiveDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LODGroupRenderingUtils), Member = "CalculateLODDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LODGroupCullingData&))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private float CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags) { }

	[CalledBy(Type = typeof(CullingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnly), Member = "UnsafeElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(FrustumPlaneCuller), Member = "ComputeSplitVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.FrustumPlaneCuller+PlanePacket4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.FrustumPlaneCuller+SplitInfo>), typeof(AABB&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ReceiverSphereCuller), Member = "ComputeSplitVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ReceiverSphereCuller+SplitInfo>), typeof(float3x3), typeof(AABB&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BatchRendererGroup), Member = "OcclusionTestAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Bounds)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CullingJob), Member = "CalculateVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(InstanceFlags)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CullingJob), Member = "CalculateLODVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(InstanceFlags)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CullingJob), Member = "PackFloatToUint8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override void Execute(int instanceIndex) { }

	[CalledBy(Type = typeof(CullingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static uint PackFloatToUint8(float percent) { }

}

