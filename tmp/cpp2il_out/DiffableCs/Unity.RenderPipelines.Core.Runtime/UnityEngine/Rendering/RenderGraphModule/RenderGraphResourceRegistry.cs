namespace UnityEngine.Rendering.RenderGraphModule;

internal class RenderGraphResourceRegistry
{
	private class RenderGraphResourcesData
	{
		public DynamicArray<IRenderGraphResource> resourceArray; //Field offset: 0x10
		public int sharedResourcesCount; //Field offset: 0x18
		public IRenderGraphResourcePool pool; //Field offset: 0x20
		public ResourceCreateCallback createResourceCallback; //Field offset: 0x28
		public ResourceCallback releaseResourceCallback; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public RenderGraphResourcesData() { }

		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ImportResourceParams&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTargetInfo), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreateSharedTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetInfo&), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
		[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure&), typeof(string)}, ReturnType = typeof(RayTracingAccelerationStructureHandle))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public int AddNewRenderGraphResource(out ResType outRes, bool pooledResource = true) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public void Cleanup() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Clear(bool onException, int frameIndex) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void PurgeUnusedGraphicsResources(int frameIndex) { }

	}

	private sealed class ResourceCallback : MulticastDelegate
	{

		[CallerCount(Count = 290)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public ResourceCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(InternalRenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	}

	private sealed class ResourceCreateCallback : MulticastDelegate
	{

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public ResourceCreateCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(InternalRenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override bool EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool Invoke(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	}

	private const int kSharedResourceLifetime = 30; //Field offset: 0x0
	private static RenderGraphResourceRegistry m_CurrentRegistry; //Field offset: 0x0
	private const int kInitialRendererListCount = 256; //Field offset: 0x0
	private static RenderTargetIdentifier emptyId; //Field offset: 0x8
	private static RenderTargetIdentifier builtinCameraRenderTarget; //Field offset: 0x30
	private RenderGraphResourcesData[] m_RenderGraphResources; //Field offset: 0x10
	private DynamicArray<RendererListResource> m_RendererListResources; //Field offset: 0x18
	private DynamicArray<RendererListLegacyResource> m_RendererListLegacyResources; //Field offset: 0x20
	private RenderGraphDebugParams m_RenderGraphDebug; //Field offset: 0x28
	private RenderGraphLogger m_ResourceLogger; //Field offset: 0x30
	private RenderGraphLogger m_FrameInformationLogger; //Field offset: 0x38
	private int m_CurrentFrameIndex; //Field offset: 0x40
	private int m_ExecutionCount; //Field offset: 0x44
	private RTHandle m_CurrentBackbuffer; //Field offset: 0x48
	private List<RendererList> m_ActiveRendererLists; //Field offset: 0x50
	internal bool forceManualClearOfResource; //Field offset: 0x58

	internal static RenderGraphResourceRegistry current
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 105
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(void))]
	private static RenderGraphResourceRegistry() { }

	[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourcePool`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private RenderGraphResourceRegistry() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void BeginExecute(int currentFrameIndex) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 3)]
	internal void BeginRenderGraph(int executionCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckBufferResource(BufferResource bufferResource) { }

	[CallerCount(Count = 13327)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[DeduplicatedMethod]
	private void CheckHandleValidity(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckHandleValidity(RenderGraphResourceType type, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void CheckTextureResource(TextureResource texResource) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RTHandles), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ClearCompiledGraph", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ClearCompiledGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void Clear(bool onException) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteInitializeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ClearTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(TextureResource)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void ClearResource(InternalRenderGraphContext rgContext, int type, int index) { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTextureCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(IRenderGraphResource)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ClearResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ClearTexture(InternalRenderGraphContext rgContext, TextureResource resource) { }

	[CalledBy(Type = typeof(RenderGraphResources), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal BufferHandle CreateBuffer(in BufferDesc desc, int transientPassIndex = -1) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateGizmoRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&), typeof(GizmoSubset&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateGizmoRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(GizmoSubset)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateGizmoRendererList(ScriptableRenderContext context, in Camera camera, in GizmoSubset gizmoSubset) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "CreatePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteInitializeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal bool CreatePooledResource(InternalRenderGraphContext rgContext, int type, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreatePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	internal bool CreatePooledResource(InternalRenderGraphContext rgContext, in ResourceHandle handle) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RendererListDesc), Member = "ConvertToParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(RendererListParams))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RendererListResource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal RendererListHandle CreateRendererList(in RendererListParams desc) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileNativeRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassCompiler))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateRendererLists", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListResource&))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListLegacyResource&))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "PrepareRendererListsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RendererList>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateShadowRendererList(ScriptableRenderContext context, ref ShadowDrawingSettings shadowDrawinSettings) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateSharedTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateSkyboxRendererList(ScriptableRenderContext context, in Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(string), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateTextureIfInvalid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandle), Member = "SwitchToFastMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(FastMemoryFlags), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ClearTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(TextureResource)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool CreateTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateUIOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&)}, ReturnType = typeof(RendererListHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateUIOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&), typeof(UISubset&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateUIOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UISubset)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateUIOverlayRendererList(ScriptableRenderContext context, in Camera camera, in UISubset uiSubset) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateWireOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&)}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateWireOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListLegacyResource&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererListHandle CreateWireOverlayRendererList(ScriptableRenderContext context, in Camera camera) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "SetIntraFrameMemoryAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void EnableIntraFrameMemoryAliasing(bool enabled) { }

	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void EndExecute() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "EndFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphLogger), Member = "GetAllLogs", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void FlushLogs() { }

	[CallerCount(Count = 0)]
	internal static RenderGraphResourceRegistry get_current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 3)]
	internal GraphicsBuffer GetBuffer(in BufferHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal GraphicsBuffer GetBuffer(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	private BufferResource GetBufferResource(in ResourceHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	private BufferResource GetBufferResource(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetBufferResourceCount() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "GetBufferDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferDesc))]
	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal BufferDesc GetBufferResourceDesc(in ResourceHandle handle, bool noThrowOnInvalidDesc = false) { }

	[CallerCount(Count = 0)]
	internal GraphicsFormat GetFormat(GraphicsFormat color, GraphicsFormat depthStencil) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "GetLatestVersionHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(ResourceHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceShared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal ResourceHandle GetLatestVersionHandle(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceShared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal int GetLatestVersionNumber(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceShared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ResourceHandle GetNewVersionedHandle(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 3)]
	internal RayTracingAccelerationStructure GetRayTracingAccelerationStructure(in RayTracingAccelerationStructureHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	private RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource(in ResourceHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetRayTracingAccelerationStructureResourceCount() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AreRendererListsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListResource&))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListLegacyResource&))]
	[CallsUnknownMethods(Count = 1)]
	internal RendererList GetRendererList(in RendererListHandle handle) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "ValidateWriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CheckNotUseFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CheckUseFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal string GetRenderGraphResourceName(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CheckResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "GetLatestVersionHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(ResourceHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CheckResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetInfo))]
	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CheckUseFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ValidateRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(NativePassData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderTexture), Member = "get_volumeDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_antiAliasing", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthStencilFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureDesc), Member = "CalculateFinalDimensions", ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_bindTextureMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal void GetRenderTargetInfo(in ResourceHandle res, out RenderTargetInfo outInfo) { }

	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetResourceCount(RenderGraphResourceType type) { }

	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal IRenderGraphResource GetResourceLowLevel(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateAllSharedResourceLastFrameIndex", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetSharedResourceCount(RenderGraphResourceType type) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(NativePassData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteSetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), typeof(RenderGraphResourceRegistry), typeof(int), typeof(ResourceHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal RTHandle GetTexture(int index) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AllocateCulledPassResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "PreRenderPassSetRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CalledBy(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "BlitMaterialRenderFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils+BlitMaterialPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[CallsUnknownMethods(Count = 2)]
	internal RTHandle GetTexture(in TextureHandle handle) { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AllocateCulledPassResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "ReadTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphPass), Member = "ComputeTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashFNV1A32&), typeof(ResourceHandle&), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "TextureNeedsFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "RefreshSharedTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&), typeof(TextureDesc&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ReleaseSharedTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal TextureResource GetTextureResource(in ResourceHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal TextureResource GetTextureResource(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetTextureResourceCount() { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(string), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "GetTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureDesc))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphPass), Member = "ComputeTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashFNV1A32&), typeof(ResourceHandle&), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(NativePassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle, bool noThrowOnInvalidDesc = false) { }

	[CallerCount(Count = 0)]
	internal ResourceHandle GetZeroVersionedHandle(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetInfo), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandle), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, in RenderTargetInfo info, in ImportResourceParams importParams) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer, bool forceRelease = false) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ImportRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure&), typeof(string)}, ReturnType = typeof(RayTracingAccelerationStructureHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RayTracingAccelerationStructureHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(in RayTracingAccelerationStructure accelStruct, string name) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Texture), Member = "get_wrapMode", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "get_anisoLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture), Member = "get_mipMapBias", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 6)]
	internal TextureHandle ImportTexture(in RTHandle rt, in ImportResourceParams importParams, bool isBuiltin = false) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ImportResourceParams&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	internal TextureHandle ImportTexture(in RTHandle rt, bool isBuiltin = false) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RenderTargetInfo), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourcesData), Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	internal TextureHandle ImportTexture(in RTHandle rt, RenderTargetInfo info, in ImportResourceParams importParams) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void IncrementReadCount(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "UseColorBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "UseDepthBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&), typeof(DepthAccess)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "ReadTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "WriteTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "ReadWriteTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "WriteRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructureHandle&)}, ReturnType = typeof(RayTracingAccelerationStructureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "WriteBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void IncrementWriteCount(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsGraphicsResourceCreated(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListResource&))]
	[Calls(Type = typeof(RendererList), Member = "get_isValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RendererListLegacyResource&))]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsRendererListCreated(in RendererListHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsRenderGraphResourceForceReleased(RenderGraphResourceType type, int index) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index) { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CountReferences", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "UseDepthBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&), typeof(DepthAccess)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "ReadTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphPass), Member = "ComputeTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashFNV1A32&), typeof(ResourceHandle&), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsRenderGraphResourceImported(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(AccessFlags), typeof(bool)}, ReturnType = typeof(ResourceHandle))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetLatestVersionHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(ResourceHandle))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetLatestVersionNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetNewVersionedHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(ResourceHandle))]
	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsRenderGraphResourceShared(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void LogResources() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ManageSharedRenderGraphResources() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void NewVersion(in ResourceHandle res) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "EndFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void PurgeUnusedGraphicsResources() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "RefreshSharedTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureDesc&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void RefreshSharedTextureDesc(in TextureHandle texture, in TextureDesc desc) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ReleaseImmediateModeResources", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ReleasePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(ResourceHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteDestroyResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void ReleasePooledResource(InternalRenderGraphContext rgContext, int type, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ReleasePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal void ReleasePooledResource(InternalRenderGraphContext rgContext, in ResourceHandle handle) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ReleaseSharedTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void ReleaseSharedTexture(in TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseTextureCallback(InternalRenderGraphContext rgContext, IRenderGraphResource res) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void set_current(RenderGraphResourceRegistry value) { }

	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "UseDepthBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&), typeof(DepthAccess)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "ReadTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool TextureNeedsFallback(in TextureHandle handle) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateAllSharedResourceLastFrameIndex", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateSharedResourceLastFrameIndex(int type, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateSharedResourceLastFrameIndex(in ResourceHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateBufferDesc(in BufferDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void ValidateFormat(GraphicsFormat color, GraphicsFormat depthStencil) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RendererListDesc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateRenderTarget(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateTextureDesc(in TextureDesc desc) { }

}

