namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
[NativeHeader("Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
public struct CullingResults : IEquatable<CullingResults>
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VFXModule"})]
	internal IntPtr ptr; //Field offset: 0x0
	private CullingAllocationInfo* m_AllocationInfo; //Field offset: 0x8

	public int lightAndReflectionProbeIndexCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.UnsafeCommandBuffer", typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 106
	}

	public NativeArray<VisibleLight> visibleLights
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowCulling", Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalShadowData", "UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout&", typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), "Unity.Collections.NativeArray`1<URPLightShadowCullingInfos>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CullingResults), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 112
	}

	public NativeArray<VisibleReflectionProbe> visibleReflectionProbes
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CullingResults), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 113
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), "UnityEngine.Rendering.Universal.ShadowSliceData&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeDirectionalShadowMatricesAndCullingPrimitives")]
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, in Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputePointShadowMatricesAndCullingPrimitives")]
	private static bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeSpotShadowMatricesAndCullingPrimitives")]
	private static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ExtractSpotLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalShadowData", typeof(int), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(CullingResults other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("FillLightAndReflectionProbeIndices")]
	private static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void FillLightAndReflectionProbeIndices_Injected(IntPtr cullingResultsPtr, IntPtr computeBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("FillLightIndexMapScriptable")]
	private static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.UnsafeCommandBuffer", typeof(CullingResults&), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int get_lightAndReflectionProbeIndexCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowCulling", Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalShadowData", "UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout&", typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), "Unity.Collections.NativeArray`1<URPLightShadowCullingInfos>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CullingResults), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	public NativeArray<VisibleLight> get_visibleLights() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CullingResults), Member = "GetNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	public NativeArray<VisibleReflectionProbe> get_visibleReflectionProbes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetLightIndexCount")]
	private static int GetLightIndexCount(IntPtr cullingResultsPtr) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public NativeArray<Int32> GetLightIndexMap(Allocator allocator) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetLightIndexMapSize")]
	private static int GetLightIndexMapSize(IntPtr cullingResultsPtr) { }

	[CalledBy(Type = typeof(CullingResults), Member = "get_visibleLights", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>))]
	[CalledBy(Type = typeof(CullingResults), Member = "get_visibleReflectionProbes", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleReflectionProbe>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private NativeArray<T> GetNativeArray(Void* dataPointer, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetReflectionProbeIndexCount")]
	private static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetShadowCasterBounds")]
	private static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(CullingResults left, CullingResults right) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetLightIndexMap(NativeArray<Int32> lightIndexMap) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("SetLightIndexMapScriptable")]
	private static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

}

