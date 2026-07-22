namespace System.Text;

public class UTF7Encoding : Encoding
{
	private sealed class Decoder : DecoderNLS
	{
		internal int bits; //Field offset: 0x30
		internal int bitCount; //Field offset: 0x34
		internal bool firstByte; //Field offset: 0x38

		internal virtual bool HasState
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public Decoder(UTF7Encoding encoding) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool get_HasState() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual void Reset() { }

	}

	private sealed class DecoderUTF7Fallback : DecoderFallback
	{

		public virtual int MaxCharCount
		{
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DecoderUTF7Fallback() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object value) { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		public virtual int get_MaxCharCount() { }

		[CallerCount(Count = 0)]
		public virtual int GetHashCode() { }

	}

	private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		private char cFallback; //Field offset: 0x20
		private int iCount; //Field offset: 0x24
		private int iSize; //Field offset: 0x28

		public virtual int Remaining
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 13
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual int get_Remaining() { }

		[CallerCount(Count = 0)]
		public virtual char GetNextChar() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual void Reset() { }

	}

	private sealed class Encoder : EncoderNLS
	{
		internal int bits; //Field offset: 0x38
		internal int bitCount; //Field offset: 0x3C

		internal virtual bool HasState
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 17
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public Encoder(UTF7Encoding encoding) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool get_HasState() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public virtual void Reset() { }

	}

	internal static readonly UTF7Encoding s_default; //Field offset: 0x0
	private Byte[] _base64Bytes; //Field offset: 0x38
	private SByte[] _base64Values; //Field offset: 0x40
	private Boolean[] _directEncode; //Field offset: 0x48
	private bool _allowOptionals; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static UTF7Encoding() { }

	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "get_UTF7", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
	public UTF7Encoding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
	public UTF7Encoding(bool allowOptionals) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual int GetByteCount(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[CLSCompliant(False)]
	public virtual int GetByteCount(Char* chars, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "get_MoreData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "GetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "get_CharsUsed", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[CLSCompliant(False)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[CLSCompliant(False)]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[CLSCompliant(False)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncodingCharBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(DecoderNLS), typeof(Char*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "get_MoreData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "GetNextByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "AdjustBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "get_BytesUsed", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	public virtual Decoder GetDecoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	public virtual Encoder GetEncoder() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public virtual int GetMaxByteCount(int charCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual int GetMaxCharCount(int byteCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 5)]
	private void MakeTables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void SetDefaultFallbacks() { }

}

