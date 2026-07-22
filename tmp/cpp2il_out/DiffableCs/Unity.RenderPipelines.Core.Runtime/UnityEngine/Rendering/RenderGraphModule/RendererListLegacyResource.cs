namespace UnityEngine.Rendering.RenderGraphModule;

internal struct RendererListLegacyResource
{
	public RendererList rendererList; //Field offset: 0x0
	public bool isActive; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal RendererListLegacyResource(in bool active = false) { }

}

