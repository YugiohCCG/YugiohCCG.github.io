namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float3x3 : IEquatable<float3x3>, IFormattable
{
	public static readonly float3x3 identity; //Field offset: 0x0
	public static readonly float3x3 zero; //Field offset: 0x24
	public float3 c0; //Field offset: 0x0
	public float3 c1; //Field offset: 0xC
	public float3 c2; //Field offset: 0x18

	public float3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	[CallerCount(Count = 0)]
	private static float3x3() { }

	[CalledBy(Type = typeof(math), Member = "float3x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(svd), Member = "givensQRFactorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3&)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(svd), Member = "qrGivensQuat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float4)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(float4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(quaternion), typeof(float3)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion), typeof(float3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(svd), Member = "svdInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(svd), Member = "jacobiIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3&), typeof(int)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(math), Member = "decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AffineTransform), typeof(float3&), typeof(quaternion&), typeof(float3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(math), Member = "AffineTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(quaternion), typeof(float3)}, ReturnType = typeof(AffineTransform))]
	[CalledBy(Type = typeof(math), Member = "AffineTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(quaternion)}, ReturnType = typeof(AffineTransform))]
	[CalledBy(Type = typeof(AffineTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AffineTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(quaternion), typeof(float3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AffineTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(math), Member = "AffineTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidTransform)}, ReturnType = typeof(AffineTransform))]
	[CalledBy(Type = typeof(svd), Member = "singularValuesDecomposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(quaternion&)}, ReturnType = typeof(float3))]
	[CallerCount(Count = 22)]
	[ContainsUnimplementedInstructions]
	public float3x3(quaternion q) { }

	[CalledBy(Type = typeof(math), Member = "float3x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(Math), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4), typeof(MinMaxAABB)}, ReturnType = typeof(MinMaxAABB))]
	[CallerCount(Count = 2)]
	public float3x3(float4x4 f4x4) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x3(double3x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x3(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x3(uint3x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x3(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float3x3(float3 c0, float3 c1, float3 c2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x3(int v) { }

	[CallerCount(Count = 0)]
	public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	[CallerCount(Count = 0)]
	public float3x3(float v) { }

	[CallerCount(Count = 0)]
	public float3x3(int3x3 v) { }

	[CallerCount(Count = 0)]
	public float3x3(bool v) { }

	[CallerCount(Count = 0)]
	public float3x3(bool3x3 v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float3x3 AxisAngle(float3 axis, float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[CallsUnknownMethods(Count = 1)]
	public static float3x3 Euler(float x, float y, float z, RotationOrder order = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(float3x3), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	[CallsUnknownMethods(Count = 1)]
	public static float3x3 Euler(float3 xyz, RotationOrder order = 4) { }

	[CalledBy(Type = typeof(float3x3), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float3x3 EulerXYZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	public static float3x3 EulerXYZ(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	public static float3x3 EulerXZY(float x, float y, float z) { }

	[CalledBy(Type = typeof(float3x3), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float3x3 EulerXZY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	public static float3x3 EulerYXZ(float x, float y, float z) { }

	[CalledBy(Type = typeof(float3x3), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float3x3 EulerYXZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	public static float3x3 EulerYZX(float x, float y, float z) { }

	[CalledBy(Type = typeof(float3x3), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float3x3 EulerYZX(float3 xyz) { }

	[CalledBy(Type = typeof(float3x3), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float3x3 EulerZXY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	public static float3x3 EulerZXY(float x, float y, float z) { }

	[CalledBy(Type = typeof(float3x3), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(float3x3), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float3x3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 76)]
	public static float3x3 EulerZYX(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3x3))]
	public static float3x3 EulerZYX(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	public static float3x3 LookRotation(float3 forward, float3 up) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "rsqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	public static float3x3 LookRotationSafe(float3 forward, float3 up) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Addition(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Addition(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Addition(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Decrement(float3x3 val) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Division(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Division(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Division(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Equality(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Equality(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Equality(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float3x3 op_Explicit(bool3x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x3 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float3x3 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x3 op_Explicit(double3x3 v) { }

	[CalledBy(Type = "UnityEngine.Rendering.ReceiverSphereCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverSphereCuller")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static float3x3 op_Explicit(float4x4 f4x4) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThan(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThan(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThan(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThanOrEqual(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThanOrEqual(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThanOrEqual(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x3 op_Implicit(int3x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x3 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float3x3 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x3 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x3 op_Implicit(uint3x3 v) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Increment(float3x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Inequality(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Inequality(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Inequality(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThan(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThan(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThan(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThanOrEqual(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThanOrEqual(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThanOrEqual(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	public static float3x3 op_Modulus(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	public static float3x3 op_Modulus(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	public static float3x3 op_Modulus(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Multiply(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Multiply(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Multiply(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Subtraction(float3x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Subtraction(float3x3 lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_Subtraction(float lhs, float3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_UnaryNegation(float3x3 val) { }

	[CallerCount(Count = 0)]
	public static float3x3 op_UnaryPlus(float3x3 val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float3x3 RotateX(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float3x3 RotateY(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float3x3 RotateZ(float angle) { }

	[CallerCount(Count = 0)]
	public static float3x3 Scale(float s) { }

	[CallerCount(Count = 0)]
	public static float3x3 Scale(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	public static float3x3 Scale(float3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 38)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 38)]
	public virtual string ToString() { }

}

