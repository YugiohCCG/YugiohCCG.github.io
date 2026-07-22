namespace ZXing.Common.ReedSolomon;

public sealed class GenericGF
{
	public static GenericGF AZTEC_DATA_12; //Field offset: 0x0
	private const int INITIALIZATION_THRESHOLD = 0; //Field offset: 0x0
	public static GenericGF AZTEC_DATA_10; //Field offset: 0x8
	public static GenericGF AZTEC_DATA_6; //Field offset: 0x10
	public static GenericGF AZTEC_PARAM; //Field offset: 0x18
	public static GenericGF QR_CODE_FIELD_256; //Field offset: 0x20
	public static GenericGF DATA_MATRIX_FIELD_256; //Field offset: 0x28
	public static GenericGF AZTEC_DATA_8; //Field offset: 0x30
	public static GenericGF MAXICODE_FIELD_64; //Field offset: 0x38
	private Int32[] expTable; //Field offset: 0x10
	private Int32[] logTable; //Field offset: 0x18
	private GenericGFPoly zero; //Field offset: 0x20
	private GenericGFPoly one; //Field offset: 0x28
	private readonly int size; //Field offset: 0x30
	private readonly int primitive; //Field offset: 0x34
	private readonly int generatorBase; //Field offset: 0x38
	private bool initialized; //Field offset: 0x3C

	public int GeneratorBase
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal GenericGFPoly One
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
		internal get { } //Length: 42
	}

	public int Size
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal GenericGFPoly Zero
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
		internal get { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private static GenericGF() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public GenericGF(int primitive, int size, int genBase) { }

	[CallerCount(Count = 0)]
	internal static int addOrSubtract(int a, int b) { }

	[CalledBy(Type = typeof(GenericGFPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal GenericGFPoly buildMonomial(int degree, int coefficient) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	private void checkInit() { }

	[CalledBy(Type = typeof(ReedSolomonEncoder), Member = "buildGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal int exp(int a) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_GeneratorBase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	internal GenericGFPoly get_One() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_Size() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	internal GenericGFPoly get_Zero() { }

	[CalledBy(Type = typeof(GenericGF), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericGF), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGF), Member = "log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GenericGF), Member = "exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GenericGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGF), Member = "get_One", ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGF), Member = "get_Zero", ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(GenericGF), Member = "checkInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void initialize() { }

	[CalledBy(Type = typeof(GenericGFPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "findErrorLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal int inverse(int a) { }

	[CalledBy(Type = typeof(GenericGFPoly), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal int log(int a) { }

	[CalledBy(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal int multiply(int a, int b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 22)]
	public virtual string ToString() { }

}

