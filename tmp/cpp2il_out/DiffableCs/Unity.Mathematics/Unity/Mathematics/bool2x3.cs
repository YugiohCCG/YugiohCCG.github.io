namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct bool2x3 : IEquatable<bool2x3>
{
	public bool2 c0; //Field offset: 0x0
	public bool2 c1; //Field offset: 0x2
	public bool2 c2; //Field offset: 0x4

	public bool2 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool2x3(bool2 c0, bool2 c1, bool2 c2) { }

	[CallerCount(Count = 0)]
	public bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) { }

	[CallerCount(Count = 0)]
	public bool2x3(bool v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool2 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static bool2x3 op_BitwiseAnd(bool lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	public static bool2x3 op_BitwiseAnd(bool2x3 lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	public static bool2x3 op_BitwiseAnd(bool2x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_BitwiseOr(bool2x3 lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_BitwiseOr(bool2x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_BitwiseOr(bool lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_Equality(bool lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_Equality(bool2x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_Equality(bool2x3 lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_ExclusiveOr(bool2x3 lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_ExclusiveOr(bool2x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_ExclusiveOr(bool lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool2x3 op_Implicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_Inequality(bool2x3 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_Inequality(bool2x3 lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_Inequality(bool lhs, bool2x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x3 op_LogicalNot(bool2x3 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 26)]
	public virtual string ToString() { }

}

