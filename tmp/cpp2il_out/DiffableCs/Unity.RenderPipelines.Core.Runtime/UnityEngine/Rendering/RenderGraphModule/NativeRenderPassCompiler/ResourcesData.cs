namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DefaultMember("Item")]
internal class ResourcesData
{
	public NativeList<ResourceUnversionedData>[] unversionedData; //Field offset: 0x10
	public NativeList<ResourceVersionedData>[] versionedData; //Field offset: 0x18
	public NativeList<ResourceReaderData>[] readerData; //Field offset: 0x20
	public Int32[] MaxVersions; //Field offset: 0x28
	public Int32[] MaxReaders; //Field offset: 0x30
	public DynamicArray<Name>[] resourceNames; //Field offset: 0x38

	public ResourceVersionedData Item
	{
		[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CompilerContextData), Member = "VersionedResourceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
		[CalledBy(Type = typeof(CompilerContextData), Member = "Readers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData>))]
		[CalledBy(Type = typeof(CompilerContextData), Member = "ResourceReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle), typeof(int)}, ReturnType = typeof(ResourceReaderData&))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "CullUnusedRenderPasses", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "FindResourceUsageRanges", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 326
	}

	[CalledBy(Type = typeof(CompilerContextData), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphCompilationCache)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public ResourcesData() { }

	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void AllocateAndResizeNativeListIfNeeded(ref NativeList<T>& nativeList, int size, NativeArrayOptions options) { }

	[CalledBy(Type = typeof(CompilerContextData), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(bool), typeof(string), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Clear() { }

	[CalledBy(Type = typeof(CompilerContextData), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "VersionedResourceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "Readers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData>))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "ResourceReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle), typeof(int)}, ReturnType = typeof(ResourceReaderData&))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "CullUnusedRenderPasses", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "FindResourceUsageRanges", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 2)]
	public ResourceVersionedData get_Item(ResourceHandle h) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int Index(ResourceHandle h) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int IndexReader(ResourceHandle h, int readerID) { }

	[CalledBy(Type = typeof(CompilerContextData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "SetupContextData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetResourceLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(IRenderGraphResource))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ResourcesData), Member = "AllocateAndResizeNativeListIfNeeded", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>&", typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = "AllocateAndResizeNativeListIfNeeded", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceVersionedData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeList`1<ResourceVersionedData>&), typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceShared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ResourceHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraphResourceType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Name), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = "AllocateAndResizeNativeListIfNeeded", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceUnversionedData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeList`1<ResourceUnversionedData>&), typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetResourceCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public void Initialize(RenderGraphResourceRegistry resources) { }

}

