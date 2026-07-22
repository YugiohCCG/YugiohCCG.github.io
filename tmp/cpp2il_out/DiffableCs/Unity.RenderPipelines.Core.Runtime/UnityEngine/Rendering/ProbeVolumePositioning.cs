namespace UnityEngine.Rendering;

internal static class ProbeVolumePositioning
{
	internal static Vector3[] m_Axes; //Field offset: 0x0
	internal static Vector3[] m_AABBCorners; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ProbeVolumePositioning() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ShouldCullCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProbeVolumePositioning), Member = "ProjectOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume&), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool OBBAABBIntersect(in Volume a, in Bounds b, in Bounds aAABB) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool OBBContains(in Volume obb, Vector3 point) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeVolumePositioning), Member = "ProjectOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume&), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 14)]
	public static bool OBBIntersect(in Volume a, in Volume b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Vector2 ProjectAABB(in Vector3[] corners, Vector3 axis) { }

	[CalledBy(Type = typeof(ProbeVolumePositioning), Member = "OBBIntersect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume&), typeof(Volume&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumePositioning), Member = "OBBAABBIntersect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume&), typeof(Bounds&), typeof(Bounds&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static Vector2 ProjectOBB(in Volume a, Vector3 axis) { }

}

