namespace ZXing.Common;

[DefaultMember("Item")]
public sealed class BitArray
{
	private static readonly Int32[] _lookup; //Field offset: 0x0
	private Int32[] bits; //Field offset: 0x10
	private int size; //Field offset: 0x18

	public Int32[] Array
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Item
	{
		[CallerCount(Count = 104)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 54
		[CalledBy(Type = typeof(BitArrayBuilder), Member = "buildBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(BitArray))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 64
	}

	public int Size
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int SizeInBytes
	{
		[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
		[CalledBy(Type = typeof(Encoder), Member = "terminateBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
		[CallerCount(Count = 5)]
		 get { } //Length: 10
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BitArray() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private BitArray(Int32[] bits, int size) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(AztecCode))]
	[CalledBy(Type = typeof(Encoder), Member = "generateModeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "generateCheckWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "stuffBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(State), Member = "toBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "buildMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(ErrorCorrectionLevel), typeof(Version), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "maybeEmbedVersionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "makeTypeInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BitArray() { }

	[CalledBy(Type = typeof(BitMatrix), Member = "getRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(BitMatrix), Member = "rotate180", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GlobalHistogramBinarizer), Member = "getBlackRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(OneDReader), Member = "doDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(BitArrayBuilder), Member = "buildBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(BitArray))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BitArray(int size) { }

	[CalledBy(Type = typeof(Encoder), Member = "terminateBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "ensureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void appendBit(bool bit) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = "ensureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void appendBitArray(BitArray other) { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(BitArray), Member = "ensureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public void appendBits(int value, int numBits) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public object Clone() { }

	[CalledBy(Type = typeof(BitArray), Member = "appendBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BitArray), Member = "appendBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ensureCapacity(int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void flip(int i) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Int32[] get_Array() { }

	[CallerCount(Count = 104)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_Item(int i) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Size() { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "terminateBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CallerCount(Count = 5)]
	public int get_SizeInBytes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(Code128Reader), Member = "findStartPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findStartGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANExtension5Support), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UPCEANExtension2Support), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "retrieveNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(ExpandedPair))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "getNextSecondBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MSIReader), Member = "findStartPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(MSIReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ITFReader), Member = "skipWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Code93Reader), Member = "findAsteriskPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Code93Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Code39Reader), Member = "findAsteriskPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Code39Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(BitArray), Member = "numberOfTrailingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public int getNextSet(int from) { }

	[CalledBy(Type = typeof(CodaBarReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(CodaBarReader), Member = "setCounters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Code128Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "getNextSecondBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "retrieveNextPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>), typeof(int)}, ReturnType = typeof(ExpandedPair))]
	[CalledBy(Type = typeof(RSSExpandedReader), Member = "parseFoundFinderPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool)}, ReturnType = typeof(FinderPattern))]
	[CalledBy(Type = typeof(UPCEANExtension2Support), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UPCEANExtension5Support), Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[]), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(bool), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEReader), Member = "decodeEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(BitArray), Member = "numberOfTrailingZeros", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public int getNextUnset(int from) { }

	[CalledBy(Type = typeof(Code128Reader), Member = "findStartPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Code128Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(Code39Reader), Member = "findAsteriskPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(MSIReader), Member = "findStartPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(MSIReader), Member = "findEndPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(Int32[])}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "findStartGuardPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(UPCEANReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[]), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool isRange(int start, int end, bool value) { }

	[CallerCount(Count = 0)]
	private static Int32[] makeArray(int size) { }

	[CalledBy(Type = typeof(BitArray), Member = "getNextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BitArray), Member = "getNextUnset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int numberOfTrailingZeros(int num) { }

	[CalledBy(Type = typeof(BitMatrix), Member = "rotate180", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(ITFReader), Member = "decodeEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(OneDReader), Member = "doDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	public void reverse() { }

	[CalledBy(Type = typeof(BitArrayBuilder), Member = "buildBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(BitArray))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_Item(int i, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void setBulk(int i, int newBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void setRange(int start, int end) { }

	[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void toBytes(int bitOffset, Byte[] array, int offset, int numBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(MatrixUtil), Member = "makeTypeInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void xor(BitArray other) { }

}

