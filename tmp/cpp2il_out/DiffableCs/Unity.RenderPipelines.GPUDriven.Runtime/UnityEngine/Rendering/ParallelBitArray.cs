namespace UnityEngine.Rendering;

internal struct ParallelBitArray
{
	private Allocator m_Allocator; //Field offset: 0x0
	private NativeArray<Int64> m_Bits; //Field offset: 0x8
	private int m_Length; //Field offset: 0x18

	public bool IsCreated
	{
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnBeginContextRendering", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "OnBeginContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(InstanceCuller), Member = "DisposeCompactVisibilityMasks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 51
	}

	public int Length
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	public ParallelBitArray(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int ChunkCount() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnBeginContextRendering", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "OnBeginContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "DisposeCompactVisibilityMasks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Int64>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public void Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int64>&), typeof(Int64&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void FillZeroes(int length) { }

	[CalledBy(Type = typeof(CullingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllocateBinsPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Get_LocalToWorldIsFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Get_MovedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Get_MovedInPreviousFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Get_VisibleInPreviousFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+GetVisibleNonProcessedTreeInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Get(int index) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "OnBeginContextRendering", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentDrawer), Member = "OnBeginContextRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "DisposeCompactVisibilityMasks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "OnEndContextRendering", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCreated() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeArray<Int64> GetBitsArray() { }

	[CallerCount(Count = 0)]
	public ulong GetChunk(int chunk_index) { }

	[CalledBy(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	public ParallelBitArray GetSubArray(int length) { }

	[CalledBy(Type = typeof(CompactVisibilityMasksJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void InterlockedOrChunk(int chunk_index, ulong chunk_bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ulong InterlockedReadChunk(int chunk_index) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "ProcessTrees", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "Unity.Collections.NativeArray`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public void Resize(int newLength) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle), typeof(SharedInstanceHandle), typeof(bool), typeof(AABB&), typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "SetDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Set_LocalToWorldIsFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Set_MovedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Set_MovedInPreviousFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Set_VisibleInPreviousFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Set(int index, bool value) { }

	[CallerCount(Count = 0)]
	public void SetChunk(int chunk_index, ulong chunk_bits) { }

}

