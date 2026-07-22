namespace UnityEngine.Rendering.Universal;

internal class DebugRendererLists
{
	private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
	private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x18
	private List<DebugRenderSetup> m_DebugRenderSetups; //Field offset: 0x38
	private List<RendererList> m_ActiveDebugRendererList; //Field offset: 0x40
	private List<RendererListHandle> m_ActiveDebugRendererListHdl; //Field offset: 0x48

	[CalledBy(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[CalledBy(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DebugRendererLists(DebugHandler debugHandler, FilteringSettings filteringSettings) { }

	[CalledBy(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugRendererLists), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void CreateDebugRenderSetups(FilteringSettings filteringSettings) { }

	[CalledBy(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugRendererLists), Member = "CreateDebugRenderSetups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugRenderSetup), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(DebugRenderSetup), Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererList&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal void CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[CalledBy(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugRendererLists), Member = "CreateDebugRenderSetups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilteringSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugRenderSetup), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(DebugRenderSetup), Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererListHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal void CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[CalledBy(Type = typeof(DebugRendererLists), Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DisposeDebugRenderLists() { }

	[CalledBy(Type = typeof(RenderObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", typeof(RasterCommandBuffer), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData), typeof(RendererList), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(RendererList), Member = "get_isValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugRendererLists), Member = "DisposeDebugRenderLists", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	internal void DrawWithRendererList(RasterCommandBuffer cmd) { }

	[CalledBy(Type = typeof(RenderObjectsPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void PrepareRendererListForRasterPass(IRasterRenderGraphBuilder builder) { }

}

