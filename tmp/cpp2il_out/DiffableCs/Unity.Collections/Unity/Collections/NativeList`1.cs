namespace Unity.Collections;

[DebuggerDisplay("Length = {m_ListData == null ? default : m_ListData->Length}, Capacity = {m_ListData == null ? default : m_ListData->Capacity}")]
[DebuggerTypeProxy(typeof(NativeListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
public struct NativeList : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public UnsafeList<T>* ListData; //Field offset: 0x0

		public Void* Ptr
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 171
		}

		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal ParallelWriter(UnsafeList<T>* listData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void AddNoResize(T value) { }

		[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer+FindRenderersFromMaterialOrMeshJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.FindDrawInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.FindMaterialDrawInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.FindNonRegisteredMeshesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.FindNonRegisteredMaterialsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void AddRangeNoResize(Void* ptr, int count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void AddRangeNoResize(UnsafeList<T> list) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public void AddRangeNoResize(NativeList<T> list) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Void* get_Ptr() { }

	}

	public const int MaxCapacity = 2147483647; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeList<T>* m_ListData; //Field offset: 0x0

	public override int Capacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 36
		[CalledBy(Type = typeof(JobFilterProducer`1), Member = "ExecuteAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"JobWrapper<T>&", typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "ScheduleQuerySortedMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeList`1<InstanceHandle>"}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 67
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 60
	}

	public override T Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 140
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 137
	}

	public override int Length
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 36
		[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<Plane>", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 73
	}

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullerSplitDebugArray", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPool", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUSharedInstanceData", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUInstanceData", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceAllocator", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContext", "UnityEngine.Rendering.InstanceCullingBatcherDesc", typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", "UnityEngine.Rendering.GPUDrivenProcessor", "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugRendererBatcherStats", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "ProcessMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "ProcessTrees", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FrustumPlaneCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "Unity.Collections.NativeArray`1<Plane>", "UnityEngine.Rendering.ReceiverSphereCuller&", typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.FrustumPlaneCuller")]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverPlanes", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverPlanes")]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverPlanes", Member = "CreateEmptyForTesting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverPlanes")]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "FindUnsupportedRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = "Unity.Collections.NativeList`1<Int32>")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "Initialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "U&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NativeList`1(AllocatorHandle allocator) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "Initialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "U&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeList`1(int initialCapacity, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Add(in T value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void AddNoResize(T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddRange(Void* ptr, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.FrustumPlaneCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "Unity.Collections.NativeArray`1<Plane>", "UnityEngine.Rendering.ReceiverSphereCuller&", typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.FrustumPlaneCuller")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void AddRange(NativeArray<T> array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddRangeNoResize(Void* ptr, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddRangeNoResize(NativeList<T> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "AddReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddReplicate(in T value, int count) { }

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public NativeArray<T> AsArray() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeList`1<InstanceHandle>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeArray<T> AsDeferredJobArray() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ReadOnly<T> AsParallelReader() { }

	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ParallelWriter<T> AsParallelWriter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ReadOnly<T> AsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckArgPositive(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void CheckHandleMatches(AllocatorHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckIndexInRange(int value, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckInitialCapacity(int initialCapacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckSufficientCapacity(int capacity, int length) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>", typeof(bool), typeof(string), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourcesData", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FrustumPlaneCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "Unity.Collections.NativeArray`1<Plane>", "UnityEngine.Rendering.ReceiverSphereCuller&", typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.FrustumPlaneCuller")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullerSplitDebugArray", Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceOcclusionEventDebugArray", Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader", Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer", "Unity.Collections.NativeArray`1<GPUInstanceIndex>", "GPUResources&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "ResetAllocators", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "GrowBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "UpdateOccluderStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CallerCount(Count = 38)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void CopyFrom(in NativeList<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void CopyFrom(in UnsafeList<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void CopyFrom(in NativeArray<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeListDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeListDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal void Dispose(ref U allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeList`1), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>*"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override T ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Capacity() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override T get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Enumerator<T> GetEnumerator() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public UnsafeList<T>* GetUnsafeList() { }

	[CalledBy(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorManager), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U", typeof(int)}, ReturnType = "U*")]
	[Calls(Type = typeof(UnsafeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal void Initialize(int initialCapacity, ref U allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void InsertRange(int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "InsertRangeWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal static NativeList<T> New(int initialCapacity, ref U allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Obsolete("Implicit cast from `NativeList<T>` to `NativeArray<T>` has been deprecated; Use '.AsArray()' method to do explicit cast instead.", False)]
	public static NativeArray<T> op_Implicit(NativeList<T> nativeList) { }

	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "NewContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveAt(int index) { }

	[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "RemoveDrawRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RangeKey&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RangeKey&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeList`1<DrawRange>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceAllocator", Member = "AllocateInstance", ReturnType = typeof(int))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveAtSwapBack(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveRange(int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "RemoveRangeSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveRangeSwapBack(int index, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourcesData", Member = "AllocateAndResizeNativeListIfNeeded", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>&", typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.UIFoldout", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawerBurst", Member = "ClassifyMaterials$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "ReadOnly<Int32, BatchMaterialID>&", "Unity.Collections.NativeList`1<Int32>&", "Unity.Collections.NativeList`1<Int32>&", "Unity.Collections.NativeList`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Resize(int length, NativeArrayOptions options) { }

	[CalledBy(Type = "UnityEngine.Rendering.CPUInstanceData", Member = "AddUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "BuildGraph", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobFilterProducer`1), Member = "ExecuteAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"JobWrapper<T>&", typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobFilterProducer`1), Member = "ExecuteFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"JobWrapper<T>&", typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FrustumPlaneCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "Unity.Collections.NativeArray`1<Plane>", "UnityEngine.Rendering.ReceiverSphereCuller&", typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.FrustumPlaneCuller")]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverSphereCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverSphereCuller")]
	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "RebuildDrawListsIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUSharedInstanceData", Member = "AddUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.SharedInstanceHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+ComputeInstancesOffsetAndResizeInstancesArrayJob", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "GetVisibleTreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ParallelBitArray&", "UnityEngine.Rendering.ParallelBitArray&", "Unity.Collections.NativeList`1<Int32>", "Unity.Collections.NativeList`1<InstanceHandle>", typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPoolBurst", Member = "AllocateOrGetLODGroupDataInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<LODGroupData>&", "Unity.Collections.NativeList`1<LODGroupCullingData>&", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUInstanceIndex>&", "Unity.Collections.NativeList`1<GPUInstanceIndex>&", "Unity.Collections.NativeArray`1<GPUInstanceIndex>&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<Plane>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void ResizeUninitialized(int length) { }

	[CalledBy(Type = typeof(JobFilterProducer`1), Member = "ExecuteAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"JobWrapper<T>&", typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "ScheduleQuerySortedMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeList`1<InstanceHandle>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Item(int index, T value) { }

	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<Plane>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Length(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<Plane>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public NativeArray<T> ToArray(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeList`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void TrimExcess() { }

}

