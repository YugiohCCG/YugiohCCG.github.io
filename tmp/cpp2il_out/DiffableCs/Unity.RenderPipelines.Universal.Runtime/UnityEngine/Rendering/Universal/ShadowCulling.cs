namespace UnityEngine.Rendering.Universal;

internal static class ShadowCulling
{
	private static readonly ProfilingSampler computeShadowCasterCullingInfosMarker; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ShadowCulling() { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "CullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext&), typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = "GetSliceShadowResolutionRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ShadowResolutionRequest))]
	[Calls(Type = typeof(Light), Member = "get_shadowNearPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(ShadowUtils), Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "GetPointLightShadowFrustumFovBiasInDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(ShadowUtils), Member = "ExtractSpotLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.ShadowSliceData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowAtlasLayout), Member = "HasSpaceForLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ShadowSplitData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingResults), Member = "get_visibleLights", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>))]
	[Calls(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(UniversalShadowData), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ShadowSplitData>), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.ShadowSplitData>))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private static void ComputeShadowCasterCullingInfos(UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullingResults, out ShadowCastersCullingInfos shadowCullingInfos, out NativeArray<URPLightShadowCullingInfos>& urpVisibleLightsShadowCullingInfos) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "CreateShadowAtlasAndCullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData), typeof(CullingResults&), typeof(ScriptableRenderContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CullShadowCasters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(ShadowCastersCullingInfos)}, ReturnType = typeof(void))]
	public static NativeArray<URPLightShadowCullingInfos> CullShadowCasters(ref ScriptableRenderContext context, UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullResults) { }

	[CallerCount(Count = 0)]
	private static BatchCullingProjectionType GetCullingProjectionType(LightType type) { }

}

