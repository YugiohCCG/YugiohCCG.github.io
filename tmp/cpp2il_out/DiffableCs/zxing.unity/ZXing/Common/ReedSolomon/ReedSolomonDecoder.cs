namespace ZXing.Common.ReedSolomon;

public sealed class ReedSolomonDecoder
{
	private readonly GenericGF field; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReedSolomonDecoder(GenericGF field) { }

	[CalledBy(Type = typeof(Decoder), Member = "correctBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(Boolean[]))]
	[CalledBy(Type = typeof(Detector), Member = "extractParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Detector), Member = "getCorrectedParameterData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Decoder), Member = "correctErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Decoder), Member = "correctErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrixParser), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(Decoder), Member = "correctErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(GenericGFPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGFPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(GenericGFPoly), typeof(int)}, ReturnType = typeof(GenericGFPoly[]))]
	[Calls(Type = typeof(GenericGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReedSolomonDecoder), Member = "findErrorMagnitudes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public bool decode(Int32[] received, int twoS) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericGFPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] findErrorLocations(GenericGFPoly errorLocator) { }

	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGF), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGFPoly), Member = "evaluateAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] findErrorMagnitudes(GenericGFPoly errorEvaluator, Int32[] errorLocations) { }

	[CalledBy(Type = typeof(ReedSolomonDecoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericGF), Member = "initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericGF), Member = "inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGF), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GenericGF), Member = "buildMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGFPoly), Member = "addOrSubtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGFPoly), Member = "multiplyByMonomial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericGFPoly)}, ReturnType = typeof(GenericGFPoly))]
	[Calls(Type = typeof(GenericGFPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GenericGFPoly))]
	[CallsUnknownMethods(Count = 4)]
	internal GenericGFPoly[] runEuclideanAlgorithm(GenericGFPoly a, GenericGFPoly b, int R) { }

}

