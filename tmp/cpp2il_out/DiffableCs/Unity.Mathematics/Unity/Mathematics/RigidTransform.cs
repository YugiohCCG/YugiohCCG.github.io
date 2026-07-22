namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public struct RigidTransform
{
	public static readonly RigidTransform identity; //Field offset: 0x0
	public quaternion rot; //Field offset: 0x0
	public float3 pos; //Field offset: 0x10

	[CallerCount(Count = 0)]
	private static RigidTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(void))]
	public RigidTransform(float4x4 transform) { }

	[CallerCount(Count = 0)]
	public RigidTransform(quaternion rotation, float3 translation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(void))]
	public RigidTransform(float3x3 rotation, float3 translation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static RigidTransform AxisAngle(float3 axis, float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object x) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Equals(RigidTransform x) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static RigidTransform Euler(float x, float y, float z, RotationOrder order = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	[CallsUnknownMethods(Count = 1)]
	public static RigidTransform Euler(float3 xyz, RotationOrder order = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerXYZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerXYZ(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerXZY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerXZY(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerYXZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerYXZ(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerYZX(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerYZX(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerZXY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerZXY(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerZYX(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(quaternion), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(quaternion))]
	public static RigidTransform EulerZYX(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static RigidTransform RotateX(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static RigidTransform RotateY(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static RigidTransform RotateZ(float angle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 30)]
	public string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 30)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	public static RigidTransform Translate(float3 vector) { }

}

