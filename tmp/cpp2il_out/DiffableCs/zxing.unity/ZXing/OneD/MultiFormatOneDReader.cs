namespace ZXing.OneD;

public sealed class MultiFormatOneDReader : OneDReader
{
	private readonly IList<OneDReader> readers; //Field offset: 0x10

	[CalledBy(Type = typeof(MultiFormatReader), Member = "set_Hints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MultiFormatUPCEANReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSIReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Code39Reader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Code93Reader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CodaBarReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSS14Reader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSSExpandedReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 59)]
	[ContainsUnimplementedInstructions]
	public MultiFormatOneDReader(IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public virtual Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public virtual void reset() { }

}

