namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private struct CullShadowCastersContext
	{
		public IntPtr cullResults; //Field offset: 0x0
		public ShadowSplitData* splitBuffer; //Field offset: 0x8
		public int splitBufferLength; //Field offset: 0x10
		public LightShadowCasterCullingInfo* perLightInfos; //Field offset: 0x18
		public int perLightInfoCount; //Field offset: 0x20

	}

	private static readonly ShaderTagId kRenderTypeTag; //Field offset: 0x0
	private IntPtr m_Ptr; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static ScriptableRenderContext() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal ScriptableRenderContext(IntPtr ptr) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderContext::BeginRenderPass")]
	private static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void BeginSubPass(NativeArray<Int32> colors, bool isDepthStencilReadOnly = false) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void BeginSubPass(NativeArray<Int32> colors, NativeArray<Int32> inputs, bool isDepthStencilReadOnly = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderContext::BeginSubPass")]
	private static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateGizmoRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(GizmoSubset&)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateGizmoRendererList(Camera camera, GizmoSubset gizmoSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private RendererList CreateGizmoRendererList_Internal(Camera camera, GizmoSubset gizmoSubset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateGizmoRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, GizmoSubset gizmoSubset, out RendererList ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<RendererListHandle>", typeof(ScriptableRenderContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthOnlyPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererList&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererList&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(RendererListParams), Member = "Validate", ReturnType = typeof(void))]
	[Calls(Type = typeof(RendererListParams), Member = "get_tagsValuePtr", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RendererListParams), Member = "get_stateBlocksPtr", ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 2)]
	public RendererList CreateRendererList(ref RendererListParams param) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, in ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ShadowDrawingSettings&)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private RendererList CreateShadowRendererList_Internal(IntPtr shadowDrawinSettings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateShadowRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawinSettings, out RendererList ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateSkyboxRendererList(Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, int mode, in Matrix4x4 proj, in Matrix4x4 view, in Matrix4x4 projR, in Matrix4x4 viewR, out RendererList ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateUIOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(UISubset&)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateUIOverlayRendererList(Camera camera, UISubset uiSubset) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateUIOverlayRendererList(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private RendererList CreateUIOverlayRendererList_Internal(Camera camera, UISubset uiSubset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateUIOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, UISubset uiSubset, out RendererList ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateWireOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public RendererList CreateWireOverlayRendererList(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private RendererList CreateWireOverlayRendererList_Internal(Camera camera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateWireOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, out RendererList ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowCulling", Member = "CullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.UniversalShadowData", "UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout&", typeof(CullingResults&)}, ReturnType = "Unity.Collections.NativeArray`1<URPLightShadowCullingInfos>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void CullShadowCasters(CullingResults cullingResults, ShadowCastersCullingInfos infos) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "DrawWireOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "DrawWireOverlay_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	public void DrawWireOverlay(Camera camera) { }

	[CalledBy(Type = typeof(ScriptableRenderContext), Member = "DrawWireOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void DrawWireOverlay_Impl(Camera camera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("PlayerEmitCanvasGeometryForCamera")]
	public static void EmitGeometryForCamera(Camera camera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EmitGeometryForCamera_Injected(IntPtr camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EndRenderPass() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderContext::EndRenderPass")]
	private static void EndRenderPass_Internal(IntPtr self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void EndSubPass() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderContext::EndSubPass")]
	private static void EndSubPass_Internal(IntPtr self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	public override bool Equals(ScriptableRenderContext other) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "ExecuteNativeRenderGraph", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "InternalStartRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "InternalFinishRenderingExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "BeginXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "EndXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr commandBuffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr commandBuffer, ComputeQueueType queueType) { }

	[CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset), typeof(IntPtr), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	internal void GetCameras(List<Camera> results) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void GetCameras_Internal(Type listType, object resultList) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasInvokeOnRenderObjectCallbacks() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderContext::HasInvokeOnRenderObjectCallbacks")]
	private static bool HasInvokeOnRenderObjectCallbacks_Internal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("InitializeSortSettings")]
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InitializeSortSettings_Injected(IntPtr camera, out SortingSettings sortingSettings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_Cull")]
	private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, in ScriptableRenderContext renderLoop, IntPtr results) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_CullShadowCasters")]
	private static void Internal_CullShadowCasters(ScriptableRenderContext renderLoop, IntPtr context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_CullShadowCasters_Injected(in ScriptableRenderContext renderLoop, IntPtr context) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	internal IntPtr Internal_GetPtr() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<RendererListHandle>", typeof(ScriptableRenderContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PrepareRendererListsAsync(List<RendererList> rendererLists) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void PrepareRendererListsAsync_Internal(object rendererLists) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "AreRendererListsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<RendererListHandle>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RendererListStatus QueryRendererListStatus(RendererList rendererList) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private RendererListStatus QueryRendererListStatus_Internal(RendererList handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, in RendererList handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "SetupCameraProperties_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "SetupCameraProperties_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public void SetupCameraProperties(Camera camera, bool stereoSetup = false) { }

	[CalledBy(Type = typeof(ScriptableRenderContext), Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderContext), Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr camera, bool stereoSetup, int eye) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "RenderBlocks&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Submit() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Submit_Internal() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool SubmitForRenderPassValidation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool SubmitForRenderPassValidation_Internal() { }

}

