namespace Unity.Mathematics.Geometry;

[DebuggerDisplay("{Normal}, {Distance}")]
[Il2CppEagerStaticClassConstruction]
public struct Plane
{
	public float4 NormalAndDistance; //Field offset: 0x0

	public float Distance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Plane Flipped
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public float3 Normal
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 20
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public Plane(float coefficientA, float coefficientB, float coefficientC, float coefficientD) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public Plane(float3 normal, float distance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public Plane(float3 normal, float3 pointInPlane) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public Plane(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckPlaneIsNormalized() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public static Plane CreateFromUnitNormalAndDistance(float3 unitNormal, float distance) { }

	[CallerCount(Count = 0)]
	public static Plane CreateFromUnitNormalAndPointInPlane(float3 unitNormal, float3 pointInPlane) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Distance() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Plane get_Flipped() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public float3 get_Normal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public static Plane Normalize(Plane plane) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	public static float4 Normalize(float4 planeCoefficients) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public static float4 op_Implicit(Plane plane) { }

	[CallerCount(Count = 0)]
	public float3 Projection(float3 point) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_Distance(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Normal(float3 value) { }

	[CallerCount(Count = 0)]
	public float SignedDistanceToPoint(float3 point) { }

}

