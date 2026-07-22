namespace UnityEngine.Rendering.Universal.Internal;

public class CopyColorPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__23_0; //Field offset: 0x8

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
		[Calls(Type = typeof(CopyColorPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.CopyColorPass+PassData", typeof(RTHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderInternal>b__23_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle source; //Field offset: 0x10
		internal TextureHandle destination; //Field offset: 0x20
		internal bool useProceduralBlit; //Field offset: 0x30
		internal Material samplingMaterial; //Field offset: 0x38
		internal Material copyColorMaterial; //Field offset: 0x40
		internal Downsampling downsamplingMethod; //Field offset: 0x48
		internal int sampleOffsetShaderHandle; //Field offset: 0x4C

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private int m_SampleOffsetShaderHandle; //Field offset: 0xB8
	private Material m_SamplingMaterial; //Field offset: 0xC0
	private Downsampling m_DownsamplingMethod; //Field offset: 0xC8
	private Material m_CopyColorMaterial; //Field offset: 0xD0
	[CompilerGenerated]
	private RTHandle <source>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private RTHandle <destination>k__BackingField; //Field offset: 0xE0
	private PassData m_PassData; //Field offset: 0xE8

	private RTHandle destination
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	private RTHandle source
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null, string customPassName = null) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyColorPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassData), typeof(RTHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(<>c), Member = "<RenderInternal>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CopyColorPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle source, bool useDrawProceduralBlit) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private RTHandle get_destination() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private RTHandle get_source() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyColorPass), Member = "RenderInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal TextureHandle Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle destination, in TextureHandle source, Downsampling downsampling) { }

	[CalledBy(Type = typeof(CopyColorPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(Downsampling)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(CopyColorPass), Member = "RenderToExistingTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(Downsampling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	private void RenderInternal(RenderGraph renderGraph, in TextureHandle destination, in TextureHandle source, bool useProceduralBlit) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "RenderRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyColorPass), Member = "RenderInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void RenderToExistingTexture(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle destination, in TextureHandle source, Downsampling downsampling = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_destination(RTHandle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_source(RTHandle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandles for source and destination.", True)]
	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling) { }

}

