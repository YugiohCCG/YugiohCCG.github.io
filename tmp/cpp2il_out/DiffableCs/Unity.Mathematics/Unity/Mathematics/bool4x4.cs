namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct bool4x4 : IEquatable<bool4x4>
{
	public bool4 c0; //Field offset: 0x0
	public bool4 c1; //Field offset: 0x4
	public bool4 c2; //Field offset: 0x8
	public bool4 c3; //Field offset: 0xC

	public bool4 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3) { }

	[CallerCount(Count = 0)]
	public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) { }

	[CallerCount(Count = 0)]
	public bool4x4(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool4x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(bool4x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static bool4x4 op_BitwiseAnd(bool lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static bool4x4 op_BitwiseAnd(bool4x4 lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static bool4x4 op_BitwiseAnd(bool4x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_BitwiseOr(bool4x4 lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_BitwiseOr(bool4x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_BitwiseOr(bool lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(bool lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(bool4x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(bool4x4 lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_ExclusiveOr(bool4x4 lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_ExclusiveOr(bool4x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_ExclusiveOr(bool lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool4x4 op_Implicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(bool4x4 lhs, bool rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(bool4x4 lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(bool lhs, bool4x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 284)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LogicalNot(bool4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public virtual string ToString() { }

}

