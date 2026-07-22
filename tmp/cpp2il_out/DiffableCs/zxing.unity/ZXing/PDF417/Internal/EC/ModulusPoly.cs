namespace ZXing.PDF417.Internal.EC;

internal sealed class ModulusPoly
{
	private readonly ModulusGF field; //Field offset: 0x10
	private readonly Int32[] coefficients; //Field offset: 0x18

	internal Int32[] Coefficients
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int Degree
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 28
	}

	internal bool isZero
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 42
	}

	[CalledBy(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ErrorCorrection), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ModulusGF), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ModulusGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "getNegative", ReturnType = typeof(ModulusPoly))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public ModulusPoly(ModulusGF field, Int32[] coefficients) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal ModulusPoly add(ModulusPoly other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModulusPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	internal ModulusPoly[] divide(ModulusPoly other) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ErrorCorrection), Member = "findErrorLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ErrorCorrection), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal int evaluateAt(int a) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal Int32[] get_Coefficients() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Degree() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_isZero() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal int getCoefficient(int degree) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal ModulusPoly getNegative() { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ModulusGF), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal ModulusPoly multiply(ModulusPoly other) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal ModulusPoly multiply(int scalar) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal ModulusPoly multiplyByMonomial(int degree, int coefficient) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ModulusPoly), Member = "getNegative", ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal ModulusPoly subtract(ModulusPoly other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

