namespace ZXing.OneD;

public sealed class EAN13Reader : UPCEANReader
{
	internal static Int32[] FIRST_DIGIT_ENCODINGS; //Field offset: 0x0
	private readonly Int32[] decodeMiddleCounters; //Field offset: 0x28

	internal virtual BarcodeFormat BarcodeFormat
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static EAN13Reader() { }

	[CalledBy(Type = typeof(MultiFormatUPCEANReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UPCAReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UPCEANReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public EAN13Reader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCEANReader), Member = "decodeDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(int), typeof(Int32[][]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected private virtual int decodeMiddle(BitArray row, Int32[] startRange, StringBuilder resultString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	private static bool determineFirstDigit(StringBuilder resultString, int lgPatternFound) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal virtual BarcodeFormat get_BarcodeFormat() { }

}

