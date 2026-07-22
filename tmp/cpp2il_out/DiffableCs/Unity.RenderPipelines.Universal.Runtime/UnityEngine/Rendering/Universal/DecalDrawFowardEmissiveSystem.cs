namespace UnityEngine.Rendering.Universal;

internal class DecalDrawFowardEmissiveSystem : DecalDrawSystem
{

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalDrawSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	public DecalDrawFowardEmissiveSystem(DecalEntityManager entityManager) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

