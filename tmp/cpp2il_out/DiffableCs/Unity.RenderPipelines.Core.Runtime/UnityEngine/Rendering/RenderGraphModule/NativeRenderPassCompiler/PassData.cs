namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal struct PassData
{
	public int passId; //Field offset: 0x0
	public RenderGraphPassType type; //Field offset: 0x4
	public bool hasFoveatedRasterization; //Field offset: 0x8
	public int tag; //Field offset: 0xC
	public PassMergeState mergeState; //Field offset: 0x10
	public int nativePassIndex; //Field offset: 0x14
	public int nativeSubPassIndex; //Field offset: 0x18
	public int firstInput; //Field offset: 0x1C
	public int numInputs; //Field offset: 0x20
	public int firstOutput; //Field offset: 0x24
	public int numOutputs; //Field offset: 0x28
	public int firstFragment; //Field offset: 0x2C
	public int numFragments; //Field offset: 0x30
	public int firstFragmentInput; //Field offset: 0x34
	public int numFragmentInputs; //Field offset: 0x38
	public int firstRandomAccessResource; //Field offset: 0x3C
	public int numRandomAccessResources; //Field offset: 0x40
	public int firstCreate; //Field offset: 0x44
	public int numCreated; //Field offset: 0x48
	public int firstDestroy; //Field offset: 0x4C
	public int numDestroyed; //Field offset: 0x50
	public int fragmentInfoWidth; //Field offset: 0x54
	public int fragmentInfoHeight; //Field offset: 0x58
	public int fragmentInfoVolumeDepth; //Field offset: 0x5C
	public int fragmentInfoSamples; //Field offset: 0x60
	public int waitOnGraphicsFencePassId; //Field offset: 0x64
	public bool asyncCompute; //Field offset: 0x68
	public bool hasSideEffects; //Field offset: 0x69
	public bool culled; //Field offset: 0x6A
	public bool beginNativeSubpass; //Field offset: 0x6B
	public bool fragmentInfoValid; //Field offset: 0x6C
	public bool fragmentInfoHasDepth; //Field offset: 0x6D
	public bool insertGraphicsFence; //Field offset: 0x6E

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public PassData(in RenderGraphPass pass, int passIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddFirstUse(ResourceHandle h, CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddFragment(ResourceHandle h, CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddFragmentInput(ResourceHandle h, CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddLastUse(ResourceHandle h, CompilerContextData ctx) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void AddRandomAccessResource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IsReadOnly]
	public ReadOnlySpan<ResourceHandle> FirstUsedResources(CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IsReadOnly]
	public ReadOnlySpan<PassFragmentData> FragmentInputs(CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IsReadOnly]
	public ReadOnlySpan<PassFragmentData> Fragments(CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public Name GetName(CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IsReadOnly]
	public ReadOnlySpan<PassInputData> Inputs(CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[IsReadOnly]
	internal bool IsUsedAsFragment(ResourceHandle h, CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IsReadOnly]
	public ReadOnlySpan<ResourceHandle> LastUsedResources(CompilerContextData ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[IsReadOnly]
	public ReadOnlySpan<PassOutputData> Outputs(CompilerContextData ctx) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ReadOnlySpan<PassRandomWriteData> RandomWriteTextures(CompilerContextData ctx) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void ResetAndInitialize(in RenderGraphPass pass, int passIndex) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "BuildGraph", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SetupAndValidateFragmentInfo(ResourceHandle h, CompilerContextData ctx) { }

}

