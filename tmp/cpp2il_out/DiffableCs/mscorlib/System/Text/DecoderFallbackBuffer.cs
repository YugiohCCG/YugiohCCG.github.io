namespace System.Text;

public abstract class DecoderFallbackBuffer
{
	internal Byte* byteStart; //Field offset: 0x10
	internal Char* charEnd; //Field offset: 0x18

	public abstract int Remaining
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DecoderFallbackBuffer() { }

	public abstract bool Fallback(Byte[] bytesUnknown, int index) { }

	public abstract int get_Remaining() { }

	public abstract char GetNextChar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	internal override bool InternalFallback(Byte[] bytes, Byte* pBytes, ref Char* chars) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	internal override int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(DecoderNLS), typeof(Char*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	internal void InternalInitialize(Byte* byteStart, Char* charEnd) { }

	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InternalReset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Reset() { }

	[CalledBy(Type = typeof(DecoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	internal void ThrowLastBytesRecursive(Byte[] bytesUnknown) { }

}

