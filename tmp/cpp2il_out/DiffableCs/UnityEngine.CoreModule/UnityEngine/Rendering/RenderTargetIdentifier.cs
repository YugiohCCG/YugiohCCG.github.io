namespace UnityEngine.Rendering;

public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	public const int AllDepthSlices = -1; //Field offset: 0x0
	private BuiltinRenderTextureType m_Type; //Field offset: 0x0
	private int m_NameID; //Field offset: 0x4
	private int m_InstanceID; //Field offset: 0x8
	private IntPtr m_BufferPointer; //Field offset: 0x10
	private int m_MipLevel; //Field offset: 0x18
	private CubemapFace m_CubeFace; //Field offset: 0x1C
	private int m_DepthSlice; //Field offset: 0x20

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttachmentDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public RenderTargetIdentifier(BuiltinRenderTextureType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public RenderTargetIdentifier(string name) { }

	[CallerCount(Count = 0)]
	public RenderTargetIdentifier(int nameID) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderTargetHandle", Member = "Identifier", ReturnType = typeof(RenderTargetIdentifier))]
	[CallerCount(Count = 1)]
	public RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPassCreateInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "IsHandleYFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetCameraTargetIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(RenderTargetIdentifier))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandle", Member = "SetRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandle", Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandles", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ClearCubemap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTexture), typeof(Color), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetCameraTargetIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(RenderTargetIdentifier))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public RenderTargetIdentifier(Texture tex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(RenderTargetIdentifier rhs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandle", Member = "GetInstanceID", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AttachmentDescriptor), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateGbufferResources", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public static RenderTargetIdentifier op_Implicit(string name) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraRenderType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(RenderBufferStoreAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderTargetHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetLastValidColorBufferIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderTargetIdentifier[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetValidColorBufferCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "IsMRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CountDistinct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "LastValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	[CallerCount(Count = 34)]
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetLastValidColorBufferIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderTargetIdentifier[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]", "UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "LastValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CountDistinct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "IsMRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetValidColorBufferCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle[]"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderTargetHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.ResourceHandle&", "UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&"}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", Member = "ComputeTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.HashFNV1A32&", "UnityEngine.Rendering.RenderGraphModule.ResourceHandle&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "ImportXRMotionColorAndDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SwapColorBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 30)]
	public virtual string ToString() { }

}

