namespace ZXing.Common;

public sealed class DecoderResult
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Byte[] <RawBytes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Text>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IList<Byte[]> <ByteSegments>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <ECLevel>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ErrorsCorrected>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <StructuredAppendSequenceNumber>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Erasures>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <StructuredAppendParity>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <Other>k__BackingField; //Field offset: 0x40

	public private IList<Byte[]> ByteSegments
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string ECLevel
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public int Erasures
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int ErrorsCorrected
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public object Other
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public private Byte[] RawBytes
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public bool StructuredAppend
	{
		[CalledBy(Type = typeof(QRCodeMultiReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
		[CalledBy(Type = typeof(QRCodeReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
		[CallerCount(Count = 2)]
		 get { } //Length: 18
	}

	public private int StructuredAppendParity
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int StructuredAppendSequenceNumber
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private string Text
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CalledBy(Type = typeof(Decoder), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AztecDetectorResult)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(DecoderResult))]
	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DecoderResult(Byte[] rawBytes, string text, IList<Byte[]> byteSegments, string ecLevel) { }

	[CalledBy(Type = typeof(DecodedBitStreamParser), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(DecoderResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DecoderResult(Byte[] rawBytes, string text, IList<Byte[]> byteSegments, string ecLevel, int saSequence, int saParity) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IList<Byte[]> get_ByteSegments() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_ECLevel() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Erasures() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ErrorsCorrected() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_Other() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Byte[] get_RawBytes() { }

	[CalledBy(Type = typeof(QRCodeMultiReader), Member = "decodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result[]))]
	[CalledBy(Type = typeof(QRCodeReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	public bool get_StructuredAppend() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_StructuredAppendParity() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_StructuredAppendSequenceNumber() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Text() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ByteSegments(IList<Byte[]> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ECLevel(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Erasures(int value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ErrorsCorrected(int value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Other(object value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_RawBytes(Byte[] value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StructuredAppendParity(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StructuredAppendSequenceNumber(int value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Text(string value) { }

}

