namespace ZXing.Datamatrix.Encoder;

internal sealed class X12Encoder : C40Encoder
{

	public virtual int EncodingMode
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public X12Encoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(C40Encoder), Member = "writeNextTriplet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderContext), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "lookAheadTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void encode(EncoderContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "illegalCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual int encodeChar(char c, StringBuilder sb) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual int get_EncodingMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncoderContext), Member = "updateSymbolInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void handleEOD(EncoderContext context, StringBuilder buffer) { }

}

