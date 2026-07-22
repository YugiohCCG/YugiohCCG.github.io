namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct DrawCommandOutputPerBatch : IJobParallelFor
{
	[ReadOnly]
	public BinningConfig binningConfig; //Field offset: 0x0
	[ReadOnly]
	public NativeParallelHashMap<UInt32, BatchID> batchIDs; //Field offset: 0x8
	[ReadOnly]
	public ReadOnly instanceDataBuffer; //Field offset: 0x18
	[ReadOnly]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x28
	[ReadOnly]
	public NativeArray<Int32> drawInstanceIndices; //Field offset: 0x30
	[ReadOnly]
	public ReadOnly instanceData; //Field offset: 0x40
	[ReadOnly]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x118
	[ReadOnly]
	public NativeArray<Byte> rendererCrossFadeValues; //Field offset: 0x128
	[DeallocateOnJobCompletion]
	[ReadOnly]
	public NativeArray<Int32> batchBinAllocOffsets; //Field offset: 0x138
	[DeallocateOnJobCompletion]
	[ReadOnly]
	public NativeArray<Int32> batchBinCounts; //Field offset: 0x148
	[DeallocateOnJobCompletion]
	[ReadOnly]
	public NativeArray<Int32> batchDrawCommandOffsets; //Field offset: 0x158
	[DeallocateOnJobCompletion]
	[ReadOnly]
	public NativeArray<Int16> binConfigIndices; //Field offset: 0x168
	[DeallocateOnJobCompletion]
	[ReadOnly]
	public NativeArray<Int32> binVisibleInstanceOffsets; //Field offset: 0x178
	[DeallocateOnJobCompletion]
	[ReadOnly]
	public NativeArray<Int32> binVisibleInstanceCounts; //Field offset: 0x188
	[ReadOnly]
	public NativeArray<BatchCullingOutputDrawCommands> cullingOutput; //Field offset: 0x198
	[ReadOnly]
	public IndirectBufferLimits indirectBufferLimits; //Field offset: 0x1A8
	[ReadOnly]
	public GraphicsBufferHandle visibleInstancesBufferHandle; //Field offset: 0x1B0
	[ReadOnly]
	public GraphicsBufferHandle indirectArgsBufferHandle; //Field offset: 0x1B4
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo; //Field offset: 0x1B8
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<IndirectDrawInfo> indirectDrawInfoGlobalArray; //Field offset: 0x1C8
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public NativeArray<IndirectInstanceInfo> indirectInstanceInfoGlobalArray; //Field offset: 0x1D8

	[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InstanceHandle), Member = "FromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InstanceHandle))]
	[Calls(Type = typeof(ReadOnly), Member = "CPUInstanceToGPUInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(GPUInstanceIndex))]
	private int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(DrawCommandOutputPerBatch), Member = "EncodeGPUInstanceIndexAndCrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DrawCommandOutputPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceHandle), Member = "FromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InstanceHandle))]
	[Calls(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnly), Member = "UnsafeElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public override void Execute(int batchIndex) { }

	[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceHandle), Member = "FromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InstanceHandle))]
	[Calls(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	private bool IsInstanceFlipped(int rendererIndex) { }

}

