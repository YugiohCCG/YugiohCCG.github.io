namespace ZXing.Common.ReedSolomon;

internal sealed class GenericGFPoly
{
	private readonly GenericGF field; //Field offset: 0x10
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

	[CalledBy(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "addOrSubtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "buildGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal GenericGFPoly(GenericGF field, Int32[] coefficients) { }

	[CalledBy(Type = typeof(GenericGFPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal GenericGFPoly addOrSubtract(GenericGFPoly other) { }

	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGFPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGFPoly), Member = "addOrSubtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	internal GenericGFPoly[] divide(GenericGFPoly other) { }

	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "findErrorLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
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

	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "buildGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GenericGF), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal GenericGFPoly multiply(GenericGFPoly other) { }

	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal GenericGFPoly multiply(int scalar) { }

	[CalledBy(Type = typeof(GenericGFPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal GenericGFPoly multiplyByMonomial(int degree, int coefficient) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(GenericGF), Member = "log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

