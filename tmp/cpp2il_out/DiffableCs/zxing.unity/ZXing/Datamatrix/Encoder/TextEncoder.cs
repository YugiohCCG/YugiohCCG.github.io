namespace ZXing.Datamatrix.Encoder;

internal sealed class TextEncoder : C40Encoder
{

	public virtual int EncodingMode
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TextEncoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "illegalCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual int encodeChar(char c, StringBuilder sb) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual int get_EncodingMode() { }

}

