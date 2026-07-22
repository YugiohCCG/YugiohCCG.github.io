namespace UnityEngine.Rendering;

internal struct SilhouettePlaneCache : IDisposable
{
	private struct Slot
	{
		public bool isActive; //Field offset: 0x0
		public int viewInstanceID; //Field offset: 0x4
		public int planeCount; //Field offset: 0x8
		public int lastUsedFrameIndex; //Field offset: 0xC

		[CallerCount(Count = 0)]
		public Slot(int viewInstanceID, int planeCount, int frameIndex) { }

	}

	private const int kMaxSilhouettePlanes = 6; //Field offset: 0x0
	private NativeParallelHashMap<Int32, Int32> m_SubviewIDToIndexMap; //Field offset: 0x0
	private NativeList<Int32> m_SlotFreeList; //Field offset: 0x10
	private NativeList<Slot> m_Slots; //Field offset: 0x18
	private NativeList<Plane> m_PlaneStorage; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.SilhouettePlaneCache+Slot>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Plane>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void FreeUnusedSlots(int frameIndex, int maximumAge) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(OccluderHandles&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	public NativeArray<Plane> GetSubArray(int viewInstanceID) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public void Init() { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "UpdateSilhouettePlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void Update(int viewInstanceID, NativeArray<Plane> planes, int frameIndex) { }

}

