namespace System.Text;

internal class DecoderNLS : Decoder
{
	private Encoding _encoding; //Field offset: 0x20
	private bool _mustFlush; //Field offset: 0x28
	internal bool _throwOnOverflow; //Field offset: 0x29
	internal int _bytesUsed; //Field offset: 0x2C

	internal override bool HasState
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public bool MustFlush
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(EncodingNLS), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UTF32Encoding+UTF32Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF32Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UTF7Encoding+Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF7Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UTF8Encoding+UTF8Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF8Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UnicodeEncoding+Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeEncoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal DecoderNLS(Encoding encoding) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	internal void ClearMustFlush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual void Convert(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_HasState() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_MustFlush() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public virtual int GetCharCount(Byte* bytes, int count, bool flush) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Reset() { }

}

