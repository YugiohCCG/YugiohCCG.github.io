namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct bool3x4 : IEquatable<bool3x4>
{
	public bool3 c0; //Field offset: 0x0
	public bool3 c1; //Field offset: 0x3
	public bool3 c2; //Field offset: 0x6
	public bool3 c3; //Field offset: 0x9

	public bool3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	public bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) { }

	[CallerCount(Count = 0)]
	public bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) { }

	[CallerCount(Count = 0)]
	public bool3x4(bool v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool3x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static bool3x4 op_BitwiseAnd(bool lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static bool3x4 op_BitwiseAnd(bool3x4 lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static bool3x4 op_BitwiseAnd(bool3x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_BitwiseOr(bool3x4 lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_BitwiseOr(bool3x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_BitwiseOr(bool lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(bool lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(bool3x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(bool3x4 lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_ExclusiveOr(bool3x4 lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_ExclusiveOr(bool3x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_ExclusiveOr(bool lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool3x4 op_Implicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Inequality(bool3x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(bool3x4 lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(bool lhs, bool3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LogicalNot(bool3x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public virtual string ToString() { }

}

