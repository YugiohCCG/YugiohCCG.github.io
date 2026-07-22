namespace UnityEngine.Rendering;

[Obsolete("This class is no longer necessary for APV implementation.")]
public class ProbeVolumeSceneData
{
	internal object parentAsset; //Field offset: 0x10
	[FormerlySerializedAs("sceneBounds")]
	[Obsolete("This data is now serialized directly in the baking set asset")]
	[SerializeField]
	internal SerializedDictionary<String, Bounds> obsoleteSceneBounds; //Field offset: 0x18
	[FormerlySerializedAs("hasProbeVolumes")]
	[Obsolete("This data is now serialized directly in the baking set asset")]
	[SerializeField]
	internal SerializedDictionary<String, Boolean> obsoleteHasProbeVolumes; //Field offset: 0x20

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ProbeVolumeSceneData(object parentAsset) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete]
	public void SetParentObject(object parent) { }

}

