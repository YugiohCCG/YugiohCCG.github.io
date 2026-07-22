namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float4x4 : IEquatable<float4x4>, IFormattable
{
	public static readonly float4x4 identity; //Field offset: 0x0
	public static readonly float4x4 zero; //Field offset: 0x40
	public float4 c0; //Field offset: 0x0
	public float4 c1; //Field offset: 0x10
	public float4 c2; //Field offset: 0x20
	public float4 c3; //Field offset: 0x30

	public float4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	private static float4x4() { }

	[CalledBy(Type = typeof(math), Member = "float4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RigidTransform)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	public float4x4(RigidTransform transform) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(math), Member = "float4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion), typeof(float3)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	public float4x4(quaternion rotation, float3 translation) { }

	[CalledBy(Type = typeof(math), Member = "float4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 1)]
	public float4x4(float3x3 rotation, float3 translation) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x4(double4x4 v) { }

	[CalledBy(Type = typeof(float4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float4x4(double v) { }

	[CalledBy(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint4x4)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float4x4(uint4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	[CallerCount(Count = 0)]
	public float4x4(int4x4 v) { }

	[CallerCount(Count = 0)]
	public float4x4(bool v) { }

	[CalledBy(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float4x4(uint v) { }

	[CallerCount(Count = 0)]
	public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	[CallerCount(Count = 0)]
	public float4x4(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x4(int v) { }

	[CalledBy(Type = typeof(math), Member = "float4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 2)]
	public float4x4(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float4x4 AxisAngle(float3 axis, float angle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(float4x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[CallsUnknownMethods(Count = 1)]
	public static float4x4 Euler(float3 xyz, RotationOrder order = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(float4x4), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	[CallsUnknownMethods(Count = 1)]
	public static float4x4 Euler(float x, float y, float z, RotationOrder order = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	public static float4x4 EulerXYZ(float x, float y, float z) { }

	[CalledBy(Type = typeof(float4x4), Member = "EulerXYZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float4x4 EulerXYZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	public static float4x4 EulerXZY(float x, float y, float z) { }

	[CalledBy(Type = typeof(float4x4), Member = "EulerXZY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float4x4 EulerXZY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	public static float4x4 EulerYXZ(float x, float y, float z) { }

	[CalledBy(Type = typeof(float4x4), Member = "EulerYXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float4x4 EulerYXZ(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	public static float4x4 EulerYZX(float x, float y, float z) { }

	[CalledBy(Type = typeof(float4x4), Member = "EulerYZX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float4x4 EulerYZX(float3 xyz) { }

	[CalledBy(Type = typeof(float4x4), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	public static float4x4 EulerZXY(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerZXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	public static float4x4 EulerZXY(float x, float y, float z) { }

	[CalledBy(Type = typeof(float4x4), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CalledBy(Type = typeof(float4x4), Member = "Euler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(RotationOrder)}, ReturnType = typeof(float4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "sincos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&), typeof(float3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 132)]
	public static float4x4 EulerZYX(float3 xyz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = "EulerZYX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float4x4))]
	public static float4x4 EulerZYX(float x, float y, float z) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public float4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float4x4 LookAt(float3 eye, float3 target, float3 up) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Addition(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Addition(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_Addition(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Decrement(float4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Division(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_Division(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_Division(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static float4x4 op_Explicit(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static float4x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x4 op_Explicit(double4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(float4x4 lhs, float rhs) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "GetDecalProjectBoundingSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(BoundingSphere))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ReceiverSphereCuller", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = "UnityEngine.Rendering.ReceiverSphereCuller")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	public static float4x4 op_Implicit(Matrix4x4 m) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static float4x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x4 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint4x4)}, ReturnType = typeof(void))]
	public static float4x4 op_Implicit(uint4x4 v) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Matrix4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	public static Matrix4x4 op_Implicit(float4x4 m) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x4 op_Implicit(int4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Increment(float4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	public static float4x4 op_Modulus(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	public static float4x4 op_Modulus(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	public static float4x4 op_Modulus(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_Multiply(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Multiply(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Multiply(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x4 op_Subtraction(float4x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_Subtraction(float4x4 lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_Subtraction(float lhs, float4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x4 op_UnaryNegation(float4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(math), Member = "f16tof32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 124)]
	public static float4x4 op_UnaryPlus(float4x4 val) { }

	[CallerCount(Count = 0)]
	public static float4x4 Ortho(float width, float height, float near, float far) { }

	[CallerCount(Count = 0)]
	public static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far) { }

	[CallerCount(Count = 0)]
	public static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float4x4 RotateX(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float4x4 RotateY(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float4x4 RotateZ(float angle) { }

	[CallerCount(Count = 0)]
	public static float4x4 Scale(float s) { }

	[CallerCount(Count = 0)]
	public static float4x4 Scale(float3 scales) { }

	[CallerCount(Count = 0)]
	public static float4x4 Scale(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	public static float4x4 Translate(float3 vector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) { }

}

