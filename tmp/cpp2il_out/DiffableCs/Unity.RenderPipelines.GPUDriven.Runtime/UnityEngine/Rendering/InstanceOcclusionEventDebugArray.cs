namespace UnityEngine.Rendering;

internal struct InstanceOcclusionEventDebugArray : IDisposable
{
	public struct Info
	{
		public int viewInstanceID; //Field offset: 0x0
		public InstanceOcclusionEventType eventType; //Field offset: 0x4
		public int occluderVersion; //Field offset: 0x8
		public int subviewMask; //Field offset: 0xC
		public OcclusionTest occlusionTest; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool HasVersion() { }

	}

	public struct Request
	{
		public UnsafeList<Info> info; //Field offset: 0x0
		public AsyncGPUReadbackRequest readback; //Field offset: 0x18

	}

	private const int InitialPassCount = 4; //Field offset: 0x0
	private const int MaxPassCount = 64; //Field offset: 0x0
	private GraphicsBuffer m_CounterBuffer; //Field offset: 0x0
	private UnsafeList<Info> m_PendingInfo; //Field offset: 0x8
	private NativeQueue<Request> m_Requests; //Field offset: 0x20
	private UnsafeList<Info> m_LatestInfo; //Field offset: 0x28
	private NativeArray<Int32> m_LatestCounters; //Field offset: 0x40
	private bool m_HasLatest; //Field offset: 0x50

	public GraphicsBuffer CounterBuffer
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(InstanceCuller), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Info>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeQueue`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Request>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Request&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "WaitForCompletion", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public GraphicsBuffer get_CounterBuffer() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources), typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(UnsafeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeQueue`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Request>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Init() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "FlushDebugCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unity.Collections.NativeQueue`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Request>), Member = "Dequeue", ReturnType = typeof(Request))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Info>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "GetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Unity.Collections.NativeQueue`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Request>), Member = "Peek", ReturnType = typeof(Request))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeQueue`1), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeQueue`1<UnityEngine.Rendering.InstanceOcclusionEventDebugArray+Request>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Request)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncGPUReadback), Member = "Request", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(AsyncGPUReadbackRequest))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOccludersUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public int TryAdd(int viewInstanceID, InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, OcclusionTest occlusionTest) { }

}

