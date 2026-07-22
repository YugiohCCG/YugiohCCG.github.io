namespace UnityEngine.Rendering;

internal class CPUDrawInstanceData
{
	private NativeParallelHashMap<RangeKey, Int32> m_RangeHash; //Field offset: 0x10
	private NativeList<DrawRange> m_DrawRanges; //Field offset: 0x20
	private NativeParallelHashMap<DrawKey, Int32> m_BatchHash; //Field offset: 0x28
	private NativeList<DrawBatch> m_DrawBatches; //Field offset: 0x38
	private NativeList<DrawInstance> m_DrawInstances; //Field offset: 0x40
	private NativeList<Int32> m_DrawInstanceIndices; //Field offset: 0x48
	private NativeList<Int32> m_DrawBatchIndices; //Field offset: 0x50
	private bool m_NeedsRebuild; //Field offset: 0x58

	public NativeParallelHashMap<DrawKey, Int32> batchHash
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public NativeList<DrawBatch> drawBatches
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NativeArray<Int32> drawBatchIndices
	{
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
		 get { } //Length: 87
	}

	public NativeArray<Int32> drawInstanceIndices
	{
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
		 get { } //Length: 87
	}

	public NativeList<DrawInstance> drawInstances
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NativeList<DrawRange> drawRanges
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NativeParallelHashMap<RangeKey, Int32> rangeHash
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public bool valid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 51
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CPUDrawInstanceData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParallelSortExtensions), Member = "ParallelSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(RemoveDrawInstanceIndices_00000184$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	public void DestroyDrawInstanceIndices(NativeArray<Int32> drawInstanceIndicesToDestroy) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(ParallelSortExtensions), Member = "ParallelSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindDrawInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindDrawInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(RemoveDrawInstanceIndices_00000184$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DestroyDrawInstances(NativeArray<InstanceHandle> destroyedInstances) { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(ParallelSortExtensions), Member = "ParallelSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindMaterialDrawInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindMaterialDrawInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(RemoveDrawInstanceIndices_00000184$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DestroyMaterialDrawInstances(NativeArray<UInt32> destroyedBatchMaterials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawRange>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeParallelHashMap<DrawKey, Int32> get_batchHash() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public NativeList<DrawBatch> get_drawBatches() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	public NativeArray<Int32> get_drawBatchIndices() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	public NativeArray<Int32> get_drawInstanceIndices() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public NativeList<DrawInstance> get_drawInstances() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public NativeList<DrawRange> get_drawRanges() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public NativeParallelHashMap<RangeKey, Int32> get_rangeHash() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_valid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public void Initialize() { }

	[CallerCount(Count = 0)]
	public void NeedsRebuild() { }

	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnPerformCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroup), typeof(BatchCullingContext), typeof(BatchCullingOutput), typeof(IntPtr)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefixSumDrawInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefixSumDrawInstancesJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildDrawListsJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildDrawListsJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void RebuildDrawListsIfNeeded() { }

}

