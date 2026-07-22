namespace System.Text;

public abstract class EncoderFallbackBuffer
{
	internal Char* charStart; //Field offset: 0x10
	internal Char* charEnd; //Field offset: 0x18
	internal EncoderNLS encoder; //Field offset: 0x20
	internal bool setEncoder; //Field offset: 0x28
	internal bool bUsedEncoder; //Field offset: 0x29
	internal bool bFallingBack; //Field offset: 0x2A
	internal int iRecursionCount; //Field offset: 0x2C

	public abstract int Remaining
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EncoderFallbackBuffer() { }

	public abstract bool Fallback(char charUnknown, int index) { }

	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public abstract int get_Remaining() { }

	public abstract char GetNextChar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal override bool InternalFallback(char ch, ref Char* chars) { }

	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "GetNextChar", ReturnType = typeof(char))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal char InternalGetNextChar() { }

	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 1)]
	internal void InternalInitialize(Char* charStart, Char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InternalReset() { }

	public abstract bool MovePrevious() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Reset() { }

	[CalledBy(Type = typeof(EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Char*&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void ThrowLastCharRecursive(int charRecursive) { }

}

