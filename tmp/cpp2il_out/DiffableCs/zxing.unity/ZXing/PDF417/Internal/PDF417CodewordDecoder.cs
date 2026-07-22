namespace ZXing.PDF417.Internal;

public static class PDF417CodewordDecoder
{
	private static readonly Single[][] RATIOS_TABLE; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static PDF417CodewordDecoder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static int getBitValue(Int32[] moduleBitCount) { }

	[CalledBy(Type = typeof(PDF417CodewordDecoder), Member = "getDecodedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static int getClosestDecodedValue(Int32[] moduleBitCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PDF417Common), Member = "getCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	private static int getDecodedCodewordValue(Int32[] moduleBitCount) { }

	[CalledBy(Type = typeof(PDF417ScanningDecoder), Member = "detectCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Codeword))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PDF417CodewordDecoder), Member = "sampleBitCounts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(PDF417Common), Member = "getCodeword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PDF417CodewordDecoder), Member = "getClosestDecodedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	public static int getDecodedValue(Int32[] moduleBitCount) { }

	[CalledBy(Type = typeof(PDF417CodewordDecoder), Member = "getDecodedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Int32[] sampleBitCounts(Int32[] moduleBitCount) { }

}

