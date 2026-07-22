namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public struct RenderGraphBuilder : IDisposable
{
	private RenderGraphPass m_RenderPass; //Field offset: 0x0
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x8
	private RenderGraph m_RenderGraph; //Field offset: 0x10
	private bool m_Disposed; //Field offset: 0x18

	[CalledBy(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "EndProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AllowPassCulling(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AllowRendererListCulling(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceTransientIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckResource(in ResourceHandle res, bool checkTransientReadWrite = true) { }

	[CalledBy(Type = typeof(RenderGraphResources), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResources), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder)}, ReturnType = typeof(RenderGraphResources))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 2)]
	public BufferHandle CreateTransientBuffer(in BufferDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetBufferResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(BufferDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 2)]
	public BufferHandle CreateTransientBuffer(in BufferHandle graphicsbuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 2)]
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 2)]
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public RendererListHandle DependsOn(in RendererListHandle input) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RenderGraph), Member = "OnPassAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RenderGraph), Member = "OnPassAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableAsyncCompute(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableFoveatedRasterization(bool value) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "EndProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void GenerateDebugData(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public BufferHandle ReadBuffer(in BufferHandle input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public RayTracingAccelerationStructureHandle ReadRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "TextureNeedsFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[Calls(Type = typeof(RenderGraph), Member = "GetImportedFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextureHandle ReadTexture(in TextureHandle input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextureHandle ReadWriteTexture(in TextureHandle input) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RenderFragmentationOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(DebugOverlay)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "BeginProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "EndProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public void SetRenderFunc(BaseRenderFunc<PassData, RenderGraphContext> renderFunc) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RenderFragmentationOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(DebugOverlay)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public TextureHandle UseColorBuffer(in TextureHandle input, int index) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RenderFragmentationOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(DebugOverlay)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "TextureNeedsFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public RendererListHandle UseRendererList(in RendererListHandle input) { }

	[CalledBy(Type = typeof(RenderGraphResources), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public BufferHandle WriteBuffer(in BufferHandle input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public RayTracingAccelerationStructureHandle WriteRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public TextureHandle WriteTexture(in TextureHandle input) { }

}

