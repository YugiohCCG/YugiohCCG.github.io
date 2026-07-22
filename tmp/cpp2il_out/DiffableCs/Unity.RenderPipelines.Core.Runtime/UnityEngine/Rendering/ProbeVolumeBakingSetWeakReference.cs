namespace UnityEngine.Rendering;

internal class ProbeVolumeBakingSetWeakReference
{
	public int m_InstanceID; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ProbeVolumeBakingSetWeakReference(ProbeVolumeBakingSet bakingSet) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ProbeVolumeBakingSetWeakReference() { }

	[CallerCount(Count = 117)]
	[Calls(Type = typeof(Resources), Member = "InstanceIDToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	public ProbeVolumeBakingSet Get() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "InstanceIDIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool IsLoaded() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "set_m_CurrentBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "set_m_LazyBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ScheduleBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ProcessScheduledBakingSet", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetActiveBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetBakingSetAsCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadBakingSet", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSystemParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "DeinitProbeReferenceVolume", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void Set(ProbeVolumeBakingSet bakingSet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "InstanceIDIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "InstanceIDToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	public void Unload() { }

}

