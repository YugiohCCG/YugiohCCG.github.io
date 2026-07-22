namespace UnityEngine.Rendering;

[AddComponentMenu(null)]
[ExecuteAlways]
public class ProbeVolumePerSceneData : MonoBehaviour
{
	public struct ObsoletePerScenarioData
	{
		public int sceneHash; //Field offset: 0x0
		public TextAsset cellDataAsset; //Field offset: 0x8
		public TextAsset cellOptionalDataAsset; //Field offset: 0x10

	}

	private struct ObsoleteSerializablePerScenarioDataItem
	{
		public string scenario; //Field offset: 0x0
		public ObsoletePerScenarioData data; //Field offset: 0x8

	}

	[FormerlySerializedAs("bakingSet")]
	[SerializeField]
	internal ProbeVolumeBakingSet serializedBakingSet; //Field offset: 0x20
	[SerializeField]
	internal string sceneGUID; //Field offset: 0x28
	[FormerlySerializedAs("asset")]
	[SerializeField]
	internal ObsoleteProbeVolumeAsset obsoleteAsset; //Field offset: 0x30
	[FormerlySerializedAs("cellSharedDataAsset")]
	[SerializeField]
	internal TextAsset obsoleteCellSharedDataAsset; //Field offset: 0x38
	[FormerlySerializedAs("cellSupportDataAsset")]
	[SerializeField]
	internal TextAsset obsoleteCellSupportDataAsset; //Field offset: 0x40
	[FormerlySerializedAs("serializedScenarios")]
	[SerializeField]
	private List<ObsoleteSerializablePerScenarioDataItem> obsoleteSerializedScenarios; //Field offset: 0x48

	public ProbeVolumeBakingSet bakingSet
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public ProbeVolumePerSceneData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeVolumePerSceneData), Member = "QueueSceneRemoval", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ProbeVolumeBakingSet get_bakingSet() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterPerSceneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumePerSceneData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSystemParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ForceSHBand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSHBands)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "RegisterBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumePerSceneData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeVolumePerSceneData), Member = "QueueSceneRemoval", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "AddPendingSceneLoading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeVolumePerSceneData), Member = "QueueSceneRemoval", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "UnregisterPerSceneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumePerSceneData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "RegisterPerSceneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumePerSceneData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void OnValidate() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetActiveBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "AddPendingSceneLoading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void QueueSceneLoading() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetActiveBakingSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeBakingSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumePerSceneData), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumePerSceneData), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumePerSceneData), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "AddPendingSceneRemoval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void QueueSceneRemoval() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeBakingSet), Member = "ResolveCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool ResolveCellData() { }

}

