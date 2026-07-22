namespace UnityEngine.Rendering.Universal;

internal class DecalSkipCulledSystem
{
	private DecalEntityManager m_EntityManager; //Field offset: 0x10
	private ProfilingSampler m_Sampler; //Field offset: 0x18
	private Camera m_Camera; //Field offset: 0x20

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DecalSkipCulledSystem(DecalEntityManager entityManager) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void Execute(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void Execute(DecalCulledChunk culledChunk, int count) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal static ulong GetSceneCullingMaskFromCamera(Camera camera) { }

}

