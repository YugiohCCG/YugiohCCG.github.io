namespace System.Text;

public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	private string _strDefault; //Field offset: 0x20
	private int _fallbackCount; //Field offset: 0x28
	private int _fallbackIndex; //Field offset: 0x2C

	public virtual int Remaining
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "ThrowLastBytesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[CallerCount(Count = 0)]
	public virtual int get_Remaining() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public virtual char GetNextChar() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[CallerCount(Count = 0)]
	public virtual void Reset() { }

}

