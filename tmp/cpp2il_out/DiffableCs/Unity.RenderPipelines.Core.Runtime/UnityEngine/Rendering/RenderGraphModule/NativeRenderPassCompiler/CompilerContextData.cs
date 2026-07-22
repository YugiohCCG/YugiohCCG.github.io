namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal class CompilerContextData : IDisposable, ICompiledGraph
{
	internal struct NativePassIterator
	{
		private readonly CompilerContextData m_Ctx; //Field offset: 0x0
		private int m_Index; //Field offset: 0x8

		[IsReadOnly]
		public NativePassData Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 74
		}

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public NativePassIterator(CompilerContextData ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
		[CallsUnknownMethods(Count = 1)]
		public NativePassData get_Current() { }

		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		public NativePassIterator GetEnumerator() { }

		[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "DetectMemoryLessResources", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool MoveNext() { }

	}

	public ResourcesData resources; //Field offset: 0x10
	public NativeList<PassData> passData; //Field offset: 0x18
	public Dictionary<Int32, GraphicsFence> fences; //Field offset: 0x20
	public DynamicArray<Name> passNames; //Field offset: 0x28
	public NativeList<PassInputData> inputData; //Field offset: 0x30
	public NativeList<PassOutputData> outputData; //Field offset: 0x38
	public NativeList<PassFragmentData> fragmentData; //Field offset: 0x40
	public NativeList<ResourceHandle> createData; //Field offset: 0x48
	public NativeList<ResourceHandle> destroyData; //Field offset: 0x50
	public NativeList<PassRandomWriteData> randomAccessResourceData; //Field offset: 0x58
	public NativeList<NativePassData> nativePassData; //Field offset: 0x60
	public NativeList<SubPassDescriptor> nativeSubPassData; //Field offset: 0x68
	private bool m_AreNativeListsAllocated; //Field offset: 0x70

	public NativePassIterator NativePasses
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 41
	}

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public CompilerContextData() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PassFragmentData&))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassFragmentData&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public bool AddToFragmentList(TextureAccess access, int listFirstIndex, int numItems) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public bool AddToRandomAccessResourceList(ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems) { }

	[CalledBy(Type = typeof(CompilerContextData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "SetupContextData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	private void AllocateNativeDataStructuresIfNeeded(int estimatedNumPasses) { }

	[CalledBy(Type = typeof(CompilerContextData), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ResourcesData), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassInputData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassOutputData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.ResourceHandle>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassRandomWriteData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.SubPassDescriptor>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Cleanup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourcesData), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public void CullAllPasses(bool isCulled) { }

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CompilerContextData), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompilerContextData), Member = "Cleanup", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public NativePassIterator get_NativePasses() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public Name GetFullPassName(int passId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativePassData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal List<NativePassData> GetNativePasses() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public string GetPassName(int passId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 2)]
	public string GetResourceName(ResourceHandle h) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string GetResourceVersionedName(ResourceHandle h) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Reserve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompilerContextData), Member = "AllocateNativeDataStructuresIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Initialize(RenderGraphResourceRegistry resourceRegistry, int estimatedNumPasses) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ReadOnlySpan<ResourceReaderData> Readers(ResourceHandle h) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 3)]
	public ResourceReaderData ResourceReader(ResourceHandle h, int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public void TagAllPasses(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
	[CallsUnknownMethods(Count = 2)]
	public ResourceUnversionedData UnversionedResourceData(ResourceHandle h) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[CallsUnknownMethods(Count = 1)]
	public ResourceVersionedData VersionedResourceData(ResourceHandle h) { }

}

