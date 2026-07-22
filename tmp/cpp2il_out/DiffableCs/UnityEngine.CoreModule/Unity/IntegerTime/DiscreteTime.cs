namespace Unity.IntegerTime;

public struct DiscreteTime : IEquatable<DiscreteTime>, IFormattable, IComparable<DiscreteTime>
{
	public static readonly DiscreteTime Zero; //Field offset: 0x0
	public static readonly DiscreteTime MinValue; //Field offset: 0x8
	public static readonly DiscreteTime MaxValue; //Field offset: 0x10
	private static readonly int TicksPerSecondBits; //Field offset: 0x18
	private static readonly int NonPow2TpsBits; //Field offset: 0x1C
	[SerializeField]
	public long Value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static DiscreteTime() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	private DiscreteTime(long v, int _) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public DiscreteTime(float v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public DiscreteTime(double v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[IsReadOnly]
	public override int CompareTo(DiscreteTime other) { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override bool Equals(DiscreteTime rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public static DiscreteTime FromTicks(long v) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[IsReadOnly]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float op_Explicit(DiscreteTime d) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double op_Explicit(DiscreteTime d) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	[CallerCount(Count = 0)]
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

