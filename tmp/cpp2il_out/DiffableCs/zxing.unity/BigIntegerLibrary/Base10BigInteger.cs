namespace BigIntegerLibrary;

internal sealed class Base10BigInteger
{
	[DefaultMember("Item")]
	private class DigitContainer
	{
		private const int ChunkSize = 32; //Field offset: 0x0
		private const int ChunkSizeDivisionShift = 5; //Field offset: 0x0
		private const int ChunkCount = 200; //Field offset: 0x0
		private readonly Int64[][] digits; //Field offset: 0x10

		public long Item
		{
			[CalledBy(Type = typeof(Base10BigInteger), Member = "Greater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
			[CallerCount(Count = 8)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 86
			[CalledBy(Type = typeof(Base10BigInteger), Member = ".ctor", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Base10BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
			[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
			[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
			[CallerCount(Count = 13)]
			[CallsUnknownMethods(Count = 3)]
			 set { } //Length: 205
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public DigitContainer() { }

		[CalledBy(Type = typeof(Base10BigInteger), Member = "Greater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		public long get_Item(int index) { }

		[CalledBy(Type = typeof(Base10BigInteger), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Base10BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
		[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
		[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
		[CallerCount(Count = 13)]
		[CallsUnknownMethods(Count = 3)]
		public void set_Item(int index, long value) { }

	}

	private const long NumberBase = 10; //Field offset: 0x0
	private const int MaxSize = 6400; //Field offset: 0x0
	private static readonly Base10BigInteger Zero; //Field offset: 0x0
	private static readonly Base10BigInteger One; //Field offset: 0x8
	private DigitContainer digits; //Field offset: 0x10
	private int size; //Field offset: 0x18
	private Sign sign; //Field offset: 0x1C

	internal Sign NumberSign
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Base10BigInteger() { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Opposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DigitContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Base10BigInteger(Base10BigInteger n) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DigitContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Base10BigInteger() { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DigitContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public Base10BigInteger(long n) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiplication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static Base10BigInteger Abs(Base10BigInteger n) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DigitContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Base10BigInteger Add(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Base10BigInteger), Member = "GreaterOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Base10BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[Calls(Type = typeof(Base10BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Base10BigInteger), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[Calls(Type = typeof(Base10BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallsUnknownMethods(Count = 1)]
	public static Base10BigInteger Addition(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool Equals(Base10BigInteger other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "GreaterOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "SmallerOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DigitContainer), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	public static bool Greater(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Smaller", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Greater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GreaterOrEqual(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[Calls(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Base10BigInteger Multiplication(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Multiplication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DigitContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DigitContainer), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static Base10BigInteger Multiply(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	public static Base10BigInteger op_Addition(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	public static Base10BigInteger op_Decrement(Base10BigInteger n) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Greater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	public static bool op_GreaterThan(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "GreaterOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	public static bool op_GreaterThanOrEqual(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	public static Base10BigInteger op_Implicit(long n) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	public static Base10BigInteger op_Increment(Base10BigInteger n) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "GreaterOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	public static bool op_LessThan(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Greater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	public static bool op_LessThanOrEqual(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(BigInteger), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[Calls(Type = typeof(Base10BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Base10BigInteger op_Multiply(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	public static Base10BigInteger op_Subtraction(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Base10BigInteger op_UnaryNegation(Base10BigInteger n) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Base10BigInteger Opposite(Base10BigInteger n) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_NumberSign(Sign value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "GreaterOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	public static bool Smaller(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Base10BigInteger), Member = "Greater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	public static bool SmallerOrEqual(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Base10BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DigitContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Base10BigInteger Subtract(Base10BigInteger a, Base10BigInteger b) { }

	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CalledBy(Type = typeof(Base10BigInteger), Member = "op_Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Base10BigInteger), Member = "GreaterOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Base10BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[Calls(Type = typeof(Base10BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Base10BigInteger), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[Calls(Type = typeof(Base10BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Base10BigInteger), typeof(Base10BigInteger)}, ReturnType = typeof(Base10BigInteger))]
	[CallsUnknownMethods(Count = 1)]
	public static Base10BigInteger Subtraction(Base10BigInteger a, Base10BigInteger b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

