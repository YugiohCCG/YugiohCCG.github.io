namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct bool3x3 : IEquatable<bool3x3>
{
	public bool3 c0; //Field offset: 0x0
	public bool3 c1; //Field offset: 0x3
	public bool3 c2; //Field offset: 0x6

	public bool3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	public bool3x3(bool3 c0, bool3 c1, bool3 c2) { }

	[CallerCount(Count = 0)]
	public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) { }

	[CallerCount(Count = 0)]
	public bool3x3(bool v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static bool3x3 op_BitwiseAnd(bool lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static bool3x3 op_BitwiseAnd(bool3x3 lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	public static bool3x3 op_BitwiseAnd(bool3x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_BitwiseOr(bool3x3 lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_BitwiseOr(bool3x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_BitwiseOr(bool lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Equality(bool lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Equality(bool3x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Equality(bool3x3 lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_ExclusiveOr(bool3x3 lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_ExclusiveOr(bool3x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_ExclusiveOr(bool lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool3x3 op_Implicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Inequality(bool3x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Inequality(bool3x3 lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_Inequality(bool lhs, bool3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LogicalNot(bool3x3 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 38)]
	public virtual string ToString() { }

}

