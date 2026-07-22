namespace UnityEngine.Rendering;

[Extension]
public static class OcclusionTestMethods
{

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Extension]
	public static uint GetBatchLayerMask(OcclusionTest occlusionTest) { }

}

