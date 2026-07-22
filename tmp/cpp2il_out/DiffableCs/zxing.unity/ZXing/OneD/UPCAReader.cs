namespace ZXing.OneD;

public sealed class UPCAReader : UPCEANReader
{
	private readonly UPCEANReader ean13Reader; //Field offset: 0x28

	internal virtual BarcodeFormat BarcodeFormat
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EAN13Reader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UPCEANReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public UPCAReader() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual int decodeMiddle(BitArray row, Int32[] startRange, StringBuilder resultString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCAReader), Member = "maybeReturnResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(Result))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Result decodeRow(int rowNumber, BitArray row, Int32[] startGuardRange, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCAReader), Member = "maybeReturnResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(Result))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	internal virtual BarcodeFormat get_BarcodeFormat() { }

	[CalledBy(Type = typeof(UPCAReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[]), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(UPCAReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Result), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(ResultPoint[]), typeof(BarcodeFormat)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Result maybeReturnResult(Result result) { }

}

