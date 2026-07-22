namespace ZXing.PDF417;

public sealed class PDF417Writer : Writer
{
	private const int WHITE_SPACE = 30; //Field offset: 0x0

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PDF417Writer() { }

	[CalledBy(Type = typeof(PDF417Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static BitMatrix bitMatrixFrombitArray(SByte[][] input, int margin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417), Member = "generateBarcodeLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BarcodeMatrix), Member = "getScaledMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(SByte[][]))]
	[Calls(Type = typeof(PDF417Writer), Member = "rotateArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte[][])}, ReturnType = typeof(SByte[][]))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private static BitMatrix bitMatrixFromEncoder(PDF417 encoder, string contents, int width, int height, int margin, int errorCorrectionLevel) { }

	[CalledBy(Type = typeof(PDF417Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(PDF417), Member = "generateBarcodeLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BarcodeMatrix), Member = "getScaledMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(SByte[][]))]
	[Calls(Type = typeof(PDF417Writer), Member = "rotateArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte[][])}, ReturnType = typeof(SByte[][]))]
	[Calls(Type = typeof(PDF417Writer), Member = "bitMatrixFrombitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte[][]), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height) { }

	[CalledBy(Type = typeof(PDF417Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PDF417Writer), Member = "bitMatrixFromEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PDF417), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static SByte[][] rotateArray(SByte[][] bitarray) { }

}

