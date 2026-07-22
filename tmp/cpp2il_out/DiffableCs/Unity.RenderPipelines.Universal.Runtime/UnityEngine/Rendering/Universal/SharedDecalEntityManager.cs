namespace UnityEngine.Rendering.Universal;

internal class SharedDecalEntityManager : IDisposable
{
	private DecalEntityManager m_DecalEntityManager; //Field offset: 0x10
	private int m_ReferenceCounter; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SharedDecalEntityManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onAllDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalEntityManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
	[Calls(Type = typeof(DecalProjector), Member = "add_onDecalAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "add_onDecalRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "add_onDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "add_onDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "add_onAllDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public DecalEntityManager Get() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "UpdateAllDecalEntitiesData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnAllDecalPropertyChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDecalAdd(DecalProjector decalProjector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "DestroyDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalEntityManager), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDecalMaterialChange(DecalProjector decalProjector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity), typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDecalPropertyChange(DecalProjector decalProjector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "DestroyDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDecalRemove(DecalProjector decalProjector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjectorAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalProjector), Member = "remove_onAllDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void Release(DecalEntityManager decalEntityManager) { }

}

