namespace UnityEngine.Rendering.Universal;

public class StencilStateData
{
	public bool overrideStencilState; //Field offset: 0x10
	public int stencilReference; //Field offset: 0x14
	public CompareFunction stencilCompareFunction; //Field offset: 0x18
	public StencilOp passOperation; //Field offset: 0x1C
	public StencilOp failOperation; //Field offset: 0x20
	public StencilOp zFailOperation; //Field offset: 0x24

	[CalledBy(Type = typeof(UniversalRendererData), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StencilStateData() { }

}

