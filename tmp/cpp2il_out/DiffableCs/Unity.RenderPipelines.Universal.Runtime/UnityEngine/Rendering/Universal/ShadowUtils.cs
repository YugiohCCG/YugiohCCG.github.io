namespace UnityEngine.Rendering.Universal;

public static class ShadowUtils
{
	internal static readonly bool m_ForceShadowPointSampling; //Field offset: 0x0
	internal const int kMinimumPunctualLightHardShadowResolution = 8; //Field offset: 0x0
	internal const int kMinimumPunctualLightSoftShadowResolution = 16; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "get_activeTier", ReturnType = typeof(GraphicsTier))]
	[Calls(Type = typeof(GraphicsSettings), Member = "HasShaderDefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsTier), typeof(BuiltinShaderDefine)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ShadowUtils() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowUtils), Member = "GetTemporaryShadowTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(RTHandle))]
	[ContainsUnimplementedInstructions]
	public static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowData), Member = "get_universalShadowData", ReturnType = typeof(UniversalShadowData))]
	[Calls(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&)}, ReturnType = typeof(bool))]
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowData), Member = "get_universalShadowData", ReturnType = typeof(UniversalShadowData))]
	[ContainsInvalidInstructions]
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData) { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CullingResults), Member = "ComputeDirectionalShadowMatricesAndCullingPrimitives", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Vector3), typeof(int), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowSplitData), Member = "get_cullingSphere", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(ShadowSplitData), Member = "set_shadowCascadeBlendCullingFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowData), Member = "get_universalShadowData", ReturnType = typeof(UniversalShadowData))]
	[Calls(Type = typeof(ShadowUtils), Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	public static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CullingResults), Member = "ComputePointShadowMatricesAndCullingPrimitives", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	public static bool ExtractPointLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowData), Member = "get_universalShadowData", ReturnType = typeof(UniversalShadowData))]
	[ContainsInvalidInstructions]
	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CullingResults), Member = "ComputeSpotShadowMatricesAndCullingPrimitives", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool FastApproximately(float a, float b) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool FastApproximately(Vector4 a, Vector4 b) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateShadowAtlasAndCullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData), typeof(CullingResults&), typeof(ScriptableRenderContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeMainLightShadowResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	internal static int GetPunctualLightShadowSlicesCount(in LightType lightType) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Light), typeof(UniversalCameraData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "SetupMainLightShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(VisibleLight&), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowData), Member = "get_bias", ReturnType = typeof(List`1<Vector4>&))]
	[Calls(Type = typeof(ShadowData), Member = "get_supportsSoftShadows", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[ContainsUnimplementedInstructions]
	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CallsUnknownMethods(Count = 1)]
	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, UniversalShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(ShadowData&), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(UniversalShadowData), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "GetPointLightShadowFrustumFovBiasInDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, List<Vector4> bias, bool supportsSoftShadows, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractSpotLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowUtils), Member = "GetTemporaryShadowTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Obsolete("Use AllocShadowRT or ShadowRTReAllocateIfNeeded", True)]
	public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits) { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "GetTemporaryShadowTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ShadowRTNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "AllocShadowRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ShadowRTReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Boolean>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsValidShadowCastingLight(UniversalLightData lightData, int i) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "ComputeShadowRequestHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsValidShadowCastingLight(UniversalLightData lightData, int i, LightType lightType, LightShadows lightShadows, float shadowStrength) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static int MinimalPunctualLightShadowResolution(bool softShadow) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalDepthBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableScissorRect", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RendererList), Member = "get_isValid", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal static void RenderShadowSlice(RasterCommandBuffer cmd, ref ShadowSliceData shadowSliceData, ref RendererList shadowRendererList, Matrix4x4 proj, Matrix4x4 view) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalDepthBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableScissorRect", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view) { }

	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetCameraPosition(RasterCommandBuffer cmd, Vector3 worldSpaceCameraPos) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetLightDirection(RasterCommandBuffer cmd, Vector3 lightDirection) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetLightPosition(RasterCommandBuffer cmd, Vector3 lightPosition) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "SetSoftShadowsKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalShadowData), typeof(Light), typeof(bool), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetPerLightSoftShadowKeyword(RasterCommandBuffer cmd, bool hasSoftShadows) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetShadowBias(RasterCommandBuffer cmd, Vector4 shadowBias) { }

	[CalledBy(Type = typeof(DeferredLights), Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetSoftShadowQualityShaderKeywords(RasterCommandBuffer cmd, UniversalShadowData shadowData) { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "SetupShadowCasterConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetupShadowCasterConstantBuffer(RasterCommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowUtils), Member = "SetupShadowCasterConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(VisibleLight&), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "RenderMainLightCascadeShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetWorldToCameraAndCameraToWorldMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetTemporaryShadowTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "CreateTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(TextureSizeMode), typeof(int), typeof(float), typeof(FilterMode), typeof(TextureWrapMode), typeof(string)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderingUtils), Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(TextureDesc&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetTemporaryShadowTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "CreateTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(TextureSizeMode), typeof(int), typeof(float), typeof(FilterMode), typeof(TextureWrapMode), typeof(string)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderingUtils), Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(TextureDesc&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "SetupForEmptyRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Light), typeof(UniversalCameraData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "SetupMainLightShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(VisibleLight&), typeof(UniversalShadowData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal static bool SupportsPerLightSoftShadowQuality() { }

}

