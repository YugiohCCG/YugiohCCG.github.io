namespace UnityEngine.Rendering;

public class RTHandle
{
	internal RTHandleSystem m_Owner; //Field offset: 0x10
	internal RenderTexture m_RT; //Field offset: 0x18
	internal Texture m_ExternalTexture; //Field offset: 0x20
	internal RenderTargetIdentifier m_NameID; //Field offset: 0x28
	internal bool m_EnableMSAA; //Field offset: 0x50
	internal bool m_EnableRandomWrite; //Field offset: 0x51
	internal bool m_EnableHWDynamicScale; //Field offset: 0x52
	internal bool m_RTHasOwnership; //Field offset: 0x53
	internal string m_Name; //Field offset: 0x58
	internal bool m_UseCustomHandleScales; //Field offset: 0x60
	internal RTHandleProperties m_CustomHandleProperties; //Field offset: 0x64
	[CompilerGenerated]
	private Vector2 <scaleFactor>k__BackingField; //Field offset: 0x94
	internal ScaleFunc scaleFunc; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <useScaling>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private Vector2Int <referenceSize>k__BackingField; //Field offset: 0xAC

	public Texture externalTexture
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool isMSAAEnabled
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string name
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public RenderTargetIdentifier nameID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 29
	}

	public internal Vector2Int referenceSize
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 8
	}

	public RenderTexture rt
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public RTHandleProperties rtHandleProperties
	{
		[CallerCount(Count = 41)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 89
	}

	public internal Vector2 scaleFactor
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal bool useScaling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal RTHandle(RTHandleSystem owner) { }

	[CallerCount(Count = 0)]
	public void ClearCustomHandleProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBufferExtensions), Member = "SwitchIntoFastMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(FastMemoryFlags), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Texture get_externalTexture() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public bool get_isMSAAEnabled() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RenderTargetIdentifier get_nameID() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Int get_referenceSize() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public RenderTexture get_rt() { }

	[CallerCount(Count = 41)]
	[CallsUnknownMethods(Count = 1)]
	public RTHandleProperties get_rtHandleProperties() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_scaleFactor() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_useScaling() { }

	[CalledBy(Type = typeof(TexturePool), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RTHandleResourcePool", Member = "AddResourceToPool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(RTHandle), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "ReAllocateGBufferIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int GetInstanceID() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Vector2Int GetScaledSize() { }

	[CalledBy(Type = typeof(RTHandleSystem), Member = "DemandResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetViewportAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle), typeof(ClearFlag)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUtils), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Vector2Int GetScaledSize(Vector2Int refSize) { }

	[CallerCount(Count = 36)]
	public static RenderTargetIdentifier op_Implicit(RTHandle handle) { }

	[CalledBy(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "BlitMaterialRenderFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils+BlitMaterialPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoLensFlareScreenSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoMotionBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupColorGrading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&", typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.FullScreenPassRendererFeature+FullScreenRenderPass", Member = "ExecuteMainPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", typeof(RTHandle), typeof(RTHandle), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupVFXCameraBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyDepthPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.CopyDepthPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<RenderDebugOccluderOverlay>b__32_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OccluderOverlayPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public static Texture op_Implicit(RTHandle handle) { }

	[CalledBy(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 2)]
	public static RenderTexture op_Implicit(RTHandle handle) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallsUnknownMethods(Count = 3)]
	public void Release() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_referenceSize(Vector2Int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_scaleFactor(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_useScaling(bool value) { }

	[CallerCount(Count = 0)]
	public void SetCustomHandleProperties(in RTHandleProperties properties) { }

	[CalledBy(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RTHandleAllocInfo)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RTHandleSystem), Member = "AllocAutoSizedRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RTHandleSystem), Member = "AllocAutoSizedRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RTHandleAllocInfo)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RTHandleAllocInfo)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetRenderTexture(RenderTexture rt, bool transferOwnership = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetTexture(Texture tex) { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetInfo&), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetTexture(RenderTargetIdentifier tex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBufferExtensions), Member = "SwitchOutOfFastMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool)}, ReturnType = typeof(void))]
	public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true) { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTextureCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(IRenderGraphResource)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBufferExtensions), Member = "SwitchIntoFastMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(FastMemoryFlags), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1, bool copyContents = false) { }

}

