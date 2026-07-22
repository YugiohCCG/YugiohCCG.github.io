namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public struct quaternion : IEquatable<quaternion>, IFormattable
{
	public static readonly quaternion identity; //Field offset: 0x0
	public float4 value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static quaternion() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public quaternion(float x, float y, float z, float w) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public quaternion(float4 value) { }

	[CalledBy(Type = typeof(math), Member = "quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(math), Member = "rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(math), Member = "RigidTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "LookRotationSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public quaternion(float3x3 m) { }

	[CalledBy(Type = typeof(math), Member = "quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(math), Member = "RigidTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public quaternion(float4x4 m) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static quaternion AxisAngle(float3 axis, float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object x) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(quaternion x) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static quaternion Euler(float x, float y, float z, RotationOrder order = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[CallsUnknownMethods(Count = 1)]
	public static quaternion Euler(float3 xyz, RotationOrder order = 4) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(Random), Member = "NextQuaternionRotation", ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(RigidTransform))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static quaternion EulerXYZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static quaternion EulerXYZ(float x, float y, float z) { }

	[CalledBy(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(Random), Member = "NextQuaternionRotation", ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(RigidTransform))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static quaternion EulerXZY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static quaternion EulerXZY(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static quaternion EulerYXZ(float x, float y, float z) { }

	[CalledBy(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(Random), Member = "NextQuaternionRotation", ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(RigidTransform))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static quaternion EulerYXZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static quaternion EulerYZX(float x, float y, float z) { }

	[CalledBy(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(Random), Member = "NextQuaternionRotation", ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(RigidTransform))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static quaternion EulerYZX(float3 xyz) { }

	[CalledBy(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(Random), Member = "NextQuaternionRotation", ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(RigidTransform))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static quaternion EulerZXY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static quaternion EulerZXY(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static quaternion EulerZYX(float x, float y, float z) { }

	[CalledBy(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(quaternion), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(Random), Member = "NextQuaternionRotation", ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(RigidTransform))]
	[CalledBy(Type = typeof(RigidTransform), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(RigidTransform))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 124)]
	public static quaternion EulerZYX(float3 xyz) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static quaternion LookRotation(float3 forward, float3 up) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static quaternion LookRotationSafe(float3 forward, float3 up) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public static quaternion op_Implicit(Quaternion q) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public static quaternion op_Implicit(float4 v) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public static Quaternion op_Implicit(quaternion q) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static quaternion RotateX(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static quaternion RotateY(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static quaternion RotateZ(float angle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}

