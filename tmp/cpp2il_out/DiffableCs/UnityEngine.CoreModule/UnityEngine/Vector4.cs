namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector4f")]
[NativeHeader("Runtime/Math/Vector4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Vector4 : IEquatable<Vector4>, IFormattable
{
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	private static readonly Vector4 zeroVector; //Field offset: 0x0
	private static readonly Vector4 oneVector; //Field offset: 0x10
	private static readonly Vector4 positiveInfinityVector; //Field offset: 0x20
	private static readonly Vector4 negativeInfinityVector; //Field offset: 0x30
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8
	public float w; //Field offset: 0xC

	public float Item
	{
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommonShaderVariables", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderContext&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 144
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 144
	}

	public float magnitude
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 167
	}

	public Vector4 normalized
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector4), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(Vector4))]
		 get { } //Length: 56
	}

	public static Vector4 one
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 67
	}

	public float sqrMagnitude
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 50
	}

	public static Vector4 zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 66
	}

	[CallerCount(Count = 0)]
	private static Vector4() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Vector4(float x, float y, float z, float w) { }

	[CallerCount(Count = 0)]
	public Vector4(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	public Vector4(float x, float y) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float Dot(Vector4 a, Vector4 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Vector4 other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommonShaderVariables", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderContext&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public float get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_magnitude() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector4), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(Vector4))]
	public Vector4 get_normalized() { }

	[CallerCount(Count = 0)]
	public static Vector4 get_one() { }

	[CallerCount(Count = 0)]
	public float get_sqrMagnitude() { }

	[CallerCount(Count = 0)]
	public static Vector4 get_zero() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Magnitude(Vector4 a) { }

	[CalledBy(Type = typeof(Vector4), Member = "get_normalized", ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static Vector4 Normalize(Vector4 a) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Vector4 op_Division(Vector4 a, float d) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 op_Implicit(Vector4 v) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public static Vector3 op_Implicit(Vector4 v) { }

	[CallerCount(Count = 0)]
	public static Vector4 op_Implicit(Vector2 v) { }

	[CallerCount(Count = 0)]
	public static Vector4 op_Implicit(Vector3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	public static Vector4 op_UnaryNegation(Vector4 a) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Scale(Vector4 scale) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void Set(float newX, float newY, float newZ, float newW) { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetAdjustedBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Rect)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_Item(int index, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

