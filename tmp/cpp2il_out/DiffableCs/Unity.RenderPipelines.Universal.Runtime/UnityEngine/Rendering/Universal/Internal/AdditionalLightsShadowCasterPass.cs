namespace UnityEngine.Rendering.Universal.Internal;

public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__64_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__64_0(PassData data, RasterGraphContext context) { }

	}

	private static class AdditionalShadowsConstantBuffer
	{
		public static readonly int _AdditionalLightsWorldToShadow; //Field offset: 0x0
		public static readonly int _AdditionalShadowParams; //Field offset: 0x4
		public static readonly int _AdditionalShadowOffset0; //Field offset: 0x8
		public static readonly int _AdditionalShadowOffset1; //Field offset: 0xC
		public static readonly int _AdditionalShadowFadeParams; //Field offset: 0x10
		public static readonly int _AdditionalShadowmapSize; //Field offset: 0x14
		public static readonly int _AdditionalLightsShadowmapID; //Field offset: 0x18
		public static readonly int _AdditionalLightsWorldToShadow_SSBO; //Field offset: 0x1C
		public static readonly int _AdditionalShadowParams_SSBO; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static AdditionalShadowsConstantBuffer() { }

	}

	private class PassData
	{
		internal int shadowmapID; //Field offset: 0x10
		internal bool emptyShadowmap; //Field offset: 0x14
		internal bool setKeywordForEmptyShadowmap; //Field offset: 0x15
		internal bool useStructuredBuffer; //Field offset: 0x16
		internal bool stripShadowsOffVariants; //Field offset: 0x17
		internal Matrix4x4 viewMatrix; //Field offset: 0x18
		internal Vector2Int allocatedShadowAtlasSize; //Field offset: 0x58
		internal TextureHandle shadowmapTexture; //Field offset: 0x60
		internal UniversalLightData lightData; //Field offset: 0x70
		internal UniversalShadowData shadowData; //Field offset: 0x78
		internal AdditionalLightsShadowCasterPass pass; //Field offset: 0x80
		internal readonly RendererList[] shadowRendererLists; //Field offset: 0x88
		internal readonly RendererListHandle[] shadowRendererListsHdl; //Field offset: 0x90

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public PassData() { }

	}

	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", True)]
	public static int m_AdditionalShadowsBufferId; //Field offset: 0x0
	private const string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture"; //Field offset: 0x0
	private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture"; //Field offset: 0x0
	private const float k_LightTypeIdentifierInShadowParams_Point = 1; //Field offset: 0x0
	private const float k_LightTypeIdentifierInShadowParams_Spot = 0; //Field offset: 0x0
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", True)]
	public static int m_AdditionalShadowsIndicesId; //Field offset: 0x4
	private static bool m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall; //Field offset: 0x8
	private static bool m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall; //Field offset: 0x9
	private static readonly Vector4 c_DefaultShadowParams; //Field offset: 0xC
	private static Vector4 s_EmptyAdditionalShadowFadeParams; //Field offset: 0x1C
	private static Vector4[] s_EmptyAdditionalLightIndexToShadowParams; //Field offset: 0x30
	private static bool isAdditionalShadowParamsDirty; //Field offset: 0x38
	internal RTHandle m_AdditionalLightsShadowmapHandle; //Field offset: 0xB8
	private int renderTargetWidth; //Field offset: 0xC0
	private int renderTargetHeight; //Field offset: 0xC4
	private bool m_CreateEmptyShadowmap; //Field offset: 0xC8
	private bool m_SetKeywordForEmptyShadowmap; //Field offset: 0xC9
	private bool m_EmptyShadowmapNeedsClear; //Field offset: 0xCA
	private bool m_IssuedMessageAboutShadowSlicesTooMany; //Field offset: 0xCB
	private bool m_IssuedMessageAboutShadowMapsRescale; //Field offset: 0xCC
	private bool m_IssuedMessageAboutShadowMapsTooBig; //Field offset: 0xCD
	private bool m_IssuedMessageAboutRemovedShadowSlices; //Field offset: 0xCE
	private readonly bool m_UseStructuredBuffer; //Field offset: 0xCF
	private float m_MaxShadowDistanceSq; //Field offset: 0xD0
	private float m_CascadeBorder; //Field offset: 0xD4
	private PassData m_PassData; //Field offset: 0xD8
	private RTHandle m_EmptyAdditionalLightShadowmapTexture; //Field offset: 0xE0
	private Boolean[] m_VisibleLightIndexToIsCastingShadows; //Field offset: 0xE8
	private Int16[] m_VisibleLightIndexToAdditionalLightIndex; //Field offset: 0xF0
	private Int16[] m_AdditionalLightIndexToVisibleLightIndex; //Field offset: 0xF8
	private Vector4[] m_AdditionalLightIndexToShadowParams; //Field offset: 0x100
	private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix; //Field offset: 0x108
	private ShadowSliceData[] m_AdditionalLightsShadowSlices; //Field offset: 0x110
	private readonly List<Byte> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex; //Field offset: 0x118
	private readonly List<Int16> m_ShadowSliceToAdditionalLightIndex; //Field offset: 0x120
	private readonly Dictionary<Int32, UInt64> m_ShadowRequestsHashes; //Field offset: 0x128
	private readonly ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0x130
	private RenderTextureDescriptor m_AdditionalLightShadowDescriptor; //Field offset: 0x138

	[CallerCount(Count = 0)]
	private static AdditionalLightsShadowCasterPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public AdditionalLightsShadowCasterPass(RenderPassEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[CallsUnknownMethods(Count = 1)]
	private bool AnyAdditionalLightHasMixedShadows(UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[Calls(Type = typeof(ShadowUtils), Member = "IsValidShadowCastingLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(int), typeof(LightType), typeof(LightShadows), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private ulong ComputeShadowRequestHash(UniversalLightData lightData, UniversalShadowData shadowData) { }

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
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "InitPassData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	private float GetLightTypeIdentifierForShadowParams(LightType lightType) { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public int GetShadowLightIndexFromLightIndex(int visibleLightIndex) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 4)]
	private void InitPassData(ref PassData passData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ShadowDrawingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererListHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void InitRendererLists(ref CullingResults cullResults, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(TextureHandle), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureDesc))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 39)]
	[ContainsUnimplementedInstructions]
	internal TextureHandle Render(RenderGraph graph, ContextContainer frameData) { }

	[CalledBy(Type = typeof(<>c), Member = "<Render>b__64_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(ShadowUtils), Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(ShadowSliceData&), typeof(RendererList&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetLightPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "SetSoftShadowQualityShaderKeywords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "FastApproximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(UniversalShadowData), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(ShadowUtils), Member = "FastApproximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ShadowUtils), Member = "SetWorldToCameraAndCameraToWorldMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	[ContainsUnimplementedInstructions]
	private void RenderAdditionalShadowmapAtlas(RasterCommandBuffer cmd, ref PassData data, bool useRenderGraph) { }

	[CallerCount(Count = 0)]
	private ulong ResolutionLog2ForHash(int resolution) { }

	[CalledBy(Type = typeof(TransparentSettingsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransparentSettingsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<Render>b__64_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(ShaderData), Member = "get_instance", ReturnType = typeof(ShaderData))]
	[Calls(Type = typeof(ShaderData), Member = "GetAdditionalLightShadowParamsStructuredBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(CullingResults), Member = "GetShadowCasterBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Bounds&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = "HasSpaceForLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "UnsafeElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPLightShadowCullingInfos)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos>), typeof(int)}, ReturnType = typeof(URPLightShadowCullingInfos&))]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "UnsafeElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(URPLightShadowCullingInfos), Member = "IsSliceValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = "GetSliceShadowResolutionRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ShadowResolutionRequest))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ShadowUtils), Member = "SoftShadowQualityToShaderProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_depthBufferBits", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = "GetSortedShadowResolutionRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ShadowResolutionRequest))]
	[Calls(Type = typeof(ShadowUtils), Member = "IsValidShadowCastingLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(int), typeof(LightType), typeof(LightShadows), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetPunctualLightShadowSlicesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 125)]
	[ContainsUnimplementedInstructions]
	public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Setup(ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShaderData), Member = "get_instance", ReturnType = typeof(ShaderData))]
	[Calls(Type = typeof(ShaderData), Member = "GetAdditionalLightShadowParamsStructuredBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderData), Member = "GetAdditionalLightShadowSliceMatricesStructuredBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetScaleAndBiasForLinearDistanceFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void SetupAdditionalLightsShadowReceiverConstants(RasterCommandBuffer cmd, Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetScaleAndBiasForLinearDistanceFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(ShadowUtils), Member = "SoftShadowQualityToShaderProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_depthBufferBits", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	private void UpdateTextureDescriptorIfNeeded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool UsesBakedShadows(Light light) { }

}

