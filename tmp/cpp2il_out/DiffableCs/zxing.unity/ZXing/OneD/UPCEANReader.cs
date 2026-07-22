namespace ZXing.OneD;

public abstract class UPCEANReader : OneDReader
{
	private static readonly int MAX_AVG_VARIANCE; //Field offset: 0x0
	private static readonly int MAX_INDIVIDUAL_VARIANCE; //Field offset: 0x4
	internal static Int32[] START_END_PATTERN; //Field offset: 0x8
	internal static Int32[] MIDDLE_PATTERN; //Field offset: 0x10
	internal static Int32[][] L_PATTERNS; //Field offset: 0x18
	internal static Int32[][] L_AND_G_PATTERNS; //Field offset: 0x20
	private readonly StringBuilder decodeRowStringBuffer; //Field offset: 0x10
	private readonly UPCEANExtensionSupport extensionReader; //Field offset: 0x18
	private readonly EANManufacturerOrgSupport eanManSupport; //Field offset: 0x20

	internal abstract BarcodeFormat BarcodeFormat
	{
		internal get { } //Length: 0
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	private static UPCEANReader() { }

	[CalledBy(Type = typeof(EAN13Reader), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EAN8Reader), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiFormatUPCEANReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UPCAReader), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UPCEReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EANManufacturerOrgSupport), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	protected UPCEANReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override bool checkChecksum(string s) { }

	[CalledBy(Type = typeof(EAN13Writer), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Boolean[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool checkStandardUPCEANChecksum(string s) { }

	[CalledBy(Type = typeof(EAN13Reader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EAN8Reader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UPCEANExtension2Support), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UPCEANExtension5Support), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UPCEReader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(OneDReader), Member = "recordPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool decodeDigit(BitArray row, Int32[] counters, int rowOffset, Int32[][] patterns, out int digit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 1)]
	protected override Int32[] decodeEnd(BitArray row, int endStart) { }

	protected private abstract int decodeMiddle(BitArray row, Int32[] startRange, StringBuilder resultString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCEANReader), Member = "findStartGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "isRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(UPCEANExtension5Support), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(UPCEANExtension2Support), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putAllMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.ResultMetadataType, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "addResultPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EANManufacturerOrgSupport), Member = "lookupCountryIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	public override Result decodeRow(int rowNumber, BitArray row, Int32[] startGuardRange, IDictionary<DecodeHintType, Object> hints) { }

	[CalledBy(Type = typeof(EAN13Reader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EAN8Reader), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 1)]
	internal static Int32[] findGuardPattern(BitArray row, int rowOffset, bool whiteFirst, Int32[] pattern) { }

	[CalledBy(Type = typeof(UPCEANExtensionSupport), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(int)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[]), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "decodeEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static Int32[] findGuardPattern(BitArray row, int rowOffset, bool whiteFirst, Int32[] pattern, Int32[] counters) { }

	[CalledBy(Type = typeof(MultiFormatUPCEANReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDReader), Member = "patternMatchVariance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "isRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static Int32[] findStartGuardPattern(BitArray row) { }

	internal abstract BarcodeFormat get_BarcodeFormat() { }

}

