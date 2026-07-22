namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeType("Runtime/Math/Vector2Int.h")]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	private static readonly Vector2Int s_Zero; //Field offset: 0x0
	private static readonly Vector2Int s_One; //Field offset: 0x8
	private static readonly Vector2Int s_Up; //Field offset: 0x10
	private static readonly Vector2Int s_Down; //Field offset: 0x18
	private static readonly Vector2Int s_Left; //Field offset: 0x20
	private static readonly Vector2Int s_Right; //Field offset: 0x28
	private int m_X; //Field offset: 0x0
	private int m_Y; //Field offset: 0x4

	public float magnitude
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 46
	}

	public static Vector2Int one
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
	}

	public int x
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public int y
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static Vector2Int zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 54
	}

	[CallerCount(Count = 0)]
	private static Vector2Int() { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public Vector2Int(int x, int y) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Vector2Int other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static Vector2Int FloorToInt(Vector2 v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_magnitude() { }

	[CallerCount(Count = 0)]
	public static Vector2Int get_one() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_x() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public int get_y() { }

	[CallerCount(Count = 0)]
	public static Vector2Int get_zero() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs) { }

	[CallerCount(Count = 0)]
	public static Vector2Int op_Addition(Vector2Int a, Vector2Int b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Vector2Int op_Division(Vector2Int a, int b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	[CallerCount(Count = 0)]
	public static Vector2 op_Implicit(Vector2Int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	[CallerCount(Count = 0)]
	public static Vector2Int op_Multiply(int a, Vector2Int b) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_x(int value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_y(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

