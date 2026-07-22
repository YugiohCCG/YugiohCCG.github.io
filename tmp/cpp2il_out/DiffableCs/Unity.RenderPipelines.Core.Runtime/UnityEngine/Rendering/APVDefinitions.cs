namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@ae070e0972dd\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs")]
internal class APVDefinitions
{
	public static int probeIndexChunkSize; //Field offset: 0x0
	public const float probeValidityThreshold = 0.05; //Field offset: 0x0
	public static int probeMaxRegionCount; //Field offset: 0x4
	public static Color32[] layerMaskColors; //Field offset: 0x8
	public static Color debugEmptyColor; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static APVDefinitions() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public APVDefinitions() { }

}

