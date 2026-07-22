namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct bool4x2 : IEquatable<bool4x2>
{
	public bool4 c0; //Field offset: 0x0
	public bool4 c1; //Field offset: 0x4

	public bool4 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public bool4x2(bool4 c0, bool4 c1) { }

	[CallerCount(Count = 0)]
	public bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) { }

	[CallerCount(Count = 0)]
	public bool4x2(bool v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x2)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static bool4x2 op_BitwiseAnd(bool lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	public static bool4x2 op_BitwiseAnd(bool4x2 lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	public static bool4x2 op_BitwiseAnd(bool4x2 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_BitwiseOr(bool4x2 lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_BitwiseOr(bool4x2 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_BitwiseOr(bool lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(bool lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(bool4x2 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(bool4x2 lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_ExclusiveOr(bool4x2 lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_ExclusiveOr(bool4x2 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_ExclusiveOr(bool lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool4x2 op_Implicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(bool4x2 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(bool4x2 lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(bool lhs, bool4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LogicalNot(bool4x2 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public virtual string ToString() { }

}

