namespace UnityEngine.Rendering;

internal struct FrustumPlaneCuller
{
	public struct PlanePacket4
	{
		public float4 nx; //Field offset: 0x0
		public float4 ny; //Field offset: 0x10
		public float4 nz; //Field offset: 0x20
		public float4 d; //Field offset: 0x30
		public float4 nxAbs; //Field offset: 0x40
		public float4 nyAbs; //Field offset: 0x50
		public float4 nzAbs; //Field offset: 0x60

		[CalledBy(Type = typeof(FrustumPlaneCuller), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(ReceiverSphereCuller&), typeof(Allocator)}, ReturnType = typeof(FrustumPlaneCuller))]
		[CallerCount(Count = 1)]
		public PlanePacket4(NativeArray<Plane> planes, int offset, int limit) { }

	}

	public struct SplitInfo
	{
		public int packetCount; //Field offset: 0x0

	}

	public NativeList<PlanePacket4> planePackets; //Field offset: 0x0
	public NativeList<SplitInfo> splitInfos; //Field offset: 0x8

	[CalledBy(Type = typeof(CullingJob), Member = "CalculateVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(InstanceFlags)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static uint ComputeSplitVisibilityMask(NativeArray<PlanePacket4> planePackets, NativeArray<SplitInfo> splitInfos, in AABB bounds) { }

	[CalledBy(Type = typeof(SetupCullingJobInput_00000146$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullerBurst), Member = "SetupCullingJobInput$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(PlanePacket4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Plane>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static FrustumPlaneCuller Create(in BatchCullingContext cc, NativeArray<Plane> receiverPlanes, in ReceiverSphereCuller receiverSphereCuller, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.FrustumPlaneCuller+PlanePacket4>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.FrustumPlaneCuller+SplitInfo>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	internal void Dispose(JobHandle job) { }

}

