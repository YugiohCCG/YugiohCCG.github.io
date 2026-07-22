namespace System.Text;

public abstract class Encoder
{
	internal EncoderFallback _fallback; //Field offset: 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	public EncoderFallback Fallback
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public EncoderFallbackBuffer FallbackBuffer
	{
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 113
	}

	internal bool InternalHasFallbackBuffer
	{
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Encoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	public override void Convert(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public override void Convert(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public EncoderFallback get_Fallback() { }

	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[CLSCompliant(False)]
	public override int GetByteCount(Char* chars, int count, bool flush) { }

	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[CLSCompliant(False)]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Reset() { }

}

