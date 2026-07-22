namespace ZXing.PDF417.Internal;

internal sealed class PDF417
{
	private const int START_PATTERN = 130728; //Field offset: 0x0
	private const int STOP_PATTERN = 260649; //Field offset: 0x0
	private static readonly Int32[][] CODEWORD_TABLE; //Field offset: 0x0
	private const float PREFERRED_RATIO = 3; //Field offset: 0x0
	private const float DEFAULT_MODULE_WIDTH = 0.357; //Field offset: 0x0
	private const float HEIGHT = 2; //Field offset: 0x0
	private BarcodeMatrix barcodeMatrix; //Field offset: 0x10
	private bool compact; //Field offset: 0x18
	private Compaction compaction; //Field offset: 0x1C
	private Encoding encoding; //Field offset: 0x20
	private bool disableEci; //Field offset: 0x28
	private int minCols; //Field offset: 0x2C
	private int maxCols; //Field offset: 0x30
	private int maxRows; //Field offset: 0x34
	private int minRows; //Field offset: 0x38

	internal BarcodeMatrix BarcodeMatrix
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static PDF417() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal PDF417() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal PDF417(bool compact) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int calculateNumberOfRows(int m, int k, int c) { }

	[CalledBy(Type = typeof(PDF417), Member = "generateBarcodeLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private Int32[] determineDimensions(int sourceCodeWords, int errorCorrectionCodeWords) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeRow), Member = "addBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void encodeChar(int pattern, int len, BarcodeRow logic) { }

	[CalledBy(Type = typeof(PDF417), Member = "generateBarcodeLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BarcodeRow), Member = "addBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void encodeLowLevel(string fullCodewords, int c, int r, int errorCorrectionLevel, BarcodeMatrix logic) { }

	[CalledBy(Type = typeof(PDF417Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PDF417Writer), Member = "bitMatrixFromEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PDF417), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PDF417HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Compaction), typeof(Encoding), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PDF417), Member = "determineDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PDF417ErrorCorrection), Member = "generateErrorCorrection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PDF417), Member = "encodeLowLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(BarcodeMatrix)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	internal void generateBarcodeLogic(string msg, int errorCorrectionLevel) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal BarcodeMatrix get_BarcodeMatrix() { }

	[CallerCount(Count = 0)]
	private static int getNumberOfPadCodewords(int m, int k, int c, int r) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void setCompact(bool compact) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void setCompaction(Compaction compaction) { }

	[CallerCount(Count = 0)]
	internal void setDimensions(int maxCols, int minCols, int maxRows, int minRows) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void setDisableEci(bool disabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallsUnknownMethods(Count = 1)]
	internal void setEncoding(string encodingname) { }

}

