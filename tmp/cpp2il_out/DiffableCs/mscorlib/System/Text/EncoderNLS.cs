namespace System.Text;

internal class EncoderNLS : Encoder
{
	internal char _charLeftOver; //Field offset: 0x20
	private Encoding _encoding; //Field offset: 0x28
	private bool _mustFlush; //Field offset: 0x30
	internal bool _throwOnOverflow; //Field offset: 0x31
	internal int _charsUsed; //Field offset: 0x34

	public Encoding Encoding
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal override bool HasState
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 9
	}

	public bool MustFlush
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(EncodingNLS), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = "System.Text.UTF7Encoding+Encoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF7Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = "System.Text.UTF8Encoding+UTF8Encoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF8Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal EncoderNLS(Encoding encoding) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	internal void ClearMustFlush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	public virtual void Convert(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public virtual void Convert(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Encoding get_Encoding() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal override bool get_HasState() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_MustFlush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public virtual int GetByteCount(Char* chars, int count, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Reset() { }

}

