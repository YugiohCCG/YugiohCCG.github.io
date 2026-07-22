namespace UnityEngine.Rendering;

[Extension]
internal static class LODGroupRenderingUtils
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float CalculateFOVHalfAngle(float fieldOfView) { }

	[CalledBy(Type = typeof(CullingJob), Member = "CalculateLODVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(InstanceFlags)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	public static float CalculateLODDistance(float relativeScreenHeight, float size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float CalculatePerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric) { }

	[CalledBy(Type = typeof(SetupCullingJobInput_00000146$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullerBurst), Member = "SetupCullingJobInput$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LODParameters), Member = "get_isOrthographic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static float CalculateScreenRelativeMetric(LODParameters lodParams, float lodBias) { }

	[CalledBy(Type = typeof(CullingJob), Member = "CalculateLODVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(InstanceFlags)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	public static float CalculateSqrPerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LODGroup), Member = "get_localReferencePoint", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Vector3 GetWorldReferencePoint(LODGroup lodGroup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float GetWorldSpaceScale(LODGroup lodGroup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(LODGroup), Member = "get_size", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float GetWorldSpaceSize(LODGroup lodGroup) { }

}

