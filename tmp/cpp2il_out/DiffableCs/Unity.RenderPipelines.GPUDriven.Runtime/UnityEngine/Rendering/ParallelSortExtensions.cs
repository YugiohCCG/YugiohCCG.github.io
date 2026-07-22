namespace UnityEngine.Rendering;

[Extension]
internal static class ParallelSortExtensions
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	public struct RadixSortBatchPrefixSumJob : IJobFor
	{
		[ReadOnly]
		public int radix; //Field offset: 0x0
		[ReadOnly]
		public int jobsCount; //Field offset: 0x4
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> array; //Field offset: 0x8
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> counter; //Field offset: 0x18
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> indicesSum; //Field offset: 0x28
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> buckets; //Field offset: 0x38
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> indices; //Field offset: 0x48

		[CalledBy(Type = typeof(RadixSortBatchPrefixSumJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		private static int AtomicIncrement(NativeArray<Int32> counter) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RadixSortBatchPrefixSumJob), Member = "JobIndexPrefixSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(RadixSortBatchPrefixSumJob), Member = "AtomicIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(int))]
		public override void Execute(int index) { }

		[CalledBy(Type = typeof(RadixSortBatchPrefixSumJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		private int JobIndexPrefixSum(int sum, int i) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	public struct RadixSortBucketCountJob : IJobFor
	{
		[ReadOnly]
		public int radix; //Field offset: 0x0
		[ReadOnly]
		public int jobsCount; //Field offset: 0x4
		[ReadOnly]
		public int batchSize; //Field offset: 0x8
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> array; //Field offset: 0x10
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> buckets; //Field offset: 0x20

		[CallerCount(Count = 0)]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	public struct RadixSortBucketSortJob : IJobFor
	{
		[ReadOnly]
		public int radix; //Field offset: 0x0
		[ReadOnly]
		public int batchSize; //Field offset: 0x4
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> array; //Field offset: 0x8
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> indices; //Field offset: 0x18
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> arraySorted; //Field offset: 0x28

		[CallerCount(Count = 0)]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	public struct RadixSortPrefixSumJob : IJobFor
	{
		[ReadOnly]
		public int jobsCount; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> indicesSum; //Field offset: 0x8
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		public NativeArray<Int32> indices; //Field offset: 0x18

		[CallerCount(Count = 0)]
		public override void Execute(int index) { }

	}

	private const int kMinRadixSortArraySize = 2048; //Field offset: 0x0
	private const int kMinRadixSortBatchSize = 256; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void <ParallelSort>g__Swap|2_0(ref NativeArray<Int32>& a, ref NativeArray<Int32>& b) { }

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUDrawInstanceData), Member = "DestroyDrawInstanceIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUDrawInstanceData), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUDrawInstanceData), Member = "DestroyMaterialDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SortJob`2), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Int32>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeSortExtension), Member = "SortJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = "Unity.Collections.SortJob`2<T, DefaultComparer`1<T>>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortBucketCountJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortBucketCountJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortBatchPrefixSumJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortBatchPrefixSumJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortPrefixSumJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortPrefixSumJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobForExtensions), Member = "ScheduleParallel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortBucketSortJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RadixSortBucketSortJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	internal static JobHandle ParallelSort(NativeArray<Int32> array) { }

}

