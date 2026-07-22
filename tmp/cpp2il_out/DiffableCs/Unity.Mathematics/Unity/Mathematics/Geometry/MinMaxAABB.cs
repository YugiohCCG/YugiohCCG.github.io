namespace Unity.Mathematics.Geometry;

[Il2CppEagerStaticClassConstruction]
public struct MinMaxAABB : IEquatable<MinMaxAABB>
{
	public float3 Min; //Field offset: 0x0
	public float3 Max; //Field offset: 0xC

	public float3 Center
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 67
	}

	public float3 Extents
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 47
	}

	public float3 HalfExtents
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 67
	}

	public bool IsValid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 41
	}

	public float SurfaceArea
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 57
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public MinMaxAABB(float3 min, float3 max) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Contains(float3 point) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Contains(MinMaxAABB aabb) { }

	[CallerCount(Count = 0)]
	public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents) { }

	[CallerCount(Count = 0)]
	public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Encapsulate(MinMaxAABB aabb) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Encapsulate(float3 point) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(MinMaxAABB other) { }

	[CallerCount(Count = 0)]
	public void Expand(float signedDistance) { }

	[CallerCount(Count = 0)]
	public float3 get_Center() { }

	[CallerCount(Count = 0)]
	public float3 get_Extents() { }

	[CallerCount(Count = 0)]
	public float3 get_HalfExtents() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsValid() { }

	[CallerCount(Count = 0)]
	public float get_SurfaceArea() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Overlaps(MinMaxAABB aabb) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

