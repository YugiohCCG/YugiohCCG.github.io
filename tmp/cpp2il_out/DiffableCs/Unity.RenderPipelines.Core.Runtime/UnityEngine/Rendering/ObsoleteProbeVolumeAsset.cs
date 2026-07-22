namespace UnityEngine.Rendering;

[PreferBinarySerialization]
internal class ObsoleteProbeVolumeAsset : ScriptableObject
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ObsoleteProbeVolumeAsset() { }

}

