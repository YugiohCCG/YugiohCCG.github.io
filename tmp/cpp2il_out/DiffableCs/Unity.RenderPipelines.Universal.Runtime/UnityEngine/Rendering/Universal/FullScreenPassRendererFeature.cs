namespace UnityEngine.Rendering.Universal;

[MovedFrom(null)]
public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver
{
	public class FullScreenRenderPass : ScriptableRenderPass
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static BaseRenderFunc<CopyPassData, RasterGraphContext> <>9__14_0; //Field offset: 0x8
			public static BaseRenderFunc<MainPassData, RasterGraphContext> <>9__14_1; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
			[Calls(Type = typeof(FullScreenRenderPass), Member = "ExecuteCopyColorPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			internal void <RecordRenderGraph>b__14_0(CopyPassData data, RasterGraphContext rgContext) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
			[Calls(Type = typeof(FullScreenRenderPass), Member = "ExecuteMainPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			internal void <RecordRenderGraph>b__14_1(MainPassData data, RasterGraphContext rgContext) { }

		}

		private class CopyPassData
		{
			internal TextureHandle inputTexture; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public CopyPassData() { }

		}

		private class MainPassData
		{
			internal Material material; //Field offset: 0x10
			internal int passIndex; //Field offset: 0x18
			internal TextureHandle inputTexture; //Field offset: 0x1C

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public MainPassData() { }

		}

		private static MaterialPropertyBlock s_SharedPropertyBlock; //Field offset: 0x0
		private Material m_Material; //Field offset: 0xB8
		private int m_PassIndex; //Field offset: 0xC0
		private bool m_FetchActiveColor; //Field offset: 0xC4
		private bool m_BindDepthStencilAttachment; //Field offset: 0xC5
		private RTHandle m_CopiedColor; //Field offset: 0xC8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private static FullScreenRenderPass() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
		public FullScreenRenderPass(string passName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
		[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
		[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(FullScreenRenderPass), Member = "ExecuteCopyColorPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraDepthTargetHandle", ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FullScreenRenderPass), Member = "ExecuteMainPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

		[CalledBy(Type = typeof(<>c), Member = "<RecordRenderGraph>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CopyPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FullScreenRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		private static void ExecuteCopyColorPass(RasterCommandBuffer cmd, RTHandle sourceTexture) { }

		[CalledBy(Type = typeof(<>c), Member = "<RecordRenderGraph>b__14_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MainPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FullScreenRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private static void ExecuteMainPass(RasterCommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptableRenderPass), Member = "ResetTarget", ReturnType = typeof(void))]
		[Calls(Type = typeof(CameraData), Member = "get_cameraTargetDescriptor", ReturnType = typeof(RenderTextureDescriptor&))]
		[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		internal void ReAllocate(RenderTextureDescriptor desc) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(RenderGraph), Member = "GetTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureDesc))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
		[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraOpaqueTexture", ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorDepth", ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraNormalsTexture", ReturnType = typeof(TextureHandle))]
		[Calls(Type = typeof(UniversalResourceData), Member = "get_activeDepthTexture", ReturnType = typeof(TextureHandle))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 51)]
		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void SetupMembers(Material material, int passIndex, bool fetchActiveColor, bool bindDepthStencilAttachment) { }

	}

	internal enum InjectionPoint
	{
		BeforeRenderingTransparents = 450,
		BeforeRenderingPostProcessing = 550,
		AfterRenderingPostProcessing = 600,
	}

	private enum Version
	{
		Uninitialised = -1,
		Initial = 0,
		AddFetchColorBufferCheckbox = 1,
		Count = 2,
		Latest = 1,
	}

	public InjectionPoint injectionPoint; //Field offset: 0x20
	public bool fetchColorBuffer; //Field offset: 0x24
	public ScriptableRenderPassInput requirements; //Field offset: 0x28
	public Material passMaterial; //Field offset: 0x30
	public int passIndex; //Field offset: 0x38
	public bool bindDepthStencilAttachment; //Field offset: 0x3C
	private FullScreenRenderPass m_FullScreenPass; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private Version m_Version; //Field offset: 0x48

	[CalledBy(Type = typeof(FullScreenPassRendererFeature_OldGUID), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRendererFeature), Member = ".ctor", ReturnType = typeof(void))]
	public FullScreenPassRendererFeature() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_cameraType", ReturnType = typeof(CameraType&))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsOffscreenDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_passCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	[CallerCount(Count = 0)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[CallerCount(Count = 0)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void UpgradeIfNeeded() { }

}

