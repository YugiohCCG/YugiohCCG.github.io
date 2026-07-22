namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal class NativePassCompiler : IDisposable
{
	public enum NativeCompilerProfileId
	{
		NRPRGComp_PrepareNativePass = 0,
		NRPRGComp_SetupContextData = 1,
		NRPRGComp_BuildGraph = 2,
		NRPRGComp_CullNodes = 3,
		NRPRGComp_TryMergeNativePasses = 4,
		NRPRGComp_FindResourceUsageRanges = 5,
		NRPRGComp_DetectMemorylessResources = 6,
		NRPRGComp_ExecuteInitializeResources = 7,
		NRPRGComp_ExecuteBeginRenderpassCommand = 8,
		NRPRGComp_ExecuteDestroyResources = 9,
	}

	public struct RenderGraphInputInfo
	{
		public RenderGraphResourceRegistry m_ResourcesForDebugOnly; //Field offset: 0x0
		public List<RenderGraphPass> m_RenderPasses; //Field offset: 0x8
		public string debugName; //Field offset: 0x10
		public bool disableCulling; //Field offset: 0x18

	}

	internal const int k_EstimatedPassCount = 100; //Field offset: 0x0
	internal const int k_MaxSubpass = 8; //Field offset: 0x0
	private const int ArbitraryMaxNbMergedPasses = 16; //Field offset: 0x0
	internal RenderGraphInputInfo graph; //Field offset: 0x10
	internal CompilerContextData contextData; //Field offset: 0x30
	internal CompilerContextData defaultContextData; //Field offset: 0x38
	internal CommandBuffer previousCommandBuffer; //Field offset: 0x40
	private Stack<Int32> toVisitPassIds; //Field offset: 0x48
	private RenderGraphCompilationCache m_CompilationCache; //Field offset: 0x50
	private NativeList<AttachmentDescriptor> m_BeginRenderPassAttachments; //Field offset: 0x58
	private DynamicArray<Name> graphPassNamesForDebug; //Field offset: 0x60

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileNativeRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassCompiler))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public NativePassCompiler(RenderGraphCompilationCache cache) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Name&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(PassData), Member = "ResetAndInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompilerContextData), Member = "AddToFragmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureAccess), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PassData), Member = "SetupAndValidateFragmentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle), typeof(CompilerContextData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompilerContextData), Member = "AddToRandomAccessResourceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle), typeof(int), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 61)]
	[ContainsUnimplementedInstructions]
	private void BuildGraph() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CompilerContextData), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Dispose", ReturnType = typeof(void))]
	public void Cleanup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Clear(bool clearContextData) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileNativeRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassCompiler))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativePassCompiler), Member = "SetupContextData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "CullUnusedRenderPasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "TryMergeNativePasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "FindResourceUsageRanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "DetectMemoryLessResources", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativePassCompiler), Member = "DetermineLoadStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativePassData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Compile(RenderGraphResourceRegistry resources) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private void CullUnusedRenderPasses() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativePassIterator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativePassCompiler), Member = "IsGlobalTextureInPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(ResourceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private void DetectMemoryLessResources() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "PrepareNativeRenderPasses", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassAttachment>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativePassAttachment&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private void DetermineLoadStoreActions(ref NativePassData nativePass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativePassCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "set_resolveTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "set_loadStoreTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.AttachmentDescriptor>), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SubPassDescriptor>), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal void ExecuteBeginRenderPass(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref NativePassData nativePass) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = "ReleaseAllTempAlloc", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ReleasePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 20)]
	private void ExecuteDestroyResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref PassData pass) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteNativeRenderGraph", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "ExecuteDestroyResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(PassData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndRenderPass", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeQueueType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.GraphicsFence>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFence)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "CreateAsyncGraphicsFence", ReturnType = typeof(GraphicsFence))]
	[Calls(Type = typeof(NativePassCompiler), Member = "ExecuteGraphNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext&), typeof(RenderGraphResourceRegistry), typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "ExecuteSetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), typeof(RenderGraphResourceRegistry), typeof(int), typeof(ResourceHandle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PassData), Member = "RandomWriteTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData)}, ReturnType = typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassRandomWriteData>))]
	[Calls(Type = typeof(CommandBuffer), Member = "NextSubPass", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(NativePassData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(CommandBuffer), Member = "WaitOnAsyncGraphicsFence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFence), typeof(SynchronisationStageFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "ExecuteInitializeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(PassData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRandomWriteTargets", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void ExecuteGraph(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, in List<RenderGraphPass>& passes) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	internal void ExecuteGraphNode(ref InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, RenderGraphPass pass) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ClearResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreatePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	private void ExecuteInitializeResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, in PassData pass) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal void ExecuteSetRandomWriteTarget(in CommandBuffer cmd, RenderGraphResourceRegistry resources, int index, ResourceHandle resource, bool preserveCounterValue = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativePassCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private void FindResourceUsageRanges() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateDebugData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativePassCompiler), Member = "InjectSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NativePassCompiler), Member = "MakePassMergeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(PassData&), typeof(PassData&), typeof(PassBreakAudit)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NativePassData), Member = "CanMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+DebugData+PassData>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PassData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "MakeAttachmentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(int)}, ReturnType = typeof(AttachmentInfo))]
	[Calls(Type = typeof(NativePassCompiler), Member = "MakePassBreakInfoMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativePassIterator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.Int32>, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.Int32>, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.Int32>, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Int32Enum, System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.ResourceHandle>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Int32Enum, System.Int32>, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.RenderGraphModule.RenderGraph+DebugData+PassData+NRPInfo+NativeRenderPassInfo+PassCompatibilityInfo>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PassCompatibilityInfo)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallsUnknownMethods(Count = 98)]
	[ContainsUnimplementedInstructions]
	internal void GenerateNativeCompilerDebugData(ref DebugData debugData) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileNativeRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassCompiler))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CompilerContextData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public bool Initialize(RenderGraphResourceRegistry resources, List<RenderGraphPass> renderPasses, bool disableCulling, string debugName, bool useCompilationCaching, int graphHash, int frameIndex) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "MakePassMergeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(PassData&), typeof(PassData&), typeof(PassBreakAudit)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string InjectSpaces(string camelCaseString) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "DetectMemoryLessResources", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsGlobalTextureInPass(RenderGraphPass pass, ResourceHandle handle) { }

	[CalledBy(Type = typeof(NativePassData), Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttachmentIndexArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	internal static bool IsSameNativeSubPass(ref SubPassDescriptor a, ref SubPassDescriptor b) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static AttachmentInfo MakeAttachmentInfo(CompilerContextData ctx, in NativePassData nativePass, int attachmentIndex) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal static string MakePassBreakInfoMessage(CompilerContextData ctx, in NativePassData nativePass) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativePassCompiler), Member = "InjectSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[ContainsInvalidInstructions]
	internal static string MakePassMergeMessage(CompilerContextData ctx, in PassData pass, in PassData prevPass, PassBreakAudit mergeResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativePassCompiler), Member = "DetermineLoadStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativePassData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PrepareNativeRenderPasses() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "TryMergeNativePasses", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	private void SetPassStatesForNativePass(int nativePassId) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Reserve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompilerContextData), Member = "AllocateNativeDataStructuresIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void SetupContextData(RenderGraphResourceRegistry resources) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativePassData), Member = "TryMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[Calls(Type = typeof(NativePassCompiler), Member = "SetPassStatesForNativePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(CompilerContextData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativePassData&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void TryMergeNativePasses() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateAttachmentRenderTarget(in RenderTargetInfo attRenderTargetInfo, RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private void ValidateNativePass(in NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount) { }

}

