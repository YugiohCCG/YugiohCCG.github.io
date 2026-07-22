namespace UnityEngine.Rendering;

internal struct ReceiverSphereCuller
{
	public struct SplitInfo
	{
		public float4 receiverSphereLightSpace; //Field offset: 0x0
		public float cascadeBlendCullingFactor; //Field offset: 0x10

	}

	public NativeList<SplitInfo> splitInfos; //Field offset: 0x0
	public float3x3 worldToLightSpaceRotation; //Field offset: 0x8

	[CalledBy(Type = typeof(CullingJob), Member = "CalculateVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(InstanceFlags)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static uint ComputeSplitVisibilityMask(NativeArray<Plane> lightFacingFrustumPlanes, NativeArray<SplitInfo> splitInfos, float3x3 worldToLightSpaceRotation, in AABB bounds) { }

	[CalledBy(Type = typeof(SetupCullingJobInput_00000146$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullerBurst), Member = "SetupCullingJobInput$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static ReceiverSphereCuller Create(in BatchCullingContext cc, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	internal static ReceiverSphereCuller CreateEmptyForTesting(Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.ReceiverSphereCuller+SplitInfo>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	internal void Dispose(JobHandle job) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static float DistanceUntilCylinderFullyCrossesPlane(float3 cylinderCenter, float3 cylinderDirection, float cylinderRadius, Plane plane) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool UseReceiverPlanes() { }

}

