namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct CompactVisibilityMasksJob : IJobParallelForBatch
{
	public const int k_BatchSize = 64; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x0
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x10

	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParallelBitArray), Member = "InterlockedOrChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ulong)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public override void Execute(int startIndex, int count) { }

}

