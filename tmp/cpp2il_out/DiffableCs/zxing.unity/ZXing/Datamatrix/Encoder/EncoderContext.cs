namespace ZXing.Datamatrix.Encoder;

internal sealed class EncoderContext
{
	private static readonly Encoding encoding; //Field offset: 0x0
	private readonly string msg; //Field offset: 0x10
	private SymbolShapeHint shape; //Field offset: 0x18
	private Dimension minSize; //Field offset: 0x20
	private Dimension maxSize; //Field offset: 0x28
	private readonly StringBuilder codewords; //Field offset: 0x30
	private int pos; //Field offset: 0x38
	private int newEncoding; //Field offset: 0x3C
	private SymbolInfo symbolInfo; //Field offset: 0x40
	private int skipAtEnd; //Field offset: 0x48

	public int CodewordCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public StringBuilder Codewords
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public char Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 36
	}

	public char CurrentChar
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 36
	}

	public bool HasMoreCharacters
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 35
	}

	public string Message
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int NewEncoding
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Pos
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int RemainingCharacters
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	public SymbolInfo SymbolInfo
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private int TotalMessageCharCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 29
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallsUnknownMethods(Count = 1)]
	private static EncoderContext() { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public EncoderContext(string msg) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_CodewordCount() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public StringBuilder get_Codewords() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public char get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public char get_CurrentChar() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_HasMoreCharacters() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Message() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_NewEncoding() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Pos() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_RemainingCharacters() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SymbolInfo get_SymbolInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int get_TotalMessageCharCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void resetEncoderSignal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void resetSymbolInfo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Pos(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void setSizeConstraints(Dimension minSize, Dimension maxSize) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void setSkipAtEnd(int count) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void setSymbolShape(SymbolShapeHint shape) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void signalEncoderChange(int encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncoderContext), Member = "updateSymbolInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void updateSymbolInfo() { }

	[CalledBy(Type = typeof(Base256Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(C40Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(C40Encoder), Member = "handleEOD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdifactEncoder), Member = "handleEOD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncoderContext), Member = "updateSymbolInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "encodeHighLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X12Encoder), Member = "handleEOD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SymbolInfo), Member = "lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SymbolShapeHint), typeof(Dimension), typeof(Dimension), typeof(bool)}, ReturnType = typeof(SymbolInfo))]
	[CallsUnknownMethods(Count = 1)]
	public void updateSymbolInfo(int len) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	public void writeCodeword(char codeword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	public void writeCodewords(string codewords) { }

}

