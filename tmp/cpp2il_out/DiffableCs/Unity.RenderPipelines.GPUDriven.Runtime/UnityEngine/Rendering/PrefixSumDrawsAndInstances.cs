namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct PrefixSumDrawsAndInstances : IJob
{
	[ReadOnly]
	public NativeList<DrawRange> drawRanges; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<Int32> drawBatchIndices; //Field offset: 0x8
	[ReadOnly]
	public NativeArray<Int32> batchBinAllocOffsets; //Field offset: 0x18
	[ReadOnly]
	public NativeArray<Int32> batchBinCounts; //Field offset: 0x28
	[ReadOnly]
	public NativeArray<Int32> binVisibleInstanceCounts; //Field offset: 0x38
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> batchDrawCommandOffsets; //Field offset: 0x48
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> binVisibleInstanceOffsets; //Field offset: 0x58
	[NativeDisableUnsafePtrRestriction]
	public NativeArray<BatchCullingOutputDrawCommands> cullingOutput; //Field offset: 0x68
	[ReadOnly]
	public IndirectBufferLimits indirectBufferLimits; //Field offset: 0x78
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo; //Field offset: 0x80
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<Int32> indirectAllocationCounters; //Field offset: 0x90

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchFilterSettings), Member = "set_receiveShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BatchFilterSettings), Member = "set_staticShadowCaster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BatchFilterSettings), Member = "set_allDepthSorted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IndirectBufferAllocInfo), Member = "IsWithinLimits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndirectBufferLimits&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryUtilities), Member = "Malloc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = "T*")]
	[Calls(Type = typeof(MemoryUtilities), Member = "Malloc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchDrawCommandIndirect)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(BatchDrawCommandIndirect*))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override void Execute() { }

}

