namespace ZXing.Common;

public sealed class BitSource
{
	private readonly Byte[] bytes; //Field offset: 0x10
	private int byteOffset; //Field offset: 0x18
	private int bitOffset; //Field offset: 0x1C

	public int BitOffset
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int ByteOffset
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BitSource(Byte[] bytes) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAsciiSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(StringBuilder), typeof(Mode&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeC40Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeTextSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAnsiX12Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeEdifactSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeBase256Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(System.Collections.Generic.IList`1<Byte[]>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeHanziSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeKanjiSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeByteSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(CharacterSetECI), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAlphanumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeNumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 31)]
	[CallsUnknownMethods(Count = 1)]
	public int available() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_BitOffset() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_ByteOffset() { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "parseECIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeNumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAlphanumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeByteSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int), typeof(CharacterSetECI), typeof(System.Collections.Generic.IList`1<Byte[]>), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeKanjiSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeHanziSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeEdifactSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAnsiX12Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeTextSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeC40Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeAsciiSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(StringBuilder), typeof(Mode&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decodeBase256Segment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSource), typeof(StringBuilder), typeof(System.Collections.Generic.IList`1<Byte[]>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	public int readBits(int numBits) { }

}

