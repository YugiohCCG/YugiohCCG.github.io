namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	internal static Dictionary<Int32, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; //Field offset: 0x8

	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	public static GraphicsTier activeTier
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "HasShaderDefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderDefine)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	public static OpenGLESVersion minOpenGLESVersion
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 91
	}

	public static bool preserveFramebufferAlpha
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 91
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static Graphics() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Blit4_Injected(IntPtr source, IntPtr dest, in Vector2 scale, in Vector2 offset) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	public static void ClearRandomWriteTargets() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeBrickPool+DataLocation", "System.Collections.Generic.List`1<BrickChunkAlloc>", "System.Collections.Generic.List`1<BrickChunkAlloc>", typeof(int), "UnityEngine.Rendering.ProbeVolumeSHBands"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "UpdateValidity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeBrickPool+DataLocation", "System.Collections.Generic.List`1<BrickChunkAlloc>", "System.Collections.Generic.List`1<BrickChunkAlloc>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 4)]
	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateTexture2DArrayFromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(string)}, ReturnType = typeof(Texture2DArray))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("CopyTextureRegion")]
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyTexture_Region_Injected(IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, IntPtr dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyTexture_Slice_Injected(IntPtr src, int srcElement, int srcMip, IntPtr dst, int dstElement, int dstMip) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 7)]
	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "get_enableInstancing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphics), Member = "Internal_DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 40)]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = True, ThrowsException = True)]
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ExecuteCommandBuffer_Injected(IntPtr buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "HasShaderDefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderDefine)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static GraphicsTier get_activeTier() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static OpenGLESVersion get_minOpenGLESVersion() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_preserveFramebufferAlpha() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "GetMinOpenGLESVersion")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	internal static OpenGLESVersion GetMinOpenGLESVersion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "GetPreserveFramebufferAlpha")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	internal static bool GetPreserveFramebufferAlpha() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[FreeFunction("GraphicsScripting::DrawMesh")]
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMesh_Injected(IntPtr mesh, int submeshIndex, in Matrix4x4 matrix, IntPtr material, int layer, IntPtr camera, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, IntPtr probeAnchor, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume) { }

	[CalledBy(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("GraphicsScripting::DrawMeshInstanced")]
	private static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMeshInstanced_Injected(IntPtr mesh, int submeshIndex, IntPtr material, ref ManagedSpanWrapper matrices, int count, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRTSimple_Injected(in RenderBuffer color, in RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_activeTier(GraphicsTier value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "EndBlit", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt) { }

	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthBuffer", ReturnType = typeof(RenderBuffer))]
	[CallsUnknownMethods(Count = 5)]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthBuffer", ReturnType = typeof(RenderBuffer))]
	[CallsUnknownMethods(Count = 5)]
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

}

