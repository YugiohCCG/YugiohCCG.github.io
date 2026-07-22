namespace ZXing.PDF417.Internal.EC;

public sealed class ErrorCorrection
{
	private readonly ModulusGF field; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ErrorCorrection() { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "decodeCodewords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[])}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "correctErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ModulusPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[Calls(Type = typeof(ModulusGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ErrorCorrection), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public bool decode(Int32[] received, int numECCodewords, Int32[] erasures, out int errorLocationsCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModulusPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ModulusGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] findErrorLocations(ModulusPoly errorLocator) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private Int32[] findErrorMagnitudes(ModulusPoly errorEvaluator, ModulusPoly errorLocator, Int32[] errorLocations) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModulusGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ModulusGF), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ModulusGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "getNegative", ReturnType = typeof(ModulusPoly))]
	[Calls(Type = typeof(ModulusPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ModulusPoly))]
	[CallsUnknownMethods(Count = 4)]
	private ModulusPoly[] runEuclideanAlgorithm(ModulusPoly a, ModulusPoly b, int R) { }

}

