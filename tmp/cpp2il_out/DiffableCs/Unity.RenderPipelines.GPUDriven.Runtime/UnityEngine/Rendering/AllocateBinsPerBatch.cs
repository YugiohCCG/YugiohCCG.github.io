namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct AllocateBinsPerBatch : IJobParallelFor
{
	[ReadOnly]
	public BinningConfig binningConfig; //Field offset: 0x0
	[ReadOnly]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x8
	[ReadOnly]
	public NativeArray<Int32> drawInstanceIndices; //Field offset: 0x10
	[ReadOnly]
	public ReadOnly instanceData; //Field offset: 0x20
	[ReadOnly]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0xF8
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> batchBinAllocOffsets; //Field offset: 0x108
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> batchBinCounts; //Field offset: 0x118
	[DeallocateOnJobCompletion]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<Int32> binAllocCounter; //Field offset: 0x128
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int16> binConfigIndices; //Field offset: 0x138
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> binVisibleInstanceCounts; //Field offset: 0x148
	[ReadOnly]
	public int debugCounterIndexBase; //Field offset: 0x158
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<Int32> splitDebugCounters; //Field offset: 0x160

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocateBinsPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AllocateBinsPerBatch), Member = "GetPrimitiveCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MeshTopology), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public override void Execute(int batchIndex) { }

	[CalledBy(Type = typeof(AllocateBinsPerBatch), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int GetPrimitiveCount(int indexCount, MeshTopology topology, bool nativeQuads) { }

	[CalledBy(Type = typeof(AllocateBinsPerBatch), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceHandle), Member = "FromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InstanceHandle))]
	[Calls(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	private bool IsInstanceFlipped(int rendererIndex) { }

}

