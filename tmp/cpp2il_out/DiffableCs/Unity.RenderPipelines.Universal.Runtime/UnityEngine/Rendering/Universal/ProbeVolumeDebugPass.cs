namespace UnityEngine.Rendering.Universal;

internal class ProbeVolumeDebugPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<WriteApvData, ComputeGraphContext> <>9__7_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BufferHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle)}, ReturnType = typeof(GraphicsBuffer))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__7_0(WriteApvData data, ComputeGraphContext ctx) { }

	}

	private class WriteApvData
	{
		public ComputeShader computeShader; //Field offset: 0x10
		public BufferHandle resultBuffer; //Field offset: 0x18
		public Vector2 clickCoordinates; //Field offset: 0x24
		public TextureHandle depthBuffer; //Field offset: 0x2C
		public TextureHandle normalBuffer; //Field offset: 0x3C

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public WriteApvData() { }

	}

	private ComputeShader m_ComputeShader; //Field offset: 0xB8
	private RTHandle m_DepthTexture; //Field offset: 0xC0
	private RTHandle m_NormalTexture; //Field offset: 0xC8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ProbeVolumeDebugPass(RenderPassEvent evt, ComputeShader computeShader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_camera", ReturnType = typeof(Camera&))]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "GetProbeSamplingDebugResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(GraphicsBuffer&), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ProbeReferenceVolume), Member = "GetProbeSamplingDebugResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(GraphicsBuffer&), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle depthPyramidBuffer, TextureHandle normalBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Setup(RTHandle depthBuffer, RTHandle normalBuffer) { }

}

