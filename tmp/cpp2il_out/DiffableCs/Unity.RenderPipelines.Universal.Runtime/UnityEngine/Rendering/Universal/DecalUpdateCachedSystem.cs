namespace UnityEngine.Rendering.Universal;

internal class DecalUpdateCachedSystem
{
	[BurstCompile]
	internal struct UpdateTransformsJob : IJobParallelForTransform
	{
		private static readonly quaternion k_MinusYtoZRotation; //Field offset: 0x0
		public NativeArray<float3> positions; //Field offset: 0x0
		public NativeArray<quaternion> rotations; //Field offset: 0x10
		public NativeArray<float3> scales; //Field offset: 0x20
		public NativeArray<Boolean> dirty; //Field offset: 0x30
		[ReadOnly]
		public NativeArray<DecalScaleMode> scaleModes; //Field offset: 0x40
		[ReadOnly]
		public NativeArray<float4x4> sizeOffsets; //Field offset: 0x50
		[WriteOnly]
		public NativeArray<float4x4> decalToWorlds; //Field offset: 0x60
		[WriteOnly]
		public NativeArray<float4x4> normalToWorlds; //Field offset: 0x70
		[WriteOnly]
		public NativeArray<BoundingSphere> boundingSpheres; //Field offset: 0x80
		public float minDistance; //Field offset: 0x90

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
		private static UpdateTransformsJob() { }

		[CalledBy(Type = typeof(UpdateTransformsJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		private float DistanceBetweenQuaternions(quaternion a, quaternion b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransformAccess), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(TransformAccess), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(UpdateTransformsJob), Member = "DistanceBetweenQuaternions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion), typeof(quaternion)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TransformAccess), Member = "get_localScale", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransformAccess), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
		[Calls(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion), typeof(float3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4), typeof(float4x4)}, ReturnType = typeof(float4x4))]
		[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(UpdateTransformsJob), Member = "GetDecalProjectBoundingSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(BoundingSphere))]
		[CallsDeduplicatedMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int index, TransformAccess transform) { }

		[CalledBy(Type = typeof(UpdateTransformsJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private BoundingSphere GetDecalProjectBoundingSphere(Matrix4x4 decalToWorld) { }

	}

	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	private ProfilingSampler m_Sampler; //Field offset: 0x18
	private ProfilingSampler m_SamplerJob; //Field offset: 0x20

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DecalUpdateCachedSystem(DecalEntityManager entityManager) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalUpdateCachedSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void Execute() { }

	[CalledBy(Type = typeof(DecalUpdateCachedSystem), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "FindPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IJobParallelForTransformExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateTransformsJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateTransformsJob), typeof(TransformAccessArray), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Execute(DecalEntityChunk entityChunk, DecalCachedChunk cachedChunk, int count) { }

}

