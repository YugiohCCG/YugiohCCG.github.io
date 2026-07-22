namespace UnityEngine.Rendering.RenderGraphModule;

internal struct RendererListResource
{
	public RendererListParams desc; //Field offset: 0x0
	public RendererList rendererList; //Field offset: 0x130

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	internal RendererListResource(in RendererListParams desc) { }

}

