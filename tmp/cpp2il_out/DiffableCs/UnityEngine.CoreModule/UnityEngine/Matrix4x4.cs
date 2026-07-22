namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Matrix4x4f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
{
	private static readonly Matrix4x4 zeroMatrix; //Field offset: 0x0
	private static readonly Matrix4x4 identityMatrix; //Field offset: 0x40
	[NativeName("m_Data[0]")]
	public float m00; //Field offset: 0x0
	[NativeName("m_Data[1]")]
	public float m10; //Field offset: 0x4
	[NativeName("m_Data[2]")]
	public float m20; //Field offset: 0x8
	[NativeName("m_Data[3]")]
	public float m30; //Field offset: 0xC
	[NativeName("m_Data[4]")]
	public float m01; //Field offset: 0x10
	[NativeName("m_Data[5]")]
	public float m11; //Field offset: 0x14
	[NativeName("m_Data[6]")]
	public float m21; //Field offset: 0x18
	[NativeName("m_Data[7]")]
	public float m31; //Field offset: 0x1C
	[NativeName("m_Data[8]")]
	public float m02; //Field offset: 0x20
	[NativeName("m_Data[9]")]
	public float m12; //Field offset: 0x24
	[NativeName("m_Data[10]")]
	public float m22; //Field offset: 0x28
	[NativeName("m_Data[11]")]
	public float m32; //Field offset: 0x2C
	[NativeName("m_Data[12]")]
	public float m03; //Field offset: 0x30
	[NativeName("m_Data[13]")]
	public float m13; //Field offset: 0x34
	[NativeName("m_Data[14]")]
	public float m23; //Field offset: 0x38
	[NativeName("m_Data[15]")]
	public float m33; //Field offset: 0x3C

	public FrustumPlanes decomposeProjection
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRView", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(Rect), typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRView", Member = "ComputeEyeCenterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 112
	}

	public static Matrix4x4 identity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 91
	}

	public Matrix4x4 inverse
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderEvents", Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.UIR.RenderChain", "UnityEngine.UIElements.UIR.UIRenderDevice"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "SetWorldToCameraAndCameraToWorldMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(Matrix4x4)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.NormalReconstruction", Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<OccluderSubviewUpdate>", "Unity.Collections.NativeArray`1<Plane>"}, ReturnType = "UnityEngine.Rendering.OccluderDepthPyramidConstants")]
		[CallerCount(Count = 15)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 173
	}

	public float Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		 set { } //Length: 15
	}

	public float Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "PopulateConstantData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Config&", "StpConstantBufferData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.ReceiverPlanes", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverPlanes")]
		[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<OccluderSubviewUpdate>", "Unity.Collections.NativeArray`1<Plane>"}, ReturnType = "UnityEngine.Rendering.OccluderDepthPyramidConstants")]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommonShaderVariables", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderContext&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 280
		[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "ExtractRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 280
	}

	public Vector3 lossyScale
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 105
	}

	public Quaternion rotation
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 90
	}

	public Matrix4x4 transpose
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "CalculateBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Vector3&), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 173
	}

	public static Matrix4x4 zero
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "SetupMainLightShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(VisibleLight&), "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 90
	}

	[CallerCount(Count = 0)]
	private static Matrix4x4() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "GetScreenToWorldMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Matrix4x4[]")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.float4x4", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float4x4"}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 5)]
	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private FrustumPlanes DecomposeProjection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Matrix4x4 other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object other) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRView", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(Rect), typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRView", Member = "ComputeEyeCenterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public FrustumPlanes get_decomposeProjection() { }

	[CallerCount(Count = 0)]
	public static Matrix4x4 get_identity() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderEvents", Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.UIR.RenderChain", "UnityEngine.UIElements.UIR.UIRenderDevice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "SetWorldToCameraAndCameraToWorldMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.NormalReconstruction", Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<OccluderSubviewUpdate>", "Unity.Collections.NativeArray`1<Plane>"}, ReturnType = "UnityEngine.Rendering.OccluderDepthPyramidConstants")]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	public Matrix4x4 get_inverse() { }

	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "PopulateConstantData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Config&", "StpConstantBufferData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverPlanes", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverPlanes")]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<OccluderSubviewUpdate>", "Unity.Collections.NativeArray`1<Plane>"}, ReturnType = "UnityEngine.Rendering.OccluderDepthPyramidConstants")]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommonShaderVariables", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderContext&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public float get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	public float get_Item(int row, int column) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 get_lossyScale() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Quaternion get_rotation() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "CalculateBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Vector3&), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Matrix4x4 get_transpose() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "SetupMainLightShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(VisibleLight&), "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static Matrix4x4 get_zero() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "UpdateBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderDerivedData", Member = "FromParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderSubviewUpdate&"}, ReturnType = "UnityEngine.Rendering.OccluderDerivedData")]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverPlanes", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverPlanes")]
	[CalledBy(Type = "Unity.Mathematics.float4x4", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = "Unity.Mathematics.float4x4")]
	[CalledBy(Type = typeof(Bounds), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "PassData&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "GetSpotDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "SetupShadowCasterConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(VisibleLight&), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+Volume", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "RenderDebugXRViewsFrustum", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "GetLightAttenuationAndSpotDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType), typeof(float), typeof(Matrix4x4), typeof(float), "System.Nullable`1<Single>", typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Vector4 GetColumn(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private Vector3 GetLossyScale() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverPlanes", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverPlanes")]
	[CallerCount(Count = 2)]
	public Vector3 GetPosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private Quaternion GetRotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BMPAlloc", typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Vector4 GetRow(int index) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "UpdateBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "CalculateViewSpaceCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(float)}, ReturnType = "UnityEngine.Vector3[]")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SetViewAndProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "GetScreenToWorldMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Matrix4x4[]")]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Inverse_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "UpdateWorldTransformInverse", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "UpdateBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Inverse3DAffine_Injected(in Matrix4x4 input, ref Matrix4x4 result) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::LookAt", IsThreadSafe = True)]
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void LookAt_Injected(in Vector3 from, in Vector3 to, in Vector3 up, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "RenderDebugXRViewsFrustum", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+Volume", Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "CalculateViewSpaceCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(float)}, ReturnType = "UnityEngine.Vector3[]")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 12)]
	public Vector3 MultiplyPoint(Vector3 point) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "ComputeAAAlignedBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Matrix4x4)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalGetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3[]", typeof(Matrix4x4&)}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 23)]
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+Volume", Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public Vector3 MultiplyVector(Vector3 vector) { }

	[CalledBy(Type = typeof(Matrix4x4), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	[CallerCount(Count = 59)]
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewportLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Matrix4x4), typeof(Vector3), typeof(Vector3), typeof(bool)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewportDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(bool)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 9)]
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::Perspective", IsThreadSafe = True)]
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static Matrix4x4 Rotate(Quaternion q) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "GetLightUVScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalAdditionalLightData&", typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "SetWorldToCameraAndCameraToWorldMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	public static Matrix4x4 Scale(Vector3 vector) { }

	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "ExtractRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_Item(int index, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public void set_Item(int row, int column, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "GetLightUVScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalAdditionalLightData&", typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(Texture2D), "Config&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.NormalReconstruction", Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderDerivedData", Member = "FromParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderSubviewUpdate&"}, ReturnType = "UnityEngine.Rendering.OccluderDerivedData")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public void SetColumn(int index, Vector4 column) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 66)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "CalculateJitterMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.TemporalAA+JitterFunc"}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<OccluderSubviewUpdate>", "Unity.Collections.NativeArray`1<Plane>"}, ReturnType = "UnityEngine.Rendering.OccluderDepthPyramidConstants")]
	[CallerCount(Count = 4)]
	public static Matrix4x4 Translate(Vector3 vector) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::Transpose", IsThreadSafe = True)]
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Transpose_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "CreateInstancedProbes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+Cell"}, ReturnType = "UnityEngine.Rendering.ProbeReferenceVolume+CellInstancedDebugProbes")]
	[CalledBy(Type = typeof(Graphics), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Material), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void TRS_Injected(in Vector3 pos, in Quaternion q, in Vector3 s, out Matrix4x4 ret) { }

}

