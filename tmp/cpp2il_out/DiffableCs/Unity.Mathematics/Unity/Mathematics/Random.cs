namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public struct Random
{
	public uint state; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Random(uint seed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckIndexForHash(uint index) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckInitState() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckNextIntMax(int max) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckNextIntMinMax(int min, int max) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckNextUIntMinMax(uint min, uint max) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckState() { }

	[CallerCount(Count = 0)]
	public static Random CreateFromIndex(uint index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void InitState(uint seed = 1851936439) { }

	[CallerCount(Count = 0)]
	public bool NextBool() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool2 NextBool2() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool3 NextBool3() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool4 NextBool4() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double NextDouble() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double NextDouble(double max) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double NextDouble(double min, double max) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double2 NextDouble2(double2 max) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double2 NextDouble2() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double2 NextDouble2(double2 min, double2 max) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public double2 NextDouble2Direction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "NextDouble3", ReturnType = typeof(double3))]
	[ContainsUnimplementedInstructions]
	public double3 NextDouble3(double3 max) { }

	[CalledBy(Type = typeof(Random), Member = "NextDouble3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double3)}, ReturnType = typeof(double3))]
	[CalledBy(Type = typeof(Random), Member = "NextDouble3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double3), typeof(double3)}, ReturnType = typeof(double3))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public double3 NextDouble3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "NextDouble3", ReturnType = typeof(double3))]
	[ContainsUnimplementedInstructions]
	public double3 NextDouble3(double3 min, double3 max) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public double3 NextDouble3Direction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "NextDouble4", ReturnType = typeof(double4))]
	[ContainsUnimplementedInstructions]
	public double4 NextDouble4(double4 max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "NextDouble4", ReturnType = typeof(double4))]
	[ContainsUnimplementedInstructions]
	public double4 NextDouble4(double4 min, double4 max) { }

	[CalledBy(Type = typeof(Random), Member = "NextDouble4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4)}, ReturnType = typeof(double4))]
	[CalledBy(Type = typeof(Random), Member = "NextDouble4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4), typeof(double4)}, ReturnType = typeof(double4))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public double4 NextDouble4() { }

	[CallerCount(Count = 0)]
	public float NextFloat(float min, float max) { }

	[CallerCount(Count = 0)]
	public float NextFloat() { }

	[CallerCount(Count = 0)]
	public float NextFloat(float max) { }

	[CallerCount(Count = 0)]
	public float2 NextFloat2() { }

	[CallerCount(Count = 0)]
	public float2 NextFloat2(float2 min, float2 max) { }

	[CallerCount(Count = 0)]
	public float2 NextFloat2(float2 max) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public float2 NextFloat2Direction() { }

	[CallerCount(Count = 0)]
	public float3 NextFloat3(float3 max) { }

	[CallerCount(Count = 0)]
	public float3 NextFloat3(float3 min, float3 max) { }

	[CallerCount(Count = 0)]
	public float3 NextFloat3() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public float3 NextFloat3Direction() { }

	[CallerCount(Count = 0)]
	public float4 NextFloat4(float4 max) { }

	[CallerCount(Count = 0)]
	public float4 NextFloat4(float4 min, float4 max) { }

	[CallerCount(Count = 0)]
	public float4 NextFloat4() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int NextInt(int min, int max) { }

	[CallerCount(Count = 0)]
	public int NextInt(int max) { }

	[CallerCount(Count = 0)]
	public int NextInt() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int2 NextInt2(int2 min, int2 max) { }

	[CallerCount(Count = 0)]
	public int2 NextInt2() { }

	[CallerCount(Count = 0)]
	public int2 NextInt2(int2 max) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3 NextInt3(int3 min, int3 max) { }

	[CallerCount(Count = 0)]
	public int3 NextInt3(int3 max) { }

	[CallerCount(Count = 0)]
	public int3 NextInt3() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4 NextInt4(int4 min, int4 max) { }

	[CallerCount(Count = 0)]
	public int4 NextInt4(int4 max) { }

	[CallerCount(Count = 0)]
	public int4 NextInt4() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2&), typeof(float2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[CallsUnknownMethods(Count = 3)]
	public quaternion NextQuaternionRotation() { }

	[CallerCount(Count = 0)]
	private uint NextState() { }

	[CallerCount(Count = 0)]
	public uint NextUInt() { }

	[CallerCount(Count = 0)]
	public uint NextUInt(uint max) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint NextUInt(uint min, uint max) { }

	[CallerCount(Count = 0)]
	public uint2 NextUInt2() { }

	[CallerCount(Count = 0)]
	public uint2 NextUInt2(uint2 max) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2 NextUInt2(uint2 min, uint2 max) { }

	[CallerCount(Count = 0)]
	public uint3 NextUInt3() { }

	[CallerCount(Count = 0)]
	public uint3 NextUInt3(uint3 max) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3 NextUInt3(uint3 min, uint3 max) { }

	[CallerCount(Count = 0)]
	public uint4 NextUInt4() { }

	[CallerCount(Count = 0)]
	public uint4 NextUInt4(uint4 max) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4 NextUInt4(uint4 min, uint4 max) { }

	[CallerCount(Count = 0)]
	internal static uint WangHash(uint n) { }

}

