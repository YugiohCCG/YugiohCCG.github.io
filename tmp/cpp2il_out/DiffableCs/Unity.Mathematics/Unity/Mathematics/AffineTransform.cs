namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public struct AffineTransform : IEquatable<AffineTransform>, IFormattable
{
	public static readonly AffineTransform identity; //Field offset: 0x0
	public static readonly AffineTransform zero; //Field offset: 0x30
	public float3x3 rs; //Field offset: 0x0
	public float3 t; //Field offset: 0x24

	[CallerCount(Count = 0)]
	private static AffineTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	public AffineTransform(float3 translation, quaternion rotation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public AffineTransform(float3 translation, quaternion rotation, float3 scale) { }

	[CallerCount(Count = 0)]
	public AffineTransform(float3 translation, float3x3 rotationScale) { }

	[CallerCount(Count = 0)]
	public AffineTransform(float3x3 rotationScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	public AffineTransform(RigidTransform rigid) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public AffineTransform(float3x4 m) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public AffineTransform(float4x4 m) { }

	[CalledBy(Type = typeof(AffineTransform), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 118)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(AffineTransform rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AffineTransform), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AffineTransform)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AffineTransform)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x4 op_Implicit(AffineTransform m) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x4 op_Implicit(AffineTransform m) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

