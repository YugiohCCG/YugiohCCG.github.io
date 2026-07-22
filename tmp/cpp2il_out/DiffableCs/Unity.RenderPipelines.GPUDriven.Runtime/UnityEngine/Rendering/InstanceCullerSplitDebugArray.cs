namespace UnityEngine.Rendering;

internal struct InstanceCullerSplitDebugArray : IDisposable
{
	public struct Info
	{
		public BatchCullingViewType viewType; //Field offset: 0x0
		public int viewInstanceID; //Field offset: 0x4
		public int splitIndex; //Field offset: 0x8

	}

	private const int MaxSplitCount = 64; //Field offset: 0x0
	private NativeList<Info> m_Info; //Field offset: 0x0
	private NativeArray<Int32> m_Counters; //Field offset: 0x8
	private NativeQueue<JobHandle> m_CounterSync; //Field offset: 0x18

	public NativeArray<Int32> Counters
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	public void AddSync(int baseIndex, JobHandle jobHandle) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceCullerSplitDebugArray+Info>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeArray<Int32> get_Counters() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources), typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeQueue`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public void Init() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "FlushDebugCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceCullerViewStats>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceCullerViewStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "FillArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", "T&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateCullJobTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(BatchCullingOutput), typeof(ReadOnly&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(CPUDrawInstanceData), typeof(Unity.Collections.NativeParallelHashMap`2<System.UInt32, UnityEngine.Rendering.BatchID>), typeof(int), typeof(float), typeof(OcclusionCullingCommon)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public int TryAddSplits(BatchCullingViewType viewType, int viewInstanceID, int splitCount) { }

}

