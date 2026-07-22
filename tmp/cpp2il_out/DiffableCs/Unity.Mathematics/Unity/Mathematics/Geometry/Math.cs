namespace Unity.Mathematics.Geometry;

public static class Math
{

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static MinMaxAABB Transform(RigidTransform transform, MinMaxAABB aabb) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(MinMaxAABB)}, ReturnType = typeof(MinMaxAABB))]
	public static MinMaxAABB Transform(float4x4 transform, MinMaxAABB aabb) { }

	[CalledBy(Type = typeof(Math), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4), typeof(MinMaxAABB)}, ReturnType = typeof(MinMaxAABB))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 168)]
	[ContainsUnimplementedInstructions]
	public static MinMaxAABB Transform(float3x3 transform, MinMaxAABB aabb) { }

}

