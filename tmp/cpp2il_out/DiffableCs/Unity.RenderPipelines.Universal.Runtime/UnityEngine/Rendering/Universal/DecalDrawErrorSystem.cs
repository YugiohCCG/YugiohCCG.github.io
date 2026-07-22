namespace UnityEngine.Rendering.Universal;

internal class DecalDrawErrorSystem : DecalDrawSystem
{
	private DecalTechnique m_Technique; //Field offset: 0x40

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalDrawSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	public DecalDrawErrorSystem(DecalEntityManager entityManager, DecalTechnique technique) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_errorMaterial", ReturnType = typeof(Material))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual Material GetMaterial(DecalEntityChunk decalEntityChunk) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

}

