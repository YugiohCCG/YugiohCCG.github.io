namespace UnityEngine.Rendering;

internal struct IndirectBufferContextHandles
{
	public BufferHandle instanceBuffer; //Field offset: 0x0
	public BufferHandle instanceInfoBuffer; //Field offset: 0xC
	public BufferHandle dispatchArgsBuffer; //Field offset: 0x18
	public BufferHandle drawArgsBuffer; //Field offset: 0x24
	public BufferHandle drawInfoBuffer; //Field offset: 0x30

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void UseForOcclusionTest(IBaseRenderGraphBuilder builder) { }

}

