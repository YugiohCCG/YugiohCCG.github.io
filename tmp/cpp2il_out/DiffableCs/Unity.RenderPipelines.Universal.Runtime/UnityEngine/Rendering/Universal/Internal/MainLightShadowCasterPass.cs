namespace UnityEngine.Rendering.Universal.Internal;

public class MainLightShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__39_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MainLightShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__39_0(PassData data, RasterGraphContext context) { }

	}

	private static class MainLightShadowConstantBuffer
	{
		public static readonly int _WorldToShadow; //Field offset: 0x0
		public static readonly int _ShadowParams; //Field offset: 0x4
		public static readonly int _CascadeShadowSplitSpheres0; //Field offset: 0x8
		public static readonly int _CascadeShadowSplitSpheres1; //Field offset: 0xC
		public static readonly int _CascadeShadowSplitSpheres2; //Field offset: 0x10
		public static readonly int _CascadeShadowSplitSpheres3; //Field offset: 0x14
		public static readonly int _CascadeShadowSplitSphereRadii; //Field offset: 0x18
		public static readonly int _ShadowOffset0; //Field offset: 0x1C
		public static readonly int _ShadowOffset1; //Field offset: 0x20
		public static readonly int _ShadowmapSize; //Field offset: 0x24
		public static readonly int _MainLightShadowmapID; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static MainLightShadowConstantBuffer() { }

	}

	private class PassData
	{
		internal bool emptyShadowmap; //Field offset: 0x10
		internal bool setKeywordForEmptyShadowmap; //Field offset: 0x11
		internal UniversalRenderingData renderingData; //Field offset: 0x18
		internal UniversalCameraData cameraData; //Field offset: 0x20
		internal UniversalLightData lightData; //Field offset: 0x28
		internal UniversalShadowData shadowData; //Field offset: 0x30
		internal MainLightShadowCasterPass pass; //Field offset: 0x38
		internal TextureHandle shadowmapTexture; //Field offset: 0x40
		internal readonly RendererList[] shadowRendererLists; //Field offset: 0x50
		internal readonly RendererListHandle[] shadowRendererListsHandle; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public PassData() { }

	}

	private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture"; //Field offset: 0x0
	private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture"; //Field offset: 0x0
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	private const int k_MaxCascades = 4; //Field offset: 0x0
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	private static Vector4 s_EmptyShadowParams; //Field offset: 0x0
	private static readonly Vector4 s_EmptyShadowmapSize; //Field offset: 0x10
	internal RTHandle m_MainLightShadowmapTexture; //Field offset: 0xB8
	private int renderTargetWidth; //Field offset: 0xC0
	private int renderTargetHeight; //Field offset: 0xC4
	private int m_ShadowCasterCascadesCount; //Field offset: 0xC8
	private bool m_CreateEmptyShadowmap; //Field offset: 0xCC
	private bool m_SetKeywordForEmptyShadowmap; //Field offset: 0xCD
	private bool m_EmptyShadowmapNeedsClear; //Field offset: 0xCE
	private float m_CascadeBorder; //Field offset: 0xD0
	private float m_MaxShadowDistanceSq; //Field offset: 0xD4
	private PassData m_PassData; //Field offset: 0xD8
	private RTHandle m_EmptyMainLightShadowmapTexture; //Field offset: 0xE0
	private RenderTextureDescriptor m_MainLightShadowDescriptor; //Field offset: 0xE8
	private readonly Vector4[] m_CascadeSplitDistances; //Field offset: 0x120
	private readonly Matrix4x4[] m_MainLightShadowMatrices; //Field offset: 0x128
	private readonly ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0x130
	private readonly ShadowSliceData[] m_CascadeSlices; //Field offset: 0x138

	[CallerCount(Count = 0)]
	private static MainLightShadowCasterPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MainLightShadowCasterPass(RenderPassEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowSliceData), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowUtils), Member = "ShadowRTReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "ConfigureClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "InitPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void InitPassData(ref PassData passData, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShadowDrawingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererListHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(ShadowDrawingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 44)]
	[ContainsUnimplementedInstructions]
	internal TextureHandle Render(RenderGraph graph, ContextContainer frameData) { }

	[CalledBy(Type = typeof(<>c), Member = "<Render>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShadowUtils), Member = "SetupShadowCasterConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(VisibleLight&), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetCameraPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetWorldToCameraAndCameraToWorldMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(UniversalShadowData), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(ShadowUtils), Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(ShadowSliceData&), typeof(RendererList&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetSoftShadowQualityShaderKeywords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "SetupMainLightShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(VisibleLight&), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsUnimplementedInstructions]
	private void RenderMainLightCascadeShadowmap(RasterCommandBuffer cmd, ref PassData data, bool isRenderGraph) { }

	[CalledBy(Type = typeof(TransparentSettingsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransparentSettingsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<Render>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Setup(ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_depthBufferBits", ReturnType = typeof(int))]
	[Calls(Type = typeof(URPLightShadowCullingInfos), Member = "IsSliceValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowSplitData), Member = "get_cullingSphere", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "UnsafeElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(CullingResults), Member = "GetShadowCasterBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Bounds&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Light), typeof(UniversalCameraData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(ShadowSliceData), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "UnsafeElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPLightShadowCullingInfos)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos>), typeof(int)}, ReturnType = typeof(URPLightShadowCullingInfos&))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 19)]
	public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(ShadowUtils), Member = "SoftShadowQualityToShaderProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetScaleAndBiasForLinearDistanceFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, Light light, UniversalCameraData cameraData, UniversalShadowData shadowData) { }

	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_zero", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(ShadowUtils), Member = "SoftShadowQualityToShaderProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetScaleAndBiasForLinearDistanceFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetupMainLightShadowReceiverConstants(RasterCommandBuffer cmd, ref VisibleLight shadowLight, UniversalShadowData shadowData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_depthBufferBits", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	private void UpdateTextureDescriptorIfNeeded() { }

}

