namespace ZXing.OneD;

public sealed class EAN8Reader : UPCEANReader
{
	private readonly Int32[] decodeMiddleCounters; //Field offset: 0x28

	internal virtual BarcodeFormat BarcodeFormat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CalledBy(Type = typeof(MultiFormatUPCEANReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UPCEANReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public EAN8Reader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCEANReader), Member = "decodeDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(int), typeof(Int32[][]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	protected private virtual int decodeMiddle(BitArray row, Int32[] startRange, StringBuilder result) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual BarcodeFormat get_BarcodeFormat() { }

}

