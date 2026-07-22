namespace UnityEngine.Rendering.Universal;

internal class DebugRenderSetup : IDisposable
{
	private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
	private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x18
	private readonly int m_Index; //Field offset: 0x38

	private DebugDisplaySettingsLighting LightingSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 39
	}

	private DebugDisplaySettingsMaterial MaterialSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 39
	}

	private DebugDisplaySettingsRendering RenderingSettings
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DebugRenderSetup(DebugHandler debugHandler, int index, FilteringSettings filteringSettings) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Begin(RasterCommandBuffer cmd) { }

	[CalledBy(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DrawingSettings), Member = "set_overrideMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererList&)}, ReturnType = typeof(void))]
	internal void CreateRendererList(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererList rendererList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererListHandle&)}, ReturnType = typeof(void))]
	internal void CreateRendererList(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererListHandle rendererListHdl) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RendererList), Member = "get_isValid", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void DrawWithRendererList(RasterCommandBuffer cmd, ref RendererList rendererList) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void End(RasterCommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DebugDisplaySettingsLighting get_LightingSettings() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int GetIndex() { }

	[CalledBy(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_opaque", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(RenderQueueRange), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange), typeof(RenderQueueRange)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_all", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_transparent", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(RenderTargetBlendState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorWriteMask), typeof(BlendMode), typeof(BlendMode), typeof(BlendMode), typeof(BlendMode), typeof(BlendOp), typeof(BlendOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_blendState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlendState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RasterState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullMode), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_rasterState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock) { }

}

