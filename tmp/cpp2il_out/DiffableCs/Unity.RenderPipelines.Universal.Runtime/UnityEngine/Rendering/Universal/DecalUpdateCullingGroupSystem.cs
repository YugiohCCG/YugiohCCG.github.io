namespace UnityEngine.Rendering.Universal;

internal class DecalUpdateCullingGroupSystem
{
	private Single[] m_BoundingDistance; //Field offset: 0x10
	private Camera m_Camera; //Field offset: 0x18
	private DecalEntityManager m_EntityManager; //Field offset: 0x20
	private ProfilingSampler m_Sampler; //Field offset: 0x28

	public float boundingDistance
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 40
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 40
	}

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public DecalUpdateCullingGroupSystem(DecalEntityManager entityManager, float drawDistance) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "set_targetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CullingGroup), Member = "SetDistanceReferencePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "SetBoundingDistances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "SetBoundingSpheres", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingSphere[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "SetBoundingSphereCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public void Execute(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "set_targetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CullingGroup), Member = "SetDistanceReferencePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "SetBoundingDistances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "SetBoundingSpheres", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundingSphere[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "SetBoundingSphereCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float get_boundingDistance() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal static ulong GetSceneCullingMaskFromCamera(Camera camera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_boundingDistance(float value) { }

}

