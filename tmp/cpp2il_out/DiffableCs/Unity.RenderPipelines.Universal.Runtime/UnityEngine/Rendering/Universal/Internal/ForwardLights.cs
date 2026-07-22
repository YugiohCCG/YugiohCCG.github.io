namespace UnityEngine.Rendering.Universal.Internal;

public class ForwardLights
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<SetupLightPassData, UnsafeGraphContext> <>9__44_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <SetupRenderGraphLights>b__44_0(SetupLightPassData data, UnsafeGraphContext rgContext) { }

	}

	public struct InitParams
	{
		public LightCookieManager lightCookieManager; //Field offset: 0x0
		public bool forwardPlus; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Settings), Member = "Create", ReturnType = typeof(Settings))]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_additionalLightsCookieResolution", ReturnType = typeof(Vector2Int))]
		[Calls(Type = typeof(LightCookieManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal static InitParams Create() { }

	}

	private static class LightConstantBuffer
	{
		public static int _MainLightPosition; //Field offset: 0x0
		public static int _MainLightColor; //Field offset: 0x4
		public static int _MainLightOcclusionProbesChannel; //Field offset: 0x8
		public static int _MainLightLayerMask; //Field offset: 0xC
		public static int _AdditionalLightsCount; //Field offset: 0x10
		public static int _AdditionalLightsPosition; //Field offset: 0x14
		public static int _AdditionalLightsColor; //Field offset: 0x18
		public static int _AdditionalLightsAttenuation; //Field offset: 0x1C
		public static int _AdditionalLightsSpotDir; //Field offset: 0x20
		public static int _AdditionalLightOcclusionProbeChannel; //Field offset: 0x24
		public static int _AdditionalLightsLayerMasks; //Field offset: 0x28

	}

	private class SetupLightPassData
	{
		internal UniversalRenderingData renderingData; //Field offset: 0x10
		internal UniversalCameraData cameraData; //Field offset: 0x18
		internal UniversalLightData lightData; //Field offset: 0x20
		internal ForwardLights forwardLights; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SetupLightPassData() { }

	}

	private const string k_SetupLightConstants = "Setup Light Constants"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingSamplerFPSetup; //Field offset: 0x8
	private static readonly ProfilingSampler m_ProfilingSamplerFPComplete; //Field offset: 0x10
	private static readonly ProfilingSampler m_ProfilingSamplerFPUpload; //Field offset: 0x18
	private static ProfilingSampler s_SetupForwardLights; //Field offset: 0x20
	private int m_AdditionalLightsBufferId; //Field offset: 0x10
	private int m_AdditionalLightsIndicesId; //Field offset: 0x14
	private MixedLightingSetup m_MixedLightingSetup; //Field offset: 0x18
	private Vector4[] m_AdditionalLightPositions; //Field offset: 0x20
	private Vector4[] m_AdditionalLightColors; //Field offset: 0x28
	private Vector4[] m_AdditionalLightAttenuations; //Field offset: 0x30
	private Vector4[] m_AdditionalLightSpotDirections; //Field offset: 0x38
	private Vector4[] m_AdditionalLightOcclusionProbeChannels; //Field offset: 0x40
	private Single[] m_AdditionalLightsLayerMasks; //Field offset: 0x48
	private bool m_UseStructuredBuffer; //Field offset: 0x50
	private bool m_UseForwardPlus; //Field offset: 0x51
	private int m_DirectionalLightCount; //Field offset: 0x54
	private int m_ActualTileWidth; //Field offset: 0x58
	private int2 m_TileResolution; //Field offset: 0x5C
	private JobHandle m_CullingHandle; //Field offset: 0x68
	private NativeArray<UInt32> m_ZBins; //Field offset: 0x78
	private GraphicsBuffer m_ZBinsBuffer; //Field offset: 0x88
	private NativeArray<UInt32> m_TileMasks; //Field offset: 0x90
	private GraphicsBuffer m_TileMasksBuffer; //Field offset: 0xA0
	private LightCookieManager m_LightCookieManager; //Field offset: 0xA8
	private ReflectionProbeManager m_ReflectionProbeManager; //Field offset: 0xB0
	private int m_WordsPerTile; //Field offset: 0x138
	private float m_ZBinScale; //Field offset: 0x13C
	private float m_ZBinOffset; //Field offset: 0x140
	private int m_LightCount; //Field offset: 0x144
	private int m_BinCount; //Field offset: 0x148

	internal ReflectionProbeManager reflectionProbeManager
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 107
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static ForwardLights() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(ForwardLights), Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionProbeManager), Member = "Create", ReturnType = typeof(ReflectionProbeManager))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal ForwardLights(InitParams initParams) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = "Create", ReturnType = typeof(Settings))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UniversalRenderPipelineAsset), Member = "get_additionalLightsCookieResolution", ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(LightCookieManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForwardLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public ForwardLights() { }

	[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <PreSetup>g__IsProbeGreater|40_0(VisibleReflectionProbe probe, VisibleReflectionProbe otherProbe) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int AlignByteCount(int count, int align) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionProbeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieManager), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxTileWords", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void CreateForwardPlusBuffers() { }

	[CallerCount(Count = 0)]
	internal ReflectionProbeManager get_reflectionProbeManager() { }

	[CalledBy(Type = typeof(ForwardLights), Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	private void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, bool supportsLightLayers, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(ForwardLights), Member = "<PreSetup>g__IsProbeGreater|40_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleReflectionProbe), typeof(VisibleReflectionProbe)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReflectionProbeMinMaxZJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReflectionProbeMinMaxZJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZBinningJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZBinningJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.InclusiveRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TilingJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TilingJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TileRangeExpansionJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TileRangeExpansionJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float2>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.InclusiveRange>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(ForwardLights), Member = "GetViewParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float4x4), typeof(Single&), typeof(Single&), typeof(float4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.Universal.Fixed2`1<Unity.Mathematics.float4x4>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4), typeof(float4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxTileWords", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ForwardLights), Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleReflectionProbes", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CullingResults), Member = "get_visibleReflectionProbes", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleReflectionProbe>))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	internal void PreSetup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupShaderLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(ForwardLights), Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(UniversalLightData)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ForwardLights), Member = "InitializeLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(bool), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.ShaderInput+LightData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderData), Member = "get_instance", ReturnType = typeof(ShaderData))]
	[Calls(Type = typeof(ShaderData), Member = "GetLightDataBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.ShaderInput+LightData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingResults), Member = "get_lightAndReflectionProbeIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ShaderData), Member = "GetLightIndicesBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	private void SetupAdditionalLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<SetupRenderGraphLights>b__44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetupLightPassData), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(PlatformAutoDetect), Member = "ShAutoDetect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShEvalMode)}, ReturnType = typeof(ShEvalMode))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(ForwardLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "UpdateShaderVariablesProbeVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ProbeVolumesOptions), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxTileWords", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.UInt32>), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float4>))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_shadowmaskMode", ReturnType = typeof(ShadowmaskMode))]
	[Calls(Type = typeof(LightCookieManager), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	internal void SetupLights(UnsafeCommandBuffer cmd, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupShaderLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_bakingOutput", ReturnType = typeof(LightBakingOutput))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(LightExtensions), Member = "GetUniversalAdditionalLightData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(UniversalAdditionalLightData))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SetupMainLightConstants(UnsafeCommandBuffer cmd, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CullingResults), Member = "GetLightIndexMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Int32>))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(CullingResults), Member = "SetLightIndexMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingResults), Member = "get_lightAndReflectionProbeIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ShaderData), Member = "get_instance", ReturnType = typeof(ShaderData))]
	[Calls(Type = typeof(ShaderData), Member = "GetLightIndicesBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[Calls(Type = typeof(CullingResults), Member = "FillLightAndReflectionProbeIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private int SetupPerObjectLightIndices(CullingResults cullResults, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ForwardLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	private void SetupShaderLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData) { }

}

