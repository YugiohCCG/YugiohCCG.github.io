namespace UnityEngine.Rendering.RenderGraphModule;

internal class RenderGraphBuilders : IBaseRenderGraphBuilder, IDisposable, IComputeRenderGraphBuilder, IRasterRenderGraphBuilder, IUnsafeRenderGraphBuilder
{
	private RenderGraphPass m_RenderPass; //Field offset: 0x10
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x18
	private RenderGraph m_RenderGraph; //Field offset: 0x20
	private bool m_Disposed; //Field offset: 0x28

	[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RenderGraphBuilders() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void AllowGlobalStateModification(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void AllowPassCulling(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckFrameBufferFetchEmulationIsSupported(in TextureHandle tex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[ContainsUnimplementedInstructions]
	private void CheckNotUseFragment(TextureHandle tex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceTransientIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckResource(in ResourceHandle res, bool checkTransientReadWrite = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 52)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckUseFragment(TextureHandle tex, bool isDepth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetBufferResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(BufferDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BufferHandle CreateTransientBuffer(in BufferHandle computebuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	public BufferHandle CreateTransientBuffer(in BufferDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AllGlobals", ReturnType = typeof(System.Collections.Generic.Dictionary`2+ValueCollection<System.Int32, UnityEngine.Rendering.RenderGraphModule.TextureHandle>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "SetGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "OnPassAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void EnableAsyncCompute(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void EnableFoveatedRasterization(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceTransientIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetLatestVersionHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	private ResourceHandle GetLatestVersionHandle(in ResourceHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = "System.ValueTuple`2<T1, T2>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void SetGlobalTextureAfterPass(in TextureHandle input, int propertyId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 2)]
	public override void SetInputAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 2)]
	public override TextureHandle SetRandomAccessAttachment(TextureHandle input, int index, AccessFlags flags = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 2)]
	public override void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 2)]
	public override void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags, int mipLevel, int depthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override void SetRenderFunc(BaseRenderFunc<PassData, ComputeGraphContext> renderFunc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override void SetRenderFunc(BaseRenderFunc<PassData, RasterGraphContext> renderFunc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override void SetRenderFunc(BaseRenderFunc<PassData, UnsafeGraphContext> renderFunc) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Setup(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetBufferResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(BufferDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(in BufferHandle computebuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	private override BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(in BufferDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	private override TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(in TextureDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(in TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = "System.ValueTuple`2<T1, T2>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.SetGlobalTextureAfterPass(in TextureHandle input, int propertyId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[DeduplicatedMethod]
	private override BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseBuffer(in BufferHandle input, AccessFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseRendererList(in RendererListHandle input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseTexture(in TextureHandle input, AccessFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void UseAllGlobalTextures(bool enable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[DeduplicatedMethod]
	public BufferHandle UseBuffer(in BufferHandle input, AccessFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 2)]
	public override BufferHandle UseBufferRandomAccess(BufferHandle input, int index, bool preserveCounterValue, AccessFlags flags = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallsUnknownMethods(Count = 2)]
	public override BufferHandle UseBufferRandomAccess(BufferHandle input, int index, AccessFlags flags = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "GetGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override void UseGlobalTexture(int propertyId, AccessFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void UseRendererList(in RendererListHandle input) { }

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementReadCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetLatestVersionHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(ResourceHandle))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceShared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IncrementWriteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceTransientIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private ResourceHandle UseResource(in ResourceHandle handle, AccessFlags flags, bool isTransient = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[DeduplicatedMethod]
	public void UseTexture(in TextureHandle input, AccessFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 40)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateWriteTo(in ResourceHandle handle) { }

}

