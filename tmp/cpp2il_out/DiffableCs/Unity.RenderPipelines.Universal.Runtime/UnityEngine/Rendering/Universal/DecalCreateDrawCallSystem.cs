namespace UnityEngine.Rendering.Universal;

internal class DecalCreateDrawCallSystem
{
	[BurstCompile]
	private struct DrawCallJob : IJob
	{
		[ReadOnly]
		public NativeArray<float4x4> decalToWorlds; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<float4x4> normalToWorlds; //Field offset: 0x10
		[ReadOnly]
		public NativeArray<float4x4> sizeOffsets; //Field offset: 0x20
		[ReadOnly]
		public NativeArray<float2> drawDistances; //Field offset: 0x30
		[ReadOnly]
		public NativeArray<float2> angleFades; //Field offset: 0x40
		[ReadOnly]
		public NativeArray<float4> uvScaleBiases; //Field offset: 0x50
		[ReadOnly]
		public NativeArray<Int32> layerMasks; //Field offset: 0x60
		[ReadOnly]
		public NativeArray<UInt64> sceneLayerMasks; //Field offset: 0x70
		[ReadOnly]
		public NativeArray<Single> fadeFactors; //Field offset: 0x80
		[ReadOnly]
		public NativeArray<BoundingSphere> boundingSpheres; //Field offset: 0x90
		[ReadOnly]
		public NativeArray<UInt32> renderingLayerMasks; //Field offset: 0xA0
		public Vector3 cameraPosition; //Field offset: 0xB0
		public ulong sceneCullingMask; //Field offset: 0xC0
		public int cullingMask; //Field offset: 0xC8
		[ReadOnly]
		public NativeArray<Int32> visibleDecalIndices; //Field offset: 0xD0
		public int visibleDecalCount; //Field offset: 0xE0
		public float maxDrawDistance; //Field offset: 0xE4
		[WriteOnly]
		public NativeArray<float4x4> decalToWorldsDraw; //Field offset: 0xE8
		[WriteOnly]
		public NativeArray<float4x4> normalToDecalsDraw; //Field offset: 0xF8
		[WriteOnly]
		public NativeArray<Single> renderingLayerMasksDraw; //Field offset: 0x108
		[WriteOnly]
		public NativeArray<DecalSubDrawCall> subCalls; //Field offset: 0x118
		[WriteOnly]
		public NativeArray<Int32> subCallCount; //Field offset: 0x128

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override void Execute() { }

	}

	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	private ProfilingSampler m_Sampler; //Field offset: 0x18
	private float m_MaxDrawDistance; //Field offset: 0x20

	public float maxDrawDistance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DecalCreateDrawCallSystem(DecalEntityManager entityManager, float maxDrawDistance) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawCallJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawCallJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public void Execute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawCallJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawCallJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 2)]
	private void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, DecalDrawCallChunk drawCallChunk, int count) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_maxDrawDistance() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_maxDrawDistance(float value) { }

}

