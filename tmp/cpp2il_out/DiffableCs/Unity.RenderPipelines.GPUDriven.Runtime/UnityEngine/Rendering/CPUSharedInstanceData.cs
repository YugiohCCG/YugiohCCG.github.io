namespace UnityEngine.Rendering;

internal struct CPUSharedInstanceData : IDisposable
{
	[IsReadOnly]
	public struct ReadOnly
	{
		public readonly ReadOnly<Int32> instanceIndices; //Field offset: 0x0
		public readonly ReadOnly<SharedInstanceHandle> instances; //Field offset: 0x10
		public readonly ReadOnly<Int32> rendererGroupIDs; //Field offset: 0x20
		public readonly ReadOnly<SmallIntegerArray> materialIDArrays; //Field offset: 0x30
		public readonly ReadOnly<Int32> meshIDs; //Field offset: 0x40
		public readonly ReadOnly<AABB> localAABBs; //Field offset: 0x50
		public readonly ReadOnly<CPUSharedInstanceFlags> flags; //Field offset: 0x60
		public readonly ReadOnly<UInt32> lodGroupAndMasks; //Field offset: 0x70
		public readonly ReadOnly<Int32> gameObjectLayers; //Field offset: 0x80
		public readonly ReadOnly<Int32> refCounts; //Field offset: 0x90

		public int handlesLength
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 55
		}

		public int instancesLength
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 55
		}

		[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "AsReadOnly", ReturnType = typeof(ReadOnly))]
		[CalledBy(Type = typeof(InstanceDataSystem), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
		[CalledBy(Type = typeof(InstanceDataSystem), Member = "ScheduleCollectInstancesLODGroupAndMasksJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
		[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		public ReadOnly(in CPUSharedInstanceData instanceData) { }

		[CallerCount(Count = 0)]
		public int get_handlesLength() { }

		[CallerCount(Count = 0)]
		public int get_instancesLength() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public SharedInstanceHandle IndexToSharedInstance(int index) { }

		[CalledBy(Type = typeof(CullingJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+CollectInstancesLODGroupsAndMasksJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ReadOnly), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public int InstanceToIndex(in ReadOnly instanceData, InstanceHandle instance) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool IsValidIndex(int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool IsValidSharedInstance(SharedInstanceHandle instance) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public int SharedInstanceToIndex(SharedInstanceHandle instance) { }

	}

	private const int k_InvalidIndex = -1; //Field offset: 0x0
	private const uint k_InvalidLODGroupAndMask = 4294967295; //Field offset: 0x0
	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	private NativeList<Int32> m_InstanceIndices; //Field offset: 0x10
	public NativeArray<SharedInstanceHandle> instances; //Field offset: 0x18
	public NativeArray<Int32> rendererGroupIDs; //Field offset: 0x28
	public NativeArray<SmallIntegerArray> materialIDArrays; //Field offset: 0x38
	public NativeArray<Int32> meshIDs; //Field offset: 0x48
	public NativeArray<AABB> localAABBs; //Field offset: 0x58
	public NativeArray<CPUSharedInstanceFlags> flags; //Field offset: 0x68
	public NativeArray<UInt32> lodGroupAndMasks; //Field offset: 0x78
	public NativeArray<Int32> gameObjectLayers; //Field offset: 0x88
	public NativeArray<Int32> refCounts; //Field offset: 0x98

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
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	public void Add(SharedInstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "AddUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int), typeof(SmallIntegerArray&), typeof(int), typeof(AABB&), typeof(TransformUpdateFlags), typeof(InstanceFlags), typeof(uint), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void AddNoGrow(SharedInstanceHandle instance) { }

	[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void AddUnsafe(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUSharedInstanceData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly AsReadOnly() { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SmallIntegerArray>), Member = "GetEnumerator", ReturnType = typeof(Unity.Collections.NativeArray`1+Enumerator<UnityEngine.Rendering.SmallIntegerArray>))]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void EnsureFreeInstances(int instancesCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public CPUSharedInstanceFlags Get_Flags(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public int Get_GameObjectLayer(SharedInstanceHandle instance) { }

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
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public AABB Get_LocalAABB(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public uint Get_LODGroupAndMask(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public SmallIntegerArray Get_MaterialIDs(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public int Get_MeshID(SharedInstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public int Get_RefCount(SharedInstanceHandle instance) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+GetVisibleNonProcessedTreeInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public int Get_RendererGroupID(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetFreeInstancesCount() { }

	[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "EnsureFreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", "T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SmallIntegerArray)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<SmallIntegerArray>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SmallIntegerArray)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<SmallIntegerArray>&), typeof(SmallIntegerArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUSharedInstanceFlags)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<CPUSharedInstanceFlags>&), typeof(int)}, ReturnType = typeof(void))]
	private void Grow(int newCapacity) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public SharedInstanceHandle IndexToSharedInstance(int index) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", "T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SmallIntegerArray>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.CPUSharedInstanceFlags>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	public void Initialize(int initCapacity) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+ProbesUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int InstanceToIndex(in CPUInstanceData instanceData, InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsFreeInstanceHandle(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsValidIndex(int index) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "InternalSanityCheckStates", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsValidInstance(SharedInstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeRendererGroupInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<InstanceHandle>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Remove(SharedInstanceHandle instance) { }

	[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CPUSharedInstanceData), Member = "SetDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	public void Set(SharedInstanceHandle instance, int rendererGroupID, in SmallIntegerArray materialIDs, int meshID, in AABB localAABB, TransformUpdateFlags transformUpdateFlags, InstanceFlags instanceFlags, uint lodGroupAndMask, int gameObjectLayer, int refCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_Flags(SharedInstanceHandle instance, CPUSharedInstanceFlags instanceFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_GameObjectLayer(SharedInstanceHandle instance, int gameObjectLayer) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_instancesCapacity(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_instancesLength(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_LocalAABB(SharedInstanceHandle instance, in AABB localAABB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_LODGroupAndMask(SharedInstanceHandle instance, uint lodGroupAndMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	public void Set_MaterialIDs(SharedInstanceHandle instance, in SmallIntegerArray materialIDs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_MeshID(SharedInstanceHandle instance, int meshID) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_RefCount(SharedInstanceHandle instance, int refCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	public void Set_RendererGroupID(SharedInstanceHandle instance, int rendererGroupID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int), typeof(SmallIntegerArray&), typeof(int), typeof(AABB&), typeof(TransformUpdateFlags), typeof(InstanceFlags), typeof(uint), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void SetDefault(SharedInstanceHandle instance) { }

	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 1)]
	public int SharedInstanceToIndex(SharedInstanceHandle instance) { }

}

