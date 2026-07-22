namespace UnityEngine.Rendering;

internal struct OccluderHandles
{
	public TextureHandle occluderDepthPyramid; //Field offset: 0x0
	public BufferHandle occlusionDebugOverlay; //Field offset: 0x10

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void UseForOccluderUpdate(IBaseRenderGraphBuilder builder) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void UseForOcclusionTest(IBaseRenderGraphBuilder builder) { }

}

