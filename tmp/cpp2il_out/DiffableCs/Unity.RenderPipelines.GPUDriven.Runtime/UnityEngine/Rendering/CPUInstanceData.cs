namespace UnityEngine.Rendering;

internal struct CPUInstanceData : IDisposable
{
	[IsReadOnly]
	public struct ReadOnly
	{
		public readonly ReadOnly<Int32> instanceIndices; //Field offset: 0x0
		public readonly ReadOnly<InstanceHandle> instances; //Field offset: 0x10
		public readonly ReadOnly<SharedInstanceHandle> sharedInstances; //Field offset: 0x20
		public readonly ParallelBitArray localToWorldIsFlippedBits; //Field offset: 0x30
		public readonly ReadOnly<AABB> worldAABBs; //Field offset: 0x50
		public readonly ReadOnly<Int32> tetrahedronCacheIndices; //Field offset: 0x60
		public readonly ParallelBitArray movedInCurrentFrameBits; //Field offset: 0x70
		public readonly ParallelBitArray movedInPreviousFrameBits; //Field offset: 0x90
		public readonly ParallelBitArray visibleInPreviousFrameBits; //Field offset: 0xB0
		public readonly ReadOnly editorData; //Field offset: 0xD0

		public int handlesLength
		{
			[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
			[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
			[CallerCount(Count = 3)]
			 get { } //Length: 55
		}

		public int instancesLength
		{
			[CalledBy(Type = typeof(InstanceCuller), Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(BinningConfig&), typeof(float), typeof(OcclusionCullingCommon), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(JobHandle))]
			[CallerCount(Count = 1)]
			 get { } //Length: 55
		}

		[CalledBy(Type = typeof(CPUInstanceData), Member = "AsReadOnly", ReturnType = typeof(ReadOnly))]
		[CalledBy(Type = typeof(InstanceDataSystem), Member = "get_instanceData", ReturnType = typeof(ReadOnly))]
		[CalledBy(Type = typeof(InstanceDataSystem), Member = "ScheduleCollectInstancesLODGroupAndMasksJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
		[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(ParallelBitArray), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ParallelBitArray))]
		public ReadOnly(in CPUInstanceData instanceData) { }

		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCompactedVisibilityMaskJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 3)]
		public int get_handlesLength() { }

		[CalledBy(Type = typeof(InstanceCuller), Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(BinningConfig&), typeof(float), typeof(OcclusionCullingCommon), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		public int get_instancesLength() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public InstanceHandle IndexToInstance(int index) { }

		[CalledBy(Type = typeof(AllocateBinsPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public int InstanceToIndex(InstanceHandle instance) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool IsValidIndex(int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool IsValidInstance(InstanceHandle instance) { }

	}

	private const int k_InvalidIndex = -1; //Field offset: 0x0
	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	private NativeList<Int32> m_InstanceIndices; //Field offset: 0x10
	public NativeArray<InstanceHandle> instances; //Field offset: 0x18
	public NativeArray<SharedInstanceHandle> sharedInstances; //Field offset: 0x28
	public ParallelBitArray localToWorldIsFlippedBits; //Field offset: 0x38
	public NativeArray<AABB> worldAABBs; //Field offset: 0x58
	public NativeArray<Int32> tetrahedronCacheIndices; //Field offset: 0x68
	public ParallelBitArray movedInCurrentFrameBits; //Field offset: 0x78
	public ParallelBitArray movedInPreviousFrameBits; //Field offset: 0x98
	public ParallelBitArray visibleInPreviousFrameBits; //Field offset: 0xB8
	public EditorInstanceDataArrays editorData; //Field offset: 0xD8

	public int handlesLength
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 75
	}

	public int instancesCapacity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public int instancesLength
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "AddUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "SetDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	public void Add(InstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CPUInstanceData), Member = "AddUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "SetDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	public void AddNoGrow(InstanceHandle instance) { }

	[CalledBy(Type = typeof(CPUInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void AddUnsafe(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly AsReadOnly() { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void EnsureFreeInstances(int instancesCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_handlesLength() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_instancesCapacity() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_instancesLength() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool Get_LocalToWorldIsFlipped(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool Get_MovedInCurrentFrame(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool Get_MovedInPreviousFrame(InstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+GetVisibleNonProcessedTreeInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeRendererGroupInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	public SharedInstanceHandle Get_SharedInstance(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	public int Get_TetrahedronCacheIndex(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool Get_VisibleInPreviousFrame(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	public AABB Get_WorldAABB(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public AABB Get_WorldBounds(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetFreeInstancesCount() { }

	[CalledBy(Type = typeof(CPUInstanceData), Member = "EnsureFreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", "T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private void Grow(int newCapacity) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public InstanceHandle IndexToInstance(int index) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", "T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParallelBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	public void Initialize(int initCapacity) { }

	[CallerCount(Count = 34)]
	[CallsUnknownMethods(Count = 1)]
	public int InstanceToIndex(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsFreeInstanceHandle(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsValidIndex(int index) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "InternalSanityCheckStates", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<InstanceHandle>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsValidInstance(InstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeRendererGroupInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<InstanceHandle>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Remove(InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void Set(InstanceHandle instance, SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, in AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_instancesCapacity(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_instancesLength(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void Set_LocalToWorldIsFlipped(InstanceHandle instance, bool isFlipped) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void Set_MovedInCurrentFrame(InstanceHandle instance, bool movedInCurrentFrame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void Set_MovedInPreviousFrame(InstanceHandle instance, bool movedInPreviousFrame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	public void Set_SharedInstance(InstanceHandle instance, SharedInstanceHandle sharedInstance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	public void Set_TetrahedronCacheIndex(InstanceHandle instance, int tetrahedronCacheIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void Set_VisibleInPreviousFrame(InstanceHandle instance, bool visibleInPreviousFrame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	public void Set_WorldAABB(InstanceHandle instance, in AABB worldBounds) { }

	[CalledBy(Type = typeof(CPUInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUInstanceData), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public void SetDefault(InstanceHandle instance) { }

}

