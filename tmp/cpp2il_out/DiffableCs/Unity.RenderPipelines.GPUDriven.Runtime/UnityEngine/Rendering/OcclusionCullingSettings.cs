namespace UnityEngine.Rendering;

public struct OcclusionCullingSettings
{
	public int viewInstanceID; //Field offset: 0x0
	public OcclusionTest occlusionTest; //Field offset: 0x4
	public int instanceMultiplier; //Field offset: 0x8

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(OcclusionTest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public OcclusionCullingSettings(int viewInstanceID, OcclusionTest occlusionTest) { }

}

